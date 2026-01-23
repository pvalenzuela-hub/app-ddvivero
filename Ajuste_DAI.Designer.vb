<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajuste_DAI
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtValorAjuste = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
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
        Me.GrillaDocumentos = New System.Windows.Forms.DataGridView()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrillaPagos = New System.Windows.Forms.DataGridView()
        Me.id_pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.docpago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipodoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numdoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorPagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDAI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Glosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbonoPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagoNoEditado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rebajaDAI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDaiNoEditado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRutCli = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_DiferenciaDAI = New System.Windows.Forms.MaskedTextBox()
        Me.nud_ValorPagado = New System.Windows.Forms.NumericUpDown()
        Me.chkPasarTotal = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtIdPago = New System.Windows.Forms.TextBox()
        Me.txtDocRefer = New System.Windows.Forms.TextBox()
        Me.txtNumRefer = New System.Windows.Forms.TextBox()
        Me.GroupBox8.SuspendLayout()
        CType(Me.GrillaDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_ValorPagado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txtValorAjuste)
        Me.GroupBox8.Controls.Add(Me.Label5)
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
        Me.GroupBox8.Location = New System.Drawing.Point(12, 14)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox8.Size = New System.Drawing.Size(1188, 103)
        Me.GroupBox8.TabIndex = 37
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Búsqueda de Cliente"
        '
        'txtValorAjuste
        '
        Me.txtValorAjuste.BackColor = System.Drawing.Color.Navy
        Me.txtValorAjuste.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorAjuste.ForeColor = System.Drawing.Color.Gold
        Me.txtValorAjuste.HidePromptOnLeave = True
        Me.txtValorAjuste.Location = New System.Drawing.Point(293, 61)
        Me.txtValorAjuste.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtValorAjuste.Name = "txtValorAjuste"
        Me.txtValorAjuste.ReadOnly = True
        Me.txtValorAjuste.Size = New System.Drawing.Size(166, 22)
        Me.txtValorAjuste.TabIndex = 118
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(203, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 15)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "Saldo DAI"
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
        Me.txtTelefonos.Size = New System.Drawing.Size(557, 22)
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
        Me.Label14.Location = New System.Drawing.Point(1114, 20)
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
        Me.txt_NombreCliente.Size = New System.Drawing.Size(796, 22)
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
        Me.txt_IdCliente.Location = New System.Drawing.Point(1136, 16)
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
        'GrillaDocumentos
        '
        Me.GrillaDocumentos.AllowUserToAddRows = False
        Me.GrillaDocumentos.AllowUserToDeleteRows = False
        Me.GrillaDocumentos.AllowUserToOrderColumns = True
        Me.GrillaDocumentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.GrillaDocumentos.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrillaDocumentos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GrillaDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GrillaDocumentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tipo, Me.Nro, Me.Tipodocsii, Me.Numdocsii, Me.FechaDoc, Me.ValorDocumento, Me.saldodoc, Me.totalpago, Me.saldo, Me.fpago, Me.numdocpago, Me.control, Me.obs, Me.EstadoDoc})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrillaDocumentos.DefaultCellStyle = DataGridViewCellStyle6
        Me.GrillaDocumentos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.GrillaDocumentos.Location = New System.Drawing.Point(12, 142)
        Me.GrillaDocumentos.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GrillaDocumentos.Name = "GrillaDocumentos"
        Me.GrillaDocumentos.ReadOnly = True
        Me.GrillaDocumentos.RowHeadersVisible = False
        Me.GrillaDocumentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.GrillaDocumentos.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.GrillaDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GrillaDocumentos.Size = New System.Drawing.Size(1188, 135)
        Me.GrillaDocumentos.TabIndex = 38
        '
        'Tipo
        '
        Me.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Tipo.FillWeight = 10.0!
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 60
        '
        'Nro
        '
        Me.Nro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Nro.FillWeight = 30.0!
        Me.Nro.HeaderText = "Nro"
        Me.Nro.Name = "Nro"
        Me.Nro.ReadOnly = True
        Me.Nro.Width = 54
        '
        'Tipodocsii
        '
        Me.Tipodocsii.HeaderText = "Tipo Doc.SII"
        Me.Tipodocsii.Name = "Tipodocsii"
        Me.Tipodocsii.ReadOnly = True
        Me.Tipodocsii.Width = 106
        '
        'Numdocsii
        '
        Me.Numdocsii.HeaderText = "N° Doc.SII"
        Me.Numdocsii.Name = "Numdocsii"
        Me.Numdocsii.ReadOnly = True
        Me.Numdocsii.Width = 92
        '
        'FechaDoc
        '
        Me.FechaDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FechaDoc.FillWeight = 30.0!
        Me.FechaDoc.HeaderText = "Fecha"
        Me.FechaDoc.Name = "FechaDoc"
        Me.FechaDoc.ReadOnly = True
        Me.FechaDoc.Width = 70
        '
        'ValorDocumento
        '
        Me.ValorDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ValorDocumento.DefaultCellStyle = DataGridViewCellStyle2
        Me.ValorDocumento.FillWeight = 30.0!
        Me.ValorDocumento.HeaderText = "Valor Documento"
        Me.ValorDocumento.Name = "ValorDocumento"
        Me.ValorDocumento.ReadOnly = True
        Me.ValorDocumento.Width = 136
        '
        'saldodoc
        '
        Me.saldodoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.saldodoc.DefaultCellStyle = DataGridViewCellStyle3
        Me.saldodoc.HeaderText = "Saldo Doc."
        Me.saldodoc.Name = "saldodoc"
        Me.saldodoc.ReadOnly = True
        Me.saldodoc.Width = 99
        '
        'totalpago
        '
        Me.totalpago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.totalpago.DefaultCellStyle = DataGridViewCellStyle4
        Me.totalpago.HeaderText = "Pagos"
        Me.totalpago.Name = "totalpago"
        Me.totalpago.ReadOnly = True
        Me.totalpago.Width = 72
        '
        'saldo
        '
        Me.saldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.saldo.DefaultCellStyle = DataGridViewCellStyle5
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
        Me.fpago.Width = 107
        '
        'numdocpago
        '
        Me.numdocpago.HeaderText = "N° Doc Pago"
        Me.numdocpago.Name = "numdocpago"
        Me.numdocpago.ReadOnly = True
        Me.numdocpago.Width = 110
        '
        'control
        '
        Me.control.HeaderText = "Control"
        Me.control.Name = "control"
        Me.control.ReadOnly = True
        Me.control.Visible = False
        Me.control.Width = 74
        '
        'obs
        '
        Me.obs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.obs.HeaderText = "Observaciones"
        Me.obs.Name = "obs"
        Me.obs.ReadOnly = True
        '
        'EstadoDoc
        '
        Me.EstadoDoc.HeaderText = "Estado"
        Me.EstadoDoc.Name = "EstadoDoc"
        Me.EstadoDoc.ReadOnly = True
        Me.EstadoDoc.Visible = False
        Me.EstadoDoc.Width = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 15)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Documentos con sobrepago"
        '
        'GrillaPagos
        '
        Me.GrillaPagos.AllowUserToAddRows = False
        Me.GrillaPagos.AllowUserToDeleteRows = False
        Me.GrillaPagos.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrillaPagos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.GrillaPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_pago, Me.FechaPago, Me.docpago, Me.num, Me.tipodoc, Me.numdoc, Me.IdPedido, Me.ValorPagado, Me.ValorDAI, Me.Glosa, Me.estado, Me.AbonoPedido, Me.PagoNoEditado, Me.rebajaDAI, Me.ValorDaiNoEditado})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrillaPagos.DefaultCellStyle = DataGridViewCellStyle11
        Me.GrillaPagos.Location = New System.Drawing.Point(12, 305)
        Me.GrillaPagos.Name = "GrillaPagos"
        Me.GrillaPagos.ReadOnly = True
        Me.GrillaPagos.RowHeadersVisible = False
        Me.GrillaPagos.Size = New System.Drawing.Size(1188, 124)
        Me.GrillaPagos.TabIndex = 82
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
        Me.FechaPago.Width = 109
        '
        'docpago
        '
        Me.docpago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.docpago.HeaderText = "Forma Pago"
        Me.docpago.Name = "docpago"
        Me.docpago.ReadOnly = True
        Me.docpago.Width = 110
        '
        'num
        '
        Me.num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.num.HeaderText = "N°"
        Me.num.Name = "num"
        Me.num.ReadOnly = True
        Me.num.Width = 49
        '
        'tipodoc
        '
        Me.tipodoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.tipodoc.HeaderText = "Tipo Doc"
        Me.tipodoc.Name = "tipodoc"
        Me.tipodoc.ReadOnly = True
        Me.tipodoc.Width = 90
        '
        'numdoc
        '
        Me.numdoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.numdoc.HeaderText = "N° Doc."
        Me.numdoc.Name = "numdoc"
        Me.numdoc.ReadOnly = True
        Me.numdoc.Width = 82
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
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ValorPagado.DefaultCellStyle = DataGridViewCellStyle9
        Me.ValorPagado.FillWeight = 50.0!
        Me.ValorPagado.HeaderText = "Valor Pagado"
        Me.ValorPagado.Name = "ValorPagado"
        Me.ValorPagado.ReadOnly = True
        Me.ValorPagado.Width = 119
        '
        'ValorDAI
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ValorDAI.DefaultCellStyle = DataGridViewCellStyle10
        Me.ValorDAI.HeaderText = "Diferencia DAI"
        Me.ValorDAI.Name = "ValorDAI"
        Me.ValorDAI.ReadOnly = True
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
        Me.AbonoPedido.Width = 122
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
        Me.rebajaDAI.HeaderText = "rebajaDAI"
        Me.rebajaDAI.Name = "rebajaDAI"
        Me.rebajaDAI.ReadOnly = True
        '
        'ValorDaiNoEditado
        '
        Me.ValorDaiNoEditado.HeaderText = "ValorDaiNoEditado"
        Me.ValorDaiNoEditado.Name = "ValorDaiNoEditado"
        Me.ValorDaiNoEditado.ReadOnly = True
        Me.ValorDaiNoEditado.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 15)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Detalle del sobrepago del Documento"
        '
        'txtRutCli
        '
        Me.txtRutCli.Location = New System.Drawing.Point(12, 573)
        Me.txtRutCli.Name = "txtRutCli"
        Me.txtRutCli.Size = New System.Drawing.Size(38, 20)
        Me.txtRutCli.TabIndex = 112
        Me.txtRutCli.Visible = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Red
        Me.Button7.Image = Global.GestionVivero.My.Resources.Resources.salir_40x40
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(1285, 4)
        Me.Button7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(48, 48)
        Me.Button7.TabIndex = 118
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(460, 442)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(99, 19)
        Me.Label18.TabIndex = 121
        Me.Label18.Text = "Valor Pagado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(460, 488)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 19)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "Monto DAI"
        '
        'txt_DiferenciaDAI
        '
        Me.txt_DiferenciaDAI.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_DiferenciaDAI.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DiferenciaDAI.HidePromptOnLeave = True
        Me.txt_DiferenciaDAI.Location = New System.Drawing.Point(595, 480)
        Me.txt_DiferenciaDAI.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_DiferenciaDAI.Mask = "9999999999"
        Me.txt_DiferenciaDAI.Name = "txt_DiferenciaDAI"
        Me.txt_DiferenciaDAI.ReadOnly = True
        Me.txt_DiferenciaDAI.Size = New System.Drawing.Size(120, 27)
        Me.txt_DiferenciaDAI.TabIndex = 123
        Me.txt_DiferenciaDAI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nud_ValorPagado
        '
        Me.nud_ValorPagado.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_ValorPagado.Location = New System.Drawing.Point(595, 438)
        Me.nud_ValorPagado.Name = "nud_ValorPagado"
        Me.nud_ValorPagado.Size = New System.Drawing.Size(120, 27)
        Me.nud_ValorPagado.TabIndex = 124
        Me.nud_ValorPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkPasarTotal
        '
        Me.chkPasarTotal.AutoSize = True
        Me.chkPasarTotal.Checked = True
        Me.chkPasarTotal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPasarTotal.Location = New System.Drawing.Point(750, 443)
        Me.chkPasarTotal.Name = "chkPasarTotal"
        Me.chkPasarTotal.Size = New System.Drawing.Size(121, 17)
        Me.chkPasarTotal.TabIndex = 125
        Me.chkPasarTotal.Text = "Pasar el Total a DAI"
        Me.chkPasarTotal.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Blue
        Me.Button3.Image = Global.GestionVivero.My.Resources.Resources.guardar_40x40
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(595, 534)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(48, 48)
        Me.Button3.TabIndex = 126
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Button3, "Actualiza DAI")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtIdPago
        '
        Me.txtIdPago.Location = New System.Drawing.Point(69, 573)
        Me.txtIdPago.Name = "txtIdPago"
        Me.txtIdPago.Size = New System.Drawing.Size(38, 20)
        Me.txtIdPago.TabIndex = 127
        Me.txtIdPago.Visible = False
        '
        'txtDocRefer
        '
        Me.txtDocRefer.Location = New System.Drawing.Point(118, 573)
        Me.txtDocRefer.Name = "txtDocRefer"
        Me.txtDocRefer.Size = New System.Drawing.Size(38, 20)
        Me.txtDocRefer.TabIndex = 129
        Me.txtDocRefer.Visible = False
        '
        'txtNumRefer
        '
        Me.txtNumRefer.Location = New System.Drawing.Point(162, 573)
        Me.txtNumRefer.Name = "txtNumRefer"
        Me.txtNumRefer.Size = New System.Drawing.Size(38, 20)
        Me.txtNumRefer.TabIndex = 130
        Me.txtNumRefer.Visible = False
        '
        'Ajuste_DAI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1334, 716)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtNumRefer)
        Me.Controls.Add(Me.txtDocRefer)
        Me.Controls.Add(Me.txtIdPago)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.chkPasarTotal)
        Me.Controls.Add(Me.nud_ValorPagado)
        Me.Controls.Add(Me.txt_DiferenciaDAI)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.txtRutCli)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GrillaPagos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrillaDocumentos)
        Me.Controls.Add(Me.GroupBox8)
        Me.Name = "Ajuste_DAI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajuste_DAI"
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.GrillaDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_ValorPagado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents txtTelefonos As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_NombreCliente As MaskedTextBox
    Friend WithEvents chkCliente As CheckBox
    Friend WithEvents txt_IdCliente As MaskedTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_clientebuscar As TextBox
    Friend WithEvents txt_RUT_CLI As MaskedTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GrillaDocumentos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GrillaPagos As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRutCli As TextBox
    Friend WithEvents Button7 As Button
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
    Friend WithEvents Label18 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_DiferenciaDAI As MaskedTextBox
    Friend WithEvents id_pago As DataGridViewTextBoxColumn
    Friend WithEvents FechaPago As DataGridViewTextBoxColumn
    Friend WithEvents docpago As DataGridViewTextBoxColumn
    Friend WithEvents num As DataGridViewTextBoxColumn
    Friend WithEvents tipodoc As DataGridViewTextBoxColumn
    Friend WithEvents numdoc As DataGridViewTextBoxColumn
    Friend WithEvents IdPedido As DataGridViewTextBoxColumn
    Friend WithEvents ValorPagado As DataGridViewTextBoxColumn
    Friend WithEvents ValorDAI As DataGridViewTextBoxColumn
    Friend WithEvents Glosa As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents AbonoPedido As DataGridViewTextBoxColumn
    Friend WithEvents PagoNoEditado As DataGridViewTextBoxColumn
    Friend WithEvents rebajaDAI As DataGridViewTextBoxColumn
    Friend WithEvents ValorDaiNoEditado As DataGridViewTextBoxColumn
    Friend WithEvents nud_ValorPagado As NumericUpDown
    Friend WithEvents chkPasarTotal As CheckBox
    Friend WithEvents Button3 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtIdPago As TextBox
    Friend WithEvents txtDocRefer As TextBox
    Friend WithEvents txtNumRefer As TextBox
    Friend WithEvents txtValorAjuste As MaskedTextBox
    Friend WithEvents Label5 As Label
End Class
