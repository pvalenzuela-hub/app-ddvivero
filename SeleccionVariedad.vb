Public Class SeleccionVariedad

    Private Sub SeleccionVariedad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        REM carga tabla de variedades filtrado por familia

        Select Case gQuienLlama
            Case 1
                txt_Familia.Text = Cambio_Estado.txt_Semilla.Text
        End Select


        sSsql = "SP_CONSULTA_FULL_VARIEDAD_FILTRADO "
        sSsql += "'" + txt_Familia.Text + "'"
        open()
        Dim i As Integer
        DataVariedad.Rows.Clear()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            While datatbl.Read = True
                DataVariedad.Rows.Add()
                DataVariedad.Rows(i).Cells(0).Value = datatbl(0)
                DataVariedad.Rows(i).Cells(1).Value = datatbl(1)
                i += 1
            End While
        End If
        close_conexion()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        REM gQuienllama = 1 ==> Consulta Lote
        If DataVariedad.Rows.Count > 0 Then
            Dim FilaGrilla As Integer
            FilaGrilla = DataVariedad.CurrentRow.Index
            Select Case gQuienLlama
                Case 1
                    If Cambio_Estado.txt_Variedad.Text <> DataVariedad.Rows(FilaGrilla).Cells(1).Value Then
                        Dim sResp = MsgBox("Esta a punto de modificar la Variedad original del Lote. Debe confirmar esta operación.", MsgBoxStyle.YesNo)
                        If sResp = MsgBoxResult.Yes Then
                            Cambio_Estado.txt_Variedad.Text = DataVariedad.Rows(FilaGrilla).Cells(1).Value
                        End If
                    End If
            End Select
        End If
        Me.Close()
    End Sub
End Class