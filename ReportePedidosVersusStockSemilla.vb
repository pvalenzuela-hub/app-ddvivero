Public Class ReportePedidosVersusStockSemilla

    Private Sub ReportePedidosVersusStockSemilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet23.SP_ReportePedidosVSStockVariedad' Puede moverla o quitarla según sea necesario.
        Me.SP_ReportePedidosVSStockVariedadTableAdapter.Connection.ConnectionString = gSOURCE
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.SP_ReportePedidosVSStockVariedadTableAdapter.Fill(Me.GESTDataSet23.SP_ReportePedidosVSStockVariedad, DateTimePicker1.Value, DateTimePicker2.Value)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class