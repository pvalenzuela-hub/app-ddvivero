<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cartola_Cliente
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataCartola = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_DeudaTotal = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_TotalAbonos = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_CHxcobrar = New System.Windows.Forms.MaskedTextBox()
        Me.txt_LetrasxCobrar = New System.Windows.Forms.MaskedTextBox()
        Me.txt_docpendientes = New System.Windows.Forms.MaskedTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkCliente = New System.Windows.Forms.CheckBox()
        Me.txt_clientebuscar = New System.Windows.Forms.TextBox()
        Me.txt_RutCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirCartolaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.txt_RutDisplay = New System.Windows.Forms.TextBox()
        Me.txt_NombreDisplay = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtValorDAI = New System.Windows.Forms.MaskedTextBox()
        Me.emision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataCartola, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataCartola)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 206)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(917, 368)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle Ventas"
        '
        'DataCartola
        '
        Me.DataCartola.AllowUserToAddRows = False
        Me.DataCartola.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataCartola.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataCartola.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataCartola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataCartola.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.emision, Me.tipo, Me.doc, Me.total, Me.saldo})
        Me.DataCartola.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataCartola.Location = New System.Drawing.Point(3, 22)
        Me.DataCartola.Name = "DataCartola"
        Me.DataCartola.ReadOnly = True
        Me.DataCartola.RowHeadersVisible = False
        Me.DataCartola.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataCartola.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataCartola.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataCartola.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataCartola.Size = New System.Drawing.Size(911, 343)
        Me.DataCartola.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtValorDAI)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txt_DeudaTotal)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txt_TotalAbonos)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txt_CHxcobrar)
        Me.GroupBox4.Controls.Add(Me.txt_LetrasxCobrar)
        Me.GroupBox4.Controls.Add(Me.txt_docpendientes)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(15, 580)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(906, 111)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "SALDOS CARTOLA"
        '
        'txt_DeudaTotal
        '
        Me.txt_DeudaTotal.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DeudaTotal.HidePromptOnLeave = True
        Me.txt_DeudaTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_DeudaTotal.Location = New System.Drawing.Point(676, 70)
        Me.txt_DeudaTotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_DeudaTotal.Name = "txt_DeudaTotal"
        Me.txt_DeudaTotal.ReadOnly = True
        Me.txt_DeudaTotal.Size = New System.Drawing.Size(131, 26)
        Me.txt_DeudaTotal.TabIndex = 44
        Me.txt_DeudaTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_DeudaTotal.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(590, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 18)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Deuda Total"
        '
        'txt_TotalAbonos
        '
        Me.txt_TotalAbonos.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalAbonos.HidePromptOnLeave = True
        Me.txt_TotalAbonos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_TotalAbonos.Location = New System.Drawing.Point(118, 70)
        Me.txt_TotalAbonos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_TotalAbonos.Name = "txt_TotalAbonos"
        Me.txt_TotalAbonos.ReadOnly = True
        Me.txt_TotalAbonos.Size = New System.Drawing.Size(131, 26)
        Me.txt_TotalAbonos.TabIndex = 42
        Me.txt_TotalAbonos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_TotalAbonos.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 18)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Total Abonos"
        '
        'txt_CHxcobrar
        '
        Me.txt_CHxcobrar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CHxcobrar.HidePromptOnLeave = True
        Me.txt_CHxcobrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_CHxcobrar.Location = New System.Drawing.Point(401, 36)
        Me.txt_CHxcobrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_CHxcobrar.Name = "txt_CHxcobrar"
        Me.txt_CHxcobrar.ReadOnly = True
        Me.txt_CHxcobrar.Size = New System.Drawing.Size(131, 26)
        Me.txt_CHxcobrar.TabIndex = 40
        Me.txt_CHxcobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_CHxcobrar.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txt_LetrasxCobrar
        '
        Me.txt_LetrasxCobrar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LetrasxCobrar.HidePromptOnLeave = True
        Me.txt_LetrasxCobrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_LetrasxCobrar.Location = New System.Drawing.Point(401, 70)
        Me.txt_LetrasxCobrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_LetrasxCobrar.Name = "txt_LetrasxCobrar"
        Me.txt_LetrasxCobrar.ReadOnly = True
        Me.txt_LetrasxCobrar.Size = New System.Drawing.Size(131, 26)
        Me.txt_LetrasxCobrar.TabIndex = 34
        Me.txt_LetrasxCobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_LetrasxCobrar.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txt_docpendientes
        '
        Me.txt_docpendientes.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_docpendientes.HidePromptOnLeave = True
        Me.txt_docpendientes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_docpendientes.Location = New System.Drawing.Point(119, 36)
        Me.txt_docpendientes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_docpendientes.Name = "txt_docpendientes"
        Me.txt_docpendientes.ReadOnly = True
        Me.txt_docpendientes.Size = New System.Drawing.Size(131, 26)
        Me.txt_docpendientes.TabIndex = 37
        Me.txt_docpendientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_docpendientes.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(293, 74)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(104, 18)
        Me.Label21.TabIndex = 39
        Me.Label21.Text = "Letras x Cobrar"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(282, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(115, 18)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "Cheques x Cobrar"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(15, 40)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(99, 18)
        Me.Label19.TabIndex = 37
        Me.Label19.Text = "Doc.Pendientes"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkCliente)
        Me.GroupBox2.Controls.Add(Me.txt_clientebuscar)
        Me.GroupBox2.Controls.Add(Me.txt_RutCliente)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_telefono)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_direccion)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(917, 137)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Cliente"
        '
        'chkCliente
        '
        Me.chkCliente.AutoSize = True
        Me.chkCliente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCliente.Location = New System.Drawing.Point(185, 43)
        Me.chkCliente.Name = "chkCliente"
        Me.chkCliente.Size = New System.Drawing.Size(132, 18)
        Me.chkCliente.TabIndex = 112
        Me.chkCliente.Text = "incluye primer nombre"
        Me.chkCliente.UseVisualStyleBackColor = True
        '
        'txt_clientebuscar
        '
        Me.txt_clientebuscar.BackColor = System.Drawing.SystemColors.Window
        Me.txt_clientebuscar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clientebuscar.ForeColor = System.Drawing.Color.Navy
        Me.txt_clientebuscar.Location = New System.Drawing.Point(185, 18)
        Me.txt_clientebuscar.Name = "txt_clientebuscar"
        Me.txt_clientebuscar.Size = New System.Drawing.Size(671, 21)
        Me.txt_clientebuscar.TabIndex = 111
        '
        'txt_RutCliente
        '
        Me.txt_RutCliente.Location = New System.Drawing.Point(76, 16)
        Me.txt_RutCliente.MaxLength = 12
        Me.txt_RutCliente.Name = "txt_RutCliente"
        Me.txt_RutCliente.Size = New System.Drawing.Size(100, 24)
        Me.txt_RutCliente.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Rut"
        '
        'txt_telefono
        '
        Me.txt_telefono.Enabled = False
        Me.txt_telefono.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefono.Location = New System.Drawing.Point(76, 97)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(780, 24)
        Me.txt_telefono.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Teléfono"
        '
        'txt_direccion
        '
        Me.txt_direccion.Enabled = False
        Me.txt_direccion.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_direccion.Location = New System.Drawing.Point(76, 62)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(780, 24)
        Me.txt_direccion.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Dirección"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.buscar_40x40
        Me.Button2.Location = New System.Drawing.Point(862, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 41)
        Me.Button2.TabIndex = 7
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1024, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirCartolaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'ImprimirCartolaToolStripMenuItem
        '
        Me.ImprimirCartolaToolStripMenuItem.Name = "ImprimirCartolaToolStripMenuItem"
        Me.ImprimirCartolaToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ImprimirCartolaToolStripMenuItem.Text = "Imprimir Cartola"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'txt_RutDisplay
        '
        Me.txt_RutDisplay.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RutDisplay.Location = New System.Drawing.Point(18, 173)
        Me.txt_RutDisplay.Name = "txt_RutDisplay"
        Me.txt_RutDisplay.Size = New System.Drawing.Size(173, 26)
        Me.txt_RutDisplay.TabIndex = 10
        '
        'txt_NombreDisplay
        '
        Me.txt_NombreDisplay.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NombreDisplay.Location = New System.Drawing.Point(200, 173)
        Me.txt_NombreDisplay.Name = "txt_NombreDisplay"
        Me.txt_NombreDisplay.Size = New System.Drawing.Size(671, 26)
        Me.txt_NombreDisplay.TabIndex = 11
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Image = Global.GestionVivero.My.Resources.Resources.page_productos_at_item3
        Me.Button3.Location = New System.Drawing.Point(938, 108)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 91)
        Me.Button3.TabIndex = 9
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.salir_40x40
        Me.Button1.Location = New System.Drawing.Point(938, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 91)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(603, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 18)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Valor DAI"
        '
        'txtValorDAI
        '
        Me.txtValorDAI.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorDAI.HidePromptOnLeave = True
        Me.txtValorDAI.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtValorDAI.Location = New System.Drawing.Point(676, 36)
        Me.txtValorDAI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtValorDAI.Name = "txtValorDAI"
        Me.txtValorDAI.ReadOnly = True
        Me.txtValorDAI.Size = New System.Drawing.Size(131, 26)
        Me.txtValorDAI.TabIndex = 46
        Me.txtValorDAI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorDAI.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'emision
        '
        Me.emision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.emision.HeaderText = "Fecha Doc."
        Me.emision.Name = "emision"
        Me.emision.ReadOnly = True
        Me.emision.Width = 120
        '
        'tipo
        '
        Me.tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        Me.tipo.Width = 80
        '
        'doc
        '
        Me.doc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.doc.HeaderText = "Nro. Documento"
        Me.doc.Name = "doc"
        Me.doc.ReadOnly = True
        Me.doc.Width = 130
        '
        'total
        '
        Me.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.total.DefaultCellStyle = DataGridViewCellStyle1
        Me.total.HeaderText = "Valor Doc."
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Width = 130
        '
        'saldo
        '
        Me.saldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.saldo.DefaultCellStyle = DataGridViewCellStyle2
        Me.saldo.HeaderText = "Saldo Pendiente"
        Me.saldo.Name = "saldo"
        Me.saldo.ReadOnly = True
        Me.saldo.Width = 130
        '
        'Cartola_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 716)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_NombreDisplay)
        Me.Controls.Add(Me.txt_RutDisplay)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cartola_Cliente"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cartola de Clientes"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataCartola, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataCartola As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Public WithEvents txt_CHxcobrar As System.Windows.Forms.MaskedTextBox
    Public WithEvents txt_LetrasxCobrar As System.Windows.Forms.MaskedTextBox
    Public WithEvents txt_docpendientes As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirCartolaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Public WithEvents txt_TotalAbonos As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents txt_DeudaTotal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As Button
    Friend WithEvents txt_RutCliente As TextBox
    Friend WithEvents txt_RutDisplay As TextBox
    Friend WithEvents txt_NombreDisplay As TextBox
    Friend WithEvents chkCliente As CheckBox
    Friend WithEvents txt_clientebuscar As TextBox
    Public WithEvents txtValorDAI As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents emision As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents doc As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents saldo As DataGridViewTextBoxColumn
End Class
