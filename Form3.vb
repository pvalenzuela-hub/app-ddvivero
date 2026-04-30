Imports System.Data
Imports System.Data.SqlClient
Imports ClosedXML.Excel

Public Class Form3
    Private _cmbCaja As ComboBox
    Private _txtCuentaCaja As TextBox
    Private _grillaReporte As DataGridView
    Private _btnExportarExcel As Button
    Private _txtSaldoInicial As TextBox
    Private _txtTotalIngresos As TextBox
    Private _txtTotalEgresos As TextBox
    Private _txtSaldoDia As TextBox
    Private _txtSaldoFinal As TextBox
    Private _txtCierreContado As TextBox
    Private _txtDiferencia As TextBox

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InicializaVistaReporte()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CargarReporteCuadratura()
    End Sub

    Private Sub InicializaVistaReporte()
        SplitContainer1.SplitterDistance = 120
        SplitContainer1.Panel1.AutoScroll = True

        Label1.Text = "Fecha reporte"
        Label1.Location = New Point(20, 13)

        DateTimePicker1.Location = New Point(110, 9)
        DateTimePicker1.Value = Date.Today

        Button1.Image = Nothing
        Button1.Text = "Consultar"
        Button1.Size = New Size(90, 28)
        Button1.Location = New Point(240, 7)

        If _btnExportarExcel Is Nothing Then
            _btnExportarExcel = New Button() With {
                .Text = "Excel",
                .Size = New Size(90, 28),
                .Location = New Point(340, 7)
            }
            AddHandler _btnExportarExcel.Click, AddressOf BtnExportarExcel_Click
            SplitContainer1.Panel1.Controls.Add(_btnExportarExcel)
        End If

        If _cmbCaja Is Nothing Then
            Dim lblCaja As New Label() With {
                .Text = "Caja",
                .Location = New Point(450, 13),
                .AutoSize = True
            }

            _cmbCaja = New ComboBox() With {
                .Location = New Point(485, 9),
                .Size = New Size(200, 21),
                .DropDownStyle = ComboBoxStyle.DropDownList
            }
            AddHandler _cmbCaja.SelectedValueChanged, AddressOf CmbCaja_SelectedValueChanged

            Dim lblCuenta As New Label() With {
                .Text = "Cuenta",
                .Location = New Point(700, 13),
                .AutoSize = True
            }

            _txtCuentaCaja = New TextBox() With {
                .Location = New Point(748, 9),
                .Size = New Size(85, 20),
                .ReadOnly = True,
                .TextAlign = HorizontalAlignment.Center
            }

            SplitContainer1.Panel1.Controls.Add(lblCaja)
            SplitContainer1.Panel1.Controls.Add(_cmbCaja)
            SplitContainer1.Panel1.Controls.Add(lblCuenta)
            SplitContainer1.Panel1.Controls.Add(_txtCuentaCaja)

            Carga_CajasDiarias(_cmbCaja, gCuentaCaja)
        End If

        CrearCampoResumen("Saldo inicial", 20, 45, _txtSaldoInicial)
        CrearCampoResumen("Total ingresos", 190, 45, _txtTotalIngresos)
        CrearCampoResumen("Total egresos", 360, 45, _txtTotalEgresos)
        CrearCampoResumen("Saldo del día", 530, 45, _txtSaldoDia)
        CrearCampoResumen("Saldo final", 700, 45, _txtSaldoFinal)
        CrearCampoResumen("Cierre contado", 870, 45, _txtCierreContado)
        CrearCampoResumen("Diferencia", 1040, 45, _txtDiferencia)

        If _grillaReporte Is Nothing Then
            _grillaReporte = New DataGridView() With {
                .Dock = DockStyle.Fill,
                .AllowUserToAddRows = False,
                .AllowUserToDeleteRows = False,
                .ReadOnly = True,
                .RowHeadersVisible = False,
                .BackgroundColor = Color.White,
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                .MultiSelect = False
            }
            AddHandler _grillaReporte.DataBindingComplete, AddressOf GrillaReporte_DataBindingComplete
        End If

        ReportViewer1.Visible = False
        SplitContainer1.Panel2.Controls.Clear()
        SplitContainer1.Panel2.Controls.Add(_grillaReporte)

        AplicarCajaActiva()
    End Sub

    Private Sub CrearCampoResumen(ByVal titulo As String,
                                  ByVal x As Integer,
                                  ByVal y As Integer,
                                  ByRef txtControl As TextBox)
        Dim nombreControl = "lblResumen_" & titulo.Replace(" ", String.Empty)

        If SplitContainer1.Panel1.Controls.ContainsKey(nombreControl) Then
            Return
        End If

        Dim lbl As New Label() With {
            .Name = nombreControl,
            .Text = titulo,
            .Location = New Point(x, y),
            .AutoSize = True
        }

        txtControl = New TextBox() With {
            .Location = New Point(x, y + 18),
            .Size = New Size(140, 20),
            .ReadOnly = True,
            .TextAlign = HorizontalAlignment.Right
        }

        SplitContainer1.Panel1.Controls.Add(lbl)
        SplitContainer1.Panel1.Controls.Add(txtControl)
    End Sub

    Private Sub CargarReporteCuadratura()
        Dim fecha = DateTimePicker1.Value.Date
        Dim cuentaCaja = CuentaCajaSeleccionada()
        Dim mensaje As String = String.Empty

        If String.IsNullOrWhiteSpace(cuentaCaja) Then
            MessageBox.Show("Debe seleccionar una caja.", "Reporte Cuadratura Diaria", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If gIdPerfil <> 1 AndAlso String.IsNullOrWhiteSpace(gCuentaCaja) AndAlso Not EstableceCajaActiva(cuentaCaja, mensaje) Then
            MessageBox.Show(mensaje, "Reporte Cuadratura Diaria", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            _cmbCaja.SelectedIndex = -1
            _txtCuentaCaja.Clear()
            Return
        End If

        Dim conteo = ObtenerConteoCaja(fecha, cuentaCaja)
        Dim movimientos = ObtenerMovimientosCaja(fecha, cuentaCaja)

        If conteo.Rows.Count = 0 AndAlso movimientos.Rows.Count = 0 Then
            MessageBox.Show("No existen datos de caja para la fecha seleccionada.", "Reporte Cuadratura Diaria", MessageBoxButtons.OK, MessageBoxIcon.Information)
            _grillaReporte.DataSource = Nothing
            LimpiarResumen()
            Return
        End If

        Dim filaConteo As DataRow = If(conteo.Rows.Count > 0, conteo.Rows(0), Nothing)
        Dim saldoInicial As Decimal = If(filaConteo Is Nothing, 0D, Convert.ToDecimal(filaConteo("Saldo_Inicial")))
        Dim cierreRegistrado As Boolean = filaConteo IsNot Nothing AndAlso Convert.ToBoolean(filaConteo("Cierre_Conteo_Registrado"))
        Dim cierreContado As Decimal = If(cierreRegistrado, Convert.ToDecimal(filaConteo("Cierre_Total_Contado")), 0D)

        Dim tabla As New DataTable()
        tabla.Columns.Add("Concepto", GetType(String))
        tabla.Columns.Add("Debe", GetType(Decimal))
        tabla.Columns.Add("Haber", GetType(Decimal))
        tabla.Columns.Add("Saldo", GetType(Decimal))

        tabla.Rows.Add("SALDO INICIAL", DBNull.Value, DBNull.Value, saldoInicial)

        Dim saldoAcumulado As Decimal = saldoInicial
        Dim totalIngresos As Decimal = 0D
        Dim totalEgresos As Decimal = 0D

        For Each fila As DataRow In movimientos.Rows
            Dim debe = Convert.ToDecimal(fila("Monto_Debe"))
            Dim haber = Convert.ToDecimal(fila("Monto_Haber"))

            totalIngresos += debe
            totalEgresos += haber
            saldoAcumulado += debe - haber

            tabla.Rows.Add(
                Convert.ToString(fila("Glosa")),
                If(debe = 0D, CType(DBNull.Value, Object), debe),
                If(haber = 0D, CType(DBNull.Value, Object), haber),
                saldoAcumulado)
        Next

        Dim saldoDia = totalIngresos - totalEgresos
        Dim saldoFinal = saldoInicial + saldoDia

        tabla.Rows.Add("TOTAL INGRESOS", totalIngresos, DBNull.Value, DBNull.Value)
        tabla.Rows.Add("TOTAL EGRESOS", DBNull.Value, totalEgresos, DBNull.Value)
        tabla.Rows.Add("SALDO DEL DÍA", DBNull.Value, DBNull.Value, saldoDia)
        tabla.Rows.Add("SALDO FINAL CONTABLE", DBNull.Value, DBNull.Value, saldoFinal)

        If cierreRegistrado Then
            tabla.Rows.Add("CIERRE CONTADO", DBNull.Value, DBNull.Value, cierreContado)
            tabla.Rows.Add("DIFERENCIA CIERRE", DBNull.Value, DBNull.Value, cierreContado - saldoFinal)
        End If

        _grillaReporte.DataSource = tabla

        _txtSaldoInicial.Text = Format(saldoInicial, "###,###,###")
        _txtTotalIngresos.Text = Format(totalIngresos, "###,###,###")
        _txtTotalEgresos.Text = Format(totalEgresos, "###,###,###")
        _txtSaldoDia.Text = Format(saldoDia, "###,###,###")
        _txtSaldoFinal.Text = Format(saldoFinal, "###,###,###")
        _txtCierreContado.Text = If(cierreRegistrado, Format(cierreContado, "###,###,###"), String.Empty)
        _txtDiferencia.Text = If(cierreRegistrado, Format(cierreContado - saldoFinal, "###,###,###"), String.Empty)
    End Sub

    Private Function ObtenerMovimientosCaja(ByVal fecha As Date) As DataTable
        Return ObtenerMovimientosCaja(fecha, CuentaCajaSeleccionada())
    End Function

    Private Function ObtenerMovimientosCaja(ByVal fecha As Date, ByVal cuentaCaja As String) As DataTable
        open()

        Try
            Using cmd As SqlCommand = connection.CreateCommand()
                cmd.CommandText = "SP_CONSULTA_CONTA_Movto_Diario"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Cta_Ctble", SqlDbType.VarChar, 7).Value = cuentaCaja
                cmd.Parameters.Add("@FechaCierre", SqlDbType.Date).Value = fecha

                Using adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        Finally
            close_conexion()
        End Try
    End Function

    Private Sub LimpiarResumen()
        _txtSaldoInicial.Clear()
        _txtTotalIngresos.Clear()
        _txtTotalEgresos.Clear()
        _txtSaldoDia.Clear()
        _txtSaldoFinal.Clear()
        _txtCierreContado.Clear()
        _txtDiferencia.Clear()
    End Sub

    Private Sub GrillaReporte_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs)
        If _grillaReporte.Columns.Count = 0 Then
            Return
        End If

        For Each colName In New String() {"Debe", "Haber", "Saldo"}
            If _grillaReporte.Columns.Contains(colName) Then
                _grillaReporte.Columns(colName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                _grillaReporte.Columns(colName).DefaultCellStyle.Format = "N0"
            End If
        Next

        For Each row As DataGridViewRow In _grillaReporte.Rows
            Dim concepto = Convert.ToString(row.Cells("Concepto").Value).Trim().ToUpperInvariant()
            If concepto.StartsWith("SALDO") OrElse concepto.StartsWith("TOTAL") OrElse concepto.StartsWith("CIERRE") OrElse concepto.StartsWith("DIFERENCIA") Then
                row.DefaultCellStyle.Font = New Font(_grillaReporte.Font, FontStyle.Bold)
                row.DefaultCellStyle.BackColor = Color.AliceBlue
            End If
        Next
    End Sub

    Private Sub BtnExportarExcel_Click(sender As Object, e As EventArgs)
        If _grillaReporte.DataSource Is Nothing OrElse _grillaReporte.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para exportar.", "Cuadratura Caja", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Using sfd As New SaveFileDialog()
            sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx"
            sfd.Title = "Guardar cuadratura diaria de caja"
            sfd.FileName = "CuadraturaCaja_" & DateTimePicker1.Value.ToString("yyyyMMdd") & ".xlsx"

            If sfd.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            Using wb As New XLWorkbook()
                Dim ws = wb.Worksheets.Add("Cuadratura Caja")

                ws.Cell(1, 1).Value = "Cuadratura diaria de caja"
                ws.Cell(1, 1).Style.Font.Bold = True
                ws.Cell(2, 1).Value = "Fecha"
                ws.Cell(2, 2).Value = DateTimePicker1.Value.Date
                ws.Cell(2, 3).Value = "Caja"
                ws.Cell(2, 4).Value = If(_cmbCaja Is Nothing, String.Empty, _cmbCaja.Text)
                ws.Cell(2, 5).Value = "Cuenta"
                ws.Cell(2, 6).Value = If(_txtCuentaCaja Is Nothing, String.Empty, _txtCuentaCaja.Text)

                ws.Cell(4, 1).Value = "Saldo inicial"
                ws.Cell(4, 2).Value = _txtSaldoInicial.Text
                ws.Cell(4, 3).Value = "Total ingresos"
                ws.Cell(4, 4).Value = _txtTotalIngresos.Text
                ws.Cell(4, 5).Value = "Total egresos"
                ws.Cell(4, 6).Value = _txtTotalEgresos.Text

                ws.Cell(5, 1).Value = "Saldo del día"
                ws.Cell(5, 2).Value = _txtSaldoDia.Text
                ws.Cell(5, 3).Value = "Saldo final"
                ws.Cell(5, 4).Value = _txtSaldoFinal.Text
                ws.Cell(5, 5).Value = "Cierre contado"
                ws.Cell(5, 6).Value = _txtCierreContado.Text
                ws.Cell(5, 7).Value = "Diferencia"
                ws.Cell(5, 8).Value = _txtDiferencia.Text

                Dim filaExcel As Integer = 7
                For col As Integer = 0 To _grillaReporte.Columns.Count - 1
                    ws.Cell(filaExcel, col + 1).Value = _grillaReporte.Columns(col).HeaderText
                    ws.Cell(filaExcel, col + 1).Style.Font.Bold = True
                Next

                filaExcel += 1
                For Each row As DataGridViewRow In _grillaReporte.Rows
                    If row.IsNewRow Then Continue For

                    For col As Integer = 0 To _grillaReporte.Columns.Count - 1
                        Dim value = row.Cells(col).Value
                        ws.Cell(filaExcel, col + 1).Value = If(value Is Nothing, String.Empty, value)
                    Next
                    filaExcel += 1
                Next

                ws.Columns().AdjustToContents()
                wb.SaveAs(sfd.FileName)
            End Using

            MessageBox.Show("Reporte generado correctamente.", "Cuadratura Caja", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TryToDisplayGeneratedFile(sfd.FileName)
        End Using
    End Sub

    Private Function CuentaCajaSeleccionada() As String
        If _cmbCaja Is Nothing OrElse _cmbCaja.SelectedValue Is Nothing Then
            Return String.Empty
        End If

        Return Convert.ToString(_cmbCaja.SelectedValue).Trim()
    End Function

    Private Sub CmbCaja_SelectedValueChanged(sender As Object, e As EventArgs)
        Dim cuentaCaja = CuentaCajaSeleccionada()
        _txtCuentaCaja.Text = cuentaCaja

        If _grillaReporte IsNot Nothing Then
            _grillaReporte.DataSource = Nothing
        End If

        If _txtSaldoInicial IsNot Nothing Then
            LimpiarResumen()
        End If
    End Sub

    Private Sub AplicarCajaActiva()
        If _cmbCaja Is Nothing Then
            Return
        End If

        If gIdPerfil = 1 OrElse String.IsNullOrWhiteSpace(gCuentaCaja) Then
            _cmbCaja.Enabled = True
            Return
        End If

        _cmbCaja.SelectedValue = gCuentaCaja.Trim()
        _txtCuentaCaja.Text = gCuentaCaja.Trim()
        _cmbCaja.Enabled = False
        CargarReporteCuadratura()
    End Sub
End Class
