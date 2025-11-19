Imports System
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms
Imports System.Drawing.Graphics
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices

Public Class NotaDePedido
    Inherits System.Windows.Forms.Form
    Private printButton As System.Windows.Forms.Button
    Private printFont As Font
    Private streamToPrint As StreamReader
    Private Lotes As New DataTable("Detalle")

    ' Declare the dialog.
    'Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    ' Declare a PrintDocument object named document.
    Private WithEvents documento As New System.Drawing.Printing.PrintDocument


    Private Sub NotaDePedido_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Crea_Tabla()
        'Dim i As Integer
        Me.txt_NumeroPedido.Text = Pedidos.cmb_Pedido.Text
        Me.txt_Cliente.Text = Pedidos.txt_NombreCliente.Text

        '        For i = 0 To Pedidos.DataGrilla.RowCount - 1
        'dr = Lotes.NewRow()
        'dr(0) = Pedidos.aCol00(i)
        'dr(1) = Pedidos.aCol01(i)
        'dr(2) = Pedidos.aCol02(i)
        'dr(3) = Pedidos.aCol03(i)
        ''dr(4) = Pedidos.aCol04(i)
        'dr(4) = Pedidos.aCol05(i)
        'dr(5) = Pedidos.aCol06(i)
        'dr(6) = Pedidos.aCol07(i)
        'dr(7) = Pedidos.aCol08(i)
        'dr(8) = Pedidos.aCol09(i)
        'dr(10) = Pedidos.aCol10(i)
        'Lotes.Rows.Add(dr)
        'Next
    End Sub
    Private Sub Crea_Tabla()
        Dim style As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim dc0 As New DataColumn("Lote", System.Type.GetType("System.Double"))
        Dim dc1 As New DataColumn("Fec.Ini", System.Type.GetType("System.String"))
        Dim dc2 As New DataColumn("Fec.Ent", System.Type.GetType("System.String"))
        Dim dc3 As New DataColumn("Band", System.Type.GetType("System.Double"))
        Dim dc4 As New DataColumn("Descripción", System.Type.GetType("System.String"))
        Dim dc5 As New DataColumn("Cant", System.Type.GetType("System.Decimal"))
        Dim dc6 As New DataColumn("Precio", System.Type.GetType("System.Decimal"))
        Dim dc7 As New DataColumn("Total", System.Type.GetType("System.Decimal"))
        Dim dc8 As New DataColumn("Tipo Band", System.Type.GetType("System.String"))


        With Lotes.Columns
            .Add(dc0)
            .Add(dc1)
            .Add(dc2)
            .Add(dc3)
            .Add(dc4)
            .Add(dc5)
            .Add(dc6)
            .Add(dc7)
            .Add(dc8)
        End With
        style.Alignment = DataGridViewContentAlignment.BottomRight
        style.ForeColor = Color.Black
        style.BackColor = Color.White
        style.SelectionBackColor = Color.LightBlue
        style.SelectionForeColor = Color.Black

        For Each column As DataGridViewColumn In DataGrilla.Columns
            column.DataGridView.RowsDefaultCellStyle = style
        Next

        DataGrilla.DataSource = Lotes

    End Sub

    Private Sub PrevisualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrevisualizarToolStripMenuItem.Click
        ' Set the PrintPreviewDialog.Document property to
        ' the PrintDocument object selected by the user.

        'PrintPreviewDialog1.Document = documento

        ' Call the ShowDialog method. This will trigger the document's
        '  PrintPage event.

        'PrintDialog1.ShowDialog()

        ' PrintNotaPedido.PrintAction = Printing.PrintAction.PrintToPreview
        'PrintNotaPedido.PrinterSettings.Copies = 2
        'PrintNotaPedido.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.CompatibleModeClientAreaOnly)
        'PrintNotaPedido.PrinterSettings
        'PrintNotaPedido.Print()
        'Dim previewDialog As PrintPreviewDialog
        'previewDialog = New PrintPreviewDialog
        'previewDialog.WindowState = FormWindowState.Maximized
        'previewDialog.PrintPreviewControl.StartPage = 0
        'previewDialog.PrintPreviewControl.Zoom = 1.0
        'PrintPreviewDialog1.PrintPreviewControl.StartPage = 0
        ' display the document two pages at a time
        'PrintPreviewDialog1.PrintPreviewControl.Columns = 2
        ' maximize the size of the dialog box on the display screen
        'PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        ' display the contents of the appropriate print document
        'PrintPreviewDialog1.Document = PrintDocument1
        'PrintPreviewDialog1.ShowDialog()
        'previewDialog.Document = PrintDocument1
        'previewDialog.ShowDialog()
    End Sub

    Private Sub document_PrintPage(ByVal sender As Object, _
    ByVal e As System.Drawing.Printing.PrintPageEventArgs) _
        Handles documento.PrintPage

        ' Insert code to render the page here.
        ' This code will be called when the PrintPreviewDialog.Show 
        ' method is called.

        ' The following code will render a simple
        ' message on the document in the dialog.
        Dim text As String = "In document_PrintPage method."
        Dim printFont As New System.Drawing.Font _
            ("Arial", 35, System.Drawing.FontStyle.Regular)

        e.Graphics.DrawString(text, printFont, _
            System.Drawing.Brushes.Black, 0, 0)

    End Sub


    Private Sub ImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
        Imprime_Doc()
    End Sub
  
    Private Sub OnPrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim hwndForm As IntPtr
        hwndForm = Me.Handle

        Dim hdcDIBSection As IntPtr
        Dim hdcRef As IntPtr
        Dim hbmDIBSection As IntPtr
        Dim hbmDIBSectionOld As IntPtr
        Dim BMPheader As Win32APICall.BITMAPINFOHEADER

        Dim leftMargin As Single = e.MarginBounds.Left
        Dim topMargin As Single = e.MarginBounds.Top
        Dim rightMargin As Single = e.MarginBounds.Right
        Dim bottomMargin As Single = e.MarginBounds.Bottom

        hdcRef = Win32APICall.GetDC(IntPtr.Zero)
        hdcDIBSection = Win32APICall.CreateCompatibleDC(hdcRef)
        Win32APICall.ReleaseDC(IntPtr.Zero, hdcRef)

        leftMargin = 0
        rightMargin = 0
        topMargin = 0
        bottomMargin = 0



        BMPheader.biBitCount = 24
        BMPheader.biClrImportant = 0
        BMPheader.biClrUsed = 0
        BMPheader.biCompression = Win32APICall.BI_RGB
        BMPheader.biSize = 40
        BMPheader.biHeight = Me.Height
        BMPheader.biPlanes = 1
        BMPheader.biSizeImage = 0
        BMPheader.biWidth = Me.Width
        BMPheader.biXPelsPerMeter = 0
        BMPheader.biYPelsPerMeter = 0

        hbmDIBSection = Win32APICall.CreateDIBSection(hdcDIBSection, BMPheader, Win32APICall.DIB_RGB_COLORS, _
        IntPtr.Zero, IntPtr.Zero, 0)

        hbmDIBSectionOld = Win32APICall.SelectObject(hdcDIBSection, hbmDIBSection)
        Win32APICall.PatBlt(hdcDIBSection, 0, 0, Me.Width, Me.Height, Win32APICall.WHITENESS)
        Win32APICall.PrintWindow(hwndForm, hdcDIBSection, 0)
        Win32APICall.SelectObject(hdcDIBSection, hbmDIBSectionOld)

        Dim imageFrm As Bitmap
        imageFrm = Image.FromHbitmap(hbmDIBSection)
        e.Graphics.DrawImage(imageFrm, 0, 0)

        Win32APICall.DeleteDC(hdcDIBSection)
        Win32APICall.DeleteObject(hbmDIBSection)



    End Sub

    Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim linesPerPage As Single = 0
        Dim yPos As Single = 0
        Dim count As Integer = 0
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim rightMargin As Single = ev.MarginBounds.Right
        Dim bottomMargin As Single = ev.MarginBounds.Bottom
        Dim line As String = Nothing
        Dim size As Rectangle = ev.MarginBounds

        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        leftMargin = 0
        rightMargin = 0
        topMargin = 0
        bottomMargin = 0

        ' Print each line of the file.
        While count < linesPerPage
            line = streamToPrint.ReadLine()
            If line Is Nothing Then
                Exit While
            End If
            yPos = topMargin + count * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, New StringFormat())
            count += 1
        End While

        ' If more lines exist, print another page.
        If (line IsNot Nothing) Then
            ev.HasMorePages = True
        Else
            ev.HasMorePages = False
        End If
    End Sub



    Private Sub Imprime_Doc()
        Dim Reporte_Pedido As New CR_Pedido
        Dim crystalmargen As CrystalDecisions.Shared.PageMargins
        Dim parmValue As New CrystalDecisions.Shared.ParameterDiscreteValue

        Dim parmfields As CrystalDecisions.Shared.ParameterFields = CrystalReportViewer1.ParameterFieldInfo
        Dim parmfield As New CrystalDecisions.Shared.ParameterField()
        Dim iNumPedido As Integer

        iNumPedido = Val(txt_NumeroPedido.Text)

        crystalmargen.leftMargin = 0
        crystalmargen.rightMargin = 0

        '        Reporte_Pedido.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape

        '       Reporte_Pedido.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter

        '      Reporte_Pedido.PrintOptions.ApplyPageMargins(crystalmargen)

        '     Reporte_Pedido.PrintOptions.PrinterName = "CutePDF Writer"

        'Reporte_Pedido.ParameterFields.Add(iNumPedido)
        'Reporte_Pedido.Parameter_gNumPedido.DefaultValues.Add(iNumPedido)


        'Reporte_Pedido.ParameterFields.Add("iNumPedido", CrystalDecisions.Shared.ParameterValueKind.NumberParameter, CrystalDecisions.Shared.DiscreteOrRangeKind.DiscreteValue, "CR_Pedido")
        parmValue.Value = iNumPedido
        parmfield.Name = "gNumPedido"
        parmfield.CurrentValues.Add(parmValue)
        parmfields.Add(parmfield)
        CrystalReportViewer1.ParameterFieldInfo = parmfields
        'Reporte_Pedido.PrintToPrinter(1, 0, 1, 1)
  
    End Sub


End Class
Public Class Win32APICall

    Public Const DIB_RGB_COLORS = 0
    Public Const BI_RGB = 0
    Public Const WHITENESS = 16711778

    <DllImport("user32.dll", EntryPoint:="PrintWindow", _
    SetLastError:=True, CharSet:=CharSet.Unicode, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function PrintWindow(ByVal hWnd As IntPtr, ByVal hDC As IntPtr, ByVal dwFlags As Integer) As UInt32
    End Function

    <StructLayout(LayoutKind.Sequential, pack:=8, CharSet:=CharSet.Auto)> _
    Structure BITMAPINFOHEADER
        Dim biSize As Int32
        Dim biWidth As Int32
        Dim biHeight As Int32
        Dim biPlanes As Int16
        Dim biBitCount As Int16
        Dim biCompression As Int32
        Dim biSizeImage As Int32
        Dim biXPelsPerMeter As Int32
        Dim biYPelsPerMeter As Int32
        Dim biClrUsed As Int32
        Dim biClrImportant As Int32
    End Structure

    <DllImport("gdi32.dll", EntryPoint:="CreateDIBSection", _
    SetLastError:=True, CharSet:=CharSet.Unicode, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function CreateDIBSection(ByVal hdc As IntPtr, ByRef pbmi As BITMAPINFOHEADER, _
    ByVal iUsage As Int32, ByVal ppvBits As IntPtr, ByVal hSection As IntPtr, _
    ByVal dwOffset As Int32) As IntPtr
    End Function

    <DllImport("gdi32.dll", EntryPoint:="PatBlt", _
    SetLastError:=True, CharSet:=CharSet.Unicode, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function PatBlt(ByVal hDC As IntPtr, ByVal nXLeft As Int32, _
        ByVal nYLeft As Int32, ByVal nWidth As Int32, ByVal nHeight As Int32, _
        ByVal dwRop As Int32) As Boolean
    End Function

    <DllImport("gdi32.dll", EntryPoint:="SelectObject", _
    SetLastError:=True, CharSet:=CharSet.Unicode, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function SelectObject(ByVal hDC As IntPtr, ByVal hObj As IntPtr) As IntPtr
    End Function

    <DllImport("GDI32.dll", EntryPoint:="CreateCompatibleDC", SetLastError:=True, CharSet:=CharSet.Unicode, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function CreateCompatibleDC(ByVal hRefDC As IntPtr) As IntPtr
    End Function

    <DllImport("GDI32.dll", EntryPoint:="DeleteDC", SetLastError:=True, CharSet:=CharSet.Unicode, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function DeleteDC(ByVal hDC As IntPtr) As Boolean
    End Function

    <DllImport("GDI32.dll", EntryPoint:="DeleteObject", SetLastError:=True, CharSet:=CharSet.Unicode, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function DeleteObject(ByVal hObj As IntPtr) As Boolean
    End Function

    <DllImport("User32.dll", EntryPoint:="ReleaseDC", SetLastError:=True, CharSet:=CharSet.Unicode, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function ReleaseDC(ByVal hWnd As IntPtr, ByVal hDC As IntPtr) As Boolean
    End Function

    <DllImport("User32.dll", EntryPoint:="GetDC", SetLastError:=True, CharSet:=CharSet.Unicode, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function GetDC(ByVal hWnd As IntPtr) As IntPtr
    End Function


End Class