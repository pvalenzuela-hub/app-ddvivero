<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CierrePeriodoAnual
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPeriodo = New System.Windows.Forms.NumericUpDown()
        Me.btnProceso = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.txtPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proceso de Apertura de Cuentas Anual"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(163, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Indique Año de Cierre Contable:"
        '
        'txtPeriodo
        '
        Me.txtPeriodo.Location = New System.Drawing.Point(349, 153)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.Size = New System.Drawing.Size(86, 20)
        Me.txtPeriodo.TabIndex = 2
        '
        'btnProceso
        '
        Me.btnProceso.Image = Global.GestionVivero.My.Resources.Resources.guardar_40x40
        Me.btnProceso.Location = New System.Drawing.Point(386, 366)
        Me.btnProceso.Name = "btnProceso"
        Me.btnProceso.Size = New System.Drawing.Size(49, 49)
        Me.btnProceso.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnProceso, "Proceso de Apertura de Saldos")
        Me.btnProceso.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.salir_40x401
        Me.Button2.Location = New System.Drawing.Point(748, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(49, 49)
        Me.Button2.TabIndex = 4
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label3.Location = New System.Drawing.Point(36, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(752, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Este proceso realiza un traspaso de los saldos de las cuentas de Activo y Pasivo " &
    "desde el año anterior al año actual."
        '
        'CierrePeriodoAnual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnProceso)
        Me.Controls.Add(Me.txtPeriodo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CierrePeriodoAnual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cierre Período Anual"
        CType(Me.txtPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPeriodo As NumericUpDown
    Friend WithEvents btnProceso As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label3 As Label
End Class
