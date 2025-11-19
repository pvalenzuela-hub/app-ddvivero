Public Class INV_ingresoGuia
    Dim sTipo As String
    Private Sub cmbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipo.SelectedIndexChanged

        sTipo = Mid(cmbTipo.Text, 1, 1)

        If sTipo = "T" Then
            lblBodegaDestino.Visible = True
            cmbBodegaDest.Visible = True
        Else
            lblBodegaDestino.Visible = False
            cmbBodegaDest.Visible = False

        End If

        If sTipo = "S" Then
            lblPVenta.Visible = True
            txtPVenta.Visible = True
        Else
            lblPVenta.Visible = False
            txtPVenta.Visible = False
        End If
    End Sub

    Private Sub INV_ingresoGuia_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSTOCK.SP_StockListadoBodegas' Puede moverla o quitarla según sea necesario.
        Me.SP_StockListadoBodegasTableAdapter.Fill(Me.DataSetSTOCK.SP_StockListadoBodegas)
        'TODO: esta línea de código carga datos en la tabla 'DataSetSTOCK.SP_consultaGuiaINV' Puede moverla o quitarla según sea necesario.
        Me.SP_consultaGuiaINVTableAdapter.Fill(Me.DataSetSTOCK.SP_consultaGuiaINV)
        'TODO: esta línea de código carga datos en la tabla 'DataSetSTOCK.SP_consultaTablaProducto' Puede moverla o quitarla según sea necesario.
        Me.SP_consultaTablaProductoTableAdapter.Fill(Me.DataSetSTOCK.SP_consultaTablaProducto)

        cmbTipo.SelectedIndex = -1
        cmbBodOrigen.SelectedIndex = -1
        cmbBodegaDest.SelectedIndex = -1
        cmbProducto.SelectedIndex = -1


    End Sub

    Private Sub Limpia_Campos()
        txtCantidad.Clear()
        txtConcepto.Clear()
        cmbBodegaDest.SelectedIndex = -1
        cmbBodOrigen.SelectedIndex = -1
        cmbProducto.SelectedIndex = -1
        cmbTipo.SelectedIndex = -1
        dtpFecha.Value = Date.Now
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ' validación
        If Format(dtpFecha.Value, "yyyyMMdd") < Format(Date.Now, "yyyyMMdd") Then
            MsgBox("La Fecha del movimienbto no puede ser menor a hoy", MsgBoxStyle.Exclamation, "INVENTARIO DE PRODUCTOS")
            Exit Sub
        End If


        If cmbTipo.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar Tipo de Movimiento de Inventario", MsgBoxStyle.Exclamation, "INVENTARIO DE PRODUCTOS")
            Exit Sub
        End If


        If cmbBodOrigen.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar Bodega Origen", MsgBoxStyle.Exclamation, "INVENTARIO DE PRODUCTOS")
            Exit Sub
        End If

        If cmbProducto.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar Producto", MsgBoxStyle.Exclamation, "INVENTARIO DE PRODUCTOS")
            Exit Sub
        End If

        If txtCantidad.Text = Nothing Then
            MsgBox("Debe Ingresar Cantidad de Inventario", MsgBoxStyle.Exclamation, "INVENTARIO DE PRODUCTOS")
            Exit Sub
        End If

        If txtConcepto.Text = Nothing Then
            txtConcepto.Text = ""
        End If

        If txtPVenta.Text = Nothing Then
            txtPVenta.Text = "0"
        End If


        open()
        sSsql = "SP_StockGrabaGuia"
        sSsql += " '" + dtpFecha.Value + "',"


        If sTipo = "T" Then
            sSsql += cmbBodOrigen.SelectedValue.ToString + ","
            sSsql += "'S',"
            sSsql += cmbProducto.SelectedValue.ToString + ","
            sSsql += txtCantidad.Text.ToString + ","
            sSsql += "'" + txtConcepto.Text + "',0"

            command = connection.CreateCommand
            command.CommandText = sSsql
            command.ExecuteNonQuery()


            sSsql = "SP_StockGrabaGuia"
            sSsql += " '" + dtpFecha.Value + "',"
            sSsql += cmbBodegaDest.SelectedValue.ToString + ","
            sSsql += "'E',"
            sSsql += cmbProducto.SelectedValue.ToString + ","
            sSsql += txtCantidad.Text.ToString + ","
            sSsql += "'" + txtConcepto.Text + "',0"

            command = connection.CreateCommand
            command.CommandText = sSsql
            command.ExecuteNonQuery()

        Else
            sSsql += cmbBodOrigen.SelectedValue.ToString + ","
            sSsql += "'" + sTipo + "',"
            sSsql += cmbProducto.SelectedValue.ToString + ","
            sSsql += txtCantidad.Text.ToString + ","
            sSsql += "'" + txtConcepto.Text + "',"
            sSsql += txtPVenta.Text.ToString

            command = connection.CreateCommand
            command.CommandText = sSsql
            command.ExecuteNonQuery()

        End If


        close_conexion()

        Me.SP_consultaGuiaINVTableAdapter.Fill(Me.DataSetSTOCK.SP_consultaGuiaINV)
        Limpia_Campos()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        open()

        For i As Integer = 0 To DataGrillaStock.Rows.Count - 1
            sSsql = "SP_Actualiza_Inventario_Producto "

            sSsql += DataGrillaStock.Rows(i).Cells("IdProd").Value.ToString + ","
            sSsql += DataGrillaStock.Rows(i).Cells("IdBodega").Value.ToString

            command = connection.CreateCommand
            command.CommandText = sSsql
            command.ExecuteNonQuery()

        Next
        close_conexion()
        Me.SP_consultaGuiaINVTableAdapter.Fill(Me.DataSetSTOCK.SP_consultaGuiaINV)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fila As Integer
        Dim Id As Integer
        Try
            fila = DataGrillaStock.CurrentCell.RowIndex
            Id = DataGrillaStock.Rows(fila).Cells("Idguiainv").Value

            sSsql = "SP_StockEliminaMovGuia " + Id.ToString
            open()
            command = connection.CreateCommand
            command.CommandText = sSsql
            command.ExecuteNonQuery()
            close_conexion()

            Me.SP_consultaGuiaINVTableAdapter.Fill(Me.DataSetSTOCK.SP_consultaGuiaINV)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class