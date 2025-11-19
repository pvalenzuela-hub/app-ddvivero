<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListaPedidos
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
        Me.components = New System.ComponentModel.Container()
        Me.PanelBotones = New System.Windows.Forms.Panel()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GrillaPedidos = New System.Windows.Forms.DataGridView()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnBusca = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbUltimos = New System.Windows.Forms.RadioButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.txtNumPedido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelBotones.SuspendLayout()
        CType(Me.GrillaPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBotones
        '
        Me.PanelBotones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelBotones.Controls.Add(Me.btnBusca)
        Me.PanelBotones.Controls.Add(Me.btnSeleccionar)
        Me.PanelBotones.Controls.Add(Me.btnsave)
        Me.PanelBotones.Location = New System.Drawing.Point(1078, 12)
        Me.PanelBotones.Name = "PanelBotones"
        Me.PanelBotones.Size = New System.Drawing.Size(57, 530)
        Me.PanelBotones.TabIndex = 0
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.BackColor = System.Drawing.Color.White
        Me.btnSeleccionar.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.btnSeleccionar.Location = New System.Drawing.Point(3, 99)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(48, 48)
        Me.btnSeleccionar.TabIndex = 109
        Me.ToolTip1.SetToolTip(Me.btnSeleccionar, "Seleccionar Pedido")
        Me.btnSeleccionar.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.White
        Me.btnsave.Image = Global.GestionVivero.My.Resources.Resources.salir_40x40
        Me.btnsave.Location = New System.Drawing.Point(4, 3)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(48, 48)
        Me.btnsave.TabIndex = 107
        Me.ToolTip1.SetToolTip(Me.btnsave, "Salir")
        Me.btnsave.UseVisualStyleBackColor = False
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
        Me.GrillaPedidos.Location = New System.Drawing.Point(12, 107)
        Me.GrillaPedidos.Name = "GrillaPedidos"
        Me.GrillaPedidos.ReadOnly = True
        Me.GrillaPedidos.RowHeadersVisible = False
        Me.GrillaPedidos.Size = New System.Drawing.Size(1063, 435)
        Me.GrillaPedidos.TabIndex = 2
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblTitulo.Location = New System.Drawing.Point(17, 81)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(53, 19)
        Me.lblTitulo.TabIndex = 3
        Me.lblTitulo.Text = "Label1"
        '
        'btnBusca
        '
        Me.btnBusca.BackColor = System.Drawing.Color.White
        Me.btnBusca.Image = Global.GestionVivero.My.Resources.Resources.buscar_40x40
        Me.btnBusca.Location = New System.Drawing.Point(3, 51)
        Me.btnBusca.Name = "btnBusca"
        Me.btnBusca.Size = New System.Drawing.Size(48, 48)
        Me.btnBusca.TabIndex = 110
        Me.ToolTip1.SetToolTip(Me.btnBusca, "Seleccionar Pedido")
        Me.btnBusca.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNumPedido)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rbTodos)
        Me.GroupBox1.Controls.Add(Me.rbUltimos)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1060, 60)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'rbUltimos
        '
        Me.rbUltimos.AutoSize = True
        Me.rbUltimos.Location = New System.Drawing.Point(439, 22)
        Me.rbUltimos.Name = "rbUltimos"
        Me.rbUltimos.Size = New System.Drawing.Size(200, 19)
        Me.rbUltimos.TabIndex = 9
        Me.rbUltimos.TabStop = True
        Me.rbUltimos.Text = "Ingresados los últimos  6 meses"
        Me.rbUltimos.UseVisualStyleBackColor = True
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Location = New System.Drawing.Point(735, 22)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(124, 19)
        Me.rbTodos.TabIndex = 10
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos los Pedidos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'txtNumPedido
        '
        Me.txtNumPedido.Location = New System.Drawing.Point(270, 20)
        Me.txtNumPedido.Name = "txtNumPedido"
        Me.txtNumPedido.Size = New System.Drawing.Size(100, 23)
        Me.txtNumPedido.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(204, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "N° Pedido:"
        '
        'ListaPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1142, 554)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.GrillaPedidos)
        Me.Controls.Add(Me.PanelBotones)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ListaPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista Pedidos"
        Me.PanelBotones.ResumeLayout(False)
        CType(Me.GrillaPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelBotones As Panel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnSeleccionar As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents GrillaPedidos As DataGridView
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnBusca As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNumPedido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rbTodos As RadioButton
    Friend WithEvents rbUltimos As RadioButton
End Class
