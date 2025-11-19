<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listado_Proveedor
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GrillaProveedor = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.rut = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.direc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.comuna = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ciudad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Telef = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Giro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.coment = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.GrillaProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(258, 33)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(313, 20)
        Me.txt_nombre.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Proveedor a Buscar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GrillaProveedor)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(868, 443)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Proveedores"
        '
        'GrillaProveedor
        '
        Me.GrillaProveedor.AllowUserToAddRows = False
        Me.GrillaProveedor.AllowUserToDeleteRows = False
        Me.GrillaProveedor.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.GrillaProveedor.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GrillaProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.GrillaProveedor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.GrillaProveedor.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.GrillaProveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GrillaProveedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrillaProveedor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GrillaProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaProveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rut, Me.nombre, Me.direc, Me.comuna, Me.ciudad, Me.Telef, Me.email, Me.Giro, Me.coment})
        Me.GrillaProveedor.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrillaProveedor.DefaultCellStyle = DataGridViewCellStyle3
        Me.GrillaProveedor.GridColor = System.Drawing.Color.White
        Me.GrillaProveedor.Location = New System.Drawing.Point(6, 19)
        Me.GrillaProveedor.Name = "GrillaProveedor"
        Me.GrillaProveedor.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrillaProveedor.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GrillaProveedor.RowHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.GrillaProveedor.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.GrillaProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GrillaProveedor.Size = New System.Drawing.Size(856, 418)
        Me.GrillaProveedor.StandardTab = True
        Me.GrillaProveedor.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(386, 515)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(592, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 30)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Consulta"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'rut
        '
        Me.rut.HeaderText = "Rut"
        Me.rut.Name = "rut"
        Me.rut.ReadOnly = True
        Me.rut.Width = 52
        '
        'nombre
        '
        Me.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 78
        '
        'direc
        '
        Me.direc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.direc.HeaderText = "Dirección"
        Me.direc.Name = "direc"
        Me.direc.ReadOnly = True
        Me.direc.Width = 85
        '
        'comuna
        '
        Me.comuna.HeaderText = "Comuna"
        Me.comuna.Name = "comuna"
        Me.comuna.ReadOnly = True
        Me.comuna.Width = 81
        '
        'ciudad
        '
        Me.ciudad.HeaderText = "Ciudad"
        Me.ciudad.Name = "ciudad"
        Me.ciudad.ReadOnly = True
        Me.ciudad.Width = 73
        '
        'Telef
        '
        Me.Telef.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Telef.HeaderText = "Teléfonos"
        Me.Telef.Name = "Telef"
        Me.Telef.ReadOnly = True
        Me.Telef.Width = 88
        '
        'email
        '
        Me.email.HeaderText = "eMail"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Width = 62
        '
        'Giro
        '
        Me.Giro.HeaderText = "Giro"
        Me.Giro.Name = "Giro"
        Me.Giro.ReadOnly = True
        Me.Giro.Width = 56
        '
        'coment
        '
        Me.coment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.coment.HeaderText = "Observaciones"
        Me.coment.Name = "coment"
        Me.coment.ReadOnly = True
        '
        'Listado_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 566)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nombre)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Listado_Proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Proveedores"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GrillaProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents GrillaProveedor As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents rut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents direc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comuna As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ciudad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telef As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Giro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coment As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
