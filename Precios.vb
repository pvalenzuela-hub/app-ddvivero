Imports System.Data.SqlClient
Public Class Precios
    Dim txt_TipoBandeja As String
    Dim txt_Semilla As String

    Private Sub Precios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Carga_Tipo_Bandeja(Me.cmb_TipoBandeja)
        Carga_Familia_Prod(Me.cmb_Familia)
        Consulta_Precios()

    End Sub

    Private Sub Consulta_Precios()
        Dim i As Integer

        sSsql = "SP_CONSULTA_PRECIO_Mantencion_Hechura "
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        GrillaPrecios.Rows.Clear()

        While datatbl.Read = True
            GrillaPrecios.Rows.Add()
            GrillaPrecios.Rows(i).Cells(0).Value = datatbl(0)
            GrillaPrecios.Rows(i).Cells(1).Value = datatbl(1)
            GrillaPrecios.Rows(i).Cells(2).Value = datatbl(2)
            GrillaPrecios.Rows(i).Cells(3).Value = Format(datatbl("Precio_Venta_PRI"), "###,##0.00")
            GrillaPrecios.Rows(i).Cells(4).Value = Format(datatbl("Precio_Venta_VER"), "###,##0.00")
            GrillaPrecios.Rows(i).Cells(5).Value = Format(datatbl("Precio_Venta_OTO"), "###,##0.00")
            GrillaPrecios.Rows(i).Cells(6).Value = Format(datatbl("Precio_Venta_INV"), "###,##0.00")
            GrillaPrecios.Rows(i).Cells(7).Value = Format(datatbl("Precio_Especial"), "###,##0.00")
            i += 1
        End While

        close_conexion()



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_actualizar.Click
        Graba_Precios()
        Consulta_Precios()
    End Sub
    Private Function Valida_Datos() As Boolean
        Dim bOk As Boolean
        Dim sMensaje As String = ""
        bOk = True
        If Val(txt_PrecioVenta_INV.Text) <= 0 Then
            sMensaje = "Precio Temporada Invierno no puede ser 0"
            bOk = False

        End If
        If sMensaje <> "" Then
            MsgBox(sMensaje, MsgBoxStyle.Critical)
        End If

        Valida_Datos = bOk
    End Function
    Private Sub Graba_Precios()

        If Valida_Datos() Then

            sSsql = "SP_GRABA_PRECIO "
            sSsql += Val(txt_IDPrecio.Text).ToString + ","
            sSsql += "'" + cmb_TipoBandeja.Text + "',"
            sSsql += "'" + cmb_Familia.Text + "',"
            sSsql += Val(txt_PrecioVenta_INV.Text).ToString + ","
            sSsql += Val(txt_PrecioVenta_VER.Text).ToString + ","
            sSsql += Val(txt_precioespecial.Text).ToString + ","
            sSsql += Val(txt_Precio_OTO.Text).ToString + ","
            sSsql += Val(txt_Precio_PRI.Text).ToString

            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            command.ExecuteNonQuery()
            close_conexion()

        End If
    End Sub
    Private Function Valida_Fechas() As Boolean
        Dim bok As Boolean
        Dim sMensaje As String
        bok = True
        sMensaje = ""




        If Not bok Then
            MsgBox(sMensaje)
        End If
        Valida_Fechas = bok
    End Function
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Modifica_Precio()
    End Sub
    Private Sub Modifica_Precio()
        '' Edición de datos
        Dim i As Integer

        i = GrillaPrecios.CurrentRow.Index
        txt_IDPrecio.Text = GrillaPrecios.Rows(i).Cells(0).Value
        cmb_TipoBandeja.SelectedItem = GrillaPrecios.Rows(i).Cells(1).Value
        cmb_Familia.SelectedItem = GrillaPrecios.Rows(i).Cells(2).Value
        'txt_FechaDesde.Text = DataGrilla.Rows(i).Cells(1).Value
        'txt_FechaHasta.Text = DataGrilla.Rows(i).Cells(2).Value
        txt_Precio_PRI.Text = GrillaPrecios.Rows(i).Cells(3).Value
        txt_PrecioVenta_VER.Text = GrillaPrecios.Rows(i).Cells(4).Value
        txt_Precio_OTO.Text = GrillaPrecios.Rows(i).Cells(5).Value
        txt_PrecioVenta_INV.Text = GrillaPrecios.Rows(i).Cells(6).Value

        txt_precioespecial.Text = GrillaPrecios.Rows(i).Cells(7).Value
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Elimina_Precio()
    End Sub
    Private Sub Elimina_Precio()
        Dim sResp As String
        Dim i As Integer


        sResp = InputBox("CONFIRME ELIMINACION DE PRECIO", "Precios de Ventas", "S")
        If UCase(sResp) = "S" Then
            i = GrillaPrecios.CurrentRow.Index
            If i >= 0 Then
                sSsql = "SP_ELIMINA_PRECIO "
                sSsql += Str(GrillaPrecios.Rows(i).Cells(0).Value)
                open()
                command = connection.CreateCommand()
                command.CommandText = sSsql
                command.ExecuteNonQuery()
                close_conexion()
                Consulta_Precios()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btn_actualizar.Enabled = True
        Consulta_Precios()
    End Sub
    Private Sub Limpia_Datos()
        txt_IDPrecio.Text = ""
        'txt_FechaDesde.Text = ""
        'txt_FechaHasta.Text = ""
        txt_PrecioVenta_VER.Text = ""
        txt_PrecioVenta_INV.Clear()
        txt_Precio_OTO.Clear()
        txt_Precio_PRI.Clear()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Limpia_Datos()
    End Sub

    Private Sub cmb_Familia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Familia.SelectedIndexChanged
        If cmb_Familia.SelectedIndex > -1 Then
            Consulta_Costos_Referencia_Plantas()
        End If
    End Sub
    Private Sub Consulta_Costos_Referencia_Plantas()
        Dim i As Integer

        Dim dPrecioCostoHechura As Double = 0
        Dim dPrecioVentaNeto As Double = 0
        Dim dPrecioMargenTipoBandeja As Double = 0
        sSsql = "SP_CONSULTA_Precio_Planta_Hechura "
        sSsql += "'" + cmb_Familia.Text + "'"

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        GrillaHechura.Rows.Clear()
        If datatbl.HasRows Then
            While datatbl.Read = True

                dPrecioCostoHechura = datatbl(3)
                dPrecioVentaNeto = dPrecioCostoHechura + (dPrecioCostoHechura * datatbl(4))
                dPrecioVentaNeto = dPrecioVentaNeto + (dPrecioVentaNeto * datatbl(5))
                GrillaHechura.Rows.Add()
                GrillaHechura.Rows(i).Cells(0).Value = datatbl(0)
                GrillaHechura.Rows(i).Cells(1).Value = Format(dPrecioCostoHechura, "###0.00")
                'GrillaHechura.Rows(i).Cells(2).Value = Format(datatbl(4) * 100, "###0.00")
                GrillaHechura.Rows(i).Cells(2).Value = Format(datatbl(5) * 100, "###0.00")
                GrillaHechura.Rows(i).Cells(3).Value = Format(dPrecioVentaNeto, "###,##0.00")
                GrillaHechura.Rows(i).Cells(4).Value = Format(datatbl(6), "###,##0.00")
                GrillaHechura.Rows(i).Cells(5).Value = Format(datatbl(7), "##0.00")

                i += 1
            End While
        Else
            MsgBox("SEMILLA NO TIENE PRECIO DE HECHURA DEFINIDO", MsgBoxStyle.Exclamation)
        End If
        datatbl.Close()
    End Sub
End Class