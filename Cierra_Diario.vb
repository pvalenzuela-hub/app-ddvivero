Imports System.Data
Imports System.Data.SqlClient

Public Class Cierra_Diario
    Private Shared ReadOnly Denominaciones As Integer() = {1000, 2000, 5000, 10000, 20000}

    Private dSaldoAcum As Double = 0
    Private dSaldoFinal As Double = 0

    Private _grpConteo As GroupBox
    Private _grillaConteo As DataGridView
    Private _txtTotalConteo As TextBox
    Private _txtDiferencia As TextBox
    Private _eventoCajaRegistrado As Boolean

    Private Sub Cierra_Diario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not _eventoCajaRegistrado Then
            AddHandler cmb_Cta_Ctble.SelectedValueChanged, AddressOf Cmb_Cta_Ctble_SelectedValueChanged
            _eventoCajaRegistrado = True
        End If

        Carga_CajasDiarias(Me.cmb_Cta_Ctble, gCuentaCaja)
        InicializaConteoCierreUI()
        btn_GrabaCierre.Enabled = False
        AplicarCajaActiva()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If AseguraCajaActivaSeleccionada() Then
            Consulta_Movimientos()
        End If
    End Sub

    Private Sub Consulta_Movimientos()
        Dim i As Integer = 0
        Dim dSaldoInicial As Double = 0
        Dim dIngresos As Double = 0
        Dim dEgresos As Double = 0

        dSaldoAcum = 0
        dSaldoFinal = 0
        GrillaCaja.Rows.Clear()

        open()
        Try
            Using cmd As SqlCommand = connection.CreateCommand()
                cmd.CommandText = "SP_CONSULTA_CONTA_Saldosdiarios"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@NombreCuenta", SqlDbType.VarChar, 100).Value = cmb_Cta_Ctble.Text.Trim()
                cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = dtp_FechaApertura.Value.Date

                Using reader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        txt_Cta_Ctble.Text = reader(0).ToString()
                        dSaldoInicial = Convert.ToDouble(reader(1))
                        btn_GrabaCierre.Enabled = True
                    Else
                        MsgBox("Esta Cuenta no tiene Apertura para la Fecha Seleccionada.", MsgBoxStyle.Exclamation, "Cierre Diario")
                        txt_Cta_Ctble.Clear()
                        btn_GrabaCierre.Enabled = False
                        MostrarConteoCierre(False)
                        Exit Sub
                    End If
                End Using
            End Using
        Finally
            close_conexion()
        End Try

        dSaldoAcum = dSaldoInicial

        open()
        Try
            Using cmd As SqlCommand = connection.CreateCommand()
                cmd.CommandText = "SP_CONSULTA_CONTA_Movto_Diario"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Cta_Ctble", SqlDbType.VarChar, 7).Value = txt_Cta_Ctble.Text.Trim()
                cmd.Parameters.Add("@FechaCierre", SqlDbType.Date).Value = dtp_FechaApertura.Value.Date

                Using reader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Dim debe = Convert.ToDouble(reader(1))
                            Dim haber = Convert.ToDouble(reader(2))

                            dSaldoAcum += debe - haber
                            dIngresos += debe
                            dEgresos += haber

                            GrillaCaja.Rows.Add()
                            GrillaCaja.Rows(i).Cells(0).Value = reader(0).ToString()
                            GrillaCaja.Rows(i).Cells(1).Value = Format(debe, "###,###,###")
                            GrillaCaja.Rows(i).Cells(2).Value = Format(haber, "###,###,###")
                            GrillaCaja.Rows(i).Cells(3).Value = Format(dSaldoAcum, "###,###,###")
                            i += 1
                        End While
                    End If
                End Using
            End Using
        Finally
            close_conexion()
        End Try

        dSaldoFinal = dSaldoAcum

        txt_Total_Ingresos.Text = Format(dIngresos, "###,###,###")
        txt_Total_Egresos.Text = Format(dEgresos, "###,###,###")
        txt_Saldo_Diario.Text = Format(dIngresos - dEgresos, "###,###,###")
        txt_Saldo_Inicial.Text = Format(dSaldoInicial, "###,###,###")
        txt_SaldoFinalDiario.Text = Format(dSaldoFinal, "###,###,###")

        MostrarConteoCierre(CuentaRequiereConteo())
        If CuentaRequiereConteo() Then
            CargarConteoCierreActual()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btn_GrabaCierre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GrabaCierre.Click
        Graba_Cierre_Diario()
    End Sub

    Private Sub Graba_Cierre_Diario()
        Dim cantidades(Denominaciones.Length - 1) As Integer

        If CuentaRequiereConteo() Then
            cantidades = ObtenerCantidadesConteo(requerirIngreso:=True)
            If cantidades Is Nothing Then
                Exit Sub
            End If

            Dim totalConteo = CalcularTotalConteo(cantidades)
            Dim diferencia = totalConteo - CDec(dSaldoFinal)

            If diferencia <> 0D Then
                Dim mensaje = "El conteo final no coincide con el saldo final contable." & vbCrLf &
                              "Saldo final contable: " & Format(dSaldoFinal, "###,###,###") & vbCrLf &
                              "Conteo final: " & Format(totalConteo, "###,###,###") & vbCrLf &
                              "Diferencia: " & Format(diferencia, "###,###,###") & vbCrLf & vbCrLf &
                              "¿Desea guardar igualmente el cierre?"

                If MessageBox.Show(mensaje, "Cierre Diario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Exit Sub
                End If
            End If
        End If

        open()
        Try
            Using cmd As SqlCommand = connection.CreateCommand()
                cmd.CommandText = "SP_CONTA_CierrediarioCuenta"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Cta_Ctble", SqlDbType.VarChar, 7).Value = txt_Cta_Ctble.Text.Trim()
                cmd.Parameters.Add("@FechaCierre", SqlDbType.DateTime).Value = dtp_FechaApertura.Value.Date
                cmd.Parameters.Add("@Saldo_Final", SqlDbType.Float).Value = dSaldoFinal
                cmd.Parameters.Add("@Cierre_B1000", SqlDbType.Int).Value = cantidades(0)
                cmd.Parameters.Add("@Cierre_B2000", SqlDbType.Int).Value = cantidades(1)
                cmd.Parameters.Add("@Cierre_B5000", SqlDbType.Int).Value = cantidades(2)
                cmd.Parameters.Add("@Cierre_B10000", SqlDbType.Int).Value = cantidades(3)
                cmd.Parameters.Add("@Cierre_B20000", SqlDbType.Int).Value = cantidades(4)
                cmd.ExecuteNonQuery()
            End Using
        Finally
            close_conexion()
        End Try

        MsgBox("Cierre Diario ha sido guardado.", MsgBoxStyle.Information, "Cierre Diario")
        Me.Close()
    End Sub

    Private Sub InicializaConteoCierreUI()
        If _grpConteo IsNot Nothing Then
            Return
        End If

        Me.ClientSize = New Size(693, 860)
        btn_GrabaCierre.Location = New Point(100, 804)
        Button2.Location = New Point(423, 804)

        _grpConteo = New GroupBox() With {
            .Text = "Conteo de billetes cierre",
            .Location = New Point(12, 560),
            .Size = New Size(674, 224),
            .Visible = False
        }

        Dim lblTotalConteo As New Label() With {
            .Text = "Total contado:",
            .Location = New Point(389, 29),
            .AutoSize = True
        }

        _txtTotalConteo = New TextBox() With {
            .Location = New Point(482, 25),
            .Size = New Size(150, 20),
            .ReadOnly = True,
            .TextAlign = HorizontalAlignment.Right
        }

        Dim lblDiferencia As New Label() With {
            .Text = "Diferencia cierre:",
            .Location = New Point(367, 57),
            .AutoSize = True
        }

        _txtDiferencia = New TextBox() With {
            .Location = New Point(482, 53),
            .Size = New Size(150, 20),
            .ReadOnly = True,
            .TextAlign = HorizontalAlignment.Right
        }

        _grillaConteo = New DataGridView() With {
            .Location = New Point(16, 25),
            .Size = New Size(330, 176),
            .AllowUserToAddRows = False,
            .AllowUserToDeleteRows = False,
            .RowHeadersVisible = False,
            .BackgroundColor = Color.White,
            .SelectionMode = DataGridViewSelectionMode.CellSelect,
            .MultiSelect = False,
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        }

        Dim colBillete As New DataGridViewTextBoxColumn() With {
            .Name = "Billete",
            .HeaderText = "Denominación",
            .ReadOnly = True
        }
        Dim colCantidad As New DataGridViewTextBoxColumn() With {
            .Name = "Cantidad",
            .HeaderText = "Cantidad"
        }
        Dim colMonto As New DataGridViewTextBoxColumn() With {
            .Name = "Monto",
            .HeaderText = "Monto",
            .ReadOnly = True,
            .DefaultCellStyle = New DataGridViewCellStyle() With {.Alignment = DataGridViewContentAlignment.MiddleRight}
        }
        _grillaConteo.Columns.AddRange(New DataGridViewColumn() {colBillete, colCantidad, colMonto})

        For Each denominacion In Denominaciones
            _grillaConteo.Rows.Add(FormatearDenominacion(denominacion), Nothing, Nothing)
        Next

        AddHandler _grillaConteo.CellEndEdit, AddressOf GrillaConteo_CellEndEdit

        _grpConteo.Controls.Add(_grillaConteo)
        _grpConteo.Controls.Add(lblTotalConteo)
        _grpConteo.Controls.Add(_txtTotalConteo)
        _grpConteo.Controls.Add(lblDiferencia)
        _grpConteo.Controls.Add(_txtDiferencia)
        Me.Controls.Add(_grpConteo)
    End Sub

    Private Sub GrillaConteo_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs)
        RecalcularConteoCierre()
    End Sub

    Private Sub MostrarConteoCierre(ByVal mostrar As Boolean)
        _grpConteo.Visible = mostrar

        If Not mostrar Then
            LimpiarConteoCierre()
            _txtTotalConteo.Clear()
            _txtDiferencia.Clear()
        End If
    End Sub

    Private Function CuentaRequiereConteo() As Boolean
        Return CuentaCajaSeleccionada().StartsWith("110100")
    End Function

    Private Sub CargarConteoCierreActual()
        LimpiarConteoCierre()

        Dim dt = ObtenerConteoCaja(dtp_FechaApertura.Value.Date, txt_Cta_Ctble.Text.Trim())
        If dt.Rows.Count = 0 Then
            RecalcularConteoCierre()
            Return
        End If

        Dim fila = dt.Rows(0)
        If Convert.ToBoolean(fila("Cierre_Conteo_Registrado")) Then
            For i As Integer = 0 To Denominaciones.Length - 1
                _grillaConteo.Rows(i).Cells("Cantidad").Value = Convert.ToInt32(fila("Cierre_B" & Denominaciones(i).ToString()))
            Next
        End If

        RecalcularConteoCierre()
    End Sub

    Private Sub LimpiarConteoCierre()
        If _grillaConteo Is Nothing Then
            Return
        End If

        For Each row As DataGridViewRow In _grillaConteo.Rows
            row.Cells("Cantidad").Value = Nothing
            row.Cells("Monto").Value = Nothing
        Next
    End Sub

    Private Sub RecalcularConteoCierre()
        Dim cantidades = ObtenerCantidadesConteo(requerirIngreso:=False)
        Dim totalConteo = CalcularTotalConteo(cantidades)
        Dim diferencia = totalConteo - CDec(dSaldoFinal)

        _txtTotalConteo.Text = Format(totalConteo, "###,###,###")
        _txtDiferencia.Text = Format(diferencia, "###,###,###")
    End Sub

    Private Function ObtenerCantidadesConteo(ByVal requerirIngreso As Boolean) As Integer()
        Dim cantidades(Denominaciones.Length - 1) As Integer

        For i As Integer = 0 To Denominaciones.Length - 1
            Dim valor = Convert.ToString(_grillaConteo.Rows(i).Cells("Cantidad").Value).Trim()

            If valor = String.Empty Then
                If requerirIngreso Then
                    MessageBox.Show("Debe ingresar la cantidad para el billete " & FormatearDenominacion(Denominaciones(i)) & ".", "Cierre Diario", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return Nothing
                End If

                cantidades(i) = 0
                _grillaConteo.Rows(i).Cells("Monto").Value = Nothing
                Continue For
            End If

            Dim cantidad As Integer
            If Not Integer.TryParse(valor, cantidad) OrElse cantidad < 0 Then
                MessageBox.Show("La cantidad para el billete " & FormatearDenominacion(Denominaciones(i)) & " debe ser un entero mayor o igual a cero.", "Cierre Diario", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return Nothing
            End If

            cantidades(i) = cantidad
            _grillaConteo.Rows(i).Cells("Cantidad").Value = cantidad
            _grillaConteo.Rows(i).Cells("Monto").Value = Format(cantidad * Denominaciones(i), "###,###,###")
        Next

        Return cantidades
    End Function

    Private Function CalcularTotalConteo(ByVal cantidades As Integer()) As Decimal
        If cantidades Is Nothing Then
            Return 0D
        End If

        Dim total As Decimal = 0D
        For i As Integer = 0 To Denominaciones.Length - 1
            total += CDec(cantidades(i) * Denominaciones(i))
        Next

        Return total
    End Function

    Private Function FormatearDenominacion(ByVal valor As Integer) As String
        Return "$" & valor.ToString("#,##0")
    End Function

    Private Function CuentaCajaSeleccionada() As String
        If cmb_Cta_Ctble.SelectedValue Is Nothing Then
            Return txt_Cta_Ctble.Text.Trim()
        End If

        Return Convert.ToString(cmb_Cta_Ctble.SelectedValue).Trim()
    End Function

    Private Sub Cmb_Cta_Ctble_SelectedValueChanged(sender As Object, e As EventArgs)
        txt_Cta_Ctble.Text = CuentaCajaSeleccionada()
        GrillaCaja.Rows.Clear()
        LimpiarConteoCierre()

        If _txtTotalConteo IsNot Nothing Then
            _txtTotalConteo.Clear()
        End If

        If _txtDiferencia IsNot Nothing Then
            _txtDiferencia.Clear()
        End If

        btn_GrabaCierre.Enabled = False
    End Sub

    Private Sub AplicarCajaActiva()
        txt_Cta_Ctble.Text = CuentaCajaSeleccionada()

        If gIdPerfil = 1 Then
            cmb_Cta_Ctble.Enabled = True
            Return
        End If

        If String.IsNullOrWhiteSpace(gCuentaCaja) Then
            cmb_Cta_Ctble.Enabled = True
            Return
        End If

        cmb_Cta_Ctble.SelectedValue = gCuentaCaja.Trim()
        txt_Cta_Ctble.Text = gCuentaCaja.Trim()
        cmb_Cta_Ctble.Enabled = False

        If cmb_Cta_Ctble.SelectedIndex > -1 Then
            Consulta_Movimientos()
        End If
    End Sub

    Private Function AseguraCajaActivaSeleccionada() As Boolean
        Dim cuenta = CuentaCajaSeleccionada()
        Dim mensaje As String = String.Empty

        If String.IsNullOrWhiteSpace(cuenta) Then
            MessageBox.Show("Debe seleccionar una caja.", "Cierre Diario", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If gIdPerfil = 1 Then
            Return True
        End If

        If String.IsNullOrWhiteSpace(gCuentaCaja) AndAlso Not EstableceCajaActiva(cuenta, mensaje) Then
            MessageBox.Show(mensaje, "Cierre Diario", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmb_Cta_Ctble.SelectedIndex = -1
            txt_Cta_Ctble.Clear()
            Return False
        End If

        Return True
    End Function
End Class
