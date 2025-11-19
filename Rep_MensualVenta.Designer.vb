<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Rep_MensualVenta
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
        Me.SP_ReporteVentaMensualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_ReporteVentas = New GestionVivero.DS_ReporteVentas()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpPeriodo2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpPeriodo1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SP_ReporteVentaMensualTableAdapter = New GestionVivero.DS_ReporteVentasTableAdapters.SP_ReporteVentaMensualTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.SP_ReporteVentaMensualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_ReporteVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SP_ReporteVentaMensualBindingSource
        '
        Me.SP_ReporteVentaMensualBindingSource.DataMember = "SP_ReporteVentaMensual"
        Me.SP_ReporteVentaMensualBindingSource.DataSource = Me.DS_ReporteVentas
        '
        'DS_ReporteVentas
        '
        Me.DS_ReporteVentas.DataSetName = "DS_ReporteVentas"
        Me.DS_ReporteVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(451, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(279, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Desde"
        '
        'dtpPeriodo2
        '
        Me.dtpPeriodo2.CustomFormat = "MM/yyyy"
        Me.dtpPeriodo2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPeriodo2.Location = New System.Drawing.Point(498, 36)
        Me.dtpPeriodo2.Name = "dtpPeriodo2"
        Me.dtpPeriodo2.Size = New System.Drawing.Size(78, 20)
        Me.dtpPeriodo2.TabIndex = 8
        '
        'dtpPeriodo1
        '
        Me.dtpPeriodo1.CustomFormat = "MM/yyyy"
        Me.dtpPeriodo1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPeriodo1.Location = New System.Drawing.Point(323, 36)
        Me.dtpPeriodo1.Name = "dtpPeriodo1"
        Me.dtpPeriodo1.Size = New System.Drawing.Size(82, 20)
        Me.dtpPeriodo1.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button1.Location = New System.Drawing.Point(845, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 41)
        Me.Button1.TabIndex = 11
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.Close
        Me.Button2.Location = New System.Drawing.Point(897, 28)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(46, 41)
        Me.Button2.TabIndex = 12
        Me.Button2.UseVisualStyleBackColor = False
        '
        'SP_ReporteVentaMensualTableAdapter
        '
        Me.SP_ReporteVentaMensualTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SP_ReporteVentaMensualBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.VentaMensual.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(968, 624)
        Me.ReportViewer1.TabIndex = 14
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpPeriodo1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpPeriodo2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(968, 723)
        Me.SplitContainer1.SplitterDistance = 95
        Me.SplitContainer1.TabIndex = 15
        '
        'Rep_MensualVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 723)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Rep_MensualVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Saldo Mensual --> Caja y Bancos"
        CType(Me.SP_ReporteVentaMensualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_ReporteVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpPeriodo2 As DateTimePicker
    Friend WithEvents dtpPeriodo1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents SP_ReporteVentaMensualBindingSource As BindingSource
    Friend WithEvents DS_ReporteVentas As DS_ReporteVentas
    Friend WithEvents SP_ReporteVentaMensualTableAdapter As DS_ReporteVentasTableAdapters.SP_ReporteVentaMensualTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SplitContainer1 As SplitContainer
End Class
