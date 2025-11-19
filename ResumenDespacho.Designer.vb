<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResumenDespacho
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GrillaResumen = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbVendedor = New System.Windows.Forms.ComboBox()
        Me.SPCONSULTAFULLVENDEDORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GESTDataSet34 = New GestionVivero.GESTDataSet34()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SP_CONSULTA_FULL_VENDEDORTableAdapter = New GestionVivero.GESTDataSet34TableAdapters.SP_CONSULTA_FULL_VENDEDORTableAdapter()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.GrillaResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPCONSULTAFULLVENDEDORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTDataSet34, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Image = Global.GestionVivero.My.Resources.Resources.salir_40x401
        Me.Cancel_Button.Location = New System.Drawing.Point(802, 424)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(50, 50)
        Me.Cancel_Button.TabIndex = 1
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.Color.White
        Me.OK_Button.Image = Global.GestionVivero.My.Resources.Resources.donaciones_40x40
        Me.OK_Button.Location = New System.Drawing.Point(750, 424)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(50, 50)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GrillaResumen)
        Me.Panel1.Location = New System.Drawing.Point(2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(852, 415)
        Me.Panel1.TabIndex = 1
        '
        'GrillaResumen
        '
        Me.GrillaResumen.AllowUserToAddRows = False
        Me.GrillaResumen.AllowUserToDeleteRows = False
        Me.GrillaResumen.BackgroundColor = System.Drawing.Color.White
        Me.GrillaResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaResumen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.GrillaResumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaResumen.Location = New System.Drawing.Point(0, 0)
        Me.GrillaResumen.Name = "GrillaResumen"
        Me.GrillaResumen.ReadOnly = True
        Me.GrillaResumen.RowHeadersVisible = False
        Me.GrillaResumen.Size = New System.Drawing.Size(852, 415)
        Me.GrillaResumen.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Cliente"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column2.HeaderText = "Cantidad Guías"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 97
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N0"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column3.HeaderText = "Total Bandejas"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 95
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N0"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column4.HeaderText = "Valor Total"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 77
        '
        'cmbVendedor
        '
        Me.cmbVendedor.DataSource = Me.SPCONSULTAFULLVENDEDORBindingSource
        Me.cmbVendedor.DisplayMember = "NOMBRE"
        Me.cmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVendedor.Enabled = False
        Me.cmbVendedor.FormattingEnabled = True
        Me.cmbVendedor.Location = New System.Drawing.Point(67, 434)
        Me.cmbVendedor.Name = "cmbVendedor"
        Me.cmbVendedor.Size = New System.Drawing.Size(143, 21)
        Me.cmbVendedor.TabIndex = 2
        Me.cmbVendedor.ValueMember = "IdVendedor"
        '
        'SPCONSULTAFULLVENDEDORBindingSource
        '
        Me.SPCONSULTAFULLVENDEDORBindingSource.DataMember = "SP_CONSULTA_FULL_VENDEDOR"
        Me.SPCONSULTAFULLVENDEDORBindingSource.DataSource = Me.GESTDataSet34
        '
        'GESTDataSet34
        '
        Me.GESTDataSet34.DataSetName = "GESTDataSet34"
        Me.GESTDataSet34.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 439)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Vendedor"
        '
        'SP_CONSULTA_FULL_VENDEDORTableAdapter
        '
        Me.SP_CONSULTA_FULL_VENDEDORTableAdapter.ClearBeforeFill = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'ResumenDespacho
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(858, 475)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbVendedor)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ResumenDespacho"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emisión de Guía automática"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrillaResumen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPCONSULTAFULLVENDEDORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTDataSet34, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GrillaResumen As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbVendedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GESTDataSet34 As GestionVivero.GESTDataSet34
    Friend WithEvents SPCONSULTAFULLVENDEDORBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SP_CONSULTA_FULL_VENDEDORTableAdapter As GestionVivero.GESTDataSet34TableAdapters.SP_CONSULTA_FULL_VENDEDORTableAdapter
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog

End Class
