Public Class ImprimeLotesCliente
    Private Sub ImprimeLotesCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DeterminaColumnaSort()
    End Sub


    Private Sub DeterminaColumnaSort()
        Dim colOrden As String = ""
        Dim tipoOrden As String = ""

        If Consulta_Cliente.DataCartola.SortedColumn IsNot Nothing Then

            colOrden = Consulta_Cliente.DataCartola.SortedColumn.Name  ' usa el campo de datos, no el encabezado
            tipoOrden = If(Consulta_Cliente.DataCartola.SortOrder = SortOrder.Descending, "DESC", "ASC")

            Dim sql As String = ""
            If colOrden <> "" Then
                sql &= colOrden & " " & tipoOrden
            End If
        End If

        Me.SP_CONSULTA_LOTE_CLIENTE_VigenteTableAdapter.Fill(Me.GESTDataSet.SP_CONSULTA_LOTE_CLIENTE_Vigente, txtIdCliente.Text, colOrden, tipoOrden)
        Me.ReportViewer1.RefreshReport()

    End Sub

End Class