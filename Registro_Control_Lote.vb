Public Class Registro_Control_Lote



    Private Sub Registro_Control_Lote_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Consulta_Inv_Lote()

    End Sub
    Private Sub Consulta_Inv_Lote()
        Dim i As Integer = 0



        sSsql = "SP_Reporte_CTL_Lotes"
        open()
        GrillaInventario.Rows.Clear()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            While datatbl.Read = True
                GrillaInventario.Rows.Add()
                GrillaInventario.Rows(i).Cells(0).Value = datatbl(0)
                GrillaInventario.Rows(i).Cells(1).Value = datatbl(1)
                GrillaInventario.Rows(i).Cells(2).Value = datatbl(2)
                GrillaInventario.Rows(i).Cells(3).Value = datatbl(6)
                GrillaInventario.Rows(i).Cells(4).Value = datatbl(22)
                GrillaInventario.Rows(i).Cells(5).Value = datatbl(7)
                GrillaInventario.Rows(i).Cells(6).Value = datatbl(8)
                GrillaInventario.Rows(i).Cells(7).Value = datatbl(5)
                GrillaInventario.Rows(i).Cells(8).Value = datatbl(9)
                GrillaInventario.Rows(i).Cells(9).Value = datatbl(12)
                GrillaInventario.Rows(i).Cells(10).Value = datatbl(17)
                'GrillaInventario.Rows(i).Cells(9).Value = datatbl(13)
                'GrillaInventario.Rows(i).Cells(10).Value = datatbl(14)
                'GrillaInventario.Rows(i).Cells(11).Value = datatbl(15)
                'GrillaInventario.Rows(i).Cells(12).Value = datatbl(16)

                i += 1

            End While
        End If
        close_conexion()
        Carga_CTL_Lote(ctl01, "CTL01")
        Carga_CTL_Lote(ctl02, "CTL02")
        Carga_CTL_Lote(ctl03, "CTL03")
        Carga_CTL_Lote(ctl04, "CTL04")


        sSsql = "SP_Reporte_CTL_Lotes"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            i = 0
            While datatbl.Read = True
                If GrillaInventario.Rows(i).Cells(2).Value = datatbl(2) Then
                    GrillaInventario.Rows(i).Cells(11).Value = datatbl(13)
                    GrillaInventario.Rows(i).Cells(12).Value = datatbl(14)
                    GrillaInventario.Rows(i).Cells(13).Value = datatbl(15)
                    GrillaInventario.Rows(i).Cells(14).Value = datatbl(16)
                    i += 1
                End If
            End While
        End If
        close_conexion()


        'For i = 0 To GrillaInventario.Rows.Count - 1

        'Next



    End Sub



    Private Sub GrillaInventario_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles GrillaInventario.CellValidating
        REM Actualiza Fecha Entrega
        If e.ColumnIndex = 9 Then
            ' Fecha de Control
            If Not IsDate(e.FormattedValue) And e.FormattedValue <> Nothing Then
                MsgBox("Fecha No Válida")
                e.Cancel = True
            Else

                If e.FormattedValue <> Nothing Then
                    GrillaInventario.Rows(e.RowIndex).Cells(9).Value = CDate(e.FormattedValue)
                    GrillaInventario.RefreshEdit()
                End If

            End If
        End If

        If e.ColumnIndex = 10 Then
            ' Fecha de Control
            If Not IsDate(e.FormattedValue) And e.FormattedValue <> Nothing Then
                MsgBox("Fecha No Válida")
                e.Cancel = True
            Else

                If e.FormattedValue <> Nothing Then
                    GrillaInventario.Rows(e.RowIndex).Cells(10).Value = CDate(e.FormattedValue)
                    GrillaInventario.RefreshEdit()
                End If

            End If
        End If

        If e.ColumnIndex = 11 Or e.ColumnIndex = 12 Or e.ColumnIndex = 13 Or e.ColumnIndex = 14 Then
            'Llena Campo Fecha de Control en forma automatica si se realizan cambios en la planilla
            If e.FormattedValue <> Nothing Then
                GrillaInventario.Rows(e.RowIndex).Cells(10).Value = Format(Now.Date, "d")
            End If
        End If




    End Sub
    Private Sub Actualiza_Control_Lote()
        Dim i As Integer = 0
        Dim dFechaHoy As Date

        dFechaHoy = Now.Date
        open()
        For i = 0 To GrillaInventario.Rows.Count - 1
            If GrillaInventario.Rows(i).Cells(10).Value <> Nothing Then
                If GrillaInventario.Rows(i).Cells(10).Value = dFechaHoy Then
                    sSsql = "SP_ACTUALIZA_Control_Lote "
                    sSsql += GrillaInventario.Rows(i).Cells(2).Value.ToString + ","
                    sSsql += "'" + GrillaInventario.Rows(i).Cells(9).Value + "',"
                    sSsql += "'" + GrillaInventario.Rows(i).Cells(10).Value + "',"
                    sSsql += "'" + RTrim(GrillaInventario.Rows(i).Cells(11).Value) + "',"
                    sSsql += "'" + RTrim(GrillaInventario.Rows(i).Cells(12).Value) + "',"
                    sSsql += "'" + RTrim(GrillaInventario.Rows(i).Cells(13).Value) + "',"
                    sSsql += "'" + RTrim(GrillaInventario.Rows(i).Cells(14).Value) + "'"
                    command = connection.CreateCommand
                    command.CommandText = sSsql
                    command.ExecuteNonQuery()
                End If
            End If

        Next
        close_conexion()
        MsgBox("Lotes han sido Actualizados.", MsgBoxStyle.Information)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Actualiza_Control_Lote()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Reporte_Control_Lote.Show()
    End Sub

    Private Sub GrillaInventario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaInventario.CellContentClick

    End Sub
End Class