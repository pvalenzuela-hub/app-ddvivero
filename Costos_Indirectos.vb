Public Class Costos_Indirectos

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim i As Integer
        '' Botón Agregar al Carro

        If cmb_TipoBandeja.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Tipo de Bandeja", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If cmb_Insumos.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Insumo.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If Val(txt_CantInsumo.Text) = 0 Then
            MsgBox("Debe Ingresar Cantidad de Insumo.", MsgBoxStyle.Critical)
            Exit Sub
        End If


        Try
            GrillaInsumo.Rows.Add()
            i = GrillaInsumo.Rows.Count - 1
            GrillaInsumo.Rows(i).Cells(0).Value = cmb_Insumos.Text
            GrillaInsumo.Rows(i).Cells(1).Value = txt_PrecioCosto.Text
            GrillaInsumo.Rows(i).Cells(2).Value = txt_CantInsumo.Text
            GrillaInsumo.Rows(i).Cells(3).Value = txt_UnidadCosto.Text
            GrillaInsumo.Rows(i).Cells(4).Value = txt_CantPlantas

            If gTipo_Venta = 0 Then
                DataGrilla.Rows(i).Cells(0).Value = txt_NumGuia.Text
                DataGrilla.Rows(i).Cells(1).Value = txt_Familia.Text
                DataGrilla.Rows(i).Cells(2).Value = txt_Variedad.Text
                DataGrilla.Rows(i).Cells(3).Value = ""
                DataGrilla.Rows(i).Cells(4).Value = txt_precio.Text
                DataGrilla.Rows(i).Cells(5).Value = txt_Cantidad.Text
                DataGrilla.Rows(i).Cells(6).Value = Math.Round(Val(Reemplaza_Comas(txt_precio.Text)) * Val(txt_Cantidad.Text), 0, MidpointRounding.AwayFromZero)
                DataGrilla.Rows(i).Cells(7).Value = txt_Glosa.Text
                DataGrilla.Rows(i).Cells(8).Value = txt_IDSemilla.Text
                DataGrilla.Rows(i).Cells(9).Value = txt_IDVariedad.Text
                DataGrilla.Rows(i).Cells(10).Value = "0"
                DataGrilla.Rows(i).Cells(11).Value = "0"
            Else
                DataGrilla.Rows(i).Cells(0).Value = "0"
                DataGrilla.Rows(i).Cells(3).Value = cmb_Insumos.Text
                DataGrilla.Rows(i).Cells(4).Value = txt_precio.Text
                DataGrilla.Rows(i).Cells(5).Value = txt_Cantidad.Text
                DataGrilla.Rows(i).Cells(6).Value = Math.Round(Val(Reemplaza_Comas(txt_precio.Text)) * Val(txt_Cantidad.Text), 0, MidpointRounding.AwayFromZero)
                DataGrilla.Rows(i).Cells(7).Value = txt_Glosa.Text
                DataGrilla.Rows(i).Cells(8).Value = "0"
                DataGrilla.Rows(i).Cells(9).Value = "0"
                DataGrilla.Rows(i).Cells(10).Value = gIdInsumo
                DataGrilla.Rows(i).Cells(11).Value = "1"

            End If


            totales()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub cmb_Insumos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Insumos.SelectedIndexChanged
        If cmb_Insumos.SelectedIndex > -1 Then
            Busca_Insumo()
        End If

    End Sub
    Private Sub Busca_Insumo()
        Dim i As Integer = 0
        sSsql = "SP_CONSULTA_INGREDIENTE "
        sSsql += "'" + cmb_Insumos.Text + "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows = True Then
            datatbl.Read()
            txt_PrecioCosto.Text = datatbl(5)
            txt_UnidadCosto.Text = datatbl(4)

        End If
        close_conexion()
    End Sub

    Private Sub txt_UnidadCosto_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txt_UnidadCosto.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txt_NumUsos.MaskInputRejected

    End Sub
End Class