Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class Pedidos
    Dim FormatoImpresion As New StringFormat

    'Dim sCODPROD(0 To 0) As String
    'Dim aINGREDIENTE(0 To 0) As String
    'Dim aING_PCOSTO(0 To 0) As Double
    'Dim aING_DESCRIP(0 To 0) As String
    'Dim aING_UNIDAD(0 To 0) As String
    Dim gPrecioVenta1 As Double
    Dim gPrecioVenta2 As Double
    Dim gPrecioVentaFinal As Double
    Dim gCostoNeto As Double
    Dim gPEDIDO As Integer
    Dim gTOTAL_NETO As Double
    Dim gTOTAL_PEDIDO As Double
    Dim gValorSemillaAplicado As Double
    Dim gTotalLote As Double

    Dim gAbono_Inicial As Double
    Dim gAbonoSugerido As Double

    'Precio
    'Dim aIDTipoBandeja(0 To 0) As Double
    'Dim PRECIO(0 To 0) As String
    'Dim gPrecio_Producto As Double
    'Dim gVARIEDAD(0 To 0) As String
    Dim pCantidadPlantas As Integer

    ' Datos Clientes
    Dim zRut(0 To 0) As String
    Dim zIDCliente(0 To 0) As Integer
    Dim zSector(0 To 0) As String


    'Arreglos para Imprimir Nota de Pedido
    Dim gDIRECCION As String
    Dim gCOMUNA As String
    Dim gCIUDAD As String
    Dim gTELEFONO As String
    Dim gGIRO As String

    Private Sub Pedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim style As DataGridViewCellStyle = New DataGridViewCellStyle()
        Carga_Forma_Entrega()
        Carga_Familia_Prod(Me.cmb_Familia)
        Carga_Tipo_Bandeja(Me.cmb_TipoBandeja)
        'Carga_Lista_Pedidos(cmb_Pedido)
        'Carga_lista_Vendedor(Me.cmbVendedor)
        gPEDIDO = 0
        LimpiaCampos()
        style.Alignment = DataGridViewContentAlignment.BottomRight

        style.ForeColor = Color.Black
        style.BackColor = Color.White
        style.SelectionBackColor = Color.LightBlue
        style.SelectionForeColor = Color.Black

        For Each column As DataGridViewColumn In DataGrilla.Columns
            column.DataGridView.RowsDefaultCellStyle = style
        Next
        FormatoImpresion.Alignment = StringAlignment.Far

        Deshabilita_Campos()

    End Sub

    Private Sub Carga_Forma_Entrega()
        Dim i As Integer
        Dim slista As String
        sSsql = "SP_CONSULTA_FULL_FORMAENTREGA"
        '0 IdFormaEntrega
        '1 DESCRIPCION
        '2 COSTO_FLETE
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then

            While datatbl.Read
                ReDim Preserve FE_CODIGO(0 To i)
                ReDim Preserve FE_DESCRIP(0 To i)
                ReDim Preserve FE_COSTO_FLETE(0 To i)

                FE_CODIGO(i) = datatbl(0)
                FE_DESCRIP(i) = datatbl(1).ToString
                FE_COSTO_FLETE(i) = datatbl(2)
                slista = FE_DESCRIP(i)
                Me.cmb_FormaEntrega.Items.Add(slista)
                i += 1
            End While

        End If
        datatbl.Close()
        close_conexion()
    End Sub


    Private Sub txt_FECHA_INICIO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub
    Private Sub cmb_TipoBandeja_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TipoBandeja.SelectedIndexChanged
        If cmb_TipoBandeja.SelectedIndex >= 0 Then
            txt_CantBandejas.Text = Calculo_Bandejas(pCantidadPlantas, TB_CANTIDAD(cmb_TipoBandeja.SelectedIndex))
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregaLote.Click
        ' Consulta_Proveedor()
        Agrega_Lote()
        Calcula_Totales()
    End Sub
    Private Sub Consulta_Proveedor()
        sSsql = "SP_CONSULTA_Proveedor_Variedad "
        sSsql += "'" & Me.cmb_variedad.Text & "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If Not datatbl.HasRows Then
            MsgBox("Recuerde Ingresar Proveedor para Variedad " & cmb_variedad.Text, MsgBoxStyle.Information)
        End If
        datatbl.Close()
        close_conexion()
    End Sub
    Private Sub Agrega_Lote()
        Dim i As Integer
        Dim bControlLote As Boolean = True
        ' Agrega LOTE al Carro

        If dtp_Fecha_Inicio.Value < Now.Date Then
            MsgBox("FECHA DE SIEMBRA NO PUEDE SER ANTERIOR A HOY!!!", MsgBoxStyle.Exclamation)
            bControlLote = False
        End If
        If Format(dtp_Fecha_Inicio.Value, "yyyyMMdd") = Format(dtp_FechaEntrega.Value, "yyyyMMdd") Then
            MsgBox("FECHA DE SIEMBRA NO DEBE SER IDENTICA A FECHA DE ENTREGA!!!", MsgBoxStyle.Exclamation)
            bControlLote = False
        End If
        If pCantidadPlantas <= 0 Then
            MsgBox("DEBE INGRESAR CANTIDAD DE PLANTAS", MsgBoxStyle.Critical)
            bControlLote = False
        End If

        If Me.cmb_variedad.SelectedIndex = -1 Then
            MsgBox("DEBE SELECCIONAR VARIEDAD", MsgBoxStyle.Critical)
            bControlLote = False
        End If

        If cmb_aportasemilla.SelectedIndex = -1 Then
            MsgBox("DEBE SELECCIONAR APORTE DE SEMILLA", MsgBoxStyle.Critical)
            bControlLote = False
        End If

        If cmb_aportasemilla.Text = "SI" AndAlso Not chkSemillaCorriente.Checked AndAlso Not chkSemillaCertificada.Checked Then
            MsgBox("DEBE MARCAR OPCION PARA TIPO DE SEMILLA DEL CLIENTE. Corriente o Certificada", MsgBoxStyle.Critical)
            bControlLote = False
        End If
        If Val(Reemplaza_Comas(txt_PrecioVenta.Text)) <= 0 Then
            MsgBox("PRECIO DE VENTA DEL LOTE NO PUEDE SER MENOR O IGUAL A CERO!!!", MsgBoxStyle.Critical)
            bControlLote = False
        End If

        If bControlLote Then
            DataGrilla.Rows.Add()
            i = DataGrilla.Rows.Count - 1
            DataGrilla.Rows(i).Cells(1).Value = Format(dtp_Fecha_Inicio.Value, "d")
            DataGrilla.Rows(i).Cells(2).Value = Format(dtp_FechaEntrega.Value, "d")
            DataGrilla.Rows(i).Cells(3).Value = Val(Reemplaza_Comas(txt_CantBandejas.Text))
            DataGrilla.Rows(i).Cells(4).Value = Me.cmb_Familia.Text
            DataGrilla.Rows(i).Cells(5).Value = Me.cmb_variedad.Text
            DataGrilla.Rows(i).Cells(6).Value = pCantidadPlantas
            DataGrilla.Rows(i).Cells(7).Value = Format(Val(Reemplaza_Comas(txt_PrecioVenta.Text)), "#,###.00")
            DataGrilla.Rows(i).Cells(8).Value = gTotalLote
            DataGrilla.Rows(i).Cells(9).Value = cmb_TipoBandeja.Text
            DataGrilla.Rows(i).Cells(10).Value = 0
            DataGrilla.Rows(i).Cells(11).Value = txt_LoteSemilla.Text
            DataGrilla.Rows(i).Cells(12).Value = txt_Batch.Text
            DataGrilla.Rows(i).Cells(13).Value = txt_FechaEnvasado.Text
            DataGrilla.Rows(i).Cells(14).Value = cmb_aportasemilla.Text
            If chkSemillaCorriente.Checked Then
                DataGrilla.Rows(i).Cells(15).Value = "SI"
            Else
                DataGrilla.Rows(i).Cells(15).Value = "NO"
            End If
            If chkSemillaCertificada.Checked Then
                DataGrilla.Rows(i).Cells(16).Value = "SI"
            Else
                DataGrilla.Rows(i).Cells(16).Value = "NO"
            End If
            'cmb_Familia.SelectedIndex = -1
            'cmb_aportasemilla.SelectedIndex = -1
            'cmb_variedad.SelectedIndex = -1
            'cmb_TipoBandeja.SelectedIndex = -1
            'txtDias_INV.Clear()
            'txtDias_OTO.Clear()
            'txtDias_PRI.Clear()
            'txtDias_VER.Clear()
            txtProveedor.Clear()
            txtUltActualizacion.Clear()
            txt_Batch.Clear()
            txt_CantBandejas.Clear()
            txt_Cantidad.Clear()
            txt_DetalleVariedad.Clear()
            txt_diasprecocidad.Clear()
            txt_FechaEnvasado.Clear()
            txt_LoteSemilla.Clear()
            'txt_Ndias_Fabricacion.Clear()
            txt_PrecioVenta.Clear()
            txt_StockDispo.Clear()
            txt_Temporada.Clear()
            txt_TipoDescarga.Clear()
            txt_totallote.Clear()
            MT_StockActual.Clear()

        End If
    End Sub
    Private Sub Calcula_Totales()
        Dim i As Integer
        Dim dTotalNeto As Double
        Dim dTotalIVA As Double
        Dim dTotalPedido As Double
        Dim dAbonoSugerido As Double
        dTotalNeto = 0
        For i = 0 To DataGrilla.Rows.Count - 1
            dTotalNeto += DataGrilla.Rows(i).Cells(8).Value
        Next
        dTotalPedido = Math.Round(dTotalNeto * gFactorIVA, 0, MidpointRounding.AwayFromZero)
        dTotalIVA = dTotalPedido - dTotalNeto
        dAbonoSugerido = Math.Round(dTotalPedido / 2, 0, MidpointRounding.AwayFromZero)
        txt_totalneto.Text = Format(dTotalNeto, "###,###,##0")
        txt_TotalIVA.Text = Format(dTotalIVA, "###,###,##0")
        txt_TotalPedido.Text = Format(dTotalPedido, "###,###,##0")
        txtAbonoSugerido.Text = Format(dAbonoSugerido, "###,###,##0")
        gTOTAL_NETO = dTotalNeto
        gTOTAL_PEDIDO = dTotalPedido
        gAbonoSugerido = dAbonoSugerido
    End Sub

    Private Sub txt_Descuento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Calcula_Totales()
    End Sub

    Private Sub txt_TotalAbono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Calcula_Totales()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminaLote.Click
        'ELIMINA N° DE LOTE
        Dim fila As Integer
        Dim sResp As String
        Dim bPermiteEliminar As Boolean = False
        Dim bTipoLote As Integer = 0
        fila = DataGrilla.CurrentRow.Index
        If DataGrilla.Rows(fila).Cells("LoteOriginal").Value > 0 And DataGrilla.Rows(fila).Cells("Estado").Value < 4 Then
            ' Lote Hijo y Estado indica que no ha sido entregado, permite eliminar
            bPermiteEliminar = True
            bTipoLote = 1
        ElseIf DataGrilla.Rows(fila).Cells("Estado").Value = 0 Then
            ' Lote original debe estar en estado=0 para eliminar
            bPermiteEliminar = True
            bTipoLote = 2
        End If
        If DataGrilla.Rows(fila).Cells("Lotes_Hijos").Value <> "" Then
            MsgBox("Lote Contiene Lotes Hijos : " & DataGrilla.Rows(fila).Cells("Lotes_Hijos").Value, MsgBoxStyle.Critical)
            bPermiteEliminar = False
        End If
        If Val(DataGrilla.Rows(fila).Cells(0).Value) > 0 Then
            If bPermiteEliminar Then
                sResp = InputBox("ESTA SEGURO DE ELIMINAR N° DE LOTE: " & Str(DataGrilla.Rows(fila).Cells(0).Value), "ELIMINACION DE N° DE LOTE", "N")
                If UCase(sResp) = "S" Then
                    sSsql = "SP_ELIMINA_PEDIDO_DETALLE " & Str(DataGrilla.Rows(fila).Cells(0).Value)
                    open()
                    command = connection.CreateCommand()
                    command.CommandText = sSsql
                    command.ExecuteNonQuery()
                    close_conexion()
                    If fila > -1 AndAlso DataGrilla.Rows.Count > 0 Then
                        DataGrilla.Rows.RemoveAt(fila)
                        Calcula_Totales()
                    End If
                End If
            Else
                If bTipoLote = 1 Then
                    MsgBox("NO ES POSIBLE ELIMINAR!!!. Lote Hijo debe estar en estado solo hasta Aviso Cliente. Estado Actual : " & DataGrilla.Rows(fila).Cells("Estado_Lote").Value)
                Else
                    MsgBox("NO ES POSIBLE ELIMINAR!!!. Lote Original debe estar en Estado Nuevo. Estado Actual : " & DataGrilla.Rows(fila).Cells("Estado_Lote").Value)
                End If
            End If
        Else
            If fila > -1 AndAlso DataGrilla.Rows.Count > 0 Then
                DataGrilla.Rows.RemoveAt(fila)
                Calcula_Totales()
            End If
        End If
    End Sub
    Private Sub Graba_Lote(ByVal IdPedido As Integer)
        ' GRABA LOTE
        Dim i As Integer
        Dim dPorcion As Decimal
        open()
        command = connection.CreateCommand()
        For i = 0 To DataGrilla.Rows.Count - 1
            If DataGrilla.Rows(i).Cells(0).Value = 0 Then
                dPorcion = DataGrilla.Rows(i).Cells(8).Value / gTOTAL_NETO
                sSsql = "SP_GRABA_PEDIDO_DETALLE "
                sSsql += "'" & DataGrilla.Rows(i).Cells(5).Value & "',"
                sSsql += Str(IdPedido) & ","
                sSsql += Str(DataGrilla.Rows(i).Cells(6).Value) & ","
                sSsql += Reemplaza_Comas(DataGrilla.Rows(i).Cells(7).Value) & ","
                sSsql += "'" & DataGrilla.Rows(i).Cells(9).Value & "',"
                sSsql += Str(DataGrilla.Rows(i).Cells(3).Value) & ","
                sSsql += "0,"
                sSsql += "'" & CDate(DataGrilla.Rows(i).Cells(1).Value) & "','"
                sSsql += CDate(DataGrilla.Rows(i).Cells(2).Value) & "',"
                sSsql += Str(DataGrilla.Rows(i).Cells(8).Value) & ","
                sSsql += "'" & DataGrilla.Rows(i).Cells(11).Value & "',"
                sSsql += "'" & DataGrilla.Rows(i).Cells(12).Value & "',"
                sSsql += "'" & DataGrilla.Rows(i).Cells(13).Value & "',"
                sSsql += "'" & DataGrilla.Rows(i).Cells(14).Value & "',"
                sSsql += "0,"
                sSsql += "'" & DataGrilla.Rows(i).Cells(4).Value & "',"
                If DataGrilla.Rows(i).Cells(15).Value = "SI" Then
                    sSsql += "1"
                Else
                    sSsql += "0"
                End If
                command.CommandText = sSsql
                command.ExecuteNonQuery()
            End If
        Next
        close_conexion()
    End Sub

    Private Function Graba_Pedido() As Integer
        Dim iFormaEntrega As Integer
        Dim iIdVendedor As Integer
        Dim iIDPEDIDO As Integer
        If Val(txtIdPedido.Text) > 0 Then
            iIDPEDIDO = Val(txtIdPedido.Text)
        Else
            iIDPEDIDO = 0
        End If
        If Valida_Pedido() Then
            open()
            command = connection.CreateCommand()
            'iIdVendedor = ID_Vendedor(cmbVendedor.SelectedIndex)
            sSsql = "Select IdVendedor From Vendedor Where IdUsuario='" & gUSER & "'"
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            datatbl.Read()
            iIdVendedor = datatbl(0)
            datatbl.Close()
            iFormaEntrega = FE_CODIGO(cmb_FormaEntrega.SelectedIndex)
            Calcula_Totales()
            ' gAbono_Inicial = Val(txt_totalabono.Text)
            sSsql = "SP_GRABA_PEDIDO_HEADER " & Str(Val(txt_IDCliente.Text)) & "," & Str(iFormaEntrega) & "," & Str(iIdVendedor) & ","
            sSsql += "'" & Format(dtp_Fecha_Pedido.Value, "d") & "',"
            sSsql += "'" & txt_LUGAR_ENTREGA.Text & "','" & txt_Comentarios.Text & "',"
            sSsql += Str(gTOTAL_NETO) & "," & Str(gTOTAL_PEDIDO) & "," & iIDPEDIDO.ToString & ","
            sSsql += "'" & gUSER & "',"
            sSsql += "Null,"
            If chkExcepcion.Checked Then
                sSsql += "1,"
                sSsql += "'" & txtMotivoExcepcion.Text & "'"
            Else
                sSsql += "0,"
                sSsql += "Null"
            End If
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                datatbl.Read()
                iIDPEDIDO = datatbl(0)
                datatbl.Close()
            Else
                iIDPEDIDO = 0
            End If
            close_conexion()
        End If
        Return iIDPEDIDO
    End Function
    Private Function Valida_Pedido() As Boolean
        bOK = True
        If cmb_FormaEntrega.SelectedIndex = -1 Then
            MsgBox("FORMA DE ENTREGA NO SELECCIONADO")
            bOK = False
        End If

        If txt_NombreCliente.Text = "" Then
            MsgBox("CLIENTE NO IDENTIFICADO")
            bOK = False
        End If

        'If gPEDIDO > 0 Then
        '    MsgBox("ATENCION!!!. Solo se grabará el Abono Inicial y los Comentarios para un Pedido con Siembra iniciada.", MsgBoxStyle.Information)
        'End If

        'If cmbVendedor.SelectedIndex = -1 Then
        '    MsgBox("Debe Seleccionar Vendedor", MsgBoxStyle.Exclamation)
        '    bOK = False
        'End If

        If DataGrilla.Rows.Count = 0 Then
            MsgBox("Pedido No tiene Lotes Ingresados!!!", MsgBoxStyle.Exclamation)
            bOK = False
        End If
        Return bOK
    End Function
    Private Sub Habilita_Campos()
        btnBuscaCliente.Enabled = True
        cmb_FormaEntrega.Enabled = True
        'cmbVendedor.Enabled = True
        cmb_TipoBandeja.Enabled = True
        cmb_aportasemilla.Enabled = True
        cmb_variedad.Enabled = True
        cmb_Familia.Enabled = True
        txt_clientebuscar.ReadOnly = False
        txt_CantBandejas.ReadOnly = False
        txt_Cantidad.ReadOnly = False
        txt_Comentarios.ReadOnly = False
        txt_LUGAR_ENTREGA.ReadOnly = False
        txt_PrecioVenta.ReadOnly = False
        txt_LoteSemilla.ReadOnly = False
        txt_Batch.ReadOnly = False
        txt_FechaEnvasado.ReadOnly = False
        dtp_FechaEntrega.Enabled = True

    End Sub
    Private Sub Deshabilita_Campos()
        btnBuscaCliente.Enabled = False
        cmb_FormaEntrega.Enabled = False
        'cmbVendedor.Enabled = False
        cmb_TipoBandeja.Enabled = False
        cmb_aportasemilla.Enabled = False
        cmb_variedad.Enabled = False
        cmb_Familia.Enabled = False
        txt_clientebuscar.ReadOnly = True
        txt_CantBandejas.ReadOnly = True
        txt_Cantidad.ReadOnly = True
        txt_Comentarios.ReadOnly = True
        txt_LUGAR_ENTREGA.ReadOnly = True
        txt_PrecioVenta.ReadOnly = True
        txt_LoteSemilla.ReadOnly = True
        txt_Batch.ReadOnly = True
        txt_FechaEnvasado.ReadOnly = True
        dtp_FechaEntrega.Enabled = False
    End Sub
    Private Sub LimpiaCampos()
        txtIdPedido.Clear()
        cmb_FormaEntrega.SelectedIndex = -1
        'cmbVendedor.SelectedIndex = -1
        cmb_TipoBandeja.SelectedIndex = -1
        cmb_aportasemilla.SelectedIndex = -1
        cmb_variedad.SelectedIndex = -1
        cmb_Familia.SelectedIndex = -1
        txt_clientebuscar.Clear()
        txt_CantBandejas.Clear()
        txt_Cantidad.Clear()
        txt_Comentarios.Clear()
        txt_IDCliente.Clear()
        txt_LUGAR_ENTREGA.Clear()
        txt_Ndias_Fabricacion.Clear()
        txt_PrecioVenta.Clear()
        txt_RUT_CLI.Clear()
        txt_TotalIVA.Clear()
        txt_totalneto.Clear()
        txt_TotalPedido.Clear()
        txt_NombreCliente.Clear()
        txt_LoteSemilla.Clear()
        txt_Batch.Clear()
        txt_FechaEnvasado.Clear()
        txt_totallote.Clear()
        DataGrilla.Rows.Clear()
        txt_DetalleVariedad.Clear()
        txt_diasprecocidad.Clear()
        txt_Temporada.Clear()
        txt_TipoDescarga.Clear()
        gStockDispo = 0
        gDetalleVariedad = ""
        txt_StockDispo.Clear()
        txtIdUsuario.Clear()
        chkSemillaCorriente.Checked = False
        chkSemillaCorriente.Visible = False
        chkSemillaCertificada.Checked = False
        chkSemillaCertificada.Visible = False
        lblDeuda.Visible = False
        txtTotalDeuda.Visible = False
        txtNotas.Clear()
        chkSemillaCertificada.Checked = False
        chkSemillaCertificada.Visible = False
        MT_StockActual.Clear()
        MT_PedidosPendientes.Clear()
        txtUltActualizacion.Clear()
        dtp_Fecha_Inicio.Value = Now
        dtp_FechaEntrega.Value = Now
        txtProveedor.Clear()
    End Sub
    Private Sub Cerrar()
        close_conexion()
        Me.Close()
        Me.Visible = False
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cerrar()
    End Sub

    Private Sub Rescata_Datos_cliente()
        sSsql = "SP_LECTURA_CLIENTE " & Str(Val(txt_IDCliente.Text))
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            gSectorDireccion = datatbl(12)
        End If
        datatbl.Close()
        close_conexion()
    End Sub
    Public Sub Recupera_Pedido(ByVal IDPedido As Integer)
        Dim i As Integer
        Dim IdCliente As Integer
        sSsql = "SP_CONSULTA_PEDIDO " & Str(IDPedido)
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            'cmbVendedor.Text = datatbl(5)
            dtp_Fecha_Pedido.Value = datatbl(6)
            cmb_FormaEntrega.Text = datatbl(4)
            txt_LUGAR_ENTREGA.Text = datatbl(8)
            txt_NombreCliente.Text = datatbl(3)
            IdCliente = datatbl(1)
            txt_RUT_CLI.Text = Format(Val(Mid(datatbl(2), 1, 11)), "###,###,###") & "-" & Mid(datatbl(2), 12, 1)
            txt_Comentarios.Text = IIf(IsDBNull(datatbl(9)), "", datatbl(9))
            txt_totalneto.Text = datatbl(10).ToString
            gDIRECCION = datatbl(12).ToString
            gCOMUNA = datatbl(13).ToString
            gCIUDAD = datatbl(14).ToString
            gTELEFONO = datatbl(15).ToString
            gGIRO = datatbl(16).ToString
            txtEstadoPedido.Text = "Estado :" & datatbl("EstadoPedido")
            If datatbl("estadopedidoid") = 3 Then
                chkExcepcion.Checked = True
                txtMotivoExcepcion.Text = datatbl("MotivoExcepcion")
            Else
                chkExcepcion.Checked = False
                txtMotivoExcepcion.Clear()
            End If
            If IsDBNull(datatbl(17)) Then
                gAbono_Inicial = 0
            Else
                gAbono_Inicial = datatbl(17)
            End If
            txtAbonoInicial.Text = Format(gAbono_Inicial, "###,###,###")
            txtIdUsuario.Text = datatbl(18)
            txtNotas.Text = datatbl(19)
            If datatbl("estadopedidoid") = 1 OrElse datatbl("estadopedidoid") = 2 Then 'Pendiente, Excepción
                btnExcepcion.Enabled = True
                btnsave.Enabled = True
                Habilita_Campos()
                btnAgregaLote.Enabled = True
                btnEliminaLote.Enabled = True
                btnAbono.Enabled = True
                btnPrintCustomer.Enabled = True
                btnPrintInternal.Enabled = True
            End If
            If datatbl("estadopedidoid") = 3 Then 'Aprobado
                btnExcepcion.Enabled = False
                btnsave.Enabled = False
                Deshabilita_Campos()
                btnAgregaLote.Enabled = False
                btnEliminaLote.Enabled = False
                btnAbono.Enabled = False
                btnPrintCustomer.Enabled = True
                btnPrintInternal.Enabled = True
                btn_CrearLoteHijo.Enabled = False
            End If
            If datatbl("estadopedidoid") = 4 Then 'Rechazado
                btnExcepcion.Enabled = False
                btnsave.Enabled = False
                Deshabilita_Campos()
                btnAgregaLote.Enabled = False
                btnEliminaLote.Enabled = False
                btnAbono.Enabled = False
                btnPrintCustomer.Enabled = True
                btnPrintInternal.Enabled = True
                btn_CrearLoteHijo.Enabled = False
            End If
            If datatbl("estadopedidoid") = 5 Then ' Cerrado
                btnExcepcion.Enabled = False
                btnsave.Enabled = False
                Deshabilita_Campos()
                btnAgregaLote.Enabled = False
                btnEliminaLote.Enabled = False
                btnAbono.Enabled = False
                btnPrintCustomer.Enabled = True
                btnPrintInternal.Enabled = True
                btn_CrearLoteHijo.Enabled = False
            End If

        End If
        datatbl.Close()
        gPEDIDO = IDPedido
        sSsql = "SP_CONSULTA_PEDIDO_DETALLE " & Str(gPEDIDO)
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        DataGrilla.Rows.Clear()
        If datatbl.HasRows Then
            i = 0
            While datatbl.Read
                If datatbl("ESTADO") <> 9 Then
                    DataGrilla.Rows.Add()
                    DataGrilla.Rows(i).Cells(0).Value = datatbl("IdPedidodet")
                    DataGrilla.Rows(i).Cells(1).Value = datatbl("fec_ini")
                    DataGrilla.Rows(i).Cells(2).Value = datatbl("fec_ent")
                    DataGrilla.Rows(i).Cells(3).Value = datatbl("Cant_Bandeja")
                    ''familia
                    DataGrilla.Rows(i).Cells(4).Value = datatbl("Especie")
                    ''variedad
                    DataGrilla.Rows(i).Cells(5).Value = datatbl("Variedad")
                    DataGrilla.Rows(i).Cells(6).Value = datatbl("CANTIDAD")
                    DataGrilla.Rows(i).Cells(7).Value = datatbl("Precio_Neto")
                    DataGrilla.Rows(i).Cells(8).Value = datatbl("TOTAL_LOTE")
                    DataGrilla.Rows(i).Cells(9).Value = datatbl("Bandeja")
                    DataGrilla.Rows(i).Cells(10).Value = datatbl("ESTADO")
                    DataGrilla.Rows(i).Cells(11).Value = datatbl("Lote_Semilla")
                    DataGrilla.Rows(i).Cells(12).Value = datatbl("Batch")
                    DataGrilla.Rows(i).Cells(13).Value = datatbl("fec_env")
                    DataGrilla.Rows(i).Cells(14).Value = datatbl("Aporta_Semilla")
                    DataGrilla.Rows(i).Cells(15).Value = datatbl("SemillaCorriente")
                    DataGrilla.Rows(i).Cells(16).Value = datatbl("SemillaCertificada")
                    DataGrilla.Rows(i).Cells("LoteOriginal").Value = datatbl("Nro_Lote_Original")
                    DataGrilla.Rows(i).Cells("Lotes_Hijos").Value = datatbl("Lotes_Hijos")
                    DataGrilla.Rows(i).Cells("Estado_Lote").Value = datatbl("Estado_Lote")
                    i += 1
                End If

            End While
        Else
            MsgBox("PEDIDO N° " & Str(gPEDIDO) & " NO CONTIENE LOTES")
        End If
        datatbl.Close()
        close_conexion()
        'Recupera deuda cliente
        txt_IDCliente.Text = IdCliente
        Calcula_Totales()
    End Sub

    Private Sub NotaInterna()
        REM Imprime Nota de Pedido Interna
        If Val(txtIdPedido.Text) = 0 Then
            MsgBox("Debe ingresar N° de Pedido a Imprimir", MsgBoxStyle.Exclamation, "Imprimir Nota de Pedido")
        Else
            For i As Integer = 0 To DataGrilla.Rows.Count - 1
                If DataGrilla.Rows(i).Cells(0).Value = 0 Then
                    MsgBox("Debe Grabar Pedido antes de Imprimir!", MsgBoxStyle.Exclamation, "Imprimir Nota de Pedido")
                Else
                    gNumPedido = Val(txtIdPedido.Text)
                    DetallePedidoInterno.Show()
                End If
            Next
        End If
    End Sub
    Private Sub Genera_Nota_Pedido(ByVal sender As System.Object, ByVal ePrint As PrintPageEventArgs)

        '' Impresión Nota de Pedido
        Dim sTitulo1, sTitulo2 As String
        Dim iTamanoLetra1 As Integer
        Dim iTamanoLetra2 As Integer
        Dim iTamanoLetra3 As Integer
        Dim iLinea As Integer
        Dim iCol As Integer
        Dim dTotalNeto As Double
        Dim dDescAbono As Double
        Dim dCantidad As Double
        Dim dPrecio As Double
        ' Dim dDescuento As Double
        Dim dAbono As Double
        'Dim dFlete As Double
        Dim gDescAbono As Double
        Dim gFlete As Double
        Dim gTotalPedidoNeto As Double

        Dim sTipoLetra As String
        Dim sLogo As String
        Dim sDataEmpFono As String


        Rescata_Datos_cliente()

        dAbono = gAbono_Inicial
        sTitulo1 = "Detalle de Venta "
        sTitulo2 = "N° Pedido: " & txtIdPedido.Text
        sLogo = gDataEmp
        sDataEmpFono = gDataEmpFono
        iTamanoLetra1 = 8
        iTamanoLetra2 = 10
        iTamanoLetra3 = 12
        sTipoLetra = "Arial"
        iLinea = 5
        ePrint.Graphics.DrawString(sTitulo1, New Font("Arial Narrow", iTamanoLetra3, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 50, iLinea)
        iLinea += 10
        ePrint.Graphics.DrawLine(Pens.Black, 155, iLinea, 555, iLinea)
        iLinea += 10

        ePrint.Graphics.DrawString(sLogo, New Font("High Tower Text", 14, FontStyle.Regular, GraphicsUnit.Point), Brushes.Green, 1, iLinea)
        iLinea += 20
        ePrint.Graphics.DrawString(sDataEmpFono, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 1, iLinea)
        iLinea += 20
        ePrint.Graphics.DrawString(Format(Now, "dd-MMM-yyyy"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        iLinea += 20
        'ePrint.Graphics.DrawString(sTitulo, New Font("Arial Narrow", iTamanoLetra3, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 40, iLinea)
        iLinea += 20
        ePrint.Graphics.DrawString("Cliente : " & Mid(txt_NombreCliente.Text, 1, 30), New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        iLinea += 12
        ePrint.Graphics.DrawString(Mid(txt_NombreCliente.Text, 31), New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        iLinea += 20
        ePrint.Graphics.DrawString("Rut : " & txt_RUT_CLI.Text, New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        iLinea += 20
        ePrint.Graphics.DrawString("Dirección : " & gDIRECCION, New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        iLinea += 20
        ePrint.Graphics.DrawString("Comuna : " & gCOMUNA, New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        iLinea += 20
        ePrint.Graphics.DrawString("Teléfono : " & gTELEFONO, New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        iLinea += 20
        ePrint.Graphics.DrawString("Sector : " & gSectorDireccion, New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        iLinea += 20
        ePrint.Graphics.DrawString("Giro : " & gGIRO, New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        iLinea += 20
        ePrint.Graphics.DrawString("Abono Inicial : " & Format(dAbono, "###,###,##0"), New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)

        '' Detalle del Lote
        ''N° Lote	Familia	Variedad	Fec.Inicio	Fec.Entrega	Unidades	Valor Unit.	Desc+Abono	Flete	Total	Tipo Band.

        'ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 280, iLinea)
        'iLinea += 10
        'iCol = 5
        'ePrint.Graphics.DrawString("N° Lote:", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        'iCol += 50
        'ePrint.Graphics.DrawString("Familia", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        'iCol += 70
        'ePrint.Graphics.DrawString("Variedad", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        'iCol += 90
        'ePrint.Graphics.DrawString("Fec.Inicio", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        'iCol += 70
        'ePrint.Graphics.DrawString("Fec.Entrega", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        'iCol += 70
        'ePrint.Graphics.DrawString("Unidades", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        'iCol += 50
        'ePrint.Graphics.DrawString("Valor Unit.", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        'iCol += 70
        'ePrint.Graphics.DrawString("Total", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        'iCol += 55
        'ePrint.Graphics.DrawString("Tipo Band.", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        'iCol += 70
        'ePrint.Graphics.DrawString("Lote Semilla", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        'iCol += 80
        'ePrint.Graphics.DrawString("Batch", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        'iCol += 40
        'ePrint.Graphics.DrawString("Fec.Env.", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        'iCol += 50
        'ePrint.Graphics.DrawString("Semilla", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        'iLinea += 15
        'ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 815, iLinea)
        'iLinea += 10


        gDescAbono = 0
        gFlete = 0
        gTotalPedidoNeto = 0

        iLinea += 20

        For i As Integer = 0 To DataGrilla.Rows.Count - 1
            ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 280, iLinea)
            iCol = 5
            ePrint.Graphics.DrawString("Lote:", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol += 45
            dCantidad = DataGrilla.Rows(i).Cells(6).Value
            dPrecio = DataGrilla.Rows(i).Cells(7).Value
            dTotalNeto = DataGrilla.Rows(i).Cells(8).Value
            ePrint.Graphics.DrawString(DataGrilla.Rows(i).Cells(0).Value, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol += 15
            'ePrint.Graphics.DrawString("Familia:", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            'iCol += 40
            ePrint.Graphics.DrawString(DataGrilla.Rows(i).Cells(4).Value, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol += 70
            'ePrint.Graphics.DrawString("Variedad:", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            'iCol += 50
            ePrint.Graphics.DrawString(Mid(DataGrilla.Rows(i).Cells(5).Value, 1, 12), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)

            iLinea += 15
            iCol = 5
            ePrint.Graphics.DrawString("F.Inicio:", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol += 50
            ePrint.Graphics.DrawString(DataGrilla.Rows(i).Cells(1).Value, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol += 70
            ePrint.Graphics.DrawString("F.Entrega:", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol += 55
            ePrint.Graphics.DrawString(DataGrilla.Rows(i).Cells(2).Value, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)

            iLinea += 15
            iCol = 50
            ePrint.Graphics.DrawString("Unidades:", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol = 180
            ePrint.Graphics.DrawString(Format(dCantidad, "###,###,##0"), New Font(iTamanoLetra1, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea, FormatoImpresion)
            iCol += 10
            ePrint.Graphics.DrawString(DataGrilla.Rows(i).Cells(9).Value, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol = 50
            iLinea += 15
            ePrint.Graphics.DrawString("Valor Unit.:", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol = 180
            ePrint.Graphics.DrawString(Format(dPrecio, "###,##0.00"), New Font(iTamanoLetra1, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea, FormatoImpresion)
            iCol = 50
            iLinea += 15
            ePrint.Graphics.DrawString("Total Lote :", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol = 180
            ePrint.Graphics.DrawString(Format(dTotalNeto, "###,###,##0"), New Font(iTamanoLetra1, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea, FormatoImpresion)
            iLinea += 15



            'ePrint.Graphics.DrawString(DataGrilla.Rows(i).Cells(9).Value, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            'iCol += 70
            'ePrint.Graphics.DrawString(IIf(IsDBNull(DataGrilla.Rows(i).Cells(11).Value), "0", DataGrilla.Rows(i).Cells(11).Value), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            'iCol += 80
            'ePrint.Graphics.DrawString(IIf(IsDBNull(DataGrilla.Rows(i).Cells(12).Value), "0", DataGrilla.Rows(i).Cells(12).Value), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            'iCol += 45
            'ePrint.Graphics.DrawString(IIf(IsDBNull(DataGrilla.Rows(i).Cells(13).Value), "0", DataGrilla.Rows(i).Cells(13).Value), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            'iCol += 60
            'ePrint.Graphics.DrawString(DataGrilla.Rows(i).Cells(14).Value, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)

            gDescAbono += dDescAbono
            gTotalPedidoNeto += dTotalNeto

        Next
        ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 280, iLinea)
        '' linea de totales
        iLinea += 8
        iCol = 50
        ePrint.Graphics.DrawString("Total Neto :", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 180
        ePrint.Graphics.DrawString(Format(gTotalPedidoNeto, "###,###,##0"), New Font(iTamanoLetra1, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea, FormatoImpresion)

        iLinea += 20

        '' resumen formulario
        ePrint.Graphics.DrawString("Observaciones:" & Mid(txt_Comentarios.Text, 1, 120), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        iLinea += 15
        ePrint.Graphics.DrawString(Mid(txt_Comentarios.Text, 120, 120), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        iLinea += 25
        ePrint.Graphics.DrawString("Valores unitarios no incluyen IVA.", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        iLinea += 20
        ePrint.Graphics.DrawString(".....................................", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 100, iLinea)
        iLinea += 10
        ePrint.Graphics.DrawString("Firma Cliente", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 130, iLinea)
        iLinea += 30
        ePrint.Graphics.DrawString("Para retirar sus plantas deberá dejar un abono por", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        iLinea += 12
        ePrint.Graphics.DrawString("bandeja hasta su devolución.", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        ePrint.HasMorePages = False
    End Sub
    Function Calcula_Lote()
        gTotalLote = Math.Round(pCantidadPlantas * gPrecioVentaFinal, 0, MidpointRounding.AwayFromZero)
        txt_totallote.Text = Format(gTotalLote, "###,###,##0")
        Return True
    End Function

    Private Sub txt_Cantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cantidad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_Comentarios.Focus()
        End If
    End Sub

    Private Sub txt_Cantidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Cantidad.LostFocus
        pCantidadPlantas = Val(txt_Cantidad.Text)
        Calcula_Lote()
        txt_CantBandejas.Text = Math.Round(pCantidadPlantas / TB_CANTIDAD(cmb_TipoBandeja.SelectedIndex), 1, MidpointRounding.AwayFromZero)
        If Val(txt_CantBandejas.Text) < 1 Then
            txt_CantBandejas.Text = 1
        End If

        Consulta_Pedidos_FechaInicio()
    End Sub

    Private Sub txt_Descuento_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Calcula_Lote()
    End Sub

    Private Sub txt_totalabono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub txt_totalabono_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Calcula_Lote()
    End Sub

    Private Sub txt_COSTO_FLETE_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Calcula_Lote()
    End Sub
    Private Sub cmb_Familia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Familia.SelectedIndexChanged
        If cmb_Familia.SelectedIndex >= 0 Then
            Carga_Variedad_Filtro(Me.cmb_variedad, Me.cmb_Familia.Text)
            Rescata_Precio()
            'Me.txt_Ndias_Fabricacion.Text = aDias_Fabricacion(Me.cmb_Familia.SelectedIndex)
        End If
    End Sub
    Private Sub Rescata_Precio()
        If Me.cmb_TipoBandeja.SelectedIndex = -1 Then
            MsgBox("DEBE SELECCIONAR TIPO DE BANDEJA")
            Me.cmb_TipoBandeja.Focus()
        Else
            sSsql = "NEWSP_CONSULTA_PRECIO_Venta "
            sSsql += "'" & cmb_TipoBandeja.Text & "',"
            sSsql += "'" & cmb_Familia.Text & "',"
            sSsql += "'" & dtp_FechaEntrega.Value & "'"
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                datatbl.Read()
                gPrecioVenta1 = datatbl(0) ' Precio_Venta_INV
                gPrecioVenta2 = datatbl(1) ' Precio_Especial
                txt_Ndias_Fabricacion.Text = datatbl(2)
                txtDias_INV.Text = datatbl("Dias_Fabrica_INV")
                txtDias_OTO.Text = datatbl("Dias_Fabrica_OTO")
                txtDias_PRI.Text = datatbl("Dias_Fabrica_PRI")
                txtDias_VER.Text = datatbl("Dias_Fabrica_VER")

                'nDiasFabricacion = Val(txt_Ndias_Fabricacion.Text) * -1
                dtp_FechaEntrega.Value = DateAdd(DateInterval.Day, Val(txt_Ndias_Fabricacion.Text), dtp_Fecha_Inicio.Value)
                'dtp_Fecha_Inicio.Value = DateAdd(DateInterval.Day, nDiasFabricacion, dtp_FechaEntrega.Value)
            Else
                gPrecioVenta1 = 0
                gPrecioVenta2 = 0
                'dtp_FechaEntrega.Value = dtp_Fecha_Inicio.Value
            End If
            datatbl.Close()
            Calcula_Precio()
            close_conexion()

        End If
    End Sub
    Private Sub Calcula_Precio()
        Dim ValorPorcentual As Double
        If rb_PrecioVentaLista.Checked Then
            gPrecioVentaFinal = gPrecioVenta1 + gValorSemillaAplicado
        End If
        If rb_PrecioVentaEspecial.Checked Then
            gPrecioVentaFinal = gPrecioVenta2 + gValorSemillaAplicado
        End If

        If Val(txtDescto.Text) > 0 Then
            ValorPorcentual = Math.Round(gPrecioVentaFinal * Val(txtDescto.Text) / 100, 2, MidpointRounding.AwayFromZero)
            If chkAumDis.Checked Then
                REM % de Aumento
                gPrecioVentaFinal += ValorPorcentual
            Else
                REM % de Dosminución
                gPrecioVentaFinal -= ValorPorcentual
            End If
        End If

        Me.txt_PrecioVenta.Text = gPrecioVentaFinal
        'Me.txt_PrecioVenta.ReadOnly = True
        Calcula_Lote()
    End Sub
    Private Sub cmb_aportasemilla_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_aportasemilla.SelectedIndexChanged
        If cmb_aportasemilla.Text = "NO" Then
            chkSemillaCorriente.Visible = False
            chkSemillaCorriente.Checked = False
            chkSemillaCertificada.Visible = False
            chkSemillaCertificada.Checked = False
            txt_Comentarios.Clear()
        Else
            chkSemillaCorriente.Visible = True
            chkSemillaCertificada.Visible = True
        End If

        Aplica_Valor_Semilla()
    End Sub

    Private Sub cmb_variedad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_variedad.SelectedIndexChanged
        Carga_Valor_Semilla(Me.cmb_Familia, Me.cmb_variedad)
        Aplica_Valor_Semilla()
        'txt_DetalleVariedad.Text = gDetalleVariedad
        txt_StockDispo.Text = Format(gStockDispo, "###,###,###")
        txtUltActualizacion.Text = gFechaActualizacion
        MT_StockActual.Text = Format(gStockActual, "###,###,###")
        MT_PedidosPendientes.Text = Format(gStockReservado, "###,###,###")
        If cmb_variedad.SelectedIndex > -1 Then
            Lectura_Parametros_Variedad()
        End If
    End Sub
    Private Sub Lectura_Parametros_Variedad()
        sSsql = "SP_CONSULTA_Valores_Variedad "
        sSsql += "'" & cmb_variedad.Text & "'"
        txtProveedor.Text = "NO DEFINIDO"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            txt_DetalleVariedad.Text = datatbl(1)
            txtProveedor.Text = datatbl(7)
            If IsDBNull(datatbl(4)) Then
                txt_TipoDescarga.Text = "No Def."
            Else
                Select Case datatbl(4)
                    Case 1
                        txt_TipoDescarga.Text = "Rápida"
                    Case 2
                        txt_TipoDescarga.Text = "Lenta"
                End Select
            End If

            If IsDBNull(datatbl(5)) Then
                txt_Temporada.Text = "No Def."
            Else
                Select Case datatbl(5)
                    Case 1
                        txt_Temporada.Text = "Temprano"
                    Case 2
                        txt_Temporada.Text = "Intermedio"
                    Case 3
                        txt_Temporada.Text = "Tarde"
                End Select
            End If
            If datatbl(6) = 0 Then
                txt_diasprecocidad.Text = 1
            Else
                txt_diasprecocidad.Text = datatbl(6)
            End If

        End If
        close_conexion()
    End Sub

    Private Sub Aplica_Valor_Semilla()
        If cmb_aportasemilla.Text = "NO" Then
            gValorSemillaAplicado = gPrecioSemilla
        Else
            gValorSemillaAplicado = 0

        End If
        Calcula_Precio()

    End Sub

    Private Sub txt_FECHA_PEDIDO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txt_clientebuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_clientebuscar.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txt_LUGAR_ENTREGA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_LUGAR_ENTREGA.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub txt_Comentarios_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub
    Private Sub Elimina_Pedido()
        ''SP_ELIMINA_PEDIDO_HEADER
        Dim sResp As String
        Dim IdPedido As Integer

        IdPedido = Val(txtIdPedido.Text)
        If IdPedido >= 0 Then
            sResp = InputBox("CONFIRME ELIMINACION DE PEDIDO #" & Format(IdPedido, "######"), "ELIMINACION DE PEDIDO", "S")
            If UCase(sResp) = "S" Then
                sSsql = "SP_ELIMINA_PEDIDO_HEADER "
                sSsql += Str(IdPedido)
                open()
                command = connection.CreateCommand()
                command.CommandText = sSsql
                datatbl = command.ExecuteReader()
                If datatbl.HasRows Then
                    datatbl.Read()
                    If datatbl(0) = 1 Then
                        MsgBox("NO ES POSIBLE ELIMINAR PEDIDO #" & Format(IdPedido, "######") & ". EXISTEN LOTES EN PROCESO.")
                    Else
                        MsgBox("PEDIDO #" & Format(IdPedido, "######") & " HA SIDO ELIMINADO DEL SISTEMA.")
                    End If
                End If
                close_conexion()
                LimpiaCampos()
            End If
        Else
            MsgBox("No se ha Seleccionado ningún Pedido para Eliminar", MsgBoxStyle.Critical, "Pedidos")
        End If
    End Sub
    Private Sub rb_PrecioVentaLista_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_PrecioVentaLista.Click
        Calcula_Precio()
    End Sub
    Private Sub rb_PrecioVentaEspecial_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_PrecioVentaEspecial.Click
        Calcula_Precio()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CrearLoteHijo.Click
        CreaLoteHijo.Show()
    End Sub
    Private Sub rb_PrecioVentaEspecial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_PrecioVentaEspecial.CheckedChanged
        If rb_PrecioVentaEspecial.Checked Then
            txt_PrecioVenta.ReadOnly = False
        End If
    End Sub
    Private Sub rb_PrecioVentaLista_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_PrecioVentaLista.CheckedChanged
        If rb_PrecioVentaLista.Checked Then
            txt_PrecioVenta.ReadOnly = True
        End If
    End Sub

    Private Sub txt_PrecioVenta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_PrecioVenta.LostFocus
        gPrecioVentaFinal = Val(txt_PrecioVenta.Text)
        Calcula_Lote()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaCliente.Click
        If chkCliente.Checked Then
            BusquedaCliente.chkIncluyePrimerNombre.Checked = True
        Else
            BusquedaCliente.chkIncluyePrimerNombre.Checked = False
        End If
        gNOMBRE = txt_clientebuscar.Text
        gQuienLlama = 2
        BusquedaCliente.Visible = True
    End Sub

    Function RecuperaDeudaCliente(IdCliente As Integer) As Double
        Dim dTotalDeduas As Double = 0
        sSsql = "Select dbo.FX_Obtiene_Total_Deuda_Cliente(" & IdCliente.ToString & ")"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            dTotalDeduas = datatbl(0)
        End If
        close_conexion()
        Return dTotalDeduas
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        gQuienLlama = 1
        Visualiza_PDF.Visible = True
    End Sub

    Private Sub txtDescto_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescto.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 13 Then
            e.Handled = False
            txt_PrecioVenta.Focus()
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtDescto_LostFocus(sender As Object, e As System.EventArgs) Handles txtDescto.LostFocus
        If txtDescto.Text <> Nothing Then
            If Val(txtDescto.Text) < 0 Then
                MsgBox("Valor % Descuento debe ser positivo.", MsgBoxStyle.Exclamation)
                txtDescto.Text = Nothing
                txtDescto.Focus()
            Else
                Calcula_Precio()
            End If
        End If
    End Sub
    Private Sub chkAumDis_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkAumDis.CheckedChanged
        Calcula_Precio()
    End Sub
    Private Sub chkSemillaCorriente_CheckedChanged(sender As Object, e As EventArgs) Handles chkSemillaCorriente.CheckedChanged
        If chkSemillaCorriente.Checked AndAlso Not chkSemillaCertificada.Checked Then
            txt_Comentarios.Text = "Semilla No Certificada. Me comprometo a cancelar mínimo un 90% de las plantas sembradas con Semillas Corrientes."
        Else
            txt_Comentarios.Clear()
        End If
    End Sub
    Private Sub txt_IDCliente_TextChanged(sender As Object, e As EventArgs) Handles txt_IDCliente.TextChanged
        Dim sMensaje As String
        Dim dMontoDeuda As Double
        If Val(txt_IDCliente.Text) > 0 Then
            dMontoDeuda = RecuperaDeudaCliente(txt_IDCliente.Text)
            If dMontoDeuda > 0 Then
                sMensaje = "CLIENTE CON DEUDA PENDIENTE." & vbCrLf & " MONTO DEUDA $" & Format(dMontoDeuda, "###,###,###")
                MsgBox(sMensaje)
                txtTotalDeuda.Text = Format(dMontoDeuda, "###,###,###")
                lblDeuda.Visible = True
                txtTotalDeuda.Visible = True
            Else
                lblDeuda.Visible = False
                txtTotalDeuda.Visible = False
            End If

            ' valida cliente bloqueado!
            If Val(txtEstadoclienteId.Text) = 2 Then
                gQuienLlama = 2
                ClienteBloqueado.Show()
            End If

        End If
    End Sub
    Private Sub Consulta_Pedidos_FechaInicio()
        Dim i As Integer
        Dim iRetorno As Integer
        Dim iMaximoPedido As Integer
        Dim iTotalPedidos As Integer
        Dim iNuevoPedido As Integer
        sSsql = "SP_Valida_Maximo_Pedidos_FechaInicio "
        sSsql += "'" & dtp_Fecha_Inicio.Value & "',"
        If Val(txt_Cantidad.Text) = 0 Then
            sSsql += "0"
        Else
            sSsql += txt_Cantidad.Text.ToString
        End If
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            iRetorno = datatbl(0)
            iMaximoPedido = datatbl(1)
        End If
        close_conexion()
        If iRetorno = 0 Then
            ResumenPedidoDiario.Text = "EXCEDE MAXIMO DIARIO DE " & iMaximoPedido.ToString
            iNuevoPedido = Val(txt_Cantidad.Text)
            ResumenPedidoDiario.txtFecha.Text = dtp_Fecha_Inicio.Value
            ResumenPedidoDiario.txtNuevoPedido.Text = Format(iNuevoPedido, "###,###,###")
            sSsql = "SP_CONSULTA_PEDIDOS_FechaInicio "
            sSsql += "'" & dtp_Fecha_Inicio.Value & "'"
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                While datatbl.Read
                    ResumenPedidoDiario.dgPedidos.Rows.Add()
                    i = ResumenPedidoDiario.dgPedidos.Rows.Count - 1
                    ResumenPedidoDiario.dgPedidos.Rows(i).Cells(0).Value = datatbl(0)
                    ResumenPedidoDiario.dgPedidos.Rows(i).Cells(1).Value = datatbl(1)
                    ResumenPedidoDiario.dgPedidos.Rows(i).Cells(2).Value = datatbl(2)
                    ResumenPedidoDiario.dgPedidos.Rows(i).Cells(3).Value = datatbl(3)
                    ResumenPedidoDiario.dgPedidos.Rows(i).Cells(4).Value = datatbl(4)
                    ResumenPedidoDiario.dgPedidos.Rows(i).Cells(5).Value = datatbl(5)
                    iTotalPedidos += datatbl(5)
                End While
            End If
            close_conexion()
            ResumenPedidoDiario.txtPedidosFecha.Text = Format(iTotalPedidos, "###,###,###")
            iTotalPedidos += Val(txt_Cantidad.Text)
            ResumenPedidoDiario.txtTotalPedidos.Text = Format(iTotalPedidos, "###,###,###")
            ResumenPedidoDiario.Show()
        End If
    End Sub

    Private Sub dtp_FechaEntrega_LostFocus(sender As Object, e As EventArgs) Handles dtp_FechaEntrega.LostFocus

        Dim añoReferencia As Integer = 2000
        Dim fechaNormalizada As Date = New Date(añoReferencia, dtp_FechaEntrega.Value.Month, dtp_FechaEntrega.Value.Day)
        Dim nDiasPrevios As Integer = 0
        ' Definición de los rangos de temporada (sin importar el año real)
        Dim invIni As Date = New Date(añoReferencia, 6, 21)
        Dim invFin As Date = New Date(añoReferencia, 9, 20)

        Dim priIni As Date = New Date(añoReferencia, 9, 21)
        Dim priFin As Date = New Date(añoReferencia, 12, 20)

        Dim verIni1 As Date = New Date(añoReferencia, 12, 21)
        Dim verFin1 As Date = New Date(añoReferencia, 12, 31)
        Dim verIni2 As Date = New Date(añoReferencia, 1, 1)
        Dim verFin2 As Date = New Date(añoReferencia, 3, 20)

        Dim otoIni As Date = New Date(añoReferencia, 3, 21)
        Dim otoFin As Date = New Date(añoReferencia, 6, 20)

        If fechaNormalizada >= invIni AndAlso fechaNormalizada <= invFin Then
            nDiasPrevios = Val(txtDias_INV.Text) * -1
            txt_Ndias_Fabricacion.Text = txtDias_INV.Text
        ElseIf fechaNormalizada >= priIni AndAlso fechaNormalizada <= priFin Then
            nDiasPrevios = Val(txtDias_PRI.Text) * -1
            txt_Ndias_Fabricacion.Text = txtDias_PRI.Text
        ElseIf fechaNormalizada >= otoIni AndAlso fechaNormalizada <= otoFin Then
            nDiasPrevios = Val(txtDias_OTO.Text) * -1
            txt_Ndias_Fabricacion.Text = txtDias_OTO.Text
        ElseIf (fechaNormalizada >= verIni1 AndAlso fechaNormalizada <= verFin1) OrElse
               (fechaNormalizada >= verIni2 AndAlso fechaNormalizada <= verFin2) Then
            nDiasPrevios = Val(txtDias_VER.Text) * -1
            txt_Ndias_Fabricacion.Text = txtDias_VER.Text
        End If
        dtp_Fecha_Inicio.Value = DateAdd(DateInterval.Day, nDiasPrevios, dtp_FechaEntrega.Value)
        If Format(dtp_Fecha_Inicio.Value, "yyyyMMdd") < Format(Now.Date, "yyyyMMdd") AndAlso Format(dtp_FechaEntrega.Value, "yyyyMMdd") > Format(Now.Date, "yyyyMMdd") Then
            MsgBox("Error en Fecha de Siembra. No debe ser anterior a hoy. Modifique Fecha de Entrega.", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles btnAbono.Click
        LlamaAbonoPedido()
    End Sub

    Private Sub LlamaAbonoPedido()
        If txt_RUT_CLI.Text = Nothing OrElse txt_IDCliente.Text = Nothing Then
            MsgBox("Debe Seleccionar Cliente para ingresar Abono", MsgBoxStyle.Critical, "Pedido")
        Else
            gQuienLlama = 90
            gRutCli = txt_RUT_CLI.Text
            Abono_Deuda.txt_RUT_CLI.Text = txt_RUT_CLI.Text
            Abono_Deuda.txt_IdCliente.Text = txt_IDCliente.Text
            Abono_Deuda.txt_NombreCliente.Text = txt_NombreCliente.Text
            Abono_Deuda.Recupera_Datos_Cliente()
            Abono_Deuda.txtIdPedido.Text = txtIdPedido.Text
            'If gAbonoSugerido > 0 Then
            'Abono_Deuda.txt_MontoDoc.Text = gAbonoSugerido
            'End If

            Abono_Deuda.Show()
        End If

    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        LimpiaCampos()
        Habilita_Campos()
        dtp_Fecha_Pedido.Focus()
        gPEDIDO = 0
        btnsave.Enabled = True
        btnAgregaLote.Enabled = True
        btnEliminaLote.Enabled = True
        btnExcepcion.Enabled = True

        btnSearch.Enabled = False
        btn_CrearLoteHijo.Enabled = False
        btnAbono.Enabled = False
        btnPrintCustomer.Enabled = False
        btnPrintInternal.Enabled = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim iNro_Pedido As Integer = 0
        Dim sMensaje As String
        open()
        iNro_Pedido = Graba_Pedido()
        If iNro_Pedido > 0 Then
            Graba_Lote(iNro_Pedido)
            'Carga_Lista_Pedidos(cmb_Pedido)
            'cmb_Pedido.Enabled = True
            'LimpiaCampos()
            MsgBox("SE HA GRABADO PEDIDO N° " & Str(iNro_Pedido))
            gPEDIDO = iNro_Pedido
            Recupera_Pedido(gPEDIDO)
            txtIdPedido.Text = iNro_Pedido
            'Resetea_Botones()
            'Deshabilita_Campos()
            If Val(txtAbonoInicial.Text) = 0 Then
                sMensaje = "El abono correspondiente para este pedido es de: $ " & Format(gAbonoSugerido, "###,###,###") & ". ¿Desea registrar el abono ahora?"
                Dim sResp = MsgBox(sMensaje, MsgBoxStyle.YesNo, "Pedidos")
                If sResp = MsgBoxResult.Yes Then
                    LlamaAbonoPedido()
                End If
            End If



        End If
        close_conexion()
    End Sub

    Private Sub Resetea_Botones()
        btnAbono.Enabled = False
        btnAgregaLote.Enabled = False
        btnBuscaCliente.Enabled = False
        btnEliminaLote.Enabled = False
        btnExcepcion.Enabled = False
        btnPrintCustomer.Enabled = False
        btnPrintInternal.Enabled = False
        btnsave.Enabled = False
        btnSearch.Enabled = True
        btn_CrearLoteHijo.Enabled = True
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ListaPedidos.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Elimina_Pedido()
        Resetea_Botones()
        Deshabilita_Campos()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btnPrintCustomer.Click
        REM Imprime Nota de Pedido
        If Val(txtIdPedido.Text) = 0 Then
            MsgBox("Debe ingresar N° de Pedido a Imprimir", MsgBoxStyle.Exclamation, "Imprimir Nota de Pedido")
        Else
            For i As Integer = 0 To DataGrilla.Rows.Count - 1
                If DataGrilla.Rows(i).Cells(0).Value = 0 Then
                    MsgBox("Debe Grabar Pedido antes de Imprimir!", MsgBoxStyle.Exclamation, "Imprimir Nota de Pedido")
                Else
                    gNumPedido = Val(txtIdPedido.Text)
                    DetalleVenta.Show()
                End If
            Next
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btnPrintInternal.Click
        NotaInterna()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Close()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles btnExcepcion.Click
        ExcepcionPedido.txtMotivoExcepcion.Text = txtMotivoExcepcion.Text
        ExcepcionPedido.ShowDialog()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim sResp = MsgBox("Si continúa, se perderán los datos no guardados. Está seguro de continuar? ", MsgBoxStyle.YesNo, "Pedidos")
        If sResp = MsgBoxResult.Yes Then
            LimpiaCampos()
            Resetea_Botones()
        End If
    End Sub



End Class