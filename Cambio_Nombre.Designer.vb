<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cambio_Nombre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cambio_Nombre))
        Me.cmb_Guia = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.txt_NombreCliente = New System.Windows.Forms.MaskedTextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txt_RUT_CLI = New System.Windows.Forms.MaskedTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.Label27 = New System.Windows.Forms.Label
        Me.txt_clientebuscar = New System.Windows.Forms.TextBox
        Me.txt_NuevoCliente = New System.Windows.Forms.MaskedTextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.txt_NuevoRUT = New System.Windows.Forms.MaskedTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_NuevoID = New System.Windows.Forms.MaskedTextBox
        Me.SuspendLayout()
        '
        'cmb_Guia
        '
        Me.cmb_Guia.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_Guia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Guia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Guia.ForeColor = System.Drawing.Color.Navy
        Me.cmb_Guia.FormattingEnabled = True
        Me.cmb_Guia.Location = New System.Drawing.Point(252, 16)
        Me.cmb_Guia.Name = "cmb_Guia"
        Me.cmb_Guia.Size = New System.Drawing.Size(86, 23)
        Me.cmb_Guia.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(191, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 13)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Guía N°"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(129, 67)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(44, 13)
        Me.Label25.TabIndex = 18
        Me.Label25.Text = "Nombre"
        '
        'txt_NombreCliente
        '
        Me.txt_NombreCliente.BackColor = System.Drawing.Color.Navy
        Me.txt_NombreCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NombreCliente.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_NombreCliente.Location = New System.Drawing.Point(123, 84)
        Me.txt_NombreCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_NombreCliente.Name = "txt_NombreCliente"
        Me.txt_NombreCliente.Size = New System.Drawing.Size(311, 22)
        Me.txt_NombreCliente.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(32, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "R.U.T. Cliente"
        '
        'txt_RUT_CLI
        '
        Me.txt_RUT_CLI.BackColor = System.Drawing.Color.Navy
        Me.txt_RUT_CLI.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RUT_CLI.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_RUT_CLI.HidePromptOnLeave = True
        Me.txt_RUT_CLI.Location = New System.Drawing.Point(34, 85)
        Me.txt_RUT_CLI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_RUT_CLI.Name = "txt_RUT_CLI"
        Me.txt_RUT_CLI.ReadOnly = True
        Me.txt_RUT_CLI.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_RUT_CLI.Size = New System.Drawing.Size(83, 22)
        Me.txt_RUT_CLI.TabIndex = 17
        Me.txt_RUT_CLI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Cambiar por:"
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button6.Location = New System.Drawing.Point(268, 207)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(66, 23)
        Me.Button6.TabIndex = 25
        Me.Button6.Text = "Buscar"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(93, 192)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(124, 13)
        Me.Label27.TabIndex = 23
        Me.Label27.Text = "Ingrese nombre a buscar"
        '
        'txt_clientebuscar
        '
        Me.txt_clientebuscar.BackColor = System.Drawing.SystemColors.Window
        Me.txt_clientebuscar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clientebuscar.ForeColor = System.Drawing.Color.Navy
        Me.txt_clientebuscar.Location = New System.Drawing.Point(96, 209)
        Me.txt_clientebuscar.Name = "txt_clientebuscar"
        Me.txt_clientebuscar.Size = New System.Drawing.Size(166, 21)
        Me.txt_clientebuscar.TabIndex = 24
        '
        'txt_NuevoCliente
        '
        Me.txt_NuevoCliente.BackColor = System.Drawing.Color.Navy
        Me.txt_NuevoCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NuevoCliente.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_NuevoCliente.Location = New System.Drawing.Point(123, 261)
        Me.txt_NuevoCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_NuevoCliente.Name = "txt_NuevoCliente"
        Me.txt_NuevoCliente.Size = New System.Drawing.Size(311, 22)
        Me.txt_NuevoCliente.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(108, 388)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Aceptar Cambios"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(340, 388)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txt_NuevoRUT
        '
        Me.txt_NuevoRUT.BackColor = System.Drawing.Color.Navy
        Me.txt_NuevoRUT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NuevoRUT.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_NuevoRUT.HidePromptOnLeave = True
        Me.txt_NuevoRUT.Location = New System.Drawing.Point(34, 261)
        Me.txt_NuevoRUT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_NuevoRUT.Name = "txt_NuevoRUT"
        Me.txt_NuevoRUT.ReadOnly = True
        Me.txt_NuevoRUT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_NuevoRUT.Size = New System.Drawing.Size(83, 22)
        Me.txt_NuevoRUT.TabIndex = 29
        Me.txt_NuevoRUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "R.U.T. Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(442, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "ID Cliente"
        '
        'txt_NuevoID
        '
        Me.txt_NuevoID.BackColor = System.Drawing.Color.Navy
        Me.txt_NuevoID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NuevoID.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_NuevoID.HidePromptOnLeave = True
        Me.txt_NuevoID.Location = New System.Drawing.Point(440, 261)
        Me.txt_NuevoID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_NuevoID.Name = "txt_NuevoID"
        Me.txt_NuevoID.ReadOnly = True
        Me.txt_NuevoID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_NuevoID.Size = New System.Drawing.Size(83, 22)
        Me.txt_NuevoID.TabIndex = 33
        Me.txt_NuevoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Cambio_Nombre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(529, 437)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_NuevoID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_NuevoRUT)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_NuevoCliente)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txt_clientebuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txt_NombreCliente)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_RUT_CLI)
        Me.Controls.Add(Me.cmb_Guia)
        Me.Controls.Add(Me.Label18)
        Me.Name = "Cambio_Nombre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Nombre"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_Guia As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txt_NombreCliente As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_RUT_CLI As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txt_clientebuscar As System.Windows.Forms.TextBox
    Friend WithEvents txt_NuevoCliente As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txt_NuevoRUT As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_NuevoID As System.Windows.Forms.MaskedTextBox
End Class
