Public Class ReporteLoteSinGuia

    Private Sub ReporteLoteSinGuia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SpReporteLotesSinGuia.SP_Reporte_Lot_sGuia' Puede moverla o quitarla según sea necesario.
        Me.SP_Reporte_Lot_sGuiaTableAdapter.Connection.ConnectionString = gSOURCE
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.SP_Reporte_Lot_sGuiaTableAdapter.FillLoteSinGuia(Me.SpReporteLotesSinGuia.SP_Reporte_Lot_sGuia, Format(DateTimePicker1.Value, "d"))
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class