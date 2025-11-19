Public Class RepCarga

    Private Sub RepCarga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSetRepDesp.SP_ReporteVentaMensual' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'GESTDataSetRepDesp.SP_RepDespachoIdDesp' Puede moverla o quitarla según sea necesario.
        Me.SP_RepDespachoIdDespTableAdapter.Connection.ConnectionString = gSOURCE
        Me.SP_RepDespachoIdDespTableAdapter.Fill(Me.GESTDataSetRepDesp.SP_RepDespachoIdDesp, Despacho.txtNumDesp.Text, 1)
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSetRepDesp.SP_RepDespachoIdDesp' Puede moverla o quitarla según sea necesario.
        'Me.SP_RepDespachoIdDespTableAdapter.Connection.ConnectionString = gSOURCE

        'Me.SP_RepDespachoIdDespTableAdapter.Fill(Me.GESTDataSetRepDesp.SP_RepDespachoIdDesp, Despacho.txtNumDesp.Text, 1)

        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet33.SP_RepDespachoIdDesp' Puede moverla o quitarla según sea necesario.
        'Me.SP_RepDespachoIdDespTableAdapter.Connection.ConnectionString = gSOURCE
        'Me.SP_RepDespachoIdDespTableAdapter.Fill(Me.GESTDataSet33.SP_RepDespachoIdDesp, Despacho.txtNumDesp.Text, 2)
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class