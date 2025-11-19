Public Class Flujo_DocVentaNoDocumentado
    Dim sRUTClienteFiltro As String = ""
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Genera_Consulta()
    End Sub
    Private Sub Genera_Consulta()
        Dim i As Integer


        Dim dTotalClienteDocumentos As Double = 0
        Dim dTotalClienteCHLE As Double = 0
        Dim dTotalClienteAbonoPedido As Double = 0
        Dim dTotalClienteDeudaTotal As Double = 0

        Dim dTotalGeneralDocumentos As Double = 0
        Dim dTotalGeneralCHLE As Double = 0
        Dim dTotalGeneralAbonoPedido As Double = 0
        Dim dTotalGeneralDeudaTotal As Double = 0
        Dim iCorte As Integer = 0
        sSsql = "SP_CONSULTA_Flujo_DocVenta_Pendiente '" & dtp_FechaVcto.Value & "',"
        If txt_RUT_CLI.Text = Nothing Then
            sSsql += "'',"
        Else
            sSsql += "'" & sRUTClienteFiltro & "',"
        End If
        If chk_Vendedor.Checked Then
            sSsql += "'" & cmb_Vendedor.Text & "'"
        Else
            sSsql += "Null"
        End If
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        DataGrilla.Rows.Clear()
        If datatbl.HasRows Then
            i = 0
            While datatbl.Read
                If iCorte <> datatbl(0) Then
                    REM resumen deuda cliente
                    iCorte = datatbl(0)
                    If dTotalClienteDeudaTotal > 0 AndAlso (i - 1) >= 0 Then
                        'dTotalClienteDeudaTotal -= dTotalClienteAbonoPedido
                        DataGrilla.Rows.Add()
                        DataGrilla.Rows(i).Cells(2).Value = "Saldo Facturas/Boletas:"
                        DataGrilla.Rows(i).Cells(3).Value = Format(dTotalClienteDocumentos, "###,###,###")
                        DataGrilla.Rows(i).Cells(4).Value = "Ch/Le por Cobrar:"
                        DataGrilla.Rows(i).Cells(5).Value = Format(dTotalClienteCHLE, "###,###,###")
                        DataGrilla.Rows(i).Cells(6).Value = "Saldo Abonos:"
                        DataGrilla.Rows(i).Cells(7).Value = Format(dTotalClienteAbonoPedido, "###,###,###")
                        DataGrilla.Rows(i).Cells(8).Value = Format(dTotalClienteDeudaTotal, "###,###,###")
                        DataGrilla.Rows(i).DefaultCellStyle.BackColor = Color.Red
                        DataGrilla.Rows(i).DefaultCellStyle.ForeColor = Color.White
                        DataGrilla.Rows(i).DefaultCellStyle.Font = New Font(DataGrilla.Font, FontStyle.Bold)
                        i += 1
                        dTotalGeneralDocumentos += dTotalClienteDocumentos
                        dTotalGeneralCHLE += dTotalClienteCHLE
                        dTotalGeneralAbonoPedido += dTotalClienteAbonoPedido
                        dTotalGeneralDeudaTotal += dTotalClienteDeudaTotal
                        dTotalClienteDocumentos = 0
                        dTotalClienteDeudaTotal = 0
                        dTotalClienteCHLE = 0
                        dTotalClienteAbonoPedido = 0

                    Else
                        If i > 0 Then
                            DataGrilla.Rows(i - 1).DefaultCellStyle.BackColor = Color.Green
                            DataGrilla.Rows(i - 1).DefaultCellStyle.ForeColor = Color.WhiteSmoke
                        End If
                    End If
                End If

                DataGrilla.Rows.Add()
                DataGrilla.Rows(i).Cells(0).Value = datatbl(4)
                DataGrilla.Rows(i).Cells(1).Value = datatbl(5)
                DataGrilla.Rows(i).Cells(2).Value = datatbl(6)
                DataGrilla.Rows(i).Cells(3).Value = datatbl(7)
                DataGrilla.Rows(i).Cells(4).Value = RTrim(datatbl(1)) & " " & RTrim(datatbl(2))
                DataGrilla.Rows(i).Cells(5).Value = Format(Val(Mid(datatbl(3), 1, 11)), "##,###,###,###") & "-" & Mid(datatbl(3), 12, 1)
                DataGrilla.Rows(i).Cells(6).Value = Format(datatbl(8), "###,###,###")
                DataGrilla.Rows(i).Cells(7).Value = Format(datatbl(9), "###,###,###")
                DataGrilla.Rows(i).Cells(8).Value = Format(datatbl(10), "###,###,###")
                DataGrilla.Rows(i).Cells(9).Value = datatbl(14)
                DataGrilla.Rows(i).Cells(10).Value = RTrim(datatbl(15)) & " " & RTrim(datatbl(16)) & " " & RTrim(datatbl(17))
                DataGrilla.Rows(i).Cells(11).Value = datatbl(18)
                DataGrilla.Rows(i).Cells(12).Value = datatbl(19)

                dTotalClienteDocumentos += datatbl(10)
                dTotalClienteAbonoPedido = datatbl("Saldo_Abonos")
                dTotalClienteCHLE = datatbl(12)
                dTotalClienteDeudaTotal += datatbl("Saldo")
                i += 1
            End While
            If DataGrilla.Rows.Count - 1 < i Then
                'dTotalClienteDeudaTotal -= dTotalClienteAbonoPedido
                DataGrilla.Rows.Add()
                DataGrilla.Rows(i).Cells(2).Value = "Saldo Facturas/Boletas:"
                DataGrilla.Rows(i).Cells(3).Value = Format(dTotalClienteDocumentos, "###,###,###")
                DataGrilla.Rows(i).Cells(4).Value = "Ch/Le por Cobrar:"
                DataGrilla.Rows(i).Cells(5).Value = Format(dTotalClienteCHLE, "###,###,###")
                DataGrilla.Rows(i).Cells(6).Value = "Saldo Abonos:"
                DataGrilla.Rows(i).Cells(7).Value = Format(dTotalClienteAbonoPedido, "###,###,###")
                DataGrilla.Rows(i).Cells(8).Value = Format(dTotalClienteDeudaTotal, "###,###,###")
                DataGrilla.Rows(i).DefaultCellStyle.BackColor = Color.Red
                DataGrilla.Rows(i).DefaultCellStyle.ForeColor = Color.White
                DataGrilla.Rows(i).DefaultCellStyle.Font = New Font(DataGrilla.Font, FontStyle.Bold)
                dTotalGeneralDocumentos += dTotalClienteDocumentos
                dTotalGeneralCHLE += dTotalClienteCHLE
                dTotalGeneralAbonoPedido += dTotalClienteAbonoPedido
                dTotalGeneralDeudaTotal += dTotalClienteDeudaTotal
            End If
        End If
        close_conexion()

        txtSaldoFactura.Text = Format(dTotalGeneralDocumentos, "###,###,###")
        txtSaldoAbono.Text = Format(dTotalGeneralAbonoPedido, "###,###,###")
        txtDeudaGeneral.Text = Format(dTotalGeneralDeudaTotal, "###,###,###")
    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cmb_clientebuscar.Items.Clear()
        Buscar_Cliente(Me.cmb_clientebuscar, Me.txt_clientebuscar.Text)
        txt_RUT_CLI.Text = Nothing
    End Sub

    Private Sub cmb_clientebuscar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_clientebuscar.SelectedIndexChanged

        If cmb_clientebuscar.SelectedIndex > -1 Then
            txt_RUT_CLI.Text = Format(Val(Mid(zRut(Me.cmb_clientebuscar.SelectedIndex), 1, 11)), "##,###,###,###") & "-" & Mid(zRut(Me.cmb_clientebuscar.SelectedIndex), 12, 1)
            txt_NOM_CLI.Text = Me.cmb_clientebuscar.Text
            sRUTClienteFiltro = zRut(Me.cmb_clientebuscar.SelectedIndex)
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        txt_clientebuscar.Clear()
        txtDeudaGeneral.Clear()
        txt_NOM_CLI.Clear()
        txtSaldoAbono.Clear()
        txt_RUT_CLI.Clear()
        txtSaldoFactura.Clear()
        dtp_FechaVcto.Value = Date.Now
        DataGrilla.Rows.Clear()
        cmb_clientebuscar.SelectedIndex = -1

    End Sub

    Private Sub Flujo_DocVentaNoDocumentado_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Carga_lista_Vendedor(Me.cmb_Vendedor)

    End Sub

    Private Sub chk_Vendedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Vendedor.CheckedChanged
        If chk_Vendedor.Checked Then
            cmb_Vendedor.Enabled = True
        Else
            cmb_Vendedor.Enabled = False
        End If
    End Sub
End Class