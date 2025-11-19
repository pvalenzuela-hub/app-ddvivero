Imports System.Windows.Forms

Public Class BuscaInsumo

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim iLargoTexto As Integer
        Dim InsumoaBuscar As String
        Dim ExpresionBuscada As String

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        ExpresionBuscada = LTrim(RTrim(txtBuscaInsumo.Text))
        iLargoTexto = Len(ExpresionBuscada)

        For i As Integer = 0 To Insumos.DataGrilla.Rows.Count - 1
            InsumoaBuscar = UCase(Insumos.DataGrilla.Rows(i).Cells(1).Value)

            If UCase(LTrim(RTrim(txtBuscaInsumo.Text))) = Mid(InsumoaBuscar, 1, iLargoTexto) Then
                Insumos.DataGrilla.FirstDisplayedScrollingRowIndex = i
                Exit For
            End If

            If InStr(InsumoaBuscar, ExpresionBuscada, CompareMethod.Text) > 0 Then
                Insumos.DataGrilla.FirstDisplayedScrollingRowIndex = i
                Exit For
            End If

        Next
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
