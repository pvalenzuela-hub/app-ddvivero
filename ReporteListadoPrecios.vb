Public Class ReporteListadoPrecios

    Private Sub ReporteListadoPrecios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet24.SP_ReporteListadoPrecioVenta' Puede moverla o quitarla según sea necesario.
        Me.SP_ReporteListadoPrecioVentaTableAdapter.Connection.ConnectionString = gSOURCE

        Me.SP_ReporteListadoPrecioVentaTableAdapter.Fill(Me.GESTDataSet24.SP_ReporteListadoPrecioVenta)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class