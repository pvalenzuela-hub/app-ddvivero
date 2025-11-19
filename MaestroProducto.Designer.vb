<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaestroProducto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbInsumo = New System.Windows.Forms.ComboBox()
        Me.SPCONSULTAINSUMOSProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetSTOCK = New GestionVivero.DataSetSTOCK()
        Me.SP_CONSULTA_INSUMOS_ProductosTableAdapter = New GestionVivero.DataSetSTOCKTableAdapters.SP_CONSULTA_INSUMOS_ProductosTableAdapter()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtDesProd = New System.Windows.Forms.TextBox()
        Me.cmbUnidad = New System.Windows.Forms.ComboBox()
        Me.SPCONSULTAFULLUNIDADESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CONSULTA_FULL_UNIDADESTableAdapter = New GestionVivero.DataSetSTOCKTableAdapters.SP_CONSULTA_FULL_UNIDADESTableAdapter()
        Me.txtCodProd = New System.Windows.Forms.TextBox()
        Me.DataGrilla = New System.Windows.Forms.DataGridView()
        Me.IdProdD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodProdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesProdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PcompraDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PventaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsumoAsociadoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoInsumoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FichaProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.SPconsultaTablaProductoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPconsultaTablaProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_consultaTablaProductoTableAdapter = New GestionVivero.DataSetSTOCKTableAdapters.SP_consultaTablaProductoTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPVenta = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txt_Dir_Ficha = New System.Windows.Forms.TextBox()
        Me.IdProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PcompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PventaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsumoAsociadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoInsumoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pcompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SPCONSULTAINSUMOSProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSTOCK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPCONSULTAFULLUNIDADESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPconsultaTablaProductoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPconsultaTablaProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Unidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(82, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Descripción"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(82, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Insumo"
        '
        'cmbInsumo
        '
        Me.cmbInsumo.DataSource = Me.SPCONSULTAINSUMOSProductosBindingSource
        Me.cmbInsumo.DisplayMember = "Descripcion"
        Me.cmbInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInsumo.FormattingEnabled = True
        Me.cmbInsumo.Location = New System.Drawing.Point(209, 184)
        Me.cmbInsumo.Name = "cmbInsumo"
        Me.cmbInsumo.Size = New System.Drawing.Size(288, 21)
        Me.cmbInsumo.TabIndex = 4
        Me.cmbInsumo.ValueMember = "IdInsumo"
        '
        'SPCONSULTAINSUMOSProductosBindingSource
        '
        Me.SPCONSULTAINSUMOSProductosBindingSource.DataMember = "SP_CONSULTA_INSUMOS_Productos"
        Me.SPCONSULTAINSUMOSProductosBindingSource.DataSource = Me.DataSetSTOCK
        '
        'DataSetSTOCK
        '
        Me.DataSetSTOCK.DataSetName = "DataSetSTOCK"
        Me.DataSetSTOCK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_CONSULTA_INSUMOS_ProductosTableAdapter
        '
        Me.SP_CONSULTA_INSUMOS_ProductosTableAdapter.ClearBeforeFill = True
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(209, 140)
        Me.txtMarca.MaxLength = 80
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(288, 20)
        Me.txtMarca.TabIndex = 3
        '
        'txtDesProd
        '
        Me.txtDesProd.Location = New System.Drawing.Point(209, 52)
        Me.txtDesProd.MaxLength = 80
        Me.txtDesProd.Name = "txtDesProd"
        Me.txtDesProd.Size = New System.Drawing.Size(288, 20)
        Me.txtDesProd.TabIndex = 1
        '
        'cmbUnidad
        '
        Me.cmbUnidad.DataSource = Me.SPCONSULTAFULLUNIDADESBindingSource
        Me.cmbUnidad.DisplayMember = "DESCRIPCION"
        Me.cmbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnidad.FormattingEnabled = True
        Me.cmbUnidad.Location = New System.Drawing.Point(209, 98)
        Me.cmbUnidad.Name = "cmbUnidad"
        Me.cmbUnidad.Size = New System.Drawing.Size(288, 21)
        Me.cmbUnidad.TabIndex = 2
        Me.cmbUnidad.ValueMember = "IdUnidad"
        '
        'SPCONSULTAFULLUNIDADESBindingSource
        '
        Me.SPCONSULTAFULLUNIDADESBindingSource.DataMember = "SP_CONSULTA_FULL_UNIDADES"
        Me.SPCONSULTAFULLUNIDADESBindingSource.DataSource = Me.DataSetSTOCK
        '
        'SP_CONSULTA_FULL_UNIDADESTableAdapter
        '
        Me.SP_CONSULTA_FULL_UNIDADESTableAdapter.ClearBeforeFill = True
        '
        'txtCodProd
        '
        Me.txtCodProd.Location = New System.Drawing.Point(209, 15)
        Me.txtCodProd.MaxLength = 20
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.Size = New System.Drawing.Size(288, 20)
        Me.txtCodProd.TabIndex = 0
        '
        'DataGrilla
        '
        Me.DataGrilla.AllowUserToAddRows = False
        Me.DataGrilla.AllowUserToDeleteRows = False
        Me.DataGrilla.AutoGenerateColumns = False
        Me.DataGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProdD, Me.CodProdDataGridViewTextBoxColumn1, Me.DesProdDataGridViewTextBoxColumn1, Me.UnidadDataGridViewTextBoxColumn1, Me.PcompraDataGridViewTextBoxColumn1, Me.PventaDataGridViewTextBoxColumn1, Me.MarcaDataGridViewTextBoxColumn1, Me.InsumoAsociadoDataGridViewTextBoxColumn1, Me.TipoInsumoDataGridViewTextBoxColumn1, Me.FichaProductoDataGridViewTextBoxColumn, Me.Column3})
        Me.DataGrilla.DataSource = Me.SPconsultaTablaProductoBindingSource1
        Me.DataGrilla.Location = New System.Drawing.Point(-2, 358)
        Me.DataGrilla.Name = "DataGrilla"
        Me.DataGrilla.ReadOnly = True
        Me.DataGrilla.RowHeadersVisible = False
        Me.DataGrilla.Size = New System.Drawing.Size(1355, 374)
        Me.DataGrilla.TabIndex = 20
        '
        'IdProdD
        '
        Me.IdProdD.DataPropertyName = "IdProd"
        Me.IdProdD.HeaderText = "Id"
        Me.IdProdD.Name = "IdProdD"
        Me.IdProdD.ReadOnly = True
        Me.IdProdD.Width = 50
        '
        'CodProdDataGridViewTextBoxColumn1
        '
        Me.CodProdDataGridViewTextBoxColumn1.DataPropertyName = "CodProd"
        Me.CodProdDataGridViewTextBoxColumn1.HeaderText = "CodProd"
        Me.CodProdDataGridViewTextBoxColumn1.Name = "CodProdDataGridViewTextBoxColumn1"
        Me.CodProdDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CodProdDataGridViewTextBoxColumn1.Width = 50
        '
        'DesProdDataGridViewTextBoxColumn1
        '
        Me.DesProdDataGridViewTextBoxColumn1.DataPropertyName = "DesProd"
        Me.DesProdDataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.DesProdDataGridViewTextBoxColumn1.Name = "DesProdDataGridViewTextBoxColumn1"
        Me.DesProdDataGridViewTextBoxColumn1.ReadOnly = True
        Me.DesProdDataGridViewTextBoxColumn1.Width = 200
        '
        'UnidadDataGridViewTextBoxColumn1
        '
        Me.UnidadDataGridViewTextBoxColumn1.DataPropertyName = "Unidad"
        Me.UnidadDataGridViewTextBoxColumn1.HeaderText = "Unidad"
        Me.UnidadDataGridViewTextBoxColumn1.Name = "UnidadDataGridViewTextBoxColumn1"
        Me.UnidadDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PcompraDataGridViewTextBoxColumn1
        '
        Me.PcompraDataGridViewTextBoxColumn1.DataPropertyName = "Pcompra"
        Me.PcompraDataGridViewTextBoxColumn1.HeaderText = "Pcompra"
        Me.PcompraDataGridViewTextBoxColumn1.Name = "PcompraDataGridViewTextBoxColumn1"
        Me.PcompraDataGridViewTextBoxColumn1.ReadOnly = True
        Me.PcompraDataGridViewTextBoxColumn1.Width = 50
        '
        'PventaDataGridViewTextBoxColumn1
        '
        Me.PventaDataGridViewTextBoxColumn1.DataPropertyName = "Pventa"
        Me.PventaDataGridViewTextBoxColumn1.HeaderText = "Pventa"
        Me.PventaDataGridViewTextBoxColumn1.Name = "PventaDataGridViewTextBoxColumn1"
        Me.PventaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.PventaDataGridViewTextBoxColumn1.Width = 50
        '
        'MarcaDataGridViewTextBoxColumn1
        '
        Me.MarcaDataGridViewTextBoxColumn1.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn1.HeaderText = "Descripción"
        Me.MarcaDataGridViewTextBoxColumn1.Name = "MarcaDataGridViewTextBoxColumn1"
        Me.MarcaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MarcaDataGridViewTextBoxColumn1.Width = 200
        '
        'InsumoAsociadoDataGridViewTextBoxColumn1
        '
        Me.InsumoAsociadoDataGridViewTextBoxColumn1.DataPropertyName = "Insumo Asociado"
        Me.InsumoAsociadoDataGridViewTextBoxColumn1.HeaderText = "Insumo Asociado"
        Me.InsumoAsociadoDataGridViewTextBoxColumn1.Name = "InsumoAsociadoDataGridViewTextBoxColumn1"
        Me.InsumoAsociadoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TipoInsumoDataGridViewTextBoxColumn1
        '
        Me.TipoInsumoDataGridViewTextBoxColumn1.DataPropertyName = "Tipo Insumo"
        Me.TipoInsumoDataGridViewTextBoxColumn1.HeaderText = "Tipo Insumo"
        Me.TipoInsumoDataGridViewTextBoxColumn1.Name = "TipoInsumoDataGridViewTextBoxColumn1"
        Me.TipoInsumoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'FichaProductoDataGridViewTextBoxColumn
        '
        Me.FichaProductoDataGridViewTextBoxColumn.DataPropertyName = "Ficha Producto"
        Me.FichaProductoDataGridViewTextBoxColumn.HeaderText = "Ubicación ficha"
        Me.FichaProductoDataGridViewTextBoxColumn.Name = "FichaProductoDataGridViewTextBoxColumn"
        Me.FichaProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FichaProductoDataGridViewTextBoxColumn.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Ver Ficha"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'SPconsultaTablaProductoBindingSource1
        '
        Me.SPconsultaTablaProductoBindingSource1.DataMember = "SP_consultaTablaProducto"
        Me.SPconsultaTablaProductoBindingSource1.DataSource = Me.DataSetSTOCK
        '
        'SPconsultaTablaProductoBindingSource
        '
        Me.SPconsultaTablaProductoBindingSource.DataMember = "SP_consultaTablaProducto"
        Me.SPconsultaTablaProductoBindingSource.DataSource = Me.DataSetSTOCK
        '
        'SP_consultaTablaProductoTableAdapter
        '
        Me.SP_consultaTablaProductoTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(1218, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 35)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Graba Producto"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.Delete
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(1219, 320)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 32)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Elimina Producto"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Notes
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(-2, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 32)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Modifica Producto"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(82, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Precio Venta"
        '
        'txtPVenta
        '
        Me.txtPVenta.Location = New System.Drawing.Point(209, 226)
        Me.txtPVenta.MaxLength = 80
        Me.txtPVenta.Name = "txtPVenta"
        Me.txtPVenta.Size = New System.Drawing.Size(288, 20)
        Me.txtPVenta.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(82, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Ficha Producto"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txt_Dir_Ficha
        '
        Me.txt_Dir_Ficha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Dir_Ficha.Location = New System.Drawing.Point(209, 271)
        Me.txt_Dir_Ficha.MaxLength = 1000
        Me.txt_Dir_Ficha.Name = "txt_Dir_Ficha"
        Me.txt_Dir_Ficha.Size = New System.Drawing.Size(691, 20)
        Me.txt_Dir_Ficha.TabIndex = 116
        '
        'IdProd
        '
        Me.IdProd.DataPropertyName = "IdProd"
        Me.IdProd.HeaderText = "IdProd"
        Me.IdProd.Name = "IdProd"
        '
        'CodProdDataGridViewTextBoxColumn
        '
        Me.CodProdDataGridViewTextBoxColumn.DataPropertyName = "CodProd"
        Me.CodProdDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodProdDataGridViewTextBoxColumn.Name = "CodProdDataGridViewTextBoxColumn"
        '
        'DesProdDataGridViewTextBoxColumn
        '
        Me.DesProdDataGridViewTextBoxColumn.DataPropertyName = "DesProd"
        Me.DesProdDataGridViewTextBoxColumn.HeaderText = "Nombre Producto"
        Me.DesProdDataGridViewTextBoxColumn.Name = "DesProdDataGridViewTextBoxColumn"
        '
        'UnidadDataGridViewTextBoxColumn
        '
        Me.UnidadDataGridViewTextBoxColumn.DataPropertyName = "Unidad"
        Me.UnidadDataGridViewTextBoxColumn.HeaderText = "Unidad"
        Me.UnidadDataGridViewTextBoxColumn.Name = "UnidadDataGridViewTextBoxColumn"
        '
        'PcompraDataGridViewTextBoxColumn
        '
        Me.PcompraDataGridViewTextBoxColumn.DataPropertyName = "Pcompra"
        Me.PcompraDataGridViewTextBoxColumn.HeaderText = "Pcompra"
        Me.PcompraDataGridViewTextBoxColumn.Name = "PcompraDataGridViewTextBoxColumn"
        '
        'PventaDataGridViewTextBoxColumn
        '
        Me.PventaDataGridViewTextBoxColumn.DataPropertyName = "Pventa"
        Me.PventaDataGridViewTextBoxColumn.HeaderText = "Pventa"
        Me.PventaDataGridViewTextBoxColumn.Name = "PventaDataGridViewTextBoxColumn"
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        '
        'InsumoAsociadoDataGridViewTextBoxColumn
        '
        Me.InsumoAsociadoDataGridViewTextBoxColumn.DataPropertyName = "Insumo Asociado"
        Me.InsumoAsociadoDataGridViewTextBoxColumn.HeaderText = "Insumo Asociado"
        Me.InsumoAsociadoDataGridViewTextBoxColumn.Name = "InsumoAsociadoDataGridViewTextBoxColumn"
        '
        'TipoInsumoDataGridViewTextBoxColumn
        '
        Me.TipoInsumoDataGridViewTextBoxColumn.DataPropertyName = "Tipo Insumo"
        Me.TipoInsumoDataGridViewTextBoxColumn.HeaderText = "Tipo Insumo"
        Me.TipoInsumoDataGridViewTextBoxColumn.Name = "TipoInsumoDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdProd"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdProd"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'CodProd
        '
        Me.CodProd.DataPropertyName = "CodProd"
        Me.CodProd.HeaderText = "CodProd"
        Me.CodProd.Name = "CodProd"
        '
        'DesProd
        '
        Me.DesProd.DataPropertyName = "DesProd"
        Me.DesProd.HeaderText = "Nombre"
        Me.DesProd.Name = "DesProd"
        '
        'Unidad
        '
        Me.Unidad.DataPropertyName = "Unidad"
        Me.Unidad.HeaderText = "Unidad"
        Me.Unidad.Name = "Unidad"
        '
        'Pcompra
        '
        Me.Pcompra.DataPropertyName = "Pcompra"
        Me.Pcompra.HeaderText = "Pcompra"
        Me.Pcompra.Name = "Pcompra"
        '
        'Pventa
        '
        Me.Pventa.DataPropertyName = "Pventa"
        Me.Pventa.HeaderText = "Pventa"
        Me.Pventa.Name = "Pventa"
        '
        'Marca
        '
        Me.Marca.DataPropertyName = "Marca"
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "IdProd"
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CodProd"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CodProd"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DesProd"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DesProd"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Unidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Pcompra"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Pcompra"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Pventa"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Pventa"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Marca"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "IdProd"
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CodProd"
        Me.DataGridViewTextBoxColumn8.HeaderText = "CodProd"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "DesProd"
        Me.DataGridViewTextBoxColumn9.HeaderText = "DesProd"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Unidad"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Pcompra"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Pcompra"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Pventa"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Pventa"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Marca"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'MaestroProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 729)
        Me.Controls.Add(Me.txt_Dir_Ficha)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPVenta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGrilla)
        Me.Controls.Add(Me.txtCodProd)
        Me.Controls.Add(Me.cmbUnidad)
        Me.Controls.Add(Me.txtDesProd)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.cmbInsumo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MaestroProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CREACION DE PRODUCTOS"
        CType(Me.SPCONSULTAINSUMOSProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSTOCK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPCONSULTAFULLUNIDADESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPconsultaTablaProductoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPconsultaTablaProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbInsumo As ComboBox
    Friend WithEvents DataSetSTOCK As DataSetSTOCK
    Friend WithEvents SPCONSULTAINSUMOSProductosBindingSource As BindingSource
    Friend WithEvents SP_CONSULTA_INSUMOS_ProductosTableAdapter As DataSetSTOCKTableAdapters.SP_CONSULTA_INSUMOS_ProductosTableAdapter
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents txtDesProd As TextBox
    Friend WithEvents cmbUnidad As ComboBox
    Friend WithEvents SPCONSULTAFULLUNIDADESBindingSource As BindingSource
    Friend WithEvents SP_CONSULTA_FULL_UNIDADESTableAdapter As DataSetSTOCKTableAdapters.SP_CONSULTA_FULL_UNIDADESTableAdapter
    Friend WithEvents txtCodProd As TextBox
    Friend WithEvents DataGrilla As DataGridView
    Friend WithEvents SPconsultaTablaProductoBindingSource As BindingSource
    Friend WithEvents SP_consultaTablaProductoTableAdapter As DataSetSTOCKTableAdapters.SP_consultaTablaProductoTableAdapter
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPVenta As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txt_Dir_Ficha As TextBox
    Friend WithEvents SPconsultaTablaProductoBindingSource1 As BindingSource
    Friend WithEvents IdProd As DataGridViewTextBoxColumn
    Friend WithEvents CodProdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DesProdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PcompraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PventaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InsumoAsociadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoInsumoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CodProd As DataGridViewTextBoxColumn
    Friend WithEvents DesProd As DataGridViewTextBoxColumn
    Friend WithEvents Unidad As DataGridViewTextBoxColumn
    Friend WithEvents Pcompra As DataGridViewTextBoxColumn
    Friend WithEvents Pventa As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents IdProdD As DataGridViewTextBoxColumn
    Friend WithEvents CodProdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DesProdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents UnidadDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PcompraDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PventaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents InsumoAsociadoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TipoInsumoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FichaProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewButtonColumn
End Class
