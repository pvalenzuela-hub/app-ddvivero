Public Class ReporteVencimientosProveedor
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub ReporteVencimientosProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetCompras.SP_CONSULTA_Vencto_Doc_Compra' Puede moverla o quitarla según sea necesario.
        '        Me.SP_CONSULTA_Vencto_Doc_CompraTableAdapter.Fill(Me.DataSetCompras.SP_CONSULTA_Vencto_Doc_Compra)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.SP_CONSULTA_Vencto_Doc_CompraTableAdapter.Fill(Me.DataSetCompras.SP_CONSULTA_Vencto_Doc_Compra, dtp_Vencimiento.Value)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class