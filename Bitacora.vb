Imports System.Data.SqlClient

Public Class Bitacora
    Dim gCantidadMaximaBandejas As Integer = 0
    Private Sub Bitacora_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Carga_lista_Vendedor(Me.cmb_IDVENDEDOR)
        Carga_lista_Vendedor(Me.cmb_UsuarioAsignado)
        Carga_Evento(Me.cmb_Evento, "B")
        Carga_Tipo_Unidad(Me.cmb_Unidad)
        Carga_Combo_Insumos(Me.cmb_Insumo)
        dtp_FechaIngreso.Value = Now

        Me.cmb_IDVENDEDOR.Text = gNomUsuario
        Me.cmb_IDVENDEDOR.Enabled = False
        'txt_fechaRegistro.Text = Now.Date
    End Sub

    Private Sub Graba_Evento()
        Dim IdBitacora As Integer
        Dim sTipo_Evento As String
        Dim IdInsumo As Integer
        Dim IdAsignadoA As Integer
        Dim sConteoInicial As String
        Dim sIngresoCamara As String
        Dim IdTipoUnidad As Integer
        Dim sIdentificacionNave As String
        Dim grabarOK As Boolean = False
        IdBitacora = 0
        If Valida_Registro_Evento() Then
            If rb_Registro.Checked Then
                sTipo_Evento = "R"
            Else
                sTipo_Evento = "M"
            End If

            If cmb_Insumo.SelectedIndex <> -1 Then
                IdInsumo = TI_ID(Me.cmb_Insumo.SelectedIndex)
            Else
                IdInsumo = 0
            End If

            If cmb_UsuarioAsignado.SelectedIndex <> -1 Then
                IdAsignadoA = ID_Vendedor(Me.cmb_UsuarioAsignado.SelectedIndex)
            Else
                IdAsignadoA = ID_Vendedor(Me.cmb_IDVENDEDOR.SelectedIndex)
            End If

            If TE_ConteoPlantas(Me.cmb_Evento.SelectedIndex) = "S" Then
                If rb_ConteoSiembra.Checked Then
                    sConteoInicial = "S"
                Else
                    sConteoInicial = "N"
                End If
                If rb_conteoPlantas.Checked Then
                    If Val(txt_CantBandejas.Text) <> Val(txt_BandConteo1.Text) + Val(txt_BandConteo2.Text) Then
                        MsgBox("Debe relizar Conteo de Plantas por la totalidad de las Bandejas del Lote.", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If
                End If
            Else
                sConteoInicial = "N"
            End If

            If TE_Camara(Me.cmb_Evento.SelectedIndex) = "S" Then
                If rb_IngresoCamara.Checked Then
                    sIngresoCamara = "S"
                Else
                    sIngresoCamara = "N"
                End If
            Else
                sIngresoCamara = "N"
            End If

            If Me.cmb_Unidad.SelectedIndex = -1 Then
                IdTipoUnidad = 0
            Else
                IdTipoUnidad = TU_ID(Me.cmb_Unidad.SelectedIndex)
            End If

            sIdentificacionNave = TE_IdentNave(Me.cmb_Evento.SelectedIndex)

            If rb_Mandatorio.Checked Then
                dtp_FechaEvento.Value = dtp_FechaMandatoria.Value
            End If

            If TE_Lote(Me.cmb_Evento.SelectedIndex) = "S" Then
                If rb_conteoPlantas.Checked And cmb_Evento.Text = "CONTEO DE PLANTAS" Then
                    If Val(txt_CantBandejas.Text) = Val(txt_Cantidad.Text) Then
                        MsgBox("Cantidad de Plantas NO PUEDE SER IGUAL A CANTIDAD DE BANDEJAS. Revise los datos del Conteo de Plantas.", MsgBoxStyle.Critical, "CONTEO DE PLANTAS")
                        Exit Sub
                    End If

                    If Math.Abs(Val(txt_SaldoPlantas.Text) - Val(txt_Cantidad.Text)) / Val(txt_SaldoPlantas.Text) * 100 > 45 Then
                        Dim stitle As String = "Conteo de Plantas"
                        MsgBox("Existe una diferencia mayor al 45% del saldo actual de plantas. Debe existir un error en los datos, revise los datos del conteo antes de continuar.", MsgBoxStyle.Critical, stitle)

                        Dim sResp = MsgBox("¿Desea continuar registrando el conteo?", MsgBoxStyle.YesNo, stitle)
                        If sResp = MsgBoxResult.No Then
                            Exit Sub
                        End If
                    End If

                    '@IdPedidodet numeric(18,0), -- N° de Lote
                    '@Evento varchar(50),
                    '@Fecha datetime, -- Fecha Evento
                    '@Hora varchar(5), -- Hora Evento
                    '@Vendedor varchar(50),
                    '@Cantidad float,
                    '@Unidad varchar(20),
                    '@Fecha_Registro datetime,
                    '@BandConteo1 int,
                    '@BandIng1 int,
                    '@PromVaciasxBand1 real,
                    '@TotalCeldasVacias1 int,
                    '@PlsegunPromConteo1 int,
                    '@TotalPlConteo1 int,
                    '@Germ1 real,
                    '@BandConteo2 int,
                    '@BandIng2 int,
                    '@PromVaciasxBand2 real,
                    '@TotalCeldasVacias2 int,
                    '@PlsegunPromConteo2 int,
                    '@TotalPlConteo2 int,
                    '@Germ2 real,
                    '@Germ_Final real
                    REM CONTEO DE PLANTAS
                    sSsql = "[dbo].[SP_Actualiza_Conteo_Plantas] "
                    sSsql += Val(txt_Lote.Text).ToString & ","
                    sSsql += "'" & cmb_Evento.Text & "',"
                    sSsql += "'" & Format(dtp_FechaEvento.Value, "d") & "',"
                    sSsql += "'" & Format(dtp_HoraEvento.Value, "T") & "',"
                    sSsql += "'" & cmb_IDVENDEDOR.Text & "',"
                    sSsql += Val(txt_Cantidad.Text).ToString & ","
                    sSsql += "'" & cmb_Unidad.Text & "',"
                    sSsql += "'" & Format(dtp_FechaIngreso.Value, "d") & "',"
                    sSsql += Val(txt_BandConteo1.Text).ToString & ","
                    sSsql += Val(txt_BandIng1.Text).ToString & ","
                    sSsql += Val(txt_PromVaciasxBand1.Text).ToString & ","
                    sSsql += Val(txt_TotalCeldasVacias1.Text).ToString & ","
                    sSsql += Val(txt_PlsegunPromConteo1.Text).ToString & ","
                    sSsql += Val(txt_TotalPlConteo1.Text).ToString & ","
                    sSsql += Val(txt_Germ1.Text).ToString & ","
                    sSsql += Val(txt_BandConteo2.Text).ToString & ","
                    sSsql += Val(txt_BandIng2.Text).ToString & ","
                    sSsql += Val(txt_PromVaciasxBand2.Text).ToString & ","
                    sSsql += Val(txt_TotalCeldasVacias2.Text).ToString & ","
                    sSsql += Val(txt_PlsegunPromConteo2.Text).ToString & ","
                    sSsql += Val(txt_TotalPlConteo2.Text).ToString & ","
                    sSsql += Val(txt_Germ2.Text).ToString & ","
                    sSsql += "'" & txt_ubicacion.Text & "',"
                    If txt_Num_Nave_lote.Text <> Nothing Then
                        sSsql += "'" & txt_Num_Nave_lote.Text & "'"
                    Else
                        sSsql += "Null"
                    End If
                    Try
                        open()
                        command = connection.CreateCommand()
                        command.CommandText = sSsql
                        command.ExecuteNonQuery()
                        grabarOK = True
                    Catch ex As Exception
                        ' Otros errores .NET (por ejemplo conexión)
                        MessageBox.Show("Error general: " & ex.Message, "Error .NET")
                    Finally
                        close_conexion()
                        If grabarOK Then
                            MsgBox("LOTE N°:" & txt_Lote.Text & " HA SIDO ACTUALIZADO")
                            Limpia_Campos()
                        End If
                    End Try
                Else
                    REM OTROS EVENTOS ASOCIADOS AL LOTE Y CONTEO DE SIEMBRA
                    Try
                        open()
                        sSsql = "SP_GRABA_BITACORA "
                        sSsql += Str(IdBitacora) & ","
                        sSsql += "'" + sTipo_Evento & "',"
                        sSsql += txt_Lote.Text & ","
                        sSsql += Str(TE_ID(Me.cmb_Evento.SelectedIndex)) & ","
                        sSsql += Str(IdInsumo) & ","
                        sSsql += "'" + Format(dtp_FechaEvento.Value, "d") & "',"
                        sSsql += "'" + Format(dtp_HoraEvento.Value, "T") & "',"
                        sSsql += Str(ID_Vendedor(Me.cmb_IDVENDEDOR.SelectedIndex)) & ","
                        sSsql += Str(IdAsignadoA) & ","
                        sSsql += Str(Val(txt_Cantidad.Text)) & ","
                        sSsql += Str(IdTipoUnidad) & ","
                        sSsql += "'" + Format(dtp_FechaIngreso.Value, "d") + "',"
                        sSsql += "'" + Format(dtp_FechaMandatoria.Value, "d") + "',"
                        sSsql += "'" + txt_comentarios.Text + "',"
                        sSsql += "'" + TE_ConteoPlantas(Me.cmb_Evento.SelectedIndex) + "',"
                        sSsql += "'" + sConteoInicial + "',"
                        sSsql += Str(Val(Reemplaza_Comas(txt_Cantidad.Text))) + ","
                        sSsql += Str(Val(txt_celdasvacias.Text)) + ","
                        sSsql += "'" + TE_Camara(Me.cmb_Evento.SelectedIndex) + "',"
                        sSsql += "'" + sIngresoCamara + "',"
                        sSsql += "'" + sIdentificacionNave + "',"
                        sSsql += "'" + txt_ubicacion.Text + "',"
                        sSsql += "'',"
                        sSsql += "'" + txt_Num_Nave_lote.Text + "',"
                        REM CAMPOS AGREGADOS PARA COMPLETAR INFORMACION CONTEO DE SIEMBRA
                        sSsql += Val(txt_Band_Nuevas.Text).ToString + ","
                        sSsql += Val(txt_Band_Usadas.Text).ToString + ","
                        If txt_LoteSemilla.Text <> Nothing Then
                            sSsql += "'" + txt_LoteSemilla.Text + "',"
                        Else
                            sSsql += "'',"
                        End If

                        If txt_Batch.Text <> Nothing Then
                            sSsql += "'" + txt_Batch.Text + "',"
                        Else
                            sSsql += "'',"
                        End If

                        If txt_FechaEnvasado.Text <> Nothing Then
                            sSsql += "'" + txt_FechaEnvasado.Text + "'"
                        Else
                            sSsql += "''"
                        End If
                        command = connection.CreateCommand()
                        command.CommandText = sSsql
                        command.ExecuteNonQuery()
                        grabarOK = True
                    Catch ex As Exception
                        ' Otros errores .NET (por ejemplo conexión)
                        MessageBox.Show("Error general: " & ex.Message, "Error .NET")
                    Finally
                        close_conexion()
                        If grabarOK Then
                            MsgBox("LOTE N°:" & txt_Lote.Text & " HA SIDO ACTUALIZADO")
                            Limpia_Campos()
                        End If
                    End Try

                    REM   Bitacora.txt_BandConteo1.Text = nUD_Cant_Band.Value
                    'Bitacora.txt_BandIng1.Text = i
                    'Bitacora.txt_PromVaciasxBand1.Text = dPromedioVacias
                    'Bitacora.txt_TotalCeldasVacias1.Text = dTotalVacias
                    'Bitacora.txt_PlsegunPromConteo1.Text = iCantTotalPlantas
                    'Bitacora.txt_TotalPlConteo1.Text = iTotalConteo
                    'Bitacora.txt_Germ1.Text
                End If
                '' Graba Bitacora para el N° de Lote
            Else
                '' Graba Bitacora sin Lote Asociado, para fines generales.
                open()
                sSsql = "SP_GRABA_BITACORA "
                sSsql += Str(IdBitacora) + ","
                sSsql += "'" + sTipo_Evento + "',"
                sSsql += "0,"
                sSsql += Str(TE_ID(Me.cmb_Evento.SelectedIndex)) + ","
                sSsql += Str(IdInsumo) + ","
                sSsql += "'" + dtp_FechaEvento.Value + "',"
                sSsql += "'" + Format(dtp_HoraEvento.Value, "T") + "',"
                sSsql += Str(ID_Vendedor(Me.cmb_IDVENDEDOR.SelectedIndex)) + ","
                sSsql += Str(IdAsignadoA) + ","
                sSsql += Str(Val(txt_Cantidad.Text)) + ","
                sSsql += Str(IdTipoUnidad) + ","
                sSsql += "'" + dtp_FechaIngreso.Value + "',"
                sSsql += "'" + dtp_FechaMandatoria.Value + "',"
                sSsql += "'" + txt_comentarios.Text + "',"
                sSsql += "'N',"
                sSsql += "'N',"
                sSsql += "0,"
                sSsql += "0,"
                sSsql += "'" + TE_Camara(Me.cmb_Evento.SelectedIndex) + "',"
                sSsql += "'" + sIngresoCamara + "',"
                sSsql += "'" + sIdentificacionNave + "',"
                sSsql += "'" + txt_ubicacion.Text + "',"
                sSsql += "'',"
                sSsql += "Null,"
                REM CAMPOS AGREGADOS PARA COMPLETAR CAMPOS VACIOS NUEVOS
                sSsql += "0,"
                sSsql += "0,"
                sSsql += "'',"
                sSsql += "'',"
                sSsql += "''"
                Try
                    command = connection.CreateCommand()
                    command.CommandText = sSsql
                    command.ExecuteNonQuery()
                    grabarOK = True
                Catch ex As Exception
                    ' Otros errores .NET (por ejemplo conexión)
                    MessageBox.Show("Error general: " & ex.Message, "Error .NET")
                Finally
                    close_conexion()
                    If grabarOK Then
                        MsgBox("REGISTRO DE BITACORA HA SIDO CREADO CORRECTAMENTE")
                        Limpia_Campos()
                    End If
                End Try
            End If
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub cmb_Evento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Evento.SelectedIndexChanged

        If cmb_Evento.SelectedIndex > -1 Then
            Activa_Campos_Segun_Evento()
            Consulta_Instrucciones()

            If cmb_Evento.Text = "CONTEO DE SIEMBRA" Then
                cmb_Unidad.Text = "BANDEJA"
                cmb_Unidad.Enabled = False
                rb_ConteoSiembra.Checked = True


            ElseIf cmb_Evento.Text = "CONTEO DE PLANTAS" Then
                cmb_Unidad.Text = "PLANTAS"
                cmb_Unidad.Enabled = False
                rb_conteoPlantas.Checked = True

            Else
                cmb_Unidad.Text = Nothing
                cmb_Unidad.Enabled = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Graba_Evento()
    End Sub

    Private Function Valida_Existencia_Lote() As Boolean
        bOK = True
        open()
        sSsql = "SP_CONSULTA_DETALLE_LOTE " + Str(Val(txt_Lote.Text))
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If Not datatbl.HasRows Then
            bOK = False
        End If
        close_conexion()
        Valida_Existencia_Lote = bOK
    End Function
    Private Function Valida_Lote() As Boolean

        ''SP_CONSULTA_DETALLE_LOTE

        If cmb_Evento.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Evento", MsgBoxStyle.Critical, "Advertencia")
            Valida_Lote = False
            Exit Function
        End If

        If cmb_IDVENDEDOR.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Usuario", MsgBoxStyle.Critical, "Advertencia")
            Valida_Lote = False
            Exit Function
        End If

        bOK = True
        open()
        sSsql = "SP_CONSULTA_DETALLE_LOTE " + Val(txt_Lote.Text).ToString
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        txt_CantBandejas.Clear()
        txt_CantidadCeldas.Clear()
        txt_ESTADO.Clear()
        txt_IdEstado.Clear()
        txt_conteosiembra.Clear()
        txt_Cantidad.Clear()
        'cmb_Unidad.SelectedIndex = -1
        txt_ubicacion.Clear()
        txt_ConteoFinal.Clear()
        txt_SaldoPlantas.Clear()

        If datatbl.HasRows Then
            datatbl.Read()

            If (IsDBNull(datatbl(76))) Then
                txt_CantBandejas.Text = datatbl(12)
            Else
                If datatbl(76) = 0 Then
                    txt_CantBandejas.Text = datatbl(12)
                Else
                    txt_CantBandejas.Text = datatbl(76)
                End If
            End If
            gCantidadMaximaBandejas = Val(txt_CantBandejas.Text)
            txt_Cantidad.Text = gCantidadMaximaBandejas
            'txt_CantBandejas.Text = If(IsDBNull(datatbl(76)), 0, datatbl(76))
            txt_CantidadCeldas.Text = datatbl(25)
            txt_ESTADO.Text = datatbl(22)
            txt_IdEstado.Text = datatbl(26)
            txt_ubicacion.Text = If(IsDBNull(datatbl(52)), "", datatbl(52))

            txt_ConteoFinal.Text = datatbl(18)
            'txt_AvisoCliente.Text = datatbl(20)
            txt_SaldoPlantas.Text = datatbl(31)
            txt_celdasvacias.Text = If(IsDBNull(datatbl(39)), "", datatbl(39))
            txt_Num_Nave_lote.Text = If(IsDBNull(datatbl(40)), "", datatbl(40))

            If Not IsDBNull(datatbl(16)) Then
                txt_conteosiembra.Text = datatbl(16)
            Else
                txt_conteosiembra.Text = 0
            End If

            txt_Semilla.Text = datatbl(28)
            txt_Variedad.Text = datatbl(29)

            txtCliente.Text = datatbl(0)
            txtPlantasPedido.Text = datatbl(10)
            txtBandejasPedido.Text = datatbl(12)
            txtTipoBandejaPedido.Text = datatbl(25)

            If datatbl(26) >= 2 Then
                txt_BandConteo1.Text = datatbl(53)
                txt_BandIng1.Text = datatbl(54)
                txt_PromVaciasxBand1.Text = datatbl(55)
                txt_TotalCeldasVacias1.Text = datatbl(56)
                txt_PlsegunPromConteo1.Text = datatbl(57)
                txt_TotalPlConteo1.Text = datatbl(58)
                txt_Germ1.Text = Format(datatbl(59), "###.##")
                txt_BandConteo2.Text = datatbl(60)
                txt_BandIng2.Text = datatbl(61)
                txt_PromVaciasxBand2.Text = datatbl(62)
                txt_TotalCeldasVacias2.Text = datatbl(63)
                txt_PlsegunPromConteo2.Text = datatbl(64)
                txt_TotalPlConteo2.Text = datatbl(65)
                txt_Germ2.Text = Format(datatbl(66), "###.##")
                txt_GermFinal.Text = Format(datatbl(67), "###.##")
            End If

            If datatbl(26) = 9 Then 'Lote Nulo
                MsgBox("No es posible efectuar Conteo. Estado del Lote = LOTE NULO.", MsgBoxStyle.Critical)
                bOK = False
                Limpia_Campos()
            End If

            If datatbl(77) > 0 Then ' Tiene Hijos
                If TE_ConteoPlantas(Me.cmb_Evento.SelectedIndex) = "S" Then ' Conteo de Plantas
                    If datatbl(26) = 5 Then ' Estado = LOTE PADRE CERRADO'
                        MsgBox("No es posible efectuar Conteo. Estado del Lote = LOTE PADRE CERRADO.", MsgBoxStyle.Critical)
                        bOK = False
                        Limpia_Campos()
                    End If

                End If
                'If TE_ConteoPlantas(Me.cmb_Evento.SelectedIndex) = "S" Then
                '    MsgBox("No es posible efectuar Conteo. Existen Lotes generados a partir del Lote Nº " + Val(txt_Lote.Text).ToString + vbCrLf + "Solo se permite realizar Conteos a Lotes Finales que serán entregados al Cliente.")
                '    bOK = False
                '    Limpia_Campos()
                'End If

            End If

            If datatbl(26) = 4 Then
                MsgBox("LOTE CERRADO. NO ES POSIBLE INGRESAR MOVIMIENTOS.", MsgBoxStyle.Critical)
                bOK = False
                Limpia_Campos()
            End If

            If datatbl(31) = 0 And datatbl(26) = 4 Then
                MsgBox("LOTE NO TIENE SALDO DE PLANTAS. NO ES POSIBLE INGRESAR MOVIMIENTOS.", MsgBoxStyle.Critical)
                bOK = False
                Limpia_Campos()
            End If


        Else
            MsgBox("NO EXISTE N° DE LOTE")
            bOK = False

        End If
        close_conexion()
        Valida_Lote = bOK
    End Function
    Private Sub Limpia_Campos()
        txt_comentarios.Text = ""
        dtp_FechaIngreso.Value = Now
        'txt_fechaRegistro.Text = Now.Date
        dtp_HoraEvento.Value = Now
        'txt_Hora.Text = ""
        txt_Lote.Clear()
        'txt_NumNave.Text = ""
        txt_CantBandejas.Text = ""
        txt_CantidadCeldas.Text = ""
        txt_ESTADO.Text = ""
        txt_IdEstado.Text = ""
        txt_conteosiembra.Text = ""
        txt_Cantidad.Text = ""
        'cmb_Unidad.SelectedIndex = -1
        txt_ubicacion.Text = ""
        txt_ConteoFinal.Text = ""
        'txt_AvisoCliente.Text = ""
        txt_BandConteo1.Clear()
        txt_BandIng1.Clear()
        txt_Germ1.Clear()
        txt_PlsegunPromConteo1.Clear()
        txt_PromVaciasxBand1.Clear()
        txt_TotalCeldasVacias1.Clear()
        txt_TotalPlConteo1.Clear()
        txt_BandConteo2.Clear()
        txt_BandIng2.Clear()
        txt_Germ2.Clear()
        txt_PlsegunPromConteo2.Clear()
        txt_PromVaciasxBand2.Clear()
        txt_TotalCeldasVacias2.Clear()
        txt_TotalPlConteo2.Clear()
        txt_NumConteo.Clear()
        txt_Semilla.Clear()
        txt_Variedad.Clear()
        txt_Num_Nave_lote.Clear()
        txt_SaldoPlantas.Clear()
        txt_LoteSemilla.Clear()
        txt_Batch.Clear()
        txt_FechaEnvasado.Clear()
        txt_Band_Nuevas.Clear()
        txt_Band_Usadas.Clear()
        txt_celdasvacias.Clear()
        'cmb_Evento.SelectedIndex = -1
        txt_Semilla.Clear()
        txt_Variedad.Clear()

        txtCliente.Clear()
        txtPlantasPedido.Clear()
        txtBandejasPedido.Clear()
        txtTipoBandejaPedido.Clear()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Limpia_Campos()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Elimina_Bitacora()
    End Sub
    Private Sub Elimina_Bitacora()
        Dim sResp As String
        Dim Idbitacora As Integer
        'Dim FilaGrilla As Integer
        sResp = InputBox("CONFIRME ELIMINACION DE BITACORA DEL SISTEMA", "ELIMINACION DE BITACORA", "S")
        If UCase(sResp) = "S" Then
            'FilaGrilla = DataGrilla.CurrentRow.Index
            'Idbitacora = DataGrilla.Rows(FilaGrilla).Cells(0).Value
            If Idbitacora <= 0 Then
                MsgBox("IDENTIFICADOR DE BITACORA NO ES VALIDO. DEBE SELECCIONAR BITACORA A ELIMINAR.")
                Exit Sub
            End If
            sSsql = "SP_ELIMINA_BITACORA "
            'idFamilia numeric(18,0)
            sSsql += Str(Idbitacora)
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            command.ExecuteNonQuery()
            close_conexion()

        End If
    End Sub

    Private Sub rb_Mandatorio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Mandatorio.CheckedChanged
        If rb_Mandatorio.Checked Then
            cmb_UsuarioAsignado.Enabled = True
            dtp_FechaMandatoria.Enabled = True
            'txt_FechaMandatoria.ReadOnly = False
            cmb_UsuarioAsignado.Focus()
            'txt_FechaEvento.Text = ""
            'txt_FechaEvento.ReadOnly = True
            dtp_FechaEvento.Enabled = False
            'txt_Hora.Text = ""
            dtp_HoraEvento.Enabled = False
            'txt_Hora.ReadOnly = True
            txt_Cantidad.Clear()
            txt_Cantidad.ReadOnly = True
            'cmb_Unidad.Enabled = False
        End If
    End Sub
    Private Sub Activa_Campos_Segun_Evento()

        If cmb_Evento.SelectedIndex > -1 Then
            If TE_Lote(Me.cmb_Evento.SelectedIndex) = "S" Then
                'rb_Lote.Enabled = True
                'rb_Nave.Enabled = True
                txt_Lote.Enabled = True
                txt_Lote.ReadOnly = False
                'rb_Lote.Checked = True
            Else
                txt_Lote.Enabled = False
                txt_Lote.ReadOnly = True
                'rb_Lote.Enabled = False
                'rb_Nave.Enabled = False
            End If
            If TE_Insumo(Me.cmb_Evento.SelectedIndex) = "S" Then
                cmb_Insumo.Enabled = True
            Else
                cmb_Insumo.Enabled = False
            End If
            If TE_ConteoPlantas(Me.cmb_Evento.SelectedIndex) = "S" Then
                txt_celdasvacias.ReadOnly = False
                grp_ConteoPlantas.Enabled = True
            Else
                txt_celdasvacias.ReadOnly = True
                grp_ConteoPlantas.Enabled = False
            End If
            If TE_Camara(Me.cmb_Evento.SelectedIndex) = "S" Then
                grp_UsoCamara.Enabled = True
            Else
                grp_UsoCamara.Enabled = False
            End If
            If TE_IdentNave(Me.cmb_Evento.SelectedIndex) = "S" Then
                txt_ubicacion.ReadOnly = False
                txt_Num_Nave_lote.ReadOnly = False
            Else
                txt_ubicacion.ReadOnly = True
                txt_Num_Nave_lote.ReadOnly = True
            End If
        End If


    End Sub
    Private Function Valida_Registro_Evento() As Boolean
        Dim bOK As Boolean
        Dim sMensaje As String
        sMensaje = ""
        bOK = True

        If TE_Lote(Me.cmb_Evento.SelectedIndex) = "S" Then
            If Val(txt_Lote.Text) <= 0 Then
                bOK = False
                sMensaje = "1. DEBE SELECCIONAR N° DE LOTE"
            End If

            If Not Valida_Existencia_Lote() Then
                bOK = False
                sMensaje += " 2. DEBE INGRESAR N° DE LOTE VALIDO"
            End If

        End If

        If TE_Insumo(Me.cmb_Evento.SelectedIndex) = "S" Then
            If cmb_Insumo.SelectedIndex = -1 Then
                bOK = False
                sMensaje += " 3. DEBE SELECCIONAR INSUMO"
            End If
        End If

        If TE_ConteoPlantas(Me.cmb_Evento.SelectedIndex) = "S" And rb_ConteoSiembra.Checked = True Then
            '            If Val(txt_IdEstado.Text) <> 0 Then
            ' bOK = False
            ' sMensaje = " 4. ESTADO DEL LOTE NO PERMITE CONTEO DE SIEMBRA"
            'End If
            If Val(txt_celdasvacias.Text) < 0 Then
                bOK = False
                sMensaje += " 4. CANTIDAD DE CELDAS VACIAS DEBE SER CERO O SUPERIOR"
            End If
        End If

        If rb_Mandatorio.Checked Then
            If cmb_UsuarioAsignado.SelectedIndex = -1 Then
                bOK = False
                sMensaje += " 5. DEBE SELECCIONAR USUARIO A QUIEN SE ASIGNARA EL EVENTO"
            End If
            'If Not IsDate(txt_FechaMandatoria.Text) Or txt_FechaMandatoria.Text = "  -  -" _
            '        Or txt_FechaMandatoria.Text = "" Then
            '    bOK = False
            '    sMensaje += " 6. FECHA MANDATORIA NO VALIDA"
            'End If
            'txt_FechaEvento.Text = ""
            'txt_Hora.Text = ""
        End If

        If rb_Registro.Checked Then
            'txt_FechaMandatoria.Text = ""
            'If txt_FechaEvento.Text = "" Or Not IsDate(txt_FechaEvento.Text) _
            ' Or txt_FechaEvento.Text = "  -  -" Then
            '    bOK = False
            '    sMensaje += " 7. FECHA DEL EVENTO NO VALIDA"
            'End If
            'If txt_Hora.Text = "" Or txt_Hora.Text = "  :" And TE_ConteoPlantas(Me.cmb_Evento.SelectedIndex) = "N" Then
            'bOK = False
            'sMensaje += " 8. HORA DEL EVENTO NO VALIDA"
            'End If


            If TE_Camara(Me.cmb_Evento.SelectedIndex) = "S" Or
               TE_ConteoPlantas(Me.cmb_Evento.SelectedIndex) = "S" Then

                If Val(txt_Cantidad.Text) <= 0 Then
                    bOK = False
                    sMensaje += " 8. CANTIDAD DEBE SER MAYOR A CERO"
                End If
                If cmb_Unidad.SelectedIndex = -1 Then
                    bOK = False
                    sMensaje += " 9. DEBE SELECCIONAR TIPO DE UNIDAD"
                End If


            End If

            If TE_IdentNave(Me.cmb_Evento.SelectedIndex) = "S" Then
                If txt_ubicacion.Text = "" Then
                    bOK = False
                    sMensaje += " 11. DEBE INGRESAR IDENTIFICACION DE LA NAVE"
                End If
            End If


            'If rb_ConteoSiembra.Checked = True Then
            '    If Val(txt_Cantidad.Text) > gCantidadMaximaBandejas Then
            '        bOK = False
            '        sMensaje += " 12. CANTIDAD DE BANDEJAS DE SIEMBRA NO DEBE SER MAYOR A BANDEJAS DEL LOTE"
            '    End If

            'End If


            If sMensaje <> "" Then
                MsgBox(sMensaje)
            End If
        End If

        Valida_Registro_Evento = bOK
    End Function
    Private Sub Consulta_Instrucciones()

        open()
        sSsql = "SP_CONSULTA_EVENTO_ID " + Str(TE_ID(Me.cmb_Evento.SelectedIndex))
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            txt_Instrucciones.Text = datatbl(2)
        End If
        close_conexion()

    End Sub

    Private Sub rb_Registro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Registro.CheckedChanged
        If rb_Registro.Checked Then
            dtp_FechaEvento.Enabled = True
            dtp_HoraEvento.Enabled = True
            txt_Cantidad.ReadOnly = False
        End If
    End Sub

    Private Sub ValidaConteoPlantas()
        If Val(txt_NumConteo.Text) <> 1 AndAlso Val(txt_NumConteo.Text) <> 2 Then
            MsgBox("N° de Conteo debe ser 1 o 2", MsgBoxStyle.Exclamation)
            txt_NumConteo.Text = Nothing
            txt_NumConteo.Focus()
            Exit Sub
        End If
        txt_Cantidad.ReadOnly = True
        txt_celdasvacias.ReadOnly = True
        txt_Band_Nuevas.Enabled = False
        txt_Band_Usadas.Enabled = False
        txt_LoteSemilla.Enabled = False
        txt_Batch.Enabled = False
        txt_FechaEnvasado.Enabled = False

        If Val(txt_conteosiembra.Text) = 0 OrElse Val(txt_CantBandejas.Text) = 0 Then
            MsgBox("LOTE NO TIENE CONTEO DE SIEMBRA")
        Else
            Conteo_Plantas.nUD_Cant_Band.Value = Val(txt_CantBandejas.Text)
            Conteo_Plantas.Visible = True
        End If

        cmb_Unidad.Text = "PLANTAS"
        cmb_Unidad.Enabled = False
    End Sub


    Private Sub rb_conteoinicialNO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_conteoPlantas.CheckedChanged
        If txt_Lote.Text <> Nothing Then
            If rb_conteoPlantas.Checked Then
                ValidaConteoPlantas()
            Else
                txt_Cantidad.ReadOnly = False
                txt_celdasvacias.ReadOnly = False
                txt_Band_Nuevas.Enabled = True
                txt_Band_Usadas.Enabled = True
                txt_LoteSemilla.Enabled = True
                txt_Batch.Enabled = True
                txt_FechaEnvasado.Enabled = True
            End If
        End If

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If cmb_Evento.Text = "CONTEO DE SIEMBRA" Then
            cmb_Unidad.Text = "BANDEJA"
            cmb_Unidad.Enabled = False
        ElseIf cmb_Evento.Text = "CONTEO DE PLANTAS" Then
            cmb_Unidad.Text = "PLANTAS"
        Else
            cmb_Unidad.Text = Nothing
        End If
        Valida_Lote()

    End Sub

    Private Sub rb_ConteoSiembra_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rb_ConteoSiembra.CheckedChanged
        'BANDEJA
        If rb_ConteoSiembra.Checked = True Then
            cmb_Unidad.Text = "BANDEJA"
            cmb_Unidad.Enabled = False
        End If
    End Sub

    Private Sub txt_NumConteo_TextChanged(sender As Object, e As EventArgs) Handles txt_NumConteo.TextChanged
        If Val(txt_NumConteo.Text) > 0 AndAlso txt_Lote.Text <> Nothing Then
            ValidaConteoPlantas()
        Else
            txt_NumConteo.Text = Nothing
        End If
    End Sub


    Private Sub txt_Lote_LostFocus(sender As Object, e As EventArgs) Handles txt_Lote.LostFocus
        Dim xLote As String
        xLote = txt_Lote.Text
        Limpia_Campos()
        txt_Lote.Text = xLote
    End Sub

    Private Sub txt_Lote_TextChanged(sender As Object, e As EventArgs) Handles txt_Lote.TextChanged

    End Sub

    Private Sub cmb_IDVENDEDOR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_IDVENDEDOR.SelectedIndexChanged

    End Sub
End Class