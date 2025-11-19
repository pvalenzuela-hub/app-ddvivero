Public Class ImpresionDocVenta
    Private Sub ImpresionDocVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataVentas.SP_Lectura_Enc_Factura' Puede moverla o quitarla según sea necesario.
        Me.SP_Lectura_Enc_FacturaTableAdapter.Fill(Me.DataVentas.SP_Lectura_Enc_Factura, idvtahead.Text)
        'TODO: esta línea de código carga datos en la tabla 'DataVentas.SP_Lectura_Det_Factura' Puede moverla o quitarla según sea necesario.
        Me.SP_Lectura_Det_FacturaTableAdapter.Fill(Me.DataVentas.SP_Lectura_Det_Factura, idvtahead.Text)


        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class