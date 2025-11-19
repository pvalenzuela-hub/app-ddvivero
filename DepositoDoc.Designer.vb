<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepositoDoc
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_RutCliente = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.cmb_TIPO_PAGO = New System.Windows.Forms.ComboBox()
        Me.dtp_fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fecha2 = New System.Windows.Forms.DateTimePicker()
        Me.Chk_Fechas = New System.Windows.Forms.CheckBox()
        Me.chk_Rut = New System.Windows.Forms.CheckBox()
        Me.Chk_Fpago = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_FPago = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_Banco = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Glosa = New System.Windows.Forms.TextBox()
        Me.txt_ValorDeposito = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumDocPago = New System.Windows.Forms.MaskedTextBox()
        Me.dtp_FechaDeposito = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GrillaPagos = New System.Windows.Forms.DataGridView()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtIdClienteDocumento = New System.Windows.Forms.TextBox()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.chkPorNombre = New System.Windows.Forms.CheckBox()
        Me.numdocpago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.formapago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechavcto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pagos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GrillaPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_RutCliente
        '
        Me.txt_RutCliente.Enabled = False
        Me.txt_RutCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RutCliente.HidePromptOnLeave = True
        Me.txt_RutCliente.Location = New System.Drawing.Point(159, 10)
        Me.txt_RutCliente.Name = "txt_RutCliente"
        Me.txt_RutCliente.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_RutCliente.Size = New System.Drawing.Size(94, 20)
        Me.txt_RutCliente.TabIndex = 86
        Me.txt_RutCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_nombre
        '
        Me.txt_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(278, 10)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(308, 20)
        Me.txt_nombre.TabIndex = 89
        '
        'cmb_TIPO_PAGO
        '
        Me.cmb_TIPO_PAGO.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_TIPO_PAGO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TIPO_PAGO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_TIPO_PAGO.FormattingEnabled = True
        Me.cmb_TIPO_PAGO.Location = New System.Drawing.Point(159, 32)
        Me.cmb_TIPO_PAGO.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmb_TIPO_PAGO.Name = "cmb_TIPO_PAGO"
        Me.cmb_TIPO_PAGO.Size = New System.Drawing.Size(427, 24)
        Me.cmb_TIPO_PAGO.TabIndex = 91
        '
        'dtp_fecha1
        '
        Me.dtp_fecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha1.Location = New System.Drawing.Point(159, 58)
        Me.dtp_fecha1.Name = "dtp_fecha1"
        Me.dtp_fecha1.Size = New System.Drawing.Size(100, 20)
        Me.dtp_fecha1.TabIndex = 94
        '
        'dtp_fecha2
        '
        Me.dtp_fecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha2.Location = New System.Drawing.Point(279, 58)
        Me.dtp_fecha2.Name = "dtp_fecha2"
        Me.dtp_fecha2.Size = New System.Drawing.Size(100, 20)
        Me.dtp_fecha2.TabIndex = 95
        '
        'Chk_Fechas
        '
        Me.Chk_Fechas.AutoSize = True
        Me.Chk_Fechas.Location = New System.Drawing.Point(21, 60)
        Me.Chk_Fechas.Name = "Chk_Fechas"
        Me.Chk_Fechas.Size = New System.Drawing.Size(106, 17)
        Me.Chk_Fechas.TabIndex = 96
        Me.Chk_Fechas.Text = "Rango de Fecha"
        Me.Chk_Fechas.UseVisualStyleBackColor = True
        '
        'chk_Rut
        '
        Me.chk_Rut.AutoSize = True
        Me.chk_Rut.Location = New System.Drawing.Point(21, 12)
        Me.chk_Rut.Name = "chk_Rut"
        Me.chk_Rut.Size = New System.Drawing.Size(58, 17)
        Me.chk_Rut.TabIndex = 97
        Me.chk_Rut.Text = "Cliente"
        Me.chk_Rut.UseVisualStyleBackColor = True
        '
        'Chk_Fpago
        '
        Me.Chk_Fpago.AutoSize = True
        Me.Chk_Fpago.Location = New System.Drawing.Point(21, 36)
        Me.Chk_Fpago.Name = "Chk_Fpago"
        Me.Chk_Fpago.Size = New System.Drawing.Size(98, 17)
        Me.Chk_Fpago.TabIndex = 98
        Me.Chk_Fpago.Text = "Forma de Pago"
        Me.Chk_Fpago.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_FPago)
        Me.GroupBox1.Controls.Add(Me.cmb_Banco)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_Glosa)
        Me.GroupBox1.Controls.Add(Me.txt_ValorDeposito)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNumDocPago)
        Me.GroupBox1.Controls.Add(Me.dtp_FechaDeposito)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1150, 84)
        Me.GroupBox1.TabIndex = 99
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Antecedentes del Depósito"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(426, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 124
        Me.Label6.Text = "Cta.Origen"
        '
        'txt_FPago
        '
        Me.txt_FPago.Enabled = False
        Me.txt_FPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FPago.HidePromptOnLeave = True
        Me.txt_FPago.Location = New System.Drawing.Point(484, 49)
        Me.txt_FPago.Name = "txt_FPago"
        Me.txt_FPago.ReadOnly = True
        Me.txt_FPago.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_FPago.Size = New System.Drawing.Size(214, 20)
        Me.txt_FPago.TabIndex = 123
        Me.txt_FPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmb_Banco
        '
        Me.cmb_Banco.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_Banco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Banco.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Banco.ForeColor = System.Drawing.Color.DodgerBlue
        Me.cmb_Banco.FormattingEnabled = True
        Me.cmb_Banco.Location = New System.Drawing.Point(244, 47)
        Me.cmb_Banco.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmb_Banco.Name = "cmb_Banco"
        Me.cmb_Banco.Size = New System.Drawing.Size(177, 24)
        Me.cmb_Banco.TabIndex = 115
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(205, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Banco"
        '
        'txt_Glosa
        '
        Me.txt_Glosa.Location = New System.Drawing.Point(305, 16)
        Me.txt_Glosa.MaxLength = 200
        Me.txt_Glosa.Name = "txt_Glosa"
        Me.txt_Glosa.Size = New System.Drawing.Size(592, 20)
        Me.txt_Glosa.TabIndex = 121
        '
        'txt_ValorDeposito
        '
        Me.txt_ValorDeposito.Location = New System.Drawing.Point(797, 52)
        Me.txt_ValorDeposito.MaxLength = 12
        Me.txt_ValorDeposito.Name = "txt_ValorDeposito"
        Me.txt_ValorDeposito.Size = New System.Drawing.Size(100, 20)
        Me.txt_ValorDeposito.TabIndex = 120
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(703, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 119
        Me.Label5.Text = "Valor Depositado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(205, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "Glosa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "N° Doc"
        '
        'txtNumDocPago
        '
        Me.txtNumDocPago.Enabled = False
        Me.txtNumDocPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumDocPago.HidePromptOnLeave = True
        Me.txtNumDocPago.Location = New System.Drawing.Point(57, 16)
        Me.txtNumDocPago.Name = "txtNumDocPago"
        Me.txtNumDocPago.ReadOnly = True
        Me.txtNumDocPago.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNumDocPago.Size = New System.Drawing.Size(140, 20)
        Me.txtNumDocPago.TabIndex = 116
        Me.txtNumDocPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtp_FechaDeposito
        '
        Me.dtp_FechaDeposito.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaDeposito.Location = New System.Drawing.Point(97, 49)
        Me.dtp_FechaDeposito.Name = "dtp_FechaDeposito"
        Me.dtp_FechaDeposito.Size = New System.Drawing.Size(100, 20)
        Me.dtp_FechaDeposito.TabIndex = 114
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Fecha Depósito"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(973, 30)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(159, 41)
        Me.Button4.TabIndex = 112
        Me.Button4.Text = "Grabar Depósito"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'GrillaPagos
        '
        Me.GrillaPagos.AllowUserToAddRows = False
        Me.GrillaPagos.AllowUserToDeleteRows = False
        Me.GrillaPagos.BackgroundColor = System.Drawing.Color.White
        Me.GrillaPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numdocpago, Me.cliente, Me.formapago, Me.fechavcto, Me.Valor, Me.pagos, Me.saldo, Me.IdCliente})
        Me.GrillaPagos.Location = New System.Drawing.Point(3, 189)
        Me.GrillaPagos.Name = "GrillaPagos"
        Me.GrillaPagos.ReadOnly = True
        Me.GrillaPagos.RowHeadersVisible = False
        Me.GrillaPagos.Size = New System.Drawing.Size(942, 564)
        Me.GrillaPagos.TabIndex = 103
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Image = Global.GestionVivero.My.Resources.Resources.Update
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(976, 270)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(159, 41)
        Me.Button5.TabIndex = 104
        Me.Button5.Text = "Documento a Depositar"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = False
        '
        'txtIdClienteDocumento
        '
        Me.txtIdClienteDocumento.Location = New System.Drawing.Point(1005, 210)
        Me.txtIdClienteDocumento.Name = "txtIdClienteDocumento"
        Me.txtIdClienteDocumento.Size = New System.Drawing.Size(100, 20)
        Me.txtIdClienteDocumento.TabIndex = 114
        Me.txtIdClienteDocumento.Visible = False
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(679, 12)
        Me.txtIdCliente.MaxLength = 12
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtIdCliente.TabIndex = 115
        Me.txtIdCliente.Visible = False
        '
        'Button3
        '
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.GestionVivero.My.Resources.Resources.buscar_40x40
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button3.Location = New System.Drawing.Point(591, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(49, 49)
        Me.Button3.TabIndex = 116
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Search
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(976, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 41)
        Me.Button1.TabIndex = 117
        Me.Button1.Text = "Buscar Documentos"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'chkPorNombre
        '
        Me.chkPorNombre.AutoSize = True
        Me.chkPorNombre.Location = New System.Drawing.Point(259, 13)
        Me.chkPorNombre.Name = "chkPorNombre"
        Me.chkPorNombre.Size = New System.Drawing.Size(15, 14)
        Me.chkPorNombre.TabIndex = 118
        Me.chkPorNombre.UseVisualStyleBackColor = True
        '
        'numdocpago
        '
        Me.numdocpago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.numdocpago.HeaderText = "N° Doc"
        Me.numdocpago.Name = "numdocpago"
        Me.numdocpago.ReadOnly = True
        Me.numdocpago.Width = 67
        '
        'cliente
        '
        Me.cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        '
        'formapago
        '
        Me.formapago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.formapago.HeaderText = "Forma Pago"
        Me.formapago.Name = "formapago"
        Me.formapago.ReadOnly = True
        Me.formapago.Width = 89
        '
        'fechavcto
        '
        Me.fechavcto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.fechavcto.HeaderText = "Fecha Venc"
        Me.fechavcto.Name = "fechavcto"
        Me.fechavcto.ReadOnly = True
        Me.fechavcto.Width = 90
        '
        'Valor
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Valor.DefaultCellStyle = DataGridViewCellStyle1
        Me.Valor.HeaderText = "Valor Documento"
        Me.Valor.Name = "Valor"
        Me.Valor.ReadOnly = True
        '
        'pagos
        '
        Me.pagos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.pagos.DefaultCellStyle = DataGridViewCellStyle2
        Me.pagos.FillWeight = 50.0!
        Me.pagos.HeaderText = "Valor Pagado"
        Me.pagos.Name = "pagos"
        Me.pagos.ReadOnly = True
        Me.pagos.Width = 96
        '
        'saldo
        '
        Me.saldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.saldo.DefaultCellStyle = DataGridViewCellStyle3
        Me.saldo.HeaderText = "Saldo Pendiente"
        Me.saldo.Name = "saldo"
        Me.saldo.ReadOnly = True
        Me.saldo.Width = 110
        '
        'IdCliente
        '
        Me.IdCliente.HeaderText = "IdCliente"
        Me.IdCliente.Name = "IdCliente"
        Me.IdCliente.ReadOnly = True
        Me.IdCliente.Visible = False
        '
        'DepositoDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1155, 765)
        Me.Controls.Add(Me.chkPorNombre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.txtIdClienteDocumento)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GrillaPagos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Chk_Fpago)
        Me.Controls.Add(Me.chk_Rut)
        Me.Controls.Add(Me.Chk_Fechas)
        Me.Controls.Add(Me.dtp_fecha2)
        Me.Controls.Add(Me.dtp_fecha1)
        Me.Controls.Add(Me.cmb_TIPO_PAGO)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_RutCliente)
        Me.Name = "DepositoDoc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Depósito Bancario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GrillaPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_RutCliente As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents cmb_TIPO_PAGO As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_fecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Chk_Fechas As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Rut As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Fpago As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GrillaPagos As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents txtIdClienteDocumento As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_FPago As MaskedTextBox
    Friend WithEvents cmb_Banco As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Glosa As TextBox
    Friend WithEvents txt_ValorDeposito As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumDocPago As MaskedTextBox
    Friend WithEvents dtp_FechaDeposito As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents chkPorNombre As CheckBox
    Friend WithEvents numdocpago As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents formapago As DataGridViewTextBoxColumn
    Friend WithEvents fechavcto As DataGridViewTextBoxColumn
    Friend WithEvents Valor As DataGridViewTextBoxColumn
    Friend WithEvents pagos As DataGridViewTextBoxColumn
    Friend WithEvents saldo As DataGridViewTextBoxColumn
    Friend WithEvents IdCliente As DataGridViewTextBoxColumn
End Class
