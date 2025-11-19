Public Class ClienteBloqueado

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bControl As Boolean = True
        If Not txtPassword.Text = gClaveBloqueo Then
            bControl = False
        End If

        Select Case gQuienLlama
            Case 1

            Case 2
                If Not bControl Then
                    Pedidos.txtEstadoclienteId.Clear()
                    Pedidos.txt_RUT_CLI.Clear()
                    Pedidos.txt_NombreCliente.Clear()
                    Pedidos.txtNotas.Clear()
                    gSectorDireccion = Nothing
                    Pedidos.txt_clientebuscar.Clear()
                    Pedidos.txt_IDCliente.Clear()

                    If Not bControl Then
                        MsgBox("No es posible generar Pedidos al cliente seleccionado!!", MsgBoxStyle.Critical, "Cliente Bloqueado")
                    End If

                End If
            Case Else
        End Select
        Me.Close()
    End Sub
End Class