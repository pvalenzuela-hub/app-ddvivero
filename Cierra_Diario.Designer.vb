<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cierra_Diario
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GrillaCaja = New System.Windows.Forms.DataGridView()
        Me.NumMov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Entrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vcto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtp_FechaApertura = New System.Windows.Forms.DateTimePicker()
        Me.btn_GrabaCierre = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_Cta_Ctble = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Cta_Ctble = New System.Windows.Forms.TextBox()
        Me.txt_SaldoFinalDiario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Total_Ingresos = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Total_Egresos = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Saldo_Diario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_Saldo_Inicial = New System.Windows.Forms.TextBox()
        CType(Me.GrillaCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(504, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 43)
        Me.Button1.TabIndex = 159
        Me.Button1.Text = "Consulta Movimientos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GrillaCaja
        '
        Me.GrillaCaja.AllowUserToAddRows = False
        Me.GrillaCaja.AllowUserToDeleteRows = False
        Me.GrillaCaja.BackgroundColor = System.Drawing.Color.White
        Me.GrillaCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaCaja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumMov, Me.Entrada, Me.vcto, Me.Saldo})
        Me.GrillaCaja.Location = New System.Drawing.Point(2, 159)
        Me.GrillaCaja.Name = "GrillaCaja"
        Me.GrillaCaja.ReadOnly = True
        Me.GrillaCaja.Size = New System.Drawing.Size(691, 270)
        Me.GrillaCaja.TabIndex = 158
        '
        'NumMov
        '
        Me.NumMov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumMov.HeaderText = "Concepto"
        Me.NumMov.Name = "NumMov"
        Me.NumMov.ReadOnly = True
        Me.NumMov.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NumMov.Width = 78
        '
        'Entrada
        '
        Me.Entrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Entrada.DefaultCellStyle = DataGridViewCellStyle1
        Me.Entrada.HeaderText = "Debe"
        Me.Entrada.Name = "Entrada"
        Me.Entrada.ReadOnly = True
        Me.Entrada.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Entrada.Width = 58
        '
        'vcto
        '
        Me.vcto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.vcto.DefaultCellStyle = DataGridViewCellStyle2
        Me.vcto.HeaderText = "Haber"
        Me.vcto.Name = "vcto"
        Me.vcto.ReadOnly = True
        Me.vcto.Width = 61
        '
        'Saldo
        '
        Me.Saldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Saldo.DefaultCellStyle = DataGridViewCellStyle3
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.ReadOnly = True
        Me.Saldo.Width = 59
        '
        'dtp_FechaApertura
        '
        Me.dtp_FechaApertura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaApertura.Location = New System.Drawing.Point(275, 62)
        Me.dtp_FechaApertura.Name = "dtp_FechaApertura"
        Me.dtp_FechaApertura.Size = New System.Drawing.Size(107, 20)
        Me.dtp_FechaApertura.TabIndex = 157
        '
        'btn_GrabaCierre
        '
        Me.btn_GrabaCierre.Location = New System.Drawing.Point(100, 610)
        Me.btn_GrabaCierre.Name = "btn_GrabaCierre"
        Me.btn_GrabaCierre.Size = New System.Drawing.Size(132, 40)
        Me.btn_GrabaCierre.TabIndex = 156
        Me.btn_GrabaCierre.Text = "Confirma Cierre"
        Me.btn_GrabaCierre.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(190, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(249, 19)
        Me.Label6.TabIndex = 155
        Me.Label6.Text = "CIERRE DE CUENTAS DIARIAS"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(423, 610)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 40)
        Me.Button2.TabIndex = 154
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(139, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "Fecha Cierre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(139, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 15)
        Me.Label2.TabIndex = 160
        Me.Label2.Text = "Descripcion Cuenta"
        '
        'cmb_Cta_Ctble
        '
        Me.cmb_Cta_Ctble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cta_Ctble.FormattingEnabled = True
        Me.cmb_Cta_Ctble.Location = New System.Drawing.Point(275, 97)
        Me.cmb_Cta_Ctble.Name = "cmb_Cta_Ctble"
        Me.cmb_Cta_Ctble.Size = New System.Drawing.Size(223, 21)
        Me.cmb_Cta_Ctble.TabIndex = 161
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(139, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "Cuenta"
        '
        'txt_Cta_Ctble
        '
        Me.txt_Cta_Ctble.Location = New System.Drawing.Point(275, 133)
        Me.txt_Cta_Ctble.Name = "txt_Cta_Ctble"
        Me.txt_Cta_Ctble.ReadOnly = True
        Me.txt_Cta_Ctble.Size = New System.Drawing.Size(107, 20)
        Me.txt_Cta_Ctble.TabIndex = 163
        '
        'txt_SaldoFinalDiario
        '
        Me.txt_SaldoFinalDiario.Location = New System.Drawing.Point(579, 529)
        Me.txt_SaldoFinalDiario.Name = "txt_SaldoFinalDiario"
        Me.txt_SaldoFinalDiario.ReadOnly = True
        Me.txt_SaldoFinalDiario.Size = New System.Drawing.Size(107, 20)
        Me.txt_SaldoFinalDiario.TabIndex = 164
        Me.txt_SaldoFinalDiario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(470, 441)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "Saldo Diario:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 441)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 15)
        Me.Label5.TabIndex = 166
        Me.Label5.Text = "Total Ingresos:"
        '
        'txt_Total_Ingresos
        '
        Me.txt_Total_Ingresos.Location = New System.Drawing.Point(100, 438)
        Me.txt_Total_Ingresos.Name = "txt_Total_Ingresos"
        Me.txt_Total_Ingresos.ReadOnly = True
        Me.txt_Total_Ingresos.Size = New System.Drawing.Size(107, 20)
        Me.txt_Total_Ingresos.TabIndex = 167
        Me.txt_Total_Ingresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(227, 441)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 15)
        Me.Label7.TabIndex = 168
        Me.Label7.Text = "Total Egresos:"
        '
        'txt_Total_Egresos
        '
        Me.txt_Total_Egresos.Location = New System.Drawing.Point(318, 438)
        Me.txt_Total_Egresos.Name = "txt_Total_Egresos"
        Me.txt_Total_Egresos.ReadOnly = True
        Me.txt_Total_Egresos.Size = New System.Drawing.Size(107, 20)
        Me.txt_Total_Egresos.TabIndex = 169
        Me.txt_Total_Egresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(470, 532)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 15)
        Me.Label8.TabIndex = 170
        Me.Label8.Text = "Saldo Final diario"
        '
        'txt_Saldo_Diario
        '
        Me.txt_Saldo_Diario.Location = New System.Drawing.Point(579, 438)
        Me.txt_Saldo_Diario.Name = "txt_Saldo_Diario"
        Me.txt_Saldo_Diario.ReadOnly = True
        Me.txt_Saldo_Diario.Size = New System.Drawing.Size(107, 20)
        Me.txt_Saldo_Diario.TabIndex = 171
        Me.txt_Saldo_Diario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(470, 484)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 15)
        Me.Label9.TabIndex = 172
        Me.Label9.Text = "Saldo Inicial:"
        '
        'txt_Saldo_Inicial
        '
        Me.txt_Saldo_Inicial.Location = New System.Drawing.Point(579, 481)
        Me.txt_Saldo_Inicial.Name = "txt_Saldo_Inicial"
        Me.txt_Saldo_Inicial.ReadOnly = True
        Me.txt_Saldo_Inicial.Size = New System.Drawing.Size(107, 20)
        Me.txt_Saldo_Inicial.TabIndex = 173
        Me.txt_Saldo_Inicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Cierra_Diario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(693, 662)
        Me.Controls.Add(Me.txt_Saldo_Inicial)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_Saldo_Diario)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_Total_Egresos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_Total_Ingresos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_SaldoFinalDiario)
        Me.Controls.Add(Me.txt_Cta_Ctble)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_Cta_Ctble)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GrillaCaja)
        Me.Controls.Add(Me.dtp_FechaApertura)
        Me.Controls.Add(Me.btn_GrabaCierre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Cierra_Diario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cierre Diario"
        CType(Me.GrillaCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GrillaCaja As System.Windows.Forms.DataGridView
    Friend WithEvents dtp_FechaApertura As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_GrabaCierre As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_Cta_Ctble As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Cta_Ctble As System.Windows.Forms.TextBox
    Friend WithEvents NumMov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Entrada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vcto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Saldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_SaldoFinalDiario As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Total_Ingresos As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_Total_Egresos As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_Saldo_Diario As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_Saldo_Inicial As System.Windows.Forms.TextBox
End Class
