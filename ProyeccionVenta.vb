Public Class ProyeccionVenta

    Private Sub ProyeccionVenta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet49.SP_ReporteProyecVenta' Puede moverla o quitarla según sea necesario.
        Me.SP_ReporteProyecVentaTableAdapter.Connection.ConnectionString = gSOURCE


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.SP_ReporteProyecVentaTableAdapter.Fill(Me.GESTDataSet49.SP_ReporteProyecVenta, txtCantMeses.Value)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class