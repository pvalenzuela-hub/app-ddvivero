<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepDespachos
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
        Me.SP_RepDespachoIdDespBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GESTDataSetRepDesp = New GestionVivero.GESTDataSetRepDesp()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SP_RepDespachoIdDespTableAdapter = New GestionVivero.GESTDataSetRepDespTableAdapters.SP_RepDespachoIdDespTableAdapter()
        CType(Me.SP_RepDespachoIdDespBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTDataSetRepDesp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SP_RepDespachoIdDespBindingSource
        '
        Me.SP_RepDespachoIdDespBindingSource.DataMember = "SP_RepDespachoIdDesp"
        Me.SP_RepDespachoIdDespBindingSource.DataSource = Me.GESTDataSetRepDesp
        '
        'GESTDataSetRepDesp
        '
        Me.GESTDataSetRepDesp.DataSetName = "GESTDataSetRepDesp"
        Me.GESTDataSetRepDesp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SP_RepDespachoIdDespBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.RepDespacho.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(984, 612)
        Me.ReportViewer1.TabIndex = 0
        '
        'SP_RepDespachoIdDespTableAdapter
        '
        Me.SP_RepDespachoIdDespTableAdapter.ClearBeforeFill = True
        '
        'RepDespachos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 612)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RepDespachos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Despachos"
        Me.TopMost = True
        CType(Me.SP_RepDespachoIdDespBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTDataSetRepDesp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SP_RepDespachoIdDespBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GESTDataSetRepDesp As GestionVivero.GESTDataSetRepDesp
    Friend WithEvents SP_RepDespachoIdDespTableAdapter As GestionVivero.GESTDataSetRepDespTableAdapters.SP_RepDespachoIdDespTableAdapter
End Class
