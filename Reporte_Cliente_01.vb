Imports System.Data.SqlClient
Public Class Reporte_Cliente_01


    Private Sub Reporte_Cliente_01_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        close_conexion()
        Me.Close()
    End Sub

    Private Sub Reporte_Cliente_01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetContaCmbte.SP_CONSULTA_CLIENTE_SINVENTAS' Puede moverla o quitarla según sea necesario.
        Me.SP_CONSULTA_CLIENTE_SINVENTASTableAdapter.Connection.ConnectionString = gSOURCE
       
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.SP_CONSULTA_CLIENTE_SINVENTASTableAdapter.Fill(Me.DataSetContaCmbte.SP_CONSULTA_CLIENTE_SINVENTAS, Format(txt_Fecha1.Value, "d"))
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class