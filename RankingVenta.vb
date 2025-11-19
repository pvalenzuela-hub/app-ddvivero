Public Class RankingVenta

    Private Sub RankingVenta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet41.SP_ReporteRankingVentaCliente' Puede moverla o quitarla según sea necesario.
        Me.SP_ReporteRankingVentaClienteTableAdapter.Connection.ConnectionString = gSOURCE
        Carga_Familia_Prod(cmbSemilla)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Me.SP_ReporteRankingVentaClienteTableAdapter.Fill(Me.GESTDataSet41.SP_ReporteRankingVentaCliente, cmbSemilla.Text, DateDesde.Value, DateHasta.Value)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        cmbSemilla.SelectedIndex = -1
        DateDesde.Value = Now
        DateHasta.Value = Now
    End Sub
End Class