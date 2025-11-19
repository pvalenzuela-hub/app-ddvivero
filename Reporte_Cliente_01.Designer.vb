<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte_Cliente_01
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.SP_CONSULTA_CLIENTE_SINVENTASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetContaCmbte = New GestionVivero.DataSetContaCmbte()
        Me.txt_Fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SP_CONSULTA_CLIENTE_SINVENTASTableAdapter = New GestionVivero.DataSetContaCmbteTableAdapters.SP_CONSULTA_CLIENTE_SINVENTASTableAdapter()
        CType(Me.SP_CONSULTA_CLIENTE_SINVENTASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetContaCmbte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SP_CONSULTA_CLIENTE_SINVENTASBindingSource
        '
        Me.SP_CONSULTA_CLIENTE_SINVENTASBindingSource.DataMember = "SP_CONSULTA_CLIENTE_SINVENTAS"
        Me.SP_CONSULTA_CLIENTE_SINVENTASBindingSource.DataSource = Me.DataSetContaCmbte
        '
        'DataSetContaCmbte
        '
        Me.DataSetContaCmbte.DataSetName = "DataSetContaCmbte"
        Me.DataSetContaCmbte.Locale = New System.Globalization.CultureInfo("es-CL")
        Me.DataSetContaCmbte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_Fecha1
        '
        Me.txt_Fecha1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Fecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_Fecha1.Location = New System.Drawing.Point(430, 15)
        Me.txt_Fecha1.Name = "txt_Fecha1"
        Me.txt_Fecha1.Size = New System.Drawing.Size(127, 25)
        Me.txt_Fecha1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(303, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sin Ventas desde"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Fecha1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1020, 549)
        Me.SplitContainer1.SplitterDistance = 54
        Me.SplitContainer1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button2.Location = New System.Drawing.Point(916, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 34)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SP_CONSULTA_CLIENTE_SINVENTASBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.ReporteClientesSinVentas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1020, 491)
        Me.ReportViewer1.TabIndex = 0
        '
        'SP_CONSULTA_CLIENTE_SINVENTASTableAdapter
        '
        Me.SP_CONSULTA_CLIENTE_SINVENTASTableAdapter.ClearBeforeFill = True
        '
        'Reporte_Cliente_01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 549)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Reporte_Cliente_01"
        Me.Text = "REPORTE CLIENTES SIN VENTAS"
        CType(Me.SP_CONSULTA_CLIENTE_SINVENTASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetContaCmbte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_Fecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SP_CONSULTA_CLIENTE_SINVENTASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetContaCmbte As GestionVivero.DataSetContaCmbte
    Friend WithEvents SP_CONSULTA_CLIENTE_SINVENTASTableAdapter As GestionVivero.DataSetContaCmbteTableAdapters.SP_CONSULTA_CLIENTE_SINVENTASTableAdapter
End Class
