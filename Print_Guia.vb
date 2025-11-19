Public Class Print_Guia
    Private Sub Print_Guia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SP_EmisionGuiaDespachoTableAdapter.Fill(Me.GESTDataSet.SP_EmisionGuiaDespacho, nDespacho.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class