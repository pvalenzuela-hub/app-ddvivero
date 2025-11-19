<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Libro_Compras
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmb_PROVEEDOR = New System.Windows.Forms.ComboBox()
        Me.txt_BUSCARPROVEEDOR = New System.Windows.Forms.TextBox()
        Me.BTN_BUSCAR = New System.Windows.Forms.Button()
        Me.chk_FiltroProv = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_Fecha2 = New System.Windows.Forms.DateTimePicker()
        Me.txt_Fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGrilla = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_IVA = New System.Windows.Forms.TextBox()
        Me.txt_TOTALFINAL = New System.Windows.Forms.TextBox()
        Me.txt_ImpEspec = New System.Windows.Forms.TextBox()
        Me.txt_TOTALNETO = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TIPODOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numdoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecvta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.neto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.impespec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_DocNormal = New System.Windows.Forms.TextBox()
        Me.txt_DocElect = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txt_Fecha2)
        Me.GroupBox1.Controls.Add(Me.txt_Fecha1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(846, 158)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selección de Fechas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(447, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(254, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Desde"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmb_PROVEEDOR)
        Me.GroupBox3.Controls.Add(Me.txt_BUSCARPROVEEDOR)
        Me.GroupBox3.Controls.Add(Me.BTN_BUSCAR)
        Me.GroupBox3.Controls.Add(Me.chk_FiltroProv)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 54)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(822, 58)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filtro"
        '
        'cmb_PROVEEDOR
        '
        Me.cmb_PROVEEDOR.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_PROVEEDOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_PROVEEDOR.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_PROVEEDOR.ForeColor = System.Drawing.Color.White
        Me.cmb_PROVEEDOR.FormattingEnabled = True
        Me.cmb_PROVEEDOR.Location = New System.Drawing.Point(365, 16)
        Me.cmb_PROVEEDOR.Name = "cmb_PROVEEDOR"
        Me.cmb_PROVEEDOR.Size = New System.Drawing.Size(441, 23)
        Me.cmb_PROVEEDOR.TabIndex = 32
        '
        'txt_BUSCARPROVEEDOR
        '
        Me.txt_BUSCARPROVEEDOR.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_BUSCARPROVEEDOR.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BUSCARPROVEEDOR.ForeColor = System.Drawing.Color.White
        Me.txt_BUSCARPROVEEDOR.Location = New System.Drawing.Point(97, 16)
        Me.txt_BUSCARPROVEEDOR.Name = "txt_BUSCARPROVEEDOR"
        Me.txt_BUSCARPROVEEDOR.Size = New System.Drawing.Size(196, 21)
        Me.txt_BUSCARPROVEEDOR.TabIndex = 31
        '
        'BTN_BUSCAR
        '
        Me.BTN_BUSCAR.Location = New System.Drawing.Point(299, 14)
        Me.BTN_BUSCAR.Name = "BTN_BUSCAR"
        Me.BTN_BUSCAR.Size = New System.Drawing.Size(52, 25)
        Me.BTN_BUSCAR.TabIndex = 30
        Me.BTN_BUSCAR.Text = "Buscar"
        Me.BTN_BUSCAR.UseVisualStyleBackColor = True
        '
        'chk_FiltroProv
        '
        Me.chk_FiltroProv.AutoSize = True
        Me.chk_FiltroProv.Location = New System.Drawing.Point(6, 19)
        Me.chk_FiltroProv.Name = "chk_FiltroProv"
        Me.chk_FiltroProv.Size = New System.Drawing.Size(75, 17)
        Me.chk_FiltroProv.TabIndex = 0
        Me.chk_FiltroProv.Text = "Proveedor"
        Me.chk_FiltroProv.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(348, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 27)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Ejecutar Consulta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_Fecha2
        '
        Me.txt_Fecha2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Fecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_Fecha2.Location = New System.Drawing.Point(491, 22)
        Me.txt_Fecha2.Name = "txt_Fecha2"
        Me.txt_Fecha2.Size = New System.Drawing.Size(102, 25)
        Me.txt_Fecha2.TabIndex = 4
        '
        'txt_Fecha1
        '
        Me.txt_Fecha1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Fecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_Fecha1.Location = New System.Drawing.Point(298, 22)
        Me.txt_Fecha1.Name = "txt_Fecha1"
        Me.txt_Fecha1.Size = New System.Drawing.Size(121, 25)
        Me.txt_Fecha1.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGrilla)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 171)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(846, 315)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle Documentos de Compras"
        '
        'DataGrilla
        '
        Me.DataGrilla.AllowUserToAddRows = False
        Me.DataGrilla.AllowUserToDeleteRows = False
        Me.DataGrilla.AllowUserToOrderColumns = True
        Me.DataGrilla.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGrilla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGrilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGrilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TIPODOC, Me.numdoc, Me.Fecvta, Me.rut, Me.Proveedor, Me.neto, Me.impespec, Me.iva, Me.total, Me.Tipo})
        Me.DataGrilla.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrilla.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGrilla.GridColor = System.Drawing.Color.White
        Me.DataGrilla.Location = New System.Drawing.Point(12, 26)
        Me.DataGrilla.Name = "DataGrilla"
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.DataGrilla.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataGrilla.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGrilla.Size = New System.Drawing.Size(822, 275)
        Me.DataGrilla.StandardTab = True
        Me.DataGrilla.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txt_DocElect)
        Me.GroupBox4.Controls.Add(Me.txt_DocNormal)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txt_IVA)
        Me.GroupBox4.Controls.Add(Me.txt_TOTALFINAL)
        Me.GroupBox4.Controls.Add(Me.txt_ImpEspec)
        Me.GroupBox4.Controls.Add(Me.txt_TOTALNETO)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 493)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(846, 70)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Resumen Compras"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(351, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "I.V.A."
        '
        'txt_IVA
        '
        Me.txt_IVA.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_IVA.CausesValidation = False
        Me.txt_IVA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IVA.ForeColor = System.Drawing.Color.Yellow
        Me.txt_IVA.Location = New System.Drawing.Point(309, 32)
        Me.txt_IVA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_IVA.Name = "txt_IVA"
        Me.txt_IVA.ReadOnly = True
        Me.txt_IVA.Size = New System.Drawing.Size(79, 22)
        Me.txt_IVA.TabIndex = 12
        Me.txt_IVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_TOTALFINAL
        '
        Me.txt_TOTALFINAL.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_TOTALFINAL.CausesValidation = False
        Me.txt_TOTALFINAL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TOTALFINAL.ForeColor = System.Drawing.Color.Yellow
        Me.txt_TOTALFINAL.Location = New System.Drawing.Point(452, 32)
        Me.txt_TOTALFINAL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_TOTALFINAL.Name = "txt_TOTALFINAL"
        Me.txt_TOTALFINAL.ReadOnly = True
        Me.txt_TOTALFINAL.Size = New System.Drawing.Size(79, 22)
        Me.txt_TOTALFINAL.TabIndex = 11
        Me.txt_TOTALFINAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_ImpEspec
        '
        Me.txt_ImpEspec.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_ImpEspec.CausesValidation = False
        Me.txt_ImpEspec.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ImpEspec.ForeColor = System.Drawing.Color.Yellow
        Me.txt_ImpEspec.Location = New System.Drawing.Point(166, 32)
        Me.txt_ImpEspec.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_ImpEspec.Name = "txt_ImpEspec"
        Me.txt_ImpEspec.ReadOnly = True
        Me.txt_ImpEspec.Size = New System.Drawing.Size(79, 22)
        Me.txt_ImpEspec.TabIndex = 10
        Me.txt_ImpEspec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_TOTALNETO
        '
        Me.txt_TOTALNETO.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_TOTALNETO.CausesValidation = False
        Me.txt_TOTALNETO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TOTALNETO.ForeColor = System.Drawing.Color.Yellow
        Me.txt_TOTALNETO.Location = New System.Drawing.Point(23, 32)
        Me.txt_TOTALNETO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_TOTALNETO.Name = "txt_TOTALNETO"
        Me.txt_TOTALNETO.ReadOnly = True
        Me.txt_TOTALNETO.Size = New System.Drawing.Size(79, 22)
        Me.txt_TOTALNETO.TabIndex = 9
        Me.txt_TOTALNETO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(485, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "TOTAL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(165, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Imp. Específico"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "NETO"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(360, 593)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 27)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TIPODOC
        '
        Me.TIPODOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TIPODOC.HeaderText = "Tipo Doc."
        Me.TIPODOC.Name = "TIPODOC"
        Me.TIPODOC.Width = 88
        '
        'numdoc
        '
        Me.numdoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.numdoc.HeaderText = "N° Doc"
        Me.numdoc.Name = "numdoc"
        Me.numdoc.Width = 74
        '
        'Fecvta
        '
        Me.Fecvta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Fecvta.HeaderText = "Fecha"
        Me.Fecvta.Name = "Fecvta"
        Me.Fecvta.Width = 69
        '
        'rut
        '
        Me.rut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.rut.HeaderText = "R.U.T."
        Me.rut.Name = "rut"
        Me.rut.Width = 69
        '
        'Proveedor
        '
        Me.Proveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.Width = 90
        '
        'neto
        '
        Me.neto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.neto.DefaultCellStyle = DataGridViewCellStyle2
        Me.neto.HeaderText = "Neto"
        Me.neto.Name = "neto"
        Me.neto.Width = 60
        '
        'impespec
        '
        Me.impespec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.impespec.DefaultCellStyle = DataGridViewCellStyle3
        Me.impespec.HeaderText = "Imp.Espec."
        Me.impespec.Name = "impespec"
        Me.impespec.Width = 99
        '
        'iva
        '
        Me.iva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.iva.DefaultCellStyle = DataGridViewCellStyle4
        Me.iva.HeaderText = "I.V.A."
        Me.iva.Name = "iva"
        Me.iva.Width = 65
        '
        'total
        '
        Me.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.total.DefaultCellStyle = DataGridViewCellStyle5
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.Width = 60
        '
        'Tipo
        '
        Me.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Width = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(609, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Doc.Normal"
        '
        'txt_DocNormal
        '
        Me.txt_DocNormal.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_DocNormal.CausesValidation = False
        Me.txt_DocNormal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DocNormal.ForeColor = System.Drawing.Color.Yellow
        Me.txt_DocNormal.Location = New System.Drawing.Point(595, 32)
        Me.txt_DocNormal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_DocNormal.Name = "txt_DocNormal"
        Me.txt_DocNormal.ReadOnly = True
        Me.txt_DocNormal.Size = New System.Drawing.Size(79, 22)
        Me.txt_DocNormal.TabIndex = 15
        Me.txt_DocNormal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_DocElect
        '
        Me.txt_DocElect.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_DocElect.CausesValidation = False
        Me.txt_DocElect.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DocElect.ForeColor = System.Drawing.Color.Yellow
        Me.txt_DocElect.Location = New System.Drawing.Point(738, 32)
        Me.txt_DocElect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_DocElect.Name = "txt_DocElect"
        Me.txt_DocElect.ReadOnly = True
        Me.txt_DocElect.Size = New System.Drawing.Size(79, 22)
        Me.txt_DocElect.TabIndex = 16
        Me.txt_DocElect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(737, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Doc.Electrónico"
        '
        'Libro_Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 632)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Libro_Compras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Libro de Compras"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_Fecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_Fecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents DataGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_TOTALFINAL As System.Windows.Forms.TextBox
    Friend WithEvents txt_ImpEspec As System.Windows.Forms.TextBox
    Friend WithEvents txt_TOTALNETO As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents chk_FiltroProv As System.Windows.Forms.CheckBox
    Friend WithEvents BTN_BUSCAR As System.Windows.Forms.Button
    Friend WithEvents txt_BUSCARPROVEEDOR As System.Windows.Forms.TextBox
    Friend WithEvents cmb_PROVEEDOR As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_IVA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TIPODOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numdoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecvta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents neto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents impespec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents iva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_DocElect As System.Windows.Forms.TextBox
    Friend WithEvents txt_DocNormal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
