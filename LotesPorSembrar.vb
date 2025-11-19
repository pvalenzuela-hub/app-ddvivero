Public Class LotesPorSembrar
    Private Sub LotesPorSembrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EjecutaConsulta()
        Me.SP_CONSULTA_LOTE_SIN_SEMBRARTableAdapter.Fill(Me.DataSetReporteInventario.SP_CONSULTA_LOTE_SIN_SEMBRAR, dtpFechaSiembra.Value)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EjecutaConsulta()
    End Sub
End Class