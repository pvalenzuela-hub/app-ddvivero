Public Class ActualizaPrecioLote
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txtNuevoPrecioIVA_TextChanged(sender As Object, e As EventArgs) Handles txtNuevoPrecioIVA.TextChanged
        Dim NuevoPrecioNeto As Decimal
        If Val(txtNuevoPrecioIVA.Text) > 0 Then
            NuevoPrecioNeto = Math.Round(txtNuevoPrecioIVA.Text / 1.19, 2)
            txtNuevoPrecioNeto.Text = Format(NuevoPrecioNeto, "###0.0000")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(txtLote.Text) > 0 Then
            sSsql = "[vivero].[SP_ActualizaPrecioLote] "
            sSsql += txtLote.Text.ToString() + ","
            sSsql += txtNuevoPrecioNeto.Text.ToString() + ","
            sSsql += "'" + gUSER + "'"
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            command.ExecuteNonQuery()
            close_conexion()
            Me.Close()
        Else
            MsgBox("N° Lote no es válido", MsgBoxStyle.Critical, "Modifica Preio Lote")
        End If
    End Sub
End Class