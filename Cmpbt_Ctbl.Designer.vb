<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cmpbt_Ctbl
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtp_FechaCmpbte = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataAsiento = New System.Windows.Forms.DataGridView()
        Me.linea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ccosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.glosacomprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numdoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecvcto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_TipoCmpbte = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkCliente = New System.Windows.Forms.CheckBox()
        Me.txt_clientebuscar = New System.Windows.Forms.TextBox()
        Me.dtp_FechaVcto = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_Num_Doc = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmb_Tipo_Doc = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rdb_RutPRO = New System.Windows.Forms.RadioButton()
        Me.txt_DescripCCosto = New System.Windows.Forms.TextBox()
        Me.txt_DescripCuenta = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_GlosaMovimiento = New System.Windows.Forms.TextBox()
        Me.txt_NombreCliente = New System.Windows.Forms.MaskedTextBox()
        Me.btn_BuscarRUT = New System.Windows.Forms.Button()
        Me.txt_Rut = New System.Windows.Forms.TextBox()
        Me.rdb_Personal = New System.Windows.Forms.RadioButton()
        Me.rdb_RutCLi = New System.Windows.Forms.RadioButton()
        Me.txt_Ccosto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_MontoDebe = New System.Windows.Forms.TextBox()
        Me.txt_MontoHaber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_CtaTble = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Glosa = New System.Windows.Forms.TextBox()
        Me.txt_TotalDEBE = New System.Windows.Forms.TextBox()
        Me.txt_TotalHABER = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrabarComprobanteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_NumCpmbte = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Referencia = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtDiferencia = New System.Windows.Forms.TextBox()
        CType(Me.DataAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Referencia.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtp_FechaCmpbte
        '
        Me.dtp_FechaCmpbte.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FechaCmpbte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaCmpbte.Location = New System.Drawing.Point(158, 73)
        Me.dtp_FechaCmpbte.Name = "dtp_FechaCmpbte"
        Me.dtp_FechaCmpbte.Size = New System.Drawing.Size(97, 25)
        Me.dtp_FechaCmpbte.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha Comprobante"
        '
        'DataAsiento
        '
        Me.DataAsiento.AllowUserToAddRows = False
        Me.DataAsiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataAsiento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataAsiento.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataAsiento.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataAsiento.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.DataAsiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataAsiento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.linea, Me.Cuenta, Me.Descrip, Me.Debe, Me.Haber, Me.ccosto, Me.descc, Me.rut, Me.glosacomprobante, Me.tipo, Me.numdoc, Me.fecvcto})
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataAsiento.DefaultCellStyle = DataGridViewCellStyle22
        Me.DataAsiento.Location = New System.Drawing.Point(15, 443)
        Me.DataAsiento.Name = "DataAsiento"
        Me.DataAsiento.ReadOnly = True
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataAsiento.RowHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.DataAsiento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.MidnightBlue
        Me.DataAsiento.RowsDefaultCellStyle = DataGridViewCellStyle24
        Me.DataAsiento.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataAsiento.RowTemplate.Height = 24
        Me.DataAsiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataAsiento.Size = New System.Drawing.Size(1208, 185)
        Me.DataAsiento.TabIndex = 2
        '
        'linea
        '
        Me.linea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.linea.HeaderText = "Id.Movto"
        Me.linea.Name = "linea"
        Me.linea.ReadOnly = True
        Me.linea.Width = 90
        '
        'Cuenta
        '
        Me.Cuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Cuenta.HeaderText = "Cta.Ctble."
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.ReadOnly = True
        Me.Cuenta.Width = 98
        '
        'Descrip
        '
        Me.Descrip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Descrip.HeaderText = "Descripción"
        Me.Descrip.Name = "Descrip"
        Me.Descrip.ReadOnly = True
        Me.Descrip.Width = 112
        '
        'Debe
        '
        Me.Debe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Debe.DefaultCellStyle = DataGridViewCellStyle20
        Me.Debe.HeaderText = "Debe"
        Me.Debe.Name = "Debe"
        Me.Debe.ReadOnly = True
        Me.Debe.Width = 68
        '
        'Haber
        '
        Me.Haber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Haber.DefaultCellStyle = DataGridViewCellStyle21
        Me.Haber.HeaderText = "Haber"
        Me.Haber.Name = "Haber"
        Me.Haber.ReadOnly = True
        Me.Haber.Width = 73
        '
        'ccosto
        '
        Me.ccosto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ccosto.HeaderText = "Cta. CC"
        Me.ccosto.Name = "ccosto"
        Me.ccosto.ReadOnly = True
        Me.ccosto.Width = 86
        '
        'descc
        '
        Me.descc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.descc.HeaderText = "Centro Costo"
        Me.descc.Name = "descc"
        Me.descc.ReadOnly = True
        Me.descc.Width = 123
        '
        'rut
        '
        Me.rut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.rut.HeaderText = "Rut"
        Me.rut.Name = "rut"
        Me.rut.ReadOnly = True
        Me.rut.Width = 56
        '
        'glosacomprobante
        '
        Me.glosacomprobante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.glosacomprobante.HeaderText = "Glosa"
        Me.glosacomprobante.Name = "glosacomprobante"
        Me.glosacomprobante.ReadOnly = True
        Me.glosacomprobante.Width = 73
        '
        'tipo
        '
        Me.tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.tipo.HeaderText = "Tipo Doc."
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        Me.tipo.Width = 98
        '
        'numdoc
        '
        Me.numdoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.numdoc.HeaderText = "N° Doc"
        Me.numdoc.Name = "numdoc"
        Me.numdoc.ReadOnly = True
        Me.numdoc.Width = 82
        '
        'fecvcto
        '
        Me.fecvcto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.fecvcto.HeaderText = "F.Vcto"
        Me.fecvcto.Name = "fecvcto"
        Me.fecvcto.ReadOnly = True
        Me.fecvcto.Width = 76
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(420, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tipo"
        '
        'cmb_TipoCmpbte
        '
        Me.cmb_TipoCmpbte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoCmpbte.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_TipoCmpbte.FormattingEnabled = True
        Me.cmb_TipoCmpbte.Items.AddRange(New Object() {"Ingreso", "Egreso", "Traspaso"})
        Me.cmb_TipoCmpbte.Location = New System.Drawing.Point(420, 73)
        Me.cmb_TipoCmpbte.Name = "cmb_TipoCmpbte"
        Me.cmb_TipoCmpbte.Size = New System.Drawing.Size(143, 28)
        Me.cmb_TipoCmpbte.TabIndex = 49
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Referencia)
        Me.GroupBox1.Controls.Add(Me.txt_DescripCCosto)
        Me.GroupBox1.Controls.Add(Me.txt_DescripCuenta)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_GlosaMovimiento)
        Me.GroupBox1.Controls.Add(Me.txt_Ccosto)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_MontoDebe)
        Me.GroupBox1.Controls.Add(Me.txt_MontoHaber)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_CtaTble)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1223, 315)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Movimiento Contable"
        '
        'chkCliente
        '
        Me.chkCliente.AutoSize = True
        Me.chkCliente.Enabled = False
        Me.chkCliente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCliente.Location = New System.Drawing.Point(162, 92)
        Me.chkCliente.Name = "chkCliente"
        Me.chkCliente.Size = New System.Drawing.Size(166, 18)
        Me.chkCliente.TabIndex = 113
        Me.chkCliente.Text = "incluye primer nombre cliente"
        Me.chkCliente.UseVisualStyleBackColor = True
        '
        'txt_clientebuscar
        '
        Me.txt_clientebuscar.BackColor = System.Drawing.SystemColors.Window
        Me.txt_clientebuscar.Enabled = False
        Me.txt_clientebuscar.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clientebuscar.ForeColor = System.Drawing.Color.Navy
        Me.txt_clientebuscar.Location = New System.Drawing.Point(162, 68)
        Me.txt_clientebuscar.Name = "txt_clientebuscar"
        Me.txt_clientebuscar.Size = New System.Drawing.Size(166, 24)
        Me.txt_clientebuscar.TabIndex = 111
        '
        'dtp_FechaVcto
        '
        Me.dtp_FechaVcto.Enabled = False
        Me.dtp_FechaVcto.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FechaVcto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaVcto.Location = New System.Drawing.Point(501, 116)
        Me.dtp_FechaVcto.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtp_FechaVcto.Name = "dtp_FechaVcto"
        Me.dtp_FechaVcto.Size = New System.Drawing.Size(134, 25)
        Me.dtp_FechaVcto.TabIndex = 83
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(409, 120)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 17)
        Me.Label16.TabIndex = 82
        Me.Label16.Text = "Fecha Vcto."
        '
        'txt_Num_Doc
        '
        Me.txt_Num_Doc.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Num_Doc.Location = New System.Drawing.Point(284, 116)
        Me.txt_Num_Doc.MaxLength = 7
        Me.txt_Num_Doc.Name = "txt_Num_Doc"
        Me.txt_Num_Doc.Size = New System.Drawing.Size(104, 25)
        Me.txt_Num_Doc.TabIndex = 81
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(221, 120)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 17)
        Me.Label15.TabIndex = 80
        Me.Label15.Text = "N° Doc"
        '
        'cmb_Tipo_Doc
        '
        Me.cmb_Tipo_Doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Tipo_Doc.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Tipo_Doc.FormattingEnabled = True
        Me.cmb_Tipo_Doc.Items.AddRange(New Object() {"FA", "BE", "CH", "EF", "TR", "LE", "PE", "BL"})
        Me.cmb_Tipo_Doc.Location = New System.Drawing.Point(162, 116)
        Me.cmb_Tipo_Doc.Name = "cmb_Tipo_Doc"
        Me.cmb_Tipo_Doc.Size = New System.Drawing.Size(48, 25)
        Me.cmb_Tipo_Doc.TabIndex = 69
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(73, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 17)
        Me.Label14.TabIndex = 79
        Me.Label14.Text = "Tipo Doc."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(35, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 17)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Nombre a buscar"
        '
        'rdb_RutPRO
        '
        Me.rdb_RutPRO.AutoSize = True
        Me.rdb_RutPRO.Enabled = False
        Me.rdb_RutPRO.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_RutPRO.Location = New System.Drawing.Point(509, 13)
        Me.rdb_RutPRO.Name = "rdb_RutPRO"
        Me.rdb_RutPRO.Size = New System.Drawing.Size(93, 21)
        Me.rdb_RutPRO.TabIndex = 78
        Me.rdb_RutPRO.TabStop = True
        Me.rdb_RutPRO.Text = "Proveedor"
        Me.rdb_RutPRO.UseVisualStyleBackColor = True
        '
        'txt_DescripCCosto
        '
        Me.txt_DescripCCosto.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DescripCCosto.Location = New System.Drawing.Point(805, 53)
        Me.txt_DescripCCosto.MaxLength = 100
        Me.txt_DescripCCosto.Name = "txt_DescripCCosto"
        Me.txt_DescripCCosto.ReadOnly = True
        Me.txt_DescripCCosto.Size = New System.Drawing.Size(377, 25)
        Me.txt_DescripCCosto.TabIndex = 77
        '
        'txt_DescripCuenta
        '
        Me.txt_DescripCuenta.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DescripCuenta.Location = New System.Drawing.Point(198, 53)
        Me.txt_DescripCuenta.MaxLength = 100
        Me.txt_DescripCuenta.Name = "txt_DescripCuenta"
        Me.txt_DescripCuenta.ReadOnly = True
        Me.txt_DescripCuenta.Size = New System.Drawing.Size(532, 25)
        Me.txt_DescripCuenta.TabIndex = 69
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(647, 97)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(123, 17)
        Me.Label13.TabIndex = 69
        Me.Label13.Text = "Glosa Movimiento"
        '
        'txt_GlosaMovimiento
        '
        Me.txt_GlosaMovimiento.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_GlosaMovimiento.Location = New System.Drawing.Point(650, 117)
        Me.txt_GlosaMovimiento.MaxLength = 100
        Me.txt_GlosaMovimiento.Name = "txt_GlosaMovimiento"
        Me.txt_GlosaMovimiento.Size = New System.Drawing.Size(532, 25)
        Me.txt_GlosaMovimiento.TabIndex = 69
        '
        'txt_NombreCliente
        '
        Me.txt_NombreCliente.BackColor = System.Drawing.Color.Navy
        Me.txt_NombreCliente.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NombreCliente.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_NombreCliente.Location = New System.Drawing.Point(641, 69)
        Me.txt_NombreCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_NombreCliente.Name = "txt_NombreCliente"
        Me.txt_NombreCliente.ReadOnly = True
        Me.txt_NombreCliente.Size = New System.Drawing.Size(532, 25)
        Me.txt_NombreCliente.TabIndex = 75
        '
        'btn_BuscarRUT
        '
        Me.btn_BuscarRUT.Enabled = False
        Me.btn_BuscarRUT.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_BuscarRUT.Image = Global.GestionVivero.My.Resources.Resources.buscar_40x40
        Me.btn_BuscarRUT.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_BuscarRUT.Location = New System.Drawing.Point(340, 62)
        Me.btn_BuscarRUT.Name = "btn_BuscarRUT"
        Me.btn_BuscarRUT.Size = New System.Drawing.Size(48, 48)
        Me.btn_BuscarRUT.TabIndex = 74
        Me.btn_BuscarRUT.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btn_BuscarRUT.UseVisualStyleBackColor = True
        '
        'txt_Rut
        '
        Me.txt_Rut.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Rut.Location = New System.Drawing.Point(501, 69)
        Me.txt_Rut.MaxLength = 7
        Me.txt_Rut.Name = "txt_Rut"
        Me.txt_Rut.ReadOnly = True
        Me.txt_Rut.Size = New System.Drawing.Size(134, 25)
        Me.txt_Rut.TabIndex = 72
        '
        'rdb_Personal
        '
        Me.rdb_Personal.AutoSize = True
        Me.rdb_Personal.Enabled = False
        Me.rdb_Personal.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_Personal.Location = New System.Drawing.Point(643, 13)
        Me.rdb_Personal.Name = "rdb_Personal"
        Me.rdb_Personal.Size = New System.Drawing.Size(84, 21)
        Me.rdb_Personal.TabIndex = 71
        Me.rdb_Personal.TabStop = True
        Me.rdb_Personal.Text = "Personal"
        Me.rdb_Personal.UseVisualStyleBackColor = True
        '
        'rdb_RutCLi
        '
        Me.rdb_RutCLi.AutoSize = True
        Me.rdb_RutCLi.Enabled = False
        Me.rdb_RutCLi.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_RutCLi.Location = New System.Drawing.Point(389, 13)
        Me.rdb_RutCLi.Name = "rdb_RutCLi"
        Me.rdb_RutCLi.Size = New System.Drawing.Size(71, 21)
        Me.rdb_RutCLi.TabIndex = 71
        Me.rdb_RutCLi.TabStop = True
        Me.rdb_RutCLi.Text = "Cliente"
        Me.rdb_RutCLi.UseVisualStyleBackColor = True
        '
        'txt_Ccosto
        '
        Me.txt_Ccosto.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Ccosto.Location = New System.Drawing.Point(753, 53)
        Me.txt_Ccosto.MaxLength = 3
        Me.txt_Ccosto.Name = "txt_Ccosto"
        Me.txt_Ccosto.Size = New System.Drawing.Size(46, 25)
        Me.txt_Ccosto.TabIndex = 59
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(750, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 17)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Centro Costo"
        '
        'txt_MontoDebe
        '
        Me.txt_MontoDebe.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MontoDebe.Location = New System.Drawing.Point(330, 117)
        Me.txt_MontoDebe.MaxLength = 10
        Me.txt_MontoDebe.Name = "txt_MontoDebe"
        Me.txt_MontoDebe.Size = New System.Drawing.Size(125, 25)
        Me.txt_MontoDebe.TabIndex = 57
        '
        'txt_MontoHaber
        '
        Me.txt_MontoHaber.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MontoHaber.Location = New System.Drawing.Point(480, 117)
        Me.txt_MontoHaber.MaxLength = 10
        Me.txt_MontoHaber.Name = "txt_MontoHaber"
        Me.txt_MontoHaber.Size = New System.Drawing.Size(115, 25)
        Me.txt_MontoHaber.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(493, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 17)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "H A B E R"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(358, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "D E B E"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(195, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 17)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Nombre Cuenta Contable"
        '
        'txt_CtaTble
        '
        Me.txt_CtaTble.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CtaTble.Location = New System.Drawing.Point(21, 53)
        Me.txt_CtaTble.MaxLength = 7
        Me.txt_CtaTble.Name = "txt_CtaTble"
        Me.txt_CtaTble.Size = New System.Drawing.Size(115, 25)
        Me.txt_CtaTble.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 17)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Cuenta Contable"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(650, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 17)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Glosa Comprobante"
        '
        'txt_Glosa
        '
        Me.txt_Glosa.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Glosa.Location = New System.Drawing.Point(650, 75)
        Me.txt_Glosa.MaxLength = 100
        Me.txt_Glosa.Name = "txt_Glosa"
        Me.txt_Glosa.Size = New System.Drawing.Size(532, 24)
        Me.txt_Glosa.TabIndex = 58
        '
        'txt_TotalDEBE
        '
        Me.txt_TotalDEBE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalDEBE.Location = New System.Drawing.Point(317, 655)
        Me.txt_TotalDEBE.MaxLength = 7
        Me.txt_TotalDEBE.Name = "txt_TotalDEBE"
        Me.txt_TotalDEBE.ReadOnly = True
        Me.txt_TotalDEBE.Size = New System.Drawing.Size(153, 26)
        Me.txt_TotalDEBE.TabIndex = 64
        Me.txt_TotalDEBE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_TotalHABER
        '
        Me.txt_TotalHABER.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalHABER.Location = New System.Drawing.Point(660, 655)
        Me.txt_TotalHABER.MaxLength = 7
        Me.txt_TotalHABER.Name = "txt_TotalHABER"
        Me.txt_TotalHABER.ReadOnly = True
        Me.txt_TotalHABER.Size = New System.Drawing.Size(153, 26)
        Me.txt_TotalHABER.TabIndex = 63
        Me.txt_TotalHABER.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(490, 659)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(156, 18)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "T O T A L    H A B E R"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(171, 659)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 18)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "T O T A L   D E B E"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1334, 26)
        Me.MenuStrip1.TabIndex = 66
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.GrabarComprobanteToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(88, 22)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(280, 22)
        Me.ToolStripMenuItem1.Text = "Nuevo Comprobante"
        '
        'GrabarComprobanteToolStripMenuItem
        '
        Me.GrabarComprobanteToolStripMenuItem.Name = "GrabarComprobanteToolStripMenuItem"
        Me.GrabarComprobanteToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.GrabarComprobanteToolStripMenuItem.Text = "Guardar Comprobante Actual"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(183, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.SalirToolStripMenuItem.Text = "Cerrar Módulo"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(26, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 20)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "N° Comprobante"
        '
        'txt_NumCpmbte
        '
        Me.txt_NumCpmbte.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NumCpmbte.Location = New System.Drawing.Point(158, 28)
        Me.txt_NumCpmbte.MaxLength = 15
        Me.txt_NumCpmbte.Name = "txt_NumCpmbte"
        Me.txt_NumCpmbte.Size = New System.Drawing.Size(97, 25)
        Me.txt_NumCpmbte.TabIndex = 62
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.buscar_40x40
        Me.Button1.Location = New System.Drawing.Point(267, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 48)
        Me.Button1.TabIndex = 68
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = Global.GestionVivero.My.Resources.Resources.eliminar_40x40
        Me.btnEliminar.Location = New System.Drawing.Point(1251, 497)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(48, 48)
        Me.btnEliminar.TabIndex = 60
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = Global.GestionVivero.My.Resources.Resources.guardar_40x40
        Me.btnAgregar.Location = New System.Drawing.Point(1251, 188)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(48, 48)
        Me.btnAgregar.TabIndex = 59
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Referencia
        '
        Me.Referencia.Controls.Add(Me.Label17)
        Me.Referencia.Controls.Add(Me.dtp_FechaVcto)
        Me.Referencia.Controls.Add(Me.chkCliente)
        Me.Referencia.Controls.Add(Me.Label16)
        Me.Referencia.Controls.Add(Me.txt_NombreCliente)
        Me.Referencia.Controls.Add(Me.txt_Num_Doc)
        Me.Referencia.Controls.Add(Me.txt_clientebuscar)
        Me.Referencia.Controls.Add(Me.Label15)
        Me.Referencia.Controls.Add(Me.txt_Rut)
        Me.Referencia.Controls.Add(Me.cmb_Tipo_Doc)
        Me.Referencia.Controls.Add(Me.rdb_RutPRO)
        Me.Referencia.Controls.Add(Me.Label14)
        Me.Referencia.Controls.Add(Me.rdb_RutCLi)
        Me.Referencia.Controls.Add(Me.rdb_Personal)
        Me.Referencia.Controls.Add(Me.btn_BuscarRUT)
        Me.Referencia.Controls.Add(Me.Label9)
        Me.Referencia.Location = New System.Drawing.Point(12, 157)
        Me.Referencia.Name = "Referencia"
        Me.Referencia.Size = New System.Drawing.Size(1198, 152)
        Me.Referencia.TabIndex = 114
        Me.Referencia.TabStop = False
        Me.Referencia.Text = "Datos de Referencia para Cuenta Contable"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(457, 72)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 17)
        Me.Label17.TabIndex = 114
        Me.Label17.Text = "RUT"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(195, 117)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(124, 17)
        Me.Label18.TabIndex = 115
        Me.Label18.Text = "Monto Movimiento"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(827, 659)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 18)
        Me.Label19.TabIndex = 69
        Me.Label19.Text = "Diferencia :"
        '
        'txtDiferencia
        '
        Me.txtDiferencia.BackColor = System.Drawing.Color.White
        Me.txtDiferencia.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferencia.ForeColor = System.Drawing.Color.Red
        Me.txtDiferencia.Location = New System.Drawing.Point(921, 655)
        Me.txtDiferencia.MaxLength = 7
        Me.txtDiferencia.Name = "txtDiferencia"
        Me.txtDiferencia.ReadOnly = True
        Me.txtDiferencia.Size = New System.Drawing.Size(153, 26)
        Me.txtDiferencia.TabIndex = 70
        Me.txtDiferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Cmpbt_Ctbl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1334, 716)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtDiferencia)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_NumCpmbte)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txt_TotalDEBE)
        Me.Controls.Add(Me.txt_TotalHABER)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_Glosa)
        Me.Controls.Add(Me.cmb_TipoCmpbte)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataAsiento)
        Me.Controls.Add(Me.dtp_FechaCmpbte)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.MediumBlue
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Cmpbt_Ctbl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COMPROBANTE CONTABLE - Módulo de Contabilidad"
        CType(Me.DataAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Referencia.ResumeLayout(False)
        Me.Referencia.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtp_FechaCmpbte As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataAsiento As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoCmpbte As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_CtaTble As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_MontoDebe As System.Windows.Forms.TextBox
    Friend WithEvents txt_MontoHaber As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_Glosa As System.Windows.Forms.TextBox
    Friend WithEvents txt_Ccosto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txt_TotalDEBE As System.Windows.Forms.TextBox
    Friend WithEvents txt_TotalHABER As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrabarComprobanteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_NumCpmbte As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rdb_Personal As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_RutCLi As System.Windows.Forms.RadioButton
    Friend WithEvents txt_Rut As System.Windows.Forms.TextBox
    Friend WithEvents btn_BuscarRUT As System.Windows.Forms.Button
    Friend WithEvents txt_NombreCliente As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_GlosaMovimiento As System.Windows.Forms.TextBox
    Friend WithEvents txt_DescripCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txt_DescripCCosto As System.Windows.Forms.TextBox
    Friend WithEvents rdb_RutPRO As System.Windows.Forms.RadioButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmb_Tipo_Doc As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Num_Doc As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaVcto As System.Windows.Forms.DateTimePicker
    Friend WithEvents linea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descrip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ccosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents glosacomprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numdoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecvcto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkCliente As CheckBox
    Friend WithEvents txt_clientebuscar As TextBox
    Friend WithEvents Referencia As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtDiferencia As TextBox
End Class
