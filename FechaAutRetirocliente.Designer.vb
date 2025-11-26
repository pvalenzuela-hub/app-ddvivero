<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FechaAutRetirocliente
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.txtFechaAutorizacionCliente = New System.Windows.Forms.MaskedTextBox()
        Me.txtFechaRetiroCliente = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtLote)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(144, 50)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "N° Lote"
        '
        'txtLote
        '
        Me.txtLote.Location = New System.Drawing.Point(12, 18)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.ReadOnly = True
        Me.txtLote.Size = New System.Drawing.Size(115, 26)
        Me.txtLote.TabIndex = 10
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.GestionVivero.My.Resources.Resources.salir_40x40
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Location = New System.Drawing.Point(631, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 48)
        Me.Button2.TabIndex = 32
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.GestionVivero.My.Resources.Resources.guardar_40x40
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Location = New System.Drawing.Point(327, 299)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 48)
        Me.Button1.TabIndex = 31
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(142, 120)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(94, 13)
        Me.lbl1.TabIndex = 33
        Me.lbl1.Text = "Fecha Aut. Cliente"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(142, 159)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(103, 13)
        Me.lbl2.TabIndex = 34
        Me.lbl2.Text = "Fecha Retiro Cliente"
        '
        'txtFechaAutorizacionCliente
        '
        Me.txtFechaAutorizacionCliente.BackColor = System.Drawing.Color.Blue
        Me.txtFechaAutorizacionCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaAutorizacionCliente.ForeColor = System.Drawing.Color.White
        Me.txtFechaAutorizacionCliente.HidePromptOnLeave = True
        Me.txtFechaAutorizacionCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtFechaAutorizacionCliente.Location = New System.Drawing.Point(295, 115)
        Me.txtFechaAutorizacionCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFechaAutorizacionCliente.Name = "txtFechaAutorizacionCliente"
        Me.txtFechaAutorizacionCliente.Size = New System.Drawing.Size(105, 22)
        Me.txtFechaAutorizacionCliente.TabIndex = 168
        Me.txtFechaAutorizacionCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFechaAutorizacionCliente.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txtFechaRetiroCliente
        '
        Me.txtFechaRetiroCliente.BackColor = System.Drawing.Color.Blue
        Me.txtFechaRetiroCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaRetiroCliente.ForeColor = System.Drawing.Color.White
        Me.txtFechaRetiroCliente.Location = New System.Drawing.Point(295, 154)
        Me.txtFechaRetiroCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFechaRetiroCliente.Name = "txtFechaRetiroCliente"
        Me.txtFechaRetiroCliente.Size = New System.Drawing.Size(105, 22)
        Me.txtFechaRetiroCliente.TabIndex = 184
        Me.txtFechaRetiroCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FechaAutRetirocliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(679, 386)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtFechaRetiroCliente)
        Me.Controls.Add(Me.txtFechaAutorizacionCliente)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FechaAutRetirocliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fecha Aut./ Retiro Cliente"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtLote As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Public WithEvents txtFechaAutorizacionCliente As MaskedTextBox
    Friend WithEvents txtFechaRetiroCliente As MaskedTextBox
End Class
