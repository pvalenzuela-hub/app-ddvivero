<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreMOAct
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtpreciodetalleinvierno = New System.Windows.Forms.TextBox()
        Me.txtpreciointermedioinvierno = New System.Windows.Forms.TextBox()
        Me.txtpreciodetalleverano = New System.Windows.Forms.TextBox()
        Me.txtpreciointermedioverano = New System.Windows.Forms.TextBox()
        Me.txtpreciobaseinvierno = New System.Windows.Forms.TextBox()
        Me.txtfactordetalle = New System.Windows.Forms.TextBox()
        Me.txtfactorintermedio = New System.Windows.Forms.TextBox()
        Me.txtFactorinvierno = New System.Windows.Forms.TextBox()
        Me.txtPrecioBase = New System.Windows.Forms.TextBox()
        Me.cmb_Familia = New System.Windows.Forms.ComboBox()
        Me.cmb_TipoBandeja = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrillaPrecios = New System.Windows.Forms.DataGridView()
        Me.SPConsultaPreMOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GESTDataSet29 = New GestionVivero.GESTDataSet29()
        Me.SP_ConsultaPreMOTableAdapter = New GestionVivero.GESTDataSet29TableAdapters.SP_ConsultaPreMOTableAdapter()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioBaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FactorINVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioBaseINVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FactorInterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioInterVERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioInterINVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FactorDetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDetalleVERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDetalleINVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.GrillaPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPConsultaPreMOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTDataSet29, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtpreciodetalleinvierno)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtpreciointermedioinvierno)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtpreciodetalleverano)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtpreciointermedioverano)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtpreciobaseinvierno)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtfactordetalle)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtfactorintermedio)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtFactorinvierno)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPrecioBase)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmb_Familia)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmb_TipoBandeja)
        Me.SplitContainer1.Panel1.Controls.Add(Me.StatusStrip1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GrillaPrecios)
        Me.SplitContainer1.Size = New System.Drawing.Size(984, 651)
        Me.SplitContainer1.SplitterDistance = 257
        Me.SplitContainer1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button1.Location = New System.Drawing.Point(872, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 32)
        Me.Button1.TabIndex = 121
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtpreciodetalleinvierno
        '
        Me.txtpreciodetalleinvierno.Location = New System.Drawing.Point(872, 154)
        Me.txtpreciodetalleinvierno.Name = "txtpreciodetalleinvierno"
        Me.txtpreciodetalleinvierno.ReadOnly = True
        Me.txtpreciodetalleinvierno.Size = New System.Drawing.Size(100, 20)
        Me.txtpreciodetalleinvierno.TabIndex = 116
        '
        'txtpreciointermedioinvierno
        '
        Me.txtpreciointermedioinvierno.Location = New System.Drawing.Point(872, 112)
        Me.txtpreciointermedioinvierno.Name = "txtpreciointermedioinvierno"
        Me.txtpreciointermedioinvierno.ReadOnly = True
        Me.txtpreciointermedioinvierno.Size = New System.Drawing.Size(100, 20)
        Me.txtpreciointermedioinvierno.TabIndex = 115
        '
        'txtpreciodetalleverano
        '
        Me.txtpreciodetalleverano.Location = New System.Drawing.Point(611, 154)
        Me.txtpreciodetalleverano.Name = "txtpreciodetalleverano"
        Me.txtpreciodetalleverano.ReadOnly = True
        Me.txtpreciodetalleverano.Size = New System.Drawing.Size(100, 20)
        Me.txtpreciodetalleverano.TabIndex = 114
        '
        'txtpreciointermedioverano
        '
        Me.txtpreciointermedioverano.Location = New System.Drawing.Point(611, 112)
        Me.txtpreciointermedioverano.Name = "txtpreciointermedioverano"
        Me.txtpreciointermedioverano.ReadOnly = True
        Me.txtpreciointermedioverano.Size = New System.Drawing.Size(100, 20)
        Me.txtpreciointermedioverano.TabIndex = 113
        '
        'txtpreciobaseinvierno
        '
        Me.txtpreciobaseinvierno.Location = New System.Drawing.Point(872, 68)
        Me.txtpreciobaseinvierno.Name = "txtpreciobaseinvierno"
        Me.txtpreciobaseinvierno.ReadOnly = True
        Me.txtpreciobaseinvierno.Size = New System.Drawing.Size(100, 20)
        Me.txtpreciobaseinvierno.TabIndex = 112
        '
        'txtfactordetalle
        '
        Me.txtfactordetalle.Location = New System.Drawing.Point(350, 156)
        Me.txtfactordetalle.Name = "txtfactordetalle"
        Me.txtfactordetalle.Size = New System.Drawing.Size(100, 20)
        Me.txtfactordetalle.TabIndex = 111
        '
        'txtfactorintermedio
        '
        Me.txtfactorintermedio.Location = New System.Drawing.Point(350, 112)
        Me.txtfactorintermedio.Name = "txtfactorintermedio"
        Me.txtfactorintermedio.Size = New System.Drawing.Size(100, 20)
        Me.txtfactorintermedio.TabIndex = 110
        '
        'txtFactorinvierno
        '
        Me.txtFactorinvierno.Location = New System.Drawing.Point(350, 68)
        Me.txtFactorinvierno.Name = "txtFactorinvierno"
        Me.txtFactorinvierno.Size = New System.Drawing.Size(100, 20)
        Me.txtFactorinvierno.TabIndex = 109
        '
        'txtPrecioBase
        '
        Me.txtPrecioBase.Location = New System.Drawing.Point(115, 68)
        Me.txtPrecioBase.Name = "txtPrecioBase"
        Me.txtPrecioBase.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioBase.TabIndex = 108
        '
        'cmb_Familia
        '
        Me.cmb_Familia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Familia.DropDownWidth = 242
        Me.cmb_Familia.Enabled = False
        Me.cmb_Familia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Familia.ForeColor = System.Drawing.Color.Navy
        Me.cmb_Familia.FormattingEnabled = True
        Me.cmb_Familia.Location = New System.Drawing.Point(541, 18)
        Me.cmb_Familia.Name = "cmb_Familia"
        Me.cmb_Familia.Size = New System.Drawing.Size(242, 23)
        Me.cmb_Familia.TabIndex = 107
        '
        'cmb_TipoBandeja
        '
        Me.cmb_TipoBandeja.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_TipoBandeja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoBandeja.Enabled = False
        Me.cmb_TipoBandeja.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_TipoBandeja.ForeColor = System.Drawing.Color.Navy
        Me.cmb_TipoBandeja.FormattingEnabled = True
        Me.cmb_TipoBandeja.Location = New System.Drawing.Point(115, 18)
        Me.cmb_TipoBandeja.Name = "cmb_TipoBandeja"
        Me.cmb_TipoBandeja.Size = New System.Drawing.Size(242, 23)
        Me.cmb_TipoBandeja.TabIndex = 106
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripDropDownButton2, Me.ToolStripDropDownButton3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 235)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(984, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.Image = Global.GestionVivero.My.Resources.Resources.Notes
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton2.Image = Global.GestionVivero.My.Resources.Resources.Add
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripDropDownButton2.Text = "ToolStripDropDownButton2"
        '
        'ToolStripDropDownButton3
        '
        Me.ToolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton3.Image = Global.GestionVivero.My.Resources.Resources.Delete
        Me.ToolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton3.Name = "ToolStripDropDownButton3"
        Me.ToolStripDropDownButton3.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripDropDownButton3.Text = "ToolStripDropDownButton3"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(742, 71)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Precio base invierno"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(742, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Precio detalle invierno"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(742, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Precio intermedio invierno"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(480, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Precio detalle verano"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(480, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Precio intermedio verano"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(274, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Factor detalle"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(257, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Factor intermedio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(267, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Factor Invierno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio Base"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(480, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Especie"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo Bandeja"
        '
        'GrillaPrecios
        '
        Me.GrillaPrecios.AllowUserToAddRows = False
        Me.GrillaPrecios.AllowUserToDeleteRows = False
        Me.GrillaPrecios.AutoGenerateColumns = False
        Me.GrillaPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaPrecios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescripcionDataGridViewTextBoxColumn, Me.DESCRIPDataGridViewTextBoxColumn, Me.PrecioBaseDataGridViewTextBoxColumn, Me.FactorINVDataGridViewTextBoxColumn, Me.PrecioBaseINVDataGridViewTextBoxColumn, Me.FactorInterDataGridViewTextBoxColumn, Me.PrecioInterVERDataGridViewTextBoxColumn, Me.PrecioInterINVDataGridViewTextBoxColumn, Me.FactorDetalleDataGridViewTextBoxColumn, Me.PrecioDetalleVERDataGridViewTextBoxColumn, Me.PrecioDetalleINVDataGridViewTextBoxColumn})
        Me.GrillaPrecios.DataSource = Me.SPConsultaPreMOBindingSource
        Me.GrillaPrecios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaPrecios.Location = New System.Drawing.Point(0, 0)
        Me.GrillaPrecios.Name = "GrillaPrecios"
        Me.GrillaPrecios.ReadOnly = True
        Me.GrillaPrecios.Size = New System.Drawing.Size(984, 390)
        Me.GrillaPrecios.TabIndex = 0
        '
        'SPConsultaPreMOBindingSource
        '
        Me.SPConsultaPreMOBindingSource.DataMember = "SP_ConsultaPreMO"
        Me.SPConsultaPreMOBindingSource.DataSource = Me.GESTDataSet29
        '
        'GESTDataSet29
        '
        Me.GESTDataSet29.DataSetName = "GESTDataSet29"
        Me.GESTDataSet29.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_ConsultaPreMOTableAdapter
        '
        Me.SP_ConsultaPreMOTableAdapter.ClearBeforeFill = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Bandeja"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DESCRIPDataGridViewTextBoxColumn
        '
        Me.DESCRIPDataGridViewTextBoxColumn.DataPropertyName = "DESCRIP"
        Me.DESCRIPDataGridViewTextBoxColumn.HeaderText = "Especie"
        Me.DESCRIPDataGridViewTextBoxColumn.Name = "DESCRIPDataGridViewTextBoxColumn"
        Me.DESCRIPDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioBaseDataGridViewTextBoxColumn
        '
        Me.PrecioBaseDataGridViewTextBoxColumn.DataPropertyName = "PrecioBase"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.PrecioBaseDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.PrecioBaseDataGridViewTextBoxColumn.HeaderText = "Precio Base"
        Me.PrecioBaseDataGridViewTextBoxColumn.Name = "PrecioBaseDataGridViewTextBoxColumn"
        Me.PrecioBaseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FactorINVDataGridViewTextBoxColumn
        '
        Me.FactorINVDataGridViewTextBoxColumn.DataPropertyName = "FactorINV"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.FactorINVDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.FactorINVDataGridViewTextBoxColumn.HeaderText = "Factor invierno"
        Me.FactorINVDataGridViewTextBoxColumn.Name = "FactorINVDataGridViewTextBoxColumn"
        Me.FactorINVDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioBaseINVDataGridViewTextBoxColumn
        '
        Me.PrecioBaseINVDataGridViewTextBoxColumn.DataPropertyName = "PrecioBaseINV"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.PrecioBaseINVDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.PrecioBaseINVDataGridViewTextBoxColumn.HeaderText = "Precio Base invierno"
        Me.PrecioBaseINVDataGridViewTextBoxColumn.Name = "PrecioBaseINVDataGridViewTextBoxColumn"
        Me.PrecioBaseINVDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FactorInterDataGridViewTextBoxColumn
        '
        Me.FactorInterDataGridViewTextBoxColumn.DataPropertyName = "FactorInter"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.FactorInterDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.FactorInterDataGridViewTextBoxColumn.HeaderText = "Factor intermedio"
        Me.FactorInterDataGridViewTextBoxColumn.Name = "FactorInterDataGridViewTextBoxColumn"
        Me.FactorInterDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioInterVERDataGridViewTextBoxColumn
        '
        Me.PrecioInterVERDataGridViewTextBoxColumn.DataPropertyName = "PrecioInterVER"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.PrecioInterVERDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.PrecioInterVERDataGridViewTextBoxColumn.HeaderText = "Precio intermedio verano"
        Me.PrecioInterVERDataGridViewTextBoxColumn.Name = "PrecioInterVERDataGridViewTextBoxColumn"
        Me.PrecioInterVERDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioInterINVDataGridViewTextBoxColumn
        '
        Me.PrecioInterINVDataGridViewTextBoxColumn.DataPropertyName = "PrecioInterINV"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.PrecioInterINVDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.PrecioInterINVDataGridViewTextBoxColumn.HeaderText = "Precio intermedio invierno"
        Me.PrecioInterINVDataGridViewTextBoxColumn.Name = "PrecioInterINVDataGridViewTextBoxColumn"
        Me.PrecioInterINVDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FactorDetalleDataGridViewTextBoxColumn
        '
        Me.FactorDetalleDataGridViewTextBoxColumn.DataPropertyName = "FactorDetalle"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.FactorDetalleDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.FactorDetalleDataGridViewTextBoxColumn.HeaderText = "Factor detalle"
        Me.FactorDetalleDataGridViewTextBoxColumn.Name = "FactorDetalleDataGridViewTextBoxColumn"
        Me.FactorDetalleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDetalleVERDataGridViewTextBoxColumn
        '
        Me.PrecioDetalleVERDataGridViewTextBoxColumn.DataPropertyName = "PrecioDetalleVER"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.PrecioDetalleVERDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.PrecioDetalleVERDataGridViewTextBoxColumn.HeaderText = "Precio detalle verano"
        Me.PrecioDetalleVERDataGridViewTextBoxColumn.Name = "PrecioDetalleVERDataGridViewTextBoxColumn"
        Me.PrecioDetalleVERDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDetalleINVDataGridViewTextBoxColumn
        '
        Me.PrecioDetalleINVDataGridViewTextBoxColumn.DataPropertyName = "PrecioDetalleINV"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.PrecioDetalleINVDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.PrecioDetalleINVDataGridViewTextBoxColumn.HeaderText = "Precio detalle invierno"
        Me.PrecioDetalleINVDataGridViewTextBoxColumn.Name = "PrecioDetalleINVDataGridViewTextBoxColumn"
        Me.PrecioDetalleINVDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PreMOAct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 651)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PreMOAct"
        Me.Text = "PreMOAct"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.GrillaPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPConsultaPreMOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTDataSet29, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripDropDownButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripDropDownButton3 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrillaPrecios As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_TipoBandeja As System.Windows.Forms.ComboBox
    Friend WithEvents txtpreciodetalleinvierno As System.Windows.Forms.TextBox
    Friend WithEvents txtpreciointermedioinvierno As System.Windows.Forms.TextBox
    Friend WithEvents txtpreciodetalleverano As System.Windows.Forms.TextBox
    Friend WithEvents txtpreciointermedioverano As System.Windows.Forms.TextBox
    Friend WithEvents txtpreciobaseinvierno As System.Windows.Forms.TextBox
    Friend WithEvents txtfactordetalle As System.Windows.Forms.TextBox
    Friend WithEvents txtfactorintermedio As System.Windows.Forms.TextBox
    Friend WithEvents txtFactorinvierno As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioBase As System.Windows.Forms.TextBox
    Friend WithEvents cmb_Familia As System.Windows.Forms.ComboBox
    Friend WithEvents GESTDataSet29 As GestionVivero.GESTDataSet29
    Friend WithEvents SPConsultaPreMOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SP_ConsultaPreMOTableAdapter As GestionVivero.GESTDataSet29TableAdapters.SP_ConsultaPreMOTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioBaseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FactorINVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioBaseINVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FactorInterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioInterVERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioInterINVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FactorDetalleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioDetalleVERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioDetalleINVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
