<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepEstadoCuentaContable
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GESTDataSet50 = New GestionVivero.GESTDataSet50()
        Me.SP_ReporteCartolaContableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_ReporteCartolaContableTableAdapter = New GestionVivero.GESTDataSet50TableAdapters.SP_ReporteCartolaContableTableAdapter()
        CType(Me.GESTDataSet50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_ReporteCartolaContableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SP_ReporteCartolaContableBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.RepEstadoCuenta.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(984, 612)
        Me.ReportViewer1.TabIndex = 0
        '
        'GESTDataSet50
        '
        Me.GESTDataSet50.DataSetName = "GESTDataSet50"
        Me.GESTDataSet50.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_ReporteCartolaContableBindingSource
        '
        Me.SP_ReporteCartolaContableBindingSource.DataMember = "SP_ReporteCartolaContable"
        Me.SP_ReporteCartolaContableBindingSource.DataSource = Me.GESTDataSet50
        '
        'SP_ReporteCartolaContableTableAdapter
        '
        Me.SP_ReporteCartolaContableTableAdapter.ClearBeforeFill = True
        '
        'RepEstadoCuentaContable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 612)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "RepEstadoCuentaContable"
        Me.Text = "RepEstadoCuentaContable"
        CType(Me.GESTDataSet50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_ReporteCartolaContableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SP_ReporteCartolaContableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GESTDataSet50 As GestionVivero.GESTDataSet50
    Friend WithEvents SP_ReporteCartolaContableTableAdapter As GestionVivero.GESTDataSet50TableAdapters.SP_ReporteCartolaContableTableAdapter
End Class
