Public Class ReporteComisionVentas

    Private Sub ReporteComisionVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet39.SP_ReporteComisionVentas' Puede moverla o quitarla según sea necesario.
        'Me.SP_ReporteComisionVentasTableAdapter.Fill(Me.GESTDataSet39.SP_ReporteComisionVentas)
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet39.SP_ReporteComisionVentas' Puede moverla o quitarla según sea necesario.
        ' Me.SP_ReporteComisionVentasTableAdapter.Fill(Me.GESTDataSet39.SP_ReporteComisionVentas)
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet38.SP_ReporteComisionVentas' Puede moverla o quitarla según sea necesario.
        'Me.SP_ReporteComisionVentasTableAdapter.Fill(Me.GESTDataSet38.SP_ReporteComisionVentas)
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet27.SP_ReporteComisionVentas' Puede moverla o quitarla según sea necesario.

        Carga_lista_Vendedor(cmbVendedor)

        Me.SP_ReporteComisionVentasTableAdapter.Connection.ConnectionString = gSOURCE
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Me.SP_ReporteComisionVentasTableAdapter.Fill(Me.GESTDataSet27.SP_ReporteComisionVentas, DateTimePicker1.Value, DateTimePicker2.Value)
        ' Me.SP_ReporteComisionVentasTableAdapter.Fill(Me.GESTDataSet38.SP_ReporteComisionVentas, DateTimePicker1.Value, DateTimePicker2.Value)
        If cmbVendedor.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Vendedor", MsgBoxStyle.Critical, "Reporte de Comisiones")
            Exit Sub
        End If

        Me.SP_ReporteComisionVentasTableAdapter.Fill(Me.GESTDataSet39.SP_ReporteComisionVentas, DateTimePicker1.Value, DateTimePicker2.Value, cmbVendedor.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class