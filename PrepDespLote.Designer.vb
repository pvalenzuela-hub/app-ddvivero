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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtNumLote = New System.Windows.Forms.TextBox()
        Me.btnBuscaLote = New System.Windows.Forms.Button()
        Me.dtpFecRepLotesConf = New System.Windows.Forms.DateTimePicker()
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
        Me.Button2 = New System.Windows.Forms.Button()
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GrillaSector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaPreparacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaDespacho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(283, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Fecha Preparación:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Buscar N° Lote:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.guardar_40x40
        Me.Button1.Location = New System.Drawing.Point(1017, 111)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 49)
        Me.Button1.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.Button1, "Guarda Cambios")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtNumLote
        '
        Me.txtNumLote.Location = New System.Drawing.Point(100, 33)
        Me.txtNumLote.Name = "txtNumLote"
        Me.txtNumLote.Size = New System.Drawing.Size(100, 20)
        Me.txtNumLote.TabIndex = 3
        '
        'btnBuscaLote
        '
        Me.btnBuscaLote.Image = Global.GestionVivero.My.Resources.Resources.buscar_40x40
        Me.btnBuscaLote.Location = New System.Drawing.Point(211, 19)
        Me.btnBuscaLote.Name = "btnBuscaLote"
        Me.btnBuscaLote.Size = New System.Drawing.Size(49, 49)
        Me.btnBuscaLote.TabIndex = 2
        Me.btnBuscaLote.Text = "..."
        Me.btnBuscaLote.UseVisualStyleBackColor = True
        '
        'dtpFecRepLotesConf
        '
        Me.dtpFecRepLotesConf.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecRepLotesConf.Location = New System.Drawing.Point(389, 33)
        Me.dtpFecRepLotesConf.Name = "dtpFecRepLotesConf"
        Me.dtpFecRepLotesConf.Size = New System.Drawing.Size(115, 20)
        Me.dtpFecRepLotesConf.TabIndex = 1
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label3.Location = New System.Drawing.Point(713, 488)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Lotes confirmados por sector"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label2.Location = New System.Drawing.Point(363, 488)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Lotes confirmados por fecha despacho"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label1.Location = New System.Drawing.Point(12, 488)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 13)
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
        Me.GrillaSector.Location = New System.Drawing.Point(708, 504)
        Me.GrillaSector.Name = "GrillaSector"
        Me.GrillaSector.ReadOnly = True
        Me.GrillaSector.RowHeadersVisible = False
        Me.GrillaSector.Size = New System.Drawing.Size(350, 99)
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.c3.DefaultCellStyle = DataGridViewCellStyle1
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
        Me.GrillaFecha.Location = New System.Drawing.Point(358, 504)
        Me.GrillaFecha.Name = "GrillaFecha"
        Me.GrillaFecha.ReadOnly = True
        Me.GrillaFecha.RowHeadersVisible = False
        Me.GrillaFecha.Size = New System.Drawing.Size(350, 99)
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
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
        Me.GrillaPreparacion.Location = New System.Drawing.Point(8, 504)
        Me.GrillaPreparacion.Name = "GrillaPreparacion"
        Me.GrillaPreparacion.ReadOnly = True
        Me.GrillaPreparacion.RowHeadersVisible = False
        Me.GrillaPreparacion.Size = New System.Drawing.Size(350, 99)
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.HeaderText = "Total Band."
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 87
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.salir_40x40
        Me.Button2.Location = New System.Drawing.Point(1017, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(49, 49)
        Me.Button2.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.Button2, "Cerrar Formulario")
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.GrillaDespacho.GridColor = System.Drawing.SystemColors.HotTrack
        Me.GrillaDespacho.Location = New System.Drawing.Point(-2, 111)
        Me.GrillaDespacho.Name = "GrillaDespacho"
        Me.GrillaDespacho.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.GrillaDespacho.RowHeadersVisible = False
        Me.GrillaDespacho.Size = New System.Drawing.Size(1013, 305)
        Me.GrillaDespacho.StandardTab = True
        Me.GrillaDespacho.TabIndex = 10
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.c11.DefaultCellStyle = DataGridViewCellStyle4
        Me.c11.HeaderText = "Pedido"
        Me.c11.Name = "c11"
        Me.c11.Width = 65
        '
        'c12
        '
        Me.c12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.c12.DefaultCellStyle = DataGridViewCellStyle5
        Me.c12.HeaderText = "Saldo"
        Me.c12.Name = "c12"
        Me.c12.Width = 59
        '
        'col10
        '
        Me.col10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.col10.DefaultCellStyle = DataGridViewCellStyle6
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
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Image = Global.GestionVivero.My.Resources.Resources.R_images0031
        Me.Button3.Location = New System.Drawing.Point(8, 436)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 49)
        Me.Button3.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.Button3, "Resumen del Despacho")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Button4.Image = Global.GestionVivero.My.Resources.Resources.eliminar_40x40
        Me.Button4.Location = New System.Drawing.Point(1017, 163)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(49, 49)
        Me.Button4.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.Button4, "Elimina Lote")
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Image = Global.GestionVivero.My.Resources.Resources.Autorizacion1
        Me.Button5.Location = New System.Drawing.Point(1017, 215)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(49, 49)
        Me.Button5.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.Button5, "Lotes Confirmados")
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Image = Global.GestionVivero.My.Resources.Resources.imprimir_40x40
        Me.Button6.Location = New System.Drawing.Point(1017, 267)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(49, 49)
        Me.Button6.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.Button6, "Lotes Confirmados")
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Image = Global.GestionVivero.My.Resources.Resources.imprimir_40x40
        Me.Button7.Location = New System.Drawing.Point(1017, 319)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(49, 49)
        Me.Button7.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.Button7, "Lotes Preparados")
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.White
        Me.Button8.Image = Global.GestionVivero.My.Resources.Resources.Notes
        Me.Button8.Location = New System.Drawing.Point(1017, 371)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(49, 49)
        Me.Button8.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.Button8, "Creación de Despachos")
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.White
        Me.Button9.Image = Global.GestionVivero.My.Resources.Resources.icon_40x40
        Me.Button9.Location = New System.Drawing.Point(1017, 423)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(49, 44)
        Me.Button9.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.Button9, "Consulta de Lotes")
        Me.Button9.UseVisualStyleBackColor = False
        '
        'PrepDespLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1070, 644)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GrillaDespacho)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GrillaSector)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GrillaFecha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GrillaPreparacion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumLote)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuscaLote)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtpFecRepLotesConf)
        Me.Name = "PrepDespLote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preparación de Despachos"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GrillaSector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaPreparacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaDespacho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LotesConfirmadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LotesPreparadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dtpFecRepLotesConf As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReporteLotesPreparadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IrAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaLoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtNumLote As TextBox
    Friend WithEvents btnBuscaLote As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents GrillaDespacho As DataGridView
    Friend WithEvents sel As DataGridViewCheckBoxColumn
    Friend WithEvents colu1 As DataGridViewTextBoxColumn
    Friend WithEvents colu4 As DataGridViewTextBoxColumn
    Friend WithEvents colu7 As DataGridViewTextBoxColumn
    Friend WithEvents c11 As DataGridViewTextBoxColumn
    Friend WithEvents c12 As DataGridViewTextBoxColumn
    Friend WithEvents col10 As DataGridViewTextBoxColumn
    Friend WithEvents col9 As DataGridViewTextBoxColumn
    Friend WithEvents col8 As DataGridViewTextBoxColumn
    Friend WithEvents colu2 As DataGridViewTextBoxColumn
    Friend WithEvents colu3 As DataGridViewTextBoxColumn
    Friend WithEvents colu5 As DataGridViewTextBoxColumn
    Friend WithEvents colu6 As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
End Class
