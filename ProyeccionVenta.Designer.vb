<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProyeccionVenta
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCantMeses = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GESTDataSet49 = New GestionVivero.GESTDataSet49()
        Me.SP_ReporteProyecVentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_ReporteProyecVentaTableAdapter = New GestionVivero.GESTDataSet49TableAdapters.SP_ReporteProyecVentaTableAdapter()
        CType(Me.txtCantMeses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTDataSet49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_ReporteProyecVentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Períodos:"
        '
        'txtCantMeses
        '
        Me.txtCantMeses.Location = New System.Drawing.Point(152, 12)
        Me.txtCantMeses.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.txtCantMeses.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtCantMeses.Name = "txtCantMeses"
        Me.txtCantMeses.Size = New System.Drawing.Size(40, 20)
        Me.txtCantMeses.TabIndex = 1
        Me.txtCantMeses.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Button1
        '
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button1.Location = New System.Drawing.Point(199, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 33)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SP_ReporteProyecVentaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.ReporteProjecVta.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 54)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(308, 258)
        Me.ReportViewer1.TabIndex = 3
        '
        'GESTDataSet49
        '
        Me.GESTDataSet49.DataSetName = "GESTDataSet49"
        Me.GESTDataSet49.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_ReporteProyecVentaBindingSource
        '
        Me.SP_ReporteProyecVentaBindingSource.DataMember = "SP_ReporteProyecVenta"
        Me.SP_ReporteProyecVentaBindingSource.DataSource = Me.GESTDataSet49
        '
        'SP_ReporteProyecVentaTableAdapter
        '
        Me.SP_ReporteProyecVentaTableAdapter.ClearBeforeFill = True
        '
        'ProyeccionVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 324)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCantMeses)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ProyeccionVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proyección de Ventas"
        CType(Me.txtCantMeses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTDataSet49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_ReporteProyecVentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCantMeses As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SP_ReporteProyecVentaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GESTDataSet49 As GestionVivero.GESTDataSet49
    Friend WithEvents SP_ReporteProyecVentaTableAdapter As GestionVivero.GESTDataSet49TableAdapters.SP_ReporteProyecVentaTableAdapter
End Class
