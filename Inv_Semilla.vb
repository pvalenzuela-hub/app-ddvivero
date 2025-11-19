Public Class Inv_Semilla

    Private Sub Inv_Semilla_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetReporteInventario.SP_Reporte_INV_Semilla' Puede moverla o quitarla según sea necesario.
        Me.SP_Reporte_INV_SemillaTableAdapter.Connection.ConnectionString = gSOURCE
     
    End Sub
    Private Sub Genera_Consulta()
        
        Dim iTipo As Integer

        If RadioButton1.Checked = True Then
            iTipo = 0
        End If

        If RadioButton2.Checked = True Then
            iTipo = 1
        End If

        Me.SP_Reporte_INV_SemillaTableAdapter.Fill(Me.DataSetReporteInventario.SP_Reporte_INV_Semilla, iTipo)

        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Genera_Consulta()

    End Sub
End Class