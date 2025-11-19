<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaControlSiembra
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GrillaTotales = New System.Windows.Forms.DataGridView()
        Me.GrillaControl = New System.Windows.Forms.DataGridView()
        Me.NumLoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EspecieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VariedadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasProgInicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechainicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechacinicialDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEntregaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasIniSiembraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BandejasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NuevaEntregaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasSembradoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasMentiraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SPReporteControlSiembraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        'Me.GESTDataSetControlSiembra = New GestionVivero.GESTDataSetControlSiembra()
        Me.SP_ReporteControlSiembraTableAdapter = New GestionVivero.GESTDataSetControlSiembraTableAdapters.SP_ReporteControlSiembraTableAdapter()
        Me.column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GrillaTotales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPReporteControlSiembraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        ' CType(Me.GESTDataSetControlSiembra, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.GrillaTotales)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GrillaControl)
        Me.SplitContainer1.Size = New System.Drawing.Size(1234, 718)
        Me.SplitContainer1.SplitterDistance = 223
        Me.SplitContainer1.TabIndex = 0
        '
        'GrillaTotales
        '
        Me.GrillaTotales.AllowUserToAddRows = False
        Me.GrillaTotales.AllowUserToDeleteRows = False
        Me.GrillaTotales.AllowUserToOrderColumns = True
        Me.GrillaTotales.BackgroundColor = System.Drawing.Color.White
        Me.GrillaTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaTotales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.column1, Me.total, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.GrillaTotales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaTotales.Location = New System.Drawing.Point(0, 0)
        Me.GrillaTotales.Name = "GrillaTotales"
        Me.GrillaTotales.ReadOnly = True
        Me.GrillaTotales.Size = New System.Drawing.Size(1234, 223)
        Me.GrillaTotales.TabIndex = 0
        '
        'GrillaControl
        '
        Me.GrillaControl.AllowUserToAddRows = False
        Me.GrillaControl.AllowUserToDeleteRows = False
        Me.GrillaControl.AllowUserToOrderColumns = True
        Me.GrillaControl.AutoGenerateColumns = False
        Me.GrillaControl.BackgroundColor = System.Drawing.Color.White
        Me.GrillaControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaControl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumLoteDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.EspecieDataGridViewTextBoxColumn, Me.VariedadDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.DiasProgInicioDataGridViewTextBoxColumn, Me.FechainicioDataGridViewTextBoxColumn, Me.FechacinicialDataGridViewTextBoxColumn1, Me.FechaEntregaDataGridViewTextBoxColumn, Me.DiasIniSiembraDataGridViewTextBoxColumn, Me.BandejasDataGridViewTextBoxColumn, Me.NuevaEntregaDataGridViewTextBoxColumn, Me.DiasSembradoDataGridViewTextBoxColumn, Me.DiasMentiraDataGridViewTextBoxColumn})
        Me.GrillaControl.DataSource = Me.SPReporteControlSiembraBindingSource
        Me.GrillaControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaControl.Location = New System.Drawing.Point(0, 0)
        Me.GrillaControl.Name = "GrillaControl"
        Me.GrillaControl.ReadOnly = True
        Me.GrillaControl.Size = New System.Drawing.Size(1234, 491)
        Me.GrillaControl.TabIndex = 0
        '
        'NumLoteDataGridViewTextBoxColumn
        '
        Me.NumLoteDataGridViewTextBoxColumn.DataPropertyName = "NumLote"
        Me.NumLoteDataGridViewTextBoxColumn.HeaderText = "N° Lote"
        Me.NumLoteDataGridViewTextBoxColumn.Name = "NumLoteDataGridViewTextBoxColumn"
        Me.NumLoteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EspecieDataGridViewTextBoxColumn
        '
        Me.EspecieDataGridViewTextBoxColumn.DataPropertyName = "Especie"
        Me.EspecieDataGridViewTextBoxColumn.HeaderText = "Especie"
        Me.EspecieDataGridViewTextBoxColumn.Name = "EspecieDataGridViewTextBoxColumn"
        Me.EspecieDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VariedadDataGridViewTextBoxColumn
        '
        Me.VariedadDataGridViewTextBoxColumn.DataPropertyName = "Variedad"
        Me.VariedadDataGridViewTextBoxColumn.HeaderText = "Variedad"
        Me.VariedadDataGridViewTextBoxColumn.Name = "VariedadDataGridViewTextBoxColumn"
        Me.VariedadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha Pedido"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiasProgInicioDataGridViewTextBoxColumn
        '
        Me.DiasProgInicioDataGridViewTextBoxColumn.DataPropertyName = "Dias_Prog_Inicio"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DiasProgInicioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.DiasProgInicioDataGridViewTextBoxColumn.HeaderText = "N° Días Programado"
        Me.DiasProgInicioDataGridViewTextBoxColumn.Name = "DiasProgInicioDataGridViewTextBoxColumn"
        Me.DiasProgInicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechainicioDataGridViewTextBoxColumn
        '
        Me.FechainicioDataGridViewTextBoxColumn.DataPropertyName = "fecha_inicio"
        Me.FechainicioDataGridViewTextBoxColumn.HeaderText = "Fec.Prog.Siembra"
        Me.FechainicioDataGridViewTextBoxColumn.Name = "FechainicioDataGridViewTextBoxColumn"
        Me.FechainicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechacinicialDataGridViewTextBoxColumn1
        '
        Me.FechacinicialDataGridViewTextBoxColumn1.DataPropertyName = "fecha_cinicial"
        Me.FechacinicialDataGridViewTextBoxColumn1.HeaderText = "Fecha Siembra"
        Me.FechacinicialDataGridViewTextBoxColumn1.Name = "FechacinicialDataGridViewTextBoxColumn1"
        Me.FechacinicialDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'FechaEntregaDataGridViewTextBoxColumn
        '
        Me.FechaEntregaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Entrega"
        Me.FechaEntregaDataGridViewTextBoxColumn.HeaderText = "Fecha Entrega"
        Me.FechaEntregaDataGridViewTextBoxColumn.Name = "FechaEntregaDataGridViewTextBoxColumn"
        Me.FechaEntregaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiasIniSiembraDataGridViewTextBoxColumn
        '
        Me.DiasIniSiembraDataGridViewTextBoxColumn.DataPropertyName = "Dias_Ini_Siembra"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DiasIniSiembraDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.DiasIniSiembraDataGridViewTextBoxColumn.HeaderText = "N° Dias Inicio Siembra"
        Me.DiasIniSiembraDataGridViewTextBoxColumn.Name = "DiasIniSiembraDataGridViewTextBoxColumn"
        Me.DiasIniSiembraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BandejasDataGridViewTextBoxColumn
        '
        Me.BandejasDataGridViewTextBoxColumn.DataPropertyName = "Bandejas"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N0"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.BandejasDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.BandejasDataGridViewTextBoxColumn.HeaderText = "Cant. Bandejas"
        Me.BandejasDataGridViewTextBoxColumn.Name = "BandejasDataGridViewTextBoxColumn"
        Me.BandejasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NuevaEntregaDataGridViewTextBoxColumn
        '
        Me.NuevaEntregaDataGridViewTextBoxColumn.DataPropertyName = "Nueva_Entrega"
        Me.NuevaEntregaDataGridViewTextBoxColumn.HeaderText = "Nueva Fecha Entrega"
        Me.NuevaEntregaDataGridViewTextBoxColumn.Name = "NuevaEntregaDataGridViewTextBoxColumn"
        Me.NuevaEntregaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiasSembradoDataGridViewTextBoxColumn
        '
        Me.DiasSembradoDataGridViewTextBoxColumn.DataPropertyName = "Dias_Sembrado"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DiasSembradoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.DiasSembradoDataGridViewTextBoxColumn.HeaderText = "N° Dias Lote sembrado"
        Me.DiasSembradoDataGridViewTextBoxColumn.Name = "DiasSembradoDataGridViewTextBoxColumn"
        Me.DiasSembradoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiasMentiraDataGridViewTextBoxColumn
        '
        Me.DiasMentiraDataGridViewTextBoxColumn.DataPropertyName = "Dias_Mentira"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DiasMentiraDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle12
        Me.DiasMentiraDataGridViewTextBoxColumn.HeaderText = "N° Días Comprometido"
        Me.DiasMentiraDataGridViewTextBoxColumn.Name = "DiasMentiraDataGridViewTextBoxColumn"
        Me.DiasMentiraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SPReporteControlSiembraBindingSource
        '
        Me.SPReporteControlSiembraBindingSource.DataMember = "SP_ReporteControlSiembra"
        ' Me.SPReporteControlSiembraBindingSource.DataSource = Me.GESTDataSetControlSiembra
        '
        'GESTDataSetControlSiembra
        '
        'Me.GESTDataSetControlSiembra.DataSetName = "GESTDataSetControlSiembra"
        'Me.GESTDataSetControlSiembra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        ''
        'SP_ReporteControlSiembraTableAdapter
        '
        Me.SP_ReporteControlSiembraTableAdapter.ClearBeforeFill = True
        '
        'column1
        '
        Me.column1.Frozen = True
        Me.column1.HeaderText = "Fecha de Siembra"
        Me.column1.Name = "column1"
        Me.column1.ReadOnly = True
        Me.column1.Width = 200
        '
        'total
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.total.DefaultCellStyle = DataGridViewCellStyle1
        Me.total.HeaderText = "Total Día"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'Column2
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.HeaderText = "432"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column3.HeaderText = "286"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column4.HeaderText = "240"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column5.HeaderText = "135"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column6.HeaderText = "540"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column7.HeaderText = "128"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "200"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "105"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'ConsultaControlSiembra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 718)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ConsultaControlSiembra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Indicadores Control de Siembra"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GrillaTotales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPReporteControlSiembraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.GESTDataSetControlSiembra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GrillaTotales As System.Windows.Forms.DataGridView
    Friend WithEvents GrillaControl As System.Windows.Forms.DataGridView

    Friend WithEvents SPReporteControlSiembraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SP_ReporteControlSiembraTableAdapter As GestionVivero.GESTDataSetControlSiembraTableAdapters.SP_ReporteControlSiembraTableAdapter
    Friend WithEvents NumLoteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EspecieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VariedadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasProgInicioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechainicioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechacinicialDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaEntregaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasIniSiembraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BandejasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NuevaEntregaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasSembradoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasMentiraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents column1 As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
