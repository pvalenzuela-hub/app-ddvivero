<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_Apertura
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.dtp_FechaApertura = New System.Windows.Forms.DateTimePicker()
        Me.GrillaCaja = New System.Windows.Forms.DataGridView()
        Me.NumMov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Entrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vcto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.GrillaCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(123, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Apertura"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(386, 420)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 40)
        Me.Button2.TabIndex = 87
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(176, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(276, 19)
        Me.Label6.TabIndex = 141
        Me.Label6.Text = "APERTURA DE CUENTAS DIARIAS"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(81, 420)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(132, 40)
        Me.Button4.TabIndex = 146
        Me.Button4.Text = "Confirma Apertura"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'dtp_FechaApertura
        '
        Me.dtp_FechaApertura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaApertura.Location = New System.Drawing.Point(258, 60)
        Me.dtp_FechaApertura.Name = "dtp_FechaApertura"
        Me.dtp_FechaApertura.Size = New System.Drawing.Size(107, 21)
        Me.dtp_FechaApertura.TabIndex = 150
        '
        'GrillaCaja
        '
        Me.GrillaCaja.AllowUserToAddRows = False
        Me.GrillaCaja.AllowUserToDeleteRows = False
        Me.GrillaCaja.BackgroundColor = System.Drawing.Color.White
        Me.GrillaCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaCaja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumMov, Me.Fecha, Me.Entrada, Me.vcto})
        Me.GrillaCaja.Location = New System.Drawing.Point(66, 133)
        Me.GrillaCaja.Name = "GrillaCaja"
        Me.GrillaCaja.ReadOnly = True
        Me.GrillaCaja.Size = New System.Drawing.Size(496, 256)
        Me.GrillaCaja.TabIndex = 151
        '
        'NumMov
        '
        Me.NumMov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumMov.HeaderText = "Cuenta"
        Me.NumMov.Name = "NumMov"
        Me.NumMov.ReadOnly = True
        Me.NumMov.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NumMov.Width = 71
        '
        'Fecha
        '
        Me.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Fecha.HeaderText = "Descripcion"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Fecha.Width = 97
        '
        'Entrada
        '
        Me.Entrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Entrada.DefaultCellStyle = DataGridViewCellStyle1
        Me.Entrada.HeaderText = "Saldo diario"
        Me.Entrada.Name = "Entrada"
        Me.Entrada.ReadOnly = True
        Me.Entrada.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Entrada.Width = 98
        '
        'vcto
        '
        Me.vcto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.vcto.HeaderText = "Fecha Saldo"
        Me.vcto.Name = "vcto"
        Me.vcto.ReadOnly = True
        Me.vcto.Width = 101
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(386, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 23)
        Me.Button1.TabIndex = 152
        Me.Button1.Text = "Confirmar Fecha"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Registro_Apertura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(628, 472)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GrillaCaja)
        Me.Controls.Add(Me.dtp_FechaApertura)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Registro_Apertura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Saldos Diarios de Apertura"
        CType(Me.GrillaCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents dtp_FechaApertura As System.Windows.Forms.DateTimePicker
    Friend WithEvents GrillaCaja As System.Windows.Forms.DataGridView
    Friend WithEvents NumMov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Entrada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vcto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
