<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Analisis_Cuenta
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Cta_Ctble = New System.Windows.Forms.TextBox()
        Me.DataAnalisis = New System.Windows.Forms.DataGridView()
        Me.comp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecvcto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipodoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numdoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_Fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.dtp_Fecha2 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txt_SaldoCuenta = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_TotalHABERCTA = New System.Windows.Forms.MaskedTextBox()
        Me.txt_TotalDEBECTA = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_DescripCuenta = New System.Windows.Forms.TextBox()
        Me.txt_RutCliente = New System.Windows.Forms.TextBox()
        Me.txt_clientebuscar = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.rdbCliente = New System.Windows.Forms.RadioButton()
        Me.rdbProveedor = New System.Windows.Forms.RadioButton()
        Me.txtprovbuscar = New System.Windows.Forms.TextBox()
        Me.txtRutProv = New System.Windows.Forms.TextBox()
        Me.txtNombreProv = New System.Windows.Forms.TextBox()
        Me.chkFiltro = New System.Windows.Forms.CheckBox()
        Me.grpfiltro = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTN_BUSCAR = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSaldoPeriodo = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotalHaber = New System.Windows.Forms.MaskedTextBox()
        Me.txtTotalDebe = New System.Windows.Forms.MaskedTextBox()
        CType(Me.DataAnalisis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpfiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cuenta Contable"
        '
        'txt_Cta_Ctble
        '
        Me.txt_Cta_Ctble.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cta_Ctble.Location = New System.Drawing.Point(135, 8)
        Me.txt_Cta_Ctble.MaxLength = 7
        Me.txt_Cta_Ctble.Name = "txt_Cta_Ctble"
        Me.txt_Cta_Ctble.Size = New System.Drawing.Size(100, 21)
        Me.txt_Cta_Ctble.TabIndex = 1
        '
        'DataAnalisis
        '
        Me.DataAnalisis.AllowUserToAddRows = False
        Me.DataAnalisis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataAnalisis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataAnalisis.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataAnalisis.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataAnalisis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataAnalisis.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.comp, Me.fecha, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.saldo, Me.DataGridViewTextBoxColumn8, Me.fecvcto, Me.tipodoc, Me.numdoc, Me.DataGridViewTextBoxColumn9})
        Me.DataAnalisis.Location = New System.Drawing.Point(1, 223)
        Me.DataAnalisis.Name = "DataAnalisis"
        Me.DataAnalisis.ReadOnly = True
        Me.DataAnalisis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataAnalisis.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataAnalisis.RowTemplate.Height = 24
        Me.DataAnalisis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataAnalisis.Size = New System.Drawing.Size(1055, 295)
        Me.DataAnalisis.TabIndex = 31
        '
        'comp
        '
        Me.comp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.comp.HeaderText = "N° Comp"
        Me.comp.Name = "comp"
        Me.comp.ReadOnly = True
        Me.comp.Width = 74
        '
        'fecha
        '
        Me.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 62
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cta.Ctble."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 78
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.HeaderText = "Centro Costo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 93
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn4.HeaderText = "Debe"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 58
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.HeaderText = "Haber"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 61
        '
        'saldo
        '
        Me.saldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.saldo.DefaultCellStyle = DataGridViewCellStyle3
        Me.saldo.HeaderText = "Saldo"
        Me.saldo.Name = "saldo"
        Me.saldo.ReadOnly = True
        Me.saldo.Width = 59
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 69
        '
        'fecvcto
        '
        Me.fecvcto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.fecvcto.HeaderText = "Fecha Vcto."
        Me.fecvcto.Name = "fecvcto"
        Me.fecvcto.ReadOnly = True
        Me.fecvcto.Width = 90
        '
        'tipodoc
        '
        Me.tipodoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.tipodoc.HeaderText = "Tipo Doc."
        Me.tipodoc.Name = "tipodoc"
        Me.tipodoc.ReadOnly = True
        Me.tipodoc.Width = 79
        '
        'numdoc
        '
        Me.numdoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.numdoc.HeaderText = "N° Doc"
        Me.numdoc.Name = "numdoc"
        Me.numdoc.ReadOnly = True
        Me.numdoc.Width = 67
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.HeaderText = "Glosa"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 59
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Desde Fecha"
        '
        'dtp_Fecha1
        '
        Me.dtp_Fecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha1.Location = New System.Drawing.Point(108, 40)
        Me.dtp_Fecha1.Name = "dtp_Fecha1"
        Me.dtp_Fecha1.Size = New System.Drawing.Size(98, 20)
        Me.dtp_Fecha1.TabIndex = 33
        '
        'dtp_Fecha2
        '
        Me.dtp_Fecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha2.Location = New System.Drawing.Point(288, 40)
        Me.dtp_Fecha2.Name = "dtp_Fecha2"
        Me.dtp_Fecha2.Size = New System.Drawing.Size(98, 20)
        Me.dtp_Fecha2.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(214, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Hasta Fecha"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.GestionVivero.My.Resources.Resources.Close
        Me.Button3.Location = New System.Drawing.Point(986, 599)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(67, 47)
        Me.Button3.TabIndex = 36
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txt_SaldoCuenta
        '
        Me.txt_SaldoCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SaldoCuenta.Location = New System.Drawing.Point(811, 612)
        Me.txt_SaldoCuenta.Name = "txt_SaldoCuenta"
        Me.txt_SaldoCuenta.ReadOnly = True
        Me.txt_SaldoCuenta.Size = New System.Drawing.Size(147, 21)
        Me.txt_SaldoCuenta.TabIndex = 43
        Me.txt_SaldoCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(724, 615)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 15)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Saldo Final"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(501, 615)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 15)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Haber"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(292, 615)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 15)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Debe"
        '
        'txt_TotalHABERCTA
        '
        Me.txt_TotalHABERCTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalHABERCTA.Location = New System.Drawing.Point(555, 612)
        Me.txt_TotalHABERCTA.Name = "txt_TotalHABERCTA"
        Me.txt_TotalHABERCTA.ReadOnly = True
        Me.txt_TotalHABERCTA.Size = New System.Drawing.Size(147, 21)
        Me.txt_TotalHABERCTA.TabIndex = 39
        Me.txt_TotalHABERCTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_TotalDEBECTA
        '
        Me.txt_TotalDEBECTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalDEBECTA.Location = New System.Drawing.Point(336, 612)
        Me.txt_TotalDEBECTA.Name = "txt_TotalDEBECTA"
        Me.txt_TotalDEBECTA.ReadOnly = True
        Me.txt_TotalDEBECTA.Size = New System.Drawing.Size(147, 21)
        Me.txt_TotalDEBECTA.TabIndex = 38
        Me.txt_TotalDEBECTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 615)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(235, 15)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "TOTALES ACUMULADOS DEL AÑO ====>"
        '
        'txt_DescripCuenta
        '
        Me.txt_DescripCuenta.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DescripCuenta.Location = New System.Drawing.Point(366, 8)
        Me.txt_DescripCuenta.MaxLength = 7
        Me.txt_DescripCuenta.Name = "txt_DescripCuenta"
        Me.txt_DescripCuenta.ReadOnly = True
        Me.txt_DescripCuenta.Size = New System.Drawing.Size(319, 21)
        Me.txt_DescripCuenta.TabIndex = 44
        '
        'txt_RutCliente
        '
        Me.txt_RutCliente.Location = New System.Drawing.Point(265, 17)
        Me.txt_RutCliente.Name = "txt_RutCliente"
        Me.txt_RutCliente.ReadOnly = True
        Me.txt_RutCliente.Size = New System.Drawing.Size(99, 20)
        Me.txt_RutCliente.TabIndex = 47
        '
        'txt_clientebuscar
        '
        Me.txt_clientebuscar.Location = New System.Drawing.Point(110, 17)
        Me.txt_clientebuscar.Name = "txt_clientebuscar"
        Me.txt_clientebuscar.Size = New System.Drawing.Size(119, 20)
        Me.txt_clientebuscar.TabIndex = 77
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(110, 70)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 23)
        Me.Button4.TabIndex = 78
        Me.Button4.Text = "Limpiar campos"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(390, 17)
        Me.txtCliente.MaxLength = 7
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(319, 21)
        Me.txtCliente.TabIndex = 81
        '
        'rdbCliente
        '
        Me.rdbCliente.AutoSize = True
        Me.rdbCliente.Checked = True
        Me.rdbCliente.Location = New System.Drawing.Point(18, 19)
        Me.rdbCliente.Name = "rdbCliente"
        Me.rdbCliente.Size = New System.Drawing.Size(57, 17)
        Me.rdbCliente.TabIndex = 83
        Me.rdbCliente.TabStop = True
        Me.rdbCliente.Text = "Cliente"
        Me.rdbCliente.UseVisualStyleBackColor = True
        '
        'rdbProveedor
        '
        Me.rdbProveedor.AutoSize = True
        Me.rdbProveedor.Location = New System.Drawing.Point(18, 46)
        Me.rdbProveedor.Name = "rdbProveedor"
        Me.rdbProveedor.Size = New System.Drawing.Size(74, 17)
        Me.rdbProveedor.TabIndex = 84
        Me.rdbProveedor.Text = "Proveedor"
        Me.rdbProveedor.UseVisualStyleBackColor = True
        '
        'txtprovbuscar
        '
        Me.txtprovbuscar.Location = New System.Drawing.Point(110, 44)
        Me.txtprovbuscar.Name = "txtprovbuscar"
        Me.txtprovbuscar.Size = New System.Drawing.Size(119, 20)
        Me.txtprovbuscar.TabIndex = 85
        '
        'txtRutProv
        '
        Me.txtRutProv.Location = New System.Drawing.Point(263, 44)
        Me.txtRutProv.Name = "txtRutProv"
        Me.txtRutProv.ReadOnly = True
        Me.txtRutProv.Size = New System.Drawing.Size(99, 20)
        Me.txtRutProv.TabIndex = 87
        '
        'txtNombreProv
        '
        Me.txtNombreProv.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreProv.Location = New System.Drawing.Point(391, 44)
        Me.txtNombreProv.MaxLength = 7
        Me.txtNombreProv.Name = "txtNombreProv"
        Me.txtNombreProv.ReadOnly = True
        Me.txtNombreProv.Size = New System.Drawing.Size(319, 21)
        Me.txtNombreProv.TabIndex = 88
        '
        'chkFiltro
        '
        Me.chkFiltro.AutoSize = True
        Me.chkFiltro.Location = New System.Drawing.Point(17, 74)
        Me.chkFiltro.Name = "chkFiltro"
        Me.chkFiltro.Size = New System.Drawing.Size(162, 17)
        Me.chkFiltro.TabIndex = 89
        Me.chkFiltro.Text = "Filtro por Cliente o Proveedor"
        Me.chkFiltro.UseVisualStyleBackColor = True
        '
        'grpfiltro
        '
        Me.grpfiltro.Controls.Add(Me.rdbCliente)
        Me.grpfiltro.Controls.Add(Me.txt_RutCliente)
        Me.grpfiltro.Controls.Add(Me.txtNombreProv)
        Me.grpfiltro.Controls.Add(Me.Button2)
        Me.grpfiltro.Controls.Add(Me.txtRutProv)
        Me.grpfiltro.Controls.Add(Me.txt_clientebuscar)
        Me.grpfiltro.Controls.Add(Me.Button5)
        Me.grpfiltro.Controls.Add(Me.Button4)
        Me.grpfiltro.Controls.Add(Me.txtprovbuscar)
        Me.grpfiltro.Controls.Add(Me.txtCliente)
        Me.grpfiltro.Controls.Add(Me.rdbProveedor)
        Me.grpfiltro.Enabled = False
        Me.grpfiltro.Location = New System.Drawing.Point(17, 103)
        Me.grpfiltro.Name = "grpfiltro"
        Me.grpfiltro.Size = New System.Drawing.Size(717, 100)
        Me.grpfiltro.TabIndex = 90
        Me.grpfiltro.TabStop = False
        Me.grpfiltro.Text = "Filtro Cliente o Proveedor"
        '
        'Button2
        '
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.PREVIEW
        Me.Button2.Location = New System.Drawing.Point(231, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(26, 23)
        Me.Button2.TabIndex = 48
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = Global.GestionVivero.My.Resources.Resources.PREVIEW
        Me.Button5.Location = New System.Drawing.Point(231, 43)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(26, 23)
        Me.Button5.TabIndex = 86
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnReporte
        '
        Me.btnReporte.Enabled = False
        Me.btnReporte.Image = Global.GestionVivero.My.Resources.Resources._34138065_papel_de_la_factura_con_la_informacion_financiera_icono_plana_moderno_estilo_de_diseno_de_ilustracio
        Me.btnReporte.Location = New System.Drawing.Point(986, 126)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(70, 70)
        Me.btnReporte.TabIndex = 82
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(916, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 39)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Ejecuta Consulta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BTN_BUSCAR
        '
        Me.BTN_BUSCAR.Image = Global.GestionVivero.My.Resources.Resources.PREVIEW
        Me.BTN_BUSCAR.Location = New System.Drawing.Point(238, 6)
        Me.BTN_BUSCAR.Name = "BTN_BUSCAR"
        Me.BTN_BUSCAR.Size = New System.Drawing.Size(27, 25)
        Me.BTN_BUSCAR.TabIndex = 30
        Me.BTN_BUSCAR.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = Global.GestionVivero.My.Resources.Resources.Notes
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(766, 18)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(144, 39)
        Me.Button6.TabIndex = 93
        Me.Button6.Text = "Limpia campos"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 542)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 15)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "TOTALES PERIODO ====>"
        '
        'txtSaldoPeriodo
        '
        Me.txtSaldoPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoPeriodo.Location = New System.Drawing.Point(811, 542)
        Me.txtSaldoPeriodo.Name = "txtSaldoPeriodo"
        Me.txtSaldoPeriodo.ReadOnly = True
        Me.txtSaldoPeriodo.Size = New System.Drawing.Size(147, 21)
        Me.txtSaldoPeriodo.TabIndex = 100
        Me.txtSaldoPeriodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(724, 545)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 15)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "Saldo Final"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(501, 545)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 15)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "Haber"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(292, 545)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 15)
        Me.Label11.TabIndex = 97
        Me.Label11.Text = "Debe"
        '
        'txtTotalHaber
        '
        Me.txtTotalHaber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalHaber.Location = New System.Drawing.Point(555, 542)
        Me.txtTotalHaber.Name = "txtTotalHaber"
        Me.txtTotalHaber.ReadOnly = True
        Me.txtTotalHaber.Size = New System.Drawing.Size(147, 21)
        Me.txtTotalHaber.TabIndex = 96
        Me.txtTotalHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalDebe
        '
        Me.txtTotalDebe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDebe.Location = New System.Drawing.Point(336, 542)
        Me.txtTotalDebe.Name = "txtTotalDebe"
        Me.txtTotalDebe.ReadOnly = True
        Me.txtTotalDebe.Size = New System.Drawing.Size(147, 21)
        Me.txtTotalDebe.TabIndex = 95
        Me.txtTotalDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Analisis_Cuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 651)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtSaldoPeriodo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtTotalHaber)
        Me.Controls.Add(Me.txtTotalDebe)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.grpfiltro)
        Me.Controls.Add(Me.chkFiltro)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_DescripCuenta)
        Me.Controls.Add(Me.txt_SaldoCuenta)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_TotalHABERCTA)
        Me.Controls.Add(Me.txt_TotalDEBECTA)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtp_Fecha2)
        Me.Controls.Add(Me.dtp_Fecha1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataAnalisis)
        Me.Controls.Add(Me.BTN_BUSCAR)
        Me.Controls.Add(Me.txt_Cta_Ctble)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MinimizeBox = False
        Me.Name = "Analisis_Cuenta"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anàlisis Cuenta Contable"
        CType(Me.DataAnalisis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpfiltro.ResumeLayout(False)
        Me.grpfiltro.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Cta_Ctble As System.Windows.Forms.TextBox
    Friend WithEvents BTN_BUSCAR As System.Windows.Forms.Button
    Friend WithEvents DataAnalisis As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtp_Fecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Fecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txt_SaldoCuenta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_TotalHABERCTA As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_TotalDEBECTA As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_DescripCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_RutCliente As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents comp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents saldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecvcto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipodoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numdoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_clientebuscar As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents btnReporte As System.Windows.Forms.Button
    Friend WithEvents rdbCliente As System.Windows.Forms.RadioButton
    Friend WithEvents rdbProveedor As System.Windows.Forms.RadioButton
    Friend WithEvents txtprovbuscar As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txtRutProv As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreProv As System.Windows.Forms.TextBox
    Friend WithEvents chkFiltro As System.Windows.Forms.CheckBox
    Friend WithEvents grpfiltro As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSaldoPeriodo As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTotalHaber As MaskedTextBox
    Friend WithEvents txtTotalDebe As MaskedTextBox
End Class
