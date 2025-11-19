<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta_Lotes
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
        Me.txtIdSemilla = New System.Windows.Forms.TextBox()
        Me.txtIdVariedad = New System.Windows.Forms.TextBox()
        Me.GESTDataSet = New GestionVivero.GESTDataSet()
        Me.NEWSPCONSULTALOTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NEWSP_CONSULTA_LOTESTableAdapter = New GestionVivero.GESTDataSetTableAdapters.NEWSP_CONSULTA_LOTESTableAdapter()
        CType(Me.GESTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NEWSPCONSULTALOTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.NEWSPCONSULTALOTESBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.ReporteLotes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1109, 679)
        Me.ReportViewer1.TabIndex = 0
        '
        'txtIdSemilla
        '
        Me.txtIdSemilla.Location = New System.Drawing.Point(801, 5)
        Me.txtIdSemilla.Name = "txtIdSemilla"
        Me.txtIdSemilla.Size = New System.Drawing.Size(100, 20)
        Me.txtIdSemilla.TabIndex = 1
        Me.txtIdSemilla.Visible = False
        '
        'txtIdVariedad
        '
        Me.txtIdVariedad.Location = New System.Drawing.Point(930, 5)
        Me.txtIdVariedad.Name = "txtIdVariedad"
        Me.txtIdVariedad.Size = New System.Drawing.Size(100, 20)
        Me.txtIdVariedad.TabIndex = 2
        Me.txtIdVariedad.Visible = False
        '
        'GESTDataSet
        '
        Me.GESTDataSet.DataSetName = "GESTDataSet"
        Me.GESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NEWSPCONSULTALOTESBindingSource
        '
        Me.NEWSPCONSULTALOTESBindingSource.DataMember = "NEWSP_CONSULTA_LOTES"
        Me.NEWSPCONSULTALOTESBindingSource.DataSource = Me.GESTDataSet
        '
        'NEWSP_CONSULTA_LOTESTableAdapter
        '
        Me.NEWSP_CONSULTA_LOTESTableAdapter.ClearBeforeFill = True
        '
        'Consulta_Lotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 679)
        Me.Controls.Add(Me.txtIdVariedad)
        Me.Controls.Add(Me.txtIdSemilla)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Consulta_Lotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Lotes"
        CType(Me.GESTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NEWSPCONSULTALOTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txtIdSemilla As TextBox
    Friend WithEvents txtIdVariedad As TextBox
    Friend WithEvents NEWSPCONSULTALOTESBindingSource As BindingSource
    Friend WithEvents GESTDataSet As GESTDataSet
    Friend WithEvents NEWSP_CONSULTA_LOTESTableAdapter As GESTDataSetTableAdapters.NEWSP_CONSULTA_LOTESTableAdapter
End Class
