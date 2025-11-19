Imports DocumentFormat.OpenXml.EMMA

Public Class ReporteDespachoRecuperacionBandejas
    Private Sub ReporteDespachoRecuperacionBandejas_Load(sender As Object, e As EventArgs) Handles Me.Load

        Carga_Full_Zona(Me.cmb_Zona)

        ' Me.cmb_Sector.Items.Add("Todos los Sectores")
        Me.cmb_Zona.Items.Add("Todas las Zonas")

    End Sub

    Private Sub cmb_Zona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Zona.SelectedIndexChanged
        If cmb_Zona.SelectedIndex > -1 Then
            Me.SP_CONSULTASectorFiltroTableAdapter.Fill(Me.GESTDataSet12.SP_CONSULTASectorFiltro, cmb_Zona.Text)
            If cmb_Zona.Text = "Todas las Zonas" Then
                Dim i As Integer = 0
                GrillaSectores.Rows.Clear()
                sSsql = "SP_CONSULTASectorFiltro 'Todas las Zonas'"
                open()
                command = connection.CreateCommand()
                command.CommandText = sSsql
                datatbl = command.ExecuteReader()
                If datatbl.HasRows Then
                    While datatbl.Read
                        GrillaSectores.Rows.Add()
                        GrillaSectores.Rows(i).Cells(1).Value = datatbl(0)
                        GrillaSectores.Rows(i).Cells(2).Value = datatbl(1)
                        i += 1
                    End While
                End If
                close_conexion()
            End If
        End If
    End Sub

    Private Sub GrillaSectores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaSectores.CellClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex <> 0 Then
                Return
            End If
            GrillaSectores.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub

    Private Sub cmb_Sector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Sector.SelectedIndexChanged
        If cmb_Sector.SelectedIndex >= 0 Then
            GrillaSectores.Rows.Add()
            Dim i As Integer = GrillaSectores.Rows.Count - 1
            GrillaSectores.Rows(i).Cells(1).Value = cmb_Sector.SelectedValue
            GrillaSectores.Rows(i).Cells(2).Value = cmb_Sector.Text
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Cursor.Current = Cursors.WaitCursor

        Dim i As Integer
        open()
        command = connection.CreateCommand()
        sSsql = "Delete From [dbo].[T_RepBandejas] Where IdUsuario = '" & gUSER & "'"
        command.CommandText = sSsql
        command.ExecuteNonQuery()

        For i = 0 To GrillaSectores.Rows.Count - 1
            sSsql = "INSERT INTO [dbo].[T_RepBandejas] (IdSector, FechaReporte, IdUsuario) VALUES("
            sSsql += GrillaSectores.Rows(i).Cells(1).Value.ToString & ","
            sSsql += "'" & Format(DateTime.Now, "d") & "',"
            sSsql += "'" & gUSER & "')"
            command.CommandText = sSsql
            command.ExecuteNonQuery()
        Next
        close_conexion()
        Me.NEWSP_ReporteDespachoRecupBandejasPendientesTableAdapter.Fill(Me.GESTDataSet11.NEWSP_ReporteDespachoRecupBandejasPendientes, gUSER)
        Me.ReportViewer1.RefreshReport()

        Cursor.Current = Cursors.Default


    End Sub


End Class