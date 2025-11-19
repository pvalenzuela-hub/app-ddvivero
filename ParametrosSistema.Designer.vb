<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParametrosSistema
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_FA = New System.Windows.Forms.TextBox()
        Me.txt_BE = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_IVA = New System.Windows.Forms.TextBox()
        Me.txt_CONTA_INI = New System.Windows.Forms.TextBox()
        Me.txt_GTOSGRALES = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_ID29_final = New System.Windows.Forms.TextBox()
        Me.txt_ID29_inicio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_ID28_final = New System.Windows.Forms.TextBox()
        Me.txt_ID28_inicio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_ID32_final = New System.Windows.Forms.TextBox()
        Me.txt_ID27_final = New System.Windows.Forms.TextBox()
        Me.txt_ID26_final = New System.Windows.Forms.TextBox()
        Me.txt_ID32_inicio = New System.Windows.Forms.TextBox()
        Me.txt_ID27_inicio = New System.Windows.Forms.TextBox()
        Me.txt_ID26_inicio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_MaximoPedido = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtNotasDetalleVenta = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtProrroga = New System.Windows.Forms.TextBox()
        Me.txtDesbloqueo = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Correlativo Boletas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Correlativo Facturas"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_FA)
        Me.GroupBox1.Controls.Add(Me.txt_BE)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(525, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Correlativo Documentos de Ventas"
        '
        'txt_FA
        '
        Me.txt_FA.Location = New System.Drawing.Point(155, 55)
        Me.txt_FA.Name = "txt_FA"
        Me.txt_FA.Size = New System.Drawing.Size(100, 20)
        Me.txt_FA.TabIndex = 5
        '
        'txt_BE
        '
        Me.txt_BE.Location = New System.Drawing.Point(155, 29)
        Me.txt_BE.Name = "txt_BE"
        Me.txt_BE.Size = New System.Drawing.Size(100, 20)
        Me.txt_BE.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_IVA)
        Me.GroupBox2.Controls.Add(Me.txt_CONTA_INI)
        Me.GroupBox2.Controls.Add(Me.txt_GTOSGRALES)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(525, 100)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Parámetros Contabilidad"
        '
        'txt_IVA
        '
        Me.txt_IVA.Location = New System.Drawing.Point(155, 50)
        Me.txt_IVA.Name = "txt_IVA"
        Me.txt_IVA.Size = New System.Drawing.Size(100, 20)
        Me.txt_IVA.TabIndex = 8
        '
        'txt_CONTA_INI
        '
        Me.txt_CONTA_INI.Location = New System.Drawing.Point(379, 24)
        Me.txt_CONTA_INI.Name = "txt_CONTA_INI"
        Me.txt_CONTA_INI.Size = New System.Drawing.Size(100, 20)
        Me.txt_CONTA_INI.TabIndex = 7
        '
        'txt_GTOSGRALES
        '
        Me.txt_GTOSGRALES.Location = New System.Drawing.Point(155, 24)
        Me.txt_GTOSGRALES.Name = "txt_GTOSGRALES"
        Me.txt_GTOSGRALES.Size = New System.Drawing.Size(100, 20)
        Me.txt_GTOSGRALES.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(283, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Año Proceso"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "% Gastos Generales"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "% I.V.A."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_ID29_final)
        Me.GroupBox3.Controls.Add(Me.txt_ID29_inicio)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txt_ID28_final)
        Me.GroupBox3.Controls.Add(Me.txt_ID28_inicio)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txt_ID32_final)
        Me.GroupBox3.Controls.Add(Me.txt_ID27_final)
        Me.GroupBox3.Controls.Add(Me.txt_ID26_final)
        Me.GroupBox3.Controls.Add(Me.txt_ID32_inicio)
        Me.GroupBox3.Controls.Add(Me.txt_ID27_inicio)
        Me.GroupBox3.Controls.Add(Me.txt_ID26_inicio)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 224)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(525, 141)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Parámetros Control de Precios de Hechura Plantas, Formato debe ser Mes Día (MMDD)" &
    ""
        '
        'txt_ID29_final
        '
        Me.txt_ID29_final.Location = New System.Drawing.Point(212, 110)
        Me.txt_ID29_final.Name = "txt_ID29_final"
        Me.txt_ID29_final.Size = New System.Drawing.Size(44, 20)
        Me.txt_ID29_final.TabIndex = 24
        '
        'txt_ID29_inicio
        '
        Me.txt_ID29_inicio.Location = New System.Drawing.Point(161, 110)
        Me.txt_ID29_inicio.Name = "txt_ID29_inicio"
        Me.txt_ID29_inicio.Size = New System.Drawing.Size(44, 20)
        Me.txt_ID29_inicio.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Invierno"
        '
        'txt_ID28_final
        '
        Me.txt_ID28_final.Location = New System.Drawing.Point(212, 81)
        Me.txt_ID28_final.Name = "txt_ID28_final"
        Me.txt_ID28_final.Size = New System.Drawing.Size(44, 20)
        Me.txt_ID28_final.TabIndex = 21
        '
        'txt_ID28_inicio
        '
        Me.txt_ID28_inicio.Location = New System.Drawing.Point(161, 81)
        Me.txt_ID28_inicio.Name = "txt_ID28_inicio"
        Me.txt_ID28_inicio.Size = New System.Drawing.Size(44, 20)
        Me.txt_ID28_inicio.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Otoño"
        '
        'txt_ID32_final
        '
        Me.txt_ID32_final.Location = New System.Drawing.Point(314, 50)
        Me.txt_ID32_final.Name = "txt_ID32_final"
        Me.txt_ID32_final.Size = New System.Drawing.Size(44, 20)
        Me.txt_ID32_final.TabIndex = 18
        '
        'txt_ID27_final
        '
        Me.txt_ID27_final.Location = New System.Drawing.Point(212, 50)
        Me.txt_ID27_final.Name = "txt_ID27_final"
        Me.txt_ID27_final.Size = New System.Drawing.Size(44, 20)
        Me.txt_ID27_final.TabIndex = 17
        '
        'txt_ID26_final
        '
        Me.txt_ID26_final.Location = New System.Drawing.Point(212, 23)
        Me.txt_ID26_final.Name = "txt_ID26_final"
        Me.txt_ID26_final.Size = New System.Drawing.Size(44, 20)
        Me.txt_ID26_final.TabIndex = 16
        '
        'txt_ID32_inicio
        '
        Me.txt_ID32_inicio.Location = New System.Drawing.Point(267, 50)
        Me.txt_ID32_inicio.Name = "txt_ID32_inicio"
        Me.txt_ID32_inicio.Size = New System.Drawing.Size(42, 20)
        Me.txt_ID32_inicio.TabIndex = 9
        '
        'txt_ID27_inicio
        '
        Me.txt_ID27_inicio.Location = New System.Drawing.Point(161, 50)
        Me.txt_ID27_inicio.Name = "txt_ID27_inicio"
        Me.txt_ID27_inicio.Size = New System.Drawing.Size(44, 20)
        Me.txt_ID27_inicio.TabIndex = 10
        '
        'txt_ID26_inicio
        '
        Me.txt_ID26_inicio.Location = New System.Drawing.Point(161, 23)
        Me.txt_ID26_inicio.Name = "txt_ID26_inicio"
        Me.txt_ID26_inicio.Size = New System.Drawing.Size(44, 20)
        Me.txt_ID26_inicio.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Primavera"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Verano"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(60, 613)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 35)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Actualizar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_MaximoPedido)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 371)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(525, 51)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Máxima Cantidad de Pedidos Diarios"
        '
        'txt_MaximoPedido
        '
        Me.txt_MaximoPedido.Location = New System.Drawing.Point(161, 18)
        Me.txt_MaximoPedido.Name = "txt_MaximoPedido"
        Me.txt_MaximoPedido.Size = New System.Drawing.Size(44, 20)
        Me.txt_MaximoPedido.TabIndex = 25
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtNotasDetalleVenta)
        Me.GroupBox5.Location = New System.Drawing.Point(11, 426)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(525, 110)
        Me.GroupBox5.TabIndex = 26
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Notas en Detalle de Venta"
        '
        'txtNotasDetalleVenta
        '
        Me.txtNotasDetalleVenta.Location = New System.Drawing.Point(5, 18)
        Me.txtNotasDetalleVenta.Multiline = True
        Me.txtNotasDetalleVenta.Name = "txtNotasDetalleVenta"
        Me.txtNotasDetalleVenta.Size = New System.Drawing.Size(515, 87)
        Me.txtNotasDetalleVenta.TabIndex = 25
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = Global.GestionVivero.My.Resources.Resources.Close
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(354, 611)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 35)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Cancelar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 548)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Contraseña Prórroga:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 572)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Contraseña Desbloqueo:"
        '
        'txtProrroga
        '
        Me.txtProrroga.Location = New System.Drawing.Point(151, 544)
        Me.txtProrroga.Name = "txtProrroga"
        Me.txtProrroga.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtProrroga.Size = New System.Drawing.Size(147, 20)
        Me.txtProrroga.TabIndex = 30
        '
        'txtDesbloqueo
        '
        Me.txtDesbloqueo.Location = New System.Drawing.Point(151, 568)
        Me.txtDesbloqueo.Name = "txtDesbloqueo"
        Me.txtDesbloqueo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtDesbloqueo.Size = New System.Drawing.Size(147, 20)
        Me.txtDesbloqueo.TabIndex = 32
        '
        'ParametrosSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(551, 650)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtDesbloqueo)
        Me.Controls.Add(Me.txtProrroga)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ParametrosSistema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parametros del Sistema"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_FA As System.Windows.Forms.TextBox
    Friend WithEvents txt_BE As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_IVA As System.Windows.Forms.TextBox
    Friend WithEvents txt_CONTA_INI As System.Windows.Forms.TextBox
    Friend WithEvents txt_GTOSGRALES As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_ID32_inicio As System.Windows.Forms.TextBox
    Friend WithEvents txt_ID27_inicio As System.Windows.Forms.TextBox
    Friend WithEvents txt_ID26_inicio As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_ID26_final As TextBox
    Friend WithEvents txt_ID27_final As TextBox
    Friend WithEvents txt_ID29_final As TextBox
    Friend WithEvents txt_ID29_inicio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_ID28_final As TextBox
    Friend WithEvents txt_ID28_inicio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_ID32_final As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txt_MaximoPedido As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtNotasDetalleVenta As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtProrroga As TextBox
    Friend WithEvents txtDesbloqueo As TextBox
End Class
