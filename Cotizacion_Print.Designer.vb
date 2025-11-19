<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cotizacion_Print
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
        Me.SPReporteCotizacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Cotizacion = New GestionVivero.DataSet_Cotizacion()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SP_ReporteCotizacionTableAdapter = New GestionVivero.DataSet_CotizacionTableAdapters.SP_ReporteCotizacionTableAdapter()
        Me.txtIdCotizacion = New System.Windows.Forms.TextBox()
        CType(Me.SPReporteCotizacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Cotizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SPReporteCotizacionBindingSource
        '
        Me.SPReporteCotizacionBindingSource.DataMember = "SP_ReporteCotizacion"
        Me.SPReporteCotizacionBindingSource.DataSource = Me.DataSet_Cotizacion
        '
        'DataSet_Cotizacion
        '
        Me.DataSet_Cotizacion.DataSetName = "DataSet_Cotizacion"
        Me.DataSet_Cotizacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SPReporteCotizacionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.Prt_Cotizacion.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(822, 602)
        Me.ReportViewer1.TabIndex = 0
        '
        'SP_ReporteCotizacionTableAdapter
        '
        Me.SP_ReporteCotizacionTableAdapter.ClearBeforeFill = True
        '
        'txtIdCotizacion
        '
        Me.txtIdCotizacion.Location = New System.Drawing.Point(653, 0)
        Me.txtIdCotizacion.Name = "txtIdCotizacion"
        Me.txtIdCotizacion.Size = New System.Drawing.Size(100, 20)
        Me.txtIdCotizacion.TabIndex = 1
        Me.txtIdCotizacion.Visible = False
        '
        'Cotizacion_Print
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 602)
        Me.Controls.Add(Me.txtIdCotizacion)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Cotizacion_Print"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cotizacion_Print"
        CType(Me.SPReporteCotizacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Cotizacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SPReporteCotizacionBindingSource As BindingSource
    Friend WithEvents DataSet_Cotizacion As DataSet_Cotizacion
    Friend WithEvents SP_ReporteCotizacionTableAdapter As DataSet_CotizacionTableAdapters.SP_ReporteCotizacionTableAdapter
    Friend WithEvents txtIdCotizacion As TextBox
End Class
