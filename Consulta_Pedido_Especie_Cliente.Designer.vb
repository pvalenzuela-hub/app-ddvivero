<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta_Pedido_Especie_Cliente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GrillaRepo = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmb_Especie = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.dtp_Fecha2 = New System.Windows.Forms.DateTimePicker
        Me.dtp_Fecha1 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_TotPlantas = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.eMail = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Telefonos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sector = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fconteo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Variedad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmb_Sector = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.GrillaRepo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrillaRepo
        '
        Me.GrillaRepo.AllowUserToAddRows = False
        Me.GrillaRepo.AllowUserToDeleteRows = False
        Me.GrillaRepo.AllowUserToOrderColumns = True
        Me.GrillaRepo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.GrillaRepo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.GrillaRepo.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.GrillaRepo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GrillaRepo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.GrillaRepo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrillaRepo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GrillaRepo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaRepo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cliente, Me.eMail, Me.Telefonos, Me.Sector, Me.fconteo, Me.Variedad, Me.cantidad})
        Me.GrillaRepo.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrillaRepo.DefaultCellStyle = DataGridViewCellStyle3
        Me.GrillaRepo.GridColor = System.Drawing.Color.White
        Me.GrillaRepo.Location = New System.Drawing.Point(0, 100)
        Me.GrillaRepo.Name = "GrillaRepo"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrillaRepo.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DarkBlue
        Me.GrillaRepo.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.GrillaRepo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GrillaRepo.Size = New System.Drawing.Size(984, 427)
        Me.GrillaRepo.StandardTab = True
        Me.GrillaRepo.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmb_Sector)
        Me.GroupBox1.Controls.Add(Me.cmb_Especie)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.dtp_Fecha2)
        Me.GroupBox1.Controls.Add(Me.dtp_Fecha1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(982, 91)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'cmb_Especie
        '
        Me.cmb_Especie.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_Especie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Especie.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Especie.ForeColor = System.Drawing.Color.Navy
        Me.cmb_Especie.FormattingEnabled = True
        Me.cmb_Especie.Location = New System.Drawing.Point(382, 30)
        Me.cmb_Especie.Name = "cmb_Especie"
        Me.cmb_Especie.Size = New System.Drawing.Size(271, 23)
        Me.cmb_Especie.TabIndex = 67
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(315, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Especie"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(783, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 27)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Ejecutar Consulta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtp_Fecha2
        '
        Me.dtp_Fecha2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Fecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha2.Location = New System.Drawing.Point(176, 60)
        Me.dtp_Fecha2.Name = "dtp_Fecha2"
        Me.dtp_Fecha2.Size = New System.Drawing.Size(110, 25)
        Me.dtp_Fecha2.TabIndex = 3
        '
        'dtp_Fecha1
        '
        Me.dtp_Fecha1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Fecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha1.Location = New System.Drawing.Point(176, 29)
        Me.dtp_Fecha1.Name = "dtp_Fecha1"
        Me.dtp_Fecha1.Size = New System.Drawing.Size(110, 25)
        Me.dtp_Fecha1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Período de Siembra"
        '
        'txt_TotPlantas
        '
        Me.txt_TotPlantas.Location = New System.Drawing.Point(482, 533)
        Me.txt_TotPlantas.Name = "txt_TotPlantas"
        Me.txt_TotPlantas.ReadOnly = True
        Me.txt_TotPlantas.Size = New System.Drawing.Size(100, 20)
        Me.txt_TotPlantas.TabIndex = 3
        Me.txt_TotPlantas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(379, 535)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total Plantas:"
        '
        'cliente
        '
        Me.cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        Me.cliente.Width = 73
        '
        'eMail
        '
        Me.eMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.eMail.HeaderText = "eMail"
        Me.eMail.Name = "eMail"
        Me.eMail.ReadOnly = True
        Me.eMail.Width = 64
        '
        'Telefonos
        '
        Me.Telefonos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Telefonos.HeaderText = "Teléfonos"
        Me.Telefonos.Name = "Telefonos"
        Me.Telefonos.ReadOnly = True
        Me.Telefonos.Width = 87
        '
        'Sector
        '
        Me.Sector.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Sector.HeaderText = "Sector"
        Me.Sector.Name = "Sector"
        Me.Sector.Width = 71
        '
        'fconteo
        '
        Me.fconteo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.fconteo.HeaderText = "Fecha Siembra"
        Me.fconteo.Name = "fconteo"
        Me.fconteo.Width = 111
        '
        'Variedad
        '
        Me.Variedad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Variedad.HeaderText = "Variedad"
        Me.Variedad.Name = "Variedad"
        Me.Variedad.ReadOnly = True
        Me.Variedad.Width = 83
        '
        'cantidad
        '
        Me.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.cantidad.HeaderText = "Plantas"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Width = 77
        '
        'cmb_Sector
        '
        Me.cmb_Sector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Sector.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Sector.FormattingEnabled = True
        Me.cmb_Sector.Location = New System.Drawing.Point(382, 62)
        Me.cmb_Sector.Name = "cmb_Sector"
        Me.cmb_Sector.Size = New System.Drawing.Size(271, 23)
        Me.cmb_Sector.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(315, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Sector"
        '
        'Consulta_Pedido_Especie_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 562)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_TotPlantas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrillaRepo)
        Me.Name = "Consulta_Pedido_Especie_Cliente"
        Me.Text = "Consulta Siembra por Período"
        CType(Me.GrillaRepo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents GrillaRepo As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Especie As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtp_Fecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Fecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_TotPlantas As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents eMail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefonos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sector As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fconteo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Variedad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_Sector As System.Windows.Forms.ComboBox
End Class
