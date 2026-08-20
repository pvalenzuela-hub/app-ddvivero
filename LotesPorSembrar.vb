Imports System.Collections.Generic
Imports System.Data
Imports ClosedXML.Excel
Imports System.IO

Public Class LotesPorSembrar
    Private Sub LotesPorSembrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DataGrilla.DataSource = Nothing
    End Sub

    Private Sub EjecutaConsulta()
        Dim i As Integer
        DataGrilla.Rows.Clear()

        sSsql = "SP_CONSULTA_LOTE_SIN_SEMBRAR '" & Format(dtpFechaSiembra.Value, "yyyy-MM-dd") & "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            i = 0
            While datatbl.Read = True
                DataGrilla.Rows.Add()
                DataGrilla.Rows(i).Cells(0).Value = datatbl(0)
                DataGrilla.Rows(i).Cells(1).Value = datatbl(1)
                DataGrilla.Rows(i).Cells(2).Value = datatbl(2)
                DataGrilla.Rows(i).Cells(3).Value = datatbl(3)
                DataGrilla.Rows(i).Cells(4).Value = datatbl(4)
                DataGrilla.Rows(i).Cells(5).Value = datatbl(5)
                DataGrilla.Rows(i).Cells(6).Value = datatbl(6)
                DataGrilla.Rows(i).Cells(7).Value = datatbl(7)
                DataGrilla.Rows(i).Cells(8).Value = datatbl(8)
                DataGrilla.Rows(i).Cells(9).Value = datatbl(14)
                DataGrilla.Rows(i).Cells(10).Value = datatbl(12)
                DataGrilla.Rows(i).Cells(11).Value = datatbl(13)
                i += 1
            End While
        End If
        close_conexion()
        CargarResumenBandejas()
    End Sub

    Private Sub CargarResumenBandejas()
        DataResumen.Rows.Clear()

        Dim resumen As New Dictionary(Of String, Decimal)()

        For Each fila As DataGridViewRow In DataGrilla.Rows
            If fila.IsNewRow Then
                Continue For
            End If

            Dim valorTipo = fila.Cells(8).Value
            Dim valorBandejas = fila.Cells(9).Value
            If valorTipo Is Nothing OrElse valorBandejas Is Nothing Then
                Continue For
            End If

            Dim tipo As String = valorTipo.ToString().Trim()
            If tipo = String.Empty Then
                Continue For
            End If

            Dim bandejas As Decimal = 0D
            Decimal.TryParse(valorBandejas.ToString(), bandejas)

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
                    Dim ultimaColumnaDetalle = columnasVisibles.Count
                    If columnasVisibles.Count = 0 Then
                        MessageBox.Show("No hay columnas visibles para exportar.", "Lotes por Sembrar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If

                    ConfigurarHojaReporte(ws, ultimaColumnaDetalle)
                    rutaLogoTemporal = CrearLogoTemporal()
                    If rutaLogoTemporal <> String.Empty Then
                        AgregarLogo(ws, rutaLogoTemporal)
                    End If

                    EscribirEncabezadoReporte(ws, ultimaColumnaDetalle)

                    Dim ultimaFilaDetalle = EscribirDetalle(ws, columnasVisibles)
                    EscribirResumen(ws, ultimaFilaDetalle, ultimaColumnaDetalle)

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

    Private Sub ConfigurarHojaReporte(ByVal ws As IXLWorksheet, ByVal totalColumnas As Integer)
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
        If totalColumnas >= 11 Then
            ws.Column(11).Width = 13
        End If
        If totalColumnas >= 12 Then
            ws.Column(12).Width = 18
        End If

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

    Private Sub EscribirEncabezadoReporte(ByVal ws As IXLWorksheet, ByVal totalColumnas As Integer)
        Dim columnaCheck As Integer = totalColumnas
        Dim columnaFecha As Integer = Math.Max(2, totalColumnas - 1)
        Dim columnaEtiquetaInicio As Integer = Math.Max(7, totalColumnas - 3)
        Dim columnaEtiquetaFin As Integer = Math.Max(columnaEtiquetaInicio, columnaFecha - 1)
        Dim columnaTituloFin As Integer = Math.Max(2, columnaEtiquetaInicio - 1)

        ws.Range(1, 2, 1, columnaTituloFin).Merge()
        With ws.Cell(1, 2)
            .Value = "LOTES POR SEMBRAR"
            .Style.Font.Bold = True
            .Style.Font.FontSize = 26
            .Style.Font.FontColor = XLColor.FromArgb(16, 87, 29)
            .Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left
        End With

        ws.Range(1, columnaEtiquetaInicio, 1, columnaEtiquetaFin).Merge()
        With ws.Cell(1, columnaEtiquetaInicio)
            .Value = "Hasta Fecha de Siembra:"
            .Style.Font.Bold = True
            .Style.Font.FontSize = 12
            .Style.Font.FontColor = XLColor.FromArgb(14, 46, 138)
            .Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right
        End With

        With ws.Cell(1, columnaFecha)
            .Value = dtpFechaSiembra.Value
            .Style.DateFormat.Format = "dd/MM/yyyy"
            .Style.Font.Bold = True
            .Style.Font.FontSize = 16
            .Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
            .Style.Fill.BackgroundColor = XLColor.White
            .Style.Border.OutsideBorder = XLBorderStyleValues.Thin
            .Style.Border.OutsideBorderColor = XLColor.FromArgb(125, 156, 115)
        End With

        With ws.Cell(1, columnaCheck)
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

            Case "Fecha_Entrega"
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

            Case "Aporta_Semilla"
                cell.Style.Font.Bold = True
                cell.Style.Font.FontColor = XLColor.FromArgb(18, 99, 38)
                cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center

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

    Private Sub EscribirResumen(ByVal ws As IXLWorksheet, ByVal ultimaFilaDetalle As Integer, ByVal totalColumnas As Integer)
        Dim filaTitulo As Integer = ultimaFilaDetalle + 2
        Dim filaEncabezado As Integer = filaTitulo + 1
        Dim filaDatos As Integer = filaEncabezado + 1
        Dim totalGeneral As Decimal = 0D
        Dim columnaMitad As Integer = CInt(Math.Ceiling(totalColumnas / 2D))
        Dim columnaInicioTotales As Integer = columnaMitad + 1

        ws.Range(filaTitulo, 1, filaTitulo, totalColumnas).Merge()
        With ws.Cell(filaTitulo, 1)
            .Value = "RESUMEN DE BANDEJAS NECESARIAS"
            .Style.Font.Bold = True
            .Style.Font.FontColor = XLColor.White
            .Style.Fill.BackgroundColor = XLColor.FromArgb(12, 56, 146)
            .Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left
        End With
        ws.Row(filaTitulo).Height = 20

        ws.Range(filaEncabezado, 1, filaEncabezado, columnaMitad).Merge()
        ws.Range(filaEncabezado, columnaInicioTotales, filaEncabezado, totalColumnas).Merge()

        AplicarEncabezadoResumen(ws.Cell(filaEncabezado, 1), "TIPO DE BANDEJA")
        AplicarEncabezadoResumen(ws.Cell(filaEncabezado, columnaInicioTotales), "TOTAL BANDEJAS")

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

            ws.Range(filaDatos, 1, filaDatos, columnaMitad).Merge()
            ws.Range(filaDatos, columnaInicioTotales, filaDatos, totalColumnas).Merge()

            With ws.Cell(filaDatos, 1)
                .Value = tipo
                .Style.Font.Bold = True
                .Style.Font.FontColor = XLColor.FromArgb(18, 51, 133)
                .Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                .Style.Border.OutsideBorder = XLBorderStyleValues.Thin
                .Style.Border.OutsideBorderColor = XLColor.FromArgb(212, 222, 243)
            End With

            With ws.Cell(filaDatos, columnaInicioTotales)
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

        ws.Range(filaDatos, 1, filaDatos, columnaMitad).Merge()
        ws.Range(filaDatos, columnaInicioTotales, filaDatos, totalColumnas).Merge()

        With ws.Cell(filaDatos, 1)
            .Value = "TOTAL GENERAL"
            .Style.Font.Bold = True
            .Style.Font.FontColor = XLColor.FromArgb(18, 51, 133)
            .Style.Fill.BackgroundColor = XLColor.FromArgb(237, 243, 252)
            .Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
            .Style.Border.OutsideBorder = XLBorderStyleValues.Thin
            .Style.Border.OutsideBorderColor = XLColor.FromArgb(186, 203, 236)
        End With

        With ws.Cell(filaDatos, columnaInicioTotales)
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
            Case "Fecha_Entrega"
                Return "FEC." & vbLf & "SOLICITADA" & vbLf & "CLIENTE"
            Case "CANTIDAD"
                Return "CANTIDAD"
            Case "Tipo"
                Return "TIPO"
            Case "TotalBandejas"
                Return "TOTAL" & vbLf & "BANDEJAS"
            Case "Aporta_Semilla"
                Return "APORTA" & vbLf & "SEMILLA S/N"
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
