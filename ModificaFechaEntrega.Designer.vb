<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificaFechaEntrega
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtFechaSiembraActual = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpNuevaFechaSiembra = New System.Windows.Forms.DateTimePicker()
        Me.txtFechaEntregaActual = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpNuevaFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdiasfab = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtLote)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(144, 50)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "N° Lote"
        '
        'txtLote
        '
        Me.txtLote.Location = New System.Drawing.Point(12, 18)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.ReadOnly = True
        Me.txtLote.Size = New System.Drawing.Size(115, 26)
        Me.txtLote.TabIndex = 10
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.GestionVivero.My.Resources.Resources.salir_40x40
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Location = New System.Drawing.Point(665, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 48)
        Me.Button2.TabIndex = 11
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.GestionVivero.My.Resources.Resources.guardar_40x40
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Location = New System.Drawing.Point(353, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 48)
        Me.Button1.TabIndex = 10
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtFechaSiembraActual
        '
        Me.txtFechaSiembraActual.Location = New System.Drawing.Point(316, 29)
        Me.txtFechaSiembraActual.Name = "txtFechaSiembraActual"
        Me.txtFechaSiembraActual.ReadOnly = True
        Me.txtFechaSiembraActual.Size = New System.Drawing.Size(212, 23)
        Me.txtFechaSiembraActual.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(166, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Fecha de Siembra Actual:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(167, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nueva Fecha de Siembra:"
        '
        'dtpNuevaFechaSiembra
        '
        Me.dtpNuevaFechaSiembra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNuevaFechaSiembra.Location = New System.Drawing.Point(316, 158)
        Me.dtpNuevaFechaSiembra.Name = "dtpNuevaFechaSiembra"
        Me.dtpNuevaFechaSiembra.Size = New System.Drawing.Size(212, 23)
        Me.dtpNuevaFechaSiembra.TabIndex = 16
        '
        'txtFechaEntregaActual
        '
        Me.txtFechaEntregaActual.Location = New System.Drawing.Point(316, 72)
        Me.txtFechaEntregaActual.Name = "txtFechaEntregaActual"
        Me.txtFechaEntregaActual.ReadOnly = True
        Me.txtFechaEntregaActual.Size = New System.Drawing.Size(212, 23)
        Me.txtFechaEntregaActual.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(170, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Fecha de Entrega Actual:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(171, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 15)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Nueva Fecha de Entrega:"
        '
        'dtpNuevaFechaEntrega
        '
        Me.dtpNuevaFechaEntrega.Enabled = False
        Me.dtpNuevaFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNuevaFechaEntrega.Location = New System.Drawing.Point(316, 201)
        Me.dtpNuevaFechaEntrega.Name = "dtpNuevaFechaEntrega"
        Me.dtpNuevaFechaEntrega.Size = New System.Drawing.Size(212, 23)
        Me.dtpNuevaFechaEntrega.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(217, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 15)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "N° Días Entrega:"
        '
        'txtdiasfab
        '
        Me.txtdiasfab.Location = New System.Drawing.Point(316, 115)
        Me.txtdiasfab.Name = "txtdiasfab"
        Me.txtdiasfab.Size = New System.Drawing.Size(212, 23)
        Me.txtdiasfab.TabIndex = 22
        '
        'ModificaFechaEntrega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(715, 325)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtdiasfab)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpNuevaFechaEntrega)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFechaEntregaActual)
        Me.Controls.Add(Me.dtpNuevaFechaSiembra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFechaSiembraActual)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ModificaFechaEntrega"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modifica Fecha de Siembra"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtLote As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtFechaSiembraActual As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpNuevaFechaSiembra As DateTimePicker
    Friend WithEvents txtFechaEntregaActual As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpNuevaFechaEntrega As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtdiasfab As TextBox
End Class
