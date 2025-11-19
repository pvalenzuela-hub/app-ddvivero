Imports System.Windows.Forms

Public Class Ventana_ayuda

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Ventana_ayuda_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBox1.Text = "Control de Presupuesto: Esta consulta muestra el valor de todos los lotes pendientes por facturar. "
        TextBox1.Text += "Corresponde al saldo valorizado de Plantas no entregadas. "
        TextBox1.Text += "Ninguno de estos saldos de lotes tiene guía de entrega emitida."
    End Sub
End Class
