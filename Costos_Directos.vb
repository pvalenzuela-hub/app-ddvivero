Public Class Costos_directos
    Dim gIdCostoDIR As Integer
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
            GrillaDetalle.Rows.Add()
            i = GrillaDetalle.Rows.Count - 1
            GrillaDetalle.Rows(i).Cells(0).Value = cmb_Insumos.Text
            GrillaDetalle.Rows(i).Cells(1).Value = txt_PrecioCosto.Text
            GrillaDetalle.Rows(i).Cells(2).Value = txt_CantInsumo.Text
            GrillaDetalle.Rows(i).Cells(3).Value = txt_TipoUnidadCosto.Text
            GrillaDetalle.Rows(i).Cells(4).Value = Format((Val(txt_PrecioCosto.Text) / Val(txt_UnidCosto.Text) * Val(txt_CantInsumo.Text)) / Val(txt_CantPlantas.Text) / Val(txt_NumUsos.Text), "#0.##########")
            GrillaDetalle.Rows(i).Cells(5).Value = Format((Val(txt_PrecioCosto.Text) / Val(txt_UnidCosto.Text) * Val(txt_CantInsumo.Text)) / Val(txt_NumUsos.Text), "#0.##########")

            Calcula_Total()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Calcula_Total()
        Dim dCostoDirectoPlanta As Double = 0
        Dim dCostoDirectoBandeja As Double = 0
        For i As Integer = 0 To GrillaDetalle.Rows.Count - 1
            dCostoDirectoPlanta += GrillaDetalle.Rows(i).Cells(4).Value
            dCostoDirectoBandeja += GrillaDetalle.Rows(i).Cells(5).Value
        Next
        txt_TotalCostoDIRBandeja.Text = Format(dCostoDirectoBandeja, "###,##0.00")
        txt_TotalCostoDirectoPlanta.Text = Format(dCostoDirectoPlanta, "###,##0.00")
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
            txt_PrecioCosto.Text = datatbl(1)
            txt_TipoUnidadCosto.Text = datatbl(4)
            txt_UnCosto.Text = RTrim(datatbl(4))
            txt_NumUsos.Text = datatbl(8)
            txt_UnidCosto.Text = datatbl(9)
            txt_UNCompra.Text = datatbl(0)
        End If
        close_conexion()
    End Sub


    Private Sub Costos_Indirectos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Carga_Full_Insumos_Directos(Me.cmb_Insumos)
        Carga_Tipo_Bandeja(Me.cmb_TipoBandeja)
    End Sub

    Private Sub cmb_TipoBandeja_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TipoBandeja.SelectedIndexChanged
        If cmb_TipoBandeja.SelectedIndex > -1 Then
            Consulta_Tipo_Bandeja()
        End If
    End Sub
    Private Sub Consulta_Tipo_Bandeja()
        Dim sResp As MsgBoxResult
        Dim i As Integer

        Limpia_Campo()
        sSsql = "SP_CONSULTA_TipoBandeja "
        sSsql += "'" + cmb_TipoBandeja.Text + "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows = True Then
            datatbl.Read()
            txt_CantPlantas.Text = datatbl(2)
        End If
        close_conexion()

        REM Lee datos Costo Directo
        sSsql = "SP_Consulta_COSTO_Directo "
        sSsql += "'" + cmb_TipoBandeja.Text + "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows = True Then
            datatbl.Read()
            cmb_TipoBandeja.SelectedItem = datatbl(1)
            txt_TotalCostoDirectoPlanta.Text = Format(datatbl(2), "##0.00")
            REM Lee detalle costo directo
            close_conexion()
            sSsql = "SP_Consulta_COSTO_Directo_DET "
            sSsql += "'" + cmb_TipoBandeja.Text + "'"
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()

            GrillaDetalle.Rows.Clear()

            If datatbl.HasRows Then
                While datatbl.Read

                    GrillaDetalle.Rows.Add()
                    i = GrillaDetalle.Rows.Count - 1
                    GrillaDetalle.Rows(i).Cells(0).Value = datatbl(2)
                    GrillaDetalle.Rows(i).Cells(1).Value = Format(datatbl(3), "###,##0")
                    GrillaDetalle.Rows(i).Cells(2).Value = datatbl(4)
                    GrillaDetalle.Rows(i).Cells(3).Value = datatbl(5)
                    GrillaDetalle.Rows(i).Cells(4).Value = Format(datatbl(6), "###,##0.00")
                    GrillaDetalle.Rows(i).Cells(5).Value = Format(datatbl(7), "###,##0.00")
                End While
                Calcula_Total()
            End If
            close_conexion()



        Else
            sResp = MsgBox("Costo no Existe. desea crear Costo para Tipo de Bandeja?", MsgBoxStyle.YesNo)
            If sResp = MsgBoxResult.Yes Then
                GrillaDetalle.Rows.Clear()
                Limpia_Campo()
                cmb_Insumos.Focus()
            End If
        End If

        close_conexion()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Grabar_Costos()
    End Sub
    Private Sub Grabar_Costos()
        Dim i As Integer = 0
        sSsql = "SP_GRABA_COSTO_Directo "
        sSsql += "'" + cmb_TipoBandeja.Text + "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        datatbl.Read()
        gIdCostoDIR = datatbl(0)
        close_conexion()
        REM Graba Detalle Costo Directo
        open()
        For i = 0 To GrillaDetalle.Rows.Count - 1
            sSsql = "SP_GRABA_COSTO_Directo_Detalle "
            sSsql += gIdCostoDIR.ToString + ","
            sSsql += "'" + GrillaDetalle.Rows(i).Cells(0).Value + "',"
            sSsql += GrillaDetalle.Rows(i).Cells(2).Value.ToString + ","
            sSsql += Reemplaza_Comas(GrillaDetalle.Rows(i).Cells(4).Value) + ","
            sSsql += Reemplaza_Comas(GrillaDetalle.Rows(i).Cells(5).Value)
            command = connection.CreateCommand
            command.CommandText = sSsql
            command.ExecuteNonQuery()

        Next
        close_conexion()
        MsgBox("Costos Directos Actualizados.", MsgBoxStyle.Information)
        Limpia_Campo()
        cmb_TipoBandeja.SelectedIndex = -1
        txt_CantPlantas.Clear()
        cmb_TipoBandeja.Focus()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Elimina_Costo()
    End Sub
    Private Sub Elimina_Costo()
        Dim iRow As Integer
        Try
            iRow = GrillaDetalle.CurrentCell.RowIndex
            If iRow > -1 And GrillaDetalle.Rows.Count > 0 Then
                GrillaDetalle.Rows.RemoveAt(iRow)
            End If
            Calcula_Total()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub Limpia_Campo()
        cmb_Insumos.SelectedIndex = -1
        'cmb_TipoBandeja.SelectedIndex = -1
        txt_CantInsumo.Clear()
        'txt_CantPlantas.Clear()
        txt_NumUsos.Clear()
        txt_PrecioCosto.Clear()
        txt_TipoUnidadCosto.Clear()
        txt_TotalCostoDirectoPlanta.Clear()
        txt_UnidCosto.Clear()
        GrillaDetalle.Rows.Clear()
        txt_UnCosto.Clear()
        txt_UNCompra.Clear()
    End Sub
End Class