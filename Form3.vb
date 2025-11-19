Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet36.SP_ReporteMovDiario' Puede moverla o quitarla según sea necesario.
        'Me.SP_ReporteMovDiarioTableAdapter.Fill(Me.GESTDataSet36.SP_ReporteMovDiario)
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet37.SP_ReporteEgresoCtaActivo' Puede moverla o quitarla según sea necesario.
        'Me.SP_ReporteEgresoCtaActivoTableAdapter.Fill(Me.GESTDataSet37.SP_ReporteEgresoCtaActivo)
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet36.SP_Reporte_Resumen_Diario' Puede moverla o quitarla según sea necesario.
        'Me.SP_Reporte_Resumen_DiarioTableAdapter.Fill(Me.GESTDataSet36.SP_Reporte_Resumen_Diario)
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet36.SP_ReporteMovDiario' Puede moverla o quitarla según sea necesario.
        'Me.SP_ReporteMovDiarioTableAdapter.Fill(Me.GESTDataSet36.SP_ReporteMovDiario)
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet37.SP_ReporteEgresoCtaActivo' Puede moverla o quitarla según sea necesario.
        'Me.SP_ReporteEgresoCtaActivoTableAdapter.Fill(Me.GESTDataSet37.SP_ReporteEgresoCtaActivo)
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet36.SP_ReporteMovDiario' Puede moverla o quitarla según sea necesario.


        Me.SP_ReporteMovDiarioTableAdapter.Connection.ConnectionString = gSOURCE
        Me.SP_ReporteEgresoCtaActivoTableAdapter.Connection.ConnectionString = gSOURCE
        'Me.SP_ReporteMovDiarioTableAdapter.Fill(Me.GESTDataSet36.SP_ReporteMovDiario, DateTimePicker1.Value.Date)

        'Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.SP_ReporteMovDiarioTableAdapter.Fill(Me.GESTDataSet36.SP_ReporteMovDiario, DateTimePicker1.Value.Date)
        Me.SP_ReporteEgresoCtaActivoTableAdapter.Fill(Me.GESTDataSet37.SP_ReporteEgresoCtaActivo, DateTimePicker1.Value)
        Me.SP_Reporte_Resumen_DiarioTableAdapter.Fill(Me.GESTDataSet36.SP_Reporte_Resumen_Diario, DateTimePicker1.Value)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class