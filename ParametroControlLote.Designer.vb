<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParametroControlLote
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_Codigo = New System.Windows.Forms.MaskedTextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txt_Descripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdTablaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SPReporteParametroControlLoteBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpReporteLotesSinGuia = New GestionVivero.SpReporteLotesSinGuia()
        Me.SPReporteParametroControlLoteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_ReporteParametroControlLoteTableAdapter = New GestionVivero.SpReporteLotesSinGuiaTableAdapters.SP_ReporteParametroControlLoteTableAdapter()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPReporteParametroControlLoteBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpReporteLotesSinGuia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPReporteParametroControlLoteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Codigo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Descripcion)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadioButton4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadioButton3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadioButton2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadioButton1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(853, 496)
        Me.SplitContainer1.SplitterDistance = 103
        Me.SplitContainer1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button1.Location = New System.Drawing.Point(678, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 34)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Location = New System.Drawing.Point(171, 62)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(40, 20)
        Me.txt_Codigo.TabIndex = 7
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(272, 66)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(63, 13)
        Me.label2.TabIndex = 6
        Me.label2.Text = "Descripción"
        '
        'txt_Descripcion
        '
        Me.txt_Descripcion.Location = New System.Drawing.Point(341, 62)
        Me.txt_Descripcion.MaxLength = 50
        Me.txt_Descripcion.Name = "txt_Descripcion"
        Me.txt_Descripcion.Size = New System.Drawing.Size(234, 20)
        Me.txt_Descripcion.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(125, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Código"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(683, 12)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(132, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Control Observaciones"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(486, 12)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(129, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Control Enfermedades"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(263, 12)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(93, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Control Cliente"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(37, 12)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(98, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Control Entrega"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.Delete
        Me.Button2.Location = New System.Drawing.Point(772, 53)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 34)
        Me.Button2.TabIndex = 9
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdTablaDataGridViewTextBoxColumn, Me.Column1DataGridViewTextBoxColumn, Me.CodigoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SPReporteParametroControlLoteBindingSource1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(853, 389)
        Me.DataGridView1.TabIndex = 0
        '
        'IdTablaDataGridViewTextBoxColumn
        '
        Me.IdTablaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IdTablaDataGridViewTextBoxColumn.DataPropertyName = "IdTabla"
        Me.IdTablaDataGridViewTextBoxColumn.HeaderText = "Nº Registro"
        Me.IdTablaDataGridViewTextBoxColumn.Name = "IdTablaDataGridViewTextBoxColumn"
        Me.IdTablaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdTablaDataGridViewTextBoxColumn.Width = 86
        '
        'Column1DataGridViewTextBoxColumn
        '
        Me.Column1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1DataGridViewTextBoxColumn.DataPropertyName = "Column1"
        Me.Column1DataGridViewTextBoxColumn.HeaderText = "Tipo Tabla"
        Me.Column1DataGridViewTextBoxColumn.Name = "Column1DataGridViewTextBoxColumn"
        Me.Column1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.Width = 65
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        '
        'SPReporteParametroControlLoteBindingSource1
        '
        Me.SPReporteParametroControlLoteBindingSource1.DataMember = "SP_ReporteParametroControlLote"
        Me.SPReporteParametroControlLoteBindingSource1.DataSource = Me.SpReporteLotesSinGuia
        '
        'SpReporteLotesSinGuia
        '
        Me.SpReporteLotesSinGuia.DataSetName = "SpReporteLotesSinGuia"
        Me.SpReporteLotesSinGuia.Locale = New System.Globalization.CultureInfo("es-CL")
        Me.SpReporteLotesSinGuia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SPReporteParametroControlLoteBindingSource
        '
        Me.SPReporteParametroControlLoteBindingSource.DataMember = "SP_ReporteParametroControlLote"
        Me.SPReporteParametroControlLoteBindingSource.DataSource = Me.SpReporteLotesSinGuia
        '
        'SP_ReporteParametroControlLoteTableAdapter
        '
        Me.SP_ReporteParametroControlLoteTableAdapter.ClearBeforeFill = True
        '
        'ParametroControlLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 496)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ParametroControlLote"
        Me.Text = "ParametroControlLote"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPReporteParametroControlLoteBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpReporteLotesSinGuia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPReporteParametroControlLoteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents txt_Codigo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SPReporteParametroControlLoteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpReporteLotesSinGuia As GestionVivero.SpReporteLotesSinGuia
    Friend WithEvents SP_ReporteParametroControlLoteTableAdapter As GestionVivero.SpReporteLotesSinGuiaTableAdapters.SP_ReporteParametroControlLoteTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SPReporteParametroControlLoteBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents IdTablaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
