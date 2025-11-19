Imports System.Data.SqlClient

Public Class Consulta_GuiasLote

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Ejecuta_Consulta()
    End Sub
    Private Sub Ejecuta_Consulta()
        Dim i As Integer
        sSsql = "SP_Reporte_Lot_sGuia "
        sSsql += "'" + txt_FechaDesde.Text + "'"
        open()

        DataLotes.Rows.Clear()

        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            i = 0
            While datatbl.Read = True
                DataLotes.Rows.Add()
                DataLotes.Rows(i).Cells(0).Value = datatbl(0)
                DataLotes.Rows(i).Cells(1).Value = datatbl(1)
                DataLotes.Rows(i).Cells(2).Value = datatbl(2)
                DataLotes.Rows(i).Cells(3).Value = datatbl(3)
                DataLotes.Rows(i).Cells(4).Value = datatbl(4)
                DataLotes.Rows(i).Cells(5).Value = datatbl(5)
                DataLotes.Rows(i).Cells(6).Value = Format(datatbl(6), "###,###,###")
                i += 1
            End While
        End If


        close_conexion()


    End Sub
End Class