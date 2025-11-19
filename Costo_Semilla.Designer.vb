<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Costo_Semilla
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
        Me.Venta = New System.Windows.Forms.GroupBox()
        Me.txtHoraActualizacion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUltimaActualizacion = New System.Windows.Forms.TextBox()
        Me.txt_TotalCompras = New System.Windows.Forms.TextBox()
        Me.txt_TotalConsumo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_MargenPCT = New System.Windows.Forms.TextBox()
        Me.txt_Germinacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Stock = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_PrecioCompraSemilla = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_PVentaFinal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_PCostoNeto = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_Variedad = New System.Windows.Forms.ComboBox()
        Me.cmb_Familia_Prod = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPrecioVentaIVA = New System.Windows.Forms.TextBox()
        Me.Venta.SuspendLayout()
        Me.SuspendLayout()
        '
        'Venta
        '
        Me.Venta.Controls.Add(Me.txtPrecioVentaIVA)
        Me.Venta.Controls.Add(Me.Label11)
        Me.Venta.Controls.Add(Me.txtHoraActualizacion)
        Me.Venta.Controls.Add(Me.Label7)
        Me.Venta.Controls.Add(Me.txtUltimaActualizacion)
        Me.Venta.Controls.Add(Me.txt_TotalCompras)
        Me.Venta.Controls.Add(Me.txt_TotalConsumo)
        Me.Venta.Controls.Add(Me.Label10)
        Me.Venta.Controls.Add(Me.Label8)
        Me.Venta.Controls.Add(Me.txt_MargenPCT)
        Me.Venta.Controls.Add(Me.txt_Germinacion)
        Me.Venta.Controls.Add(Me.Label6)
        Me.Venta.Controls.Add(Me.txt_Stock)
        Me.Venta.Controls.Add(Me.Label5)
        Me.Venta.Controls.Add(Me.txt_PrecioCompraSemilla)
        Me.Venta.Controls.Add(Me.Label4)
        Me.Venta.Controls.Add(Me.txt_PVentaFinal)
        Me.Venta.Controls.Add(Me.Label3)
        Me.Venta.Controls.Add(Me.Label2)
        Me.Venta.Controls.Add(Me.Label1)
        Me.Venta.Controls.Add(Me.txt_PCostoNeto)
        Me.Venta.Controls.Add(Me.Label23)
        Me.Venta.Controls.Add(Me.Label9)
        Me.Venta.Controls.Add(Me.cmb_Variedad)
        Me.Venta.Controls.Add(Me.cmb_Familia_Prod)
        Me.Venta.Location = New System.Drawing.Point(5, 30)
        Me.Venta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Venta.Name = "Venta"
        Me.Venta.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Venta.Size = New System.Drawing.Size(623, 349)
        Me.Venta.TabIndex = 4
        Me.Venta.TabStop = False
        '
        'txtHoraActualizacion
        '
        Me.txtHoraActualizacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtHoraActualizacion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraActualizacion.Location = New System.Drawing.Point(543, 106)
        Me.txtHoraActualizacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHoraActualizacion.Name = "txtHoraActualizacion"
        Me.txtHoraActualizacion.ReadOnly = True
        Me.txtHoraActualizacion.Size = New System.Drawing.Size(71, 22)
        Me.txtHoraActualizacion.TabIndex = 76
        Me.txtHoraActualizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(357, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 13)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Ultima actualización"
        '
        'txtUltimaActualizacion
        '
        Me.txtUltimaActualizacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtUltimaActualizacion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUltimaActualizacion.Location = New System.Drawing.Point(461, 106)
        Me.txtUltimaActualizacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUltimaActualizacion.Name = "txtUltimaActualizacion"
        Me.txtUltimaActualizacion.ReadOnly = True
        Me.txtUltimaActualizacion.Size = New System.Drawing.Size(71, 22)
        Me.txtUltimaActualizacion.TabIndex = 74
        Me.txtUltimaActualizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_TotalCompras
        '
        Me.txt_TotalCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_TotalCompras.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalCompras.Location = New System.Drawing.Point(461, 307)
        Me.txt_TotalCompras.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_TotalCompras.Name = "txt_TotalCompras"
        Me.txt_TotalCompras.ReadOnly = True
        Me.txt_TotalCompras.Size = New System.Drawing.Size(71, 22)
        Me.txt_TotalCompras.TabIndex = 73
        Me.txt_TotalCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_TotalConsumo
        '
        Me.txt_TotalConsumo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_TotalConsumo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalConsumo.Location = New System.Drawing.Point(461, 274)
        Me.txt_TotalConsumo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_TotalConsumo.Name = "txt_TotalConsumo"
        Me.txt_TotalConsumo.ReadOnly = True
        Me.txt_TotalConsumo.Size = New System.Drawing.Size(71, 22)
        Me.txt_TotalConsumo.TabIndex = 72
        Me.txt_TotalConsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(377, 312)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Total Compras"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(377, 283)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Total Consumo"
        '
        'txt_MargenPCT
        '
        Me.txt_MargenPCT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_MargenPCT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MargenPCT.Location = New System.Drawing.Point(256, 208)
        Me.txt_MargenPCT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_MargenPCT.Name = "txt_MargenPCT"
        Me.txt_MargenPCT.ReadOnly = True
        Me.txt_MargenPCT.Size = New System.Drawing.Size(71, 22)
        Me.txt_MargenPCT.TabIndex = 67
        Me.txt_MargenPCT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Germinacion
        '
        Me.txt_Germinacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_Germinacion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Germinacion.Location = New System.Drawing.Point(256, 134)
        Me.txt_Germinacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Germinacion.Name = "txt_Germinacion"
        Me.txt_Germinacion.Size = New System.Drawing.Size(71, 22)
        Me.txt_Germinacion.TabIndex = 66
        Me.txt_Germinacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "% Rendimiento"
        '
        'txt_Stock
        '
        Me.txt_Stock.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_Stock.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Stock.Location = New System.Drawing.Point(256, 274)
        Me.txt_Stock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Stock.Name = "txt_Stock"
        Me.txt_Stock.ReadOnly = True
        Me.txt_Stock.Size = New System.Drawing.Size(71, 22)
        Me.txt_Stock.TabIndex = 63
        Me.txt_Stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Stock Producto"
        '
        'txt_PrecioCompraSemilla
        '
        Me.txt_PrecioCompraSemilla.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_PrecioCompraSemilla.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PrecioCompraSemilla.Location = New System.Drawing.Point(256, 106)
        Me.txt_PrecioCompraSemilla.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_PrecioCompraSemilla.Name = "txt_PrecioCompraSemilla"
        Me.txt_PrecioCompraSemilla.Size = New System.Drawing.Size(71, 22)
        Me.txt_PrecioCompraSemilla.TabIndex = 61
        Me.txt_PrecioCompraSemilla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Precio Compra/Lista Producto"
        '
        'txt_PVentaFinal
        '
        Me.txt_PVentaFinal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_PVentaFinal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PVentaFinal.Location = New System.Drawing.Point(256, 242)
        Me.txt_PVentaFinal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_PVentaFinal.Name = "txt_PVentaFinal"
        Me.txt_PVentaFinal.ReadOnly = True
        Me.txt_PVentaFinal.Size = New System.Drawing.Size(71, 22)
        Me.txt_PVentaFinal.TabIndex = 59
        Me.txt_PVentaFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Precio Venta Neto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "% Margen Utilidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Precio Costo Neto"
        '
        'txt_PCostoNeto
        '
        Me.txt_PCostoNeto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_PCostoNeto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PCostoNeto.Location = New System.Drawing.Point(256, 178)
        Me.txt_PCostoNeto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_PCostoNeto.Name = "txt_PCostoNeto"
        Me.txt_PCostoNeto.ReadOnly = True
        Me.txt_PCostoNeto.Size = New System.Drawing.Size(71, 22)
        Me.txt_PCostoNeto.TabIndex = 54
        Me.txt_PCostoNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(11, 56)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(49, 13)
        Me.Label23.TabIndex = 53
        Me.Label23.Text = "Variedad"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Especie"
        '
        'cmb_Variedad
        '
        Me.cmb_Variedad.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_Variedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Variedad.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Variedad.ForeColor = System.Drawing.Color.White
        Me.cmb_Variedad.FormattingEnabled = True
        Me.cmb_Variedad.Location = New System.Drawing.Point(14, 73)
        Me.cmb_Variedad.Name = "cmb_Variedad"
        Me.cmb_Variedad.Size = New System.Drawing.Size(313, 23)
        Me.cmb_Variedad.TabIndex = 52
        '
        'cmb_Familia_Prod
        '
        Me.cmb_Familia_Prod.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_Familia_Prod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Familia_Prod.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Familia_Prod.ForeColor = System.Drawing.Color.White
        Me.cmb_Familia_Prod.FormattingEnabled = True
        Me.cmb_Familia_Prod.Location = New System.Drawing.Point(14, 30)
        Me.cmb_Familia_Prod.Name = "cmb_Familia_Prod"
        Me.cmb_Familia_Prod.Size = New System.Drawing.Size(313, 23)
        Me.cmb_Familia_Prod.TabIndex = 51
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(84, 386)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 30)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Grabar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(405, 386)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 30)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(246, 386)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(61, 30)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(343, 247)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 13)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "Precio Venta Con IVA"
        '
        'txtPrecioVentaIVA
        '
        Me.txtPrecioVentaIVA.BackColor = System.Drawing.Color.Blue
        Me.txtPrecioVentaIVA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioVentaIVA.ForeColor = System.Drawing.Color.White
        Me.txtPrecioVentaIVA.Location = New System.Drawing.Point(461, 242)
        Me.txtPrecioVentaIVA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrecioVentaIVA.Name = "txtPrecioVentaIVA"
        Me.txtPrecioVentaIVA.Size = New System.Drawing.Size(71, 22)
        Me.txtPrecioVentaIVA.TabIndex = 78
        Me.txtPrecioVentaIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Costo_Semilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 428)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Venta)
        Me.Name = "Costo_Semilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Precios Productos"
        Me.Venta.ResumeLayout(False)
        Me.Venta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Venta As System.Windows.Forms.GroupBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmb_Variedad As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Familia_Prod As System.Windows.Forms.ComboBox
    Friend WithEvents txt_PCostoNeto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_PVentaFinal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Stock As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_PrecioCompraSemilla As System.Windows.Forms.TextBox
    Friend WithEvents txt_Germinacion As System.Windows.Forms.TextBox
    Friend WithEvents txt_MargenPCT As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtUltimaActualizacion As System.Windows.Forms.TextBox
    Friend WithEvents txtHoraActualizacion As System.Windows.Forms.TextBox
    Friend WithEvents txt_TotalCompras As System.Windows.Forms.TextBox
    Friend WithEvents txt_TotalConsumo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPrecioVentaIVA As TextBox
    Friend WithEvents Label11 As Label
End Class
