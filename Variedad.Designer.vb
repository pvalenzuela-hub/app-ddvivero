<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Variedad
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdb_Temporada1 = New System.Windows.Forms.RadioButton()
        Me.rdb_Temporada2 = New System.Windows.Forms.RadioButton()
        Me.rdb_Temporada3 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdb_descarga1 = New System.Windows.Forms.RadioButton()
        Me.rdb_Descarga2 = New System.Windows.Forms.RadioButton()
        Me.NUD_nrodiasprecocidad = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Detalle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_Proveedor = New System.Windows.Forms.ComboBox()
        Me.cmb_Familia = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Descripcion = New System.Windows.Forms.TextBox()
        Me.txt_IDvariedad = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGrilla = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NdiasProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdFamilia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Temporada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precocidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ficha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NUD_nrodiasprecocidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.NUD_nrodiasprecocidad)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_Detalle)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmb_Proveedor)
        Me.GroupBox1.Controls.Add(Me.cmb_Familia)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_Descripcion)
        Me.GroupBox1.Controls.Add(Me.txt_IDvariedad)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(975, 231)
        Me.GroupBox1.TabIndex = 95
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdb_Temporada1)
        Me.GroupBox3.Controls.Add(Me.rdb_Temporada2)
        Me.GroupBox3.Controls.Add(Me.rdb_Temporada3)
        Me.GroupBox3.Location = New System.Drawing.Point(212, 142)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(296, 48)
        Me.GroupBox3.TabIndex = 113
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Temporada"
        '
        'rdb_Temporada1
        '
        Me.rdb_Temporada1.AutoSize = True
        Me.rdb_Temporada1.Checked = True
        Me.rdb_Temporada1.Location = New System.Drawing.Point(8, 25)
        Me.rdb_Temporada1.Name = "rdb_Temporada1"
        Me.rdb_Temporada1.Size = New System.Drawing.Size(73, 17)
        Me.rdb_Temporada1.TabIndex = 109
        Me.rdb_Temporada1.TabStop = True
        Me.rdb_Temporada1.Text = "Temprano"
        Me.rdb_Temporada1.UseVisualStyleBackColor = True
        '
        'rdb_Temporada2
        '
        Me.rdb_Temporada2.AutoSize = True
        Me.rdb_Temporada2.Location = New System.Drawing.Point(113, 25)
        Me.rdb_Temporada2.Name = "rdb_Temporada2"
        Me.rdb_Temporada2.Size = New System.Drawing.Size(74, 17)
        Me.rdb_Temporada2.TabIndex = 110
        Me.rdb_Temporada2.Text = "Intermedio"
        Me.rdb_Temporada2.UseVisualStyleBackColor = True
        '
        'rdb_Temporada3
        '
        Me.rdb_Temporada3.AutoSize = True
        Me.rdb_Temporada3.Location = New System.Drawing.Point(216, 25)
        Me.rdb_Temporada3.Name = "rdb_Temporada3"
        Me.rdb_Temporada3.Size = New System.Drawing.Size(53, 17)
        Me.rdb_Temporada3.TabIndex = 111
        Me.rdb_Temporada3.Text = "Tarde"
        Me.rdb_Temporada3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdb_descarga1)
        Me.GroupBox2.Controls.Add(Me.rdb_Descarga2)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(192, 48)
        Me.GroupBox2.TabIndex = 112
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Descarga"
        '
        'rdb_descarga1
        '
        Me.rdb_descarga1.AutoSize = True
        Me.rdb_descarga1.Checked = True
        Me.rdb_descarga1.Location = New System.Drawing.Point(16, 25)
        Me.rdb_descarga1.Name = "rdb_descarga1"
        Me.rdb_descarga1.Size = New System.Drawing.Size(59, 17)
        Me.rdb_descarga1.TabIndex = 104
        Me.rdb_descarga1.TabStop = True
        Me.rdb_descarga1.Text = "Rápida"
        Me.rdb_descarga1.UseVisualStyleBackColor = True
        '
        'rdb_Descarga2
        '
        Me.rdb_Descarga2.AutoSize = True
        Me.rdb_Descarga2.Location = New System.Drawing.Point(116, 25)
        Me.rdb_Descarga2.Name = "rdb_Descarga2"
        Me.rdb_Descarga2.Size = New System.Drawing.Size(52, 17)
        Me.rdb_Descarga2.TabIndex = 105
        Me.rdb_Descarga2.Text = "Lenta"
        Me.rdb_Descarga2.UseVisualStyleBackColor = True
        '
        'NUD_nrodiasprecocidad
        '
        Me.NUD_nrodiasprecocidad.Location = New System.Drawing.Point(637, 156)
        Me.NUD_nrodiasprecocidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUD_nrodiasprecocidad.Name = "NUD_nrodiasprecocidad"
        Me.NUD_nrodiasprecocidad.Size = New System.Drawing.Size(50, 20)
        Me.NUD_nrodiasprecocidad.TabIndex = 107
        Me.NUD_nrodiasprecocidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(533, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 15)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "Precocidad Días"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(2, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 102
        Me.Label5.Text = "Descripcion"
        '
        'txt_Detalle
        '
        Me.txt_Detalle.Location = New System.Drawing.Point(81, 66)
        Me.txt_Detalle.MaxLength = 2000
        Me.txt_Detalle.Multiline = True
        Me.txt_Detalle.Name = "txt_Detalle"
        Me.txt_Detalle.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_Detalle.Size = New System.Drawing.Size(888, 70)
        Me.txt_Detalle.TabIndex = 101
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(639, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 14)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Proveedor"
        '
        'cmb_Proveedor
        '
        Me.cmb_Proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Proveedor.FormattingEnabled = True
        Me.cmb_Proveedor.Location = New System.Drawing.Point(635, 32)
        Me.cmb_Proveedor.Name = "cmb_Proveedor"
        Me.cmb_Proveedor.Size = New System.Drawing.Size(336, 21)
        Me.cmb_Proveedor.TabIndex = 99
        '
        'cmb_Familia
        '
        Me.cmb_Familia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Familia.FormattingEnabled = True
        Me.cmb_Familia.Location = New System.Drawing.Point(361, 32)
        Me.cmb_Familia.Name = "cmb_Familia"
        Me.cmb_Familia.Size = New System.Drawing.Size(270, 21)
        Me.cmb_Familia.TabIndex = 98
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.GestionVivero.My.Resources.Resources.guardar_40x40
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(982, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 49)
        Me.Button1.TabIndex = 97
        Me.ToolTip1.SetToolTip(Me.Button1, "Guardar Datos")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(358, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 14)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Familia de Producto"
        '
        'txt_Descripcion
        '
        Me.txt_Descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Descripcion.Location = New System.Drawing.Point(43, 32)
        Me.txt_Descripcion.Name = "txt_Descripcion"
        Me.txt_Descripcion.Size = New System.Drawing.Size(314, 20)
        Me.txt_Descripcion.TabIndex = 94
        '
        'txt_IDvariedad
        '
        Me.txt_IDvariedad.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IDvariedad.HidePromptOnLeave = True
        Me.txt_IDvariedad.Location = New System.Drawing.Point(5, 32)
        Me.txt_IDvariedad.Name = "txt_IDvariedad"
        Me.txt_IDvariedad.ReadOnly = True
        Me.txt_IDvariedad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_IDvariedad.Size = New System.Drawing.Size(33, 20)
        Me.txt_IDvariedad.TabIndex = 91
        Me.txt_IDvariedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 14)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Variedad de Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 14)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "ID"
        '
        'DataGrilla
        '
        Me.DataGrilla.AllowUserToAddRows = False
        Me.DataGrilla.AllowUserToDeleteRows = False
        Me.DataGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGrilla.BackgroundColor = System.Drawing.Color.White
        Me.DataGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Descrip, Me.NdiasProd, Me.IdFamilia, Me.Proveedor, Me.descripc, Me.Descarga, Me.Temporada, Me.Precocidad, Me.ficha})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrilla.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGrilla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGrilla.Location = New System.Drawing.Point(1, 242)
        Me.DataGrilla.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.DataGrilla.Name = "DataGrilla"
        Me.DataGrilla.ReadOnly = True
        Me.DataGrilla.RowHeadersVisible = False
        Me.DataGrilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataGrilla.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGrilla.Size = New System.Drawing.Size(976, 319)
        Me.DataGrilla.TabIndex = 65
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button8
        '
        Me.Button8.BackgroundImage = Global.GestionVivero.My.Resources.Resources.buscar_40x40
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.Location = New System.Drawing.Point(982, 35)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(49, 49)
        Me.Button8.TabIndex = 105
        Me.ToolTip1.SetToolTip(Me.Button8, "Listar Variedades")
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.BackgroundImage = Global.GestionVivero.My.Resources.Resources.salir_40x40
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.Location = New System.Drawing.Point(982, 136)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(49, 49)
        Me.Button9.TabIndex = 106
        Me.ToolTip1.SetToolTip(Me.Button9, "Listar Variedades")
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Id
        '
        Me.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 41
        '
        'Descrip
        '
        Me.Descrip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.Descrip.DefaultCellStyle = DataGridViewCellStyle10
        Me.Descrip.FillWeight = 200.0!
        Me.Descrip.HeaderText = "Variedad"
        Me.Descrip.MinimumWidth = 100
        Me.Descrip.Name = "Descrip"
        Me.Descrip.ReadOnly = True
        '
        'NdiasProd
        '
        Me.NdiasProd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NdiasProd.FillWeight = 150.0!
        Me.NdiasProd.HeaderText = "Especie"
        Me.NdiasProd.Name = "NdiasProd"
        Me.NdiasProd.ReadOnly = True
        Me.NdiasProd.Width = 70
        '
        'IdFamilia
        '
        Me.IdFamilia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IdFamilia.HeaderText = "ID Familia"
        Me.IdFamilia.Name = "IdFamilia"
        Me.IdFamilia.ReadOnly = True
        Me.IdFamilia.Width = 78
        '
        'Proveedor
        '
        Me.Proveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.ReadOnly = True
        Me.Proveedor.Width = 81
        '
        'descripc
        '
        Me.descripc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.descripc.HeaderText = "Descripción"
        Me.descripc.Name = "descripc"
        Me.descripc.ReadOnly = True
        Me.descripc.Width = 88
        '
        'Descarga
        '
        Me.Descarga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Descarga.HeaderText = "Descarga"
        Me.Descarga.Name = "Descarga"
        Me.Descarga.ReadOnly = True
        Me.Descarga.Width = 78
        '
        'Temporada
        '
        Me.Temporada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Temporada.HeaderText = "Temporada"
        Me.Temporada.Name = "Temporada"
        Me.Temporada.ReadOnly = True
        Me.Temporada.Width = 86
        '
        'Precocidad
        '
        Me.Precocidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Precocidad.HeaderText = "Precocidad"
        Me.Precocidad.Name = "Precocidad"
        Me.Precocidad.ReadOnly = True
        Me.Precocidad.Width = 86
        '
        'ficha
        '
        Me.ficha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ficha.HeaderText = "Ubicacion Ficha"
        Me.ficha.Name = "ficha"
        Me.ficha.ReadOnly = True
        Me.ficha.Visible = False
        Me.ficha.Width = 109
        '
        'Button7
        '
        Me.Button7.BackgroundImage = Global.GestionVivero.My.Resources.Resources.nuevo_40x40
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.Location = New System.Drawing.Point(982, 242)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(49, 49)
        Me.Button7.TabIndex = 107
        Me.ToolTip1.SetToolTip(Me.Button7, "Nueva Variedad")
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.BackgroundImage = Global.GestionVivero.My.Resources.Resources.editar_40x40
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.Location = New System.Drawing.Point(983, 291)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(49, 49)
        Me.Button10.TabIndex = 108
        Me.ToolTip1.SetToolTip(Me.Button10, "Modificar Variedad")
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.BackgroundImage = Global.GestionVivero.My.Resources.Resources.eliminar_40x40
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.Location = New System.Drawing.Point(982, 346)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(49, 49)
        Me.Button11.TabIndex = 109
        Me.ToolTip1.SetToolTip(Me.Button11, "Eliminar Variedad")
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Variedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 569)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.DataGrilla)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Variedad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de Variedad"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NUD_nrodiasprecocidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_IDvariedad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_Familia As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_Proveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Detalle As System.Windows.Forms.TextBox
    Friend WithEvents rdb_Descarga2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_descarga1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Temporada3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Temporada2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Temporada1 As System.Windows.Forms.RadioButton
    Friend WithEvents NUD_nrodiasprecocidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button8 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button9 As Button
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Descrip As DataGridViewTextBoxColumn
    Friend WithEvents NdiasProd As DataGridViewTextBoxColumn
    Friend WithEvents IdFamilia As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents descripc As DataGridViewTextBoxColumn
    Friend WithEvents Descarga As DataGridViewTextBoxColumn
    Friend WithEvents Temporada As DataGridViewTextBoxColumn
    Friend WithEvents Precocidad As DataGridViewTextBoxColumn
    Friend WithEvents ficha As DataGridViewTextBoxColumn
    Friend WithEvents Button7 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
End Class
