<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrepDespLote
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtNumLote = New System.Windows.Forms.TextBox()
        Me.btnBuscaLote = New System.Windows.Forms.Button()
        Me.dtpFecRepLotesConf = New System.Windows.Forms.DateTimePicker()
        Me.GrillaDespacho = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colu1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colu4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colu7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colu2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colu3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colu5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colu6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GuardarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LotesConfirmadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteLotesPreparadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LotesPreparadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IrAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaLoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrillaSector = New System.Windows.Forms.DataGridView()
        Me.c1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrillaFecha = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrillaPreparacion = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GrillaDespacho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GrillaSector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaPreparacion, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtNumLote)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnBuscaLote)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpFecRepLotesConf)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GrillaDespacho)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GrillaSector)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GrillaFecha)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GrillaPreparacion)
        Me.SplitContainer1.Size = New System.Drawing.Size(1016, 644)
        Me.SplitContainer1.SplitterDistance = 439
        Me.SplitContainer1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.Close
        Me.Button2.Location = New System.Drawing.Point(962, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 38)
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button1.Location = New System.Drawing.Point(914, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 38)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtNumLote
        '
        Me.txtNumLote.Location = New System.Drawing.Point(208, 12)
        Me.txtNumLote.Name = "txtNumLote"
        Me.txtNumLote.Size = New System.Drawing.Size(100, 20)
        Me.txtNumLote.TabIndex = 3
        '
        'btnBuscaLote
        '
        Me.btnBuscaLote.Location = New System.Drawing.Point(308, 11)
        Me.btnBuscaLote.Name = "btnBuscaLote"
        Me.btnBuscaLote.Size = New System.Drawing.Size(25, 23)
        Me.btnBuscaLote.TabIndex = 2
        Me.btnBuscaLote.Text = "..."
        Me.btnBuscaLote.UseVisualStyleBackColor = True
        '
        'dtpFecRepLotesConf
        '
        Me.dtpFecRepLotesConf.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecRepLotesConf.Location = New System.Drawing.Point(707, 12)
        Me.dtpFecRepLotesConf.Name = "dtpFecRepLotesConf"
        Me.dtpFecRepLotesConf.Size = New System.Drawing.Size(115, 20)
        Me.dtpFecRepLotesConf.TabIndex = 1
        Me.dtpFecRepLotesConf.Visible = False
        '
        'GrillaDespacho
        '
        Me.GrillaDespacho.AllowUserToDeleteRows = False
        Me.GrillaDespacho.AllowUserToOrderColumns = True
        Me.GrillaDespacho.BackgroundColor = System.Drawing.Color.White
        Me.GrillaDespacho.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GrillaDespacho.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GrillaDespacho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.GrillaDespacho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaDespacho.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.colu1, Me.colu4, Me.colu7, Me.c11, Me.c12, Me.col10, Me.col9, Me.col8, Me.colu2, Me.colu3, Me.colu5, Me.colu6})
        Me.GrillaDespacho.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GrillaDespacho.Location = New System.Drawing.Point(2, 43)
        Me.GrillaDespacho.Name = "GrillaDespacho"
        Me.GrillaDespacho.RowHeadersVisible = False
        Me.GrillaDespacho.Size = New System.Drawing.Size(1011, 393)
        Me.GrillaDespacho.StandardTab = True
        Me.GrillaDespacho.TabIndex = 0
        '
        'sel
        '
        Me.sel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.sel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sel.HeaderText = "Conf."
        Me.sel.Name = "sel"
        Me.sel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.sel.Width = 57
        '
        'colu1
        '
        Me.colu1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colu1.HeaderText = "Nº Lote"
        Me.colu1.Name = "colu1"
        Me.colu1.Width = 63
        '
        'colu4
        '
        Me.colu4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colu4.HeaderText = "Cliente"
        Me.colu4.Name = "colu4"
        Me.colu4.ReadOnly = True
        Me.colu4.Width = 64
        '
        'colu7
        '
        Me.colu7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colu7.HeaderText = "Fono"
        Me.colu7.Name = "colu7"
        Me.colu7.ReadOnly = True
        Me.colu7.Width = 56
        '
        'c11
        '
        Me.c11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.c11.DefaultCellStyle = DataGridViewCellStyle7
        Me.c11.HeaderText = "Pedido"
        Me.c11.Name = "c11"
        Me.c11.Width = 65
        '
        'c12
        '
        Me.c12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N0"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.c12.DefaultCellStyle = DataGridViewCellStyle8
        Me.c12.HeaderText = "Saldo"
        Me.c12.Name = "c12"
        Me.c12.Width = 59
        '
        'col10
        '
        Me.col10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N0"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.col10.DefaultCellStyle = DataGridViewCellStyle9
        Me.col10.HeaderText = "Bandejas"
        Me.col10.Name = "col10"
        Me.col10.ReadOnly = True
        Me.col10.Width = 76
        '
        'col9
        '
        Me.col9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.col9.HeaderText = "Fecha Despacho"
        Me.col9.Name = "col9"
        Me.col9.Width = 105
        '
        'col8
        '
        Me.col8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.col8.HeaderText = "Acuerdo comercial"
        Me.col8.Name = "col8"
        Me.col8.Width = 110
        '
        'colu2
        '
        Me.colu2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colu2.HeaderText = "Especie"
        Me.colu2.Name = "colu2"
        Me.colu2.ReadOnly = True
        Me.colu2.Width = 70
        '
        'colu3
        '
        Me.colu3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colu3.HeaderText = "Variedad"
        Me.colu3.Name = "colu3"
        Me.colu3.ReadOnly = True
        Me.colu3.Width = 74
        '
        'colu5
        '
        Me.colu5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colu5.HeaderText = "Sector"
        Me.colu5.Name = "colu5"
        Me.colu5.ReadOnly = True
        Me.colu5.Width = 63
        '
        'colu6
        '
        Me.colu6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colu6.HeaderText = "Zona"
        Me.colu6.Name = "colu6"
        Me.colu6.ReadOnly = True
        Me.colu6.Width = 57
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarDatosToolStripMenuItem, Me.SalirToolStripMenuItem, Me.ToolStripSeparator1, Me.ToolStripMenuItem1, Me.ToolStripSeparator2, Me.LotesConfirmadosToolStripMenuItem, Me.ReporteLotesPreparadosToolStripMenuItem, Me.LotesPreparadosToolStripMenuItem, Me.IrAToolStripMenuItem, Me.ConsultaLoteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(235, 192)
        '
        'GuardarDatosToolStripMenuItem
        '
        Me.GuardarDatosToolStripMenuItem.Name = "GuardarDatosToolStripMenuItem"
        Me.GuardarDatosToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.GuardarDatosToolStripMenuItem.Text = "Guardar Datos"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(231, 6)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(234, 22)
        Me.ToolStripMenuItem1.Text = "Elimina Lote"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(231, 6)
        '
        'LotesConfirmadosToolStripMenuItem
        '
        Me.LotesConfirmadosToolStripMenuItem.Name = "LotesConfirmadosToolStripMenuItem"
        Me.LotesConfirmadosToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.LotesConfirmadosToolStripMenuItem.Text = "Consulta Lotes Confirmados"
        '
        'ReporteLotesPreparadosToolStripMenuItem
        '
        Me.ReporteLotesPreparadosToolStripMenuItem.Name = "ReporteLotesPreparadosToolStripMenuItem"
        Me.ReporteLotesPreparadosToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.ReporteLotesPreparadosToolStripMenuItem.Text = "Reporte de Lotes Confirmados"
        '
        'LotesPreparadosToolStripMenuItem
        '
        Me.LotesPreparadosToolStripMenuItem.Name = "LotesPreparadosToolStripMenuItem"
        Me.LotesPreparadosToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.LotesPreparadosToolStripMenuItem.Text = "Consulta Lotes Preparados"
        '
        'IrAToolStripMenuItem
        '
        Me.IrAToolStripMenuItem.Name = "IrAToolStripMenuItem"
        Me.IrAToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.IrAToolStripMenuItem.Text = "Ir a Creación de Despachos"
        '
        'ConsultaLoteToolStripMenuItem
        '
        Me.ConsultaLoteToolStripMenuItem.Name = "ConsultaLoteToolStripMenuItem"
        Me.ConsultaLoteToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.ConsultaLoteToolStripMenuItem.Text = "Consulta Lote"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Button3.Image = Global.GestionVivero.My.Resources.Resources.Despacho99x72
        Me.Button3.Location = New System.Drawing.Point(561, 10)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 38)
        Me.Button3.TabIndex = 6
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(734, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Lotes confirmados por sector"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(400, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Lotes confirmados por fecha despacho"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Lotes en preparación por sector"
        '
        'GrillaSector
        '
        Me.GrillaSector.AllowUserToAddRows = False
        Me.GrillaSector.AllowUserToDeleteRows = False
        Me.GrillaSector.BackgroundColor = System.Drawing.Color.White
        Me.GrillaSector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaSector.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c1, Me.c2, Me.c3})
        Me.GrillaSector.Location = New System.Drawing.Point(627, 69)
        Me.GrillaSector.Name = "GrillaSector"
        Me.GrillaSector.ReadOnly = True
        Me.GrillaSector.RowHeadersVisible = False
        Me.GrillaSector.Size = New System.Drawing.Size(377, 127)
        Me.GrillaSector.TabIndex = 5
        '
        'c1
        '
        Me.c1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.c1.HeaderText = "Sector"
        Me.c1.Name = "c1"
        Me.c1.ReadOnly = True
        '
        'c2
        '
        Me.c2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.c2.HeaderText = "Zona"
        Me.c2.Name = "c2"
        Me.c2.ReadOnly = True
        '
        'c3
        '
        Me.c3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N0"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.c3.DefaultCellStyle = DataGridViewCellStyle10
        Me.c3.HeaderText = "Total Band"
        Me.c3.Name = "c3"
        Me.c3.ReadOnly = True
        Me.c3.Width = 84
        '
        'GrillaFecha
        '
        Me.GrillaFecha.AllowUserToAddRows = False
        Me.GrillaFecha.AllowUserToDeleteRows = False
        Me.GrillaFecha.BackgroundColor = System.Drawing.Color.White
        Me.GrillaFecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaFecha.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.GrillaFecha.Location = New System.Drawing.Point(364, 69)
        Me.GrillaFecha.Name = "GrillaFecha"
        Me.GrillaFecha.ReadOnly = True
        Me.GrillaFecha.RowHeadersVisible = False
        Me.GrillaFecha.Size = New System.Drawing.Size(257, 127)
        Me.GrillaFecha.TabIndex = 4
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha Despacho"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N0"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn5.HeaderText = "Total Band."
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'GrillaPreparacion
        '
        Me.GrillaPreparacion.AllowUserToAddRows = False
        Me.GrillaPreparacion.AllowUserToDeleteRows = False
        Me.GrillaPreparacion.BackgroundColor = System.Drawing.Color.White
        Me.GrillaPreparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaPreparacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.GrillaPreparacion.Location = New System.Drawing.Point(8, 68)
        Me.GrillaPreparacion.Name = "GrillaPreparacion"
        Me.GrillaPreparacion.ReadOnly = True
        Me.GrillaPreparacion.RowHeadersVisible = False
        Me.GrillaPreparacion.Size = New System.Drawing.Size(350, 128)
        Me.GrillaPreparacion.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.HeaderText = "Sector"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "Zona"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N0"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn3.HeaderText = "Total Band."
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 87
        '
        'PrepDespLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 644)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PrepDespLote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preparación de Despachos"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GrillaDespacho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GrillaSector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaPreparacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GrillaDespacho As System.Windows.Forms.DataGridView
    Friend WithEvents GrillaFecha As System.Windows.Forms.DataGridView
    Friend WithEvents GrillaPreparacion As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GuardarDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrillaSector As System.Windows.Forms.DataGridView
    Friend WithEvents c1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colu1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colu4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colu7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colu2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colu3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colu5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colu6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LotesConfirmadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LotesPreparadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dtpFecRepLotesConf As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReporteLotesPreparadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IrAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaLoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtNumLote As TextBox
    Friend WithEvents btnBuscaLote As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
