<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RankingVenta
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
        Me.DateHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSemilla = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GESTDataSet41 = New GestionVivero.GESTDataSet41()
        Me.SP_ReporteRankingVentaClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_ReporteRankingVentaClienteTableAdapter = New GestionVivero.GESTDataSet41TableAdapters.SP_ReporteRankingVentaClienteTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.GESTDataSet41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_ReporteRankingVentaClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateHasta
        '
        Me.DateHasta.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateHasta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateHasta.Location = New System.Drawing.Point(329, 12)
        Me.DateHasta.Name = "DateHasta"
        Me.DateHasta.Size = New System.Drawing.Size(98, 21)
        Me.DateHasta.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(285, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Hasta:"
        '
        'DateDesde
        '
        Me.DateDesde.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDesde.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDesde.Location = New System.Drawing.Point(163, 12)
        Me.DateDesde.Name = "DateDesde"
        Me.DateDesde.Size = New System.Drawing.Size(92, 21)
        Me.DateDesde.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Desde:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(443, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Semilla"
        '
        'cmbSemilla
        '
        Me.cmbSemilla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSemilla.FormattingEnabled = True
        Me.cmbSemilla.Location = New System.Drawing.Point(489, 12)
        Me.cmbSemilla.Name = "cmbSemilla"
        Me.cmbSemilla.Size = New System.Drawing.Size(219, 21)
        Me.cmbSemilla.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button1.Location = New System.Drawing.Point(728, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 31)
        Me.Button1.TabIndex = 23
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SP_ReporteRankingVentaClienteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.ReporteRankingVentaCliente.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 48)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(786, 586)
        Me.ReportViewer1.TabIndex = 24
        '
        'GESTDataSet41
        '
        Me.GESTDataSet41.DataSetName = "GESTDataSet41"
        Me.GESTDataSet41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_ReporteRankingVentaClienteBindingSource
        '
        Me.SP_ReporteRankingVentaClienteBindingSource.DataMember = "SP_ReporteRankingVentaCliente"
        Me.SP_ReporteRankingVentaClienteBindingSource.DataSource = Me.GESTDataSet41
        '
        'SP_ReporteRankingVentaClienteTableAdapter
        '
        Me.SP_ReporteRankingVentaClienteTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 23)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Nueva Consulta"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RankingVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 636)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbSemilla)
        Me.Controls.Add(Me.DateHasta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateDesde)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "RankingVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ranking de Venta por Cliente"
        CType(Me.GESTDataSet41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_ReporteRankingVentaClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbSemilla As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SP_ReporteRankingVentaClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GESTDataSet41 As GestionVivero.GESTDataSet41
    Friend WithEvents SP_ReporteRankingVentaClienteTableAdapter As GestionVivero.GESTDataSet41TableAdapters.SP_ReporteRankingVentaClienteTableAdapter
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
