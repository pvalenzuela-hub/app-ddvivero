<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Devolucion_Bandejas
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtp_FechaDevol = New System.Windows.Forms.DateTimePicker()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txt_NuevaBandDevol = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txt_clientebuscar = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkCliente = New System.Windows.Forms.CheckBox()
        Me.txt_IdCliente = New System.Windows.Forms.TextBox()
        Me.chk_Todo = New System.Windows.Forms.CheckBox()
        Me.cmb_TipoBandeja = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Cliente = New System.Windows.Forms.TextBox()
        Me.txt_TotalBandPendientes = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DataGuia = New System.Windows.Forms.DataGridView()
        Me.NumLote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loteoriginal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecEnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Semilla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Variedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantpedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipob = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_TotalDevueltas = New System.Windows.Forms.TextBox()
        Me.btnEmiteGuia = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotBandRet = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGuia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtp_FechaDevol)
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Controls.Add(Me.txt_NuevaBandDevol)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 146)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1020, 83)
        Me.GroupBox2.TabIndex = 64
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Devolución de Bandejas"
        '
        'dtp_FechaDevol
        '
        Me.dtp_FechaDevol.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaDevol.Location = New System.Drawing.Point(414, 28)
        Me.dtp_FechaDevol.Name = "dtp_FechaDevol"
        Me.dtp_FechaDevol.Size = New System.Drawing.Size(96, 20)
        Me.dtp_FechaDevol.TabIndex = 89
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(709, 24)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(106, 30)
        Me.btnAgregar.TabIndex = 67
        Me.btnAgregar.Text = "Carga cantidades"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txt_NuevaBandDevol
        '
        Me.txt_NuevaBandDevol.BackColor = System.Drawing.Color.Azure
        Me.txt_NuevaBandDevol.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NuevaBandDevol.ForeColor = System.Drawing.Color.Navy
        Me.txt_NuevaBandDevol.HidePromptOnLeave = True
        Me.txt_NuevaBandDevol.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_NuevaBandDevol.Location = New System.Drawing.Point(653, 27)
        Me.txt_NuevaBandDevol.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_NuevaBandDevol.Name = "txt_NuevaBandDevol"
        Me.txt_NuevaBandDevol.Size = New System.Drawing.Size(50, 22)
        Me.txt_NuevaBandDevol.TabIndex = 66
        Me.txt_NuevaBandDevol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_NuevaBandDevol.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(541, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 13)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "Bandejas a Devolver"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(316, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 13)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "Fecha Devolución"
        '
        'Button1
        '
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(925, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 33)
        Me.Button1.TabIndex = 65
        Me.Button1.Text = "Grabar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.Close
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(925, 47)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 33)
        Me.Button2.TabIndex = 66
        Me.Button2.Text = "Cerrar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.GestionVivero.My.Resources.Resources.Search
        Me.Button4.Location = New System.Drawing.Point(149, 23)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(40, 30)
        Me.Button4.TabIndex = 72
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 14)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(121, 13)
        Me.Label27.TabIndex = 70
        Me.Label27.Text = "Ingrese Cliente a buscar"
        '
        'txt_clientebuscar
        '
        Me.txt_clientebuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_clientebuscar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clientebuscar.ForeColor = System.Drawing.Color.White
        Me.txt_clientebuscar.Location = New System.Drawing.Point(9, 28)
        Me.txt_clientebuscar.Name = "txt_clientebuscar"
        Me.txt_clientebuscar.Size = New System.Drawing.Size(138, 21)
        Me.txt_clientebuscar.TabIndex = 69
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkCliente)
        Me.GroupBox3.Controls.Add(Me.txt_IdCliente)
        Me.GroupBox3.Controls.Add(Me.chk_Todo)
        Me.GroupBox3.Controls.Add(Me.cmb_TipoBandeja)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txt_Cliente)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.txt_clientebuscar)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(916, 95)
        Me.GroupBox3.TabIndex = 73
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Identificación Cliente"
        '
        'chkCliente
        '
        Me.chkCliente.AutoSize = True
        Me.chkCliente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCliente.Location = New System.Drawing.Point(9, 55)
        Me.chkCliente.Name = "chkCliente"
        Me.chkCliente.Size = New System.Drawing.Size(132, 18)
        Me.chkCliente.TabIndex = 110
        Me.chkCliente.Text = "incluye primer nombre"
        Me.chkCliente.UseVisualStyleBackColor = True
        '
        'txt_IdCliente
        '
        Me.txt_IdCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_IdCliente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IdCliente.ForeColor = System.Drawing.Color.White
        Me.txt_IdCliente.Location = New System.Drawing.Point(784, 28)
        Me.txt_IdCliente.Name = "txt_IdCliente"
        Me.txt_IdCliente.ReadOnly = True
        Me.txt_IdCliente.Size = New System.Drawing.Size(48, 21)
        Me.txt_IdCliente.TabIndex = 95
        '
        'chk_Todo
        '
        Me.chk_Todo.AutoSize = True
        Me.chk_Todo.Location = New System.Drawing.Point(728, 61)
        Me.chk_Todo.Name = "chk_Todo"
        Me.chk_Todo.Size = New System.Drawing.Size(104, 17)
        Me.chk_Todo.TabIndex = 94
        Me.chk_Todo.Text = "Todas las Guías"
        Me.chk_Todo.UseVisualStyleBackColor = True
        '
        'cmb_TipoBandeja
        '
        Me.cmb_TipoBandeja.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_TipoBandeja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoBandeja.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_TipoBandeja.FormattingEnabled = True
        Me.cmb_TipoBandeja.Location = New System.Drawing.Point(350, 55)
        Me.cmb_TipoBandeja.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmb_TipoBandeja.Name = "cmb_TipoBandeja"
        Me.cmb_TipoBandeja.Size = New System.Drawing.Size(130, 24)
        Me.cmb_TipoBandeja.TabIndex = 92
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(269, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Tipo Bandeja"
        '
        'txt_Cliente
        '
        Me.txt_Cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_Cliente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cliente.ForeColor = System.Drawing.Color.White
        Me.txt_Cliente.Location = New System.Drawing.Point(191, 28)
        Me.txt_Cliente.Name = "txt_Cliente"
        Me.txt_Cliente.ReadOnly = True
        Me.txt_Cliente.Size = New System.Drawing.Size(587, 21)
        Me.txt_Cliente.TabIndex = 92
        '
        'txt_TotalBandPendientes
        '
        Me.txt_TotalBandPendientes.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_TotalBandPendientes.CausesValidation = False
        Me.txt_TotalBandPendientes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalBandPendientes.ForeColor = System.Drawing.Color.White
        Me.txt_TotalBandPendientes.Location = New System.Drawing.Point(802, 114)
        Me.txt_TotalBandPendientes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_TotalBandPendientes.Name = "txt_TotalBandPendientes"
        Me.txt_TotalBandPendientes.ReadOnly = True
        Me.txt_TotalBandPendientes.Size = New System.Drawing.Size(50, 22)
        Me.txt_TotalBandPendientes.TabIndex = 84
        Me.txt_TotalBandPendientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(662, 119)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(137, 13)
        Me.Label12.TabIndex = 84
        Me.Label12.Text = "Total Bandejas Pendientes:"
        '
        'DataGuia
        '
        Me.DataGuia.AllowUserToAddRows = False
        Me.DataGuia.AllowUserToDeleteRows = False
        Me.DataGuia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGuia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGuia.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGuia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGuia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumLote, Me.loteoriginal, Me.NumPedido, Me.FechaPedido, Me.FechaInicio, Me.FecEnt, Me.Semilla, Me.Variedad, Me.Cantpedido, Me.tipob, Me.Tipo, Me.Column1})
        Me.DataGuia.Location = New System.Drawing.Point(5, 235)
        Me.DataGuia.Name = "DataGuia"
        Me.DataGuia.ReadOnly = True
        Me.DataGuia.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataGuia.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGuia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGuia.Size = New System.Drawing.Size(1021, 405)
        Me.DataGuia.TabIndex = 85
        '
        'NumLote
        '
        Me.NumLote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumLote.HeaderText = "N° Guía"
        Me.NumLote.Name = "NumLote"
        Me.NumLote.ReadOnly = True
        Me.NumLote.Width = 66
        '
        'loteoriginal
        '
        Me.loteoriginal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.loteoriginal.HeaderText = "Fecha"
        Me.loteoriginal.Name = "loteoriginal"
        Me.loteoriginal.ReadOnly = True
        Me.loteoriginal.Width = 62
        '
        'NumPedido
        '
        Me.NumPedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumPedido.HeaderText = "N° Lote"
        Me.NumPedido.Name = "NumPedido"
        Me.NumPedido.ReadOnly = True
        Me.NumPedido.Width = 63
        '
        'FechaPedido
        '
        Me.FechaPedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.FechaPedido.DefaultCellStyle = DataGridViewCellStyle1
        Me.FechaPedido.HeaderText = "Plantas"
        Me.FechaPedido.Name = "FechaPedido"
        Me.FechaPedido.ReadOnly = True
        Me.FechaPedido.Width = 67
        '
        'FechaInicio
        '
        Me.FechaInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.FechaInicio.DefaultCellStyle = DataGridViewCellStyle2
        Me.FechaInicio.HeaderText = "B.Retiradas"
        Me.FechaInicio.Name = "FechaInicio"
        Me.FechaInicio.ReadOnly = True
        Me.FechaInicio.Width = 87
        '
        'FecEnt
        '
        Me.FecEnt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.FecEnt.DefaultCellStyle = DataGridViewCellStyle3
        Me.FecEnt.HeaderText = "B.Devueltas"
        Me.FecEnt.Name = "FecEnt"
        Me.FecEnt.ReadOnly = True
        Me.FecEnt.Width = 90
        '
        'Semilla
        '
        Me.Semilla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Semilla.HeaderText = "F.Devolución"
        Me.Semilla.Name = "Semilla"
        Me.Semilla.ReadOnly = True
        Me.Semilla.Width = 95
        '
        'Variedad
        '
        Me.Variedad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Variedad.HeaderText = "Especie"
        Me.Variedad.Name = "Variedad"
        Me.Variedad.ReadOnly = True
        Me.Variedad.Width = 70
        '
        'Cantpedido
        '
        Me.Cantpedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Cantpedido.HeaderText = "Variedad"
        Me.Cantpedido.Name = "Cantpedido"
        Me.Cantpedido.ReadOnly = True
        Me.Cantpedido.Width = 74
        '
        'tipob
        '
        Me.tipob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.tipob.HeaderText = "Tipo"
        Me.tipob.Name = "tipob"
        Me.tipob.ReadOnly = True
        Me.tipob.Width = 53
        '
        'Tipo
        '
        Me.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Tipo.DefaultCellStyle = DataGridViewCellStyle4
        Me.Tipo.HeaderText = "Saldo Bandejas"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 97
        '
        'Column1
        '
        Me.Column1.HeaderText = "Bandejas"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 76
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(362, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 13)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Total Bandejas Devueltas:"
        '
        'txt_TotalDevueltas
        '
        Me.txt_TotalDevueltas.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_TotalDevueltas.CausesValidation = False
        Me.txt_TotalDevueltas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalDevueltas.ForeColor = System.Drawing.Color.White
        Me.txt_TotalDevueltas.Location = New System.Drawing.Point(495, 114)
        Me.txt_TotalDevueltas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_TotalDevueltas.Name = "txt_TotalDevueltas"
        Me.txt_TotalDevueltas.ReadOnly = True
        Me.txt_TotalDevueltas.Size = New System.Drawing.Size(50, 22)
        Me.txt_TotalDevueltas.TabIndex = 87
        Me.txt_TotalDevueltas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnEmiteGuia
        '
        Me.btnEmiteGuia.Image = Global.GestionVivero.My.Resources.Resources.page_productos_at_item3
        Me.btnEmiteGuia.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEmiteGuia.Location = New System.Drawing.Point(928, 12)
        Me.btnEmiteGuia.Name = "btnEmiteGuia"
        Me.btnEmiteGuia.Size = New System.Drawing.Size(98, 113)
        Me.btnEmiteGuia.TabIndex = 92
        Me.btnEmiteGuia.Text = "Recupera Guías"
        Me.btnEmiteGuia.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEmiteGuia.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(114, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 13)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Total Bandejas Retiradas:"
        '
        'txtTotBandRet
        '
        Me.txtTotBandRet.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtTotBandRet.CausesValidation = False
        Me.txtTotBandRet.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotBandRet.ForeColor = System.Drawing.Color.White
        Me.txtTotBandRet.Location = New System.Drawing.Point(243, 114)
        Me.txtTotBandRet.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotBandRet.Name = "txtTotBandRet"
        Me.txtTotBandRet.ReadOnly = True
        Me.txtTotBandRet.Size = New System.Drawing.Size(50, 22)
        Me.txtTotBandRet.TabIndex = 94
        Me.txtTotBandRet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Devolucion_Bandejas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 643)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtTotBandRet)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnEmiteGuia)
        Me.Controls.Add(Me.txt_TotalDevueltas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGuia)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_TotalBandPendientes)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Devolucion_Bandejas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Devolución de Bandejas por Guías"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGuia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents txt_NuevaBandDevol As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txt_clientebuscar As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_TotalBandPendientes As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DataGuia As System.Windows.Forms.DataGridView
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_TotalDevueltas As System.Windows.Forms.TextBox
    Friend WithEvents dtp_FechaDevol As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_Cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoBandeja As System.Windows.Forms.ComboBox
    Friend WithEvents chk_Todo As System.Windows.Forms.CheckBox
    Friend WithEvents txt_IdCliente As System.Windows.Forms.TextBox
    Friend WithEvents btnEmiteGuia As System.Windows.Forms.Button
    Friend WithEvents NumLote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents loteoriginal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumPedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaPedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FecEnt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Semilla As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Variedad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantpedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipob As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotBandRet As System.Windows.Forms.TextBox
    Friend WithEvents chkCliente As CheckBox
End Class
