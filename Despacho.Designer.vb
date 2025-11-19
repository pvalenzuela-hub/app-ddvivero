<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Despacho
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtNumDesp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.txtPatente = New System.Windows.Forms.TextBox()
        Me.txtNomChofer = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtSerieLotes = New System.Windows.Forms.TextBox()
        Me.chkGuias = New System.Windows.Forms.CheckBox()
        Me.btnEmiteGuia = New System.Windows.Forms.Button()
        Me.btncarga = New System.Windows.Forms.Button()
        Me.btndespacho = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txthorafin = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtkmfin = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txthoraini = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtkmini = New System.Windows.Forms.TextBox()
        Me.txtTotalBand = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GrillaDespacho = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NumLoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZonaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuerdoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDGUIADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaGuiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalGuiaIVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SPConsultaDespDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GESTDataSet33 = New GestionVivero.GESTDataSet33()
        Me.SP_ConsultaDespDTableAdapter = New GestionVivero.GESTDataSet33TableAdapters.SP_ConsultaDespDTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GrillaDespacho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPConsultaDespDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTDataSet33, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNumDesp
        '
        Me.txtNumDesp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtNumDesp.Location = New System.Drawing.Point(173, 22)
        Me.txtNumDesp.Name = "txtNumDesp"
        Me.txtNumDesp.Size = New System.Drawing.Size(105, 20)
        Me.txtNumDesp.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Estado:"
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Ingreso", "Despacho", "Retorno", "Anulado"})
        Me.cmbEstado.Location = New System.Drawing.Point(173, 163)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(355, 21)
        Me.cmbEstado.TabIndex = 24
        '
        'txtPatente
        '
        Me.txtPatente.Location = New System.Drawing.Point(173, 129)
        Me.txtPatente.MaxLength = 10
        Me.txtPatente.Name = "txtPatente"
        Me.txtPatente.Size = New System.Drawing.Size(355, 20)
        Me.txtPatente.TabIndex = 23
        '
        'txtNomChofer
        '
        Me.txtNomChofer.Location = New System.Drawing.Point(173, 96)
        Me.txtNomChofer.MaxLength = 30
        Me.txtNomChofer.Name = "txtNomChofer"
        Me.txtNomChofer.Size = New System.Drawing.Size(355, 20)
        Me.txtNomChofer.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Patente Vehículo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nombre Chofer:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(173, 63)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(105, 20)
        Me.DateTimePicker1.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Fecha Despacho:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSerieLotes)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkGuias)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnEmiteGuia)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btncarga)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btndespacho)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtTotalBand)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtNumDesp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbEstado)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPatente)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtNomChofer)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GrillaDespacho)
        Me.SplitContainer1.Size = New System.Drawing.Size(1212, 740)
        Me.SplitContainer1.SplitterDistance = 318
        Me.SplitContainer1.TabIndex = 26
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Image = Global.GestionVivero.My.Resources.Resources.R_images0031
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(804, 245)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 70)
        Me.Button4.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.Button4, "Vuelve Lote a Preparación")
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Image = Global.GestionVivero.My.Resources.Resources.buscar_40x40
        Me.Button3.Location = New System.Drawing.Point(296, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(49, 49)
        Me.Button3.TabIndex = 42
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtSerieLotes
        '
        Me.txtSerieLotes.Location = New System.Drawing.Point(37, 218)
        Me.txtSerieLotes.Name = "txtSerieLotes"
        Me.txtSerieLotes.Size = New System.Drawing.Size(100, 20)
        Me.txtSerieLotes.TabIndex = 41
        Me.txtSerieLotes.Visible = False
        '
        'chkGuias
        '
        Me.chkGuias.AutoSize = True
        Me.chkGuias.Enabled = False
        Me.chkGuias.Location = New System.Drawing.Point(1026, 298)
        Me.chkGuias.Name = "chkGuias"
        Me.chkGuias.Size = New System.Drawing.Size(181, 17)
        Me.chkGuias.TabIndex = 40
        Me.chkGuias.Text = "Emitir Guías para todos los Lotes"
        Me.chkGuias.UseVisualStyleBackColor = True
        '
        'btnEmiteGuia
        '
        Me.btnEmiteGuia.BackColor = System.Drawing.Color.White
        Me.btnEmiteGuia.Enabled = False
        Me.btnEmiteGuia.Image = Global.GestionVivero.My.Resources.Resources.page_productos_at_item3
        Me.btnEmiteGuia.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEmiteGuia.Location = New System.Drawing.Point(1119, 192)
        Me.btnEmiteGuia.Name = "btnEmiteGuia"
        Me.btnEmiteGuia.Size = New System.Drawing.Size(90, 100)
        Me.btnEmiteGuia.TabIndex = 39
        Me.btnEmiteGuia.Text = "Guía   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             "
        Me.btnEmiteGuia.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEmiteGuia.UseVisualStyleBackColor = False
        '
        'btncarga
        '
        Me.btncarga.BackColor = System.Drawing.Color.White
        Me.btncarga.Enabled = False
        Me.btncarga.Image = Global.GestionVivero.My.Resources.Resources.Carga99x72
        Me.btncarga.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncarga.Location = New System.Drawing.Point(1119, 96)
        Me.btncarga.Name = "btncarga"
        Me.btncarga.Size = New System.Drawing.Size(90, 90)
        Me.btncarga.TabIndex = 38
        Me.btncarga.Text = "Carga"
        Me.btncarga.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncarga.UseVisualStyleBackColor = False
        '
        'btndespacho
        '
        Me.btndespacho.BackColor = System.Drawing.Color.White
        Me.btndespacho.Enabled = False
        Me.btndespacho.Image = Global.GestionVivero.My.Resources.Resources.Despacho99x72
        Me.btndespacho.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btndespacho.Location = New System.Drawing.Point(1119, 3)
        Me.btndespacho.Name = "btndespacho"
        Me.btndespacho.Size = New System.Drawing.Size(90, 90)
        Me.btndespacho.TabIndex = 37
        Me.btndespacho.Text = "Despacho"
        Me.btndespacho.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndespacho.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txthorafin)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtkmfin)
        Me.GroupBox2.Location = New System.Drawing.Point(557, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 92)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Retorno"
        '
        'txthorafin
        '
        Me.txthorafin.Location = New System.Drawing.Point(109, 52)
        Me.txthorafin.Mask = "00:00"
        Me.txthorafin.Name = "txthorafin"
        Me.txthorafin.ReadOnly = True
        Me.txthorafin.Size = New System.Drawing.Size(57, 20)
        Me.txthorafin.TabIndex = 35
        Me.txthorafin.ValidatingType = GetType(Date)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Hora:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Km final:"
        '
        'txtkmfin
        '
        Me.txtkmfin.Location = New System.Drawing.Point(109, 23)
        Me.txtkmfin.MaxLength = 10
        Me.txtkmfin.Name = "txtkmfin"
        Me.txtkmfin.ReadOnly = True
        Me.txtkmfin.Size = New System.Drawing.Size(57, 20)
        Me.txtkmfin.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txthoraini)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtkmini)
        Me.GroupBox1.Location = New System.Drawing.Point(557, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 92)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Despacho"
        '
        'txthoraini
        '
        Me.txthoraini.Location = New System.Drawing.Point(109, 52)
        Me.txthoraini.Mask = "00:00"
        Me.txthoraini.Name = "txthoraini"
        Me.txthoraini.ReadOnly = True
        Me.txthoraini.RejectInputOnFirstFailure = True
        Me.txthoraini.Size = New System.Drawing.Size(57, 20)
        Me.txthoraini.TabIndex = 35
        Me.txthoraini.ValidatingType = GetType(Date)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Hora:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Km inicial:"
        '
        'txtkmini
        '
        Me.txtkmini.Location = New System.Drawing.Point(109, 23)
        Me.txtkmini.MaxLength = 10
        Me.txtkmini.Name = "txtkmini"
        Me.txtkmini.ReadOnly = True
        Me.txtkmini.Size = New System.Drawing.Size(57, 20)
        Me.txtkmini.TabIndex = 32
        '
        'txtTotalBand
        '
        Me.txtTotalBand.Location = New System.Drawing.Point(173, 196)
        Me.txtTotalBand.Name = "txtTotalBand"
        Me.txtTotalBand.ReadOnly = True
        Me.txtTotalBand.Size = New System.Drawing.Size(355, 20)
        Me.txtTotalBand.TabIndex = 28
        Me.txtTotalBand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Total Bandejas Despacho:"
        '
        'Button2
        '
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(37, 283)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(147, 32)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Actualiza Despacho"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.PREVIEW
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(37, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 24)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Despachos"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GrillaDespacho
        '
        Me.GrillaDespacho.AllowUserToAddRows = False
        Me.GrillaDespacho.AllowUserToDeleteRows = False
        Me.GrillaDespacho.AllowUserToOrderColumns = True
        Me.GrillaDespacho.AutoGenerateColumns = False
        Me.GrillaDespacho.BackgroundColor = System.Drawing.Color.White
        Me.GrillaDespacho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaDespacho.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.NumLoteDataGridViewTextBoxColumn, Me.SectorDataGridViewTextBoxColumn, Me.ZonaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.FonoDataGridViewTextBoxColumn, Me.AcuerdoDataGridViewTextBoxColumn, Me.DESCRIPDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.BandDataGridViewTextBoxColumn, Me.IDGUIADataGridViewTextBoxColumn, Me.FechaGuiaDataGridViewTextBoxColumn, Me.TotalGuiaIVADataGridViewTextBoxColumn})
        Me.GrillaDespacho.DataSource = Me.SPConsultaDespDBindingSource
        Me.GrillaDespacho.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaDespacho.Location = New System.Drawing.Point(0, 0)
        Me.GrillaDespacho.Name = "GrillaDespacho"
        Me.GrillaDespacho.RowHeadersVisible = False
        Me.GrillaDespacho.Size = New System.Drawing.Size(1212, 418)
        Me.GrillaDespacho.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column1.HeaderText = "Guías"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 42
        '
        'NumLoteDataGridViewTextBoxColumn
        '
        Me.NumLoteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NumLoteDataGridViewTextBoxColumn.DataPropertyName = "NumLote"
        Me.NumLoteDataGridViewTextBoxColumn.HeaderText = "Nº Lote"
        Me.NumLoteDataGridViewTextBoxColumn.Name = "NumLoteDataGridViewTextBoxColumn"
        Me.NumLoteDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumLoteDataGridViewTextBoxColumn.Width = 68
        '
        'SectorDataGridViewTextBoxColumn
        '
        Me.SectorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SectorDataGridViewTextBoxColumn.DataPropertyName = "Sector"
        Me.SectorDataGridViewTextBoxColumn.HeaderText = "Sector"
        Me.SectorDataGridViewTextBoxColumn.Name = "SectorDataGridViewTextBoxColumn"
        Me.SectorDataGridViewTextBoxColumn.ReadOnly = True
        Me.SectorDataGridViewTextBoxColumn.Width = 63
        '
        'ZonaDataGridViewTextBoxColumn
        '
        Me.ZonaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ZonaDataGridViewTextBoxColumn.DataPropertyName = "Zona"
        Me.ZonaDataGridViewTextBoxColumn.HeaderText = "Zona"
        Me.ZonaDataGridViewTextBoxColumn.Name = "ZonaDataGridViewTextBoxColumn"
        Me.ZonaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ZonaDataGridViewTextBoxColumn.Width = 57
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 64
        '
        'FonoDataGridViewTextBoxColumn
        '
        Me.FonoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FonoDataGridViewTextBoxColumn.DataPropertyName = "Fono"
        Me.FonoDataGridViewTextBoxColumn.HeaderText = "Fono"
        Me.FonoDataGridViewTextBoxColumn.Name = "FonoDataGridViewTextBoxColumn"
        Me.FonoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FonoDataGridViewTextBoxColumn.Width = 56
        '
        'AcuerdoDataGridViewTextBoxColumn
        '
        Me.AcuerdoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.AcuerdoDataGridViewTextBoxColumn.DataPropertyName = "Acuerdo"
        Me.AcuerdoDataGridViewTextBoxColumn.HeaderText = "Acuerdo"
        Me.AcuerdoDataGridViewTextBoxColumn.Name = "AcuerdoDataGridViewTextBoxColumn"
        Me.AcuerdoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AcuerdoDataGridViewTextBoxColumn.Width = 72
        '
        'DESCRIPDataGridViewTextBoxColumn
        '
        Me.DESCRIPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DESCRIPDataGridViewTextBoxColumn.DataPropertyName = "DESCRIP"
        Me.DESCRIPDataGridViewTextBoxColumn.HeaderText = "Especie"
        Me.DESCRIPDataGridViewTextBoxColumn.Name = "DESCRIPDataGridViewTextBoxColumn"
        Me.DESCRIPDataGridViewTextBoxColumn.ReadOnly = True
        Me.DESCRIPDataGridViewTextBoxColumn.Width = 70
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Variedad"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 74
        '
        'BandDataGridViewTextBoxColumn
        '
        Me.BandDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.BandDataGridViewTextBoxColumn.DataPropertyName = "Band"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.BandDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.BandDataGridViewTextBoxColumn.HeaderText = "Bandejas"
        Me.BandDataGridViewTextBoxColumn.Name = "BandDataGridViewTextBoxColumn"
        Me.BandDataGridViewTextBoxColumn.ReadOnly = True
        Me.BandDataGridViewTextBoxColumn.Width = 76
        '
        'IDGUIADataGridViewTextBoxColumn
        '
        Me.IDGUIADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IDGUIADataGridViewTextBoxColumn.DataPropertyName = "IDGUIA"
        Me.IDGUIADataGridViewTextBoxColumn.HeaderText = "Nº Guía"
        Me.IDGUIADataGridViewTextBoxColumn.Name = "IDGUIADataGridViewTextBoxColumn"
        Me.IDGUIADataGridViewTextBoxColumn.ReadOnly = True
        Me.IDGUIADataGridViewTextBoxColumn.Width = 71
        '
        'FechaGuiaDataGridViewTextBoxColumn
        '
        Me.FechaGuiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FechaGuiaDataGridViewTextBoxColumn.DataPropertyName = "FechaGuia"
        Me.FechaGuiaDataGridViewTextBoxColumn.HeaderText = "Fecha Guía"
        Me.FechaGuiaDataGridViewTextBoxColumn.Name = "FechaGuiaDataGridViewTextBoxColumn"
        Me.FechaGuiaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaGuiaDataGridViewTextBoxColumn.Width = 89
        '
        'TotalGuiaIVADataGridViewTextBoxColumn
        '
        Me.TotalGuiaIVADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TotalGuiaIVADataGridViewTextBoxColumn.DataPropertyName = "Total_GuiaIVA"
        Me.TotalGuiaIVADataGridViewTextBoxColumn.HeaderText = "Total Guía"
        Me.TotalGuiaIVADataGridViewTextBoxColumn.Name = "TotalGuiaIVADataGridViewTextBoxColumn"
        Me.TotalGuiaIVADataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalGuiaIVADataGridViewTextBoxColumn.Width = 83
        '
        'SPConsultaDespDBindingSource
        '
        Me.SPConsultaDespDBindingSource.DataMember = "SP_ConsultaDespD"
        Me.SPConsultaDespDBindingSource.DataSource = Me.GESTDataSet33
        '
        'GESTDataSet33
        '
        Me.GESTDataSet33.DataSetName = "GESTDataSet33"
        Me.GESTDataSet33.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_ConsultaDespDTableAdapter
        '
        Me.SP_ConsultaDespDTableAdapter.ClearBeforeFill = True
        '
        'Despacho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1212, 740)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Despacho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Despachos"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GrillaDespacho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPConsultaDespDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTDataSet33, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNumDesp As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents txtPatente As System.Windows.Forms.TextBox
    Friend WithEvents txtNomChofer As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtTotalBand As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GrillaDespacho As System.Windows.Forms.DataGridView
    Friend WithEvents txtkmini As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txthorafin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtkmfin As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txthoraini As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btndespacho As System.Windows.Forms.Button
    Friend WithEvents btncarga As System.Windows.Forms.Button
    Friend WithEvents btnEmiteGuia As System.Windows.Forms.Button
    Friend WithEvents SPConsultaDespDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GESTDataSet33 As GestionVivero.GESTDataSet33
    Friend WithEvents SP_ConsultaDespDTableAdapter As GestionVivero.GESTDataSet33TableAdapters.SP_ConsultaDespDTableAdapter
    Friend WithEvents chkGuias As System.Windows.Forms.CheckBox
    Friend WithEvents txtSerieLotes As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Column1 As DataGridViewCheckBoxColumn
    Friend WithEvents NumLoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SectorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZonaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcuerdoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDGUIADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaGuiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalGuiaIVADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
