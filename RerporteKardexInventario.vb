Public Class ReporteKardexInventario

    Private Sub RerporteKardexInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet21.SP_ReporteMoviKardexVariedad' Puede moverla o quitarla según sea necesario.



        Carga_Familia_Prod(cmb_familia)

    End Sub

    Private Sub cmb_familia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_familia.SelectedIndexChanged
        If cmb_familia.SelectedIndex > -1 Then
            Carga_Variedad_Filtro(cmb_variedad, cmb_familia.Text)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Me.SP_ReporteMoviKardexVariedadTableAdapter.Fill(Me.GESTDataSet21.SP_ReporteMoviKardexVariedad, DateTimePicker1.Value, DateTimePicker2.Value, cmb_variedad.Text, cmb_familia.Text)
        'Me.ReportViewer1.RefreshReport()
        'dbo.SP_ReporteMoviKardexVariedad '01/01/2014','18/07/2014','GLORIA','REPOLLO'
        Dim i As Integer
        Dim dSaldoInicial As Double
        Dim dSaldoParcial As Double

        txt_SaldoFinal.Clear()
        txt_SaldoInicial.Clear()


        sSsql = "SP_ReporteMoviKardexVariedad "
        sSsql += "'" + Format(DateTimePicker1.Value, "d") + "',"
        sSsql += "'" + Format(DateTimePicker2.Value, "d") + "',"
        sSsql += "'" + cmb_variedad.Text + "',"
        sSsql += "'" + cmb_familia.Text + "'"

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        DataGrilla.Rows.Clear()
        If datatbl.HasRows Then
            i = 0
            datatbl.Read()
            dSaldoInicial = datatbl(1)
            txt_SaldoInicial.Text = Format(dSaldoInicial, "###,###,##0")
            dSaldoParcial = dSaldoInicial + datatbl(2) - datatbl(3)

            DataGrilla.Rows.Add()
            DataGrilla.Rows(i).Cells(0).Value = datatbl(0)
            DataGrilla.Rows(i).Cells(1).Value = Format(datatbl(2), "###,###,##0")
            DataGrilla.Rows(i).Cells(2).Value = Format(datatbl(3), "###,###,##0")
            DataGrilla.Rows(i).Cells(3).Value = Format(dSaldoParcial, "###,###,##0")
            DataGrilla.Rows(i).Cells(4).Value = datatbl(4)
            DataGrilla.Rows(i).Cells(5).Value = datatbl(5)
            i += 1
            While datatbl.Read = True
                dSaldoParcial = dSaldoParcial + datatbl(2) - datatbl(3)
                DataGrilla.Rows.Add()
                DataGrilla.Rows(i).Cells(0).Value = datatbl(0)
                DataGrilla.Rows(i).Cells(1).Value = Format(datatbl(2), "###,###,##0")
                DataGrilla.Rows(i).Cells(2).Value = Format(datatbl(3), "###,###,##0")
                DataGrilla.Rows(i).Cells(3).Value = Format(dSaldoParcial, "###,###,##0")
                DataGrilla.Rows(i).Cells(4).Value = datatbl(4)
                DataGrilla.Rows(i).Cells(5).Value = datatbl(5)

                i += 1
            End While
            txt_SaldoFinal.Text = Format(dSaldoParcial, "###,###,##0")
        Else
            MsgBox("No Existen Movimientos de Inventario para la Variedad Seleccionada.")
        End If

        close_conexion()


    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
End Class