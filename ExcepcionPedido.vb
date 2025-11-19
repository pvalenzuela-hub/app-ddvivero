Public Class ExcepcionPedido
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtMotivoExcepcion.Text <> Nothing Then
            Pedidos.chkExcepcion.Checked = True
            Pedidos.txtMotivoExcepcion.Text = txtMotivoExcepcion.Text
            Me.Close()
        Else
            MsgBox("Para guardar excepciones debe ingresar motivo!!!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtMotivoExcepcion.Clear()
        Pedidos.chkExcepcion.Checked = False
        Pedidos.txtMotivoExcepcion.Clear()
    End Sub
End Class