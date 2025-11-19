<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ranking
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateDesde = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateHasta = New System.Windows.Forms.DateTimePicker
        Me.Button2 = New System.Windows.Forms.Button
        Me.rdb_cliente = New System.Windows.Forms.RadioButton
        Me.rdb_Variedad = New System.Windows.Forms.RadioButton
        Me.rdb_Monto = New System.Windows.Forms.RadioButton
        Me.rdb_Cantidad = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataConsulta = New System.Windows.Forms.DataGridView
        Me.emision = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.doc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txt_TotMonto = New System.Windows.Forms.TextBox
        Me.txt_TotCant = New System.Windows.Forms.TextBox
        Me.rdb_semilla = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(228, 453)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desde:"
        '
        'DateDesde
        '
        Me.DateDesde.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDesde.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDesde.Location = New System.Drawing.Point(71, 34)
        Me.DateDesde.Name = "DateDesde"
        Me.DateDesde.Size = New System.Drawing.Size(92, 21)
        Me.DateDesde.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(193, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hasta:"
        '
        'DateHasta
        '
        Me.DateHasta.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateHasta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateHasta.Location = New System.Drawing.Point(237, 34)
        Me.DateHasta.Name = "DateHasta"
        Me.DateHasta.Size = New System.Drawing.Size(98, 21)
        Me.DateHasta.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(228, 122)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Consultar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'rdb_cliente
        '
        Me.rdb_cliente.AutoSize = True
        Me.rdb_cliente.Checked = True
        Me.rdb_cliente.Location = New System.Drawing.Point(27, 82)
        Me.rdb_cliente.Name = "rdb_cliente"
        Me.rdb_cliente.Size = New System.Drawing.Size(100, 17)
        Me.rdb_cliente.TabIndex = 7
        Me.rdb_cliente.TabStop = True
        Me.rdb_cliente.Text = "Ranking Cliente"
        Me.rdb_cliente.UseVisualStyleBackColor = True
        '
        'rdb_Variedad
        '
        Me.rdb_Variedad.AutoSize = True
        Me.rdb_Variedad.Location = New System.Drawing.Point(151, 82)
        Me.rdb_Variedad.Name = "rdb_Variedad"
        Me.rdb_Variedad.Size = New System.Drawing.Size(110, 17)
        Me.rdb_Variedad.TabIndex = 8
        Me.rdb_Variedad.Text = "Ranking Variedad"
        Me.rdb_Variedad.UseVisualStyleBackColor = True
        '
        'rdb_Monto
        '
        Me.rdb_Monto.AutoSize = True
        Me.rdb_Monto.Checked = True
        Me.rdb_Monto.Location = New System.Drawing.Point(37, 19)
        Me.rdb_Monto.Name = "rdb_Monto"
        Me.rdb_Monto.Size = New System.Drawing.Size(74, 17)
        Me.rdb_Monto.TabIndex = 9
        Me.rdb_Monto.TabStop = True
        Me.rdb_Monto.Text = "Por Monto"
        Me.rdb_Monto.UseVisualStyleBackColor = True
        '
        'rdb_Cantidad
        '
        Me.rdb_Cantidad.AutoSize = True
        Me.rdb_Cantidad.Location = New System.Drawing.Point(37, 42)
        Me.rdb_Cantidad.Name = "rdb_Cantidad"
        Me.rdb_Cantidad.Size = New System.Drawing.Size(86, 17)
        Me.rdb_Cantidad.TabIndex = 10
        Me.rdb_Cantidad.Text = "Por Cantidad"
        Me.rdb_Cantidad.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdb_Monto)
        Me.GroupBox1.Controls.Add(Me.rdb_Cantidad)
        Me.GroupBox1.Location = New System.Drawing.Point(419, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 64)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ordenado"
        '
        'DataConsulta
        '
        Me.DataConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataConsulta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataConsulta.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataConsulta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.emision, Me.tipo, Me.doc})
        Me.DataConsulta.Location = New System.Drawing.Point(12, 160)
        Me.DataConsulta.Name = "DataConsulta"
        Me.DataConsulta.ReadOnly = True
        Me.DataConsulta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataConsulta.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataConsulta.Size = New System.Drawing.Size(585, 278)
        Me.DataConsulta.TabIndex = 12
        '
        'emision
        '
        Me.emision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.emision.HeaderText = "Descripción"
        Me.emision.Name = "emision"
        Me.emision.ReadOnly = True
        '
        'tipo
        '
        Me.tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.tipo.DefaultCellStyle = DataGridViewCellStyle1
        Me.tipo.HeaderText = "Monto"
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        Me.tipo.Width = 62
        '
        'doc
        '
        Me.doc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.doc.DefaultCellStyle = DataGridViewCellStyle2
        Me.doc.HeaderText = "Cantidad"
        Me.doc.Name = "doc"
        Me.doc.ReadOnly = True
        Me.doc.Width = 74
        '
        'txt_TotMonto
        '
        Me.txt_TotMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotMonto.Location = New System.Drawing.Point(418, 456)
        Me.txt_TotMonto.Name = "txt_TotMonto"
        Me.txt_TotMonto.ReadOnly = True
        Me.txt_TotMonto.Size = New System.Drawing.Size(83, 21)
        Me.txt_TotMonto.TabIndex = 13
        Me.txt_TotMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_TotCant
        '
        Me.txt_TotCant.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotCant.Location = New System.Drawing.Point(514, 456)
        Me.txt_TotCant.Name = "txt_TotCant"
        Me.txt_TotCant.ReadOnly = True
        Me.txt_TotCant.Size = New System.Drawing.Size(83, 21)
        Me.txt_TotCant.TabIndex = 14
        Me.txt_TotCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rdb_semilla
        '
        Me.rdb_semilla.AutoSize = True
        Me.rdb_semilla.Location = New System.Drawing.Point(281, 82)
        Me.rdb_semilla.Name = "rdb_semilla"
        Me.rdb_semilla.Size = New System.Drawing.Size(101, 17)
        Me.rdb_semilla.TabIndex = 15
        Me.rdb_semilla.Text = "Ranking Semilla"
        Me.rdb_semilla.UseVisualStyleBackColor = True
        '
        'Ranking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 488)
        Me.ControlBox = False
        Me.Controls.Add(Me.rdb_semilla)
        Me.Controls.Add(Me.txt_TotCant)
        Me.Controls.Add(Me.txt_TotMonto)
        Me.Controls.Add(Me.DataConsulta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.rdb_Variedad)
        Me.Controls.Add(Me.rdb_cliente)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DateHasta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateDesde)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Ranking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ranking de Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents rdb_cliente As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Variedad As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Monto As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Cantidad As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataConsulta As System.Windows.Forms.DataGridView
    Friend WithEvents emision As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_TotMonto As System.Windows.Forms.TextBox
    Friend WithEvents txt_TotCant As System.Windows.Forms.TextBox
    Friend WithEvents rdb_semilla As System.Windows.Forms.RadioButton
End Class
