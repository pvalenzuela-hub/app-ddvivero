<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreaLoteHijo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_IDCliente = New System.Windows.Forms.MaskedTextBox()
        Me.txt_NombreCliente = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTipoBandejaRecuperado = New System.Windows.Forms.TextBox()
        Me.txtVariedadLoteRecuperado = New System.Windows.Forms.TextBox()
        Me.txtFamiliaLoteRecuperado = New System.Windows.Forms.TextBox()
        Me.chkRequiereGestion = New System.Windows.Forms.CheckBox()
        Me.txt_ValorTotalNuevoLote = New System.Windows.Forms.MaskedTextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_SaldoPlantas = New System.Windows.Forms.MaskedTextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txt_PrecioVentaSemilla = New System.Windows.Forms.MaskedTextBox()
        Me.txt_NuevoPrecioLote = New System.Windows.Forms.MaskedTextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txt_CantBandOriginal = New System.Windows.Forms.MaskedTextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txt_AporteSemillaLoteantiguo = New System.Windows.Forms.TextBox()
        Me.txt_PrecioOriginal = New System.Windows.Forms.MaskedTextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txt_CantBandNuevo = New System.Windows.Forms.MaskedTextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_CantPlantasNuevoLote = New System.Windows.Forms.MaskedTextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txt_NumLote = New System.Windows.Forms.TextBox()
        Me.btnModificaCliente = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtIdVendedor = New System.Windows.Forms.TextBox()
        Me.txtIdFormaEntrega = New System.Windows.Forms.TextBox()
        Me.txtDirEntrega = New System.Windows.Forms.TextBox()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_IDCliente)
        Me.GroupBox3.Controls.Add(Me.txt_NombreCliente)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtTipoBandejaRecuperado)
        Me.GroupBox3.Controls.Add(Me.txtVariedadLoteRecuperado)
        Me.GroupBox3.Controls.Add(Me.txtFamiliaLoteRecuperado)
        Me.GroupBox3.Controls.Add(Me.chkRequiereGestion)
        Me.GroupBox3.Controls.Add(Me.txt_ValorTotalNuevoLote)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txt_SaldoPlantas)
        Me.GroupBox3.Controls.Add(Me.Label37)
        Me.GroupBox3.Controls.Add(Me.Label36)
        Me.GroupBox3.Controls.Add(Me.txt_PrecioVentaSemilla)
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
        Me.GroupBox3.Controls.Add(Me.txt_NumLote)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(738, 486)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        '
        'txt_IDCliente
        '
        Me.txt_IDCliente.BackColor = System.Drawing.Color.Navy
        Me.txt_IDCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IDCliente.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_IDCliente.HidePromptOnLeave = True
        Me.txt_IDCliente.Location = New System.Drawing.Point(682, 52)
        Me.txt_IDCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_IDCliente.Mask = "99999999999"
        Me.txt_IDCliente.Name = "txt_IDCliente"
        Me.txt_IDCliente.ReadOnly = True
        Me.txt_IDCliente.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_IDCliente.Size = New System.Drawing.Size(39, 22)
        Me.txt_IDCliente.TabIndex = 63
        Me.txt_IDCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_NombreCliente
        '
        Me.txt_NombreCliente.BackColor = System.Drawing.Color.Navy
        Me.txt_NombreCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NombreCliente.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_NombreCliente.Location = New System.Drawing.Point(166, 52)
        Me.txt_NombreCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_NombreCliente.Name = "txt_NombreCliente"
        Me.txt_NombreCliente.ReadOnly = True
        Me.txt_NombreCliente.Size = New System.Drawing.Size(505, 22)
        Me.txt_NombreCliente.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 14)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 14)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Tipo Bandeja"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 14)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Variedad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 14)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Semilla"
        '
        'txtTipoBandejaRecuperado
        '
        Me.txtTipoBandejaRecuperado.BackColor = System.Drawing.Color.Green
        Me.txtTipoBandejaRecuperado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoBandejaRecuperado.ForeColor = System.Drawing.Color.White
        Me.txtTipoBandejaRecuperado.Location = New System.Drawing.Point(166, 134)
        Me.txtTipoBandejaRecuperado.Name = "txtTipoBandejaRecuperado"
        Me.txtTipoBandejaRecuperado.ReadOnly = True
        Me.txtTipoBandejaRecuperado.Size = New System.Drawing.Size(505, 21)
        Me.txtTipoBandejaRecuperado.TabIndex = 57
        '
        'txtVariedadLoteRecuperado
        '
        Me.txtVariedadLoteRecuperado.BackColor = System.Drawing.Color.Green
        Me.txtVariedadLoteRecuperado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVariedadLoteRecuperado.ForeColor = System.Drawing.Color.White
        Me.txtVariedadLoteRecuperado.Location = New System.Drawing.Point(166, 107)
        Me.txtVariedadLoteRecuperado.Name = "txtVariedadLoteRecuperado"
        Me.txtVariedadLoteRecuperado.ReadOnly = True
        Me.txtVariedadLoteRecuperado.Size = New System.Drawing.Size(505, 21)
        Me.txtVariedadLoteRecuperado.TabIndex = 56
        '
        'txtFamiliaLoteRecuperado
        '
        Me.txtFamiliaLoteRecuperado.BackColor = System.Drawing.Color.Green
        Me.txtFamiliaLoteRecuperado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFamiliaLoteRecuperado.ForeColor = System.Drawing.Color.White
        Me.txtFamiliaLoteRecuperado.Location = New System.Drawing.Point(166, 80)
        Me.txtFamiliaLoteRecuperado.Name = "txtFamiliaLoteRecuperado"
        Me.txtFamiliaLoteRecuperado.ReadOnly = True
        Me.txtFamiliaLoteRecuperado.Size = New System.Drawing.Size(505, 21)
        Me.txtFamiliaLoteRecuperado.TabIndex = 55
        '
        'chkRequiereGestion
        '
        Me.chkRequiereGestion.AutoSize = True
        Me.chkRequiereGestion.Location = New System.Drawing.Point(37, 265)
        Me.chkRequiereGestion.Name = "chkRequiereGestion"
        Me.chkRequiereGestion.Size = New System.Drawing.Size(121, 18)
        Me.chkRequiereGestion.TabIndex = 48
        Me.chkRequiereGestion.Text = "Requiere Gestión"
        Me.chkRequiereGestion.UseVisualStyleBackColor = True
        '
        'txt_ValorTotalNuevoLote
        '
        Me.txt_ValorTotalNuevoLote.BackColor = System.Drawing.Color.Green
        Me.txt_ValorTotalNuevoLote.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ValorTotalNuevoLote.ForeColor = System.Drawing.Color.White
        Me.txt_ValorTotalNuevoLote.HidePromptOnLeave = True
        Me.txt_ValorTotalNuevoLote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_ValorTotalNuevoLote.Location = New System.Drawing.Point(442, 460)
        Me.txt_ValorTotalNuevoLote.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_ValorTotalNuevoLote.Mask = "######0"
        Me.txt_ValorTotalNuevoLote.Name = "txt_ValorTotalNuevoLote"
        Me.txt_ValorTotalNuevoLote.ReadOnly = True
        Me.txt_ValorTotalNuevoLote.Size = New System.Drawing.Size(229, 23)
        Me.txt_ValorTotalNuevoLote.TabIndex = 47
        Me.txt_ValorTotalNuevoLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_ValorTotalNuevoLote.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(347, 466)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 15)
        Me.Label20.TabIndex = 46
        Me.Label20.Text = "Valor Total"
        '
        'txt_SaldoPlantas
        '
        Me.txt_SaldoPlantas.BackColor = System.Drawing.Color.Green
        Me.txt_SaldoPlantas.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SaldoPlantas.ForeColor = System.Drawing.Color.White
        Me.txt_SaldoPlantas.HidePromptOnLeave = True
        Me.txt_SaldoPlantas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_SaldoPlantas.Location = New System.Drawing.Point(442, 376)
        Me.txt_SaldoPlantas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_SaldoPlantas.Mask = "######0"
        Me.txt_SaldoPlantas.Name = "txt_SaldoPlantas"
        Me.txt_SaldoPlantas.ReadOnly = True
        Me.txt_SaldoPlantas.Size = New System.Drawing.Size(229, 23)
        Me.txt_SaldoPlantas.TabIndex = 45
        Me.txt_SaldoPlantas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_SaldoPlantas.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(347, 380)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(83, 15)
        Me.Label37.TabIndex = 44
        Me.Label37.Text = "Saldo Plantas"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(347, 337)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(59, 15)
        Me.Label36.TabIndex = 43
        Me.Label36.Text = "Prec.Sem."
        '
        'txt_PrecioVentaSemilla
        '
        Me.txt_PrecioVentaSemilla.BackColor = System.Drawing.Color.Green
        Me.txt_PrecioVentaSemilla.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PrecioVentaSemilla.ForeColor = System.Drawing.Color.White
        Me.txt_PrecioVentaSemilla.HidePromptOnLeave = True
        Me.txt_PrecioVentaSemilla.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_PrecioVentaSemilla.Location = New System.Drawing.Point(442, 334)
        Me.txt_PrecioVentaSemilla.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_PrecioVentaSemilla.Name = "txt_PrecioVentaSemilla"
        Me.txt_PrecioVentaSemilla.ReadOnly = True
        Me.txt_PrecioVentaSemilla.Size = New System.Drawing.Size(229, 23)
        Me.txt_PrecioVentaSemilla.TabIndex = 42
        Me.txt_PrecioVentaSemilla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_PrecioVentaSemilla.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txt_NuevoPrecioLote
        '
        Me.txt_NuevoPrecioLote.BackColor = System.Drawing.SystemColors.Window
        Me.txt_NuevoPrecioLote.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NuevoPrecioLote.ForeColor = System.Drawing.Color.Navy
        Me.txt_NuevoPrecioLote.HidePromptOnLeave = True
        Me.txt_NuevoPrecioLote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_NuevoPrecioLote.Location = New System.Drawing.Point(166, 203)
        Me.txt_NuevoPrecioLote.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_NuevoPrecioLote.Name = "txt_NuevoPrecioLote"
        Me.txt_NuevoPrecioLote.Size = New System.Drawing.Size(133, 22)
        Me.txt_NuevoPrecioLote.TabIndex = 34
        Me.txt_NuevoPrecioLote.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(34, 208)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(77, 14)
        Me.Label35.TabIndex = 33
        Me.Label35.Text = "Nuevo Precio"
        '
        'txt_CantBandOriginal
        '
        Me.txt_CantBandOriginal.BackColor = System.Drawing.Color.Green
        Me.txt_CantBandOriginal.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CantBandOriginal.ForeColor = System.Drawing.Color.White
        Me.txt_CantBandOriginal.HidePromptOnLeave = True
        Me.txt_CantBandOriginal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_CantBandOriginal.Location = New System.Drawing.Point(442, 208)
        Me.txt_CantBandOriginal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_CantBandOriginal.Name = "txt_CantBandOriginal"
        Me.txt_CantBandOriginal.ReadOnly = True
        Me.txt_CantBandOriginal.Size = New System.Drawing.Size(229, 23)
        Me.txt_CantBandOriginal.TabIndex = 32
        Me.txt_CantBandOriginal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_CantBandOriginal.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.txt_CantBandOriginal.ValidatingType = GetType(Integer)
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(347, 208)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(92, 15)
        Me.Label34.TabIndex = 31
        Me.Label34.Text = "Saldo Bandejas"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(347, 294)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(88, 15)
        Me.Label33.TabIndex = 30
        Me.Label33.Text = "Aporta Semilla"
        '
        'txt_AporteSemillaLoteantiguo
        '
        Me.txt_AporteSemillaLoteantiguo.BackColor = System.Drawing.Color.Green
        Me.txt_AporteSemillaLoteantiguo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_AporteSemillaLoteantiguo.ForeColor = System.Drawing.Color.White
        Me.txt_AporteSemillaLoteantiguo.Location = New System.Drawing.Point(442, 292)
        Me.txt_AporteSemillaLoteantiguo.Name = "txt_AporteSemillaLoteantiguo"
        Me.txt_AporteSemillaLoteantiguo.ReadOnly = True
        Me.txt_AporteSemillaLoteantiguo.Size = New System.Drawing.Size(229, 23)
        Me.txt_AporteSemillaLoteantiguo.TabIndex = 29
        Me.txt_AporteSemillaLoteantiguo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_PrecioOriginal
        '
        Me.txt_PrecioOriginal.BackColor = System.Drawing.Color.Green
        Me.txt_PrecioOriginal.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PrecioOriginal.ForeColor = System.Drawing.Color.White
        Me.txt_PrecioOriginal.HidePromptOnLeave = True
        Me.txt_PrecioOriginal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_PrecioOriginal.Location = New System.Drawing.Point(442, 250)
        Me.txt_PrecioOriginal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_PrecioOriginal.Name = "txt_PrecioOriginal"
        Me.txt_PrecioOriginal.ReadOnly = True
        Me.txt_PrecioOriginal.Size = New System.Drawing.Size(229, 23)
        Me.txt_PrecioOriginal.TabIndex = 28
        Me.txt_PrecioOriginal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_PrecioOriginal.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(347, 251)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(63, 15)
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
        Me.txt_CantBandNuevo.Location = New System.Drawing.Point(166, 235)
        Me.txt_CantBandNuevo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_CantBandNuevo.Name = "txt_CantBandNuevo"
        Me.txt_CantBandNuevo.Size = New System.Drawing.Size(133, 22)
        Me.txt_CantBandNuevo.TabIndex = 26
        Me.txt_CantBandNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_CantBandNuevo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(34, 235)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(65, 14)
        Me.Label31.TabIndex = 25
        Me.Label31.Text = "Cant.Band."
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(347, 423)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(77, 15)
        Me.Label23.TabIndex = 24
        Me.Label23.Text = "Cant.Plantas"
        '
        'txt_CantPlantasNuevoLote
        '
        Me.txt_CantPlantasNuevoLote.BackColor = System.Drawing.Color.Green
        Me.txt_CantPlantasNuevoLote.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CantPlantasNuevoLote.ForeColor = System.Drawing.Color.White
        Me.txt_CantPlantasNuevoLote.HidePromptOnLeave = True
        Me.txt_CantPlantasNuevoLote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_CantPlantasNuevoLote.Location = New System.Drawing.Point(442, 418)
        Me.txt_CantPlantasNuevoLote.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_CantPlantasNuevoLote.Mask = "######0"
        Me.txt_CantPlantasNuevoLote.Name = "txt_CantPlantasNuevoLote"
        Me.txt_CantPlantasNuevoLote.ReadOnly = True
        Me.txt_CantPlantasNuevoLote.Size = New System.Drawing.Size(229, 23)
        Me.txt_CantPlantasNuevoLote.TabIndex = 23
        Me.txt_CantPlantasNuevoLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_CantPlantasNuevoLote.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(32, 18)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(119, 15)
        Me.Label30.TabIndex = 18
        Me.Label30.Text = "N° Lote a Recuperar"
        '
        'txt_NumLote
        '
        Me.txt_NumLote.Location = New System.Drawing.Point(166, 16)
        Me.txt_NumLote.Name = "txt_NumLote"
        Me.txt_NumLote.Size = New System.Drawing.Size(157, 22)
        Me.txt_NumLote.TabIndex = 19
        '
        'btnModificaCliente
        '
        Me.btnModificaCliente.BackColor = System.Drawing.Color.White
        Me.btnModificaCliente.Enabled = False
        Me.btnModificaCliente.Image = Global.GestionVivero.My.Resources.Resources.editar_40x40
        Me.btnModificaCliente.Location = New System.Drawing.Point(760, 60)
        Me.btnModificaCliente.Name = "btnModificaCliente"
        Me.btnModificaCliente.Size = New System.Drawing.Size(48, 48)
        Me.btnModificaCliente.TabIndex = 118
        Me.ToolTip1.SetToolTip(Me.btnModificaCliente, "Modificar Cliente")
        Me.btnModificaCliente.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.Image = Global.GestionVivero.My.Resources.Resources.buscar_40x40
        Me.btnSearch.Location = New System.Drawing.Point(760, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(48, 48)
        Me.btnSearch.TabIndex = 117
        Me.ToolTip1.SetToolTip(Me.btnSearch, "Buscar Lote Padre")
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.White
        Me.btnsave.Enabled = False
        Me.btnsave.Image = Global.GestionVivero.My.Resources.Resources.guardar_40x40
        Me.btnsave.Location = New System.Drawing.Point(760, 110)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(48, 48)
        Me.btnsave.TabIndex = 116
        Me.ToolTip1.SetToolTip(Me.btnsave, "Crear Lote Hijo")
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.Image = Global.GestionVivero.My.Resources.Resources.salir_40x40
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(760, 161)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(48, 48)
        Me.btnSalir.TabIndex = 122
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnSalir, "Salir")
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtIdVendedor
        '
        Me.txtIdVendedor.Location = New System.Drawing.Point(12, 495)
        Me.txtIdVendedor.Name = "txtIdVendedor"
        Me.txtIdVendedor.Size = New System.Drawing.Size(100, 22)
        Me.txtIdVendedor.TabIndex = 123
        Me.txtIdVendedor.Visible = False
        '
        'txtIdFormaEntrega
        '
        Me.txtIdFormaEntrega.Location = New System.Drawing.Point(118, 495)
        Me.txtIdFormaEntrega.Name = "txtIdFormaEntrega"
        Me.txtIdFormaEntrega.Size = New System.Drawing.Size(100, 22)
        Me.txtIdFormaEntrega.TabIndex = 124
        Me.txtIdFormaEntrega.Visible = False
        '
        'txtDirEntrega
        '
        Me.txtDirEntrega.Location = New System.Drawing.Point(235, 495)
        Me.txtDirEntrega.Name = "txtDirEntrega"
        Me.txtDirEntrega.Size = New System.Drawing.Size(100, 22)
        Me.txtDirEntrega.TabIndex = 125
        Me.txtDirEntrega.Visible = False
        '
        'CreaLoteHijo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 519)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtDirEntrega)
        Me.Controls.Add(Me.txtIdFormaEntrega)
        Me.Controls.Add(Me.txtIdVendedor)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnModificaCliente)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "CreaLoteHijo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crea Lote Hijo"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtTipoBandejaRecuperado As TextBox
    Friend WithEvents txtVariedadLoteRecuperado As TextBox
    Friend WithEvents txtFamiliaLoteRecuperado As TextBox
    Friend WithEvents chkRequiereGestion As CheckBox
    Public WithEvents txt_ValorTotalNuevoLote As MaskedTextBox
    Friend WithEvents Label20 As Label
    Public WithEvents txt_SaldoPlantas As MaskedTextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Public WithEvents txt_PrecioVentaSemilla As MaskedTextBox
    Public WithEvents txt_NuevoPrecioLote As MaskedTextBox
    Friend WithEvents Label35 As Label
    Public WithEvents txt_CantBandOriginal As MaskedTextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents txt_AporteSemillaLoteantiguo As TextBox
    Public WithEvents txt_PrecioOriginal As MaskedTextBox
    Friend WithEvents Label32 As Label
    Public WithEvents txt_CantBandNuevo As MaskedTextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label23 As Label
    Public WithEvents txt_CantPlantasNuevoLote As MaskedTextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txt_NumLote As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnModificaCliente As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_NombreCliente As MaskedTextBox
    Friend WithEvents txt_IDCliente As MaskedTextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtIdVendedor As TextBox
    Friend WithEvents txtIdFormaEntrega As TextBox
    Friend WithEvents txtDirEntrega As TextBox
End Class
