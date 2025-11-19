Public Class Preventa_Popup

    Private Sub CambiaMarcaPreventa()
        Dim iNumLote As Integer
        Dim Motivo As String = "(" & gUSER & ") " & txtMotivoPreventa.Text.Trim()

        open()
        command = connection.CreateCommand()

        For i = 0 To Consulta_Cliente.DataCartola.Rows.Count - 1
            iNumLote = CInt(Consulta_Cliente.DataCartola.Rows(i).Cells("IdPedidodet").Value)

            If CBool(Consulta_Cliente.DataCartola.Rows(i).Cells("EsPreventa").Value) AndAlso
           CDec(Consulta_Cliente.DataCartola.Rows(i).Cells("Saldo_Bandeja").Value) > 0 Then

                ' --- MARCAR COMO PREVENTA ---
                sSsql = "
                UPDATE PEDIDO_DETALLE 
                SET 
                    EsPreventa = 1,
                    MotivoEnablePreventa = 
                        ISNULL(MotivoEnablePreventa, '') 
                        + CASE WHEN LEN(ISNULL(MotivoEnablePreventa, '')) > 0 THEN CHAR(13) + CHAR(10) ELSE '' END
                        + FORMAT(GETDATE(), 'dd/MM/yyyy HH:mm') + ': ' + @Motivo
                WHERE EsPreventa = 0 AND IdPedidodet = @Id
            "

            Else
                ' --- QUITAR PREVENTA ---
                sSsql = "
                UPDATE PEDIDO_DETALLE 
                SET 
                    EsPreventa = 0,
                    MotivoDisablePreventa = 
                        ISNULL(MotivoDisablePreventa, '') 
                        + CASE WHEN LEN(ISNULL(MotivoDisablePreventa, '')) > 0 THEN CHAR(13) + CHAR(10) ELSE '' END
                        + FORMAT(GETDATE(), 'dd/MM/yyyy HH:mm') + ': ' + @Motivo
                WHERE EsPreventa = 1 AND IdPedidodet = @Id
            "
            End If

            command.CommandText = sSsql
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@Motivo", Motivo)
            command.Parameters.AddWithValue("@Id", iNumLote)
            command.ExecuteNonQuery()
        Next

        close_conexion()
        Consulta_Cliente.CargaCartola(gIDCliente, 1)
        Me.Close()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If txtMotivoPreventa.Text <> Nothing Then
            CambiaMarcaPreventa()
        Else
            MsgBox("Debe ingresar un motivo para realizar cambios de Preventa en lotes del cliente.")
        End If
    End Sub
End Class