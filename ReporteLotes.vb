Public Class ReporteLotes

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Genera_Consulta()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BusquedaCliente.chkIncluyePrimerNombre.Checked = chk_name.Checked
        gNOMBRE = txt_nombre.Text
        gQuienLlama = 18
        BusquedaCliente.Visible = True
    End Sub

    Private Sub Rdb_Cliente_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_Cliente.CheckedChanged
        If Rdb_Cliente.Checked = True Then
            txt_nombre.Enabled = True
            txt_nombre.ReadOnly = False
            cmb_variedad.Enabled = False
            cmb_variedad.SelectedIndex = -1
            cmb_familia.Enabled = False
            cmb_familia.SelectedIndex = -1
        End If
    End Sub
    Private Sub Genera_Consulta()
        Dim iTipo As Integer
        'Dim i As Integer
        If rdb_Todo.Checked = True Then
            iTipo = 0
        End If
        If rdb_Cliente.Checked = True Then
            iTipo = 1
        End If
        If rdb_Variedad.Checked = True Then
            If cmb_variedad.SelectedIndex = -1 Then
                MsgBox("Debe Seleccionar Variedad.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            iTipo = 2
        End If

        If rdb_Semilla.Checked = True Then
            If cmb_Familia.SelectedIndex = -1 Then
                MsgBox("Seleccione Semilla", MsgBoxStyle.Critical)
                Exit Sub
            End If
            iTipo = 3
        End If
        Me.SP_CONSULTA_LOTE_RESUMENTableAdapter.Fill(Me.DataSetReporteInventario.SP_CONSULTA_LOTE_RESUMEN, gIDCliente, cmb_variedad.Text, iTipo, Format(DateTimePicker1.Value, "d"), Format(DateTimePicker2.Value, "d"), cmb_familia.Text)

        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub ReporteLotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gQuienLlama = 1
        Carga_Variedad(cmb_variedad)
        Carga_Familia_Prod(cmb_familia)

        Me.SP_CONSULTA_LOTE_RESUMENTableAdapter.Connection.ConnectionString = gSOURCE

    End Sub

    Private Sub rdb_Semilla_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_Semilla.CheckedChanged
        If rdb_Semilla.Checked = True Then
            txt_nombre.ReadOnly = False
            txt_nombre.Clear()
            cmb_variedad.Enabled = False
            cmb_variedad.SelectedIndex = -1
            cmb_familia.Enabled = True
        End If
    End Sub

    Private Sub rdb_Todo_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_Todo.CheckedChanged
        If rdb_Todo.Checked = True Then
            txt_nombre.ReadOnly = True
            cmb_variedad.Enabled = False
            txt_nombre.Text = ""
            cmb_variedad.SelectedIndex = -1
        End If
    End Sub

    Private Sub rdb_Variedad_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_Variedad.CheckedChanged
        If rdb_Variedad.Checked = True Then
            cmb_variedad.Enabled = True
            txt_nombre.ReadOnly = True
            cmb_familia.SelectedIndex = -1
            cmb_familia.Enabled = False
            txt_nombre.Text = ""
        End If
    End Sub
End Class