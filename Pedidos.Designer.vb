<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pedidos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEstadoclienteId = New System.Windows.Forms.TextBox()
        Me.chkCliente = New System.Windows.Forms.CheckBox()
        Me.btnBuscaCliente = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_NombreCliente = New System.Windows.Forms.MaskedTextBox()
        Me.txt_IDCliente = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_RUT_CLI = New System.Windows.Forms.MaskedTextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txt_clientebuscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_FormaEntrega = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_LUGAR_ENTREGA = New System.Windows.Forms.MaskedTextBox()
        Me.txt_Ndias_Fabricacion = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDias_INV = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtDias_OTO = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtDias_VER = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.MT_PedidosPendientes = New System.Windows.Forms.MaskedTextBox()
        Me.txtDias_PRI = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.MT_StockActual = New System.Windows.Forms.MaskedTextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.chkSemillaCertificada = New System.Windows.Forms.CheckBox()
        Me.chkSemillaCorriente = New System.Windows.Forms.CheckBox()
        Me.txtUltActualizacion = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_diasprecocidad = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txt_Temporada = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txt_TipoDescarga = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.dtp_FechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.dtp_Fecha_Inicio = New System.Windows.Forms.DateTimePicker()
        Me.txt_StockDispo = New System.Windows.Forms.MaskedTextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txt_DetalleVariedad = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkAumDis = New System.Windows.Forms.CheckBox()
        Me.txtDescto = New System.Windows.Forms.TextBox()
        Me.rb_PrecioVentaEspecial = New System.Windows.Forms.RadioButton()
        Me.rb_PrecioVentaLista = New System.Windows.Forms.RadioButton()
        Me.txt_PrecioVenta = New System.Windows.Forms.MaskedTextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_totallote = New System.Windows.Forms.TextBox()
        Me.txt_CantBandejas = New System.Windows.Forms.MaskedTextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_Batch = New System.Windows.Forms.MaskedTextBox()
        Me.txt_LoteSemilla = New System.Windows.Forms.MaskedTextBox()
        Me.txt_FechaEnvasado = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_aportasemilla = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_variedad = New System.Windows.Forms.ComboBox()
        Me.cmb_Familia = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmb_TipoBandeja = New System.Windows.Forms.ComboBox()
        Me.txt_Cantidad = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.Lotesemilla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.batch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecenvasado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.aportesemilla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoteOriginal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lotes_Hijos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado_Lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNotas = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txt_Comentarios = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_totalneto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_TotalIVA = New System.Windows.Forms.TextBox()
        Me.txt_TotalPedido = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtIdUsuario = New System.Windows.Forms.MaskedTextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.printdocument = New System.Drawing.Printing.PrintDocument()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.dtp_Fecha_Pedido = New System.Windows.Forms.DateTimePicker()
        Me.lblDeuda = New System.Windows.Forms.Label()
        Me.txtTotalDeuda = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExcepcion = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.btnPrintInternal = New System.Windows.Forms.Button()
        Me.btnPrintCustomer = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnAbono = New System.Windows.Forms.Button()
        Me.btn_CrearLoteHijo = New System.Windows.Forms.Button()
        Me.btnAgregaLote = New System.Windows.Forms.Button()
        Me.btnEliminaLote = New System.Windows.Forms.Button()
        Me.txtEstadoPedido = New System.Windows.Forms.TextBox()
        Me.chkExcepcion = New System.Windows.Forms.CheckBox()
        Me.txtMotivoExcepcion = New System.Windows.Forms.TextBox()
        Me.txtIdPedido = New System.Windows.Forms.TextBox()
        Me.txtAbonoInicial = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAbonoSugerido = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEstadoclienteId)
        Me.GroupBox1.Controls.Add(Me.chkCliente)
        Me.GroupBox1.Controls.Add(Me.btnBuscaCliente)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.txt_NombreCliente)
        Me.GroupBox1.Controls.Add(Me.txt_IDCliente)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_RUT_CLI)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.txt_clientebuscar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmb_FormaEntrega)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_LUGAR_ENTREGA)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1274, 101)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Pedido"
        '
        'txtEstadoclienteId
        '
        Me.txtEstadoclienteId.Location = New System.Drawing.Point(269, 61)
        Me.txtEstadoclienteId.Name = "txtEstadoclienteId"
        Me.txtEstadoclienteId.Size = New System.Drawing.Size(39, 20)
        Me.txtEstadoclienteId.TabIndex = 112
        Me.txtEstadoclienteId.Visible = False
        '
        'chkCliente
        '
        Me.chkCliente.AutoSize = True
        Me.chkCliente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCliente.Location = New System.Drawing.Point(16, 61)
        Me.chkCliente.Name = "chkCliente"
        Me.chkCliente.Size = New System.Drawing.Size(132, 18)
        Me.chkCliente.TabIndex = 110
        Me.chkCliente.Text = "incluye primer nombre"
        Me.chkCliente.UseVisualStyleBackColor = True
        '
        'btnBuscaCliente
        '
        Me.btnBuscaCliente.Enabled = False
        Me.btnBuscaCliente.Image = CType(resources.GetObject("btnBuscaCliente.Image"), System.Drawing.Image)
        Me.btnBuscaCliente.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnBuscaCliente.Location = New System.Drawing.Point(188, 32)
        Me.btnBuscaCliente.Name = "btnBuscaCliente"
        Me.btnBuscaCliente.Size = New System.Drawing.Size(66, 23)
        Me.btnBuscaCliente.TabIndex = 22
        Me.btnBuscaCliente.Text = "Buscar"
        Me.btnBuscaCliente.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnBuscaCliente.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(409, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(44, 13)
        Me.Label25.TabIndex = 14
        Me.Label25.Text = "Nombre"
        '
        'txt_NombreCliente
        '
        Me.txt_NombreCliente.BackColor = System.Drawing.Color.Navy
        Me.txt_NombreCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NombreCliente.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_NombreCliente.Location = New System.Drawing.Point(403, 33)
        Me.txt_NombreCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_NombreCliente.Name = "txt_NombreCliente"
        Me.txt_NombreCliente.ReadOnly = True
        Me.txt_NombreCliente.Size = New System.Drawing.Size(505, 22)
        Me.txt_NombreCliente.TabIndex = 15
        '
        'txt_IDCliente
        '
        Me.txt_IDCliente.BackColor = System.Drawing.Color.Navy
        Me.txt_IDCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IDCliente.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_IDCliente.HidePromptOnLeave = True
        Me.txt_IDCliente.Location = New System.Drawing.Point(269, 34)
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
        Me.Label11.Location = New System.Drawing.Point(268, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "ID"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(312, 17)
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
        Me.txt_RUT_CLI.Location = New System.Drawing.Point(314, 34)
        Me.txt_RUT_CLI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_RUT_CLI.Name = "txt_RUT_CLI"
        Me.txt_RUT_CLI.ReadOnly = True
        Me.txt_RUT_CLI.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_RUT_CLI.Size = New System.Drawing.Size(83, 22)
        Me.txt_RUT_CLI.TabIndex = 8
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(13, 17)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(124, 13)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Ingrese nombre a buscar"
        '
        'txt_clientebuscar
        '
        Me.txt_clientebuscar.BackColor = System.Drawing.SystemColors.Window
        Me.txt_clientebuscar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clientebuscar.ForeColor = System.Drawing.Color.Navy
        Me.txt_clientebuscar.Location = New System.Drawing.Point(16, 34)
        Me.txt_clientebuscar.Name = "txt_clientebuscar"
        Me.txt_clientebuscar.Size = New System.Drawing.Size(166, 21)
        Me.txt_clientebuscar.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(911, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Forma Entrega"
        '
        'cmb_FormaEntrega
        '
        Me.cmb_FormaEntrega.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_FormaEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_FormaEntrega.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_FormaEntrega.ForeColor = System.Drawing.Color.Navy
        Me.cmb_FormaEntrega.FormattingEnabled = True
        Me.cmb_FormaEntrega.Location = New System.Drawing.Point(914, 32)
        Me.cmb_FormaEntrega.Name = "cmb_FormaEntrega"
        Me.cmb_FormaEntrega.Size = New System.Drawing.Size(345, 23)
        Me.cmb_FormaEntrega.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(834, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Lugar Entrega"
        '
        'txt_LUGAR_ENTREGA
        '
        Me.txt_LUGAR_ENTREGA.BackColor = System.Drawing.SystemColors.Window
        Me.txt_LUGAR_ENTREGA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LUGAR_ENTREGA.ForeColor = System.Drawing.Color.Navy
        Me.txt_LUGAR_ENTREGA.Location = New System.Drawing.Point(914, 68)
        Me.txt_LUGAR_ENTREGA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_LUGAR_ENTREGA.Name = "txt_LUGAR_ENTREGA"
        Me.txt_LUGAR_ENTREGA.Size = New System.Drawing.Size(345, 22)
        Me.txt_LUGAR_ENTREGA.TabIndex = 13
        '
        'txt_Ndias_Fabricacion
        '
        Me.txt_Ndias_Fabricacion.BackColor = System.Drawing.Color.Navy
        Me.txt_Ndias_Fabricacion.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Ndias_Fabricacion.ForeColor = System.Drawing.Color.White
        Me.txt_Ndias_Fabricacion.HidePromptOnLeave = True
        Me.txt_Ndias_Fabricacion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_Ndias_Fabricacion.Location = New System.Drawing.Point(21, 184)
        Me.txt_Ndias_Fabricacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Ndias_Fabricacion.Mask = "###"
        Me.txt_Ndias_Fabricacion.Name = "txt_Ndias_Fabricacion"
        Me.txt_Ndias_Fabricacion.ReadOnly = True
        Me.txt_Ndias_Fabricacion.Size = New System.Drawing.Size(41, 23)
        Me.txt_Ndias_Fabricacion.TabIndex = 9
        Me.txt_Ndias_Fabricacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_Ndias_Fabricacion.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(24, 165)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 13)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "N° Días"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(218, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Fecha Siembra"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Fecha Entrega"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(345, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Fecha Pedido"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDias_INV)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.txtDias_OTO)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.txtDias_VER)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.MT_PedidosPendientes)
        Me.GroupBox2.Controls.Add(Me.txtDias_PRI)
        Me.GroupBox2.Controls.Add(Me.Label45)
        Me.GroupBox2.Controls.Add(Me.MT_StockActual)
        Me.GroupBox2.Controls.Add(Me.Label44)
        Me.GroupBox2.Controls.Add(Me.chkSemillaCertificada)
        Me.GroupBox2.Controls.Add(Me.chkSemillaCorriente)
        Me.GroupBox2.Controls.Add(Me.txtUltActualizacion)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtProveedor)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txt_diasprecocidad)
        Me.GroupBox2.Controls.Add(Me.Label41)
        Me.GroupBox2.Controls.Add(Me.txt_Temporada)
        Me.GroupBox2.Controls.Add(Me.Label40)
        Me.GroupBox2.Controls.Add(Me.txt_TipoDescarga)
        Me.GroupBox2.Controls.Add(Me.Label39)
        Me.GroupBox2.Controls.Add(Me.dtp_FechaEntrega)
        Me.GroupBox2.Controls.Add(Me.dtp_Fecha_Inicio)
        Me.GroupBox2.Controls.Add(Me.txt_StockDispo)
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Controls.Add(Me.txt_DetalleVariedad)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txt_Batch)
        Me.GroupBox2.Controls.Add(Me.txt_LoteSemilla)
        Me.GroupBox2.Controls.Add(Me.txt_FechaEnvasado)
        Me.GroupBox2.Controls.Add(Me.cmb_aportasemilla)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmb_variedad)
        Me.GroupBox2.Controls.Add(Me.cmb_Familia)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.cmb_TipoBandeja)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txt_Ndias_Fabricacion)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txt_Cantidad)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.DataGrilla)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 184)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1274, 393)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos para cada Lote"
        '
        'txtDias_INV
        '
        Me.txtDias_INV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDias_INV.Location = New System.Drawing.Point(300, 212)
        Me.txtDias_INV.Name = "txtDias_INV"
        Me.txtDias_INV.ReadOnly = True
        Me.txtDias_INV.Size = New System.Drawing.Size(46, 21)
        Me.txtDias_INV.TabIndex = 119
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(269, 216)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(25, 13)
        Me.Label23.TabIndex = 124
        Me.Label23.Text = "Inv."
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(185, 216)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(27, 13)
        Me.Label32.TabIndex = 123
        Me.Label32.Text = "Oto."
        '
        'txtDias_OTO
        '
        Me.txtDias_OTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDias_OTO.Location = New System.Drawing.Point(212, 212)
        Me.txtDias_OTO.Name = "txtDias_OTO"
        Me.txtDias_OTO.ReadOnly = True
        Me.txtDias_OTO.Size = New System.Drawing.Size(46, 21)
        Me.txtDias_OTO.TabIndex = 120
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(99, 216)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(26, 13)
        Me.Label31.TabIndex = 122
        Me.Label31.Text = "Ver."
        '
        'txtDias_VER
        '
        Me.txtDias_VER.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDias_VER.Location = New System.Drawing.Point(125, 212)
        Me.txtDias_VER.Name = "txtDias_VER"
        Me.txtDias_VER.ReadOnly = True
        Me.txtDias_VER.Size = New System.Drawing.Size(46, 21)
        Me.txtDias_VER.TabIndex = 122
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(18, 216)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(22, 13)
        Me.Label30.TabIndex = 68
        Me.Label30.Text = "Pri."
        '
        'MT_PedidosPendientes
        '
        Me.MT_PedidosPendientes.BackColor = System.Drawing.Color.Navy
        Me.MT_PedidosPendientes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MT_PedidosPendientes.ForeColor = System.Drawing.SystemColors.Window
        Me.MT_PedidosPendientes.HidePromptOnLeave = True
        Me.MT_PedidosPendientes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MT_PedidosPendientes.Location = New System.Drawing.Point(980, 125)
        Me.MT_PedidosPendientes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MT_PedidosPendientes.Name = "MT_PedidosPendientes"
        Me.MT_PedidosPendientes.ReadOnly = True
        Me.MT_PedidosPendientes.Size = New System.Drawing.Size(90, 22)
        Me.MT_PedidosPendientes.TabIndex = 66
        Me.MT_PedidosPendientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MT_PedidosPendientes.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txtDias_PRI
        '
        Me.txtDias_PRI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDias_PRI.Location = New System.Drawing.Point(41, 212)
        Me.txtDias_PRI.Name = "txtDias_PRI"
        Me.txtDias_PRI.ReadOnly = True
        Me.txtDias_PRI.Size = New System.Drawing.Size(46, 21)
        Me.txtDias_PRI.TabIndex = 121
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(973, 110)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(101, 13)
        Me.Label45.TabIndex = 67
        Me.Label45.Text = "Pedidos Pendientes"
        '
        'MT_StockActual
        '
        Me.MT_StockActual.BackColor = System.Drawing.Color.Navy
        Me.MT_StockActual.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MT_StockActual.ForeColor = System.Drawing.SystemColors.Window
        Me.MT_StockActual.HidePromptOnLeave = True
        Me.MT_StockActual.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MT_StockActual.Location = New System.Drawing.Point(858, 125)
        Me.MT_StockActual.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MT_StockActual.Name = "MT_StockActual"
        Me.MT_StockActual.ReadOnly = True
        Me.MT_StockActual.Size = New System.Drawing.Size(90, 22)
        Me.MT_StockActual.TabIndex = 64
        Me.MT_StockActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MT_StockActual.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(866, 110)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(68, 13)
        Me.Label44.TabIndex = 65
        Me.Label44.Text = "Stock Actual"
        '
        'chkSemillaCertificada
        '
        Me.chkSemillaCertificada.AutoSize = True
        Me.chkSemillaCertificada.Location = New System.Drawing.Point(1043, 36)
        Me.chkSemillaCertificada.Name = "chkSemillaCertificada"
        Me.chkSemillaCertificada.Size = New System.Drawing.Size(125, 17)
        Me.chkSemillaCertificada.TabIndex = 61
        Me.chkSemillaCertificada.Text = "Es semilla Certificada"
        Me.chkSemillaCertificada.UseVisualStyleBackColor = True
        Me.chkSemillaCertificada.Visible = False
        '
        'chkSemillaCorriente
        '
        Me.chkSemillaCorriente.AutoSize = True
        Me.chkSemillaCorriente.Location = New System.Drawing.Point(1043, 12)
        Me.chkSemillaCorriente.Name = "chkSemillaCorriente"
        Me.chkSemillaCorriente.Size = New System.Drawing.Size(117, 17)
        Me.chkSemillaCorriente.TabIndex = 60
        Me.chkSemillaCorriente.Text = "Es semilla Corriente"
        Me.chkSemillaCorriente.UseVisualStyleBackColor = True
        Me.chkSemillaCorriente.Visible = False
        '
        'txtUltActualizacion
        '
        Me.txtUltActualizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUltActualizacion.Location = New System.Drawing.Point(691, 126)
        Me.txtUltActualizacion.Name = "txtUltActualizacion"
        Me.txtUltActualizacion.ReadOnly = True
        Me.txtUltActualizacion.Size = New System.Drawing.Size(91, 21)
        Me.txtUltActualizacion.TabIndex = 56
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(687, 110)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(136, 13)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Fecha Actualización Precio"
        '
        'txtProveedor
        '
        Me.txtProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedor.Location = New System.Drawing.Point(380, 212)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(406, 21)
        Me.txtProveedor.TabIndex = 54
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(671, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 36)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "Ver Ficha"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'txt_diasprecocidad
        '
        Me.txt_diasprecocidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_diasprecocidad.Location = New System.Drawing.Point(460, 126)
        Me.txt_diasprecocidad.Name = "txt_diasprecocidad"
        Me.txt_diasprecocidad.ReadOnly = True
        Me.txt_diasprecocidad.Size = New System.Drawing.Size(46, 21)
        Me.txt_diasprecocidad.TabIndex = 50
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(437, 110)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(99, 13)
        Me.Label41.TabIndex = 49
        Me.Label41.Text = "N° días precocidad"
        '
        'txt_Temporada
        '
        Me.txt_Temporada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Temporada.Location = New System.Drawing.Point(200, 126)
        Me.txt_Temporada.Name = "txt_Temporada"
        Me.txt_Temporada.ReadOnly = True
        Me.txt_Temporada.Size = New System.Drawing.Size(91, 21)
        Me.txt_Temporada.TabIndex = 48
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(197, 110)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(61, 13)
        Me.Label40.TabIndex = 47
        Me.Label40.Text = "Temporada"
        '
        'txt_TipoDescarga
        '
        Me.txt_TipoDescarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TipoDescarga.Location = New System.Drawing.Point(21, 126)
        Me.txt_TipoDescarga.Name = "txt_TipoDescarga"
        Me.txt_TipoDescarga.ReadOnly = True
        Me.txt_TipoDescarga.Size = New System.Drawing.Size(91, 21)
        Me.txt_TipoDescarga.TabIndex = 46
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(18, 110)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(53, 13)
        Me.Label39.TabIndex = 45
        Me.Label39.Text = "Descarga"
        '
        'dtp_FechaEntrega
        '
        Me.dtp_FechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaEntrega.Location = New System.Drawing.Point(82, 186)
        Me.dtp_FechaEntrega.Name = "dtp_FechaEntrega"
        Me.dtp_FechaEntrega.Size = New System.Drawing.Size(91, 20)
        Me.dtp_FechaEntrega.TabIndex = 44
        '
        'dtp_Fecha_Inicio
        '
        Me.dtp_Fecha_Inicio.Enabled = False
        Me.dtp_Fecha_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha_Inicio.Location = New System.Drawing.Point(217, 186)
        Me.dtp_Fecha_Inicio.Name = "dtp_Fecha_Inicio"
        Me.dtp_Fecha_Inicio.Size = New System.Drawing.Size(91, 20)
        Me.dtp_Fecha_Inicio.TabIndex = 43
        '
        'txt_StockDispo
        '
        Me.txt_StockDispo.BackColor = System.Drawing.Color.Navy
        Me.txt_StockDispo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_StockDispo.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_StockDispo.HidePromptOnLeave = True
        Me.txt_StockDispo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_StockDispo.Location = New System.Drawing.Point(1097, 125)
        Me.txt_StockDispo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_StockDispo.Name = "txt_StockDispo"
        Me.txt_StockDispo.ReadOnly = True
        Me.txt_StockDispo.Size = New System.Drawing.Size(90, 22)
        Me.txt_StockDispo.TabIndex = 24
        Me.txt_StockDispo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_StockDispo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(1098, 110)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(87, 13)
        Me.Label38.TabIndex = 42
        Me.Label38.Text = "Stock Disponible"
        '
        'txt_DetalleVariedad
        '
        Me.txt_DetalleVariedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DetalleVariedad.Location = New System.Drawing.Point(8, 59)
        Me.txt_DetalleVariedad.Multiline = True
        Me.txt_DetalleVariedad.Name = "txt_DetalleVariedad"
        Me.txt_DetalleVariedad.ReadOnly = True
        Me.txt_DetalleVariedad.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_DetalleVariedad.Size = New System.Drawing.Size(1220, 44)
        Me.txt_DetalleVariedad.TabIndex = 41
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkAumDis)
        Me.GroupBox4.Controls.Add(Me.txtDescto)
        Me.GroupBox4.Controls.Add(Me.rb_PrecioVentaEspecial)
        Me.GroupBox4.Controls.Add(Me.rb_PrecioVentaLista)
        Me.GroupBox4.Controls.Add(Me.txt_PrecioVenta)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.txt_totallote)
        Me.GroupBox4.Controls.Add(Me.txt_CantBandejas)
        Me.GroupBox4.Location = New System.Drawing.Point(810, 152)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(418, 77)
        Me.GroupBox4.TabIndex = 39
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Precio de Venta"
        '
        'chkAumDis
        '
        Me.chkAumDis.AutoSize = True
        Me.chkAumDis.Checked = True
        Me.chkAumDis.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAumDis.Location = New System.Drawing.Point(110, 17)
        Me.chkAumDis.Name = "chkAumDis"
        Me.chkAumDis.Size = New System.Drawing.Size(32, 17)
        Me.chkAumDis.TabIndex = 25
        Me.chkAumDis.Text = "+"
        Me.chkAumDis.UseVisualStyleBackColor = True
        '
        'txtDescto
        '
        Me.txtDescto.BackColor = System.Drawing.Color.Navy
        Me.txtDescto.ForeColor = System.Drawing.Color.White
        Me.txtDescto.Location = New System.Drawing.Point(143, 15)
        Me.txtDescto.Name = "txtDescto"
        Me.txtDescto.Size = New System.Drawing.Size(67, 20)
        Me.txtDescto.TabIndex = 24
        Me.txtDescto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rb_PrecioVentaEspecial
        '
        Me.rb_PrecioVentaEspecial.AutoSize = True
        Me.rb_PrecioVentaEspecial.Location = New System.Drawing.Point(8, 47)
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
        Me.rb_PrecioVentaLista.Location = New System.Drawing.Point(8, 17)
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
        Me.txt_PrecioVenta.Location = New System.Drawing.Point(143, 44)
        Me.txt_PrecioVenta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_PrecioVenta.Name = "txt_PrecioVenta"
        Me.txt_PrecioVenta.Size = New System.Drawing.Size(67, 22)
        Me.txt_PrecioVenta.TabIndex = 15
        Me.txt_PrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_PrecioVenta.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(225, 19)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(55, 13)
        Me.Label26.TabIndex = 18
        Me.Label26.Text = "Total Lote"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(245, 49)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(35, 13)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "Band."
        '
        'txt_totallote
        '
        Me.txt_totallote.BackColor = System.Drawing.Color.Navy
        Me.txt_totallote.CausesValidation = False
        Me.txt_totallote.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totallote.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_totallote.Location = New System.Drawing.Point(289, 14)
        Me.txt_totallote.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_totallote.Name = "txt_totallote"
        Me.txt_totallote.ReadOnly = True
        Me.txt_totallote.Size = New System.Drawing.Size(79, 22)
        Me.txt_totallote.TabIndex = 19
        Me.txt_totallote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_CantBandejas
        '
        Me.txt_CantBandejas.BackColor = System.Drawing.Color.Navy
        Me.txt_CantBandejas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CantBandejas.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_CantBandejas.HidePromptOnLeave = True
        Me.txt_CantBandejas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_CantBandejas.Location = New System.Drawing.Point(289, 44)
        Me.txt_CantBandejas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_CantBandejas.Name = "txt_CantBandejas"
        Me.txt_CantBandejas.ReadOnly = True
        Me.txt_CantBandejas.Size = New System.Drawing.Size(79, 22)
        Me.txt_CantBandejas.TabIndex = 21
        Me.txt_CantBandejas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_CantBandejas.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(625, 165)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(76, 13)
        Me.Label29.TabIndex = 38
        Me.Label29.Text = "Fec.Envasado"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(520, 165)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(35, 13)
        Me.Label28.TabIndex = 37
        Me.Label28.Text = "Batch"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(377, 165)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 13)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "Lote Semilla"
        '
        'txt_Batch
        '
        Me.txt_Batch.BackColor = System.Drawing.SystemColors.Window
        Me.txt_Batch.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Batch.ForeColor = System.Drawing.Color.Navy
        Me.txt_Batch.Location = New System.Drawing.Point(513, 182)
        Me.txt_Batch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Batch.Name = "txt_Batch"
        Me.txt_Batch.Size = New System.Drawing.Size(99, 22)
        Me.txt_Batch.TabIndex = 22
        '
        'txt_LoteSemilla
        '
        Me.txt_LoteSemilla.BackColor = System.Drawing.SystemColors.Window
        Me.txt_LoteSemilla.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LoteSemilla.ForeColor = System.Drawing.Color.Navy
        Me.txt_LoteSemilla.Location = New System.Drawing.Point(380, 182)
        Me.txt_LoteSemilla.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_LoteSemilla.Name = "txt_LoteSemilla"
        Me.txt_LoteSemilla.Size = New System.Drawing.Size(108, 22)
        Me.txt_LoteSemilla.TabIndex = 21
        '
        'txt_FechaEnvasado
        '
        Me.txt_FechaEnvasado.BackColor = System.Drawing.SystemColors.Window
        Me.txt_FechaEnvasado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FechaEnvasado.ForeColor = System.Drawing.Color.Navy
        Me.txt_FechaEnvasado.Location = New System.Drawing.Point(632, 182)
        Me.txt_FechaEnvasado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_FechaEnvasado.Mask = "00/0000"
        Me.txt_FechaEnvasado.Name = "txt_FechaEnvasado"
        Me.txt_FechaEnvasado.Size = New System.Drawing.Size(62, 22)
        Me.txt_FechaEnvasado.TabIndex = 23
        '
        'cmb_aportasemilla
        '
        Me.cmb_aportasemilla.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_aportasemilla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_aportasemilla.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_aportasemilla.ForeColor = System.Drawing.Color.Navy
        Me.cmb_aportasemilla.FormattingEnabled = True
        Me.cmb_aportasemilla.Items.AddRange(New Object() {"SI", "NO"})
        Me.cmb_aportasemilla.Location = New System.Drawing.Point(970, 19)
        Me.cmb_aportasemilla.Name = "cmb_aportasemilla"
        Me.cmb_aportasemilla.Size = New System.Drawing.Size(56, 23)
        Me.cmb_aportasemilla.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(858, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Cliente aporta semilla"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(439, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Variedad"
        '
        'cmb_variedad
        '
        Me.cmb_variedad.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_variedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_variedad.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_variedad.ForeColor = System.Drawing.Color.Navy
        Me.cmb_variedad.FormattingEnabled = True
        Me.cmb_variedad.Location = New System.Drawing.Point(435, 30)
        Me.cmb_variedad.Name = "cmb_variedad"
        Me.cmb_variedad.Size = New System.Drawing.Size(228, 23)
        Me.cmb_variedad.TabIndex = 5
        '
        'cmb_Familia
        '
        Me.cmb_Familia.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_Familia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Familia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Familia.ForeColor = System.Drawing.Color.Navy
        Me.cmb_Familia.FormattingEnabled = True
        Me.cmb_Familia.Location = New System.Drawing.Point(188, 30)
        Me.cmb_Familia.Name = "cmb_Familia"
        Me.cmb_Familia.Size = New System.Drawing.Size(241, 23)
        Me.cmb_Familia.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(10, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(85, 13)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Tipo de Bandeja"
        '
        'cmb_TipoBandeja
        '
        Me.cmb_TipoBandeja.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_TipoBandeja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoBandeja.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_TipoBandeja.ForeColor = System.Drawing.Color.Navy
        Me.cmb_TipoBandeja.FormattingEnabled = True
        Me.cmb_TipoBandeja.Location = New System.Drawing.Point(7, 30)
        Me.cmb_TipoBandeja.Name = "cmb_TipoBandeja"
        Me.cmb_TipoBandeja.Size = New System.Drawing.Size(170, 23)
        Me.cmb_TipoBandeja.TabIndex = 1
        '
        'txt_Cantidad
        '
        Me.txt_Cantidad.BackColor = System.Drawing.SystemColors.Window
        Me.txt_Cantidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cantidad.ForeColor = System.Drawing.Color.Navy
        Me.txt_Cantidad.HidePromptOnLeave = True
        Me.txt_Cantidad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_Cantidad.Location = New System.Drawing.Point(719, 182)
        Me.txt_Cantidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Cantidad.Mask = "########0"
        Me.txt_Cantidad.Name = "txt_Cantidad"
        Me.txt_Cantidad.Size = New System.Drawing.Size(67, 22)
        Me.txt_Cantidad.TabIndex = 17
        Me.txt_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_Cantidad.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(719, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Cant.Plantas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(192, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Especie"
        '
        'DataGrilla
        '
        Me.DataGrilla.AllowUserToAddRows = False
        Me.DataGrilla.AllowUserToDeleteRows = False
        Me.DataGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGrilla.BackgroundColor = System.Drawing.Color.White
        Me.DataGrilla.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.lote, Me.fecini, Me.fecentrega, Me.bandejas, Me.Semilla, Me.Variedad, Me.Cantidad, Me.prec, Me.Total, Me.Tipoband, Me.Estado, Me.Lotesemilla, Me.batch, Me.Fecenvasado, Me.aportesemilla, Me.Column1, Me.Column2, Me.LoteOriginal, Me.Lotes_Hijos, Me.Estado_Lote})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrilla.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrilla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGrilla.Location = New System.Drawing.Point(8, 241)
        Me.DataGrilla.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGrilla.Name = "DataGrilla"
        Me.DataGrilla.ReadOnly = True
        Me.DataGrilla.RowHeadersVisible = False
        Me.DataGrilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataGrilla.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGrilla.Size = New System.Drawing.Size(1261, 145)
        Me.DataGrilla.TabIndex = 26
        '
        'lote
        '
        Me.lote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.lote.FillWeight = 40.0!
        Me.lote.HeaderText = "N°"
        Me.lote.Name = "lote"
        Me.lote.ReadOnly = True
        Me.lote.Width = 44
        '
        'fecini
        '
        Me.fecini.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.fecini.FillWeight = 50.0!
        Me.fecini.HeaderText = "Fec.Ini."
        Me.fecini.Name = "fecini"
        Me.fecini.ReadOnly = True
        Me.fecini.Width = 67
        '
        'fecentrega
        '
        Me.fecentrega.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.fecentrega.FillWeight = 50.0!
        Me.fecentrega.HeaderText = "Fec.Ent."
        Me.fecentrega.Name = "fecentrega"
        Me.fecentrega.ReadOnly = True
        Me.fecentrega.Width = 72
        '
        'bandejas
        '
        Me.bandejas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.bandejas.FillWeight = 20.0!
        Me.bandejas.HeaderText = "Band."
        Me.bandejas.Name = "bandejas"
        Me.bandejas.ReadOnly = True
        Me.bandejas.Width = 60
        '
        'Semilla
        '
        Me.Semilla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Semilla.FillWeight = 80.0!
        Me.Semilla.HeaderText = "Semilla"
        Me.Semilla.Name = "Semilla"
        Me.Semilla.ReadOnly = True
        Me.Semilla.Width = 65
        '
        'Variedad
        '
        Me.Variedad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Variedad.FillWeight = 80.0!
        Me.Variedad.HeaderText = "Variedad"
        Me.Variedad.Name = "Variedad"
        Me.Variedad.ReadOnly = True
        Me.Variedad.Width = 74
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Cantidad.FillWeight = 60.0!
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 74
        '
        'prec
        '
        Me.prec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.prec.FillWeight = 60.0!
        Me.prec.HeaderText = "Precio"
        Me.prec.Name = "prec"
        Me.prec.ReadOnly = True
        Me.prec.Width = 62
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Total.FillWeight = 60.0!
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 56
        '
        'Tipoband
        '
        Me.Tipoband.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Tipoband.FillWeight = 40.0!
        Me.Tipoband.HeaderText = "T. Band."
        Me.Tipoband.Name = "Tipoband"
        Me.Tipoband.ReadOnly = True
        Me.Tipoband.Width = 73
        '
        'Estado
        '
        Me.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Estado.FillWeight = 30.0!
        Me.Estado.HeaderText = "Est."
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Visible = False
        '
        'Lotesemilla
        '
        Me.Lotesemilla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Lotesemilla.FillWeight = 50.0!
        Me.Lotesemilla.HeaderText = "Lote Semilla"
        Me.Lotesemilla.Name = "Lotesemilla"
        Me.Lotesemilla.ReadOnly = True
        Me.Lotesemilla.Width = 89
        '
        'batch
        '
        Me.batch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.batch.HeaderText = "Batch"
        Me.batch.Name = "batch"
        Me.batch.ReadOnly = True
        Me.batch.Width = 60
        '
        'Fecenvasado
        '
        Me.Fecenvasado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Fecenvasado.HeaderText = "Fec.Env."
        Me.Fecenvasado.Name = "Fecenvasado"
        Me.Fecenvasado.ReadOnly = True
        Me.Fecenvasado.Width = 75
        '
        'aportesemilla
        '
        Me.aportesemilla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.aportesemilla.FillWeight = 30.0!
        Me.aportesemilla.HeaderText = "Sem."
        Me.aportesemilla.Name = "aportesemilla"
        Me.aportesemilla.ReadOnly = True
        Me.aportesemilla.Width = 56
        '
        'Column1
        '
        Me.Column1.HeaderText = "Corriente"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 74
        '
        'Column2
        '
        Me.Column2.HeaderText = "Certificada"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 82
        '
        'LoteOriginal
        '
        Me.LoteOriginal.HeaderText = "LoteOriginal"
        Me.LoteOriginal.Name = "LoteOriginal"
        Me.LoteOriginal.ReadOnly = True
        Me.LoteOriginal.Visible = False
        Me.LoteOriginal.Width = 88
        '
        'Lotes_Hijos
        '
        Me.Lotes_Hijos.HeaderText = "Lotes_Hijos"
        Me.Lotes_Hijos.Name = "Lotes_Hijos"
        Me.Lotes_Hijos.ReadOnly = True
        Me.Lotes_Hijos.Visible = False
        Me.Lotes_Hijos.Width = 87
        '
        'Estado_Lote
        '
        Me.Estado_Lote.HeaderText = "Estado"
        Me.Estado_Lote.Name = "Estado_Lote"
        Me.Estado_Lote.ReadOnly = True
        Me.Estado_Lote.Width = 65
        '
        'txtNotas
        '
        Me.txtNotas.Location = New System.Drawing.Point(114, 651)
        Me.txtNotas.Multiline = True
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.ReadOnly = True
        Me.txtNotas.Size = New System.Drawing.Size(631, 39)
        Me.txtNotas.TabIndex = 63
        '
        'Label42
        '
        Me.Label42.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label42.AutoSize = True
        Me.Label42.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label42.Location = New System.Drawing.Point(12, 659)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(70, 13)
        Me.Label42.TabIndex = 62
        Me.Label42.Text = "Notas Cliente"
        '
        'txt_Comentarios
        '
        Me.txt_Comentarios.Location = New System.Drawing.Point(114, 609)
        Me.txt_Comentarios.Multiline = True
        Me.txt_Comentarios.Name = "txt_Comentarios"
        Me.txt_Comentarios.Size = New System.Drawing.Size(631, 39)
        Me.txt_Comentarios.TabIndex = 52
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtAbonoSugerido)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.txt_totalneto)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.txt_TotalIVA)
        Me.GroupBox5.Controls.Add(Me.txt_TotalPedido)
        Me.GroupBox5.Location = New System.Drawing.Point(1076, 583)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 121)
        Me.GroupBox5.TabIndex = 40
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Total Pedido"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Total Neto"
        '
        'txt_totalneto
        '
        Me.txt_totalneto.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_totalneto.CausesValidation = False
        Me.txt_totalneto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalneto.ForeColor = System.Drawing.Color.Yellow
        Me.txt_totalneto.Location = New System.Drawing.Point(100, 14)
        Me.txt_totalneto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_totalneto.Name = "txt_totalneto"
        Me.txt_totalneto.ReadOnly = True
        Me.txt_totalneto.Size = New System.Drawing.Size(86, 22)
        Me.txt_totalneto.TabIndex = 28
        Me.txt_totalneto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "I.V.A."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 67)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Total Pedido"
        '
        'txt_TotalIVA
        '
        Me.txt_TotalIVA.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_TotalIVA.CausesValidation = False
        Me.txt_TotalIVA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalIVA.ForeColor = System.Drawing.Color.Yellow
        Me.txt_TotalIVA.Location = New System.Drawing.Point(100, 38)
        Me.txt_TotalIVA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_TotalIVA.Name = "txt_TotalIVA"
        Me.txt_TotalIVA.ReadOnly = True
        Me.txt_TotalIVA.Size = New System.Drawing.Size(86, 22)
        Me.txt_TotalIVA.TabIndex = 30
        Me.txt_TotalIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_TotalPedido
        '
        Me.txt_TotalPedido.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_TotalPedido.CausesValidation = False
        Me.txt_TotalPedido.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalPedido.ForeColor = System.Drawing.Color.Yellow
        Me.txt_TotalPedido.Location = New System.Drawing.Point(100, 62)
        Me.txt_TotalPedido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_TotalPedido.Name = "txt_TotalPedido"
        Me.txt_TotalPedido.ReadOnly = True
        Me.txt_TotalPedido.Size = New System.Drawing.Size(86, 22)
        Me.txt_TotalPedido.TabIndex = 32
        Me.txt_TotalPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label24.Location = New System.Drawing.Point(12, 614)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(101, 13)
        Me.Label24.TabIndex = 22
        Me.Label24.Text = "Comentarios Pedido"
        '
        'txtIdUsuario
        '
        Me.txtIdUsuario.BackColor = System.Drawing.Color.Navy
        Me.txtIdUsuario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdUsuario.ForeColor = System.Drawing.SystemColors.Window
        Me.txtIdUsuario.HidePromptOnLeave = True
        Me.txtIdUsuario.Location = New System.Drawing.Point(906, 11)
        Me.txtIdUsuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIdUsuario.Name = "txtIdUsuario"
        Me.txtIdUsuario.ReadOnly = True
        Me.txtIdUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtIdUsuario.Size = New System.Drawing.Size(121, 22)
        Me.txtIdUsuario.TabIndex = 23
        Me.txtIdUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(828, 16)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(75, 13)
        Me.Label43.TabIndex = 58
        Me.Label43.Text = "Ingresado por:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(29, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Pedido N°"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'dtp_Fecha_Pedido
        '
        Me.dtp_Fecha_Pedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha_Pedido.Location = New System.Drawing.Point(424, 12)
        Me.dtp_Fecha_Pedido.Name = "dtp_Fecha_Pedido"
        Me.dtp_Fecha_Pedido.Size = New System.Drawing.Size(84, 20)
        Me.dtp_Fecha_Pedido.TabIndex = 45
        '
        'lblDeuda
        '
        Me.lblDeuda.AutoSize = True
        Me.lblDeuda.Location = New System.Drawing.Point(578, 16)
        Me.lblDeuda.Name = "lblDeuda"
        Me.lblDeuda.Size = New System.Drawing.Size(75, 13)
        Me.lblDeuda.TabIndex = 102
        Me.lblDeuda.Text = "Total Deuda $"
        Me.lblDeuda.Visible = False
        '
        'txtTotalDeuda
        '
        Me.txtTotalDeuda.BackColor = System.Drawing.Color.GhostWhite
        Me.txtTotalDeuda.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDeuda.ForeColor = System.Drawing.Color.Red
        Me.txtTotalDeuda.Location = New System.Drawing.Point(659, 11)
        Me.txtTotalDeuda.Name = "txtTotalDeuda"
        Me.txtTotalDeuda.ReadOnly = True
        Me.txtTotalDeuda.Size = New System.Drawing.Size(95, 22)
        Me.txtTotalDeuda.TabIndex = 48
        Me.txtTotalDeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalDeuda.Visible = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.White
        Me.btnReset.Image = Global.GestionVivero.My.Resources.Resources.Close
        Me.btnReset.Location = New System.Drawing.Point(1282, 561)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(48, 48)
        Me.btnReset.TabIndex = 118
        Me.ToolTip1.SetToolTip(Me.btnReset, "Búsqueda Pedidos")
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnExcepcion
        '
        Me.btnExcepcion.BackColor = System.Drawing.Color.White
        Me.btnExcepcion.Enabled = False
        Me.btnExcepcion.Image = Global.GestionVivero.My.Resources.Resources.Autorizacion1
        Me.btnExcepcion.Location = New System.Drawing.Point(1282, 393)
        Me.btnExcepcion.Name = "btnExcepcion"
        Me.btnExcepcion.Size = New System.Drawing.Size(48, 48)
        Me.btnExcepcion.TabIndex = 111
        Me.ToolTip1.SetToolTip(Me.btnExcepcion, "Solicitar excepción Abono Inicial")
        Me.btnExcepcion.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.White
        Me.Button13.Image = Global.GestionVivero.My.Resources.Resources.salir_40x40
        Me.Button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button13.Location = New System.Drawing.Point(1282, 617)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(48, 48)
        Me.Button13.TabIndex = 109
        Me.Button13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Button13, "Salir")
        Me.Button13.UseVisualStyleBackColor = False
        '
        'btnPrintInternal
        '
        Me.btnPrintInternal.BackColor = System.Drawing.Color.White
        Me.btnPrintInternal.Enabled = False
        Me.btnPrintInternal.Image = Global.GestionVivero.My.Resources.Resources.imprimir_40x40
        Me.btnPrintInternal.Location = New System.Drawing.Point(1282, 337)
        Me.btnPrintInternal.Name = "btnPrintInternal"
        Me.btnPrintInternal.Size = New System.Drawing.Size(48, 48)
        Me.btnPrintInternal.TabIndex = 108
        Me.ToolTip1.SetToolTip(Me.btnPrintInternal, "Imprime Nota Pedido Interna")
        Me.btnPrintInternal.UseVisualStyleBackColor = False
        '
        'btnPrintCustomer
        '
        Me.btnPrintCustomer.BackColor = System.Drawing.Color.White
        Me.btnPrintCustomer.Enabled = False
        Me.btnPrintCustomer.Image = Global.GestionVivero.My.Resources.Resources.imprimir_40x40
        Me.btnPrintCustomer.Location = New System.Drawing.Point(1282, 281)
        Me.btnPrintCustomer.Name = "btnPrintCustomer"
        Me.btnPrintCustomer.Size = New System.Drawing.Size(48, 48)
        Me.btnPrintCustomer.TabIndex = 107
        Me.ToolTip1.SetToolTip(Me.btnPrintCustomer, "Imprime Nota Pedido Cliente")
        Me.btnPrintCustomer.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.Image = Global.GestionVivero.My.Resources.Resources.buscar_40x40
        Me.btnSearch.Location = New System.Drawing.Point(1282, 113)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(48, 48)
        Me.btnSearch.TabIndex = 105
        Me.ToolTip1.SetToolTip(Me.btnSearch, "Búsqueda Pedidos")
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.White
        Me.btnsave.Enabled = False
        Me.btnsave.Image = Global.GestionVivero.My.Resources.Resources.guardar_40x40
        Me.btnsave.Location = New System.Drawing.Point(1282, 57)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(48, 48)
        Me.btnsave.TabIndex = 104
        Me.ToolTip1.SetToolTip(Me.btnsave, "Guardar Pedido")
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Image = Global.GestionVivero.My.Resources.Resources.New_document
        Me.Button7.Location = New System.Drawing.Point(1282, 1)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(48, 48)
        Me.Button7.TabIndex = 103
        Me.ToolTip1.SetToolTip(Me.Button7, "Nuevo Pedido")
        Me.Button7.UseVisualStyleBackColor = False
        '
        'btnAbono
        '
        Me.btnAbono.BackColor = System.Drawing.Color.White
        Me.btnAbono.Enabled = False
        Me.btnAbono.Image = Global.GestionVivero.My.Resources.Resources.donaciones_40x40
        Me.btnAbono.Location = New System.Drawing.Point(1282, 225)
        Me.btnAbono.Name = "btnAbono"
        Me.btnAbono.Size = New System.Drawing.Size(48, 48)
        Me.btnAbono.TabIndex = 68
        Me.ToolTip1.SetToolTip(Me.btnAbono, "Registrar Abono Inicial")
        Me.btnAbono.UseVisualStyleBackColor = False
        '
        'btn_CrearLoteHijo
        '
        Me.btn_CrearLoteHijo.BackColor = System.Drawing.Color.White
        Me.btn_CrearLoteHijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CrearLoteHijo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btn_CrearLoteHijo.Image = Global.GestionVivero.My.Resources.Resources.nuevo_40x40
        Me.btn_CrearLoteHijo.Location = New System.Drawing.Point(1282, 169)
        Me.btn_CrearLoteHijo.Name = "btn_CrearLoteHijo"
        Me.btn_CrearLoteHijo.Size = New System.Drawing.Size(48, 48)
        Me.btn_CrearLoteHijo.TabIndex = 41
        Me.ToolTip1.SetToolTip(Me.btn_CrearLoteHijo, "Crear Nuevo Lote hijo a partir del Lote seleccionado")
        Me.btn_CrearLoteHijo.UseVisualStyleBackColor = False
        '
        'btnAgregaLote
        '
        Me.btnAgregaLote.BackColor = System.Drawing.Color.White
        Me.btnAgregaLote.Enabled = False
        Me.btnAgregaLote.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.btnAgregaLote.Location = New System.Drawing.Point(1282, 449)
        Me.btnAgregaLote.Name = "btnAgregaLote"
        Me.btnAgregaLote.Size = New System.Drawing.Size(48, 48)
        Me.btnAgregaLote.TabIndex = 24
        Me.btnAgregaLote.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnAgregaLote, "Agregar Lote")
        Me.btnAgregaLote.UseVisualStyleBackColor = False
        '
        'btnEliminaLote
        '
        Me.btnEliminaLote.BackColor = System.Drawing.Color.White
        Me.btnEliminaLote.Enabled = False
        Me.btnEliminaLote.Image = Global.GestionVivero.My.Resources.Resources.eliminar_40x40
        Me.btnEliminaLote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminaLote.Location = New System.Drawing.Point(1282, 505)
        Me.btnEliminaLote.Name = "btnEliminaLote"
        Me.btnEliminaLote.Size = New System.Drawing.Size(48, 48)
        Me.btnEliminaLote.TabIndex = 25
        Me.btnEliminaLote.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnEliminaLote, "Eliminar Lote Seleccionado")
        Me.btnEliminaLote.UseVisualStyleBackColor = False
        '
        'txtEstadoPedido
        '
        Me.txtEstadoPedido.BackColor = System.Drawing.Color.White
        Me.txtEstadoPedido.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstadoPedido.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtEstadoPedido.Location = New System.Drawing.Point(114, 693)
        Me.txtEstadoPedido.Name = "txtEstadoPedido"
        Me.txtEstadoPedido.ReadOnly = True
        Me.txtEstadoPedido.Size = New System.Drawing.Size(631, 23)
        Me.txtEstadoPedido.TabIndex = 110
        Me.txtEstadoPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkExcepcion
        '
        Me.chkExcepcion.AutoSize = True
        Me.chkExcepcion.Enabled = False
        Me.chkExcepcion.Location = New System.Drawing.Point(761, 614)
        Me.chkExcepcion.Name = "chkExcepcion"
        Me.chkExcepcion.Size = New System.Drawing.Size(111, 17)
        Me.chkExcepcion.TabIndex = 113
        Me.chkExcepcion.Text = "Motivo Excepción"
        Me.chkExcepcion.UseVisualStyleBackColor = True
        '
        'txtMotivoExcepcion
        '
        Me.txtMotivoExcepcion.Location = New System.Drawing.Point(761, 631)
        Me.txtMotivoExcepcion.Multiline = True
        Me.txtMotivoExcepcion.Name = "txtMotivoExcepcion"
        Me.txtMotivoExcepcion.ReadOnly = True
        Me.txtMotivoExcepcion.Size = New System.Drawing.Size(309, 65)
        Me.txtMotivoExcepcion.TabIndex = 114
        '
        'txtIdPedido
        '
        Me.txtIdPedido.Location = New System.Drawing.Point(90, 12)
        Me.txtIdPedido.Name = "txtIdPedido"
        Me.txtIdPedido.ReadOnly = True
        Me.txtIdPedido.Size = New System.Drawing.Size(100, 20)
        Me.txtIdPedido.TabIndex = 115
        '
        'txtAbonoInicial
        '
        Me.txtAbonoInicial.BackColor = System.Drawing.Color.GhostWhite
        Me.txtAbonoInicial.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbonoInicial.ForeColor = System.Drawing.Color.Red
        Me.txtAbonoInicial.Location = New System.Drawing.Point(92, 152)
        Me.txtAbonoInicial.Name = "txtAbonoInicial"
        Me.txtAbonoInicial.ReadOnly = True
        Me.txtAbonoInicial.Size = New System.Drawing.Size(95, 22)
        Me.txtAbonoInicial.TabIndex = 116
        Me.txtAbonoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(11, 157)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(76, 13)
        Me.Label20.TabIndex = 117
        Me.Label20.Text = "Abono inicial $"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Valor a Abonar"
        '
        'txtAbonoSugerido
        '
        Me.txtAbonoSugerido.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtAbonoSugerido.CausesValidation = False
        Me.txtAbonoSugerido.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbonoSugerido.ForeColor = System.Drawing.Color.Yellow
        Me.txtAbonoSugerido.Location = New System.Drawing.Point(100, 89)
        Me.txtAbonoSugerido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAbonoSugerido.Name = "txtAbonoSugerido"
        Me.txtAbonoSugerido.ReadOnly = True
        Me.txtAbonoSugerido.Size = New System.Drawing.Size(86, 22)
        Me.txtAbonoSugerido.TabIndex = 34
        Me.txtAbonoSugerido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1334, 716)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtAbonoInicial)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtIdPedido)
        Me.Controls.Add(Me.txtMotivoExcepcion)
        Me.Controls.Add(Me.chkExcepcion)
        Me.Controls.Add(Me.btnExcepcion)
        Me.Controls.Add(Me.txtEstadoPedido)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.btnPrintInternal)
        Me.Controls.Add(Me.btnPrintCustomer)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.txtNotas)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.txt_Comentarios)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.btnAbono)
        Me.Controls.Add(Me.txtTotalDeuda)
        Me.Controls.Add(Me.lblDeuda)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.txtIdUsuario)
        Me.Controls.Add(Me.dtp_Fecha_Pedido)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_CrearLoteHijo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnAgregaLote)
        Me.Controls.Add(Me.btnEliminaLote)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label24)
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Name = "Pedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Pedido y Lote"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_clientebuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txt_RUT_CLI As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_FormaEntrega As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_LUGAR_ENTREGA As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents txt_Cantidad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnAgregaLote As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnEliminaLote As System.Windows.Forms.Button
    Friend WithEvents DataGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents txt_Ndias_Fabricacion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents txt_CantBandejas As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoBandeja As System.Windows.Forms.ComboBox
    Public WithEvents txt_PrecioVenta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_totalneto As System.Windows.Forms.TextBox
    Friend WithEvents txt_TotalPedido As System.Windows.Forms.TextBox
    Friend WithEvents txt_TotalIVA As System.Windows.Forms.TextBox
    Friend WithEvents txt_IDCliente As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txt_NombreCliente As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txt_totallote As System.Windows.Forms.TextBox
    Friend WithEvents printdocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents cmb_Familia As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_variedad As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_aportasemilla As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_Batch As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_LoteSemilla As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_FechaEnvasado As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_PrecioVentaEspecial As System.Windows.Forms.RadioButton
    Friend WithEvents rb_PrecioVentaLista As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_CrearLoteHijo As System.Windows.Forms.Button
    Friend WithEvents btnBuscaCliente As System.Windows.Forms.Button
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents txt_DetalleVariedad As System.Windows.Forms.TextBox
    Public WithEvents txt_StockDispo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents dtp_Fecha_Inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FechaEntrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Fecha_Pedido As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txt_TipoDescarga As System.Windows.Forms.TextBox
    Friend WithEvents txt_Temporada As System.Windows.Forms.TextBox
    Friend WithEvents txt_diasprecocidad As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_Comentarios As System.Windows.Forms.TextBox
    Friend WithEvents txtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents txtUltActualizacion As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtIdUsuario As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents txtDescto As System.Windows.Forms.TextBox
    Friend WithEvents chkAumDis As System.Windows.Forms.CheckBox
    Friend WithEvents chkSemillaCorriente As CheckBox
    Friend WithEvents lblDeuda As Label
    Friend WithEvents txtTotalDeuda As TextBox
    Friend WithEvents chkSemillaCertificada As CheckBox
    Friend WithEvents txtNotas As TextBox
    Friend WithEvents Label42 As Label
    Public WithEvents MT_PedidosPendientes As MaskedTextBox
    Friend WithEvents Label45 As Label
    Public WithEvents MT_StockActual As MaskedTextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents chkCliente As CheckBox
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
    Friend WithEvents Lotesemilla As DataGridViewTextBoxColumn
    Friend WithEvents batch As DataGridViewTextBoxColumn
    Friend WithEvents Fecenvasado As DataGridViewTextBoxColumn
    Friend WithEvents aportesemilla As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents LoteOriginal As DataGridViewTextBoxColumn
    Friend WithEvents Lotes_Hijos As DataGridViewTextBoxColumn
    Friend WithEvents Estado_Lote As DataGridViewTextBoxColumn
    Friend WithEvents btnAbono As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button7 As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnPrintCustomer As Button
    Friend WithEvents btnPrintInternal As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents txtEstadoPedido As TextBox
    Friend WithEvents btnExcepcion As Button
    Friend WithEvents chkExcepcion As CheckBox
    Friend WithEvents txtMotivoExcepcion As TextBox
    Friend WithEvents txtIdPedido As TextBox
    Friend WithEvents txtAbonoInicial As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtDias_INV As TextBox
    Friend WithEvents txtDias_OTO As TextBox
    Friend WithEvents txtDias_PRI As TextBox
    Friend WithEvents txtDias_VER As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents txtEstadoclienteId As TextBox
    Friend WithEvents txtAbonoSugerido As TextBox
    Friend WithEvents Label5 As Label
End Class
