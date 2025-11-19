Public Class Costo_Produccion
    Dim gIdFamilia As Double

    Private Sub Costo_Produccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Carga_Familia_Prod(Me.cmb_Familia_Prod)
        gIdFamilia = 0
    End Sub

    Private Sub cmb_Familia_Prod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Familia_Prod.SelectedIndexChanged
        Dim i As Integer

        i = Me.cmb_Familia_Prod.SelectedIndex
        txt_DESCRIP.Text = Me.cmb_Familia_Prod.Text
        txt_PCostoNeto.Text = Format(aPrecio_Costo_Neto_Familia(i), "###,##0.00")
        txt_MargenPCT.Text = Format(aMargen_Porc_Familia(i), "###,##0.00")
        txt_PVentaFinal.Text = Format(aPrecio_Neto_Familia(i), "###,##0.00")
        gIdFamilia = aID_FAMILIA_PROD(i)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        '' Boton CANCELAR
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        '' Boton NUEVO
        Reseta_Campos()
        gIdFamilia = 0
        Me.txt_DESCRIP.ReadOnly = False
    End Sub
    Private Sub Reseta_Campos()
        txt_DESCRIP.Text = ""
        txt_MargenPCT.Text = ""
        txt_PCostoNeto.Text = ""
        txt_PVentaFinal.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '' Botón GRABAR
        Dim dCostoNeto As Double
        Dim dMargen As Double

        dCostoNeto = Val(Reemplaza_Comas(txt_PCostoNeto.Text))
        dMargen = Val(Reemplaza_Comas(txt_MargenPCT.Text))

        sSsql = "SP_GRABA_FAMILIA "
        sSsql += Str(gIdFamilia)
        sSsql += ","
        sSsql += "'" & txt_DESCRIP.Text & "'"
        sSsql += ","
        sSsql += Str(dCostoNeto)
        sSsql += ","
        sSsql += Str(dMargen)
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()
        close_conexion()
        MsgBox("FAMILIA DE PRODUCTO HA SIDO GRABADA")
        Reseta_Campos()
        Carga_Familia_Prod(Me.cmb_Familia_Prod)
        gIdFamilia = 0
    End Sub
    Private Sub Calcula_Precio_Final()
        If Val(txt_MargenPCT.Text) > 0 And Val(txt_PCostoNeto.Text) > 0 Then
            txt_PVentaFinal.Text = Format(txt_PCostoNeto.Text * (1 + (txt_MargenPCT.Text / 100)), "###,##0.00")
        End If
    End Sub

    Private Sub txt_PCostoNeto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_PCostoNeto.LostFocus
        txt_PCostoNeto.Text = Reemplaza_Puntos(txt_PCostoNeto.Text)
        Calcula_Precio_Final()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        '' Boton ELIMINAR
        If InputBox("ELIMINACION DE FAMILIA DE PRODUCTO", "ELIMINA FAMILIA DE PRODUCTO S / N?", "N") = "S" Then
            sSsql = "SP_ELIMINA_FAMILIA "
            sSsql += Str(gIdFamilia)
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                datatbl.Read()
                If datatbl(0) = 0 Then
                    MsgBox("COSTO DE FAMILIA ELIMINADO")
                    Me.cmb_Familia_Prod.Items.Clear()
                    Carga_Familia_Prod(Me.cmb_Familia_Prod)
                    gIdFamilia = 0
                Else
                    MsgBox("NO ES POSIBLE ELIMINAR FAMILIA DE PRODUCTO. EXISTE AL MENOS UN PRODUCTO UTILIZANDO ESTA FAMILIA")
                End If
            End If
            close_conexion()

            Reseta_Campos()

        End If
    End Sub

    Private Sub txt_MargenPCT_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MargenPCT.LostFocus
        txt_MargenPCT.Text = Reemplaza_Puntos(txt_MargenPCT.Text)
        Calcula_Precio_Final()
    End Sub
End Class