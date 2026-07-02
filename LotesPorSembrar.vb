Imports System.Collections.Generic
Imports System.Data
Imports ClosedXML.Excel
Imports System.IO

Public Class LotesPorSembrar
    Private Sub LotesPorSembrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EjecutaConsulta()
        Me.SP_CONSULTA_LOTE_SIN_SEMBRARTableAdapter.Fill(Me.DataSetReporteInventario.SP_CONSULTA_LOTE_SIN_SEMBRAR, dtpFechaSiembra.Value)
        CargarResumenBandejas()
    End Sub

    Private Sub CargarResumenBandejas()
        DataResumen.Rows.Clear()

        Dim resumen As New Dictionary(Of String, Decimal)()

        For Each fila As DataRow In Me.DataSetReporteInventario.SP_CONSULTA_LOTE_SIN_SEMBRAR.Rows
            If fila.IsNull("Tipo") OrElse fila.IsNull("TotalBandejas") Then
                Continue For
            End If

            Dim tipo As String = fila("Tipo").ToString().Trim()
            If tipo = String.Empty Then
                Continue For
            End If

            Dim bandejas As Decimal = 0D
            Decimal.TryParse(fila("TotalBandejas").ToString(), bandejas)

            If resumen.ContainsKey(tipo) Then
                resumen(tipo) += bandejas
            Else
                resumen(tipo) = bandejas
            End If
        Next

        Dim claves As New List(Of String)(resumen.Keys)
        claves.Sort()

        For Each clave As String In claves
            DataResumen.Rows.Add(clave, resumen(clave))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EjecutaConsulta()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGrilla.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para exportar.", "Lotes por Sembrar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Using dlg As New SaveFileDialog()
            dlg.Filter = "Libro de Excel (*.xlsx)|*.xlsx"
            dlg.FileName = "LotesPorSembrar_" & dtpFechaSiembra.Value.ToString("yyyyMMdd") & ".xlsx"

            If dlg.ShowDialog(Me) <> DialogResult.OK Then
                Return
            End If

            Dim rutaLogoTemporal As String = String.Empty

            Try
                Using wb As New XLWorkbook()
                    Dim ws = wb.Worksheets.Add("Lotes por Sembrar")
                    Dim columnasVisibles = ObtenerColumnasVisibles(DataGrilla)
                    If columnasVisibles.Count = 0 Then
                        MessageBox.Show("No hay columnas visibles para exportar.", "Lotes por Sembrar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If

                    ConfigurarHojaReporte(ws)
                    rutaLogoTemporal = CrearLogoTemporal()
                    If rutaLogoTemporal <> String.Empty Then
                        AgregarLogo(ws, rutaLogoTemporal)
                    End If

                    EscribirEncabezadoReporte(ws)

                    Dim ultimaFilaDetalle = EscribirDetalle(ws, columnasVisibles)
                    EscribirResumen(ws, ultimaFilaDetalle)

                    wb.SaveAs(dlg.FileName)
                End Using
            Finally
                If rutaLogoTemporal <> String.Empty AndAlso File.Exists(rutaLogoTemporal) Then
                    File.Delete(rutaLogoTemporal)
                End If
            End Try
        End Using

        MessageBox.Show("Exportación completada.", "Lotes por Sembrar", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ConfigurarHojaReporte(ByVal ws As IXLWorksheet)
        ws.Style.Font.FontName = "Arial"
        ws.Style.Font.FontSize = 9
        ws.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center

        ws.Column(1).Width = 9
        ws.Column(2).Width = 10
        ws.Column(3).Width = 34
        ws.Column(4).Width = 14
        ws.Column(5).Width = 17
        ws.Column(6).Width = 14
        ws.Column(7).Width = 11
        ws.Column(8).Width = 16.86
        ws.Column(9).Width = 18.57
        ws.Column(10).Width = 22

        ws.Row(1).Height = 38
        ws.Row(2).Height = 6
        ws.Row(3).Height = 28
    End Sub

    Private Function CrearLogoTemporal() As String
        If My.Resources.logo3 Is Nothing Then
            Return String.Empty
        End If

        Dim ruta = Path.Combine(Path.GetTempPath(), "GestionVivero_LotesPorSembrar_logo3.png")
        My.Resources.logo3.Save(ruta, System.Drawing.Imaging.ImageFormat.Png)
        Return ruta
    End Function

    Private Sub AgregarLogo(ByVal ws As IXLWorksheet, ByVal rutaLogo As String)
        Dim pic = ws.AddPicture(rutaLogo)
        pic.MoveTo(ws.Cell(1, 1))
        pic.Width = 46
        pic.Height = 46

        With ws.Cell(1, 1).Style
            .Fill.BackgroundColor = XLColor.White
            .Border.OutsideBorder = XLBorderStyleValues.Thin
            .Border.OutsideBorderColor = XLColor.FromArgb(125, 156, 115)
        End With
    End Sub

    Private Sub EscribirEncabezadoReporte(ByVal ws As IXLWorksheet)
        ws.Range(1, 2, 1, 6).Merge()
        With ws.Cell(1, 2)
            .Value = "LOTES POR SEMBRAR"
            .Style.Font.Bold = True
            .Style.Font.FontSize = 26
            .Style.Font.FontColor = XLColor.FromArgb(16, 87, 29)
            .Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left
        End With

        ws.Range(1, 7, 1, 8).Merge()
        With ws.Cell(1, 7)
            .Value = "Hasta Fecha de Siembra:"
            .Style.Font.Bold = True
            .Style.Font.FontSize = 12
            .Style.Font.FontColor = XLColor.FromArgb(14, 46, 138)
            .Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right
        End With

        With ws.Cell(1, 9)
            .Value = dtpFechaSiembra.Value
            .Style.DateFormat.Format = "dd/MM/yyyy"
            .Style.Font.Bold = True
            .Style.Font.FontSize = 16
            .Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
            .Style.Fill.BackgroundColor = XLColor.White
            .Style.Border.OutsideBorder = XLBorderStyleValues.Thin
            .Style.Border.OutsideBorderColor = XLColor.FromArgb(125, 156, 115)
        End With

        With ws.Cell(1, 10)
            .Value = ChrW(&H2714)
            .Style.Font.Bold = True
            .Style.Font.FontSize = 22
            .Style.Font.FontColor = XLColor.FromArgb(36, 120, 36)
            .Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
            .Style.Fill.BackgroundColor = XLColor.White
            .Style.Border.OutsideBorder = XLBorderStyleValues.Thin
            .Style.Border.OutsideBorderColor = XLColor.FromArgb(125, 156, 115)
        End With
    End Sub

    Private Function EscribirDetalle(ByVal ws As IXLWorksheet, ByVal columnasVisibles As List(Of DataGridViewColumn)) As Integer
        Dim filaEncabezado As Integer = 3
        Dim filaExcel As Integer = 4

        For i As Integer = 0 To columnasVisibles.Count - 1
            Dim col = columnasVisibles(i)
            Dim cell = ws.Cell(filaEncabezado, i + 1)
            cell.Value = ObtenerEncabezadoExcel(col)
            cell.Style.Font.Bold = True
            cell.Style.Font.FontColor = XLColor.White
            cell.Style.Fill.BackgroundColor = XLColor.FromArgb(13, 79, 17)
            cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
            cell.Style.Alignment.WrapText = True
            cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin
            cell.Style.Border.OutsideBorderColor = XLColor.FromArgb(209, 220, 207)
        Next

        For Each fila As DataGridViewRow In DataGrilla.Rows
            If fila.IsNewRow Then
                Continue For
            End If

            ws.Row(filaExcel).Height = 20

            For i As Integer = 0 To columnasVisibles.Count - 1
                Dim col = columnasVisibles(i)
                Dim cell = ws.Cell(filaExcel, i + 1)
                Dim valor = fila.Cells(col.Index).Value

                EscribeCeldaExcel(cell, valor, col)
                AplicarEstiloDetalle(cell, col, valor)
            Next

            filaExcel += 1
        Next

        Return filaExcel - 1
    End Function

    Private Sub AplicarEstiloDetalle(ByVal cell As IXLCell, ByVal columna As DataGridViewColumn, ByVal valor As Object)
        cell.Style.Fill.BackgroundColor = XLColor.White
        cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin
        cell.Style.Border.OutsideBorderColor = XLColor.FromArgb(224, 224, 224)
        cell.Style.Alignment.WrapText = False
        cell.Style.Font.FontSize = 9

        Select Case columna.DataPropertyName
            Case "IdPedidodet", "IdPedido"
                cell.Style.Font.Bold = True
                cell.Style.Font.FontColor = XLColor.FromArgb(31, 67, 168)
                cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center

            Case "Cliente"
                cell.Style.Font.Bold = True
                cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left

            Case "Descrip", "Descripcion"
                cell.Style.Font.Bold = True
                cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center

            Case "Fecha_Siembra"
                cell.Style.Font.Bold = True
                cell.Style.Font.FontColor = XLColor.FromArgb(31, 67, 168)
                cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center

            Case "CANTIDAD"
                cell.Style.Font.Bold = True
                cell.Style.Font.FontSize = 12
                cell.Style.Font.FontColor = XLColor.FromArgb(31, 67, 168)
                cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right

            Case "Tipo"
                cell.Style.Font.Bold = True
                cell.Style.Font.FontColor = XLColor.FromArgb(18, 99, 38)
                cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center

            Case "TotalBandejas"
                cell.Style.Font.Bold = True
                cell.Style.Font.FontColor = XLColor.FromArgb(18, 99, 38)
                cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right

            Case "Comentario"
                cell.Style.Font.FontSize = 8
                cell.Style.Font.FontColor = XLColor.FromArgb(18, 99, 38)
                cell.Style.Alignment.WrapText = True
                If Not (valor Is Nothing OrElse valor Is DBNull.Value) AndAlso Convert.ToString(valor).Length > 40 Then
                    cell.WorksheetRow().Height = 28
                End If

            Case Else
                cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
        End Select
    End Sub

    Private Sub EscribirResumen(ByVal ws As IXLWorksheet, ByVal ultimaFilaDetalle As Integer)
        Dim filaTitulo As Integer = ultimaFilaDetalle + 2
        Dim filaEncabezado As Integer = filaTitulo + 1
        Dim filaDatos As Integer = filaEncabezado + 1
        Dim totalGeneral As Decimal = 0D

        ws.Range(filaTitulo, 1, filaTitulo, 10).Merge()
        With ws.Cell(filaTitulo, 1)
            .Value = "RESUMEN DE BANDEJAS NECESARIAS"
            .Style.Font.Bold = True
            .Style.Font.FontColor = XLColor.White
            .Style.Fill.BackgroundColor = XLColor.FromArgb(12, 56, 146)
            .Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left
        End With
        ws.Row(filaTitulo).Height = 20

        ws.Range(filaEncabezado, 1, filaEncabezado, 5).Merge()
        ws.Range(filaEncabezado, 6, filaEncabezado, 10).Merge()

        AplicarEncabezadoResumen(ws.Cell(filaEncabezado, 1), "TIPO DE BANDEJA")
        AplicarEncabezadoResumen(ws.Cell(filaEncabezado, 6), "TOTAL BANDEJAS")

        For Each fila As DataGridViewRow In DataResumen.Rows
            If fila.IsNewRow Then
                Continue For
            End If

            Dim tipo = Convert.ToString(fila.Cells(0).Value).Trim()
            If tipo = String.Empty Then
                Continue For
            End If

            Dim total As Decimal = 0D
            Decimal.TryParse(Convert.ToString(fila.Cells(1).Value), total)
            totalGeneral += total

            ws.Range(filaDatos, 1, filaDatos, 5).Merge()
            ws.Range(filaDatos, 6, filaDatos, 10).Merge()

            With ws.Cell(filaDatos, 1)
                .Value = tipo
                .Style.Font.Bold = True
                .Style.Font.FontColor = XLColor.FromArgb(18, 51, 133)
                .Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                .Style.Border.OutsideBorder = XLBorderStyleValues.Thin
                .Style.Border.OutsideBorderColor = XLColor.FromArgb(212, 222, 243)
            End With

            With ws.Cell(filaDatos, 6)
                .Value = total
                .Style.Font.Bold = True
                .Style.Font.FontColor = XLColor.FromArgb(18, 51, 133)
                .Style.NumberFormat.Format = "#,##0.00"
                .Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                .Style.Border.OutsideBorder = XLBorderStyleValues.Thin
                .Style.Border.OutsideBorderColor = XLColor.FromArgb(212, 222, 243)
            End With

            filaDatos += 1
        Next

        ws.Range(filaDatos, 1, filaDatos, 5).Merge()
        ws.Range(filaDatos, 6, filaDatos, 10).Merge()

        With ws.Cell(filaDatos, 1)
            .Value = "TOTAL GENERAL"
            .Style.Font.Bold = True
            .Style.Font.FontColor = XLColor.FromArgb(18, 51, 133)
            .Style.Fill.BackgroundColor = XLColor.FromArgb(237, 243, 252)
            .Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
            .Style.Border.OutsideBorder = XLBorderStyleValues.Thin
            .Style.Border.OutsideBorderColor = XLColor.FromArgb(186, 203, 236)
        End With

        With ws.Cell(filaDatos, 6)
            .Value = totalGeneral
            .Style.Font.Bold = True
            .Style.Font.FontSize = 11
            .Style.Font.FontColor = XLColor.FromArgb(18, 51, 133)
            .Style.Fill.BackgroundColor = XLColor.FromArgb(237, 243, 252)
            .Style.NumberFormat.Format = "#,##0.00"
            .Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
            .Style.Border.OutsideBorder = XLBorderStyleValues.Thin
            .Style.Border.OutsideBorderColor = XLColor.FromArgb(186, 203, 236)
        End With
    End Sub

    Private Sub AplicarEncabezadoResumen(ByVal cell As IXLCell, ByVal texto As String)
        cell.Value = texto
        cell.Style.Font.Bold = True
        cell.Style.Font.FontColor = XLColor.FromArgb(18, 51, 133)
        cell.Style.Fill.BackgroundColor = XLColor.White
        cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
        cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin
        cell.Style.Border.OutsideBorderColor = XLColor.FromArgb(212, 222, 243)
    End Sub

    Private Function ObtenerEncabezadoExcel(ByVal columna As DataGridViewColumn) As String
        Select Case columna.DataPropertyName
            Case "IdPedidodet"
                Return "N° LOTE"
            Case "IdPedido"
                Return "N° PEDIDO"
            Case "Cliente"
                Return "CLIENTE"
            Case "Descrip"
                Return "SEMILLA"
            Case "Descripcion"
                Return "VARIEDAD"
            Case "Fecha_Siembra"
                Return "FECHA" & vbLf & "SIEMBRA"
            Case "CANTIDAD"
                Return "CANTIDAD"
            Case "Tipo"
                Return "TIPO"
            Case "TotalBandejas"
                Return "TOTAL" & vbLf & "BANDEJAS"
            Case "Comentario"
                Return "COMENTARIO"
            Case Else
                Return columna.HeaderText.ToUpperInvariant()
        End Select
    End Function

    Private Function ObtenerColumnasVisibles(ByVal grilla As DataGridView) As List(Of DataGridViewColumn)
        Dim columnas As New List(Of DataGridViewColumn)()

        For Each col As DataGridViewColumn In grilla.Columns
            If col.Visible Then
                columnas.Add(col)
            End If
        Next

        Return columnas
    End Function

    Private Sub EscribeCeldaExcel(ByVal cell As IXLCell, ByVal valor As Object, ByVal columna As DataGridViewColumn)
        If valor Is Nothing OrElse valor Is DBNull.Value Then
            cell.Value = String.Empty
            Return
        End If

        If TypeOf valor Is DateTime Then
            cell.Value = DirectCast(valor, DateTime)
            cell.Style.DateFormat.Format = "dd/MM/yyyy"
            cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
            Return
        End If

        If EsNumerica(valor) Then
            cell.Value = Convert.ToDecimal(valor)
            If columna.DataPropertyName = "TotalBandejas" Then
                cell.Style.NumberFormat.Format = "#,##0.00"
            Else
                cell.Style.NumberFormat.Format = If(EsEntera(valor), "#,##0", "#,##0.00")
            End If
            cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right
            Return
        End If

        cell.Value = Convert.ToString(valor)
    End Sub

    Private Function EsNumerica(ByVal valor As Object) As Boolean
        Return TypeOf valor Is Byte OrElse TypeOf valor Is SByte OrElse TypeOf valor Is Short OrElse TypeOf valor Is UShort OrElse
               TypeOf valor Is Integer OrElse TypeOf valor Is UInteger OrElse TypeOf valor Is Long OrElse TypeOf valor Is ULong OrElse
               TypeOf valor Is Decimal OrElse TypeOf valor Is Double OrElse TypeOf valor Is Single
    End Function

    Private Function EsEntera(ByVal valor As Object) As Boolean
        Return TypeOf valor Is Byte OrElse TypeOf valor Is SByte OrElse TypeOf valor Is Short OrElse TypeOf valor Is UShort OrElse
               TypeOf valor Is Integer OrElse TypeOf valor Is UInteger OrElse TypeOf valor Is Long OrElse TypeOf valor Is ULong
    End Function
End Class
