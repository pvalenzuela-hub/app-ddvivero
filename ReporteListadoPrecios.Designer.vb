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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GESTDataSet24 = New GestionVivero.GESTDataSet24()
        Me.SP_ReporteListadoPrecioVentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_ReporteListadoPrecioVentaTableAdapter = New GestionVivero.GESTDataSet24TableAdapters.SP_ReporteListadoPrecioVentaTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.GESTDataSet24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_ReporteListadoPrecioVentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ReportViewer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1048, 524)
        Me.Panel1.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SP_ReporteListadoPrecioVentaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.Report26.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1048, 524)
        Me.ReportViewer1.TabIndex = 0
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
        Me.Text = "Listado de Precios"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GESTDataSet24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_ReporteListadoPrecioVentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SP_ReporteListadoPrecioVentaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GESTDataSet24 As GestionVivero.GESTDataSet24
    Friend WithEvents SP_ReporteListadoPrecioVentaTableAdapter As GestionVivero.GESTDataSet24TableAdapters.SP_ReporteListadoPrecioVentaTableAdapter
End Class
