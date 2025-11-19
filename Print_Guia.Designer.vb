<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Print_Guia
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
        Me.SPEmisionGuiaDespachoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GESTDataSet = New GestionVivero.GESTDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.nDespacho = New System.Windows.Forms.TextBox()
        Me.SP_EmisionGuiaDespachoTableAdapter = New GestionVivero.GESTDataSetTableAdapters.SP_EmisionGuiaDespachoTableAdapter()
        CType(Me.SPEmisionGuiaDespachoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SPEmisionGuiaDespachoBindingSource
        '
        Me.SPEmisionGuiaDespachoBindingSource.DataMember = "SP_EmisionGuiaDespacho"
        Me.SPEmisionGuiaDespachoBindingSource.DataSource = Me.GESTDataSet
        '
        'GESTDataSet
        '
        Me.GESTDataSet.DataSetName = "GESTDataSet"
        Me.GESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SPEmisionGuiaDespachoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.Print_Masivo_Guias.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(844, 716)
        Me.ReportViewer1.TabIndex = 0
        '
        'nDespacho
        '
        Me.nDespacho.Location = New System.Drawing.Point(671, 2)
        Me.nDespacho.Name = "nDespacho"
        Me.nDespacho.ReadOnly = True
        Me.nDespacho.Size = New System.Drawing.Size(100, 20)
        Me.nDespacho.TabIndex = 1
        Me.nDespacho.Visible = False
        '
        'SP_EmisionGuiaDespachoTableAdapter
        '
        Me.SP_EmisionGuiaDespachoTableAdapter.ClearBeforeFill = True
        '
        'Print_Guia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 716)
        Me.Controls.Add(Me.nDespacho)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Print_Guia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresión Guías Despacho"
        CType(Me.SPEmisionGuiaDespachoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents nDespacho As TextBox
    Friend WithEvents SPEmisionGuiaDespachoBindingSource As BindingSource
    Friend WithEvents GESTDataSet As GESTDataSet
    Friend WithEvents SP_EmisionGuiaDespachoTableAdapter As GESTDataSetTableAdapters.SP_EmisionGuiaDespachoTableAdapter
End Class
