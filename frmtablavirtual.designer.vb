<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmtablavirtual
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grpSinGuia = New System.Windows.Forms.GroupBox()
        Me.txtStockInsumo = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmb_Variedad = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cmb_Familia_Prod = New System.Windows.Forms.ComboBox()
        Me.txt_unidad = New System.Windows.Forms.MaskedTextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmb_Insumos = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_Glosa = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Cantidad = New System.Windows.Forms.MaskedTextBox()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.grpBoletaFactura = New System.Windows.Forms.GroupBox()
        Me.rb3NotaCredito = New System.Windows.Forms.RadioButton()
        Me.rb1_VentaGuia = New System.Windows.Forms.RadioButton()
        Me.rb2_insumo = New System.Windows.Forms.RadioButton()
        Me.grpConGuia = New System.Windows.Forms.GroupBox()
        Me.chk_SelectAll = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGuias = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Guia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaGuia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BandejasGuia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EspecieGuia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VariedadGuia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioGuia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadGuia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtTotalPagos = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_TOTALFINAL = New System.Windows.Forms.TextBox()
        Me.txt_IVA = New System.Windows.Forms.TextBox()
        Me.txt_TOTALNETO = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.grpOtroCliente = New System.Windows.Forms.GroupBox()
        Me.txtIdClienteFactura = New System.Windows.Forms.TextBox()
        Me.txt_NombreClienteFactura = New System.Windows.Forms.MaskedTextBox()
        Me.txt_RutFactura = New System.Windows.Forms.TextBox()
        Me.chkCliente = New System.Windows.Forms.CheckBox()
        Me.txtSaldoAbono = New System.Windows.Forms.TextBox()
        Me.txtAbonoRebajar = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.chk_CLienteFactura = New System.Windows.Forms.CheckBox()
        Me.btnBuscaCliente = New System.Windows.Forms.Button()
        Me.txt_clientebuscar = New System.Windows.Forms.TextBox()
        Me.txt_Rut_Cli = New System.Windows.Forms.TextBox()
        Me.txt_NOM_CLI = New System.Windows.Forms.MaskedTextBox()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_FechaDoc = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TXT_Comentario = New System.Windows.Forms.MaskedTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_MontoEscrito = New System.Windows.Forms.MaskedTextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.txt_Anulado = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txt_IDcliente = New System.Windows.Forms.TextBox()
        Me.txtProceso = New System.Windows.Forms.TextBox()
        Me.DataGrilla = New System.Windows.Forms.DataGridView()
        Me.numguia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Familia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Variedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Insumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preciounit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Glosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdVtaDetNC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Indice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PromedioPlantasNC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadBandejasNC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdVtaDet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.grpDocumentoVenta = New System.Windows.Forms.GroupBox()
        Me.cmb_TIPODOC = New System.Windows.Forms.ComboBox()
        Me.TipoDocumentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataVentas = New GestionVivero.DataVentas()
        Me.txt_NUM_DOC = New System.Windows.Forms.MaskedTextBox()
        Me.grpNotaCredito = New System.Windows.Forms.GroupBox()
        Me.txtCantidadBandejasNC = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPlantasDevolucionNC = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtGuiaNC = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNumDocNC = New System.Windows.Forms.TextBox()
        Me.txtTipoDocNC = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnDocumentoNC = New System.Windows.Forms.Button()
        Me.txtIdVtaDetNC = New System.Windows.Forms.TextBox()
        Me.txtIdVtaHead = New System.Windows.Forms.TextBox()
        Me.txtPromedioPlantasNC = New System.Windows.Forms.TextBox()
        Me.txtPrecioNeto = New System.Windows.Forms.TextBox()
        Me.txtFamilia = New System.Windows.Forms.TextBox()
        Me.txtVariedad = New System.Windows.Forms.TextBox()
        Me.TipoDocumentoTableAdapter = New GestionVivero.DataVentasTableAdapters.TipoDocumentoTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtNumDocSII = New System.Windows.Forms.TextBox()
        Me.txtTipoDocSII = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpSinGuia.SuspendLayout()
        Me.grpBoletaFactura.SuspendLayout()
        Me.grpConGuia.SuspendLayout()
        CType(Me.DataGuias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.grpOtroCliente.SuspendLayout()
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDocumentoVenta.SuspendLayout()
        CType(Me.TipoDocumentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpNotaCredito.SuspendLayout()
        CType(Me.txtCantidadBandejasNC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSinGuia
        '
        Me.grpSinGuia.Controls.Add(Me.txtStockInsumo)
        Me.grpSinGuia.Controls.Add(Me.Label11)
        Me.grpSinGuia.Controls.Add(Me.cmb_Variedad)
        Me.grpSinGuia.Controls.Add(Me.Label3)
        Me.grpSinGuia.Controls.Add(Me.Label24)
        Me.grpSinGuia.Controls.Add(Me.cmb_Familia_Prod)
        Me.grpSinGuia.Controls.Add(Me.txt_unidad)
        Me.grpSinGuia.Controls.Add(Me.Label29)
        Me.grpSinGuia.Controls.Add(Me.Label23)
        Me.grpSinGuia.Controls.Add(Me.cmb_Insumos)
        Me.grpSinGuia.Controls.Add(Me.Label26)
        Me.grpSinGuia.Controls.Add(Me.Label10)
        Me.grpSinGuia.Controls.Add(Me.txt_Glosa)
        Me.grpSinGuia.Controls.Add(Me.Label4)
        Me.grpSinGuia.Controls.Add(Me.txt_Cantidad)
        Me.grpSinGuia.Controls.Add(Me.txt_precio)
        Me.grpSinGuia.Enabled = False
        Me.grpSinGuia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSinGuia.Location = New System.Drawing.Point(5, 309)
        Me.grpSinGuia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpSinGuia.Name = "grpSinGuia"
        Me.grpSinGuia.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpSinGuia.Size = New System.Drawing.Size(1218, 101)
        Me.grpSinGuia.TabIndex = 5
        Me.grpSinGuia.TabStop = False
        Me.grpSinGuia.Text = "Venta Sin Guía de Lote"
        '
        'txtStockInsumo
        '
        Me.txtStockInsumo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtStockInsumo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockInsumo.ForeColor = System.Drawing.Color.Navy
        Me.txtStockInsumo.Location = New System.Drawing.Point(506, 17)
        Me.txtStockInsumo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStockInsumo.Name = "txtStockInsumo"
        Me.txtStockInsumo.ReadOnly = True
        Me.txtStockInsumo.Size = New System.Drawing.Size(94, 22)
        Me.txtStockInsumo.TabIndex = 102
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(431, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 14)
        Me.Label11.TabIndex = 101
        Me.Label11.Text = "Stock Insumo"
        '
        'cmb_Variedad
        '
        Me.cmb_Variedad.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_Variedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Variedad.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Variedad.ForeColor = System.Drawing.Color.Yellow
        Me.cmb_Variedad.FormattingEnabled = True
        Me.cmb_Variedad.Location = New System.Drawing.Point(121, 71)
        Me.cmb_Variedad.Name = "cmb_Variedad"
        Me.cmb_Variedad.Size = New System.Drawing.Size(299, 23)
        Me.cmb_Variedad.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(779, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 14)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Unidad"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(19, 75)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(50, 14)
        Me.Label24.TabIndex = 35
        Me.Label24.Text = "Variedad"
        '
        'cmb_Familia_Prod
        '
        Me.cmb_Familia_Prod.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_Familia_Prod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Familia_Prod.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Familia_Prod.ForeColor = System.Drawing.Color.Yellow
        Me.cmb_Familia_Prod.FormattingEnabled = True
        Me.cmb_Familia_Prod.Location = New System.Drawing.Point(121, 44)
        Me.cmb_Familia_Prod.Name = "cmb_Familia_Prod"
        Me.cmb_Familia_Prod.Size = New System.Drawing.Size(299, 23)
        Me.cmb_Familia_Prod.TabIndex = 7
        '
        'txt_unidad
        '
        Me.txt_unidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_unidad.Enabled = False
        Me.txt_unidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_unidad.ForeColor = System.Drawing.Color.Navy
        Me.txt_unidad.Location = New System.Drawing.Point(821, 29)
        Me.txt_unidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_unidad.Name = "txt_unidad"
        Me.txt_unidad.ReadOnly = True
        Me.txt_unidad.Size = New System.Drawing.Size(293, 22)
        Me.txt_unidad.TabIndex = 99
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(432, 48)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(68, 14)
        Me.Label29.TabIndex = 98
        Me.Label29.Text = "Precio Venta"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(19, 48)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(45, 14)
        Me.Label23.TabIndex = 90
        Me.Label23.Text = "Especie"
        '
        'cmb_Insumos
        '
        Me.cmb_Insumos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_Insumos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Insumos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Insumos.ForeColor = System.Drawing.Color.White
        Me.cmb_Insumos.FormattingEnabled = True
        Me.cmb_Insumos.Location = New System.Drawing.Point(121, 17)
        Me.cmb_Insumos.Name = "cmb_Insumos"
        Me.cmb_Insumos.Size = New System.Drawing.Size(299, 23)
        Me.cmb_Insumos.TabIndex = 54
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(19, 21)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(41, 14)
        Me.Label26.TabIndex = 53
        Me.Label26.Text = "Insumo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(779, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 14)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Glosa"
        '
        'txt_Glosa
        '
        Me.txt_Glosa.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_Glosa.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Glosa.ForeColor = System.Drawing.Color.Navy
        Me.txt_Glosa.Location = New System.Drawing.Point(821, 56)
        Me.txt_Glosa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Glosa.Name = "txt_Glosa"
        Me.txt_Glosa.Size = New System.Drawing.Size(293, 22)
        Me.txt_Glosa.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(441, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cantidad"
        '
        'txt_Cantidad
        '
        Me.txt_Cantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_Cantidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cantidad.HidePromptOnLeave = True
        Me.txt_Cantidad.Location = New System.Drawing.Point(506, 71)
        Me.txt_Cantidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Cantidad.Mask = "999999"
        Me.txt_Cantidad.Name = "txt_Cantidad"
        Me.txt_Cantidad.Size = New System.Drawing.Size(94, 22)
        Me.txt_Cantidad.TabIndex = 8
        Me.txt_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_precio
        '
        Me.txt_precio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_precio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precio.Location = New System.Drawing.Point(506, 44)
        Me.txt_precio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(94, 22)
        Me.txt_precio.TabIndex = 8
        Me.txt_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grpBoletaFactura
        '
        Me.grpBoletaFactura.Controls.Add(Me.rb3NotaCredito)
        Me.grpBoletaFactura.Controls.Add(Me.rb1_VentaGuia)
        Me.grpBoletaFactura.Controls.Add(Me.rb2_insumo)
        Me.grpBoletaFactura.Location = New System.Drawing.Point(5, 119)
        Me.grpBoletaFactura.Name = "grpBoletaFactura"
        Me.grpBoletaFactura.Size = New System.Drawing.Size(182, 83)
        Me.grpBoletaFactura.TabIndex = 105
        Me.grpBoletaFactura.TabStop = False
        Me.grpBoletaFactura.Text = "Tipo de Venta"
        '
        'rb3NotaCredito
        '
        Me.rb3NotaCredito.AutoSize = True
        Me.rb3NotaCredito.Enabled = False
        Me.rb3NotaCredito.Location = New System.Drawing.Point(10, 61)
        Me.rb3NotaCredito.Name = "rb3NotaCredito"
        Me.rb3NotaCredito.Size = New System.Drawing.Size(99, 18)
        Me.rb3NotaCredito.TabIndex = 39
        Me.rb3NotaCredito.Text = "Nota de Crédito"
        Me.rb3NotaCredito.UseVisualStyleBackColor = True
        '
        'rb1_VentaGuia
        '
        Me.rb1_VentaGuia.AutoSize = True
        Me.rb1_VentaGuia.Enabled = False
        Me.rb1_VentaGuia.Location = New System.Drawing.Point(10, 19)
        Me.rb1_VentaGuia.Name = "rb1_VentaGuia"
        Me.rb1_VentaGuia.Size = New System.Drawing.Size(166, 18)
        Me.rb1_VentaGuia.TabIndex = 37
        Me.rb1_VentaGuia.Text = "Venta de Plantines con Guías"
        Me.rb1_VentaGuia.UseVisualStyleBackColor = True
        '
        'rb2_insumo
        '
        Me.rb2_insumo.AutoSize = True
        Me.rb2_insumo.Enabled = False
        Me.rb2_insumo.Location = New System.Drawing.Point(10, 40)
        Me.rb2_insumo.Name = "rb2_insumo"
        Me.rb2_insumo.Size = New System.Drawing.Size(102, 18)
        Me.rb2_insumo.TabIndex = 38
        Me.rb2_insumo.Text = "Venta Sin Guías"
        Me.rb2_insumo.UseVisualStyleBackColor = True
        '
        'grpConGuia
        '
        Me.grpConGuia.Controls.Add(Me.chk_SelectAll)
        Me.grpConGuia.Controls.Add(Me.Label1)
        Me.grpConGuia.Controls.Add(Me.DataGuias)
        Me.grpConGuia.Enabled = False
        Me.grpConGuia.Location = New System.Drawing.Point(5, 205)
        Me.grpConGuia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpConGuia.Name = "grpConGuia"
        Me.grpConGuia.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpConGuia.Size = New System.Drawing.Size(1218, 98)
        Me.grpConGuia.TabIndex = 3
        Me.grpConGuia.TabStop = False
        Me.grpConGuia.Text = "Venta con Guía de Lote"
        '
        'chk_SelectAll
        '
        Me.chk_SelectAll.AutoSize = True
        Me.chk_SelectAll.Location = New System.Drawing.Point(37, 61)
        Me.chk_SelectAll.Name = "chk_SelectAll"
        Me.chk_SelectAll.Size = New System.Drawing.Size(101, 18)
        Me.chk_SelectAll.TabIndex = 6
        Me.chk_SelectAll.Text = "Todas las guías"
        Me.chk_SelectAll.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 14)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Guía a Facturar"
        '
        'DataGuias
        '
        Me.DataGuias.AllowUserToAddRows = False
        Me.DataGuias.AllowUserToDeleteRows = False
        Me.DataGuias.AllowUserToResizeColumns = False
        Me.DataGuias.AllowUserToResizeRows = False
        Me.DataGuias.BackgroundColor = System.Drawing.Color.White
        Me.DataGuias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGuias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Guia, Me.FechaGuia, Me.BandejasGuia, Me.EspecieGuia, Me.VariedadGuia, Me.PrecioGuia, Me.CantidadGuia})
        Me.DataGuias.Location = New System.Drawing.Point(190, 14)
        Me.DataGuias.Name = "DataGuias"
        Me.DataGuias.RowHeadersVisible = False
        Me.DataGuias.Size = New System.Drawing.Size(1022, 82)
        Me.DataGuias.TabIndex = 101
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 20
        '
        'Guia
        '
        Me.Guia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Guia.HeaderText = "N° Guía"
        Me.Guia.Name = "Guia"
        Me.Guia.ReadOnly = True
        Me.Guia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Guia.Width = 49
        '
        'FechaGuia
        '
        Me.FechaGuia.HeaderText = "Fecha"
        Me.FechaGuia.Name = "FechaGuia"
        Me.FechaGuia.ReadOnly = True
        '
        'BandejasGuia
        '
        Me.BandejasGuia.HeaderText = "Bandejas"
        Me.BandejasGuia.Name = "BandejasGuia"
        Me.BandejasGuia.ReadOnly = True
        '
        'EspecieGuia
        '
        Me.EspecieGuia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EspecieGuia.HeaderText = "Especie"
        Me.EspecieGuia.Name = "EspecieGuia"
        Me.EspecieGuia.ReadOnly = True
        '
        'VariedadGuia
        '
        Me.VariedadGuia.HeaderText = "Variedad"
        Me.VariedadGuia.Name = "VariedadGuia"
        Me.VariedadGuia.ReadOnly = True
        '
        'PrecioGuia
        '
        Me.PrecioGuia.HeaderText = "Precio Venta"
        Me.PrecioGuia.Name = "PrecioGuia"
        Me.PrecioGuia.ReadOnly = True
        '
        'CantidadGuia
        '
        Me.CantidadGuia.HeaderText = "Cantidad"
        Me.CantidadGuia.Name = "CantidadGuia"
        Me.CantidadGuia.ReadOnly = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Gold
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox4.Controls.Add(Me.txtTotalPagos)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txt_TOTALFINAL)
        Me.GroupBox4.Controls.Add(Me.txt_IVA)
        Me.GroupBox4.Controls.Add(Me.txt_TOTALNETO)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(1024, 597)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(1)
        Me.GroupBox4.Size = New System.Drawing.Size(197, 107)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        '
        'txtTotalPagos
        '
        Me.txtTotalPagos.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtTotalPagos.CausesValidation = False
        Me.txtTotalPagos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPagos.ForeColor = System.Drawing.Color.Yellow
        Me.txtTotalPagos.Location = New System.Drawing.Point(92, 81)
        Me.txtTotalPagos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalPagos.Name = "txtTotalPagos"
        Me.txtTotalPagos.ReadOnly = True
        Me.txtTotalPagos.Size = New System.Drawing.Size(93, 22)
        Me.txtTotalPagos.TabIndex = 13
        Me.txtTotalPagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 15)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "TOTAL PAGOS"
        '
        'txt_TOTALFINAL
        '
        Me.txt_TOTALFINAL.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_TOTALFINAL.CausesValidation = False
        Me.txt_TOTALFINAL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TOTALFINAL.ForeColor = System.Drawing.Color.Yellow
        Me.txt_TOTALFINAL.Location = New System.Drawing.Point(92, 58)
        Me.txt_TOTALFINAL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_TOTALFINAL.Name = "txt_TOTALFINAL"
        Me.txt_TOTALFINAL.ReadOnly = True
        Me.txt_TOTALFINAL.Size = New System.Drawing.Size(93, 22)
        Me.txt_TOTALFINAL.TabIndex = 11
        Me.txt_TOTALFINAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_IVA
        '
        Me.txt_IVA.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_IVA.CausesValidation = False
        Me.txt_IVA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IVA.ForeColor = System.Drawing.Color.Yellow
        Me.txt_IVA.Location = New System.Drawing.Point(92, 36)
        Me.txt_IVA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_IVA.Name = "txt_IVA"
        Me.txt_IVA.ReadOnly = True
        Me.txt_IVA.Size = New System.Drawing.Size(93, 22)
        Me.txt_IVA.TabIndex = 10
        Me.txt_IVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_TOTALNETO
        '
        Me.txt_TOTALNETO.BackColor = System.Drawing.Color.MidnightBlue
        Me.txt_TOTALNETO.CausesValidation = False
        Me.txt_TOTALNETO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TOTALNETO.ForeColor = System.Drawing.Color.Yellow
        Me.txt_TOTALNETO.Location = New System.Drawing.Point(92, 13)
        Me.txt_TOTALNETO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_TOTALNETO.Name = "txt_TOTALNETO"
        Me.txt_TOTALNETO.ReadOnly = True
        Me.txt_TOTALNETO.Size = New System.Drawing.Size(93, 22)
        Me.txt_TOTALNETO.TabIndex = 9
        Me.txt_TOTALNETO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(44, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "TOTAL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(60, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "IVA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "NETO"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.grpOtroCliente)
        Me.GroupBox8.Controls.Add(Me.chkCliente)
        Me.GroupBox8.Controls.Add(Me.txtSaldoAbono)
        Me.GroupBox8.Controls.Add(Me.txtAbonoRebajar)
        Me.GroupBox8.Controls.Add(Me.Label17)
        Me.GroupBox8.Controls.Add(Me.Label28)
        Me.GroupBox8.Controls.Add(Me.chk_CLienteFactura)
        Me.GroupBox8.Controls.Add(Me.btnBuscaCliente)
        Me.GroupBox8.Controls.Add(Me.txt_clientebuscar)
        Me.GroupBox8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(5, 29)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox8.Size = New System.Drawing.Size(1218, 87)
        Me.GroupBox8.TabIndex = 34
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "CLIENTE"
        '
        'grpOtroCliente
        '
        Me.grpOtroCliente.Controls.Add(Me.txtIdClienteFactura)
        Me.grpOtroCliente.Controls.Add(Me.txt_NombreClienteFactura)
        Me.grpOtroCliente.Controls.Add(Me.txt_RutFactura)
        Me.grpOtroCliente.Location = New System.Drawing.Point(656, 10)
        Me.grpOtroCliente.Name = "grpOtroCliente"
        Me.grpOtroCliente.Size = New System.Drawing.Size(548, 67)
        Me.grpOtroCliente.TabIndex = 117
        Me.grpOtroCliente.TabStop = False
        Me.grpOtroCliente.Text = "Facturar a otro cliente"
        Me.grpOtroCliente.Visible = False
        '
        'txtIdClienteFactura
        '
        Me.txtIdClienteFactura.Location = New System.Drawing.Point(451, 39)
        Me.txtIdClienteFactura.Name = "txtIdClienteFactura"
        Me.txtIdClienteFactura.Size = New System.Drawing.Size(91, 20)
        Me.txtIdClienteFactura.TabIndex = 117
        Me.txtIdClienteFactura.Visible = False
        '
        'txt_NombreClienteFactura
        '
        Me.txt_NombreClienteFactura.BackColor = System.Drawing.Color.White
        Me.txt_NombreClienteFactura.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NombreClienteFactura.ForeColor = System.Drawing.Color.Navy
        Me.txt_NombreClienteFactura.Location = New System.Drawing.Point(6, 17)
        Me.txt_NombreClienteFactura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_NombreClienteFactura.Name = "txt_NombreClienteFactura"
        Me.txt_NombreClienteFactura.ReadOnly = True
        Me.txt_NombreClienteFactura.Size = New System.Drawing.Size(439, 22)
        Me.txt_NombreClienteFactura.TabIndex = 62
        '
        'txt_RutFactura
        '
        Me.txt_RutFactura.BackColor = System.Drawing.Color.White
        Me.txt_RutFactura.Location = New System.Drawing.Point(451, 17)
        Me.txt_RutFactura.Name = "txt_RutFactura"
        Me.txt_RutFactura.ReadOnly = True
        Me.txt_RutFactura.Size = New System.Drawing.Size(91, 20)
        Me.txt_RutFactura.TabIndex = 107
        '
        'chkCliente
        '
        Me.chkCliente.AutoSize = True
        Me.chkCliente.Enabled = False
        Me.chkCliente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCliente.Location = New System.Drawing.Point(7, 38)
        Me.chkCliente.Name = "chkCliente"
        Me.chkCliente.Size = New System.Drawing.Size(81, 18)
        Me.chkCliente.TabIndex = 111
        Me.chkCliente.Text = "por nombre"
        Me.chkCliente.UseVisualStyleBackColor = True
        '
        'txtSaldoAbono
        '
        Me.txtSaldoAbono.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSaldoAbono.Location = New System.Drawing.Point(253, 46)
        Me.txtSaldoAbono.Name = "txtSaldoAbono"
        Me.txtSaldoAbono.ReadOnly = True
        Me.txtSaldoAbono.Size = New System.Drawing.Size(147, 20)
        Me.txtSaldoAbono.TabIndex = 108
        '
        'txtAbonoRebajar
        '
        Me.txtAbonoRebajar.Enabled = False
        Me.txtAbonoRebajar.Location = New System.Drawing.Point(458, 46)
        Me.txtAbonoRebajar.Name = "txtAbonoRebajar"
        Me.txtAbonoRebajar.Size = New System.Drawing.Size(136, 20)
        Me.txtAbonoRebajar.TabIndex = 103
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(464, 29)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(126, 14)
        Me.Label17.TabIndex = 102
        Me.Label17.Text = "Ingrese Abono a Rebajar"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(275, 29)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(97, 14)
        Me.Label28.TabIndex = 65
        Me.Label28.Text = "Saldo Abono Inicial"
        '
        'chk_CLienteFactura
        '
        Me.chk_CLienteFactura.AutoSize = True
        Me.chk_CLienteFactura.Enabled = False
        Me.chk_CLienteFactura.Location = New System.Drawing.Point(7, 62)
        Me.chk_CLienteFactura.Name = "chk_CLienteFactura"
        Me.chk_CLienteFactura.Size = New System.Drawing.Size(135, 18)
        Me.chk_CLienteFactura.TabIndex = 58
        Me.chk_CLienteFactura.Text = "Facturar a Otro Cliente"
        Me.chk_CLienteFactura.UseVisualStyleBackColor = True
        '
        'btnBuscaCliente
        '
        Me.btnBuscaCliente.BackColor = System.Drawing.Color.White
        Me.btnBuscaCliente.Enabled = False
        Me.btnBuscaCliente.Image = Global.GestionVivero.My.Resources.Resources.PREVIEW
        Me.btnBuscaCliente.Location = New System.Drawing.Point(153, 38)
        Me.btnBuscaCliente.Name = "btnBuscaCliente"
        Me.btnBuscaCliente.Size = New System.Drawing.Size(30, 25)
        Me.btnBuscaCliente.TabIndex = 29
        Me.btnBuscaCliente.UseVisualStyleBackColor = False
        '
        'txt_clientebuscar
        '
        Me.txt_clientebuscar.BackColor = System.Drawing.Color.White
        Me.txt_clientebuscar.Enabled = False
        Me.txt_clientebuscar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clientebuscar.ForeColor = System.Drawing.Color.Black
        Me.txt_clientebuscar.Location = New System.Drawing.Point(7, 14)
        Me.txt_clientebuscar.Name = "txt_clientebuscar"
        Me.txt_clientebuscar.Size = New System.Drawing.Size(176, 21)
        Me.txt_clientebuscar.TabIndex = 1
        '
        'txt_Rut_Cli
        '
        Me.txt_Rut_Cli.BackColor = System.Drawing.Color.White
        Me.txt_Rut_Cli.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Rut_Cli.ForeColor = System.Drawing.Color.Navy
        Me.txt_Rut_Cli.Location = New System.Drawing.Point(661, 4)
        Me.txt_Rut_Cli.Name = "txt_Rut_Cli"
        Me.txt_Rut_Cli.ReadOnly = True
        Me.txt_Rut_Cli.Size = New System.Drawing.Size(168, 27)
        Me.txt_Rut_Cli.TabIndex = 106
        '
        'txt_NOM_CLI
        '
        Me.txt_NOM_CLI.BackColor = System.Drawing.Color.White
        Me.txt_NOM_CLI.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NOM_CLI.ForeColor = System.Drawing.Color.Navy
        Me.txt_NOM_CLI.Location = New System.Drawing.Point(126, 4)
        Me.txt_NOM_CLI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_NOM_CLI.Name = "txt_NOM_CLI"
        Me.txt_NOM_CLI.ReadOnly = True
        Me.txt_NOM_CLI.Size = New System.Drawing.Size(530, 27)
        Me.txt_NOM_CLI.TabIndex = 21
        '
        'txtVendedor
        '
        Me.txtVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtVendedor.Location = New System.Drawing.Point(95, 652)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.ReadOnly = True
        Me.txtVendedor.Size = New System.Drawing.Size(698, 20)
        Me.txtVendedor.TabIndex = 113
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 655)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 14)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Vendedor"
        '
        'dtp_FechaDoc
        '
        Me.dtp_FechaDoc.Enabled = False
        Me.dtp_FechaDoc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FechaDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaDoc.Location = New System.Drawing.Point(8, 5)
        Me.dtp_FechaDoc.Name = "dtp_FechaDoc"
        Me.dtp_FechaDoc.Size = New System.Drawing.Size(99, 21)
        Me.dtp_FechaDoc.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(12, 599)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(81, 14)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = "Observaciones"
        '
        'TXT_Comentario
        '
        Me.TXT_Comentario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXT_Comentario.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Comentario.ForeColor = System.Drawing.Color.Blue
        Me.TXT_Comentario.Location = New System.Drawing.Point(95, 595)
        Me.TXT_Comentario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_Comentario.Name = "TXT_Comentario"
        Me.TXT_Comentario.ReadOnly = True
        Me.TXT_Comentario.Size = New System.Drawing.Size(698, 23)
        Me.TXT_Comentario.TabIndex = 30
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(64, 627)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(29, 14)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "Son:"
        '
        'txt_MontoEscrito
        '
        Me.txt_MontoEscrito.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_MontoEscrito.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MontoEscrito.Location = New System.Drawing.Point(95, 623)
        Me.txt_MontoEscrito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_MontoEscrito.Name = "txt_MontoEscrito"
        Me.txt_MontoEscrito.Size = New System.Drawing.Size(698, 22)
        Me.txt_MontoEscrito.TabIndex = 38
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'txt_Anulado
        '
        Me.txt_Anulado.BackColor = System.Drawing.SystemColors.Menu
        Me.txt_Anulado.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Anulado.ForeColor = System.Drawing.Color.Red
        Me.txt_Anulado.Location = New System.Drawing.Point(463, 687)
        Me.txt_Anulado.Name = "txt_Anulado"
        Me.txt_Anulado.Size = New System.Drawing.Size(330, 27)
        Me.txt_Anulado.TabIndex = 39
        Me.txt_Anulado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEstado
        '
        Me.txtEstado.BackColor = System.Drawing.SystemColors.Menu
        Me.txtEstado.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.ForeColor = System.Drawing.Color.Red
        Me.txtEstado.Location = New System.Drawing.Point(2, 687)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(454, 27)
        Me.txtEstado.TabIndex = 40
        Me.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_IDcliente
        '
        Me.txt_IDcliente.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IDcliente.ForeColor = System.Drawing.Color.Navy
        Me.txt_IDcliente.Location = New System.Drawing.Point(834, 4)
        Me.txt_IDcliente.Name = "txt_IDcliente"
        Me.txt_IDcliente.Size = New System.Drawing.Size(100, 27)
        Me.txt_IDcliente.TabIndex = 112
        '
        'txtProceso
        '
        Me.txtProceso.BackColor = System.Drawing.SystemColors.Menu
        Me.txtProceso.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProceso.ForeColor = System.Drawing.Color.Red
        Me.txtProceso.Location = New System.Drawing.Point(940, 4)
        Me.txtProceso.Name = "txtProceso"
        Me.txtProceso.ReadOnly = True
        Me.txtProceso.Size = New System.Drawing.Size(340, 27)
        Me.txtProceso.TabIndex = 113
        Me.txtProceso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataGrilla
        '
        Me.DataGrilla.AllowUserToAddRows = False
        Me.DataGrilla.AllowUserToDeleteRows = False
        Me.DataGrilla.AllowUserToResizeColumns = False
        Me.DataGrilla.AllowUserToResizeRows = False
        Me.DataGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGrilla.BackgroundColor = System.Drawing.Color.White
        Me.DataGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numguia, Me.Familia, Me.Variedad, Me.Insumo, Me.Column1, Me.preciounit, Me.Cantidad, Me.Total, Me.Glosa, Me.tipoventa, Me.IdVtaDetNC, Me.Indice, Me.PromedioPlantasNC, Me.CantidadBandejasNC, Me.IdVtaDet})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrilla.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrilla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGrilla.Location = New System.Drawing.Point(5, 448)
        Me.DataGrilla.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGrilla.Name = "DataGrilla"
        Me.DataGrilla.ReadOnly = True
        Me.DataGrilla.RowHeadersVisible = False
        Me.DataGrilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataGrilla.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGrilla.Size = New System.Drawing.Size(1218, 145)
        Me.DataGrilla.TabIndex = 114
        '
        'numguia
        '
        Me.numguia.HeaderText = "N° Guía"
        Me.numguia.Name = "numguia"
        Me.numguia.ReadOnly = True
        Me.numguia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.numguia.Width = 49
        '
        'Familia
        '
        Me.Familia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Familia.HeaderText = "Familia"
        Me.Familia.Name = "Familia"
        Me.Familia.ReadOnly = True
        Me.Familia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Variedad
        '
        Me.Variedad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Variedad.HeaderText = "Variedad"
        Me.Variedad.Name = "Variedad"
        Me.Variedad.ReadOnly = True
        Me.Variedad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Insumo
        '
        Me.Insumo.HeaderText = "Insumo"
        Me.Insumo.Name = "Insumo"
        Me.Insumo.ReadOnly = True
        Me.Insumo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Insumo.Width = 47
        '
        'Column1
        '
        Me.Column1.HeaderText = "Unidad"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column1.Width = 46
        '
        'preciounit
        '
        Me.preciounit.HeaderText = "Precio Unit."
        Me.preciounit.Name = "preciounit"
        Me.preciounit.ReadOnly = True
        Me.preciounit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.preciounit.Width = 67
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Cantidad.Width = 55
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Total.Width = 35
        '
        'Glosa
        '
        Me.Glosa.HeaderText = "Glosa"
        Me.Glosa.Name = "Glosa"
        Me.Glosa.ReadOnly = True
        Me.Glosa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Glosa.Width = 41
        '
        'tipoventa
        '
        Me.tipoventa.HeaderText = "Tipo Vta"
        Me.tipoventa.Name = "tipoventa"
        Me.tipoventa.ReadOnly = True
        Me.tipoventa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.tipoventa.Width = 53
        '
        'IdVtaDetNC
        '
        Me.IdVtaDetNC.HeaderText = "IdVtaDetNC"
        Me.IdVtaDetNC.Name = "IdVtaDetNC"
        Me.IdVtaDetNC.ReadOnly = True
        Me.IdVtaDetNC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.IdVtaDetNC.Width = 68
        '
        'Indice
        '
        Me.Indice.HeaderText = "Indice"
        Me.Indice.Name = "Indice"
        Me.Indice.ReadOnly = True
        Me.Indice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Indice.Width = 41
        '
        'PromedioPlantasNC
        '
        Me.PromedioPlantasNC.HeaderText = "PromedioPlantasNC"
        Me.PromedioPlantasNC.Name = "PromedioPlantasNC"
        Me.PromedioPlantasNC.ReadOnly = True
        Me.PromedioPlantasNC.Width = 125
        '
        'CantidadBandejasNC
        '
        Me.CantidadBandejasNC.HeaderText = "CantidadBandejasNC"
        Me.CantidadBandejasNC.Name = "CantidadBandejasNC"
        Me.CantidadBandejasNC.ReadOnly = True
        Me.CantidadBandejasNC.Width = 133
        '
        'IdVtaDet
        '
        Me.IdVtaDet.HeaderText = "IdVtaDet"
        Me.IdVtaDet.Name = "IdVtaDet"
        Me.IdVtaDet.ReadOnly = True
        Me.IdVtaDet.Width = 73
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.Image = Global.GestionVivero.My.Resources.Resources.Close
        Me.btnCancel.Location = New System.Drawing.Point(1229, 387)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(51, 51)
        Me.btnCancel.TabIndex = 122
        Me.ToolTip1.SetToolTip(Me.btnCancel, "Cancela Registro")
        Me.btnCancel.UseVisualStyleBackColor = False
        Me.btnCancel.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Image = Global.GestionVivero.My.Resources.Resources.salir_40x40
        Me.btnExit.Location = New System.Drawing.Point(1229, 335)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(51, 51)
        Me.btnExit.TabIndex = 121
        Me.ToolTip1.SetToolTip(Me.btnExit, "Salir")
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.White
        Me.btnPrint.Enabled = False
        Me.btnPrint.Image = Global.GestionVivero.My.Resources.Resources.imprimir_40x40
        Me.btnPrint.Location = New System.Drawing.Point(1229, 284)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(51, 51)
        Me.btnPrint.TabIndex = 120
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.Enabled = False
        Me.btnDelete.Image = Global.GestionVivero.My.Resources.Resources.eliminar_40x40
        Me.btnDelete.Location = New System.Drawing.Point(1229, 233)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(51, 51)
        Me.btnDelete.TabIndex = 119
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.Enabled = False
        Me.btnSave.Image = Global.GestionVivero.My.Resources.Resources.guardar_40x40
        Me.btnSave.Location = New System.Drawing.Point(1229, 182)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 51)
        Me.btnSave.TabIndex = 118
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.White
        Me.btnEdit.Enabled = False
        Me.btnEdit.Image = Global.GestionVivero.My.Resources.Resources.editar_40x40
        Me.btnEdit.Location = New System.Drawing.Point(1229, 131)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(51, 51)
        Me.btnEdit.TabIndex = 117
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.White
        Me.btnsearch.Image = Global.GestionVivero.My.Resources.Resources.buscar_40x40
        Me.btnsearch.Location = New System.Drawing.Point(1229, 80)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(51, 51)
        Me.btnsearch.TabIndex = 116
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.White
        Me.btnNew.Image = Global.GestionVivero.My.Resources.Resources.nuevo_40x40
        Me.btnNew.Location = New System.Drawing.Point(1229, 29)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(51, 51)
        Me.btnNew.TabIndex = 115
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = Global.GestionVivero.My.Resources.Resources.Delete
        Me.btnEliminar.Location = New System.Drawing.Point(43, 411)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(35, 35)
        Me.btnEliminar.TabIndex = 11
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.btnAgregar.Location = New System.Drawing.Point(8, 411)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(35, 35)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'grpDocumentoVenta
        '
        Me.grpDocumentoVenta.Controls.Add(Me.cmb_TIPODOC)
        Me.grpDocumentoVenta.Controls.Add(Me.txt_NUM_DOC)
        Me.grpDocumentoVenta.Location = New System.Drawing.Point(197, 119)
        Me.grpDocumentoVenta.Name = "grpDocumentoVenta"
        Me.grpDocumentoVenta.Size = New System.Drawing.Size(183, 83)
        Me.grpDocumentoVenta.TabIndex = 123
        Me.grpDocumentoVenta.TabStop = False
        Me.grpDocumentoVenta.Text = "Documento de Venta"
        '
        'cmb_TIPODOC
        '
        Me.cmb_TIPODOC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_TIPODOC.DataSource = Me.TipoDocumentoBindingSource
        Me.cmb_TIPODOC.DisplayMember = "Nombre"
        Me.cmb_TIPODOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TIPODOC.Enabled = False
        Me.cmb_TIPODOC.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmb_TIPODOC.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_TIPODOC.Location = New System.Drawing.Point(6, 20)
        Me.cmb_TIPODOC.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmb_TIPODOC.Name = "cmb_TIPODOC"
        Me.cmb_TIPODOC.Size = New System.Drawing.Size(169, 24)
        Me.cmb_TIPODOC.TabIndex = 2
        Me.cmb_TIPODOC.ValueMember = "id"
        '
        'TipoDocumentoBindingSource
        '
        Me.TipoDocumentoBindingSource.DataMember = "TipoDocumento"
        Me.TipoDocumentoBindingSource.DataSource = Me.DataVentas
        '
        'DataVentas
        '
        Me.DataVentas.DataSetName = "DataVentas"
        Me.DataVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_NUM_DOC
        '
        Me.txt_NUM_DOC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_NUM_DOC.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NUM_DOC.HidePromptOnLeave = True
        Me.txt_NUM_DOC.Location = New System.Drawing.Point(6, 46)
        Me.txt_NUM_DOC.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_NUM_DOC.Mask = "999999999999"
        Me.txt_NUM_DOC.Name = "txt_NUM_DOC"
        Me.txt_NUM_DOC.ReadOnly = True
        Me.txt_NUM_DOC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_NUM_DOC.Size = New System.Drawing.Size(169, 22)
        Me.txt_NUM_DOC.TabIndex = 3
        Me.txt_NUM_DOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grpNotaCredito
        '
        Me.grpNotaCredito.Controls.Add(Me.txtCantidadBandejasNC)
        Me.grpNotaCredito.Controls.Add(Me.Label16)
        Me.grpNotaCredito.Controls.Add(Me.txtPlantasDevolucionNC)
        Me.grpNotaCredito.Controls.Add(Me.Label15)
        Me.grpNotaCredito.Controls.Add(Me.txtGuiaNC)
        Me.grpNotaCredito.Controls.Add(Me.Label14)
        Me.grpNotaCredito.Controls.Add(Me.txtNumDocNC)
        Me.grpNotaCredito.Controls.Add(Me.txtTipoDocNC)
        Me.grpNotaCredito.Controls.Add(Me.Label9)
        Me.grpNotaCredito.Controls.Add(Me.btnDocumentoNC)
        Me.grpNotaCredito.Location = New System.Drawing.Point(558, 119)
        Me.grpNotaCredito.Name = "grpNotaCredito"
        Me.grpNotaCredito.Size = New System.Drawing.Size(665, 83)
        Me.grpNotaCredito.TabIndex = 122
        Me.grpNotaCredito.TabStop = False
        Me.grpNotaCredito.Text = "Documento Nota de Crédito"
        Me.grpNotaCredito.Visible = False
        '
        'txtCantidadBandejasNC
        '
        Me.txtCantidadBandejasNC.Location = New System.Drawing.Point(432, 40)
        Me.txtCantidadBandejasNC.Name = "txtCantidadBandejasNC"
        Me.txtCantidadBandejasNC.Size = New System.Drawing.Size(104, 20)
        Me.txtCantidadBandejasNC.TabIndex = 131
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(557, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 14)
        Me.Label16.TabIndex = 130
        Me.Label16.Text = "Plantas a Devolver"
        '
        'txtPlantasDevolucionNC
        '
        Me.txtPlantasDevolucionNC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPlantasDevolucionNC.Enabled = False
        Me.txtPlantasDevolucionNC.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlantasDevolucionNC.ForeColor = System.Drawing.Color.Black
        Me.txtPlantasDevolucionNC.Location = New System.Drawing.Point(553, 40)
        Me.txtPlantasDevolucionNC.Name = "txtPlantasDevolucionNC"
        Me.txtPlantasDevolucionNC.ReadOnly = True
        Me.txtPlantasDevolucionNC.Size = New System.Drawing.Size(106, 21)
        Me.txtPlantasDevolucionNC.TabIndex = 129
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(429, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(107, 14)
        Me.Label15.TabIndex = 127
        Me.Label15.Text = "Bandejas a Devolver"
        '
        'txtGuiaNC
        '
        Me.txtGuiaNC.Location = New System.Drawing.Point(273, 45)
        Me.txtGuiaNC.Name = "txtGuiaNC"
        Me.txtGuiaNC.ReadOnly = True
        Me.txtGuiaNC.Size = New System.Drawing.Size(147, 20)
        Me.txtGuiaNC.TabIndex = 126
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(197, 47)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 14)
        Me.Label14.TabIndex = 125
        Me.Label14.Text = "N° Guía"
        '
        'txtNumDocNC
        '
        Me.txtNumDocNC.Location = New System.Drawing.Point(320, 19)
        Me.txtNumDocNC.Name = "txtNumDocNC"
        Me.txtNumDocNC.ReadOnly = True
        Me.txtNumDocNC.Size = New System.Drawing.Size(100, 20)
        Me.txtNumDocNC.TabIndex = 124
        '
        'txtTipoDocNC
        '
        Me.txtTipoDocNC.Location = New System.Drawing.Point(273, 19)
        Me.txtTipoDocNC.Name = "txtTipoDocNC"
        Me.txtTipoDocNC.ReadOnly = True
        Me.txtTipoDocNC.Size = New System.Drawing.Size(42, 20)
        Me.txtTipoDocNC.TabIndex = 123
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(197, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 14)
        Me.Label9.TabIndex = 122
        Me.Label9.Text = "N° Doc. Venta"
        '
        'btnDocumentoNC
        '
        Me.btnDocumentoNC.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnDocumentoNC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDocumentoNC.Image = Global.GestionVivero.My.Resources.Resources.PREVIEW
        Me.btnDocumentoNC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDocumentoNC.Location = New System.Drawing.Point(7, 27)
        Me.btnDocumentoNC.Name = "btnDocumentoNC"
        Me.btnDocumentoNC.Size = New System.Drawing.Size(182, 30)
        Me.btnDocumentoNC.TabIndex = 121
        Me.btnDocumentoNC.Text = "Documento de Venta Asociado"
        Me.btnDocumentoNC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDocumentoNC.UseVisualStyleBackColor = False
        '
        'txtIdVtaDetNC
        '
        Me.txtIdVtaDetNC.BackColor = System.Drawing.Color.White
        Me.txtIdVtaDetNC.Location = New System.Drawing.Point(221, 418)
        Me.txtIdVtaDetNC.Name = "txtIdVtaDetNC"
        Me.txtIdVtaDetNC.ReadOnly = True
        Me.txtIdVtaDetNC.Size = New System.Drawing.Size(91, 20)
        Me.txtIdVtaDetNC.TabIndex = 119
        '
        'txtIdVtaHead
        '
        Me.txtIdVtaHead.BackColor = System.Drawing.Color.White
        Me.txtIdVtaHead.Location = New System.Drawing.Point(97, 418)
        Me.txtIdVtaHead.Name = "txtIdVtaHead"
        Me.txtIdVtaHead.ReadOnly = True
        Me.txtIdVtaHead.Size = New System.Drawing.Size(91, 20)
        Me.txtIdVtaHead.TabIndex = 118
        '
        'txtPromedioPlantasNC
        '
        Me.txtPromedioPlantasNC.Location = New System.Drawing.Point(843, 418)
        Me.txtPromedioPlantasNC.Name = "txtPromedioPlantasNC"
        Me.txtPromedioPlantasNC.Size = New System.Drawing.Size(100, 20)
        Me.txtPromedioPlantasNC.TabIndex = 124
        '
        'txtPrecioNeto
        '
        Me.txtPrecioNeto.Location = New System.Drawing.Point(395, 418)
        Me.txtPrecioNeto.Name = "txtPrecioNeto"
        Me.txtPrecioNeto.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioNeto.TabIndex = 125
        '
        'txtFamilia
        '
        Me.txtFamilia.Location = New System.Drawing.Point(509, 418)
        Me.txtFamilia.Name = "txtFamilia"
        Me.txtFamilia.Size = New System.Drawing.Size(100, 20)
        Me.txtFamilia.TabIndex = 126
        '
        'txtVariedad
        '
        Me.txtVariedad.Location = New System.Drawing.Point(622, 418)
        Me.txtVariedad.Name = "txtVariedad"
        Me.txtVariedad.Size = New System.Drawing.Size(100, 20)
        Me.txtVariedad.TabIndex = 127
        '
        'TipoDocumentoTableAdapter
        '
        Me.TipoDocumentoTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtNumDocSII)
        Me.GroupBox1.Controls.Add(Me.txtTipoDocSII)
        Me.GroupBox1.Location = New System.Drawing.Point(389, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(161, 83)
        Me.GroupBox1.TabIndex = 128
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información SII"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 50)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 14)
        Me.Label21.TabIndex = 111
        Me.Label21.Text = "N° Doc."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 25)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 14)
        Me.Label19.TabIndex = 110
        Me.Label19.Text = "Tipo Doc."
        '
        'txtNumDocSII
        '
        Me.txtNumDocSII.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNumDocSII.Location = New System.Drawing.Point(58, 47)
        Me.txtNumDocSII.Name = "txtNumDocSII"
        Me.txtNumDocSII.ReadOnly = True
        Me.txtNumDocSII.Size = New System.Drawing.Size(91, 20)
        Me.txtNumDocSII.TabIndex = 109
        '
        'txtTipoDocSII
        '
        Me.txtTipoDocSII.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTipoDocSII.Location = New System.Drawing.Point(58, 22)
        Me.txtTipoDocSII.Name = "txtTipoDocSII"
        Me.txtTipoDocSII.ReadOnly = True
        Me.txtTipoDocSII.Size = New System.Drawing.Size(91, 20)
        Me.txtTipoDocSII.TabIndex = 108
        '
        'frmtablavirtual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1280, 714)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtIdVtaDetNC)
        Me.Controls.Add(Me.txt_Anulado)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.grpBoletaFactura)
        Me.Controls.Add(Me.txt_IDcliente)
        Me.Controls.Add(Me.txtProceso)
        Me.Controls.Add(Me.txt_Rut_Cli)
        Me.Controls.Add(Me.grpNotaCredito)
        Me.Controls.Add(Me.txtIdVtaHead)
        Me.Controls.Add(Me.txtVariedad)
        Me.Controls.Add(Me.txtFamilia)
        Me.Controls.Add(Me.txtPrecioNeto)
        Me.Controls.Add(Me.txtPromedioPlantasNC)
        Me.Controls.Add(Me.grpDocumentoVenta)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txt_NOM_CLI)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.dtp_FechaDoc)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.DataGrilla)
        Me.Controls.Add(Me.txtVendedor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_MontoEscrito)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TXT_Comentario)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.grpSinGuia)
        Me.Controls.Add(Me.grpConGuia)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmtablavirtual"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documento de Venta"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpSinGuia.ResumeLayout(False)
        Me.grpSinGuia.PerformLayout()
        Me.grpBoletaFactura.ResumeLayout(False)
        Me.grpBoletaFactura.PerformLayout()
        Me.grpConGuia.ResumeLayout(False)
        Me.grpConGuia.PerformLayout()
        CType(Me.DataGuias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.grpOtroCliente.ResumeLayout(False)
        Me.grpOtroCliente.PerformLayout()
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDocumentoVenta.ResumeLayout(False)
        Me.grpDocumentoVenta.PerformLayout()
        CType(Me.TipoDocumentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpNotaCredito.ResumeLayout(False)
        Me.grpNotaCredito.PerformLayout()
        CType(Me.txtCantidadBandejasNC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpSinGuia As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents grpConGuia As System.Windows.Forms.GroupBox
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_NOM_CLI As System.Windows.Forms.MaskedTextBox


    Friend WithEvents txt_TOTALNETO As System.Windows.Forms.TextBox
    Friend WithEvents txt_TOTALFINAL As System.Windows.Forms.TextBox
    Friend WithEvents txt_IVA As System.Windows.Forms.TextBox
    Friend WithEvents txt_Cantidad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_clientebuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscaCliente As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TXT_Comentario As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_Glosa As System.Windows.Forms.MaskedTextBox
    Friend WithEvents rb2_insumo As System.Windows.Forms.RadioButton
    Friend WithEvents rb1_VentaGuia As System.Windows.Forms.RadioButton
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cmb_Insumos As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_unidad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_NombreClienteFactura As System.Windows.Forms.MaskedTextBox
    Friend WithEvents chk_CLienteFactura As System.Windows.Forms.CheckBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_MontoEscrito As System.Windows.Forms.MaskedTextBox
    Friend WithEvents dtp_FechaDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents txt_Anulado As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtAbonoRebajar As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents grpBoletaFactura As System.Windows.Forms.GroupBox
    Friend WithEvents txt_RutFactura As System.Windows.Forms.TextBox
    Friend WithEvents txt_Rut_Cli As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldoAbono As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtStockInsumo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkCliente As CheckBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents DataGuias As DataGridView
    Friend WithEvents chk_SelectAll As CheckBox
    Friend WithEvents txt_IDcliente As TextBox
    Friend WithEvents cmb_Variedad As ComboBox
    Friend WithEvents cmb_Familia_Prod As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txtVendedor As TextBox
    Friend WithEvents txtProceso As TextBox
    Friend WithEvents DataGrilla As DataGridView
    Friend WithEvents btnNew As Button
    Friend WithEvents btnsearch As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Column2 As DataGridViewCheckBoxColumn
    Friend WithEvents Guia As DataGridViewTextBoxColumn
    Friend WithEvents FechaGuia As DataGridViewTextBoxColumn
    Friend WithEvents BandejasGuia As DataGridViewTextBoxColumn
    Friend WithEvents EspecieGuia As DataGridViewTextBoxColumn
    Friend WithEvents VariedadGuia As DataGridViewTextBoxColumn
    Friend WithEvents PrecioGuia As DataGridViewTextBoxColumn
    Friend WithEvents CantidadGuia As DataGridViewTextBoxColumn
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTotalPagos As TextBox
    Friend WithEvents grpDocumentoVenta As GroupBox
    Friend WithEvents txtIdVtaDetNC As TextBox
    Friend WithEvents txtIdVtaHead As TextBox
    Friend WithEvents cmb_TIPODOC As ComboBox
    Friend WithEvents txt_NUM_DOC As MaskedTextBox
    Friend WithEvents grpNotaCredito As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtGuiaNC As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtNumDocNC As TextBox
    Friend WithEvents txtTipoDocNC As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnDocumentoNC As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents txtPlantasDevolucionNC As TextBox
    Friend WithEvents txtPromedioPlantasNC As TextBox
    Friend WithEvents txtCantidadBandejasNC As NumericUpDown
    Friend WithEvents txtPrecioNeto As TextBox
    Friend WithEvents txtFamilia As TextBox
    Friend WithEvents txtVariedad As TextBox
    Friend WithEvents DataVentas As DataVentas
    Friend WithEvents TipoDocumentoBindingSource As BindingSource
    Friend WithEvents TipoDocumentoTableAdapter As DataVentasTableAdapters.TipoDocumentoTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNumDocSII As TextBox
    Friend WithEvents txtTipoDocSII As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents grpOtroCliente As GroupBox
    Friend WithEvents txtIdClienteFactura As TextBox
    Friend WithEvents numguia As DataGridViewTextBoxColumn
    Friend WithEvents Familia As DataGridViewTextBoxColumn
    Friend WithEvents Variedad As DataGridViewTextBoxColumn
    Friend WithEvents Insumo As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents preciounit As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Glosa As DataGridViewTextBoxColumn
    Friend WithEvents tipoventa As DataGridViewTextBoxColumn
    Friend WithEvents IdVtaDetNC As DataGridViewTextBoxColumn
    Friend WithEvents Indice As DataGridViewTextBoxColumn
    Friend WithEvents PromedioPlantasNC As DataGridViewTextBoxColumn
    Friend WithEvents CantidadBandejasNC As DataGridViewTextBoxColumn
    Friend WithEvents IdVtaDet As DataGridViewTextBoxColumn
    Friend WithEvents rb3NotaCredito As RadioButton
    Friend WithEvents ToolTip1 As ToolTip
End Class
