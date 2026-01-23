Imports System.Drawing.Printing
Public Class Abono_Deuda
    Dim dVentaTotal As Double
    Dim dAbonoTotal As Double
    Dim dDeudaTotal As Double
    Dim dNuevoAbono As Double
    Dim gTotalPagar As Double
    Dim gSaldoxAsignar As Double = 0

    Dim gAbonoActual As Double
    Dim gAbonoRecibo As Double
    Dim gFechaContable As Date
    Dim gSaldoAjusteDAI As Integer
    Dim gIdCliente As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'cmb_clientebuscar.Items.Clear()
        'Buscar_Cliente(Me.cmb_clientebuscar, Me.txt_clientebuscar.Text)
        gNOMBRE = txt_clientebuscar.Text
        gQuienLlama = 13

        If chkCliente.Checked Then
            BusquedaCliente.chkIncluyePrimerNombre.Checked = True
        Else
            BusquedaCliente.chkIncluyePrimerNombre.Checked = False
        End If
        BusquedaCliente.Visible = True
        'txt_saldo.Clear()
    End Sub

    Private Sub RescataPedidosActCli(ByVal idCliente As Integer)
        cmbPedido.Items.Clear()
        sSsql = "SP_ConsPedidoActCli "
        sSsql += idCliente.ToString
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            While datatbl.Read
                cmbPedido.Items.Add(datatbl(0))
            End While
        End If
        close_conexion()
    End Sub
    Public Sub Rescata_Resumen_Cliente()
        If Val(txt_IdCliente.Text) > 0 Then
            Dim LineaUtilizada As Double
            sSsql = "NEWSP_Consulta_Resumen_Deuda_Cliente "
            sSsql += Val(txt_IdCliente.Text).ToString()
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            datatbl.Read()
            txt_SaldoFacturas.Text = Format(datatbl("Doc.Pendientes"), "###,###,##0")
            txt_ChequesxCobrar.Text = Format(datatbl("Cheques"), "###,###,##0")
            txt_LetrasxCobrar.Text = Format(datatbl("Letras"), "###,###,##0")
            txt_TotalAbonos.Text = Format(datatbl("Abonos"), "###,###,##0")
            txt_DeudaTotal.Text = Format(datatbl("DeudaTotal"), "###,###,##0")
            txtSaldoAjusteDAI.Text = Format(datatbl("AjusteDAI"), "###,###,##0")
            txtLineaCredito.Text = Format(datatbl("LineaCredito"), "###,###,##0")
            LineaUtilizada = datatbl("LineaCredito") - datatbl("SaldoLC")
            txtLineaUtilizada.Text = Format(LineaUtilizada, "###,###,##0")
            txtSaldoLineaCredito.Text = Format(datatbl("SaldoLC"), "###,###,##0")
            gSaldoAjusteDAI = datatbl("AjusteDAI")
            If Val(txt_TotalAbonos.Text) > 0 Then
                gAbonoActual = datatbl("Abonos")
                btnDevolucion.Enabled = True
            Else
                gAbonoActual = 0
                btnDevolucion.Enabled = False
            End If

            close_conexion()
        Else
            MsgBox("Debe Seleccionar Cliente", MsgBoxStyle.Critical, "Abono Deuda")
        End If
    End Sub
    Private Sub limpia_campos()
        txt_NombreCliente.Clear()
        txtRutCli.Clear()
        cmb_TIPO_PAGO.SelectedIndex = -1
        txt_ChequesxCobrar.Clear()
        txt_clientebuscar.Clear()
        txt_DeudaTotal.Clear()
        txt_Glosa.Clear()
        txt_LetrasxCobrar.Clear()
        txt_MontoDoc.Clear()
        'txt_NOM_CLI.Clear()
        txt_NumDocPago.Clear()
        txt_RUT_CLI.Clear()
        ' txt_saldo.Clear()
        txt_SaldoFacturas.Clear()
        'txt_SaldoporAsignar.Clear()
        txt_TotalAbonos.Clear()
        GrillaVentas.Rows.Clear()
        GrillaPagos.Rows.Clear()
        txt_clientebuscar.Focus()
        'chkAbonoPedido.Checked = False
        cmbPedido.Items.Clear()
        cmbPedido.Enabled = False
        cmbDocumento.Items.Clear()
        cmbDocumento.Enabled = False
    End Sub

    Private Sub Rescata_Pagos_Historicos(ByVal Id_Cliente As Integer)
        Dim i As Integer
        open()
        sSsql = "SP_CONSULTA_PAGOS_HISTORICO " & Str(Id_Cliente)
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        GrillaPagos.Rows.Clear()
        dAbonoTotal = 0
        If datatbl.HasRows Then
            i = 0
            While datatbl.Read
                GrillaPagos.Rows.Add()
                GrillaPagos.Rows(i).Cells("id_pago").Value = datatbl(0)
                GrillaPagos.Rows(i).Cells("FechaPago").Value = datatbl(2)
                GrillaPagos.Rows(i).Cells("fechaconta").Value = datatbl(15)
                GrillaPagos.Rows(i).Cells("docpago").Value = datatbl(11)
                GrillaPagos.Rows(i).Cells("num").Value = datatbl(12)
                GrillaPagos.Rows(i).Cells("monto").Value = Format(datatbl(13), "###,###,###")
                GrillaPagos.Rows(i).Cells("tipodoc").Value = datatbl(8)
                GrillaPagos.Rows(i).Cells("numdoc").Value = datatbl(9)
                GrillaPagos.Rows(i).Cells("IdPedido").Value = datatbl(16)
                GrillaPagos.Rows(i).Cells("ValorPagado").Value = Format(datatbl(6), "###,###,###")
                GrillaPagos.Rows(i).Cells("fec_venc").Value = datatbl(5)
                GrillaPagos.Rows(i).Cells("Glosa").Value = datatbl(7)
                GrillaPagos.Rows(i).Cells("estado").Value = datatbl(14)
                GrillaPagos.Rows(i).Cells("AbonoPedido").Value = datatbl(17)
                GrillaPagos.Rows(i).Cells("PagoNoEditado").Value = datatbl(6)
                GrillaPagos.Rows(i).Cells("ValorDAI").Value = Format(datatbl("ValorDAI"), "###,###,###")
                GrillaPagos.Rows(i).Cells("rebajaDAI").Value = datatbl("RebajaDAI")
                GrillaPagos.Rows(i).Cells("usuario").Value = datatbl("Usuario")
                dAbonoTotal += datatbl(6)
                If datatbl(6) < 0 Then
                    GrillaPagos.Rows(i).DefaultCellStyle.BackColor = Color.Red
                    GrillaPagos.Rows(i).DefaultCellStyle.ForeColor = Color.White
                End If

                i += 1
            End While
            'GrillaPagos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
        close_conexion()
        'Deuda_Total()
    End Sub
    Private Sub Rescata_Documentos_Ventas(ByVal idcliente As Integer, ByVal iIndicador As Integer)
        '' Recupera Datos de Documentos pendientes de pago
        Dim i As Integer
        open()
        sSsql = "SP_CONSULTA_DocumentosVentaCliente " & idcliente.ToString() & ","
        sSsql += iIndicador.ToString
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        cmbDocumento.Items.Clear()
        GrillaVentas.Rows.Clear()
        If datatbl.HasRows Then
            i = 0
            While datatbl.Read
                GrillaVentas.Rows.Add()
                GrillaVentas.Rows(i).Cells("Tipo").Value = datatbl("TIPO_DOC")
                GrillaVentas.Rows(i).Cells("Nro").Value = datatbl("NUM_DOC")
                GrillaVentas.Rows(i).Cells("Tipodocsii").Value = datatbl("TipoDocSII")
                GrillaVentas.Rows(i).Cells("Numdocsii").Value = datatbl("NumDocSII")
                GrillaVentas.Rows(i).Cells("ValorDocumento").Value = Format(datatbl("Valor_Doc"), "###,###,###")
                GrillaVentas.Rows(i).Cells("saldodoc").Value = datatbl("Saldo_doc")
                GrillaVentas.Rows(i).Cells("totalpago").Value = datatbl("totalpago")
                GrillaVentas.Rows(i).Cells("obs").Value = datatbl("obs")
                GrillaVentas.Rows(i).Cells("EstadoDoc").Value = datatbl("ESTADO")
                GrillaVentas.Rows(i).Cells("FechaDoc").Value = datatbl("fecha_doc")
                If GrillaVentas.Rows(i).Cells("saldodoc").Value > 0 Then
                    cmbDocumento.Items.Add(GrillaVentas.Rows(i).Cells("Tipo").Value & GrillaVentas.Rows(i).Cells("Nro").Value)
                End If
                i += 1
            End While
        End If
        close_conexion()
        cmbDocumento.SelectedIndex = -1
        cmbPedido.SelectedIndex = -1

        'Deuda_Total()
    End Sub
    Private Sub Calculo_Pagos()
        Dim iFilas As Integer
        Dim i As Integer
        iFilas = GrillaPagos.Rows.Count - 1
        dAbonoTotal = 0
        For i = 0 To iFilas
            If GrillaVentas.Rows(i).Cells("EstadoDoc").Value < 9 Then
                dAbonoTotal += GrillaVentas.Rows(i).Cells("ValorDocumento").Value
            End If
        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub Agregar_Pago()
        Dim bAgregarPago As Boolean = True
        Dim sTipodoc As String
        Dim sNumdoc As String
        Dim SaldoDoc As Integer = 0
        Dim stitle As String = "Abono Deuda"

        For i As Integer = 0 To GrillaPagos.Rows.Count - 1
            If GrillaPagos.Rows(i).Cells("id_pago").Value = 0 Then
                bAgregarPago = False
            End If
        Next
        If Not bAgregarPago Then
            MsgBox("Existen Abonos Pendientes sin grabar. Debe Guardar Abonos antes de continuar.", MsgBoxStyle.Critical, stitle)
            bAgregarPago = False
        End If

        If cmb_TIPO_PAGO.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Forma de Pago", MsgBoxStyle.Exclamation)
            bAgregarPago = False
        End If

        If Val(txt_MontoDoc.Text) <= 0 Then
            MsgBox("Monto a Pagar debe ser superior a Cero!!!.", MsgBoxStyle.Exclamation)
            bAgregarPago = False
        End If

        If rbAbonoPedido.Checked AndAlso cmbPedido.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar N° de Pedido a abonar!!!.", MsgBoxStyle.Exclamation)
            bAgregarPago = False
        End If

        If rbAbonoDocumento.Checked AndAlso cmbDocumento.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar N° de Documento a Pagar!!!", MsgBoxStyle.Exclamation)
            bAgregarPago = False
        End If

        If txt_Glosa.Text = Nothing Then
            MsgBox("Debe Ingresar una glosa para el pago!!!", MsgBoxStyle.Exclamation)
            bAgregarPago = False
        End If

        If Not rbAbonoPedido.Checked AndAlso Not rbAbonoDocumento.Checked AndAlso Not chkRebajaDAI.Checked Then
            MsgBox("Debe Seleccionar Destino del Abono: Abono a Pedido o Abono Documento!!!", MsgBoxStyle.Exclamation, stitle)
            bAgregarPago = False
        End If

        If rbAbonoDocumento.Checked AndAlso bAgregarPago Then
            sTipodoc = Mid(cmbDocumento.Text, 1, 2)
            sNumdoc = Mid(cmbDocumento.Text, 3)
            SaldoDoc = 0
            For i = 0 To GrillaVentas.Rows.Count - 1
                If sTipodoc = GrillaVentas.Rows(i).Cells("Tipo").Value AndAlso sNumdoc = GrillaVentas.Rows(i).Cells("Nro").Value Then
                    SaldoDoc = GrillaVentas.Rows(i).Cells("saldodoc").Value
                End If
            Next
            If SaldoDoc = 0 Then
                MsgBox("No se encontró el documento seleccionado para recuperar el saldo", MsgBoxStyle.Critical, stitle)
                bAgregarPago = False
            Else
                If Val(txt_MontoDoc.Text) > gSaldoAjusteDAI AndAlso cmb_TIPO_PAGO.Text = "DOCUMENTO DE AJUSTE INTERNO" Then
                    MsgBox("Monto ingresado de Pago debe ser inferior al Saldo de ajuste DAI del cliente!!!", MsgBoxStyle.Critical, stitle)
                    bAgregarPago = False
                Else
                    If Val(txt_MontoDoc.Text) > SaldoDoc Then
                        If cmb_TIPO_PAGO.Text = "DOCUMENTO DE AJUSTE INTERNO" Then
                            MsgBox("Para pagos con Ajuste Interno DAI, debe ingresar valor de pago menor o igual al saldo del documento!!!", MsgBoxStyle.Exclamation, stitle)
                            bAgregarPago = False
                        Else
                            Dim sResp = MsgBox("Valor pago excede Saldo Pendiente del Documento. Confirme si desea aumentar saldo a favor del cliente.", MsgBoxStyle.YesNo, stitle)
                            If sResp = MsgBoxResult.Yes Then
                                bAgregarPago = True
                            Else
                                bAgregarPago = False
                            End If
                        End If
                    End If

                    If (cmb_TIPO_PAGO.Text = "Letras por Cobrar" OrElse cmb_TIPO_PAGO.Text = "Cheques por Cobrar" OrElse cmb_TIPO_PAGO.Text = "Cheque por Cobrar al Día") AndAlso Val(txt_NumDocPago.Text) <= 0 Then
                        MsgBox("Debe ingresar N° Cheque o Letra según corresponda!!!", MsgBoxStyle.Critical, stitle)
                        bAgregarPago = False
                    End If

                End If
                End If
        End If
        If bAgregarPago Then
            Aplicar_Pago(SaldoDoc)
            Me.cmb_TIPO_PAGO.SelectedIndex = -1
            txt_MontoDoc.Clear()
            txt_Glosa.Clear()
            txt_NumDocPago.Clear()
            cmbPedido.SelectedIndex = -1
            cmbDocumento.SelectedIndex = -1
            rbAbonoPedido.Checked = False
            rbAbonoDocumento.Checked = False
            cmbPedido.Enabled = False
            cmbDocumento.Enabled = False
        End If

    End Sub
    Private Sub btn_AgregarPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Agregar_Pago()
    End Sub

    Private Sub Abono_Deuda_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Carga_FormaPago(Me.cmb_TIPO_PAGO, 2)
    End Sub
    Private Sub Elimina_Pago_Actual(iFila As Integer)
        If GrillaPagos.Rows.Count > 0 Then

            If GrillaPagos.Rows(iFila).Cells("AbonoPedido").Value = "S" Then
                MsgBox("NOTA: Los Pagos provenientes de Abonos a Pedidos se realizan en forma automática desde la emisión de un documento de Venta, por lo tanto este registro no puede ser eliminado.", MsgBoxStyle.Exclamation)
            Else
                If GrillaPagos.Rows(iFila).Cells("estado").Value = 1 Then
                    Dim sResp = MsgBox("Movimiento Contabilizado. Confirme Eliminación de Pago.", MsgBoxStyle.YesNo)
                    If sResp = MsgBoxResult.Yes Then
                        Elimina_Pago_Parcial(GrillaPagos.Rows(iFila).Cells("id_pago").Value)
                        GrillaPagos.Rows.RemoveAt(iFila)
                    End If
                ElseIf GrillaPagos.Rows(iFila).Cells("id_pago").Value > 0 Then
                    Dim sResp = MsgBox("Este Pago ya se encuentra registrado anteriormente. Confirme Eliminación de Pago.", MsgBoxStyle.YesNo)
                    If sResp = MsgBoxResult.Yes Then
                        Elimina_Pago_Parcial(GrillaPagos.Rows(iFila).Cells("id_pago").Value)
                        GrillaPagos.Rows.RemoveAt(iFila)
                    End If
                Else
                    GrillaPagos.Rows.RemoveAt(iFila)
                End If
            End If
        End If
    End Sub
    Private Sub Elimina_Pago_Parcial(ByVal iClave As Integer)
        Dim stitle As String = "Abono Deuda"
        sSsql = "SP_ELIMINA_PAGOS_PARCIAL " & iClave.ToString
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            If datatbl(0) = 0 Then
                MsgBox("Pago ha sido Eliminado de la base de datos.", MsgBoxStyle.Information, stitle)
            Else
                MsgBox("No es posible eliminar Pago. Documento a eliminar tiene pagos asociados!!!", MsgBoxStyle.Critical, stitle)
            End If
        End If
        close_conexion()
    End Sub

    Private Sub Grabar_Pagos()
        Dim i As Integer
        If Val(txt_IdCliente.Text) = 0 Then
            MsgBox("Id. Cliente no puede ser 0", MsgBoxStyle.Critical)
        Else
            open()
            command = connection.CreateCommand()
            dNuevoAbono = 0
            For i = 0 To GrillaPagos.Rows.Count - 1
                If GrillaPagos.Rows(i).Cells("id_pago").Value = 0 Then
                    sSsql = "SP_INSERTA_PAGOS_PARCIALES "
                    sSsql += Val(txt_IdCliente.Text).ToString & ","
                    sSsql += "'" & GrillaPagos.Rows(i).Cells("FechaPago").Value & "',"
                    sSsql += "'" & GrillaPagos.Rows(i).Cells("docpago").Value & "',"
                    sSsql += "'" & GrillaPagos.Rows(i).Cells("num").Value & "',"
                    sSsql += GrillaPagos.Rows(i).Cells("monto").Value.ToString & ","
                    sSsql += "'" & GrillaPagos.Rows(i).Cells("tipodoc").Value & "',"
                    sSsql += "'" & GrillaPagos.Rows(i).Cells("numdoc").Value.ToString & "',"
                    sSsql += GrillaPagos.Rows(i).Cells("ValorPagado").Value.ToString & ","
                    sSsql += "'" & GrillaPagos.Rows(i).Cells("fec_venc").Value & "',"
                    sSsql += "'" & GrillaPagos.Rows(i).Cells("Glosa").Value & "',"
                    sSsql += "'N',"
                    sSsql += "'" & GrillaPagos.Rows(i).Cells("fechaconta").Value & "',"
                    sSsql += GrillaPagos.Rows(i).Cells("IdPedido").Value.ToString & ","
                    sSsql += "'" & gUSER & "',"
                    sSsql += Val(GrillaPagos.Rows(i).Cells("ValorDAI").Value).ToString() & ","
                    sSsql += "0,"
                    sSsql += "'" & GrillaPagos.Rows(i).Cells("rebajaDAI").Value & "'"
                    command.CommandText = sSsql
                    command.ExecuteNonQuery()
                    dNuevoAbono += GrillaPagos.Rows(i).Cells("ValorPagado").Value
                End If
            Next
            close_conexion()
            If dNuevoAbono > 0 Then
                Dim sResp = MsgBox("Imprime Comprobante de Pago?", MsgBoxStyle.YesNo)
                If sResp = MsgBoxResult.Yes Then
                    Emision_Comprobante(dNuevoAbono, Now.Date)
                End If
            End If
            Recupera_Datos_Cliente()
        End If
    End Sub
    Private Sub btn_grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Grabar_Pagos()
    End Sub
    Private Sub Emision_Comprobante(AbonoActual As Double, FechaContable As Date)
        gAbonoRecibo = AbonoActual
        gFechaContable = FechaContable
        Dim prnTxt As New PrintDocument
        AddHandler prnTxt.PrintPage, AddressOf Me.Genera_Comprobante_Pago
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            prnTxt.PrinterSettings.PrinterName = PrintDialog1.PrinterSettings.PrinterName
            prnTxt.PrinterSettings.Copies = 1
            prnTxt.Print()
        End If
    End Sub
    Private Sub Genera_Comprobante_Pago(ByVal sender As System.Object, ByVal ePrint As PrintPageEventArgs)
        Dim sTitulo As String
        Dim iTamanoLetra1 As Integer
        Dim iTamanoLetra2 As Integer
        Dim iTamanoLetra3 As Integer
        Dim iLinea As Integer
        Dim iCol As Integer
        Dim sTipoLetra As String
        Dim sLogo As String
        Dim sTexto00 As String
        Dim sTexto01 As String
        Dim sTexto02 As String
        Dim sTexto03 As String
        Dim sTexto04 As String
        Dim sTexto05 As String
        Dim sTexto06 As String
        Rescata_Resumen_Cliente()
        sTexto00 = "Con fecha " & Format(gFechaContable, "dd") & " de " & Format(gFechaContable, "MMMM") & " de " & Format(gFechaContable, "yyyy")
        sTexto01 = "Hemos recibido del Señor;"
        sTexto02 = txt_NombreCliente.Text
        'sTexto02 = "123456789012345678901234567890123456789012345678901234567890"
        sTexto03 = "RUT: " & txt_RUT_CLI.Text
        sTexto04 = "La suma de $" & Format(gAbonoRecibo, "###,###,###")
        sTexto05 = "por concepto de Abono"
        sTexto06 = "La deuda actual es de $" & txt_DeudaTotal.Text
        iCol = 10
        sTitulo = "RECIBO DE DINERO"
        sLogo = gDataEmp
        iTamanoLetra1 = 8
        iTamanoLetra2 = 10
        iTamanoLetra3 = 8
        sTipoLetra = "Arial"
        ePrint.Graphics.DrawString(sLogo, New Font("High Tower Text", 14, FontStyle.Bold, GraphicsUnit.Point), Brushes.Green, 0, 1)
        iLinea += 25
        ePrint.Graphics.DrawString(gDataEmpFono, New Font("Arial Narrow", iTamanoLetra1, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 30
        iCol = 30
        ePrint.Graphics.DrawString(sTitulo, New Font("Arial Narrow", iTamanoLetra3, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 40
        iCol = 0
        ePrint.Graphics.DrawString(sTexto00, New Font(sTipoLetra, iTamanoLetra3, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 30
        ePrint.Graphics.DrawString(sTexto01, New Font(sTipoLetra, iTamanoLetra3, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 15
        ePrint.Graphics.DrawString(sTexto02, New Font("Arial Narrow", iTamanoLetra3, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 15
        ePrint.Graphics.DrawString(sTexto03, New Font(sTipoLetra, iTamanoLetra3, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 15
        ePrint.Graphics.DrawString(sTexto04, New Font(sTipoLetra, iTamanoLetra3, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 15
        ePrint.Graphics.DrawString(sTexto05, New Font(sTipoLetra, iTamanoLetra3, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 30
        ePrint.Graphics.DrawString(sTexto06, New Font(sTipoLetra, iTamanoLetra3, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 30
        ePrint.Graphics.DrawString(".....................................", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol + 20, iLinea)
        iLinea += 10
        ePrint.Graphics.DrawString("Firma Cliente", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol + 35, iLinea)
        ePrint.HasMorePages = False
    End Sub

    Private Sub Aplicar_Pago(iSaldoDocumento As Integer)
        Dim j As Integer = 0
        Dim sTipoDocumento As String
        Dim iNumDocumento As Integer
        Dim MontoAbonoDocumento As Integer
        Dim ValorDAI As Integer
        If rbAbonoPedido.Checked Then
            GrillaPagos.Rows.Add()
            j = GrillaPagos.Rows.Count - 1
            GrillaPagos.Rows(j).Cells("id_pago").Value = 0
            GrillaPagos.Rows(j).Cells("FechaPago").Value = Format(Now.Date, "dd/MM/yyyy")
            GrillaPagos.Rows(j).Cells("fechaconta").Value = Format(dtp_Fecha_Contable.Value, "d")
            GrillaPagos.Rows(j).Cells("docpago").Value = cmb_TIPO_PAGO.Text
            GrillaPagos.Rows(j).Cells("num").Value = txt_NumDocPago.Text
            GrillaPagos.Rows(j).Cells("monto").Value = Format(Val(txt_MontoDoc.Text), "#########")
            GrillaPagos.Rows(j).Cells("tipodoc").Value = ""
            GrillaPagos.Rows(j).Cells("numdoc").Value = 0
            GrillaPagos.Rows(j).Cells("IdPedido").Value = Val(cmbPedido.Text)
            GrillaPagos.Rows(j).Cells("ValorPagado").Value = Format(Val(txt_MontoDoc.Text), "#########")
            GrillaPagos.Rows(j).Cells("fec_venc").Value = Format(dtp_FechaVenc.Value, "d")
            GrillaPagos.Rows(j).Cells("Glosa").Value = txt_Glosa.Text
            GrillaPagos.Rows(j).Cells("estado").Value = 0
            GrillaPagos.Rows(j).Cells("PagoNoEditado").Value = Val(txt_MontoDoc.Text)
            GrillaPagos.Rows(j).Cells("ValorDAI").Value = 0
            GrillaPagos.Rows(j).Cells("rebajaDAI").Value = "N"
            GrillaPagos.Rows(j).Cells("usuario").Value = gUSER
            gSaldoxAsignar = 0
            gTotalPagar = 0
        End If
        If rbAbonoDocumento.Checked Then
            ' Abono a Documento Seleccionado
            sTipoDocumento = Mid(cmbDocumento.Text, 1, 2)
            iNumDocumento = Val(Mid(cmbDocumento.Text, 3))
            If Val(txt_MontoDoc.Text) > iSaldoDocumento Then
                MontoAbonoDocumento = iSaldoDocumento
                ValorDAI = Val(txt_MontoDoc.Text) - iSaldoDocumento
            Else
                MontoAbonoDocumento = Val(txt_MontoDoc.Text)
                ValorDAI = 0
            End If
            GrillaPagos.Rows.Add()
            j = GrillaPagos.Rows.Count - 1
            GrillaPagos.Rows(j).Cells("id_pago").Value = 0
            GrillaPagos.Rows(j).Cells("FechaPago").Value = Format(Now.Date, "dd/MM/yyyy")
            GrillaPagos.Rows(j).Cells("fechaconta").Value = Format(dtp_Fecha_Contable.Value, "d")
            GrillaPagos.Rows(j).Cells("docpago").Value = cmb_TIPO_PAGO.Text
            GrillaPagos.Rows(j).Cells("num").Value = txt_NumDocPago.Text
            GrillaPagos.Rows(j).Cells("monto").Value = Format(MontoAbonoDocumento, "#########")
            GrillaPagos.Rows(j).Cells("tipodoc").Value = sTipoDocumento
            GrillaPagos.Rows(j).Cells("numdoc").Value = iNumDocumento
            GrillaPagos.Rows(j).Cells("IdPedido").Value = 0
            GrillaPagos.Rows(j).Cells("ValorPagado").Value = Format(MontoAbonoDocumento, "#########")
            GrillaPagos.Rows(j).Cells("fec_venc").Value = Format(dtp_FechaVenc.Value, "d")
            GrillaPagos.Rows(j).Cells("Glosa").Value = txt_Glosa.Text
            GrillaPagos.Rows(j).Cells("estado").Value = 0
            GrillaPagos.Rows(j).Cells("PagoNoEditado").Value = Val(txt_MontoDoc.Text)
            GrillaPagos.Rows(j).Cells("ValorDAI").Value = Format(ValorDAI, "#########")
            GrillaPagos.Rows(j).Cells("rebajaDAI").Value = "N"
            GrillaPagos.Rows(j).Cells("usuario").Value = gUSER
        End If

        If chkRebajaDAI.Checked Then
            GrillaPagos.Rows.Add()
            j = GrillaPagos.Rows.Count - 1
            GrillaPagos.Rows(j).Cells("id_pago").Value = 0
            GrillaPagos.Rows(j).Cells("FechaPago").Value = Format(Now.Date, "dd/MM/yyyy")
            GrillaPagos.Rows(j).Cells("fechaconta").Value = Format(dtp_Fecha_Contable.Value, "d")
            GrillaPagos.Rows(j).Cells("docpago").Value = cmb_TIPO_PAGO.Text
            GrillaPagos.Rows(j).Cells("num").Value = txt_NumDocPago.Text
            GrillaPagos.Rows(j).Cells("monto").Value = Format(Val(txt_MontoDoc.Text), "#########")
            GrillaPagos.Rows(j).Cells("tipodoc").Value = ""
            GrillaPagos.Rows(j).Cells("numdoc").Value = 0
            GrillaPagos.Rows(j).Cells("IdPedido").Value = 0
            GrillaPagos.Rows(j).Cells("ValorPagado").Value = Format(Val(txt_MontoDoc.Text), "#########")
            GrillaPagos.Rows(j).Cells("fec_venc").Value = Format(dtp_FechaVenc.Value, "d")
            GrillaPagos.Rows(j).Cells("Glosa").Value = txt_Glosa.Text
            GrillaPagos.Rows(j).Cells("estado").Value = 0
            GrillaPagos.Rows(j).Cells("PagoNoEditado").Value = Val(txt_MontoDoc.Text)
            GrillaPagos.Rows(j).Cells("ValorDAI").Value = 0
            GrillaPagos.Rows(j).Cells("rebajaDAI").Value = "S"
            GrillaPagos.Rows(j).Cells("usuario").Value = gUSER
        End If
        GrillaPagos.Sort(id_pago, System.ComponentModel.ListSortDirection.Ascending)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Rescata_Documentos_Ventas(txt_IdCliente.Text, 1)
    End Sub
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim bAgregaPago As Boolean = True
        If rbAbonoPedido.Checked Then
            Select Case cmbPedido.SelectedIndex
                Case Is <> -1
                Case Else
                    MsgBox("Debe Seleccionar Nº de Pedido", MsgBoxStyle.Exclamation)
                    bAgregaPago = False
            End Select
        End If
        If bAgregaPago Then
            Agregar_Pago()
        End If
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Elimina_Pago_Actual(GrillaPagos.CurrentRow.Index)
        Recupera_Datos_Cliente()
    End Sub
    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Grabar_Pagos()
    End Sub
    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If Val(txt_IdCliente.Text) = 0 Then
            MsgBox("Seleccione Cliente!!!", MsgBoxStyle.Critical, "Abono Deuda")
        Else
            open()
            command = connection.CreateCommand()
            sSsql = "SP_Actualiza_Abono_Inicial_Cliente " & Val(txt_IdCliente.Text).ToString()
            command.CommandText = sSsql
            command.ExecuteNonQuery()
            close_conexion()
            MsgBox("Abono Inicial ha sido Actualizado!")
            Recupera_Datos_Cliente()
        End If
    End Sub

    Public Sub Recupera_Datos_Cliente()
        'limpia campos editables
        cmb_TIPO_PAGO.SelectedIndex = -1
        cmbPedido.SelectedIndex = -1
        cmbDocumento.SelectedIndex = -1
        txt_MontoDoc.Clear()
        cmbDocumento.Items.Clear()
        cmbPedido.Items.Clear()
        rbAbonoDocumento.Checked = False
        rbAbonoPedido.Checked = False
        cmbPedido.Enabled = False
        cmbDocumento.Enabled = False
        txt_Glosa.Clear()
        txt_NumDocPago.Clear()
        Rescata_Resumen_Cliente()
        Rescata_Documentos_Ventas(txt_IdCliente.Text, 0)
        Rescata_Pagos_Historicos(Val(txt_IdCliente.Text).ToString)
        RescataPedidosActCli(Val(txt_IdCliente.Text))
        gIdCliente = Val(txt_IdCliente.Text)
    End Sub
    Private Sub txt_NombreCliente_TextChanged(sender As Object, e As EventArgs) Handles txt_NombreCliente.TextChanged
        gRutCli = txtRutCli.Text
        Recupera_Datos_Cliente()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Rescata_Documentos_Ventas(txt_IdCliente.Text, 0)
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If GrillaPagos.Rows.Count > 0 Then
            Dim i As Integer = GrillaPagos.CurrentRow.Index
            Dim Abono As Double = GrillaPagos.Rows(i).Cells("PagoNoEditado").Value
            gFechaContable = GrillaPagos.Rows(i).Cells("fechaconta").Value
            Emision_Comprobante(Abono, gFechaContable)
        End If
    End Sub

    Private Sub rbAbonoPedido_CheckedChanged(sender As Object, e As EventArgs) Handles rbAbonoPedido.CheckedChanged
        If rbAbonoPedido.Checked Then
            cmbPedido.Enabled = True
            cmbDocumento.Enabled = False
            cmbDocumento.SelectedIndex = -1
            cmbPedido.Select()
        End If
    End Sub

    Private Sub rbAbonoDocumento_CheckedChanged(sender As Object, e As EventArgs) Handles rbAbonoDocumento.CheckedChanged
        If rbAbonoDocumento.Checked Then
            cmbDocumento.Enabled = True
            cmbPedido.Enabled = False
            cmbPedido.SelectedIndex = -1
            cmbDocumento.Select()
        End If
    End Sub

    Private Sub chkRebajaDAI_CheckedChanged(sender As Object, e As EventArgs) Handles chkRebajaDAI.CheckedChanged
        If chkRebajaDAI.Checked Then
            rbAbonoDocumento.Enabled = False
            rbAbonoPedido.Enabled = False
        Else
            rbAbonoDocumento.Enabled = True
            rbAbonoPedido.Enabled = True
        End If
    End Sub
    Private Sub txt_MontoDoc_LostFocus(sender As Object, e As EventArgs) Handles txt_MontoDoc.LostFocus
        If chkRebajaDAI.Checked Then
            If Val(txt_MontoDoc.Text) <= 0 OrElse gSaldoAjusteDAI <= 0 OrElse Val(txt_MontoDoc.Text) <= gSaldoAjusteDAI Then
                Return
            End If
            MsgBox("Valor no puede ser superior al saldo D.A.I del cliente!!!", MsgBoxStyle.Critical, "Abono Deuda")
            txt_MontoDoc.Clear()
            txt_MontoDoc.Select()
        End If

        If Val(txt_MontoDoc.Text) > 0 Then
            If cmb_TIPO_PAGO.Text = "Letras por Cobrar" OrElse cmb_TIPO_PAGO.Text = "Cheques por Cobrar" Then
                If Val(txt_MontoDoc.Text) > Val(Extrae_comas(txtSaldoLineaCredito.Text)) Then
                    MsgBox("Saldo de Línea de Crédito insuficiente para forma de pago seleccionada!!!", MsgBoxStyle.Critical, "Abono Deuda")
                    txt_MontoDoc.Clear()
                    txt_MontoDoc.Select()
                End If
            End If

        End If
    End Sub


    Private Sub cmb_TIPO_PAGO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_TIPO_PAGO.SelectedIndexChanged
        If cmb_TIPO_PAGO.Text = "Letras por Cobrar" Then
            Dim iNumLetra As Integer
            sSsql = "Select MAX(num_doc_pago)+1 From CarteraDocumentos Where IdFpago=5"
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                datatbl.Read()
                iNumLetra = datatbl(0)
                txt_NumDocPago.Text = iNumLetra
                txt_NumDocPago.ReadOnly = True
            End If
            close_conexion()
        End If
        If cmb_TIPO_PAGO.Text = "Cheques por Cobrar" Then
            txt_NumDocPago.Clear()
            txt_NumDocPago.ReadOnly = False
        End If


        If cmb_TIPO_PAGO.Text = "Letras por Cobrar" OrElse cmb_TIPO_PAGO.Text = "Cheques por Cobrar" Then
            If Val(txt_MontoDoc.Text) > Val(Extrae_comas(txtSaldoLineaCredito.Text)) Then
                MsgBox("Saldo de Línea de Crédito insuficiente para forma de pago seleccionada!!!", MsgBoxStyle.Critical, "Abono Deuda")
                txt_MontoDoc.Clear()
                txt_MontoDoc.Select()
            End If
        End If
    End Sub
    Private Sub txt_NumDocPago_LostFocus(sender As Object, e As EventArgs) Handles txt_NumDocPago.LostFocus
        Dim stitle As String = "Abono Deuda"
        If Val(txt_NumDocPago.Text) > 0 AndAlso cmb_TIPO_PAGO.Text = "Cheques por Cobrar" AndAlso Val(txt_IdCliente.Text) > 0 Then
            sSsql = "select 1 from CarteraDocumentos Where IdCliente=" & Val(txt_IdCliente.Text).ToString & " and Num_Doc_Pago=" & Val(txt_NumDocPago.Text).ToString & " and IdFpago=2"
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                MsgBox("N° de Cheque ya está siendo utilizado en pago anterior!!!", MsgBoxStyle.Critical, stitle)
                txt_NumDocPago.Clear()
            End If
            close_conexion()
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnDevolucion.Click
        RebajaAbonoInicial.txtSaldoAbono.Text = txt_TotalAbonos.Text
        RebajaAbonoInicial.txtMontoAbono.Text = gAbonoActual
        RebajaAbonoInicial.txtIdCliente.Text = gIdCliente
        RebajaAbonoInicial.Show()
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click

        If gQuienLlama = 90 Then ' llamado desde Pedidos
            Pedidos.Recupera_Pedido(txtIdPedido.Text)
        End If
        Me.Close()
    End Sub

    Private Sub txt_MontoDoc_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_MontoDoc.MaskInputRejected

    End Sub

    Private Sub txt_IdCliente_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_IdCliente.MaskInputRejected

    End Sub

    Private Sub txt_NombreCliente_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_NombreCliente.MaskInputRejected

    End Sub
End Class