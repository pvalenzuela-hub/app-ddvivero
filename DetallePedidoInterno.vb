Public Class DetallePedidoInterno
    Private Sub DetallePedidoInterno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet.SP_CONSULTA_PEDIDO' Puede moverla o quitarla según sea necesario.
        Me.SP_CONSULTA_PEDIDOTableAdapter.Fill(Me.GESTDataSet.SP_CONSULTA_PEDIDO, gNumPedido)
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet.SP_CONSULTA_PEDIDO_DETALLE' Puede moverla o quitarla según sea necesario.
        Me.SP_CONSULTA_PEDIDO_DETALLETableAdapter.Fill(Me.GESTDataSet.SP_CONSULTA_PEDIDO_DETALLE, gNumPedido)
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet.SYS_INI' Puede moverla o quitarla según sea necesario.
        Me.SYS_INITableAdapter.Fill(Me.GESTDataSet.SYS_INI)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class