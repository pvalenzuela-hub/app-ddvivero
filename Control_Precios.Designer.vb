<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Control_Precios
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
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGrilla = New System.Windows.Forms.DataGridView
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Insumo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoOriginal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnidadCompra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Unidades = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txt_CostoUnitarioPlanta = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_CostoTotalBandeja = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_NumCeldas = New System.Windows.Forms.TextBox
        Me.txt_TipoBandeja = New System.Windows.Forms.TextBox
        Me.cmb_Formulas = New System.Windows.Forms.ComboBox
        Me.cmb_Semilla = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GrillaPrecios = New System.Windows.Forms.DataGridView
        Me.fechadesde = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.preciohasta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.precioventa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GrillaPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGrilla)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 161)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(973, 267)
        Me.GroupBox2.TabIndex = 102
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de Fórmulas"
        '
        'DataGrilla
        '
        Me.DataGrilla.AllowUserToAddRows = False
        Me.DataGrilla.AllowUserToDeleteRows = False
        Me.DataGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Insumo, Me.CostoOriginal, Me.UnidadCompra, Me.Unidades, Me.TipoUnidad, Me.CostoUnidad, Me.CostoTotal})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrilla.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGrilla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGrilla.Location = New System.Drawing.Point(11, 24)
        Me.DataGrilla.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.DataGrilla.Name = "DataGrilla"
        Me.DataGrilla.ReadOnly = True
        Me.DataGrilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataGrilla.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.DataGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGrilla.Size = New System.Drawing.Size(956, 233)
        Me.DataGrilla.TabIndex = 65
        '
        'Id
        '
        Me.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 42
        '
        'Insumo
        '
        Me.Insumo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.Insumo.DefaultCellStyle = DataGridViewCellStyle13
        Me.Insumo.FillWeight = 200.0!
        Me.Insumo.HeaderText = "Descripción Insumo"
        Me.Insumo.MinimumWidth = 100
        Me.Insumo.Name = "Insumo"
        Me.Insumo.ReadOnly = True
        '
        'CostoOriginal
        '
        Me.CostoOriginal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
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
        Me.CostoUnidad.HeaderText = "Costo Unitario"
        Me.CostoUnidad.Name = "CostoUnidad"
        Me.CostoUnidad.ReadOnly = True
        '
        'CostoTotal
        '
        Me.CostoTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CostoTotal.HeaderText = "Costo Total"
        Me.CostoTotal.Name = "CostoTotal"
        Me.CostoTotal.ReadOnly = True
        '
        'txt_CostoUnitarioPlanta
        '
        Me.txt_CostoUnitarioPlanta.BackColor = System.Drawing.Color.RoyalBlue
        Me.txt_CostoUnitarioPlanta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CostoUnitarioPlanta.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_CostoUnitarioPlanta.Location = New System.Drawing.Point(864, 471)
        Me.txt_CostoUnitarioPlanta.Name = "txt_CostoUnitarioPlanta"
        Me.txt_CostoUnitarioPlanta.ReadOnly = True
        Me.txt_CostoUnitarioPlanta.Size = New System.Drawing.Size(116, 21)
        Me.txt_CostoUnitarioPlanta.TabIndex = 112
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(694, 474)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 15)
        Me.Label6.TabIndex = 111
        Me.Label6.Text = "Costo Unitario Planta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(694, 440)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 15)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "Costo Total Bandeja"
        '
        'txt_CostoTotalBandeja
        '
        Me.txt_CostoTotalBandeja.BackColor = System.Drawing.Color.RoyalBlue
        Me.txt_CostoTotalBandeja.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CostoTotalBandeja.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_CostoTotalBandeja.Location = New System.Drawing.Point(864, 437)
        Me.txt_CostoTotalBandeja.Name = "txt_CostoTotalBandeja"
        Me.txt_CostoTotalBandeja.ReadOnly = True
        Me.txt_CostoTotalBandeja.Size = New System.Drawing.Size(116, 21)
        Me.txt_CostoTotalBandeja.TabIndex = 110
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_NumCeldas)
        Me.GroupBox1.Controls.Add(Me.txt_TipoBandeja)
        Me.GroupBox1.Controls.Add(Me.cmb_Formulas)
        Me.GroupBox1.Controls.Add(Me.cmb_Semilla)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(973, 140)
        Me.GroupBox1.TabIndex = 115
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de búsqueda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(631, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "N° Celdas"
        '
        'txt_NumCeldas
        '
        Me.txt_NumCeldas.Location = New System.Drawing.Point(701, 30)
        Me.txt_NumCeldas.Name = "txt_NumCeldas"
        Me.txt_NumCeldas.ReadOnly = True
        Me.txt_NumCeldas.Size = New System.Drawing.Size(73, 21)
        Me.txt_NumCeldas.TabIndex = 120
        '
        'txt_TipoBandeja
        '
        Me.txt_TipoBandeja.Location = New System.Drawing.Point(305, 30)
        Me.txt_TipoBandeja.Name = "txt_TipoBandeja"
        Me.txt_TipoBandeja.ReadOnly = True
        Me.txt_TipoBandeja.Size = New System.Drawing.Size(265, 21)
        Me.txt_TipoBandeja.TabIndex = 119
        '
        'cmb_Formulas
        '
        Me.cmb_Formulas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Formulas.FormattingEnabled = True
        Me.cmb_Formulas.Location = New System.Drawing.Point(158, 30)
        Me.cmb_Formulas.Name = "cmb_Formulas"
        Me.cmb_Formulas.Size = New System.Drawing.Size(82, 23)
        Me.cmb_Formulas.TabIndex = 118
        '
        'cmb_Semilla
        '
        Me.cmb_Semilla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Semilla.FormattingEnabled = True
        Me.cmb_Semilla.Location = New System.Drawing.Point(158, 85)
        Me.cmb_Semilla.Name = "cmb_Semilla"
        Me.cmb_Semilla.Size = New System.Drawing.Size(412, 23)
        Me.cmb_Semilla.TabIndex = 95
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(268, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 15)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Tipo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Semilla"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(808, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 53)
        Me.Button1.TabIndex = 92
        Me.Button1.Text = "Consulta Precios"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 15)
        Me.Label9.TabIndex = 116
        Me.Label9.Text = "Identificador Fórmula"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(472, 576)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 32)
        Me.Button2.TabIndex = 118
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GrillaPrecios)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 440)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(657, 120)
        Me.GroupBox3.TabIndex = 119
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Precios de Venta por Unidad"
        '
        'GrillaPrecios
        '
        Me.GrillaPrecios.AllowUserToAddRows = False
        Me.GrillaPrecios.AllowUserToDeleteRows = False
        Me.GrillaPrecios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.GrillaPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GrillaPrecios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fechadesde, Me.preciohasta, Me.precioventa})
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrillaPrecios.DefaultCellStyle = DataGridViewCellStyle17
        Me.GrillaPrecios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GrillaPrecios.Location = New System.Drawing.Point(11, 23)
        Me.GrillaPrecios.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.GrillaPrecios.Name = "GrillaPrecios"
        Me.GrillaPrecios.ReadOnly = True
        Me.GrillaPrecios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.GrillaPrecios.RowsDefaultCellStyle = DataGridViewCellStyle18
        Me.GrillaPrecios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GrillaPrecios.Size = New System.Drawing.Size(630, 88)
        Me.GrillaPrecios.TabIndex = 66
        '
        'fechadesde
        '
        Me.fechadesde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.fechadesde.DefaultCellStyle = DataGridViewCellStyle16
        Me.fechadesde.HeaderText = "Fecha Desde"
        Me.fechadesde.MinimumWidth = 100
        Me.fechadesde.Name = "fechadesde"
        Me.fechadesde.ReadOnly = True
        '
        'preciohasta
        '
        Me.preciohasta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.preciohasta.HeaderText = "Fecha Hasta"
        Me.preciohasta.Name = "preciohasta"
        Me.preciohasta.ReadOnly = True
        '
        'precioventa
        '
        Me.precioventa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.precioventa.HeaderText = "Precio de Venta"
        Me.precioventa.Name = "precioventa"
        Me.precioventa.ReadOnly = True
        '
        'Control_Precios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 631)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_CostoUnitarioPlanta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_CostoTotalBandeja)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Control_Precios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de Precios"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GrillaPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Insumo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoOriginal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unidades As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_CostoUnitarioPlanta As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_CostoTotalBandeja As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_Semilla As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_NumCeldas As System.Windows.Forms.TextBox
    Friend WithEvents txt_TipoBandeja As System.Windows.Forms.TextBox
    Friend WithEvents cmb_Formulas As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GrillaPrecios As System.Windows.Forms.DataGridView
    Friend WithEvents fechadesde As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents preciohasta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precioventa As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
