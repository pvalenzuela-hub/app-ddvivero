Public Class Print_Guia_Individual
    Private Sub Print_Guia_Individual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SP_CONSULTA_GUIATableAdapter.Fill(Me.GESTDataSet.SP_CONSULTA_GUIA, NumGuia.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class