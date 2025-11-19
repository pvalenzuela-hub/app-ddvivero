<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteStockSemilla
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
        Me.SP_Reporte_Stock_SemillaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GESTDataSet40 = New GestionVivero.GESTDataSet40()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SP_Reporte_Stock_SemillaTableAdapter = New GestionVivero.GESTDataSet40TableAdapters.SP_Reporte_Stock_SemillaTableAdapter()
        CType(Me.SP_Reporte_Stock_SemillaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTDataSet40, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SP_Reporte_Stock_SemillaBindingSource
        '
        Me.SP_Reporte_Stock_SemillaBindingSource.DataMember = "SP_Reporte_Stock_Semilla"
        Me.SP_Reporte_Stock_SemillaBindingSource.DataSource = Me.GESTDataSet40
        '
        'GESTDataSet40
        '
        Me.GESTDataSet40.DataSetName = "GESTDataSet40"
        Me.GESTDataSet40.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet2"
        ReportDataSource1.Value = Me.SP_Reporte_Stock_SemillaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.Report27.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1184, 731)
        Me.ReportViewer1.TabIndex = 0
        '
        'SP_Reporte_Stock_SemillaTableAdapter
        '
        Me.SP_Reporte_Stock_SemillaTableAdapter.ClearBeforeFill = True
        '
        'ReporteStockSemilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 731)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReporteStockSemilla"
        Me.Text = "Stock Semillas"
        CType(Me.SP_Reporte_Stock_SemillaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTDataSet40, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GESTDataSet40 As GestionVivero.GESTDataSet40
    Friend WithEvents SP_Reporte_Stock_SemillaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SP_Reporte_Stock_SemillaTableAdapter As GestionVivero.GESTDataSet40TableAdapters.SP_Reporte_Stock_SemillaTableAdapter
End Class
