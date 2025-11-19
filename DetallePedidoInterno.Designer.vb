<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetallePedidoInterno
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GESTDataSet = New GestionVivero.GESTDataSet()
        Me.SPCONSULTAPEDIDOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CONSULTA_PEDIDOTableAdapter = New GestionVivero.GESTDataSetTableAdapters.SP_CONSULTA_PEDIDOTableAdapter()
        Me.SPCONSULTAPEDIDODETALLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CONSULTA_PEDIDO_DETALLETableAdapter = New GestionVivero.GESTDataSetTableAdapters.SP_CONSULTA_PEDIDO_DETALLETableAdapter()
        Me.SYSINIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SYS_INITableAdapter = New GestionVivero.GESTDataSetTableAdapters.SYS_INITableAdapter()
        Me.SP_CONSULTA_PEDIDOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CONSULTA_PEDIDO_DETALLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SYS_INIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.GESTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPCONSULTAPEDIDOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPCONSULTAPEDIDODETALLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SYSINIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CONSULTA_PEDIDOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CONSULTA_PEDIDO_DETALLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SYS_INIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SP_CONSULTA_PEDIDOBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.SP_CONSULTA_PEDIDO_DETALLEBindingSource
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.SYS_INIBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.DetallePedidoInterno.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1181, 510)
        Me.ReportViewer1.TabIndex = 0
        '
        'GESTDataSet
        '
        Me.GESTDataSet.DataSetName = "GESTDataSet"
        Me.GESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SPCONSULTAPEDIDOBindingSource
        '
        Me.SPCONSULTAPEDIDOBindingSource.DataMember = "SP_CONSULTA_PEDIDO"
        Me.SPCONSULTAPEDIDOBindingSource.DataSource = Me.GESTDataSet
        '
        'SP_CONSULTA_PEDIDOTableAdapter
        '
        Me.SP_CONSULTA_PEDIDOTableAdapter.ClearBeforeFill = True
        '
        'SPCONSULTAPEDIDODETALLEBindingSource
        '
        Me.SPCONSULTAPEDIDODETALLEBindingSource.DataMember = "SP_CONSULTA_PEDIDO_DETALLE"
        Me.SPCONSULTAPEDIDODETALLEBindingSource.DataSource = Me.GESTDataSet
        '
        'SP_CONSULTA_PEDIDO_DETALLETableAdapter
        '
        Me.SP_CONSULTA_PEDIDO_DETALLETableAdapter.ClearBeforeFill = True
        '
        'SYSINIBindingSource
        '
        Me.SYSINIBindingSource.DataMember = "SYS_INI"
        Me.SYSINIBindingSource.DataSource = Me.GESTDataSet
        '
        'SYS_INITableAdapter
        '
        Me.SYS_INITableAdapter.ClearBeforeFill = True
        '
        'SP_CONSULTA_PEDIDOBindingSource
        '
        Me.SP_CONSULTA_PEDIDOBindingSource.DataMember = "SP_CONSULTA_PEDIDO"
        Me.SP_CONSULTA_PEDIDOBindingSource.DataSource = Me.GESTDataSet
        '
        'SP_CONSULTA_PEDIDO_DETALLEBindingSource
        '
        Me.SP_CONSULTA_PEDIDO_DETALLEBindingSource.DataMember = "SP_CONSULTA_PEDIDO_DETALLE"
        Me.SP_CONSULTA_PEDIDO_DETALLEBindingSource.DataSource = Me.GESTDataSet
        '
        'SYS_INIBindingSource
        '
        Me.SYS_INIBindingSource.DataMember = "SYS_INI"
        Me.SYS_INIBindingSource.DataSource = Me.GESTDataSet
        '
        'DetallePedidoInterno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 510)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "DetallePedidoInterno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle Pedido Interno"
        CType(Me.GESTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPCONSULTAPEDIDOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPCONSULTAPEDIDODETALLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SYSINIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CONSULTA_PEDIDOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CONSULTA_PEDIDO_DETALLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SYS_INIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GESTDataSet As GESTDataSet
    Friend WithEvents SPCONSULTAPEDIDOBindingSource As BindingSource
    Friend WithEvents SP_CONSULTA_PEDIDOTableAdapter As GESTDataSetTableAdapters.SP_CONSULTA_PEDIDOTableAdapter
    Friend WithEvents SPCONSULTAPEDIDODETALLEBindingSource As BindingSource
    Friend WithEvents SP_CONSULTA_PEDIDO_DETALLETableAdapter As GESTDataSetTableAdapters.SP_CONSULTA_PEDIDO_DETALLETableAdapter
    Friend WithEvents SYSINIBindingSource As BindingSource
    Friend WithEvents SYS_INITableAdapter As GESTDataSetTableAdapters.SYS_INITableAdapter
    Friend WithEvents SP_CONSULTA_PEDIDOBindingSource As BindingSource
    Friend WithEvents SP_CONSULTA_PEDIDO_DETALLEBindingSource As BindingSource
    Friend WithEvents SYS_INIBindingSource As BindingSource
End Class
