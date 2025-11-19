Imports Microsoft.Reporting.WinForms
Public Class LotesParaConteo
    Private Sub LotesParaConteo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet.SP_CONSULTALoteparaConteo' Puede moverla o quitarla según sea necesario.
        Me.SP_CONSULTALoteparaConteoTableAdapter.Fill(Me.GESTDataSet.SP_CONSULTALoteparaConteo)

        Dim rds1 As New ReportDataSource("DataSet1", Me.SP_CONSULTALoteparaConteoBindingSource)

        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(rds1)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class