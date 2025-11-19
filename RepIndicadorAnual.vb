Public Class RepIndicadorAnual
    Private Sub RepIndicadorAnual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet19.SP_ReporteIndicadorPlantasRetiradas_Agno' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'DataSetCompras.SP_CONSULTA_Vencto_Doc_Compra' Puede moverla o quitarla según sea necesario.

        Me.SP_ReporteIndicadorPlantasRetiradas_AgnoTableAdapter.Connection.ConnectionString = gSOURCE

        Dim yagno As Integer = Year(Date.Now)
        cmbPeriodo.Items.Add(yagno)
        cmbPeriodo.Items.Add(yagno - 1)
        cmbPeriodo.Items.Add(yagno - 2)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (cmbPeriodo.SelectedIndex > -1) And Val(txtComision.Text) > 0 Then

            Me.SP_ReporteIndicadorPlantasRetiradas_AgnoTableAdapter.Fill(Me.GESTDataSet19.SP_ReporteIndicadorPlantasRetiradas_Agno, cmbPeriodo.SelectedItem, txtComision.Text)
            Me.ReportViewer1.RefreshReport()

        End If
    End Sub
End Class