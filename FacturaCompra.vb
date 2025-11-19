Imports System.Data.SqlClient

Public Class facturaCompra
    Dim gTipoCuenta As String
    Dim sVentana As String = "Factura Proveedor"
    Dim datatbl As SqlClient.SqlDataReader = Nothing
    Dim command As SqlCommand = Nothing
    Dim command_docvta As SqlCommand = Nothing
    Dim command_docdet As SqlCommand = Nothing
    Dim command_docpag As SqlCommand = Nothing


    Dim GranTotal As Double
    Dim gTotalNeto As Double
    Dim gImp_Especifico As Double
    Dim gTotal_Impuesto As Double

    Dim dTotalPagos As Double
    Dim sTipoDoc As String
    Dim sNumeDoc As String
    Dim zRut(0 To 0) As String
    Dim gRUTPROV As String


    'Private detpago As New DataTable("Documentos")

    Private fila As Byte

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim i As Integer

        If txt_CtaCtble.Text = Nothing Then
            MsgBox("Debe Ingresar Cuenta Contable", MsgBoxStyle.Exclamation)
            txt_CtaCtble.Focus()
            Exit Sub
        End If

        If gTipoCuenta = "R" Then
            If txt_Ccosto.Text = Nothing Then
                MsgBox("Debe Ingresar Centro Costo", MsgBoxStyle.Exclamation)
                txt_Ccosto.Focus()
                Exit Sub
            End If
        End If

        If Val(txt_Cantidad.Text) <= 0 Then
            MsgBox("Debe Ingresar Cantidad de Producto a Comprar", MsgBoxStyle.Exclamation, sVentana)
            Exit Sub
        End If

        If Val(txtprecio.Text) <= 0 Then
            MsgBox("Debe Ingresar Precio Unitario de Compra", MsgBoxStyle.Exclamation, sVentana)
            Exit Sub
        End If

        If rb_Semilla.Checked = True Then
            If txt_PrecioCompraSemilla.Text = Nothing Then
                MsgBox("Debe Ingresar Precio de Compra y Unidades Envasados")
                Exit Sub
            End If
            If cmb_Semilla.SelectedIndex = -1 Then
                MsgBox("Debe Seleccionar Semilla")
                Exit Sub
            End If
            If cmb_Variedad.SelectedIndex = -1 Then
                MsgBox("Debe Seleccionar Variedad")
                Exit Sub
            End If
        End If

        If rb_insumo.Checked = True Then
            If cmb_Insumos.SelectedIndex = -1 Then
                cmb_Insumos.Enabled = True
                cmb_Semilla.Enabled = False
                cmb_Variedad.Enabled = False
                MsgBox("Debe Seleccionar Insumo")
                Exit Sub
            End If

        End If
        ' validar que bodega tenga stock suficiente
        'If Not ValidaBodega(LSet(cmb_bodega.Text, 2), Val(txt_Cantidad.Text)) Then
        ' MessageBox.Show("No existe suficiente Stock en bodega de venta")
        'Else
        Try
            DataDetalle.Rows.Add()
            i = DataDetalle.Rows.Count - 1
            DataDetalle.Rows(i).Cells(0).Value = 0
            'Insumo
            If rb_insumo.Checked = True Then
                DataDetalle.Rows(i).Cells(1).Value = cmb_Insumos.Text
            End If
            If rb_Semilla.Checked = True Then
                'Semilla
                DataDetalle.Rows(i).Cells(2).Value = cmb_Semilla.Text
                'Variedad
                DataDetalle.Rows(i).Cells(3).Value = cmb_Variedad.Text
            End If
            'Descripcion
            DataDetalle.Rows(i).Cells(4).Value = txt_Descripcion.Text
            'Precio Unitario
            DataDetalle.Rows(i).Cells(5).Value = Reemplaza_Comas(txtprecio.Text)
            'Cantidad
            DataDetalle.Rows(i).Cells(6).Value = txt_Cantidad.Text
            'Total
            DataDetalle.Rows(i).Cells(7).Value = Format(Val(txtprecio.Text) * Val(txt_Cantidad.Text), "###,###,##0")
            'Precio Semilla
            DataDetalle.Rows(i).Cells(8).Value = txt_PrecioCompraSemilla.Text
            'Unidades de Semilla por Envase
            DataDetalle.Rows(i).Cells(9).Value = txt_TotalUnidades.Text
            'Descripcion Cuenta Contable
            DataDetalle.Rows(i).Cells(10).Value = txt_DescrpCtaCtble.Text
            'Cuenta Contable
            DataDetalle.Rows(i).Cells(11).Value = txt_CtaCtble.Text
            'Centro de Costo
            DataDetalle.Rows(i).Cells(12).Value = txt_Ccosto.Text

            totales()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ' End If
    End Sub
    Function Obtiene_Total_Detalle() As Double

        If rb_Semilla.Checked = True Then
            If Val(txt_TotalUnidades.Text) > 0 And Val(txtprecio.Text) > 0 Then
                txt_PrecioCompraSemilla.Text = Val(txtprecio.Text) / Val(txt_TotalUnidades.Text)
            End If
        End If
        Obtiene_Total_Detalle = Math.Round(Val(txtprecio.Text) * Val(txt_Cantidad.Text), 2)

    End Function



   

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        '' Eliminar detalle de compra




        Dim ifila As Integer

        Try

            If DataDetalle.Rows.Count > 0 Then
                ifila = DataDetalle.CurrentRow.Index
                Dim sResp = MsgBox("Esta seguro de Eliminar ítem de Compra?", MsgBoxStyle.YesNo, "Factura de Compra")
                If sResp = MsgBoxResult.Yes Then
                    If DataDetalle.Rows(ifila).Cells(0).Value > 0 Then
                        sSsql = "SP_ELIMINA_DETALLE_COMPRA "
                        sSsql += DataDetalle.Rows(ifila).Cells(0).Value.ToString
                        open()
                        command = connection.CreateCommand()
                        command.CommandText = sSsql
                        command.ExecuteNonQuery()
                        close_conexion()
                    End If
                    DataDetalle.Rows.RemoveAt(ifila)
                    MsgBox("Item de Compra ha sido Eliminado.", MsgBoxStyle.Information)
                    totales()
                Else
                    Exit Sub
                End If

            End If


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub totales()
        Dim i As Integer
        Dim totalneto, totalconiva, totaliva As Double
        For i = 0 To DataDetalle.Rows.Count - 1
            totalneto += Math.Round(DataDetalle.Rows(i).Cells(5).Value * DataDetalle.Rows(i).Cells(6).Value, 0)
            'detiva = Math.Round(DataDetalle.Rows(i).Cells(5).Value * GIVA / 100, 0, MidpointRounding.AwayFromZero)
            'detconiva = DataDetalle.Rows(i).Cells(5).Value + detiva

            'total += carrito.Rows(i)(5)
            'detiva = Math.Round(carrito.Rows(i)(5) * GIVA / 100, 0, MidpointRounding.AwayFromZero)
            'If chk_ImptoEspecifico.Checked = False Then
            'detiva = Math.Round(carrito.Rows(i)(5) * GIVA / 100, 0, MidpointRounding.AwayFromZero)
            'End If

            'detiva = Math.Round((carrito.Rows(i)(6) * 0.19) + 0.1, 0)
            'totaliva += detiva
            'detconiva = carrito.Rows(i)(5) + detiva
            'totalconiva += detconiva

        Next
        totalneto -= Val(txt_TotalDescuentos.Text)
        totaliva = Math.Round(totalneto * GIVA / 100, 0, MidpointRounding.AwayFromZero)
        totalconiva = totalneto + totaliva

        If chk_ImptoEspecifico.Checked = True Then
            totalconiva += Val(txt_ImptoEspecifico.Text)
        End If

        gTotalNeto = totalneto
        gImp_Especifico = Val(txt_ImptoEspecifico.Text)
        gTotal_Impuesto = totaliva
        Me.txt_TOTALNETO.Text = Format(gTotalNeto, "###,###,##0")
        Me.txt_IVA.Text = Format(totaliva, "###,###,##0")
        Me.txt_TOTALFINAL.Text = Format(totalconiva, "###,###,##0")
        GranTotal = totalconiva


    End Sub
    Private Sub TotalPagos()
        Dim i As Integer
        dTotalPagos = 0
        For i = 0 To DataGridPago.Rows.Count - 1
            dTotalPagos += DataGridPago.Rows(i).Cells(5).Value
        Next
        Me.txt_TOTPAGOS.Text = Format(dTotalPagos, "###,###,##0")

    End Sub

    Private Sub txt_Cantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txt_DIGRUT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_DIGPRO.Leave
        If txt_RUT_PRO.Text <> "" Then
            If BuscarpProveedor(txt_RUT_PRO.Text, txt_DIGPRO.Text) Then
                Lectura_Factura()
            End If
        Else
            MsgBox("Debe ingresar N° de RUT Proveedor.", MsgBoxStyle.Exclamation, sVentana)
            txt_RUT_PRO.Focus()
        End If
    End Sub

    Function BuscarpProveedor(ByVal sRUTPROVEEDOR As String, ByVal sDIGITORUT As String) As Boolean
        Dim sRutPro As String

        sRutPro = Format(Val(sRUTPROVEEDOR), "00000000000")
        sRutPro = sRutPro & UCase(sDIGITORUT)

        gRUTPROV = sRutPro

        ' buscar proveedor en la BD
        sSsql = "SP_CONSULTA_PROVEEDOR_NOMBRE '" + gRUTPROV + "',1"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        bOK = False
        If datatbl.HasRows Then
            If datatbl.Read Then
                txt_NOM_PRO.Text = datatbl(1)
            End If
            bOK = True
        Else
            MessageBox.Show("No Existe Proveedor con RUT ingresado. Itente nuevamente.")
            txt_DIGPRO.Text = ""
            txt_RUT_PRO.Text = ""
            txt_RUT_PRO.Focus()
        End If
        close_conexion()

        BuscarpProveedor = bOK
    End Function

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Visible = False
    End Sub

    Function GrabarBaseDatos() As Boolean

        Dim sRutPro As String
        Dim i As Integer
        '        Dim sTATUS As String
        'Dim sPrecio As String
        Dim sTipo_Compra As String
        Dim dIDCompras As Double

        bOK = True
        'prepara Key
        sTipoDoc = Mid(Me.cmb_TIPODOC.Text, Len(cmb_TIPODOC.Text) - 1, 2)
        sNumeDoc = Me.txt_NUM_DOC.Text

        sRutPro = Format(Val(txt_RUT_PRO.Text), "00000000000")
        sRutPro = sRutPro & UCase(txt_DIGPRO.Text)

        REM Graba Encabezado de Documento de Compra

        sTipo_Compra = Mid(cmb_TipoCompra.Text, Len(cmb_TipoCompra.Text) - 4, 5)
    
        TotalPagos()
        sSsql = "SP_INSERTA_DOCHEADER_COMPRA "
        sSsql += sNumeDoc + ","
        sSsql += "'" + sTipoDoc + "',"
        sSsql += "'" + Format(dtp_FechaEmi.Value, "d") + "',"
        sSsql += "'" + sRutPro + "',"
        sSsql += Val(txt_TOTALCOMPRA.Text).ToString + ",'"
        sSsql += sTipo_Compra + "',"
        sSsql += gTotalNeto.ToString + ","
        sSsql += gImp_Especifico.ToString + ","
        sSsql += gTotal_Impuesto.ToString + ","
        sSsql += Val(txt_TotalDescuentos.Text).ToString + ","
        sSsql += "'" + Format(dtp_Fecha_Declaracion.Value, "d") + "',"
        If rdb_Normal.Checked = True Then
            sSsql += "'N'"
        Else
            sSsql += "'E'"
        End If
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        datatbl.Read()
        dIDCompras = datatbl(0)
        close_conexion()

        open()
        REM Graba Detalle Documento de Compra
        For i = 0 To DataDetalle.Rows.Count - 1
            'sPrecio = Replace(DataDetalle.Rows(i).Cells(3).Value, ",", ".")
            If IsDBNull(DataDetalle.Rows(i).Cells(9).Value) Then
                DataDetalle.Rows(i).Cells(9).Value = 0
            End If
            sSsql = "SP_INSERTA_DOCDETALLE_COMPRA " + Str(dIDCompras) + ","
            sSsql += DataDetalle.Rows(i).Cells(0).Value.ToString + ","
            sSsql += "'" + DataDetalle.Rows(i).Cells(1).Value + "',"
            sSsql += "'" + DataDetalle.Rows(i).Cells(2).Value + "',"
            sSsql += "'" + DataDetalle.Rows(i).Cells(3).Value + "',"
            sSsql += "'" + DataDetalle.Rows(i).Cells(4).Value + "',"
            sSsql += DataDetalle.Rows(i).Cells(5).Value.ToString + ","
            sSsql += DataDetalle.Rows(i).Cells(6).Value.ToString + ","
            sSsql += Val(DataDetalle.Rows(i).Cells(9).Value).ToString + ","
            sSsql += "'" + DataDetalle.Rows(i).Cells(11).Value + "',"
            sSsql += Val(DataDetalle.Rows(i).Cells(12).Value).ToString + ","

            If chk_Stock.Checked = True Then
                sSsql += "'S'"
            Else
                sSsql += "'N'"
            End If

            command = connection.CreateCommand()
            command.CommandText = sSsql
            command.ExecuteNonQuery()
        Next
        close_conexion()
        'GRABAR COMPRA_PAGOS si fueron ingresados
        'NUM_DOC,TIPO_DOC,TIPO_PAGO,NUM_DOCPAGO,BANCO,FECHA_VCTO,VALOR_DOC
        'Item,Forma Pago,Documento,Banco,Fecha Vcto,Monto
        If DataGridPago.Rows.Count - 1 >= 0 Then
            open()
            command = connection.CreateCommand()
            '@TIPO_DOC,@NUM_DOC,@TIPO_PAGO,@NUM_DOCPAGO,@BANCO,@FECHA_VCTO,@VALOR_DOC,@TIPO_TRANSAC

            For i = 0 To DataGridPago.Rows.Count - 1
                sSsql = "SP_INSERTA_PAGOS_COMPRAS " + Str(dIDCompras) + ",'" + DataGridPago.Rows(i).Cells(1).Value + "','" + DataGridPago.Rows(i).Cells(2).Value + "',"
                sSsql += "'" + DataGridPago.Rows(i).Cells(3).Value + "','" + DataGridPago.Rows(i).Cells(4).Value + "'," + DataGridPago.Rows(i).Cells(5).Value.ToString

                command.CommandText = sSsql
                command.ExecuteNonQuery()
            Next
            close_conexion()
        End If

        'If sTipo_Compra = "INVER" Then
        '' Actualiza Inventario de Compras
        'Inventario(2, sNumeDoc, sTipoDoc, txt_FECHA_DOC.Text, "")
        'End If
        'LimpiaCampos()
        'HabilitaCampos()
        Me.cmb_TIPODOC.Focus()
        GrabarBaseDatos = bOK

    End Function
    Private Sub EliminaRegistros(ByVal sPreguntar As String, ByVal sNUMERODOC As Integer, ByVal sTIPODOC As String, sRutProveedor As String)

        Dim sRespuesta As String
        'Dim dPuntaje_Venta As Double
        'Dim dPuntaje_Canje As Double
        'Dim dSaldoVenta As Double

        If sNUMERODOC = 0 Then
            MessageBox.Show("INGRESE NUMERO DE DOCUMENTO")
            LimpiaCampos()
            HabilitaCampos()
            Me.cmb_TIPODOC.Focus()
            Exit Sub
        End If
        sRespuesta = "S"
        If sPreguntar = "S" Then
            sRespuesta = InputBox("ESTA SEGURO DE ELIMINAR DOCUMENTO <S/N>?", "ELIMINACION DE DOCUMENTO. NO OLVIDE ACTUALIZAR LOS MOVIMIENTOS CONTABLES.", "S")
        End If

        If sPreguntar = "S" Then
            'Inventario(6, sNUMERODOC, sTIPODOC, txt_FECHA_DOC.Text, "")
        End If

        If UCase(sRespuesta) = "S" Then
            sSsql = "SP_ELIMINA_DOCCOMPRA '" + sTIPODOC + "',"
            sSsql += sNUMERODOC.ToString + ","
            sSsql += "'" + sRutProveedor + "'"
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            command.ExecuteNonQuery()
            close_conexion()
            If sPreguntar = "S" Then
                MessageBox.Show("El Documento ha sido Eliminado")
                LimpiaCampos()
                HabilitaCampos()
                Me.cmb_TIPODOC.Focus()

            End If

        End If

    End Sub
    
    Function ValidarTotales() As Boolean
        Dim mensaje As String
        'Dim dTotalPagos As Double
        Dim i As Integer
        bOK = True
        mensaje = "REVISE LOS SIGUIENTES MENSAJES:" + Chr(13)
        'GranTotal = Math.Round(GranTotal)
        Try
            If Len(Trim(cmb_TipoCompra.Text)) = 0 Then
                bOK = False
                mensaje += " DEBE SELECCIONAR TIPO DE COMPRA." + Chr(13)
            End If
            ' If LSet(cmb_bodega.Text, 2) = "  " Then
            ' bOK = False
            ' mensaje = "SELECCIONE BODEGA DE VENTA"
            ' End If
            If Val(txt_TOTALCOMPRA.Text) <> GranTotal Then
                bOK = False
                mensaje += " SUMA DE VALORES DE PRODUCTOS DEBE COINCIDIR CON TOTAL COMPRA." + Chr(13)
            End If
            dTotalPagos = 0
            For i = 0 To DataGridPago.Rows.Count - 1
                dTotalPagos += DataGridPago.Rows(i).Cells(5).Value
            Next
            'If dTotalPagos <> GranTotal Then
            ' bOK = False
            ' mensaje += " SUMA DE VALORES DE DOCUMENTOS DE PAGO DEBE COINCIDIR CON TOTAL COMPRA." + Chr(13)
            ' End If

            If cmb_TIPODOC.Text = "" Then
                bOK = False
                mensaje += " DEBE SELECCIONAR TIPO DE DOCUMENTO DE COMPRA." + Chr(13)
            End If
            If txt_NUM_DOC.Text.ToString = "" Then
                bOK = False
                mensaje += " DEBE INGRESAR NUMERO DE DOCUMENTO DE COMPRA." + Chr(13)
            End If
        Catch ex As Exception

        End Try

        If Not bOK Then
            MessageBox.Show(mensaje)
        End If
        ValidarTotales = bOK
    End Function


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
       
        If bOK Then
            Try
                DataGridPago.Rows.Add()
                i = DataGridPago.Rows.Count - 1
                DataGridPago.Rows(i).Cells(0).Value = i + 1
                DataGridPago.Rows(i).Cells(1).Value = cmb_TIPO_PAGO.Text
                DataGridPago.Rows(i).Cells(2).Value = txt_NUM_DOCPAGO.Text
                DataGridPago.Rows(i).Cells(3).Value = txt_BANCO.Text
                DataGridPago.Rows(i).Cells(4).Value = dtp_FechaVcto.Value
                DataGridPago.Rows(i).Cells(5).Value = txt_MontoDoc.Text

                TotalPagos()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            fila = DataGridPago.CurrentCell.RowIndex
            If fila > -1 And DataGridPago.Rows.Count > 0 Then
                dTotalPagos -= Single.Parse(DataGridPago.Item(5, fila).Value)
                DataGridPago.Rows.RemoveAt(fila)
      
                TotalPagos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub txt_NUM_DOC_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_NUM_DOC.Leave
        '** Sale del campo Numero Documento
        If cmb_TIPODOC.SelectedIndex > -1 Then
            sTipoDoc = Mid(Me.cmb_TIPODOC.Text, Len(Me.cmb_TIPODOC.Text) - 1, 2)
            sNumeDoc = Me.txt_NUM_DOC.Text
        End If
        

    End Sub

    Private Sub Lectura_Factura()
        Dim bExiste As Boolean = False

        sSsql = "SP_CONSULTA_DOCCOMPRA "
        sSsql += "'" + sTipoDoc + "',"
        sSsql += "'" + sNumeDoc + "',"
        sSsql += "'" + gRUTPROV + "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        'NUM_DOC, TIPO_DOC, FECHA_DOC, RUT, VALOR_DOC, STATUS, TIPO_COMPRA
        If datatbl.HasRows Then
            bExiste = True
            datatbl.Read()
            Me.dtp_FechaEmi.Value = datatbl(2)
            Me.dtp_Fecha_Declaracion.Value = datatbl(12)
            Me.txt_RUT_PRO.Text = Mid(datatbl(3), 1, 11)
            Me.txt_DIGPRO.Text = Mid(datatbl(3), 12, 1)
            Me.txt_TOTALCOMPRA.Text = datatbl(4)
            Me.txt_NOM_PRO.Text = datatbl(13)
            If Not IsDBNull(datatbl(7)) Then
                gImp_Especifico = datatbl(7)
                txt_ImptoEspecifico.Text = gImp_Especifico
                If gImp_Especifico > 0 Then
                    chk_ImptoEspecifico.Checked = True
                Else
                    chk_ImptoEspecifico.Checked = False
                End If

            End If

            Select Case datatbl(5).ToString
                Case "INVER"
                    cmb_TipoCompra.SelectedIndex = 0
                Case "GTOSG"
                    cmb_TipoCompra.SelectedIndex = 1
                Case "OTROS"
                    cmb_TipoCompra.SelectedIndex = 2
            End Select
            Me.cmb_TipoCompra.Show()

            If datatbl(14) = "N" Then
                rdb_Normal.Checked = True
                rdb_DocElect.Checked = False
            Else
                rdb_DocElect.Checked = True
                rdb_Normal.Checked = False
            End If

            If datatbl(9) = 1 Then
                MsgBox("Documento Contabilizado. No es posible Modificar.", MsgBoxStyle.Exclamation)
                ToolStripMenuItem2.Enabled = False
                ToolStripMenuItem3.Enabled = False
            Else
                ToolStripMenuItem2.Enabled = True
                ToolStripMenuItem3.Enabled = True
            End If


        End If
        close_conexion()
        If bExiste Then
            LoadingDatos(sNumeDoc, sTipoDoc)
        End If

    End Sub
    Private Sub LoadingDatos(ByVal sNUMERODOCUMENTO As String, ByVal sTIPODOCUMENTO As String)
        Dim i As Integer
        Dim sRutPro As String
        'busca proveedor
        BuscarpProveedor(Me.txt_RUT_PRO.Text, Me.txt_DIGPRO.Text)
        'carga productos

        sRutPro = Format(Val(txt_RUT_PRO.Text), "00000000000")
        sRutPro = sRutPro & UCase(txt_DIGPRO.Text)

        sSsql = "SP_CONSULTA_DOCDETALLE "
        sSsql += "'" + sTIPODOCUMENTO + "',"
        sSsql += sNUMERODOCUMENTO.ToString + ","
        sSsql += "2,"
        sSsql += "'" + sRutPro + "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        ' Item
        ' Insumo
        ' Semilla
        ' Variedad
        ' descripción
        ' precio unit.
        ' cantidad
        ' total
        ' precio semilla
        ' semillas por env
        If datatbl.HasRows Then
            i = 0
            DataDetalle.Rows.Clear()

            While datatbl.Read = True
                DataDetalle.Rows.Add()
                DataDetalle.Rows(i).Cells(0).Value = datatbl(2)
                DataDetalle.Rows(i).Cells(1).Value = datatbl(3)
                DataDetalle.Rows(i).Cells(2).Value = datatbl(4)
                DataDetalle.Rows(i).Cells(3).Value = datatbl(5)
                DataDetalle.Rows(i).Cells(4).Value = datatbl(6)
                DataDetalle.Rows(i).Cells(5).Value = datatbl(7)
                DataDetalle.Rows(i).Cells(6).Value = datatbl(8)
                DataDetalle.Rows(i).Cells(7).Value = Format(datatbl(9), "###,###,##0")
                DataDetalle.Rows(i).Cells(8).Value = datatbl(10)
                DataDetalle.Rows(i).Cells(9).Value = datatbl(11)
                DataDetalle.Rows(i).Cells(10).Value = datatbl(14)
                DataDetalle.Rows(i).Cells(11).Value = datatbl(12)
                DataDetalle.Rows(i).Cells(12).Value = datatbl(13)

                i += 1
            End While

        End If
        totales()
        close_conexion()
        'carga pagos
        sSsql = "SP_CONSULTA_DOCPAGOS "
        sSsql += "'" + sTIPODOCUMENTO + "',"
        sSsql += sNUMERODOCUMENTO.ToString + ","
        sSsql += "2,"
        sSsql += "'" + sRutPro + "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()



        If datatbl.HasRows Then
            i = 0
            DataGridPago.Rows.Clear()
            While datatbl.Read = True
                DataGridPago.Rows.Add()
                DataGridPago.Rows(i).Cells(0).Value = i + 1
                DataGridPago.Rows(i).Cells(1).Value = datatbl(1)
                DataGridPago.Rows(i).Cells(2).Value = datatbl(2)
                DataGridPago.Rows(i).Cells(3).Value = datatbl(3)
                DataGridPago.Rows(i).Cells(4).Value = datatbl(4)
                DataGridPago.Rows(i).Cells(5).Value = datatbl(5)

                i += 1
            End While
            TotalPagos()
        End If
        close_conexion()

    End Sub


    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        'Botón Grabar formulario
        If Trim(txt_RUT_PRO.Text) = "" Then
            MessageBox.Show("Debe ingresar Rut Proveedor")
            txt_RUT_PRO.Focus()
        Else
            If ValidarTotales() Then
                ' Grabar Base de Datos
                If GrabarBaseDatos() Then
                    'limpiar campos de pantalla
                    LimpiaCampos()
                End If
            End If
        End If

    End Sub
    Function ValidaBodega(ByVal sBodega As String, ByVal dCantidad As Double) As Boolean
        bOK = False
        Select Case sBodega
            Case "00"
                'If Val(Me.txt_bodega00.Text) >= dCantidad Then
                ' bOK = True
                ' Else
                ' bOK = False
                ' End If
            Case "01"
                'If Val(Me.txt_bodega01.Text) >= dCantidad Then
                ' bOK = True
                ' Else
                ' bOK = False
                ' End If

            Case "02"
                'If Val(Me.txt_bodega02.Text) >= dCantidad Then
                ' bOK = True
                ' Else
                ' bOK = False
                ' End If

        End Select
        ValidaBodega = bOK
    End Function
    Private Sub LimpiaCampos()
        
        Me.txt_PrecioCompraSemilla.Clear()
        Me.txt_TotalUnidades.Clear()
        Me.cmb_Semilla.SelectedIndex = -1
        Me.cmb_Insumos.SelectedIndex = -1
        Me.cmb_Variedad.SelectedIndex = -1
        Me.cmb_TipoCompra.SelectedIndex = -1
        txt_BUSCARPROVEEDOR.Clear()
        'Me.cmb_PROVEEDOR.SelectedIndex = -1
        Me.cmb_TIPO_PAGO.SelectedIndex = -1
        Me.cmb_TIPODOC.SelectedIndex = -1

        txt_BANCO.Clear()
        txt_Cantidad.Clear()
        txt_Descripcion.Clear()
        txt_DIGPRO.Clear()
        txt_ImptoEspecifico.Clear()
        txt_IVA.Clear()
        txt_MontoDoc.Clear()
        txt_NOM_PRO.Clear()
        txt_NUM_DOC.Clear()
        txt_NUM_DOCPAGO.Clear()
        txt_PrecioCompraSemilla.Clear()
        txt_RUT_PRO.Clear()
        txt_TOTALCOMPRA.Clear()
        txt_totaldetalle.Clear()
        txt_TOTALFINAL.Clear()
        txt_TOTALNETO.Clear()
        txt_TotalUnidades.Clear()
        txt_TOTPAGOS.Clear()
        txt_UNIDAD.Clear()
        txt_TotalDescuentos.Clear()
        txtprecio.Clear()
        DataDetalle.Rows.Clear()
        DataGridPago.Rows.Clear()
        txt_Ccosto.Clear()
        txt_CtaCtble.Clear()
        dtp_FechaEmi.Value = Date.Now
        dtp_Fecha_Declaracion.Value = Date.Now
        dtp_FechaVcto.Value = Date.Now
        rdb_DocElect.Checked = False
        rdb_Normal.Checked = True
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        LimpiaCampos()
        HabilitaCampos()
        Me.cmb_TIPODOC.Focus()
    End Sub
    Private Sub HabilitaCampos()
        Me.txt_RUT_PRO.Enabled = True
        Me.txt_NOM_PRO.Enabled = True
        Me.txt_TOTALFINAL.Enabled = True
        Me.txt_TOTALNETO.Enabled = True
        Me.txt_TOTALCOMPRA.Enabled = True
        Me.txt_TOTPAGOS.Enabled = True
        Me.txt_UNIDAD.Enabled = True
        Me.txt_Cantidad.Enabled = True
        Me.txtprecio.Enabled = True
        Me.txt_NUM_DOC.Enabled = True
        Me.txt_MontoDoc.Enabled = True
        Me.txt_NUM_DOCPAGO.Enabled = True
        Me.txt_BANCO.Enabled = True
        'Me.txt_IDInsumo.Enabled = True
        Me.txt_DIGPRO.Enabled = True
        Me.dtp_FechaEmi.Enabled = True
        Me.dtp_FechaVcto.Enabled = True
        Me.txt_IVA.Enabled = True
        Me.cmb_TIPODOC.Enabled = True
        Me.cmb_TIPO_PAGO.Enabled = True
        'Me.cmb_bodega.Enabled = True
        Me.btn_AgregarPago.Enabled = True
        Me.btnAgregar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.Button3.Enabled = True
        Me.txt_BUSCARPROVEEDOR.Enabled = True
        Me.BTN_BUSCAR.Enabled = True
        'Me.cmb_PROVEEDOR.Enabled = True
        ToolStripMenuItem2.Enabled = True
        ToolStripMenuItem3.Enabled = True
        rdb_Normal.Enabled = True
        rdb_DocElect.Enabled = True
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        sNumeDoc = Val(Me.txt_NUM_DOC.Text)
        sTipoDoc = Mid(cmb_TIPODOC.Text, Len(cmb_TIPODOC.Text) - 1, 2)
        gRUTPROV = gRUT
        EliminaRegistros("S", sNumeDoc, sTipoDoc, gRUTPROV)
    End Sub

    Private Sub facturaCompra_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave

        Me.Close()

    End Sub

    Private Sub facturaCompra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Carga_Insumos_Compras(Me.cmb_Insumos)
        Carga_Familia_Prod(Me.cmb_Semilla)
        Carga_FormaPago(Me.cmb_TIPO_PAGO, 1)
        'Carga_Variedad(Me.cmb_Variedad)
        'txt_FECHA_DOC.Text = Now.Date

    End Sub

    Private Sub txt_RUT_PRO_GotFocus(sender As Object, e As EventArgs) Handles txt_RUT_PRO.GotFocus
        If txt_RUT_PRO.Text <> Nothing Then
            gRUTPROV = txt_RUT_PRO.Text + txt_DIGPRO.Text

            If sTipoDoc <> Nothing And sNumeDoc <> Nothing And gRUTPROV <> Nothing Then
                Lectura_Factura()
            End If

        End If
    End Sub

  

    Private Sub txt_RUT_PRO_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txt_RUT_PRO.MaskInputRejected

        If txt_RUT_PRO.Text <> Nothing And txt_DIGPRO.Text <> Nothing Then
            BuscarpProveedor(txt_RUT_PRO.Text, txt_DIGPRO.Text)
        End If

    End Sub

    Private Sub BTN_BUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR.Click

        gNOMBRE = txt_BUSCARPROVEEDOR.Text
        gQuienLlama = 1
        Busqueda_Proveedor.Show()
        txt_RUT_PRO.Focus()

        'Dim i As Integer
        ''Dim x As Integer
        'Dim sNombre As String
        'cmb_PROVEEDOR.Items.Clear()

        'sSsql = "SP_CONSULTA_PROVEEDOR_NOMBRE '" + Trim(txt_BUSCARPROVEEDOR.Text) + "',2"

        'open()
        'command = connection.CreateCommand()
        'command.CommandText = sSsql
        'datatbl = command.ExecuteReader()

        'If datatbl.HasRows Then
        '    i = 0
        '    While datatbl.Read = True
        '        ReDim Preserve zRut(0 To i)
        '        zRut(i) = datatbl(0)
        '        sNombre = datatbl(1)
        '        cmb_PROVEEDOR.Items.Add(sNombre)
        '        i += 1
        '    End While
        '    cmb_PROVEEDOR.Focus()
        'Else
        '    MessageBox.Show("NO EXISTEN PROVEEDORES CON DATOS INGRESADOS")
        '    txt_BUSCARPROVEEDOR.Focus()
        'End If
        'close_conexion()
    End Sub

   

    Private Sub chk_ImptoEspecifico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ImptoEspecifico.CheckedChanged
        If Val(txt_ImptoEspecifico.Text) > 0 Then
            totales()
        End If

    End Sub

    Private Sub txt_Cantidad_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Cantidad.TextChanged
        If Val(txt_Cantidad.Text) > 0 Then
            txt_totaldetalle.Text = Format(Obtiene_Total_Detalle, "###,###,##0.00")
        End If

    End Sub

    Private Sub txtprecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprecio.TextChanged
        If Val(txtprecio.Text) > 0 Then
            txt_totaldetalle.Text = Format(Obtiene_Total_Detalle, "###,###,##0.00")
        End If
    End Sub

    Private Sub txt_ImptoEspecifico_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ImptoEspecifico.TextChanged
        If Val(txt_ImptoEspecifico.Text) > 0 Then
            totales()
        End If
    End Sub

    Private Sub cmb_TIPO_PAGO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TIPO_PAGO.SelectedIndexChanged
        If cmb_TIPODOC.Text <> "CHEQUE" Then
            dtp_FechaVcto.Value = dtp_FechaEmi.Value
        End If
    End Sub

    Private Sub rb_Semilla_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Semilla.CheckedChanged
        cmb_Insumos.Enabled = False
        cmb_Semilla.Enabled = True
        cmb_Variedad.Enabled = True
    End Sub

    Private Sub rb_Semilla_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_Semilla.Click
        If rb_Semilla.Checked = True Then
            rb_insumo.Checked = False
            cmb_Insumos.Enabled = False
            cmb_Semilla.Enabled = True
            cmb_Variedad.Enabled = True
            txt_TotalUnidades.ReadOnly = False
        End If
    End Sub

    Private Sub cmb_Semilla_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Semilla.SelectedIndexChanged
        If cmb_Semilla.SelectedIndex > -1 Then
            Carga_Variedad_Filtro(cmb_Variedad, cmb_Semilla.Text)
            Lectura_Cuenta_Contable_Semilla()
            cmb_Insumos.SelectedIndex = -1
        End If
    End Sub
    Private Sub Lectura_Cuenta_Contable_Semilla()
        sSsql = "SP_CONSULTA_Cuenta_Especie "
        sSsql += "'" + cmb_Semilla.SelectedItem + "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            txt_CtaCtble.Text = datatbl(4)
            txt_Ccosto.Text = datatbl(5)
        Else
            MsgBox("Familia de Producto No tiene Cuenta Contable Definida. Se debe crear la cuenta contable antes de continuar.", MsgBoxStyle.Exclamation)
        End If
        close_conexion()
    End Sub
    Private Sub txt_TotalDescuentos_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_TotalDescuentos.TextChanged
        If Val(txt_TotalDescuentos.Text) > 0 Then
            totales()
        End If
    End Sub

    Private Sub txt_TotalUnidades_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_TotalUnidades.TextChanged
        If Val(txtprecio.Text) > 0 Then
            txt_totaldetalle.Text = Format(Obtiene_Total_Detalle, "###,###,##0.00")
        End If
    End Sub

    Private Sub cmb_Variedad_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Variedad.SelectedIndexChanged
        txt_TotalUnidades.Clear()
        txtprecio.Clear()
        txt_Cantidad.Clear()
        txt_totaldetalle.Clear()
        txt_PrecioCompraSemilla.Clear()
    End Sub

    Private Sub rb_insumo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_insumo.CheckedChanged
        cmb_Insumos.Enabled = True
        cmb_Semilla.Enabled = False
        cmb_Variedad.Enabled = False
        txt_TotalUnidades.Clear()
        txtprecio.Clear()
        txt_Cantidad.Clear()
        txt_totaldetalle.Clear()
        txt_PrecioCompraSemilla.Clear()
    End Sub

    Private Sub txt_CtaCtble_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_CtaCtble.LostFocus
        'If txt_CtaCtble.Text <> Nothing Then

        '    If Len(txt_CtaCtble.Text) <> 7 Then
        '        MsgBox("Cuenta Contable Inválida", MsgBoxStyle.Exclamation)
        '        txt_CtaCtble.Focus()
        '        Exit Sub
        '    End If

        '    sSsql = "SP_CONSULTA_CONTA_CodigoCuenta "
        '    sSsql += "'" + txt_CtaCtble.Text + "'"
        '    open()
        '    command = connection.CreateCommand()
        '    command.CommandText = sSsql
        '    datatbl = command.ExecuteReader()
        '    If datatbl.HasRows Then
        '        datatbl.Read()
        '        txt_DescrpCtaCtble.Text = datatbl(1)
        '        gTipoCuenta = datatbl(2)

        '    Else
        '        MsgBox("No Existe Cuenta Contable. Se debe crear la cuenta contable antes de continuar.", MsgBoxStyle.Exclamation)
        '        close_conexion()
        '        txt_CtaCtble.Focus()
        '        Exit Sub
        '    End If


        '    close_conexion()
        'End If
    End Sub

    Private Sub txt_Ccosto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Ccosto.LostFocus
        'If txt_Ccosto.Text <> Nothing Then
        '    sSsql = "SP_CONSULTA_CONTA_CCosto "
        '    sSsql += txt_Ccosto.Text.ToString
        '    open()
        '    command = connection.CreateCommand()
        '    command.CommandText = sSsql
        '    datatbl = command.ExecuteReader()
        '    If datatbl.HasRows Then
        '        datatbl.Read()
        '        txt_DescrpCtaCtble.Text = RTrim(txt_DescrpCtaCtble.Text) + "-" + RTrim(datatbl(1))
        '    Else
        '        MsgBox("No Existe Centro de Costo.", MsgBoxStyle.Exclamation)
        '        close_conexion()
        '        txt_Ccosto.Focus()
        '        Exit Sub
        '    End If
        '    close_conexion()
        'End If
    End Sub

 
  
    Private Sub cmb_Insumos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Insumos.SelectedIndexChanged
        If cmb_Insumos.SelectedIndex > -1 Then
            cmb_Semilla.SelectedIndex = -1
            cmb_Variedad.SelectedIndex = -1

            sSsql = "SP_CONSULTA_Cuenta_INSUMO "
            sSsql += "'" + cmb_Insumos.SelectedItem + "'"
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                datatbl.Read()
                txt_CtaCtble.Text = datatbl(0)
                txt_Ccosto.Text = datatbl(1)
            Else
                MsgBox("Insumo No tiene Cuenta Contable Definida. Se debe crear la cuenta contable antes de continuar.", MsgBoxStyle.Exclamation)
            End If
            close_conexion()
        End If
    End Sub



    Private Sub dtp_FechaEmi_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaEmi.ValueChanged
        dtp_Fecha_Declaracion.Value = dtp_FechaEmi.Value
    End Sub



    Private Sub cmb_TIPODOC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_TIPODOC.SelectedIndexChanged
        If cmb_TIPODOC.SelectedIndex > -1 Then
            sTipoDoc = Mid(cmb_TIPODOC.Text, Len(cmb_TIPODOC.Text) - 1, 2)
        End If

    End Sub




    Private Sub txt_NUM_DOC_TextChanged(sender As Object, e As EventArgs) Handles txt_NUM_DOC.TextChanged
        If txt_NUM_DOC.Text <> Nothing Then
            sNumeDoc = Val(txt_NUM_DOC.Text)
        End If
    End Sub


    Private Sub txt_RUT_PRO_Leave(sender As Object, e As EventArgs) Handles txt_RUT_PRO.Leave
        If txt_RUT_PRO.Text <> Nothing Then
            gRUTPROV = txt_RUT_PRO.Text + txt_DIGPRO.Text

            If sTipoDoc <> Nothing And sNumeDoc <> Nothing And gRUTPROV <> Nothing Then
                Lectura_Factura()
            End If

        End If
    End Sub
End Class