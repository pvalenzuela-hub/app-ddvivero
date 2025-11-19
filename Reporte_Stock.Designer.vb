<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte_Stock
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
        Me.SP_Consulta_STOCKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetReporteInventario = New GestionVivero.DataSetReporteInventario()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SP_Consulta_STOCKTableAdapter = New GestionVivero.DataSetReporteInventarioTableAdapters.SP_Consulta_STOCKTableAdapter()
        CType(Me.SP_Consulta_STOCKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetReporteInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SP_Consulta_STOCKBindingSource
        '
        Me.SP_Consulta_STOCKBindingSource.DataMember = "SP_Consulta_STOCK"
        Me.SP_Consulta_STOCKBindingSource.DataSource = Me.DataSetReporteInventario
        '
        'DataSetReporteInventario
        '
        Me.DataSetReporteInventario.DataSetName = "DataSetReporteInventario"
        Me.DataSetReporteInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SP_Consulta_STOCKBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.Report11.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1108, 738)
        Me.ReportViewer1.TabIndex = 0
        '
        'SP_Consulta_STOCKTableAdapter
        '
        Me.SP_Consulta_STOCKTableAdapter.ClearBeforeFill = True
        '
        'Reporte_Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 738)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Reporte_Stock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Stock de Plantas"
        CType(Me.SP_Consulta_STOCKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetReporteInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SP_Consulta_STOCKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetReporteInventario As GestionVivero.DataSetReporteInventario
    Friend WithEvents SP_Consulta_STOCKTableAdapter As GestionVivero.DataSetReporteInventarioTableAdapters.SP_Consulta_STOCKTableAdapter
End Class
