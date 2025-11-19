Public Class DevolucionPlantas
    Private Sub btnBuscaCliente_Click(sender As Object, e As EventArgs) Handles btnBuscaCliente.Click
        If chkCliente.Checked Then
            BusquedaCliente.chkIncluyePrimerNombre.Checked = True
        Else
            BusquedaCliente.chkIncluyePrimerNombre.Checked = False
        End If
        gQuienLlama = 15
        gNOMBRE = txt_clientebuscar.Text
        BusquedaCliente.Visible = True
    End Sub
End Class