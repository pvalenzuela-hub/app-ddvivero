Public Class ParametrosSistema



    Private Sub ParametrosSistema_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open()
        Try
            command = connection.CreateCommand()
            command.CommandText = "SP_CONSULTA_SYS_INI"
            command.CommandType = CommandType.StoredProcedure
            datatbl = command.ExecuteReader()

            If datatbl.HasRows Then

                While datatbl.Read
                    Select Case datatbl(0)
                        Case 1
                            txt_GTOSGRALES.Text = datatbl(2)
                        Case 7
                            txt_IVA.Text = datatbl(2)
                        Case 33
                            txt_MaximoPedido.Text = datatbl(2)
                        Case 26
                            txt_ID26_inicio.Text = datatbl(3)
                            txt_ID26_final.Text = datatbl(4)
                        Case 27
                            txt_ID27_inicio.Text = datatbl(3)
                            txt_ID27_final.Text = datatbl(4)

                        Case 28
                            txt_ID28_inicio.Text = datatbl(3)
                            txt_ID28_final.Text = datatbl(4)
                        Case 29
                            txt_ID29_inicio.Text = datatbl(3)
                            txt_ID29_final.Text = datatbl(4)
                        Case 32
                            txt_ID32_inicio.Text = datatbl(3)
                            txt_ID32_final.Text = datatbl(4)
                        Case 26
                            txt_ID26_inicio.Text = datatbl(3)
                            txt_ID26_final.Text = datatbl(4)
                        Case 14
                            txt_BE.Text = datatbl(2)
                        Case 25
                            txt_FA.Text = datatbl(2)
                        Case 17
                            txt_CONTA_INI.Text = datatbl(2)
                        Case 38
                            txtNotasDetalleVenta.Text = datatbl(5)
                    End Select
                End While
            End If
        Finally
            If datatbl IsNot Nothing AndAlso Not datatbl.IsClosed Then
                datatbl.Close()
            End If
            close_conexion()
        End Try


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ActualizaParametrosSistema()
    End Sub

    Private Sub ActualizaParametrosSistema()

        open()
        Try
            EjecutaActualizacionParametro("GTOSGRALES", txt_GTOSGRALES.Text)
            EjecutaActualizacionParametro("IVA", txt_IVA.Text)
            EjecutaActualizacionParametro("TEMPO_PRI", "0", txt_ID26_inicio.Text, txt_ID26_final.Text, 26)
            EjecutaActualizacionParametro("TEMPO_VER", "0", txt_ID27_inicio.Text, txt_ID27_final.Text, 27)
            EjecutaActualizacionParametro("TEMPO_VER", "0", txt_ID32_inicio.Text, txt_ID32_final.Text, 32)
            EjecutaActualizacionParametro("TEMPO_OTO", "0", txt_ID28_inicio.Text, txt_ID28_final.Text, 28)
            EjecutaActualizacionParametro("TEMPO_INV", "0", txt_ID29_inicio.Text, txt_ID29_final.Text, 29)
            EjecutaActualizacionParametro("MAXPEDIDO", txt_MaximoPedido.Text)
            EjecutaActualizacionParametro("BE", txt_BE.Text)
            EjecutaActualizacionParametro("FE", txt_FA.Text)
            EjecutaActualizacionParametro("CONTA_INI", txt_CONTA_INI.Text)
            EjecutaActualizacionParametro("NOTASVENTA", "0", Nothing, Nothing, 38, txtNotasDetalleVenta.Text)

            If Not String.IsNullOrWhiteSpace(txtProrroga.Text) Then
                EjecutaActualizacionParametro("PRORROGA", txtProrroga.Text)
            End If

            If Not String.IsNullOrWhiteSpace(txtDesbloqueo.Text) Then
                EjecutaActualizacionParametro("PWDBLOQUEO", txtDesbloqueo.Text)
            End If
        Finally
            close_conexion()
        End Try

        MsgBox("Parámetros Actualizados.")
        Me.Close()
    End Sub

    Private Sub EjecutaActualizacionParametro(ByVal tipoParam As String,
                                              ByVal valorParam As String,
                                              Optional ByVal tempInicio As String = Nothing,
                                              Optional ByVal tempFinal As String = Nothing,
                                              Optional ByVal idSysIni As Integer? = Nothing,
                                              Optional ByVal notasPedido As String = Nothing)
        Using cmd As SqlClient.SqlCommand = connection.CreateCommand()
            cmd.CommandText = "SP_ActualizaParametrosSistema"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Tipo_Param", SqlDbType.VarChar, 10).Value = tipoParam
            cmd.Parameters.Add("@Valor_Param", SqlDbType.VarChar, 50).Value = valorParam

            Dim pTempInicio = cmd.Parameters.Add("@Temp_Inicio", SqlDbType.VarChar, 4)
            pTempInicio.Value = If(String.IsNullOrWhiteSpace(tempInicio), CType(DBNull.Value, Object), tempInicio)

            Dim pTempFinal = cmd.Parameters.Add("@Temp_Final", SqlDbType.VarChar, 4)
            pTempFinal.Value = If(String.IsNullOrWhiteSpace(tempFinal), CType(DBNull.Value, Object), tempFinal)

            Dim pIdSysIni = cmd.Parameters.Add("@ID_SysIni", SqlDbType.Int)
            pIdSysIni.Value = If(idSysIni.HasValue, CType(idSysIni.Value, Object), DBNull.Value)

            Dim pNotasPedido = cmd.Parameters.Add("@NotasPedido", SqlDbType.VarChar, -1)
            pNotasPedido.Value = If(String.IsNullOrEmpty(notasPedido), CType(DBNull.Value, Object), notasPedido)

            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
