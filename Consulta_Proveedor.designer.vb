<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta_Proveedor
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.txt_digrut = New System.Windows.Forms.MaskedTextBox
        Me.btn_BuscarProveedor = New System.Windows.Forms.Button
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.txt_Rut = New System.Windows.Forms.MaskedTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmb_proveedor = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txt_Documento = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_TotalPagos = New System.Windows.Forms.MaskedTextBox
        Me.txt_TotalCompra = New System.Windows.Forms.MaskedTextBox
        Me.doc_pagos = New System.Windows.Forms.DataGridView
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Banco = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Num = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fec = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.doc_detalle = New System.Windows.Forms.DataGridView
        Me.doc_header = New System.Windows.Forms.DataGridView
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ndoc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tipocompra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TXT_Giro = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.TXT_Contacto = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txt_digitorut = New System.Windows.Forms.MaskedTextBox
        Me.txt_rutproveedor = New System.Windows.Forms.MaskedTextBox
        Me.TXT_Comentarios = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txt_NOMBRES = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txt_fax = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txt_email = New System.Windows.Forms.TextBox
        Me.txt_telcelular = New System.Windows.Forms.TextBox
        Me.txt_teloficina = New System.Windows.Forms.TextBox
        Me.txt_telcasa = New System.Windows.Forms.TextBox
        Me.txt_ciudad = New System.Windows.Forms.TextBox
        Me.txt_comuna = New System.Windows.Forms.TextBox
        Me.txt_dircli = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Insumo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.semilla = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.variedad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Unidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.doc_pagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doc_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doc_header, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.txt_digrut)
        Me.GroupBox1.Controls.Add(Me.btn_BuscarProveedor)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.txt_Rut)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 95)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar Proveedor"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(15, 60)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(129, 19)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.Text = "Busca por Nombre"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(15, 29)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(109, 19)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Busca por RUT"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'txt_digrut
        '
        Me.txt_digrut.HidePromptOnLeave = True
        Me.txt_digrut.Location = New System.Drawing.Point(238, 27)
        Me.txt_digrut.Mask = "A"
        Me.txt_digrut.Name = "txt_digrut"
        Me.txt_digrut.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_digrut.Size = New System.Drawing.Size(17, 21)
        Me.txt_digrut.TabIndex = 1
        Me.txt_digrut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_BuscarProveedor
        '
        Me.btn_BuscarProveedor.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_BuscarProveedor.Location = New System.Drawing.Point(481, 35)
        Me.btn_BuscarProveedor.Name = "btn_BuscarProveedor"
        Me.btn_BuscarProveedor.Size = New System.Drawing.Size(77, 44)
        Me.btn_BuscarProveedor.TabIndex = 4
        Me.btn_BuscarProveedor.Tag = ""
        Me.btn_BuscarProveedor.Text = "Buscar Proveedor"
        Me.btn_BuscarProveedor.UseVisualStyleBackColor = True
        '
        'txt_nombre
        '
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Location = New System.Drawing.Point(150, 60)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.ReadOnly = True
        Me.txt_nombre.Size = New System.Drawing.Size(313, 21)
        Me.txt_nombre.TabIndex = 2
        '
        'txt_Rut
        '
        Me.txt_Rut.HidePromptOnLeave = True
        Me.txt_Rut.Location = New System.Drawing.Point(150, 27)
        Me.txt_Rut.Mask = "###########"
        Me.txt_Rut.Name = "txt_Rut"
        Me.txt_Rut.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Rut.Size = New System.Drawing.Size(82, 21)
        Me.txt_Rut.TabIndex = 0
        Me.txt_Rut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Seleccione Proveedor"
        '
        'cmb_proveedor
        '
        Me.cmb_proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_proveedor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_proveedor.FormattingEnabled = True
        Me.cmb_proveedor.Location = New System.Drawing.Point(144, 20)
        Me.cmb_proveedor.Name = "cmb_proveedor"
        Me.cmb_proveedor.Size = New System.Drawing.Size(377, 24)
        Me.cmb_proveedor.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_Documento)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_TotalPagos)
        Me.GroupBox2.Controls.Add(Me.txt_TotalCompra)
        Me.GroupBox2.Controls.Add(Me.doc_pagos)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.doc_detalle)
        Me.GroupBox2.Controls.Add(Me.doc_header)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cmb_proveedor)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(571, 431)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cartola Proveedor"
        '
        'txt_Documento
        '
        Me.txt_Documento.Location = New System.Drawing.Point(15, 147)
        Me.txt_Documento.Name = "txt_Documento"
        Me.txt_Documento.ReadOnly = True
        Me.txt_Documento.Size = New System.Drawing.Size(109, 21)
        Me.txt_Documento.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(487, 352)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 15)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Total Pagos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(484, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Total Detalle"
        '
        'txt_TotalPagos
        '
        Me.txt_TotalPagos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalPagos.HidePromptOnLeave = True
        Me.txt_TotalPagos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_TotalPagos.Location = New System.Drawing.Point(475, 371)
        Me.txt_TotalPagos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_TotalPagos.Name = "txt_TotalPagos"
        Me.txt_TotalPagos.ReadOnly = True
        Me.txt_TotalPagos.Size = New System.Drawing.Size(84, 22)
        Me.txt_TotalPagos.TabIndex = 12
        Me.txt_TotalPagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_TotalPagos.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txt_TotalCompra
        '
        Me.txt_TotalCompra.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalCompra.HidePromptOnLeave = True
        Me.txt_TotalCompra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_TotalCompra.Location = New System.Drawing.Point(475, 237)
        Me.txt_TotalCompra.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_TotalCompra.Name = "txt_TotalCompra"
        Me.txt_TotalCompra.ReadOnly = True
        Me.txt_TotalCompra.Size = New System.Drawing.Size(84, 22)
        Me.txt_TotalCompra.TabIndex = 11
        Me.txt_TotalCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_TotalCompra.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'doc_pagos
        '
        Me.doc_pagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.doc_pagos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.doc_pagos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.doc_pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.doc_pagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tipo, Me.Banco, Me.Num, Me.fec, Me.Valor})
        Me.doc_pagos.Location = New System.Drawing.Point(15, 338)
        Me.doc_pagos.Name = "doc_pagos"
        Me.doc_pagos.ReadOnly = True
        Me.doc_pagos.RowHeadersVisible = False
        Me.doc_pagos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.doc_pagos.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.doc_pagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.doc_pagos.Size = New System.Drawing.Size(448, 87)
        Me.doc_pagos.TabIndex = 10
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 56
        '
        'Banco
        '
        Me.Banco.HeaderText = "Banco"
        Me.Banco.Name = "Banco"
        Me.Banco.ReadOnly = True
        Me.Banco.Width = 67
        '
        'Num
        '
        Me.Num.HeaderText = "N°"
        Me.Num.Name = "Num"
        Me.Num.ReadOnly = True
        Me.Num.Width = 46
        '
        'fec
        '
        Me.fec.HeaderText = "Fecha Vcto."
        Me.fec.Name = "fec"
        Me.fec.ReadOnly = True
        Me.fec.Width = 95
        '
        'Valor
        '
        Me.Valor.HeaderText = "Monto"
        Me.Valor.Name = "Valor"
        Me.Valor.ReadOnly = True
        Me.Valor.Width = 65
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(481, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 38)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Ver Detalle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'doc_detalle
        '
        Me.doc_detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.doc_detalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.doc_detalle.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.doc_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.doc_detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Insumo, Me.semilla, Me.variedad, Me.Cantidad, Me.Unidad, Me.precio, Me.total})
        Me.doc_detalle.Location = New System.Drawing.Point(15, 169)
        Me.doc_detalle.Name = "doc_detalle"
        Me.doc_detalle.ReadOnly = True
        Me.doc_detalle.RowHeadersVisible = False
        Me.doc_detalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.doc_detalle.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.doc_detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.doc_detalle.Size = New System.Drawing.Size(448, 146)
        Me.doc_detalle.TabIndex = 8
        '
        'doc_header
        '
        Me.doc_header.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.doc_header.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.doc_header.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.doc_header.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.doc_header.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha, Me.ndoc, Me.Nro, Me.monto, Me.tipocompra})
        Me.doc_header.Location = New System.Drawing.Point(15, 60)
        Me.doc_header.Name = "doc_header"
        Me.doc_header.ReadOnly = True
        Me.doc_header.RowHeadersVisible = False
        Me.doc_header.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.doc_header.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.doc_header.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.doc_header.Size = New System.Drawing.Size(448, 87)
        Me.doc_header.TabIndex = 0
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 66
        '
        'ndoc
        '
        Me.ndoc.HeaderText = "Doc"
        Me.ndoc.Name = "ndoc"
        Me.ndoc.ReadOnly = True
        Me.ndoc.Width = 54
        '
        'Nro
        '
        Me.Nro.HeaderText = "Número"
        Me.Nro.Name = "Nro"
        Me.Nro.ReadOnly = True
        Me.Nro.Width = 77
        '
        'monto
        '
        Me.monto.HeaderText = "Monto"
        Me.monto.Name = "monto"
        Me.monto.ReadOnly = True
        Me.monto.Width = 65
        '
        'tipocompra
        '
        Me.tipocompra.HeaderText = "Tipo Gasto"
        Me.tipocompra.Name = "tipocompra"
        Me.tipocompra.ReadOnly = True
        Me.tipocompra.Width = 92
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TXT_Giro)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.TXT_Contacto)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txt_digitorut)
        Me.GroupBox3.Controls.Add(Me.txt_rutproveedor)
        Me.GroupBox3.Controls.Add(Me.TXT_Comentarios)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txt_NOMBRES)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.txt_fax)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txt_email)
        Me.GroupBox3.Controls.Add(Me.txt_telcelular)
        Me.GroupBox3.Controls.Add(Me.txt_teloficina)
        Me.GroupBox3.Controls.Add(Me.txt_telcasa)
        Me.GroupBox3.Controls.Add(Me.txt_ciudad)
        Me.GroupBox3.Controls.Add(Me.txt_comuna)
        Me.GroupBox3.Controls.Add(Me.txt_dircli)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(598, 32)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(381, 534)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Antecedentes del Proveedor"
        '
        'TXT_Giro
        '
        Me.TXT_Giro.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Giro.Location = New System.Drawing.Point(132, 392)
        Me.TXT_Giro.Name = "TXT_Giro"
        Me.TXT_Giro.ReadOnly = True
        Me.TXT_Giro.Size = New System.Drawing.Size(233, 21)
        Me.TXT_Giro.TabIndex = 41
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(15, 396)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(32, 14)
        Me.Label22.TabIndex = 40
        Me.Label22.Text = "GIRO"
        '
        'TXT_Contacto
        '
        Me.TXT_Contacto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Contacto.Location = New System.Drawing.Point(132, 369)
        Me.TXT_Contacto.Name = "TXT_Contacto"
        Me.TXT_Contacto.ReadOnly = True
        Me.TXT_Contacto.Size = New System.Drawing.Size(233, 21)
        Me.TXT_Contacto.TabIndex = 39
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(15, 372)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 14)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "CONTACTO"
        '
        'txt_digitorut
        '
        Me.txt_digitorut.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_digitorut.HidePromptOnLeave = True
        Me.txt_digitorut.Location = New System.Drawing.Point(220, 20)
        Me.txt_digitorut.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_digitorut.Mask = "A"
        Me.txt_digitorut.Name = "txt_digitorut"
        Me.txt_digitorut.ReadOnly = True
        Me.txt_digitorut.Size = New System.Drawing.Size(18, 22)
        Me.txt_digitorut.TabIndex = 37
        '
        'txt_rutproveedor
        '
        Me.txt_rutproveedor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rutproveedor.HidePromptOnLeave = True
        Me.txt_rutproveedor.Location = New System.Drawing.Point(131, 20)
        Me.txt_rutproveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_rutproveedor.Mask = "99999999999"
        Me.txt_rutproveedor.Name = "txt_rutproveedor"
        Me.txt_rutproveedor.ReadOnly = True
        Me.txt_rutproveedor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_rutproveedor.Size = New System.Drawing.Size(83, 22)
        Me.txt_rutproveedor.TabIndex = 36
        Me.txt_rutproveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXT_Comentarios
        '
        Me.TXT_Comentarios.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Comentarios.Location = New System.Drawing.Point(132, 346)
        Me.TXT_Comentarios.Name = "TXT_Comentarios"
        Me.TXT_Comentarios.ReadOnly = True
        Me.TXT_Comentarios.Size = New System.Drawing.Size(233, 21)
        Me.TXT_Comentarios.TabIndex = 32
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(15, 348)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 14)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "COMENTARIOS"
        '
        'txt_NOMBRES
        '
        Me.txt_NOMBRES.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NOMBRES.Location = New System.Drawing.Point(131, 46)
        Me.txt_NOMBRES.Name = "txt_NOMBRES"
        Me.txt_NOMBRES.ReadOnly = True
        Me.txt_NOMBRES.Size = New System.Drawing.Size(233, 21)
        Me.txt_NOMBRES.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(15, 52)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 14)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "NOMBRE"
        '
        'txt_fax
        '
        Me.txt_fax.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fax.Location = New System.Drawing.Point(131, 205)
        Me.txt_fax.Name = "txt_fax"
        Me.txt_fax.ReadOnly = True
        Me.txt_fax.Size = New System.Drawing.Size(233, 21)
        Me.txt_fax.TabIndex = 23
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(15, 211)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 14)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "FAX"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(131, 229)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.ReadOnly = True
        Me.txt_email.Size = New System.Drawing.Size(233, 21)
        Me.txt_email.TabIndex = 24
        '
        'txt_telcelular
        '
        Me.txt_telcelular.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telcelular.Location = New System.Drawing.Point(131, 182)
        Me.txt_telcelular.Name = "txt_telcelular"
        Me.txt_telcelular.ReadOnly = True
        Me.txt_telcelular.Size = New System.Drawing.Size(233, 21)
        Me.txt_telcelular.TabIndex = 22
        '
        'txt_teloficina
        '
        Me.txt_teloficina.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_teloficina.Location = New System.Drawing.Point(131, 159)
        Me.txt_teloficina.Name = "txt_teloficina"
        Me.txt_teloficina.ReadOnly = True
        Me.txt_teloficina.Size = New System.Drawing.Size(233, 21)
        Me.txt_teloficina.TabIndex = 21
        '
        'txt_telcasa
        '
        Me.txt_telcasa.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telcasa.Location = New System.Drawing.Point(131, 136)
        Me.txt_telcasa.Name = "txt_telcasa"
        Me.txt_telcasa.ReadOnly = True
        Me.txt_telcasa.Size = New System.Drawing.Size(233, 21)
        Me.txt_telcasa.TabIndex = 20
        '
        'txt_ciudad
        '
        Me.txt_ciudad.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ciudad.Location = New System.Drawing.Point(131, 114)
        Me.txt_ciudad.Name = "txt_ciudad"
        Me.txt_ciudad.ReadOnly = True
        Me.txt_ciudad.Size = New System.Drawing.Size(233, 21)
        Me.txt_ciudad.TabIndex = 19
        '
        'txt_comuna
        '
        Me.txt_comuna.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_comuna.Location = New System.Drawing.Point(131, 92)
        Me.txt_comuna.Name = "txt_comuna"
        Me.txt_comuna.ReadOnly = True
        Me.txt_comuna.Size = New System.Drawing.Size(233, 21)
        Me.txt_comuna.TabIndex = 18
        '
        'txt_dircli
        '
        Me.txt_dircli.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dircli.Location = New System.Drawing.Point(131, 70)
        Me.txt_dircli.Name = "txt_dircli"
        Me.txt_dircli.ReadOnly = True
        Me.txt_dircli.Size = New System.Drawing.Size(233, 21)
        Me.txt_dircli.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 235)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 14)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "EMAIL"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 188)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 14)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "TEL.CELULAR"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 14)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "TEL.OFICINA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 14)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "TEL.CASA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 14)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "CIUDAD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 14)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "COMUNA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 14)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "DIRECCION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RUT"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(985, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ToolStripMenuItem1, Me.ModificarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.CerrarToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevoToolStripMenuItem.Text = "&Nuevo"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem1.Text = "Grabar"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ModificarToolStripMenuItem.Text = "&Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EliminarToolStripMenuItem.Text = "&Eliminar"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CerrarToolStripMenuItem.Text = "&Cerrar Ventana"
        '
        'Insumo
        '
        Me.Insumo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Insumo.HeaderText = "Insumo"
        Me.Insumo.Name = "Insumo"
        Me.Insumo.ReadOnly = True
        Me.Insumo.Width = 74
        '
        'semilla
        '
        Me.semilla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.semilla.HeaderText = "Semilla"
        Me.semilla.Name = "semilla"
        Me.semilla.ReadOnly = True
        Me.semilla.Width = 74
        '
        'variedad
        '
        Me.variedad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.variedad.HeaderText = "Variedad"
        Me.variedad.Name = "variedad"
        Me.variedad.ReadOnly = True
        Me.variedad.Width = 80
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 82
        '
        'Unidad
        '
        Me.Unidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Unidad.HeaderText = "Unidad"
        Me.Unidad.Name = "Unidad"
        Me.Unidad.ReadOnly = True
        Me.Unidad.Width = 72
        '
        'precio
        '
        Me.precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.precio.DefaultCellStyle = DataGridViewCellStyle3
        Me.precio.HeaderText = "Precio Unit."
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        Me.precio.Width = 95
        '
        'total
        '
        Me.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.total.DefaultCellStyle = DataGridViewCellStyle4
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Width = 58
        '
        'Consulta_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 584)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Consulta_Proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PROVEEDOR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.doc_pagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doc_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doc_header, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Rut As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents btn_BuscarProveedor As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_proveedor As System.Windows.Forms.ComboBox
    Friend WithEvents txt_digrut As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents doc_header As System.Windows.Forms.DataGridView
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_dircli As System.Windows.Forms.TextBox
    Friend WithEvents txt_comuna As System.Windows.Forms.TextBox
    Friend WithEvents txt_telcasa As System.Windows.Forms.TextBox
    Friend WithEvents txt_ciudad As System.Windows.Forms.TextBox
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_telcelular As System.Windows.Forms.TextBox
    Friend WithEvents txt_teloficina As System.Windows.Forms.TextBox
    Friend WithEvents txt_fax As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt_NOMBRES As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TXT_Comentarios As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_rutproveedor As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_digitorut As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TXT_Contacto As System.Windows.Forms.TextBox
    Friend WithEvents TXT_Giro As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents doc_detalle As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents doc_pagos As System.Windows.Forms.DataGridView
    Public WithEvents txt_TotalCompra As System.Windows.Forms.MaskedTextBox
    Public WithEvents txt_TotalPagos As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Documento As System.Windows.Forms.TextBox
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ndoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Banco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipocompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Insumo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents semilla As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents variedad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
