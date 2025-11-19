Public Class ReporteFlujoIngresoEgresoPresupuesto

    Private Sub ReporteFlujoIngresoEgresoPresupuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet5.SP_ReporteFlujoIngresoEgresoPresupuesto' Puede moverla o quitarla según sea necesario.
        'Me.SP_ReporteFlujoIngresoEgresoPresupuestoTableAdapter.Connection.ConnectionString = gSOURCE

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Me.SP_ReporteFlujoIngresoEgresoPresupuestoTableAdapter.Fill(Me.GESTDataSet5.SP_ReporteFlujoIngresoEgresoPresupuesto, DateTimePicker1.Value)
        'Me.ReportViewer1.RefreshReport()
    End Sub
End Class