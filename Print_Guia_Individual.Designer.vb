<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Print_Guia_Individual
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GESTDataSet = New GestionVivero.GESTDataSet()
        Me.SPCONSULTAGUIABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CONSULTA_GUIATableAdapter = New GestionVivero.GESTDataSetTableAdapters.SP_CONSULTA_GUIATableAdapter()
        Me.NumGuia = New System.Windows.Forms.TextBox()
        CType(Me.GESTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPCONSULTAGUIABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.SPCONSULTAGUIABindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.Print_Guia_rpt.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(844, 716)
        Me.ReportViewer1.TabIndex = 0
        '
        'GESTDataSet
        '
        Me.GESTDataSet.DataSetName = "GESTDataSet"
        Me.GESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SPCONSULTAGUIABindingSource
        '
        Me.SPCONSULTAGUIABindingSource.DataMember = "SP_CONSULTA_GUIA"
        Me.SPCONSULTAGUIABindingSource.DataSource = Me.GESTDataSet
        '
        'SP_CONSULTA_GUIATableAdapter
        '
        Me.SP_CONSULTA_GUIATableAdapter.ClearBeforeFill = True
        '
        'NumGuia
        '
        Me.NumGuia.Location = New System.Drawing.Point(669, 0)
        Me.NumGuia.Name = "NumGuia"
        Me.NumGuia.ReadOnly = True
        Me.NumGuia.Size = New System.Drawing.Size(100, 20)
        Me.NumGuia.TabIndex = 2
        Me.NumGuia.Visible = False
        '
        'Print_Guia_Individual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 716)
        Me.Controls.Add(Me.NumGuia)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Print_Guia_Individual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresión Guía Individual"
        CType(Me.GESTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPCONSULTAGUIABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SPCONSULTAGUIABindingSource As BindingSource
    Friend WithEvents GESTDataSet As GESTDataSet
    Friend WithEvents SP_CONSULTA_GUIATableAdapter As GESTDataSetTableAdapters.SP_CONSULTA_GUIATableAdapter
    Friend WithEvents NumGuia As TextBox
End Class
