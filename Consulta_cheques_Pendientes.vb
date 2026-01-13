Public Class Consulta_cheques_Pendientes


    Private Sub Genera_Consulta()
        Dim i As Integer
        Dim dTotalDeuda As Double
        Dim dTotalVencida As Double

        open()
        sSsql = "SP_CONSULTA_Cheques_New"
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        DataGrilla.Rows.Clear()
        dTotalDeuda = 0
        dTotalVencida = 0
        If datatbl.HasRows Then
            i = 0
            While datatbl.Read

                If Not gEsAutorizador Then
                    Dim vendedorFila As String = Convert.ToString(datatbl("IdUsuario")).Trim()
                    If Not String.Equals(vendedorFila, gUSER.Trim(), StringComparison.OrdinalIgnoreCase) Then
                        Continue While
                    End If
                End If

                DataGrilla.Rows.Add()
                DataGrilla.Rows(i).Cells("num_doc").Value = datatbl("num_doc")
                DataGrilla.Rows(i).Cells("documento").Value = datatbl("documento")
                DataGrilla.Rows(i).Cells("fvcto").Value = datatbl("fvcto")
                DataGrilla.Rows(i).Cells("Saldo").Value = Format(datatbl("Saldo"), "###,###,###")
                DataGrilla.Rows(i).Cells("Cliente").Value = datatbl("Cliente")
                DataGrilla.Rows(i).Cells("Fecha").Value = datatbl("FechaRegistro")
                DataGrilla.Rows(i).Cells("idFpago").Value = datatbl("idFpago")
                DataGrilla.Rows(i).Cells("IdCliente").Value = datatbl("IdCliente")
                DataGrilla.Rows(i).Cells("vendedor").Value = datatbl("IdUsuario")

                If datatbl("SaldoVencido") > 0 Then
                    With DataGrilla.Rows(i).Cells("Saldo").Style
                        .ForeColor = Color.Red
                        .Font = New Font(DataGrilla.Font, FontStyle.Bold)
                    End With
                Else
                    With DataGrilla.Rows(i).Cells("Saldo").Style
                        .ForeColor = Color.Green
                        .Font = New Font(DataGrilla.Font, FontStyle.Regular)
                    End With

                End If
                i += 1
                dTotalDeuda += datatbl("Saldo")
                dTotalVencida += datatbl("SaldoVencido")
            End While
        End If
        close_conexion()
        txt_DeudaTotal.Text = Format(dTotalDeuda, "###,###,###")
        txtSaldoVencido.Text = Format(dTotalVencida, "###,###,###")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        '' Solicita prórroga
        Dim iFila As Integer
        If DataGrilla.Rows.Count > 0 Then
            iFila = DataGrilla.CurrentRow.Index
            dtp_fecha_Prorroga.Value = DataGrilla.Rows(iFila).Cells("fvcto").Value
            dtp_fecha_Prorroga.Enabled = True
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprorroga.Click
        '' guardar cambios de fecha
        Dim iFila As Integer

        If txt_Password.Text <> gProrroga Then
            MsgBox("Clave Inválida", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If DataGrilla.Rows.Count > 0 Then
            iFila = DataGrilla.CurrentRow.Index
            sSsql = "SP_GRABA_PRORROGA_CHEQUE_New "
            sSsql += DataGrilla.Rows(iFila).Cells("num_doc").Value.ToString & ","
            sSsql += DataGrilla.Rows(iFila).Cells("IdCliente").Value.ToString & ","
            sSsql += DataGrilla.Rows(iFila).Cells("idFpago").Value.ToString & ","
            sSsql += "'" & dtp_fecha_Prorroga.Value & "',"
            sSsql += "'" & txt_user.Text & "'"

            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            command.ExecuteNonQuery()
            close_conexion()
            dtp_fecha_Prorroga.Enabled = False
            MsgBox("Cambio de fecha ha sido actualizado", MsgBoxStyle.Exclamation, "Consulta de Cheques")
            btnprorroga.Enabled = False
            txt_Password.Clear()
            dtp_fecha_Prorroga.Value = Now
            Genera_Consulta()
        End If
    End Sub

    Private Sub Consulta_cheques_Pendientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_user.Text = gUSER
        Genera_Consulta()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub txt_Password_TextChanged(sender As Object, e As EventArgs) Handles txt_Password.TextChanged
        If Len(txt_Password.Text) > 0 Then
            btnprorroga.Enabled = True
        End If
    End Sub
End Class