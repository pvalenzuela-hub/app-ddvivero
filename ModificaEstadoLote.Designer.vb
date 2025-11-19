<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificaEstadoLote
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEstadoActual = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmb_Estados = New System.Windows.Forms.ComboBox()
        Me.GESTDataSet = New GestionVivero.GESTDataSet()
        Me.TEstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TEstadoTableAdapter = New GestionVivero.GESTDataSetTableAdapters.tEstadoTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GESTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(171, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Nuevo Estado"
        '
        'txtEstadoActual
        '
        Me.txtEstadoActual.Location = New System.Drawing.Point(290, 68)
        Me.txtEstadoActual.Name = "txtEstadoActual"
        Me.txtEstadoActual.ReadOnly = True
        Me.txtEstadoActual.Size = New System.Drawing.Size(212, 20)
        Me.txtEstadoActual.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(167, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Estado Actual"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtLote)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(144, 50)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "N° Lote"
        '
        'txtLote
        '
        Me.txtLote.Location = New System.Drawing.Point(12, 18)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.ReadOnly = True
        Me.txtLote.Size = New System.Drawing.Size(115, 26)
        Me.txtLote.TabIndex = 10
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.GestionVivero.My.Resources.Resources.salir_40x40
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Location = New System.Drawing.Point(666, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 48)
        Me.Button2.TabIndex = 24
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.GestionVivero.My.Resources.Resources.guardar_40x40
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Location = New System.Drawing.Point(345, 253)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 48)
        Me.Button1.TabIndex = 23
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmb_Estados
        '
        Me.cmb_Estados.DataSource = Me.TEstadoBindingSource
        Me.cmb_Estados.DisplayMember = "nombre"
        Me.cmb_Estados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Estados.FormattingEnabled = True
        Me.cmb_Estados.Location = New System.Drawing.Point(290, 115)
        Me.cmb_Estados.Name = "cmb_Estados"
        Me.cmb_Estados.Size = New System.Drawing.Size(212, 21)
        Me.cmb_Estados.TabIndex = 32
        Me.cmb_Estados.ValueMember = "codigo"
        '
        'GESTDataSet
        '
        Me.GESTDataSet.DataSetName = "GESTDataSet"
        Me.GESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TEstadoBindingSource
        '
        Me.TEstadoBindingSource.DataMember = "tEstado"
        Me.TEstadoBindingSource.DataSource = Me.GESTDataSet
        '
        'TEstadoTableAdapter
        '
        Me.TEstadoTableAdapter.ClearBeforeFill = True
        '
        'ModificaEstadoLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(715, 325)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmb_Estados)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEstadoActual)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "ModificaEstadoLote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modifica Estado Lote"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GESTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txtEstadoActual As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtLote As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cmb_Estados As ComboBox
    Friend WithEvents GESTDataSet As GESTDataSet
    Friend WithEvents TEstadoBindingSource As BindingSource
    Friend WithEvents TEstadoTableAdapter As GESTDataSetTableAdapters.tEstadoTableAdapter
End Class
