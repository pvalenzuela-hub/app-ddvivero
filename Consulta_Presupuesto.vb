Public Class Consulta_Presupuesto

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

   

    Private Sub Consulta_Presupuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetContaCmbte.SP_CONSULTA_Presupuesto' Puede moverla o quitarla según sea necesario.
        Me.SP_CONSULTA_PresupuestoTableAdapter.Connection.ConnectionString = gSOURCE


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.SP_CONSULTA_PresupuestoTableAdapter.Fill(Me.DataSetContaCmbte.SP_CONSULTA_Presupuesto, Format(txt_Fecha1.Value, "d"))
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class