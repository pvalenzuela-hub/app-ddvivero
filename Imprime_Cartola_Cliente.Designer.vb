<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Imprime_Cartola_Cliente
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.SP_CONSULTA_CLIENTE_IDclienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GESTDataSet = New GestionVivero.GESTDataSet()
        Me.SP_Cartola_Cliente_IdClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Cartola_Cliente_DocXcobrar_IdCLienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Consulta_Resumen_Deuda_Cliente_IdClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SP_CONSULTA_CLIENTE_IDclienteTableAdapter = New GestionVivero.GESTDataSetTableAdapters.SP_CONSULTA_CLIENTE_IDclienteTableAdapter()
        Me.SP_Cartola_Cliente_IdClienteTableAdapter = New GestionVivero.GESTDataSetTableAdapters.SP_Cartola_Cliente_IdClienteTableAdapter()
        Me.SP_Cartola_Cliente_DocXcobrar_IdCLienteTableAdapter = New GestionVivero.GESTDataSetTableAdapters.SP_Cartola_Cliente_DocXcobrar_IdCLienteTableAdapter()
        Me.SP_Consulta_Resumen_Deuda_Cliente_IdClienteTableAdapter = New GestionVivero.GESTDataSetTableAdapters.SP_Consulta_Resumen_Deuda_Cliente_IdClienteTableAdapter()
        CType(Me.SP_CONSULTA_CLIENTE_IDclienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Cartola_Cliente_IdClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Cartola_Cliente_DocXcobrar_IdCLienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Consulta_Resumen_Deuda_Cliente_IdClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SP_CONSULTA_CLIENTE_IDclienteBindingSource
        '
        Me.SP_CONSULTA_CLIENTE_IDclienteBindingSource.DataMember = "SP_CONSULTA_CLIENTE_IDcliente"
        Me.SP_CONSULTA_CLIENTE_IDclienteBindingSource.DataSource = Me.GESTDataSet
        '
        'GESTDataSet
        '
        Me.GESTDataSet.DataSetName = "GESTDataSet"
        Me.GESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_Cartola_Cliente_IdClienteBindingSource
        '
        Me.SP_Cartola_Cliente_IdClienteBindingSource.DataMember = "SP_Cartola_Cliente_IdCliente"
        Me.SP_Cartola_Cliente_IdClienteBindingSource.DataSource = Me.GESTDataSet
        '
        'SP_Cartola_Cliente_DocXcobrar_IdCLienteBindingSource
        '
        Me.SP_Cartola_Cliente_DocXcobrar_IdCLienteBindingSource.DataMember = "SP_Cartola_Cliente_DocXcobrar_IdCLiente"
        Me.SP_Cartola_Cliente_DocXcobrar_IdCLienteBindingSource.DataSource = Me.GESTDataSet
        '
        'SP_Consulta_Resumen_Deuda_Cliente_IdClienteBindingSource
        '
        Me.SP_Consulta_Resumen_Deuda_Cliente_IdClienteBindingSource.DataMember = "SP_Consulta_Resumen_Deuda_Cliente_IdCliente"
        Me.SP_Consulta_Resumen_Deuda_Cliente_IdClienteBindingSource.DataSource = Me.GESTDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SP_CONSULTA_CLIENTE_IDclienteBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.SP_Cartola_Cliente_IdClienteBindingSource
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.SP_Cartola_Cliente_DocXcobrar_IdCLienteBindingSource
        ReportDataSource4.Name = "DataSet4"
        ReportDataSource4.Value = Me.SP_Consulta_Resumen_Deuda_Cliente_IdClienteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.Rep_Cartola_Cliente.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1024, 716)
        Me.ReportViewer1.TabIndex = 0
        '
        'SP_CONSULTA_CLIENTE_IDclienteTableAdapter
        '
        Me.SP_CONSULTA_CLIENTE_IDclienteTableAdapter.ClearBeforeFill = True
        '
        'SP_Cartola_Cliente_IdClienteTableAdapter
        '
        Me.SP_Cartola_Cliente_IdClienteTableAdapter.ClearBeforeFill = True
        '
        'SP_Cartola_Cliente_DocXcobrar_IdCLienteTableAdapter
        '
        Me.SP_Cartola_Cliente_DocXcobrar_IdCLienteTableAdapter.ClearBeforeFill = True
        '
        'SP_Consulta_Resumen_Deuda_Cliente_IdClienteTableAdapter
        '
        Me.SP_Consulta_Resumen_Deuda_Cliente_IdClienteTableAdapter.ClearBeforeFill = True
        '
        'Imprime_Cartola_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 716)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Imprime_Cartola_Cliente"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cartola Cliente"
        CType(Me.SP_CONSULTA_CLIENTE_IDclienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Cartola_Cliente_IdClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Cartola_Cliente_DocXcobrar_IdCLienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Consulta_Resumen_Deuda_Cliente_IdClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SP_CONSULTA_CLIENTE_IDclienteBindingSource As BindingSource
    Friend WithEvents GESTDataSet As GESTDataSet
    Friend WithEvents SP_Cartola_Cliente_IdClienteBindingSource As BindingSource
    Friend WithEvents SP_Cartola_Cliente_DocXcobrar_IdCLienteBindingSource As BindingSource
    Friend WithEvents SP_Consulta_Resumen_Deuda_Cliente_IdClienteBindingSource As BindingSource
    Friend WithEvents SP_CONSULTA_CLIENTE_IDclienteTableAdapter As GESTDataSetTableAdapters.SP_CONSULTA_CLIENTE_IDclienteTableAdapter
    Friend WithEvents SP_Cartola_Cliente_IdClienteTableAdapter As GESTDataSetTableAdapters.SP_Cartola_Cliente_IdClienteTableAdapter
    Friend WithEvents SP_Cartola_Cliente_DocXcobrar_IdCLienteTableAdapter As GESTDataSetTableAdapters.SP_Cartola_Cliente_DocXcobrar_IdCLienteTableAdapter
    Friend WithEvents SP_Consulta_Resumen_Deuda_Cliente_IdClienteTableAdapter As GESTDataSetTableAdapters.SP_Consulta_Resumen_Deuda_Cliente_IdClienteTableAdapter
End Class
