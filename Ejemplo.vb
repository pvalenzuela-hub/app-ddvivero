Imports System
Public Class Ejemplo

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Dim lineHeight As Single
        'Dim yPos As Single = e.MarginBounds.Top
        'Dim leftMargin As Single = e.MarginBounds.Left

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        'PrintForm1.Print()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'PrintDialog1.ShowDialog()
    End Sub
    Private Sub VistaPrevia(ByVal TipoFuente As String, ByVal TamañoFuente As Byte, _
ByVal TextoImpresion As String, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        Dim Fuente As New Font(TipoFuente, TamañoFuente)
        Dim AreaImpresion_Alto, AreaImpresion_Ancho, MargenIzquierdo, MargenSuperior As Integer

        With Me.PrintDocument1.DefaultPageSettings
            'Area Neta de Impresion (se descuenta los margenes)
            AreaImpresion_Alto = .PaperSize.Height - .Margins.Top - .Margins.Bottom
            AreaImpresion_Ancho = .PaperSize.Width - .Margins.Left - .Margins.Right
            MargenIzquierdo = .Margins.Left
            MargenSuperior = .Margins.Top

            'Verificar si se ha elegido el modo horizontal
            If .Landscape Then
                Dim NroTemp As Integer
                NroTemp = AreaImpresion_Alto
                AreaImpresion_Alto = AreaImpresion_Ancho
                AreaImpresion_Ancho = NroTemp
            End If
            Dim Formato As New StringFormat(StringFormatFlags.LineLimit)
            Dim Rectangulo As New RectangleF(MargenIzquierdo, MargenSuperior, _
            AreaImpresion_Ancho, AreaImpresion_Alto)
            Dim NroLineasImpresion As Integer = CInt(AreaImpresion_Alto / Fuente.Height)
            Dim NroLineasRelleno, NroLetrasLinea As Integer
            Static CaracterActual As Integer

            e.Graphics.MeasureString(Mid(Me.txt_texto.Text, +1), Fuente, _
            New SizeF(AreaImpresion_Ancho, AreaImpresion_Alto), Formato, NroLetrasLinea, _
            NroLineasRelleno)
            e.Graphics.DrawString(Mid(TextoImpresion, CaracterActual + 1), Fuente, _
            Brushes.Black, Rectangulo, Formato)

            e.Graphics.DrawString("PEDIDO CLIENTE: " + txt_Cliente.Text, Fuente, _
            Brushes.Black, Rectangulo, Formato)

            CaracterActual += NroLetrasLinea
            If CaracterActual < TextoImpresion.Length Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
                CaracterActual = 0
            End If
        End With

    End Sub


    'PrintDocument.PrintPage (Evento): Se produce cuando se necesita el 
    'resultado que se va a imprimir para la página actual.

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, _
    ByVal e As System.Drawing.Printing.PrintPageEventArgs) _
    Handles PrintDocument1.PrintPage

        'VistaPrevia("Arial", 12, Me.txt_texto.Text, e)

    End Sub
    'Es aquí donde se pone en marcha la impresión del documento.
    Private Sub ImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub
End Class