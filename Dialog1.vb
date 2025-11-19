Imports System.Windows.Forms

Public Class Dialog1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Despacho.txtNumDesp.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
        Despacho.txtNumDesp.Focus()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet32.DespH' Puede moverla o quitarla según sea necesario.
        Me.DespHTableAdapter.Connection.ConnectionString = gSOURCE
        Me.DespHTableAdapter.Fill(Me.GESTDataSet32.DespH)

    End Sub
End Class
