Public Class Imprime_Cartola_Cliente
    Private Sub Imprime_Cartola_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet.SP_CONSULTA_CLIENTE_IDcliente' Puede moverla o quitarla según sea necesario.
        Me.SP_CONSULTA_CLIENTE_IDclienteTableAdapter.Fill(Me.GESTDataSet.SP_CONSULTA_CLIENTE_IDcliente, gIDCliente.ToString())
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet.SP_Cartola_Cliente_IdCliente' Puede moverla o quitarla según sea necesario.
        Me.SP_Cartola_Cliente_IdClienteTableAdapter.Fill(Me.GESTDataSet.SP_Cartola_Cliente_IdCliente, gIDCliente.ToString())
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet.SP_Cartola_Cliente_DocXcobrar_IdCLiente' Puede moverla o quitarla según sea necesario.
        Me.SP_Cartola_Cliente_DocXcobrar_IdCLienteTableAdapter.Fill(Me.GESTDataSet.SP_Cartola_Cliente_DocXcobrar_IdCLiente, gIDCliente.ToString())
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet.SP_Consulta_Resumen_Deuda_Cliente_IdCliente' Puede moverla o quitarla según sea necesario.
        Me.SP_Consulta_Resumen_Deuda_Cliente_IdClienteTableAdapter.Fill(Me.GESTDataSet.SP_Consulta_Resumen_Deuda_Cliente_IdCliente, gIDCliente.ToString())

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class