<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aplic_Producto
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Aplic_Producto))
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmb_usuario = New System.Windows.Forms.ComboBox
        Me.cmb_Evento = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_NumNave = New System.Windows.Forms.TextBox
        Me.DataLote = New System.Windows.Forms.DataGridView
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Insumo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.marca = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.saldoplantas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataLoteFinal = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cant = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.coment = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.saldo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmb_Insumo = New System.Windows.Forms.ComboBox
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_CantidadTotal = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_Comentario = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtp_FechaAplic = New System.Windows.Forms.DateTimePicker
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.cmb_Unidad = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtp_HoraAplic = New System.Windows.Forms.DateTimePicker
        Me.DataLoteManual = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button7 = New System.Windows.Forms.Button
        Me.txt_NumFilas = New System.Windows.Forms.NumericUpDown
        Me.Button8 = New System.Windows.Forms.Button
        Me.rdb_PorLote = New System.Windows.Forms.RadioButton
        Me.rdb_PorNave = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        CType(Me.DataLote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLoteFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLoteManual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NumFilas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Ingresado por"
        '
        'cmb_usuario
        '
        Me.cmb_usuario.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_usuario.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_usuario.ForeColor = System.Drawing.Color.Navy
        Me.cmb_usuario.FormattingEnabled = True
        Me.cmb_usuario.Location = New System.Drawing.Point(33, 29)
        Me.cmb_usuario.Name = "cmb_usuario"
        Me.cmb_usuario.Size = New System.Drawing.Size(109, 23)
        Me.cmb_usuario.TabIndex = 105
        '
        'cmb_Evento
        '
        Me.cmb_Evento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Evento.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Evento.ForeColor = System.Drawing.Color.Navy
        Me.cmb_Evento.FormattingEnabled = True
        Me.cmb_Evento.Location = New System.Drawing.Point(148, 29)
        Me.cmb_Evento.Name = "cmb_Evento"
        Me.cmb_Evento.Size = New System.Drawing.Size(315, 23)
        Me.cmb_Evento.TabIndex = 106
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Evento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(97, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 15)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "N° Nave"
        '
        'txt_NumNave
        '
        Me.txt_NumNave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_NumNave.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NumNave.Location = New System.Drawing.Point(155, 13)
        Me.txt_NumNave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_NumNave.Name = "txt_NumNave"
        Me.txt_NumNave.Size = New System.Drawing.Size(71, 22)
        Me.txt_NumNave.TabIndex = 109
        Me.txt_NumNave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataLote
        '
        Me.DataLote.AllowUserToAddRows = False
        Me.DataLote.AllowUserToDeleteRows = False
        Me.DataLote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataLote.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Insumo, Me.marca, Me.saldoplantas})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataLote.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataLote.Location = New System.Drawing.Point(6, 38)
        Me.DataLote.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.DataLote.Name = "DataLote"
        Me.DataLote.RowHeadersVisible = False
        Me.DataLote.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataLote.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataLote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataLote.Size = New System.Drawing.Size(323, 123)
        Me.DataLote.TabIndex = 110
        '
        'Id
        '
        Me.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Id.HeaderText = "N° Lote"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 68
        '
        'Insumo
        '
        Me.Insumo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.Insumo.DefaultCellStyle = DataGridViewCellStyle1
        Me.Insumo.FillWeight = 200.0!
        Me.Insumo.HeaderText = "Ubicación"
        Me.Insumo.MinimumWidth = 100
        Me.Insumo.Name = "Insumo"
        Me.Insumo.ReadOnly = True
        '
        'marca
        '
        Me.marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.marca.HeaderText = "Marca"
        Me.marca.Name = "marca"
        Me.marca.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.marca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.marca.Width = 62
        '
        'saldoplantas
        '
        Me.saldoplantas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.saldoplantas.HeaderText = "Saldo Plantas"
        Me.saldoplantas.Name = "saldoplantas"
        Me.saldoplantas.Width = 97
        '
        'DataLoteFinal
        '
        Me.DataLoteFinal.AllowUserToAddRows = False
        Me.DataLoteFinal.AllowUserToDeleteRows = False
        Me.DataLoteFinal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataLoteFinal.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataLoteFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataLoteFinal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.cant, Me.coment, Me.saldo})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataLoteFinal.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataLoteFinal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataLoteFinal.Location = New System.Drawing.Point(3, 315)
        Me.DataLoteFinal.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.DataLoteFinal.Name = "DataLoteFinal"
        Me.DataLoteFinal.ReadOnly = True
        Me.DataLoteFinal.RowHeadersVisible = False
        Me.DataLoteFinal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataLoteFinal.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataLoteFinal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataLoteFinal.Size = New System.Drawing.Size(661, 174)
        Me.DataLoteFinal.TabIndex = 111
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "N° Lote"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 68
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn2.FillWeight = 200.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Ubicación"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'cant
        '
        Me.cant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.cant.HeaderText = "Cantidad"
        Me.cant.Name = "cant"
        Me.cant.ReadOnly = True
        Me.cant.Width = 74
        '
        'coment
        '
        Me.coment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.coment.HeaderText = "Comentario"
        Me.coment.Name = "coment"
        Me.coment.ReadOnly = True
        Me.coment.Width = 85
        '
        'saldo
        '
        Me.saldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.saldo.HeaderText = "Saldo Plantas"
        Me.saldo.Name = "saldo"
        Me.saldo.ReadOnly = True
        Me.saldo.Width = 97
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(476, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Producto"
        '
        'cmb_Insumo
        '
        Me.cmb_Insumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Insumo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Insumo.FormattingEnabled = True
        Me.cmb_Insumo.Location = New System.Drawing.Point(469, 29)
        Me.cmb_Insumo.Name = "cmb_Insumo"
        Me.cmb_Insumo.Size = New System.Drawing.Size(234, 23)
        Me.cmb_Insumo.TabIndex = 113
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = Global.GestionVivero.My.Resources.Resources.Delete
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnEliminar.Location = New System.Drawing.Point(670, 351)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(73, 48)
        Me.btnEliminar.TabIndex = 115
        Me.btnEliminar.Text = "Elimina Lote"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAgregar.Location = New System.Drawing.Point(168, 162)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(78, 38)
        Me.btnAgregar.TabIndex = 114
        Me.btnAgregar.Text = "Agregar Lote"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 501)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 15)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "Cantidad Total"
        '
        'txt_CantidadTotal
        '
        Me.txt_CantidadTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_CantidadTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CantidadTotal.Location = New System.Drawing.Point(194, 497)
        Me.txt_CantidadTotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_CantidadTotal.Name = "txt_CantidadTotal"
        Me.txt_CantidadTotal.Size = New System.Drawing.Size(71, 22)
        Me.txt_CantidadTotal.TabIndex = 117
        Me.txt_CantidadTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 15)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Comentario"
        '
        'txt_Comentario
        '
        Me.txt_Comentario.AcceptsReturn = True
        Me.txt_Comentario.AcceptsTab = True
        Me.txt_Comentario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_Comentario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Comentario.Location = New System.Drawing.Point(117, 263)
        Me.txt_Comentario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Comentario.MaxLength = 200
        Me.txt_Comentario.Multiline = True
        Me.txt_Comentario.Name = "txt_Comentario"
        Me.txt_Comentario.Size = New System.Drawing.Size(415, 47)
        Me.txt_Comentario.TabIndex = 119
        '
        'Button1
        '
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(846, 466)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 84)
        Me.Button1.TabIndex = 120
        Me.Button1.Text = "Guardar Aplicaciones"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(738, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 15)
        Me.Label7.TabIndex = 121
        Me.Label7.Text = "Fecha Aplicación"
        '
        'dtp_FechaAplic
        '
        Me.dtp_FechaAplic.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaAplic.Location = New System.Drawing.Point(743, 27)
        Me.dtp_FechaAplic.Name = "dtp_FechaAplic"
        Me.dtp_FechaAplic.Size = New System.Drawing.Size(96, 20)
        Me.dtp_FechaAplic.TabIndex = 122
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(431, 497)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 123
        Me.Button2.Text = "Distribuir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(232, 13)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 124
        Me.Button3.Text = "Buscar Lote"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(335, 74)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(66, 35)
        Me.Button4.TabIndex = 125
        Me.Button4.Text = "Marcar Todos"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(335, 116)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(66, 35)
        Me.Button5.TabIndex = 126
        Me.Button5.Text = "Desmarcar Todos"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(670, 406)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(73, 48)
        Me.Button6.TabIndex = 127
        Me.Button6.Text = "Limpiar Todo"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'cmb_Unidad
        '
        Me.cmb_Unidad.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_Unidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Unidad.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Unidad.ForeColor = System.Drawing.Color.Navy
        Me.cmb_Unidad.FormattingEnabled = True
        Me.cmb_Unidad.Location = New System.Drawing.Point(271, 497)
        Me.cmb_Unidad.Name = "cmb_Unidad"
        Me.cmb_Unidad.Size = New System.Drawing.Size(142, 23)
        Me.cmb_Unidad.TabIndex = 128
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(843, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 15)
        Me.Label8.TabIndex = 129
        Me.Label8.Text = "Hora Aplicación"
        '
        'dtp_HoraAplic
        '
        Me.dtp_HoraAplic.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_HoraAplic.Location = New System.Drawing.Point(861, 27)
        Me.dtp_HoraAplic.Name = "dtp_HoraAplic"
        Me.dtp_HoraAplic.Size = New System.Drawing.Size(74, 20)
        Me.dtp_HoraAplic.TabIndex = 130
        '
        'DataLoteManual
        '
        Me.DataLoteManual.AllowUserToAddRows = False
        Me.DataLoteManual.AllowUserToDeleteRows = False
        Me.DataLoteManual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataLoteManual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataLoteManual.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataLoteManual.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataLoteManual.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.DataLoteManual.Location = New System.Drawing.Point(19, 40)
        Me.DataLoteManual.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.DataLoteManual.Name = "DataLoteManual"
        Me.DataLoteManual.RowHeadersVisible = False
        Me.DataLoteManual.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataLoteManual.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataLoteManual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataLoteManual.Size = New System.Drawing.Size(111, 155)
        Me.DataLoteManual.TabIndex = 131
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn3.HeaderText = "N° Lote"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 68
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(136, 16)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(46, 23)
        Me.Button7.TabIndex = 132
        Me.Button7.Text = "+ filas"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'txt_NumFilas
        '
        Me.txt_NumFilas.Location = New System.Drawing.Point(19, 17)
        Me.txt_NumFilas.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.txt_NumFilas.Name = "txt_NumFilas"
        Me.txt_NumFilas.Size = New System.Drawing.Size(111, 20)
        Me.txt_NumFilas.TabIndex = 133
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button8.Location = New System.Drawing.Point(136, 90)
        Me.Button8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(78, 38)
        Me.Button8.TabIndex = 134
        Me.Button8.Text = "Agregar Lotes"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button8.UseVisualStyleBackColor = True
        '
        'rdb_PorLote
        '
        Me.rdb_PorLote.AutoSize = True
        Me.rdb_PorLote.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rdb_PorLote.Location = New System.Drawing.Point(551, 178)
        Me.rdb_PorLote.Name = "rdb_PorLote"
        Me.rdb_PorLote.Size = New System.Drawing.Size(71, 18)
        Me.rdb_PorLote.TabIndex = 135
        Me.rdb_PorLote.Text = "Por Lote"
        Me.rdb_PorLote.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.rdb_PorLote.UseVisualStyleBackColor = True
        '
        'rdb_PorNave
        '
        Me.rdb_PorNave.AutoSize = True
        Me.rdb_PorNave.Checked = True
        Me.rdb_PorNave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rdb_PorNave.Location = New System.Drawing.Point(36, 178)
        Me.rdb_PorNave.Name = "rdb_PorNave"
        Me.rdb_PorNave.Size = New System.Drawing.Size(76, 18)
        Me.rdb_PorNave.TabIndex = 136
        Me.rdb_PorNave.TabStop = True
        Me.rdb_PorNave.Text = "Por Nave"
        Me.rdb_PorNave.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.rdb_PorNave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataLoteManual)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.txt_NumFilas)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Location = New System.Drawing.Point(628, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 201)
        Me.GroupBox1.TabIndex = 137
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lotes"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataLote)
        Me.GroupBox2.Controls.Add(Me.txt_NumNave)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Location = New System.Drawing.Point(117, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(415, 201)
        Me.GroupBox2.TabIndex = 138
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lotes por Nave"
        '
        'Aplic_Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 562)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.rdb_PorNave)
        Me.Controls.Add(Me.rdb_PorLote)
        Me.Controls.Add(Me.txt_Comentario)
        Me.Controls.Add(Me.dtp_HoraAplic)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmb_Unidad)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dtp_FechaAplic)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_CantidadTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.cmb_Insumo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataLoteFinal)
        Me.Controls.Add(Me.cmb_Evento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_usuario)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Aplic_Producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicación de Producto"
        CType(Me.DataLote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLoteFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLoteManual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NumFilas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_usuario As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Evento As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_NumNave As System.Windows.Forms.TextBox
    Friend WithEvents DataLote As System.Windows.Forms.DataGridView
    Friend WithEvents DataLoteFinal As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_Insumo As System.Windows.Forms.ComboBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_CantidadTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Comentario As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaAplic As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Insumo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents marca As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents saldoplantas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmb_Unidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtp_HoraAplic As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents saldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataLoteManual As System.Windows.Forms.DataGridView
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents txt_NumFilas As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents rdb_PorLote As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_PorNave As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
