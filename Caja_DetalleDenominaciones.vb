Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports ClosedXML.Excel

Public Class Caja_DetalleDenominaciones
    Inherits System.Windows.Forms.Form

    Private _cmbCaja As ComboBox
    Private _dtpFecha As DateTimePicker
    Private _btnConsultar As Button
    Private _btnExcel As Button
    Private _grilla As DataGridView
    Private _txtApertura As TextBox
    Private _txtCierre As TextBox
    Private _txtIngresos As TextBox
    Private _txtEgresos As TextBox
    Private _txtSaldoRealFinal As TextBox
    Private _txtTotalDenominaciones As TextBox
    Private _txtDiferencia As TextBox

    Private Shared ReadOnly Denominaciones As Integer() = {1000, 2000, 5000, 10000, 20000, 500, 100, 50, 10}

    Private Sub Caja_DetalleDenominaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConstruirUI()
        Carga_CajasDiarias(_cmbCaja, gCuentaCaja)
        If _cmbCaja.Items.Count > 0 Then
            _cmbCaja.SelectedIndex = -1
        End If
        _dtpFecha.Value = Date.Today
        CentrarFormularioEnPantalla()
    End Sub

    Private Sub CentrarFormularioEnPantalla()
        Dim area = Screen.PrimaryScreen.WorkingArea
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(area.Left + (area.Width - Me.Width) / 2, area.Top + (area.Height - Me.Height) / 2)
    End Sub

    Private Sub ConstruirUI()
        Me.Text = "Detalle Denominaciones Caja"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.ClientSize = New Size(980, 650)
        Me.BackColor = Color.White

        Dim lblFecha As New Label() With {.Text = "Fecha", .Location = New Point(18, 18), .AutoSize = True}
        _dtpFecha = New DateTimePicker() With {.Location = New Point(70, 14), .Size = New Size(110, 21), .Format = DateTimePickerFormat.Short}

        Dim lblCaja As New Label() With {.Text = "Caja", .Location = New Point(200, 18), .AutoSize = True}
        _cmbCaja = New ComboBox() With {.Location = New Point(240, 14), .Size = New Size(180, 21), .DropDownStyle = ComboBoxStyle.DropDownList}

        _btnConsultar = New Button() With {.Text = "Consultar", .Location = New Point(440, 12), .Size = New Size(90, 25)}
        AddHandler _btnConsultar.Click, AddressOf Consultar_Click

        _btnExcel = New Button() With {.Text = "Excel", .Location = New Point(540, 12), .Size = New Size(80, 25)}
        AddHandler _btnExcel.Click, AddressOf Excel_Click

        Dim grpResumen As New GroupBox() With {
            .Text = "Resumen del día",
            .Location = New Point(18, 45),
            .Size = New Size(940, 42),
            .BackColor = Color.AliceBlue
        }

        Dim lblIng As New Label() With {.Text = "Total Ingresos", .Location = New Point(12, 18), .AutoSize = True}
        _txtIngresos = New TextBox() With {.Location = New Point(100, 15), .Size = New Size(100, 21), .ReadOnly = True, .TextAlign = HorizontalAlignment.Right}
        Dim lblEgr As New Label() With {.Text = "Total Egresos", .Location = New Point(220, 18), .AutoSize = True}
        _txtEgresos = New TextBox() With {.Location = New Point(305, 15), .Size = New Size(100, 21), .ReadOnly = True, .TextAlign = HorizontalAlignment.Right}
        Dim lblA As New Label() With {.Text = "Apertura", .Location = New Point(425, 18), .AutoSize = True}
        _txtApertura = New TextBox() With {.Location = New Point(490, 15), .Size = New Size(110, 21), .ReadOnly = True, .TextAlign = HorizontalAlignment.Right}
        Dim lblC As New Label() With {.Text = "Cierre", .Location = New Point(620, 18), .AutoSize = True}
        _txtCierre = New TextBox() With {.Location = New Point(670, 15), .Size = New Size(110, 21), .ReadOnly = True, .TextAlign = HorizontalAlignment.Right}

        Dim grpResumen2 As New GroupBox() With {
            .Text = "Cuadratura",
            .Location = New Point(18, 106),
            .Size = New Size(940, 42),
            .BackColor = Color.Honeydew
        }

        Dim lblSR As New Label() With {.Text = "Saldo Real Final", .Location = New Point(12, 18), .AutoSize = True}
        _txtSaldoRealFinal = New TextBox() With {.Location = New Point(115, 15), .Size = New Size(110, 21), .ReadOnly = True, .TextAlign = HorizontalAlignment.Right}
        Dim lblTD As New Label() With {.Text = "Total Denominaciones", .Location = New Point(245, 18), .AutoSize = True}
        _txtTotalDenominaciones = New TextBox() With {.Location = New Point(385, 15), .Size = New Size(110, 21), .ReadOnly = True, .TextAlign = HorizontalAlignment.Right}
        Dim lblDif As New Label() With {.Text = "Diferencia", .Location = New Point(515, 18), .AutoSize = True}
        _txtDiferencia = New TextBox() With {.Location = New Point(585, 15), .Size = New Size(110, 21), .ReadOnly = True, .TextAlign = HorizontalAlignment.Right}

        _grilla = New DataGridView() With {
            .Location = New Point(18, 150),
            .Size = New Size(940, 430),
            .AllowUserToAddRows = False,
            .AllowUserToDeleteRows = False,
            .ReadOnly = True,
            .RowHeadersVisible = False,
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        }
        _grilla.Columns.Add("Denom", "Denominación")
        _grilla.Columns.Add("Ap", "Apertura")
        _grilla.Columns.Add("Ci", "Cierre")
        _grilla.Columns.Add("TotalA", "Total Apertura")
        _grilla.Columns.Add("TotalC", "Total Cierre")
        _grilla.Columns("Denom").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        For Each colName In New String() {"Ap", "Ci", "TotalA", "TotalC"}
            _grilla.Columns(colName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            _grilla.Columns(colName).DefaultCellStyle.Format = "N0"
        Next

        Me.Controls.Add(lblFecha)
        Me.Controls.Add(_dtpFecha)
        Me.Controls.Add(lblCaja)
        Me.Controls.Add(_cmbCaja)
        Me.Controls.Add(_btnConsultar)
        Me.Controls.Add(_btnExcel)
        grpResumen.Controls.Add(lblIng)
        grpResumen.Controls.Add(_txtIngresos)
        grpResumen.Controls.Add(lblEgr)
        grpResumen.Controls.Add(_txtEgresos)
        grpResumen.Controls.Add(lblA)
        grpResumen.Controls.Add(_txtApertura)
        grpResumen.Controls.Add(lblC)
        grpResumen.Controls.Add(_txtCierre)
        grpResumen2.Controls.Add(lblSR)
        grpResumen2.Controls.Add(_txtSaldoRealFinal)
        grpResumen2.Controls.Add(lblTD)
        grpResumen2.Controls.Add(_txtTotalDenominaciones)
        grpResumen2.Controls.Add(lblDif)
        grpResumen2.Controls.Add(_txtDiferencia)
        Me.Controls.Add(grpResumen)
        Me.Controls.Add(grpResumen2)
        Me.Controls.Add(_grilla)
    End Sub

    Private Sub Consultar_Click(sender As Object, e As EventArgs)
        Dim caja = If(_cmbCaja.SelectedValue Is Nothing, String.Empty, Convert.ToString(_cmbCaja.SelectedValue).Trim())
        If String.IsNullOrWhiteSpace(caja) Then
            MessageBox.Show("Seleccione una caja.", "Detalle Denominaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim dt = ObtenerConteoCaja(_dtpFecha.Value.Date, caja)
        If dt.Rows.Count = 0 Then
            MessageBox.Show("No existen datos para la fecha seleccionada.", "Detalle Denominaciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
            _grilla.Rows.Clear()
            Return
        End If

        Dim fila = dt.Rows(0)
        _grilla.Rows.Clear()

        Dim mov = ObtenerMovimientosCaja(_dtpFecha.Value.Date, caja)
        Dim totalIng As Decimal = 0D
        Dim totalEgr As Decimal = 0D
        For Each r As DataRow In mov.Rows
            totalIng += Convert.ToDecimal(r("Monto_Debe"))
            totalEgr += Convert.ToDecimal(r("Monto_Haber"))
        Next

        Dim totalA As Decimal = 0D
        Dim totalC As Decimal = 0D

        For Each denom In Denominaciones
            Dim a As Integer = 0
            Dim c As Integer = 0
            Dim colA = "Apertura_B" & denom.ToString()
            Dim colC = "Cierre_B" & denom.ToString()

            If fila.Table.Columns.Contains(colA) AndAlso Not IsDBNull(fila(colA)) Then Integer.TryParse(Convert.ToString(fila(colA)), a)
            If fila.Table.Columns.Contains(colC) AndAlso Not IsDBNull(fila(colC)) Then Integer.TryParse(Convert.ToString(fila(colC)), c)

            totalA += a * denom
            totalC += c * denom
            _grilla.Rows.Add(Formatear(denom), a, c, a * denom, c * denom)
        Next

        _txtApertura.Text = Format(totalA, "N0")
        _txtCierre.Text = Format(totalC, "N0")
        _txtIngresos.Text = Format(totalIng, "N0")
        _txtEgresos.Text = Format(totalEgr, "N0")
        Dim saldoInicial As Decimal = 0D
        If fila.Table.Columns.Contains("Saldo_Inicial") AndAlso Not IsDBNull(fila("Saldo_Inicial")) Then
            saldoInicial = Convert.ToDecimal(fila("Saldo_Inicial"))
        End If

        Dim saldoRealFinal As Decimal = saldoInicial + totalIng - totalEgr
        Dim totalDenominaciones As Decimal = totalC
        _txtSaldoRealFinal.Text = Format(saldoRealFinal, "N0")
        _txtTotalDenominaciones.Text = Format(totalDenominaciones, "N0")
        _txtDiferencia.Text = Format(totalDenominaciones - saldoRealFinal, "N0")
    End Sub

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

    Private Sub Excel_Click(sender As Object, e As EventArgs)
        If _grilla.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para exportar.", "Detalle Denominaciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Using sfd As New SaveFileDialog()
            sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx"
            sfd.Title = "Guardar detalle de denominaciones"
            sfd.FileName = "DetalleDenominaciones_" & _dtpFecha.Value.ToString("yyyyMMdd") & ".xlsx"

            If sfd.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            Using wb As New XLWorkbook()
                Dim ws = wb.Worksheets.Add("Detalle")
                ws.Cell(1, 1).Value = "Detalle Denominaciones Caja"
                ws.Cell(1, 1).Style.Font.Bold = True
                ws.Cell(2, 1).Value = "Fecha"
                ws.Cell(2, 2).Value = _dtpFecha.Value.Date
                ws.Cell(2, 3).Value = "Caja"
                ws.Cell(2, 4).Value = If(_cmbCaja Is Nothing, String.Empty, _cmbCaja.Text)
                ws.Cell(2, 5).Value = "Total Ingresos"
                ws.Cell(2, 6).Value = _txtIngresos.Text
                ws.Cell(2, 7).Value = "Total Egresos"
                ws.Cell(2, 8).Value = _txtEgresos.Text
                ws.Cell(2, 9).Value = "Apertura"
                ws.Cell(2, 10).Value = _txtApertura.Text
                ws.Cell(2, 11).Value = "Cierre"
                ws.Cell(2, 12).Value = _txtCierre.Text
                ws.Cell(3, 1).Value = "Saldo Real Final"
                ws.Cell(3, 2).Value = _txtSaldoRealFinal.Text
                ws.Cell(3, 3).Value = "Total Denominaciones"
                ws.Cell(3, 4).Value = _txtTotalDenominaciones.Text
                ws.Cell(3, 5).Value = "Diferencia"
                ws.Cell(3, 6).Value = _txtDiferencia.Text

                For c As Integer = 0 To _grilla.Columns.Count - 1
                    ws.Cell(4, c + 1).Value = _grilla.Columns(c).HeaderText
                    ws.Cell(4, c + 1).Style.Font.Bold = True
                Next

                Dim filaExcel As Integer = 5
                For Each row As DataGridViewRow In _grilla.Rows
                    If row.IsNewRow Then Continue For
                    For c As Integer = 0 To _grilla.Columns.Count - 1
                        Dim valor = row.Cells(c).Value
                        If valor Is Nothing OrElse IsDBNull(valor) Then
                            ws.Cell(filaExcel, c + 1).Value = String.Empty
                        ElseIf c = 1 OrElse c = 2 OrElse c = 3 OrElse c = 4 Then
                            ws.Cell(filaExcel, c + 1).Value = Convert.ToDecimal(valor)
                        Else
                            ws.Cell(filaExcel, c + 1).Value = Convert.ToString(valor)
                        End If
                    Next
                    filaExcel += 1
                Next

                ws.Columns().AdjustToContents()
                wb.SaveAs(sfd.FileName)
            End Using
        End Using
    End Sub

    Private Function Formatear(ByVal valor As Integer) As String
        Return "$" & valor.ToString("#,##0")
    End Function

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Caja_DetalleDenominaciones
        '
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Name = "Caja_DetalleDenominaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
End Class
