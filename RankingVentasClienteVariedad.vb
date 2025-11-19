Public Class RankingVentasClienteVariedad

    Private Sub RankingVentasClienteVariedad_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet42.SP_ReporteRankingVentaClienteVariedad' Puede moverla o quitarla según sea necesario.
        Me.SP_ReporteRankingVentaClienteVariedadTableAdapter.Connection.ConnectionString = gSOURCE


        Carga_Familia_Prod(cmbSemilla)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.SP_ReporteRankingVentaClienteVariedadTableAdapter.Fill(Me.GESTDataSet42.SP_ReporteRankingVentaClienteVariedad, cmbSemilla.Text, DateDesde.Value, DateHasta.Value)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class