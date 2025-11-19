Public Class ModificaEstadoLote
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(txtLote.Text) > 0 Then
            sSsql = "[vivero].[SP_ActualizaEstadoLote] "
            sSsql += txtLote.Text.ToString() + ","
            sSsql += cmb_Estados.SelectedValue.ToString() + ","
            sSsql += "'" + gUSER + "'"
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            command.ExecuteNonQuery()
            close_conexion()
            Me.Close()
        Else
            MsgBox("N° Lote no es válido!", MsgBoxStyle.Critical, "Modifica Lote")
        End If
    End Sub

    Private Sub ModificaEstadoLote_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet.tEstado' Puede moverla o quitarla según sea necesario.
        Me.TEstadoTableAdapter.Fill(Me.GESTDataSet.tEstado)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class