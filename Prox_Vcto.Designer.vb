<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prox_Vcto
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataCompras = New System.Windows.Forms.DataGridView()
        Me.tipodoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numdoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechavcto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_Total = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_SaldoVencido = New System.Windows.Forms.MaskedTextBox()
        CType(Me.DataCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataCompras
        '
        Me.DataCompras.AllowUserToAddRows = False
        Me.DataCompras.AllowUserToDeleteRows = False
        Me.DataCompras.AllowUserToResizeColumns = False
        Me.DataCompras.AllowUserToResizeRows = False
        Me.DataCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataCompras.BackgroundColor = System.Drawing.Color.White
        Me.DataCompras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataCompras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tipodoc, Me.numdoc, Me.fecha, Me.proveedor, Me.valor, Me.pago, Me.Saldo, Me.fechavcto})
        Me.DataCompras.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataCompras.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataCompras.GridColor = System.Drawing.Color.White
        Me.DataCompras.Location = New System.Drawing.Point(3, 17)
        Me.DataCompras.Name = "DataCompras"
        Me.DataCompras.ReadOnly = True
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataCompras.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.DataCompras.RowHeadersVisible = False
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataCompras.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.DataCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataCompras.Size = New System.Drawing.Size(1009, 408)
        Me.DataCompras.StandardTab = True
        Me.DataCompras.TabIndex = 1
        '
        'tipodoc
        '
        Me.tipodoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.tipodoc.HeaderText = "Tipo"
        Me.tipodoc.Name = "tipodoc"
        Me.tipodoc.ReadOnly = True
        Me.tipodoc.Width = 40
        '
        'numdoc
        '
        Me.numdoc.HeaderText = "N° Doc."
        Me.numdoc.Name = "numdoc"
        Me.numdoc.ReadOnly = True
        Me.numdoc.Width = 69
        '
        'fecha
        '
        Me.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.fecha.HeaderText = "Fecha Compra"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 105
        '
        'proveedor
        '
        Me.proveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.proveedor.HeaderText = "Proveedor"
        Me.proveedor.Name = "proveedor"
        Me.proveedor.ReadOnly = True
        '
        'valor
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N0"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.valor.DefaultCellStyle = DataGridViewCellStyle9
        Me.valor.HeaderText = "Valor"
        Me.valor.Name = "valor"
        Me.valor.ReadOnly = True
        Me.valor.Width = 59
        '
        'pago
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N0"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.pago.DefaultCellStyle = DataGridViewCellStyle10
        Me.pago.HeaderText = "Total Pago"
        Me.pago.Name = "pago"
        Me.pago.ReadOnly = True
        Me.pago.Width = 83
        '
        'Saldo
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N0"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.Saldo.DefaultCellStyle = DataGridViewCellStyle11
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.ReadOnly = True
        Me.Saldo.Width = 64
        '
        'fechavcto
        '
        Me.fechavcto.HeaderText = "Fecha Vencimiento"
        Me.fechavcto.Name = "fechavcto"
        Me.fechavcto.ReadOnly = True
        Me.fechavcto.Width = 124
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataCompras)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1015, 428)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.GestionVivero.My.Resources.Resources.salir_40x40
        Me.Button1.Location = New System.Drawing.Point(1027, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 41)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_Total
        '
        Me.txt_Total.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Total.Location = New System.Drawing.Point(505, 485)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.ReadOnly = True
        Me.txt_Total.Size = New System.Drawing.Size(129, 23)
        Me.txt_Total.TabIndex = 6
        Me.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(349, 489)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Saldo Total Documentado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(303, 456)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Saldo Total Documentado Vencido:"
        '
        'txt_SaldoVencido
        '
        Me.txt_SaldoVencido.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SaldoVencido.ForeColor = System.Drawing.Color.Red
        Me.txt_SaldoVencido.Location = New System.Drawing.Point(504, 453)
        Me.txt_SaldoVencido.Name = "txt_SaldoVencido"
        Me.txt_SaldoVencido.ReadOnly = True
        Me.txt_SaldoVencido.Size = New System.Drawing.Size(129, 23)
        Me.txt_SaldoVencido.TabIndex = 11
        Me.txt_SaldoVencido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Prox_Vcto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1073, 520)
        Me.Controls.Add(Me.txt_SaldoVencido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_Total)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MinimizeBox = False
        Me.Name = "Prox_Vcto"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas con Saldo Pendientes"
        Me.TopMost = True
        CType(Me.DataCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents DataCompras As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_Total As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_SaldoVencido As MaskedTextBox
    Friend WithEvents tipodoc As DataGridViewTextBoxColumn
    Friend WithEvents numdoc As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents proveedor As DataGridViewTextBoxColumn
    Friend WithEvents valor As DataGridViewTextBoxColumn
    Friend WithEvents pago As DataGridViewTextBoxColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
    Friend WithEvents fechavcto As DataGridViewTextBoxColumn
End Class
