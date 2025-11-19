<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cotizacion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.chkCliente = New System.Windows.Forms.CheckBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txt_clientebuscar = New System.Windows.Forms.TextBox()
        Me.cmb_IDVENDEDOR = New System.Windows.Forms.ComboBox()
        Me.SPCONSULTAFULLVENDEDORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GESTDataSet = New GestionVivero.GESTDataSet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_NombreCliente = New System.Windows.Forms.MaskedTextBox()
        Me.txt_IDCliente = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_RUT_CLI = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.cmb_FormaEntrega = New System.Windows.Forms.ComboBox()
        Me.SPCONSULTAFULLFORMAENTREGABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Cotizacion = New GestionVivero.DS_Cotizacion()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_LUGAR_ENTREGA = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_FechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.dtp_Fecha_Inicio = New System.Windows.Forms.DateTimePicker()
        Me.txt_Ndias_Fabricacion = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_totallote = New System.Windows.Forms.TextBox()
        Me.txt_CantBandejas = New System.Windows.Forms.MaskedTextBox()
        Me.txt_Cantidad = New System.Windows.Forms.MaskedTextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txt_TotalPedido = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rb_PrecioVentaEspecial = New System.Windows.Forms.RadioButton()
        Me.rb_PrecioVentaLista = New System.Windows.Forms.RadioButton()
        Me.txt_PrecioVenta = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_aportasemilla = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_variedad = New System.Windows.Forms.ComboBox()
        Me.SPCONSULTAFULLVARIEDADIdFamiliaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_Familia = New System.Windows.Forms.ComboBox()
        Me.SPCONSULTAFULLFAMILIAPRODUCTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_Comentarios = New System.Windows.Forms.MaskedTextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmb_TipoBandeja = New System.Windows.Forms.ComboBox()
        Me.SPCONSULTAFULLTIPOBANDEJABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGrilla = New System.Windows.Forms.DataGridView()
        Me.lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecini = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecentrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bandejas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Semilla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Variedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipoband = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdtipoBand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idfam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idvariedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.aportesemilla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.printdocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.SP_CONSULTA_FULL_VENDEDORTableAdapter = New GestionVivero.GESTDataSetTableAdapters.SP_CONSULTA_FULL_VENDEDORTableAdapter()
        Me.SP_CONSULTA_FULL_TIPOBANDEJATableAdapter = New GestionVivero.DS_CotizacionTableAdapters.SP_CONSULTA_FULL_TIPOBANDEJATableAdapter()
        Me.SP_CONSULTA_FULL_FAMILIA_PRODUCTOTableAdapter = New GestionVivero.DS_CotizacionTableAdapters.SP_CONSULTA_FULL_FAMILIA_PRODUCTOTableAdapter()
        Me.SP_CONSULTA_FULL_VARIEDAD_IdFamiliaTableAdapter = New GestionVivero.DS_CotizacionTableAdapters.SP_CONSULTA_FULL_VARIEDAD_IdFamiliaTableAdapter()
        Me.SP_CONSULTA_FULL_FORMAENTREGATableAdapter = New GestionVivero.DS_CotizacionTableAdapters.SP_CONSULTA_FULL_FORMAENTREGATableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.SPCONSULTAFULLVENDEDORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.SPCONSULTAFULLFORMAENTREGABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Cotizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.SPCONSULTAFULLVARIEDADIdFamiliaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPCONSULTAFULLFAMILIAPRODUCTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPCONSULTAFULLTIPOBANDEJABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox9)
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.cmb_IDVENDEDOR)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.txt_NombreCliente)
        Me.GroupBox1.Controls.Add(Me.txt_IDCliente)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_RUT_CLI)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1123, 109)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Pedido"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.dtpFecha)
        Me.GroupBox9.Controls.Add(Me.Label9)
        Me.GroupBox9.Location = New System.Drawing.Point(46, 15)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(314, 86)
        Me.GroupBox9.TabIndex = 113
        Me.GroupBox9.TabStop = False
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(86, 35)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(109, 20)
        Me.dtpFecha.TabIndex = 114
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 113
        Me.Label9.Text = "Fecha"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.chkCliente)
        Me.GroupBox8.Controls.Add(Me.Button6)
        Me.GroupBox8.Controls.Add(Me.Label27)
        Me.GroupBox8.Controls.Add(Me.txt_clientebuscar)
        Me.GroupBox8.Location = New System.Drawing.Point(384, 15)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(314, 86)
        Me.GroupBox8.TabIndex = 112
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Selección del Cliente"
        '
        'chkCliente
        '
        Me.chkCliente.AutoSize = True
        Me.chkCliente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCliente.Location = New System.Drawing.Point(35, 62)
        Me.chkCliente.Name = "chkCliente"
        Me.chkCliente.Size = New System.Drawing.Size(132, 18)
        Me.chkCliente.TabIndex = 115
        Me.chkCliente.Text = "incluye primer nombre"
        Me.chkCliente.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = Global.GestionVivero.My.Resources.Resources.buscar_40x40
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button6.Location = New System.Drawing.Point(251, 26)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(48, 48)
        Me.Button6.TabIndex = 114
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(35, 21)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(124, 13)
        Me.Label27.TabIndex = 112
        Me.Label27.Text = "Ingrese nombre a buscar"
        '
        'txt_clientebuscar
        '
        Me.txt_clientebuscar.BackColor = System.Drawing.SystemColors.Window
        Me.txt_clientebuscar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clientebuscar.ForeColor = System.Drawing.Color.Navy
        Me.txt_clientebuscar.Location = New System.Drawing.Point(35, 37)
        Me.txt_clientebuscar.Name = "txt_clientebuscar"
        Me.txt_clientebuscar.Size = New System.Drawing.Size(206, 21)
        Me.txt_clientebuscar.TabIndex = 113
        '
        'cmb_IDVENDEDOR
        '
        Me.cmb_IDVENDEDOR.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_IDVENDEDOR.DataSource = Me.SPCONSULTAFULLVENDEDORBindingSource
        Me.cmb_IDVENDEDOR.DisplayMember = "NOMBRE"
        Me.cmb_IDVENDEDOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_IDVENDEDOR.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_IDVENDEDOR.ForeColor = System.Drawing.Color.Navy
        Me.cmb_IDVENDEDOR.FormattingEnabled = True
        Me.cmb_IDVENDEDOR.Location = New System.Drawing.Point(804, 72)
        Me.cmb_IDVENDEDOR.Name = "cmb_IDVENDEDOR"
        Me.cmb_IDVENDEDOR.Size = New System.Drawing.Size(311, 23)
        Me.cmb_IDVENDEDOR.TabIndex = 10
        Me.cmb_IDVENDEDOR.ValueMember = "IdVendedor"
        '
        'SPCONSULTAFULLVENDEDORBindingSource
        '
        Me.SPCONSULTAFULLVENDEDORBindingSource.DataMember = "SP_CONSULTA_FULL_VENDEDOR"
        Me.SPCONSULTAFULLVENDEDORBindingSource.DataSource = Me.GESTDataSet
        '
        'GESTDataSet
        '
        Me.GESTDataSet.DataSetName = "GESTDataSet"
        Me.GESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(708, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Vendedor"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(704, 45)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(79, 13)
        Me.Label25.TabIndex = 14
        Me.Label25.Text = "Nombre Cliente"
        '
        'txt_NombreCliente
        '
        Me.txt_NombreCliente.BackColor = System.Drawing.Color.Navy
        Me.txt_NombreCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NombreCliente.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_NombreCliente.Location = New System.Drawing.Point(804, 40)
        Me.txt_NombreCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_NombreCliente.Name = "txt_NombreCliente"
        Me.txt_NombreCliente.Size = New System.Drawing.Size(311, 22)
        Me.txt_NombreCliente.TabIndex = 15
        '
        'txt_IDCliente
        '
        Me.txt_IDCliente.BackColor = System.Drawing.Color.Navy
        Me.txt_IDCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IDCliente.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_IDCliente.HidePromptOnLeave = True
        Me.txt_IDCliente.Location = New System.Drawing.Point(1076, 15)
        Me.txt_IDCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_IDCliente.Mask = "99999999999"
        Me.txt_IDCliente.Name = "txt_IDCliente"
        Me.txt_IDCliente.ReadOnly = True
        Me.txt_IDCliente.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_IDCliente.Size = New System.Drawing.Size(39, 22)
        Me.txt_IDCliente.TabIndex = 6
        Me.txt_IDCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1052, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Id"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(704, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "R.U.T. Cliente"
        '
        'txt_RUT_CLI
        '
        Me.txt_RUT_CLI.BackColor = System.Drawing.Color.Navy
        Me.txt_RUT_CLI.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RUT_CLI.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_RUT_CLI.HidePromptOnLeave = True
        Me.txt_RUT_CLI.Location = New System.Drawing.Point(804, 15)
        Me.txt_RUT_CLI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_RUT_CLI.Name = "txt_RUT_CLI"
        Me.txt_RUT_CLI.ReadOnly = True
        Me.txt_RUT_CLI.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_RUT_CLI.Size = New System.Drawing.Size(83, 22)
        Me.txt_RUT_CLI.TabIndex = 8
        Me.txt_RUT_CLI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox7)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.cmb_aportasemilla)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmb_variedad)
        Me.GroupBox2.Controls.Add(Me.cmb_Familia)
        Me.GroupBox2.Controls.Add(Me.txt_Comentarios)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.cmb_TipoBandeja)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.DataGrilla)
        Me.GroupBox2.Location = New System.Drawing.Point(1, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1123, 543)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos para cada Lote"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.cmb_FormaEntrega)
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Controls.Add(Me.txt_LUGAR_ENTREGA)
        Me.GroupBox7.Location = New System.Drawing.Point(359, 392)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(519, 100)
        Me.GroupBox7.TabIndex = 48
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Entrega"
        '
        'cmb_FormaEntrega
        '
        Me.cmb_FormaEntrega.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_FormaEntrega.DataSource = Me.SPCONSULTAFULLFORMAENTREGABindingSource
        Me.cmb_FormaEntrega.DisplayMember = "DESCRIPCION"
        Me.cmb_FormaEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_FormaEntrega.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_FormaEntrega.ForeColor = System.Drawing.Color.Navy
        Me.cmb_FormaEntrega.FormattingEnabled = True
        Me.cmb_FormaEntrega.Location = New System.Drawing.Point(87, 52)
        Me.cmb_FormaEntrega.Name = "cmb_FormaEntrega"
        Me.cmb_FormaEntrega.Size = New System.Drawing.Size(359, 23)
        Me.cmb_FormaEntrega.TabIndex = 17
        Me.cmb_FormaEntrega.ValueMember = "IdFormaEntrega"
        '
        'SPCONSULTAFULLFORMAENTREGABindingSource
        '
        Me.SPCONSULTAFULLFORMAENTREGABindingSource.DataMember = "SP_CONSULTA_FULL_FORMAENTREGA"
        Me.SPCONSULTAFULLFORMAENTREGABindingSource.DataSource = Me.DS_Cotizacion
        '
        'DS_Cotizacion
        '
        Me.DS_Cotizacion.DataSetName = "DS_Cotizacion"
        Me.DS_Cotizacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Forma"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Lugar"
        '
        'txt_LUGAR_ENTREGA
        '
        Me.txt_LUGAR_ENTREGA.BackColor = System.Drawing.SystemColors.Window
        Me.txt_LUGAR_ENTREGA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LUGAR_ENTREGA.ForeColor = System.Drawing.Color.Navy
        Me.txt_LUGAR_ENTREGA.Location = New System.Drawing.Point(87, 20)
        Me.txt_LUGAR_ENTREGA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_LUGAR_ENTREGA.Name = "txt_LUGAR_ENTREGA"
        Me.txt_LUGAR_ENTREGA.Size = New System.Drawing.Size(359, 22)
        Me.txt_LUGAR_ENTREGA.TabIndex = 15
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.dtp_FechaEntrega)
        Me.GroupBox6.Controls.Add(Me.dtp_Fecha_Inicio)
        Me.GroupBox6.Controls.Add(Me.txt_Ndias_Fabricacion)
        Me.GroupBox6.Location = New System.Drawing.Point(98, 71)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(256, 100)
        Me.GroupBox6.TabIndex = 47
        Me.GroupBox6.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(22, 13)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 13)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "N° Días"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Fecha Inicio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Fecha Entrega"
        '
        'dtp_FechaEntrega
        '
        Me.dtp_FechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaEntrega.Location = New System.Drawing.Point(109, 70)
        Me.dtp_FechaEntrega.Name = "dtp_FechaEntrega"
        Me.dtp_FechaEntrega.Size = New System.Drawing.Size(79, 20)
        Me.dtp_FechaEntrega.TabIndex = 48
        '
        'dtp_Fecha_Inicio
        '
        Me.dtp_Fecha_Inicio.Enabled = False
        Me.dtp_Fecha_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha_Inicio.Location = New System.Drawing.Point(109, 39)
        Me.dtp_Fecha_Inicio.Name = "dtp_Fecha_Inicio"
        Me.dtp_Fecha_Inicio.Size = New System.Drawing.Size(79, 20)
        Me.dtp_Fecha_Inicio.TabIndex = 47
        '
        'txt_Ndias_Fabricacion
        '
        Me.txt_Ndias_Fabricacion.BackColor = System.Drawing.Color.Navy
        Me.txt_Ndias_Fabricacion.Enabled = False
        Me.txt_Ndias_Fabricacion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Ndias_Fabricacion.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_Ndias_Fabricacion.HidePromptOnLeave = True
        Me.txt_Ndias_Fabricacion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_Ndias_Fabricacion.Location = New System.Drawing.Point(109, 10)
        Me.txt_Ndias_Fabricacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Ndias_Fabricacion.Mask = "###"
        Me.txt_Ndias_Fabricacion.Name = "txt_Ndias_Fabricacion"
        Me.txt_Ndias_Fabricacion.ReadOnly = True
        Me.txt_Ndias_Fabricacion.Size = New System.Drawing.Size(79, 22)
        Me.txt_Ndias_Fabricacion.TabIndex = 46
        Me.txt_Ndias_Fabricacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_Ndias_Fabricacion.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_totallote)
        Me.GroupBox3.Controls.Add(Me.txt_CantBandejas)
        Me.GroupBox3.Controls.Add(Me.txt_Cantidad)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(684, 71)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(256, 100)
        Me.GroupBox3.TabIndex = 46
        Me.GroupBox3.TabStop = False
        '
        'txt_totallote
        '
        Me.txt_totallote.BackColor = System.Drawing.Color.Navy
        Me.txt_totallote.CausesValidation = False
        Me.txt_totallote.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totallote.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_totallote.Location = New System.Drawing.Point(149, 70)
        Me.txt_totallote.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_totallote.Name = "txt_totallote"
        Me.txt_totallote.ReadOnly = True
        Me.txt_totallote.Size = New System.Drawing.Size(93, 22)
        Me.txt_totallote.TabIndex = 25
        Me.txt_totallote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_CantBandejas
        '
        Me.txt_CantBandejas.BackColor = System.Drawing.Color.Navy
        Me.txt_CantBandejas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CantBandejas.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_CantBandejas.HidePromptOnLeave = True
        Me.txt_CantBandejas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_CantBandejas.Location = New System.Drawing.Point(149, 40)
        Me.txt_CantBandejas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_CantBandejas.Name = "txt_CantBandejas"
        Me.txt_CantBandejas.ReadOnly = True
        Me.txt_CantBandejas.Size = New System.Drawing.Size(93, 22)
        Me.txt_CantBandejas.TabIndex = 26
        Me.txt_CantBandejas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_CantBandejas.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txt_Cantidad
        '
        Me.txt_Cantidad.BackColor = System.Drawing.SystemColors.Window
        Me.txt_Cantidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cantidad.ForeColor = System.Drawing.Color.Navy
        Me.txt_Cantidad.HidePromptOnLeave = True
        Me.txt_Cantidad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_Cantidad.Location = New System.Drawing.Point(149, 13)
        Me.txt_Cantidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Cantidad.Mask = "########0"
        Me.txt_Cantidad.Name = "txt_Cantidad"
        Me.txt_Cantidad.Size = New System.Drawing.Size(93, 22)
        Me.txt_Cantidad.TabIndex = 24
        Me.txt_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_Cantidad.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(22, 75)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(55, 13)
        Me.Label26.TabIndex = 22
        Me.Label26.Text = "Total Lote"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(22, 45)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(51, 13)
        Me.Label22.TabIndex = 23
        Me.Label22.Text = "Bandejas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Cantidad Plantas"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txt_TotalPedido)
        Me.GroupBox5.Location = New System.Drawing.Point(917, 421)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 54)
        Me.GroupBox5.TabIndex = 40
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Valor Total Cotización"
        '
        'txt_TotalPedido
        '
        Me.txt_TotalPedido.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_TotalPedido.CausesValidation = False
        Me.txt_TotalPedido.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalPedido.ForeColor = System.Drawing.Color.Yellow
        Me.txt_TotalPedido.Location = New System.Drawing.Point(48, 20)
        Me.txt_TotalPedido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_TotalPedido.Name = "txt_TotalPedido"
        Me.txt_TotalPedido.ReadOnly = True
        Me.txt_TotalPedido.Size = New System.Drawing.Size(114, 26)
        Me.txt_TotalPedido.TabIndex = 28
        Me.txt_TotalPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rb_PrecioVentaEspecial)
        Me.GroupBox4.Controls.Add(Me.rb_PrecioVentaLista)
        Me.GroupBox4.Controls.Add(Me.txt_PrecioVenta)
        Me.GroupBox4.Location = New System.Drawing.Point(369, 71)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(256, 100)
        Me.GroupBox4.TabIndex = 39
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Precio de Venta Final"
        '
        'rb_PrecioVentaEspecial
        '
        Me.rb_PrecioVentaEspecial.AutoSize = True
        Me.rb_PrecioVentaEspecial.Location = New System.Drawing.Point(10, 58)
        Me.rb_PrecioVentaEspecial.Name = "rb_PrecioVentaEspecial"
        Me.rb_PrecioVentaEspecial.Size = New System.Drawing.Size(98, 17)
        Me.rb_PrecioVentaEspecial.TabIndex = 23
        Me.rb_PrecioVentaEspecial.Text = "Precio Especial"
        Me.rb_PrecioVentaEspecial.UseVisualStyleBackColor = True
        '
        'rb_PrecioVentaLista
        '
        Me.rb_PrecioVentaLista.AutoSize = True
        Me.rb_PrecioVentaLista.Checked = True
        Me.rb_PrecioVentaLista.Location = New System.Drawing.Point(10, 33)
        Me.rb_PrecioVentaLista.Name = "rb_PrecioVentaLista"
        Me.rb_PrecioVentaLista.Size = New System.Drawing.Size(80, 17)
        Me.rb_PrecioVentaLista.TabIndex = 22
        Me.rb_PrecioVentaLista.TabStop = True
        Me.rb_PrecioVentaLista.Text = "Precio Lista"
        Me.rb_PrecioVentaLista.UseVisualStyleBackColor = True
        '
        'txt_PrecioVenta
        '
        Me.txt_PrecioVenta.BackColor = System.Drawing.Color.Navy
        Me.txt_PrecioVenta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PrecioVenta.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_PrecioVenta.HidePromptOnLeave = True
        Me.txt_PrecioVenta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_PrecioVenta.Location = New System.Drawing.Point(155, 40)
        Me.txt_PrecioVenta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_PrecioVenta.Name = "txt_PrecioVenta"
        Me.txt_PrecioVenta.Size = New System.Drawing.Size(67, 22)
        Me.txt_PrecioVenta.TabIndex = 15
        Me.txt_PrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_PrecioVenta.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'cmb_aportasemilla
        '
        Me.cmb_aportasemilla.BackColor = System.Drawing.Color.White
        Me.cmb_aportasemilla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_aportasemilla.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_aportasemilla.ForeColor = System.Drawing.Color.Navy
        Me.cmb_aportasemilla.FormattingEnabled = True
        Me.cmb_aportasemilla.Items.AddRange(New Object() {"SI", "NO"})
        Me.cmb_aportasemilla.Location = New System.Drawing.Point(884, 30)
        Me.cmb_aportasemilla.Name = "cmb_aportasemilla"
        Me.cmb_aportasemilla.Size = New System.Drawing.Size(56, 23)
        Me.cmb_aportasemilla.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(863, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Cliente aporta semilla"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(582, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Variedad"
        '
        'cmb_variedad
        '
        Me.cmb_variedad.BackColor = System.Drawing.Color.White
        Me.cmb_variedad.DataSource = Me.SPCONSULTAFULLVARIEDADIdFamiliaBindingSource
        Me.cmb_variedad.DisplayMember = "Descripcion"
        Me.cmb_variedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_variedad.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_variedad.ForeColor = System.Drawing.Color.Navy
        Me.cmb_variedad.FormattingEnabled = True
        Me.cmb_variedad.Location = New System.Drawing.Point(585, 30)
        Me.cmb_variedad.Name = "cmb_variedad"
        Me.cmb_variedad.Size = New System.Drawing.Size(254, 23)
        Me.cmb_variedad.TabIndex = 5
        Me.cmb_variedad.ValueMember = "IdVariedad"
        '
        'SPCONSULTAFULLVARIEDADIdFamiliaBindingSource
        '
        Me.SPCONSULTAFULLVARIEDADIdFamiliaBindingSource.DataMember = "SP_CONSULTA_FULL_VARIEDAD_IdFamilia"
        Me.SPCONSULTAFULLVARIEDADIdFamiliaBindingSource.DataSource = Me.DS_Cotizacion
        '
        'cmb_Familia
        '
        Me.cmb_Familia.BackColor = System.Drawing.Color.White
        Me.cmb_Familia.DataSource = Me.SPCONSULTAFULLFAMILIAPRODUCTOBindingSource
        Me.cmb_Familia.DisplayMember = "DESCRIP"
        Me.cmb_Familia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Familia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Familia.ForeColor = System.Drawing.Color.Navy
        Me.cmb_Familia.FormattingEnabled = True
        Me.cmb_Familia.Location = New System.Drawing.Point(271, 30)
        Me.cmb_Familia.Name = "cmb_Familia"
        Me.cmb_Familia.Size = New System.Drawing.Size(308, 23)
        Me.cmb_Familia.TabIndex = 3
        Me.cmb_Familia.ValueMember = "idFamilia"
        '
        'SPCONSULTAFULLFAMILIAPRODUCTOBindingSource
        '
        Me.SPCONSULTAFULLFAMILIAPRODUCTOBindingSource.DataMember = "SP_CONSULTA_FULL_FAMILIA_PRODUCTO"
        Me.SPCONSULTAFULLFAMILIAPRODUCTOBindingSource.DataSource = Me.DS_Cotizacion
        '
        'txt_Comentarios
        '
        Me.txt_Comentarios.BackColor = System.Drawing.SystemColors.Window
        Me.txt_Comentarios.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Comentarios.ForeColor = System.Drawing.Color.Navy
        Me.txt_Comentarios.Location = New System.Drawing.Point(84, 505)
        Me.txt_Comentarios.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Comentarios.Name = "txt_Comentarios"
        Me.txt_Comentarios.Size = New System.Drawing.Size(794, 22)
        Me.txt_Comentarios.TabIndex = 24
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(13, 510)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(65, 13)
        Me.Label24.TabIndex = 22
        Me.Label24.Text = "Comentarios"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(13, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(85, 13)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Tipo de Bandeja"
        '
        'cmb_TipoBandeja
        '
        Me.cmb_TipoBandeja.BackColor = System.Drawing.Color.White
        Me.cmb_TipoBandeja.DataSource = Me.SPCONSULTAFULLTIPOBANDEJABindingSource
        Me.cmb_TipoBandeja.DisplayMember = "DESCRIPCION"
        Me.cmb_TipoBandeja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoBandeja.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_TipoBandeja.ForeColor = System.Drawing.Color.Navy
        Me.cmb_TipoBandeja.FormattingEnabled = True
        Me.cmb_TipoBandeja.Location = New System.Drawing.Point(12, 30)
        Me.cmb_TipoBandeja.Name = "cmb_TipoBandeja"
        Me.cmb_TipoBandeja.Size = New System.Drawing.Size(242, 23)
        Me.cmb_TipoBandeja.TabIndex = 1
        Me.cmb_TipoBandeja.ValueMember = "IdTipoBandeja"
        '
        'SPCONSULTAFULLTIPOBANDEJABindingSource
        '
        Me.SPCONSULTAFULLTIPOBANDEJABindingSource.DataMember = "SP_CONSULTA_FULL_TIPOBANDEJA"
        Me.SPCONSULTAFULLTIPOBANDEJABindingSource.DataSource = Me.DS_Cotizacion
        '
        'Button3
        '
        Me.Button3.Image = Global.GestionVivero.My.Resources.Resources.eliminar_40x40
        Me.Button3.Location = New System.Drawing.Point(1031, 267)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(48, 48)
        Me.Button3.TabIndex = 25
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.guardar_40x40
        Me.Button2.Location = New System.Drawing.Point(1031, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 48)
        Me.Button2.TabIndex = 24
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(268, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Semilla"
        '
        'DataGrilla
        '
        Me.DataGrilla.AllowUserToAddRows = False
        Me.DataGrilla.AllowUserToDeleteRows = False
        Me.DataGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGrilla.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.lote, Me.fecini, Me.fecentrega, Me.bandejas, Me.Semilla, Me.Variedad, Me.Cantidad, Me.prec, Me.Total, Me.Tipoband, Me.Estado, Me.IdtipoBand, Me.idfam, Me.idvariedad, Me.aportesemilla})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrilla.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrilla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGrilla.Location = New System.Drawing.Point(2, 192)
        Me.DataGrilla.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGrilla.Name = "DataGrilla"
        Me.DataGrilla.RowHeadersVisible = False
        Me.DataGrilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataGrilla.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGrilla.Size = New System.Drawing.Size(938, 196)
        Me.DataGrilla.TabIndex = 26
        '
        'lote
        '
        Me.lote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.lote.FillWeight = 40.0!
        Me.lote.HeaderText = "N°"
        Me.lote.Name = "lote"
        Me.lote.Visible = False
        '
        'fecini
        '
        Me.fecini.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.fecini.FillWeight = 50.0!
        Me.fecini.HeaderText = "Fec.Siembra"
        Me.fecini.Name = "fecini"
        Me.fecini.Width = 91
        '
        'fecentrega
        '
        Me.fecentrega.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.fecentrega.FillWeight = 50.0!
        Me.fecentrega.HeaderText = "Fec.Entrega"
        Me.fecentrega.Name = "fecentrega"
        Me.fecentrega.Width = 90
        '
        'bandejas
        '
        Me.bandejas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.bandejas.FillWeight = 20.0!
        Me.bandejas.HeaderText = "Bandejas"
        Me.bandejas.Name = "bandejas"
        Me.bandejas.Width = 76
        '
        'Semilla
        '
        Me.Semilla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Semilla.FillWeight = 80.0!
        Me.Semilla.HeaderText = "Semilla"
        Me.Semilla.Name = "Semilla"
        Me.Semilla.Width = 65
        '
        'Variedad
        '
        Me.Variedad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Variedad.FillWeight = 80.0!
        Me.Variedad.HeaderText = "Variedad"
        Me.Variedad.Name = "Variedad"
        Me.Variedad.Width = 74
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Cantidad.FillWeight = 60.0!
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 74
        '
        'prec
        '
        Me.prec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.prec.FillWeight = 60.0!
        Me.prec.HeaderText = "Precio"
        Me.prec.Name = "prec"
        Me.prec.Width = 62
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Total.FillWeight = 60.0!
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.Width = 56
        '
        'Tipoband
        '
        Me.Tipoband.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Tipoband.FillWeight = 40.0!
        Me.Tipoband.HeaderText = "T. Band."
        Me.Tipoband.Name = "Tipoband"
        Me.Tipoband.Width = 73
        '
        'Estado
        '
        Me.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Estado.FillWeight = 30.0!
        Me.Estado.HeaderText = "Est."
        Me.Estado.Name = "Estado"
        Me.Estado.Width = 50
        '
        'IdtipoBand
        '
        Me.IdtipoBand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IdtipoBand.FillWeight = 20.0!
        Me.IdtipoBand.HeaderText = "Id.Band"
        Me.IdtipoBand.Name = "IdtipoBand"
        Me.IdtipoBand.Visible = False
        '
        'idfam
        '
        Me.idfam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.idfam.FillWeight = 20.0!
        Me.idfam.HeaderText = "Id.Sem."
        Me.idfam.Name = "idfam"
        Me.idfam.Visible = False
        '
        'idvariedad
        '
        Me.idvariedad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.idvariedad.FillWeight = 20.0!
        Me.idvariedad.HeaderText = "Id.Var."
        Me.idvariedad.Name = "idvariedad"
        Me.idvariedad.Visible = False
        '
        'aportesemilla
        '
        Me.aportesemilla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.aportesemilla.FillWeight = 30.0!
        Me.aportesemilla.HeaderText = "Sem."
        Me.aportesemilla.Name = "aportesemilla"
        Me.aportesemilla.Width = 56
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1136, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(117, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'SP_CONSULTA_FULL_VENDEDORTableAdapter
        '
        Me.SP_CONSULTA_FULL_VENDEDORTableAdapter.ClearBeforeFill = True
        '
        'SP_CONSULTA_FULL_TIPOBANDEJATableAdapter
        '
        Me.SP_CONSULTA_FULL_TIPOBANDEJATableAdapter.ClearBeforeFill = True
        '
        'SP_CONSULTA_FULL_FAMILIA_PRODUCTOTableAdapter
        '
        Me.SP_CONSULTA_FULL_FAMILIA_PRODUCTOTableAdapter.ClearBeforeFill = True
        '
        'SP_CONSULTA_FULL_VARIEDAD_IdFamiliaTableAdapter
        '
        Me.SP_CONSULTA_FULL_VARIEDAD_IdFamiliaTableAdapter.ClearBeforeFill = True
        '
        'SP_CONSULTA_FULL_FORMAENTREGATableAdapter
        '
        Me.SP_CONSULTA_FULL_FORMAENTREGATableAdapter.ClearBeforeFill = True
        '
        'Cotizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1136, 692)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Cotizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cotización"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.SPCONSULTAFULLVENDEDORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.SPCONSULTAFULLFORMAENTREGABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Cotizacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.SPCONSULTAFULLVARIEDADIdFamiliaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPCONSULTAFULLFAMILIAPRODUCTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPCONSULTAFULLTIPOBANDEJABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txt_NombreCliente As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_IDCliente As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_RUT_CLI As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_TotalPedido As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_PrecioVentaEspecial As System.Windows.Forms.RadioButton
    Friend WithEvents rb_PrecioVentaLista As System.Windows.Forms.RadioButton
    Public WithEvents txt_PrecioVenta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmb_aportasemilla As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_variedad As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Familia As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Comentarios As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoBandeja As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_IDVENDEDOR As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents printdocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents GESTDataSet As GESTDataSet
    Friend WithEvents SPCONSULTAFULLVENDEDORBindingSource As BindingSource
    Friend WithEvents SP_CONSULTA_FULL_VENDEDORTableAdapter As GESTDataSetTableAdapters.SP_CONSULTA_FULL_VENDEDORTableAdapter
    Friend WithEvents DS_Cotizacion As DS_Cotizacion
    Friend WithEvents SPCONSULTAFULLTIPOBANDEJABindingSource As BindingSource
    Friend WithEvents SP_CONSULTA_FULL_TIPOBANDEJATableAdapter As DS_CotizacionTableAdapters.SP_CONSULTA_FULL_TIPOBANDEJATableAdapter
    Friend WithEvents SPCONSULTAFULLFAMILIAPRODUCTOBindingSource As BindingSource
    Friend WithEvents SP_CONSULTA_FULL_FAMILIA_PRODUCTOTableAdapter As DS_CotizacionTableAdapters.SP_CONSULTA_FULL_FAMILIA_PRODUCTOTableAdapter
    Friend WithEvents SPCONSULTAFULLVARIEDADIdFamiliaBindingSource As BindingSource
    Friend WithEvents SP_CONSULTA_FULL_VARIEDAD_IdFamiliaTableAdapter As DS_CotizacionTableAdapters.SP_CONSULTA_FULL_VARIEDAD_IdFamiliaTableAdapter
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_FechaEntrega As DateTimePicker
    Friend WithEvents dtp_Fecha_Inicio As DateTimePicker
    Public WithEvents txt_Ndias_Fabricacion As MaskedTextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_totallote As TextBox
    Public WithEvents txt_CantBandejas As MaskedTextBox
    Public WithEvents txt_Cantidad As MaskedTextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents cmb_FormaEntrega As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_LUGAR_ENTREGA As MaskedTextBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents chkCliente As CheckBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Label27 As Label
    Friend WithEvents txt_clientebuscar As TextBox
    Friend WithEvents SPCONSULTAFULLFORMAENTREGABindingSource As BindingSource
    Friend WithEvents SP_CONSULTA_FULL_FORMAENTREGATableAdapter As DS_CotizacionTableAdapters.SP_CONSULTA_FULL_FORMAENTREGATableAdapter
    Friend WithEvents lote As DataGridViewTextBoxColumn
    Friend WithEvents fecini As DataGridViewTextBoxColumn
    Friend WithEvents fecentrega As DataGridViewTextBoxColumn
    Friend WithEvents bandejas As DataGridViewTextBoxColumn
    Friend WithEvents Semilla As DataGridViewTextBoxColumn
    Friend WithEvents Variedad As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents prec As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Tipoband As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents IdtipoBand As DataGridViewTextBoxColumn
    Friend WithEvents idfam As DataGridViewTextBoxColumn
    Friend WithEvents idvariedad As DataGridViewTextBoxColumn
    Friend WithEvents aportesemilla As DataGridViewTextBoxColumn
End Class
