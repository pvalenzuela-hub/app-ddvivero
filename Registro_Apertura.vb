Imports System.Data
Imports System.Data.SqlClient

Public Class Registro_Apertura
    Private Shared ReadOnly Denominaciones As Integer() = {1000, 2000, 5000, 10000, 20000}

    Private _cmbCaja As ComboBox
    Private _txtCuentaCaja As TextBox
    Private _grpConteo As GroupBox
    Private _grillaConteo As DataGridView
    Private _txtSaldoEsperado As TextBox
    Private _txtTotalConteo As TextBox
    Private _txtDiferencia As TextBox

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim cantidades = ObtenerCantidadesConteo(requerirIngreso:=True)
        If cantidades Is Nothing Then
            Exit Sub
        End If

        Dim totalConteo = CalcularTotalConteo(cantidades)
        Dim saldoEsperado = ObtenerMontoTextBox(_txtSaldoEsperado)

        If totalConteo <> saldoEsperado Then
            Dim diferencia = totalConteo - saldoEsperado
            Dim mensaje = "El conteo de apertura no coincide con el saldo inicial esperado." & vbCrLf &
                          "Saldo esperado: " & Format(saldoEsperado, "###,###,###") & vbCrLf &
                          "Conteo ingresado: " & Format(totalConteo, "###,###,###") & vbCrLf &
                          "Diferencia: " & Format(diferencia, "###,###,###") & vbCrLf & vbCrLf &
                          "¿Desea guardar igualmente la apertura?"

            If MessageBox.Show(mensaje, "Apertura de Caja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Exit Sub
            End If
        End If

        Apertura_Diaria(cantidades)
    End Sub

    Private Sub Apertura_Diaria(ByVal cantidades As Integer())
        Dim ctaCtble = CuentaCajaSeleccionada()
        If String.IsNullOrWhiteSpace(ctaCtble) Then
            MessageBox.Show("Debe seleccionar una caja.", "Apertura de Caja", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        open()

        Try
            Using cmd As SqlCommand = connection.CreateCommand()
                cmd.CommandText = "SP_CONTA_AperturaSaldos"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@FechaApertura", SqlDbType.DateTime).Value = dtp_FechaApertura.Value.Date
                cmd.Parameters.Add("@Cta_Ctble", SqlDbType.VarChar, 7).Value = ctaCtble
                cmd.Parameters.Add("@Apertura_B1000", SqlDbType.Int).Value = cantidades(0)
                cmd.Parameters.Add("@Apertura_B2000", SqlDbType.Int).Value = cantidades(1)
                cmd.Parameters.Add("@Apertura_B5000", SqlDbType.Int).Value = cantidades(2)
                cmd.Parameters.Add("@Apertura_B10000", SqlDbType.Int).Value = cantidades(3)
                cmd.Parameters.Add("@Apertura_B20000", SqlDbType.Int).Value = cantidades(4)
                cmd.ExecuteNonQuery()
            End Using
        Finally
            close_conexion()
        End Try

        MsgBox("Saldos de Apertura han sido guardados", MsgBoxStyle.Information)
        CargarConteoAperturaActual()
    End Sub

    Private Sub Registro_Apertura_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InicializaConteoAperturaUI()
        dtp_FechaApertura.Value = Date.Today
        Carga_CajasDiarias(_cmbCaja, gCuentaCaja)
        Button4.Enabled = False
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Lectura_Saldo_Apertura()
    End Sub

    Private Sub Lectura_Saldo_Apertura()
        Dim i As Integer = 0

        Dim saldoEsperado As Decimal = 0D
        Dim ctaCtble = CuentaCajaSeleccionada()
        Dim mensaje As String = String.Empty

        If String.IsNullOrWhiteSpace(ctaCtble) Then
            MessageBox.Show("Debe seleccionar una caja para consultar la apertura.", "Apertura de Caja", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(gCuentaCaja) AndAlso Not EstableceCajaActiva(ctaCtble, mensaje) Then
            MessageBox.Show(mensaje, "Apertura de Caja", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            _cmbCaja.SelectedIndex = -1
            _txtCuentaCaja.Clear()
            Exit Sub
        End If

        GrillaCaja.Rows.Clear()
        _txtSaldoEsperado.Clear()

        open()

        Try
            command = connection.CreateCommand()
            command.CommandText = "SP_CONSULTA_CONTA_SaldosdiariosApertura"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@FechaApertura", SqlDbType.DateTime).Value = dtp_FechaApertura.Value.Date
            command.Parameters.Add("@Cta_Ctble", SqlDbType.VarChar, 7).Value = ctaCtble
            Using reader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        GrillaCaja.Rows.Add()
                        GrillaCaja.Rows(i).Cells(0).Value = reader(0)
                        GrillaCaja.Rows(i).Cells(1).Value = reader(1)
                        GrillaCaja.Rows(i).Cells(2).Value = Format(reader(2), "###,###,###")
                        GrillaCaja.Rows(i).Cells(3).Value = reader(3)
                        saldoEsperado = Convert.ToDecimal(reader(2))
                        i += 1
                    End While
                End If
            End Using
        Finally
            close_conexion()
        End Try

        _txtSaldoEsperado.Text = Format(saldoEsperado, "###,###,###")
        Button4.Enabled = True
        CargarConteoAperturaActual()

        If GrillaCaja.Rows.Count = 0 Then
            MessageBox.Show("No existe saldo final del día anterior. La apertura se realizará con saldo inicial cero.", "Apertura de Caja", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub InicializaConteoAperturaUI()
        If _grpConteo IsNot Nothing Then
            Return
        End If

        Me.ClientSize = New Size(628, 740)
        Button1.Text = "Consultar apertura"
        Button1.Size = New Size(120, 23)
        Button1.Location = New Point(442, 58)
        GrillaCaja.Location = New Point(66, 173)
        Button4.Location = New Point(81, 682)
        Button2.Location = New Point(386, 682)

        Dim lblCaja As New Label() With {
            .Text = "Caja",
            .Location = New Point(123, 95),
            .AutoSize = True
        }

        _cmbCaja = New ComboBox() With {
            .Location = New Point(258, 92),
            .Size = New Size(248, 23),
            .DropDownStyle = ComboBoxStyle.DropDownList
        }
        AddHandler _cmbCaja.SelectedValueChanged, AddressOf CmbCaja_SelectedValueChanged

        Dim lblCuenta As New Label() With {
            .Text = "Cuenta contable",
            .Location = New Point(123, 126),
            .AutoSize = True
        }

        _txtCuentaCaja = New TextBox() With {
            .Location = New Point(258, 123),
            .Size = New Size(107, 21),
            .ReadOnly = True,
            .TextAlign = HorizontalAlignment.Center
        }

        Me.Controls.Add(lblCaja)
        Me.Controls.Add(_cmbCaja)
        Me.Controls.Add(lblCuenta)
        Me.Controls.Add(_txtCuentaCaja)

        _grpConteo = New GroupBox() With {
            .Text = "Conteo de billetes apertura",
            .Location = New Point(66, 450),
            .Size = New Size(496, 214)
        }

        Dim lblSaldoEsperado As New Label() With {
            .Text = "Saldo inicial esperado:",
            .Location = New Point(18, 28),
            .AutoSize = True
        }

        _txtSaldoEsperado = New TextBox() With {
            .Location = New Point(152, 24),
            .Size = New Size(100, 21),
            .ReadOnly = True,
            .TextAlign = HorizontalAlignment.Right
        }

        Dim lblTotalConteo As New Label() With {
            .Text = "Total contado:",
            .Location = New Point(276, 28),
            .AutoSize = True
        }

        _txtTotalConteo = New TextBox() With {
            .Location = New Point(365, 24),
            .Size = New Size(100, 21),
            .ReadOnly = True,
            .TextAlign = HorizontalAlignment.Right
        }

        Dim lblDiferencia As New Label() With {
            .Text = "Diferencia:",
            .Location = New Point(276, 55),
            .AutoSize = True
        }

        _txtDiferencia = New TextBox() With {
            .Location = New Point(365, 51),
            .Size = New Size(100, 21),
            .ReadOnly = True,
            .TextAlign = HorizontalAlignment.Right
        }

        _grillaConteo = New DataGridView() With {
            .Location = New Point(21, 84),
            .Size = New Size(444, 112),
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

        _grpConteo.Controls.Add(lblSaldoEsperado)
        _grpConteo.Controls.Add(_txtSaldoEsperado)
        _grpConteo.Controls.Add(lblTotalConteo)
        _grpConteo.Controls.Add(_txtTotalConteo)
        _grpConteo.Controls.Add(lblDiferencia)
        _grpConteo.Controls.Add(_txtDiferencia)
        _grpConteo.Controls.Add(_grillaConteo)
        Me.Controls.Add(_grpConteo)
    End Sub

    Private Sub GrillaConteo_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs)
        RecalcularConteo()
    End Sub

    Private Sub CargarConteoAperturaActual()
        LimpiarConteoApertura()

        Dim ctaCtble = CuentaCajaSeleccionada()
        If String.IsNullOrWhiteSpace(ctaCtble) Then
            RecalcularConteo()
            Return
        End If

        Dim dt = ObtenerConteoCaja(dtp_FechaApertura.Value.Date, ctaCtble)
        If dt.Rows.Count = 0 Then
            RecalcularConteo()
            Return
        End If

        Dim fila = dt.Rows(0)
        If Convert.ToBoolean(fila("Apertura_Conteo_Registrado")) Then
            CargarConteoEnGrilla(fila, True)
        End If

        RecalcularConteo()
    End Sub

    Private Sub CargarConteoEnGrilla(ByVal fila As DataRow, ByVal esApertura As Boolean)
        Dim prefijo = If(esApertura, "Apertura_B", "Cierre_B")

        For i As Integer = 0 To Denominaciones.Length - 1
            _grillaConteo.Rows(i).Cells("Cantidad").Value = Convert.ToInt32(fila(prefijo & Denominaciones(i).ToString()))
        Next
    End Sub

    Private Sub LimpiarConteoApertura()
        For Each row As DataGridViewRow In _grillaConteo.Rows
            row.Cells("Cantidad").Value = Nothing
            row.Cells("Monto").Value = Nothing
        Next
    End Sub

    Private Sub RecalcularConteo()
        Dim cantidades = ObtenerCantidadesConteo(requerirIngreso:=False)
        Dim totalConteo = CalcularTotalConteo(cantidades)
        Dim saldoEsperado = ObtenerMontoTextBox(_txtSaldoEsperado)

        _txtTotalConteo.Text = Format(totalConteo, "###,###,###")
        _txtDiferencia.Text = Format(totalConteo - saldoEsperado, "###,###,###")
    End Sub

    Private Function ObtenerCantidadesConteo(ByVal requerirIngreso As Boolean) As Integer()
        Dim cantidades(Denominaciones.Length - 1) As Integer

        For i As Integer = 0 To Denominaciones.Length - 1
            Dim valor = Convert.ToString(_grillaConteo.Rows(i).Cells("Cantidad").Value).Trim()

            If valor = String.Empty Then
                If requerirIngreso Then
                    MessageBox.Show("Debe ingresar la cantidad para el billete " & FormatearDenominacion(Denominaciones(i)) & ".", "Apertura de Caja", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return Nothing
                End If

                cantidades(i) = 0
                _grillaConteo.Rows(i).Cells("Monto").Value = Nothing
                Continue For
            End If

            Dim cantidad As Integer
            If Not Integer.TryParse(valor, cantidad) OrElse cantidad < 0 Then
                MessageBox.Show("La cantidad para el billete " & FormatearDenominacion(Denominaciones(i)) & " debe ser un entero mayor o igual a cero.", "Apertura de Caja", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

    Private Function ObtenerMontoTextBox(ByVal txt As TextBox) As Decimal
        Dim valor As Decimal = 0D
        Dim texto = txt.Text.Replace(".", String.Empty).Replace(",", String.Empty).Trim()
        Decimal.TryParse(texto, valor)
        Return valor
    End Function

    Private Sub CmbCaja_SelectedValueChanged(sender As Object, e As EventArgs)
        ActualizarCajaSeleccionada()
    End Sub

    Private Sub ActualizarCajaSeleccionada()
        Dim ctaCtble = CuentaCajaSeleccionada()
        _txtCuentaCaja.Text = ctaCtble

        GrillaCaja.Rows.Clear()
        _txtSaldoEsperado.Clear()
        Button4.Enabled = False
        LimpiarConteoApertura()
        RecalcularConteo()
    End Sub

    Private Function CuentaCajaSeleccionada() As String
        If _cmbCaja Is Nothing OrElse _cmbCaja.SelectedValue Is Nothing Then
            Return String.Empty
        End If

        Return Convert.ToString(_cmbCaja.SelectedValue).Trim()
    End Function

    Private Function FormatearDenominacion(ByVal valor As Integer) As String
        Return "$" & valor.ToString("#,##0")
    End Function
End Class
