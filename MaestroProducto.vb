Public Class MaestroProducto
    Private Sub MaestroProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSTOCK.SP_consultaTablaProducto' Puede moverla o quitarla según sea necesario.
        Me.SP_consultaTablaProductoTableAdapter.Fill(Me.DataSetSTOCK.SP_consultaTablaProducto)
        'TODO: esta línea de código carga datos en la tabla 'DataSetSTOCK.SP_CONSULTA_FULL_UNIDADES' Puede moverla o quitarla según sea necesario.
        Me.SP_CONSULTA_FULL_UNIDADESTableAdapter.Fill(Me.DataSetSTOCK.SP_CONSULTA_FULL_UNIDADES)
        'TODO: esta línea de código carga datos en la tabla 'DataSetSTOCK.SP_CONSULTA_INSUMOS_Productos' Puede moverla o quitarla según sea necesario.
        Me.SP_CONSULTA_INSUMOS_ProductosTableAdapter.Fill(Me.DataSetSTOCK.SP_CONSULTA_INSUMOS_Productos)
        cmbInsumo.SelectedIndex = -1
        cmbUnidad.SelectedIndex = -1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Graba_Producto()
    End Sub
    Private Sub Graba_Producto()
        ' Validación de Ingreso de Datos
        If txtCodProd.Text = Nothing Then
            MsgBox("Falta Ingresar Código del Producto", MsgBoxStyle.Critical, "GRABA PRODUCTO")
            Exit Sub
        End If

        If txtDesProd.Text = Nothing Then
            MsgBox("Falta Ingresar Descripción del Producto", MsgBoxStyle.Critical, "GRABA PRODUCTO")
            Exit Sub
        End If

        If cmbUnidad.SelectedIndex = -1 Then
            MsgBox("Falta Seleccionar Unidad del Producto. Recuerde asociar la misma unidad utilizada para el insumo asociado.", MsgBoxStyle.Critical, "GRABA PRODUCTO")
            Exit Sub
        End If

        Dim pVenta As Integer

        pVenta = Val(txtPVenta.Text)

        sSsql = "SP_Stock_CreaProductos "
        sSsql += "'" + txtCodProd.Text + "',"
        sSsql += "'" + txtDesProd.Text + "',"
        sSsql += cmbUnidad.SelectedValue.ToString + ","
        sSsql += "'" + txtMarca.Text + "',"
        If cmbInsumo.SelectedIndex = -1 Then
            sSsql += "Null,"
        Else
            sSsql += cmbInsumo.SelectedValue.ToString + ","
        End If
        If Val(pVenta) = 0 Then
            sSsql += "0,"
        Else
            sSsql += pVenta.ToString + ","
        End If

        If txt_Dir_Ficha.Text = Nothing Then
            sSsql += "''"
        Else
            sSsql += "'" + txt_Dir_Ficha.Text + "'"
        End If


        open()
        command = connection.CreateCommand
        command.CommandText = sSsql
        command.ExecuteNonQuery()
        close_conexion()
        Me.SP_consultaTablaProductoTableAdapter.Fill(Me.DataSetSTOCK.SP_consultaTablaProducto)
        Limpia_Campos()
    End Sub
    Private Sub Limpia_Campos()
        txtCodProd.Clear()
        txtDesProd.Clear()
        txtMarca.Clear()
        txtPVenta.Clear()
        txt_Dir_Ficha.Clear()
        cmbInsumo.SelectedIndex = -1
        cmbUnidad.SelectedIndex = -1
        txtCodProd.Enabled = True
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Elimina Producto
        Dim fila As Integer
        Dim IdProd As Integer
        Try
            fila = DataGrilla.CurrentCell.RowIndex
            IdProd = DataGrilla.Rows(fila).Cells("IdProd").Value

            sSsql = "SP_Stock_EliminaProducto " + IdProd.ToString
            open()
            command = connection.CreateCommand
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()

            If datatbl.HasRows = True Then
                datatbl.Read()
                If datatbl(0) = -1 Then
                    MsgBox("No es posible Eliminar Producto con Historia de Stock", MsgBoxStyle.Exclamation)
                End If
            End If
            close_conexion()

            Me.SP_consultaTablaProductoTableAdapter.Fill(Me.DataSetSTOCK.SP_consultaTablaProducto)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Modifica Producto
        Dim fila As Integer
        Dim IdProd As Integer
        Try
            fila = DataGrilla.CurrentCell.RowIndex
            IdProd = DataGrilla.Rows(fila).Cells(0).Value



            txtCodProd.Text = DataGrilla.Rows(fila).Cells(1).Value
            txtDesProd.Text = DataGrilla.Rows(fila).Cells(2).Value
            cmbUnidad.Text = DataGrilla.Rows(fila).Cells(3).Value
            txtMarca.Text = DataGrilla.Rows(fila).Cells(6).Value
            txt_Dir_Ficha.Text = DataGrilla.Rows(fila).Cells(9).Value


            If Trim(DataGrilla.Rows(fila).Cells(7).Value) = Nothing Then
                cmbInsumo.SelectedIndex = -1
            Else
                cmbInsumo.Text = DataGrilla.Rows(fila).Cells(7).Value
            End If

            'MsgBox(DataGrilla.Rows(fila).Cells(5).Value.ToString)

            If IsDBNull(DataGrilla.Rows(fila).Cells(5).Value) = True Then
                txtPVenta.Text = ""
            Else
                txtPVenta.Text = DataGrilla.Rows(fila).Cells(5).Value
            End If



            txtCodProd.Enabled = False

            'Graba_Producto()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        'OpenFileDialog1.InitialDirectory = My.Settings.Dir_Ficha
        'OpenFileDialog1.Filter = "PDF|*.pdf"
        'If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    txt_Dir_Ficha.Text = OpenFileDialog1.FileName
        'End If
    End Sub



    Private Sub DataGrilla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrilla.CellClick
        If DataGrilla.RowCount > 0 Then
            If e.ColumnIndex = 10 And e.RowIndex >= 0 Then
                ''botón Ver Ficha
                gIdProd = DataGrilla.Rows(e.RowIndex).Cells(0).Value
                gQuienLlama = 2
                Visualiza_PDF.Show()
            End If

        End If
    End Sub


End Class