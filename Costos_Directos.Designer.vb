<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Costos_directos
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GrillaDetalle = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_TipoBandeja = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_CantPlantas = New System.Windows.Forms.MaskedTextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cmb_Insumos = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_CantInsumo = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_PrecioCosto = New System.Windows.Forms.MaskedTextBox()
        Me.txt_TipoUnidadCosto = New System.Windows.Forms.MaskedTextBox()
        Me.txt_TotalCostoDirectoPlanta = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_NumUsos = New System.Windows.Forms.MaskedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_UnidCosto = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_UnCosto = New System.Windows.Forms.MaskedTextBox()
        Me.txt_UNCompra = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechahasta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hasta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cband = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_TotalCostoDIRBandeja = New System.Windows.Forms.MaskedTextBox()
        CType(Me.GrillaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrillaDetalle
        '
        Me.GrillaDetalle.AllowUserToAddRows = False
        Me.GrillaDetalle.AllowUserToDeleteRows = False
        Me.GrillaDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.GrillaDetalle.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.GrillaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GrillaDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.desde, Me.fechahasta, Me.Precio, Me.hasta, Me.cband})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrillaDetalle.DefaultCellStyle = DataGridViewCellStyle5
        Me.GrillaDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GrillaDetalle.Location = New System.Drawing.Point(2, 279)
        Me.GrillaDetalle.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GrillaDetalle.Name = "GrillaDetalle"
        Me.GrillaDetalle.ReadOnly = True
        Me.GrillaDetalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.GrillaDetalle.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.GrillaDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GrillaDetalle.Size = New System.Drawing.Size(715, 129)
        Me.GrillaDetalle.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 429)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Costo MD por Bandeja"
        '
        'cmb_TipoBandeja
        '
        Me.cmb_TipoBandeja.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_TipoBandeja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoBandeja.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_TipoBandeja.ForeColor = System.Drawing.Color.Navy
        Me.cmb_TipoBandeja.FormattingEnabled = True
        Me.cmb_TipoBandeja.Location = New System.Drawing.Point(153, 32)
        Me.cmb_TipoBandeja.Name = "cmb_TipoBandeja"
        Me.cmb_TipoBandeja.Size = New System.Drawing.Size(242, 23)
        Me.cmb_TipoBandeja.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Tipo Bandeja"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(422, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Cantidad Plantas"
        '
        'txt_CantPlantas
        '
        Me.txt_CantPlantas.BackColor = System.Drawing.Color.Navy
        Me.txt_CantPlantas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CantPlantas.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_CantPlantas.HidePromptOnLeave = True
        Me.txt_CantPlantas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_CantPlantas.Location = New System.Drawing.Point(513, 33)
        Me.txt_CantPlantas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_CantPlantas.Name = "txt_CantPlantas"
        Me.txt_CantPlantas.ReadOnly = True
        Me.txt_CantPlantas.Size = New System.Drawing.Size(90, 22)
        Me.txt_CantPlantas.TabIndex = 70
        Me.txt_CantPlantas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_CantPlantas.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = Global.GestionVivero.My.Resources.Resources.Delete
        Me.btnEliminar.Location = New System.Drawing.Point(368, 240)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(30, 30)
        Me.btnEliminar.TabIndex = 72
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.btnAgregar.Location = New System.Drawing.Point(321, 240)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(30, 30)
        Me.btnAgregar.TabIndex = 71
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'cmb_Insumos
        '
        Me.cmb_Insumos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_Insumos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Insumos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Insumos.ForeColor = System.Drawing.Color.White
        Me.cmb_Insumos.FormattingEnabled = True
        Me.cmb_Insumos.Location = New System.Drawing.Point(153, 21)
        Me.cmb_Insumos.Name = "cmb_Insumos"
        Me.cmb_Insumos.Size = New System.Drawing.Size(242, 23)
        Me.cmb_Insumos.TabIndex = 73
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Descripción"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Cantidad por Bandeja"
        '
        'txt_CantInsumo
        '
        Me.txt_CantInsumo.BackColor = System.Drawing.SystemColors.Window
        Me.txt_CantInsumo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CantInsumo.ForeColor = System.Drawing.Color.Navy
        Me.txt_CantInsumo.HidePromptOnLeave = True
        Me.txt_CantInsumo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_CantInsumo.Location = New System.Drawing.Point(153, 123)
        Me.txt_CantInsumo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_CantInsumo.Name = "txt_CantInsumo"
        Me.txt_CantInsumo.Size = New System.Drawing.Size(67, 22)
        Me.txt_CantInsumo.TabIndex = 76
        Me.txt_CantInsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_CantInsumo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(442, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Precio Costo"
        '
        'txt_PrecioCosto
        '
        Me.txt_PrecioCosto.BackColor = System.Drawing.Color.Navy
        Me.txt_PrecioCosto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PrecioCosto.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_PrecioCosto.HidePromptOnLeave = True
        Me.txt_PrecioCosto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_PrecioCosto.Location = New System.Drawing.Point(513, 21)
        Me.txt_PrecioCosto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_PrecioCosto.Name = "txt_PrecioCosto"
        Me.txt_PrecioCosto.ReadOnly = True
        Me.txt_PrecioCosto.Size = New System.Drawing.Size(90, 22)
        Me.txt_PrecioCosto.TabIndex = 80
        Me.txt_PrecioCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_PrecioCosto.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txt_TipoUnidadCosto
        '
        Me.txt_TipoUnidadCosto.BackColor = System.Drawing.Color.Navy
        Me.txt_TipoUnidadCosto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TipoUnidadCosto.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_TipoUnidadCosto.HidePromptOnLeave = True
        Me.txt_TipoUnidadCosto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_TipoUnidadCosto.Location = New System.Drawing.Point(589, 72)
        Me.txt_TipoUnidadCosto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_TipoUnidadCosto.Name = "txt_TipoUnidadCosto"
        Me.txt_TipoUnidadCosto.ReadOnly = True
        Me.txt_TipoUnidadCosto.Size = New System.Drawing.Size(67, 22)
        Me.txt_TipoUnidadCosto.TabIndex = 81
        Me.txt_TipoUnidadCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_TipoUnidadCosto.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txt_TotalCostoDirectoPlanta
        '
        Me.txt_TotalCostoDirectoPlanta.BackColor = System.Drawing.Color.Navy
        Me.txt_TotalCostoDirectoPlanta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalCostoDirectoPlanta.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_TotalCostoDirectoPlanta.HidePromptOnLeave = True
        Me.txt_TotalCostoDirectoPlanta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_TotalCostoDirectoPlanta.Location = New System.Drawing.Point(489, 424)
        Me.txt_TotalCostoDirectoPlanta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_TotalCostoDirectoPlanta.Name = "txt_TotalCostoDirectoPlanta"
        Me.txt_TotalCostoDirectoPlanta.ReadOnly = True
        Me.txt_TotalCostoDirectoPlanta.Size = New System.Drawing.Size(90, 22)
        Me.txt_TotalCostoDirectoPlanta.TabIndex = 82
        Me.txt_TotalCostoDirectoPlanta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_TotalCostoDirectoPlanta.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(427, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "N° Reutilización"
        '
        'txt_NumUsos
        '
        Me.txt_NumUsos.BackColor = System.Drawing.Color.Navy
        Me.txt_NumUsos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NumUsos.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_NumUsos.HidePromptOnLeave = True
        Me.txt_NumUsos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_NumUsos.Location = New System.Drawing.Point(513, 123)
        Me.txt_NumUsos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_NumUsos.Name = "txt_NumUsos"
        Me.txt_NumUsos.ReadOnly = True
        Me.txt_NumUsos.Size = New System.Drawing.Size(44, 22)
        Me.txt_NumUsos.TabIndex = 84
        Me.txt_NumUsos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_NumUsos.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(186, 476)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 23)
        Me.Button1.TabIndex = 85
        Me.Button1.Text = "Gabar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(445, 476)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 23)
        Me.Button2.TabIndex = 86
        Me.Button2.Text = "Vovler"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(307, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(202, 13)
        Me.Label9.TabIndex = 87
        Me.Label9.Text = "Cantidad Equivalente en unidad de costo"
        '
        'txt_UnidCosto
        '
        Me.txt_UnidCosto.BackColor = System.Drawing.Color.Navy
        Me.txt_UnidCosto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_UnidCosto.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_UnidCosto.HidePromptOnLeave = True
        Me.txt_UnidCosto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_UnidCosto.Location = New System.Drawing.Point(513, 72)
        Me.txt_UnidCosto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_UnidCosto.Name = "txt_UnidCosto"
        Me.txt_UnidCosto.ReadOnly = True
        Me.txt_UnidCosto.Size = New System.Drawing.Size(70, 22)
        Me.txt_UnidCosto.TabIndex = 88
        Me.txt_UnidCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_UnidCosto.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_UnCosto)
        Me.GroupBox1.Controls.Add(Me.txt_UNCompra)
        Me.GroupBox1.Controls.Add(Me.txt_UnidCosto)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt_NumUsos)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmb_Insumos)
        Me.GroupBox1.Controls.Add(Me.txt_CantInsumo)
        Me.GroupBox1.Controls.Add(Me.txt_TipoUnidadCosto)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_PrecioCosto)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(714, 161)
        Me.GroupBox1.TabIndex = 89
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro MD"
        '
        'txt_UnCosto
        '
        Me.txt_UnCosto.BackColor = System.Drawing.SystemColors.Control
        Me.txt_UnCosto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_UnCosto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_UnCosto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_UnCosto.HidePromptOnLeave = True
        Me.txt_UnCosto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_UnCosto.Location = New System.Drawing.Point(226, 127)
        Me.txt_UnCosto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_UnCosto.Name = "txt_UnCosto"
        Me.txt_UnCosto.ReadOnly = True
        Me.txt_UnCosto.Size = New System.Drawing.Size(67, 15)
        Me.txt_UnCosto.TabIndex = 91
        Me.txt_UnCosto.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txt_UNCompra
        '
        Me.txt_UNCompra.BackColor = System.Drawing.Color.Navy
        Me.txt_UNCompra.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_UNCompra.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_UNCompra.HidePromptOnLeave = True
        Me.txt_UNCompra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_UNCompra.Location = New System.Drawing.Point(153, 72)
        Me.txt_UNCompra.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_UNCompra.Name = "txt_UNCompra"
        Me.txt_UNCompra.ReadOnly = True
        Me.txt_UNCompra.Size = New System.Drawing.Size(67, 22)
        Me.txt_UNCompra.TabIndex = 90
        Me.txt_UNCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_UNCompra.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 13)
        Me.Label10.TabIndex = 90
        Me.Label10.Text = "Unidad de Compra"
        '
        'Id
        '
        Me.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Id.HeaderText = "Material"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        '
        'desde
        '
        Me.desde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.desde.DefaultCellStyle = DataGridViewCellStyle1
        Me.desde.HeaderText = "Precio Costo"
        Me.desde.MinimumWidth = 100
        Me.desde.Name = "desde"
        Me.desde.ReadOnly = True
        '
        'fechahasta
        '
        Me.fechahasta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.fechahasta.DefaultCellStyle = DataGridViewCellStyle2
        Me.fechahasta.HeaderText = "Cantidad"
        Me.fechahasta.Name = "fechahasta"
        Me.fechahasta.ReadOnly = True
        Me.fechahasta.Width = 74
        '
        'Precio
        '
        Me.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Precio.HeaderText = "Unidad"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 66
        '
        'hasta
        '
        Me.hasta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.hasta.DefaultCellStyle = DataGridViewCellStyle3
        Me.hasta.HeaderText = "Costo Planta"
        Me.hasta.Name = "hasta"
        Me.hasta.ReadOnly = True
        Me.hasta.Width = 92
        '
        'cband
        '
        Me.cband.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cband.DefaultCellStyle = DataGridViewCellStyle4
        Me.cband.HeaderText = "Costo Bandeja"
        Me.cband.Name = "cband"
        Me.cband.ReadOnly = True
        Me.cband.Width = 101
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(378, 429)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 13)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Costo MD por Planta"
        '
        'txt_TotalCostoDIRBandeja
        '
        Me.txt_TotalCostoDIRBandeja.BackColor = System.Drawing.Color.Navy
        Me.txt_TotalCostoDIRBandeja.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalCostoDIRBandeja.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_TotalCostoDIRBandeja.HidePromptOnLeave = True
        Me.txt_TotalCostoDIRBandeja.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_TotalCostoDIRBandeja.Location = New System.Drawing.Point(174, 424)
        Me.txt_TotalCostoDIRBandeja.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_TotalCostoDIRBandeja.Name = "txt_TotalCostoDIRBandeja"
        Me.txt_TotalCostoDIRBandeja.ReadOnly = True
        Me.txt_TotalCostoDIRBandeja.Size = New System.Drawing.Size(90, 22)
        Me.txt_TotalCostoDIRBandeja.TabIndex = 91
        Me.txt_TotalCostoDIRBandeja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_TotalCostoDIRBandeja.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Costos_directos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 511)
        Me.Controls.Add(Me.txt_TotalCostoDIRBandeja)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_TotalCostoDirectoPlanta)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txt_CantPlantas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_TipoBandeja)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrillaDetalle)
        Me.Name = "Costos_directos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Material Directo MD"
        CType(Me.GrillaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrillaDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoBandeja As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents txt_CantPlantas As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents cmb_Insumos As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents txt_CantInsumo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents txt_PrecioCosto As System.Windows.Forms.MaskedTextBox
    Public WithEvents txt_TipoUnidadCosto As System.Windows.Forms.MaskedTextBox
    Public WithEvents txt_TotalCostoDirectoPlanta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents txt_NumUsos As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents txt_UnidCosto As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents txt_UNCompra As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents txt_UnCosto As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desde As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechahasta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hasta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cband As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents txt_TotalCostoDIRBandeja As System.Windows.Forms.MaskedTextBox
End Class
