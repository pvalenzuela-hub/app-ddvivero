Imports System.Data.SqlClient
Public Class win_Ingredientes
    Private Costos As New DataTable("Detalle")
    Dim datatbl As SqlClient.SqlDataReader = Nothing
    Dim command As SqlCommand = Nothing


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub win_Ingredientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Consulta_Ingredientes()
        Carga_Full_Insumos_Directos(Me.cmb_InsumosDirectos)
        Carga_Unidades()
    End Sub
    Private Sub Carga_Unidades()
        Dim i As Integer

        sSsql = "SP_CONSULTA_FULL_UNIDADES"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then
            i = 0
            While datatbl.Read = True
                Me.cmb_UN_COSTO.Items.Add(datatbl(1))
                Me.cmb_UNCompra.Items.Add(datatbl(1))
                Me.cmb_UNMedida.Items.Add(datatbl(1))
            End While

        End If
        close_conexion()

    End Sub
  


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If cmb_InsumosDirectos.SelectedIndex = -1 Then
            MsgBox("Debe Ingresar Descripción Item de Costo")
            Exit Sub
        End If

        If cmb_UNCompra.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Unidad de Compra")
            Exit Sub
        End If

        If Val(txt_PrecioCompra.Text) = 0 Then
            MsgBox("Debe Definir Precio de Compra")
            Exit Sub
        End If

        If cmb_UNMedida.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Unidad de Medida del item de costo")
            Exit Sub
        End If

        If Val(txt_CantMedida.Text) = 0 Then
            MsgBox("Debe Ingresar Cantidad de Item de costo")
            Exit Sub
        End If

        If cmb_UN_COSTO.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Unidad de Medida para Costo del Item")
            Exit Sub
        End If

        If Val(txt_NumUsos.Text) <= 0 Then
            MsgBox("Debe Ingresar Cantidad de Veces que se puede utilizar el material en la Propducción")
            Exit Sub
        End If

        '@IdInsumo int,
        '@UN_COMPRA varchar(10),
        '@PRECIO_COMPRA decimal(18,2),
        '@UN_MEDIDA varchar(10),
        '@CANT_MEDIDA decimal(18,2),
        '@UN_COSTO varchar(10)



        'Ejecuta Procedimiento Almacenado para Grabar Item - ingrediente en la Base de Datos
        sSsql = "SP_GRABA_INGREDIENTE "
        sSsql += Val(txt_IdInsumo.Text).ToString + ","
        sSsql += "'" + cmb_UNCompra.Text + "',"
        sSsql += Val(txt_PrecioCompra.Text).ToString + ","
        sSsql += "'" + cmb_UNMedida.Text + "',"
        sSsql += Val(txt_CantMedida.Text).ToString + ","
        sSsql += "'" + cmb_UN_COSTO.Text + "',"
        sSsql += Val(txt_NumUsos.Text).ToString
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()
        close_conexion()
        Consulta_Ingredientes()


    End Sub
    Private Sub Consulta_Ingredientes()
        Dim i As Integer
        sSsql = "SP_CONSULTA_FULL_INGREDIENTE"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then
            i = 0
            DataGrilla.Rows.Clear()

            While datatbl.Read = True
                DataGrilla.Rows.Add()
                DataGrilla.Rows(i).Cells(0).Value = datatbl(0)
                DataGrilla.Rows(i).Cells(1).Value = datatbl(1)
                DataGrilla.Rows(i).Cells(2).Value = datatbl(2)
                DataGrilla.Rows(i).Cells(3).Value = datatbl(3)
                DataGrilla.Rows(i).Cells(4).Value = Format(datatbl(4), "########0.00")
                DataGrilla.Rows(i).Cells(5).Value = datatbl(5)
                DataGrilla.Rows(i).Cells(6).Value = Format(datatbl(6), "########0.00")
                DataGrilla.Rows(i).Cells(7).Value = datatbl(7)
                DataGrilla.Rows(i).Cells(8).Value = Format(datatbl(8), "###,###,##0.00")
                DataGrilla.Rows(i).Cells(9).Value = Format(datatbl(9), "###,###,##0.00")
                DataGrilla.Rows(i).Cells(10).Value = datatbl(10)
                DataGrilla.Rows(i).Cells(11).Value = datatbl(11)


                i += 1
            End While

        End If

        close_conexion()



    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim ifila As Integer
        Dim iCod As Integer
        Dim sResp As String
        ifila = DataGrilla.CurrentCell.RowIndex

        If ifila > -1 And DataGrilla.Rows.Count > 0 Then
            iCod = DataGrilla.Rows(ifila).Cells(0).Value
            sResp = InputBox("ESTA SEGURO DE ELIMINAR ITEM, CODIGO:" + Str(iCod) + " PARA ELIMINAR INGRESE 'S' Y PRESIONE BOTON 'ACEPTAR'", "Item de Costo", "N")
            If UCase(sResp) = "S" Then
                If Elimina_Ingrediente_DB(iCod) = 0 Then
                    DataGrilla.Rows.RemoveAt(ifila)
                    Consulta_Ingredientes()
                Else
                    MsgBox("NO SE PERMITE ELIMINAR ITEM DE COSTO, CODIGO:" + Str(iCod) + ". ESTE ITEM DE COSTO, ESTA SIENDO UTILIZADO EN PLANTILLA DE PRODUCTO.")
                End If
            End If

            '            For i = 0 To Costos.Rows.Count - 1
            ' carrito.Rows(i).BeginEdit()
            ' carrito.Rows(i)(0) = i + 1
            ' carrito.Rows(i).EndEdit()
            'Next
            'totales()
        End If

    End Sub
    Function Elimina_Ingrediente_DB(ByVal IdIngred As Integer) As Boolean
        Dim CodRetorno As Integer

        sSsql = "SP_ELIMINA_INGREDIENTE " + Str(IdIngred)
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then
            datatbl.Read()
            CodRetorno = datatbl(0)
        End If

        Elimina_Ingrediente_DB = CodRetorno
        close_conexion()
    End Function


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Modificar_Datos()

    End Sub
    Private Sub Modificar_Datos()
        '' Edición de datos
        Dim i As Integer

        i = DataGrilla.CurrentRow.Index

        txt_CodIngrediente.Text = DataGrilla.Rows(i).Cells(0).Value
        txt_IdInsumo.Text = DataGrilla.Rows(i).Cells(1).Value
        cmb_InsumosDirectos.SelectedItem = DataGrilla.Rows(i).Cells(2).Value
        cmb_UNCompra.SelectedItem = DataGrilla.Rows(i).Cells(3).Value
        txt_PrecioCompra.Text = DataGrilla.Rows(i).Cells(4).Value
        cmb_UNMedida.SelectedItem = DataGrilla.Rows(i).Cells(5).Value
        txt_CantMedida.Text = DataGrilla.Rows(i).Cells(6).Value
        cmb_UN_COSTO.SelectedItem = DataGrilla.Rows(i).Cells(7).Value
    End Sub

 

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txt_CantMedida.Clear()
        txt_CodIngrediente.Clear()
        txt_IdInsumo.Clear()
        txt_PrecioCompra.Clear()
        cmb_InsumosDirectos.SelectedIndex = -1
        cmb_UN_COSTO.SelectedIndex = -1
        cmb_UNCompra.SelectedIndex = -1
        cmb_UNMedida.SelectedIndex = -1
        txt_NumUsos.Clear()

    End Sub

    Private Sub cmb_InsumosDirectos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_InsumosDirectos.SelectedIndexChanged
        If cmb_InsumosDirectos.SelectedIndex > -1 Then
            sSsql = "SP_CONSULTA_Insumo "
            sSsql += "'" + cmb_InsumosDirectos.Text + "'"
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()

            If datatbl.HasRows Then
                datatbl.Read()
                txt_IdInsumo.Text = datatbl(0)
                txt_PrecioCompra.Text = datatbl(3)
            End If
            close_conexion()
        End If


    End Sub
End Class