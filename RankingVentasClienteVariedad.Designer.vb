<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RankingVentasClienteVariedad
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSemilla = New System.Windows.Forms.ComboBox()
        Me.DateHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GESTDataSet42 = New GestionVivero.GESTDataSet42()
        Me.SP_ReporteRankingVentaClienteVariedadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_ReporteRankingVentaClienteVariedadTableAdapter = New GestionVivero.GESTDataSet42TableAdapters.SP_ReporteRankingVentaClienteVariedadTableAdapter()
        CType(Me.GESTDataSet42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_ReporteRankingVentaClienteVariedadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 23)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Nueva Consulta"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button1.Location = New System.Drawing.Point(722, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 31)
        Me.Button1.TabIndex = 33
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(437, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Semilla"
        '
        'cmbSemilla
        '
        Me.cmbSemilla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSemilla.FormattingEnabled = True
        Me.cmbSemilla.Location = New System.Drawing.Point(483, 12)
        Me.cmbSemilla.Name = "cmbSemilla"
        Me.cmbSemilla.Size = New System.Drawing.Size(219, 21)
        Me.cmbSemilla.TabIndex = 31
        '
        'DateHasta
        '
        Me.DateHasta.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateHasta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateHasta.Location = New System.Drawing.Point(323, 12)
        Me.DateHasta.Name = "DateHasta"
        Me.DateHasta.Size = New System.Drawing.Size(98, 21)
        Me.DateHasta.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(279, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Hasta:"
        '
        'DateDesde
        '
        Me.DateDesde.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDesde.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDesde.Location = New System.Drawing.Point(157, 12)
        Me.DateDesde.Name = "DateDesde"
        Me.DateDesde.Size = New System.Drawing.Size(92, 21)
        Me.DateDesde.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Desde:"
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.SP_ReporteRankingVentaClienteVariedadBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.ReporteRankingVentaClienteVariedad.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 42)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(878, 578)
        Me.ReportViewer1.TabIndex = 34
        '
        'GESTDataSet42
        '
        Me.GESTDataSet42.DataSetName = "GESTDataSet42"
        Me.GESTDataSet42.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_ReporteRankingVentaClienteVariedadBindingSource
        '
        Me.SP_ReporteRankingVentaClienteVariedadBindingSource.DataMember = "SP_ReporteRankingVentaClienteVariedad"
        Me.SP_ReporteRankingVentaClienteVariedadBindingSource.DataSource = Me.GESTDataSet42
        '
        'SP_ReporteRankingVentaClienteVariedadTableAdapter
        '
        Me.SP_ReporteRankingVentaClienteVariedadTableAdapter.ClearBeforeFill = True
        '
        'RankingVentasClienteVariedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 622)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbSemilla)
        Me.Controls.Add(Me.DateHasta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateDesde)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "RankingVentasClienteVariedad"
        Me.Text = "Ranking Ventas por Cliente y Variedad"
        CType(Me.GESTDataSet42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_ReporteRankingVentaClienteVariedadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbSemilla As System.Windows.Forms.ComboBox
    Friend WithEvents DateHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SP_ReporteRankingVentaClienteVariedadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GESTDataSet42 As GestionVivero.GESTDataSet42
    Friend WithEvents SP_ReporteRankingVentaClienteVariedadTableAdapter As GestionVivero.GESTDataSet42TableAdapters.SP_ReporteRankingVentaClienteVariedadTableAdapter
End Class
