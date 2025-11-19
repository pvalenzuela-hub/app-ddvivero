Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class Pedidos
    Dim sCODPROD(0 To 0) As String
    Dim aINGREDIENTE(0 To 0) As String
    Dim aING_PCOSTO(0 To 0) As Double
    Dim aING_DESCRIP(0 To 0) As String
    Dim aING_UNIDAD(0 To 0) As String
    Dim gPrecioVenta1 As Double
    Dim gPrecioVenta2 As Double
    Dim gPrecioVentaFinal As Double
    Dim gCostoNeto As Double
    Dim gPEDIDO As Integer
    Dim gTOTAL_NETO As Double
    Dim gTOTAL_PEDIDO As Double
    Dim gValorSemillaAplicado As Double
    Dim gTotalLote As Double
    Dim gPromedioPlantas As Decimal
    Dim gAbono_Inicial As Double

    'Precio
    Dim aIDTipoBandeja(0 To 0) As Double
    Dim PRECIO(0 To 0) As String
    Dim gPrecio_Producto As Double
    Dim gVARIEDAD(0 To 0) As String
    'forma de entrega
    Dim FE_CODIGO(0 To 0) As Integer
    Dim FE_DESCRIP(0 To 0) As String
    Dim FE_COSTO_FLETE(0 To 0) As Double

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


    Private Sub Pedidos_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        close_conexion()
        Me.Close()
        Me.Visible = False
    End Sub

    Private Sub Pedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim style As DataGridViewCellStyle = New DataGridViewCellStyle()
        open()
        'Crea_Tabla()
        Carga_lista_Vendedor(Me.cmb_IDVENDEDOR)
        Carga_Forma_Entrega()
        Carga_Familia_Prod(Me.cmb_Familia)
        Carga_Tipo_Bandeja(Me.cmb_TipoBandeja)
        'Carga_Variedad(Me.cmb_variedad)
        Carga_Lista_Pedidos()
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

            While datatbl.Read = True
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


    Private Sub txt_FECHA_INICIO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FECHA_INICIO.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub



    Private Sub txt_FECHA_INICIO_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FECHA_INICIO.LostFocus
        If IsDate(txt_FECHA_INICIO.Text) Then
            txt_FECHA_ENTREGA.Text = DateAdd("d", Val(txt_Ndias_Fabricacion.Text), txt_FECHA_INICIO.Text)
            Rescata_Precio()
        End If
    End Sub

    Private Sub txt_Ndias_Fabricacion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Ndias_Fabricacion.LostFocus
        If IsDate(txt_FECHA_INICIO.Text) Then
            txt_FECHA_ENTREGA.Text = DateAdd("d", Val(txt_Ndias_Fabricacion.Text), txt_FECHA_INICIO.Text)
        End If
    End Sub


    Private Sub cmb_TipoBandeja_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TipoBandeja.SelectedIndexChanged
        If cmb_TipoBandeja.SelectedIndex >= 0 Then
            txt_CantBandejas.Text = Calculo_Bandejas(Val(txt_Cantidad.Text), TB_CANTIDAD(cmb_TipoBandeja.SelectedIndex))
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Agrega_Lote()
        Calcula_Totales()
    End Sub
    Private Sub Agrega_Lote()
        Dim i As Integer

        ' Agrega LOTE al Carro
        'dc11.Expression = "(Cantidad*Precio) + Flete - Descuento - Abono"
        If Val(txt_Cantidad.Text) <= 0 Then
            MsgBox("DEBE INGRESAR CANTIDAD DE PLANTAS")
            Exit Sub
        End If

        If Me.cmb_variedad.SelectedIndex = -1 Then
            MsgBox("DEBE SELECCIONAR VARIEDAD")
            Exit Sub
        End If

        DataGrilla.Rows.Add()
        i = DataGrilla.Rows.Count - 1
        'dr = Pedidos.NewRow()
        DataGrilla.Rows(i).Cells(1).Value = txt_FECHA_INICIO.Text
        'dr(1) = txt_FECHA_INICIO.Text
        DataGrilla.Rows(i).Cells(2).Value = txt_FECHA_ENTREGA.Text
        'dr(2) = txt_FECHA_ENTREGA.Text
        'dr(3) = Val(txt_CantBandejas.Text)
        DataGrilla.Rows(i).Cells(3).Value = Val(Reemplaza_Comas(txt_CantBandejas.Text))
        'dr(4) = Me.cmb_Familia.Text
        DataGrilla.Rows(i).Cells(4).Value = Me.cmb_Familia.Text
        'dr(5) = Me.cmb_variedad.Text
        DataGrilla.Rows(i).Cells(5).Value = Me.cmb_variedad.Text
        'dr(6) = Format(Val(txt_Cantidad.Text), "###,###,###")
        DataGrilla.Rows(i).Cells(6).Value = Format(Val(txt_Cantidad.Text), "###,###,###")
        'dr(7) = Format(Val(Reemplaza_Comas(txt_PrecioVenta.Text)), "#,###.00")
        DataGrilla.Rows(i).Cells(7).Value = Format(Val(Reemplaza_Comas(txt_PrecioVenta.Text)), "#,###.00")
        'dr(8) = Format(Val(txt_totallote.Text), "###,###,##0")
        DataGrilla.Rows(i).Cells(8).Value = gTotalLote
        'dr(9) = cmb_TipoBandeja.Text
        DataGrilla.Rows(i).Cells(9).Value = cmb_TipoBandeja.Text
        'dr(10) = "0"
        DataGrilla.Rows(i).Cells(10).Value = 0
        'dr(11) = TB_CODIGO(Me.cmb_TipoBandeja.SelectedIndex)
        DataGrilla.Rows(i).Cells(11).Value = TB_CODIGO(Me.cmb_TipoBandeja.SelectedIndex)
        'dr(12) = aID_FAMILIA_PROD(Me.cmb_Familia.SelectedIndex)
        DataGrilla.Rows(i).Cells(12).Value = aID_FAMILIA_PROD(Me.cmb_Familia.SelectedIndex)
        'dr(13) = aID_VARIEDAD(Me.cmb_variedad.SelectedIndex)
        DataGrilla.Rows(i).Cells(13).Value = aID_VARIEDAD(Me.cmb_variedad.SelectedIndex)
        'dr(14) = txt_LoteSemilla.Text
        DataGrilla.Rows(i).Cells(14).Value = txt_LoteSemilla.Text
        'dr(15) = txt_Batch.Text
        DataGrilla.Rows(i).Cells(15).Value = txt_Batch.Text
        'dr(16) = txt_FechaEnvasado.Text
        DataGrilla.Rows(i).Cells(16).Value = txt_FechaEnvasado.Text
        DataGrilla.Rows(i).Cells(17).Value = cmb_aportasemilla.Text

    End Sub
    Private Sub Calcula_Totales()
        Dim i As Integer
        Dim dTotalNeto As Double
        Dim dTotalIVA As Double
        Dim dTotalPedido As Double
        'Dim dSaldo As Double

        dTotalNeto = 0
        For i = 0 To DataGrilla.Rows.Count - 1
            'dTotalPedido += Val(Extrae_comas(Pedidos.Rows(i)(11).ToString))
            dTotalNeto += DataGrilla.Rows(i).Cells(8).Value
        Next

        dTotalPedido = Math.Round(dTotalNeto * gFactorIVA, 0, MidpointRounding.AwayFromZero)
        'dSaldo = dTotalPedido
        'dTotalNeto = Math.Round(dTotalPedido / gFactorIVA, 0)
        dTotalIVA = dTotalPedido - dTotalNeto
        txt_totalneto.Text = Format(dTotalNeto, "###,###,##0")
        txt_TotalIVA.Text = Format(dTotalIVA, "###,###,##0")
        txt_TotalPedido.Text = Format(dTotalPedido, "###,###,##0")

        gTOTAL_NETO = dTotalNeto
        gTOTAL_PEDIDO = dTotalPedido
    End Sub

    Private Sub txt_Descuento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Calcula_Totales()
    End Sub

    Private Sub txt_TotalAbono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Calcula_Totales()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'ELIMINA N° DE LOTE

        Dim fila As Integer
        Dim sResp As String
        fila = DataGrilla.CurrentRow.Index
        If Val(DataGrilla.Rows(fila).Cells(0).Value) > 0 Then
            If DataGrilla.Rows(fila).Cells(10).Value > 0 Then
                MsgBox("LOTE EN PROCESO. NO ES POSIBLE ELIMINAR. LOTE DEBE ESTAR EN ESTADO=0. ESTADO ACTUAL : " + Str(DataGrilla.Rows(fila).Cells(10).Value))
            Else
                sResp = InputBox("ESTA SEGURO DE ELIMINAR N° DE LOTE: " + Str(DataGrilla.Rows(fila).Cells(0).Value), "ELIMINACION DE N° DE LOTE", "N")
                If UCase(sResp) = "S" Then
                    sSsql = "SP_ELIMINA_PEDIDO_DETALLE " + Str(DataGrilla.Rows(fila).Cells(0).Value)
                    'notepad()
                    open()
                    command = connection.CreateCommand()
                    command.CommandText = sSsql
                    command.ExecuteNonQuery()
                    close_conexion()
                    If fila > -1 And DataGrilla.Rows.Count > 0 Then
                        DataGrilla.Rows.RemoveAt(fila)
                        Calcula_Totales()
                    End If
                End If
            End If
        Else
            If fila > -1 And DataGrilla.Rows.Count > 0 Then
                DataGrilla.Rows.RemoveAt(fila)
                Calcula_Totales()
            End If

        End If

    End Sub
    Private Sub Graba_Lote(ByVal IdPedido As Integer)
        Dim i As Integer
        Dim dAbono As Double
        Dim dPorcion As Decimal

        open()
        command = connection.CreateCommand()
        For i = 0 To DataGrilla.Rows.Count - 1
            'sPrecio = Replace(carrito.Rows(i)(3).ToString, ",", ".")

            '@IDPRODUCTO numeric(18,0),@IdPedido int,@CANTIDAD int,@IdTipoBandeja int,@Cant_Bandeja int,@ESTADO int,@Fecha_Inicio datetime
            '@Fecha_Entrega datetime
            If DataGrilla.Rows(i).Cells(0).Value = 0 Then

                dPorcion = DataGrilla.Rows(i).Cells(8).Value / gTOTAL_NETO
                dAbono = Math.Round(gAbono_Inicial * dPorcion, 0, MidpointRounding.AwayFromZero)

                sSsql = "SP_GRABA_PEDIDO_DETALLE "
                sSsql += Str(DataGrilla.Rows(i).Cells(12).Value) + ","
                sSsql += Str(IdPedido) + ","
                sSsql += Str(DataGrilla.Rows(i).Cells(6).Value) + ","
                sSsql += Reemplaza_Comas(DataGrilla.Rows(i).Cells(7).Value) + ","
                sSsql += Str(DataGrilla.Rows(i).Cells(11).Value) + ","
                sSsql += Str(DataGrilla.Rows(i).Cells(3).Value) + ","
                sSsql += "0,"
                sSsql += "'" + CDate(DataGrilla.Rows(i).Cells(1).Value) + "','"
                sSsql += CDate(DataGrilla.Rows(i).Cells(2).Value) + "',"
                sSsql += Str(DataGrilla.Rows(i).Cells(8).Value) + ","
                sSsql += Str(DataGrilla.Rows(i).Cells(13).Value) + ","
                sSsql += "'" + DataGrilla.Rows(i).Cells(14).Value + "',"
                sSsql += "'" + DataGrilla.Rows(i).Cells(15).Value + "',"
                sSsql += "'" + DataGrilla.Rows(i).Cells(16).Value + "',"
                sSsql += "'" + DataGrilla.Rows(i).Cells(17).Value + "',"
                sSsql += Str(dAbono)

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
        
        iIDPEDIDO = 0

        If Valida_Pedido() Then
            iIdVendedor = ID_Vendedor(cmb_IDVENDEDOR.SelectedIndex)
            iFormaEntrega = FE_CODIGO(cmb_FormaEntrega.SelectedIndex)

            Calcula_Totales()
            gAbono_Inicial = Val(txt_totalabono.Text)
            sSsql = "SP_GRABA_PEDIDO_HEADER " + Str(Val(txt_IDCliente.Text)) + "," + Str(iFormaEntrega) + "," + Str(iIdVendedor) + ",'"
            sSsql += CDate(txt_FECHA_PEDIDO.Text) + "','" + txt_LUGAR_ENTREGA.Text + "','" + txt_Comentarios.Text + "',"
            sSsql += Str(gTOTAL_NETO) + "," + Str(gTOTAL_PEDIDO) + "," + Str(gPEDIDO) + "," + Str(gAbono_Inicial)
            open()
            command = connection.CreateCommand()
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

        Graba_Pedido = iIDPEDIDO

    End Function
    Private Function Valida_Pedido() As Boolean
        bOK = True
        If cmb_FormaEntrega.SelectedIndex = -1 Then
            MsgBox("FORMA DE ENTREGA NO SELECCIONADO")
            bOK = False
        End If

        If cmb_IDVENDEDOR.SelectedIndex = -1 Then
            MsgBox("VENDEDOR NO SELECCIONADO")
            bOK = False
        End If
        If txt_NombreCliente.Text = "" Then
            MsgBox("CLIENTE NO IDENTIFICADO")
            bOK = False
        End If
        Valida_Pedido = bOK
    End Function
    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim iNro_Pedido As Integer
        open()
        iNro_Pedido = Graba_Pedido()
        If iNro_Pedido > 0 Then
            Graba_Lote(iNro_Pedido)
            Carga_Lista_Pedidos()
            cmb_Pedido.Enabled = True
            LimpiaCampos()
            MsgBox("SE HA GRABADO PEDIDO N° " & Str(iNro_Pedido))
        End If
        close_conexion()
    End Sub
    Private Sub LimpiaCampos()
        cmb_Pedido.SelectedIndex = -1
        cmb_FormaEntrega.SelectedIndex = -1
        cmb_IDVENDEDOR.SelectedIndex = -1
        cmb_TipoBandeja.SelectedIndex = -1
        cmb_aportasemilla.SelectedIndex = -1
        cmb_variedad.SelectedIndex = -1
        cmb_Familia.SelectedIndex = -1
        txt_clientebuscar.Text = ""
        txt_CantBandejas.Text = ""
        txt_Cantidad.Text = ""
        txt_Comentarios.Text = ""
        'txt_COSTO_FLETE.Text = ""
        'txt_Descuento.Text = ""
        txt_FECHA_ENTREGA.Text = ""
        txt_FECHA_INICIO.Text = ""
        txt_FECHA_PEDIDO.Text = Now.Date
        txt_IDCliente.Text = ""
        txt_LUGAR_ENTREGA.Text = ""
        txt_Ndias_Fabricacion.Text = ""
        txt_PrecioVenta.Text = ""
        txt_RUT_CLI.Text = ""
        txt_totalabono.Text = ""
        txt_TotalIVA.Text = ""
        txt_totalneto.Text = ""
        txt_TotalPedido.Text = ""
        txt_NombreCliente.Text = ""
        txt_LoteSemilla.Text = ""
        txt_Batch.Text = ""
        txt_FechaEnvasado.Text = ""
        txt_totallote.Text = ""
        DataGrilla.Rows.Clear()

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        LimpiaCampos()
        cmb_Pedido.Enabled = False
        cmb_IDVENDEDOR.Focus()
        gPEDIDO = 0
        cmb_Pedido.Text = ""
    End Sub
    Private Sub Cerrar()
        close_conexion()
        Me.Close()
        Me.Visible = False
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Cerrar()
    End Sub
    Private Sub Carga_Lista_Pedidos()
        cmb_Pedido.Items.Clear()
        open()
        sSsql = "SP_CONSULTA_FULL_PEDIDOS"
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then

            While datatbl.Read = True
                Me.cmb_Pedido.Items.Add(datatbl(0))
            End While

        End If
        datatbl.Close()
        close_conexion()
    End Sub
    Private Sub Rescata_Datos_cliente()


        sSsql = "SP_LECTURA_CLIENTE " + Str(Val(txt_IDCliente.Text))
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
    Private Sub Recupera_Pedido(ByVal IDPedido As Integer)
        Dim i As Integer

        sSsql = "SP_CONSULTA_PEDIDO " + Str(IDPedido)
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            cmb_IDVENDEDOR.Text = datatbl(5)
            txt_FECHA_PEDIDO.Text = datatbl(6)
            cmb_FormaEntrega.Text = datatbl(4)
            txt_LUGAR_ENTREGA.Text = datatbl(8)
            txt_NombreCliente.Text = datatbl(3)
            txt_IDCliente.Text = datatbl(1)
            txt_RUT_CLI.Text = Format(Val(Mid(datatbl(2), 1, 11)), "###,###,###") + "-" + Mid(datatbl(2), 12, 1)
            txt_Comentarios.Text = datatbl(9)
            txt_totalneto.Text = datatbl(10).ToString
            gDIRECCION = datatbl(12).ToString
            gCOMUNA = datatbl(13).ToString
            gCIUDAD = datatbl(14).ToString
            gTELEFONO = datatbl(15).ToString
            gGIRO = datatbl(16).ToString
            txt_totalabono.Text = datatbl(17)
        End If
        datatbl.Close()
        gPEDIDO = IDPedido
        sSsql = "SP_CONSULTA_PEDIDO_DETALLE " + Str(gPEDIDO)
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        DataGrilla.Rows.Clear()

        If datatbl.HasRows Then

            i = 0

            While datatbl.Read = True
                DataGrilla.Rows.Add()
                DataGrilla.Rows(i).Cells(0).Value = datatbl(0)
                DataGrilla.Rows(i).Cells(1).Value = datatbl(10)
                DataGrilla.Rows(i).Cells(2).Value = datatbl(11)
                DataGrilla.Rows(i).Cells(3).Value = datatbl(8)
                ''familia
                DataGrilla.Rows(i).Cells(4).Value = datatbl(3)
                ''variedad
                DataGrilla.Rows(i).Cells(5).Value = datatbl(18)
                DataGrilla.Rows(i).Cells(6).Value = datatbl(6)
                DataGrilla.Rows(i).Cells(7).Value = datatbl(4)
                DataGrilla.Rows(i).Cells(8).Value = datatbl(17)
                DataGrilla.Rows(i).Cells(9).Value = datatbl(16)
                DataGrilla.Rows(i).Cells(10).Value = datatbl(9)
                DataGrilla.Rows(i).Cells(11).Value = datatbl(7)
                DataGrilla.Rows(i).Cells(12).Value = datatbl(2)
                DataGrilla.Rows(i).Cells(13).Value = datatbl(19)
                DataGrilla.Rows(i).Cells(14).Value = datatbl(20)
                DataGrilla.Rows(i).Cells(15).Value = datatbl(21)
                DataGrilla.Rows(i).Cells(16).Value = datatbl(22)
                DataGrilla.Rows(i).Cells(17).Value = datatbl(23)
                i += 1
            End While
        Else
            MsgBox("PEDIDO N° " + Str(gPEDIDO) + " NO CONTIENE LOTES")
        End If
        datatbl.Close()
        close_conexion()
        Calcula_Totales()
    End Sub

    Private Sub cmb_Pedido_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Pedido.SelectedIndexChanged
        If cmb_Pedido.SelectedIndex >= 0 Then
            Recupera_Pedido(Val(cmb_Pedido.Text))
        End If

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        LimpiaCampos()
        cmb_Pedido.Enabled = True
        cmb_Pedido.Focus()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click

        If Val(cmb_Pedido.Text) = 0 Then
            MsgBox("DEBE SELECCIONAR N° DE PEDIDO")
            Exit Sub
        End If

        Dim prnTxt As New PrintDocument
        AddHandler prnTxt.PrintPage, AddressOf Me.Genera_Nota_Pedido

        prnTxt.PrinterSettings.PrinterName = gPrinter
        prnTxt.Print()


    End Sub
    Private Sub Genera_Nota_Pedido(ByVal sender As System.Object, ByVal ePrint As PrintPageEventArgs)

        '' Impresión Nota de Pedido
        Dim sTitulo As String
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


        Rescata_Datos_cliente()

        dAbono = Val(txt_totalabono.Text)
        sTitulo = "NOTA DE PEDIDO N° " & cmb_Pedido.Text
        sLogo = "Vivero Palquibudi"
        iTamanoLetra1 = 8
        iTamanoLetra2 = 10
        iTamanoLetra3 = 12
        sTipoLetra = "Arial"
        ePrint.Graphics.DrawString(sLogo, New Font("High Tower Text", 14, FontStyle.Bold, GraphicsUnit.Point), Brushes.Green, 600, 1)
        ePrint.Graphics.DrawString("Fonos 09.8859339 09.4792985", New Font("Arial Narrow", iTamanoLetra1, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, 610, 25)
        ePrint.Graphics.DrawString(Format(Now, "dd-MMM-yyyy"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 1, 1)
        ePrint.Graphics.DrawString(sTitulo, New Font("Arial Narrow", iTamanoLetra3, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, 5, 25)
        iLinea = 60
        ePrint.Graphics.DrawString("Cliente : " & txt_NombreCliente.Text, New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        ePrint.Graphics.DrawString("Rut : " & txt_RUT_CLI.Text, New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 400, iLinea)
        iLinea += 20
        ePrint.Graphics.DrawString("Dirección : " & gDIRECCION, New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        ePrint.Graphics.DrawString("Comuna : " & gCOMUNA, New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 400, iLinea)
        iLinea += 20
        ePrint.Graphics.DrawString("Teléfono : " & gTELEFONO, New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        ePrint.Graphics.DrawString("Sector : " & gSectorDireccion, New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 400, iLinea)
        iLinea += 20
        ePrint.Graphics.DrawString("Giro : " & gGIRO, New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        iLinea += 20
        ePrint.Graphics.DrawString("Abono Inicial : " & Format(dAbono, "###,###,##0"), New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)

        '' Detalle del Lote


        ''N° Lote	Familia	Variedad	Fec.Inicio	Fec.Entrega	Unidades	Valor Unit.	Desc+Abono	Flete	Total	Tipo Band.
        iLinea += 50
        ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 815, iLinea)
        iLinea += 10
        iCol = 5
        ePrint.Graphics.DrawString("N° Lote", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol += 50
        ePrint.Graphics.DrawString("Familia", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol += 70
        ePrint.Graphics.DrawString("Variedad", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol += 90
        ePrint.Graphics.DrawString("Fec.Inicio", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol += 70
        ePrint.Graphics.DrawString("Fec.Entrega", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol += 70
        ePrint.Graphics.DrawString("Unidades", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol += 50
        ePrint.Graphics.DrawString("Valor Unit.", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol += 70
        ePrint.Graphics.DrawString("Total", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol += 55
        ePrint.Graphics.DrawString("Tipo Band.", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol += 70
        ePrint.Graphics.DrawString("Lote Semilla", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol += 100
        ePrint.Graphics.DrawString("Batch", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol += 60
        ePrint.Graphics.DrawString("Fec.Envasado", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 15
        ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 815, iLinea)
        iLinea += 10


        gDescAbono = 0
        gFlete = 0
        gTotalPedidoNeto = 0
        For i = 0 To DataGrilla.Rows.Count - 1
            iCol = 5

            dCantidad = DataGrilla.Rows(i).Cells(6).Value
            dPrecio = DataGrilla.Rows(i).Cells(7).Value
            dTotalNeto = DataGrilla.Rows(i).Cells(8).Value
            ePrint.Graphics.DrawString(DataGrilla.Rows(i).Cells(0).Value, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol += 50
            ePrint.Graphics.DrawString(DataGrilla.Rows(i).Cells(4).Value, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol += 70
            ePrint.Graphics.DrawString(DataGrilla.Rows(i).Cells(5).Value, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol += 90
            ePrint.Graphics.DrawString(DataGrilla.Rows(i).Cells(1).Value, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol += 70
            ePrint.Graphics.DrawString(DataGrilla.Rows(i).Cells(2).Value, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol += 70
            ePrint.Graphics.DrawString(Format(dCantidad, "###,##0"), New Font(iTamanoLetra1, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol += 70
            ePrint.Graphics.DrawString(Format(dPrecio, "###,##0.00"), New Font(iTamanoLetra1, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol += 50
            ePrint.Graphics.DrawString(Format(dTotalNeto, "###,###,##0"), New Font(iTamanoLetra1, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol += 55
            ePrint.Graphics.DrawString(DataGrilla.Rows(i).Cells(9).Value, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol += 70
            ePrint.Graphics.DrawString(IIf(IsDBNull(DataGrilla.Rows(i).Cells(14).Value), "0", DataGrilla.Rows(i).Cells(14).Value), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol += 100
            ePrint.Graphics.DrawString(IIf(IsDBNull(DataGrilla.Rows(i).Cells(15).Value), "0", DataGrilla.Rows(i).Cells(15).Value), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol += 70
            ePrint.Graphics.DrawString(IIf(IsDBNull(DataGrilla.Rows(i).Cells(16).Value), "0", DataGrilla.Rows(i).Cells(16).Value), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)

            iLinea += 12

            gDescAbono += dDescAbono
            gTotalPedidoNeto += dTotalNeto

        Next
        ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 815, iLinea)
        '' linea de totales
        iLinea += 8
        ePrint.Graphics.DrawString("Total Neto", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, 385, iLinea)
        iCol = 455
        ePrint.Graphics.DrawString(Format(gTotalPedidoNeto, "###,###,##0"), New Font(iTamanoLetra1, iTamanoLetra1, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)

        iLinea += 20

        '' resumen formulario
        ePrint.Graphics.DrawString("Observaciones " & txt_Comentarios.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        iLinea += 30
        ePrint.Graphics.DrawString(".....................................", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 300, iLinea)
        iLinea += 10
        ePrint.Graphics.DrawString("Valores unitarios no incluyen IVA.", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        ePrint.Graphics.DrawString("Firma Cliente", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 330, iLinea)
        iLinea += 30
        ePrint.Graphics.DrawString("Para retirar sus plantas deberá dejar un abono por bandeja hasta su devolución", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        ePrint.HasMorePages = False
    End Sub
    Function Calcula_Lote()
        Calcula_Lote = Nothing
        gTotalLote = Val(txt_Cantidad.Text) * gPrecioVentaFinal
        txt_totallote.Text = Format(gTotalLote, "###,###,##0")

    End Function

    Private Sub txt_Cantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cantidad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_Comentarios.Focus()
            '            e.Handled = True
            '           SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub txt_Cantidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Cantidad.LostFocus
        Calcula_Lote()
        txt_CantBandejas.Text = Math.Round(Val(txt_Cantidad.Text) / TB_CANTIDAD(cmb_TipoBandeja.SelectedIndex), 1, MidpointRounding.AwayFromZero)
        If Val(txt_CantBandejas.Text) < 1 Then
            txt_CantBandejas.Text = 1
        End If
    End Sub

    Private Sub txt_Descuento_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Calcula_Lote()
    End Sub

    Private Sub txt_totalabono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_totalabono.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub txt_totalabono_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_totalabono.LostFocus
        Calcula_Lote()
    End Sub

    Private Sub txt_COSTO_FLETE_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Calcula_Lote()
    End Sub


    Private Sub cmb_Familia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Familia.SelectedIndexChanged
        If cmb_Familia.SelectedIndex >= 0 Then
            Carga_Variedad_Filtro(Me.cmb_variedad, aID_FAMILIA_PROD(Me.cmb_Familia.SelectedIndex))
            Rescata_Precio()
            Me.txt_Ndias_Fabricacion.Text = aDias_Fabricacion(Me.cmb_Familia.SelectedIndex)
        End If
    End Sub
    Private Sub Rescata_Precio()

        If Me.cmb_TipoBandeja.SelectedIndex = -1 Then
            MsgBox("DEBE SELECCIONAR TIPO DE BANDEJA")
            Me.cmb_TipoBandeja.Focus()
            Exit Sub
        End If

        If IsDate(txt_FECHA_INICIO.Text) Then
            sSsql = "SP_CONSULTA_PRECIOS "
            sSsql += Str(TB_CODIGO(Me.cmb_TipoBandeja.SelectedIndex)) + ","
            sSsql += Str(aID_FAMILIA_PROD(Me.cmb_Familia.SelectedIndex)) + ","
            sSsql += "'" + txt_FECHA_INICIO.Text + "'"
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()

            If datatbl.HasRows Then
                datatbl.Read()
                gPrecioVenta1 = datatbl(1)
                gPrecioVenta2 = datatbl(4)
            Else
                gPrecioVenta1 = 0
                gPrecioVenta2 = 0
                MsgBox("PRECIO NO DEFINIDO PARA COMBINACION TIPO DE BANDEJA Y SEMILLA")
            End If
            datatbl.Close()
            Calcula_Precio()
            close_conexion()
        End If

    End Sub
    Private Sub Calcula_Precio()
        If rb_PrecioVentaLista.Checked Then
            gPrecioVentaFinal = gPrecioVenta1 + gValorSemillaAplicado
        End If
        If rb_PrecioVentaEspecial.Checked Then
            gPrecioVentaFinal = gPrecioVenta2 + gValorSemillaAplicado
        End If
        Me.txt_PrecioVenta.Text = gPrecioVentaFinal
        'Me.txt_PrecioVenta.ReadOnly = True
        Calcula_Lote()
    End Sub
    Private Sub cmb_aportasemilla_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_aportasemilla.SelectedIndexChanged
        Aplica_Valor_Semilla()
    End Sub

    Private Sub cmb_variedad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_variedad.SelectedIndexChanged
        Carga_Valor_Semilla(Me.cmb_Familia, Me.cmb_variedad)
        Aplica_Valor_Semilla()
    End Sub
    Private Sub Aplica_Valor_Semilla()
        If cmb_aportasemilla.Text = "NO" Then
            gValorSemillaAplicado = gPrecioSemilla
        Else
            gValorSemillaAplicado = 0
        End If
        Calcula_Precio()

    End Sub

    Private Sub txt_FECHA_PEDIDO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FECHA_PEDIDO.KeyPress
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

    Private Sub txt_Comentarios_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Comentarios.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Elimina_Pedido()
    End Sub
    Private Sub Elimina_Pedido()
        ''SP_ELIMINA_PEDIDO_HEADER
        Dim sResp As String
        Dim IdPedido As Integer

        IdPedido = Val(Me.cmb_Pedido.Text)
        If IdPedido >= 0 Then
            sResp = InputBox("CONFIRME ELIMINACION DE PEDIDO #" + Format(IdPedido, "######"), "ELIMINACION DE PEDIDO", "S")
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
                        MsgBox("NO ES POSIBLE ELIMINAR PEDIDO #" + Format(IdPedido, "######") + ". EXISTEN LOTES EN PROCESO.")
                    Else
                        MsgBox("PEDIDO #" + Format(IdPedido, "######") + " HA SIDO ELIMINADO DEL SISTEMA.")
                        Carga_Lista_Pedidos()
                    End If
                End If
                close_conexion()
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click


        If Rescata_Datos_Lote() Then

        End If

    End Sub
    Private Function Rescata_Datos_Lote() As Boolean
        Dim bOK As Boolean
        Dim iCantidadBandOriginal As Decimal
        Dim iConteoPlantasOriginal As Integer
        Dim Idsemilla As Integer
        Dim IdVariedad As Integer

        ''SP_CONSULTA_DETALLE_LOTE
        bOK = True
        open()
        sSsql = "SP_CONSULTA_DETALLE_LOTE " + Str(Val(txt_NumLote.Text))
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        Idsemilla = 0
        If datatbl.HasRows Then
            datatbl.Read()
            Idsemilla = datatbl(44)
            IdVariedad = datatbl(45)
            txt_PrecioOriginal.Text = datatbl(11)
            txt_AporteSemillaLoteantiguo.Text = datatbl(42)
            txt_SaldoPlantas.Text = datatbl(31)
            '' Revisa que Lote tenga Conteo de Siembra
            If IsDBNull(datatbl(38)) Then
                iCantidadBandOriginal = 0
                iConteoPlantasOriginal = 0
            Else
                iCantidadBandOriginal = datatbl(38)
                iConteoPlantasOriginal = datatbl(16)
            End If
            '' Recpera conteo de plantas si existe
            If Not IsDBNull(datatbl(18)) Then
                If datatbl(18) > 0 Then
                    iConteoPlantasOriginal = datatbl(18)
                End If
            End If
            txt_CantBandOriginal.Text = iCantidadBandOriginal
            If iCantidadBandOriginal <= 0 Then
                MsgBox("LOTE N° " & txt_NumLote.Text & " NO TIENE SALDO DE BANDEJAS")
            Else
                gPromedioPlantas = iConteoPlantasOriginal / iCantidadBandOriginal
            End If
            '' calculo promedio de plantas

        Else
            MsgBox("NO EXISTE N° DE LOTE")
            bOK = False
        End If
        close_conexion()
        If Idsemilla > 0 Then
            Lectura_Costo_Semilla(Idsemilla, IdVariedad)
        End If
        Rescata_Datos_Lote = bOK
    End Function
    Private Sub Lectura_Costo_Semilla(ByVal idFamilia As Integer, ByVal idVariedad As Integer)

        sSsql = "SP_LECTURA_COSTO_SEMILLA "
        sSsql += Str(idFamilia)
        sSsql += ","
        sSsql += Str(idVariedad)
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            txt_PrecioVentaSemilla.Text = Format(datatbl(2), "###,##0.00")
        Else
            MsgBox("SEMILLA NO TIENE PRECIO DE VENTA")
            txt_PrecioVentaSemilla.Text = 0
        End If
        close_conexion()

    End Sub

    Private Sub rb_PrecioVentaLista_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_PrecioVentaLista.Click
        Calcula_Precio()
    End Sub


    Private Sub rb_PrecioVentaEspecial_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_PrecioVentaEspecial.Click
        Calcula_Precio()
    End Sub

    Private Sub txt_CantBandNuevo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_CantBandNuevo.Leave
        txt_ValorTotalNuevoLote.Text = Format(Math.Round(txt_NuevoPrecioLote.Text * txt_CantPlantasNuevoLote.Text, 0), "###,###,###")
    End Sub

    Private Sub txt_CantBandNuevo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_CantBandNuevo.LostFocus
        Dim iCantidadPlantasnuevo As Integer

        If Val(txt_CantBandNuevo.Text) > Val(txt_CantBandOriginal.Text) Then
            MsgBox("CANTIDAD DE BANDEJAS NO PUEDE SER MAYOR AL LOTE ORIGINAL")
            txt_CantBandNuevo.Focus()
            Exit Sub
        End If
        If Val(txt_CantBandNuevo.Text) <= 0 Then
            MsgBox("CANTIDAD DE BANDEJAS DEBE SER MAYOR A CERO")
            txt_CantBandNuevo.Focus()
            Exit Sub
        End If
        iCantidadPlantasnuevo = Math.Round(Val(txt_CantBandNuevo.Text) * gPromedioPlantas, 0, MidpointRounding.AwayFromZero)
        txt_CantPlantasNuevoLote.Text = iCantidadPlantasnuevo
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        '' Botón Crea Nuevo Lote
        Dim sResp As String
        Dim iNuevoPedido As Integer
        If Valida_Pedido() Then
            If Val(txt_NumLote.Text) = 0 Then
                MsgBox("N° DE LOTE NO VALIDO")
                Exit Sub
            End If
            If Val(txt_CantBandNuevo.Text) = 0 Then
                MsgBox("CANTIDAD DE BANDEJAS NO VALIDO")
                Exit Sub
            End If

            If Val(txt_CantPlantasNuevoLote.Text) > Val(txt_SaldoPlantas.Text) Then
                MsgBox("CANTIDAD DE PLANTAS NO PUEDE EXCEDER SALDO DE PLANTAS LOTE ORIGINAL")
                Exit Sub
            End If
            sResp = InputBox("CONFIRME CREACION DE PEDIDO", "Copiar Lote Existente", "S")
            If UCase(sResp) = "S" Then
                iNuevoPedido = Graba_Pedido()
                If iNuevoPedido > 0 Then
                    '' Crear Nuevo Lote a partir de uno existente, utilizando nueva cantidad de plantas
                    sSsql = "SP_CREA_NUEVO_LOTE_EXISTENTE "
                    sSsql += Str(iNuevoPedido) + ","
                    sSsql += Str(Val(txt_NumLote.Text)) + ","
                    sSsql += Str(Val(txt_NuevoPrecioLote.Text)) + ","
                    sSsql += Str(Val(txt_CantPlantasNuevoLote.Text)) + ","
                    sSsql += Str(gPromedioPlantas) + ","
                    sSsql += Str(Val(txt_CantBandNuevo.Text))
                    open()
                    command = connection.CreateCommand()
                    command.CommandText = sSsql
                    command.ExecuteNonQuery()
                    close_conexion()
                    MsgBox("SE HA CREADO EL PEDIDO N° " + Str(iNuevoPedido))
                    Carga_Lista_Pedidos()
                End If
            End If
        End If

    End Sub


    Private Sub txt_CantBandNuevo_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txt_CantBandNuevo.MaskInputRejected

    End Sub

    Private Sub txt_Cantidad_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txt_Cantidad.MaskInputRejected

    End Sub

    Private Sub rb_PrecioVentaEspecial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_PrecioVentaEspecial.CheckedChanged
        If rb_PrecioVentaEspecial.Checked = True Then
            txt_PrecioVenta.ReadOnly = False
        End If
    End Sub

    Private Sub rb_PrecioVentaLista_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_PrecioVentaLista.CheckedChanged
        If rb_PrecioVentaLista.Checked = True Then
            txt_PrecioVenta.ReadOnly = True
        End If
    End Sub

    Private Sub txt_FECHA_INICIO_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txt_FECHA_INICIO.MaskInputRejected

    End Sub

    Private Sub txt_PrecioVenta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_PrecioVenta.LostFocus
        gPrecioVentaFinal = txt_PrecioVenta.Text
        Calcula_Lote()
    End Sub

    Private Sub txt_PrecioVenta_MarginChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_PrecioVenta.MarginChanged

    End Sub

    Private Sub txt_PrecioVenta_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txt_PrecioVenta.MaskInputRejected

    End Sub

    Private Sub txt_NuevoPrecioLote_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_NuevoPrecioLote.Leave
        If Val(txt_NuevoPrecioLote.Text) > 0 And Val(txt_CantPlantasNuevoLote.Text) > 0 Then
            txt_ValorTotalNuevoLote.Text = Format(Math.Round(txt_NuevoPrecioLote.Text * txt_CantPlantasNuevoLote.Text, 0), "###,###,###")
        End If

    End Sub

    Private Sub txt_NuevoPrecioLote_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txt_NuevoPrecioLote.MaskInputRejected

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        gNOMBRE = txt_clientebuscar.Text
        gQuienLlama = 2
        BusquedaCliente.Visible = True
    End Sub

    Private Sub txt_CantPlantasNuevoLote_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_CantPlantasNuevoLote.Leave
        If Val(txt_NuevoPrecioLote.Text) > 0 And Val(txt_CantPlantasNuevoLote.Text) > 0 Then
            txt_ValorTotalNuevoLote.Text = Format(Math.Round(txt_NuevoPrecioLote.Text * txt_CantPlantasNuevoLote.Text, 0), "###,###,###")
        End If

    End Sub

End Class