Public Class Reporte_Costo_Planta

    Private Sub Reporte_Costo_Planta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetReporteInventario.SP_ReportePreciosEspecie' Puede moverla o quitarla según sea necesario.
        'Me.SP_ReportePreciosEspecieTableAdapter.Fill(Me.DataSetReporteInventario.SP_ReportePreciosEspecie)
        ''TODO: esta línea de código carga datos en la tabla 'DataSetReporteInventario.SP_ReportePreciosEspecie' Puede moverla o quitarla según sea necesario.
        'Me.SP_ReportePreciosEspecieTableAdapter.Fill(Me.DataSetReporteInventario.SP_ReportePreciosEspecie)
        'TODO: esta línea de código carga datos en la tabla 'DataSetReporteInventario.SP_ReportePreciosEspecie' Puede moverla o quitarla según sea necesario.
        Me.SP_ReportePreciosEspecieTableAdapter.Connection.ConnectionString = gSOURCE
        Carga_Familia_Prod(Me.cmb_Familia)
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If cmb_Familia.SelectedIndex = -1 Then
            MsgBox("Seleccione Especie", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Me.SP_ReportePreciosEspecieTableAdapter.Fill(Me.DataSetReporteInventario.SP_ReportePreciosEspecie, cmb_Familia.Text, Format(DateTimePicker1.Value, "d"), Format(DateTimePicker2.Value, "d"))
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class