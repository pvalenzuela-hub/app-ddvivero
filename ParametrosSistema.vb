Public Class ParametrosSistema



    Private Sub ParametrosSistema_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sSsql = "SP_CONSULTA_SYS_INI"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
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
                    Case 39
                        txtProrroga.Text = datatbl(2)
                    Case 40
                        txtDesbloqueo.Text = datatbl(2)
                End Select
            End While
        End If
        close_conexion()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ActualizaParametrosSistema()
    End Sub

    Private Sub ActualizaParametrosSistema()

        open()
        command = connection.CreateCommand()
        sSsql = "SP_ActualizaParametrosSistema "
        sSsql &= "'" & "GTOSGRALES" & "',"
        sSsql &= "'" & txt_GTOSGRALES.Text & "'"
        command.CommandText = sSsql
        command.ExecuteNonQuery()

        sSsql = "SP_ActualizaParametrosSistema "
        sSsql &= "'" & "IVA" & "',"
        sSsql &= "'" & txt_IVA.Text & "'"
        command.CommandText = sSsql
        command.ExecuteNonQuery()

        sSsql = "SP_ActualizaParametrosSistema "
        sSsql &= "'" & "TEMPO_PRI" & "',0,"
        sSsql &= "'" & txt_ID26_inicio.Text & "',"
        sSsql &= "'" & txt_ID26_final.Text & "',"
        sSsql &= "26"
        '        sSsql &= "'" & txt_INV_MDESDE.Text & "',"
        command.CommandText = sSsql
        command.ExecuteNonQuery()

        sSsql = "SP_ActualizaParametrosSistema "
        sSsql &= "'" & "TEMPO_VER" & "',0,"
        sSsql &= "'" & txt_ID27_inicio.Text & "',"
        sSsql &= "'" & txt_ID27_final.Text & "',"
        sSsql &= "27"
        command.CommandText = sSsql
        command.ExecuteNonQuery()

        sSsql = "SP_ActualizaParametrosSistema "
        sSsql &= "'" & "TEMPO_VER" & "',0,"
        sSsql &= "'" & txt_ID32_inicio.Text & "',"
        sSsql &= "'" & txt_ID32_final.Text & "',"
        sSsql &= "32"
        command.CommandText = sSsql
        command.ExecuteNonQuery()

        sSsql = "SP_ActualizaParametrosSistema "
        sSsql &= "'" & "TEMPO_OTO" & "',0,"
        sSsql &= "'" & txt_ID28_inicio.Text & "',"
        sSsql &= "'" & txt_ID28_final.Text & "',"
        sSsql &= "28"
        command.CommandText = sSsql
        command.ExecuteNonQuery()


        sSsql = "SP_ActualizaParametrosSistema "
        sSsql &= "'" & "TEMPO_INV" & "',0,"
        sSsql &= "'" & txt_ID29_inicio.Text & "',"
        sSsql &= "'" & txt_ID29_final.Text & "',"
        sSsql &= "29"
        command.CommandText = sSsql
        command.ExecuteNonQuery()

        sSsql = "SP_ActualizaParametrosSistema "
        sSsql &= "'" & "MAXPEDIDO" & "',"
        sSsql &= "'" & txt_MaximoPedido.Text.ToString & "'"
        command.CommandText = sSsql
        command.ExecuteNonQuery()

        sSsql = "SP_ActualizaParametrosSistema "
        sSsql &= "'" & "BE" & "',"
        sSsql &= "'" & txt_BE.Text & "'"
        command.CommandText = sSsql
        command.ExecuteNonQuery()

        sSsql = "SP_ActualizaParametrosSistema "
        sSsql &= "'" & "FE" & "',"
        sSsql &= "'" & txt_FA.Text & "'"
        command.CommandText = sSsql
        command.ExecuteNonQuery()

        sSsql = "SP_ActualizaParametrosSistema "
        sSsql &= "'" & "CONTA_INI" & "',"
        sSsql &= "'" & txt_CONTA_INI.Text & "'"
        command.CommandText = sSsql
        command.ExecuteNonQuery()

        sSsql = "SP_ActualizaParametrosSistema "
        sSsql &= "'" & "NOTASVENTA" & "',0,"
        sSsql &= "Null,"
        sSsql &= "Null,"
        sSsql &= "38,"
        sSsql &= "'" & txtNotasDetalleVenta.Text & "'"
        command.CommandText = sSsql
        command.ExecuteNonQuery()

        sSsql = "SP_ActualizaParametrosSistema "
        sSsql &= "'" & "PRORROGA" & "',"
        sSsql &= "'" & txtProrroga.Text.ToString & "'"
        command.CommandText = sSsql
        command.ExecuteNonQuery()

        sSsql = "SP_ActualizaParametrosSistema "
        sSsql &= "'" & "PWDBLOQUEO" & "',"
        sSsql &= "'" & txtDesbloqueo.Text.ToString & "'"
        command.CommandText = sSsql
        command.ExecuteNonQuery()


        close_conexion()

        MsgBox("Parámetros Actualizados.")
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class