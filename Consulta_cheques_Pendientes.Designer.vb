<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta_cheques_Pendientes
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGrilla = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_DeudaTotal = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dtp_fecha_Prorroga = New System.Windows.Forms.DateTimePicker()
        Me.btnprorroga = New System.Windows.Forms.Button()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSaldoVencido = New System.Windows.Forms.TextBox()
        Me.num_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fvcto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idFpago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGrilla)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(887, 342)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cheques y Letras"
        '
        'DataGrilla
        '
        Me.DataGrilla.AllowUserToAddRows = False
        Me.DataGrilla.AllowUserToDeleteRows = False
        Me.DataGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGrilla.BackgroundColor = System.Drawing.Color.White
        Me.DataGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num_doc, Me.documento, Me.fvcto, Me.Saldo, Me.Cliente, Me.Fecha, Me.idFpago, Me.IdCliente, Me.vendedor})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrilla.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGrilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrilla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGrilla.Location = New System.Drawing.Point(3, 16)
        Me.DataGrilla.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGrilla.Name = "DataGrilla"
        Me.DataGrilla.ReadOnly = True
        Me.DataGrilla.RowHeadersVisible = False
        Me.DataGrilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataGrilla.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGrilla.Size = New System.Drawing.Size(881, 323)
        Me.DataGrilla.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(674, 424)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Total Documentos:"
        '
        'txt_DeudaTotal
        '
        Me.txt_DeudaTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DeudaTotal.Location = New System.Drawing.Point(793, 421)
        Me.txt_DeudaTotal.Name = "txt_DeudaTotal"
        Me.txt_DeudaTotal.ReadOnly = True
        Me.txt_DeudaTotal.Size = New System.Drawing.Size(100, 21)
        Me.txt_DeudaTotal.TabIndex = 18
        Me.txt_DeudaTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(18, 416)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 31)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Solicita Prórroga"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dtp_fecha_Prorroga
        '
        Me.dtp_fecha_Prorroga.Enabled = False
        Me.dtp_fecha_Prorroga.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_Prorroga.Location = New System.Drawing.Point(141, 419)
        Me.dtp_fecha_Prorroga.Name = "dtp_fecha_Prorroga"
        Me.dtp_fecha_Prorroga.Size = New System.Drawing.Size(88, 20)
        Me.dtp_fecha_Prorroga.TabIndex = 22
        '
        'btnprorroga
        '
        Me.btnprorroga.Enabled = False
        Me.btnprorroga.Location = New System.Drawing.Point(265, 416)
        Me.btnprorroga.Name = "btnprorroga"
        Me.btnprorroga.Size = New System.Drawing.Size(117, 31)
        Me.btnprorroga.TabIndex = 23
        Me.btnprorroga.Text = "Confirmar Cambios"
        Me.btnprorroga.UseVisualStyleBackColor = True
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(18, 479)
        Me.txt_user.MaxLength = 10
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(100, 20)
        Me.txt_user.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 463)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Usuario"
        '
        'txt_Password
        '
        Me.txt_Password.Location = New System.Drawing.Point(134, 479)
        Me.txt_Password.MaxLength = 100
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Password.Size = New System.Drawing.Size(111, 20)
        Me.txt_Password.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(131, 463)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Clave"
        '
        'Button5
        '
        Me.Button5.Image = Global.GestionVivero.My.Resources.Resources.salir_40x40
        Me.Button5.Location = New System.Drawing.Point(860, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(49, 49)
        Me.Button5.TabIndex = 29
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(666, 461)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 15)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Total Saldo Vencido:"
        '
        'txtSaldoVencido
        '
        Me.txtSaldoVencido.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoVencido.Location = New System.Drawing.Point(793, 458)
        Me.txtSaldoVencido.Name = "txtSaldoVencido"
        Me.txtSaldoVencido.ReadOnly = True
        Me.txtSaldoVencido.Size = New System.Drawing.Size(100, 21)
        Me.txtSaldoVencido.TabIndex = 31
        Me.txtSaldoVencido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'num_doc
        '
        Me.num_doc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.num_doc.HeaderText = "N°"
        Me.num_doc.Name = "num_doc"
        Me.num_doc.ReadOnly = True
        Me.num_doc.Width = 44
        '
        'documento
        '
        Me.documento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.documento.HeaderText = "Documento"
        Me.documento.Name = "documento"
        Me.documento.ReadOnly = True
        Me.documento.Width = 87
        '
        'fvcto
        '
        Me.fvcto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.fvcto.HeaderText = "Vencimiento"
        Me.fvcto.Name = "fvcto"
        Me.fvcto.ReadOnly = True
        Me.fvcto.Width = 90
        '
        'Saldo
        '
        Me.Saldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Saldo.DefaultCellStyle = DataGridViewCellStyle1
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.ReadOnly = True
        Me.Saldo.ToolTipText = "Total:Facturas,Boletas,Exentas,Notas de Créditos (restadas)"
        Me.Saldo.Width = 70
        '
        'Cliente
        '
        Me.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Fecha.HeaderText = "Fecha Registro"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 104
        '
        'idFpago
        '
        Me.idFpago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.idFpago.HeaderText = "IdFPago"
        Me.idFpago.Name = "idFpago"
        Me.idFpago.ReadOnly = True
        Me.idFpago.Visible = False
        Me.idFpago.Width = 72
        '
        'IdCliente
        '
        Me.IdCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IdCliente.HeaderText = "IdCliente"
        Me.IdCliente.Name = "IdCliente"
        Me.IdCliente.ReadOnly = True
        Me.IdCliente.ToolTipText = "Total Abonos realizados por el cliente"
        Me.IdCliente.Visible = False
        Me.IdCliente.Width = 73
        '
        'vendedor
        '
        Me.vendedor.HeaderText = "Vendedor"
        Me.vendedor.Name = "vendedor"
        Me.vendedor.ReadOnly = True
        Me.vendedor.Width = 78
        '
        'Consulta_cheques_Pendientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(911, 515)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtSaldoVencido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.btnprorroga)
        Me.Controls.Add(Me.dtp_fecha_Prorroga)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_DeudaTotal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Consulta_cheques_Pendientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cheques / Letras con Saldo Pendiente"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_DeudaTotal As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents dtp_fecha_Prorroga As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnprorroga As System.Windows.Forms.Button
    Friend WithEvents txt_user As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Password As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSaldoVencido As TextBox
    Friend WithEvents num_doc As DataGridViewTextBoxColumn
    Friend WithEvents documento As DataGridViewTextBoxColumn
    Friend WithEvents fvcto As DataGridViewTextBoxColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents idFpago As DataGridViewTextBoxColumn
    Friend WithEvents IdCliente As DataGridViewTextBoxColumn
    Friend WithEvents vendedor As DataGridViewTextBoxColumn
End Class
