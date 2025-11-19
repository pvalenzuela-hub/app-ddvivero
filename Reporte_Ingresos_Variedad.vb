Public Class Reporte_Ingresos_Variedad

    Private Sub Reporte_Ingresos_Variedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetContaCmbte.SP_ReporteIngresosVariedad' Puede moverla o quitarla según sea necesario.

        Me.SP_ReporteIngresosVariedadTableAdapter.Connection.ConnectionString = gSOURCE
        'Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.SP_ReporteIngresosVariedadTableAdapter.Fill(Me.DataSetContaCmbte.SP_ReporteIngresosVariedad, Format(DateTimePicker1.Value, "d"), Format(DateTimePicker2.Value, "d"))
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class