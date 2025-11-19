Public Class Consulta_Lotes
    Private Sub Consulta_Lotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.NEWSP_CONSULTA_LOTESTableAdapter.Fill(Me.GESTDataSet.NEWSP_CONSULTA_LOTES, txtIdSemilla.Text, txtIdVariedad.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class