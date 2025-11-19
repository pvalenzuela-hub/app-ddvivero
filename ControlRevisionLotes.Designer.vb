<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlRevisionLotes
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cmb_CTL_Entrega = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_CTL_Cliente = New System.Windows.Forms.ComboBox()
        Me.cmb_CTL_Enfermedades = New System.Windows.Forms.ComboBox()
        Me.cmb_CTL_Observaciones = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSetReporteInventario = New GestionVivero.DataSetReporteInventario()
        Me.SP_Reporte_CTL_LoteCheckBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Reporte_CTL_LoteCheckTableAdapter = New GestionVivero.DataSetReporteInventarioTableAdapters.SP_Reporte_CTL_LoteCheckTableAdapter()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataSetReporteInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Reporte_CTL_LoteCheckBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmb_CTL_Observaciones)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmb_CTL_Enfermedades)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmb_CTL_Cliente)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmb_CTL_Entrega)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(975, 458)
        Me.SplitContainer1.SplitterDistance = 73
        Me.SplitContainer1.TabIndex = 0
        '
        'cmb_CTL_Entrega
        '
        Me.cmb_CTL_Entrega.FormattingEnabled = True
        Me.cmb_CTL_Entrega.Location = New System.Drawing.Point(129, 12)
        Me.cmb_CTL_Entrega.Name = "cmb_CTL_Entrega"
        Me.cmb_CTL_Entrega.Size = New System.Drawing.Size(284, 21)
        Me.cmb_CTL_Entrega.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Control Entrega"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Control Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(447, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Control Enfermedades"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(447, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Control Observaciones"
        '
        'cmb_CTL_Cliente
        '
        Me.cmb_CTL_Cliente.FormattingEnabled = True
        Me.cmb_CTL_Cliente.Location = New System.Drawing.Point(129, 42)
        Me.cmb_CTL_Cliente.Name = "cmb_CTL_Cliente"
        Me.cmb_CTL_Cliente.Size = New System.Drawing.Size(284, 21)
        Me.cmb_CTL_Cliente.TabIndex = 9
        '
        'cmb_CTL_Enfermedades
        '
        Me.cmb_CTL_Enfermedades.FormattingEnabled = True
        Me.cmb_CTL_Enfermedades.Location = New System.Drawing.Point(564, 12)
        Me.cmb_CTL_Enfermedades.Name = "cmb_CTL_Enfermedades"
        Me.cmb_CTL_Enfermedades.Size = New System.Drawing.Size(284, 21)
        Me.cmb_CTL_Enfermedades.TabIndex = 10
        '
        'cmb_CTL_Observaciones
        '
        Me.cmb_CTL_Observaciones.FormattingEnabled = True
        Me.cmb_CTL_Observaciones.Location = New System.Drawing.Point(564, 42)
        Me.cmb_CTL_Observaciones.Name = "cmb_CTL_Observaciones"
        Me.cmb_CTL_Observaciones.Size = New System.Drawing.Size(284, 21)
        Me.cmb_CTL_Observaciones.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button1.Location = New System.Drawing.Point(896, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 34)
        Me.Button1.TabIndex = 12
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SP_Reporte_CTL_LoteCheckBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.Report9.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(975, 381)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSetReporteInventario
        '
        Me.DataSetReporteInventario.DataSetName = "DataSetReporteInventario"
        Me.DataSetReporteInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_Reporte_CTL_LoteCheckBindingSource
        '
        Me.SP_Reporte_CTL_LoteCheckBindingSource.DataMember = "SP_Reporte_CTL_LoteCheck"
        Me.SP_Reporte_CTL_LoteCheckBindingSource.DataSource = Me.DataSetReporteInventario
        '
        'SP_Reporte_CTL_LoteCheckTableAdapter
        '
        Me.SP_Reporte_CTL_LoteCheckTableAdapter.ClearBeforeFill = True
        '
        'ControlRevisionLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 458)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ControlRevisionLotes"
        Me.Text = "Lotes Inventario por Control de Revisión"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataSetReporteInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Reporte_CTL_LoteCheckBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmb_CTL_Observaciones As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_CTL_Enfermedades As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_CTL_Cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_CTL_Entrega As System.Windows.Forms.ComboBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SP_Reporte_CTL_LoteCheckBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetReporteInventario As GestionVivero.DataSetReporteInventario
    Friend WithEvents SP_Reporte_CTL_LoteCheckTableAdapter As GestionVivero.DataSetReporteInventarioTableAdapters.SP_Reporte_CTL_LoteCheckTableAdapter
End Class
