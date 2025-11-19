<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta_Boleta_Pendiente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rb4 = New System.Windows.Forms.RadioButton()
        Me.rb3 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_Fecha2 = New System.Windows.Forms.DateTimePicker()
        Me.txt_Fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGrilla = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarVentanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_Saldo = New System.Windows.Forms.TextBox()
        Me.txt_Descto = New System.Windows.Forms.TextBox()
        Me.txt_Venta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Pagado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TIPODOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numdoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecvta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pendiente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txt_Fecha2)
        Me.GroupBox1.Controls.Add(Me.txt_Fecha1)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(989, 133)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selección de Fechas"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rb4)
        Me.GroupBox3.Controls.Add(Me.rb3)
        Me.GroupBox3.Controls.Add(Me.rb2)
        Me.GroupBox3.Controls.Add(Me.rb1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(206, 107)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filtro"
        '
        'rb4
        '
        Me.rb4.AutoSize = True
        Me.rb4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb4.ForeColor = System.Drawing.Color.Navy
        Me.rb4.Location = New System.Drawing.Point(23, 88)
        Me.rb4.Name = "rb4"
        Me.rb4.Size = New System.Drawing.Size(132, 19)
        Me.rb4.TabIndex = 3
        Me.rb4.Text = "Documentos Nulos"
        Me.rb4.UseVisualStyleBackColor = True
        '
        'rb3
        '
        Me.rb3.AutoSize = True
        Me.rb3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb3.ForeColor = System.Drawing.Color.Navy
        Me.rb3.Location = New System.Drawing.Point(23, 63)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(162, 19)
        Me.rb3.TabIndex = 2
        Me.rb3.Text = "Documentos Pendientes"
        Me.rb3.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb2.ForeColor = System.Drawing.Color.Navy
        Me.rb2.Location = New System.Drawing.Point(23, 40)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(149, 19)
        Me.rb2.TabIndex = 1
        Me.rb2.Text = "Documentos Pagados"
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
        Me.rb1.Size = New System.Drawing.Size(153, 19)
        Me.rb1.TabIndex = 0
        Me.rb1.TabStop = True
        Me.rb1.Text = "Todos los Documentos"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(514, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 27)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Ejecutar Consulta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_Fecha2
        '
        Me.txt_Fecha2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Fecha2.Location = New System.Drawing.Point(617, 19)
        Me.txt_Fecha2.Name = "txt_Fecha2"
        Me.txt_Fecha2.Size = New System.Drawing.Size(302, 25)
        Me.txt_Fecha2.TabIndex = 4
        '
        'txt_Fecha1
        '
        Me.txt_Fecha1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Fecha1.Location = New System.Drawing.Point(259, 19)
        Me.txt_Fecha1.Name = "txt_Fecha1"
        Me.txt_Fecha1.Size = New System.Drawing.Size(302, 25)
        Me.txt_Fecha1.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGrilla)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 171)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(989, 323)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle Documentos Pendientes de Pago"
        '
        'DataGrilla
        '
        Me.DataGrilla.AllowUserToAddRows = False
        Me.DataGrilla.AllowUserToDeleteRows = False
        Me.DataGrilla.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.DataGrilla.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGrilla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGrilla.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGrilla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGrilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TIPODOC, Me.numdoc, Me.Fecvta, Me.cliente, Me.email, Me.telefono, Me.venta, Me.descto, Me.pagado, Me.Pendiente, Me.Column1})
        Me.DataGrilla.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrilla.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGrilla.GridColor = System.Drawing.Color.White
        Me.DataGrilla.Location = New System.Drawing.Point(13, 16)
        Me.DataGrilla.Name = "DataGrilla"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrilla.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataGrilla.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGrilla.Size = New System.Drawing.Size(970, 291)
        Me.DataGrilla.StandardTab = True
        Me.DataGrilla.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1017, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarVentanaToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'CerrarVentanaToolStripMenuItem
        '
        Me.CerrarVentanaToolStripMenuItem.Name = "CerrarVentanaToolStripMenuItem"
        Me.CerrarVentanaToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CerrarVentanaToolStripMenuItem.Text = "Cerrar Ventana"
        '
        'txt_Saldo
        '
        Me.txt_Saldo.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_Saldo.CausesValidation = False
        Me.txt_Saldo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Saldo.ForeColor = System.Drawing.Color.Yellow
        Me.txt_Saldo.Location = New System.Drawing.Point(929, 588)
        Me.txt_Saldo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Saldo.Name = "txt_Saldo"
        Me.txt_Saldo.ReadOnly = True
        Me.txt_Saldo.Size = New System.Drawing.Size(79, 22)
        Me.txt_Saldo.TabIndex = 12
        Me.txt_Saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Descto
        '
        Me.txt_Descto.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_Descto.CausesValidation = False
        Me.txt_Descto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Descto.ForeColor = System.Drawing.Color.Yellow
        Me.txt_Descto.Location = New System.Drawing.Point(929, 531)
        Me.txt_Descto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Descto.Name = "txt_Descto"
        Me.txt_Descto.ReadOnly = True
        Me.txt_Descto.Size = New System.Drawing.Size(79, 22)
        Me.txt_Descto.TabIndex = 13
        Me.txt_Descto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Venta
        '
        Me.txt_Venta.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_Venta.CausesValidation = False
        Me.txt_Venta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Venta.ForeColor = System.Drawing.Color.Yellow
        Me.txt_Venta.Location = New System.Drawing.Point(928, 501)
        Me.txt_Venta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Venta.Name = "txt_Venta"
        Me.txt_Venta.ReadOnly = True
        Me.txt_Venta.Size = New System.Drawing.Size(79, 22)
        Me.txt_Venta.TabIndex = 14
        Me.txt_Venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(832, 506)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Total Venta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(832, 536)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Total Descuentos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(832, 593)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Total Saldo"
        '
        'txt_Pagado
        '
        Me.txt_Pagado.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_Pagado.CausesValidation = False
        Me.txt_Pagado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Pagado.ForeColor = System.Drawing.Color.Yellow
        Me.txt_Pagado.Location = New System.Drawing.Point(929, 560)
        Me.txt_Pagado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Pagado.Name = "txt_Pagado"
        Me.txt_Pagado.ReadOnly = True
        Me.txt_Pagado.Size = New System.Drawing.Size(79, 22)
        Me.txt_Pagado.TabIndex = 18
        Me.txt_Pagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(832, 565)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Total Pagado"
        '
        'TIPODOC
        '
        Me.TIPODOC.HeaderText = "Tipo Doc."
        Me.TIPODOC.Name = "TIPODOC"
        Me.TIPODOC.Width = 87
        '
        'numdoc
        '
        Me.numdoc.HeaderText = "N° Doc"
        Me.numdoc.Name = "numdoc"
        Me.numdoc.Width = 73
        '
        'Fecvta
        '
        Me.Fecvta.HeaderText = "Fecha Venta"
        Me.Fecvta.Name = "Fecvta"
        Me.Fecvta.Width = 105
        '
        'cliente
        '
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.Name = "cliente"
        Me.cliente.Width = 72
        '
        'email
        '
        Me.email.HeaderText = "eMail"
        Me.email.Name = "email"
        Me.email.Width = 63
        '
        'telefono
        '
        Me.telefono.HeaderText = "Teléfono"
        Me.telefono.Name = "telefono"
        Me.telefono.Width = 79
        '
        'venta
        '
        Me.venta.HeaderText = "Venta"
        Me.venta.Name = "venta"
        Me.venta.Width = 65
        '
        'descto
        '
        Me.descto.HeaderText = "Descuento"
        Me.descto.Name = "descto"
        Me.descto.Width = 94
        '
        'pagado
        '
        Me.pagado.HeaderText = "Total Pagado"
        Me.pagado.Name = "pagado"
        Me.pagado.Width = 107
        '
        'Pendiente
        '
        Me.Pendiente.HeaderText = "Pendiente"
        Me.Pendiente.Name = "Pendiente"
        Me.Pendiente.Width = 90
        '
        'Column1
        '
        Me.Column1.HeaderText = "N° Doc SII"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 92
        '
        'Consulta_Boleta_Pendiente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 616)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_Pagado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Venta)
        Me.Controls.Add(Me.txt_Descto)
        Me.Controls.Add(Me.txt_Saldo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Consulta_Boleta_Pendiente"
        Me.Text = "Consulta Ventas Pendientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Fecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_Fecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarVentanaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt_Saldo As System.Windows.Forms.TextBox
    Friend WithEvents txt_Descto As System.Windows.Forms.TextBox
    Friend WithEvents txt_Venta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Pagado As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rb3 As System.Windows.Forms.RadioButton
    Friend WithEvents rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents rb4 As System.Windows.Forms.RadioButton
    Public WithEvents DataGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents TIPODOC As DataGridViewTextBoxColumn
    Friend WithEvents numdoc As DataGridViewTextBoxColumn
    Friend WithEvents Fecvta As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents venta As DataGridViewTextBoxColumn
    Friend WithEvents descto As DataGridViewTextBoxColumn
    Friend WithEvents pagado As DataGridViewTextBoxColumn
    Friend WithEvents Pendiente As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
