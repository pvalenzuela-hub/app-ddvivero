<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Costos_Indirectos
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
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GrillaInsumo = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_TipoBandeja = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_CantPlantas = New System.Windows.Forms.MaskedTextBox
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.cmb_Insumos = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_CantInsumo = New System.Windows.Forms.MaskedTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_PrecioCosto = New System.Windows.Forms.MaskedTextBox
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.desde = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fechahasta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.hasta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txt_UnidadCosto = New System.Windows.Forms.MaskedTextBox
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_NumUsos = New System.Windows.Forms.MaskedTextBox
        CType(Me.GrillaInsumo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrillaInsumo
        '
        Me.GrillaInsumo.AllowUserToAddRows = False
        Me.GrillaInsumo.AllowUserToDeleteRows = False
        Me.GrillaInsumo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.GrillaInsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GrillaInsumo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.desde, Me.fechahasta, Me.Precio, Me.hasta})
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrillaInsumo.DefaultCellStyle = DataGridViewCellStyle19
        Me.GrillaInsumo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GrillaInsumo.Location = New System.Drawing.Point(2, 279)
        Me.GrillaInsumo.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GrillaInsumo.Name = "GrillaInsumo"
        Me.GrillaInsumo.ReadOnly = True
        Me.GrillaInsumo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.GrillaInsumo.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.GrillaInsumo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GrillaInsumo.Size = New System.Drawing.Size(647, 129)
        Me.GrillaInsumo.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(209, 434)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Total Costo Directo"
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
        Me.Label3.Location = New System.Drawing.Point(44, 75)
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
        Me.txt_CantPlantas.Location = New System.Drawing.Point(153, 70)
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
        Me.btnEliminar.Location = New System.Drawing.Point(619, 199)
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
        Me.btnAgregar.Location = New System.Drawing.Point(573, 199)
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
        Me.cmb_Insumos.Location = New System.Drawing.Point(153, 118)
        Me.cmb_Insumos.Name = "cmb_Insumos"
        Me.cmb_Insumos.Size = New System.Drawing.Size(173, 23)
        Me.cmb_Insumos.TabIndex = 73
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Item de Costo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Cantidad"
        '
        'txt_CantInsumo
        '
        Me.txt_CantInsumo.BackColor = System.Drawing.SystemColors.Window
        Me.txt_CantInsumo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CantInsumo.ForeColor = System.Drawing.Color.Navy
        Me.txt_CantInsumo.HidePromptOnLeave = True
        Me.txt_CantInsumo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_CantInsumo.Location = New System.Drawing.Point(153, 192)
        Me.txt_CantInsumo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_CantInsumo.Mask = "######0"
        Me.txt_CantInsumo.Name = "txt_CantInsumo"
        Me.txt_CantInsumo.ReadOnly = True
        Me.txt_CantInsumo.Size = New System.Drawing.Size(67, 22)
        Me.txt_CantInsumo.TabIndex = 76
        Me.txt_CantInsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_CantInsumo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Unidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 160)
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
        Me.txt_PrecioCosto.Location = New System.Drawing.Point(153, 155)
        Me.txt_PrecioCosto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_PrecioCosto.Name = "txt_PrecioCosto"
        Me.txt_PrecioCosto.ReadOnly = True
        Me.txt_PrecioCosto.Size = New System.Drawing.Size(90, 22)
        Me.txt_PrecioCosto.TabIndex = 80
        Me.txt_PrecioCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_PrecioCosto.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Id
        '
        Me.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Id.HeaderText = "Item"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 52
        '
        'desde
        '
        Me.desde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.desde.DefaultCellStyle = DataGridViewCellStyle16
        Me.desde.HeaderText = "Precio Costo"
        Me.desde.MinimumWidth = 100
        Me.desde.Name = "desde"
        Me.desde.ReadOnly = True
        '
        'fechahasta
        '
        Me.fechahasta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.fechahasta.DefaultCellStyle = DataGridViewCellStyle17
        Me.fechahasta.HeaderText = "Cantidad"
        Me.fechahasta.Name = "fechahasta"
        Me.fechahasta.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Precio.HeaderText = "Unidad"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'hasta
        '
        Me.hasta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.hasta.DefaultCellStyle = DataGridViewCellStyle18
        Me.hasta.HeaderText = "Costo Planta"
        Me.hasta.Name = "hasta"
        Me.hasta.ReadOnly = True
        '
        'txt_UnidadCosto
        '
        Me.txt_UnidadCosto.BackColor = System.Drawing.Color.Navy
        Me.txt_UnidadCosto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_UnidadCosto.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_UnidadCosto.HidePromptOnLeave = True
        Me.txt_UnidadCosto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_UnidadCosto.Location = New System.Drawing.Point(153, 234)
        Me.txt_UnidadCosto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_UnidadCosto.Name = "txt_UnidadCosto"
        Me.txt_UnidadCosto.ReadOnly = True
        Me.txt_UnidadCosto.Size = New System.Drawing.Size(173, 22)
        Me.txt_UnidadCosto.TabIndex = 81
        Me.txt_UnidadCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_UnidadCosto.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.BackColor = System.Drawing.Color.Navy
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.MaskedTextBox1.HidePromptOnLeave = True
        Me.MaskedTextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MaskedTextBox1.Location = New System.Drawing.Point(333, 429)
        Me.MaskedTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.ReadOnly = True
        Me.MaskedTextBox1.Size = New System.Drawing.Size(90, 22)
        Me.MaskedTextBox1.TabIndex = 82
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MaskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(382, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "N° de Usos Item"
        '
        'txt_NumUsos
        '
        Me.txt_NumUsos.BackColor = System.Drawing.Color.Navy
        Me.txt_NumUsos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NumUsos.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_NumUsos.HidePromptOnLeave = True
        Me.txt_NumUsos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_NumUsos.Location = New System.Drawing.Point(472, 234)
        Me.txt_NumUsos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_NumUsos.Name = "txt_NumUsos"
        Me.txt_NumUsos.ReadOnly = True
        Me.txt_NumUsos.Size = New System.Drawing.Size(44, 22)
        Me.txt_NumUsos.TabIndex = 84
        Me.txt_NumUsos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_NumUsos.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Costos_Indirectos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 511)
        Me.Controls.Add(Me.txt_NumUsos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.txt_UnidadCosto)
        Me.Controls.Add(Me.txt_PrecioCosto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_CantInsumo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_Insumos)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txt_CantPlantas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_TipoBandeja)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrillaInsumo)
        Me.Name = "Costos_Indirectos"
        Me.Text = "Costos Directos"
        CType(Me.GrillaInsumo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrillaInsumo As System.Windows.Forms.DataGridView
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents txt_PrecioCosto As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desde As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechahasta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hasta As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents txt_UnidadCosto As System.Windows.Forms.MaskedTextBox
    Public WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents txt_NumUsos As System.Windows.Forms.MaskedTextBox
End Class
