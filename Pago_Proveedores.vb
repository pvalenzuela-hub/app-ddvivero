Public Class Pago_Proveedores
    Dim dTotalPagos As Double
    Dim dValorCompra As Double
    Dim dIdCompras As Integer
    Private fila As Byte
    Dim gIdProveedor(0 To 0) As Integer

    Private Sub btn_AgregarPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AgregarPago.Click
        bOK = True
        Dim i As Integer
        If txt_BANCO.Text = Nothing Then
            txt_BANCO.Text = ""
        End If
        If Val(txt_MontoDoc.Text) <= 0 Then
            MessageBox.Show("MONTO DEL DOCUMENTO DEBE SER MAYOR A CERO")
            bOK = False
        End If

        If Val(txt_MontoDoc.Text) > dValorCompra - dTotalPagos Then
            MsgBox("Revise Monto de la Compra, está ingresando un valor mayor al Saldo por Pagar.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If bOK Then
            Try
                DataGridPago.Rows.Add()
                i = DataGridPago.Rows.Count - 1
                DataGridPago.Rows(i).Cells(0).Value = 0
                DataGridPago.Rows(i).Cells(1).Value = cmb_TIPO_PAGO.Text
                DataGridPago.Rows(i).Cells(2).Value = txt_NUM_DOCPAGO.Text
                DataGridPago.Rows(i).Cells(3).Value = txt_BANCO.Text
                DataGridPago.Rows(i).Cells(4).Value = dtp_FechaVcto.Value
                DataGridPago.Rows(i).Cells(5).Value = txt_MontoDoc.Text
                DataGridPago.Rows(i).Cells(6).Value = 0
                DataGridPago.Rows(i).Cells(7).Value = "NO"
                TotalPagos()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
    Private Sub TotalPagos()
        Dim i As Integer
        dTotalPagos = 0
        For i = 0 To DataGridPago.Rows.Count - 1
            If DataGridPago.Rows(i).Cells(7).Value = "SI" Then
                dTotalPagos += DataGridPago.Rows(i).Cells(5).Value
            End If
        Next
        Me.txt_TOTPAGOS.Text = Format(dTotalPagos, "###,###,##0")
        Me.txt_ValorPagado.Text = Format(dTotalPagos, "###,###,##0")
    End Sub

    Private Sub Pago_Proveedores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'DS_FormaPago.BANCO' Puede moverla o quitarla según sea necesario.
        Me.BANCOTableAdapter.Fill(Me.DS_FormaPago.BANCO)
        Carga_FormaPago(Me.cmb_TIPO_PAGO, 1)
    End Sub

    Private Sub cmb_PROVEEDOR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_PROVEEDOR.SelectedIndexChanged
        If cmb_PROVEEDOR.SelectedIndex > -1 Then
            'txt_RutProveedor.Text = zRut(Me.cmb_PROVEEDOR.SelectedIndex)
            txtIdProveedor.Text = gIdProveedor(Me.cmb_PROVEEDOR.SelectedIndex)
            Consulta_Facturas()
        End If

    End Sub
    Private Sub Consulta_Facturas()
        sSsql = "SP_CONSULTA_Factura_Compra_PendientePago " + txtIdProveedor.Text.ToString()

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        cmb_Factura.Items.Clear()
        If datatbl.HasRows Then
            While datatbl.Read = True
                cmb_Factura.Items.Add(datatbl(0))
            End While
        Else
            MsgBox("Proveedor No tiene Facturas", MsgBoxStyle.Exclamation)
        End If
        close_conexion()

    End Sub
    Private Sub Consulta_Pagos()
        Dim i As Integer = 0
        sSsql = "SP_CONSULTA_DOCCOMPRA_IdProveedor "
        sSsql += "'FA',"
        sSsql += RTrim(cmb_Factura.Text.ToString) + "," + txtIdProveedor.Text.ToString()

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            txt_Valor_Neto.Text = Format(datatbl(6), "###,###,###")
            txt_ImpEspecifico.Text = Format(datatbl(7), "###,###,###")
            txt_Iva.Text = Format(datatbl(8), "###,###,###")
            txt_ValorDocumento.Text = Format(datatbl(4), "###,###,###")
            txt_FechaFactura.Text = datatbl(2)
            txt_ValorPagado.Text = Format(datatbl(10), "###,###,###")
            dValorCompra = datatbl(4)
            dIdCompras = datatbl(11)
        Else
            MsgBox("No Existen Documentos asociados al Proveedor", MsgBoxStyle.Exclamation)
            close_conexion()
            Exit Sub
        End If

        close_conexion()
        DataGridPago.Rows.Clear()
        sSsql = "SP_CONSULTA_DOCPAGOS_PENDIENTES_IdCompras " + dIdCompras.ToString()
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then
            i = 0

            While datatbl.Read = True
                DataGridPago.Rows.Add()
                DataGridPago.Rows(i).Cells(0).Value = datatbl(0)
                DataGridPago.Rows(i).Cells(1).Value = datatbl(1)
                DataGridPago.Rows(i).Cells(2).Value = datatbl(2)
                DataGridPago.Rows(i).Cells(3).Value = datatbl(3)
                DataGridPago.Rows(i).Cells(4).Value = datatbl(4)
                DataGridPago.Rows(i).Cells(5).Value = datatbl(5)
                DataGridPago.Rows(i).Cells(6).Value = datatbl(6)
                DataGridPago.Rows(i).Cells(7).Value = datatbl(7)
                DataGridPago.Rows(i).Cells(8).Value = datatbl(8)

                i += 1
            End While

        End If
        TotalPagos()
        close_conexion()
    End Sub

    Private Sub BTN_BUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR.Click
        Dim i As Integer
        'Dim x As Integer
        Dim sNombre As String
        cmb_PROVEEDOR.Items.Clear()

        sSsql = "SP_CONSULTA_PROVEEDOR_NOMBRE '" + Trim(txt_BUSCARPROVEEDOR.Text) + "',2"

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then
            i = 0
            While datatbl.Read = True
                ReDim Preserve gIdProveedor(0 To i)
                gIdProveedor(i) = datatbl("IDPROVEEDOR")
                sNombre = datatbl(1)
                cmb_PROVEEDOR.Items.Add(sNombre)
                i += 1
            End While
            cmb_PROVEEDOR.Focus()
        Else
            MessageBox.Show("NO EXISTEN PROVEEDORES CON DATOS INGRESADOS")
            txt_BUSCARPROVEEDOR.Focus()
        End If
        close_conexion()
    End Sub

    Private Sub cmb_Factura_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Factura.SelectedIndexChanged
        If cmb_Factura.SelectedIndex > -1 Then
            Consulta_Pagos()
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GrabarPagosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrabarPagosToolStripMenuItem.Click
        Guardar_Pagos()
    End Sub
    Private Sub Guardar_Pagos()
        Dim i As Integer
        If DataGridPago.Rows.Count - 1 >= 0 Then
            open()
            command = connection.CreateCommand()
            For i = 0 To DataGridPago.Rows.Count - 1
                If DataGridPago.Rows(i).Cells(0).Value = 0 Then
                    sSsql = "SP_INSERTA_PAGOS_COMPRAS " + Str(dIdCompras) + ",'" + DataGridPago.Rows(i).Cells(1).Value + "','" + DataGridPago.Rows(i).Cells(2).Value + "',"
                    sSsql += "'" + DataGridPago.Rows(i).Cells(3).Value + "','" + Format(DataGridPago.Rows(i).Cells(4).Value, "d") + "'," + DataGridPago.Rows(i).Cells(5).Value.ToString

                    command.CommandText = sSsql
                    command.ExecuteNonQuery()
                End If
            Next
            close_conexion()
            Limpia_Campos()
        End If
    End Sub
    Private Sub Limpia_Campos()
        txt_BANCO.Clear()
        txt_FechaFactura.Clear()
        txt_ImpEspecifico.Clear()
        txt_Iva.Clear()
        txt_MontoDoc.Clear()
        txt_NUM_DOCPAGO.Clear()
        txt_TOTPAGOS.Clear()
        txt_Valor_Neto.Clear()
        txt_ValorDocumento.Clear()
        txt_ValorPagado.Clear()
        cmb_TIPO_PAGO.SelectedIndex = -1
        DataGridPago.Rows.Clear()
        TotalPagos()
        dValorCompra = 0
        cmb_Factura.SelectedIndex = -1
        cmbFormaPago.SelectedIndex = -1
        txtIDPagos.Clear()
        txtMontoPagar.Clear()


    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim sResp As String
        Try
            fila = DataGridPago.CurrentCell.RowIndex
            If fila > -1 And DataGridPago.Rows.Count > 0 Then
                If DataGridPago.Rows(fila).Cells(6).Value > 0 Then
                    MsgBox("Este Pago ya fué Contabilizado, no es posible Eliminar Pago.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                If DataGridPago.Rows(fila).Cells(0).Value > 0 Then
                    sResp = InputBox("CONFIRME ELIMINACION DE PAGO N°" + Format(DataGridPago.Rows(fila).Cells(0).Value, "######"), "ELIMINACION DE PAGO", "S")
                    If UCase(sResp) = "S" Then
                        sSsql = "SP_ELIMINA_Pago_Compra "
                        sSsql += DataGridPago.Rows(fila).Cells(0).Value.ToString
                        open()
                        command = connection.CreateCommand()
                        command.CommandText = sSsql
                        command.ExecuteNonQuery()
                        close_conexion()

                    End If
                End If
                dTotalPagos -= Single.Parse(DataGridPago.Item(5, fila).Value)
                DataGridPago.Rows.RemoveAt(fila)
                MsgBox("Registro de Pago ha sido eliminado.", MsgBoxStyle.Information)
                TotalPagos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub DataGridPago_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridPago.CellContentClick
        If DataGridPago.RowCount > 0 Then
            Dim iCol As Integer = e.ColumnIndex
            If iCol = 9 Then
                ' Efectuar Pago del documento
                If DataGridPago.Rows(e.RowIndex).Cells(7).Value = "SI" Then
                    MsgBox("Documento ya se encuentra pagado!!!")
                    Exit Sub
                End If
                cmbFormaPago.SelectedIndex = -1
                txtMontoPagar.Text = DataGridPago.Rows(e.RowIndex).Cells(5).Value
                txtIDPagos.Text = DataGridPago.Rows(e.RowIndex).Cells(0).Value
                btn_Pago.Enabled = True
            End If
        End If
    End Sub

    Private Sub btn_Pago_Click(sender As Object, e As EventArgs) Handles btn_Pago.Click
        If cmbFormaPago.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Forma de Pago", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If Val(txtIDPagos.Text) > 0 Then
            Dim idcodigo_BANCO As Integer = cmbFormaPago.SelectedValue
            open()
            command = connection.CreateCommand()
            command.CommandText = "Update [ddvivero].[dbo].[COMPRA_PAGOS] Set Pagado=1,idcodigo_BANCO=" + idcodigo_BANCO.ToString() + ",FechaPago='" + Format(dtpFechaPago.Value, "dd/MM/yyyy") + "'" + " Where IDPAGOS=" + Val(txtIDPagos.Text).ToString()
            command.ExecuteNonQuery()

            command.CommandText = "Update COMPRA_HEADER Set Total_Pago = (SELECT ISNULL(SUM(VALOR_DOC),0) FROM COMPRA_PAGOS WHERE Pagado=1 AND IDCOMPRAS = " + dIdCompras.ToString() + ") Where IDCOMPRAS = " + dIdCompras.ToString()
            command.ExecuteNonQuery()

            command.CommandText = "exec [dbo].[SP_CONTA_Contabiliza_Pago_Documento_Proveedor] " + Val(txtIDPagos.Text).ToString()
            command.ExecuteNonQuery()

            close_conexion()
            MsgBox("Pago ha sido actualizado")
            Limpia_Campos()
        Else
            MsgBox("Debe seleccionar un Item de Pago.", MsgBoxStyle.Exclamation)
        End If
    End Sub


End Class