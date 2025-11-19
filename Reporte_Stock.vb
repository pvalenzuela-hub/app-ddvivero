Public Class Reporte_Stock

    Private Sub Reporte_Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetReporteInventario.SP_Consulta_STOCK' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet4.SP_Consulta_STOCK' Puede moverla o quitarla según sea necesario.
        Me.SP_Consulta_STOCKTableAdapter.Connection.ConnectionString = gSOURCE

        Me.SP_Consulta_STOCKTableAdapter.Fill(Me.DataSetReporteInventario.SP_Consulta_STOCK)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class