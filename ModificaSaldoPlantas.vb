Public Class ModificaSaldoPlantas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(txtLote.Text) > 0 Then
            sSsql = "[vivero].[SP_ActualizaNuevoSaldoPlantas] "
            sSsql += txtLote.Text.ToString() + ","
            sSsql += txtNuevoSaldoPlantas.Text.ToString() + ","
            sSsql += "'" + gUSER + "'"
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            command.ExecuteNonQuery()
            close_conexion()
            Me.Close()
        Else
            MsgBox("N° Lote no es válido", MsgBoxStyle.Critical, "Modifica Saldo Plantas")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class