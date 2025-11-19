Public Class RepLotConf

    Private Sub RepLotConf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSetReporteLotConf.SP_RepLotConf' Puede moverla o quitarla según sea necesario.

        Me.SP_RepLotConfTableAdapter.Connection.ConnectionString = gSOURCE
        Me.SP_RepLotConfTableAdapter.Fill(Me.GESTDataSetReporteLotConf.SP_RepLotConf, PrepDespLote.dtpFecRepLotesConf.Value)
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSetRepCtlDesp.SP_ConsultaCtlDesp' Puede moverla o quitarla según sea necesario.
        'Me.SP_ConsultaCtlDespTableAdapter.Connection.ConnectionString = gSOURCE
        'Me.SP_ConsultaCtlDespTableAdapter.Fill(Me.GESTDataSetRepCtlDesp.SP_ConsultaCtlDesp, PrepDespLote.dtpFecRepLotesConf.Value)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class