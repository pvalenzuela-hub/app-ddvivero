Public Class Analisis_Cuenta
    Dim dSaldoInicial As Double
    Private Sub BTN_BUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR.Click
        gQuienLlama = 0
        Plan_Cuentas.Visible = True
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Consulta_Cuenta_Detalle()
        EjecutaConsulta()
    End Sub

    Private Sub EjecutaConsulta()
        Dim i As Integer = 0
        Dim dTotalDebe As Double = 0
        Dim dTotalHaber As Double = 0
        Dim dSaldoCuenta As Double = 0
        Dim dTotalAcumDebe As Double = 0
        Dim dTotalAcumHaber As Double = 0
        Dim dSaldoFinal As Double = 0

        Dim sRut As String

        If chkFiltro.Checked Then
            If txt_RutCliente.Text = Nothing Or txt_RutCliente.Text = "" Then
                sRut = "'" + txtRutProv.Text + "'"
            Else
                sRut = "'" + txt_RutCliente.Text + "'"
            End If
        Else
            sRut = "Null"
        End If

        sSsql = "SP_CONTA_AnalisisCuenta "
        sSsql += "'" + txt_Cta_Ctble.Text + "',"
        sSsql += "'" + Format(dtp_Fecha1.Value, "d") + "',"
        sSsql += "'" + Format(dtp_Fecha2.Value, "d") + "',"
        sSsql += sRut

        DataAnalisis.Rows.Clear()

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            While datatbl.Read
                txt_DescripCuenta.Text = datatbl(12)
                dTotalDebe += datatbl(4)
                dTotalHaber += datatbl(5)
                dSaldoCuenta += datatbl(4) - datatbl(5)
                DataAnalisis.Rows.Add()
                DataAnalisis.Rows(i).Cells(0).Value = datatbl(1)
                DataAnalisis.Rows(i).Cells(1).Value = datatbl(11)
                DataAnalisis.Rows(i).Cells(2).Value = datatbl(2)
                DataAnalisis.Rows(i).Cells(3).Value = datatbl(3)
                DataAnalisis.Rows(i).Cells(4).Value = Format(datatbl(4), "###,###,###")
                DataAnalisis.Rows(i).Cells(5).Value = Format(datatbl(5), "###,###,###")
                If dSaldoCuenta < 0 Then
                    DataAnalisis.Rows(i).Cells(6).Value = Format(Math.Abs(dSaldoCuenta), "CR ###,###,###")
                Else
                    DataAnalisis.Rows(i).Cells(6).Value = Format(dSaldoCuenta, "DB ###,###,###")
                End If
                DataAnalisis.Rows(i).Cells(7).Value = datatbl(6)
                DataAnalisis.Rows(i).Cells(8).Value = datatbl(7)
                DataAnalisis.Rows(i).Cells(9).Value = datatbl(8)
                DataAnalisis.Rows(i).Cells(10).Value = datatbl(9)
                DataAnalisis.Rows(i).Cells(11).Value = datatbl(10)
                dTotalAcumDebe = datatbl(13)
                dTotalAcumHaber = datatbl(14)
                i += 1

            End While
            btnReporte.Enabled = True
        Else
            MsgBox("No Existen Datos para la Consulta.", MsgBoxStyle.Information)
            btnReporte.Enabled = False
        End If
        close_conexion()

        txtTotalDebe.Text = Format(dTotalDebe, "###,###,###")
        txtTotalHaber.Text = Format(dTotalHaber, "###,###,###")
        dSaldoCuenta += dSaldoInicial
        If dSaldoCuenta < 0 Then
            txtSaldoPeriodo.Text = Format(Math.Abs(dSaldoCuenta), "CR ###,###,###")
        Else
            txtSaldoPeriodo.Text = Format(dSaldoCuenta, "DB ###,###,###")
        End If
        dSaldoFinal = dTotalAcumDebe - dTotalAcumHaber
        If dSaldoFinal < 0 Then
            txt_SaldoCuenta.Text = Format(Math.Abs(dSaldoFinal), "CR ###,###,###")
        Else
            txt_SaldoCuenta.Text = Format(dSaldoFinal, "DB ###,###,###")
        End If
        txt_TotalDEBECTA.Text = Format(dTotalAcumDebe, "###,###,###")
        txt_TotalHABERCTA.Text = Format(dTotalAcumHaber, "###,###,###")

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        gNOMBRE = txt_clientebuscar.Text
        gQuienLlama = 10
        BusquedaCliente.Visible = True

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        txt_clientebuscar.Clear()
        txt_RutCliente.Clear()
        txtCliente.Clear()
        txtprovbuscar.Clear()
        txtRutProv.Clear()
        txtNombreProv.Clear()
        txt_Cta_Ctble.Clear()
        dtp_Fecha1.Value = Now
        dtp_Fecha2.Value = Now
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        gNOMBRE = txtprovbuscar.Text
        gQuienLlama = 5
        Busqueda_Proveedor.Visible = True
    End Sub

    Private Sub chkFiltro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltro.CheckedChanged
        If chkFiltro.Checked = True Then
            grpfiltro.Enabled = True
        Else
            grpfiltro.Enabled = False
        End If
    End Sub

    Private Sub rdbCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCliente.CheckedChanged
        If rdbCliente.Checked = True Then
            txtNombreProv.Clear()
            txtRutProv.Clear()
        End If
    End Sub

    Private Sub rdbProveedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbProveedor.CheckedChanged
        If rdbProveedor.Checked = True Then
            txt_RutCliente.Clear()
            txtCliente.Clear()
        End If
    End Sub

    Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click
        If chkFiltro.Checked = False Then
            RepEstadoCuentaContable.Visible = True
        End If
    End Sub

    Private Sub dtp_Fecha1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Fecha1.ValueChanged

    End Sub

    Private Sub Analisis_Cuenta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtp_Fecha2.Value = Now

        'Carga_Centro_Costo(cmbCCosto)

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        txt_Cta_Ctble.Clear()
        txt_DescripCuenta.Clear()
        txt_RutCliente.Clear()
        'txt_Saldo_Inicial.Clear()
        txt_SaldoCuenta.Clear()
        txt_TotalDEBECTA.Clear()
        txt_TotalHABERCTA.Clear()
        txtRutProv.Clear()
        'cmbCCosto.SelectedIndex = -1
        dtp_Fecha1.Value = Date.Now
        dtp_Fecha2.Value = Date.Now
        chkFiltro.Checked = False
        DataAnalisis.Rows.Clear()
        txtTotalDebe.Clear()
        txtTotalHaber.Clear()
        txtSaldoPeriodo.Clear()
    End Sub
End Class