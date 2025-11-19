<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Busqueda_Proveedor
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
        Me.DataProveedor = New System.Windows.Forms.DataGridView
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.rut = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.comuna = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.rutnoedit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idcliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataProveedor
        '
        Me.DataProveedor.AllowUserToAddRows = False
        Me.DataProveedor.AllowUserToDeleteRows = False
        Me.DataProveedor.AllowUserToResizeColumns = False
        Me.DataProveedor.AllowUserToResizeRows = False
        Me.DataProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataProveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rut, Me.Nombre, Me.direccion, Me.comuna, Me.rutnoedit, Me.idcliente})
        Me.DataProveedor.Location = New System.Drawing.Point(12, 12)
        Me.DataProveedor.Name = "DataProveedor"
        Me.DataProveedor.ReadOnly = True
        Me.DataProveedor.RowHeadersVisible = False
        Me.DataProveedor.Size = New System.Drawing.Size(642, 335)
        Me.DataProveedor.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(444, 364)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(124, 364)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Seleccionar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rut
        '
        Me.rut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.rut.HeaderText = "Rut"
        Me.rut.Name = "rut"
        Me.rut.Width = 49
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Proveedor"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 303
        '
        'direccion
        '
        Me.direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.direccion.HeaderText = "Dirección"
        Me.direccion.Name = "direccion"
        Me.direccion.Width = 77
        '
        'comuna
        '
        Me.comuna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.comuna.HeaderText = "Comuna"
        Me.comuna.Name = "comuna"
        Me.comuna.Width = 71
        '
        'rutnoedit
        '
        Me.rutnoedit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.rutnoedit.HeaderText = "Ciudad"
        Me.rutnoedit.Name = "rutnoedit"
        Me.rutnoedit.Width = 65
        '
        'idcliente
        '
        Me.idcliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.idcliente.HeaderText = "Teléfono"
        Me.idcliente.Name = "idcliente"
        Me.idcliente.Width = 74
        '
        'Busqueda_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 399)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataProveedor)
        Me.Name = "Busqueda_Proveedor"
        Me.Text = "Busqueda de Proveedor"
        Me.TopMost = True
        CType(Me.DataProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataProveedor As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents rut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comuna As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rutnoedit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idcliente As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
