<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pago_Proveedores
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BTN_BUSCAR = New System.Windows.Forms.Button()
        Me.cmb_PROVEEDOR = New System.Windows.Forms.ComboBox()
        Me.txt_BUSCARPROVEEDOR = New System.Windows.Forms.TextBox()
        Me.txt_NOM_PRO = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_Factura = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_ValorDocumento = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Iva = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Valor_Neto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_ImpEspecifico = New System.Windows.Forms.TextBox()
        Me.txt_ValorPagado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dtp_FechaVcto = New System.Windows.Forms.DateTimePicker()
        Me.txt_MontoDoc = New System.Windows.Forms.MaskedTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_BANCO = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_NUM_DOCPAGO = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_TIPO_PAGO = New System.Windows.Forms.ComboBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridPago = New System.Windows.Forms.DataGridView()
        Me.item0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fpago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecvcto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_AgregarPago = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.txt_TOTPAGOS = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_RutProveedor = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_FechaFactura = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrabarPagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIDPagos = New System.Windows.Forms.TextBox()
        Me.btn_Pago = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.txtMontoPagar = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.BANCOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_FormaPago = New GestionVivero.DS_FormaPago()
        Me.BANCOTableAdapter = New GestionVivero.DS_FormaPagoTableAdapters.BANCOTableAdapter()
        Me.txtIdProveedor = New System.Windows.Forms.TextBox()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.DataGridPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox10.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BANCOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_FormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_BUSCAR
        '
        Me.BTN_BUSCAR.Location = New System.Drawing.Point(169, 41)
        Me.BTN_BUSCAR.Name = "BTN_BUSCAR"
        Me.BTN_BUSCAR.Size = New System.Drawing.Size(52, 25)
        Me.BTN_BUSCAR.TabIndex = 33
        Me.BTN_BUSCAR.Text = "Buscar"
        Me.BTN_BUSCAR.UseVisualStyleBackColor = True
        '
        'cmb_PROVEEDOR
        '
        Me.cmb_PROVEEDOR.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_PROVEEDOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_PROVEEDOR.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_PROVEEDOR.ForeColor = System.Drawing.Color.White
        Me.cmb_PROVEEDOR.FormattingEnabled = True
        Me.cmb_PROVEEDOR.Location = New System.Drawing.Point(227, 43)
        Me.cmb_PROVEEDOR.Name = "cmb_PROVEEDOR"
        Me.cmb_PROVEEDOR.Size = New System.Drawing.Size(249, 23)
        Me.cmb_PROVEEDOR.TabIndex = 32
        '
        'txt_BUSCARPROVEEDOR
        '
        Me.txt_BUSCARPROVEEDOR.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_BUSCARPROVEEDOR.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BUSCARPROVEEDOR.ForeColor = System.Drawing.Color.White
        Me.txt_BUSCARPROVEEDOR.Location = New System.Drawing.Point(26, 43)
        Me.txt_BUSCARPROVEEDOR.Name = "txt_BUSCARPROVEEDOR"
        Me.txt_BUSCARPROVEEDOR.Size = New System.Drawing.Size(138, 21)
        Me.txt_BUSCARPROVEEDOR.TabIndex = 31
        '
        'txt_NOM_PRO
        '
        Me.txt_NOM_PRO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NOM_PRO.Location = New System.Drawing.Point(279, 79)
        Me.txt_NOM_PRO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_NOM_PRO.Name = "txt_NOM_PRO"
        Me.txt_NOM_PRO.ReadOnly = True
        Me.txt_NOM_PRO.Size = New System.Drawing.Size(409, 22)
        Me.txt_NOM_PRO.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "N° Factura"
        '
        'cmb_Factura
        '
        Me.cmb_Factura.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_Factura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Factura.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Factura.ForeColor = System.Drawing.Color.White
        Me.cmb_Factura.FormattingEnabled = True
        Me.cmb_Factura.Location = New System.Drawing.Point(91, 80)
        Me.cmb_Factura.Name = "cmb_Factura"
        Me.cmb_Factura.Size = New System.Drawing.Size(104, 23)
        Me.cmb_Factura.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(247, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Valor Documento"
        '
        'txt_ValorDocumento
        '
        Me.txt_ValorDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_ValorDocumento.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ValorDocumento.ForeColor = System.Drawing.Color.White
        Me.txt_ValorDocumento.Location = New System.Drawing.Point(341, 111)
        Me.txt_ValorDocumento.Name = "txt_ValorDocumento"
        Me.txt_ValorDocumento.ReadOnly = True
        Me.txt_ValorDocumento.Size = New System.Drawing.Size(97, 21)
        Me.txt_ValorDocumento.TabIndex = 37
        Me.txt_ValorDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(247, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Valor Pagado"
        '
        'txt_Iva
        '
        Me.txt_Iva.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_Iva.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Iva.ForeColor = System.Drawing.Color.White
        Me.txt_Iva.Location = New System.Drawing.Point(107, 166)
        Me.txt_Iva.Name = "txt_Iva"
        Me.txt_Iva.ReadOnly = True
        Me.txt_Iva.Size = New System.Drawing.Size(97, 21)
        Me.txt_Iva.TabIndex = 39
        Me.txt_Iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Total Neto"
        '
        'txt_Valor_Neto
        '
        Me.txt_Valor_Neto.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_Valor_Neto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Valor_Neto.ForeColor = System.Drawing.Color.White
        Me.txt_Valor_Neto.Location = New System.Drawing.Point(107, 111)
        Me.txt_Valor_Neto.Name = "txt_Valor_Neto"
        Me.txt_Valor_Neto.ReadOnly = True
        Me.txt_Valor_Neto.Size = New System.Drawing.Size(97, 21)
        Me.txt_Valor_Neto.TabIndex = 41
        Me.txt_Valor_Neto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Imp. Espécifico"
        '
        'txt_ImpEspecifico
        '
        Me.txt_ImpEspecifico.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_ImpEspecifico.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ImpEspecifico.ForeColor = System.Drawing.Color.White
        Me.txt_ImpEspecifico.Location = New System.Drawing.Point(107, 139)
        Me.txt_ImpEspecifico.Name = "txt_ImpEspecifico"
        Me.txt_ImpEspecifico.ReadOnly = True
        Me.txt_ImpEspecifico.Size = New System.Drawing.Size(97, 21)
        Me.txt_ImpEspecifico.TabIndex = 43
        Me.txt_ImpEspecifico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_ValorPagado
        '
        Me.txt_ValorPagado.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_ValorPagado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ValorPagado.ForeColor = System.Drawing.Color.White
        Me.txt_ValorPagado.Location = New System.Drawing.Point(341, 139)
        Me.txt_ValorPagado.Name = "txt_ValorPagado"
        Me.txt_ValorPagado.ReadOnly = True
        Me.txt_ValorPagado.Size = New System.Drawing.Size(97, 21)
        Me.txt_ValorPagado.TabIndex = 44
        Me.txt_ValorPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "I.V.A"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dtp_FechaVcto)
        Me.GroupBox6.Controls.Add(Me.txt_MontoDoc)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.txt_BANCO)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.txt_NUM_DOCPAGO)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.cmb_TIPO_PAGO)
        Me.GroupBox6.Location = New System.Drawing.Point(16, 191)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox6.Size = New System.Drawing.Size(422, 101)
        Me.GroupBox6.TabIndex = 47
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Formas de Pago"
        '
        'dtp_FechaVcto
        '
        Me.dtp_FechaVcto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FechaVcto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaVcto.Location = New System.Drawing.Point(19, 70)
        Me.dtp_FechaVcto.Name = "dtp_FechaVcto"
        Me.dtp_FechaVcto.Size = New System.Drawing.Size(86, 21)
        Me.dtp_FechaVcto.TabIndex = 34
        '
        'txt_MontoDoc
        '
        Me.txt_MontoDoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_MontoDoc.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MontoDoc.HidePromptOnLeave = True
        Me.txt_MontoDoc.Location = New System.Drawing.Point(146, 69)
        Me.txt_MontoDoc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_MontoDoc.Mask = "999999999"
        Me.txt_MontoDoc.Name = "txt_MontoDoc"
        Me.txt_MontoDoc.Size = New System.Drawing.Size(69, 22)
        Me.txt_MontoDoc.TabIndex = 19
        Me.txt_MontoDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(150, 53)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 13)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Monto"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 53)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(98, 13)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Fecha Vencimiento"
        '
        'txt_BANCO
        '
        Me.txt_BANCO.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_BANCO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BANCO.Location = New System.Drawing.Point(227, 69)
        Me.txt_BANCO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_BANCO.Name = "txt_BANCO"
        Me.txt_BANCO.Size = New System.Drawing.Size(183, 22)
        Me.txt_BANCO.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(231, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Banco"
        '
        'txt_NUM_DOCPAGO
        '
        Me.txt_NUM_DOCPAGO.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_NUM_DOCPAGO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NUM_DOCPAGO.HidePromptOnLeave = True
        Me.txt_NUM_DOCPAGO.Location = New System.Drawing.Point(303, 20)
        Me.txt_NUM_DOCPAGO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_NUM_DOCPAGO.Mask = "999999999999999"
        Me.txt_NUM_DOCPAGO.Name = "txt_NUM_DOCPAGO"
        Me.txt_NUM_DOCPAGO.Size = New System.Drawing.Size(111, 22)
        Me.txt_NUM_DOCPAGO.TabIndex = 13
        Me.txt_NUM_DOCPAGO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(233, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Nro.Doc."
        '
        'cmb_TIPO_PAGO
        '
        Me.cmb_TIPO_PAGO.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_TIPO_PAGO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TIPO_PAGO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_TIPO_PAGO.FormattingEnabled = True
        Me.cmb_TIPO_PAGO.Location = New System.Drawing.Point(10, 19)
        Me.cmb_TIPO_PAGO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmb_TIPO_PAGO.Name = "cmb_TIPO_PAGO"
        Me.cmb_TIPO_PAGO.Size = New System.Drawing.Size(192, 24)
        Me.cmb_TIPO_PAGO.TabIndex = 0
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Button3)
        Me.GroupBox9.Controls.Add(Me.DataGridPago)
        Me.GroupBox9.Controls.Add(Me.btn_AgregarPago)
        Me.GroupBox9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(2, 300)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox9.Size = New System.Drawing.Size(938, 414)
        Me.GroupBox9.TabIndex = 48
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Documentos de Pago"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(89, 15)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 24)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "&Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridPago
        '
        Me.DataGridPago.AllowUserToAddRows = False
        Me.DataGridPago.AllowUserToDeleteRows = False
        Me.DataGridPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridPago.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item0, Me.fpago, Me.doc, Me.bco, Me.fecvcto, Me.Monto, Me.estado, Me.Column2, Me.Column3, Me.Column1})
        Me.DataGridPago.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridPago.Location = New System.Drawing.Point(6, 40)
        Me.DataGridPago.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridPago.Name = "DataGridPago"
        Me.DataGridPago.ReadOnly = True
        Me.DataGridPago.RowHeadersVisible = False
        Me.DataGridPago.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataGridPago.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridPago.Size = New System.Drawing.Size(926, 366)
        Me.DataGridPago.TabIndex = 0
        '
        'item0
        '
        Me.item0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.item0.HeaderText = "Item"
        Me.item0.Name = "item0"
        Me.item0.ReadOnly = True
        Me.item0.Width = 56
        '
        'fpago
        '
        Me.fpago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.fpago.HeaderText = "Forma Pago"
        Me.fpago.Name = "fpago"
        Me.fpago.ReadOnly = True
        '
        'doc
        '
        Me.doc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.doc.HeaderText = "Documento"
        Me.doc.Name = "doc"
        Me.doc.ReadOnly = True
        Me.doc.Width = 96
        '
        'bco
        '
        Me.bco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.bco.HeaderText = "Banco"
        Me.bco.Name = "bco"
        Me.bco.ReadOnly = True
        Me.bco.Width = 67
        '
        'fecvcto
        '
        Me.fecvcto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.fecvcto.HeaderText = "Fecha Vcto."
        Me.fecvcto.Name = "fecvcto"
        Me.fecvcto.ReadOnly = True
        Me.fecvcto.Width = 95
        '
        'Monto
        '
        Me.Monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Monto.DefaultCellStyle = DataGridViewCellStyle1
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        Me.Monto.Width = 65
        '
        'estado
        '
        Me.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.estado.HeaderText = "Contabilizado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        Me.estado.Width = 107
        '
        'Column2
        '
        Me.Column2.HeaderText = "Pagado"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 75
        '
        'Column3
        '
        Me.Column3.HeaderText = "Fecha Pago"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 98
        '
        'Column1
        '
        Me.Column1.HeaderText = "PAGAR"
        Me.Column1.Image = Global.GestionVivero.My.Resources.Resources.Update
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.Width = 52
        '
        'btn_AgregarPago
        '
        Me.btn_AgregarPago.Location = New System.Drawing.Point(8, 15)
        Me.btn_AgregarPago.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_AgregarPago.Name = "btn_AgregarPago"
        Me.btn_AgregarPago.Size = New System.Drawing.Size(75, 24)
        Me.btn_AgregarPago.TabIndex = 9
        Me.btn_AgregarPago.Text = "&Agregar -->"
        Me.btn_AgregarPago.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(217, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Proveedor"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.txt_TOTPAGOS)
        Me.GroupBox10.Controls.Add(Me.Label19)
        Me.GroupBox10.Location = New System.Drawing.Point(946, 646)
        Me.GroupBox10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox10.Size = New System.Drawing.Size(112, 60)
        Me.GroupBox10.TabIndex = 50
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Total Pagos"
        '
        'txt_TOTPAGOS
        '
        Me.txt_TOTPAGOS.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_TOTPAGOS.CausesValidation = False
        Me.txt_TOTPAGOS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TOTPAGOS.ForeColor = System.Drawing.Color.Yellow
        Me.txt_TOTPAGOS.Location = New System.Drawing.Point(18, 25)
        Me.txt_TOTPAGOS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_TOTPAGOS.Name = "txt_TOTPAGOS"
        Me.txt_TOTPAGOS.ReadOnly = True
        Me.txt_TOTPAGOS.Size = New System.Drawing.Size(79, 22)
        Me.txt_TOTPAGOS.TabIndex = 11
        Me.txt_TOTPAGOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(271, 14)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(0, 13)
        Me.Label19.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(505, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "RUT Proveedor"
        '
        'txt_RutProveedor
        '
        Me.txt_RutProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_RutProveedor.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RutProveedor.ForeColor = System.Drawing.Color.White
        Me.txt_RutProveedor.Location = New System.Drawing.Point(593, 43)
        Me.txt_RutProveedor.Name = "txt_RutProveedor"
        Me.txt_RutProveedor.ReadOnly = True
        Me.txt_RutProveedor.Size = New System.Drawing.Size(97, 21)
        Me.txt_RutProveedor.TabIndex = 52
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(488, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Fecha"
        '
        'txt_FechaFactura
        '
        Me.txt_FechaFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_FechaFactura.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FechaFactura.ForeColor = System.Drawing.Color.White
        Me.txt_FechaFactura.Location = New System.Drawing.Point(541, 111)
        Me.txt_FechaFactura.Name = "txt_FechaFactura"
        Me.txt_FechaFactura.ReadOnly = True
        Me.txt_FechaFactura.Size = New System.Drawing.Size(97, 21)
        Me.txt_FechaFactura.TabIndex = 54
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1058, 24)
        Me.MenuStrip1.TabIndex = 55
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GrabarPagosToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'GrabarPagosToolStripMenuItem
        '
        Me.GrabarPagosToolStripMenuItem.Name = "GrabarPagosToolStripMenuItem"
        Me.GrabarPagosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GrabarPagosToolStripMenuItem.Text = "Grabar Pagos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtIDPagos)
        Me.GroupBox1.Controls.Add(Me.btn_Pago)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.dtpFechaPago)
        Me.GroupBox1.Controls.Add(Me.txtMontoPagar)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cmbFormaPago)
        Me.GroupBox1.Location = New System.Drawing.Point(518, 191)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(525, 101)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pago de Documentos"
        '
        'txtIDPagos
        '
        Me.txtIDPagos.Location = New System.Drawing.Point(23, 81)
        Me.txtIDPagos.Name = "txtIDPagos"
        Me.txtIDPagos.Size = New System.Drawing.Size(100, 20)
        Me.txtIDPagos.TabIndex = 37
        Me.txtIDPagos.Visible = False
        '
        'btn_Pago
        '
        Me.btn_Pago.BackColor = System.Drawing.Color.White
        Me.btn_Pago.Enabled = False
        Me.btn_Pago.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.btn_Pago.Location = New System.Drawing.Point(428, 31)
        Me.btn_Pago.Name = "btn_Pago"
        Me.btn_Pago.Size = New System.Drawing.Size(75, 47)
        Me.btn_Pago.TabIndex = 36
        Me.btn_Pago.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 13)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Forma de Pago"
        '
        'dtpFechaPago
        '
        Me.dtpFechaPago.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPago.Location = New System.Drawing.Point(283, 55)
        Me.dtpFechaPago.Name = "dtpFechaPago"
        Me.dtpFechaPago.Size = New System.Drawing.Size(86, 21)
        Me.dtpFechaPago.TabIndex = 34
        '
        'txtMontoPagar
        '
        Me.txtMontoPagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMontoPagar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoPagar.HidePromptOnLeave = True
        Me.txtMontoPagar.Location = New System.Drawing.Point(113, 56)
        Me.txtMontoPagar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMontoPagar.Mask = "999999999"
        Me.txtMontoPagar.Name = "txtMontoPagar"
        Me.txtMontoPagar.ReadOnly = True
        Me.txtMontoPagar.Size = New System.Drawing.Size(93, 22)
        Me.txtMontoPagar.TabIndex = 19
        Me.txtMontoPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Monto"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(212, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Fecha Pago"
        '
        'cmbFormaPago
        '
        Me.cmbFormaPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbFormaPago.DataSource = Me.BANCOBindingSource
        Me.cmbFormaPago.DisplayMember = "Nombre"
        Me.cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFormaPago.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFormaPago.FormattingEnabled = True
        Me.cmbFormaPago.Location = New System.Drawing.Point(113, 24)
        Me.cmbFormaPago.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbFormaPago.Name = "cmbFormaPago"
        Me.cmbFormaPago.Size = New System.Drawing.Size(256, 24)
        Me.cmbFormaPago.TabIndex = 0
        Me.cmbFormaPago.ValueMember = "idcodigo"
        '
        'BANCOBindingSource
        '
        Me.BANCOBindingSource.DataMember = "BANCO"
        Me.BANCOBindingSource.DataSource = Me.DS_FormaPago
        '
        'DS_FormaPago
        '
        Me.DS_FormaPago.DataSetName = "DS_FormaPago"
        Me.DS_FormaPago.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BANCOTableAdapter
        '
        Me.BANCOTableAdapter.ClearBeforeFill = True
        '
        'txtIdProveedor
        '
        Me.txtIdProveedor.Location = New System.Drawing.Point(752, 41)
        Me.txtIdProveedor.Name = "txtIdProveedor"
        Me.txtIdProveedor.Size = New System.Drawing.Size(100, 20)
        Me.txtIdProveedor.TabIndex = 56
        Me.txtIdProveedor.Visible = False
        '
        'Pago_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 711)
        Me.Controls.Add(Me.txtIdProveedor)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_FechaFactura)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_RutProveedor)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_ValorPagado)
        Me.Controls.Add(Me.txt_ImpEspecifico)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_Valor_Neto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_Iva)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_ValorDocumento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_Factura)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_BUSCAR)
        Me.Controls.Add(Me.cmb_PROVEEDOR)
        Me.Controls.Add(Me.txt_BUSCARPROVEEDOR)
        Me.Controls.Add(Me.txt_NOM_PRO)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Pago_Proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago Proveedores"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.DataGridPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BANCOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_FormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_BUSCAR As System.Windows.Forms.Button
    Friend WithEvents cmb_PROVEEDOR As System.Windows.Forms.ComboBox
    Friend WithEvents txt_BUSCARPROVEEDOR As System.Windows.Forms.TextBox
    Friend WithEvents txt_NOM_PRO As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_Factura As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_ValorDocumento As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Iva As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Valor_Neto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_ImpEspecifico As System.Windows.Forms.TextBox
    Friend WithEvents txt_ValorPagado As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_FechaVcto As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_MontoDoc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_BANCO As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_NUM_DOCPAGO As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_TIPO_PAGO As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridPago As System.Windows.Forms.DataGridView
    Friend WithEvents btn_AgregarPago As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_TOTPAGOS As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_RutProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_FechaFactura As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrabarPagosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents item0 As DataGridViewTextBoxColumn
    Friend WithEvents fpago As DataGridViewTextBoxColumn
    Friend WithEvents doc As DataGridViewTextBoxColumn
    Friend WithEvents bco As DataGridViewTextBoxColumn
    Friend WithEvents fecvcto As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpFechaPago As DateTimePicker
    Friend WithEvents txtMontoPagar As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbFormaPago As ComboBox
    Friend WithEvents DS_FormaPago As DS_FormaPago
    Friend WithEvents BANCOBindingSource As BindingSource
    Friend WithEvents BANCOTableAdapter As DS_FormaPagoTableAdapters.BANCOTableAdapter
    Friend WithEvents btn_Pago As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents txtIDPagos As TextBox
    Friend WithEvents txtIdProveedor As TextBox
End Class
