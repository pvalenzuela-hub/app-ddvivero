<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReporteDespachoRecuperacionBandejas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.NEWSPReporteDespachoRecupBandejasPendientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GESTDataSet11 = New GestionVivero.GESTDataSet11()
        Me.cmb_Sector = New System.Windows.Forms.ComboBox()
        Me.SPCONSULTASectorFiltroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GESTDataSet12 = New GestionVivero.GESTDataSet12()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_Zona = New System.Windows.Forms.ComboBox()
        Me.GrillaSectores = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SP_CONSULTASectorFiltroTableAdapter = New GestionVivero.GESTDataSet12TableAdapters.SP_CONSULTASectorFiltroTableAdapter()
        Me.NEWSP_ReporteDespachoRecupBandejasPendientesTableAdapter = New GestionVivero.GESTDataSet11TableAdapters.NEWSP_ReporteDespachoRecupBandejasPendientesTableAdapter()
        CType(Me.NEWSPReporteDespachoRecupBandejasPendientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPCONSULTASectorFiltroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTDataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaSectores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NEWSPReporteDespachoRecupBandejasPendientesBindingSource
        '
        Me.NEWSPReporteDespachoRecupBandejasPendientesBindingSource.DataMember = "NEWSP_ReporteDespachoRecupBandejasPendientes"
        Me.NEWSPReporteDespachoRecupBandejasPendientesBindingSource.DataSource = Me.GESTDataSet11
        '
        'GESTDataSet11
        '
        Me.GESTDataSet11.DataSetName = "GESTDataSet11"
        Me.GESTDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmb_Sector
        '
        Me.cmb_Sector.DataSource = Me.SPCONSULTASectorFiltroBindingSource
        Me.cmb_Sector.DisplayMember = "Nombre"
        Me.cmb_Sector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Sector.FormattingEnabled = True
        Me.cmb_Sector.Location = New System.Drawing.Point(58, 61)
        Me.cmb_Sector.Name = "cmb_Sector"
        Me.cmb_Sector.Size = New System.Drawing.Size(284, 21)
        Me.cmb_Sector.TabIndex = 4
        Me.cmb_Sector.ValueMember = "idSector"
        '
        'SPCONSULTASectorFiltroBindingSource
        '
        Me.SPCONSULTASectorFiltroBindingSource.DataMember = "SP_CONSULTASectorFiltro"
        Me.SPCONSULTASectorFiltroBindingSource.DataSource = Me.GESTDataSet12
        '
        'GESTDataSet12
        '
        Me.GESTDataSet12.DataSetName = "GESTDataSet12"
        Me.GESTDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Zona"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Sector"
        '
        'cmb_Zona
        '
        Me.cmb_Zona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Zona.FormattingEnabled = True
        Me.cmb_Zona.Location = New System.Drawing.Point(58, 25)
        Me.cmb_Zona.Name = "cmb_Zona"
        Me.cmb_Zona.Size = New System.Drawing.Size(284, 21)
        Me.cmb_Zona.TabIndex = 5
        '
        'GrillaSectores
        '
        Me.GrillaSectores.AllowUserToAddRows = False
        Me.GrillaSectores.AllowUserToDeleteRows = False
        Me.GrillaSectores.BackgroundColor = System.Drawing.Color.White
        Me.GrillaSectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaSectores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column2, Me.Column1})
        Me.GrillaSectores.Location = New System.Drawing.Point(379, 20)
        Me.GrillaSectores.Name = "GrillaSectores"
        Me.GrillaSectores.ReadOnly = True
        Me.GrillaSectores.RowHeadersVisible = False
        Me.GrillaSectores.Size = New System.Drawing.Size(533, 93)
        Me.GrillaSectores.TabIndex = 8
        '
        'Column3
        '
        Me.Column3.HeaderText = ""
        Me.Column3.Image = Global.GestionVivero.My.Resources.Resources.Delete1
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.Width = 30
        '
        'Column2
        '
        Me.Column2.HeaderText = "Código"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 50
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Sectores Seleccionados"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.imprimir_40x40
        Me.Button1.Location = New System.Drawing.Point(938, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 49)
        Me.Button1.TabIndex = 9
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.NEWSPReporteDespachoRecupBandejasPendientesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.RecuperacionBandejas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 123)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1071, 536)
        Me.ReportViewer1.TabIndex = 10
        '
        'SP_CONSULTASectorFiltroTableAdapter
        '
        Me.SP_CONSULTASectorFiltroTableAdapter.ClearBeforeFill = True
        '
        'NEWSP_ReporteDespachoRecupBandejasPendientesTableAdapter
        '
        Me.NEWSP_ReporteDespachoRecupBandejasPendientesTableAdapter.ClearBeforeFill = True
        '
        'ReporteDespachoRecuperacionBandejas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1076, 661)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GrillaSectores)
        Me.Controls.Add(Me.cmb_Sector)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_Zona)
        Me.Name = "ReporteDespachoRecuperacionBandejas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Bandejas Pendientes"
        CType(Me.NEWSPReporteDespachoRecupBandejasPendientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPCONSULTASectorFiltroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTDataSet12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaSectores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_Sector As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_Zona As ComboBox
    Friend WithEvents GrillaSectores As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents SPCONSULTASectorFiltroBindingSource As BindingSource
    Friend WithEvents GESTDataSet12 As GESTDataSet12
    Friend WithEvents SP_CONSULTASectorFiltroTableAdapter As GESTDataSet12TableAdapters.SP_CONSULTASectorFiltroTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Column3 As DataGridViewImageColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents NEWSPReporteDespachoRecupBandejasPendientesBindingSource As BindingSource
    Friend WithEvents GESTDataSet11 As GESTDataSet11
    Friend WithEvents NEWSP_ReporteDespachoRecupBandejasPendientesTableAdapter As GESTDataSet11TableAdapters.NEWSP_ReporteDespachoRecupBandejasPendientesTableAdapter
End Class
