Public Class Cartola_Proveedor

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        gNOMBRE = txt_nombre.Text
        gQuienLlama = 0
        Busqueda_Proveedor.Visible = True
    End Sub
    Private Sub CargaCartola()
        Dim i As Integer
        Dim dTotalNeto As Double
        Dim dTotalPago As Double
        Dim dSaldo As Double

        DataCartola.Rows.Clear()
        sSsql = "SP_Cartola_Proveedor "
        sSsql += "'" + txt_RutProveedor.Text + "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then
            i = 0

            While datatbl.Read = True
                DataCartola.Rows.Add()
                DataCartola.Rows(i).Cells(0).Value = datatbl(0)
                DataCartola.Rows(i).Cells(1).Value = datatbl(1)
                DataCartola.Rows(i).Cells(2).Value = datatbl(2)
                DataCartola.Rows(i).Cells(3).Value = datatbl(3)
                DataCartola.Rows(i).Cells(4).Value = datatbl(4)
                DataCartola.Rows(i).Cells(5).Value = datatbl(5)
                DataCartola.Rows(i).Cells(6).Value = datatbl(6)
                dTotalNeto += datatbl(4)
                dTotalPago += datatbl(5)
                dSaldo += datatbl(6)
                i += 1
            End While
        End If
        close_conexion()

        txt_totalCompras.Text = dTotalNeto.ToString("###,###,##0")
        txt_totalPagos.Text = dTotalPago.ToString("###,###,##0")
        TXT_TotalDeuda.Text = dSaldo.ToString("###,###,##0")
    End Sub


    Private Sub txt_nombre_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_nombre.TextChanged

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        CargaCartola()
    End Sub
End Class