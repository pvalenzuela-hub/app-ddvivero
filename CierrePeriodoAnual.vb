Public Class CierrePeriodoAnual
    Private Sub CierrePeriodoAnual_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim AgnoActual As Integer
        AgnoActual = Now.Year

        txtPeriodo.Maximum = AgnoActual - 1
        txtPeriodo.Value = AgnoActual - 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub EjecutaProceso()
        sSsql = "[vivero].[SP_CONTA_CierrePeriodoContable] "
        sSsql += txtPeriodo.Value.ToString()

        open()
        Try
            command = connection.CreateCommand()
            command.CommandText = sSsql
            command.ExecuteNonQuery()
            MsgBox("Apertura de Año " & txtPeriodo.Value.ToString() & " ha termindo correctamente")
            btnProceso.Enabled = True
        Catch ex As Exception
            MsgBox("Ha ocurrido un error en el proceso de Apertura ")
        End Try
        close_conexion()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnProceso.Click
        btnProceso.Enabled = False
        EjecutaProceso()
    End Sub
End Class