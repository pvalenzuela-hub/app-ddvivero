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
        Me.btnAprobar = New System.Windows.Forms.Button()
        Me.btnCerrarPedido = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnRechazar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbPendientes = New System.Windows.Forms.RadioButton()
        Me.btnBusca = New System.Windows.Forms.Button()
        Me.txtNumPedido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.rbUltimos = New System.Windows.Forms.RadioButton()
        Me.btnPendiente = New System.Windows.Forms.Button()
        Me.ChkSeleccion = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.txtFiltroValor = New System.Windows.Forms.TextBox()
        Me.cmbfiltros = New System.Windows.Forms.ComboBox()
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
        Me.GrillaPedidos.Location = New System.Drawing.Point(2, 117)
        Me.GrillaPedidos.Name = "GrillaPedidos"
        Me.GrillaPedidos.ReadOnly = True
        Me.GrillaPedidos.RowHeadersVisible = False
        Me.GrillaPedidos.Size = New System.Drawing.Size(1060, 546)
        Me.GrillaPedidos.TabIndex = 1
        '
        'btnAprobar
        '
        Me.btnAprobar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAprobar.BackColor = System.Drawing.Color.White
        Me.btnAprobar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAprobar.ForeColor = System.Drawing.Color.Blue
        Me.btnAprobar.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.btnAprobar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAprobar.Location = New System.Drawing.Point(12, 670)
        Me.btnAprobar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAprobar.Name = "btnAprobar"
        Me.btnAprobar.Size = New System.Drawing.Size(139, 43)
        Me.btnAprobar.TabIndex = 107
        Me.btnAprobar.Text = "Aprobar Pedido"
        Me.btnAprobar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAprobar.UseVisualStyleBackColor = False
        '
        'btnCerrarPedido
        '
        Me.btnCerrarPedido.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnCerrarPedido.BackColor = System.Drawing.Color.White
        Me.btnCerrarPedido.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarPedido.ForeColor = System.Drawing.Color.Blue
        Me.btnCerrarPedido.Image = Global.GestionVivero.My.Resources.Resources.Close
        Me.btnCerrarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarPedido.Location = New System.Drawing.Point(693, 670)
        Me.btnCerrarPedido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCerrarPedido.Name = "btnCerrarPedido"
        Me.btnCerrarPedido.Size = New System.Drawing.Size(139, 43)
        Me.btnCerrarPedido.TabIndex = 108
        Me.btnCerrarPedido.Text = "Cerrar Pedido"
        Me.btnCerrarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrarPedido.UseVisualStyleBackColor = False
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
        'btnRechazar
        '
        Me.btnRechazar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnRechazar.BackColor = System.Drawing.Color.White
        Me.btnRechazar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRechazar.ForeColor = System.Drawing.Color.Blue
        Me.btnRechazar.Image = Global.GestionVivero.My.Resources.Resources.Delete
        Me.btnRechazar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRechazar.Location = New System.Drawing.Point(239, 670)
        Me.btnRechazar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRechazar.Name = "btnRechazar"
        Me.btnRechazar.Size = New System.Drawing.Size(139, 43)
        Me.btnRechazar.TabIndex = 111
        Me.btnRechazar.Text = "Rechazar Pedido"
        Me.btnRechazar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRechazar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.txtFiltroValor)
        Me.GroupBox1.Controls.Add(Me.cmbfiltros)
        Me.GroupBox1.Controls.Add(Me.rbPendientes)
        Me.GroupBox1.Controls.Add(Me.btnBusca)
        Me.GroupBox1.Controls.Add(Me.txtNumPedido)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rbTodos)
        Me.GroupBox1.Controls.Add(Me.rbUltimos)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1060, 86)
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
        'btnPendiente
        '
        Me.btnPendiente.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnPendiente.BackColor = System.Drawing.Color.White
        Me.btnPendiente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPendiente.ForeColor = System.Drawing.Color.Blue
        Me.btnPendiente.Image = Global.GestionVivero.My.Resources.Resources.Add
        Me.btnPendiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPendiente.Location = New System.Drawing.Point(466, 670)
        Me.btnPendiente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPendiente.Name = "btnPendiente"
        Me.btnPendiente.Size = New System.Drawing.Size(139, 43)
        Me.btnPendiente.TabIndex = 113
        Me.btnPendiente.Text = "Dejar Pendiente"
        Me.btnPendiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPendiente.UseVisualStyleBackColor = False
        '
        'ChkSeleccion
        '
        Me.ChkSeleccion.AutoSize = True
        Me.ChkSeleccion.Location = New System.Drawing.Point(12, 94)
        Me.ChkSeleccion.Name = "ChkSeleccion"
        Me.ChkSeleccion.Size = New System.Drawing.Size(112, 17)
        Me.ChkSeleccion.TabIndex = 114
        Me.ChkSeleccion.Text = "Selecciona Todos"
        Me.ChkSeleccion.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(299, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "Filtro:"
        '
        'Button6
        '
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button6.Image = Global.GestionVivero.My.Resources.Resources.Close
        Me.Button6.Location = New System.Drawing.Point(680, 48)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(32, 32)
        Me.Button6.TabIndex = 115
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = True
        '
        'txtFiltroValor
        '
        Me.txtFiltroValor.Location = New System.Drawing.Point(517, 53)
        Me.txtFiltroValor.Name = "txtFiltroValor"
        Me.txtFiltroValor.Size = New System.Drawing.Size(158, 20)
        Me.txtFiltroValor.TabIndex = 114
        '
        'cmbfiltros
        '
        Me.cmbfiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbfiltros.FormattingEnabled = True
        Me.cmbfiltros.Location = New System.Drawing.Point(344, 53)
        Me.cmbfiltros.Name = "cmbfiltros"
        Me.cmbfiltros.Size = New System.Drawing.Size(167, 21)
        Me.cmbfiltros.TabIndex = 113
        '
        'AutorizacionPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1066, 716)
        Me.ControlBox = False
        Me.Controls.Add(Me.ChkSeleccion)
        Me.Controls.Add(Me.btnPendiente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRechazar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnCerrarPedido)
        Me.Controls.Add(Me.btnAprobar)
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
    Friend WithEvents btnAprobar As Button
    Friend WithEvents btnCerrarPedido As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnRechazar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNumPedido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rbTodos As RadioButton
    Friend WithEvents rbUltimos As RadioButton
    Friend WithEvents btnBusca As Button
    Friend WithEvents btnPendiente As Button
    Friend WithEvents ChkSeleccion As CheckBox
    Friend WithEvents rbPendientes As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents txtFiltroValor As TextBox
    Friend WithEvents cmbfiltros As ComboBox
End Class
