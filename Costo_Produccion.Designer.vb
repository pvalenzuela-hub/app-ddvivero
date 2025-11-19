<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Costo_Produccion
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
        Me.Venta = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_DESCRIP = New System.Windows.Forms.TextBox
        Me.txt_PVentaFinal = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_MargenPCT = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_PCostoNeto = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmb_Familia_Prod = New System.Windows.Forms.ComboBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Venta.SuspendLayout()
        Me.SuspendLayout()
        '
        'Venta
        '
        Me.Venta.Controls.Add(Me.Label4)
        Me.Venta.Controls.Add(Me.txt_DESCRIP)
        Me.Venta.Controls.Add(Me.txt_PVentaFinal)
        Me.Venta.Controls.Add(Me.Label3)
        Me.Venta.Controls.Add(Me.txt_MargenPCT)
        Me.Venta.Controls.Add(Me.Label2)
        Me.Venta.Controls.Add(Me.Label1)
        Me.Venta.Controls.Add(Me.txt_PCostoNeto)
        Me.Venta.Location = New System.Drawing.Point(26, 35)
        Me.Venta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Venta.Name = "Venta"
        Me.Venta.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Venta.Size = New System.Drawing.Size(529, 213)
        Me.Venta.TabIndex = 0
        Me.Venta.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Descripción"
        '
        'txt_DESCRIP
        '
        Me.txt_DESCRIP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_DESCRIP.Location = New System.Drawing.Point(196, 34)
        Me.txt_DESCRIP.Name = "txt_DESCRIP"
        Me.txt_DESCRIP.ReadOnly = True
        Me.txt_DESCRIP.Size = New System.Drawing.Size(326, 20)
        Me.txt_DESCRIP.TabIndex = 0
        '
        'txt_PVentaFinal
        '
        Me.txt_PVentaFinal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_PVentaFinal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PVentaFinal.Location = New System.Drawing.Point(196, 140)
        Me.txt_PVentaFinal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_PVentaFinal.Name = "txt_PVentaFinal"
        Me.txt_PVentaFinal.ReadOnly = True
        Me.txt_PVentaFinal.Size = New System.Drawing.Size(71, 22)
        Me.txt_PVentaFinal.TabIndex = 3
        Me.txt_PVentaFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Precio Venta Final Neto"
        '
        'txt_MargenPCT
        '
        Me.txt_MargenPCT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_MargenPCT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MargenPCT.Location = New System.Drawing.Point(196, 107)
        Me.txt_MargenPCT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_MargenPCT.Name = "txt_MargenPCT"
        Me.txt_MargenPCT.Size = New System.Drawing.Size(71, 22)
        Me.txt_MargenPCT.TabIndex = 2
        Me.txt_MargenPCT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "% Margen Utilidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Precio Costo Neto"
        '
        'txt_PCostoNeto
        '
        Me.txt_PCostoNeto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_PCostoNeto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PCostoNeto.Location = New System.Drawing.Point(196, 74)
        Me.txt_PCostoNeto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_PCostoNeto.Name = "txt_PCostoNeto"
        Me.txt_PCostoNeto.Size = New System.Drawing.Size(71, 22)
        Me.txt_PCostoNeto.TabIndex = 1
        Me.txt_PCostoNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(58, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Seleccionar Familia de Producto"
        '
        'cmb_Familia_Prod
        '
        Me.cmb_Familia_Prod.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_Familia_Prod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Familia_Prod.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Familia_Prod.ForeColor = System.Drawing.Color.White
        Me.cmb_Familia_Prod.FormattingEnabled = True
        Me.cmb_Familia_Prod.Location = New System.Drawing.Point(222, 9)
        Me.cmb_Familia_Prod.Name = "cmb_Familia_Prod"
        Me.cmb_Familia_Prod.Size = New System.Drawing.Size(326, 23)
        Me.cmb_Familia_Prod.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(332, 275)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(61, 30)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(459, 275)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 30)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(193, 275)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 30)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Grabar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(51, 275)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 30)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Nuevo"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Costo_Produccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 315)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Venta)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmb_Familia_Prod)
        Me.Name = "Costo_Produccion"
        Me.Text = "Hechura de Plantas"
        Me.Venta.ResumeLayout(False)
        Me.Venta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Venta As System.Windows.Forms.GroupBox
    Friend WithEvents txt_PVentaFinal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_MargenPCT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_PCostoNeto As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmb_Familia_Prod As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_DESCRIP As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
