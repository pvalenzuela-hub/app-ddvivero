<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta_Conteo
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
        Me.SP_CONSULTA_LOTE_CONTEOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GESTDataSet = New GestionVivero.GESTDataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_todo = New System.Windows.Forms.CheckBox()
        Me.chk_3 = New System.Windows.Forms.CheckBox()
        Me.chk_2 = New System.Windows.Forms.CheckBox()
        Me.chk_1 = New System.Windows.Forms.CheckBox()
        Me.chk_0 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SP_CONSULTA_LOTE_CONTEOTableAdapter = New GestionVivero.GESTDataSetTableAdapters.SP_CONSULTA_LOTE_CONTEOTableAdapter()
        CType(Me.SP_CONSULTA_LOTE_CONTEOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SP_CONSULTA_LOTE_CONTEOBindingSource
        '
        Me.SP_CONSULTA_LOTE_CONTEOBindingSource.DataMember = "SP_CONSULTA_LOTE_CONTEO"
        Me.SP_CONSULTA_LOTE_CONTEOBindingSource.DataSource = Me.GESTDataSet
        '
        'GESTDataSet
        '
        Me.GESTDataSet.DataSetName = "GESTDataSet"
        Me.GESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_todo)
        Me.GroupBox2.Controls.Add(Me.chk_3)
        Me.GroupBox2.Controls.Add(Me.chk_2)
        Me.GroupBox2.Controls.Add(Me.chk_1)
        Me.GroupBox2.Controls.Add(Me.chk_0)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(585, 52)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estados Lote"
        '
        'chk_todo
        '
        Me.chk_todo.AutoSize = True
        Me.chk_todo.Location = New System.Drawing.Point(481, 25)
        Me.chk_todo.Name = "chk_todo"
        Me.chk_todo.Size = New System.Drawing.Size(67, 21)
        Me.chk_todo.TabIndex = 13
        Me.chk_todo.Text = "Todos"
        Me.chk_todo.UseVisualStyleBackColor = True
        '
        'chk_3
        '
        Me.chk_3.AutoSize = True
        Me.chk_3.Location = New System.Drawing.Point(352, 25)
        Me.chk_3.Name = "chk_3"
        Me.chk_3.Size = New System.Drawing.Size(123, 21)
        Me.chk_3.TabIndex = 12
        Me.chk_3.Text = "Aviso al Cliente"
        Me.chk_3.UseVisualStyleBackColor = True
        '
        'chk_2
        '
        Me.chk_2.AutoSize = True
        Me.chk_2.Location = New System.Drawing.Point(203, 25)
        Me.chk_2.Name = "chk_2"
        Me.chk_2.Size = New System.Drawing.Size(143, 21)
        Me.chk_2.TabIndex = 11
        Me.chk_2.Text = "Conteo de Plantas"
        Me.chk_2.UseVisualStyleBackColor = True
        '
        'chk_1
        '
        Me.chk_1.AutoSize = True
        Me.chk_1.Location = New System.Drawing.Point(118, 25)
        Me.chk_1.Name = "chk_1"
        Me.chk_1.Size = New System.Drawing.Size(79, 21)
        Me.chk_1.TabIndex = 10
        Me.chk_1.Text = "Siembra"
        Me.chk_1.UseVisualStyleBackColor = True
        '
        'chk_0
        '
        Me.chk_0.AutoSize = True
        Me.chk_0.Location = New System.Drawing.Point(41, 25)
        Me.chk_0.Name = "chk_0"
        Me.chk_0.Size = New System.Drawing.Size(71, 21)
        Me.chk_0.TabIndex = 9
        Me.chk_0.Text = "Pedido"
        Me.chk_0.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button1.Location = New System.Drawing.Point(1037, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 52)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.Close
        Me.Button2.Location = New System.Drawing.Point(1089, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(52, 52)
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SP_CONSULTA_LOTE_CONTEOBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionVivero.ReporteConteoLotes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1141, 545)
        Me.ReportViewer1.TabIndex = 6
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1141, 601)
        Me.SplitContainer1.SplitterDistance = 52
        Me.SplitContainer1.TabIndex = 8
        '
        'SP_CONSULTA_LOTE_CONTEOTableAdapter
        '
        Me.SP_CONSULTA_LOTE_CONTEOTableAdapter.ClearBeforeFill = True
        '
        'Consulta_Conteo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1141, 601)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Consulta_Conteo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Conteo"
        CType(Me.SP_CONSULTA_LOTE_CONTEOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents chk_todo As CheckBox
    Friend WithEvents chk_3 As CheckBox
    Friend WithEvents chk_2 As CheckBox
    Friend WithEvents chk_1 As CheckBox
    Friend WithEvents chk_0 As CheckBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SP_CONSULTA_LOTE_CONTEOBindingSource As BindingSource
    Friend WithEvents GESTDataSet As GESTDataSet
    Friend WithEvents SP_CONSULTA_LOTE_CONTEOTableAdapter As GESTDataSetTableAdapters.SP_CONSULTA_LOTE_CONTEOTableAdapter
End Class
