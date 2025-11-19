Public Class Cierra_Diario
    Dim dSaldoAcum As Double = 0
    Dim dSaldoFinal As Double = 0
    Private Sub Cierra_Diario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Carga_Cuenta_Diaria(Me.cmb_Cta_Ctble)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cmb_Cta_Ctble.SelectedIndex > -1 Then
            Consulta_Movimientos()
        End If
    End Sub
    Private Sub Consulta_Movimientos()
        Dim i As Integer = 0

        Dim dSaldoInicial As Double = 0
        Dim dIngresos As Double = 0
        Dim dEgresos As Double = 0


        dSaldoAcum = 0
        dSaldoFinal = 0

        GrillaCaja.Rows.Clear()

        sSsql = "SP_CONSULTA_CONTA_Saldosdiarios "
        sSsql += "'" + cmb_Cta_Ctble.SelectedItem + "',"
        sSsql += "'" + Format(dtp_FechaApertura.Value, "d") + "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            txt_Cta_Ctble.Text = datatbl(0)
            dSaldoInicial = datatbl(1)
            btn_GrabaCierre.Enabled = True
        Else
            MsgBox("Esta Cuenta no tiene Apertura para la Fecha Seleccionada.", MsgBoxStyle.Exclamation, "Cierre Diario")
            btn_GrabaCierre.Enabled = False
        End If
        close_conexion()
        GrillaCaja.Rows.Clear()
        'GrillaCaja.Rows.Add()
        'GrillaCaja.Rows(i).Cells(0).Value = "SALDO INICIAL"
        'GrillaCaja.Rows(i).Cells(3).Value = Format(dSaldoInicial, "###,###,###")
        'i += 1
        'dSaldoAcum = dSaldoInicial

        sSsql = "SP_CONSULTA_CONTA_Movto_Diario "
        sSsql += "'" + txt_Cta_Ctble.Text + "',"
        sSsql += "'" + Format(dtp_FechaApertura.Value, "d") + "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            While datatbl.Read
                dSaldoAcum += datatbl(1) - datatbl(2)
                dIngresos += datatbl(1)
                dEgresos += datatbl(2)
                GrillaCaja.Rows.Add()
                GrillaCaja.Rows(i).Cells(0).Value = datatbl(0)
                GrillaCaja.Rows(i).Cells(1).Value = Format(datatbl(1), "###,###,###")
                GrillaCaja.Rows(i).Cells(2).Value = Format(datatbl(2), "###,###,###")
                GrillaCaja.Rows(i).Cells(3).Value = Format(dSaldoAcum, "###,###,###")
                i += 1
            End While
        End If
        close_conexion()


        'sSsql = "SP_CONSULTA_CONTA_Saldosdiarios "
        'sSsql += "'" + cmb_Cta_Ctble.SelectedItem + "',"
        'sSsql += "'" + Format(dtp_FechaApertura.Value, "d") + "'"
        'open()
        'command = connection.CreateCommand()
        'command.CommandText = sSsql
        'datatbl = command.ExecuteReader()
        'If datatbl.HasRows Then
        '    datatbl.Read()
        '    txt_Cta_Ctble.Text = datatbl(0)
        '    dSaldoFinal = datatbl(2)
        '    If dSaldoFinal > 0 Then
        '        GrillaCaja.Rows.Add()
        '        GrillaCaja.Rows(i).Cells(0).Value = "SALDO FINAL"
        '        GrillaCaja.Rows(i).Cells(3).Value = Format(dSaldoFinal, "###,###,###")
        '    End If
        'End If
        'close_conexion()
        dSaldoFinal = dSaldoAcum + dSaldoInicial

        txt_Total_Ingresos.Text = Format(dIngresos, "###,###,###")
        txt_Total_Egresos.Text = Format(dEgresos, "###,###,###")
        txt_Saldo_Diario.Text = Format(dIngresos - dEgresos, "###,###,###")
        txt_Saldo_Inicial.Text = Format(dSaldoInicial, "###,###,###")
        txt_SaldoFinalDiario.Text = Format(dSaldoFinal, "###,###,###")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Private Sub btn_GrabaCierre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GrabaCierre.Click
        Graba_Cierre_Diario()
    End Sub
    Private Sub Graba_Cierre_Diario()
        sSsql = "SP_CONTA_CierrediarioCuenta "
        sSsql += "'" + txt_Cta_Ctble.Text + "',"
        sSsql += "'" + Format(dtp_FechaApertura.Value, "d") + "',"
        sSsql += dSaldoFinal.ToString
        open()
        command = connection.CreateCommand
        command.CommandText = sSsql
        command.ExecuteNonQuery()
        close_conexion()
        MsgBox("Cierre Diario ha sido guardado.", MsgBoxStyle.Information, "Cierre Diario")
        Me.Close()
    End Sub
End Class