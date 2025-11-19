<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cartola_Proveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cartola_Proveedor))
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txt_Ciudad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Comuna = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_RutProveedor = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataCartola = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_totalPagos = New System.Windows.Forms.MaskedTextBox()
        Me.TXT_TotalDeuda = New System.Windows.Forms.MaskedTextBox()
        Me.txt_totalCompras = New System.Windows.Forms.MaskedTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipocompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valordoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pasgado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataCartola, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_Ciudad)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_Comuna)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_telefono)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_direccion)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.txt_RutProveedor)
        Me.GroupBox2.Controls.Add(Me.txt_nombre)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(585, 137)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Antecedentes Proveedor"
        '
        'Button3
        '
        Me.Button3.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button3.Location = New System.Drawing.Point(697, 66)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(46, 47)
        Me.Button3.TabIndex = 17
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txt_Ciudad
        '
        Me.txt_Ciudad.Enabled = False
        Me.txt_Ciudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Ciudad.Location = New System.Drawing.Point(344, 80)
        Me.txt_Ciudad.Name = "txt_Ciudad"
        Me.txt_Ciudad.ReadOnly = True
        Me.txt_Ciudad.Size = New System.Drawing.Size(193, 20)
        Me.txt_Ciudad.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(298, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Ciudad"
        '
        'txt_Comuna
        '
        Me.txt_Comuna.Enabled = False
        Me.txt_Comuna.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Comuna.Location = New System.Drawing.Point(67, 83)
        Me.txt_Comuna.Name = "txt_Comuna"
        Me.txt_Comuna.ReadOnly = True
        Me.txt_Comuna.Size = New System.Drawing.Size(193, 20)
        Me.txt_Comuna.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Comuna"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Rut"
        '
        'txt_telefono
        '
        Me.txt_telefono.Enabled = False
        Me.txt_telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefono.Location = New System.Drawing.Point(67, 111)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.ReadOnly = True
        Me.txt_telefono.Size = New System.Drawing.Size(408, 20)
        Me.txt_telefono.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Teléfono"
        '
        'txt_direccion
        '
        Me.txt_direccion.Enabled = False
        Me.txt_direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_direccion.Location = New System.Drawing.Point(67, 54)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.ReadOnly = True
        Me.txt_direccion.Size = New System.Drawing.Size(408, 20)
        Me.txt_direccion.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Dirección"
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.Location = New System.Drawing.Point(481, 26)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(23, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txt_RutProveedor
        '
        Me.txt_RutProveedor.Enabled = False
        Me.txt_RutProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RutProveedor.HidePromptOnLeave = True
        Me.txt_RutProveedor.Location = New System.Drawing.Point(67, 27)
        Me.txt_RutProveedor.Name = "txt_RutProveedor"
        Me.txt_RutProveedor.ReadOnly = True
        Me.txt_RutProveedor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_RutProveedor.Size = New System.Drawing.Size(94, 20)
        Me.txt_RutProveedor.TabIndex = 0
        Me.txt_RutProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_nombre
        '
        Me.txt_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(167, 27)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(308, 20)
        Me.txt_nombre.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataCartola)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 169)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(807, 329)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Compras"
        '
        'DataCartola
        '
        Me.DataCartola.AllowUserToAddRows = False
        Me.DataCartola.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataCartola.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataCartola.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataCartola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataCartola.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tipo, Me.doc, Me.Fecha, Me.tipocompra, Me.valordoc, Me.pasgado, Me.saldo})
        Me.DataCartola.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataCartola.Location = New System.Drawing.Point(3, 16)
        Me.DataCartola.Name = "DataCartola"
        Me.DataCartola.ReadOnly = True
        Me.DataCartola.RowHeadersVisible = False
        Me.DataCartola.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataCartola.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataCartola.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataCartola.Size = New System.Drawing.Size(801, 310)
        Me.DataCartola.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Controls.Add(Me.txt_totalPagos)
        Me.GroupBox4.Controls.Add(Me.TXT_TotalDeuda)
        Me.GroupBox4.Controls.Add(Me.txt_totalCompras)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Location = New System.Drawing.Point(55, 504)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(688, 39)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "SALDOS CARTOLA"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox6.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox6.Controls.Add(Me.MaskedTextBox3)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Location = New System.Drawing.Point(3, 46)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(561, 40)
        Me.GroupBox6.TabIndex = 41
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "SALDOS CARTOLA"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox1.HidePromptOnLeave = True
        Me.MaskedTextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MaskedTextBox1.Location = New System.Drawing.Point(290, 13)
        Me.MaskedTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.ReadOnly = True
        Me.MaskedTextBox1.Size = New System.Drawing.Size(67, 22)
        Me.MaskedTextBox1.TabIndex = 40
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MaskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox2.HidePromptOnLeave = True
        Me.MaskedTextBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MaskedTextBox2.Location = New System.Drawing.Point(481, 13)
        Me.MaskedTextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.ReadOnly = True
        Me.MaskedTextBox2.Size = New System.Drawing.Size(67, 22)
        Me.MaskedTextBox2.TabIndex = 34
        Me.MaskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MaskedTextBox2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox3.HidePromptOnLeave = True
        Me.MaskedTextBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MaskedTextBox3.Location = New System.Drawing.Point(108, 13)
        Me.MaskedTextBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.ReadOnly = True
        Me.MaskedTextBox3.Size = New System.Drawing.Size(67, 22)
        Me.MaskedTextBox3.TabIndex = 37
        Me.MaskedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MaskedTextBox3.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(416, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 14)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Saldo Final"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(220, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 14)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Total Canjes"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(36, 18)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(69, 14)
        Me.Label23.TabIndex = 37
        Me.Label23.Text = "Total Abonos"
        '
        'txt_totalPagos
        '
        Me.txt_totalPagos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalPagos.HidePromptOnLeave = True
        Me.txt_totalPagos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_totalPagos.Location = New System.Drawing.Point(289, 13)
        Me.txt_totalPagos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_totalPagos.Name = "txt_totalPagos"
        Me.txt_totalPagos.ReadOnly = True
        Me.txt_totalPagos.Size = New System.Drawing.Size(93, 22)
        Me.txt_totalPagos.TabIndex = 40
        Me.txt_totalPagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_totalPagos.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'TXT_TotalDeuda
        '
        Me.TXT_TotalDeuda.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TotalDeuda.HidePromptOnLeave = True
        Me.TXT_TotalDeuda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TXT_TotalDeuda.Location = New System.Drawing.Point(484, 13)
        Me.TXT_TotalDeuda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_TotalDeuda.Name = "TXT_TotalDeuda"
        Me.TXT_TotalDeuda.ReadOnly = True
        Me.TXT_TotalDeuda.Size = New System.Drawing.Size(93, 22)
        Me.TXT_TotalDeuda.TabIndex = 34
        Me.TXT_TotalDeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TXT_TotalDeuda.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txt_totalCompras
        '
        Me.txt_totalCompras.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalCompras.HidePromptOnLeave = True
        Me.txt_totalCompras.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_totalCompras.Location = New System.Drawing.Point(112, 13)
        Me.txt_totalCompras.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_totalCompras.Name = "txt_totalCompras"
        Me.txt_totalCompras.ReadOnly = True
        Me.txt_totalCompras.Size = New System.Drawing.Size(93, 22)
        Me.txt_totalCompras.TabIndex = 37
        Me.txt_totalCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_totalCompras.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(418, 18)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 14)
        Me.Label21.TabIndex = 39
        Me.Label21.Text = "Saldo Final"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(224, 18)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 14)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "Total Pagos"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(36, 18)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 14)
        Me.Label19.TabIndex = 37
        Me.Label19.Text = "Total Compras"
        '
        'tipo
        '
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        Me.tipo.Width = 53
        '
        'doc
        '
        Me.doc.HeaderText = "Nro. Documento"
        Me.doc.Name = "doc"
        Me.doc.ReadOnly = True
        Me.doc.Width = 101
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 62
        '
        'tipocompra
        '
        Me.tipocompra.HeaderText = "Tipo Compra"
        Me.tipocompra.Name = "tipocompra"
        Me.tipocompra.ReadOnly = True
        Me.tipocompra.Width = 85
        '
        'valordoc
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.valordoc.DefaultCellStyle = DataGridViewCellStyle5
        Me.valordoc.HeaderText = "Total Compra"
        Me.valordoc.Name = "valordoc"
        Me.valordoc.ReadOnly = True
        Me.valordoc.Width = 87
        '
        'pasgado
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.pasgado.DefaultCellStyle = DataGridViewCellStyle6
        Me.pasgado.HeaderText = "Valor Pagado"
        Me.pasgado.Name = "pasgado"
        Me.pasgado.ReadOnly = True
        Me.pasgado.Width = 88
        '
        'saldo
        '
        Me.saldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.saldo.DefaultCellStyle = DataGridViewCellStyle7
        Me.saldo.HeaderText = "Saldo"
        Me.saldo.Name = "saldo"
        Me.saldo.ReadOnly = True
        '
        'Cartola_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 545)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Cartola_Proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cartola Proveedor"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataCartola, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txt_RutProveedor As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataCartola As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Public WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Public WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Public WithEvents MaskedTextBox3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Public WithEvents txt_totalPagos As System.Windows.Forms.MaskedTextBox
    Public WithEvents TXT_TotalDeuda As System.Windows.Forms.MaskedTextBox
    Public WithEvents txt_totalCompras As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_Comuna As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Ciudad As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipocompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents valordoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pasgado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents saldo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
