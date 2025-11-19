Public Class Reporte_Plantas_Entregadas

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.SP_PanelControl_PlantasEntregadasTableAdapter.Fill(Me.DataSetReporteInventario.SP_PanelControl_PlantasEntregadas, Format(DateTimePicker1.Value, "d"), Format(DateTimePicker2.Value, "d"))
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Reporte_Plantas_Entregadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetReporteInventario.SP_PanelControl_PlantasEntregadas' Puede moverla o quitarla según sea necesario.
        'Me.SP_PanelControl_PlantasEntregadasTableAdapter.Fill(Me.DataSetReporteInventario.SP_PanelControl_PlantasEntregadas)
        Me.SP_PanelControl_PlantasEntregadasTableAdapter.Connection.ConnectionString = gSOURCE

    End Sub
End Class