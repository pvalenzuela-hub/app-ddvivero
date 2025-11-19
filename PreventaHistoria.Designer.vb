<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreventaHistoria
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
        Me.txtMotivoEnablePreventa = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtMotivoDisablePreventa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(292, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Historia de cambios en Preventa"
        '
        'txtMotivoEnablePreventa
        '
        Me.txtMotivoEnablePreventa.Location = New System.Drawing.Point(28, 93)
        Me.txtMotivoEnablePreventa.Multiline = True
        Me.txtMotivoEnablePreventa.Name = "txtMotivoEnablePreventa"
        Me.txtMotivoEnablePreventa.ReadOnly = True
        Me.txtMotivoEnablePreventa.Size = New System.Drawing.Size(760, 88)
        Me.txtMotivoEnablePreventa.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.salir_40x40
        Me.Button1.Location = New System.Drawing.Point(749, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 49)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtMotivoDisablePreventa
        '
        Me.txtMotivoDisablePreventa.Location = New System.Drawing.Point(28, 207)
        Me.txtMotivoDisablePreventa.Multiline = True
        Me.txtMotivoDisablePreventa.Name = "txtMotivoDisablePreventa"
        Me.txtMotivoDisablePreventa.ReadOnly = True
        Me.txtMotivoDisablePreventa.Size = New System.Drawing.Size(760, 88)
        Me.txtMotivoDisablePreventa.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Seleccionado como  Preventa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Retiro de marca"
        '
        'PreventaHistoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 307)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMotivoDisablePreventa)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtMotivoEnablePreventa)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PreventaHistoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preventa Historia"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtMotivoEnablePreventa As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtMotivoDisablePreventa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
