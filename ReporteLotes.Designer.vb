<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteLotes
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
        Me.SP_CONSULTA_LOTE_RESUMENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetReporteInventario = New GestionVivero.DataSetReporteInventario()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_Cliente = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.cmb_variedad = New System.Windows.Forms.ComboBox()
        Me.cmb_familia = New System.Windows.Forms.ComboBox()
        Me.rdb_Semilla = New System.Windows.Forms.RadioButton()
        Me.rdb_Variedad = New System.Windows.Forms.RadioButton()
        Me.Rdb_Cliente = New System.Windows.Forms.RadioButton()
        Me.rdb_Todo = New System.Windows.Forms.RadioButton()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SP_CONSULTA_LOTE_RESUMENTableAdapter = New GestionVivero.DataSetReporteInventarioTableAdapters.SP_CONSULTA_LOTE_RESUMENTableAdapter()
        Me.chk_name = New System.Windows.Forms.CheckBox()
        CType(Me.SP_CONSULTA_LOTE_RESUMENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetReporteInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SP_CONSULTA_LOTE_RESUMENBindingSource
        '
        Me.SP_CONSULTA_LOTE_RESUMENBindingSource.DataMember = "SP_CONSULTA_LOTE_RESUMEN"
        Me.SP_CONSULTA_LOTE_RESUMENBindingSource.DataSource = Me.DataSetReporteInventario
        '
        'DataSetReporteInventario
        '
        Me.DataSetReporteInventario.DataSetName = "DataSetReporteInventario"
        Me.DataSetReporteInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.chk_name)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Cliente)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_nombre)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmb_variedad)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmb_familia)
        Me.SplitContainer1.Panel1.Controls.Add(Me.rdb_Semilla)
        Me.SplitContainer1.Panel1.Controls.Add(Me.rdb_Variedad)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Rdb_Cliente)
        Me.SplitContainer1.Panel1.Controls.Add(Me.rdb_Todo)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1100, 733)
        Me.SplitContainer1.SplitterDistance = 135
        Me.SplitContainer1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(673, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(493, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Desde"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(711, 65)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(103, 20)
        Me.DateTimePicker2.TabIndex = 13
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(537, 65)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(103, 20)
        Me.DateTimePicker1.TabIndex = 12
        '
        'Button2
        '
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button2.Location = New System.Drawing.Point(842, 60)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(36, 34)
        Me.Button2.TabIndex = 9
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txt_Cliente
        '
        Me.txt_Cliente.Location = New System.Drawing.Point(400, 10)
        Me.txt_Cliente.Name = "txt_Cliente"
        Me.txt_Cliente.ReadOnly = True
        Me.txt_Cliente.Size = New System.Drawing.Size(477, 20)
        Me.txt_Cliente.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(364, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 21)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(150, 10)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(212, 20)
        Me.txt_nombre.TabIndex = 6
        '
        'cmb_variedad
        '
        Me.cmb_variedad.FormattingEnabled = True
        Me.cmb_variedad.Location = New System.Drawing.Point(150, 78)
        Me.cmb_variedad.Name = "cmb_variedad"
        Me.cmb_variedad.Size = New System.Drawing.Size(212, 21)
        Me.cmb_variedad.TabIndex = 5
        '
        'cmb_familia
        '
        Me.cmb_familia.FormattingEnabled = True
        Me.cmb_familia.Location = New System.Drawing.Point(150, 44)
        Me.cmb_familia.Name = "cmb_familia"
        Me.cmb_familia.Size = New System.Drawing.Size(212, 21)
        Me.cmb_familia.TabIndex = 4
        '
        'rdb_Semilla
        '
        Me.rdb_Semilla.AutoSize = True
        Me.rdb_Semilla.Location = New System.Drawing.Point(40, 46)
        Me.rdb_Semilla.Name = "rdb_Semilla"
        Me.rdb_Semilla.Size = New System.Drawing.Size(63, 17)
        Me.rdb_Semilla.TabIndex = 3
        Me.rdb_Semilla.Text = "Especie"
        Me.rdb_Semilla.UseVisualStyleBackColor = True
        '
        'rdb_Variedad
        '
        Me.rdb_Variedad.AutoSize = True
        Me.rdb_Variedad.Location = New System.Drawing.Point(40, 80)
        Me.rdb_Variedad.Name = "rdb_Variedad"
        Me.rdb_Variedad.Size = New System.Drawing.Size(67, 17)
        Me.rdb_Variedad.TabIndex = 2
        Me.rdb_Variedad.Text = "Variedad"
        Me.rdb_Variedad.UseVisualStyleBackColor = True
        '
        'Rdb_Cliente
        '
        Me.Rdb_Cliente.AutoSize = True
        Me.Rdb_Cliente.Checked = True
        Me.Rdb_Cliente.Location = New System.Drawing.Point(40, 12)
        Me.Rdb_Cliente.Name = "Rdb_Cliente"
        Me.Rdb_Cliente.Size = New System.Drawing.Size(57, 17)
        Me.Rdb_Cliente.TabIndex = 1
        Me.Rdb_Cliente.TabStop = True
        Me.Rdb_Cliente.Text = "Cliente"
        Me.Rdb_Cliente.UseVisualStyleBackColor = True
        '
        'rdb_Todo
        '
        Me.rdb_Todo.AutoSize = True
        Me.rdb_Todo.Location = New System.Drawing.Point(40, 114)
        Me.rdb_Todo.Name = "rdb_Todo"
        Me.rdb_Todo.Size = New System.Drawing.Size(100, 17)
        Me.rdb_Todo.TabIndex = 0
        Me.rdb_Todo.Text = "Todos los Lotes"
        Me.rdb_Todo.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.SP_CONSULTA_LOTE_RESUMENBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.Report7.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1100, 594)
        Me.ReportViewer1.TabIndex = 1
        '
        'SP_CONSULTA_LOTE_RESUMENTableAdapter
        '
        Me.SP_CONSULTA_LOTE_RESUMENTableAdapter.ClearBeforeFill = True
        '
        'chk_name
        '
        Me.chk_name.AutoSize = True
        Me.chk_name.Location = New System.Drawing.Point(132, 13)
        Me.chk_name.Name = "chk_name"
        Me.chk_name.Size = New System.Drawing.Size(15, 14)
        Me.chk_name.TabIndex = 16
        Me.chk_name.UseVisualStyleBackColor = True
        '
        'ReporteLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 733)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ReporteLotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Lotes Histórico"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SP_CONSULTA_LOTE_RESUMENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetReporteInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents rdb_Todo As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb_Cliente As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Semilla As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Variedad As System.Windows.Forms.RadioButton
    Friend WithEvents cmb_familia As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_variedad As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Cliente As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SP_CONSULTA_LOTE_RESUMENBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetReporteInventario As GestionVivero.DataSetReporteInventario
    Friend WithEvents SP_CONSULTA_LOTE_RESUMENTableAdapter As GestionVivero.DataSetReporteInventarioTableAdapters.SP_CONSULTA_LOTE_RESUMENTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents chk_name As CheckBox
End Class
