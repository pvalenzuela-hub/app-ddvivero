<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteListadoPrecios
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.cboModoFiltro = New System.Windows.Forms.ComboBox()
        Me.cboEspecie = New System.Windows.Forms.ComboBox()
        Me.cboVariedad = New System.Windows.Forms.ComboBox()
        Me.lblModoFiltro = New System.Windows.Forms.Label()
        Me.lblEspecie = New System.Windows.Forms.Label()
        Me.lblVariedad = New System.Windows.Forms.Label()
        Me.btnExportarExcel = New System.Windows.Forms.Button()
        Me.dgvPrecios = New System.Windows.Forms.DataGridView()
        Me.GESTDataSet24 = New GestionVivero.GESTDataSet24()
        Me.SP_ReporteListadoPrecioVentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_ReporteListadoPrecioVentaTableAdapter = New GestionVivero.GESTDataSet24TableAdapters.SP_ReporteListadoPrecioVentaTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.TopPanel.SuspendLayout()
        CType(Me.dgvPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTDataSet24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_ReporteListadoPrecioVentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvPrecios)
        Me.Panel1.Controls.Add(Me.TopPanel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1048, 524)
        Me.Panel1.TabIndex = 0
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.btnExportarExcel)
        Me.TopPanel.Controls.Add(Me.cboModoFiltro)
        Me.TopPanel.Controls.Add(Me.cboEspecie)
        Me.TopPanel.Controls.Add(Me.cboVariedad)
        Me.TopPanel.Controls.Add(Me.lblModoFiltro)
        Me.TopPanel.Controls.Add(Me.lblEspecie)
        Me.TopPanel.Controls.Add(Me.lblVariedad)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1048, 88)
        Me.TopPanel.TabIndex = 0
        '
        'cboModoFiltro
        '
        Me.cboModoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboModoFiltro.FormattingEnabled = True
        Me.cboModoFiltro.Location = New System.Drawing.Point(99, 11)
        Me.cboModoFiltro.Name = "cboModoFiltro"
        Me.cboModoFiltro.Size = New System.Drawing.Size(203, 21)
        Me.cboModoFiltro.TabIndex = 0
        '
        'cboEspecie
        '
        Me.cboEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEspecie.FormattingEnabled = True
        Me.cboEspecie.Location = New System.Drawing.Point(99, 38)
        Me.cboEspecie.Name = "cboEspecie"
        Me.cboEspecie.Size = New System.Drawing.Size(240, 21)
        Me.cboEspecie.TabIndex = 1
        '
        'cboVariedad
        '
        Me.cboVariedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVariedad.FormattingEnabled = True
        Me.cboVariedad.Location = New System.Drawing.Point(99, 64)
        Me.cboVariedad.Name = "cboVariedad"
        Me.cboVariedad.Size = New System.Drawing.Size(240, 21)
        Me.cboVariedad.TabIndex = 2
        '
        'lblModoFiltro
        '
        Me.lblModoFiltro.AutoSize = True
        Me.lblModoFiltro.Location = New System.Drawing.Point(8, 14)
        Me.lblModoFiltro.Name = "lblModoFiltro"
        Me.lblModoFiltro.Size = New System.Drawing.Size(79, 13)
        Me.lblModoFiltro.TabIndex = 3
        Me.lblModoFiltro.Text = "Tipo de filtro"
        '
        'lblEspecie
        '
        Me.lblEspecie.AutoSize = True
        Me.lblEspecie.Location = New System.Drawing.Point(8, 41)
        Me.lblEspecie.Name = "lblEspecie"
        Me.lblEspecie.Size = New System.Drawing.Size(43, 13)
        Me.lblEspecie.TabIndex = 4
        Me.lblEspecie.Text = "Especie:"
        '
        'lblVariedad
        '
        Me.lblVariedad.AutoSize = True
        Me.lblVariedad.Location = New System.Drawing.Point(8, 67)
        Me.lblVariedad.Name = "lblVariedad"
        Me.lblVariedad.Size = New System.Drawing.Size(47, 13)
        Me.lblVariedad.TabIndex = 5
        Me.lblVariedad.Text = "Variedad:"
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Location = New System.Drawing.Point(370, 12)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(132, 38)
        Me.btnExportarExcel.TabIndex = 6
        Me.btnExportarExcel.Text = "Exportar Excel"
        Me.btnExportarExcel.UseVisualStyleBackColor = True
        '
        'dgvPrecios
        '
        Me.dgvPrecios.AllowUserToAddRows = False
        Me.dgvPrecios.AllowUserToDeleteRows = False
        Me.dgvPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrecios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPrecios.Location = New System.Drawing.Point(0, 88)
        Me.dgvPrecios.Name = "dgvPrecios"
        Me.dgvPrecios.ReadOnly = True
        Me.dgvPrecios.Size = New System.Drawing.Size(1048, 436)
        Me.dgvPrecios.TabIndex = 1
        '
        'GESTDataSet24
        '
        Me.GESTDataSet24.DataSetName = "GESTDataSet24"
        Me.GESTDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_ReporteListadoPrecioVentaBindingSource
        '
        Me.SP_ReporteListadoPrecioVentaBindingSource.DataMember = "SP_ReporteListadoPrecioVenta"
        Me.SP_ReporteListadoPrecioVentaBindingSource.DataSource = Me.GESTDataSet24
        '
        'SP_ReporteListadoPrecioVentaTableAdapter
        '
        Me.SP_ReporteListadoPrecioVentaTableAdapter.ClearBeforeFill = True
        '
        'ReporteListadoPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 524)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ReporteListadoPrecios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Precios de Venta"
        Me.Panel1.ResumeLayout(False)
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        CType(Me.dgvPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTDataSet24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_ReporteListadoPrecioVentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TopPanel As System.Windows.Forms.Panel
    Friend WithEvents cboModoFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents cboEspecie As System.Windows.Forms.ComboBox
    Friend WithEvents cboVariedad As System.Windows.Forms.ComboBox
    Friend WithEvents lblModoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblEspecie As System.Windows.Forms.Label
    Friend WithEvents lblVariedad As System.Windows.Forms.Label
    Friend WithEvents btnExportarExcel As System.Windows.Forms.Button
    Friend WithEvents dgvPrecios As System.Windows.Forms.DataGridView
    Friend WithEvents SP_ReporteListadoPrecioVentaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GESTDataSet24 As GestionVivero.GESTDataSet24
    Friend WithEvents SP_ReporteListadoPrecioVentaTableAdapter As GestionVivero.GESTDataSet24TableAdapters.SP_ReporteListadoPrecioVentaTableAdapter
End Class
