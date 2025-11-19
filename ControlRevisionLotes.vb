Public Class ControlRevisionLotes

    Private Sub ControlRevisionLotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetReporteInventario.SP_Reporte_CTL_LoteCheck' Puede moverla o quitarla según sea necesario.
        ' Me.SP_Reporte_CTL_LoteCheckTableAdapter.Fill(Me.DataSetReporteInventario.SP_Reporte_CTL_LoteCheck)
        'TODO: esta línea de código carga datos en la tabla 'DataSetReporteInventario.SP_Reporte_CTL_LoteCheck' Puede moverla o quitarla según sea necesario.
        ' Me.SP_Reporte_CTL_LoteCheckTableAdapter.Fill(Me.DataSetReporteInventario.SP_Reporte_CTL_LoteCheck)
        'TODO: esta línea de código carga datos en la tabla 'DataSetReporteInventario.SP_Reporte_CTL_LoteCheck' Puede moverla o quitarla según sea necesario.
        Me.SP_Reporte_CTL_LoteCheckTableAdapter.Connection.ConnectionString = gSOURCE

        Carga_CTL_Lote_ComboBox(Me.cmb_CTL_Entrega, "CTL01")
        Carga_CTL_Lote_ComboBox(Me.cmb_CTL_Cliente, "CTL02")
        Carga_CTL_Lote_ComboBox(Me.cmb_CTL_Enfermedades, "CTL03")
        Carga_CTL_Lote_ComboBox(Me.cmb_CTL_Observaciones, "CTL04")


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sCTL_Entrega As String
        Dim sCTL_Cliente As String
        Dim sCTL_Enfermedad As String
        Dim sCTL_Observacion As String

        If cmb_CTL_Entrega.SelectedIndex > 0 Then
            sCTL_Entrega = cmb_CTL_Entrega.Text
        Else
            sCTL_Entrega = ""
        End If

        If cmb_CTL_Cliente.SelectedIndex > 0 Then
            sCTL_Cliente = cmb_CTL_Cliente.Text
        Else
            sCTL_Cliente = ""
        End If

        If cmb_CTL_Enfermedades.SelectedIndex > 0 Then
            sCTL_Enfermedad = cmb_CTL_Enfermedades.Text
        Else
            sCTL_Enfermedad = ""
        End If

        If cmb_CTL_Observaciones.SelectedIndex > 0 Then
            sCTL_Observacion = cmb_CTL_Observaciones.Text
        Else
            sCTL_Observacion = ""
        End If

        Me.SP_Reporte_CTL_LoteCheckTableAdapter.Fill(Me.DataSetReporteInventario.SP_Reporte_CTL_LoteCheck, sCTL_Entrega, sCTL_Cliente, sCTL_Enfermedad, sCTL_Observacion)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class