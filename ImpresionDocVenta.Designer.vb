<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImpresionDocVenta
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.SP_Lectura_Enc_FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataVentas = New GestionVivero.DataVentas()
        Me.SP_Lectura_Det_FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SPLecturaEncFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Lectura_Enc_FacturaTableAdapter = New GestionVivero.DataVentasTableAdapters.SP_Lectura_Enc_FacturaTableAdapter()
        Me.SPLecturaDetFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Lectura_Det_FacturaTableAdapter = New GestionVivero.DataVentasTableAdapters.SP_Lectura_Det_FacturaTableAdapter()
        Me.idvtahead = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.SP_Lectura_Enc_FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Lectura_Det_FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPLecturaEncFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPLecturaDetFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SP_Lectura_Enc_FacturaBindingSource
        '
        Me.SP_Lectura_Enc_FacturaBindingSource.DataMember = "SP_Lectura_Enc_Factura"
        Me.SP_Lectura_Enc_FacturaBindingSource.DataSource = Me.DataVentas
        '
        'DataVentas
        '
        Me.DataVentas.DataSetName = "DataVentas"
        Me.DataVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_Lectura_Det_FacturaBindingSource
        '
        Me.SP_Lectura_Det_FacturaBindingSource.DataMember = "SP_Lectura_Det_Factura"
        Me.SP_Lectura_Det_FacturaBindingSource.DataSource = Me.DataVentas
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SP_Lectura_Enc_FacturaBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.SP_Lectura_Det_FacturaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.DocumentoVenta.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(755, 640)
        Me.ReportViewer1.TabIndex = 0
        '
        'SPLecturaEncFacturaBindingSource
        '
        Me.SPLecturaEncFacturaBindingSource.DataMember = "SP_Lectura_Enc_Factura"
        Me.SPLecturaEncFacturaBindingSource.DataSource = Me.DataVentas
        '
        'SP_Lectura_Enc_FacturaTableAdapter
        '
        Me.SP_Lectura_Enc_FacturaTableAdapter.ClearBeforeFill = True
        '
        'SPLecturaDetFacturaBindingSource
        '
        Me.SPLecturaDetFacturaBindingSource.DataMember = "SP_Lectura_Det_Factura"
        Me.SPLecturaDetFacturaBindingSource.DataSource = Me.DataVentas
        '
        'SP_Lectura_Det_FacturaTableAdapter
        '
        Me.SP_Lectura_Det_FacturaTableAdapter.ClearBeforeFill = True
        '
        'idvtahead
        '
        Me.idvtahead.Location = New System.Drawing.Point(632, 0)
        Me.idvtahead.Name = "idvtahead"
        Me.idvtahead.Size = New System.Drawing.Size(100, 20)
        Me.idvtahead.TabIndex = 1
        Me.idvtahead.Visible = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.GestionVivero.My.Resources.Resources.salir_40x401
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Location = New System.Drawing.Point(751, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 48)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ImpresionDocVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 640)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.idvtahead)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ImpresionDocVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresion Documento Venta"
        Me.TopMost = True
        CType(Me.SP_Lectura_Enc_FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Lectura_Det_FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPLecturaEncFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPLecturaDetFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SPLecturaEncFacturaBindingSource As BindingSource
    Friend WithEvents DataVentas As DataVentas
    Friend WithEvents SPLecturaDetFacturaBindingSource As BindingSource
    Friend WithEvents SP_Lectura_Enc_FacturaTableAdapter As DataVentasTableAdapters.SP_Lectura_Enc_FacturaTableAdapter
    Friend WithEvents SP_Lectura_Det_FacturaTableAdapter As DataVentasTableAdapters.SP_Lectura_Det_FacturaTableAdapter
    Friend WithEvents SP_Lectura_Enc_FacturaBindingSource As BindingSource
    Friend WithEvents SP_Lectura_Det_FacturaBindingSource As BindingSource
    Friend WithEvents idvtahead As TextBox
    Friend WithEvents Button1 As Button
End Class
