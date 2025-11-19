Imports System.Data.SqlClient
Public Class Prox_Vcto
    Dim datatbl As SqlClient.SqlDataReader = Nothing
    Dim Command As SqlCommand = Nothing
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        close_conexion()
        Me.Close()
    End Sub

    Private Sub Prox_Vcto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave

        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        '' boton consulta
        CargaGrilla()
    End Sub
    Private Sub CargaGrilla()

        Dim dTotal As Double
        Dim i As Integer
        'Ejecutar Consulta

        DataCompras.Rows.Clear()
        ''SP_CONSULTA_COMPRAS_PENDIENTES '01/01/2010','05/08/2010'
        sSsql = "SP_CONSULTA_COMPRAS_PENDIENTES "
        sSsql += "'" + Format(dtp_Fecha1.Value, "dd/MM/yyyy") + "',"
        sSsql += "'" + Format(dtp_fecha2.Value, "dd/MM/yyyy") + "'"
        open()
        Command = connection.CreateCommand()
        Command.CommandText = sSsql
        datatbl = Command.ExecuteReader()

        dTotal = 0
        i = 0
        If datatbl.HasRows Then
            While datatbl.Read = True
                DataCompras.Rows.Add()
                DataCompras.Rows(i).Cells(0).Value = datatbl(0)
                DataCompras.Rows(i).Cells(1).Value = datatbl(1)
                DataCompras.Rows(i).Cells(2).Value = datatbl(2)
                DataCompras.Rows(i).Cells(3).Value = datatbl(3)
                DataCompras.Rows(i).Cells(4).Value = Format(datatbl(4), "###,###,###")
                DataCompras.Rows(i).Cells(5).Value = Format(datatbl(5), "###,###,###")
                DataCompras.Rows(i).Cells(6).Value = Format(datatbl(6), "###,###,###")
                i += 1
                dTotal += datatbl(6)
            End While
            DataCompras.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DataCompras.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DataCompras.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Else
            MessageBox.Show("NO EXISTEN DATOS ASOCIADOS A LA CONSULTA")
        End If
        close_conexion()
        txt_Total.Text = Format(dTotal, "###,###,###")

    End Sub
End Class