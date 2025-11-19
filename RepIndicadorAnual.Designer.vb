<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RepIndicadorAnual
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtComision = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmbPeriodo = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GESTDataSet19 = New GestionVivero.GESTDataSet19()
        Me.SP_ReporteIndicadorPlantasRetiradas_AgnoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_ReporteIndicadorPlantasRetiradas_AgnoTableAdapter = New GestionVivero.GESTDataSet19TableAdapters.SP_ReporteIndicadorPlantasRetiradas_AgnoTableAdapter()
        CType(Me.GESTDataSet19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_ReporteIndicadorPlantasRetiradas_AgnoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(308, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Período"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(633, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "% Comisión:"
        '
        'txtComision
        '
        Me.txtComision.Location = New System.Drawing.Point(703, 13)
        Me.txtComision.Name = "txtComision"
        Me.txtComision.Size = New System.Drawing.Size(55, 20)
        Me.txtComision.TabIndex = 42
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.SP_ReporteIndicadorPlantasRetiradas_AgnoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.RepIndicadoresSiembraAnual.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(2, 48)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1058, 535)
        Me.ReportViewer1.TabIndex = 43
        '
        'cmbPeriodo
        '
        Me.cmbPeriodo.FormattingEnabled = True
        Me.cmbPeriodo.Location = New System.Drawing.Point(367, 13)
        Me.cmbPeriodo.Name = "cmbPeriodo"
        Me.cmbPeriodo.Size = New System.Drawing.Size(121, 21)
        Me.cmbPeriodo.TabIndex = 45
        '
        'Button1
        '
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button1.Location = New System.Drawing.Point(848, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 31)
        Me.Button1.TabIndex = 46
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GESTDataSet19
        '
        Me.GESTDataSet19.DataSetName = "GESTDataSet19"
        Me.GESTDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_ReporteIndicadorPlantasRetiradas_AgnoBindingSource
        '
        Me.SP_ReporteIndicadorPlantasRetiradas_AgnoBindingSource.DataMember = "SP_ReporteIndicadorPlantasRetiradas_Agno"
        Me.SP_ReporteIndicadorPlantasRetiradas_AgnoBindingSource.DataSource = Me.GESTDataSet19
        '
        'SP_ReporteIndicadorPlantasRetiradas_AgnoTableAdapter
        '
        Me.SP_ReporteIndicadorPlantasRetiradas_AgnoTableAdapter.ClearBeforeFill = True
        '
        'RepIndicadorAnual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 582)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbPeriodo)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.txtComision)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RepIndicadorAnual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Indicadores Anuales por Especie"
        CType(Me.GESTDataSet19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_ReporteIndicadorPlantasRetiradas_AgnoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtComision As TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cmbPeriodo As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents SP_ReporteIndicadorPlantasRetiradas_AgnoBindingSource As BindingSource
    Friend WithEvents GESTDataSet19 As GESTDataSet19
    Friend WithEvents SP_ReporteIndicadorPlantasRetiradas_AgnoTableAdapter As GESTDataSet19TableAdapters.SP_ReporteIndicadorPlantasRetiradas_AgnoTableAdapter
End Class
