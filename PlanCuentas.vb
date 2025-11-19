Public Class PlanCuentas

    REM variables publicas del formulario

  

    Private Sub PlanCuentas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaPlanCuentas()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Limpia_Campos()
    End Sub
    Private Sub Limpia_Campos()
        txt_Cta_Ctble.Clear()
        txt_Descrip.Clear()
        txt_ReferTipo.Clear()
        txt_SaldoDebe.Clear()
        txt_SaldoHaber.Clear()
        txt_SaldoInicial.Clear()
        cmb_TipoCta.SelectedIndex = -1
        cmb_SaldoDiario.SelectedIndex = -1
    End Sub

    Private Sub CargaPlanCuentas()
        Dim i As Integer

        DataPlan.Rows.Clear()

        sSsql = "SP_CONSULTA_CONTA_PlanCuentas"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            While datatbl.Read = True
                DataPlan.Rows.Add()
                DataPlan.Rows(i).Cells(0).Value = datatbl(0)
                DataPlan.Rows(i).Cells(1).Value = datatbl(1)
                DataPlan.Rows(i).Cells(2).Value = datatbl(2)
                DataPlan.Rows(i).Cells(3).Value = Format(datatbl(3), "###,###,##0")
                DataPlan.Rows(i).Cells(4).Value = Format(datatbl(4), "###,###,##0")
                DataPlan.Rows(i).Cells(5).Value = Format(datatbl(5), "###,###,##0")
                DataPlan.Rows(i).Cells(6).Value = datatbl(6)
                DataPlan.Rows(i).Cells(7).Value = datatbl(7)
                i += 1
            End While
        End If
        close_conexion()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ModificaCuenta()
    End Sub

    Private Sub ModificaCuenta()
        Dim FilaGrilla As Integer
        FilaGrilla = DataPlan.CurrentRow.Index
        'txt_idfamilia.Text = DataGrilla.Rows(FilaGrilla).Cells(0).Value
        txt_Cta_Ctble.Text = DataPlan.Rows(FilaGrilla).Cells(0).Value
        txt_Descrip.Text = DataPlan.Rows(FilaGrilla).Cells(1).Value
        cmb_TipoCta.Text = DataPlan.Rows(FilaGrilla).Cells(2).Value
        txt_SaldoInicial.Text = Val(DataPlan.Rows(FilaGrilla).Cells(3).Value)
        txt_SaldoDebe.Text = Val(DataPlan.Rows(FilaGrilla).Cells(4).Value)
        txt_SaldoHaber.Text = Val(DataPlan.Rows(FilaGrilla).Cells(5).Value)
        txt_ReferTipo.Text = DataPlan.Rows(FilaGrilla).Cells(6).Value
        cmb_SaldoDiario.Text = DataPlan.Rows(FilaGrilla).Cells(7).Value
        txt_Descrip.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        EliminaCuenta()
    End Sub

    Private Sub EliminaCuenta()
        Dim sResp As String
        Dim sCtaCtble As String
        Dim FilaGrilla As Integer
        sResp = InputBox("Confirmación de Eliminación de Cuenta Contable", "Eliminación de Cuenta Contable", "S")
        If UCase(sResp) = "S" Then
            FilaGrilla = DataPlan.CurrentRow.Index
            sCtaCtble = DataPlan.Rows(FilaGrilla).Cells(0).Value
            If sCtaCtble = "" Or Val(sCtaCtble) = 0 Then
                MsgBox("Cuenta Contable no es válida. Debe Seleccionar Cuenta a Eliminar.")
                Exit Sub
            End If
            sSsql = "SP_EliminaCONTA_Cuenta "
            'idFamilia numeric(18,0)
            sSsql += "'" + sCtaCtble + "'"
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                datatbl.Read()
                If datatbl(0) = -1 Then
                    MsgBox("No ha sido posible Eliminar Cuenta: " & sCtaCtble & ". Cuenta está en uso en Comprobantes")
                End If
            End If
            close_conexion()
            CargaPlanCuentas()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ActualizarCuenta()
    End Sub

    Private Sub ActualizarCuenta()
        sSsql = "SP_ActualizaCONTA_CtaCtble "
        'idFamilia numeric(18,0),
        sSsql += "'" + txt_Cta_Ctble.Text + "',"
        sSsql += "'" + txt_Descrip.Text + "',"
        sSsql += "'" + cmb_TipoCta.Text + "',"
        sSsql += txt_SaldoInicial.Text.ToString + ","
        sSsql += txt_ReferTipo.Text.ToString + ","
        sSsql += "'" + cmb_SaldoDiario.Text + "'"

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()
        close_conexion()
        CargaPlanCuentas()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class