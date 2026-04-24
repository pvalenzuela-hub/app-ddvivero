Imports System.Data.SqlClient

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
                DataGrilla.Rows(i).Cells("glosapago").Value = datatbl("GlosaPago")
                DataGrilla.Rows(i).Cells("comentario").Value = datatbl("Comentarios")

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

        If Not ValidaClaveSistemaSP("PRORROGA", txt_Password.Text) Then
            MsgBox("Clave Inválida", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If DataGrilla.Rows.Count > 0 Then
            iFila = DataGrilla.CurrentRow.Index

            open()

            Try
                command = connection.CreateCommand()
                command.CommandText = "SP_GRABA_PRORROGA_CHEQUE_New"
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Add("@Num_Doc_Pago", SqlDbType.Int).Value = CInt(DataGrilla.Rows(iFila).Cells("num_doc").Value)
                command.Parameters.Add("@IdCliente", SqlDbType.Int).Value = CInt(DataGrilla.Rows(iFila).Cells("IdCliente").Value)
                command.Parameters.Add("@IdFPago", SqlDbType.Int).Value = CInt(DataGrilla.Rows(iFila).Cells("idFpago").Value)
                command.Parameters.Add("@FechaVcto", SqlDbType.Date).Value = dtp_fecha_Prorroga.Value.Date
                command.Parameters.Add("@UsuarioProrroga", SqlDbType.VarChar, 10).Value = txt_user.Text.Trim()
                command.ExecuteNonQuery()

                dtp_fecha_Prorroga.Enabled = False
                MsgBox("Cambio de fecha ha sido actualizado", MsgBoxStyle.Exclamation, "Consulta de Cheques")
                btnprorroga.Enabled = False
                txt_Password.Clear()
                dtp_fecha_Prorroga.Value = Now
                Genera_Consulta()
            Catch ex As Exception
                MessageBox.Show("Error al guardar la prórroga: " & ex.Message, "Consulta de Cheques", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                close_conexion()
            End Try
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

    Private Sub DataGrilla_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrilla.CellDoubleClick
        'Doble Click para Agregar Comentarios
        If DataGrilla.Rows.Count > 0 Then
            If e.ColumnIndex = 8 Then
                txtComentarios.Text = DataGrilla.Rows(e.RowIndex).Cells("comentario").Value
                grpComentario.Visible = True
                txtnum_doc_pago.Text = DataGrilla.Rows(e.RowIndex).Cells("num_doc").Value
                txtidcliente.Text = DataGrilla.Rows(e.RowIndex).Cells("IdCliente").Value
                txtidfpago.Text = DataGrilla.Rows(e.RowIndex).Cells("idFpago").Value
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtComentarios.Text <> Nothing Then
            open()
            Try
                ' 1) UPDATE a CarteraDocumentos
                Dim sql As String =
                "UPDATE CarteraDocumentos SET " &
                "    Comentarios = @comentarios, " &
                "    FechaUltimoComentario = GETDATE() " &
                "WHERE Num_Doc_Pago = @Num_Doc_Pago AND IdCliente = @IdCliente AND IdFpago = @IdFpago"

                Dim command As SqlCommand = connection.CreateCommand()
                command.CommandText = sql

                ' Mejor pasar los valores numéricos como tal, no con Str()
                command.Parameters.AddWithValue("@comentarios", txtComentarios.Text)
                command.Parameters.AddWithValue("@Num_Doc_Pago", CInt(Val(txtnum_doc_pago.Text)))
                command.Parameters.AddWithValue("@IdCliente", CInt(Val(txtidcliente.Text)))
                command.Parameters.AddWithValue("@IdFpago", CInt(Val(txtidfpago.Text)))

                command.ExecuteNonQuery()


            Catch ex As Exception
                MessageBox.Show("Error al actualizar Comentarios: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                close_conexion()
                MessageBox.Show("Se han actualizado los comentarios.", "Documentos con Saldo Pendiente",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                Genera_Consulta()


            End Try

            LimpiaCampos()

        End If
    End Sub
    Private Sub LimpiaCampos()
        txtComentarios.Clear()
        txtnum_doc_pago.Clear()
        txtidcliente.Clear()
        txtidfpago.Clear()
        grpComentario.Visible = False
    End Sub


    Private Sub DataGrilla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrilla.CellClick
        LimpiaCampos()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim sResp = MsgBox("¿Desea eliminar todos los comentarios registrados en el documento?. Confirme Eliminación.", MsgBoxStyle.YesNo, "Documentos Pendientes")

        If sResp = MsgBoxResult.Yes Then
            txtComentarios.Clear()
            Dim sql As String =
            "UPDATE CarteraDocumentos SET " &
            "    Comentarios = NULL, " &
            "    FechaUltimoComentario = NULL " &
            "WHERE Num_Doc_Pago = @Num_Doc_Pago AND IdCliente = @IdCliente AND IdFpago = @IdFpago"
            open()
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = sql
            ' Mejor pasar los valores numéricos como tal, no con Str()
            command.Parameters.AddWithValue("@Num_Doc_Pago", CInt(Val(txtnum_doc_pago.Text)))
            command.Parameters.AddWithValue("@IdCliente", CInt(Val(txtidcliente.Text)))
            command.Parameters.AddWithValue("@IdFpago", CInt(Val(txtidfpago.Text)))
            command.ExecuteNonQuery()
            close_conexion()
            LimpiaCampos()
            Genera_Consulta()
        End If
    End Sub
End Class
