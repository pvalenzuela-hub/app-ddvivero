<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepLotConf
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
        Me.GESTDataSetReporteLotConf = New GestionVivero.GESTDataSetReporteLotConf()
        Me.SP_RepLotConfBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RepLotConfTableAdapter = New GestionVivero.GESTDataSetReporteLotConfTableAdapters.SP_RepLotConfTableAdapter()
        CType(Me.GESTDataSetReporteLotConf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RepLotConfBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SP_RepLotConfBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.RepLotConf.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(984, 612)
        Me.ReportViewer1.TabIndex = 0
        '
        'GESTDataSetReporteLotConf
        '
        Me.GESTDataSetReporteLotConf.DataSetName = "GESTDataSetReporteLotConf"
        Me.GESTDataSetReporteLotConf.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_RepLotConfBindingSource
        '
        Me.SP_RepLotConfBindingSource.DataMember = "SP_RepLotConf"
        Me.SP_RepLotConfBindingSource.DataSource = Me.GESTDataSetReporteLotConf
        '
        'SP_RepLotConfTableAdapter
        '
        Me.SP_RepLotConfTableAdapter.ClearBeforeFill = True
        '
        'RepLotConf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 612)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "RepLotConf"
        Me.Text = "RepLotConf"
        CType(Me.GESTDataSetReporteLotConf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RepLotConfBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SP_RepLotConfBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GESTDataSetReporteLotConf As GestionVivero.GESTDataSetReporteLotConf
    Friend WithEvents SP_RepLotConfTableAdapter As GestionVivero.GESTDataSetReporteLotConfTableAdapters.SP_RepLotConfTableAdapter
End Class
