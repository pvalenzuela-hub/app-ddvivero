
Imports System.Drawing.Printing
Imports System.Data.SqlClient
Public Class frmtablavirtual
    Dim FormatoImpresion As New StringFormat
    Dim datatbl As SqlClient.SqlDataReader = Nothing
    Dim command As SqlCommand = Nothing
    Dim GranTotal As Double
    Dim dTotalNeto As Double
    Dim dTotalPagos As Double
    Dim sTipoDoc As String
    Dim iNumeDoc As Integer
    Dim gTipo_Venta As Integer
    Dim gIdInsumo As Integer
    Dim gTotalFinal As Double
    Dim gIdVtahead As Integer = 0
    Dim gESTADO As Integer = 0
    Private fila As Byte

    Private Sub frmtablavirtual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TipoDocumentoTableAdapter.Fill(Me.DataVentas.TipoDocumento)

        open()
        command = connection.CreateCommand()
        sSsql = "Select IdVendedor, Nombre From Vendedor Where IdUsuario='" & gUSER & "'"
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        datatbl.Read()
        gIdVendedor = datatbl(0)
        txtVendedor.Text = datatbl(1)
        close_conexion()

        Carga_Insumos_Ventas(cmb_Insumos)
        Carga_Familia_Prod(cmb_Familia_Prod)
        Carga_Variedad(cmb_Variedad)
        gTipo_Venta = 0
        gIdInsumo = 0
        gIdVtahead = 0
        FormatoImpresion.Alignment = StringAlignment.Far
        cmb_TIPODOC.SelectedIndex = -1
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim i As Integer
        Dim bAgregaGrilla As Boolean = True

        If Val(txt_IDcliente.Text) = 0 Then
            MsgBox("Debe Seleccionar Cliente !!!", MsgBoxStyle.Critical, "Documento de Venta")
            bAgregaGrilla = False
        End If

        If cmb_TIPODOC.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Tipo de Documento!!!", MsgBoxStyle.Critical, "Documento de Venta")
            bAgregaGrilla = False
        End If

        If Not rb1_VentaGuia.Checked AndAlso Not rb2_insumo.Checked AndAlso Not rb3NotaCredito.Checked Then
            MsgBox("Debe Seleccionar Tipo de Venta", MsgBoxStyle.Critical, "Documento de Venta")
            bAgregaGrilla = False
        End If

        If bAgregaGrilla AndAlso sTipoDoc = "NC" Then
            If Val(txtIdVtaDetNC.Text) = 0 Then
                MsgBox("Debe Seleccionar Documento de Venta para la Nota de Crédito !!!", MsgBoxStyle.Critical, "Documento de Venta")
                bAgregaGrilla = False
            End If

            If txtCantidadBandejasNC.Value <= 0 Then
                MsgBox("Cantidad de Bandejas a Devolver debe ser mayor a cero !!!", MsgBoxStyle.Critical, "Documento de Venta")
                bAgregaGrilla = False
            End If
            If bAgregaGrilla Then
                Agrega_Guias(2)
            End If
        End If

        If rb1_VentaGuia.Checked AndAlso bAgregaGrilla Then
            Dim HayGuiaSeleccionada As Boolean = False
            For i = 0 To DataGuias.Rows.Count - 1
                If DataGuias.Rows(i).Cells(0).Value Then
                    HayGuiaSeleccionada = True
                End If
            Next
            If Not HayGuiaSeleccionada Then
                MsgBox("Debe Seleccionar Guía a Facturar!!!", MsgBoxStyle.Critical, "Documento de Venta")
                bAgregaGrilla = False
            End If

            If HayGuiaSeleccionada AndAlso bAgregaGrilla Then
                Agrega_Guias(0)
            End If
        End If

        If rb2_insumo.Checked AndAlso bAgregaGrilla Then
            If cmb_Insumos.SelectedIndex = -1 AndAlso cmb_Familia_Prod.SelectedIndex = -1 Then
                MsgBox("Debe Seleccionar Insumo o Familia y Variedad de Producto")
                bAgregaGrilla = False
            End If
            If Val(txt_precio.Text) = 0 Then
                MsgBox("Falta Ingresar Precio Unitario!!!", MsgBoxStyle.Critical, "Documento de Venta")
                bAgregaGrilla = False
            End If
            If Val(txt_Cantidad.Text) <= 0 Then
                MsgBox("Falta Ingresar Cantidad!!!", MsgBoxStyle.Critical, "Documento de Venta")
                bAgregaGrilla = False
            End If
            If bAgregaGrilla Then
                Agrega_Guias(1)
            End If
        End If
    End Sub
    Private Sub Agrega_Guias(itipo As Integer)
        'Agrega Guías en forma automatica desde grilla Guias
        Dim i As Integer
        Dim x As Integer

        Dim dPrecio As Double
        Dim dCantidad As Double
        '        DataGrilla.Rows.Clear()
        Select Case itipo
            Case 0
                For i = 0 To DataGuias.Rows.Count - 1
                    If DataGuias.Rows(i).Cells(0).Value Then
                        If Not ExisteGuiaenGrilla(DataGuias.Rows(i).Cells(1).Value) Then
                            dPrecio = Val(Reemplaza_Comas(DataGuias.Rows(i).Cells("PrecioGuia").Value))
                            dCantidad = Val(DataGuias.Rows(i).Cells("CantidadGuia").Value)
                            DataGrilla.Rows.Add()
                            x = DataGrilla.Rows.Count - 1
                            DataGrilla.Rows(x).Cells(0).Value = DataGuias.Rows(i).Cells(1).Value.ToString()
                            DataGrilla.Rows(x).Cells(1).Value = DataGuias.Rows(i).Cells("EspecieGuia").Value
                            DataGrilla.Rows(x).Cells(2).Value = DataGuias.Rows(i).Cells("VariedadGuia").Value
                            DataGrilla.Rows(x).Cells(3).Value = ""
                            DataGrilla.Rows(x).Cells(4).Value = ""
                            DataGrilla.Rows(x).Cells(5).Value = Reemplaza_Comas(DataGuias.Rows(i).Cells("PrecioGuia").Value)
                            DataGrilla.Rows(x).Cells(6).Value = DataGuias.Rows(i).Cells("CantidadGuia").Value
                            DataGrilla.Rows(x).Cells(7).Value = Math.Round(dPrecio * dCantidad, 0, MidpointRounding.AwayFromZero)
                            DataGrilla.Rows(x).Cells(8).Value = "Guia N°:" & DataGuias.Rows(i).Cells(1).Value.ToString()
                            DataGrilla.Rows(x).Cells(9).Value = "0"
                            DataGrilla.Rows(x).Cells("IdVtaDetNC").Value = 0
                            DataGrilla.Rows(x).Cells("Indice").Value = x
                            DataGrilla.Rows(x).Cells("PromedioPlantasNC").Value = 0
                            DataGrilla.Rows(x).Cells("CantidadBandejasNC").Value = 0
                            DataGrilla.Rows(x).Cells("IdVtaDet").Value = 0
                        Else
                            MsgBox("Guía N° " & DataGuias.Rows(i).Cells(1).Value & " ya se encuentra asignada al Documento de Venta", MsgBoxStyle.Critical, "Documento de Venta")
                        End If
                    End If
                Next

                chk_SelectAll.Checked = False

            Case 1
                'Venta sin Guías
                If cmb_Familia_Prod.SelectedIndex > -1 Then
                    DataGrilla.Rows.Add()
                    i = DataGrilla.Rows.Count - 1
                    DataGrilla.Rows(i).Cells(0).Value = "0"
                    DataGrilla.Rows(i).Cells(1).Value = cmb_Familia_Prod.Text
                    DataGrilla.Rows(i).Cells(2).Value = cmb_Variedad.Text
                    DataGrilla.Rows(i).Cells(3).Value = ""
                    DataGrilla.Rows(i).Cells(4).Value = ""
                    DataGrilla.Rows(i).Cells(5).Value = Reemplaza_Comas(txt_precio.Text)
                    DataGrilla.Rows(i).Cells(6).Value = txt_Cantidad.Text
                    DataGrilla.Rows(i).Cells(7).Value = Math.Round(Val(Reemplaza_Comas(txt_precio.Text)) * Val(txt_Cantidad.Text), 0, MidpointRounding.AwayFromZero)
                    DataGrilla.Rows(i).Cells(8).Value = txt_Glosa.Text
                    DataGrilla.Rows(i).Cells(9).Value = "0"
                    DataGrilla.Rows(i).Cells("IdVtaDetNC").Value = 0
                    DataGrilla.Rows(i).Cells("Indice").Value = i
                    DataGrilla.Rows(i).Cells("PromedioPlantasNC").Value = 0
                    DataGrilla.Rows(i).Cells("CantidadBandejasNC").Value = 0
                    DataGrilla.Rows(i).Cells("IdVtaDet").Value = 0
                Else
                    'Venta de Insumos
                    DataGrilla.Rows.Add()
                    i = DataGrilla.Rows.Count - 1
                    DataGrilla.Rows(i).Cells(0).Value = "0"
                    DataGrilla.Rows(i).Cells(3).Value = cmb_Insumos.Text
                    DataGrilla.Rows(i).Cells(4).Value = txt_unidad.Text
                    DataGrilla.Rows(i).Cells(5).Value = Reemplaza_Comas(txt_precio.Text)
                    DataGrilla.Rows(i).Cells(6).Value = txt_Cantidad.Text
                    DataGrilla.Rows(i).Cells(7).Value = Math.Round(Val(Reemplaza_Comas(txt_precio.Text)) * Val(txt_Cantidad.Text), 0, MidpointRounding.AwayFromZero)
                    DataGrilla.Rows(i).Cells(8).Value = txt_Glosa.Text
                    DataGrilla.Rows(i).Cells(9).Value = "1"
                    DataGrilla.Rows(i).Cells("IdVtaDetNC").Value = 0
                    DataGrilla.Rows(i).Cells("Indice").Value = i
                    DataGrilla.Rows(i).Cells("PromedioPlantasNC").Value = 0
                    DataGrilla.Rows(i).Cells("CantidadBandejasNC").Value = 0
                    DataGrilla.Rows(i).Cells("IdVtaDet").Value = 0
                End If

                cmb_Insumos.SelectedIndex = -1
                cmb_Familia_Prod.SelectedIndex = -1
                cmb_Variedad.SelectedIndex = -1
                txt_precio.Clear()
                txt_Cantidad.Clear()
                txt_Glosa.Clear()
                txtStockInsumo.Clear()
                txt_unidad.Clear()

            Case 2
                If Not ExisteGuiaenGrilla(txtGuiaNC.Text) Then
                    DataGrilla.Rows.Clear()
                    DataGrilla.Rows.Add()
                    i = 0
                    DataGrilla.Rows(i).Cells(0).Value = txtGuiaNC.Text
                    DataGrilla.Rows(i).Cells(1).Value = txtFamilia.Text
                    DataGrilla.Rows(i).Cells(2).Value = txtVariedad.Text
                    DataGrilla.Rows(i).Cells(3).Value = ""
                    DataGrilla.Rows(i).Cells(4).Value = ""
                    DataGrilla.Rows(i).Cells(5).Value = txtPrecioNeto.Text
                    DataGrilla.Rows(i).Cells(6).Value = txtPlantasDevolucionNC.Text
                    DataGrilla.Rows(i).Cells(7).Value = Math.Round(Val(txtPrecioNeto.Text) * Val(txtPlantasDevolucionNC.Text), 0, MidpointRounding.AwayFromZero)
                    DataGrilla.Rows(i).Cells(8).Value = "NOTA DE CREDITO Guia N°:" & txtGuiaNC.Text
                    DataGrilla.Rows(i).Cells(9).Value = "2"
                    DataGrilla.Rows(i).Cells("IdVtaDetNC").Value = txtIdVtaDetNC.Text
                    DataGrilla.Rows(i).Cells("Indice").Value = i
                    DataGrilla.Rows(i).Cells("PromedioPlantasNC").Value = txtPromedioPlantasNC.Text
                    DataGrilla.Rows(i).Cells("CantidadBandejasNC").Value = txtCantidadBandejasNC.Value
                    DataGrilla.Rows(i).Cells("IdVtaDet").Value = 0

                    txtTipoDocNC.Clear()
                    txtNumDocNC.Clear()
                    txtGuiaNC.Clear()
                    txtCantidadBandejasNC.Value = 0
                    txtPlantasDevolucionNC.Clear()
                    txtPromedioPlantasNC.Clear()
                    txtFamilia.Clear()
                    txtVariedad.Clear()
                    txtIdVtaDetNC.Clear()

                    btnSave.Enabled = True
                Else
                    MsgBox("Guía N° " & txtGuiaNC.Text & " ya se encuentra asignada en la Nota de Crédito!!!", MsgBoxStyle.Critical, "Documento de Venta")
                End If
        End Select
        totales()
    End Sub
    Function ExisteGuiaenGrilla(NumGuia As Integer)
        Dim bretorno = False
        Dim j As Integer = 0

        For j = 0 To DataGrilla.Rows.Count - 1
            If NumGuia = DataGrilla.Rows(j).Cells(0).Value Then
                bretorno = True
            End If
        Next

        Return bretorno
    End Function
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim bRetorno As Boolean = True
        Try
            If DataGrilla.Rows.Count > 0 Then
                fila = DataGrilla.CurrentCell.RowIndex
                If fila > -1 AndAlso DataGrilla.Rows.Count > 0 Then
                    If DataGrilla.Rows(fila).Cells("tipoventa").Value = 2 Then
                        MsgBox("No es posible Modificar Nota de Crédito!!!", MsgBoxStyle.Critical, "Documento de Venta")
                        bRetorno = False
                    Else
                        DataGrilla.Rows.RemoveAt(fila)
                    End If
                    totales()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub totales()
        Dim i As Integer
        Dim DFactor_IVA As Decimal
        Dim total, totalconiva, totaliva As Double
        Dim dettotal As Double
        DFactor_IVA = 1 + (GIVA / 100)
        For i = 0 To DataGrilla.Rows.Count - 1
            dettotal = DataGrilla.Rows(i).Cells(7).Value
            total += dettotal
        Next
        If cmb_TIPODOC.SelectedIndex = -1 Then
            MsgBox("DEBE INGRESAR TIPO Y NUMERO DE DOCUMENTO DE VENTA")
        Else
            If sTipoDoc = "BE" Then
                gTotalFinal = total
                totaliva = 0
                totalconiva = total
            Else
                totaliva = Math.Round(total * GIVA / 100, 0, MidpointRounding.AwayFromZero)
                totalconiva = Math.Round(total + totaliva, 0, MidpointRounding.AwayFromZero)
            End If

            sSsql = "SP_COnsulta_Monto_Escrito " & totalconiva.ToString
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                datatbl.Read()
                Me.txt_MontoEscrito.Text = datatbl(0)
            End If
            close_conexion()

            dTotalNeto = total
            Me.txt_TOTALNETO.Text = Format(total, "###,###,##0")
            Me.txt_IVA.Text = Format(totaliva, "########0")
            Me.txt_TOTALFINAL.Text = Format(totalconiva, "###,###,##0")
            Me.txtTotalPagos.Text = Format(dTotalPagos, "###,###,##0")
            GranTotal = totalconiva
        End If


    End Sub

    Private Sub txt_Cantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not (Char.IsDigit(e.KeyChar) OrElse Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Visible = False
    End Sub

    Function EliminaRegistros(ByVal IdVtaHead As Integer) As Boolean
        Dim bRetorno As Boolean = True
        Dim sResp = MsgBox("Confirme Eliminación de Documento de Venta", MsgBoxStyle.YesNo)
        If sResp = MsgBoxResult.Yes Then
            sSsql = "NEWSP_ELIMINA_DOCVENTA " & IdVtaHead.ToString()
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader
            'command.ExecuteNonQuery()
            datatbl.Read()
            If datatbl(0) = -1 Then
                MsgBox("No es posible eliminar Documento de Venta. Existen pagos Contabilizados!!!", MsgBoxStyle.Critical, "Documento de Venta")
                bRetorno = False
            Else
                MsgBox("Documento de Venta ha sido Eliminado!!!", MsgBoxStyle.Information, "Documento de Venta")
                LimpiaCampos()
                HabilitaCampos()
                Me.cmb_TIPODOC.Focus()
            End If
            close_conexion()
        Else
            bRetorno = False
        End If

        Return bRetorno

    End Function
    Private Sub RecuperaDocumento(IdVtaHead As Integer)
        Dim i As Integer = 0
        Dim iEstado As Integer = 0
        DataGrilla.Rows.Clear()
        sSsql = "[dbo].[NEWSP_CONSULTA_DOCVENTA] " & IdVtaHead.ToString()
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            While datatbl.Read
                If i = 0 Then
                    txt_NOM_CLI.Text = datatbl("Cliente")
                    txt_Rut_Cli.Text = FormatoRut(datatbl("RutCliente"))
                    txt_NombreClienteFactura.Text = datatbl("ClienteFactura")
                    txt_RutFactura.Text = FormatoRut(datatbl("RutFactura"))
                    txtSaldoAbono.Text = datatbl("Saldo_Abonos")
                    iEstado = datatbl("ESTADO")
                    txtVendedor.Text = datatbl("Usuario")
                    txt_IDcliente.Text = datatbl("IDCLIENTE")
                    cmb_TIPODOC.SelectedValue = datatbl("TipoDocumentoId")
                    txt_NUM_DOC.Text = datatbl("NUM_DOC")
                    dtp_FechaDoc.Value = datatbl("FECHA_DOC")
                    sTipoDoc = RetornaTipoDoc(cmb_TIPODOC.SelectedValue)
                    dTotalPagos = datatbl("TOTAL_PAGO")
                    TXT_Comentario.Text = datatbl("COMENTARIO")
                End If
                DataGrilla.Rows.Add()
                DataGrilla.Rows(i).Cells(0).Value = datatbl("IDGUIA")
                DataGrilla.Rows(i).Cells(1).Value = datatbl("Familia")
                DataGrilla.Rows(i).Cells(2).Value = datatbl("Variedad")
                DataGrilla.Rows(i).Cells(3).Value = datatbl("Insumo")
                DataGrilla.Rows(i).Cells(4).Value = ""
                DataGrilla.Rows(i).Cells(5).Value = datatbl("PRECIO_UNITARIO")
                DataGrilla.Rows(i).Cells(6).Value = datatbl("CANTIDAD")
                DataGrilla.Rows(i).Cells(7).Value = datatbl("TOTAL_NETO")
                DataGrilla.Rows(i).Cells(8).Value = datatbl("GLOSA")
                DataGrilla.Rows(i).Cells("tipoventa").Value = datatbl("Tipo_Venta")
                DataGrilla.Rows(i).Cells("IdVtaDetNC").Value = 0
                DataGrilla.Rows(i).Cells("Indice").Value = i
                DataGrilla.Rows(i).Cells("PromedioPlantasNC").Value = 0
                DataGrilla.Rows(i).Cells("CantidadBandejasNC").Value = 0
                DataGrilla.Rows(i).Cells("IdVtaDet").Value = datatbl("IdVtaDet")
                i += 1
            End While
        End If
        close_conexion()
        Select Case iEstado
            Case 0
                txtEstado.Text = "VIGENTE"
                btnEdit.Enabled = True
                btnDelete.Enabled = True
            Case 1
                txtEstado.Text = "NULO"
                btnEdit.Enabled = False
                btnDelete.Enabled = False
            Case 9
                txtEstado.Text = "ELIMINADO"
                btnEdit.Enabled = False
                btnDelete.Enabled = False
        End Select

        btnAgregar.Enabled = False
        btnEliminar.Enabled = False

        If dTotalPagos > 0 Then
            btnEdit.Enabled = False
            btnDelete.Enabled = False
        End If

        If sTipoDoc = "NC" Then
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            rb1_VentaGuia.Checked = False
            rb2_insumo.Checked = False
            rb3NotaCredito.Checked = True
        End If

        btnPrint.Enabled = True

        totales()
    End Sub





    Private Sub LimpiaCampos()
        gTotalFinal = 0
        Me.txt_Rut_Cli.Clear()
        Me.txt_NOM_CLI.Clear()
        Me.txt_TOTALFINAL.Clear()
        Me.txt_TOTALNETO.Clear()
        Me.txt_NUM_DOC.Clear()
        dtp_FechaDoc.Value = Now
        Me.txt_IVA.Clear()
        Me.txt_Glosa.Clear()
        cmb_Familia_Prod.SelectedIndex = -1
        cmb_Variedad.SelectedIndex = -1
        Me.txt_precio.Clear()
        Me.txt_Glosa.Clear()
        Me.txt_Cantidad.Clear()
        Me.cmb_TIPODOC.SelectedIndex = -1
        Me.cmb_Insumos.SelectedIndex = -1
        Me.txt_clientebuscar.Clear()
        DataGrilla.Rows.Clear()
        txt_Anulado.Clear()
        txt_NombreClienteFactura.Clear()
        txt_RutFactura.Clear()
        txtAbonoRebajar.Clear()
        txtSaldoAbono.Clear()
        txt_MontoEscrito.Clear()
        txtEstado.Clear()
        gIdVtahead = 0
        DataGuias.Rows.Clear()
        TXT_Comentario.Clear()
        btnAgregar.Enabled = True
        btnEliminar.Enabled = True
        txtStockInsumo.Clear()
        txt_unidad.Clear()
        chkCliente.Checked = False
        chk_CLienteFactura.Checked = False
        chk_SelectAll.Checked = False
        rb1_VentaGuia.Checked = False
        rb2_insumo.Checked = False
        rb3NotaCredito.Checked = False
        grpConGuia.Enabled = False
        grpSinGuia.Enabled = False
        txt_IDcliente.Clear()
        txtIdClienteFactura.Clear()
        txtIdVtaHead.Clear()
        txtProceso.Clear()
        txt_NUM_DOC.Clear()
        cmb_TIPODOC.SelectedIndex = -1
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LimpiaCampos()
        HabilitaCampos()
    End Sub
    Private Sub HabilitaCampos()
        dtp_FechaDoc.Enabled = True
        cmb_TIPODOC.Enabled = True
        btnBuscaCliente.Enabled = True
        chkCliente.Enabled = True
        chk_CLienteFactura.Enabled = True
        txtAbonoRebajar.Enabled = True
        rb1_VentaGuia.Enabled = True
        rb2_insumo.Enabled = True
        rb3NotaCredito.Enabled = True
        Me.btnAgregar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.txt_clientebuscar.Enabled = True
        TXT_Comentario.ReadOnly = False
    End Sub
    Private Sub InhabilitaCampos()
        dtp_FechaDoc.Enabled = False
        cmb_TIPODOC.Enabled = False
        txt_NUM_DOC.Enabled = False
        btnBuscaCliente.Enabled = False
        chkCliente.Enabled = False
        chk_CLienteFactura.Enabled = False
        txtAbonoRebajar.Enabled = False
        rb1_VentaGuia.Enabled = False
        rb2_insumo.Enabled = False
        rb3NotaCredito.Enabled = False
        Me.btnAgregar.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.txt_clientebuscar.Enabled = False
        TXT_Comentario.ReadOnly = True
    End Sub
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'CierraConexionDB()
        'Close()
        'Me.Visible = False
        Dim sResp As String
        sResp = InputBox("DESEA CERRAR VENTANA DE VENTAS", "SALIR DE VENTAS", "S")
        If UCase(sResp) = "S" Then
            close_conexion()
            Me.Close()
        End If

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaCliente.Click
        'Buscar_Cliente(Me.cmb_clientebuscar, txt_clientebuscar.Text)
        If chkCliente.Checked Then
            BusquedaCliente.chkIncluyePrimerNombre.Checked = True
        Else
            BusquedaCliente.chkIncluyePrimerNombre.Checked = False
        End If
        gQuienLlama = 12
        gNOMBRE = txt_clientebuscar.Text
        BusquedaCliente.Visible = True

        'GuiaXFacturar(txt_RUT_CLI.Text)
    End Sub

    Private Sub GuiaXFacturar(ByVal IdCliente As Integer)
        Dim i As Integer = 0
        sSsql = "NEWSP_CONSULTA_GUIA_X_FACTURAR " & IdCliente.ToString()
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        DataGuias.Rows.Clear()
        If datatbl.HasRows Then
            While datatbl.Read
                DataGuias.Rows.Add()
                DataGuias.Rows(i).Cells("Guia").Value = datatbl(0)
                DataGuias.Rows(i).Cells("EspecieGuia").Value = datatbl(15)
                DataGuias.Rows(i).Cells("VariedadGuia").Value = datatbl(16)
                DataGuias.Rows(i).Cells("PrecioGuia").Value = datatbl(9)
                DataGuias.Rows(i).Cells("CantidadGuia").Value = datatbl(36)
                DataGuias.Rows(i).Cells("BandejasGuia").Value = datatbl(6)
                DataGuias.Rows(i).Cells("FechaGuia").Value = datatbl(4)
                i += 1
            End While
        Else
            MsgBox("CLIENTE NO TIENE GUIAS POR FACTURAR")
        End If
        close_conexion()
    End Sub

    Private Sub rb1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb1_VentaGuia.CheckedChanged
        If rb1_VentaGuia.Checked Then
            grpConGuia.Enabled = True
            grpSinGuia.Enabled = False
            gTipo_Venta = 0
        End If
    End Sub

    Private Sub rb2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb2_insumo.CheckedChanged
        If rb2_insumo.Checked Then
            grpConGuia.Enabled = False
            grpSinGuia.Enabled = True
            gTipo_Venta = 1
        End If
    End Sub

    Private Sub Consulta_Correlativo_doc(ByVal sTipoDoc As String)

        sSsql = "SP_CONSULTA_Correlativo_DOC "
        sSsql += "'" & Trim(sTipoDoc) & "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        datatbl.Read()
        txt_NUM_DOC.Text = datatbl(0)
        close_conexion()

    End Sub

    Private Sub Imprime_Factura(IdVtaHead As Integer)

        If IdVtaHead > 0 Then
            ImpresionDocVenta.idvtahead.Text = IdVtaHead
            ImpresionDocVenta.Show()
        Else
            MsgBox("Debe Abrir el Documento a Imprimir", MsgBoxStyle.Information, "Documento de Venta")
        End If
    End Sub
    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Reimprime Factura
        If gIdVtahead > 0 Then
            ImpresionDocVenta.idvtahead.Text = gIdVtahead
            ImpresionDocVenta.Show()
        Else
            MsgBox("Debe Abrir el Documento a Imprimir", MsgBoxStyle.Information, "Documento de Venta")
        End If
    End Sub
    Private Sub cmb_Familia_Prod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Familia_Prod.SelectedIndexChanged
        If cmb_Familia_Prod.SelectedIndex > -1 Then
            Carga_Variedad_Filtro(cmb_Variedad, cmb_Familia_Prod.Text)
            txt_precio.ReadOnly = False
        End If
    End Sub
    Private Sub txtAbonoRebajar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAbonoRebajar.TextChanged
        If Val(txtAbonoRebajar.Text) > 0 Then
            If Val(txtAbonoRebajar.Text) <= Val(txtSaldoAbono.Text) Then
                Return
            End If
            MsgBox("Abono a Rebajar en la Venta no puede ser superior al Saldo de Abono Inicial", MsgBoxStyle.Exclamation)
            txtAbonoRebajar.Clear()
        End If
    End Sub

    Private Sub cmb_Insumos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmb_Insumos.SelectedIndexChanged
        If cmb_Insumos.SelectedIndex > -1 Then
            RescataValoresInsumo()
        End If
    End Sub
    Private Sub RescataValoresInsumo()
        sSsql = "SP_CONSULTA_Insumo "
        sSsql += "'" & cmb_Insumos.SelectedItem & "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            If IsDBNull(datatbl(4)) Then
                txt_precio.Text = 0
            Else
                txt_precio.Text = datatbl(4)
            End If
            If IsDBNull(datatbl(6)) Then
                txtStockInsumo.Text = 0
            Else
                txtStockInsumo.Text = datatbl(6)
            End If
            txt_unidad.Text = datatbl(5)
        End If
        close_conexion()
    End Sub

    Private Sub chk_SelectAll_CheckedChanged(sender As Object, e As EventArgs) Handles chk_SelectAll.CheckedChanged
        If DataGuias.Rows.Count > 0 Then
            Dim i As Integer = 0
            Dim Status As Boolean
            If chk_SelectAll.Checked Then
                Status = True
            Else
                Status = False
            End If
            For i = 0 To DataGuias.Rows.Count - 1
                DataGuias.Rows(i).Cells(0).Value = Status
            Next
        End If
    End Sub
    Private Sub txt_IDcliente_TextChanged(sender As Object, e As EventArgs) Handles txt_IDcliente.TextChanged
        If Val(txt_IDcliente.Text) > 0 AndAlso Val(txtIdVtaHead.Text) = 0 Then
            GuiaXFacturar(txt_IDcliente.Text)
        End If
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs)
        ' Habilitar datos para permitir Modificar Documento, solo se habilita si no hay pagos asociados
    End Sub


    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        btnsearch.Enabled = False
        btnSave.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnPrint.Enabled = False
        btnCancel.Visible = True
        LimpiaCampos()
        HabilitaCampos()
        txtProceso.Text = "NUEVO DOCUMENTO"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        LimpiaCampos()
        InhabilitaCampos()
        btnsearch.Enabled = True
        btnEdit.Enabled = True
        btnSave.Enabled = False
        btnDelete.Enabled = True
        btnCancel.Visible = False
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        ModificaVenta.Show()
    End Sub


    Private Sub cmb_TIPODOC_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmb_TIPODOC.SelectedIndexChanged

        If cmb_TIPODOC.SelectedIndex > -1 AndAlso Val(txtIdVtaHead.Text) = 0 Then
            If Val(txt_IDcliente.Text) > 0 Then
                sTipoDoc = RetornaTipoDoc(cmb_TIPODOC.SelectedValue)
                Consulta_Correlativo_doc(sTipoDoc)
                If sTipoDoc = "BE" Then 'Boleta Exenta de IVA
                    txt_IVA.ReadOnly = False
                Else
                    txt_IVA.ReadOnly = True
                End If
                If sTipoDoc = "NC" Then
                    grpNotaCredito.Visible = True
                    gTipo_Venta = 2
                Else
                    grpNotaCredito.Visible = False
                End If
            Else
                MsgBox("Debe seleccionar Cliente!!!", MsgBoxStyle.Critical, "Documento de Venta")
                cmb_TIPODOC.SelectedIndex = -1
            End If

        End If
    End Sub
    Private Sub btnDocumentoNC_Click(sender As Object, e As EventArgs) Handles btnDocumentoNC.Click
        ListaDocVentaCliente.Show()
    End Sub
    Private Sub txtCantidadBandejasNC_ValueChanged(sender As Object, e As EventArgs) Handles txtCantidadBandejasNC.ValueChanged
        txtPlantasDevolucionNC.Text = Math.Round(Val(txtCantidadBandejasNC.Text) * txtPromedioPlantasNC.Text, 0, MidpointRounding.AwayFromZero)
    End Sub

    Private Sub txtCantidadBandejasNC_LostFocus(sender As Object, e As EventArgs) Handles txtCantidadBandejasNC.LostFocus
        txtPlantasDevolucionNC.Text = Math.Round(Val(txtCantidadBandejasNC.Text) * txtPromedioPlantasNC.Text, 0, MidpointRounding.AwayFromZero)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If Val(txtAbonoRebajar.Text) > GranTotal Then
            MsgBox("Monto a Rebajar del Abono Inicial no puede ser mayor al Valor del Documento", MsgBoxStyle.Critical)
        Else
            If DataGrilla.Rows.Count > 0 Then
                Dim i As Integer = 0
                Dim IdVtaHead As Integer = Val(txtIdVtaHead.Text)
                iNumeDoc = Val(Me.txt_NUM_DOC.Text)

                ' Asignar siempre valor Indice = 0 a la primera fila
                DataGrilla.Rows(0).Cells("Indice").Value = 0
                open()

                For i = 0 To DataGrilla.Rows.Count - 1
                    sSsql = "NEWSP_GRABA_DOCUMENTOVENTA "
                    sSsql += IdVtaHead.ToString() & ","
                    sSsql += gIdVendedor.ToString() & ","
                    sSsql += Val(txt_IDcliente.Text).ToString() & ","
                    sSsql += GranTotal.ToString() & ","
                    sSsql += "'" & Format(dtp_FechaDoc.Value, "d") & "',"
                    sSsql += iNumeDoc.ToString() & ","
                    sSsql += "'" & sTipoDoc & "',"
                    sSsql += "'" & TXT_Comentario.Text & "',"
                    sSsql += Val(txtIdClienteFactura.Text).ToString() & ","
                    sSsql += dTotalNeto.ToString() & ","
                    sSsql += "'" & gUSER & "',"
                    sSsql += Val(txtAbonoRebajar.Text).ToString & ","
                    sSsql += gESTADO.ToString() & ","
                    sSsql += DataGrilla.Rows(i).Cells("IdVtaDetNC").Value.ToString() & ","
                    sSsql += "'" & DataGrilla.Rows(i).Cells("Familia").Value & "',"
                    sSsql += "'" & DataGrilla.Rows(i).Cells("Variedad").Value & "',"
                    sSsql += DataGrilla.Rows(i).Cells("Cantidad").Value.ToString() & ","
                    sSsql += DataGrilla.Rows(i).Cells("preciounit").Value.ToString() & ","
                    sSsql += "'" & DataGrilla.Rows(i).Cells("Glosa").Value & "',"
                    sSsql += DataGrilla.Rows(i).Cells("numguia").Value.ToString() & ","
                    sSsql += DataGrilla.Rows(i).Cells("tipoventa").Value.ToString() & ","
                    sSsql += "'" & DataGrilla.Rows(i).Cells("Insumo").Value & "',"
                    sSsql += DataGrilla.Rows(i).Cells("Indice").Value.ToString() & ","
                    sSsql += DataGrilla.Rows(i).Cells("PromedioPlantasNC").Value.ToString() & ","
                    sSsql += DataGrilla.Rows(i).Cells("CantidadBandejasNC").Value.ToString()

                    command = connection.CreateCommand
                    command.CommandText = sSsql
                    datatbl.Close()
                    datatbl = command.ExecuteReader()
                    If datatbl.HasRows Then
                        datatbl.Read()
                        IdVtaHead = datatbl(0)
                    End If
                Next
                close_conexion()
                ' Permite Imprimir Documento grabado
                If IdVtaHead > 0 Then
                    Dim sResp = MsgBox("Desea imprimir Documento ?", MsgBoxStyle.YesNo)
                    If sResp = MsgBoxResult.Yes Then
                        Imprime_Factura(IdVtaHead)
                    End If
                End If
                LimpiaCampos()
                InhabilitaCampos()
                btnsearch.Enabled = True
                btnEdit.Enabled = False
                btnSave.Enabled = False
                btnDelete.Enabled = False
                btnCancel.Visible = False
            Else
                MsgBox("No existen datos para guardar!!!", MsgBoxStyle.Critical, "Documento de Venta")
            End If
        End If
    End Sub

    Private Sub txtIdVtaHead_TextChanged_1(sender As Object, e As EventArgs) Handles txtIdVtaHead.TextChanged
        If Val(txtIdVtaHead.Text) > 0 Then
            RecuperaDocumento(Val(txtIdVtaHead.Text))
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        HabilitaCampos()
        cmb_TIPODOC.Enabled = False
        btnSave.Enabled = True
        txtProceso.Text = "MODIFICACIÓN DE DOCUMENTO"
        txt_clientebuscar.Enabled = False
        chkCliente.Enabled = False
        chk_CLienteFactura.Enabled = False
        btnBuscaCliente.Enabled = False
    End Sub

    Private Sub chk_CLienteFactura_CheckedChanged(sender As Object, e As EventArgs) Handles chk_CLienteFactura.CheckedChanged
        If chk_CLienteFactura.Checked Then
            grpOtroCliente.Visible = True
        Else
            grpOtroCliente.Visible = False
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        txtProceso.Text = "ELIMINACIÓN DE DOCUMENTO"
        If Val(txtIdVtaHead.Text) > 0 Then
            EliminaRegistros(Val(txtIdVtaHead.Text))
        Else
            MsgBox("No ha seleccionado ningún Documento de Venta!!!", MsgBoxStyle.Critical, "Documento de Venta")
        End If
    End Sub

    Private Sub rbNotaCredito_CheckedChanged(sender As Object, e As EventArgs) Handles rb3NotaCredito.CheckedChanged
        If rb3NotaCredito.Checked Then
            cmb_TIPODOC.SelectedValue = 3
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Imprime_Factura(Val(txtIdVtaHead.Text))
    End Sub
End Class