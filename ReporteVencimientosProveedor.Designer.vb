<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteVencimientosProveedor
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_Vencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSetCompras = New GestionVivero.DataSetCompras()
        Me.SP_CONSULTA_Vencto_Doc_CompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CONSULTA_Vencto_Doc_CompraTableAdapter = New GestionVivero.DataSetComprasTableAdapters.SP_CONSULTA_Vencto_Doc_CompraTableAdapter()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataSetCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CONSULTA_Vencto_Doc_CompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtp_Vencimiento)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1284, 681)
        Me.SplitContainer1.SplitterDistance = 56
        Me.SplitContainer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(508, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vencimientos Hasta:"
        '
        'dtp_Vencimiento
        '
        Me.dtp_Vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Vencimiento.Location = New System.Drawing.Point(618, 21)
        Me.dtp_Vencimiento.Name = "dtp_Vencimiento"
        Me.dtp_Vencimiento.Size = New System.Drawing.Size(93, 20)
        Me.dtp_Vencimiento.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button2.Location = New System.Drawing.Point(1180, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(52, 56)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.GestionVivero.My.Resources.Resources.Close
        Me.Button3.Location = New System.Drawing.Point(1232, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(52, 56)
        Me.Button3.TabIndex = 7
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.SP_CONSULTA_Vencto_Doc_CompraBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.ReportVencimientosProveedor.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1284, 621)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSetCompras
        '
        Me.DataSetCompras.DataSetName = "DataSetCompras"
        Me.DataSetCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_CONSULTA_Vencto_Doc_CompraBindingSource
        '
        Me.SP_CONSULTA_Vencto_Doc_CompraBindingSource.DataMember = "SP_CONSULTA_Vencto_Doc_Compra"
        Me.SP_CONSULTA_Vencto_Doc_CompraBindingSource.DataSource = Me.DataSetCompras
        '
        'SP_CONSULTA_Vencto_Doc_CompraTableAdapter
        '
        Me.SP_CONSULTA_Vencto_Doc_CompraTableAdapter.ClearBeforeFill = True
        '
        'ReporteVencimientosProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ReporteVencimientosProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vencimientos por Proveedor"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataSetCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CONSULTA_Vencto_Doc_CompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents dtp_Vencimiento As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SP_CONSULTA_Vencto_Doc_CompraBindingSource As BindingSource
    Friend WithEvents DataSetCompras As DataSetCompras
    Friend WithEvents SP_CONSULTA_Vencto_Doc_CompraTableAdapter As DataSetComprasTableAdapters.SP_CONSULTA_Vencto_Doc_CompraTableAdapter
End Class
