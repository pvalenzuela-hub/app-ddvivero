<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Impresion_Guia
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_NumGuia = New System.Windows.Forms.MaskedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_Band_Usadas = New System.Windows.Forms.MaskedTextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txt_Band_Nuevas = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_TipoBandeja = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_ValorUnitBandeja = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_EstadoBandejas = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_DIGRUT = New System.Windows.Forms.MaskedTextBox()
        Me.txt_NumLote = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_comentarios = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txt_NumPedido = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_vendedor = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_PrecioNeto = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Variedad = New System.Windows.Forms.MaskedTextBox()
        Me.txt_Familia = New System.Windows.Forms.MaskedTextBox()
        Me.txt_Cliente = New System.Windows.Forms.MaskedTextBox()
        Me.txt_RUT_CLI = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_ValorFinalGuia = New System.Windows.Forms.MaskedTextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txt_garantiaband = New System.Windows.Forms.MaskedTextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txt_IvaGuia = New System.Windows.Forms.MaskedTextBox()
        Me.txt_ValorNetoGuia = New System.Windows.Forms.MaskedTextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txt_FechaGuia = New System.Windows.Forms.MaskedTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_CantidadBandejasRetiro = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_PlantasRetiro = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.txt_IndicadorFacturado = New System.Windows.Forms.MaskedTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminaGuiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtAbonoInicial = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtAcuerdoCom = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "GUIA DE ENTREGA N°:"
        '
        'txt_NumGuia
        '
        Me.txt_NumGuia.BackColor = System.Drawing.Color.White
        Me.txt_NumGuia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NumGuia.HidePromptOnLeave = True
        Me.txt_NumGuia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_NumGuia.Location = New System.Drawing.Point(365, 29)
        Me.txt_NumGuia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_NumGuia.Mask = "#########"
        Me.txt_NumGuia.Name = "txt_NumGuia"
        Me.txt_NumGuia.Size = New System.Drawing.Size(67, 22)
        Me.txt_NumGuia.TabIndex = 3
        Me.txt_NumGuia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_NumGuia.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(461, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 24)
        Me.Button1.TabIndex = 64
        Me.Button1.Text = "Buscar Guía"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtAcuerdoCom)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtAbonoInicial)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txt_Band_Usadas)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.txt_Band_Nuevas)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txt_TipoBandeja)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txt_ValorUnitBandeja)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txt_EstadoBandejas)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_DIGRUT)
        Me.GroupBox2.Controls.Add(Me.txt_NumLote)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_comentarios)
        Me.GroupBox2.Controls.Add(Me.Label39)
        Me.GroupBox2.Controls.Add(Me.txt_NumPedido)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_vendedor)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_PrecioNeto)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_Variedad)
        Me.GroupBox2.Controls.Add(Me.txt_Familia)
        Me.GroupBox2.Controls.Add(Me.txt_Cliente)
        Me.GroupBox2.Controls.Add(Me.txt_RUT_CLI)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txt_ValorFinalGuia)
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Controls.Add(Me.txt_garantiaband)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.txt_IvaGuia)
        Me.GroupBox2.Controls.Add(Me.txt_ValorNetoGuia)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.txt_FechaGuia)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txt_CantidadBandejasRetiro)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_PlantasRetiro)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(1, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(691, 487)
        Me.GroupBox2.TabIndex = 83
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos para el Retiro de Plantas"
        '
        'txt_Band_Usadas
        '
        Me.txt_Band_Usadas.BackColor = System.Drawing.Color.Blue
        Me.txt_Band_Usadas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Band_Usadas.ForeColor = System.Drawing.Color.White
        Me.txt_Band_Usadas.Location = New System.Drawing.Point(596, 455)
        Me.txt_Band_Usadas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Band_Usadas.Name = "txt_Band_Usadas"
        Me.txt_Band_Usadas.ReadOnly = True
        Me.txt_Band_Usadas.Size = New System.Drawing.Size(37, 22)
        Me.txt_Band_Usadas.TabIndex = 181
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(499, 460)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(90, 13)
        Me.Label27.TabIndex = 180
        Me.Label27.Text = "Bandejas Usadas"
        '
        'txt_Band_Nuevas
        '
        Me.txt_Band_Nuevas.BackColor = System.Drawing.Color.Blue
        Me.txt_Band_Nuevas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Band_Nuevas.ForeColor = System.Drawing.Color.White
        Me.txt_Band_Nuevas.Location = New System.Drawing.Point(596, 427)
        Me.txt_Band_Nuevas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Band_Nuevas.Name = "txt_Band_Nuevas"
        Me.txt_Band_Nuevas.ReadOnly = True
        Me.txt_Band_Nuevas.Size = New System.Drawing.Size(37, 22)
        Me.txt_Band_Nuevas.TabIndex = 179
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(499, 432)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 13)
        Me.Label15.TabIndex = 178
        Me.Label15.Text = "Bandejas Nuevas"
        '
        'txt_TipoBandeja
        '
        Me.txt_TipoBandeja.BackColor = System.Drawing.Color.Blue
        Me.txt_TipoBandeja.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TipoBandeja.ForeColor = System.Drawing.Color.White
        Me.txt_TipoBandeja.HidePromptOnLeave = True
        Me.txt_TipoBandeja.Location = New System.Drawing.Point(370, 108)
        Me.txt_TipoBandeja.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_TipoBandeja.Name = "txt_TipoBandeja"
        Me.txt_TipoBandeja.ReadOnly = True
        Me.txt_TipoBandeja.Size = New System.Drawing.Size(67, 22)
        Me.txt_TipoBandeja.TabIndex = 177
        Me.txt_TipoBandeja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_TipoBandeja.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(295, 113)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 176
        Me.Label14.Text = "Tipo Bandeja"
        '
        'txt_ValorUnitBandeja
        '
        Me.txt_ValorUnitBandeja.BackColor = System.Drawing.Color.Blue
        Me.txt_ValorUnitBandeja.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ValorUnitBandeja.ForeColor = System.Drawing.Color.White
        Me.txt_ValorUnitBandeja.HidePromptOnLeave = True
        Me.txt_ValorUnitBandeja.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_ValorUnitBandeja.Location = New System.Drawing.Point(370, 427)
        Me.txt_ValorUnitBandeja.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_ValorUnitBandeja.Name = "txt_ValorUnitBandeja"
        Me.txt_ValorUnitBandeja.ReadOnly = True
        Me.txt_ValorUnitBandeja.Size = New System.Drawing.Size(67, 22)
        Me.txt_ValorUnitBandeja.TabIndex = 175
        Me.txt_ValorUnitBandeja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_ValorUnitBandeja.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(295, 432)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 174
        Me.Label11.Text = "Valor Unitario"
        '
        'txt_EstadoBandejas
        '
        Me.txt_EstadoBandejas.BackColor = System.Drawing.Color.Blue
        Me.txt_EstadoBandejas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EstadoBandejas.ForeColor = System.Drawing.Color.White
        Me.txt_EstadoBandejas.Location = New System.Drawing.Point(140, 427)
        Me.txt_EstadoBandejas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_EstadoBandejas.Name = "txt_EstadoBandejas"
        Me.txt_EstadoBandejas.ReadOnly = True
        Me.txt_EstadoBandejas.Size = New System.Drawing.Size(102, 22)
        Me.txt_EstadoBandejas.TabIndex = 173
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(32, 432)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 172
        Me.Label10.Text = "Estado Bandejas"
        '
        'txt_DIGRUT
        '
        Me.txt_DIGRUT.BackColor = System.Drawing.Color.Blue
        Me.txt_DIGRUT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DIGRUT.ForeColor = System.Drawing.Color.White
        Me.txt_DIGRUT.HidePromptOnLeave = True
        Me.txt_DIGRUT.Location = New System.Drawing.Point(637, 24)
        Me.txt_DIGRUT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_DIGRUT.Mask = "A"
        Me.txt_DIGRUT.Name = "txt_DIGRUT"
        Me.txt_DIGRUT.ReadOnly = True
        Me.txt_DIGRUT.Size = New System.Drawing.Size(24, 22)
        Me.txt_DIGRUT.TabIndex = 171
        '
        'txt_NumLote
        '
        Me.txt_NumLote.BackColor = System.Drawing.Color.Blue
        Me.txt_NumLote.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NumLote.ForeColor = System.Drawing.Color.White
        Me.txt_NumLote.HidePromptOnLeave = True
        Me.txt_NumLote.Location = New System.Drawing.Point(370, 81)
        Me.txt_NumLote.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_NumLote.Name = "txt_NumLote"
        Me.txt_NumLote.ReadOnly = True
        Me.txt_NumLote.Size = New System.Drawing.Size(67, 22)
        Me.txt_NumLote.TabIndex = 170
        Me.txt_NumLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_NumLote.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(322, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 169
        Me.Label6.Text = "N° Lote"
        '
        'txt_comentarios
        '
        Me.txt_comentarios.BackColor = System.Drawing.Color.Blue
        Me.txt_comentarios.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_comentarios.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_comentarios.Location = New System.Drawing.Point(140, 304)
        Me.txt_comentarios.Multiline = True
        Me.txt_comentarios.Name = "txt_comentarios"
        Me.txt_comentarios.ReadOnly = True
        Me.txt_comentarios.Size = New System.Drawing.Size(493, 63)
        Me.txt_comentarios.TabIndex = 168
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(54, 304)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(65, 13)
        Me.Label39.TabIndex = 167
        Me.Label39.Text = "Comentarios"
        '
        'txt_NumPedido
        '
        Me.txt_NumPedido.BackColor = System.Drawing.Color.Blue
        Me.txt_NumPedido.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NumPedido.ForeColor = System.Drawing.Color.White
        Me.txt_NumPedido.HidePromptOnLeave = True
        Me.txt_NumPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_NumPedido.Location = New System.Drawing.Point(370, 54)
        Me.txt_NumPedido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_NumPedido.Name = "txt_NumPedido"
        Me.txt_NumPedido.ReadOnly = True
        Me.txt_NumPedido.Size = New System.Drawing.Size(67, 22)
        Me.txt_NumPedido.TabIndex = 166
        Me.txt_NumPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_NumPedido.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(310, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 165
        Me.Label9.Text = "N° Pedido"
        '
        'txt_vendedor
        '
        Me.txt_vendedor.BackColor = System.Drawing.Color.Blue
        Me.txt_vendedor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_vendedor.ForeColor = System.Drawing.Color.White
        Me.txt_vendedor.Location = New System.Drawing.Point(370, 249)
        Me.txt_vendedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_vendedor.Name = "txt_vendedor"
        Me.txt_vendedor.ReadOnly = True
        Me.txt_vendedor.Size = New System.Drawing.Size(216, 22)
        Me.txt_vendedor.TabIndex = 164
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(295, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 163
        Me.Label5.Text = "Atendido por:"
        '
        'txt_PrecioNeto
        '
        Me.txt_PrecioNeto.BackColor = System.Drawing.Color.Blue
        Me.txt_PrecioNeto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PrecioNeto.ForeColor = System.Drawing.Color.White
        Me.txt_PrecioNeto.HidePromptOnLeave = True
        Me.txt_PrecioNeto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_PrecioNeto.Location = New System.Drawing.Point(370, 224)
        Me.txt_PrecioNeto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_PrecioNeto.Name = "txt_PrecioNeto"
        Me.txt_PrecioNeto.ReadOnly = True
        Me.txt_PrecioNeto.Size = New System.Drawing.Size(67, 22)
        Me.txt_PrecioNeto.TabIndex = 162
        Me.txt_PrecioNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_PrecioNeto.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(309, 229)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 161
        Me.Label12.Text = "Valor Unit."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(316, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 160
        Me.Label4.Text = "Variedad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(325, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 159
        Me.Label3.Text = "Semilla"
        '
        'txt_Variedad
        '
        Me.txt_Variedad.BackColor = System.Drawing.Color.Blue
        Me.txt_Variedad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Variedad.ForeColor = System.Drawing.Color.White
        Me.txt_Variedad.Location = New System.Drawing.Point(370, 199)
        Me.txt_Variedad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Variedad.Name = "txt_Variedad"
        Me.txt_Variedad.ReadOnly = True
        Me.txt_Variedad.Size = New System.Drawing.Size(216, 22)
        Me.txt_Variedad.TabIndex = 158
        '
        'txt_Familia
        '
        Me.txt_Familia.BackColor = System.Drawing.Color.Blue
        Me.txt_Familia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Familia.ForeColor = System.Drawing.Color.White
        Me.txt_Familia.Location = New System.Drawing.Point(370, 174)
        Me.txt_Familia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Familia.Name = "txt_Familia"
        Me.txt_Familia.ReadOnly = True
        Me.txt_Familia.Size = New System.Drawing.Size(216, 22)
        Me.txt_Familia.TabIndex = 157
        '
        'txt_Cliente
        '
        Me.txt_Cliente.BackColor = System.Drawing.Color.Blue
        Me.txt_Cliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cliente.ForeColor = System.Drawing.Color.White
        Me.txt_Cliente.Location = New System.Drawing.Point(140, 24)
        Me.txt_Cliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Cliente.Name = "txt_Cliente"
        Me.txt_Cliente.ReadOnly = True
        Me.txt_Cliente.Size = New System.Drawing.Size(316, 22)
        Me.txt_Cliente.TabIndex = 33
        '
        'txt_RUT_CLI
        '
        Me.txt_RUT_CLI.BackColor = System.Drawing.Color.Blue
        Me.txt_RUT_CLI.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RUT_CLI.ForeColor = System.Drawing.Color.White
        Me.txt_RUT_CLI.HidePromptOnLeave = True
        Me.txt_RUT_CLI.Location = New System.Drawing.Point(550, 24)
        Me.txt_RUT_CLI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_RUT_CLI.Name = "txt_RUT_CLI"
        Me.txt_RUT_CLI.ReadOnly = True
        Me.txt_RUT_CLI.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_RUT_CLI.Size = New System.Drawing.Size(83, 22)
        Me.txt_RUT_CLI.TabIndex = 31
        Me.txt_RUT_CLI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 156
        Me.Label2.Text = "Cliente"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(470, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "R.U.T. Cliente"
        '
        'txt_ValorFinalGuia
        '
        Me.txt_ValorFinalGuia.BackColor = System.Drawing.Color.Blue
        Me.txt_ValorFinalGuia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ValorFinalGuia.ForeColor = System.Drawing.Color.White
        Me.txt_ValorFinalGuia.HidePromptOnLeave = True
        Me.txt_ValorFinalGuia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_ValorFinalGuia.Location = New System.Drawing.Point(140, 274)
        Me.txt_ValorFinalGuia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_ValorFinalGuia.Name = "txt_ValorFinalGuia"
        Me.txt_ValorFinalGuia.ReadOnly = True
        Me.txt_ValorFinalGuia.Size = New System.Drawing.Size(67, 22)
        Me.txt_ValorFinalGuia.TabIndex = 155
        Me.txt_ValorFinalGuia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_ValorFinalGuia.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(39, 279)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(80, 13)
        Me.Label38.TabIndex = 154
        Me.Label38.Text = "Valor final Guía"
        '
        'txt_garantiaband
        '
        Me.txt_garantiaband.BackColor = System.Drawing.Color.Blue
        Me.txt_garantiaband.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_garantiaband.ForeColor = System.Drawing.Color.White
        Me.txt_garantiaband.HidePromptOnLeave = True
        Me.txt_garantiaband.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_garantiaband.Location = New System.Drawing.Point(140, 136)
        Me.txt_garantiaband.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_garantiaband.Name = "txt_garantiaband"
        Me.txt_garantiaband.Size = New System.Drawing.Size(67, 22)
        Me.txt_garantiaband.TabIndex = 153
        Me.txt_garantiaband.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_garantiaband.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(23, 141)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(96, 13)
        Me.Label37.TabIndex = 152
        Me.Label37.Text = "Garantía Bandejas"
        '
        'txt_IvaGuia
        '
        Me.txt_IvaGuia.BackColor = System.Drawing.Color.Blue
        Me.txt_IvaGuia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IvaGuia.ForeColor = System.Drawing.Color.White
        Me.txt_IvaGuia.HidePromptOnLeave = True
        Me.txt_IvaGuia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_IvaGuia.Location = New System.Drawing.Point(140, 199)
        Me.txt_IvaGuia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_IvaGuia.Name = "txt_IvaGuia"
        Me.txt_IvaGuia.ReadOnly = True
        Me.txt_IvaGuia.Size = New System.Drawing.Size(67, 22)
        Me.txt_IvaGuia.TabIndex = 150
        Me.txt_IvaGuia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_IvaGuia.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txt_ValorNetoGuia
        '
        Me.txt_ValorNetoGuia.BackColor = System.Drawing.Color.Blue
        Me.txt_ValorNetoGuia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ValorNetoGuia.ForeColor = System.Drawing.Color.White
        Me.txt_ValorNetoGuia.HidePromptOnLeave = True
        Me.txt_ValorNetoGuia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_ValorNetoGuia.Location = New System.Drawing.Point(140, 174)
        Me.txt_ValorNetoGuia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_ValorNetoGuia.Name = "txt_ValorNetoGuia"
        Me.txt_ValorNetoGuia.ReadOnly = True
        Me.txt_ValorNetoGuia.Size = New System.Drawing.Size(67, 22)
        Me.txt_ValorNetoGuia.TabIndex = 149
        Me.txt_ValorNetoGuia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_ValorNetoGuia.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(86, 204)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(33, 13)
        Me.Label35.TabIndex = 147
        Me.Label35.Text = "I.V.A."
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(35, 179)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(84, 13)
        Me.Label33.TabIndex = 146
        Me.Label33.Text = "Valor Neto Guía"
        '
        'txt_FechaGuia
        '
        Me.txt_FechaGuia.BackColor = System.Drawing.Color.Blue
        Me.txt_FechaGuia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FechaGuia.ForeColor = System.Drawing.Color.White
        Me.txt_FechaGuia.Location = New System.Drawing.Point(140, 53)
        Me.txt_FechaGuia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_FechaGuia.Mask = "00/00/0000"
        Me.txt_FechaGuia.Name = "txt_FechaGuia"
        Me.txt_FechaGuia.ReadOnly = True
        Me.txt_FechaGuia.Size = New System.Drawing.Size(74, 22)
        Me.txt_FechaGuia.TabIndex = 139
        Me.txt_FechaGuia.ValidatingType = GetType(Date)
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(55, 58)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 13)
        Me.Label21.TabIndex = 124
        Me.Label21.Text = "Fecha Guía"
        '
        'txt_CantidadBandejasRetiro
        '
        Me.txt_CantidadBandejasRetiro.BackColor = System.Drawing.Color.Blue
        Me.txt_CantidadBandejasRetiro.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CantidadBandejasRetiro.ForeColor = System.Drawing.Color.White
        Me.txt_CantidadBandejasRetiro.HidePromptOnLeave = True
        Me.txt_CantidadBandejasRetiro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_CantidadBandejasRetiro.Location = New System.Drawing.Point(140, 81)
        Me.txt_CantidadBandejasRetiro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_CantidadBandejasRetiro.Name = "txt_CantidadBandejasRetiro"
        Me.txt_CantidadBandejasRetiro.Size = New System.Drawing.Size(67, 22)
        Me.txt_CantidadBandejasRetiro.TabIndex = 41
        Me.txt_CantidadBandejasRetiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_CantidadBandejasRetiro.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Bandejas Retiradas"
        '
        'txt_PlantasRetiro
        '
        Me.txt_PlantasRetiro.BackColor = System.Drawing.Color.Blue
        Me.txt_PlantasRetiro.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PlantasRetiro.ForeColor = System.Drawing.Color.White
        Me.txt_PlantasRetiro.HidePromptOnLeave = True
        Me.txt_PlantasRetiro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_PlantasRetiro.Location = New System.Drawing.Point(140, 108)
        Me.txt_PlantasRetiro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_PlantasRetiro.Name = "txt_PlantasRetiro"
        Me.txt_PlantasRetiro.ReadOnly = True
        Me.txt_PlantasRetiro.Size = New System.Drawing.Size(67, 22)
        Me.txt_PlantasRetiro.TabIndex = 39
        Me.txt_PlantasRetiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_PlantasRetiro.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Plantas Retiradas"
        '
        'btn_grabar
        '
        Me.btn_grabar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_grabar.Location = New System.Drawing.Point(141, 571)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(118, 29)
        Me.btn_grabar.TabIndex = 84
        Me.btn_grabar.Text = "Imprime GUIA"
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(438, 571)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 29)
        Me.Button3.TabIndex = 85
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'txt_IndicadorFacturado
        '
        Me.txt_IndicadorFacturado.BackColor = System.Drawing.SystemColors.Control
        Me.txt_IndicadorFacturado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IndicadorFacturado.ForeColor = System.Drawing.Color.Red
        Me.txt_IndicadorFacturado.Location = New System.Drawing.Point(278, 53)
        Me.txt_IndicadorFacturado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_IndicadorFacturado.Name = "txt_IndicadorFacturado"
        Me.txt_IndicadorFacturado.ReadOnly = True
        Me.txt_IndicadorFacturado.Size = New System.Drawing.Size(151, 22)
        Me.txt_IndicadorFacturado.TabIndex = 169
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(696, 24)
        Me.MenuStrip1.TabIndex = 170
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminaGuiaToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'EliminaGuiaToolStripMenuItem
        '
        Me.EliminaGuiaToolStripMenuItem.Name = "EliminaGuiaToolStripMenuItem"
        Me.EliminaGuiaToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.EliminaGuiaToolStripMenuItem.Text = "Elimina Guia"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(470, 58)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 13)
        Me.Label16.TabIndex = 182
        Me.Label16.Text = "Abono Inicial:"
        '
        'txtAbonoInicial
        '
        Me.txtAbonoInicial.BackColor = System.Drawing.Color.Blue
        Me.txtAbonoInicial.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbonoInicial.ForeColor = System.Drawing.Color.White
        Me.txtAbonoInicial.HidePromptOnLeave = True
        Me.txtAbonoInicial.Location = New System.Drawing.Point(550, 53)
        Me.txtAbonoInicial.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAbonoInicial.Name = "txtAbonoInicial"
        Me.txtAbonoInicial.ReadOnly = True
        Me.txtAbonoInicial.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAbonoInicial.Size = New System.Drawing.Size(83, 22)
        Me.txtAbonoInicial.TabIndex = 183
        Me.txtAbonoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(54, 374)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 13)
        Me.Label17.TabIndex = 184
        Me.Label17.Text = "Acuerdos"
        '
        'txtAcuerdoCom
        '
        Me.txtAcuerdoCom.BackColor = System.Drawing.Color.Blue
        Me.txtAcuerdoCom.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcuerdoCom.ForeColor = System.Drawing.SystemColors.Window
        Me.txtAcuerdoCom.Location = New System.Drawing.Point(140, 374)
        Me.txtAcuerdoCom.Multiline = True
        Me.txtAcuerdoCom.Name = "txtAcuerdoCom"
        Me.txtAcuerdoCom.ReadOnly = True
        Me.txtAcuerdoCom.Size = New System.Drawing.Size(493, 45)
        Me.txtAcuerdoCom.TabIndex = 185
        '
        'Impresion_Guia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 612)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_IndicadorFacturado)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_grabar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_NumGuia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Impresion_Guia"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reimpresión de Guías"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents txt_NumGuia As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents txt_ValorFinalGuia As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Public WithEvents txt_garantiaband As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Public WithEvents txt_IvaGuia As System.Windows.Forms.MaskedTextBox
    Public WithEvents txt_ValorNetoGuia As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txt_FechaGuia As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents txt_CantidadBandejasRetiro As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents txt_PlantasRetiro As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_grabar As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txt_Cliente As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_RUT_CLI As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Familia As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_Variedad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents txt_PrecioNeto As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_vendedor As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents txt_NumPedido As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txt_comentarios As System.Windows.Forms.TextBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents txt_IndicadorFacturado As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminaGuiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents txt_NumLote As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_DIGRUT As System.Windows.Forms.MaskedTextBox
    Public WithEvents txt_ValorUnitBandeja As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_EstadoBandejas As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents txt_TipoBandeja As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_Band_Usadas As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txt_Band_Nuevas As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtAbonoInicial As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtAcuerdoCom As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
