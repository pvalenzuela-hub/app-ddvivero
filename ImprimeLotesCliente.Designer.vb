<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprimeLotesCliente
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
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.GESTDataSet = New GestionVivero.GESTDataSet()
        Me.SPCONSULTALOTECLIENTEVigenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CONSULTA_LOTE_CLIENTE_VigenteTableAdapter = New GestionVivero.GESTDataSetTableAdapters.SP_CONSULTA_LOTE_CLIENTE_VigenteTableAdapter()
        Me.SP_CONSULTA_LOTE_CLIENTE_VigenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.GESTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPCONSULTALOTECLIENTEVigenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CONSULTA_LOTE_CLIENTE_VigenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SP_CONSULTA_LOTE_CLIENTE_VigenteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.ImprimeLotesCliente.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(956, 475)
        Me.ReportViewer1.TabIndex = 0
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(693, 0)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtIdCliente.TabIndex = 1
        Me.txtIdCliente.Visible = False
        '
        'GESTDataSet
        '
        Me.GESTDataSet.DataSetName = "GESTDataSet"
        Me.GESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SPCONSULTALOTECLIENTEVigenteBindingSource
        '
        Me.SPCONSULTALOTECLIENTEVigenteBindingSource.DataMember = "SP_CONSULTA_LOTE_CLIENTE_Vigente"
        Me.SPCONSULTALOTECLIENTEVigenteBindingSource.DataSource = Me.GESTDataSet
        '
        'SP_CONSULTA_LOTE_CLIENTE_VigenteTableAdapter
        '
        Me.SP_CONSULTA_LOTE_CLIENTE_VigenteTableAdapter.ClearBeforeFill = True
        '
        'SP_CONSULTA_LOTE_CLIENTE_VigenteBindingSource
        '
        Me.SP_CONSULTA_LOTE_CLIENTE_VigenteBindingSource.DataMember = "SP_CONSULTA_LOTE_CLIENTE_Vigente"
        Me.SP_CONSULTA_LOTE_CLIENTE_VigenteBindingSource.DataSource = Me.GESTDataSet
        '
        'ImprimeLotesCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 475)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ImprimeLotesCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lotes Cliente"
        CType(Me.GESTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPCONSULTALOTECLIENTEVigenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CONSULTA_LOTE_CLIENTE_VigenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents SPCONSULTALOTECLIENTEVigenteBindingSource As BindingSource
    Friend WithEvents GESTDataSet As GESTDataSet
    Friend WithEvents SP_CONSULTA_LOTE_CLIENTE_VigenteTableAdapter As GESTDataSetTableAdapters.SP_CONSULTA_LOTE_CLIENTE_VigenteTableAdapter
    Friend WithEvents SP_CONSULTA_LOTE_CLIENTE_VigenteBindingSource As BindingSource
End Class
