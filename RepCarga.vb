Public Class RepCarga

    Private Sub RepCarga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SP_RepDespachoIdDespTableAdapter.Connection.ConnectionString = gSOURCE
        Me.SP_RepDespachoIdDespTableAdapter.Fill(Me.GESTDataSetRepDesp.SP_RepDespachoIdDesp, Despacho.txtNumDesp.Text, 1)
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class