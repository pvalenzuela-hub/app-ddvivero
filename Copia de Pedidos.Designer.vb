<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pedidos))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txt_SaldoPlantas = New System.Windows.Forms.MaskedTextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.txt_PrecioVentaSemilla = New System.Windows.Forms.MaskedTextBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.txt_NuevoPrecioLote = New System.Windows.Forms.MaskedTextBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.txt_CantBandOriginal = New System.Windows.Forms.MaskedTextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.txt_AporteSemillaLoteantiguo = New System.Windows.Forms.TextBox
        Me.txt_PrecioOriginal = New System.Windows.Forms.MaskedTextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.txt_CantBandNuevo = New System.Windows.Forms.MaskedTextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.txt_CantPlantasNuevoLote = New System.Windows.Forms.MaskedTextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.txt_NumLote = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.txt_NombreCliente = New System.Windows.Forms.MaskedTextBox
        Me.txt_totalabono = New System.Windows.Forms.MaskedTextBox
        Me.txt_IDCliente = New System.Windows.Forms.MaskedTextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txt_RUT_CLI = New System.Windows.Forms.MaskedTextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.txt_clientebuscar = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmb_FormaEntrega = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_LUGAR_ENTREGA = New System.Windows.Forms.MaskedTextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txt_Ndias_Fabricacion = New System.Windows.Forms.MaskedTextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_FECHA_INICIO = New System.Windows.Forms.MaskedTextBox
        Me.txt_FECHA_ENTREGA = New System.Windows.Forms.MaskedTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_FECHA_PEDIDO = New System.Windows.Forms.MaskedTextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmb_IDVENDEDOR = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_totalneto = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_TotalIVA = New System.Windows.Forms.TextBox
        Me.txt_TotalPedido = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.rb_PrecioVentaEspecial = New System.Windows.Forms.RadioButton
        Me.rb_PrecioVentaLista = New System.Windows.Forms.RadioButton
        Me.txt_PrecioVenta = New System.Windows.Forms.MaskedTextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txt_Batch = New System.Windows.Forms.MaskedTextBox
        Me.txt_LoteSemilla = New System.Windows.Forms.MaskedTextBox
        Me.txt_FechaEnvasado = New System.Windows.Forms.MaskedTextBox
        Me.cmb_aportasemilla = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmb_variedad = New System.Windows.Forms.ComboBox
        Me.cmb_Familia = New System.Windows.Forms.ComboBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.txt_totallote = New System.Windows.Forms.TextBox
        Me.txt_Comentarios = New System.Windows.Forms.MaskedTextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txt_CantBandejas = New System.Windows.Forms.MaskedTextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.cmb_TipoBandeja = New System.Windows.Forms.ComboBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.txt_Cantidad = New System.Windows.Forms.MaskedTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.DataGrilla = New System.Windows.Forms.DataGridView
        Me.lote = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fecini = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fecentrega = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bandejas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Semilla = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Variedad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.prec = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tipoband = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdtipoBand = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idfam = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idvariedad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Lotesemilla = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.batch = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fecenvasado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.aportesemilla = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label18 = New System.Windows.Forms.Label
        Me.cmb_Pedido = New System.Windows.Forms.ComboBox
        Me.printdocument = New System.Drawing.Printing.PrintDocument
        Me.Label20 = New System.Windows.Forms.Label
        Me.txt_ValorTotalNuevoLote = New System.Windows.Forms.MaskedTextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.txt_NombreCliente)
        Me.GroupBox1.Controls.Add(Me.txt_totalabono)
        Me.GroupBox1.Controls.Add(Me.txt_IDCliente)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_RUT_CLI)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.txt_clientebuscar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmb_FormaEntrega)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_LUGAR_ENTREGA)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(975, 148)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Pedido"
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button6.Location = New System.Drawing.Point(188, 32)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(66, 23)
        Me.Button6.TabIndex = 22
        Me.Button6.Text = "Buscar"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_ValorTotalNuevoLote)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txt_SaldoPlantas)
        Me.GroupBox3.Controls.Add(Me.Label37)
        Me.GroupBox3.Controls.Add(Me.Label36)
        Me.GroupBox3.Controls.Add(Me.txt_PrecioVentaSemilla)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.txt_NuevoPrecioLote)
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.txt_CantBandOriginal)
        Me.GroupBox3.Controls.Add(Me.Label34)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.txt_AporteSemillaLoteantiguo)
        Me.GroupBox3.Controls.Add(Me.txt_PrecioOriginal)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.txt_CantBandNuevo)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.txt_CantPlantasNuevoLote)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.txt_NumLote)
        Me.GroupBox3.Location = New System.Drawing.Point(188, 69)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(779, 73)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Copiar Lote Existente"
        '
        'txt_SaldoPlantas
        '
        Me.txt_SaldoPlantas.BackColor = System.Drawing.SystemColors.Window
        Me.txt_SaldoPlantas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SaldoPlantas.ForeColor = System.Drawing.Color.Navy
        Me.txt_SaldoPlantas.HidePromptOnLeave = True
        Me.txt_SaldoPlantas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_SaldoPlantas.Location = New System.Drawing.Point(650, 15)
        Me.txt_SaldoPlantas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_SaldoPlantas.Mask = "######0"
        Me.txt_SaldoPlantas.Name = "txt_SaldoPlantas"
        Me.txt_SaldoPlantas.ReadOnly = True
        Me.txt_SaldoPlantas.Size = New System.Drawing.Size(67, 22)
        Me.txt_SaldoPlantas.TabIndex = 45
        Me.txt_SaldoPlantas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_SaldoPlantas.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(599, 20)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(34, 13)
        Me.Label37.TabIndex = 44
        Me.Label37.Text = "Saldo"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(461, 20)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(56, 13)
        Me.Label36.TabIndex = 43
        Me.Label36.Text = "Prec.Sem."
        '
        'txt_PrecioVentaSemilla
        '
        Me.txt_PrecioVentaSemilla.BackColor = System.Drawing.SystemColors.Window
        Me.txt_PrecioVentaSemilla.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PrecioVentaSemilla.ForeColor = System.Drawing.Color.Navy
        Me.txt_PrecioVentaSemilla.HidePromptOnLeave = True
        Me.txt_PrecioVentaSemilla.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_PrecioVentaSemilla.Location = New System.Drawing.Point(518, 15)
        Me.txt_PrecioVentaSemilla.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_PrecioVentaSemilla.Name = "txt_PrecioVentaSemilla"
        Me.txt_PrecioVentaSemilla.ReadOnly = True
        Me.txt_PrecioVentaSemilla.Size = New System.Drawing.Size(62, 22)
        Me.txt_PrecioVentaSemilla.TabIndex = 42
        Me.txt_PrecioVentaSemilla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_PrecioVentaSemilla.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(726, 21)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(45, 42)
        Me.Button5.TabIndex = 41
        Me.Button5.Text = "Crear Lote"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txt_NuevoPrecioLote
        '
        Me.txt_NuevoPrecioLote.BackColor = System.Drawing.SystemColors.Window
        Me.txt_NuevoPrecioLote.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NuevoPrecioLote.ForeColor = System.Drawing.Color.Navy
        Me.txt_NuevoPrecioLote.HidePromptOnLeave = True
        Me.txt_NuevoPrecioLote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_NuevoPrecioLote.Location = New System.Drawing.Point(232, 45)
        Me.txt_NuevoPrecioLote.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_NuevoPrecioLote.Name = "txt_NuevoPrecioLote"
        Me.txt_NuevoPrecioLote.Size = New System.Drawing.Size(59, 22)
        Me.txt_NuevoPrecioLote.TabIndex = 34
        Me.txt_NuevoPrecioLote.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(156, 50)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(72, 13)
        Me.Label35.TabIndex = 33
        Me.Label35.Text = "Nuevo Precio"
        '
        'txt_CantBandOriginal
        '
        Me.txt_CantBandOriginal.BackColor = System.Drawing.SystemColors.Window
        Me.txt_CantBandOriginal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CantBandOriginal.ForeColor = System.Drawing.Color.Navy
        Me.txt_CantBandOriginal.HidePromptOnLeave = True
        Me.txt_CantBandOriginal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_CantBandOriginal.Location = New System.Drawing.Point(109, 45)
        Me.txt_CantBandOriginal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_CantBandOriginal.Name = "txt_CantBandOriginal"
        Me.txt_CantBandOriginal.ReadOnly = True
        Me.txt_CantBandOriginal.Size = New System.Drawing.Size(37, 22)
        Me.txt_CantBandOriginal.TabIndex = 32
        Me.txt_CantBandOriginal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_CantBandOriginal.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.txt_CantBandOriginal.ValidatingType = GetType(Integer)
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(2, 50)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(101, 13)
        Me.Label34.TabIndex = 31
        Me.Label34.Text = "Cant.Band. Siembra"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(402, 20)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(31, 13)
        Me.Label33.TabIndex = 30
        Me.Label33.Text = "Sem."
        '
        'txt_AporteSemillaLoteantiguo
        '
        Me.txt_AporteSemillaLoteantiguo.Location = New System.Drawing.Point(433, 17)
        Me.txt_AporteSemillaLoteantiguo.Name = "txt_AporteSemillaLoteantiguo"
        Me.txt_AporteSemillaLoteantiguo.ReadOnly = True
        Me.txt_AporteSemillaLoteantiguo.Size = New System.Drawing.Size(23, 20)
        Me.txt_AporteSemillaLoteantiguo.TabIndex = 29
        '
        'txt_PrecioOriginal
        '
        Me.txt_PrecioOriginal.BackColor = System.Drawing.SystemColors.Window
        Me.txt_PrecioOriginal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PrecioOriginal.ForeColor = System.Drawing.Color.Navy
        Me.txt_PrecioOriginal.HidePromptOnLeave = True
        Me.txt_PrecioOriginal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_PrecioOriginal.Location = New System.Drawing.Point(347, 17)
        Me.txt_PrecioOriginal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_PrecioOriginal.Name = "txt_PrecioOriginal"
        Me.txt_PrecioOriginal.ReadOnly = True
        Me.txt_PrecioOriginal.Size = New System.Drawing.Size(51, 22)
        Me.txt_PrecioOriginal.TabIndex = 28
        Me.txt_PrecioOriginal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_PrecioOriginal.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(287, 20)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(60, 13)
        Me.Label32.TabIndex = 27
        Me.Label32.Text = "Prec.Venta"
        '
        'txt_CantBandNuevo
        '
        Me.txt_CantBandNuevo.BackColor = System.Drawing.SystemColors.Window
        Me.txt_CantBandNuevo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CantBandNuevo.ForeColor = System.Drawing.Color.Navy
        Me.txt_CantBandNuevo.HidePromptOnLeave = True
        Me.txt_CantBandNuevo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_CantBandNuevo.Location = New System.Drawing.Point(362, 45)
        Me.txt_CantBandNuevo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_CantBandNuevo.Name = "txt_CantBandNuevo"
        Me.txt_CantBandNuevo.Size = New System.Drawing.Size(51, 22)
        Me.txt_CantBandNuevo.TabIndex = 26
        Me.txt_CantBandNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_CantBandNuevo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(302, 50)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(60, 13)
        Me.Label31.TabIndex = 25
        Me.Label31.Text = "Cant.Band."
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(443, 50)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(67, 13)
        Me.Label23.TabIndex = 24
        Me.Label23.Text = "Cant.Plantas"
        '
        'txt_CantPlantasNuevoLote
        '
        Me.txt_CantPlantasNuevoLote.BackColor = System.Drawing.SystemColors.Window
        Me.txt_CantPlantasNuevoLote.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CantPlantasNuevoLote.ForeColor = System.Drawing.Color.Navy
        Me.txt_CantPlantasNuevoLote.HidePromptOnLeave = True
        Me.txt_CantPlantasNuevoLote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_CantPlantasNuevoLote.Location = New System.Drawing.Point(513, 45)
        Me.txt_CantPlantasNuevoLote.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_CantPlantasNuevoLote.Mask = "######0"
        Me.txt_CantPlantasNuevoLote.Name = "txt_CantPlantasNuevoLote"
        Me.txt_CantPlantasNuevoLote.ReadOnly = True
        Me.txt_CantPlantasNuevoLote.Size = New System.Drawing.Size(67, 22)
        Me.txt_CantPlantasNuevoLote.TabIndex = 23
        Me.txt_CantPlantasNuevoLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_CantPlantasNuevoLote.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(2, 21)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(95, 15)
        Me.Label30.TabIndex = 18
        Me.Label30.Text = "N° Lote a copiar"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(176, 15)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 23)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Recuperar Lote"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txt_NumLote
        '
        Me.txt_NumLote.Location = New System.Drawing.Point(109, 17)
        Me.txt_NumLote.Name = "txt_NumLote"
        Me.txt_NumLote.Size = New System.Drawing.Size(61, 20)
        Me.txt_NumLote.TabIndex = 19
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(409, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(44, 13)
        Me.Label25.TabIndex = 14
        Me.Label25.Text = "Nombre"
        '
        'txt_NombreCliente
        '
        Me.txt_NombreCliente.BackColor = System.Drawing.Color.Navy
        Me.txt_NombreCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NombreCliente.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_NombreCliente.Location = New System.Drawing.Point(403, 33)
        Me.txt_NombreCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_NombreCliente.Name = "txt_NombreCliente"
        Me.txt_NombreCliente.Size = New System.Drawing.Size(311, 22)
        Me.txt_NombreCliente.TabIndex = 15
        '
        'txt_totalabono
        '
        Me.txt_totalabono.BackColor = System.Drawing.SystemColors.Window
        Me.txt_totalabono.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalabono.ForeColor = System.Drawing.Color.Navy
        Me.txt_totalabono.HidePromptOnLeave = True
        Me.txt_totalabono.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_totalabono.Location = New System.Drawing.Point(16, 78)
        Me.txt_totalabono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_totalabono.Mask = "########0"
        Me.txt_totalabono.Name = "txt_totalabono"
        Me.txt_totalabono.Size = New System.Drawing.Size(67, 22)
        Me.txt_totalabono.TabIndex = 17
        Me.txt_totalabono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_totalabono.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txt_IDCliente
        '
        Me.txt_IDCliente.BackColor = System.Drawing.Color.Navy
        Me.txt_IDCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IDCliente.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_IDCliente.HidePromptOnLeave = True
        Me.txt_IDCliente.Location = New System.Drawing.Point(269, 34)
        Me.txt_IDCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_IDCliente.Mask = "99999999999"
        Me.txt_IDCliente.Name = "txt_IDCliente"
        Me.txt_IDCliente.ReadOnly = True
        Me.txt_IDCliente.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_IDCliente.Size = New System.Drawing.Size(39, 22)
        Me.txt_IDCliente.TabIndex = 6
        Me.txt_IDCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(268, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "ID"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(312, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "R.U.T. Cliente"
        '
        'txt_RUT_CLI
        '
        Me.txt_RUT_CLI.BackColor = System.Drawing.Color.Navy
        Me.txt_RUT_CLI.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RUT_CLI.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_RUT_CLI.HidePromptOnLeave = True
        Me.txt_RUT_CLI.Location = New System.Drawing.Point(314, 34)
        Me.txt_RUT_CLI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_RUT_CLI.Name = "txt_RUT_CLI"
        Me.txt_RUT_CLI.ReadOnly = True
        Me.txt_RUT_CLI.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_RUT_CLI.Size = New System.Drawing.Size(83, 22)
        Me.txt_RUT_CLI.TabIndex = 8
        Me.txt_RUT_CLI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(13, 17)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(124, 13)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Ingrese nombre a buscar"
        '
        'txt_clientebuscar
        '
        Me.txt_clientebuscar.BackColor = System.Drawing.SystemColors.Window
        Me.txt_clientebuscar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clientebuscar.ForeColor = System.Drawing.Color.Navy
        Me.txt_clientebuscar.Location = New System.Drawing.Point(16, 34)
        Me.txt_clientebuscar.Name = "txt_clientebuscar"
        Me.txt_clientebuscar.Size = New System.Drawing.Size(166, 21)
        Me.txt_clientebuscar.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(730, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Forma Entrega"
        '
        'cmb_FormaEntrega
        '
        Me.cmb_FormaEntrega.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_FormaEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_FormaEntrega.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_FormaEntrega.ForeColor = System.Drawing.Color.Navy
        Me.cmb_FormaEntrega.FormattingEnabled = True
        Me.cmb_FormaEntrega.Location = New System.Drawing.Point(716, 32)
        Me.cmb_FormaEntrega.Name = "cmb_FormaEntrega"
        Me.cmb_FormaEntrega.Size = New System.Drawing.Size(210, 23)
        Me.cmb_FormaEntrega.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Lugar Entrega"
        '
        'txt_LUGAR_ENTREGA
        '
        Me.txt_LUGAR_ENTREGA.BackColor = System.Drawing.SystemColors.Window
        Me.txt_LUGAR_ENTREGA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LUGAR_ENTREGA.ForeColor = System.Drawing.Color.Navy
        Me.txt_LUGAR_ENTREGA.Location = New System.Drawing.Point(16, 119)
        Me.txt_LUGAR_ENTREGA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_LUGAR_ENTREGA.Name = "txt_LUGAR_ENTREGA"
        Me.txt_LUGAR_ENTREGA.Size = New System.Drawing.Size(163, 22)
        Me.txt_LUGAR_ENTREGA.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(13, 63)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 13)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Abono Inicial"
        '
        'txt_Ndias_Fabricacion
        '
        Me.txt_Ndias_Fabricacion.BackColor = System.Drawing.Color.Navy
        Me.txt_Ndias_Fabricacion.Enabled = False
        Me.txt_Ndias_Fabricacion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Ndias_Fabricacion.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_Ndias_Fabricacion.HidePromptOnLeave = True
        Me.txt_Ndias_Fabricacion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_Ndias_Fabricacion.Location = New System.Drawing.Point(12, 86)
        Me.txt_Ndias_Fabricacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Ndias_Fabricacion.Mask = "###"
        Me.txt_Ndias_Fabricacion.Name = "txt_Ndias_Fabricacion"
        Me.txt_Ndias_Fabricacion.ReadOnly = True
        Me.txt_Ndias_Fabricacion.Size = New System.Drawing.Size(41, 22)
        Me.txt_Ndias_Fabricacion.TabIndex = 9
        Me.txt_Ndias_Fabricacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_Ndias_Fabricacion.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(1, 69)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 13)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Tiempo Fab."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(80, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Fecha Inicio"
        '
        'txt_FECHA_INICIO
        '
        Me.txt_FECHA_INICIO.BackColor = System.Drawing.SystemColors.Window
        Me.txt_FECHA_INICIO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FECHA_INICIO.ForeColor = System.Drawing.Color.Navy
        Me.txt_FECHA_INICIO.Location = New System.Drawing.Point(76, 86)
        Me.txt_FECHA_INICIO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_FECHA_INICIO.Mask = "00/00/0000"
        Me.txt_FECHA_INICIO.Name = "txt_FECHA_INICIO"
        Me.txt_FECHA_INICIO.Size = New System.Drawing.Size(74, 22)
        Me.txt_FECHA_INICIO.TabIndex = 11
        Me.txt_FECHA_INICIO.ValidatingType = GetType(Date)
        '
        'txt_FECHA_ENTREGA
        '
        Me.txt_FECHA_ENTREGA.BackColor = System.Drawing.Color.Navy
        Me.txt_FECHA_ENTREGA.Enabled = False
        Me.txt_FECHA_ENTREGA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FECHA_ENTREGA.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_FECHA_ENTREGA.Location = New System.Drawing.Point(160, 86)
        Me.txt_FECHA_ENTREGA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_FECHA_ENTREGA.Mask = "00/00/0000"
        Me.txt_FECHA_ENTREGA.Name = "txt_FECHA_ENTREGA"
        Me.txt_FECHA_ENTREGA.ReadOnly = True
        Me.txt_FECHA_ENTREGA.Size = New System.Drawing.Size(74, 22)
        Me.txt_FECHA_ENTREGA.TabIndex = 13
        Me.txt_FECHA_ENTREGA.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(157, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Fecha Entrega"
        '
        'txt_FECHA_PEDIDO
        '
        Me.txt_FECHA_PEDIDO.AsciiOnly = True
        Me.txt_FECHA_PEDIDO.BackColor = System.Drawing.SystemColors.Window
        Me.txt_FECHA_PEDIDO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FECHA_PEDIDO.ForeColor = System.Drawing.Color.Navy
        Me.txt_FECHA_PEDIDO.Location = New System.Drawing.Point(821, 42)
        Me.txt_FECHA_PEDIDO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_FECHA_PEDIDO.Mask = "00/00/0000"
        Me.txt_FECHA_PEDIDO.Name = "txt_FECHA_PEDIDO"
        Me.txt_FECHA_PEDIDO.Size = New System.Drawing.Size(74, 22)
        Me.txt_FECHA_PEDIDO.TabIndex = 5
        Me.txt_FECHA_PEDIDO.ValidatingType = GetType(Date)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(742, 47)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Fecha Pedido"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(302, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Vendedor"
        '
        'cmb_IDVENDEDOR
        '
        Me.cmb_IDVENDEDOR.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_IDVENDEDOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_IDVENDEDOR.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_IDVENDEDOR.ForeColor = System.Drawing.Color.Navy
        Me.cmb_IDVENDEDOR.FormattingEnabled = True
        Me.cmb_IDVENDEDOR.Location = New System.Drawing.Point(355, 43)
        Me.cmb_IDVENDEDOR.Name = "cmb_IDVENDEDOR"
        Me.cmb_IDVENDEDOR.Size = New System.Drawing.Size(260, 23)
        Me.cmb_IDVENDEDOR.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txt_Batch)
        Me.GroupBox2.Controls.Add(Me.txt_LoteSemilla)
        Me.GroupBox2.Controls.Add(Me.txt_FechaEnvasado)
        Me.GroupBox2.Controls.Add(Me.cmb_aportasemilla)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmb_variedad)
        Me.GroupBox2.Controls.Add(Me.cmb_Familia)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.txt_totallote)
        Me.GroupBox2.Controls.Add(Me.txt_Comentarios)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.txt_CantBandejas)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.cmb_TipoBandeja)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.txt_Ndias_Fabricacion)
        Me.GroupBox2.Controls.Add(Me.txt_FECHA_INICIO)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txt_FECHA_ENTREGA)
        Me.GroupBox2.Controls.Add(Me.txt_Cantidad)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.DataGrilla)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 231)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(975, 396)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos para cada Lote"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.txt_totalneto)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.txt_TotalIVA)
        Me.GroupBox5.Controls.Add(Me.txt_TotalPedido)
        Me.GroupBox5.Location = New System.Drawing.Point(767, 289)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox5.TabIndex = 40
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Total Pedido"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Total Neto"
        '
        'txt_totalneto
        '
        Me.txt_totalneto.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_totalneto.CausesValidation = False
        Me.txt_totalneto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalneto.ForeColor = System.Drawing.Color.Yellow
        Me.txt_totalneto.Location = New System.Drawing.Point(107, 20)
        Me.txt_totalneto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_totalneto.Name = "txt_totalneto"
        Me.txt_totalneto.ReadOnly = True
        Me.txt_totalneto.Size = New System.Drawing.Size(79, 22)
        Me.txt_totalneto.TabIndex = 28
        Me.txt_totalneto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "I.V.A."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 79)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Total Pedido"
        '
        'txt_TotalIVA
        '
        Me.txt_TotalIVA.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_TotalIVA.CausesValidation = False
        Me.txt_TotalIVA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalIVA.ForeColor = System.Drawing.Color.Yellow
        Me.txt_TotalIVA.Location = New System.Drawing.Point(107, 48)
        Me.txt_TotalIVA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_TotalIVA.Name = "txt_TotalIVA"
        Me.txt_TotalIVA.ReadOnly = True
        Me.txt_TotalIVA.Size = New System.Drawing.Size(79, 22)
        Me.txt_TotalIVA.TabIndex = 30
        Me.txt_TotalIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_TotalPedido
        '
        Me.txt_TotalPedido.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_TotalPedido.CausesValidation = False
        Me.txt_TotalPedido.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalPedido.ForeColor = System.Drawing.Color.Yellow
        Me.txt_TotalPedido.Location = New System.Drawing.Point(107, 74)
        Me.txt_TotalPedido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_TotalPedido.Name = "txt_TotalPedido"
        Me.txt_TotalPedido.ReadOnly = True
        Me.txt_TotalPedido.Size = New System.Drawing.Size(79, 22)
        Me.txt_TotalPedido.TabIndex = 32
        Me.txt_TotalPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rb_PrecioVentaEspecial)
        Me.GroupBox4.Controls.Add(Me.rb_PrecioVentaLista)
        Me.GroupBox4.Controls.Add(Me.txt_PrecioVenta)
        Me.GroupBox4.Location = New System.Drawing.Point(618, 69)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(216, 67)
        Me.GroupBox4.TabIndex = 39
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Precio de Venta"
        '
        'rb_PrecioVentaEspecial
        '
        Me.rb_PrecioVentaEspecial.AutoSize = True
        Me.rb_PrecioVentaEspecial.Location = New System.Drawing.Point(8, 40)
        Me.rb_PrecioVentaEspecial.Name = "rb_PrecioVentaEspecial"
        Me.rb_PrecioVentaEspecial.Size = New System.Drawing.Size(98, 17)
        Me.rb_PrecioVentaEspecial.TabIndex = 23
        Me.rb_PrecioVentaEspecial.Text = "Precio Especial"
        Me.rb_PrecioVentaEspecial.UseVisualStyleBackColor = True
        '
        'rb_PrecioVentaLista
        '
        Me.rb_PrecioVentaLista.AutoSize = True
        Me.rb_PrecioVentaLista.Checked = True
        Me.rb_PrecioVentaLista.Location = New System.Drawing.Point(8, 17)
        Me.rb_PrecioVentaLista.Name = "rb_PrecioVentaLista"
        Me.rb_PrecioVentaLista.Size = New System.Drawing.Size(80, 17)
        Me.rb_PrecioVentaLista.TabIndex = 22
        Me.rb_PrecioVentaLista.TabStop = True
        Me.rb_PrecioVentaLista.Text = "Precio Lista"
        Me.rb_PrecioVentaLista.UseVisualStyleBackColor = True
        '
        'txt_PrecioVenta
        '
        Me.txt_PrecioVenta.BackColor = System.Drawing.Color.Navy
        Me.txt_PrecioVenta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PrecioVenta.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_PrecioVenta.HidePromptOnLeave = True
        Me.txt_PrecioVenta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_PrecioVenta.Location = New System.Drawing.Point(143, 17)
        Me.txt_PrecioVenta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_PrecioVenta.Name = "txt_PrecioVenta"
        Me.txt_PrecioVenta.Size = New System.Drawing.Size(67, 22)
        Me.txt_PrecioVenta.TabIndex = 15
        Me.txt_PrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_PrecioVenta.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(456, 69)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(76, 13)
        Me.Label29.TabIndex = 38
        Me.Label29.Text = "Fec.Envasado"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(351, 69)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(35, 13)
        Me.Label28.TabIndex = 37
        Me.Label28.Text = "Batch"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(240, 69)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 13)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "Lote Semilla"
        '
        'txt_Batch
        '
        Me.txt_Batch.BackColor = System.Drawing.SystemColors.Window
        Me.txt_Batch.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Batch.ForeColor = System.Drawing.Color.Navy
        Me.txt_Batch.Location = New System.Drawing.Point(354, 86)
        Me.txt_Batch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Batch.Name = "txt_Batch"
        Me.txt_Batch.Size = New System.Drawing.Size(99, 22)
        Me.txt_Batch.TabIndex = 22
        '
        'txt_LoteSemilla
        '
        Me.txt_LoteSemilla.BackColor = System.Drawing.SystemColors.Window
        Me.txt_LoteSemilla.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LoteSemilla.ForeColor = System.Drawing.Color.Navy
        Me.txt_LoteSemilla.Location = New System.Drawing.Point(240, 86)
        Me.txt_LoteSemilla.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_LoteSemilla.Name = "txt_LoteSemilla"
        Me.txt_LoteSemilla.Size = New System.Drawing.Size(108, 22)
        Me.txt_LoteSemilla.TabIndex = 21
        '
        'txt_FechaEnvasado
        '
        Me.txt_FechaEnvasado.BackColor = System.Drawing.SystemColors.Window
        Me.txt_FechaEnvasado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FechaEnvasado.ForeColor = System.Drawing.Color.Navy
        Me.txt_FechaEnvasado.Location = New System.Drawing.Point(459, 86)
        Me.txt_FechaEnvasado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_FechaEnvasado.Mask = "00/0000"
        Me.txt_FechaEnvasado.Name = "txt_FechaEnvasado"
        Me.txt_FechaEnvasado.Size = New System.Drawing.Size(62, 22)
        Me.txt_FechaEnvasado.TabIndex = 23
        '
        'cmb_aportasemilla
        '
        Me.cmb_aportasemilla.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_aportasemilla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_aportasemilla.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_aportasemilla.ForeColor = System.Drawing.Color.Navy
        Me.cmb_aportasemilla.FormattingEnabled = True
        Me.cmb_aportasemilla.Items.AddRange(New Object() {"SI", "NO"})
        Me.cmb_aportasemilla.Location = New System.Drawing.Point(778, 30)
        Me.cmb_aportasemilla.Name = "cmb_aportasemilla"
        Me.cmb_aportasemilla.Size = New System.Drawing.Size(56, 23)
        Me.cmb_aportasemilla.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(762, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Cliente aporta semilla"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(530, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Variedad"
        '
        'cmb_variedad
        '
        Me.cmb_variedad.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_variedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_variedad.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_variedad.ForeColor = System.Drawing.Color.Navy
        Me.cmb_variedad.FormattingEnabled = True
        Me.cmb_variedad.Location = New System.Drawing.Point(533, 30)
        Me.cmb_variedad.Name = "cmb_variedad"
        Me.cmb_variedad.Size = New System.Drawing.Size(228, 23)
        Me.cmb_variedad.TabIndex = 5
        '
        'cmb_Familia
        '
        Me.cmb_Familia.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_Familia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Familia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Familia.ForeColor = System.Drawing.Color.Navy
        Me.cmb_Familia.FormattingEnabled = True
        Me.cmb_Familia.Location = New System.Drawing.Point(271, 30)
        Me.cmb_Familia.Name = "cmb_Familia"
        Me.cmb_Familia.Size = New System.Drawing.Size(241, 23)
        Me.cmb_Familia.TabIndex = 3
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(864, 69)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(55, 13)
        Me.Label26.TabIndex = 18
        Me.Label26.Text = "Total Lote"
        '
        'txt_totallote
        '
        Me.txt_totallote.BackColor = System.Drawing.Color.Navy
        Me.txt_totallote.CausesValidation = False
        Me.txt_totallote.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totallote.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_totallote.Location = New System.Drawing.Point(847, 86)
        Me.txt_totallote.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_totallote.Name = "txt_totallote"
        Me.txt_totallote.ReadOnly = True
        Me.txt_totallote.Size = New System.Drawing.Size(79, 22)
        Me.txt_totallote.TabIndex = 19
        Me.txt_totallote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Comentarios
        '
        Me.txt_Comentarios.BackColor = System.Drawing.SystemColors.Window
        Me.txt_Comentarios.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Comentarios.ForeColor = System.Drawing.Color.Navy
        Me.txt_Comentarios.Location = New System.Drawing.Point(76, 363)
        Me.txt_Comentarios.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Comentarios.Name = "txt_Comentarios"
        Me.txt_Comentarios.Size = New System.Drawing.Size(678, 22)
        Me.txt_Comentarios.TabIndex = 24
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(3, 368)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(65, 13)
        Me.Label24.TabIndex = 22
        Me.Label24.Text = "Comentarios"
        '
        'txt_CantBandejas
        '
        Me.txt_CantBandejas.BackColor = System.Drawing.Color.Navy
        Me.txt_CantBandejas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CantBandejas.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_CantBandejas.HidePromptOnLeave = True
        Me.txt_CantBandejas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_CantBandejas.Location = New System.Drawing.Point(930, 86)
        Me.txt_CantBandejas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_CantBandejas.Name = "txt_CantBandejas"
        Me.txt_CantBandejas.ReadOnly = True
        Me.txt_CantBandejas.Size = New System.Drawing.Size(41, 22)
        Me.txt_CantBandejas.TabIndex = 21
        Me.txt_CantBandejas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_CantBandejas.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(932, 69)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(35, 13)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "Band."
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(13, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(85, 13)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Tipo de Bandeja"
        '
        'cmb_TipoBandeja
        '
        Me.cmb_TipoBandeja.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_TipoBandeja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoBandeja.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_TipoBandeja.ForeColor = System.Drawing.Color.Navy
        Me.cmb_TipoBandeja.FormattingEnabled = True
        Me.cmb_TipoBandeja.Location = New System.Drawing.Point(12, 30)
        Me.cmb_TipoBandeja.Name = "cmb_TipoBandeja"
        Me.cmb_TipoBandeja.Size = New System.Drawing.Size(242, 23)
        Me.cmb_TipoBandeja.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 289)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(152, 24)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Eliminar Lote"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(877, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 40)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Agregar Lote"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txt_Cantidad
        '
        Me.txt_Cantidad.BackColor = System.Drawing.SystemColors.Window
        Me.txt_Cantidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cantidad.ForeColor = System.Drawing.Color.Navy
        Me.txt_Cantidad.HidePromptOnLeave = True
        Me.txt_Cantidad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_Cantidad.Location = New System.Drawing.Point(541, 86)
        Me.txt_Cantidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Cantidad.Mask = "########0"
        Me.txt_Cantidad.Name = "txt_Cantidad"
        Me.txt_Cantidad.Size = New System.Drawing.Size(67, 22)
        Me.txt_Cantidad.TabIndex = 17
        Me.txt_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_Cantidad.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(538, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Cant.Plantas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(268, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Semilla"
        '
        'DataGrilla
        '
        Me.DataGrilla.AllowUserToAddRows = False
        Me.DataGrilla.AllowUserToDeleteRows = False
        Me.DataGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGrilla.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.lote, Me.fecini, Me.fecentrega, Me.bandejas, Me.Semilla, Me.Variedad, Me.Cantidad, Me.prec, Me.Total, Me.Tipoband, Me.Estado, Me.IdtipoBand, Me.idfam, Me.idvariedad, Me.Lotesemilla, Me.batch, Me.Fecenvasado, Me.aportesemilla})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrilla.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGrilla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGrilla.Location = New System.Drawing.Point(4, 143)
        Me.DataGrilla.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGrilla.Name = "DataGrilla"
        Me.DataGrilla.RowHeadersVisible = False
        Me.DataGrilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataGrilla.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGrilla.Size = New System.Drawing.Size(970, 139)
        Me.DataGrilla.TabIndex = 26
        '
        'lote
        '
        Me.lote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.lote.FillWeight = 40.0!
        Me.lote.HeaderText = "N°"
        Me.lote.Name = "lote"
        Me.lote.Width = 44
        '
        'fecini
        '
        Me.fecini.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.fecini.FillWeight = 50.0!
        Me.fecini.HeaderText = "Fec.Ini."
        Me.fecini.Name = "fecini"
        Me.fecini.Width = 67
        '
        'fecentrega
        '
        Me.fecentrega.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.fecentrega.FillWeight = 50.0!
        Me.fecentrega.HeaderText = "Fec.Ent."
        Me.fecentrega.Name = "fecentrega"
        Me.fecentrega.Width = 72
        '
        'bandejas
        '
        Me.bandejas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.bandejas.FillWeight = 20.0!
        Me.bandejas.HeaderText = "Band."
        Me.bandejas.Name = "bandejas"
        Me.bandejas.Width = 60
        '
        'Semilla
        '
        Me.Semilla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Semilla.FillWeight = 80.0!
        Me.Semilla.HeaderText = "Semilla"
        Me.Semilla.Name = "Semilla"
        Me.Semilla.Width = 65
        '
        'Variedad
        '
        Me.Variedad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Variedad.FillWeight = 80.0!
        Me.Variedad.HeaderText = "Variedad"
        Me.Variedad.Name = "Variedad"
        Me.Variedad.Width = 74
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Cantidad.FillWeight = 60.0!
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 74
        '
        'prec
        '
        Me.prec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.prec.FillWeight = 60.0!
        Me.prec.HeaderText = "Precio"
        Me.prec.Name = "prec"
        Me.prec.Width = 62
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Total.FillWeight = 60.0!
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.Width = 56
        '
        'Tipoband
        '
        Me.Tipoband.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Tipoband.FillWeight = 40.0!
        Me.Tipoband.HeaderText = "T. Band."
        Me.Tipoband.Name = "Tipoband"
        Me.Tipoband.Width = 73
        '
        'Estado
        '
        Me.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Estado.FillWeight = 30.0!
        Me.Estado.HeaderText = "Est."
        Me.Estado.Name = "Estado"
        Me.Estado.Width = 50
        '
        'IdtipoBand
        '
        Me.IdtipoBand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IdtipoBand.FillWeight = 20.0!
        Me.IdtipoBand.HeaderText = "Id.Band"
        Me.IdtipoBand.Name = "IdtipoBand"
        Me.IdtipoBand.Width = 69
        '
        'idfam
        '
        Me.idfam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.idfam.FillWeight = 20.0!
        Me.idfam.HeaderText = "Id.Sem."
        Me.idfam.Name = "idfam"
        Me.idfam.Width = 68
        '
        'idvariedad
        '
        Me.idvariedad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.idvariedad.FillWeight = 20.0!
        Me.idvariedad.HeaderText = "Id.Var."
        Me.idvariedad.Name = "idvariedad"
        Me.idvariedad.Width = 63
        '
        'Lotesemilla
        '
        Me.Lotesemilla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Lotesemilla.FillWeight = 50.0!
        Me.Lotesemilla.HeaderText = "Lote Semilla"
        Me.Lotesemilla.Name = "Lotesemilla"
        Me.Lotesemilla.Width = 89
        '
        'batch
        '
        Me.batch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.batch.HeaderText = "Batch"
        Me.batch.Name = "batch"
        Me.batch.Width = 60
        '
        'Fecenvasado
        '
        Me.Fecenvasado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Fecenvasado.HeaderText = "Fec.Env."
        Me.Fecenvasado.Name = "Fecenvasado"
        Me.Fecenvasado.Width = 75
        '
        'aportesemilla
        '
        Me.aportesemilla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.aportesemilla.FillWeight = 30.0!
        Me.aportesemilla.HeaderText = "Sem."
        Me.aportesemilla.Name = "aportesemilla"
        Me.aportesemilla.Width = 56
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(992, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ToolStripMenuItem1, Me.EliminarToolStripMenuItem, Me.ToolStripSeparator1, Me.ToolStripMenuItem2, Me.CerrarToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.ArchivoToolStripMenuItem.Text = "Opciones"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.NuevoToolStripMenuItem.Text = "&Nuevo"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.GuardarToolStripMenuItem.Text = "&Grabar"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(199, 22)
        Me.ToolStripMenuItem1.Text = "Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(196, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(199, 22)
        Me.ToolStripMenuItem2.Text = "Imprime Nota de Pedido"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(29, 47)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Pedido N°"
        '
        'cmb_Pedido
        '
        Me.cmb_Pedido.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_Pedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Pedido.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Pedido.ForeColor = System.Drawing.Color.Navy
        Me.cmb_Pedido.FormattingEnabled = True
        Me.cmb_Pedido.Location = New System.Drawing.Point(90, 43)
        Me.cmb_Pedido.Name = "cmb_Pedido"
        Me.cmb_Pedido.Size = New System.Drawing.Size(86, 23)
        Me.cmb_Pedido.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(587, 50)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 13)
        Me.Label20.TabIndex = 46
        Me.Label20.Text = "Valor Total"
        '
        'txt_ValorTotalNuevoLote
        '
        Me.txt_ValorTotalNuevoLote.BackColor = System.Drawing.SystemColors.Window
        Me.txt_ValorTotalNuevoLote.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ValorTotalNuevoLote.ForeColor = System.Drawing.Color.Navy
        Me.txt_ValorTotalNuevoLote.HidePromptOnLeave = True
        Me.txt_ValorTotalNuevoLote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_ValorTotalNuevoLote.Location = New System.Drawing.Point(650, 45)
        Me.txt_ValorTotalNuevoLote.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_ValorTotalNuevoLote.Mask = "######0"
        Me.txt_ValorTotalNuevoLote.Name = "txt_ValorTotalNuevoLote"
        Me.txt_ValorTotalNuevoLote.ReadOnly = True
        Me.txt_ValorTotalNuevoLote.Size = New System.Drawing.Size(67, 22)
        Me.txt_ValorTotalNuevoLote.TabIndex = 47
        Me.txt_ValorTotalNuevoLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_ValorTotalNuevoLote.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(992, 673)
        Me.Controls.Add(Me.cmb_Pedido)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmb_IDVENDEDOR)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_FECHA_PEDIDO)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Pedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Pedido y Lote"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_clientebuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txt_RUT_CLI As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_FECHA_PEDIDO As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_FECHA_ENTREGA As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_FormaEntrega As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_LUGAR_ENTREGA As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_IDVENDEDOR As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents txt_Cantidad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_FECHA_INICIO As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents txt_Ndias_Fabricacion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmb_Pedido As System.Windows.Forms.ComboBox
    Public WithEvents txt_CantBandejas As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoBandeja As System.Windows.Forms.ComboBox
    Public WithEvents txt_PrecioVenta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_totalneto As System.Windows.Forms.TextBox
    Friend WithEvents txt_TotalPedido As System.Windows.Forms.TextBox
    Friend WithEvents txt_TotalIVA As System.Windows.Forms.TextBox
    Friend WithEvents txt_IDCliente As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_Comentarios As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txt_NombreCliente As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents txt_totalabono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txt_totallote As System.Windows.Forms.TextBox
    Friend WithEvents printdocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents cmb_Familia As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_variedad As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_aportasemilla As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_Batch As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_LoteSemilla As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_FechaEnvasado As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents txt_NumLote As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_PrecioVentaEspecial As System.Windows.Forms.RadioButton
    Friend WithEvents rb_PrecioVentaLista As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Public WithEvents txt_CantPlantasNuevoLote As System.Windows.Forms.MaskedTextBox
    Public WithEvents txt_CantBandNuevo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Public WithEvents txt_PrecioOriginal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txt_AporteSemillaLoteantiguo As System.Windows.Forms.TextBox
    Public WithEvents txt_NuevoPrecioLote As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Public WithEvents txt_CantBandOriginal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Public WithEvents txt_PrecioVentaSemilla As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Public WithEvents txt_SaldoPlantas As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecini As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecentrega As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bandejas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Semilla As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Variedad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipoband As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdtipoBand As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idfam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idvariedad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lotesemilla As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents batch As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecenvasado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents aportesemilla As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Public WithEvents txt_ValorTotalNuevoLote As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
End Class
