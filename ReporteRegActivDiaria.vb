Public Class ReporteRegActivDiaria

    Private Sub ReporteRegActivDiaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetReporteInventario.SP_ConsultaRegistroActivDiaria' Puede moverla o quitarla según sea necesario.
        'Me.SP_ConsultaRegistroActivDiariaTableAdapter.Fill(Me.DataSetReporteInventario.SP_ConsultaRegistroActivDiaria)
        'TODO: esta línea de código carga datos en la tabla 'DataSetReporteInventario.SP_ConsultaRegistroActivDiaria' Puede moverla o quitarla según sea necesario.
        Me.SP_ConsultaRegistroActivDiariaTableAdapter.Connection.ConnectionString = gSOURCE


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iEstado As Integer
        If CheckBox1.Checked = True Then
            iEstado = 0
        Else
            iEstado = 99
        End If

        Me.SP_ConsultaRegistroActivDiariaTableAdapter.Fill(Me.DataSetReporteInventario.SP_ConsultaRegistroActivDiaria, Format(DateTimePicker1.Value, "d"), Format(DateTimePicker2.Value, "d"), iEstado)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class