Public Class Plan_Cuentas

    Private Sub Plan_Cuentas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Buscar_Cuenta()
    End Sub
    Private Sub Buscar_Cuenta()
        Dim i As Integer
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
                DataPlan.Rows(i).Cells(3).Value = datatbl(6)
              
                i += 1
            End While
        End If
        close_conexion()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Variable gQuienLlama
        '0 = Analisis de Cuenta
        '1 = Comprobante Contable
        Dim iFilaActual As Integer
        iFilaActual = DataPlan.CurrentCell.RowIndex

        Select Case gQuienLlama
            Case 0
                Analisis_Cuenta.txt_Cta_Ctble.Text = DataPlan.Rows(iFilaActual).Cells(0).Value
                Analisis_Cuenta.txt_DescripCuenta.Text = DataPlan.Rows(iFilaActual).Cells(1).Value
            Case 1
        End Select
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class