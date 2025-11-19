Public Class ReporteSiembras

    Private Sub ReporteSiembras_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.SP_ResumenReporteSiembraTableAdapter.Connection.ConnectionString = gSOURCE
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.SP_ResumenReporteSiembraTableAdapter.Fill(Me.GESTDataSet47.SP_ResumenReporteSiembra, DateTimePicker1.Value, DateTimePicker2.Value)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class