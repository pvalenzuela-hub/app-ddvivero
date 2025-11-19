<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlDesp
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtIDcliente = New System.Windows.Forms.TextBox()
        Me.txtbuscacli = New System.Windows.Forms.TextBox()
        Me.rdbcli = New System.Windows.Forms.RadioButton()
        Me.btnbuscacli = New System.Windows.Forms.Button()
        Me.rdbfecha = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.txtTotalBand = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPatente = New System.Windows.Forms.TextBox()
        Me.txtNomChofer = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GrillaDespacho = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OrdenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GrillaDespacho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtIDcliente)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtbuscacli)
        Me.SplitContainer1.Panel1.Controls.Add(Me.rdbcli)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnbuscacli)
        Me.SplitContainer1.Panel1.Controls.Add(Me.rdbfecha)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbEstado)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtTotalBand)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPatente)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtNomChofer)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTimePicker1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GrillaDespacho)
        Me.SplitContainer1.Size = New System.Drawing.Size(984, 612)
        Me.SplitContainer1.SplitterDistance = 244
        Me.SplitContainer1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.Despacho99x72
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(657, 199)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 38)
        Me.Button2.TabIndex = 51
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtIDcliente
        '
        Me.txtIDcliente.Location = New System.Drawing.Point(898, 19)
        Me.txtIDcliente.Name = "txtIDcliente"
        Me.txtIDcliente.Size = New System.Drawing.Size(67, 20)
        Me.txtIDcliente.TabIndex = 50
        Me.txtIDcliente.Visible = False
        '
        'txtbuscacli
        '
        Me.txtbuscacli.Location = New System.Drawing.Point(474, 18)
        Me.txtbuscacli.MaxLength = 30
        Me.txtbuscacli.Name = "txtbuscacli"
        Me.txtbuscacli.Size = New System.Drawing.Size(355, 20)
        Me.txtbuscacli.TabIndex = 49
        '
        'rdbcli
        '
        Me.rdbcli.AutoSize = True
        Me.rdbcli.Checked = True
        Me.rdbcli.Location = New System.Drawing.Point(357, 20)
        Me.rdbcli.Name = "rdbcli"
        Me.rdbcli.Size = New System.Drawing.Size(111, 17)
        Me.rdbcli.TabIndex = 48
        Me.rdbcli.TabStop = True
        Me.rdbcli.Text = "Buscar por Cliente"
        Me.rdbcli.UseVisualStyleBackColor = True
        '
        'btnbuscacli
        '
        Me.btnbuscacli.Image = Global.GestionVivero.My.Resources.Resources.PREVIEW
        Me.btnbuscacli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbuscacli.Location = New System.Drawing.Point(831, 16)
        Me.btnbuscacli.Name = "btnbuscacli"
        Me.btnbuscacli.Size = New System.Drawing.Size(24, 24)
        Me.btnbuscacli.TabIndex = 47
        Me.btnbuscacli.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnbuscacli.UseVisualStyleBackColor = True
        '
        'rdbfecha
        '
        Me.rdbfecha.AutoSize = True
        Me.rdbfecha.Location = New System.Drawing.Point(42, 20)
        Me.rdbfecha.Name = "rdbfecha"
        Me.rdbfecha.Size = New System.Drawing.Size(109, 17)
        Me.rdbfecha.TabIndex = 45
        Me.rdbfecha.Text = "Buscar por Fecha"
        Me.rdbfecha.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Estado"
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Vigente", "Despachado", "Anulado"})
        Me.cmbEstado.Location = New System.Drawing.Point(124, 157)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(141, 21)
        Me.cmbEstado.TabIndex = 16
        '
        'txtTotalBand
        '
        Me.txtTotalBand.Location = New System.Drawing.Point(854, 221)
        Me.txtTotalBand.Name = "txtTotalBand"
        Me.txtTotalBand.ReadOnly = True
        Me.txtTotalBand.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalBand.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(839, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Total Bandejas Despacho:"
        '
        'Button1
        '
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(297, 204)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 38)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Crear Despacho"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtPatente
        '
        Me.txtPatente.Location = New System.Drawing.Point(124, 120)
        Me.txtPatente.MaxLength = 10
        Me.txtPatente.Name = "txtPatente"
        Me.txtPatente.Size = New System.Drawing.Size(141, 20)
        Me.txtPatente.TabIndex = 7
        '
        'txtNomChofer
        '
        Me.txtNomChofer.Location = New System.Drawing.Point(124, 83)
        Me.txtNomChofer.MaxLength = 30
        Me.txtNomChofer.Name = "txtNomChofer"
        Me.txtNomChofer.Size = New System.Drawing.Size(355, 20)
        Me.txtNomChofer.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Patente Vehìculo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Chofer"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(176, 18)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(89, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'GrillaDespacho
        '
        Me.GrillaDespacho.AllowUserToAddRows = False
        Me.GrillaDespacho.AllowUserToDeleteRows = False
        Me.GrillaDespacho.AllowUserToOrderColumns = True
        Me.GrillaDespacho.BackgroundColor = System.Drawing.Color.White
        Me.GrillaDespacho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaDespacho.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        Me.GrillaDespacho.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaDespacho.Location = New System.Drawing.Point(0, 0)
        Me.GrillaDespacho.Name = "GrillaDespacho"
        Me.GrillaDespacho.RowHeadersVisible = False
        Me.GrillaDespacho.Size = New System.Drawing.Size(984, 364)
        Me.GrillaDespacho.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column1.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.HeaderText = "Orden"
        Me.Column1.Name = "Column1"
        Me.Column1.ToolTipText = "Existen opciones con el botón derecho del mouse"
        Me.Column1.Width = 61
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrdenToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(182, 26)
        '
        'OrdenToolStripMenuItem
        '
        Me.OrdenToolStripMenuItem.Name = "OrdenToolStripMenuItem"
        Me.OrdenToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.OrdenToolStripMenuItem.Text = "Completar Nª orden"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column2.HeaderText = "Nº Lote"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 68
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column3.HeaderText = "Sector"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 63
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column4.HeaderText = "Zona"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 57
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column5.HeaderText = "Cliente"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 64
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column6.HeaderText = "Fono"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 56
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column7.HeaderText = "Acuerdo"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 72
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column8.HeaderText = "Especie"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 70
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column9.HeaderText = "Variedad"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 74
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column10.HeaderText = "Bandejas"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 76
        '
        'Column11
        '
        Me.Column11.HeaderText = "A preparación"
        Me.Column11.Name = "Column11"
        '
        'CtlDesp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 612)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "CtlDesp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Creación Despachos"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GrillaDespacho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GrillaDespacho As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtPatente As System.Windows.Forms.TextBox
    Friend WithEvents txtNomChofer As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTotalBand As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OrdenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents rdbfecha As System.Windows.Forms.RadioButton
    Friend WithEvents txtbuscacli As System.Windows.Forms.TextBox
    Friend WithEvents rdbcli As System.Windows.Forms.RadioButton
    Friend WithEvents btnbuscacli As System.Windows.Forms.Button
    Friend WithEvents txtIDcliente As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewCheckBoxColumn
End Class
