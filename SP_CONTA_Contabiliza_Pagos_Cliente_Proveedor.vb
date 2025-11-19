Public Class SP_CONTA_Contabiliza_Pagos_Cliente_Proveedor

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Proceso_Pago_Proveedores()
        Proceso_Pago_Clientes()
        MsgBox("Fin Proceso de Actualización.")
        Me.Close()
    End Sub
    Private Sub Proceso_Pago_Clientes()
      
        sSsql = "SP_CONTA_Contabiliza_Pagos_Cliente"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()
        close_conexion()
    End Sub
    Private Sub Proceso_Pago_Proveedores()

        sSsql = "SP_CONTA_Contabiliza_Pagos_Proveedor"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()
        close_conexion()
    End Sub
        
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class