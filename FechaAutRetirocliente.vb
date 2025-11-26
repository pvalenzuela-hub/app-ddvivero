Public Class FechaAutRetirocliente
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(txtLote.Text) > 0 Then
            sSsql = ""
            If txtFechaAutorizacionCliente.Text <> Nothing Then
                sSsql = "UPDATE Pedido_Detalle set FechaAutorizacionCliente = '" & txtFechaAutorizacionCliente.Text & "' "
            End If

            If txtFechaRetiroCliente.Text <> Nothing Then
                If sSsql <> "" Then
                    sSsql += ", FechaRetiroCliente = '" & txtFechaRetiroCliente.Text & "' "
                Else
                    sSsql = "UPDATE Pedido_Detalle set FechaRetiroCliente = '" & txtFechaRetiroCliente.Text & "' "
                End If
            End If

            If sSsql <> "" Then
                sSsql += "WHERE Idpedidodet=" & txtLote.Text.ToString()
                open()
                command = connection.CreateCommand()
                command.CommandText = sSsql
                command.ExecuteNonQuery()
                close_conexion()
                Me.Close()

            End If
        Else
            MsgBox("N° Lote no válido!!!", MsgBoxStyle.Critical, "Comentario Lote")
        End If
    End Sub
End Class