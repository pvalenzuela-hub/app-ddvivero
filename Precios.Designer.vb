<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Precios
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GrillaPrecios = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoband = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Semilla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.oto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechahasta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioespecial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Precio_PRI = New System.Windows.Forms.TextBox()
        Me.txt_Precio_OTO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_TipoBandeja = New System.Windows.Forms.ComboBox()
        Me.cmb_Familia = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_PrecioVenta_INV = New System.Windows.Forms.TextBox()
        Me.txt_precioespecial = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_PrecioVenta_VER = New System.Windows.Forms.TextBox()
        Me.txt_IDPrecio = New System.Windows.Forms.MaskedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GrillaHechura = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hasta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ppublico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.margp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GrillaPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GrillaHechura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrillaPrecios
        '
        Me.GrillaPrecios.AllowUserToAddRows = False
        Me.GrillaPrecios.AllowUserToDeleteRows = False
        Me.GrillaPrecios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.GrillaPrecios.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.GrillaPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GrillaPrecios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.tipoband, Me.Semilla, Me.pri, Me.Precio, Me.oto, Me.fechahasta, Me.precioespecial})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrillaPrecios.DefaultCellStyle = DataGridViewCellStyle4
        Me.GrillaPrecios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GrillaPrecios.Location = New System.Drawing.Point(6, 22)
        Me.GrillaPrecios.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GrillaPrecios.Name = "GrillaPrecios"
        Me.GrillaPrecios.ReadOnly = True
        Me.GrillaPrecios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.GrillaPrecios.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.GrillaPrecios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GrillaPrecios.Size = New System.Drawing.Size(852, 193)
        Me.GrillaPrecios.TabIndex = 64
        '
        'Id
        '
        Me.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 42
        '
        'tipoband
        '
        Me.tipoband.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.tipoband.HeaderText = "Tipo"
        Me.tipoband.Name = "tipoband"
        Me.tipoband.ReadOnly = True
        Me.tipoband.Width = 56
        '
        'Semilla
        '
        Me.Semilla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Semilla.HeaderText = "Semilla"
        Me.Semilla.Name = "Semilla"
        Me.Semilla.ReadOnly = True
        '
        'pri
        '
        Me.pri.HeaderText = "Precio Primavera"
        Me.pri.Name = "pri"
        Me.pri.ReadOnly = True
        Me.pri.Width = 126
        '
        'Precio
        '
        Me.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle1
        Me.Precio.HeaderText = "Precio Verano"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 108
        '
        'oto
        '
        Me.oto.HeaderText = "Precio Otoño"
        Me.oto.Name = "oto"
        Me.oto.ReadOnly = True
        Me.oto.Width = 103
        '
        'fechahasta
        '
        Me.fechahasta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.fechahasta.DefaultCellStyle = DataGridViewCellStyle2
        Me.fechahasta.HeaderText = "Precio Invierno"
        Me.fechahasta.Name = "fechahasta"
        Me.fechahasta.ReadOnly = True
        Me.fechahasta.Width = 113
        '
        'precioespecial
        '
        Me.precioespecial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.precioespecial.DefaultCellStyle = DataGridViewCellStyle3
        Me.precioespecial.HeaderText = "Precio Especial"
        Me.precioespecial.Name = "precioespecial"
        Me.precioespecial.ReadOnly = True
        Me.precioespecial.Width = 118
        '
        'btn_actualizar
        '
        Me.btn_actualizar.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_actualizar.Location = New System.Drawing.Point(777, 53)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(89, 50)
        Me.btn_actualizar.TabIndex = 77
        Me.btn_actualizar.Text = "Actualiza Precio"
        Me.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_actualizar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GrillaPrecios)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 283)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(864, 223)
        Me.GroupBox1.TabIndex = 91
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Precios"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(423, 512)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(122, 28)
        Me.Button4.TabIndex = 93
        Me.Button4.Text = "Eliminar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(223, 512)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 28)
        Me.Button3.TabIndex = 92
        Me.Button3.Text = "Modificar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(632, 512)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 28)
        Me.Button2.TabIndex = 94
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_Precio_PRI)
        Me.GroupBox2.Controls.Add(Me.txt_Precio_OTO)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmb_TipoBandeja)
        Me.GroupBox2.Controls.Add(Me.cmb_Familia)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_PrecioVenta_INV)
        Me.GroupBox2.Controls.Add(Me.txt_precioespecial)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_PrecioVenta_VER)
        Me.GroupBox2.Controls.Add(Me.txt_IDPrecio)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(742, 122)
        Me.GroupBox2.TabIndex = 98
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Definición Precio de Hechura"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 14)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "Precio Primavera"
        '
        'txt_Precio_PRI
        '
        Me.txt_Precio_PRI.Location = New System.Drawing.Point(26, 94)
        Me.txt_Precio_PRI.Name = "txt_Precio_PRI"
        Me.txt_Precio_PRI.Size = New System.Drawing.Size(100, 20)
        Me.txt_Precio_PRI.TabIndex = 110
        '
        'txt_Precio_OTO
        '
        Me.txt_Precio_OTO.Location = New System.Drawing.Point(302, 94)
        Me.txt_Precio_OTO.Name = "txt_Precio_OTO"
        Me.txt_Precio_OTO.Size = New System.Drawing.Size(100, 20)
        Me.txt_Precio_OTO.TabIndex = 109
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(315, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 14)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Precio Otoño"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(326, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Semilla"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 15)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Tipo de Bandeja"
        '
        'cmb_TipoBandeja
        '
        Me.cmb_TipoBandeja.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_TipoBandeja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoBandeja.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_TipoBandeja.ForeColor = System.Drawing.Color.Navy
        Me.cmb_TipoBandeja.FormattingEnabled = True
        Me.cmb_TipoBandeja.Location = New System.Drawing.Point(76, 45)
        Me.cmb_TipoBandeja.Name = "cmb_TipoBandeja"
        Me.cmb_TipoBandeja.Size = New System.Drawing.Size(242, 23)
        Me.cmb_TipoBandeja.TabIndex = 105
        '
        'cmb_Familia
        '
        Me.cmb_Familia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Familia.FormattingEnabled = True
        Me.cmb_Familia.Location = New System.Drawing.Point(324, 45)
        Me.cmb_Familia.Name = "cmb_Familia"
        Me.cmb_Familia.Size = New System.Drawing.Size(304, 22)
        Me.cmb_Familia.TabIndex = 104
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(461, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 14)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Precio Invierno"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(610, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 14)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Precio Especial"
        '
        'txt_PrecioVenta_INV
        '
        Me.txt_PrecioVenta_INV.Location = New System.Drawing.Point(450, 94)
        Me.txt_PrecioVenta_INV.Name = "txt_PrecioVenta_INV"
        Me.txt_PrecioVenta_INV.Size = New System.Drawing.Size(100, 20)
        Me.txt_PrecioVenta_INV.TabIndex = 102
        '
        'txt_precioespecial
        '
        Me.txt_precioespecial.Location = New System.Drawing.Point(603, 94)
        Me.txt_precioespecial.Name = "txt_precioespecial"
        Me.txt_precioespecial.Size = New System.Drawing.Size(100, 20)
        Me.txt_precioespecial.TabIndex = 100
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(171, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 14)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "Precio Verano"
        '
        'txt_PrecioVenta_VER
        '
        Me.txt_PrecioVenta_VER.Location = New System.Drawing.Point(160, 94)
        Me.txt_PrecioVenta_VER.Name = "txt_PrecioVenta_VER"
        Me.txt_PrecioVenta_VER.Size = New System.Drawing.Size(100, 20)
        Me.txt_PrecioVenta_VER.TabIndex = 98
        '
        'txt_IDPrecio
        '
        Me.txt_IDPrecio.HidePromptOnLeave = True
        Me.txt_IDPrecio.Location = New System.Drawing.Point(9, 20)
        Me.txt_IDPrecio.Name = "txt_IDPrecio"
        Me.txt_IDPrecio.ReadOnly = True
        Me.txt_IDPrecio.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_IDPrecio.Size = New System.Drawing.Size(53, 20)
        Me.txt_IDPrecio.TabIndex = 89
        Me.txt_IDPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 512)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 28)
        Me.Button1.TabIndex = 99
        Me.Button1.Text = "Nuevo Precio"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GrillaHechura
        '
        Me.GrillaHechura.AllowUserToAddRows = False
        Me.GrillaHechura.AllowUserToDeleteRows = False
        Me.GrillaHechura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.GrillaHechura.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.GrillaHechura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GrillaHechura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.desde, Me.DataGridViewTextBoxColumn3, Me.hasta, Me.ppublico, Me.margp})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrillaHechura.DefaultCellStyle = DataGridViewCellStyle11
        Me.GrillaHechura.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GrillaHechura.Location = New System.Drawing.Point(12, 146)
        Me.GrillaHechura.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GrillaHechura.Name = "GrillaHechura"
        Me.GrillaHechura.ReadOnly = True
        Me.GrillaHechura.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.GrillaHechura.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.GrillaHechura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GrillaHechura.Size = New System.Drawing.Size(854, 129)
        Me.GrillaHechura.TabIndex = 100
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tipo Bandeja"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'desde
        '
        Me.desde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.desde.DefaultCellStyle = DataGridViewCellStyle6
        Me.desde.HeaderText = "Precio Hechura"
        Me.desde.MinimumWidth = 100
        Me.desde.Name = "desde"
        Me.desde.ReadOnly = True
        Me.desde.Width = 117
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn3.HeaderText = "% Margen"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 87
        '
        'hasta
        '
        Me.hasta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.hasta.DefaultCellStyle = DataGridViewCellStyle8
        Me.hasta.HeaderText = "Precio Venta Neto"
        Me.hasta.Name = "hasta"
        Me.hasta.ReadOnly = True
        Me.hasta.Width = 129
        '
        'ppublico
        '
        Me.ppublico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ppublico.DefaultCellStyle = DataGridViewCellStyle9
        Me.ppublico.HeaderText = "Precio Publico"
        Me.ppublico.Name = "ppublico"
        Me.ppublico.ReadOnly = True
        Me.ppublico.Width = 111
        '
        'margp
        '
        Me.margp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.margp.DefaultCellStyle = DataGridViewCellStyle10
        Me.margp.HeaderText = "% Marg. real"
        Me.margp.Name = "margp"
        Me.margp.ReadOnly = True
        '
        'Precios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 552)
        Me.Controls.Add(Me.GrillaHechura)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_actualizar)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Precios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Precios de Hechuras"
        CType(Me.GrillaPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GrillaHechura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrillaPrecios As System.Windows.Forms.DataGridView
    Friend WithEvents btn_actualizar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_PrecioVenta_VER As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_precioespecial As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_PrecioVenta_INV As System.Windows.Forms.TextBox
    Friend WithEvents txt_IDPrecio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GrillaHechura As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_Familia As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoBandeja As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desde As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hasta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ppublico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents margp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_Precio_PRI As TextBox
    Friend WithEvents txt_Precio_OTO As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents tipoband As DataGridViewTextBoxColumn
    Friend WithEvents Semilla As DataGridViewTextBoxColumn
    Friend WithEvents pri As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents oto As DataGridViewTextBoxColumn
    Friend WithEvents fechahasta As DataGridViewTextBoxColumn
    Friend WithEvents precioespecial As DataGridViewTextBoxColumn
End Class
