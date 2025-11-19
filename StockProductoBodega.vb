Public Class StockProductoBodega
    Private Sub StockProductoBodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSTOCK.SP_StockListadoBodegas' Puede moverla o quitarla según sea necesario.
        Me.SP_StockListadoBodegasTableAdapter.Fill(Me.DataSetSTOCK.SP_StockListadoBodegas)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.SP_Stock_ConsultaInventariosProductosTableAdapter.Fill(Me.DataSetSTOCK.SP_Stock_ConsultaInventariosProductos, cmbBodega.SelectedValue)
    End Sub

    Private Sub DataGrilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrilla.CellContentClick

    End Sub

    Private Sub DataGrilla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrilla.CellClick
        If DataGrilla.RowCount > 0 Then
            If e.ColumnIndex = 12 And e.RowIndex >= 0 Then
                ''botón Ver Ficha
                gIdProd = DataGrilla.Rows(e.RowIndex).Cells(1).Value
                gQuienLlama = 2
                Visualiza_PDF.Show()
            End If

        End If
    End Sub
End Class
