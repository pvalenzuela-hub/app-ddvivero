<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubirAutorizacionEntrega
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OP_FechaAutorizacion = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OP_RegistroUbicacion = New System.Windows.Forms.RadioButton()
        Me.OP_FechaRetiroCliente = New System.Windows.Forms.RadioButton()
        Me.OP_Ajuste = New System.Windows.Forms.RadioButton()
        Me.OP_Conteo = New System.Windows.Forms.RadioButton()
        Me.OP_Siembra = New System.Windows.Forms.RadioButton()
        Me.OP_Pedido = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccionar Archivo Excel"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(178, 198)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(31, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtFileName
        '
        Me.txtFileName.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileName.Location = New System.Drawing.Point(31, 222)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.ReadOnly = True
        Me.txtFileName.Size = New System.Drawing.Size(735, 23)
        Me.txtFileName.TabIndex = 4
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(660, 297)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(106, 102)
        Me.ListBox1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(657, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 14)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Lotes Actualizados"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = Global.GestionVivero.My.Resources.Resources.Update
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(329, 340)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 48)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.GestionVivero.My.Resources.Resources.salir_40x40
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Location = New System.Drawing.Point(772, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 48)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(249, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "SUBIR ACTUALIZACIONES"
        '
        'OP_FechaAutorizacion
        '
        Me.OP_FechaAutorizacion.AutoSize = True
        Me.OP_FechaAutorizacion.Location = New System.Drawing.Point(13, 21)
        Me.OP_FechaAutorizacion.Name = "OP_FechaAutorizacion"
        Me.OP_FechaAutorizacion.Size = New System.Drawing.Size(229, 18)
        Me.OP_FechaAutorizacion.TabIndex = 16
        Me.OP_FechaAutorizacion.TabStop = True
        Me.OP_FechaAutorizacion.Text = "FECHA AUTORIZACION CLIENTE (2 cols.)"
        Me.OP_FechaAutorizacion.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OP_RegistroUbicacion)
        Me.GroupBox1.Controls.Add(Me.OP_FechaRetiroCliente)
        Me.GroupBox1.Controls.Add(Me.OP_Ajuste)
        Me.GroupBox1.Controls.Add(Me.OP_Conteo)
        Me.GroupBox1.Controls.Add(Me.OP_Siembra)
        Me.GroupBox1.Controls.Add(Me.OP_Pedido)
        Me.GroupBox1.Controls.Add(Me.OP_FechaAutorizacion)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(735, 135)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione Tipo de Archivo"
        '
        'OP_RegistroUbicacion
        '
        Me.OP_RegistroUbicacion.AutoSize = True
        Me.OP_RegistroUbicacion.Location = New System.Drawing.Point(13, 105)
        Me.OP_RegistroUbicacion.Name = "OP_RegistroUbicacion"
        Me.OP_RegistroUbicacion.Size = New System.Drawing.Size(200, 18)
        Me.OP_RegistroUbicacion.TabIndex = 22
        Me.OP_RegistroUbicacion.TabStop = True
        Me.OP_RegistroUbicacion.Text = "REGISTRO DE UBICACIÓN (3 cols.)"
        Me.OP_RegistroUbicacion.UseVisualStyleBackColor = True
        '
        'OP_FechaRetiroCliente
        '
        Me.OP_FechaRetiroCliente.AutoSize = True
        Me.OP_FechaRetiroCliente.Location = New System.Drawing.Point(13, 63)
        Me.OP_FechaRetiroCliente.Name = "OP_FechaRetiroCliente"
        Me.OP_FechaRetiroCliente.Size = New System.Drawing.Size(188, 18)
        Me.OP_FechaRetiroCliente.TabIndex = 21
        Me.OP_FechaRetiroCliente.TabStop = True
        Me.OP_FechaRetiroCliente.Text = "FECHA RETIRO CLIENTE (4 cols.)"
        Me.OP_FechaRetiroCliente.UseVisualStyleBackColor = True
        '
        'OP_Ajuste
        '
        Me.OP_Ajuste.AutoSize = True
        Me.OP_Ajuste.Location = New System.Drawing.Point(520, 63)
        Me.OP_Ajuste.Name = "OP_Ajuste"
        Me.OP_Ajuste.Size = New System.Drawing.Size(172, 18)
        Me.OP_Ajuste.TabIndex = 20
        Me.OP_Ajuste.TabStop = True
        Me.OP_Ajuste.Text = "APROBACIÓN AJUSTE (1 col.)"
        Me.OP_Ajuste.UseVisualStyleBackColor = True
        '
        'OP_Conteo
        '
        Me.OP_Conteo.AutoSize = True
        Me.OP_Conteo.Location = New System.Drawing.Point(520, 21)
        Me.OP_Conteo.Name = "OP_Conteo"
        Me.OP_Conteo.Size = New System.Drawing.Size(177, 18)
        Me.OP_Conteo.TabIndex = 19
        Me.OP_Conteo.TabStop = True
        Me.OP_Conteo.Text = "APROBACIÓN CONTEO (1 col.)"
        Me.OP_Conteo.UseVisualStyleBackColor = True
        '
        'OP_Siembra
        '
        Me.OP_Siembra.AutoSize = True
        Me.OP_Siembra.Location = New System.Drawing.Point(291, 63)
        Me.OP_Siembra.Name = "OP_Siembra"
        Me.OP_Siembra.Size = New System.Drawing.Size(182, 18)
        Me.OP_Siembra.TabIndex = 18
        Me.OP_Siembra.TabStop = True
        Me.OP_Siembra.Text = "APROBACIÓN SIEMBRA (1 col.)"
        Me.OP_Siembra.UseVisualStyleBackColor = True
        '
        'OP_Pedido
        '
        Me.OP_Pedido.AutoSize = True
        Me.OP_Pedido.Location = New System.Drawing.Point(291, 21)
        Me.OP_Pedido.Name = "OP_Pedido"
        Me.OP_Pedido.Size = New System.Drawing.Size(175, 18)
        Me.OP_Pedido.TabIndex = 17
        Me.OP_Pedido.TabStop = True
        Me.OP_Pedido.Text = "APROBACIÓN PEDIDO (1 col.)"
        Me.OP_Pedido.UseVisualStyleBackColor = True
        '
        'SubirAutorizacionEntrega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(821, 411)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "SubirAutorizacionEntrega"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subir Información al Sistema"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OP_FechaAutorizacion As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents OP_Pedido As RadioButton
    Friend WithEvents OP_Ajuste As RadioButton
    Friend WithEvents OP_Conteo As RadioButton
    Friend WithEvents OP_Siembra As RadioButton
    Friend WithEvents OP_FechaRetiroCliente As RadioButton
    Friend WithEvents OP_RegistroUbicacion As RadioButton
End Class
