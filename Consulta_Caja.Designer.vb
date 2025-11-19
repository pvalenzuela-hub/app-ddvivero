<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta_Caja
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GrillaCaja = New System.Windows.Forms.DataGridView
        Me.NumMov = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Entrada = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Salida = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Glosa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vcto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.concepto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_SaldoFinal = New System.Windows.Forms.TextBox
        Me.txt_SaldoInicial = New System.Windows.Forms.TextBox
        Me.dtp_fechadesde = New System.Windows.Forms.DateTimePicker
        Me.dtp_fechahasta = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        CType(Me.GrillaCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrillaCaja
        '
        Me.GrillaCaja.AllowUserToAddRows = False
        Me.GrillaCaja.AllowUserToDeleteRows = False
        Me.GrillaCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaCaja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumMov, Me.Fecha, Me.Entrada, Me.Salida, Me.Saldo, Me.Glosa, Me.vcto, Me.concepto})
        Me.GrillaCaja.Location = New System.Drawing.Point(3, 76)
        Me.GrillaCaja.Name = "GrillaCaja"
        Me.GrillaCaja.ReadOnly = True
        Me.GrillaCaja.Size = New System.Drawing.Size(978, 345)
        Me.GrillaCaja.TabIndex = 0
        '
        'NumMov
        '
        Me.NumMov.HeaderText = "N° Mov"
        Me.NumMov.Name = "NumMov"
        Me.NumMov.ReadOnly = True
        Me.NumMov.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NumMov.Width = 60
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Fecha.Width = 80
        '
        'Entrada
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Entrada.DefaultCellStyle = DataGridViewCellStyle4
        Me.Entrada.HeaderText = "Entrada"
        Me.Entrada.Name = "Entrada"
        Me.Entrada.ReadOnly = True
        Me.Entrada.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Salida
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Salida.DefaultCellStyle = DataGridViewCellStyle5
        Me.Salida.HeaderText = "Salida"
        Me.Salida.Name = "Salida"
        Me.Salida.ReadOnly = True
        Me.Salida.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Saldo
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Saldo.DefaultCellStyle = DataGridViewCellStyle6
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.ReadOnly = True
        Me.Saldo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Glosa
        '
        Me.Glosa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Glosa.HeaderText = "Glosa"
        Me.Glosa.Name = "Glosa"
        Me.Glosa.ReadOnly = True
        Me.Glosa.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Glosa.Width = 59
        '
        'vcto
        '
        Me.vcto.HeaderText = "F.Vcto."
        Me.vcto.Name = "vcto"
        Me.vcto.ReadOnly = True
        Me.vcto.Width = 80
        '
        'concepto
        '
        Me.concepto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.concepto.HeaderText = "Tipo Pago"
        Me.concepto.Name = "concepto"
        Me.concepto.ReadOnly = True
        Me.concepto.Width = 81
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(293, 425)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(399, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cuenta Caja"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 430)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Saldo Inicial"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(804, 430)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Saldo Final"
        '
        'txt_SaldoFinal
        '
        Me.txt_SaldoFinal.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_SaldoFinal.CausesValidation = False
        Me.txt_SaldoFinal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SaldoFinal.ForeColor = System.Drawing.Color.Yellow
        Me.txt_SaldoFinal.Location = New System.Drawing.Point(869, 425)
        Me.txt_SaldoFinal.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txt_SaldoFinal.Name = "txt_SaldoFinal"
        Me.txt_SaldoFinal.ReadOnly = True
        Me.txt_SaldoFinal.Size = New System.Drawing.Size(105, 22)
        Me.txt_SaldoFinal.TabIndex = 81
        Me.txt_SaldoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_SaldoInicial
        '
        Me.txt_SaldoInicial.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_SaldoInicial.CausesValidation = False
        Me.txt_SaldoInicial.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SaldoInicial.ForeColor = System.Drawing.Color.Yellow
        Me.txt_SaldoInicial.Location = New System.Drawing.Point(112, 425)
        Me.txt_SaldoInicial.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txt_SaldoInicial.Name = "txt_SaldoInicial"
        Me.txt_SaldoInicial.ReadOnly = True
        Me.txt_SaldoInicial.Size = New System.Drawing.Size(105, 22)
        Me.txt_SaldoInicial.TabIndex = 82
        Me.txt_SaldoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtp_fechadesde
        '
        Me.dtp_fechadesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechadesde.Location = New System.Drawing.Point(319, 41)
        Me.dtp_fechadesde.Name = "dtp_fechadesde"
        Me.dtp_fechadesde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_fechadesde.TabIndex = 83
        '
        'dtp_fechahasta
        '
        Me.dtp_fechahasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechahasta.Location = New System.Drawing.Point(496, 41)
        Me.dtp_fechahasta.Name = "dtp_fechahasta"
        Me.dtp_fechahasta.Size = New System.Drawing.Size(97, 20)
        Me.dtp_fechahasta.TabIndex = 84
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(223, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Rango de Fecha:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(628, 39)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 24)
        Me.Button2.TabIndex = 86
        Me.Button2.Text = "Consulta Movimientos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(524, 425)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(132, 23)
        Me.Button3.TabIndex = 87
        Me.Button3.Text = "Modificar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Consulta_Caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 462)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtp_fechahasta)
        Me.Controls.Add(Me.dtp_fechadesde)
        Me.Controls.Add(Me.txt_SaldoInicial)
        Me.Controls.Add(Me.txt_SaldoFinal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GrillaCaja)
        Me.Name = "Consulta_Caja"
        Me.Text = "Consulta_Caja"
        CType(Me.GrillaCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrillaCaja As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_SaldoFinal As System.Windows.Forms.TextBox
    Friend WithEvents txt_SaldoInicial As System.Windows.Forms.TextBox
    Friend WithEvents dtp_fechadesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fechahasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents NumMov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Entrada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Salida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Saldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Glosa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vcto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents concepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
