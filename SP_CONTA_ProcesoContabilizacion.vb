Public Class SP_CONTA_ProcesoContabilizacion

    Private Sub txt_MesProceso_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_MesProceso.ValueChanged
        ' setear año de proceso
        txt_AgnoProceso.Minimum = gPeriodoContable
        txt_AgnoProceso.Maximum = Year(Now)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txt_AgnoProceso.Value = 0 Then
            MsgBox("Debe Ingresar Año de Proceso Contable")
            Exit Sub
        End If

        Contabiliza_Mes()
        MsgBox("Fin Proceso de Actualización.")


    End Sub
    Private Sub Contabiliza_Mes()
        sSsql = "SP_CONTA_ProcesoContabilizacion "
        sSsql += txt_MesProceso.Value.ToString + ","
        sSsql += txt_AgnoProceso.Value.ToString

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()
        close_conexion()
    End Sub

    Private Sub SP_CONTA_ProcesoContabilizacion_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class