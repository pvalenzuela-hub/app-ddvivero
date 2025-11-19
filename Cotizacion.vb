Imports System.Drawing.Printing
Public Class Cotizacion
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
    Dim gCeldas As Integer
    Dim PRECIO(0 To 0) As String
    Dim gPrecio_Producto As Double
    Dim gVARIEDAD(0 To 0) As String


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
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)




        'gNOMBRE = txt_clientebuscar.Text
        'gQuienLlama = 3
        'BusquedaCliente.Visible = True
    End Sub

    Private Sub Cotizacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'DS_Cotizacion.SP_CONSULTA_FULL_FORMAENTREGA' Puede moverla o quitarla según sea necesario.
        Me.SP_CONSULTA_FULL_FORMAENTREGATableAdapter.Fill(Me.DS_Cotizacion.SP_CONSULTA_FULL_FORMAENTREGA)
        'TODO: esta línea de código carga datos en la tabla 'DS_Cotizacion.SP_CONSULTA_FULL_FAMILIA_PRODUCTO' Puede moverla o quitarla según sea necesario.
        Me.SP_CONSULTA_FULL_FAMILIA_PRODUCTOTableAdapter.Fill(Me.DS_Cotizacion.SP_CONSULTA_FULL_FAMILIA_PRODUCTO)
        'TODO: esta línea de código carga datos en la tabla 'DS_Cotizacion.SP_CONSULTA_FULL_TIPOBANDEJA' Puede moverla o quitarla según sea necesario.
        Me.SP_CONSULTA_FULL_TIPOBANDEJATableAdapter.Fill(Me.DS_Cotizacion.SP_CONSULTA_FULL_TIPOBANDEJA)
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet.SP_CONSULTA_FULL_VENDEDOR' Puede moverla o quitarla según sea necesario.
        Me.SP_CONSULTA_FULL_VENDEDORTableAdapter.Fill(Me.GESTDataSet.SP_CONSULTA_FULL_VENDEDOR)
        Dim style As DataGridViewCellStyle = New DataGridViewCellStyle()

        'Carga_lista_Vendedor(Me.cmb_IDVENDEDOR)
        'Carga_Forma_Entrega(cmb_FormaEntrega)
        'Carga_Familia_Prod(Me.cmb_Familia)
        'Carga_Tipo_Bandeja(Me.cmb_TipoBandeja)
        'Carga_Variedad(Me.cmb_variedad)


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
    Private Sub LimpiaCampos()
        cmb_FormaEntrega.SelectedIndex = -1
        cmb_IDVENDEDOR.SelectedIndex = -1
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
        txt_PrecioVenta.Text = "0"
        txt_RUT_CLI.Clear()

        txt_TotalPedido.Clear()
        'txt_TotalPedido.Text = ""
        txt_NombreCliente.Clear()

        txt_totallote.Text = ""
        DataGrilla.Rows.Clear()

    End Sub

    Private Sub cmb_TipoBandeja_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TipoBandeja.SelectedIndexChanged
        If cmb_TipoBandeja.SelectedIndex >= 0 Then

            sSsql = "Select Cantidad From TBL_TIPO_BANDEJA Where IdTipoBandeja=" + cmb_TipoBandeja.SelectedValue.ToString()
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows() Then
                datatbl.Read()
                If IsDBNull(datatbl(0)) = True Then
                    gCeldas = 0
                Else
                    gCeldas = datatbl(0)
                End If
            End If
            close_conexion()
            txt_CantBandejas.Text = Calculo_Bandejas(Val(txt_Cantidad.Text), gCeldas)
        End If
    End Sub

    Private Sub cmb_Familia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Familia.SelectedIndexChanged
        If cmb_Familia.SelectedIndex >= 0 Then
            Me.SP_CONSULTA_FULL_VARIEDAD_IdFamiliaTableAdapter.Fill(Me.DS_Cotizacion.SP_CONSULTA_FULL_VARIEDAD_IdFamilia, cmb_Familia.SelectedValue)
            'Carga_Variedad_Filtro(Me.cmb_variedad, Me.cmb_Familia.Text)
            Rescata_Precio()
            sSsql = "Select Dias_Fabrica From FAMILIA Where IdFamilia=" + cmb_Familia.SelectedValue.ToString()
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows() Then
                datatbl.Read()
                If IsDBNull(datatbl(0)) = True Then
                    Me.txt_Ndias_Fabricacion.Text = 0
                Else
                    Me.txt_Ndias_Fabricacion.Text = datatbl(0)
                End If
            End If
            close_conexion()
            'Me.txt_Ndias_Fabricacion.Text = aDias_Fabricacion(Me.cmb_Familia.SelectedIndex)
        End If
    End Sub

    Private Sub cmb_variedad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_variedad.SelectedIndexChanged
        Carga_Valor_Semilla_Id(Me.cmb_Familia, Me.cmb_variedad)
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
    Private Sub Calcula_Precio()
        If rb_PrecioVentaLista.Checked Then
            gPrecioVentaFinal = Math.Round(gPrecioVenta1 * 1.19, 2, MidpointRounding.AwayFromZero) + gValorSemillaAplicado
        End If
        If rb_PrecioVentaEspecial.Checked Then
            gPrecioVentaFinal = Math.Round(gPrecioVenta2 * 1.19, 2, MidpointRounding.AwayFromZero) + gValorSemillaAplicado
        End If
        Me.txt_PrecioVenta.Text = gPrecioVentaFinal
        'Me.txt_PrecioVenta.ReadOnly = True
        Calcula_Lote()
    End Sub
    Function Calcula_Lote()
        Calcula_Lote = Nothing
        gTotalLote = Val(txt_Cantidad.Text) * gPrecioVentaFinal
        txt_totallote.Text = Format(gTotalLote, "###,###,##0")

    End Function
    Private Sub Rescata_Precio()

        If Me.cmb_TipoBandeja.SelectedIndex = -1 Then
            MsgBox("DEBE SELECCIONAR TIPO DE BANDEJA")
            Me.cmb_TipoBandeja.Focus()
            Exit Sub
        End If

        sSsql = "SP_CONSULTA_PRECIO_Venta_Id "
        sSsql += "'" + cmb_TipoBandeja.SelectedValue.ToString() + "',"
        sSsql += "'" + cmb_Familia.SelectedValue.ToString() + "',"
        sSsql += "'" + dtp_Fecha_Inicio.Value + "'"

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then
            datatbl.Read()
            gPrecioVenta1 = datatbl(1)
            gPrecioVenta2 = datatbl(2)
            txt_Ndias_Fabricacion.Text = datatbl(3)
            dtp_FechaEntrega.Value = DateAdd(DateInterval.Day, Val(txt_Ndias_Fabricacion.Text), dtp_Fecha_Inicio.Value)
        Else
            gPrecioVenta1 = 0
            gPrecioVenta2 = 0
            dtp_FechaEntrega.Value = dtp_Fecha_Inicio.Value

            MsgBox("PRECIO NO DEFINIDO PARA COMBINACION TIPO DE BANDEJA Y SEMILLA")
        End If
        datatbl.Close()
        Calcula_Precio()
        close_conexion()


    End Sub

    Private Sub cmb_aportasemilla_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_aportasemilla.SelectedIndexChanged
        Aplica_Valor_Semilla()
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
            MsgBox("Cantidad de Plantas debe ser un valor mayor a cero", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If Me.cmb_variedad.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Variedad", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If txt_NombreCliente.Text = Nothing Or txt_NombreCliente.Text = "" Or Val(txt_IDCliente.Text) <= 0 Then
            MsgBox("Debe Seleccionar Cliente", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If cmb_IDVENDEDOR.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Vendedor que atendió al Cliente", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If cmb_FormaEntrega.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Forma de Entrega", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If cmb_TipoBandeja.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Tipo de Bandeja", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If cmb_Familia.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Semilla o Familia", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If cmb_aportasemilla.SelectedIndex = -1 Then
            MsgBox("Debe Indicar si Cliente Aporta Semilla", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Val(txt_PrecioVenta.Text) <= 0 Then
            MsgBox("Debe Indicar Precio de Venta con IVA", MsgBoxStyle.Critical)
            Exit Sub
        End If

        DataGrilla.Rows.Add()
        i = DataGrilla.Rows.Count - 1
        'dr = Pedidos.NewRow()
        DataGrilla.Rows(i).Cells(1).Value = Format(dtp_Fecha_Inicio.Value, "d")
        DataGrilla.Rows(i).Cells(2).Value = Format(dtp_FechaEntrega.Value, "d")
        DataGrilla.Rows(i).Cells(3).Value = Val(Reemplaza_Comas(txt_CantBandejas.Text))
        DataGrilla.Rows(i).Cells(4).Value = Me.cmb_Familia.Text
        DataGrilla.Rows(i).Cells(5).Value = Me.cmb_variedad.Text
        DataGrilla.Rows(i).Cells(6).Value = Val(txt_Cantidad.Text)
        DataGrilla.Rows(i).Cells(7).Value = Format(Val(Reemplaza_Comas(txt_PrecioVenta.Text)), "####.00")
        DataGrilla.Rows(i).Cells(8).Value = gTotalLote
        DataGrilla.Rows(i).Cells(9).Value = cmb_TipoBandeja.Text
        DataGrilla.Rows(i).Cells(10).Value = 0
        DataGrilla.Rows(i).Cells(11).Value = cmb_TipoBandeja.SelectedValue
        DataGrilla.Rows(i).Cells(12).Value = cmb_Familia.SelectedValue
        DataGrilla.Rows(i).Cells(13).Value = cmb_variedad.SelectedValue
        DataGrilla.Rows(i).Cells(14).Value = cmb_aportasemilla.Text

        cmb_TipoBandeja.SelectedIndex = -1
        cmb_Familia.SelectedIndex = -1
        cmb_variedad.SelectedIndex = -1
        cmb_aportasemilla.SelectedIndex = -1
        txt_Ndias_Fabricacion.Clear()
        dtp_Fecha_Inicio.Value = Date.Now()
        dtp_FechaEntrega.Value = dtp_Fecha_Inicio.Value
        txt_PrecioVenta.Text = "0"
        txt_Cantidad.Clear()
        txt_CantBandejas.Clear()
        txt_totallote.Clear()



    End Sub
    Private Sub Calcula_Totales()
        Dim i As Integer
        Dim dTotalPedido As Double = 0
        'Dim dSaldo As Double

        For i = 0 To DataGrilla.Rows.Count - 1
            'dTotalPedido += Val(Extrae_comas(Pedidos.Rows(i)(11).ToString))
            dTotalPedido += DataGrilla.Rows(i).Cells(8).Value
        Next

        ' dTotalPedido = Math.Round(dTotalNeto * gFactorIVA, 0, MidpointRounding.AwayFromZero)
        'dSaldo = dTotalPedido
        'dTotalNeto = Math.Round(dTotalPedido / gFactorIVA, 0)
        'dTotalIVA = dTotalPedido - dTotalNeto
        'txt_TotalPedido.Text = Format(dTotalNeto, "###,###,##0")
        'txt_TotalIVA.Text = Format(dTotalIVA, "###,###,##0")
        txt_TotalPedido.Text = Format(dTotalPedido, "###,###,##0")


        'gTOTAL_NETO = dTotalNeto
        gTOTAL_PEDIDO = dTotalPedido
    End Sub

    Private Sub txt_FECHA_INICIO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub



    Private Sub rb_PrecioVentaLista_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_PrecioVentaLista.Click
        Calcula_Precio()
    End Sub



    Private Sub rb_PrecioVentaLista_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_PrecioVentaLista.CheckedChanged
        If rb_PrecioVentaLista.Checked = True Then
            txt_PrecioVenta.ReadOnly = True
        End If
    End Sub

    Private Sub rb_PrecioVentaEspecial_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_PrecioVentaEspecial.Click
        Calcula_Precio()
    End Sub

    Private Sub rb_PrecioVentaEspecial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_PrecioVentaEspecial.CheckedChanged
        If rb_PrecioVentaEspecial.Checked = True Then
            txt_PrecioVenta.ReadOnly = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'ELIMINA N° DE LOTE

        Dim fila As Integer
        Dim sResp As String
        fila = DataGrilla.CurrentRow.Index

        sResp = InputBox("Confirma Eliminación de Lote Cotizado", "ELIMINACION LOTE", "N")
        If UCase(sResp) = "S" And fila > -1 And DataGrilla.Rows.Count > 0 Then
            DataGrilla.Rows.RemoveAt(fila)
            Calcula_Totales()
        End If

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
        ' Grabar Cotizacion
        If DataGrilla.Rows.Count > 0 Then
            Dim i As Integer
            Dim dCantidad As Integer
            Dim dPrecio As Double
            Dim dTotal As Double
            Dim IdCotizacion As Integer
            Dim iCantidadBandejas As Integer
            Dim IdTipoBandeja As Integer
            Dim IdFamilia As Integer
            Dim IdVariedad As Integer
            Dim FechaSiembra As String
            Dim FechaEntrega As String

            ' Graba encabezado cotización
            IdCotizacion = Graba_Cotizacion()

            If IdCotizacion > 0 Then
                open()
                command = connection.CreateCommand()
                For i = 0 To DataGrilla.Rows.Count - 1
                    dCantidad = DataGrilla.Rows(i).Cells(6).Value
                    dPrecio = DataGrilla.Rows(i).Cells(7).Value
                    dTotal = DataGrilla.Rows(i).Cells(8).Value
                    iCantidadBandejas = DataGrilla.Rows(i).Cells(3).Value
                    IdTipoBandeja = DataGrilla.Rows(i).Cells(11).Value
                    IdFamilia = DataGrilla.Rows(i).Cells(12).Value
                    IdVariedad = DataGrilla.Rows(i).Cells(13).Value
                    FechaSiembra = DataGrilla.Rows(i).Cells(1).Value
                    FechaEntrega = DataGrilla.Rows(i).Cells(2).Value

                    sSsql = "INSERT INTO [vivero].[CotizacionDetalle] ([IdCotizacion],[Precio],[Cantidad],[Total],[Bandejas],[IdTipoBandeja],[IdFamilia],[IdVariedad],[FechaSiembra],[AportaSemilla],[FechaEntrega]) "
                    sSsql += "VALUES (" + IdCotizacion.ToString() + "," + dPrecio.ToString() + "," + dCantidad.ToString() + "," + dTotal.ToString() + "," + iCantidadBandejas.ToString() + "," + IdTipoBandeja.ToString() + "," + IdFamilia.ToString() + "," + IdVariedad.ToString()
                    sSsql += ",'" + FechaSiembra + "','" + DataGrilla.Rows(i).Cells(14).Value + "','" + FechaEntrega + "')"

                    command.CommandText = sSsql
                    command.ExecuteNonQuery()
                Next
            End If
            close_conexion()
            Cotizacion_Print.txtIdCotizacion.Text = IdCotizacion
            Cotizacion_Print.Show()

        End If

        LimpiaCampos()
        'Dim prnTxt As New PrintDocument
        'AddHandler prnTxt.PrintPage, AddressOf Me.Genera_Cotizacion

        ''prnTxt.PrinterSettings.PrinterName = gPrintPDF

        'If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    prnTxt.PrinterSettings.PrinterName = PrintDialog1.PrinterSettings.PrinterName
        '    prnTxt.Print()
        'End If


    End Sub

    Private Function Graba_Cotizacion() As Integer

        Dim IdFormaEntrega As Integer
        Dim iIdVendedor As Integer
        Dim IdCotizacion As Integer

        iIdVendedor = cmb_IDVENDEDOR.SelectedValue
        IdFormaEntrega = cmb_FormaEntrega.SelectedValue

        If txt_LUGAR_ENTREGA.Text = Nothing Then
            txt_LUGAR_ENTREGA.Text = ""
        End If
        sSsql = "INSERT INTO [vivero].[Cotizacion] ([Fecha],[IdCliente],[IdVendedor],[IdFormaEntrega],[LugarEntrega]) "
        sSsql += "VALUES ('" + Format(dtpFecha.Value, "dd/MM/yyyy") + "'," + txt_IDCliente.Text + "," + iIdVendedor.ToString() + "," + IdFormaEntrega.ToString() + ",'" + txt_LUGAR_ENTREGA.Text + "');"
        sSsql += "Select @@Identity"

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then
            datatbl.Read()
            IdCotizacion = datatbl(0)
            datatbl.Close()
        Else
            IdCotizacion = 0
        End If
        close_conexion()

        Graba_Cotizacion = IdCotizacion

    End Function
    Private Sub Genera_Cotizacion(ByVal sender As System.Object, ByVal ePrint As PrintPageEventArgs)

        '' Impresión Nota de Pedido
        Dim sTitulo As String
        Dim iTamanoLetra1 As Integer
        Dim iTamanoLetra2 As Integer
        Dim iTamanoLetra3 As Integer
        Dim iLinea As Integer
        Dim iCol As Integer
        Dim dTotalNeto As Double
        Dim dCantidad As Double
        Dim dPrecio As Double

        Dim gDescAbono As Double
        Dim gFlete As Double
        Dim gTotalPedidoNeto As Double

        Dim sTipoLetra As String
        Dim sLogo As String


        Rescata_Datos_cliente()

        'dAbono = Val(txt_totalabono.Text)
        sTitulo = "COTIZACION"
        sLogo = My.Settings.DatEMPLADFono
        iTamanoLetra1 = 8
        iTamanoLetra2 = 10
        iTamanoLetra3 = 12
        sTipoLetra = "Arial"
        ePrint.Graphics.DrawString(sLogo, New Font("High Tower Text", 14, FontStyle.Bold, GraphicsUnit.Point), Brushes.Green, 600, 1)
        ePrint.Graphics.DrawString(Format(Now, "dd-MMM-yyyy"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 1, 1)
        ePrint.Graphics.DrawString(sTitulo, New Font("Arial Narrow", iTamanoLetra3, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, 5, 25)
        iLinea = 60
        ePrint.Graphics.DrawString("Cliente : " & txt_NombreCliente.Text, New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        iLinea += 20
        ePrint.Graphics.DrawString("Rut : " & txt_RUT_CLI.Text, New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        iLinea += 20
        'ePrint.Graphics.DrawString("Dirección : " & gDIRECCION, New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        'ePrint.Graphics.DrawString("Comuna : " & gCOMUNA, New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 400, iLinea)
        'iLinea += 20
        'ePrint.Graphics.DrawString("Teléfono : " & gTELEFONO, New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        'ePrint.Graphics.DrawString("Sector : " & gSectorDireccion, New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 400, iLinea)
        'iLinea += 20
        'ePrint.Graphics.DrawString("Giro : " & gGIRO, New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)


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
        For i As Integer = 0 To DataGrilla.Rows.Count - 1
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
            ePrint.Graphics.DrawString(DataGrilla.Rows(i).Cells(6).Value, New Font(iTamanoLetra1, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
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

            gTotalPedidoNeto += dTotalNeto

        Next
        ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 815, iLinea)
        '' linea de totales
        iLinea += 8
        ePrint.Graphics.DrawString("Total", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, 385, iLinea)
        iCol = 455
        ePrint.Graphics.DrawString(Format(gTotalPedidoNeto, "###,###,##0"), New Font(iTamanoLetra1, iTamanoLetra1, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)

        iLinea += 20

        '' resumen formulario
        ePrint.Graphics.DrawString("Observaciones " & txt_Comentarios.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        iLinea += 30
        ePrint.Graphics.DrawString(".....................................", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 300, iLinea)
        iLinea += 10
        'ePrint.Graphics.DrawString("Valores unitarios no incluyen IVA.", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        ePrint.Graphics.DrawString("Firma Cliente", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 330, iLinea)
        iLinea += 30
        ePrint.Graphics.DrawString("Para retirar sus plantas deberá dejar un abono por bandeja hasta su devolución", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)
        ePrint.HasMorePages = False
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
            gDIRECCION = datatbl(3)
            gCOMUNA = datatbl(4)
            gTELEFONO = datatbl(6)
            gGIRO = datatbl(10)
        End If
        datatbl.Close()
        close_conexion()


    End Sub

    Private Sub txt_Cantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)


        If Asc(e.KeyChar) = 13 Then
            txt_Comentarios.Focus()
            '            e.Handled = True
            '           SendKeys.Send("{TAB}")
        End If
    End Sub



    Private Sub txt_PrecioVenta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_PrecioVenta.LostFocus
        gPrecioVentaFinal = Val(txt_PrecioVenta.Text)
        Calcula_Lote()
    End Sub

    Private Sub dtp_Fecha_Inicio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Rescata_Precio()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        If chkCliente.Checked = True Then
            BusquedaCliente.chkIncluyePrimerNombre.Checked = True
        Else
            BusquedaCliente.chkIncluyePrimerNombre.Checked = False
        End If


        gNOMBRE = txt_clientebuscar.Text
        gQuienLlama = 3
        BusquedaCliente.Visible = True

    End Sub

    Private Sub dtp_FechaEntrega_ValueChanged(sender As Object, e As EventArgs) Handles dtp_FechaEntrega.ValueChanged

    End Sub

    Private Sub dtp_FechaEntrega_LostFocus(sender As Object, e As EventArgs) Handles dtp_FechaEntrega.LostFocus
        Dim Ndias_Fabricacion_Previo As Integer
        If Val(txt_Ndias_Fabricacion.Text) > 0 Then
            Ndias_Fabricacion_Previo = Val(txt_Ndias_Fabricacion.Text) * -1
            'dDifDiasInicioTermino = DateDiff(DateInterval.Day, dtp_Fecha_Inicio.Value, dtp_FechaEntrega.Value)
            dtp_Fecha_Inicio.Value = DateAdd(DateInterval.Day, Ndias_Fabricacion_Previo, dtp_FechaEntrega.Value)
            If dtp_Fecha_Inicio.Value < Now.Date Then
                MsgBox("Fecgha de Siembra No puede ser anterior a hoy!!!", MsgBoxStyle.Exclamation)
                dtp_Fecha_Inicio.Value = Now.Date
            End If
        End If
        Rescata_Precio()
    End Sub

    Private Sub txt_Cantidad_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_Cantidad.MaskInputRejected

    End Sub

    Private Sub txt_PrecioVenta_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_PrecioVenta.MaskInputRejected

    End Sub

    Private Sub txt_Cantidad_LostFocus(sender As Object, e As EventArgs) Handles txt_Cantidad.LostFocus

        Calcula_Lote()
        txt_CantBandejas.Text = Math.Round(Val(txt_Cantidad.Text) / gCeldas, 1, MidpointRounding.AwayFromZero)
        If Val(txt_CantBandejas.Text) < 1 Then
            txt_CantBandejas.Text = 1
        End If
    End Sub
End Class