Imports System.Data.SqlClient
Public Class Cambio_Estado
    Dim datatbl As SqlClient.SqlDataReader = Nothing
    Dim command As SqlCommand = Nothing
    Dim command_lote As SqlCommand = Nothing
    Dim GESTADO As Integer
    Dim GEstado_Actual As Integer
    Dim pCantidadPedido As Double
    Dim pPrecioUnitario As Decimal


    Private Sub ConteoDePlantasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        GESTADO = 2
        Reset_Campos()
        txt_FechaConteoPlantas.ReadOnly = False
        txt_ConteoPlantas.ReadOnly = False
        txt_FechaRetiro.ReadOnly = False

        txt_FechaRetiro.Focus()
        txt_FechaConteoPlantas.BackColor = Color.Green
        txt_ConteoPlantas.BackColor = Color.Green
        txt_FechaRetiro.BackColor = Color.Green

        Conteo_Plantas.Visible = True

    End Sub
    Private Sub Limpia_Campos()
        txt_Cliente.Text = ""
        txt_RUT_CLI.Text = ""
        txt_DIGRUT.Text = ""
        txt_Vendedor.Text = ""
        txt_FECHA_PEDIDO.Text = ""
        txt_FechaEntregaPedido.Text = ""
        txt_FormaEntrega.Text = ""
        'txt_TotalPedido.Text = ""
        'txt_CostoFlete.Text = ""
        'txt_Descuento.Text = ""
        'txt_Abono.Text = ""
        'txt_SaldoPedido.Text = ""
        txt_FechaConteoSiembra.Text = ""
        txt_FechaConteoPlantas.Text = ""
        txt_LoteOriginal.Text = ""
        txt_Semilla.Text = ""

        txt_CantidadPedido.Text = ""
        txt_Precio.Text = ""
        txt_BandejasPedido.Text = ""

        txt_FechaInicioLote.Text = ""
        txt_FechaRetiro.Text = ""
        txt_ConteoSiembra.Text = ""
        txt_ConteoPlantas.Text = ""
        'txt_CantidadBandejasRetiro.Text = ""
        'txt_DevolucionBandejas.Text = ""
        txt_loteshijos.Text = ""
        'txt_SaldoBandejas.Text = ""
        txt_germinacion.Text = ""
        txtTotalPedido.Text = ""
        txt_CantidadCeldas.Text = ""
        txt_CantBandejasConteoInicial.Text = ""
        txt_ubicacion.Text = ""
        txt_guias.Text = ""
        txt_Band_Nuevas.Clear()
        txt_Band_Usadas.Clear()
        TSM_ActualizaDatos.Enabled = False
        TSM_Modificar.Enabled = False
        TSM_ModificaPrecioLote.Enabled = False
        TSM_ModificaEstadoLote.Enabled = False
        TSM_ModificaFechaSiembra.Enabled = False
        TSM_ModificaSaldoBandejas.Enabled = False
        TSM_ModificaSaldoPlantas.Enabled = False
        btn_SelectVariedad.Enabled = False
        txt_Num_Nave.Clear()
        txt_Variedad.Clear()
        txt_LoteSemilla.Clear()
        txt_FechaEnvasado.Clear()
        txt_SaldoBandeja.Clear()
        txt_saldoplantas.Clear()
        txt_NumPedido.Clear()
        txt_Telefonos.Clear()
        txt_Estado.Clear()
        txtComentariosLote.Clear()
        txtAportaSemilla.Clear()
    End Sub
    Private Sub Reset_Campos()
        txt_FechaConteoPlantas.ReadOnly = True
        txt_ConteoPlantas.ReadOnly = True
        txt_FechaRetiro.ReadOnly = True
        txt_CantBandejasConteoInicial.ReadOnly = True
        txt_ubicacion.ReadOnly = True
        txtComentariosLote.ReadOnly = True
        'txt_FechaConteoSiembra.ReadOnly = True
        'txt_ConteoSiembra.ReadOnly = True
        txt_loteshijos.ReadOnly = True
        'txt_DevolucionBandejas.ReadOnly = True
        'txt_CantidadBandejasRetiro.ReadOnly = True

        txt_FechaConteoPlantas.BackColor = Color.Blue
        txt_ConteoPlantas.BackColor = Color.Blue
        txt_FechaRetiro.BackColor = Color.Blue
        txt_CantBandejasConteoInicial.BackColor = Color.Blue
        'txt_FechaConteoSiembra.BackColor = Color.Blue
        'txt_ConteoSiembra.BackColor = Color.Blue
        txt_loteshijos.BackColor = Color.Blue


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        EjecutaConsultaLote()
        cmbTipoBandeja.SelectedIndex = -1
        cmbTipoBandeja.Visible = False
    End Sub

    Public Sub EjecutaConsultaLote()
        Recupera_Lote()
        Recupera_detalle_bitacora()

    End Sub


    Private Sub Recupera_detalle_bitacora()
        Dim i As Integer = 0
        sSsql = "SP_CONSULTA_Detalle_Bitacora_Lote "
        sSsql += Val(txt_NumLote.Text).ToString
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        DataBitacora.Rows.Clear()
        If datatbl.HasRows Then

            While datatbl.Read
                DataBitacora.Rows.Add()
                DataBitacora.Rows(i).Cells(0).Value = datatbl(0)
                DataBitacora.Rows(i).Cells(1).Value = datatbl(1)
                DataBitacora.Rows(i).Cells(2).Value = datatbl(2)
                DataBitacora.Rows(i).Cells(3).Value = datatbl(3)
                DataBitacora.Rows(i).Cells(4).Value = Format(datatbl(4), "###,###,##0.00")
                DataBitacora.Rows(i).Cells(5).Value = datatbl(5)
                DataBitacora.Rows(i).Cells(6).Value = datatbl(6)
                DataBitacora.Rows(i).Cells(7).Value = datatbl(7)
                DataBitacora.Rows(i).Cells(8).Value = datatbl(8)
                DataBitacora.Rows(i).Cells(9).Value = datatbl(9)
                i += 1
            End While

        End If

        close_conexion()
    End Sub
    Private Sub Recupera_Lote()

        'Dim dTotalPedido As Double
        Dim dIVA As Double
        'Dim dSaldoPendiente As Double
        Dim dSaldoBandejas As Double
        Dim dFactorIVA As Decimal
        'Dim dIVALote As Double
        Dim dTotalLote As Double
        Dim dPrecioNeto As Double
        dFactorIVA = GIVA / 100

        Limpia_Campos()
        open()
        sSsql = "SP_CONSULTA_DETALLE_LOTE " + Str(Val(txt_NumLote.Text))
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then
            datatbl.Read()
            'Información del Pedido
            dIVA = Math.Round(datatbl("Total_Lote") * dFactorIVA, 0, MidpointRounding.AwayFromZero)
            'dTotalPedido = datatbl(6) + dIVA
            'dSaldoPendiente = dTotalPedido + datatbl(7) - datatbl(8) - datatbl(9)
            txt_Cliente.Text = datatbl("Cliente")
            txt_RUT_CLI.Text = Mid(datatbl("Rut"), 1, 11)
            txt_DIGRUT.Text = Mid(datatbl("Rut"), 12, 1)
            txt_Vendedor.Text = datatbl("Nombre")
            txt_Telefonos.Text = datatbl("Telefonos")
            txt_NumPedido.Text = datatbl("IdPedido")
            txt_FECHA_PEDIDO.Text = datatbl("Fec_emi")
            txt_FechaEntregaPedido.Text = datatbl("fec_ent1")
            txt_FormaEntrega.Text = datatbl("formaretiro")
            txtNdiasFab.Text = datatbl("Dias_Fabrica")
            If IsDBNull(datatbl("ABONO_INICIAL")) Then
                txt_TotalAbonos.Text = 0
            Else
                txt_TotalAbonos.Text = Format(datatbl("ABONO_INICIAL"), "###,###,###")
            End If
            dTotalLote = datatbl("Total_Lote")
            'Información del Lote
            txt_Estado.Text = datatbl("Estado_Lote")
            GEstado_Actual = datatbl("Estado")
            dSaldoBandejas = 0
            If GEstado_Actual >= 2 Then
                txt_germinacion.Text = Format(Math.Round(datatbl("Conteo_Final") / datatbl("Conteo_Inicial") * 100, 2, MidpointRounding.AwayFromZero), "###.##")
            End If
            If Not IsDBNull(datatbl("fec_cini")) Then
                txt_FechaConteoSiembra.Text = datatbl("fec_cini")
            End If
            'dias en vivero
            txtDiasEnVivero.Text = datatbl("DiasEnVivero")
            If Not IsDBNull(datatbl("fec_cfinal")) Then
                txt_FechaConteoPlantas.Text = datatbl("fec_cfinal")
            End If
            txt_Semilla.Text = datatbl("Semilla")
            txt_Variedad.Text = datatbl("Variedad")
            txt_CantidadPedido.Text = Format(datatbl("CantidadPlantas"), "###,###,##0")
            'variables publicas del programa
            pCantidadPedido = datatbl("CantidadPlantas")
            pPrecioUnitario = datatbl("Precio_Neto")

            dPrecioNeto = datatbl("Precio_Neto")
            txt_Precio.Text = Format(dPrecioNeto, "###,###.00")
            txtTotalPedido.Text = Format(dTotalLote, "###,###,###")
            txt_BandejasPedido.Text = Format(datatbl("Cant_Bandeja"), "#,##0")

            txt_CantidadCeldas.Text = datatbl("CantidadCeldas")
            txt_FechaInicioLote.Text = datatbl("fec_ini")
            txt_FechaRetiro.Text = datatbl("fec_ent2")
            txt_ConteoSiembra.Text = Format(datatbl("Conteo_Inicial"), "###,###,##0")
            txt_ConteoPlantas.Text = Format(datatbl("Conteo_Final"), "###,###,##0")
            txt_CantBandConteoFinal.Text = Format(datatbl("Cant_Band_Conteo"), "##,##0")
            txt_loteshijos.Text = datatbl("Nro_LotesHijos").ToString

            txt_CantBandejasConteoInicial.Text = datatbl("Cant_Band_CInicial").ToString
            txt_ubicacion.Text = datatbl("Ubicacion")
            txt_Num_Nave.Text = datatbl("Num_Nave")
            txt_LoteOriginal.Text = datatbl("Nro_Lote_Original")
            txt_guias.Text = datatbl("Nro_Guias")
            txt_Band_Usadas.Text = Format(datatbl("Cant_Band_Usadas"), "###,##0")
            txt_Band_Nuevas.Text = Format(datatbl("Cant_Band_Nuevas"), "###,##0")
            txt_LoteSemilla.Text = datatbl("Lote_Semilla")
            txt_Batch.Text = datatbl("Batch")
            txt_FechaEnvasado.Text = datatbl("Fecha_Envasado")
            txt_FechaRetiro.Text = datatbl("Fecha_Retiro")
            txt_ComentariosPedido.Text = datatbl("ComentarioPedido")
            txtComentariosLote.Text = datatbl("ComentarioLote")

            Calcula_Total_Lote(datatbl("Saldo_Plantas"), dPrecioNeto)

            txt_SaldoBandeja.Text = Format(datatbl("Saldo_Bandeja"), "###,###,##0")
            txt_saldoplantas.Text = Format(datatbl("Saldo_Plantas"), "###,###,##0")
            txtAportaSemilla.Text = datatbl("Aporta_Semilla")
            txtFechaAutorizacionCliente.Text = datatbl("FechaAutorizacionCliente")
            txtPedidoAprob.Text = datatbl("EsAprobPedido")
            txtSiembraAprob.Text = datatbl("EsAprobSiembra")
            txtConteoAprob.Text = datatbl("EsAprobConteo")
            txtAjusteAprob.Text = datatbl("EsAprobAjuste")
            txtFechaRetiroCliente.Text = datatbl("FechaRetiroCliente")
            txtRetiro.Text = datatbl("Retiro")
            txtComentarioRetiro.Text = datatbl("ComentarioRetiro")
            txtEsPreventa.Text = datatbl("Preventa")
            If GEstado_Actual <= 2 And gIdPerfil = 1 Then
                TSM_Modificar.Enabled = True
                TSM_Actualizadatos.Enabled = True
            Else
                TSM_Actualizadatos.Enabled = False
                TSM_Modificar.Enabled = False
            End If

            If GEstado_Actual < 4 And gIdPerfil = 1 Then
                TSM_ModificaPrecioLote.Enabled = True
            Else
                TSM_ModificaPrecioLote.Enabled = False
            End If

            If GEstado_Actual = 0 And gIdPerfil = 1 Then
                TSM_ModificaFechaSiembra.Enabled = True
            Else
                TSM_ModificaFechaSiembra.Enabled = False
            End If

            If GEstado_Actual < 8 And gIdPerfil = 1 Then
                TSM_ModificaEstadoLote.Enabled = True
                TSM_ModificaSaldoPlantas.Enabled = True
                TSM_ModificaSaldoBandejas.Enabled = True
            Else
                TSM_ModificaEstadoLote.Enabled = False
                TSM_ModificaSaldoPlantas.Enabled = False
                TSM_ModificaSaldoBandejas.Enabled = False
            End If
            txtPreventa1.Text = datatbl("MotivoEnablePreventa")
            txtPreventa2.Text = datatbl("MotivoDisablePreventa")

        Else
            MsgBox("NO EXISTE N° DE LOTE", MsgBoxStyle.Exclamation)
        End If
        datatbl.Close()
        close_conexion()
    End Sub
    Private Sub Calcula_Total_Lote(ByVal dSaldoPlantas As Double, ByVal dPrecio As Double)
        Dim dIvaLote As Double
        Dim dValorTotalNeto As Double
        Dim dValorTotalLote As Double

        dValorTotalNeto = Math.Round(dSaldoPlantas * dPrecio, 0, MidpointRounding.AwayFromZero)
        txtTotalNeto.Text = Format(dValorTotalNeto, "###,###,##0")
        dIvaLote = Math.Round(dValorTotalNeto * GIVA / 100, 0, MidpointRounding.AwayFromZero)
        txtIVA.Text = Format(dIvaLote, "###,###,##0")
        dValorTotalLote = dValorTotalNeto + dIvaLote
        txtTotalLote.Text = Format(dValorTotalLote, "###,###,##0")
    End Sub
    Private Sub GuardarCambiosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Guardar_Cambios()
    End Sub
    Private Sub Guardar_Cambios()
        Dim bOK As Boolean
        Dim sMSG As String

        sMSG = ""
        bOK = True

        Select Case GESTADO
            Case 1
                If txt_FechaConteoSiembra.Text = "" Or txt_ConteoSiembra.Text = "" Then
                    sMSG = "DEBE COMPLETAR DATOS PARA CONTEO DE SIEMBRA"
                    bOK = False
                End If
            Case 2
                If txt_FechaConteoPlantas.Text = "  /  /" Or txt_ConteoPlantas.Text = "" Or txt_FechaRetiro.Text = "  /  /" Then
                    sMSG = "DEBE COMPLETAR DATOS PARA CONTEO DE PLANTAS"
                    bOK = False
                End If
            Case 3
                'Case 4
                'if txt_FechaRetiro.Text = "  /  /" Or txt_CantidadBandejasRetiro.Text = "" Then
                'sMSG = "DEBE COMPLETAR DATOS PARA RETIRO DE PLANTAS"
                'bOK = False
                'End If
                'Case 99
                'If txt_FechaDevolucion.Text = "  /  /" Or txt_DevolucionBandejas.Text = "" Then
                'sMSG = "DEBE COMPLETAR DATOS PARA DEVOLUCION DE BANDEJAS"
                'bOK = False
                'End If
            Case Else
                sMSG = "DEBE SELECCIONAR TIPO DE PROCESO A GUARDAR"
                bOK = False
        End Select

        If Not bOK Then
            MsgBox(sMSG)
            Reset_Campos()
            Exit Sub
        End If
        bOK = False
        If (GEstado_Actual = GESTADO Or GEstado_Actual + 1 = GESTADO) Or
            (GESTADO = 99 And GEstado_Actual = 4) Then
            bOK = True
            'GUARDAR CAMBIOS
            '@NumLote int,
            '@ESTADO int,
            '@FechaConteoSiembra datetime,
            '@ConteoSiembra int,
            '@FechaConteoPlantas datetime,
            '@ConteoPlantas int,
            '@FechaEntregaLote datetime,
            '@FechaAvisoCliente datetime,
            '@AvisoCliente varchar(100),
            '@FechaRetiro datetime,
            '@CantidadBandejasRetiro int,
            '@FechaDevolucion datetime,
            '@DevolucionBandejas int
            sSsql = "SP_ACTUALIZA_DETALLE_PEDIDO " + Str(Val(txt_NumLote.Text)) + "," + Str(GESTADO) + ",'"
            sSsql += txt_FechaConteoSiembra.Text + "'," + Replace(Str(Val(txt_ConteoSiembra.Text)), ".", "") + ",'"
            If IsDate(txt_FechaConteoPlantas.Text) Then
                sSsql += txt_FechaConteoPlantas.Text + "',"
            Else
                sSsql += CDate(Now.Date) + "',"
            End If
            sSsql += Replace(Str(Val(txt_ConteoPlantas.Text)), ".", "") + ",'"
            If IsDate(txt_FechaRetiro.Text) Then
                sSsql += CDate(txt_FechaRetiro.Text) + "','"
            Else
                sSsql += CDate(Now.Date) + "','"
            End If
            sSsql += txt_loteshijos.Text + "',"
            sSsql += txt_CantBandejasConteoInicial.Text + ","
            'sSsql += txt_CeldasVacias.Text + ","
            sSsql += txt_ubicacion.Text
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            command.ExecuteNonQuery()
            close_conexion()
            Limpia_Campos()
            Reset_Campos()
        Else
            sMSG = "DEBE RESPETAR EL ORDEN CORRELATIVO DE LOS PASOS DEL PROCESO TAL COMO SE INDICA A CONTINUACION:"
            sMSG += Chr(10) + "PASO 0: INGRESO DE PEDIDO" + Chr(10) + "PASO 1: CONTEO DE SIEMBRA"
            sMSG += Chr(10) + "PASO 2: CONTEO DE PLANTAS" + Chr(10) + "PASO 3: AVISO DE ENTREGA AL CLIENTE"
            'sMSG += Chr(10) + "PASO 4: RETIRO DE PLANTAS Y PAGO"

            MsgBox(sMSG)
            Reset_Campos()
        End If

    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSM_Modificar.Click
        REM modifica algunos campos del lote solo para estado <= 2
        REM Permite modificar Variedad, Precio Unitario, Lote semilla, Batch, Fecha envasado, Nº Nave y Ubicación Lote

        If txt_NumLote.Text <> Nothing Then
            If GEstado_Actual <= 2 Then
                REM permite los cambios de btón Variedad, LoteSemilla,fecha envasado,N° nave y ubicacion
                ' Siempre que Estado = CONTEO DE PLANTAS
                btn_SelectVariedad.Enabled = True
                'txt_Precio.ReadOnly = False
                txt_LoteSemilla.ReadOnly = False
                txt_FechaEnvasado.ReadOnly = False
                txt_Num_Nave.ReadOnly = False
                txt_ubicacion.ReadOnly = False
                cmbTipoBandeja.Visible = True
                cmbTipoBandeja.SelectedIndex = -1
                txtComentariosLote.ReadOnly = False
            Else
                MsgBox("Estado del Lote no Permite Realizar Cambios. No se permite Modificar lotes con entrega de plantas. Los estados Permitidos son: Lotes Creados, Conteo de Siembra y Conteo de Plantas.")
            End If
        Else
            MsgBox("Debe Ingresar Nº de Lote a Modificar.")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelectVariedad.Click
        gQuienLlama = 1
        SeleccionVariedad.Show()
    End Sub

    Private Sub ActualizaDatoslote()
        sSsql = "SP_ACTUALIZAEDatosLote "
        sSsql += txt_NumLote.Text + ","
        sSsql += "'" + txt_Semilla.Text + "',"
        sSsql += "'" + txt_Variedad.Text + "',"

        sSsql += "NULL,"

        sSsql += Val(txt_Num_Nave.Text).ToString + ","
        sSsql += "'" + txt_LoteSemilla.Text + "',"
        sSsql += "'" + txt_Batch.Text + "',"
        sSsql += "'" + txt_FechaEnvasado.Text + "',"
        sSsql += "'" + txt_ubicacion.Text + "',"
        sSsql += "'" + txtComentariosLote.Text + "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()
        close_conexion()

        ' Actualiza Tipo de Bandeja si hizo un cambio
        If cmbTipoBandeja.SelectedIndex > -1 Then
            sSsql = "Update Pedido_Detalle set IdTipoBandeja=" + cmbTipoBandeja.SelectedValue.ToString() + " Where IdPedidodet=" + txt_NumLote.Text
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            command.ExecuteNonQuery()
            close_conexion()
            cmbTipoBandeja.SelectedIndex = -1
        End If
        cmbTipoBandeja.Visible = False
        MsgBox("Los Datos han sido actualizados.")
        Reset_Campos()
        Limpia_Campos()
        EjecutaConsultaLote()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Val(txt_Precio.Text) <= 0 Then
            MsgBox("Precio Unitario incorrecto. vuelva a definir Precio.")
        Else
            ActualizaDatoslote()
        End If

    End Sub



    Private Sub ToolStripMenuItem1_Click_1(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim iFilaActual As Integer
        iFilaActual = DataBitacora.CurrentRow.Index
        If DataBitacora.Rows(iFilaActual).Cells(9).Value = 11 Or DataBitacora.Rows(iFilaActual).Cells(9).Value = 17 Then
            MsgBox("No es posible Eliminar Conteos del Lote.", MsgBoxStyle.Critical, "Consulta Lote")
            Exit Sub
        End If
        Dim iResp = MsgBox("Confirme Eliminación de Bitácora: " & DataBitacora.Rows(iFilaActual).Cells(3).Value, MsgBoxStyle.YesNo, "Elimina Bitácora")
        If iResp = MsgBoxResult.Yes Then
            sSsql = "SP_ELIMINA_BITACORA "
            sSsql += DataBitacora.Rows(iFilaActual).Cells(8).Value.ToString
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            command.ExecuteNonQuery()
            close_conexion()
            MsgBox("Datos han sido Eliminados", MsgBoxStyle.Information, "Consulta Lote")
            Recupera_detalle_bitacora()
        End If
    End Sub

    Private Sub Cambio_Estado_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet.TBL_TIPO_BANDEJA' Puede moverla o quitarla según sea necesario.
        Me.TBL_TIPO_BANDEJATableAdapter.Fill(Me.GESTDataSet.TBL_TIPO_BANDEJA)
        If gQuienLlama = 2 Then
            EjecutaConsultaLote()
        End If
    End Sub

    Private Sub txt_Precio_LostFocus(sender As Object, e As EventArgs) Handles txt_Precio.LostFocus
        Dim Precio As Decimal
        Dim TotalPedido As Double
        If (Val(txt_Precio.Text) > 0) Then
            Precio = CDec(txt_Precio.Text)

            TotalPedido = Math.Round(Precio * pCantidadPedido, 0, MidpointRounding.AwayFromZero)

            pPrecioUnitario = Precio

            txtTotalPedido.Text = Format(TotalPedido, "###,###,###")

        End If

    End Sub

    Private Sub ToolStripMenuItem2_Click_1(sender As Object, e As EventArgs) Handles TSM_ModificaPrecioLote.Click
        If GEstado_Actual < 4 Then
            ActualizaPrecioLote.txtPrecioActualNeto.Text = txt_Precio.Text
            ActualizaPrecioLote.txtLote.Text = txt_NumLote.Text
            ActualizaPrecioLote.Show()
        Else
            MsgBox("Estado del Lote no permite Modificar Precio Unitario!", MsgBoxStyle.Critical, "Actuasliza Precio de Venta")
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click_2(sender As Object, e As EventArgs) Handles TSM_ModificaFechaSiembra.Click

        If GEstado_Actual = 0 Then 'solo para Lotes en Estado PEDIDO, se permite modificar fecha de siembra
            ModificaFechaEntrega.txtLote.Text = txt_NumLote.Text
            ModificaFechaEntrega.txtFechaSiembraActual.Text = txt_FechaInicioLote.Text
            ModificaFechaEntrega.txtFechaEntregaActual.Text = txt_FechaEntregaPedido.Text
            ModificaFechaEntrega.txtdiasfab.Text = txtNdiasFab.Text
            ModificaFechaEntrega.dtpNuevaFechaSiembra.Value = txt_FechaInicioLote.Text
            ModificaFechaEntrega.Show()
        Else
            MsgBox("Solo se permite modificar Fecha de Siembra para Lotes en Estado=PEDIDO!", MsgBoxStyle.Exclamation, "Modifica Fecha de Siembra")
        End If
    End Sub



    Private Sub ActualizaDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TSM_Actualizadatos.Click

        ActualizaDatoslote()

    End Sub

    Private Sub TSM_ModificaEstadoLote_Click(sender As Object, e As EventArgs) Handles TSM_ModificaEstadoLote.Click
        If GEstado_Actual < 8 Then
            ModificaEstadoLote.txtLote.Text = txt_NumLote.Text
            ModificaEstadoLote.txtEstadoActual.Text = txt_Estado.Text
            ModificaEstadoLote.Show()
        End If
    End Sub

    Private Sub TSM_ModificaSaldoPlantas_Click(sender As Object, e As EventArgs) Handles TSM_ModificaSaldoPlantas.Click
        If GEstado_Actual < 8 Then
            ModificaSaldoPlantas.txtLote.Text = txt_NumLote.Text
            ModificaSaldoPlantas.txtSaldoActualPlantas.Text = txt_saldoplantas.Text
            ModificaSaldoPlantas.Show()
        End If

    End Sub

    Private Sub TSM_ModificaSaldoBandejas_Click(sender As Object, e As EventArgs) Handles TSM_ModificaSaldoBandejas.Click
        If GEstado_Actual < 8 Then
            ModificaSaldoBandeja.txtLote.Text = txt_NumLote.Text
            ModificaSaldoBandeja.txtSaldoActualBandejas.Text = txt_SaldoBandeja.Text
            ModificaSaldoBandeja.Show()
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        PreventaHistoria.txtMotivoEnablePreventa.Text = txtPreventa1.Text
        PreventaHistoria.txtMotivoDisablePreventa.Text = txtPreventa2.Text
        PreventaHistoria.Show()
    End Sub
End Class