Public Class ConsultaCuentaGestion

    Private Sub ConsultaCuentaGestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetContaCmbte.SP_Consulta_CuentasGestionCC' Puede moverla o quitarla según sea necesario.
        '  Me.SP_Consulta_CuentasGestionCCTableAdapter.Connection.ConnectionString = gSOURCE

        '  Me.SP_Consulta_CuentasGestionCCTableAdapter.Fill(Me.DataSetContaCmbte.SP_Consulta_CuentasGestionCC)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class