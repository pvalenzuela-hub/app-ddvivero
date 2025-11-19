Imports EO
Imports EO.Pdf
Public Class Visualiza_PDF
    Dim sFileName As String
    Private Sub Visualiza_PDF_Leave(sender As Object, e As EventArgs) Handles Me.Leave

        WebView2.Dispose()

    End Sub

    Private Sub Visualiza_PDF_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Select Case gQuienLlama
            Case 1
                sSsql = "SP_CONSULTA_FichaTecnicaVariedad "
                sSsql += "'" + Pedidos.cmb_Familia.Text + "',"
                sSsql += "'" + Pedidos.cmb_variedad.Text + "'"
                open()
                command = connection.CreateCommand()
                command.CommandText = sSsql
                datatbl = command.ExecuteReader()
                datatbl.Read()
                sFileName = datatbl(0)
                close_conexion()
            Case 2

                sSsql = "SP_CONSULTA_FichaTecnicaProducto "
                sSsql += gIdProd.ToString
                open()
                command = connection.CreateCommand()
                command.CommandText = sSsql
                datatbl = command.ExecuteReader()
                datatbl.Read()
                sFileName = datatbl(0)
                close_conexion()
            Case Else

        End Select
        WebView2.Url = sFileName
        'Dim doc As New PdfDocument(sFileName)
        'EO.WebBrowser.
        'WebBrowser1.Navigate(sFileName, False)

    End Sub


End Class