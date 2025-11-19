<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Libro_Ventas
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rb5 = New System.Windows.Forms.RadioButton()
        Me.rb4 = New System.Windows.Forms.RadioButton()
        Me.rb3 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_Fecha2 = New System.Windows.Forms.DateTimePicker()
        Me.txt_Fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_TOTALFINAL = New System.Windows.Forms.TextBox()
        Me.txt_IVA = New System.Windows.Forms.TextBox()
        Me.txt_TOTALNETO = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGrilla = New System.Windows.Forms.DataGridView()
        Me.TIPODOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numdoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecvta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.neto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rb6 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txt_Fecha2)
        Me.GroupBox1.Controls.Add(Me.txt_Fecha1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(846, 180)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selección de Fechas"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rb6)
        Me.GroupBox3.Controls.Add(Me.rb5)
        Me.GroupBox3.Controls.Add(Me.rb4)
        Me.GroupBox3.Controls.Add(Me.rb3)
        Me.GroupBox3.Controls.Add(Me.rb2)
        Me.GroupBox3.Controls.Add(Me.rb1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(206, 154)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filtro"
        '
        'rb5
        '
        Me.rb5.AutoSize = True
        Me.rb5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb5.ForeColor = System.Drawing.Color.Navy
        Me.rb5.Location = New System.Drawing.Point(23, 129)
        Me.rb5.Name = "rb5"
        Me.rb5.Size = New System.Drawing.Size(58, 19)
        Me.rb5.TabIndex = 4
        Me.rb5.Text = "Nulos"
        Me.rb5.UseVisualStyleBackColor = True
        '
        'rb4
        '
        Me.rb4.AutoSize = True
        Me.rb4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb4.ForeColor = System.Drawing.Color.Navy
        Me.rb4.Location = New System.Drawing.Point(23, 107)
        Me.rb4.Name = "rb4"
        Me.rb4.Size = New System.Drawing.Size(118, 19)
        Me.rb4.TabIndex = 3
        Me.rb4.Text = "Notas de Credito"
        Me.rb4.UseVisualStyleBackColor = True
        '
        'rb3
        '
        Me.rb3.AutoSize = True
        Me.rb3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb3.ForeColor = System.Drawing.Color.Navy
        Me.rb3.Location = New System.Drawing.Point(23, 84)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(114, 19)
        Me.rb3.TabIndex = 2
        Me.rb3.Text = "Boletas Exentas"
        Me.rb3.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb2.ForeColor = System.Drawing.Color.Navy
        Me.rb2.Location = New System.Drawing.Point(23, 61)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(124, 19)
        Me.rb2.TabIndex = 1
        Me.rb2.Text = "Boletas Manuales"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Checked = True
        Me.rb1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb1.ForeColor = System.Drawing.Color.Navy
        Me.rb1.Location = New System.Drawing.Point(23, 19)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(73, 19)
        Me.rb1.TabIndex = 0
        Me.rb1.TabStop = True
        Me.rb1.Text = "Facturas"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(450, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 27)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Ejecutar Consulta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_Fecha2
        '
        Me.txt_Fecha2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Fecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_Fecha2.Location = New System.Drawing.Point(501, 20)
        Me.txt_Fecha2.Name = "txt_Fecha2"
        Me.txt_Fecha2.Size = New System.Drawing.Size(114, 25)
        Me.txt_Fecha2.TabIndex = 4
        '
        'txt_Fecha1
        '
        Me.txt_Fecha1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Fecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_Fecha1.Location = New System.Drawing.Point(352, 19)
        Me.txt_Fecha1.Name = "txt_Fecha1"
        Me.txt_Fecha1.Size = New System.Drawing.Size(115, 25)
        Me.txt_Fecha1.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_TOTALFINAL)
        Me.GroupBox4.Controls.Add(Me.txt_IVA)
        Me.GroupBox4.Controls.Add(Me.txt_TOTALNETO)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(197, 523)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(502, 70)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Resumen de Venta"
        '
        'txt_TOTALFINAL
        '
        Me.txt_TOTALFINAL.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_TOTALFINAL.CausesValidation = False
        Me.txt_TOTALFINAL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TOTALFINAL.ForeColor = System.Drawing.Color.Yellow
        Me.txt_TOTALFINAL.Location = New System.Drawing.Point(374, 32)
        Me.txt_TOTALFINAL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_TOTALFINAL.Name = "txt_TOTALFINAL"
        Me.txt_TOTALFINAL.ReadOnly = True
        Me.txt_TOTALFINAL.Size = New System.Drawing.Size(79, 22)
        Me.txt_TOTALFINAL.TabIndex = 11
        Me.txt_TOTALFINAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_IVA
        '
        Me.txt_IVA.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_IVA.CausesValidation = False
        Me.txt_IVA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IVA.ForeColor = System.Drawing.Color.Yellow
        Me.txt_IVA.Location = New System.Drawing.Point(203, 32)
        Me.txt_IVA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_IVA.Name = "txt_IVA"
        Me.txt_IVA.ReadOnly = True
        Me.txt_IVA.Size = New System.Drawing.Size(79, 22)
        Me.txt_IVA.TabIndex = 10
        Me.txt_IVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_TOTALNETO
        '
        Me.txt_TOTALNETO.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_TOTALNETO.CausesValidation = False
        Me.txt_TOTALNETO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TOTALNETO.ForeColor = System.Drawing.Color.Yellow
        Me.txt_TOTALNETO.Location = New System.Drawing.Point(23, 32)
        Me.txt_TOTALNETO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_TOTALNETO.Name = "txt_TOTALNETO"
        Me.txt_TOTALNETO.ReadOnly = True
        Me.txt_TOTALNETO.Size = New System.Drawing.Size(79, 22)
        Me.txt_TOTALNETO.TabIndex = 9
        Me.txt_TOTALNETO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(398, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "TOTAL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(221, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "IVA :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "NETO"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(361, 600)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 27)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGrilla
        '
        Me.DataGrilla.AllowUserToAddRows = False
        Me.DataGrilla.AllowUserToDeleteRows = False
        Me.DataGrilla.AllowUserToOrderColumns = True
        Me.DataGrilla.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGrilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGrilla.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TIPODOC, Me.numdoc, Me.Fecvta, Me.rut, Me.cliente, Me.neto, Me.iva, Me.total})
        Me.DataGrilla.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataGrilla.GridColor = System.Drawing.Color.White
        Me.DataGrilla.Location = New System.Drawing.Point(1, 187)
        Me.DataGrilla.Name = "DataGrilla"
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrilla.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataGrilla.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrilla.Size = New System.Drawing.Size(869, 329)
        Me.DataGrilla.StandardTab = True
        Me.DataGrilla.TabIndex = 2
        '
        'TIPODOC
        '
        Me.TIPODOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TIPODOC.HeaderText = "Tipo Doc."
        Me.TIPODOC.Name = "TIPODOC"
        Me.TIPODOC.Width = 79
        '
        'numdoc
        '
        Me.numdoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.numdoc.HeaderText = "N° Doc"
        Me.numdoc.Name = "numdoc"
        Me.numdoc.Width = 67
        '
        'Fecvta
        '
        Me.Fecvta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Fecvta.HeaderText = "Fecha Venta"
        Me.Fecvta.Name = "Fecvta"
        Me.Fecvta.Width = 93
        '
        'rut
        '
        Me.rut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.rut.HeaderText = "R.U.T."
        Me.rut.Name = "rut"
        Me.rut.Width = 64
        '
        'cliente
        '
        Me.cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.Name = "cliente"
        Me.cliente.Width = 64
        '
        'neto
        '
        Me.neto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.neto.DefaultCellStyle = DataGridViewCellStyle6
        Me.neto.HeaderText = "Neto"
        Me.neto.Name = "neto"
        Me.neto.Width = 55
        '
        'iva
        '
        Me.iva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.iva.DefaultCellStyle = DataGridViewCellStyle7
        Me.iva.HeaderText = "I.V.A."
        Me.iva.Name = "iva"
        Me.iva.Width = 58
        '
        'total
        '
        Me.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.total.DefaultCellStyle = DataGridViewCellStyle8
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.Width = 56
        '
        'rb6
        '
        Me.rb6.AutoSize = True
        Me.rb6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb6.ForeColor = System.Drawing.Color.Navy
        Me.rb6.Location = New System.Drawing.Point(23, 40)
        Me.rb6.Name = "rb6"
        Me.rb6.Size = New System.Drawing.Size(138, 19)
        Me.rb6.TabIndex = 5
        Me.rb6.Text = "Boletas Electrónicas"
        Me.rb6.UseVisualStyleBackColor = True
        '
        'Libro_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 632)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGrilla)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Libro_Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Libro de Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rb4 As System.Windows.Forms.RadioButton
    Friend WithEvents rb3 As System.Windows.Forms.RadioButton
    Friend WithEvents rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_Fecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_Fecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents rb5 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_TOTALFINAL As System.Windows.Forms.TextBox
    Friend WithEvents txt_IVA As System.Windows.Forms.TextBox
    Friend WithEvents txt_TOTALNETO As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Public WithEvents DataGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents TIPODOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numdoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecvta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents neto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents iva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rb6 As RadioButton
End Class
