<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformeCCosto
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
        Me.DataSetContaCmbte = New GestionVivero.DataSetContaCmbte()
        Me.CONTASPConsultaCCostoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONTA_SPConsultaCCostoTableAdapter = New GestionVivero.DataSetContaCmbteTableAdapters.CONTA_SPConsultaCCostoTableAdapter()
        CType(Me.DataSetContaCmbte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTASPConsultaCCostoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.CONTASPConsultaCCostoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.InformeCCosto.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSetContaCmbte
        '
        Me.DataSetContaCmbte.DataSetName = "DataSetContaCmbte"
        Me.DataSetContaCmbte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONTASPConsultaCCostoBindingSource
        '
        Me.CONTASPConsultaCCostoBindingSource.DataMember = "CONTA_SPConsultaCCosto"
        Me.CONTASPConsultaCCostoBindingSource.DataSource = Me.DataSetContaCmbte
        '
        'CONTA_SPConsultaCCostoTableAdapter
        '
        Me.CONTA_SPConsultaCCostoTableAdapter.ClearBeforeFill = True
        '
        'InformeCCosto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "InformeCCosto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe C.Costo"
        CType(Me.DataSetContaCmbte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTASPConsultaCCostoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataSetContaCmbte As DataSetContaCmbte
    Friend WithEvents CONTASPConsultaCCostoBindingSource As BindingSource
    Friend WithEvents CONTA_SPConsultaCCostoTableAdapter As DataSetContaCmbteTableAdapters.CONTA_SPConsultaCCostoTableAdapter
End Class
