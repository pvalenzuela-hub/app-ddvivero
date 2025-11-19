Public Class LotesXSembrar

    Private Sub LotesXSembrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SP_CONSULTA_LOTE_x_SEMBRARTableAdapter.Connection.ConnectionString = gSOURCE
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.SP_CONSULTA_LOTE_x_SEMBRARTableAdapter.Fill(Me.DataSetReporteInventario.SP_CONSULTA_LOTE_x_SEMBRAR, Format(DateTimePicker1.Value, "d"))
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class