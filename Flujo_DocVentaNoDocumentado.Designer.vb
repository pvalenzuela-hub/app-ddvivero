<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Flujo_DocVentaNoDocumentado
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGrilla = New System.Windows.Forms.DataGridView()
        Me.tipodoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numdoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.femision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fvcto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numguia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Glosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cont = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtp_FechaVcto = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDeudaGeneral = New System.Windows.Forms.TextBox()
        Me.txtSaldoAbono = New System.Windows.Forms.TextBox()
        Me.txtSaldoFactura = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.chk_Vendedor = New System.Windows.Forms.CheckBox()
        Me.cmb_Vendedor = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmb_clientebuscar = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txt_clientebuscar = New System.Windows.Forms.TextBox()
        Me.txt_NOM_CLI = New System.Windows.Forms.MaskedTextBox()
        Me.txt_RUT_CLI = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGrilla)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 158)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1128, 479)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Documentos de Venta"
        '
        'DataGrilla
        '
        Me.DataGrilla.AllowUserToAddRows = False
        Me.DataGrilla.AllowUserToDeleteRows = False
        Me.DataGrilla.AllowUserToResizeColumns = False
        Me.DataGrilla.AllowUserToResizeRows = False
        Me.DataGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGrilla.BackgroundColor = System.Drawing.Color.White
        Me.DataGrilla.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tipodoc, Me.numdoc, Me.femision, Me.fvcto, Me.numguia, Me.rut, Me.Cant, Me.Total, Me.Glosa, Me.Tel, Me.dir, Me.cont, Me.Column1})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrilla.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGrilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrilla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGrilla.Location = New System.Drawing.Point(3, 16)
        Me.DataGrilla.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGrilla.Name = "DataGrilla"
        Me.DataGrilla.ReadOnly = True
        Me.DataGrilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataGrilla.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGrilla.ShowEditingIcon = False
        Me.DataGrilla.Size = New System.Drawing.Size(1122, 460)
        Me.DataGrilla.TabIndex = 1
        '
        'tipodoc
        '
        Me.tipodoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.tipodoc.Frozen = True
        Me.tipodoc.HeaderText = "Doc"
        Me.tipodoc.Name = "tipodoc"
        Me.tipodoc.ReadOnly = True
        Me.tipodoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.tipodoc.Width = 33
        '
        'numdoc
        '
        Me.numdoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.numdoc.Frozen = True
        Me.numdoc.HeaderText = "N°"
        Me.numdoc.Name = "numdoc"
        Me.numdoc.ReadOnly = True
        Me.numdoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.numdoc.Width = 25
        '
        'femision
        '
        Me.femision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.femision.Frozen = True
        Me.femision.HeaderText = "Fecha"
        Me.femision.Name = "femision"
        Me.femision.ReadOnly = True
        Me.femision.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.femision.Width = 43
        '
        'fvcto
        '
        Me.fvcto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.fvcto.Frozen = True
        Me.fvcto.HeaderText = "Fec.Vcto."
        Me.fvcto.Name = "fvcto"
        Me.fvcto.ReadOnly = True
        Me.fvcto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fvcto.Width = 80
        '
        'numguia
        '
        Me.numguia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.numguia.Frozen = True
        Me.numguia.HeaderText = "Cliente"
        Me.numguia.Name = "numguia"
        Me.numguia.ReadOnly = True
        Me.numguia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.numguia.Width = 45
        '
        'rut
        '
        Me.rut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.rut.HeaderText = "RUT"
        Me.rut.Name = "rut"
        Me.rut.ReadOnly = True
        Me.rut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Cant
        '
        Me.Cant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Cant.DefaultCellStyle = DataGridViewCellStyle6
        Me.Cant.HeaderText = "Valor Doc."
        Me.Cant.Name = "Cant"
        Me.Cant.ReadOnly = True
        Me.Cant.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Cant.ToolTipText = "Total:Facturas,Boletas,Exentas,Notas de Créditos (restadas)"
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Total.DefaultCellStyle = DataGridViewCellStyle7
        Me.Total.HeaderText = "Abonos a Doc"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Total.ToolTipText = "Total Abonos a Facturas"
        '
        'Glosa
        '
        Me.Glosa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Red
        Me.Glosa.DefaultCellStyle = DataGridViewCellStyle8
        Me.Glosa.HeaderText = "Deuda"
        Me.Glosa.Name = "Glosa"
        Me.Glosa.ReadOnly = True
        Me.Glosa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Glosa.ToolTipText = "Diferencia por Pagar, de todos los documentos emitidos"
        '
        'Tel
        '
        Me.Tel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Tel.HeaderText = "Teléfonos"
        Me.Tel.Name = "Tel"
        Me.Tel.ReadOnly = True
        Me.Tel.Width = 79
        '
        'dir
        '
        Me.dir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dir.HeaderText = "Dirección"
        Me.dir.Name = "dir"
        Me.dir.ReadOnly = True
        Me.dir.Width = 77
        '
        'cont
        '
        Me.cont.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.cont.HeaderText = "Contacto"
        Me.cont.Name = "cont"
        Me.cont.ReadOnly = True
        Me.cont.Width = 75
        '
        'Column1
        '
        Me.Column1.HeaderText = "N° Doc.SII"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 83
        '
        'dtp_FechaVcto
        '
        Me.dtp_FechaVcto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaVcto.Location = New System.Drawing.Point(258, 81)
        Me.dtp_FechaVcto.Name = "dtp_FechaVcto"
        Me.dtp_FechaVcto.Size = New System.Drawing.Size(87, 21)
        Me.dtp_FechaVcto.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(182, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Vencimiento"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(1030, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 62)
        Me.Button1.TabIndex = 10
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.Close
        Me.Button2.Location = New System.Drawing.Point(1104, -1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(31, 32)
        Me.Button2.TabIndex = 11
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(924, 649)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Deuda Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(430, 649)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Saldo Abono Pedidos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 649)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Facturas/Boletas:"
        '
        'txtDeudaGeneral
        '
        Me.txtDeudaGeneral.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeudaGeneral.Location = New System.Drawing.Point(1001, 646)
        Me.txtDeudaGeneral.Name = "txtDeudaGeneral"
        Me.txtDeudaGeneral.ReadOnly = True
        Me.txtDeudaGeneral.Size = New System.Drawing.Size(100, 21)
        Me.txtDeudaGeneral.TabIndex = 14
        Me.txtDeudaGeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSaldoAbono
        '
        Me.txtSaldoAbono.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoAbono.Location = New System.Drawing.Point(566, 646)
        Me.txtSaldoAbono.Name = "txtSaldoAbono"
        Me.txtSaldoAbono.ReadOnly = True
        Me.txtSaldoAbono.Size = New System.Drawing.Size(100, 21)
        Me.txtSaldoAbono.TabIndex = 13
        Me.txtSaldoAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSaldoFactura
        '
        Me.txtSaldoFactura.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoFactura.Location = New System.Drawing.Point(129, 646)
        Me.txtSaldoFactura.Name = "txtSaldoFactura"
        Me.txtSaldoFactura.ReadOnly = True
        Me.txtSaldoFactura.Size = New System.Drawing.Size(100, 21)
        Me.txtSaldoFactura.TabIndex = 12
        Me.txtSaldoFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(544, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Reporte de Facturas y documentos de venta pendientes de cobro.. Ordenado por Clie" &
    "nte y Fecha de Vencimiento"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.chk_Vendedor)
        Me.GroupBox8.Controls.Add(Me.cmb_Vendedor)
        Me.GroupBox8.Controls.Add(Me.Button4)
        Me.GroupBox8.Controls.Add(Me.Label7)
        Me.GroupBox8.Controls.Add(Me.Button3)
        Me.GroupBox8.Controls.Add(Me.cmb_clientebuscar)
        Me.GroupBox8.Controls.Add(Me.Label27)
        Me.GroupBox8.Controls.Add(Me.txt_clientebuscar)
        Me.GroupBox8.Controls.Add(Me.txt_NOM_CLI)
        Me.GroupBox8.Controls.Add(Me.Button1)
        Me.GroupBox8.Controls.Add(Me.txt_RUT_CLI)
        Me.GroupBox8.Controls.Add(Me.Label11)
        Me.GroupBox8.Controls.Add(Me.Label1)
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Controls.Add(Me.dtp_FechaVcto)
        Me.GroupBox8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(4, 38)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox8.Size = New System.Drawing.Size(1128, 115)
        Me.GroupBox8.TabIndex = 37
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Identificación del Cliente"
        '
        'chk_Vendedor
        '
        Me.chk_Vendedor.AutoSize = True
        Me.chk_Vendedor.Location = New System.Drawing.Point(429, 82)
        Me.chk_Vendedor.Name = "chk_Vendedor"
        Me.chk_Vendedor.Size = New System.Drawing.Size(78, 19)
        Me.chk_Vendedor.TabIndex = 35
        Me.chk_Vendedor.Text = "Vendedor"
        Me.chk_Vendedor.UseVisualStyleBackColor = True
        '
        'cmb_Vendedor
        '
        Me.cmb_Vendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_Vendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Vendedor.Enabled = False
        Me.cmb_Vendedor.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Vendedor.ForeColor = System.Drawing.Color.White
        Me.cmb_Vendedor.FormattingEnabled = True
        Me.cmb_Vendedor.Location = New System.Drawing.Point(513, 79)
        Me.cmb_Vendedor.Name = "cmb_Vendedor"
        Me.cmb_Vendedor.Size = New System.Drawing.Size(179, 23)
        Me.cmb_Vendedor.TabIndex = 33
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(18, 80)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(101, 23)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "Limpiar Filtros"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(521, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 15)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Nombre del Cliente"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(178, 38)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 29)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Buscar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cmb_clientebuscar
        '
        Me.cmb_clientebuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_clientebuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_clientebuscar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_clientebuscar.ForeColor = System.Drawing.Color.White
        Me.cmb_clientebuscar.FormattingEnabled = True
        Me.cmb_clientebuscar.Location = New System.Drawing.Point(255, 40)
        Me.cmb_clientebuscar.Name = "cmb_clientebuscar"
        Me.cmb_clientebuscar.Size = New System.Drawing.Size(263, 23)
        Me.cmb_clientebuscar.TabIndex = 28
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(18, 22)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(142, 15)
        Me.Label27.TabIndex = 27
        Me.Label27.Text = "Ingrese Cliente a buscar"
        '
        'txt_clientebuscar
        '
        Me.txt_clientebuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_clientebuscar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clientebuscar.ForeColor = System.Drawing.Color.White
        Me.txt_clientebuscar.Location = New System.Drawing.Point(18, 40)
        Me.txt_clientebuscar.Name = "txt_clientebuscar"
        Me.txt_clientebuscar.Size = New System.Drawing.Size(160, 21)
        Me.txt_clientebuscar.TabIndex = 26
        '
        'txt_NOM_CLI
        '
        Me.txt_NOM_CLI.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_NOM_CLI.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NOM_CLI.ForeColor = System.Drawing.Color.Navy
        Me.txt_NOM_CLI.Location = New System.Drawing.Point(524, 42)
        Me.txt_NOM_CLI.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_NOM_CLI.Name = "txt_NOM_CLI"
        Me.txt_NOM_CLI.ReadOnly = True
        Me.txt_NOM_CLI.Size = New System.Drawing.Size(329, 22)
        Me.txt_NOM_CLI.TabIndex = 21
        '
        'txt_RUT_CLI
        '
        Me.txt_RUT_CLI.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_RUT_CLI.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RUT_CLI.HidePromptOnLeave = True
        Me.txt_RUT_CLI.Location = New System.Drawing.Point(857, 41)
        Me.txt_RUT_CLI.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_RUT_CLI.Name = "txt_RUT_CLI"
        Me.txt_RUT_CLI.ReadOnly = True
        Me.txt_RUT_CLI.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_RUT_CLI.Size = New System.Drawing.Size(96, 22)
        Me.txt_RUT_CLI.TabIndex = 4
        Me.txt_RUT_CLI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(259, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 15)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Seleccione Cliente"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(856, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 15)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "R.U.T. Cliente"
        '
        'Flujo_DocVentaNoDocumentado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1134, 672)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSaldoFactura)
        Me.Controls.Add(Me.txtDeudaGeneral)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtSaldoAbono)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Flujo_DocVentaNoDocumentado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flujo de Facturas y Boletas Pendientes"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents dtp_FechaVcto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDeudaGeneral As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldoAbono As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldoFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cmb_clientebuscar As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txt_clientebuscar As System.Windows.Forms.TextBox
    Friend WithEvents txt_NOM_CLI As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_RUT_CLI As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents cmb_Vendedor As System.Windows.Forms.ComboBox
    Friend WithEvents chk_Vendedor As System.Windows.Forms.CheckBox
    Friend WithEvents tipodoc As DataGridViewTextBoxColumn
    Friend WithEvents numdoc As DataGridViewTextBoxColumn
    Friend WithEvents femision As DataGridViewTextBoxColumn
    Friend WithEvents fvcto As DataGridViewTextBoxColumn
    Friend WithEvents numguia As DataGridViewTextBoxColumn
    Friend WithEvents rut As DataGridViewTextBoxColumn
    Friend WithEvents Cant As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Glosa As DataGridViewTextBoxColumn
    Friend WithEvents Tel As DataGridViewTextBoxColumn
    Friend WithEvents dir As DataGridViewTextBoxColumn
    Friend WithEvents cont As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
