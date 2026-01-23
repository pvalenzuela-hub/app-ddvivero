Imports ClosedXML.Excel
Imports System.IO
Public Class ConsultaLotesPantalla
    Private Sub ConsultaLotesPantalla_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.SP_CONSULTA_FULL_FAMILIA_PRODUCTOTableAdapter.Fill(Me.GESTDataSet.SP_CONSULTA_FULL_FAMILIA_PRODUCTO)
        cmbVariedad.SelectedIndex = -1
        cmbSemilla.SelectedIndex = -1
        CargaGrillaLotes()
        'If gEsAutorizador Then
        '    chkTodo.Visible = True
        'Else
        '    chkTodo.Visible = False
        'End If

    End Sub

    Private Sub CargaGrillaLotes()
        Dim i As Integer = 0

        GrillaLotes.Rows.Clear()
        sSsql = "[dbo].[L001_SP_ReporteLotes] "
        If cmbSemilla.SelectedIndex > -1 Then
            sSsql += cmbSemilla.SelectedValue.ToString & ","
        Else
            sSsql += "0,"
        End If
        If cmbVariedad.SelectedIndex > -1 Then
            sSsql += cmbVariedad.SelectedValue.ToString & ","
        Else
            sSsql += "0,"
        End If

        If chkTodo.Checked Then
            sSsql += "1"
        Else
            sSsql += "0"
        End If

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            While datatbl.Read
                GrillaLotes.Rows.Add()
                GrillaLotes.Rows(i).Cells("nlote").Value = datatbl("NLote")
                GrillaLotes.Rows(i).Cells("cliente").Value = datatbl("Cliente")
                GrillaLotes.Rows(i).Cells("semilla").Value = datatbl("Semilla")
                GrillaLotes.Rows(i).Cells("variedad").Value = datatbl("Variedad")
                GrillaLotes.Rows(i).Cells("semilla").Value = datatbl("Semilla")
                GrillaLotes.Rows(i).Cells("aportasemilla").Value = datatbl("AportaSemilla")
                GrillaLotes.Rows(i).Cells("pedido").Value = datatbl("Pedido")
                GrillaLotes.Rows(i).Cells("fechaconteos").Value = Format(datatbl("FechaConteoSiembra"), "dd/MM/yyyy")
                GrillaLotes.Rows(i).Cells("tipo").Value = datatbl("Tipo")
                GrillaLotes.Rows(i).Cells("saldoplanta").Value = datatbl("SaldoPlantas")
                GrillaLotes.Rows(i).Cells("saldobandeja").Value = datatbl("SaldoBandejas")
                GrillaLotes.Rows(i).Cells("fechasiembra").Value = Format(datatbl("FechaSiembra"), "dd/MM/yyyy")
                GrillaLotes.Rows(i).Cells("fechaentrega").Value = Format(datatbl("FechaEntrega"), "dd/MM/yyyy")
                GrillaLotes.Rows(i).Cells("estadolote").Value = datatbl("EstadoLote")
                GrillaLotes.Rows(i).Cells("ubicacion").Value = datatbl("Ubicacion")
                GrillaLotes.Rows(i).Cells("numnave").Value = datatbl("Nave")
                GrillaLotes.Rows(i).Cells("diasvivero").Value = datatbl("DiasVivero")
                If Not IsDBNull(datatbl("FechaAutorizacionCliente")) Then
                    GrillaLotes.Rows(i).Cells("FechaAutorizacionCliente").Value = Format(datatbl("FechaAutorizacionCliente"), "dd/MM/yyyy")
                End If


                If datatbl("Atraso") = 1 Then
                    GrillaLotes.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                End If
                i += 1
            End While
        End If
        close_conexion()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReporteExcel.Click
        'If cmbSemilla.SelectedIndex > -1 Then
        '    Consulta_Lotes.txtIdSemilla.Text = cmbSemilla.SelectedValue
        'Else
        '    Consulta_Lotes.txtIdSemilla.Text = 0
        'End If
        'If cmbVariedad.SelectedIndex > -1 Then
        '    Consulta_Lotes.txtIdVariedad.Text = cmbVariedad.SelectedValue
        'Else
        '    Consulta_Lotes.txtIdVariedad.Text = 0
        'End If
        'Consulta_Lotes.ChkTodo.Checked = chkTodo.Checked
        'Consulta_Lotes.Show()


        Try
            If GrillaLotes.Rows.Count = 0 Then
                MessageBox.Show("No hay datos para exportar.", "Reporte Excel", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            ExportarGrillaLotesAExcel()

        Catch ex As Exception
            MessageBox.Show("Error exportando a Excel: " & ex.Message, "Reporte Excel", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cmbSemilla.SelectedIndex = -1
        cmbVariedad.SelectedIndex = -1
        chkTodo.Checked = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CargaGrillaLotes()
    End Sub

    Private Sub cmbSemilla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSemilla.SelectedIndexChanged
        If cmbSemilla.SelectedIndex > -1 Then
            Me.SP_CONSULTA_FULL_VARIEDAD_IdFamiliaTableAdapter.Fill(Me.GESTDataSet.SP_CONSULTA_FULL_VARIEDAD_IdFamilia, cmbSemilla.SelectedValue)
            cmbVariedad.SelectedIndex = -1
        End If
    End Sub

    Private Sub ExportarGrillaLotesAExcel()

        Using sfd As New SaveFileDialog()
            sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx"
            sfd.FileName = "Reporte_Lotes_" & DateTime.Now.ToString("yyyyMMdd_HHmm")

            If sfd.ShowDialog() <> DialogResult.OK Then Exit Sub

            Dim filePath As String = sfd.FileName

            Using wb As New XLWorkbook()
                Dim ws = wb.Worksheets.Add("Lotes")

                ' =========================
                ' Encabezados
                ' =========================
                Dim colIndex As Integer = 1
                For Each col As DataGridViewColumn In GrillaLotes.Columns
                    If col.Visible Then
                        ws.Cell(1, colIndex).Value = col.HeaderText
                        ws.Cell(1, colIndex).Style.Font.Bold = True
                        ws.Cell(1, colIndex).Style.Fill.BackgroundColor = XLColor.LightGray
                        ws.Cell(1, colIndex).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                        ws.Cell(1, colIndex).Style.Border.OutsideBorder = XLBorderStyleValues.Thin
                        colIndex += 1
                    End If
                Next

                ' =========================
                ' Datos
                ' =========================
                Dim rowIndexExcel As Integer = 2
                For Each row As DataGridViewRow In GrillaLotes.Rows
                    If row.IsNewRow Then Continue For

                    colIndex = 1

                    For Each col As DataGridViewColumn In GrillaLotes.Columns
                        If col.Visible Then

                            Dim cell = ws.Cell(rowIndexExcel, colIndex)
                            Dim val = row.Cells(col.Name).Value

                            If val Is Nothing OrElse IsDBNull(val) Then
                                cell.Value = ""
                            Else
                                ' Intento de fechas por nombre de columna
                                If EsColumnaFecha(col.Name) OrElse EsColumnaFecha(col.HeaderText) Then

                                    Dim dt As DateTime

                                    ' Si ya viene como DateTime desde el grid/reader
                                    If TypeOf val Is DateTime Then
                                        dt = DirectCast(val, DateTime)
                                        cell.Value = dt
                                        cell.Style.DateFormat.Format = "dd/MM/yyyy"

                                    Else
                                        ' Si por algún motivo viene como texto
                                        Dim s As String = val.ToString().Trim()

                                        If DateTime.TryParse(s, dt) Then
                                            cell.Value = dt
                                            cell.Style.DateFormat.Format = "dd/MM/yyyy"
                                        Else
                                            ' fallback: deja el texto
                                            cell.Value = s
                                        End If
                                    End If

                                Else
                                    ' No fecha: como texto normal
                                    cell.Value = val.ToString()
                                End If
                            End If

                            cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin
                            colIndex += 1
                        End If
                    Next

                    ' Mantener color visual del grid
                    If row.DefaultCellStyle.BackColor = Color.LightGreen Then
                        ws.Range(rowIndexExcel, 1, rowIndexExcel, colIndex - 1) _
          .Style.Fill.BackgroundColor = XLColor.LightGreen
                    End If

                    rowIndexExcel += 1
                Next


                ' =========================
                ' Ajustes estéticos
                ' =========================
                ws.Columns().AdjustToContents()

                ' Autofiltro
                ws.Range(1, 1, 1, ws.LastColumnUsed().ColumnNumber()).SetAutoFilter()

                ' Congelar encabezado
                ws.SheetView.FreezeRows(1)

                wb.SaveAs(filePath)
            End Using

            MessageBox.Show("Reporte generado correctamente.", "Reporte Excel", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Opcional: abrir archivo
            Try
                Process.Start(filePath)
            Catch
            End Try

        End Using

    End Sub

    Private Function EsColumnaFecha(nombre As String) As Boolean
        If String.IsNullOrWhiteSpace(nombre) Then Return False

        Dim n = nombre.Trim().ToLower()

        ' Ajusta esta lista a tus nombres reales del grid
        Return n.Contains("fecha") _
        OrElse n.Contains("fechainicio") _
        OrElse n.Contains("fechaentrega") _
        OrElse n.Contains("fechaconteo") _
        OrElse n.Contains("fechaautorizacion")
    End Function


End Class