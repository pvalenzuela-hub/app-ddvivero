<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LotesParaConteo
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
        Me.SP_CONSULTALoteparaConteoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GESTDataSet = New GestionVivero.GESTDataSet()
        Me.SP_CONSULTALoteparaConteoTableAdapter = New GestionVivero.GESTDataSetTableAdapters.SP_CONSULTALoteparaConteoTableAdapter()
        Me.TableAdapterManager = New GestionVivero.GESTDataSetTableAdapters.TableAdapterManager()
        CType(Me.SP_CONSULTALoteparaConteoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SP_CONSULTALoteparaConteoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.ReporteLotesparaConteo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1144, 573)
        Me.ReportViewer1.TabIndex = 0
        '
        'SP_CONSULTALoteparaConteoBindingSource
        '
        Me.SP_CONSULTALoteparaConteoBindingSource.DataMember = "SP_CONSULTALoteparaConteo"
        Me.SP_CONSULTALoteparaConteoBindingSource.DataSource = Me.GESTDataSet
        '
        'GESTDataSet
        '
        Me.GESTDataSet.DataSetName = "GESTDataSet"
        Me.GESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_CONSULTALoteparaConteoTableAdapter
        '
        Me.SP_CONSULTALoteparaConteoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BANCOTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.SYS_INITableAdapter = Nothing
        Me.TableAdapterManager.TBL_EVENTOTableAdapter = Nothing
        Me.TableAdapterManager.TBL_TIPO_BANDEJATableAdapter = Nothing
        Me.TableAdapterManager.tEstadoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GestionVivero.GESTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LotesParaConteo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 573)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "LotesParaConteo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lotes Para Conteo"
        CType(Me.SP_CONSULTALoteparaConteoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GESTDataSet As GESTDataSet
    Friend WithEvents SP_CONSULTALoteparaConteoBindingSource As BindingSource
    Friend WithEvents SP_CONSULTALoteparaConteoTableAdapter As GESTDataSetTableAdapters.SP_CONSULTALoteparaConteoTableAdapter
    Friend WithEvents TableAdapterManager As GESTDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
