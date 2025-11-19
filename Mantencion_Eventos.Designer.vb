<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mantencion_Eventos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rb_identNaveNO = New System.Windows.Forms.RadioButton()
        Me.rb_identNave = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rb_PlantasNO = New System.Windows.Forms.RadioButton()
        Me.rb_Plantas = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rb_CamaraNO = New System.Windows.Forms.RadioButton()
        Me.rb_Camara = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rb_LoteNO = New System.Windows.Forms.RadioButton()
        Me.rb_Lote = New System.Windows.Forms.RadioButton()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.grp_Insumo = New System.Windows.Forms.GroupBox()
        Me.rb_insumoNO = New System.Windows.Forms.RadioButton()
        Me.rb_Insumo = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_Orden = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Descripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Detalle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdEventoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InstruccionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsumoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CamaraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConteoPlantaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdentNaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoEventoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SPCONSULTATBLEVENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GESTDataSet2 = New GestionVivero.GESTDataSet2()
        Me.SP_CONSULTA_TBL_EVENTOSTableAdapter = New GestionVivero.GESTDataSet2TableAdapters.SP_CONSULTA_TBL_EVENTOSTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.grp_Insumo.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPCONSULTATBLEVENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.grp_Insumo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Orden)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Descripcion)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Detalle)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadioButton3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadioButton2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadioButton1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(950, 582)
        Me.SplitContainer1.SplitterDistance = 228
        Me.SplitContainer1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(189, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 123
        Me.Button2.Text = "Refrescar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSize = True
        Me.GroupBox3.Controls.Add(Me.rb_identNaveNO)
        Me.GroupBox3.Controls.Add(Me.rb_identNave)
        Me.GroupBox3.Location = New System.Drawing.Point(459, 97)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(124, 80)
        Me.GroupBox3.TabIndex = 122
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Identificador de Nave"
        '
        'rb_identNaveNO
        '
        Me.rb_identNaveNO.AutoSize = True
        Me.rb_identNaveNO.Checked = True
        Me.rb_identNaveNO.Location = New System.Drawing.Point(28, 44)
        Me.rb_identNaveNO.Name = "rb_identNaveNO"
        Me.rb_identNaveNO.Size = New System.Drawing.Size(39, 17)
        Me.rb_identNaveNO.TabIndex = 1
        Me.rb_identNaveNO.TabStop = True
        Me.rb_identNaveNO.Text = "No"
        Me.rb_identNaveNO.UseVisualStyleBackColor = True
        '
        'rb_identNave
        '
        Me.rb_identNave.AutoSize = True
        Me.rb_identNave.Location = New System.Drawing.Point(28, 21)
        Me.rb_identNave.Name = "rb_identNave"
        Me.rb_identNave.Size = New System.Drawing.Size(36, 17)
        Me.rb_identNave.TabIndex = 0
        Me.rb_identNave.Text = "Sí"
        Me.rb_identNave.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.AutoSize = True
        Me.GroupBox6.Controls.Add(Me.rb_PlantasNO)
        Me.GroupBox6.Controls.Add(Me.rb_Plantas)
        Me.GroupBox6.Location = New System.Drawing.Point(336, 97)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(112, 80)
        Me.GroupBox6.TabIndex = 121
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Conteo"
        '
        'rb_PlantasNO
        '
        Me.rb_PlantasNO.AutoSize = True
        Me.rb_PlantasNO.Checked = True
        Me.rb_PlantasNO.Location = New System.Drawing.Point(28, 44)
        Me.rb_PlantasNO.Name = "rb_PlantasNO"
        Me.rb_PlantasNO.Size = New System.Drawing.Size(39, 17)
        Me.rb_PlantasNO.TabIndex = 1
        Me.rb_PlantasNO.TabStop = True
        Me.rb_PlantasNO.Text = "No"
        Me.rb_PlantasNO.UseVisualStyleBackColor = True
        '
        'rb_Plantas
        '
        Me.rb_Plantas.AutoSize = True
        Me.rb_Plantas.Location = New System.Drawing.Point(28, 21)
        Me.rb_Plantas.Name = "rb_Plantas"
        Me.rb_Plantas.Size = New System.Drawing.Size(36, 17)
        Me.rb_Plantas.TabIndex = 0
        Me.rb_Plantas.Text = "Sí"
        Me.rb_Plantas.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.AutoSize = True
        Me.GroupBox5.Controls.Add(Me.rb_CamaraNO)
        Me.GroupBox5.Controls.Add(Me.rb_Camara)
        Me.GroupBox5.Location = New System.Drawing.Point(220, 97)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(100, 80)
        Me.GroupBox5.TabIndex = 120
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Utiliza Camara"
        '
        'rb_CamaraNO
        '
        Me.rb_CamaraNO.AutoSize = True
        Me.rb_CamaraNO.Checked = True
        Me.rb_CamaraNO.Location = New System.Drawing.Point(28, 44)
        Me.rb_CamaraNO.Name = "rb_CamaraNO"
        Me.rb_CamaraNO.Size = New System.Drawing.Size(39, 17)
        Me.rb_CamaraNO.TabIndex = 1
        Me.rb_CamaraNO.TabStop = True
        Me.rb_CamaraNO.Text = "No"
        Me.rb_CamaraNO.UseVisualStyleBackColor = True
        '
        'rb_Camara
        '
        Me.rb_Camara.AutoSize = True
        Me.rb_Camara.Location = New System.Drawing.Point(28, 21)
        Me.rb_Camara.Name = "rb_Camara"
        Me.rb_Camara.Size = New System.Drawing.Size(36, 17)
        Me.rb_Camara.TabIndex = 0
        Me.rb_Camara.Text = "Sí"
        Me.rb_Camara.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.AutoSize = True
        Me.GroupBox4.Controls.Add(Me.rb_LoteNO)
        Me.GroupBox4.Controls.Add(Me.rb_Lote)
        Me.GroupBox4.Location = New System.Drawing.Point(114, 97)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(100, 80)
        Me.GroupBox4.TabIndex = 119
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Aplica a N° Lote"
        '
        'rb_LoteNO
        '
        Me.rb_LoteNO.AutoSize = True
        Me.rb_LoteNO.Checked = True
        Me.rb_LoteNO.Location = New System.Drawing.Point(28, 44)
        Me.rb_LoteNO.Name = "rb_LoteNO"
        Me.rb_LoteNO.Size = New System.Drawing.Size(39, 17)
        Me.rb_LoteNO.TabIndex = 1
        Me.rb_LoteNO.TabStop = True
        Me.rb_LoteNO.Text = "No"
        Me.rb_LoteNO.UseVisualStyleBackColor = True
        '
        'rb_Lote
        '
        Me.rb_Lote.AutoSize = True
        Me.rb_Lote.Location = New System.Drawing.Point(28, 21)
        Me.rb_Lote.Name = "rb_Lote"
        Me.rb_Lote.Size = New System.Drawing.Size(36, 17)
        Me.rb_Lote.TabIndex = 0
        Me.rb_Lote.Text = "Sí"
        Me.rb_Lote.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.AutoSize = True
        Me.Button6.Image = Global.GestionVivero.My.Resources.Resources.Delete
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(602, 136)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(119, 32)
        Me.Button6.TabIndex = 117
        Me.Button6.Text = "Eliminar Evento"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'grp_Insumo
        '
        Me.grp_Insumo.AutoSize = True
        Me.grp_Insumo.Controls.Add(Me.rb_insumoNO)
        Me.grp_Insumo.Controls.Add(Me.rb_Insumo)
        Me.grp_Insumo.Location = New System.Drawing.Point(7, 97)
        Me.grp_Insumo.Name = "grp_Insumo"
        Me.grp_Insumo.Size = New System.Drawing.Size(93, 80)
        Me.grp_Insumo.TabIndex = 118
        Me.grp_Insumo.TabStop = False
        Me.grp_Insumo.Text = "Utiliza Insumo"
        '
        'rb_insumoNO
        '
        Me.rb_insumoNO.AutoSize = True
        Me.rb_insumoNO.Checked = True
        Me.rb_insumoNO.Location = New System.Drawing.Point(28, 44)
        Me.rb_insumoNO.Name = "rb_insumoNO"
        Me.rb_insumoNO.Size = New System.Drawing.Size(39, 17)
        Me.rb_insumoNO.TabIndex = 1
        Me.rb_insumoNO.TabStop = True
        Me.rb_insumoNO.Text = "No"
        Me.rb_insumoNO.UseVisualStyleBackColor = True
        '
        'rb_Insumo
        '
        Me.rb_Insumo.AutoSize = True
        Me.rb_Insumo.Location = New System.Drawing.Point(28, 21)
        Me.rb_Insumo.Name = "rb_Insumo"
        Me.rb_Insumo.Size = New System.Drawing.Size(36, 17)
        Me.rb_Insumo.TabIndex = 0
        Me.rb_Insumo.Text = "Sí"
        Me.rb_Insumo.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(602, 101)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 34)
        Me.Button1.TabIndex = 116
        Me.Button1.Text = "Agregar Evento"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_Orden
        '
        Me.txt_Orden.Location = New System.Drawing.Point(433, 53)
        Me.txt_Orden.MaxLength = 5
        Me.txt_Orden.Name = "txt_Orden"
        Me.txt_Orden.Size = New System.Drawing.Size(42, 20)
        Me.txt_Orden.TabIndex = 115
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(386, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Orden"
        '
        'txt_Descripcion
        '
        Me.txt_Descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Descripcion.Location = New System.Drawing.Point(433, 7)
        Me.txt_Descripcion.MaxLength = 50
        Me.txt_Descripcion.Name = "txt_Descripcion"
        Me.txt_Descripcion.Size = New System.Drawing.Size(376, 20)
        Me.txt_Descripcion.TabIndex = 111
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(354, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 15)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "Descripción"
        '
        'txt_Detalle
        '
        Me.txt_Detalle.Location = New System.Drawing.Point(433, 30)
        Me.txt_Detalle.Name = "txt_Detalle"
        Me.txt_Detalle.Size = New System.Drawing.Size(474, 20)
        Me.txt_Detalle.TabIndex = 113
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(346, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Instrucciones"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(12, 54)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(165, 17)
        Me.RadioButton3.TabIndex = 109
        Me.RadioButton3.Text = "Eventos para Trabajos diarios"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(12, 31)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(130, 17)
        Me.RadioButton2.TabIndex = 108
        Me.RadioButton2.Text = "Eventos para Bitácora"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(12, 8)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(140, 17)
        Me.RadioButton1.TabIndex = 107
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Aplicación de Productos"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEventoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.InstruccionesDataGridViewTextBoxColumn, Me.InsumoDataGridViewTextBoxColumn, Me.LoteDataGridViewTextBoxColumn, Me.CamaraDataGridViewTextBoxColumn, Me.ConteoPlantaDataGridViewTextBoxColumn, Me.IdentNaveDataGridViewTextBoxColumn, Me.TipoEventoDataGridViewTextBoxColumn, Me.OrdenDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SPCONSULTATBLEVENTOSBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(950, 350)
        Me.DataGridView1.TabIndex = 0
        '
        'IdEventoDataGridViewTextBoxColumn
        '
        Me.IdEventoDataGridViewTextBoxColumn.DataPropertyName = "IdEvento"
        Me.IdEventoDataGridViewTextBoxColumn.HeaderText = "IdEvento"
        Me.IdEventoDataGridViewTextBoxColumn.Name = "IdEventoDataGridViewTextBoxColumn"
        Me.IdEventoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        '
        'InstruccionesDataGridViewTextBoxColumn
        '
        Me.InstruccionesDataGridViewTextBoxColumn.DataPropertyName = "Instrucciones"
        Me.InstruccionesDataGridViewTextBoxColumn.HeaderText = "Instrucciones"
        Me.InstruccionesDataGridViewTextBoxColumn.Name = "InstruccionesDataGridViewTextBoxColumn"
        '
        'InsumoDataGridViewTextBoxColumn
        '
        Me.InsumoDataGridViewTextBoxColumn.DataPropertyName = "Insumo"
        Me.InsumoDataGridViewTextBoxColumn.HeaderText = "Insumo"
        Me.InsumoDataGridViewTextBoxColumn.Name = "InsumoDataGridViewTextBoxColumn"
        '
        'LoteDataGridViewTextBoxColumn
        '
        Me.LoteDataGridViewTextBoxColumn.DataPropertyName = "Lote"
        Me.LoteDataGridViewTextBoxColumn.HeaderText = "Lote"
        Me.LoteDataGridViewTextBoxColumn.Name = "LoteDataGridViewTextBoxColumn"
        '
        'CamaraDataGridViewTextBoxColumn
        '
        Me.CamaraDataGridViewTextBoxColumn.DataPropertyName = "Camara"
        Me.CamaraDataGridViewTextBoxColumn.HeaderText = "Camara"
        Me.CamaraDataGridViewTextBoxColumn.Name = "CamaraDataGridViewTextBoxColumn"
        '
        'ConteoPlantaDataGridViewTextBoxColumn
        '
        Me.ConteoPlantaDataGridViewTextBoxColumn.DataPropertyName = "Conteo_Planta"
        Me.ConteoPlantaDataGridViewTextBoxColumn.HeaderText = "Conteo_Planta"
        Me.ConteoPlantaDataGridViewTextBoxColumn.Name = "ConteoPlantaDataGridViewTextBoxColumn"
        '
        'IdentNaveDataGridViewTextBoxColumn
        '
        Me.IdentNaveDataGridViewTextBoxColumn.DataPropertyName = "Ident_Nave"
        Me.IdentNaveDataGridViewTextBoxColumn.HeaderText = "Ident_Nave"
        Me.IdentNaveDataGridViewTextBoxColumn.Name = "IdentNaveDataGridViewTextBoxColumn"
        '
        'TipoEventoDataGridViewTextBoxColumn
        '
        Me.TipoEventoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Evento"
        Me.TipoEventoDataGridViewTextBoxColumn.HeaderText = "Tipo_Evento"
        Me.TipoEventoDataGridViewTextBoxColumn.Name = "TipoEventoDataGridViewTextBoxColumn"
        '
        'OrdenDataGridViewTextBoxColumn
        '
        Me.OrdenDataGridViewTextBoxColumn.DataPropertyName = "Orden"
        Me.OrdenDataGridViewTextBoxColumn.HeaderText = "Orden"
        Me.OrdenDataGridViewTextBoxColumn.Name = "OrdenDataGridViewTextBoxColumn"
        '
        'SPCONSULTATBLEVENTOSBindingSource
        '
        Me.SPCONSULTATBLEVENTOSBindingSource.DataMember = "SP_CONSULTA_TBL_EVENTOS"
        Me.SPCONSULTATBLEVENTOSBindingSource.DataSource = Me.GESTDataSet2
        '
        'GESTDataSet2
        '
        Me.GESTDataSet2.DataSetName = "GESTDataSet2"
        Me.GESTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_CONSULTA_TBL_EVENTOSTableAdapter
        '
        Me.SP_CONSULTA_TBL_EVENTOSTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(7, 183)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 39)
        Me.Button3.TabIndex = 124
        Me.Button3.Text = "Actualiza Evento"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Mantencion_Eventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 582)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Mantencion_Eventos"
        Me.Text = "Mantención Eventos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.grp_Insumo.ResumeLayout(False)
        Me.grp_Insumo.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPCONSULTATBLEVENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents txt_Orden As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Detalle As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_identNaveNO As System.Windows.Forms.RadioButton
    Friend WithEvents rb_identNave As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_PlantasNO As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Plantas As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_CamaraNO As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Camara As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_LoteNO As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Lote As System.Windows.Forms.RadioButton
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents grp_Insumo As System.Windows.Forms.GroupBox
    Friend WithEvents rb_insumoNO As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Insumo As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IdEventoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstruccionesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InsumoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CamaraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConteoPlantaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdentNaveDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoEventoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrdenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SPCONSULTATBLEVENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GESTDataSet2 As GestionVivero.GESTDataSet2
    Friend WithEvents SP_CONSULTA_TBL_EVENTOSTableAdapter As GestionVivero.GESTDataSet2TableAdapters.SP_CONSULTA_TBL_EVENTOSTableAdapter
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
