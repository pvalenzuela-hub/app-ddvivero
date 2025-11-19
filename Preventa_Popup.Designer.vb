<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preventa_Popup
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMotivoPreventa = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(154, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese motivo de Modificación de Preventa"
        '
        'txtMotivoPreventa
        '
        Me.txtMotivoPreventa.Location = New System.Drawing.Point(86, 60)
        Me.txtMotivoPreventa.Multiline = True
        Me.txtMotivoPreventa.Name = "txtMotivoPreventa"
        Me.txtMotivoPreventa.Size = New System.Drawing.Size(423, 120)
        Me.txtMotivoPreventa.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.guardar_40x40
        Me.Button1.Location = New System.Drawing.Point(252, 205)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 49)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.salir_40x40
        Me.Button2.Location = New System.Drawing.Point(509, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(49, 49)
        Me.Button2.TabIndex = 4
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Preventa_Popup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 266)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtMotivoPreventa)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Preventa_Popup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preventa"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtMotivoPreventa As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
