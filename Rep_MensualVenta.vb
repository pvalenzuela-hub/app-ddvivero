Public Class Rep_MensualVenta
    Private Sub Rep_MensualVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS_ReporteVentas.SP_ReporteVentaMensual' Puede moverla o quitarla según sea necesario.
        'Me.SP_ReporteVentaMensualTableAdapter.Fill(Me.DS_ReporteVentas.SP_ReporteVentaMensual)
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSetRepDesp.SP_RepDespachoIdDesp' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'GESTDataSetRepDesp.SP_RepDespachoIdDesp' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'GESTDataSetRepDesp.SP_ReporteVentaMensual' Puede moverla o quitarla según sea necesario.
        ' Me.SP_ReporteVentaMensualTableAdapter.Fill(Me.GESTDataSetRepDesp.SP_ReporteVentaMensual)
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSetRepDesp.SP_RepDespachoIdDesp' Puede moverla o quitarla según sea necesario.

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.SP_ReporteVentaMensualTableAdapter.Fill(Me.DS_ReporteVentas.SP_ReporteVentaMensual, Format(dtpPeriodo1.Value, "yyyyMM"), Format(dtpPeriodo2.Value, "yyyyMM"))
        'Me.SP_ReporteVentaMensualTableAdapter.Fill(Me.GESTDataSetRepDesp.SP_ReporteVentaMensual, Format(dtpPeriodo1.Value, "yyyyMM"), Format(dtpPeriodo2.Value, "yyyyMM"))
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class