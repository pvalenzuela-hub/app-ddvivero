<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_Control_Lote
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GrillaInventario = New System.Windows.Forms.DataGridView()
        Me.item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.semilla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fonos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.especie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.variedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stockres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.insumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fentrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fcontrol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctl01 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ctl02 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ctl03 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ctl04 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.GrillaInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrillaInventario
        '
        Me.GrillaInventario.AllowDrop = True
        Me.GrillaInventario.AllowUserToAddRows = False
        Me.GrillaInventario.AllowUserToDeleteRows = False
        Me.GrillaInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.GrillaInventario.BackgroundColor = System.Drawing.SystemColors.Window
        Me.GrillaInventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.GrillaInventario.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.GrillaInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GrillaInventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item, Me.id, Me.semilla, Me.cliente, Me.Fonos, Me.especie, Me.variedad, Me.stockres, Me.insumo, Me.fentrega, Me.fcontrol, Me.ctl01, Me.ctl02, Me.ctl03, Me.ctl04})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrillaInventario.DefaultCellStyle = DataGridViewCellStyle7
        Me.GrillaInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaInventario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.GrillaInventario.GridColor = System.Drawing.Color.Navy
        Me.GrillaInventario.Location = New System.Drawing.Point(0, 0)
        Me.GrillaInventario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GrillaInventario.Name = "GrillaInventario"
        Me.GrillaInventario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.GrillaInventario.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.GrillaInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GrillaInventario.Size = New System.Drawing.Size(1249, 514)
        Me.GrillaInventario.TabIndex = 2
        '
        'item
        '
        Me.item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.item.Frozen = True
        Me.item.HeaderText = "N° Nave"
        Me.item.Name = "item"
        Me.item.ReadOnly = True
        Me.item.Width = 73
        '
        'id
        '
        Me.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.id.Frozen = True
        Me.id.HeaderText = "Mesa"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 58
        '
        'semilla
        '
        Me.semilla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.semilla.DefaultCellStyle = DataGridViewCellStyle1
        Me.semilla.Frozen = True
        Me.semilla.HeaderText = "N° Lote"
        Me.semilla.Name = "semilla"
        Me.semilla.ReadOnly = True
        Me.semilla.Width = 68
        '
        'cliente
        '
        Me.cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.cliente.Frozen = True
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        Me.cliente.Width = 64
        '
        'Fonos
        '
        Me.Fonos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Fonos.Frozen = True
        Me.Fonos.HeaderText = "Teléfonos"
        Me.Fonos.Name = "Fonos"
        Me.Fonos.Width = 79
        '
        'especie
        '
        Me.especie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.especie.HeaderText = "Especie"
        Me.especie.Name = "especie"
        Me.especie.ReadOnly = True
        Me.especie.Width = 70
        '
        'variedad
        '
        Me.variedad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.variedad.HeaderText = "Variedad"
        Me.variedad.Name = "variedad"
        Me.variedad.ReadOnly = True
        Me.variedad.Width = 74
        '
        'stockres
        '
        Me.stockres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.stockres.DefaultCellStyle = DataGridViewCellStyle2
        Me.stockres.HeaderText = "N° Band"
        Me.stockres.Name = "stockres"
        Me.stockres.ReadOnly = True
        Me.stockres.Width = 72
        '
        'insumo
        '
        Me.insumo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.insumo.DefaultCellStyle = DataGridViewCellStyle3
        Me.insumo.HeaderText = "Conteo"
        Me.insumo.Name = "insumo"
        Me.insumo.ReadOnly = True
        Me.insumo.Width = 66
        '
        'fentrega
        '
        Me.fentrega.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.fentrega.HeaderText = "Fecha Entrega"
        Me.fentrega.Name = "fentrega"
        Me.fentrega.Width = 102
        '
        'fcontrol
        '
        Me.fcontrol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.fcontrol.DefaultCellStyle = DataGridViewCellStyle4
        Me.fcontrol.HeaderText = "Fecha Control"
        Me.fcontrol.MaxInputLength = 10
        Me.fcontrol.Name = "fcontrol"
        Me.fcontrol.Width = 98
        '
        'ctl01
        '
        Me.ctl01.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ctl01.DefaultCellStyle = DataGridViewCellStyle5
        Me.ctl01.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.ctl01.HeaderText = "Control Entrega"
        Me.ctl01.Name = "ctl01"
        Me.ctl01.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ctl01.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ctl02
        '
        Me.ctl02.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ctl02.DefaultCellStyle = DataGridViewCellStyle6
        Me.ctl02.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.ctl02.HeaderText = "Control Cliente"
        Me.ctl02.Name = "ctl02"
        Me.ctl02.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ctl02.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ctl03
        '
        Me.ctl03.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ctl03.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.ctl03.HeaderText = "Control Enfermedades"
        Me.ctl03.Name = "ctl03"
        Me.ctl03.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ctl03.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ctl04
        '
        Me.ctl04.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ctl04.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.ctl04.HeaderText = "Control Observaciones"
        Me.ctl04.Name = "ctl04"
        Me.ctl04.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ctl04.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GrillaInventario)
        Me.SplitContainer1.Size = New System.Drawing.Size(1249, 562)
        Me.SplitContainer1.SplitterDistance = 44
        Me.SplitContainer1.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.PREVIEW
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(1087, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 33)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Reporte"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(545, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 33)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Grabar Control de Lote"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Registro_Control_Lote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1249, 562)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Registro_Control_Lote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Control Lote"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GrillaInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrillaInventario As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents semilla As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fonos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents especie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents variedad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stockres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents insumo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fentrega As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fcontrol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ctl01 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ctl02 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ctl03 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ctl04 As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
