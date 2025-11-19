Public Class REP_CostoMOmes

    Private Sub REP_CostoMOmes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet28.SP_ReporteCostoMOMensual' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet28.SP_ReporteCostoMOMensual' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'DataSetContaCmbte.SP_ReporteCostoMOMensual' Puede moverla o quitarla según sea necesario.
        'Me.SP_ReporteCostoMOMensualTableAdapter.Fill(Me.DataSetContaCmbte.SP_ReporteCostoMOMensual)
        'TODO: esta línea de código carga datos en la tabla 'DataSetPlantaEntregada.SP_ReporteCostoMOMensual' Puede moverla o quitarla según sea necesario.
        'Me.SP_ReporteCostoMOMensualTableAdapter.Fill(Me.DataSetPlantaEntregada.SP_ReporteCostoMOMensual)
        'TODO: esta línea de código carga datos en la tabla 'DataSetPlantaEntregada.SP_ReporteCostoMOMensual' Puede moverla o quitarla según sea necesario.
        
        ' Me.SP_ReporteCostoMOMensualTableAdapter.Connection.ConnectionString = gSOURCE

        Me.SP_ReporteCostoMOMensualTableAdapter.Connection.ConnectionString = gSOURCE

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Me.SP_ReporteCostoMOMensualTableAdapter.Fill(Me.DataSetPlantaEntregada.SP_ReporteCostoMOMensual, Format(DateTimePicker1.Value, "d"), Format(DateTimePicker2.Value, "d"))
        '        Me.SP_ReporteCostoMOMensualTableAdapter.Fill(Me.DataSetPlantaEntregada.SP_ReporteCostoMOMensual, Format(DateTimePicker1.Value, "d"), Format(DateTimePicker2.Value, "d"))



        Me.SP_ReporteCostoMOMensualTableAdapter.Fill(Me.GESTDataSet28.SP_ReporteCostoMOMensual, Format(DateTimePicker1.Value, "d"), Format(DateTimePicker2.Value, "d"))

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class