<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formula
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_IDRegistro = New System.Windows.Forms.MaskedTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmb_TipoBandeja = New System.Windows.Forms.ComboBox
        Me.cmb_Insumo = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_Unidades = New System.Windows.Forms.MaskedTextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmb_TipoUnidad = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGrilla = New System.Windows.Forms.DataGridView
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.ident_formula = New System.Windows.Forms.NumericUpDown
        Me.Button4 = New System.Windows.Forms.Button
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumFormula = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Celdas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Insumo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoOriginal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnidadCompra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Unidades = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ident_formula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 15)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "ID"
        '
        'txt_IDRegistro
        '
        Me.txt_IDRegistro.HidePromptOnLeave = True
        Me.txt_IDRegistro.Location = New System.Drawing.Point(17, 43)
        Me.txt_IDRegistro.Name = "txt_IDRegistro"
        Me.txt_IDRegistro.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_IDRegistro.Size = New System.Drawing.Size(53, 20)
        Me.txt_IDRegistro.TabIndex = 98
        Me.txt_IDRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(709, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Unidades"
        '
        'cmb_TipoBandeja
        '
        Me.cmb_TipoBandeja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoBandeja.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_TipoBandeja.FormattingEnabled = True
        Me.cmb_TipoBandeja.Location = New System.Drawing.Point(88, 43)
        Me.cmb_TipoBandeja.Name = "cmb_TipoBandeja"
        Me.cmb_TipoBandeja.Size = New System.Drawing.Size(213, 23)
        Me.cmb_TipoBandeja.TabIndex = 96
        '
        'cmb_Insumo
        '
        Me.cmb_Insumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Insumo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Insumo.FormattingEnabled = True
        Me.cmb_Insumo.Location = New System.Drawing.Point(325, 43)
        Me.cmb_Insumo.Name = "cmb_Insumo"
        Me.cmb_Insumo.Size = New System.Drawing.Size(348, 23)
        Me.cmb_Insumo.TabIndex = 95
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(322, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Insumo"
        '
        'txt_Unidades
        '
        Me.txt_Unidades.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Unidades.HidePromptOnLeave = True
        Me.txt_Unidades.Location = New System.Drawing.Point(712, 43)
        Me.txt_Unidades.Name = "txt_Unidades"
        Me.txt_Unidades.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Unidades.Size = New System.Drawing.Size(58, 21)
        Me.txt_Unidades.TabIndex = 93
        Me.txt_Unidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(384, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 28)
        Me.Button1.TabIndex = 92
        Me.Button1.Text = "Actualiza Fórmula"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 15)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Tipo de Bandeja"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_TipoUnidad)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_IDRegistro)
        Me.GroupBox1.Controls.Add(Me.txt_Unidades)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmb_TipoBandeja)
        Me.GroupBox1.Controls.Add(Me.cmb_Insumo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(929, 103)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Formulación"
        '
        'cmb_TipoUnidad
        '
        Me.cmb_TipoUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoUnidad.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_TipoUnidad.FormattingEnabled = True
        Me.cmb_TipoUnidad.Location = New System.Drawing.Point(794, 43)
        Me.cmb_TipoUnidad.Name = "cmb_TipoUnidad"
        Me.cmb_TipoUnidad.Size = New System.Drawing.Size(84, 23)
        Me.cmb_TipoUnidad.TabIndex = 101
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(791, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 15)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Tipo Unidad"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGrilla)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(929, 231)
        Me.GroupBox2.TabIndex = 101
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de Fórmulas"
        '
        'DataGrilla
        '
        Me.DataGrilla.AllowUserToAddRows = False
        Me.DataGrilla.AllowUserToDeleteRows = False
        Me.DataGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.NumFormula, Me.Celdas, Me.Insumo, Me.CostoOriginal, Me.UnidadCompra, Me.Unidades, Me.TipoUnidad, Me.CostoUnidad, Me.CostoTotal})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrilla.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGrilla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGrilla.Location = New System.Drawing.Point(6, 21)
        Me.DataGrilla.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.DataGrilla.Name = "DataGrilla"
        Me.DataGrilla.ReadOnly = True
        Me.DataGrilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataGrilla.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGrilla.Size = New System.Drawing.Size(906, 202)
        Me.DataGrilla.TabIndex = 65
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(100, 382)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 28)
        Me.Button2.TabIndex = 102
        Me.Button2.Text = "Modificar Fórmula"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(396, 382)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 28)
        Me.Button3.TabIndex = 103
        Me.Button3.Text = "Eliminar Fórmula"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(352, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 15)
        Me.Label9.TabIndex = 102
        Me.Label9.Text = "Identificador Fórmula"
        '
        'ident_formula
        '
        Me.ident_formula.Location = New System.Drawing.Point(481, 10)
        Me.ident_formula.Name = "ident_formula"
        Me.ident_formula.Size = New System.Drawing.Size(64, 20)
        Me.ident_formula.TabIndex = 109
        Me.ident_formula.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(702, 382)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(149, 28)
        Me.Button4.TabIndex = 110
        Me.Button4.Text = "Volver"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Id
        '
        Me.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Id.FillWeight = 25.0!
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        '
        'NumFormula
        '
        Me.NumFormula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NumFormula.FillWeight = 70.0!
        Me.NumFormula.HeaderText = "Ident.Fórm."
        Me.NumFormula.Name = "NumFormula"
        Me.NumFormula.ReadOnly = True
        '
        'Celdas
        '
        Me.Celdas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Celdas.FillWeight = 45.0!
        Me.Celdas.HeaderText = "Celdas"
        Me.Celdas.Name = "Celdas"
        Me.Celdas.ReadOnly = True
        '
        'Insumo
        '
        Me.Insumo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.Insumo.DefaultCellStyle = DataGridViewCellStyle1
        Me.Insumo.FillWeight = 200.0!
        Me.Insumo.HeaderText = "Descripción Insumo"
        Me.Insumo.MinimumWidth = 100
        Me.Insumo.Name = "Insumo"
        Me.Insumo.ReadOnly = True
        '
        'CostoOriginal
        '
        Me.CostoOriginal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CostoOriginal.DefaultCellStyle = DataGridViewCellStyle2
        Me.CostoOriginal.HeaderText = "Precio Costo"
        Me.CostoOriginal.Name = "CostoOriginal"
        Me.CostoOriginal.ReadOnly = True
        '
        'UnidadCompra
        '
        Me.UnidadCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UnidadCompra.FillWeight = 80.0!
        Me.UnidadCompra.HeaderText = "Un.Compra"
        Me.UnidadCompra.Name = "UnidadCompra"
        Me.UnidadCompra.ReadOnly = True
        '
        'Unidades
        '
        Me.Unidades.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Unidades.DefaultCellStyle = DataGridViewCellStyle3
        Me.Unidades.HeaderText = "Unidades"
        Me.Unidades.Name = "Unidades"
        Me.Unidades.ReadOnly = True
        '
        'TipoUnidad
        '
        Me.TipoUnidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TipoUnidad.FillWeight = 80.0!
        Me.TipoUnidad.HeaderText = "Un.Costo"
        Me.TipoUnidad.Name = "TipoUnidad"
        Me.TipoUnidad.ReadOnly = True
        '
        'CostoUnidad
        '
        Me.CostoUnidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CostoUnidad.DefaultCellStyle = DataGridViewCellStyle4
        Me.CostoUnidad.HeaderText = "Costo Unitario"
        Me.CostoUnidad.Name = "CostoUnidad"
        Me.CostoUnidad.ReadOnly = True
        '
        'CostoTotal
        '
        Me.CostoTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CostoTotal.DefaultCellStyle = DataGridViewCellStyle5
        Me.CostoTotal.HeaderText = "Costo Total"
        Me.CostoTotal.Name = "CostoTotal"
        Me.CostoTotal.ReadOnly = True
        '
        'Formula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 417)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ident_formula)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Formula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulación de Precios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ident_formula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_IDRegistro As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoBandeja As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Insumo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Unidades As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_TipoUnidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ident_formula As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumFormula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Celdas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Insumo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoOriginal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unidades As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoTotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
