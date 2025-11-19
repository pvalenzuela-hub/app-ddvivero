
Imports System.Data.SqlClient

Public Class CreaLoteHijo
    Dim stitle As String = "Crea Lote Hijo"
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If Val(txt_NumLote.Text) > 0 Then
            If Not Rescata_Datos_Lote(Val(txt_NumLote.Text)) Then
                'Lote no puede ser recuperado por falta de plantas.

                LimpiaCampos()
            Else
                btnModificaCliente.Enabled = True
                btnsave.Enabled = True
            End If
        Else
            MsgBox("Debe Ingresar N° lote a Recuperar", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub LimpiaCampos()
        txtDirEntrega.Clear()
        txtFamiliaLoteRecuperado.Clear()
        txtIdFormaEntrega.Clear()
        txtIdVendedor.Clear()
        txtTipoBandejaRecuperado.Clear()
        txtVariedadLoteRecuperado.Clear()
        txt_AporteSemillaLoteantiguo.Clear()
        txt_CantBandNuevo.Clear()
        txt_CantBandOriginal.Clear()
        txt_CantPlantasNuevoLote.Clear()
        txt_IDCliente.Clear()
        txt_NombreCliente.Clear()
        txt_NuevoPrecioLote.Clear()
        txt_NumLote.Clear()
        txt_PrecioOriginal.Clear()
        txt_PrecioVentaSemilla.Clear()
        txt_SaldoPlantas.Clear()
        txt_ValorTotalNuevoLote.Clear()

    End Sub
    Private Function Rescata_Datos_Lote(NumLote As Integer) As Boolean
        Dim bOK As Boolean
        Dim iCantidadBandOriginal As Decimal
        Dim iConteoPlantasOriginal As Integer
        Dim iSaldoBandeja As Integer
        Dim Idsemilla As Integer
        Dim IdVariedad As Integer
        Dim sMensajeError As String = ""
        bOK = True
        open()
        sSsql = "SP_CONSULTA_DETALLE_LOTE " & NumLote.ToString
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        Idsemilla = 0
        If datatbl.HasRows Then
            datatbl.Read()
            Idsemilla = datatbl(44)
            IdVariedad = datatbl(45)
            txt_PrecioOriginal.Text = datatbl("PrecioIVA")
            txt_AporteSemillaLoteantiguo.Text = IIf(IsDBNull(datatbl(42)), "", datatbl(42))
            txt_SaldoPlantas.Text = datatbl(31)
            txtFamiliaLoteRecuperado.Text = datatbl(28)
            txtVariedadLoteRecuperado.Text = datatbl(29)
            txtTipoBandejaRecuperado.Text = datatbl(25)
            txt_NombreCliente.Text = datatbl("Cliente")
            txt_IDCliente.Text = datatbl("IDcliente")
            txtIdVendedor.Text = datatbl("IdVendedor")
            txtIdFormaEntrega.Text = datatbl("IdFormaEntrega")
            txtDirEntrega.Text = datatbl("DIR_ENTREGA")
            REM Revisa si Lote no tiene Conteo de Siembra
            If IsDBNull(datatbl(38)) Then
                iCantidadBandOriginal = 0
                iConteoPlantasOriginal = 0
                txt_CantBandOriginal.Text = 0
                sMensajeError += "Lote debe tener al menos Conteo de Siembra" & vbCrLf
                bOK = False
            End If
            REM Recuperar Saldo de Plantas
            If IsDBNull(datatbl(31)) Then
                sMensajeError += "Lote no Tiene Saldo de Plantas" & vbCrLf
                bOK = False
            Else
                If datatbl(31) <= 0 Then
                    sMensajeError += "Lote no Tiene Saldo de Plantas" & vbCrLf
                    bOK = False
                Else
                    iConteoPlantasOriginal = datatbl(31)
                End If
            End If
            REM Recuperar Saldo de Bandejas
            If IsDBNull(datatbl(76)) Then
                txt_CantBandOriginal.Text = 0
                iSaldoBandeja = 0
            Else
                REM Si Lote Tiene Saldo de Bandejas, entonces, Recupera Valor Saldo de Bandejas
                iSaldoBandeja = datatbl(76)
                iCantidadBandOriginal = iSaldoBandeja
            End If
            txt_CantBandOriginal.Text = iSaldoBandeja
            REM Pregunta si Lote no tiene Saldo de Bandejas y envia mensaje.
            If iSaldoBandeja <= 0 Then
                sMensajeError += "Lote no Tiene Saldo de Bandejas" & vbCrLf
                bOK = False
                txt_CantBandOriginal.Text = 0
            End If
            REM calculo promedio de plantas
            If bOK Then
                REM Calcula el nuevo promedio de Plantas por Bandejas, para Calcular posteriormente la Cantidad de Plantas a entregar al nuevo Lote
                REM El calculo divide la variable del conteo de plantas original y lo divide por la Cantidad de Bandejas Original
                If IsDBNull(datatbl("PromedioPlantas")) Then
                    gPromedioPlantas = 0
                Else
                    gPromedioPlantas = datatbl("PromedioPlantas")
                End If
            End If
        Else
            sMensajeError = "NO EXISTE N° DE LOTE"
            bOK = False
        End If
        close_conexion()
        If Idsemilla > 0 Then
            Lectura_Costo_Semilla(Idsemilla, IdVariedad)
        End If

        If Not bOK Then
            MsgBox(sMensajeError, MsgBoxStyle.Critical, stitle)
        End If
        Return bOK
    End Function

    Private Sub Lectura_Costo_Semilla(ByVal idFamilia As Integer, ByVal idVariedad As Integer)
        sSsql = "[dbo].[SP_CostosSemillaVariedad] " & idFamilia.ToString & "," & idVariedad.ToString
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            txt_PrecioVentaSemilla.Text = Format(datatbl(2), "###,##0.00")
        Else
            MsgBox("SEMILLA NO TIENE PRECIO DE VENTA DEFINIDO.")
            txt_PrecioVentaSemilla.Text = 0
        End If
        close_conexion()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        '' Botón Crea Nuevo Lote
        Dim sResp As String = ""
        Dim iNuevoPedido As Integer
        Dim bControlSave As Boolean = True

        If Val(txt_CantBandOriginal.Text) = 0 Then
            MsgBox("LOTE NO TIENE SALDO DE BANDEJAS", MsgBoxStyle.Critical)
            bControlSave = False
        End If

        If Val(txt_NumLote.Text) = 0 Then
            MsgBox("N° DE LOTE NO VALIDO", MsgBoxStyle.Critical)
            bControlSave = False
        End If
        If Val(txt_CantBandNuevo.Text) = 0 Then
            MsgBox("CANTIDAD DE BANDEJAS NO VALIDO", MsgBoxStyle.Critical)
            bControlSave = False
        End If

        If Val(txt_CantPlantasNuevoLote.Text) > Val(txt_SaldoPlantas.Text) Then
            MsgBox("CANTIDAD DE PLANTAS NO PUEDE EXCEDER SALDO DE PLANTAS LOTE ORIGINAL")
            bControlSave = False
        End If
        sResp = MsgBox("Confirme Creación Pedido Hijo.", MsgBoxStyle.YesNo, stitle)
        If sResp = MsgBoxResult.Yes AndAlso bControlSave Then
            If Val(Pedidos.txtIdPedido.Text) > 0 Then
                iNuevoPedido = Val(Pedidos.txtIdPedido.Text)
            Else
                iNuevoPedido = Graba_PedidoHijo()
            End If
            If iNuevoPedido > 0 Then
                '' Crear Nuevo Lote a partir de uno existente, utilizando nueva cantidad de plantas
                Try
                    sSsql = "SP_CREA_NUEVO_LOTE_EXISTENTE "
                    sSsql += Str(iNuevoPedido) & ","
                    sSsql += Str(Val(txt_NumLote.Text)) & ","
                    sSsql += Str(Val(txt_NuevoPrecioLote.Text)) & ","
                    sSsql += Str(Val(txt_CantPlantasNuevoLote.Text)) & ","
                    sSsql += Str(gPromedioPlantas) & ","
                    sSsql += Str(Val(txt_CantBandNuevo.Text)) & ","
                    If chkRequiereGestion.Checked Then
                        sSsql += "1"
                    Else
                        sSsql += "0"
                    End If
                    open()
                    command = connection.CreateCommand()
                    command.CommandText = sSsql
                    command.ExecuteNonQuery()

                Catch ex As SqlException
                    ' Captura los THROW del SP
                    Select Case ex.Number
                        Case 50001
                            MessageBox.Show("❌ El lote padre no existe.", "Error")
                        Case 50002
                            MessageBox.Show("⚠️ No hay saldo suficiente de bandejas en el lote padre.", "Aviso")
                        Case 50003
                            MessageBox.Show("⚠️ No hay saldo suficiente de plantas en el lote padre.", "Aviso")
                        Case Else
                            MessageBox.Show("Error inesperado en SQL: " & ex.Message, "Error crítico")
                    End Select
                Catch ex As Exception
                    ' Otros errores .NET (por ejemplo conexión)
                    MessageBox.Show("Error general: " & ex.Message, "Error .NET")
                Finally
                    close_conexion()
                    MsgBox("SE HA CREADO PEDIDO N° " & Str(iNuevoPedido))
                    Me.Close()
                End Try

            End If
        End If
    End Sub
    Private Function Graba_PedidoHijo() As Integer
        Dim iFormaEntrega As Integer
        Dim iIdVendedor As Integer
        Dim IdPEDIDO As Integer
        Dim FechaPedido As Date = Date.Now
        Dim Comentario As String = ""
        Dim dTotalPedidoNeto As Integer
        Dim dTotalPedido As Integer
        IdPEDIDO = 0
        iIdVendedor = txtIdVendedor.Text
        iFormaEntrega = txtIdFormaEntrega.Text
        dTotalPedidoNeto = Val(txt_NuevoPrecioLote.Text) * Val(txt_CantPlantasNuevoLote.Text)
        dTotalPedido = Math.Round(dTotalPedidoNeto * gFactorIVA, 0, MidpointRounding.AwayFromZero)
        sSsql = "SP_GRABA_PEDIDO_HEADER " & Str(Val(txt_IDCliente.Text)) & "," & Str(iFormaEntrega) & "," & Str(iIdVendedor) & ","
        sSsql += "'" & FechaPedido & "',"
        sSsql += "'" & txtDirEntrega.Text & "','" & Comentario & "',"
        sSsql += Str(dTotalPedidoNeto) & "," & Str(dTotalPedido) & "," & Str(IdPEDIDO) & ","
        sSsql += "'" & gUSER & "',1"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            IdPEDIDO = datatbl(0)
            datatbl.Close()
        Else
            IdPEDIDO = 0
        End If
        close_conexion()
        Return IdPEDIDO
    End Function

    Private Sub btnModificaCliente_Click(sender As Object, e As EventArgs) Handles btnModificaCliente.Click
        gQuienLlama = 17
        BusquedaCliente.Show()
    End Sub
    Private Sub txt_CantBandNuevo_Leave(sender As Object, e As EventArgs) Handles txt_CantBandNuevo.Leave
        Calcula_Plantas_Total_Lote()
    End Sub

    Private Sub txt_CantBandNuevo_LostFocus(sender As Object, e As EventArgs) Handles txt_CantBandNuevo.LostFocus
        Calcula_Plantas_Total_Lote()
    End Sub
    Private Sub Calcula_Plantas_Total_Lote()
        Dim iCantidadPlantasnuevo As Integer
        Dim bControl As Boolean = True
        If Val(txt_CantBandNuevo.Text) > Val(txt_CantBandOriginal.Text) Then
            MsgBox("CANTIDAD DE BANDEJAS NO PUEDE SER MAYOR AL LOTE ORIGINAL")
            txt_CantBandNuevo.Focus()
            bControl = False
        End If
        If Val(txt_CantBandNuevo.Text) <= 0 Then
            MsgBox("CANTIDAD DE BANDEJAS DEBE SER MAYOR A CERO")
            txt_CantBandNuevo.Focus()
            bControl = False
        End If
        If bControl Then
            iCantidadPlantasnuevo = Math.Round(Val(txt_CantBandNuevo.Text) * gPromedioPlantas, 0, MidpointRounding.AwayFromZero)
            txt_CantPlantasNuevoLote.Text = iCantidadPlantasnuevo
            REM Calculo del Total en $ del nuevo Lote: El Nuevo Precio Ingresado Multiplicado por la Cantidad de Plantas del Nuevo Lote
            txt_ValorTotalNuevoLote.Text = Format(Math.Round(Val(txt_NuevoPrecioLote.Text) * Val(txt_CantPlantasNuevoLote.Text), 0, MidpointRounding.AwayFromZero), "###,###,###")
        End If
    End Sub
    Private Sub txt_NuevoPrecioLote_Leave(sender As Object, e As EventArgs) Handles txt_NuevoPrecioLote.Leave
        If Val(txt_NuevoPrecioLote.Text) > 0 AndAlso Val(txt_CantPlantasNuevoLote.Text) > 0 Then
            txt_ValorTotalNuevoLote.Text = Format(Math.Round(txt_NuevoPrecioLote.Text * txt_CantPlantasNuevoLote.Text, 0, MidpointRounding.AwayFromZero), "###,###,###")
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class