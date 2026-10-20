<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AplicacionProductos
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
        Me.tabPrincipal = New System.Windows.Forms.TabControl()
        Me.tpNueva = New System.Windows.Forms.TabPage()
        Me.grpResumen = New System.Windows.Forms.GroupBox()
        Me.btnRevisar = New System.Windows.Forms.Button()
        Me.lblErrores = New System.Windows.Forms.Label()
        Me.lblNota = New System.Windows.Forms.Label()
        Me.lblResLitros = New System.Windows.Forms.Label()
        Me.lblResLitrosTit = New System.Windows.Forms.Label()
        Me.lblResTotal = New System.Windows.Forms.Label()
        Me.lblResTotalTit = New System.Windows.Forms.Label()
        Me.lblResProducto = New System.Windows.Forms.Label()
        Me.lblResProductoTit = New System.Windows.Forms.Label()
        Me.lblPlantas = New System.Windows.Forms.Label()
        Me.lblPlantasTit = New System.Windows.Forms.Label()
        Me.lblBandejas = New System.Windows.Forms.Label()
        Me.lblBandejasTit = New System.Windows.Forms.Label()
        Me.lblCantLotesTit = New System.Windows.Forms.Label()
        Me.lblCantLotes = New System.Windows.Forms.Label()
        Me.grpObs = New System.Windows.Forms.GroupBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.grpMezcla = New System.Windows.Forms.GroupBox()
        Me.pnlResultado = New System.Windows.Forms.Panel()
        Me.lblUtilizado = New System.Windows.Forms.Label()
        Me.lblUtilizadoTit = New System.Windows.Forms.Label()
        Me.lblSobrante = New System.Windows.Forms.Label()
        Me.lblSobranteTit = New System.Windows.Forms.Label()
        Me.lblEquiv = New System.Windows.Forms.Label()
        Me.lblEquivTit = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalTit = New System.Windows.Forms.Label()
        Me.chkTodaMezcla = New System.Windows.Forms.CheckBox()
        Me.txtLitrosUtilizados = New System.Windows.Forms.TextBox()
        Me.lblLitrosUtilizados = New System.Windows.Forms.Label()
        Me.txtSuperficie = New System.Windows.Forms.TextBox()
        Me.lblSuperficie = New System.Windows.Forms.Label()
        Me.txtDosis = New System.Windows.Forms.TextBox()
        Me.lblDosis = New System.Windows.Forms.Label()
        Me.txtLitrosPreparados = New System.Windows.Forms.TextBox()
        Me.lblLitrosPreparados = New System.Windows.Forms.Label()
        Me.cmbUnidad = New System.Windows.Forms.ComboBox()
        Me.lblUnidad = New System.Windows.Forms.Label()
        Me.cmbForma = New System.Windows.Forms.ComboBox()
        Me.lblForma = New System.Windows.Forms.Label()
        Me.cmbProducto = New System.Windows.Forms.ComboBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.grpLotes = New System.Windows.Forms.GroupBox()
        Me.gridLotes = New System.Windows.Forms.DataGridView()
        Me.colSel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colLote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCultivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMesa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBandejas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAlveolos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPlantas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSeleccion = New System.Windows.Forms.Label()
        Me.btnQuitarSeleccion = New System.Windows.Forms.Button()
        Me.btnSeleccionarResultados = New System.Windows.Forms.Button()
        Me.cmbCultivo = New System.Windows.Forms.ComboBox()
        Me.lblCultivo = New System.Windows.Forms.Label()
        Me.cmbMesa = New System.Windows.Forms.ComboBox()
        Me.lblMesa = New System.Windows.Forms.Label()
        Me.cmbNave = New System.Windows.Forms.ComboBox()
        Me.lblNave = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.lblMotivo = New System.Windows.Forms.Label()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.cmbAplicador = New System.Windows.Forms.ComboBox()
        Me.lblAplicador = New System.Windows.Forms.Label()
        Me.dtpHora = New System.Windows.Forms.DateTimePicker()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.tpHistorial = New System.Windows.Forms.TabPage()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.lblDetalleTit = New System.Windows.Forms.Label()
        Me.gridHistorial = New System.Windows.Forms.DataGridView()
        Me.hFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hAplicador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hCantLotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hPlantas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hUtilizado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hLitros = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAnular = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.chkAnuladas = New System.Windows.Forms.CheckBox()
        Me.txtBuscarHist = New System.Windows.Forms.TextBox()
        Me.lblBuscarHist = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.tabPrincipal.SuspendLayout()
        Me.tpNueva.SuspendLayout()
        Me.grpResumen.SuspendLayout()
        Me.grpObs.SuspendLayout()
        Me.grpMezcla.SuspendLayout()
        Me.pnlResultado.SuspendLayout()
        Me.grpLotes.SuspendLayout()
        CType(Me.gridLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatos.SuspendLayout()
        Me.tpHistorial.SuspendLayout()
        CType(Me.gridHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabPrincipal
        '
        Me.tabPrincipal.Controls.Add(Me.tpNueva)
        Me.tabPrincipal.Controls.Add(Me.tpHistorial)
        Me.tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tabPrincipal.Name = "tabPrincipal"
        Me.tabPrincipal.SelectedIndex = 0
        Me.tabPrincipal.Size = New System.Drawing.Size(1320, 700)
        Me.tabPrincipal.TabIndex = 0
        '
        'tpNueva
        '
        Me.tpNueva.Controls.Add(Me.grpResumen)
        Me.tpNueva.Controls.Add(Me.grpObs)
        Me.tpNueva.Controls.Add(Me.grpMezcla)
        Me.tpNueva.Controls.Add(Me.grpLotes)
        Me.tpNueva.Controls.Add(Me.grpDatos)
        Me.tpNueva.Location = New System.Drawing.Point(4, 24)
        Me.tpNueva.Name = "tpNueva"
        Me.tpNueva.Padding = New System.Windows.Forms.Padding(3)
        Me.tpNueva.Size = New System.Drawing.Size(1312, 672)
        Me.tpNueva.TabIndex = 0
        Me.tpNueva.Text = "Nueva aplicación"
        Me.tpNueva.UseVisualStyleBackColor = True
        '
        'grpResumen
        '
        Me.grpResumen.Controls.Add(Me.btnRevisar)
        Me.grpResumen.Controls.Add(Me.lblErrores)
        Me.grpResumen.Controls.Add(Me.lblNota)
        Me.grpResumen.Controls.Add(Me.lblResLitros)
        Me.grpResumen.Controls.Add(Me.lblResLitrosTit)
        Me.grpResumen.Controls.Add(Me.lblResTotal)
        Me.grpResumen.Controls.Add(Me.lblResTotalTit)
        Me.grpResumen.Controls.Add(Me.lblResProducto)
        Me.grpResumen.Controls.Add(Me.lblResProductoTit)
        Me.grpResumen.Controls.Add(Me.lblPlantas)
        Me.grpResumen.Controls.Add(Me.lblPlantasTit)
        Me.grpResumen.Controls.Add(Me.lblBandejas)
        Me.grpResumen.Controls.Add(Me.lblBandejasTit)
        Me.grpResumen.Controls.Add(Me.lblCantLotesTit)
        Me.grpResumen.Controls.Add(Me.lblCantLotes)
        Me.grpResumen.Location = New System.Drawing.Point(1006, 6)
        Me.grpResumen.Name = "grpResumen"
        Me.grpResumen.Size = New System.Drawing.Size(298, 658)
        Me.grpResumen.TabIndex = 4
        Me.grpResumen.TabStop = False
        Me.grpResumen.Text = "Resumen de aplicación"
        '
        'btnRevisar
        '
        Me.btnRevisar.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnRevisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRevisar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRevisar.ForeColor = System.Drawing.Color.White
        Me.btnRevisar.Location = New System.Drawing.Point(14, 604)
        Me.btnRevisar.Name = "btnRevisar"
        Me.btnRevisar.Size = New System.Drawing.Size(270, 42)
        Me.btnRevisar.TabIndex = 0
        Me.btnRevisar.Text = "Revisar aplicación →"
        Me.btnRevisar.UseVisualStyleBackColor = False
        '
        'lblErrores
        '
        Me.lblErrores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lblErrores.Location = New System.Drawing.Point(14, 330)
        Me.lblErrores.Name = "lblErrores"
        Me.lblErrores.Size = New System.Drawing.Size(270, 264)
        Me.lblErrores.TabIndex = 14
        '
        'lblNota
        '
        Me.lblNota.ForeColor = System.Drawing.Color.DimGray
        Me.lblNota.Location = New System.Drawing.Point(14, 278)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(270, 40)
        Me.lblNota.TabIndex = 13
        Me.lblNota.Text = "Se creará un único registro asociado a todos los lotes seleccionados."
        '
        'lblResLitros
        '
        Me.lblResLitros.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblResLitros.Location = New System.Drawing.Point(140, 240)
        Me.lblResLitros.Name = "lblResLitros"
        Me.lblResLitros.Size = New System.Drawing.Size(144, 20)
        Me.lblResLitros.TabIndex = 12
        Me.lblResLitros.Text = "—"
        Me.lblResLitros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblResLitrosTit
        '
        Me.lblResLitrosTit.ForeColor = System.Drawing.Color.DimGray
        Me.lblResLitrosTit.Location = New System.Drawing.Point(14, 240)
        Me.lblResLitrosTit.Name = "lblResLitrosTit"
        Me.lblResLitrosTit.Size = New System.Drawing.Size(124, 20)
        Me.lblResLitrosTit.TabIndex = 11
        Me.lblResLitrosTit.Text = "Litros utilizados"
        Me.lblResLitrosTit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblResTotal
        '
        Me.lblResTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblResTotal.Location = New System.Drawing.Point(140, 210)
        Me.lblResTotal.Name = "lblResTotal"
        Me.lblResTotal.Size = New System.Drawing.Size(144, 20)
        Me.lblResTotal.TabIndex = 10
        Me.lblResTotal.Text = "—"
        Me.lblResTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblResTotalTit
        '
        Me.lblResTotalTit.ForeColor = System.Drawing.Color.DimGray
        Me.lblResTotalTit.Location = New System.Drawing.Point(14, 210)
        Me.lblResTotalTit.Name = "lblResTotalTit"
        Me.lblResTotalTit.Size = New System.Drawing.Size(124, 20)
        Me.lblResTotalTit.TabIndex = 9
        Me.lblResTotalTit.Text = "Total de producto"
        Me.lblResTotalTit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblResProducto
        '
        Me.lblResProducto.AutoEllipsis = True
        Me.lblResProducto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblResProducto.Location = New System.Drawing.Point(90, 180)
        Me.lblResProducto.Name = "lblResProducto"
        Me.lblResProducto.Size = New System.Drawing.Size(194, 20)
        Me.lblResProducto.TabIndex = 8
        Me.lblResProducto.Text = "Sin indicar"
        Me.lblResProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblResProductoTit
        '
        Me.lblResProductoTit.ForeColor = System.Drawing.Color.DimGray
        Me.lblResProductoTit.Location = New System.Drawing.Point(14, 180)
        Me.lblResProductoTit.Name = "lblResProductoTit"
        Me.lblResProductoTit.Size = New System.Drawing.Size(74, 20)
        Me.lblResProductoTit.TabIndex = 7
        Me.lblResProductoTit.Text = "Producto"
        Me.lblResProductoTit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPlantas
        '
        Me.lblPlantas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPlantas.Location = New System.Drawing.Point(140, 150)
        Me.lblPlantas.Name = "lblPlantas"
        Me.lblPlantas.Size = New System.Drawing.Size(144, 20)
        Me.lblPlantas.TabIndex = 6
        Me.lblPlantas.Text = "0"
        Me.lblPlantas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPlantasTit
        '
        Me.lblPlantasTit.ForeColor = System.Drawing.Color.DimGray
        Me.lblPlantasTit.Location = New System.Drawing.Point(14, 150)
        Me.lblPlantasTit.Name = "lblPlantasTit"
        Me.lblPlantasTit.Size = New System.Drawing.Size(124, 20)
        Me.lblPlantasTit.TabIndex = 5
        Me.lblPlantasTit.Text = "Plantas tratadas"
        Me.lblPlantasTit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBandejas
        '
        Me.lblBandejas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBandejas.Location = New System.Drawing.Point(140, 120)
        Me.lblBandejas.Name = "lblBandejas"
        Me.lblBandejas.Size = New System.Drawing.Size(144, 20)
        Me.lblBandejas.TabIndex = 4
        Me.lblBandejas.Text = "0"
        Me.lblBandejas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBandejasTit
        '
        Me.lblBandejasTit.ForeColor = System.Drawing.Color.DimGray
        Me.lblBandejasTit.Location = New System.Drawing.Point(14, 120)
        Me.lblBandejasTit.Name = "lblBandejasTit"
        Me.lblBandejasTit.Size = New System.Drawing.Size(124, 20)
        Me.lblBandejasTit.TabIndex = 3
        Me.lblBandejasTit.Text = "Bandejas"
        Me.lblBandejasTit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCantLotesTit
        '
        Me.lblCantLotesTit.ForeColor = System.Drawing.Color.DimGray
        Me.lblCantLotesTit.Location = New System.Drawing.Point(14, 80)
        Me.lblCantLotesTit.Name = "lblCantLotesTit"
        Me.lblCantLotesTit.Size = New System.Drawing.Size(200, 20)
        Me.lblCantLotesTit.TabIndex = 2
        Me.lblCantLotesTit.Text = "lotes seleccionados"
        '
        'lblCantLotes
        '
        Me.lblCantLotes.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantLotes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.lblCantLotes.Location = New System.Drawing.Point(10, 28)
        Me.lblCantLotes.Name = "lblCantLotes"
        Me.lblCantLotes.Size = New System.Drawing.Size(200, 50)
        Me.lblCantLotes.TabIndex = 1
        Me.lblCantLotes.Text = "0"
        '
        'grpObs
        '
        Me.grpObs.Controls.Add(Me.txtObservaciones)
        Me.grpObs.Location = New System.Drawing.Point(8, 562)
        Me.grpObs.Name = "grpObs"
        Me.grpObs.Size = New System.Drawing.Size(990, 102)
        Me.grpObs.TabIndex = 3
        Me.grpObs.TabStop = False
        Me.grpObs.Text = "4. Observaciones"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(12, 22)
        Me.txtObservaciones.MaxLength = 1000
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(966, 70)
        Me.txtObservaciones.TabIndex = 0
        '
        'grpMezcla
        '
        Me.grpMezcla.Controls.Add(Me.pnlResultado)
        Me.grpMezcla.Controls.Add(Me.chkTodaMezcla)
        Me.grpMezcla.Controls.Add(Me.txtLitrosUtilizados)
        Me.grpMezcla.Controls.Add(Me.lblLitrosUtilizados)
        Me.grpMezcla.Controls.Add(Me.txtSuperficie)
        Me.grpMezcla.Controls.Add(Me.lblSuperficie)
        Me.grpMezcla.Controls.Add(Me.txtDosis)
        Me.grpMezcla.Controls.Add(Me.lblDosis)
        Me.grpMezcla.Controls.Add(Me.txtLitrosPreparados)
        Me.grpMezcla.Controls.Add(Me.lblLitrosPreparados)
        Me.grpMezcla.Controls.Add(Me.cmbUnidad)
        Me.grpMezcla.Controls.Add(Me.lblUnidad)
        Me.grpMezcla.Controls.Add(Me.cmbForma)
        Me.grpMezcla.Controls.Add(Me.lblForma)
        Me.grpMezcla.Controls.Add(Me.cmbProducto)
        Me.grpMezcla.Controls.Add(Me.lblProducto)
        Me.grpMezcla.Location = New System.Drawing.Point(8, 386)
        Me.grpMezcla.Name = "grpMezcla"
        Me.grpMezcla.Size = New System.Drawing.Size(990, 172)
        Me.grpMezcla.TabIndex = 2
        Me.grpMezcla.TabStop = False
        Me.grpMezcla.Text = "3. Producto y preparación de mezcla"
        '
        'pnlResultado
        '
        Me.pnlResultado.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.pnlResultado.Controls.Add(Me.lblUtilizado)
        Me.pnlResultado.Controls.Add(Me.lblUtilizadoTit)
        Me.pnlResultado.Controls.Add(Me.lblSobrante)
        Me.pnlResultado.Controls.Add(Me.lblSobranteTit)
        Me.pnlResultado.Controls.Add(Me.lblEquiv)
        Me.pnlResultado.Controls.Add(Me.lblEquivTit)
        Me.pnlResultado.Controls.Add(Me.lblTotal)
        Me.pnlResultado.Controls.Add(Me.lblTotalTit)
        Me.pnlResultado.Location = New System.Drawing.Point(12, 116)
        Me.pnlResultado.Name = "pnlResultado"
        Me.pnlResultado.Size = New System.Drawing.Size(966, 48)
        Me.pnlResultado.TabIndex = 15
        '
        'lblUtilizado
        '
        Me.lblUtilizado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblUtilizado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.lblUtilizado.Location = New System.Drawing.Point(726, 20)
        Me.lblUtilizado.Name = "lblUtilizado"
        Me.lblUtilizado.Size = New System.Drawing.Size(230, 24)
        Me.lblUtilizado.TabIndex = 7
        Me.lblUtilizado.Text = "—"
        '
        'lblUtilizadoTit
        '
        Me.lblUtilizadoTit.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.lblUtilizadoTit.ForeColor = System.Drawing.Color.DimGray
        Me.lblUtilizadoTit.Location = New System.Drawing.Point(726, 4)
        Me.lblUtilizadoTit.Name = "lblUtilizadoTit"
        Me.lblUtilizadoTit.Size = New System.Drawing.Size(230, 16)
        Me.lblUtilizadoTit.TabIndex = 6
        Me.lblUtilizadoTit.Text = "PRODUCTO UTILIZADO ESTIMADO"
        '
        'lblSobrante
        '
        Me.lblSobrante.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSobrante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.lblSobrante.Location = New System.Drawing.Point(486, 20)
        Me.lblSobrante.Name = "lblSobrante"
        Me.lblSobrante.Size = New System.Drawing.Size(230, 24)
        Me.lblSobrante.TabIndex = 5
        Me.lblSobrante.Text = "—"
        '
        'lblSobranteTit
        '
        Me.lblSobranteTit.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.lblSobranteTit.ForeColor = System.Drawing.Color.DimGray
        Me.lblSobranteTit.Location = New System.Drawing.Point(486, 4)
        Me.lblSobranteTit.Name = "lblSobranteTit"
        Me.lblSobranteTit.Size = New System.Drawing.Size(230, 16)
        Me.lblSobranteTit.TabIndex = 4
        Me.lblSobranteTit.Text = "LITROS SOBRANTES"
        '
        'lblEquiv
        '
        Me.lblEquiv.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblEquiv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.lblEquiv.Location = New System.Drawing.Point(246, 20)
        Me.lblEquiv.Name = "lblEquiv"
        Me.lblEquiv.Size = New System.Drawing.Size(230, 24)
        Me.lblEquiv.TabIndex = 3
        Me.lblEquiv.Text = "—"
        '
        'lblEquivTit
        '
        Me.lblEquivTit.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.lblEquivTit.ForeColor = System.Drawing.Color.DimGray
        Me.lblEquivTit.Location = New System.Drawing.Point(246, 4)
        Me.lblEquivTit.Name = "lblEquivTit"
        Me.lblEquivTit.Size = New System.Drawing.Size(230, 16)
        Me.lblEquivTit.TabIndex = 2
        Me.lblEquivTit.Text = "DOSIS EQUIVALENTE / AGUA"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(6, 20)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(230, 24)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "—"
        '
        'lblTotalTit
        '
        Me.lblTotalTit.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.lblTotalTit.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalTit.Location = New System.Drawing.Point(6, 4)
        Me.lblTotalTit.Name = "lblTotalTit"
        Me.lblTotalTit.Size = New System.Drawing.Size(230, 16)
        Me.lblTotalTit.TabIndex = 0
        Me.lblTotalTit.Text = "PRODUCTO TOTAL A INCORPORAR"
        '
        'chkTodaMezcla
        '
        Me.chkTodaMezcla.AutoSize = True
        Me.chkTodaMezcla.Location = New System.Drawing.Point(624, 86)
        Me.chkTodaMezcla.Name = "chkTodaMezcla"
        Me.chkTodaMezcla.Size = New System.Drawing.Size(162, 19)
        Me.chkTodaMezcla.TabIndex = 14
        Me.chkTodaMezcla.Text = "Se utilizó toda la mezcla"
        Me.chkTodaMezcla.UseVisualStyleBackColor = True
        '
        'txtLitrosUtilizados
        '
        Me.txtLitrosUtilizados.Location = New System.Drawing.Point(464, 84)
        Me.txtLitrosUtilizados.Name = "txtLitrosUtilizados"
        Me.txtLitrosUtilizados.Size = New System.Drawing.Size(150, 23)
        Me.txtLitrosUtilizados.TabIndex = 13
        '
        'lblLitrosUtilizados
        '
        Me.lblLitrosUtilizados.AutoSize = True
        Me.lblLitrosUtilizados.Location = New System.Drawing.Point(464, 66)
        Me.lblLitrosUtilizados.Name = "lblLitrosUtilizados"
        Me.lblLitrosUtilizados.Size = New System.Drawing.Size(92, 15)
        Me.lblLitrosUtilizados.TabIndex = 12
        Me.lblLitrosUtilizados.Text = "Litros utilizados"
        '
        'txtSuperficie
        '
        Me.txtSuperficie.Location = New System.Drawing.Point(334, 84)
        Me.txtSuperficie.Name = "txtSuperficie"
        Me.txtSuperficie.Size = New System.Drawing.Size(120, 23)
        Me.txtSuperficie.TabIndex = 11
        Me.txtSuperficie.Visible = False
        '
        'lblSuperficie
        '
        Me.lblSuperficie.AutoSize = True
        Me.lblSuperficie.Location = New System.Drawing.Point(334, 66)
        Me.lblSuperficie.Name = "lblSuperficie"
        Me.lblSuperficie.Size = New System.Drawing.Size(116, 15)
        Me.lblSuperficie.TabIndex = 10
        Me.lblSuperficie.Text = "Superficie tratada (m²)"
        Me.lblSuperficie.Visible = False
        '
        'txtDosis
        '
        Me.txtDosis.Location = New System.Drawing.Point(174, 84)
        Me.txtDosis.Name = "txtDosis"
        Me.txtDosis.Size = New System.Drawing.Size(150, 23)
        Me.txtDosis.TabIndex = 9
        '
        'lblDosis
        '
        Me.lblDosis.AutoSize = True
        Me.lblDosis.Location = New System.Drawing.Point(174, 66)
        Me.lblDosis.Name = "lblDosis"
        Me.lblDosis.Size = New System.Drawing.Size(73, 15)
        Me.lblDosis.TabIndex = 8
        Me.lblDosis.Text = "Dosis (mL/L)"
        '
        'txtLitrosPreparados
        '
        Me.txtLitrosPreparados.Location = New System.Drawing.Point(12, 84)
        Me.txtLitrosPreparados.Name = "txtLitrosPreparados"
        Me.txtLitrosPreparados.Size = New System.Drawing.Size(152, 23)
        Me.txtLitrosPreparados.TabIndex = 7
        '
        'lblLitrosPreparados
        '
        Me.lblLitrosPreparados.AutoSize = True
        Me.lblLitrosPreparados.Location = New System.Drawing.Point(12, 66)
        Me.lblLitrosPreparados.Name = "lblLitrosPreparados"
        Me.lblLitrosPreparados.Size = New System.Drawing.Size(150, 15)
        Me.lblLitrosPreparados.TabIndex = 6
        Me.lblLitrosPreparados.Text = "Litros preparados (agua)"
        '
        'cmbUnidad
        '
        Me.cmbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnidad.FormattingEnabled = True
        Me.cmbUnidad.Location = New System.Drawing.Point(564, 38)
        Me.cmbUnidad.Name = "cmbUnidad"
        Me.cmbUnidad.Size = New System.Drawing.Size(110, 23)
        Me.cmbUnidad.TabIndex = 5
        '
        'lblUnidad
        '
        Me.lblUnidad.AutoSize = True
        Me.lblUnidad.Location = New System.Drawing.Point(564, 20)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(115, 15)
        Me.lblUnidad.TabIndex = 4
        Me.lblUnidad.Text = "Unidad del producto"
        '
        'cmbForma
        '
        Me.cmbForma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbForma.FormattingEnabled = True
        Me.cmbForma.Location = New System.Drawing.Point(354, 38)
        Me.cmbForma.Name = "cmbForma"
        Me.cmbForma.Size = New System.Drawing.Size(200, 23)
        Me.cmbForma.TabIndex = 3
        '
        'lblForma
        '
        Me.lblForma.AutoSize = True
        Me.lblForma.Location = New System.Drawing.Point(354, 20)
        Me.lblForma.Name = "lblForma"
        Me.lblForma.Size = New System.Drawing.Size(96, 15)
        Me.lblForma.TabIndex = 2
        Me.lblForma.Text = "Forma de ingreso"
        '
        'cmbProducto
        '
        Me.cmbProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(12, 38)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(332, 23)
        Me.cmbProducto.TabIndex = 1
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(12, 20)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(115, 15)
        Me.lblProducto.TabIndex = 0
        Me.lblProducto.Text = "Nombre del producto"
        '
        'grpLotes
        '
        Me.grpLotes.Controls.Add(Me.gridLotes)
        Me.grpLotes.Controls.Add(Me.lblSeleccion)
        Me.grpLotes.Controls.Add(Me.btnQuitarSeleccion)
        Me.grpLotes.Controls.Add(Me.btnSeleccionarResultados)
        Me.grpLotes.Controls.Add(Me.cmbCultivo)
        Me.grpLotes.Controls.Add(Me.lblCultivo)
        Me.grpLotes.Controls.Add(Me.cmbMesa)
        Me.grpLotes.Controls.Add(Me.lblMesa)
        Me.grpLotes.Controls.Add(Me.cmbNave)
        Me.grpLotes.Controls.Add(Me.lblNave)
        Me.grpLotes.Controls.Add(Me.txtBuscar)
        Me.grpLotes.Controls.Add(Me.lblBuscar)
        Me.grpLotes.Location = New System.Drawing.Point(8, 82)
        Me.grpLotes.Name = "grpLotes"
        Me.grpLotes.Size = New System.Drawing.Size(990, 300)
        Me.grpLotes.TabIndex = 1
        Me.grpLotes.TabStop = False
        Me.grpLotes.Text = "2. Lotes que recibirán la aplicación"
        '
        'gridLotes
        '
        Me.gridLotes.AllowUserToAddRows = False
        Me.gridLotes.AllowUserToDeleteRows = False
        Me.gridLotes.AllowUserToResizeRows = False
        Me.gridLotes.BackgroundColor = System.Drawing.Color.White
        Me.gridLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridLotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSel, Me.colLote, Me.colCultivo, Me.colNave, Me.colMesa, Me.colBandejas, Me.colAlveolos, Me.colPlantas, Me.colEstado})
        Me.gridLotes.Location = New System.Drawing.Point(12, 98)
        Me.gridLotes.MultiSelect = False
        Me.gridLotes.Name = "gridLotes"
        Me.gridLotes.RowHeadersVisible = False
        Me.gridLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridLotes.Size = New System.Drawing.Size(966, 192)
        Me.gridLotes.TabIndex = 11
        '
        'colSel
        '
        Me.colSel.HeaderText = ""
        Me.colSel.Name = "colSel"
        Me.colSel.Width = 36
        '
        'colLote
        '
        Me.colLote.HeaderText = "N° lote"
        Me.colLote.Name = "colLote"
        Me.colLote.ReadOnly = True
        Me.colLote.Width = 70
        '
        'colCultivo
        '
        Me.colCultivo.HeaderText = "Cultivo / variedad"
        Me.colCultivo.Name = "colCultivo"
        Me.colCultivo.ReadOnly = True
        Me.colCultivo.Width = 260
        '
        'colNave
        '
        Me.colNave.HeaderText = "Nave"
        Me.colNave.Name = "colNave"
        Me.colNave.ReadOnly = True
        Me.colNave.Width = 60
        '
        'colMesa
        '
        Me.colMesa.HeaderText = "Mesa"
        Me.colMesa.Name = "colMesa"
        Me.colMesa.ReadOnly = True
        Me.colMesa.Width = 60
        '
        'colBandejas
        '
        Me.colBandejas.HeaderText = "Bandejas"
        Me.colBandejas.Name = "colBandejas"
        Me.colBandejas.ReadOnly = True
        Me.colBandejas.Width = 75
        '
        'colAlveolos
        '
        Me.colAlveolos.HeaderText = "Alvéolos / bandeja"
        Me.colAlveolos.Name = "colAlveolos"
        Me.colAlveolos.ReadOnly = True
        Me.colAlveolos.Width = 110
        '
        'colPlantas
        '
        Me.colPlantas.HeaderText = "Plantas"
        Me.colPlantas.Name = "colPlantas"
        Me.colPlantas.ReadOnly = True
        Me.colPlantas.Width = 85
        '
        'colEstado
        '
        Me.colEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colEstado.HeaderText = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.ReadOnly = True
        '
        'lblSeleccion
        '
        Me.lblSeleccion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSeleccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.lblSeleccion.Location = New System.Drawing.Point(560, 70)
        Me.lblSeleccion.Name = "lblSeleccion"
        Me.lblSeleccion.Size = New System.Drawing.Size(418, 20)
        Me.lblSeleccion.TabIndex = 10
        Me.lblSeleccion.Text = "0 seleccionados · 0 visibles"
        Me.lblSeleccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnQuitarSeleccion
        '
        Me.btnQuitarSeleccion.Location = New System.Drawing.Point(180, 66)
        Me.btnQuitarSeleccion.Name = "btnQuitarSeleccion"
        Me.btnQuitarSeleccion.Size = New System.Drawing.Size(170, 27)
        Me.btnQuitarSeleccion.TabIndex = 9
        Me.btnQuitarSeleccion.Text = "Quitar toda la selección"
        Me.btnQuitarSeleccion.UseVisualStyleBackColor = True
        '
        'btnSeleccionarResultados
        '
        Me.btnSeleccionarResultados.Location = New System.Drawing.Point(12, 66)
        Me.btnSeleccionarResultados.Name = "btnSeleccionarResultados"
        Me.btnSeleccionarResultados.Size = New System.Drawing.Size(160, 27)
        Me.btnSeleccionarResultados.TabIndex = 8
        Me.btnSeleccionarResultados.Text = "Seleccionar resultados"
        Me.btnSeleccionarResultados.UseVisualStyleBackColor = True
        '
        'cmbCultivo
        '
        Me.cmbCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCultivo.FormattingEnabled = True
        Me.cmbCultivo.Location = New System.Drawing.Point(574, 38)
        Me.cmbCultivo.Name = "cmbCultivo"
        Me.cmbCultivo.Size = New System.Drawing.Size(200, 23)
        Me.cmbCultivo.TabIndex = 7
        '
        'lblCultivo
        '
        Me.lblCultivo.AutoSize = True
        Me.lblCultivo.Location = New System.Drawing.Point(574, 20)
        Me.lblCultivo.Name = "lblCultivo"
        Me.lblCultivo.Size = New System.Drawing.Size(46, 15)
        Me.lblCultivo.TabIndex = 6
        Me.lblCultivo.Text = "Cultivo"
        '
        'cmbMesa
        '
        Me.cmbMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMesa.FormattingEnabled = True
        Me.cmbMesa.Location = New System.Drawing.Point(464, 38)
        Me.cmbMesa.Name = "cmbMesa"
        Me.cmbMesa.Size = New System.Drawing.Size(100, 23)
        Me.cmbMesa.TabIndex = 5
        '
        'lblMesa
        '
        Me.lblMesa.AutoSize = True
        Me.lblMesa.Location = New System.Drawing.Point(464, 20)
        Me.lblMesa.Name = "lblMesa"
        Me.lblMesa.Size = New System.Drawing.Size(34, 15)
        Me.lblMesa.TabIndex = 4
        Me.lblMesa.Text = "Mesa"
        '
        'cmbNave
        '
        Me.cmbNave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNave.FormattingEnabled = True
        Me.cmbNave.Location = New System.Drawing.Point(354, 38)
        Me.cmbNave.Name = "cmbNave"
        Me.cmbNave.Size = New System.Drawing.Size(100, 23)
        Me.cmbNave.TabIndex = 3
        '
        'lblNave
        '
        Me.lblNave.AutoSize = True
        Me.lblNave.Location = New System.Drawing.Point(354, 20)
        Me.lblNave.Name = "lblNave"
        Me.lblNave.Size = New System.Drawing.Size(34, 15)
        Me.lblNave.TabIndex = 2
        Me.lblNave.Text = "Nave"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(12, 38)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(332, 23)
        Me.txtBuscar.TabIndex = 1
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(12, 20)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(181, 15)
        Me.lblBuscar.TabIndex = 0
        Me.lblBuscar.Text = "Buscar N° de lote, cultivo o variedad"
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.txtMotivo)
        Me.grpDatos.Controls.Add(Me.lblMotivo)
        Me.grpDatos.Controls.Add(Me.cmbTipo)
        Me.grpDatos.Controls.Add(Me.lblTipo)
        Me.grpDatos.Controls.Add(Me.cmbAplicador)
        Me.grpDatos.Controls.Add(Me.lblAplicador)
        Me.grpDatos.Controls.Add(Me.dtpHora)
        Me.grpDatos.Controls.Add(Me.lblHora)
        Me.grpDatos.Controls.Add(Me.dtpFecha)
        Me.grpDatos.Controls.Add(Me.lblFecha)
        Me.grpDatos.Location = New System.Drawing.Point(8, 6)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(990, 72)
        Me.grpDatos.TabIndex = 0
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "1. Datos de la aplicación"
        '
        'txtMotivo
        '
        Me.txtMotivo.Location = New System.Drawing.Point(634, 38)
        Me.txtMotivo.MaxLength = 200
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(344, 23)
        Me.txtMotivo.TabIndex = 9
        '
        'lblMotivo
        '
        Me.lblMotivo.AutoSize = True
        Me.lblMotivo.Location = New System.Drawing.Point(634, 20)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(238, 15)
        Me.lblMotivo.TabIndex = 8
        Me.lblMotivo.Text = "Motivo de aplicación (ej.: tratamiento preventivo)"
        '
        'cmbTipo
        '
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(454, 38)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(170, 23)
        Me.cmbTipo.TabIndex = 7
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(454, 20)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(106, 15)
        Me.lblTipo.TabIndex = 6
        Me.lblTipo.Text = "Tipo de aplicación"
        '
        'cmbAplicador
        '
        Me.cmbAplicador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAplicador.FormattingEnabled = True
        Me.cmbAplicador.Location = New System.Drawing.Point(224, 38)
        Me.cmbAplicador.Name = "cmbAplicador"
        Me.cmbAplicador.Size = New System.Drawing.Size(220, 23)
        Me.cmbAplicador.TabIndex = 5
        '
        'lblAplicador
        '
        Me.lblAplicador.AutoSize = True
        Me.lblAplicador.Location = New System.Drawing.Point(224, 20)
        Me.lblAplicador.Name = "lblAplicador"
        Me.lblAplicador.Size = New System.Drawing.Size(107, 15)
        Me.lblAplicador.TabIndex = 4
        Me.lblAplicador.Text = "Persona que aplica"
        '
        'dtpHora
        '
        Me.dtpHora.CustomFormat = "HH:mm"
        Me.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHora.Location = New System.Drawing.Point(134, 38)
        Me.dtpHora.Name = "dtpHora"
        Me.dtpHora.ShowUpDown = True
        Me.dtpHora.Size = New System.Drawing.Size(80, 23)
        Me.dtpHora.TabIndex = 3
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(134, 20)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(33, 15)
        Me.lblHora.TabIndex = 2
        Me.lblHora.Text = "Hora"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(12, 38)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(112, 23)
        Me.dtpFecha.TabIndex = 1
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(12, 20)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(38, 15)
        Me.lblFecha.TabIndex = 0
        Me.lblFecha.Text = "Fecha"
        '
        'tpHistorial
        '
        Me.tpHistorial.Controls.Add(Me.txtDetalle)
        Me.tpHistorial.Controls.Add(Me.lblDetalleTit)
        Me.tpHistorial.Controls.Add(Me.gridHistorial)
        Me.tpHistorial.Controls.Add(Me.btnAnular)
        Me.tpHistorial.Controls.Add(Me.btnExportar)
        Me.tpHistorial.Controls.Add(Me.btnBuscar)
        Me.tpHistorial.Controls.Add(Me.chkAnuladas)
        Me.tpHistorial.Controls.Add(Me.txtBuscarHist)
        Me.tpHistorial.Controls.Add(Me.lblBuscarHist)
        Me.tpHistorial.Controls.Add(Me.dtpHasta)
        Me.tpHistorial.Controls.Add(Me.lblHasta)
        Me.tpHistorial.Controls.Add(Me.dtpDesde)
        Me.tpHistorial.Controls.Add(Me.lblDesde)
        Me.tpHistorial.Location = New System.Drawing.Point(4, 24)
        Me.tpHistorial.Name = "tpHistorial"
        Me.tpHistorial.Padding = New System.Windows.Forms.Padding(3)
        Me.tpHistorial.Size = New System.Drawing.Size(1312, 672)
        Me.tpHistorial.TabIndex = 1
        Me.tpHistorial.Text = "Historial de aplicaciones"
        Me.tpHistorial.UseVisualStyleBackColor = True
        '
        'txtDetalle
        '
        Me.txtDetalle.BackColor = System.Drawing.Color.White
        Me.txtDetalle.Location = New System.Drawing.Point(8, 488)
        Me.txtDetalle.Multiline = True
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.ReadOnly = True
        Me.txtDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetalle.Size = New System.Drawing.Size(1296, 176)
        Me.txtDetalle.TabIndex = 12
        '
        'lblDetalleTit
        '
        Me.lblDetalleTit.AutoSize = True
        Me.lblDetalleTit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDetalleTit.Location = New System.Drawing.Point(8, 468)
        Me.lblDetalleTit.Name = "lblDetalleTit"
        Me.lblDetalleTit.Size = New System.Drawing.Size(165, 15)
        Me.lblDetalleTit.TabIndex = 11
        Me.lblDetalleTit.Text = "Detalle de la aplicación"
        '
        'gridHistorial
        '
        Me.gridHistorial.AllowUserToAddRows = False
        Me.gridHistorial.AllowUserToDeleteRows = False
        Me.gridHistorial.AllowUserToResizeRows = False
        Me.gridHistorial.BackgroundColor = System.Drawing.Color.White
        Me.gridHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridHistorial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.hFecha, Me.hProducto, Me.hTipo, Me.hAplicador, Me.hCantLotes, Me.hPlantas, Me.hTotal, Me.hUtilizado, Me.hLitros, Me.hEstado})
        Me.gridHistorial.Location = New System.Drawing.Point(8, 64)
        Me.gridHistorial.MultiSelect = False
        Me.gridHistorial.Name = "gridHistorial"
        Me.gridHistorial.ReadOnly = True
        Me.gridHistorial.RowHeadersVisible = False
        Me.gridHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridHistorial.Size = New System.Drawing.Size(1296, 396)
        Me.gridHistorial.TabIndex = 10
        '
        'hFecha
        '
        Me.hFecha.DataPropertyName = "FechaAplicacion"
        Me.hFecha.HeaderText = "Fecha y hora"
        Me.hFecha.Name = "hFecha"
        Me.hFecha.ReadOnly = True
        Me.hFecha.Width = 120
        '
        'hProducto
        '
        Me.hProducto.DataPropertyName = "Producto"
        Me.hProducto.HeaderText = "Producto"
        Me.hProducto.Name = "hProducto"
        Me.hProducto.ReadOnly = True
        Me.hProducto.Width = 220
        '
        'hTipo
        '
        Me.hTipo.DataPropertyName = "Tipo"
        Me.hTipo.HeaderText = "Tipo"
        Me.hTipo.Name = "hTipo"
        Me.hTipo.ReadOnly = True
        Me.hTipo.Width = 120
        '
        'hAplicador
        '
        Me.hAplicador.DataPropertyName = "Aplicador"
        Me.hAplicador.HeaderText = "Aplicador"
        Me.hAplicador.Name = "hAplicador"
        Me.hAplicador.ReadOnly = True
        Me.hAplicador.Width = 180
        '
        'hCantLotes
        '
        Me.hCantLotes.DataPropertyName = "CantLotes"
        Me.hCantLotes.HeaderText = "Lotes"
        Me.hCantLotes.Name = "hCantLotes"
        Me.hCantLotes.ReadOnly = True
        Me.hCantLotes.Width = 60
        '
        'hPlantas
        '
        Me.hPlantas.DataPropertyName = "Plantas"
        Me.hPlantas.HeaderText = "Plantas"
        Me.hPlantas.Name = "hPlantas"
        Me.hPlantas.ReadOnly = True
        Me.hPlantas.Width = 80
        '
        'hTotal
        '
        Me.hTotal.DataPropertyName = "TotalTexto"
        Me.hTotal.HeaderText = "Producto total"
        Me.hTotal.Name = "hTotal"
        Me.hTotal.ReadOnly = True
        Me.hTotal.Width = 110
        '
        'hUtilizado
        '
        Me.hUtilizado.DataPropertyName = "UtilizadoTexto"
        Me.hUtilizado.HeaderText = "Producto utilizado"
        Me.hUtilizado.Name = "hUtilizado"
        Me.hUtilizado.ReadOnly = True
        Me.hUtilizado.Width = 120
        '
        'hLitros
        '
        Me.hLitros.DataPropertyName = "LitrosTexto"
        Me.hLitros.HeaderText = "Litros usados / preparados"
        Me.hLitros.Name = "hLitros"
        Me.hLitros.ReadOnly = True
        Me.hLitros.Width = 160
        '
        'hEstado
        '
        Me.hEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.hEstado.DataPropertyName = "EstadoTexto"
        Me.hEstado.HeaderText = "Estado"
        Me.hEstado.Name = "hEstado"
        Me.hEstado.ReadOnly = True
        '
        'btnAnular
        '
        Me.btnAnular.Location = New System.Drawing.Point(1166, 28)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(138, 27)
        Me.btnAnular.TabIndex = 9
        Me.btnAnular.Text = "Anular aplicación"
        Me.btnAnular.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(1020, 28)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(138, 27)
        Me.btnExportar.TabIndex = 8
        Me.btnExportar.Text = "↓ Exportar a Excel"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(650, 28)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 27)
        Me.btnBuscar.TabIndex = 7
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'chkAnuladas
        '
        Me.chkAnuladas.AutoSize = True
        Me.chkAnuladas.Location = New System.Drawing.Point(524, 32)
        Me.chkAnuladas.Name = "chkAnuladas"
        Me.chkAnuladas.Size = New System.Drawing.Size(114, 19)
        Me.chkAnuladas.TabIndex = 6
        Me.chkAnuladas.Text = "Incluir anuladas"
        Me.chkAnuladas.UseVisualStyleBackColor = True
        '
        'txtBuscarHist
        '
        Me.txtBuscarHist.Location = New System.Drawing.Point(244, 30)
        Me.txtBuscarHist.Name = "txtBuscarHist"
        Me.txtBuscarHist.Size = New System.Drawing.Size(270, 23)
        Me.txtBuscarHist.TabIndex = 5
        '
        'lblBuscarHist
        '
        Me.lblBuscarHist.AutoSize = True
        Me.lblBuscarHist.Location = New System.Drawing.Point(244, 12)
        Me.lblBuscarHist.Name = "lblBuscarHist"
        Me.lblBuscarHist.Size = New System.Drawing.Size(212, 15)
        Me.lblBuscarHist.TabIndex = 4
        Me.lblBuscarHist.Text = "Buscar por N° de lote, producto o aplicador"
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(126, 30)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(110, 23)
        Me.dtpHasta.TabIndex = 3
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(126, 12)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(37, 15)
        Me.lblHasta.TabIndex = 2
        Me.lblHasta.Text = "Hasta"
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(8, 30)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(110, 23)
        Me.dtpDesde.TabIndex = 1
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Location = New System.Drawing.Point(8, 12)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(39, 15)
        Me.lblDesde.TabIndex = 0
        Me.lblDesde.Text = "Desde"
        '
        'AplicacionProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 700)
        Me.Controls.Add(Me.tabPrincipal)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AplicacionProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicación de Productos"
        Me.tabPrincipal.ResumeLayout(False)
        Me.tpNueva.ResumeLayout(False)
        Me.grpResumen.ResumeLayout(False)
        Me.grpObs.ResumeLayout(False)
        Me.grpObs.PerformLayout()
        Me.grpMezcla.ResumeLayout(False)
        Me.grpMezcla.PerformLayout()
        Me.pnlResultado.ResumeLayout(False)
        Me.grpLotes.ResumeLayout(False)
        Me.grpLotes.PerformLayout()
        CType(Me.gridLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        Me.tpHistorial.ResumeLayout(False)
        Me.tpHistorial.PerformLayout()
        CType(Me.gridHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabPrincipal As TabControl
    Friend WithEvents tpNueva As TabPage
    Friend WithEvents tpHistorial As TabPage
    Friend WithEvents grpDatos As GroupBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents lblHora As Label
    Friend WithEvents dtpHora As DateTimePicker
    Friend WithEvents lblAplicador As Label
    Friend WithEvents cmbAplicador As ComboBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents lblMotivo As Label
    Friend WithEvents txtMotivo As TextBox
    Friend WithEvents grpLotes As GroupBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents lblNave As Label
    Friend WithEvents cmbNave As ComboBox
    Friend WithEvents lblMesa As Label
    Friend WithEvents cmbMesa As ComboBox
    Friend WithEvents lblCultivo As Label
    Friend WithEvents cmbCultivo As ComboBox
    Friend WithEvents btnSeleccionarResultados As Button
    Friend WithEvents btnQuitarSeleccion As Button
    Friend WithEvents lblSeleccion As Label
    Friend WithEvents gridLotes As DataGridView
    Friend WithEvents colSel As DataGridViewCheckBoxColumn
    Friend WithEvents colLote As DataGridViewTextBoxColumn
    Friend WithEvents colCultivo As DataGridViewTextBoxColumn
    Friend WithEvents colNave As DataGridViewTextBoxColumn
    Friend WithEvents colMesa As DataGridViewTextBoxColumn
    Friend WithEvents colBandejas As DataGridViewTextBoxColumn
    Friend WithEvents colAlveolos As DataGridViewTextBoxColumn
    Friend WithEvents colPlantas As DataGridViewTextBoxColumn
    Friend WithEvents colEstado As DataGridViewTextBoxColumn
    Friend WithEvents grpMezcla As GroupBox
    Friend WithEvents lblProducto As Label
    Friend WithEvents cmbProducto As ComboBox
    Friend WithEvents lblForma As Label
    Friend WithEvents cmbForma As ComboBox
    Friend WithEvents lblUnidad As Label
    Friend WithEvents cmbUnidad As ComboBox
    Friend WithEvents lblLitrosPreparados As Label
    Friend WithEvents txtLitrosPreparados As TextBox
    Friend WithEvents lblDosis As Label
    Friend WithEvents txtDosis As TextBox
    Friend WithEvents lblSuperficie As Label
    Friend WithEvents txtSuperficie As TextBox
    Friend WithEvents lblLitrosUtilizados As Label
    Friend WithEvents txtLitrosUtilizados As TextBox
    Friend WithEvents chkTodaMezcla As CheckBox
    Friend WithEvents pnlResultado As Panel
    Friend WithEvents lblTotalTit As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblEquivTit As Label
    Friend WithEvents lblEquiv As Label
    Friend WithEvents lblSobranteTit As Label
    Friend WithEvents lblSobrante As Label
    Friend WithEvents lblUtilizadoTit As Label
    Friend WithEvents lblUtilizado As Label
    Friend WithEvents grpObs As GroupBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents grpResumen As GroupBox
    Friend WithEvents lblCantLotes As Label
    Friend WithEvents lblCantLotesTit As Label
    Friend WithEvents lblBandejasTit As Label
    Friend WithEvents lblBandejas As Label
    Friend WithEvents lblPlantasTit As Label
    Friend WithEvents lblPlantas As Label
    Friend WithEvents lblResProductoTit As Label
    Friend WithEvents lblResProducto As Label
    Friend WithEvents lblResTotalTit As Label
    Friend WithEvents lblResTotal As Label
    Friend WithEvents lblResLitrosTit As Label
    Friend WithEvents lblResLitros As Label
    Friend WithEvents lblNota As Label
    Friend WithEvents lblErrores As Label
    Friend WithEvents btnRevisar As Button
    Friend WithEvents lblDesde As Label
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents lblHasta As Label
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents lblBuscarHist As Label
    Friend WithEvents txtBuscarHist As TextBox
    Friend WithEvents chkAnuladas As CheckBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnAnular As Button
    Friend WithEvents gridHistorial As DataGridView
    Friend WithEvents hFecha As DataGridViewTextBoxColumn
    Friend WithEvents hProducto As DataGridViewTextBoxColumn
    Friend WithEvents hTipo As DataGridViewTextBoxColumn
    Friend WithEvents hAplicador As DataGridViewTextBoxColumn
    Friend WithEvents hCantLotes As DataGridViewTextBoxColumn
    Friend WithEvents hPlantas As DataGridViewTextBoxColumn
    Friend WithEvents hTotal As DataGridViewTextBoxColumn
    Friend WithEvents hUtilizado As DataGridViewTextBoxColumn
    Friend WithEvents hLitros As DataGridViewTextBoxColumn
    Friend WithEvents hEstado As DataGridViewTextBoxColumn
    Friend WithEvents lblDetalleTit As Label
    Friend WithEvents txtDetalle As TextBox
End Class
