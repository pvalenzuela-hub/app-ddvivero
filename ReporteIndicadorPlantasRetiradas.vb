Public Class ReporteIndicadorPlantasRetiradas

    Private Sub ReporteIndicadorPlantasRetiradas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet19.SP_ReporteIndicadorPlantasRetiradas1' Puede moverla o quitarla según sea necesario.
        'Me.SP_ReporteIndicadorPlantasRetiradas1TableAdapter.Fill(Me.GESTDataSet19.SP_ReporteIndicadorPlantasRetiradas1)
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet19.SP_ReporteIndicadorPlantasRetiradas1' Puede moverla o quitarla según sea necesario.
        'Me.SP_ReporteIndicadorPlantasRetiradas1TableAdapter.Fill(Me.GESTDataSet19.SP_ReporteIndicadorPlantasRetiradas1)
        ''TODO: esta línea de código carga datos en la tabla 'GESTDataSet19.SP_ReporteIndicadorPlantasRetiradas1' Puede moverla o quitarla según sea necesario.
        'Me.SP_ReporteIndicadorPlantasRetiradas1TableAdapter.Fill(Me.GESTDataSet19.SP_ReporteIndicadorPlantasRetiradas1)
        ''TODO: esta línea de código carga datos en la tabla 'GESTDataSet19.SP_ReporteIndicadorPlantasRetiradas1' Puede moverla o quitarla según sea necesario.
        'Me.SP_ReporteIndicadorPlantasRetiradas1TableAdapter.Fill(Me.GESTDataSet19.SP_ReporteIndicadorPlantasRetiradas1)

        'Me.SP_ReporteIndicadorPlantasRetiradasTableAdapter.Connection.ConnectionString = gSOURCE
        

        Me.SP_ReporteIndicadorPlantasRetiradas1TableAdapter.Connection.ConnectionString = gSOURCE
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.SP_ReporteIndicadorPlantasRetiradas1TableAdapter.Fill(Me.GESTDataSet19.SP_ReporteIndicadorPlantasRetiradas1, DateTimePicker1.Value, DateTimePicker2.Value)

        Me.ReportViewer1.RefreshReport()
    End Sub

 
End Class