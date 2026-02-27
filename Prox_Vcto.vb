Imports System.Data.SqlClient
Public Class Prox_Vcto
    Dim datatbl As SqlClient.SqlDataReader = Nothing
    Dim Command As SqlCommand = Nothing
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub CargaGrilla()

        Dim dTotal As Double
        Dim dSaldoTotalVencido As Double = 0
        Dim i As Integer
        'Ejecutar Consulta

        DataCompras.Rows.Clear()
        ''SP_CONSULTA_COMPRAS_PENDIENTES '01/01/2010','05/08/2010'
        sSsql = "COMP_COMPRAS_PENDIENTES"
        open()
        Command = connection.CreateCommand()
        Command.CommandText = sSsql
        datatbl = Command.ExecuteReader()

        dTotal = 0
        i = 0
        If datatbl.HasRows Then
            While datatbl.Read
                DataCompras.Rows.Add()
                DataCompras.Rows(i).Cells(0).Value = datatbl(0)
                DataCompras.Rows(i).Cells(1).Value = datatbl(1)
                DataCompras.Rows(i).Cells(2).Value = datatbl(2)
                DataCompras.Rows(i).Cells(3).Value = datatbl(3)
                DataCompras.Rows(i).Cells(4).Value = datatbl(4)
                DataCompras.Rows(i).Cells(5).Value = datatbl(5)
                DataCompras.Rows(i).Cells(6).Value = datatbl(6)
                DataCompras.Rows(i).Cells(7).Value = datatbl("Fecha_Vencimiento")

                If datatbl("Vencida") = 1 Then
                    dSaldoTotalVencido += datatbl("Saldo")
                    DataCompras.Rows(i).DefaultCellStyle.BackColor = Color.Red
                    DataCompras.Rows(i).DefaultCellStyle.ForeColor = Color.White
                End If
                i += 1
                dTotal += datatbl(6)
            End While

        Else
            MessageBox.Show("NO EXISTEN DATOS ASOCIADOS A LA CONSULTA")
        End If
        close_conexion()
        txt_Total.Text = Format(dTotal, "###,###,###")
        txt_SaldoVencido.Text = Format(dSaldoTotalVencido, "###,###,###")

    End Sub



    Private Sub Prox_Vcto_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargaGrilla()
    End Sub
End Class