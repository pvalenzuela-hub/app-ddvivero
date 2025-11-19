Public Class ModificaFechaEntrega
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpNuevaFechaSiembra.ValueChanged
        dtpNuevaFechaEntrega.Value = DateAdd(DateInterval.Day, Val(txtdiasfab.Text), dtpNuevaFechaSiembra.Value)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(txtLote.Text) > 0 Then
            sSsql = "[vivero].[SP_ActualizaFechaSiembra] "
            sSsql += txtLote.Text.ToString() + ","
            sSsql += "'" + dtpNuevaFechaSiembra.Value + "',"
            sSsql += "'" + dtpNuevaFechaEntrega.Value + "',"
            sSsql += "'" + gUSER + "'"
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            command.ExecuteNonQuery()
            close_conexion()
            Me.Close()
        Else
            MsgBox("N° Lote no es válido!", MsgBoxStyle.Critical, "Modifica Fecha Siembra")
        End If
    End Sub

    Private Sub txtdiasfab_TextChanged(sender As Object, e As EventArgs) Handles txtdiasfab.TextChanged
        dtpNuevaFechaEntrega.Value = DateAdd(DateInterval.Day, Val(txtdiasfab.Text), dtpNuevaFechaSiembra.Value)
    End Sub
End Class