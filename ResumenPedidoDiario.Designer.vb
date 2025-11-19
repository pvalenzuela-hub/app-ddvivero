<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResumenPedidoDiario
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgPedidos = New System.Windows.Forms.DataGridView()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPedidosFecha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNuevoPedido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalPedidos = New System.Windows.Forms.TextBox()
        Me.numlote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.semilla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.variedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plantas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(437, 424)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 47)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgPedidos
        '
        Me.dgPedidos.AllowUserToAddRows = False
        Me.dgPedidos.AllowUserToDeleteRows = False
        Me.dgPedidos.AllowUserToResizeColumns = False
        Me.dgPedidos.AllowUserToResizeRows = False
        Me.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numlote, Me.semilla, Me.variedad, Me.cliente, Me.pedido, Me.plantas})
        Me.dgPedidos.Location = New System.Drawing.Point(9, 37)
        Me.dgPedidos.Name = "dgPedidos"
        Me.dgPedidos.ReadOnly = True
        Me.dgPedidos.RowHeadersVisible = False
        Me.dgPedidos.RowTemplate.Height = 24
        Me.dgPedidos.Size = New System.Drawing.Size(916, 313)
        Me.dgPedidos.TabIndex = 1
        '
        'txtFecha
        '
        Me.txtFecha.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(115, 6)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(156, 24)
        Me.txtFecha.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha Inicio:"
        '
        'txtPedidosFecha
        '
        Me.txtPedidosFecha.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedidosFecha.Location = New System.Drawing.Point(813, 356)
        Me.txtPedidosFecha.Name = "txtPedidosFecha"
        Me.txtPedidosFecha.ReadOnly = True
        Me.txtPedidosFecha.Size = New System.Drawing.Size(112, 28)
        Me.txtPedidosFecha.TabIndex = 4
        Me.txtPedidosFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(677, 361)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Pedidos Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(677, 403)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nuevo Pedido:"
        '
        'txtNuevoPedido
        '
        Me.txtNuevoPedido.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevoPedido.Location = New System.Drawing.Point(813, 398)
        Me.txtNuevoPedido.Name = "txtNuevoPedido"
        Me.txtNuevoPedido.ReadOnly = True
        Me.txtNuevoPedido.Size = New System.Drawing.Size(112, 28)
        Me.txtNuevoPedido.TabIndex = 7
        Me.txtNuevoPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(677, 447)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total Pedidos:"
        '
        'txtTotalPedidos
        '
        Me.txtTotalPedidos.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPedidos.Location = New System.Drawing.Point(813, 441)
        Me.txtTotalPedidos.Name = "txtTotalPedidos"
        Me.txtTotalPedidos.ReadOnly = True
        Me.txtTotalPedidos.Size = New System.Drawing.Size(112, 28)
        Me.txtTotalPedidos.TabIndex = 9
        Me.txtTotalPedidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numlote
        '
        Me.numlote.HeaderText = "N° Lote"
        Me.numlote.Name = "numlote"
        Me.numlote.ReadOnly = True
        Me.numlote.Width = 80
        '
        'semilla
        '
        Me.semilla.HeaderText = "Semilla"
        Me.semilla.Name = "semilla"
        Me.semilla.ReadOnly = True
        Me.semilla.Width = 150
        '
        'variedad
        '
        Me.variedad.HeaderText = "Variedad"
        Me.variedad.Name = "variedad"
        Me.variedad.ReadOnly = True
        Me.variedad.Width = 150
        '
        'cliente
        '
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        Me.cliente.Width = 350
        '
        'pedido
        '
        Me.pedido.HeaderText = "N° Pedido"
        Me.pedido.Name = "pedido"
        Me.pedido.ReadOnly = True
        Me.pedido.Width = 80
        '
        'plantas
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.plantas.DefaultCellStyle = DataGridViewCellStyle2
        Me.plantas.HeaderText = "Cantidad"
        Me.plantas.Name = "plantas"
        Me.plantas.ReadOnly = True
        '
        'ResumenPedidoDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 483)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtTotalPedidos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNuevoPedido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPedidosFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.dgPedidos)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ResumenPedidoDiario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen Pedido Diario - EXCEDE MAXIMO DIARIO"
        Me.TopMost = True
        CType(Me.dgPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents dgPedidos As DataGridView
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPedidosFecha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNuevoPedido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalPedidos As TextBox
    Friend WithEvents numlote As DataGridViewTextBoxColumn
    Friend WithEvents semilla As DataGridViewTextBoxColumn
    Friend WithEvents variedad As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents pedido As DataGridViewTextBoxColumn
    Friend WithEvents plantas As DataGridViewTextBoxColumn
End Class
