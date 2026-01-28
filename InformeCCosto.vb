Public Class InformeCCosto
    Private Sub InformeCCosto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetContaCmbte.CONTA_SPConsultaCCosto' Puede moverla o quitarla según sea necesario.
        Me.CONTA_SPConsultaCCostoTableAdapter.Fill(Me.DataSetContaCmbte.CONTA_SPConsultaCCosto)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class