Public Class RepEstadoCuentaContable

    Private Sub RepEstadoCuentaContable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim sCtaCtble As String
        Dim dFecha1 As Date
        Dim dFecha2 As Date

        sCtaCtble = Analisis_Cuenta.txt_Cta_Ctble.Text
        dFecha1 = Analisis_Cuenta.dtp_Fecha1.Value
        dFecha2 = Analisis_Cuenta.dtp_Fecha2.Value


        Dim sRut As String

        'If Analisis_Cuenta.cmbCCosto.SelectedIndex = -1 Then
        '    sCentroCosto = Nothing
        'Else
        '    sCentroCosto = Analisis_Cuenta.cmbCCosto.Text
        'End If

        If Analisis_Cuenta.chkFiltro.Checked Then
            If Analisis_Cuenta.txt_RutCliente.Text = Nothing OrElse Analisis_Cuenta.txt_RutCliente.Text = "" Then
                sRut = Analisis_Cuenta.txtRutProv.Text
            Else
                sRut = Analisis_Cuenta.txt_RutCliente.Text
            End If
        Else
            sRut = Nothing
        End If

        Me.SP_ReporteCartolaContableTableAdapter.Connection.ConnectionString = gSOURCE
        Me.SP_ReporteCartolaContableTableAdapter.Fill(Me.GESTDataSet50.SP_ReporteCartolaContable, sCtaCtble, dFecha1, dFecha2, "NULL", sRut, gUSER)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class