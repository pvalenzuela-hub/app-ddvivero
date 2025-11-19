Public Class Cotizacion_ReImpresion
    Private Sub Cotizacion_ReImpresion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet_Cotizacion.SP_ReporteCotizacion_ALL' Puede moverla o quitarla según sea necesario.
        Me.SP_ReporteCotizacion_ALLTableAdapter.Fill(Me.DataSet_Cotizacion.SP_ReporteCotizacion_ALL)
        'TODO: esta línea de código carga datos en la tabla 'DataSet_Cotizacion.SP_ReporteCotizacion_ALL' Puede moverla o quitarla según sea necesario.

        If gQuienLlama = 1 Then
            GrillaCot.Columns(0).Visible = False
        End If




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cotizacion.Show()
    End Sub





    Private Sub GrillaCot_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaCot.CellClick
        If GrillaCot.Rows.Count > 0 Then
            If e.ColumnIndex = 1 Then
                Cotizacion_Print.txtIdCotizacion.Text = GrillaCot.Rows(e.RowIndex).Cells(1).Value
                Cotizacion_Print.Show()
            End If
            If e.ColumnIndex = 0 Then
                Pedidos.txt_IDCliente.Text = 1
            End If
        End If
    End Sub

    Private Sub GrillaCot_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaCot.CellContentClick

    End Sub
End Class