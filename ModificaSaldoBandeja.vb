Public Class ModificaSaldoBandeja
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Val(txtLote.Text) > 0 Then
            sSsql = "[vivero].[SP_ActualizaNuevoSaldoBandejas] "
            sSsql += txtLote.Text.ToString() & ","
            sSsql += txtNuevoSaldoBandejas.Text.ToString() + ","
            sSsql += "'" & gUSER & "'"
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            command.ExecuteNonQuery()
            close_conexion()
            Me.Close()
        Else
            MsgBox("N° Lote no es válido", MsgBoxStyle.Critical, "Modifica Saldo Bandejas")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class