<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Abono_Deuda
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
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtTelefonos = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_NombreCliente = New System.Windows.Forms.MaskedTextBox()
        Me.chkCliente = New System.Windows.Forms.CheckBox()
        Me.txt_IdCliente = New System.Windows.Forms.MaskedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_clientebuscar = New System.Windows.Forms.TextBox()
        Me.txt_RUT_CLI = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtRutCli = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cmbDocumento = New System.Windows.Forms.ComboBox()
        Me.txtIdPedido = New System.Windows.Forms.TextBox()
        Me.rbAbonoDocumento = New System.Windows.Forms.RadioButton()
        Me.rbAbonoPedido = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbPedido = New System.Windows.Forms.ComboBox()
        Me.dtp_Fecha_Contable = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtp_FechaVenc = New System.Windows.Forms.DateTimePicker()
        Me.txt_NumDocPago = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_MontoDoc = New System.Windows.Forms.MaskedTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txt_Glosa = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmb_TIPO_PAGO = New System.Windows.Forms.ComboBox()
        Me.GrillaVentas = New System.Windows.Forms.DataGridView()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipodocsii = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numdocsii = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldodoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalpago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fpago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numdocpago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.control = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SaldoFacturas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GrillaPagos = New System.Windows.Forms.DataGridView()
        Me.id_pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaconta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.docpago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipodoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numdoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorPagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDAI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fec_venc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Glosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbonoPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagoNoEditado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rebajaDAI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_TotalAbonos = New System.Windows.Forms.TextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_ChequesxCobrar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_DeudaTotal = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.txtSaldoAjusteDAI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkRebajaDAI = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_LetrasxCobrar = New System.Windows.Forms.TextBox()
        Me.btnDevolucion = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.grpsaldos = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtLineaUtilizada = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtSaldoLineaCredito = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtLineaCredito = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.GrillaVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpsaldos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txtTelefonos)
        Me.GroupBox8.Controls.Add(Me.Label10)
        Me.GroupBox8.Controls.Add(Me.Label14)
        Me.GroupBox8.Controls.Add(Me.Label4)
        Me.GroupBox8.Controls.Add(Me.txt_NombreCliente)
        Me.GroupBox8.Controls.Add(Me.chkCliente)
        Me.GroupBox8.Controls.Add(Me.txt_IdCliente)
        Me.GroupBox8.Controls.Add(Me.Button1)
        Me.GroupBox8.Controls.Add(Me.txt_clientebuscar)
        Me.GroupBox8.Controls.Add(Me.txt_RUT_CLI)
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(7, 5)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox8.Size = New System.Drawing.Size(1020, 62)
        Me.GroupBox8.TabIndex = 36
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Búsqueda de Cliente"
        '
        'txtTelefonos
        '
        Me.txtTelefonos.BackColor = System.Drawing.Color.Navy
        Me.txtTelefonos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonos.ForeColor = System.Drawing.Color.Gold
        Me.txtTelefonos.HidePromptOnLeave = True
        Me.txtTelefonos.Location = New System.Drawing.Point(532, 32)
        Me.txtTelefonos.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtTelefonos.Name = "txtTelefonos"
        Me.txtTelefonos.ReadOnly = True
        Me.txtTelefonos.Size = New System.Drawing.Size(371, 22)
        Me.txtTelefonos.TabIndex = 116
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(468, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 15)
        Me.Label10.TabIndex = 115
        Me.Label10.Text = "Teléfonos:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(909, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(17, 15)
        Me.Label14.TabIndex = 114
        Me.Label14.Text = "Id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(203, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 15)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "Cliente"
        '
        'txt_NombreCliente
        '
        Me.txt_NombreCliente.BackColor = System.Drawing.Color.Navy
        Me.txt_NombreCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NombreCliente.ForeColor = System.Drawing.Color.Gold
        Me.txt_NombreCliente.Location = New System.Drawing.Point(293, 10)
        Me.txt_NombreCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_NombreCliente.Name = "txt_NombreCliente"
        Me.txt_NombreCliente.ReadOnly = True
        Me.txt_NombreCliente.Size = New System.Drawing.Size(610, 22)
        Me.txt_NombreCliente.TabIndex = 112
        '
        'chkCliente
        '
        Me.chkCliente.AutoSize = True
        Me.chkCliente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCliente.Location = New System.Drawing.Point(12, 40)
        Me.chkCliente.Name = "chkCliente"
        Me.chkCliente.Size = New System.Drawing.Size(132, 18)
        Me.chkCliente.TabIndex = 110
        Me.chkCliente.Text = "incluye primer nombre"
        Me.chkCliente.UseVisualStyleBackColor = True
        '
        'txt_IdCliente
        '
        Me.txt_IdCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_IdCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IdCliente.HidePromptOnLeave = True
        Me.txt_IdCliente.Location = New System.Drawing.Point(931, 15)
        Me.txt_IdCliente.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_IdCliente.Name = "txt_IdCliente"
        Me.txt_IdCliente.ReadOnly = True
        Me.txt_IdCliente.Size = New System.Drawing.Size(34, 22)
        Me.txt_IdCliente.TabIndex = 30
        Me.txt_IdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.buscar_40x40
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(141, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 48)
        Me.Button1.TabIndex = 29
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_clientebuscar
        '
        Me.txt_clientebuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_clientebuscar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clientebuscar.ForeColor = System.Drawing.Color.White
        Me.txt_clientebuscar.Location = New System.Drawing.Point(12, 16)
        Me.txt_clientebuscar.Name = "txt_clientebuscar"
        Me.txt_clientebuscar.Size = New System.Drawing.Size(123, 21)
        Me.txt_clientebuscar.TabIndex = 26
        '
        'txt_RUT_CLI
        '
        Me.txt_RUT_CLI.BackColor = System.Drawing.Color.Navy
        Me.txt_RUT_CLI.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RUT_CLI.ForeColor = System.Drawing.Color.Gold
        Me.txt_RUT_CLI.HidePromptOnLeave = True
        Me.txt_RUT_CLI.Location = New System.Drawing.Point(293, 32)
        Me.txt_RUT_CLI.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_RUT_CLI.Name = "txt_RUT_CLI"
        Me.txt_RUT_CLI.ReadOnly = True
        Me.txt_RUT_CLI.Size = New System.Drawing.Size(166, 22)
        Me.txt_RUT_CLI.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(203, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 15)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "R.U.T. Cliente"
        '
        'txtRutCli
        '
        Me.txtRutCli.Location = New System.Drawing.Point(949, 48)
        Me.txtRutCli.Name = "txtRutCli"
        Me.txtRutCli.Size = New System.Drawing.Size(38, 23)
        Me.txtRutCli.TabIndex = 111
        Me.txtRutCli.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cmbDocumento)
        Me.GroupBox6.Controls.Add(Me.txtIdPedido)
        Me.GroupBox6.Controls.Add(Me.rbAbonoDocumento)
        Me.GroupBox6.Controls.Add(Me.rbAbonoPedido)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.cmbPedido)
        Me.GroupBox6.Controls.Add(Me.txtRutCli)
        Me.GroupBox6.Controls.Add(Me.dtp_Fecha_Contable)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.dtp_FechaVenc)
        Me.GroupBox6.Controls.Add(Me.txt_NumDocPago)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.txt_MontoDoc)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.btnAgregar)
        Me.GroupBox6.Controls.Add(Me.txt_Glosa)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.cmb_TIPO_PAGO)
        Me.GroupBox6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(9, 165)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox6.Size = New System.Drawing.Size(1018, 205)
        Me.GroupBox6.TabIndex = 79
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Registro de Pago"
        '
        'cmbDocumento
        '
        Me.cmbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDocumento.Enabled = False
        Me.cmbDocumento.FormattingEnabled = True
        Me.cmbDocumento.Location = New System.Drawing.Point(719, 74)
        Me.cmbDocumento.Name = "cmbDocumento"
        Me.cmbDocumento.Size = New System.Drawing.Size(148, 24)
        Me.cmbDocumento.TabIndex = 35
        '
        'txtIdPedido
        '
        Me.txtIdPedido.Location = New System.Drawing.Point(949, 18)
        Me.txtIdPedido.Name = "txtIdPedido"
        Me.txtIdPedido.Size = New System.Drawing.Size(37, 23)
        Me.txtIdPedido.TabIndex = 118
        Me.txtIdPedido.Visible = False
        '
        'rbAbonoDocumento
        '
        Me.rbAbonoDocumento.AutoSize = True
        Me.rbAbonoDocumento.Location = New System.Drawing.Point(547, 76)
        Me.rbAbonoDocumento.Name = "rbAbonoDocumento"
        Me.rbAbonoDocumento.Size = New System.Drawing.Size(173, 20)
        Me.rbAbonoDocumento.TabIndex = 34
        Me.rbAbonoDocumento.TabStop = True
        Me.rbAbonoDocumento.Text = "Abono a Documento N°"
        Me.rbAbonoDocumento.UseVisualStyleBackColor = True
        '
        'rbAbonoPedido
        '
        Me.rbAbonoPedido.AutoSize = True
        Me.rbAbonoPedido.Location = New System.Drawing.Point(547, 28)
        Me.rbAbonoPedido.Name = "rbAbonoPedido"
        Me.rbAbonoPedido.Size = New System.Drawing.Size(145, 20)
        Me.rbAbonoPedido.TabIndex = 33
        Me.rbAbonoPedido.TabStop = True
        Me.rbAbonoPedido.Text = "Abono a Pedido N°"
        Me.rbAbonoPedido.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 16)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Forma de pago"
        '
        'cmbPedido
        '
        Me.cmbPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPedido.Enabled = False
        Me.cmbPedido.FormattingEnabled = True
        Me.cmbPedido.Location = New System.Drawing.Point(719, 26)
        Me.cmbPedido.Name = "cmbPedido"
        Me.cmbPedido.Size = New System.Drawing.Size(148, 24)
        Me.cmbPedido.TabIndex = 31
        '
        'dtp_Fecha_Contable
        '
        Me.dtp_Fecha_Contable.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha_Contable.Location = New System.Drawing.Point(719, 121)
        Me.dtp_Fecha_Contable.Name = "dtp_Fecha_Contable"
        Me.dtp_Fecha_Contable.Size = New System.Drawing.Size(148, 23)
        Me.dtp_Fecha_Contable.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(547, 124)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 16)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Fecha Contable"
        '
        'dtp_FechaVenc
        '
        Me.dtp_FechaVenc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaVenc.Location = New System.Drawing.Point(719, 167)
        Me.dtp_FechaVenc.Name = "dtp_FechaVenc"
        Me.dtp_FechaVenc.Size = New System.Drawing.Size(148, 23)
        Me.dtp_FechaVenc.TabIndex = 27
        '
        'txt_NumDocPago
        '
        Me.txt_NumDocPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_NumDocPago.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NumDocPago.Location = New System.Drawing.Point(150, 167)
        Me.txt_NumDocPago.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_NumDocPago.Mask = "99999999"
        Me.txt_NumDocPago.Name = "txt_NumDocPago"
        Me.txt_NumDocPago.Size = New System.Drawing.Size(306, 22)
        Me.txt_NumDocPago.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "N° Documento Pago"
        '
        'txt_MontoDoc
        '
        Me.txt_MontoDoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_MontoDoc.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MontoDoc.HidePromptOnLeave = True
        Me.txt_MontoDoc.Location = New System.Drawing.Point(150, 27)
        Me.txt_MontoDoc.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_MontoDoc.Mask = "9999999999"
        Me.txt_MontoDoc.Name = "txt_MontoDoc"
        Me.txt_MontoDoc.Size = New System.Drawing.Size(306, 22)
        Me.txt_MontoDoc.TabIndex = 19
        Me.txt_MontoDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(13, 30)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 16)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Monto"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(547, 170)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(127, 16)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Fecha Vencimiento"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.White
        Me.btnAgregar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = Global.GestionVivero.My.Resources.Resources.AGREGAR_40x40
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.Location = New System.Drawing.Point(927, 128)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(85, 61)
        Me.btnAgregar.TabIndex = 104
        Me.btnAgregar.Text = "Agregar Pago"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'txt_Glosa
        '
        Me.txt_Glosa.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Glosa.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Glosa.Location = New System.Drawing.Point(150, 121)
        Me.txt_Glosa.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_Glosa.Name = "txt_Glosa"
        Me.txt_Glosa.Size = New System.Drawing.Size(306, 22)
        Me.txt_Glosa.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 124)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 16)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Glosa"
        '
        'cmb_TIPO_PAGO
        '
        Me.cmb_TIPO_PAGO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_TIPO_PAGO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TIPO_PAGO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_TIPO_PAGO.FormattingEnabled = True
        Me.cmb_TIPO_PAGO.Location = New System.Drawing.Point(150, 74)
        Me.cmb_TIPO_PAGO.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmb_TIPO_PAGO.Name = "cmb_TIPO_PAGO"
        Me.cmb_TIPO_PAGO.Size = New System.Drawing.Size(306, 24)
        Me.cmb_TIPO_PAGO.TabIndex = 0
        '
        'GrillaVentas
        '
        Me.GrillaVentas.AllowUserToAddRows = False
        Me.GrillaVentas.AllowUserToDeleteRows = False
        Me.GrillaVentas.AllowUserToOrderColumns = True
        Me.GrillaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.GrillaVentas.BackgroundColor = System.Drawing.Color.White
        Me.GrillaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GrillaVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tipo, Me.Nro, Me.Tipodocsii, Me.Numdocsii, Me.FechaDoc, Me.ValorDocumento, Me.saldodoc, Me.totalpago, Me.saldo, Me.fpago, Me.numdocpago, Me.control, Me.obs, Me.EstadoDoc})
        Me.GrillaVentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.GrillaVentas.Location = New System.Drawing.Point(7, 71)
        Me.GrillaVentas.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GrillaVentas.Name = "GrillaVentas"
        Me.GrillaVentas.ReadOnly = True
        Me.GrillaVentas.RowHeadersVisible = False
        Me.GrillaVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.GrillaVentas.RowsDefaultCellStyle = DataGridViewCellStyle25
        Me.GrillaVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GrillaVentas.Size = New System.Drawing.Size(929, 87)
        Me.GrillaVentas.TabIndex = 0
        '
        'Tipo
        '
        Me.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Tipo.FillWeight = 10.0!
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 53
        '
        'Nro
        '
        Me.Nro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Nro.FillWeight = 30.0!
        Me.Nro.HeaderText = "Nro"
        Me.Nro.Name = "Nro"
        Me.Nro.ReadOnly = True
        Me.Nro.Width = 49
        '
        'Tipodocsii
        '
        Me.Tipodocsii.HeaderText = "Tipo Doc.SII"
        Me.Tipodocsii.Name = "Tipodocsii"
        Me.Tipodocsii.ReadOnly = True
        Me.Tipodocsii.Width = 92
        '
        'Numdocsii
        '
        Me.Numdocsii.HeaderText = "N° Doc.SII"
        Me.Numdocsii.Name = "Numdocsii"
        Me.Numdocsii.ReadOnly = True
        Me.Numdocsii.Width = 83
        '
        'FechaDoc
        '
        Me.FechaDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FechaDoc.FillWeight = 30.0!
        Me.FechaDoc.HeaderText = "Fecha"
        Me.FechaDoc.Name = "FechaDoc"
        Me.FechaDoc.ReadOnly = True
        Me.FechaDoc.Width = 62
        '
        'ValorDocumento
        '
        Me.ValorDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ValorDocumento.DefaultCellStyle = DataGridViewCellStyle21
        Me.ValorDocumento.FillWeight = 30.0!
        Me.ValorDocumento.HeaderText = "Valor Documento"
        Me.ValorDocumento.Name = "ValorDocumento"
        Me.ValorDocumento.ReadOnly = True
        Me.ValorDocumento.Width = 114
        '
        'saldodoc
        '
        Me.saldodoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.saldodoc.DefaultCellStyle = DataGridViewCellStyle22
        Me.saldodoc.HeaderText = "Saldo Doc."
        Me.saldodoc.Name = "saldodoc"
        Me.saldodoc.ReadOnly = True
        Me.saldodoc.Width = 85
        '
        'totalpago
        '
        Me.totalpago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.totalpago.DefaultCellStyle = DataGridViewCellStyle23
        Me.totalpago.HeaderText = "Pagos"
        Me.totalpago.Name = "totalpago"
        Me.totalpago.ReadOnly = True
        Me.totalpago.Width = 62
        '
        'saldo
        '
        Me.saldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.saldo.DefaultCellStyle = DataGridViewCellStyle24
        Me.saldo.HeaderText = "Nuevo Saldo"
        Me.saldo.Name = "saldo"
        Me.saldo.ReadOnly = True
        Me.saldo.Visible = False
        '
        'fpago
        '
        Me.fpago.HeaderText = "Forma Pago"
        Me.fpago.Name = "fpago"
        Me.fpago.ReadOnly = True
        Me.fpago.Width = 89
        '
        'numdocpago
        '
        Me.numdocpago.HeaderText = "N° Doc Pago"
        Me.numdocpago.Name = "numdocpago"
        Me.numdocpago.ReadOnly = True
        Me.numdocpago.Width = 95
        '
        'control
        '
        Me.control.HeaderText = "Control"
        Me.control.Name = "control"
        Me.control.ReadOnly = True
        Me.control.Visible = False
        Me.control.Width = 65
        '
        'obs
        '
        Me.obs.HeaderText = "Observaciones"
        Me.obs.Name = "obs"
        Me.obs.ReadOnly = True
        Me.obs.Width = 103
        '
        'EstadoDoc
        '
        Me.EstadoDoc.HeaderText = "Estado"
        Me.EstadoDoc.Name = "EstadoDoc"
        Me.EstadoDoc.ReadOnly = True
        Me.EstadoDoc.Visible = False
        Me.EstadoDoc.Width = 65
        '
        'txt_SaldoFacturas
        '
        Me.txt_SaldoFacturas.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_SaldoFacturas.CausesValidation = False
        Me.txt_SaldoFacturas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SaldoFacturas.ForeColor = System.Drawing.Color.Yellow
        Me.txt_SaldoFacturas.Location = New System.Drawing.Point(154, 18)
        Me.txt_SaldoFacturas.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_SaldoFacturas.Name = "txt_SaldoFacturas"
        Me.txt_SaldoFacturas.ReadOnly = True
        Me.txt_SaldoFacturas.Size = New System.Drawing.Size(134, 26)
        Me.txt_SaldoFacturas.TabIndex = 79
        Me.txt_SaldoFacturas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(6, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 19)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Saldo Doc."
        '
        'GrillaPagos
        '
        Me.GrillaPagos.AllowUserToAddRows = False
        Me.GrillaPagos.AllowUserToDeleteRows = False
        Me.GrillaPagos.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrillaPagos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle26
        Me.GrillaPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_pago, Me.FechaPago, Me.fechaconta, Me.docpago, Me.num, Me.monto, Me.tipodoc, Me.numdoc, Me.IdPedido, Me.ValorPagado, Me.ValorDAI, Me.fec_venc, Me.Glosa, Me.estado, Me.AbonoPedido, Me.PagoNoEditado, Me.rebajaDAI, Me.usuario})
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrillaPagos.DefaultCellStyle = DataGridViewCellStyle30
        Me.GrillaPagos.Location = New System.Drawing.Point(9, 389)
        Me.GrillaPagos.Name = "GrillaPagos"
        Me.GrillaPagos.ReadOnly = True
        Me.GrillaPagos.RowHeadersVisible = False
        Me.GrillaPagos.Size = New System.Drawing.Size(1318, 274)
        Me.GrillaPagos.TabIndex = 81
        '
        'id_pago
        '
        Me.id_pago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.id_pago.HeaderText = "Clave"
        Me.id_pago.Name = "id_pago"
        Me.id_pago.ReadOnly = True
        Me.id_pago.Width = 68
        '
        'FechaPago
        '
        Me.FechaPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FechaPago.FillWeight = 50.0!
        Me.FechaPago.HeaderText = "Fecha Pago"
        Me.FechaPago.Name = "FechaPago"
        Me.FechaPago.ReadOnly = True
        '
        'fechaconta
        '
        Me.fechaconta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.fechaconta.HeaderText = "Fecha Contable"
        Me.fechaconta.Name = "fechaconta"
        Me.fechaconta.ReadOnly = True
        Me.fechaconta.Width = 121
        '
        'docpago
        '
        Me.docpago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.docpago.HeaderText = "Forma Pago"
        Me.docpago.Name = "docpago"
        Me.docpago.ReadOnly = True
        Me.docpago.Width = 101
        '
        'num
        '
        Me.num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.num.HeaderText = "N°"
        Me.num.Name = "num"
        Me.num.ReadOnly = True
        Me.num.Width = 49
        '
        'monto
        '
        Me.monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.monto.DefaultCellStyle = DataGridViewCellStyle27
        Me.monto.HeaderText = "Valor"
        Me.monto.Name = "monto"
        Me.monto.ReadOnly = True
        Me.monto.Width = 66
        '
        'tipodoc
        '
        Me.tipodoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.tipodoc.HeaderText = "Tipo Doc"
        Me.tipodoc.Name = "tipodoc"
        Me.tipodoc.ReadOnly = True
        Me.tipodoc.Width = 61
        '
        'numdoc
        '
        Me.numdoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.numdoc.HeaderText = "N° Doc."
        Me.numdoc.Name = "numdoc"
        Me.numdoc.ReadOnly = True
        Me.numdoc.Width = 76
        '
        'IdPedido
        '
        Me.IdPedido.HeaderText = "Nº Pedido"
        Me.IdPedido.Name = "IdPedido"
        Me.IdPedido.ReadOnly = True
        '
        'ValorPagado
        '
        Me.ValorPagado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ValorPagado.DefaultCellStyle = DataGridViewCellStyle28
        Me.ValorPagado.FillWeight = 50.0!
        Me.ValorPagado.HeaderText = "Valor Pagado"
        Me.ValorPagado.Name = "ValorPagado"
        Me.ValorPagado.ReadOnly = True
        Me.ValorPagado.Width = 109
        '
        'ValorDAI
        '
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ValorDAI.DefaultCellStyle = DataGridViewCellStyle29
        Me.ValorDAI.HeaderText = "Diferencia DAI"
        Me.ValorDAI.Name = "ValorDAI"
        Me.ValorDAI.ReadOnly = True
        '
        'fec_venc
        '
        Me.fec_venc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.fec_venc.HeaderText = "Fecha Venc"
        Me.fec_venc.Name = "fec_venc"
        Me.fec_venc.ReadOnly = True
        Me.fec_venc.Width = 99
        '
        'Glosa
        '
        Me.Glosa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Glosa.HeaderText = "Glosa"
        Me.Glosa.Name = "Glosa"
        Me.Glosa.ReadOnly = True
        Me.Glosa.Width = 70
        '
        'estado
        '
        Me.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        Me.estado.Width = 77
        '
        'AbonoPedido
        '
        Me.AbonoPedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.AbonoPedido.HeaderText = "Abono Pedido"
        Me.AbonoPedido.Name = "AbonoPedido"
        Me.AbonoPedido.ReadOnly = True
        Me.AbonoPedido.Width = 112
        '
        'PagoNoEditado
        '
        Me.PagoNoEditado.HeaderText = "PagoNoEditado"
        Me.PagoNoEditado.Name = "PagoNoEditado"
        Me.PagoNoEditado.ReadOnly = True
        Me.PagoNoEditado.Visible = False
        '
        'rebajaDAI
        '
        Me.rebajaDAI.HeaderText = "Rebaja DAI"
        Me.rebajaDAI.Name = "rebajaDAI"
        Me.rebajaDAI.ReadOnly = True
        '
        'usuario
        '
        Me.usuario.HeaderText = "Usuario"
        Me.usuario.Name = "usuario"
        Me.usuario.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(6, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 19)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Total Abonos"
        '
        'txt_TotalAbonos
        '
        Me.txt_TotalAbonos.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_TotalAbonos.CausesValidation = False
        Me.txt_TotalAbonos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalAbonos.ForeColor = System.Drawing.Color.Yellow
        Me.txt_TotalAbonos.Location = New System.Drawing.Point(154, 150)
        Me.txt_TotalAbonos.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_TotalAbonos.Name = "txt_TotalAbonos"
        Me.txt_TotalAbonos.ReadOnly = True
        Me.txt_TotalAbonos.Size = New System.Drawing.Size(134, 26)
        Me.txt_TotalAbonos.TabIndex = 84
        Me.txt_TotalAbonos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(6, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 19)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "Cheq. x Cobrar"
        '
        'txt_ChequesxCobrar
        '
        Me.txt_ChequesxCobrar.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_ChequesxCobrar.CausesValidation = False
        Me.txt_ChequesxCobrar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ChequesxCobrar.ForeColor = System.Drawing.Color.Yellow
        Me.txt_ChequesxCobrar.Location = New System.Drawing.Point(154, 84)
        Me.txt_ChequesxCobrar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_ChequesxCobrar.Name = "txt_ChequesxCobrar"
        Me.txt_ChequesxCobrar.ReadOnly = True
        Me.txt_ChequesxCobrar.Size = New System.Drawing.Size(134, 26)
        Me.txt_ChequesxCobrar.TabIndex = 99
        Me.txt_ChequesxCobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(6, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 19)
        Me.Label8.TabIndex = 100
        Me.Label8.Text = "Deuda Total"
        '
        'txt_DeudaTotal
        '
        Me.txt_DeudaTotal.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_DeudaTotal.CausesValidation = False
        Me.txt_DeudaTotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DeudaTotal.ForeColor = System.Drawing.Color.Yellow
        Me.txt_DeudaTotal.Location = New System.Drawing.Point(154, 183)
        Me.txt_DeudaTotal.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_DeudaTotal.Name = "txt_DeudaTotal"
        Me.txt_DeudaTotal.ReadOnly = True
        Me.txt_DeudaTotal.Size = New System.Drawing.Size(134, 26)
        Me.txt_DeudaTotal.TabIndex = 101
        Me.txt_DeudaTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(942, 71)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 40)
        Me.Button2.TabIndex = 102
        Me.Button2.Text = "Todos los Documentos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(942, 118)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(85, 40)
        Me.Button5.TabIndex = 105
        Me.Button5.Text = "Documentos Pendientes"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.SeaGreen
        Me.Button4.Image = Global.GestionVivero.My.Resources.Resources.Update
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(233, 669)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(166, 48)
        Me.Button4.TabIndex = 107
        Me.Button4.Text = "Actualiza Abono Inicial"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Blue
        Me.Button3.Image = Global.GestionVivero.My.Resources.Resources.guardar_40x40
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(13, 669)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(166, 48)
        Me.Button3.TabIndex = 106
        Me.Button3.Text = "Guardar Abonos"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.White
        Me.btnEliminar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Red
        Me.btnEliminar.Image = Global.GestionVivero.My.Resources.Resources.eliminar_40x40
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(1083, 669)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(119, 48)
        Me.btnEliminar.TabIndex = 103
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Image = Global.GestionVivero.My.Resources.Resources.New_document
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(453, 669)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(166, 48)
        Me.Button6.TabIndex = 112
        Me.Button6.Text = "Imprime Recibo de Pago"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = False
        '
        'txtSaldoAjusteDAI
        '
        Me.txtSaldoAjusteDAI.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtSaldoAjusteDAI.CausesValidation = False
        Me.txtSaldoAjusteDAI.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoAjusteDAI.ForeColor = System.Drawing.Color.Yellow
        Me.txtSaldoAjusteDAI.Location = New System.Drawing.Point(154, 51)
        Me.txtSaldoAjusteDAI.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtSaldoAjusteDAI.Name = "txtSaldoAjusteDAI"
        Me.txtSaldoAjusteDAI.ReadOnly = True
        Me.txtSaldoAjusteDAI.Size = New System.Drawing.Size(134, 26)
        Me.txtSaldoAjusteDAI.TabIndex = 113
        Me.txtSaldoAjusteDAI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(25, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 19)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "D.A.I."
        '
        'chkRebajaDAI
        '
        Me.chkRebajaDAI.AutoSize = True
        Me.chkRebajaDAI.Location = New System.Drawing.Point(6, 57)
        Me.chkRebajaDAI.Name = "chkRebajaDAI"
        Me.chkRebajaDAI.Size = New System.Drawing.Size(15, 14)
        Me.chkRebajaDAI.TabIndex = 115
        Me.chkRebajaDAI.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(6, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 19)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Letras x Cobrar"
        '
        'txt_LetrasxCobrar
        '
        Me.txt_LetrasxCobrar.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_LetrasxCobrar.CausesValidation = False
        Me.txt_LetrasxCobrar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LetrasxCobrar.ForeColor = System.Drawing.Color.Yellow
        Me.txt_LetrasxCobrar.Location = New System.Drawing.Point(154, 117)
        Me.txt_LetrasxCobrar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_LetrasxCobrar.Name = "txt_LetrasxCobrar"
        Me.txt_LetrasxCobrar.ReadOnly = True
        Me.txt_LetrasxCobrar.Size = New System.Drawing.Size(134, 26)
        Me.txt_LetrasxCobrar.TabIndex = 85
        Me.txt_LetrasxCobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDevolucion
        '
        Me.btnDevolucion.BackColor = System.Drawing.Color.White
        Me.btnDevolucion.Enabled = False
        Me.btnDevolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDevolucion.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnDevolucion.Image = Global.GestionVivero.My.Resources.Resources.donaciones_40x40
        Me.btnDevolucion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDevolucion.Location = New System.Drawing.Point(673, 669)
        Me.btnDevolucion.Name = "btnDevolucion"
        Me.btnDevolucion.Size = New System.Drawing.Size(166, 48)
        Me.btnDevolucion.TabIndex = 116
        Me.btnDevolucion.Text = "Devolución Abono"
        Me.btnDevolucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDevolucion.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Red
        Me.Button7.Image = Global.GestionVivero.My.Resources.Resources.salir_40x40
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(1208, 669)
        Me.Button7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(119, 48)
        Me.Button7.TabIndex = 117
        Me.Button7.Text = "Salir"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = False
        '
        'grpsaldos
        '
        Me.grpsaldos.Controls.Add(Me.Label6)
        Me.grpsaldos.Controls.Add(Me.txt_LetrasxCobrar)
        Me.grpsaldos.Controls.Add(Me.Label2)
        Me.grpsaldos.Controls.Add(Me.chkRebajaDAI)
        Me.grpsaldos.Controls.Add(Me.txt_TotalAbonos)
        Me.grpsaldos.Controls.Add(Me.Label1)
        Me.grpsaldos.Controls.Add(Me.Label8)
        Me.grpsaldos.Controls.Add(Me.txtSaldoAjusteDAI)
        Me.grpsaldos.Controls.Add(Me.txt_DeudaTotal)
        Me.grpsaldos.Controls.Add(Me.Label3)
        Me.grpsaldos.Controls.Add(Me.txt_SaldoFacturas)
        Me.grpsaldos.Controls.Add(Me.Label7)
        Me.grpsaldos.Controls.Add(Me.txt_ChequesxCobrar)
        Me.grpsaldos.Location = New System.Drawing.Point(1033, 5)
        Me.grpsaldos.Name = "grpsaldos"
        Me.grpsaldos.Size = New System.Drawing.Size(294, 228)
        Me.grpsaldos.TabIndex = 119
        Me.grpsaldos.TabStop = False
        Me.grpsaldos.Text = "Saldos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtLineaUtilizada)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txtSaldoLineaCredito)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtLineaCredito)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Location = New System.Drawing.Point(1033, 239)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(294, 131)
        Me.GroupBox2.TabIndex = 120
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Línea de Crédito"
        '
        'txtLineaUtilizada
        '
        Me.txtLineaUtilizada.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtLineaUtilizada.CausesValidation = False
        Me.txtLineaUtilizada.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLineaUtilizada.ForeColor = System.Drawing.Color.Yellow
        Me.txtLineaUtilizada.Location = New System.Drawing.Point(154, 55)
        Me.txtLineaUtilizada.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtLineaUtilizada.Name = "txtLineaUtilizada"
        Me.txtLineaUtilizada.ReadOnly = True
        Me.txtLineaUtilizada.Size = New System.Drawing.Size(134, 26)
        Me.txtLineaUtilizada.TabIndex = 120
        Me.txtLineaUtilizada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(6, 59)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(128, 19)
        Me.Label19.TabIndex = 119
        Me.Label19.Text = "Monto Utilizado"
        '
        'txtSaldoLineaCredito
        '
        Me.txtSaldoLineaCredito.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtSaldoLineaCredito.CausesValidation = False
        Me.txtSaldoLineaCredito.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoLineaCredito.ForeColor = System.Drawing.Color.Yellow
        Me.txtSaldoLineaCredito.Location = New System.Drawing.Point(154, 88)
        Me.txtSaldoLineaCredito.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtSaldoLineaCredito.Name = "txtSaldoLineaCredito"
        Me.txtSaldoLineaCredito.ReadOnly = True
        Me.txtSaldoLineaCredito.Size = New System.Drawing.Size(134, 26)
        Me.txtSaldoLineaCredito.TabIndex = 118
        Me.txtSaldoLineaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(6, 92)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(137, 19)
        Me.Label16.TabIndex = 117
        Me.Label16.Text = "Cupo Disponible"
        '
        'txtLineaCredito
        '
        Me.txtLineaCredito.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtLineaCredito.CausesValidation = False
        Me.txtLineaCredito.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLineaCredito.ForeColor = System.Drawing.Color.Yellow
        Me.txtLineaCredito.Location = New System.Drawing.Point(154, 26)
        Me.txtLineaCredito.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtLineaCredito.Name = "txtLineaCredito"
        Me.txtLineaCredito.ReadOnly = True
        Me.txtLineaCredito.Size = New System.Drawing.Size(134, 26)
        Me.txtLineaCredito.TabIndex = 116
        Me.txtLineaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(6, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(134, 19)
        Me.Label15.TabIndex = 101
        Me.Label15.Text = "Línea de Crédito"
        '
        'Abono_Deuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1334, 716)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpsaldos)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.btnDevolucion)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GrillaPagos)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.GrillaVentas)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox8)
        Me.Name = "Abono_Deuda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes:  Abono Deuda"
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.GrillaVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpsaldos.ResumeLayout(False)
        Me.grpsaldos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_clientebuscar As System.Windows.Forms.TextBox
    Friend WithEvents txt_RUT_CLI As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_MontoDoc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_Glosa As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmb_TIPO_PAGO As System.Windows.Forms.ComboBox
    Friend WithEvents GrillaVentas As System.Windows.Forms.DataGridView
    Friend WithEvents txt_SaldoFacturas As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_TotalAbonos As System.Windows.Forms.TextBox
    Friend WithEvents GrillaPagos As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents txt_NumDocPago As System.Windows.Forms.MaskedTextBox
    Friend WithEvents dtp_FechaVenc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_ChequesxCobrar As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_DeudaTotal As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dtp_Fecha_Contable As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txt_IdCliente As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbPedido As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents chkCliente As CheckBox
    Friend WithEvents txt_NombreCliente As MaskedTextBox
    Friend WithEvents txtRutCli As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbDocumento As ComboBox
    Friend WithEvents rbAbonoDocumento As RadioButton
    Friend WithEvents rbAbonoPedido As RadioButton
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Nro As DataGridViewTextBoxColumn
    Friend WithEvents Tipodocsii As DataGridViewTextBoxColumn
    Friend WithEvents Numdocsii As DataGridViewTextBoxColumn
    Friend WithEvents FechaDoc As DataGridViewTextBoxColumn
    Friend WithEvents ValorDocumento As DataGridViewTextBoxColumn
    Friend WithEvents saldodoc As DataGridViewTextBoxColumn
    Friend WithEvents totalpago As DataGridViewTextBoxColumn
    Friend WithEvents saldo As DataGridViewTextBoxColumn
    Friend WithEvents fpago As DataGridViewTextBoxColumn
    Friend WithEvents numdocpago As DataGridViewTextBoxColumn
    Friend WithEvents control As DataGridViewTextBoxColumn
    Friend WithEvents obs As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDoc As DataGridViewTextBoxColumn
    Friend WithEvents txtSaldoAjusteDAI As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkRebajaDAI As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_LetrasxCobrar As TextBox
    Friend WithEvents btnDevolucion As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents txtIdPedido As TextBox
    Friend WithEvents txtTelefonos As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents grpsaldos As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtLineaUtilizada As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtSaldoLineaCredito As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtLineaCredito As TextBox
    Friend WithEvents id_pago As DataGridViewTextBoxColumn
    Friend WithEvents FechaPago As DataGridViewTextBoxColumn
    Friend WithEvents fechaconta As DataGridViewTextBoxColumn
    Friend WithEvents docpago As DataGridViewTextBoxColumn
    Friend WithEvents num As DataGridViewTextBoxColumn
    Friend WithEvents monto As DataGridViewTextBoxColumn
    Friend WithEvents tipodoc As DataGridViewTextBoxColumn
    Friend WithEvents numdoc As DataGridViewTextBoxColumn
    Friend WithEvents IdPedido As DataGridViewTextBoxColumn
    Friend WithEvents ValorPagado As DataGridViewTextBoxColumn
    Friend WithEvents ValorDAI As DataGridViewTextBoxColumn
    Friend WithEvents fec_venc As DataGridViewTextBoxColumn
    Friend WithEvents Glosa As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents AbonoPedido As DataGridViewTextBoxColumn
    Friend WithEvents PagoNoEditado As DataGridViewTextBoxColumn
    Friend WithEvents rebajaDAI As DataGridViewTextBoxColumn
    Friend WithEvents usuario As DataGridViewTextBoxColumn
End Class
