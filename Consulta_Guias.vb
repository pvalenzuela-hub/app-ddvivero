Imports System.Data.SqlClient
Public Class Consulta_Guias
    Dim datatbl As SqlClient.SqlDataReader = Nothing
    Dim command As SqlCommand = Nothing
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Genera_consulta()
    End Sub
    Private Sub Genera_consulta()
        Dim i As Integer
        sSsql = ""
        sSsql = "SP_CONSULTA_FULL_GUIA '" + Format(CDate(DateDesde.Text), "dd/MM/yyyy") + "','"
        sSsql += Format(CDate(DateHasta.Text), "dd/MM/yyyy") + "',"

        If chk_PendientesFactura.Checked Then
            sSsql += "1"
        Else
            sSsql += "0"
        End If


        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        DataConsulta.Rows.Clear()

        If datatbl.HasRows Then

            While datatbl.Read = True

                DataConsulta.Rows.Add()
                DataConsulta.Rows(i).Cells(0).Value = datatbl(0)
                DataConsulta.Rows(i).Cells(1).Value = datatbl(1)
                DataConsulta.Rows(i).Cells(2).Value = datatbl(16)
                DataConsulta.Rows(i).Cells(3).Value = datatbl(27)
                DataConsulta.Rows(i).Cells(4).Value = datatbl(4)
                DataConsulta.Rows(i).Cells(5).Value = datatbl(5)
                DataConsulta.Rows(i).Cells(6).Value = datatbl(6)
                DataConsulta.Rows(i).Cells(7).Value = datatbl(7)
                DataConsulta.Rows(i).Cells(8).Value = datatbl(8)
                DataConsulta.Rows(i).Cells(9).Value = datatbl(9)
                DataConsulta.Rows(i).Cells(10).Value = datatbl(10)
                DataConsulta.Rows(i).Cells(11).Value = datatbl(11)
                DataConsulta.Rows(i).Cells(12).Value = datatbl(34)
                DataConsulta.Rows(i).Cells(13).Value = datatbl(35)



                i += 1
            End While
            DataConsulta.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DataConsulta.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DataConsulta.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DataConsulta.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DataConsulta.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DataConsulta.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DataConsulta.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        End If

        datatbl.Close()
        close_conexion()
    End Sub
End Class