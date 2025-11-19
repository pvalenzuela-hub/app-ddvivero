<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejemplo
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
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txt_SaldoPedido = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txt_Abono = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txt_Descuento = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txt_CostoFlete = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txt_TotalPedido = New System.Windows.Forms.TextBox
        Me.txt_FormaEntrega = New System.Windows.Forms.MaskedTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_FechaEntregaPedido = New System.Windows.Forms.MaskedTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txt_Vendedor = New System.Windows.Forms.MaskedTextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txt_DIGRUT = New System.Windows.Forms.MaskedTextBox
        Me.txt_RUT_CLI = New System.Windows.Forms.MaskedTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_Cliente = New System.Windows.Forms.MaskedTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_FECHA_PEDIDO = New System.Windows.Forms.MaskedTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_texto = New System.Windows.Forms.TextBox
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(624, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txt_SaldoPedido)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.txt_Abono)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.txt_Descuento)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.txt_CostoFlete)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.txt_TotalPedido)
        Me.GroupBox5.Controls.Add(Me.txt_FormaEntrega)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.txt_FechaEntregaPedido)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.txt_Vendedor)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.txt_DIGRUT)
        Me.GroupBox5.Controls.Add(Me.txt_RUT_CLI)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.txt_Cliente)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.txt_FECHA_PEDIDO)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(593, 162)
        Me.GroupBox5.TabIndex = 42
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Identificación del Cliente"
        '
        'txt_SaldoPedido
        '
        Me.txt_SaldoPedido.BackColor = System.Drawing.Color.White
        Me.txt_SaldoPedido.CausesValidation = False
        Me.txt_SaldoPedido.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SaldoPedido.ForeColor = System.Drawing.Color.Black
        Me.txt_SaldoPedido.Location = New System.Drawing.Point(449, 128)
        Me.txt_SaldoPedido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_SaldoPedido.Name = "txt_SaldoPedido"
        Me.txt_SaldoPedido.ReadOnly = True
        Me.txt_SaldoPedido.Size = New System.Drawing.Size(79, 20)
        Me.txt_SaldoPedido.TabIndex = 13
        Me.txt_SaldoPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(434, 111)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(116, 13)
        Me.Label19.TabIndex = 82
        Me.Label19.Text = "SALDO PENDIENTE"
        '
        'txt_Abono
        '
        Me.txt_Abono.BackColor = System.Drawing.Color.White
        Me.txt_Abono.CausesValidation = False
        Me.txt_Abono.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Abono.ForeColor = System.Drawing.Color.Black
        Me.txt_Abono.Location = New System.Drawing.Point(328, 128)
        Me.txt_Abono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Abono.Name = "txt_Abono"
        Me.txt_Abono.ReadOnly = True
        Me.txt_Abono.Size = New System.Drawing.Size(79, 20)
        Me.txt_Abono.TabIndex = 12
        Me.txt_Abono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(351, 111)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 13)
        Me.Label18.TabIndex = 80
        Me.Label18.Text = "ABONO"
        '
        'txt_Descuento
        '
        Me.txt_Descuento.BackColor = System.Drawing.Color.White
        Me.txt_Descuento.CausesValidation = False
        Me.txt_Descuento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Descuento.ForeColor = System.Drawing.Color.Black
        Me.txt_Descuento.Location = New System.Drawing.Point(228, 128)
        Me.txt_Descuento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Descuento.Name = "txt_Descuento"
        Me.txt_Descuento.ReadOnly = True
        Me.txt_Descuento.Size = New System.Drawing.Size(79, 20)
        Me.txt_Descuento.TabIndex = 11
        Me.txt_Descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(229, 111)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 13)
        Me.Label17.TabIndex = 78
        Me.Label17.Text = "DESCUENTO"
        '
        'txt_CostoFlete
        '
        Me.txt_CostoFlete.BackColor = System.Drawing.Color.White
        Me.txt_CostoFlete.CausesValidation = False
        Me.txt_CostoFlete.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CostoFlete.ForeColor = System.Drawing.Color.Black
        Me.txt_CostoFlete.Location = New System.Drawing.Point(125, 128)
        Me.txt_CostoFlete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_CostoFlete.Name = "txt_CostoFlete"
        Me.txt_CostoFlete.ReadOnly = True
        Me.txt_CostoFlete.Size = New System.Drawing.Size(79, 20)
        Me.txt_CostoFlete.TabIndex = 10
        Me.txt_CostoFlete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(146, 111)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 76
        Me.Label14.Text = "FLETE"
        '
        'txt_TotalPedido
        '
        Me.txt_TotalPedido.BackColor = System.Drawing.Color.White
        Me.txt_TotalPedido.CausesValidation = False
        Me.txt_TotalPedido.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalPedido.ForeColor = System.Drawing.Color.Black
        Me.txt_TotalPedido.Location = New System.Drawing.Point(22, 128)
        Me.txt_TotalPedido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_TotalPedido.Name = "txt_TotalPedido"
        Me.txt_TotalPedido.ReadOnly = True
        Me.txt_TotalPedido.Size = New System.Drawing.Size(79, 20)
        Me.txt_TotalPedido.TabIndex = 9
        Me.txt_TotalPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_FormaEntrega
        '
        Me.txt_FormaEntrega.BackColor = System.Drawing.Color.White
        Me.txt_FormaEntrega.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FormaEntrega.ForeColor = System.Drawing.Color.Black
        Me.txt_FormaEntrega.Location = New System.Drawing.Point(354, 71)
        Me.txt_FormaEntrega.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_FormaEntrega.Name = "txt_FormaEntrega"
        Me.txt_FormaEntrega.ReadOnly = True
        Me.txt_FormaEntrega.Size = New System.Drawing.Size(228, 20)
        Me.txt_FormaEntrega.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(230, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 13)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "FORMA DE ENTREGA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "TOTAL PEDIDO"
        '
        'txt_FechaEntregaPedido
        '
        Me.txt_FechaEntregaPedido.BackColor = System.Drawing.Color.White
        Me.txt_FechaEntregaPedido.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FechaEntregaPedido.ForeColor = System.Drawing.Color.Black
        Me.txt_FechaEntregaPedido.Location = New System.Drawing.Point(124, 71)
        Me.txt_FechaEntregaPedido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_FechaEntregaPedido.Mask = "00/00/0000"
        Me.txt_FechaEntregaPedido.Name = "txt_FechaEntregaPedido"
        Me.txt_FechaEntregaPedido.ReadOnly = True
        Me.txt_FechaEntregaPedido.Size = New System.Drawing.Size(74, 20)
        Me.txt_FechaEntregaPedido.TabIndex = 7
        Me.txt_FechaEntregaPedido.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "FECHA ENTREGA"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(434, 46)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 69
        Me.Label16.Text = "FECHA"
        '
        'txt_Vendedor
        '
        Me.txt_Vendedor.BackColor = System.Drawing.Color.White
        Me.txt_Vendedor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Vendedor.ForeColor = System.Drawing.Color.Black
        Me.txt_Vendedor.Location = New System.Drawing.Point(124, 41)
        Me.txt_Vendedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Vendedor.Name = "txt_Vendedor"
        Me.txt_Vendedor.ReadOnly = True
        Me.txt_Vendedor.Size = New System.Drawing.Size(295, 20)
        Me.txt_Vendedor.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(434, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 13)
        Me.Label15.TabIndex = 67
        Me.Label15.Text = "RUT"
        '
        'txt_DIGRUT
        '
        Me.txt_DIGRUT.BackColor = System.Drawing.Color.White
        Me.txt_DIGRUT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DIGRUT.ForeColor = System.Drawing.Color.Black
        Me.txt_DIGRUT.HidePromptOnLeave = True
        Me.txt_DIGRUT.Location = New System.Drawing.Point(560, 15)
        Me.txt_DIGRUT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_DIGRUT.Mask = "A"
        Me.txt_DIGRUT.Name = "txt_DIGRUT"
        Me.txt_DIGRUT.ReadOnly = True
        Me.txt_DIGRUT.Size = New System.Drawing.Size(22, 20)
        Me.txt_DIGRUT.TabIndex = 4
        '
        'txt_RUT_CLI
        '
        Me.txt_RUT_CLI.BackColor = System.Drawing.Color.White
        Me.txt_RUT_CLI.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RUT_CLI.ForeColor = System.Drawing.Color.Black
        Me.txt_RUT_CLI.HidePromptOnLeave = True
        Me.txt_RUT_CLI.Location = New System.Drawing.Point(485, 15)
        Me.txt_RUT_CLI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_RUT_CLI.Mask = "99999999999"
        Me.txt_RUT_CLI.Name = "txt_RUT_CLI"
        Me.txt_RUT_CLI.ReadOnly = True
        Me.txt_RUT_CLI.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_RUT_CLI.Size = New System.Drawing.Size(71, 20)
        Me.txt_RUT_CLI.TabIndex = 3
        Me.txt_RUT_CLI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "CLIENTE"
        '
        'txt_Cliente
        '
        Me.txt_Cliente.BackColor = System.Drawing.Color.White
        Me.txt_Cliente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cliente.ForeColor = System.Drawing.Color.Black
        Me.txt_Cliente.Location = New System.Drawing.Point(124, 15)
        Me.txt_Cliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Cliente.Name = "txt_Cliente"
        Me.txt_Cliente.ReadOnly = True
        Me.txt_Cliente.Size = New System.Drawing.Size(295, 20)
        Me.txt_Cliente.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 13)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "ATENDIDO POR"
        '
        'txt_FECHA_PEDIDO
        '
        Me.txt_FECHA_PEDIDO.BackColor = System.Drawing.Color.White
        Me.txt_FECHA_PEDIDO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FECHA_PEDIDO.ForeColor = System.Drawing.Color.Black
        Me.txt_FECHA_PEDIDO.Location = New System.Drawing.Point(508, 41)
        Me.txt_FECHA_PEDIDO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_FECHA_PEDIDO.Mask = "00/00/0000"
        Me.txt_FECHA_PEDIDO.Name = "txt_FECHA_PEDIDO"
        Me.txt_FECHA_PEDIDO.ReadOnly = True
        Me.txt_FECHA_PEDIDO.Size = New System.Drawing.Size(74, 20)
        Me.txt_FECHA_PEDIDO.TabIndex = 6
        Me.txt_FECHA_PEDIDO.ValidatingType = GetType(Date)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(464, 429)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 14)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "FIRMA CLIENTE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(54, 429)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 14)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "FIRMA DESPACHADOR"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 416)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(193, 13)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = ".............................................................."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(410, 416)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = ".............................................................."
        '
        'txt_texto
        '
        Me.txt_texto.Location = New System.Drawing.Point(34, 222)
        Me.txt_texto.Name = "txt_texto"
        Me.txt_texto.Size = New System.Drawing.Size(506, 20)
        Me.txt_texto.TabIndex = 60
        '
        'Ejemplo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(624, 462)
        Me.Controls.Add(Me.txt_texto)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Ejemplo"
        Me.Text = "Ejemplo"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_SaldoPedido As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_Abono As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_Descuento As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_CostoFlete As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_TotalPedido As System.Windows.Forms.TextBox
    Friend WithEvents txt_FormaEntrega As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_FechaEntregaPedido As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_Vendedor As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_DIGRUT As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_RUT_CLI As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_Cliente As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_FECHA_PEDIDO As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_texto As System.Windows.Forms.TextBox
End Class
