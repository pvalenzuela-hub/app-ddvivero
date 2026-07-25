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
        sSsql = "SELECT ch.TIPO_DOC, ch.NUM_DOC, CONVERT(char, ch.FECHA_DOC, 103) FechaCompra, " &
            "ch.TIPO_COMPRA, " &
            "CASE WHEN ch.Tipo_Doc = 'NC' THEN ROUND(ch.Total_Neto * 1.19, 0) * -1 ELSE ROUND(ch.Total_Neto * 1.19, 0) END TotalNeto, " &
            "ch.TOTAL_PAGO, " &
            "CASE WHEN ch.Tipo_doc = 'NC' THEN (ROUND(ch.Total_Neto * 1.19, 0) - ch.TOTAL_PAGO) * -1 ELSE ROUND(ch.Total_Neto * 1.19, 0) - ch.TOTAL_PAGO END Saldo, " &
            "ISNULL(pend.Fecha_Vcto, '') AS Fecha_Vcto, " &
            "ISNULL(pend.MedioPago, '') AS MedioPago " &
            "FROM COMPRA_HEADER ch " &
            "OUTER APPLY ( " &
            "    SELECT TOP 1 CONVERT(char, cp.FECHA_VCTO, 103) AS Fecha_Vcto, " &
            "           fp.DESCRIPCION AS MedioPago " &
            "    FROM COMPRA_PAGOS cp " &
            "    LEFT JOIN FORMAPAGO fp ON fp.IdFPago = cp.IdFPago " &
            "    WHERE cp.IDCOMPRAS = ch.IDCOMPRAS AND ISNULL(cp.Pagado, 0) = 0 " &
            "    ORDER BY cp.FECHA_VCTO " &
            ") pend " &
            "WHERE ch.RUT = '" & txt_RutProveedor.Text & "' " &
            "ORDER BY CONVERT(char, ch.FECHA_DOC, 112)"
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
                DataCartola.Rows(i).Cells(7).Value = datatbl(7)
                DataCartola.Rows(i).Cells(8).Value = datatbl(8)
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