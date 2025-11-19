<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INV_ingresoGuia
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.cmbBodOrigen = New System.Windows.Forms.ComboBox()
        Me.SPStockListadoBodegasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetSTOCKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetSTOCK = New GestionVivero.DataSetSTOCK()
        Me.lblBodegaDestino = New System.Windows.Forms.Label()
        Me.cmbBodegaDest = New System.Windows.Forms.ComboBox()
        Me.SPStockListadoBodegasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbProducto = New System.Windows.Forms.ComboBox()
        Me.SPconsultaTablaProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_consultaTablaProductoTableAdapter = New GestionVivero.DataSetSTOCKTableAdapters.SP_consultaTablaProductoTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGrillaStock = New System.Windows.Forms.DataGridView()
        Me.SPconsultaGuiaINVBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPconsultaGuiaINVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_consultaGuiaINVTableAdapter = New GestionVivero.DataSetSTOCKTableAdapters.SP_consultaGuiaINVTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblPVenta = New System.Windows.Forms.Label()
        Me.txtPVenta = New System.Windows.Forms.TextBox()
        Me.SP_StockListadoBodegasTableAdapter = New GestionVivero.DataSetSTOCKTableAdapters.SP_StockListadoBodegasTableAdapter()
        Me.Idguiainv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bodega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoMovtoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConceptoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdBodega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SPStockListadoBodegasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSTOCKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSTOCK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPStockListadoBodegasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPconsultaTablaProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrillaStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPconsultaGuiaINVBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPconsultaGuiaINVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Bodega Origen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Producto"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(136, 26)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(121, 20)
        Me.dtpFecha.TabIndex = 0
        '
        'cmbTipo
        '
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"Entrada", "Salida", "Traspaso"})
        Me.cmbTipo.Location = New System.Drawing.Point(136, 71)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipo.TabIndex = 1
        '
        'cmbBodOrigen
        '
        Me.cmbBodOrigen.DataSource = Me.SPStockListadoBodegasBindingSource
        Me.cmbBodOrigen.DisplayMember = "Descripcion"
        Me.cmbBodOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBodOrigen.FormattingEnabled = True
        Me.cmbBodOrigen.Location = New System.Drawing.Point(136, 120)
        Me.cmbBodOrigen.Name = "cmbBodOrigen"
        Me.cmbBodOrigen.Size = New System.Drawing.Size(235, 21)
        Me.cmbBodOrigen.TabIndex = 2
        Me.cmbBodOrigen.ValueMember = "IdBodega"
        '
        'SPStockListadoBodegasBindingSource
        '
        Me.SPStockListadoBodegasBindingSource.DataMember = "SP_StockListadoBodegas"
        Me.SPStockListadoBodegasBindingSource.DataSource = Me.DataSetSTOCKBindingSource
        '
        'DataSetSTOCKBindingSource
        '
        Me.DataSetSTOCKBindingSource.DataSource = Me.DataSetSTOCK
        Me.DataSetSTOCKBindingSource.Position = 0
        '
        'DataSetSTOCK
        '
        Me.DataSetSTOCK.DataSetName = "DataSetSTOCK"
        Me.DataSetSTOCK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblBodegaDestino
        '
        Me.lblBodegaDestino.AutoSize = True
        Me.lblBodegaDestino.Location = New System.Drawing.Point(425, 124)
        Me.lblBodegaDestino.Name = "lblBodegaDestino"
        Me.lblBodegaDestino.Size = New System.Drawing.Size(83, 13)
        Me.lblBodegaDestino.TabIndex = 7
        Me.lblBodegaDestino.Text = "Bodega Destino"
        Me.lblBodegaDestino.Visible = False
        '
        'cmbBodegaDest
        '
        Me.cmbBodegaDest.DataSource = Me.SPStockListadoBodegasBindingSource1
        Me.cmbBodegaDest.DisplayMember = "Descripcion"
        Me.cmbBodegaDest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBodegaDest.FormattingEnabled = True
        Me.cmbBodegaDest.Location = New System.Drawing.Point(524, 121)
        Me.cmbBodegaDest.Name = "cmbBodegaDest"
        Me.cmbBodegaDest.Size = New System.Drawing.Size(176, 21)
        Me.cmbBodegaDest.TabIndex = 3
        Me.cmbBodegaDest.ValueMember = "IdBodega"
        Me.cmbBodegaDest.Visible = False
        '
        'SPStockListadoBodegasBindingSource1
        '
        Me.SPStockListadoBodegasBindingSource1.DataMember = "SP_StockListadoBodegas"
        Me.SPStockListadoBodegasBindingSource1.DataSource = Me.DataSetSTOCKBindingSource
        '
        'cmbProducto
        '
        Me.cmbProducto.DataSource = Me.SPconsultaTablaProductoBindingSource
        Me.cmbProducto.DisplayMember = "DesProd"
        Me.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(136, 174)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(235, 21)
        Me.cmbProducto.TabIndex = 4
        Me.cmbProducto.ValueMember = "IdProd"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Cantidad"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(136, 217)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Concepto"
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(136, 260)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(330, 20)
        Me.txtConcepto.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(1040, 30)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(134, 32)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Graba Guìa"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGrillaStock
        '
        Me.DataGrillaStock.AllowUserToAddRows = False
        Me.DataGrillaStock.AllowUserToDeleteRows = False
        Me.DataGrillaStock.AutoGenerateColumns = False
        Me.DataGrillaStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrillaStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Idguiainv, Me.FechaDataGridViewTextBoxColumn, Me.Bodega, Me.TipoMovtoDataGridViewTextBoxColumn, Me.DesProdDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.ConceptoDataGridViewTextBoxColumn, Me.IdProd, Me.IdBodega, Me.PVenta})
        Me.DataGrillaStock.DataSource = Me.SPconsultaGuiaINVBindingSource1
        Me.DataGrillaStock.Location = New System.Drawing.Point(-1, 384)
        Me.DataGrillaStock.Name = "DataGrillaStock"
        Me.DataGrillaStock.ReadOnly = True
        Me.DataGrillaStock.RowHeadersVisible = False
        Me.DataGrillaStock.Size = New System.Drawing.Size(1175, 374)
        Me.DataGrillaStock.TabIndex = 19
        '
        'SPconsultaGuiaINVBindingSource1
        '
        Me.SPconsultaGuiaINVBindingSource1.DataMember = "SP_consultaGuiaINV"
        Me.SPconsultaGuiaINVBindingSource1.DataSource = Me.DataSetSTOCKBindingSource
        '
        'SPconsultaGuiaINVBindingSource
        '
        Me.SPconsultaGuiaINVBindingSource.DataMember = "SP_consultaGuiaINV"
        Me.SPconsultaGuiaINVBindingSource.DataSource = Me.DataSetSTOCKBindingSource
        '
        'SP_consultaGuiaINVTableAdapter
        '
        Me.SP_consultaGuiaINVTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(12, 346)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(203, 32)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Actualiza Inventario Productos"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.Delete
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(1040, 346)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 32)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Elimina Movimiento"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblPVenta
        '
        Me.lblPVenta.AutoSize = True
        Me.lblPVenta.Location = New System.Drawing.Point(57, 308)
        Me.lblPVenta.Name = "lblPVenta"
        Me.lblPVenta.Size = New System.Drawing.Size(68, 13)
        Me.lblPVenta.TabIndex = 22
        Me.lblPVenta.Text = "Precio Venta"
        Me.lblPVenta.Visible = False
        '
        'txtPVenta
        '
        Me.txtPVenta.Location = New System.Drawing.Point(136, 304)
        Me.txtPVenta.Name = "txtPVenta"
        Me.txtPVenta.Size = New System.Drawing.Size(100, 20)
        Me.txtPVenta.TabIndex = 23
        Me.txtPVenta.Visible = False
        '
        'SP_StockListadoBodegasTableAdapter
        '
        Me.SP_StockListadoBodegasTableAdapter.ClearBeforeFill = True
        '
        'Idguiainv
        '
        Me.Idguiainv.DataPropertyName = "Idguiainv"
        Me.Idguiainv.HeaderText = "Nº Guía"
        Me.Idguiainv.Name = "Idguiainv"
        Me.Idguiainv.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Bodega
        '
        Me.Bodega.DataPropertyName = "Bodega"
        Me.Bodega.HeaderText = "Bodega"
        Me.Bodega.Name = "Bodega"
        Me.Bodega.ReadOnly = True
        Me.Bodega.Width = 120
        '
        'TipoMovtoDataGridViewTextBoxColumn
        '
        Me.TipoMovtoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Movto"
        Me.TipoMovtoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoMovtoDataGridViewTextBoxColumn.Name = "TipoMovtoDataGridViewTextBoxColumn"
        Me.TipoMovtoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DesProdDataGridViewTextBoxColumn
        '
        Me.DesProdDataGridViewTextBoxColumn.DataPropertyName = "DesProd"
        Me.DesProdDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.DesProdDataGridViewTextBoxColumn.Name = "DesProdDataGridViewTextBoxColumn"
        Me.DesProdDataGridViewTextBoxColumn.ReadOnly = True
        Me.DesProdDataGridViewTextBoxColumn.Width = 250
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.CantidadDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConceptoDataGridViewTextBoxColumn
        '
        Me.ConceptoDataGridViewTextBoxColumn.DataPropertyName = "Concepto"
        Me.ConceptoDataGridViewTextBoxColumn.HeaderText = "Concepto"
        Me.ConceptoDataGridViewTextBoxColumn.Name = "ConceptoDataGridViewTextBoxColumn"
        Me.ConceptoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ConceptoDataGridViewTextBoxColumn.Width = 250
        '
        'IdProd
        '
        Me.IdProd.DataPropertyName = "IdProd"
        Me.IdProd.HeaderText = "IdProd"
        Me.IdProd.Name = "IdProd"
        Me.IdProd.ReadOnly = True
        Me.IdProd.Visible = False
        '
        'IdBodega
        '
        Me.IdBodega.DataPropertyName = "IdBodega"
        Me.IdBodega.HeaderText = "IdBodega"
        Me.IdBodega.Name = "IdBodega"
        Me.IdBodega.ReadOnly = True
        Me.IdBodega.Visible = False
        '
        'PVenta
        '
        Me.PVenta.DataPropertyName = "PVenta"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.PVenta.DefaultCellStyle = DataGridViewCellStyle2
        Me.PVenta.HeaderText = "P.Venta"
        Me.PVenta.Name = "PVenta"
        Me.PVenta.ReadOnly = True
        Me.PVenta.Width = 150
        '
        'INV_ingresoGuia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1176, 761)
        Me.Controls.Add(Me.txtPVenta)
        Me.Controls.Add(Me.lblPVenta)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGrillaStock)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbProducto)
        Me.Controls.Add(Me.cmbBodegaDest)
        Me.Controls.Add(Me.lblBodegaDestino)
        Me.Controls.Add(Me.cmbBodOrigen)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "INV_ingresoGuia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INVENTARIO DE PRODUCTOS"
        CType(Me.SPStockListadoBodegasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSTOCKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSTOCK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPStockListadoBodegasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPconsultaTablaProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrillaStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPconsultaGuiaINVBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPconsultaGuiaINVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents cmbBodOrigen As ComboBox
    Friend WithEvents lblBodegaDestino As Label
    Friend WithEvents cmbBodegaDest As ComboBox
    Friend WithEvents cmbProducto As ComboBox
    Friend WithEvents DataSetSTOCK As DataSetSTOCK
    Friend WithEvents SPconsultaTablaProductoBindingSource As BindingSource
    Friend WithEvents SP_consultaTablaProductoTableAdapter As DataSetSTOCKTableAdapters.SP_consultaTablaProductoTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtConcepto As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGrillaStock As DataGridView
    Friend WithEvents DataSetSTOCKBindingSource As BindingSource
    Friend WithEvents SPconsultaGuiaINVBindingSource As BindingSource
    Friend WithEvents SP_consultaGuiaINVTableAdapter As DataSetSTOCKTableAdapters.SP_consultaGuiaINVTableAdapter
    Friend WithEvents SPconsultaGuiaINVBindingSource1 As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblPVenta As Label
    Friend WithEvents txtPVenta As TextBox
    Friend WithEvents SPStockListadoBodegasBindingSource As BindingSource
    Friend WithEvents SP_StockListadoBodegasTableAdapter As DataSetSTOCKTableAdapters.SP_StockListadoBodegasTableAdapter
    Friend WithEvents SPStockListadoBodegasBindingSource1 As BindingSource
    Friend WithEvents Idguiainv As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Bodega As DataGridViewTextBoxColumn
    Friend WithEvents TipoMovtoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DesProdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConceptoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdProd As DataGridViewTextBoxColumn
    Friend WithEvents IdBodega As DataGridViewTextBoxColumn
    Friend WithEvents PVenta As DataGridViewTextBoxColumn
End Class
