<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Visualiza_PDF
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.WebView1 = New EO.WebBrowser.WebView()
        Me.WebControl1 = New EO.WinForm.WebControl()
        Me.WebView2 = New EO.WebBrowser.WebView()
        Me.SuspendLayout()
        '
        'WebView1
        '
        Me.WebView1.InputMsgFilter = Nothing
        Me.WebView1.ObjectForScripting = Nothing
        Me.WebView1.Title = Nothing
        '
        'WebControl1
        '
        Me.WebControl1.BackColor = System.Drawing.Color.White
        Me.WebControl1.Location = New System.Drawing.Point(3, 2)
        Me.WebControl1.Name = "WebControl1"
        Me.WebControl1.Size = New System.Drawing.Size(1348, 658)
        Me.WebControl1.TabIndex = 3
        Me.WebControl1.Text = "WebControl1"
        Me.WebControl1.WebView = Me.WebView2
        '
        'WebView2
        '
        Me.WebView2.InputMsgFilter = Nothing
        Me.WebView2.ObjectForScripting = Nothing
        Me.WebView2.Title = Nothing
        '
        'Visualiza_PDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 661)
        Me.Controls.Add(Me.WebControl1)
        Me.Name = "Visualiza_PDF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Ficha PDF"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WebView1 As EO.WebBrowser.WebView
    Friend WithEvents WebControl1 As EO.WinForm.WebControl
    Friend WithEvents WebView2 As EO.WebBrowser.WebView
End Class
