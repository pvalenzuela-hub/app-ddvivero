<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AutorizacionPedidos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GrillaPedidos = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbPendientes = New System.Windows.Forms.RadioButton()
        Me.btnBusca = New System.Windows.Forms.Button()
        Me.txtNumPedido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.rbUltimos = New System.Windows.Forms.RadioButton()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ChkSeleccion = New System.Windows.Forms.CheckBox()
        CType(Me.GrillaPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrillaPedidos
        '
        Me.GrillaPedidos.AllowUserToAddRows = False
        Me.GrillaPedidos.AllowUserToDeleteRows = False
        Me.GrillaPedidos.AllowUserToResizeColumns = False
        Me.GrillaPedidos.AllowUserToResizeRows = False
        Me.GrillaPedidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrillaPedidos.BackgroundColor = System.Drawing.Color.White
        Me.GrillaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaPedidos.Location = New System.Drawing.Point(2, 84)
        Me.GrillaPedidos.Name = "GrillaPedidos"
        Me.GrillaPedidos.ReadOnly = True
        Me.GrillaPedidos.RowHeadersVisible = False
        Me.GrillaPedidos.Size = New System.Drawing.Size(1060, 579)
        Me.GrillaPedidos.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Blue
        Me.Button3.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(12, 670)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 43)
        Me.Button3.TabIndex = 107
        Me.Button3.Text = "Aprobar Pedido"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Close
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(693, 670)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 43)
        Me.Button1.TabIndex = 108
        Me.Button1.Text = "Cerrar Pedido"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Blue
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.salir_40x40
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(920, 670)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 43)
        Me.Button2.TabIndex = 109
        Me.Button2.Text = "Salir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Blue
        Me.Button4.Image = Global.GestionVivero.My.Resources.Resources.Delete
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(239, 670)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 43)
        Me.Button4.TabIndex = 111
        Me.Button4.Text = "Rechazar Pedido"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbPendientes)
        Me.GroupBox1.Controls.Add(Me.btnBusca)
        Me.GroupBox1.Controls.Add(Me.txtNumPedido)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rbTodos)
        Me.GroupBox1.Controls.Add(Me.rbUltimos)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1060, 60)
        Me.GroupBox1.TabIndex = 112
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'rbPendientes
        '
        Me.rbPendientes.AutoSize = True
        Me.rbPendientes.Checked = True
        Me.rbPendientes.Location = New System.Drawing.Point(395, 24)
        Me.rbPendientes.Name = "rbPendientes"
        Me.rbPendientes.Size = New System.Drawing.Size(160, 17)
        Me.rbPendientes.TabIndex = 112
        Me.rbPendientes.TabStop = True
        Me.rbPendientes.Text = "Pedidos Pendientes (default)"
        Me.rbPendientes.UseVisualStyleBackColor = True
        '
        'btnBusca
        '
        Me.btnBusca.BackColor = System.Drawing.Color.White
        Me.btnBusca.Image = Global.GestionVivero.My.Resources.Resources.buscar_40x40
        Me.btnBusca.Location = New System.Drawing.Point(1009, 8)
        Me.btnBusca.Name = "btnBusca"
        Me.btnBusca.Size = New System.Drawing.Size(48, 48)
        Me.btnBusca.TabIndex = 111
        Me.btnBusca.UseVisualStyleBackColor = False
        '
        'txtNumPedido
        '
        Me.txtNumPedido.Location = New System.Drawing.Point(169, 20)
        Me.txtNumPedido.Name = "txtNumPedido"
        Me.txtNumPedido.Size = New System.Drawing.Size(100, 20)
        Me.txtNumPedido.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "N° Pedido:"
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Location = New System.Drawing.Point(856, 22)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(112, 17)
        Me.rbTodos.TabIndex = 10
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos los Pedidos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'rbUltimos
        '
        Me.rbUltimos.AutoSize = True
        Me.rbUltimos.Location = New System.Drawing.Point(619, 24)
        Me.rbUltimos.Name = "rbUltimos"
        Me.rbUltimos.Size = New System.Drawing.Size(173, 17)
        Me.rbUltimos.TabIndex = 9
        Me.rbUltimos.TabStop = True
        Me.rbUltimos.Text = "Ingresados los últimos  6 meses"
        Me.rbUltimos.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Blue
        Me.Button5.Image = Global.GestionVivero.My.Resources.Resources.Add
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(466, 670)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(139, 43)
        Me.Button5.TabIndex = 113
        Me.Button5.Text = "Dejar Pendiente"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = False
        '
        'ChkSeleccion
        '
        Me.ChkSeleccion.AutoSize = True
        Me.ChkSeleccion.Location = New System.Drawing.Point(6, 64)
        Me.ChkSeleccion.Name = "ChkSeleccion"
        Me.ChkSeleccion.Size = New System.Drawing.Size(112, 17)
        Me.ChkSeleccion.TabIndex = 114
        Me.ChkSeleccion.Text = "Selecciona Todos"
        Me.ChkSeleccion.UseVisualStyleBackColor = True
        '
        'AutorizacionPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 716)
        Me.ControlBox = False
        Me.Controls.Add(Me.ChkSeleccion)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GrillaPedidos)
        Me.Name = "AutorizacionPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Pedidos para Autorizar"
        CType(Me.GrillaPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrillaPedidos As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNumPedido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rbTodos As RadioButton
    Friend WithEvents rbUltimos As RadioButton
    Friend WithEvents btnBusca As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ChkSeleccion As CheckBox
    Friend WithEvents rbPendientes As RadioButton
End Class
