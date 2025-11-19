Public Class Consulta_Deudores

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Genera_Consulta()
    End Sub
    Private Sub Genera_Consulta()
        Dim i As Integer
   
        Dim dTotalDeuda As Double

        open()
        sSsql = "SP_CONSULTA_DEUDORES"
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        DataGrilla.Rows.Clear()

        dTotalDeuda = 0

        If datatbl.HasRows Then

            i = 0
            While datatbl.Read

                DataGrilla.Rows.Add()
                DataGrilla.Rows(i).Cells(0).Value = datatbl(2)
                DataGrilla.Rows(i).Cells(1).Value = Mid(datatbl(1), 1, 11) + "-" + Mid(datatbl(1), 12, 1)
                DataGrilla.Rows(i).Cells(2).Value = datatbl(3)
                DataGrilla.Rows(i).Cells(3).Value = Format(datatbl(4), "###,###,###")
                DataGrilla.Rows(i).Cells(4).Value = datatbl("FechaUltFac")
                DataGrilla.Rows(i).Cells(5).Value = datatbl("TipoDoc")
                i += 1

                dTotalDeuda += datatbl(4)

            End While

        End If

        close_conexion()
        txt_DeudaTotal.Text = Format(dTotalDeuda, "###,###,###")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class