Public Class Cotizacion_Print
    Private Sub Cotizacion_Print_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SP_CONSULTA_GUIATableAdapter.Fill(Me.GESTDataSet.SP_CONSULTA_GUIA, txtIdGuia.Text)
        Me.SP_ReporteCotizacionTableAdapter.Fill(Me.DataSet_Cotizacion.SP_ReporteCotizacion, txtIdCotizacion.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class