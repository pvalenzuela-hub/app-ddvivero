Public Class AgregaComentarioLote
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(txtLote.Text) > 0 Then

            If txtNuevoComentario.Text <> Nothing Then
                Dim sComentario As String = txtNuevoComentario.Text
                sComentario = "'(" & Format(DateTime.Now, "dd/MM/yyyy") & "):" & sComentario & "'"

                sSsql = "UPDATE Pedido_Detalle set ObsDespacho = ISNULL(ObsDespacho,'') + CHAR(13) + CHAR(10) + " & sComentario
                sSsql += "WHERE Idpedidodet=" & txtLote.Text.ToString()

                open()
                command = connection.CreateCommand()
                command.CommandText = sSsql
                command.ExecuteNonQuery()
                close_conexion()
                Me.Close()
            Else
                MsgBox("Comentario retiro en blanco!!!", MsgBoxStyle.Critical, "Comentario Retiro Lote")
            End If
        Else
            MsgBox("N° Lote no válido!!!", MsgBoxStyle.Critical, "Comentario Retiro Lote")
        End If
    End Sub
End Class