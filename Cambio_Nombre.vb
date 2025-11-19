Public Class Cambio_Nombre

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Cambio_Nombre_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Carga_Full_Guias(cmb_Guia)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        gNOMBRE = txt_clientebuscar.Text
        gQuienLlama = 4
        BusquedaCliente.Visible = True
    End Sub

    Private Sub cmb_Pedido_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Guia.SelectedIndexChanged
        If cmb_Guia.SelectedIndex >= 0 Then
            Recupera_Guia(Val(cmb_Guia.Text))
        End If
    End Sub
    Private Sub Recupera_Guia(ByVal IDGuia As Integer)
        'Dim i As Integer

        sSsql = "SP_CONSULTA_GUIA " + Str(IDGuia)
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            txt_NombreCliente.Text = datatbl(17)
            txt_RUT_CLI.Text = Format(Val(Mid(datatbl(29), 1, 11)), "###,###,###") + "-" + Mid(datatbl(29), 12, 1)
        End If
        close_conexion()
    End Sub
    Private Sub Limpia_Campos()
        txt_clientebuscar.Text = ""
        txt_NombreCliente.Text = ""
        txt_NuevoCliente.Text = ""
        txt_NuevoID.Text = ""
        txt_NuevoRUT.Text = ""
        txt_RUT_CLI.Text = ""
        cmb_Guia.SelectedIndex = -1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sResp = MsgBox("Esta seguro de confirmar cambio de Nombre", MsgBoxStyle.YesNo, "Cambio de Nombre de la Guía")
        If sResp = MsgBoxResult.Yes Then
            Graba_Cambios()
        End If
    End Sub
    Private Sub Graba_Cambios()
        sSsql = "SP_CAMBIA_NOMBRE_GUIA " + Str(Val(cmb_Guia.Text)) + ","
        sSsql += Str(txt_NuevoID.Text)
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()

        close_conexion()
        MsgBox("Se ha modificado el cliente para la Guía " + Str(cmb_Guia.Text), MsgBoxStyle.Exclamation, "Cambio de Nombre de la Guía")
        Limpia_Campos()
    End Sub
End Class