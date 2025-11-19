<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.SP_ReporteMovDiarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GESTDataSet36 = New GestionVivero.GESTDataSet36()
        Me.SP_ReporteEgresoCtaActivoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GESTDataSet37 = New GestionVivero.GESTDataSet37()
        Me.SP_Reporte_Resumen_DiarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SP_ReporteEgresoCtaActivoTableAdapter = New GestionVivero.GESTDataSet37TableAdapters.SP_ReporteEgresoCtaActivoTableAdapter()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SP_ReporteMovDiarioTableAdapter = New GestionVivero.GESTDataSet36TableAdapters.SP_ReporteMovDiarioTableAdapter()
        Me.SP_Reporte_Resumen_DiarioTableAdapter = New GestionVivero.GESTDataSet36TableAdapters.SP_Reporte_Resumen_DiarioTableAdapter()
        CType(Me.SP_ReporteMovDiarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTDataSet36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_ReporteEgresoCtaActivoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTDataSet37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Reporte_Resumen_DiarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SP_ReporteMovDiarioBindingSource
        '
        Me.SP_ReporteMovDiarioBindingSource.DataMember = "SP_ReporteMovDiario"
        Me.SP_ReporteMovDiarioBindingSource.DataSource = Me.GESTDataSet36
        '
        'GESTDataSet36
        '
        Me.GESTDataSet36.DataSetName = "GESTDataSet36"
        Me.GESTDataSet36.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_ReporteEgresoCtaActivoBindingSource
        '
        Me.SP_ReporteEgresoCtaActivoBindingSource.DataMember = "SP_ReporteEgresoCtaActivo"
        Me.SP_ReporteEgresoCtaActivoBindingSource.DataSource = Me.GESTDataSet37
        '
        'GESTDataSet37
        '
        Me.GESTDataSet37.DataSetName = "GESTDataSet37"
        Me.GESTDataSet37.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_Reporte_Resumen_DiarioBindingSource
        '
        Me.SP_Reporte_Resumen_DiarioBindingSource.DataMember = "SP_Reporte_Resumen_Diario"
        Me.SP_Reporte_Resumen_DiarioBindingSource.DataSource = Me.GESTDataSet36
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SP_ReporteMovDiarioBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.SP_ReporteEgresoCtaActivoBindingSource
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.SP_Reporte_Resumen_DiarioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.RepDiarioCaja.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1286, 672)
        Me.ReportViewer1.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(518, 9)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(108, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button1.Location = New System.Drawing.Point(659, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SP_ReporteEgresoCtaActivoTableAdapter
        '
        Me.SP_ReporteEgresoCtaActivoTableAdapter.ClearBeforeFill = True
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTimePicker1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1286, 740)
        Me.SplitContainer1.SplitterDistance = 64
        Me.SplitContainer1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(407, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha Reporte"
        '
        'SP_ReporteMovDiarioTableAdapter
        '
        Me.SP_ReporteMovDiarioTableAdapter.ClearBeforeFill = True
        '
        'SP_Reporte_Resumen_DiarioTableAdapter
        '
        Me.SP_Reporte_Resumen_DiarioTableAdapter.ClearBeforeFill = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1286, 740)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form3"
        Me.Text = "Reporte Cuadratura Diaria"
        CType(Me.SP_ReporteMovDiarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTDataSet36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_ReporteEgresoCtaActivoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTDataSet37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Reporte_Resumen_DiarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SP_ReporteMovDiarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GESTDataSet36 As GestionVivero.GESTDataSet36
    Friend WithEvents SP_ReporteMovDiarioTableAdapter As GestionVivero.GESTDataSet36TableAdapters.SP_ReporteMovDiarioTableAdapter
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SP_ReporteEgresoCtaActivoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GESTDataSet37 As GestionVivero.GESTDataSet37
    Friend WithEvents SP_ReporteEgresoCtaActivoTableAdapter As GestionVivero.GESTDataSet37TableAdapters.SP_ReporteEgresoCtaActivoTableAdapter
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SP_Reporte_Resumen_DiarioBindingSource As BindingSource
    Friend WithEvents SP_Reporte_Resumen_DiarioTableAdapter As GESTDataSet36TableAdapters.SP_Reporte_Resumen_DiarioTableAdapter
End Class
