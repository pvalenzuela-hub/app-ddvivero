Public Class ReporteStockSemilla

  

    Private Sub ReporteStockSemilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet40.SP_Reporte_Stock_Semilla' Puede moverla o quitarla según sea necesario.

        Me.SP_Reporte_Stock_SemillaTableAdapter.Connection.ConnectionString = gSOURCE
        Me.SP_Reporte_Stock_SemillaTableAdapter.Fill(Me.GESTDataSet40.SP_Reporte_Stock_Semilla)
        Me.ReportViewer1.RefreshReport()
    End Sub



End Class