<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockProductoBodega
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbBodega = New System.Windows.Forms.ComboBox()
        Me.SPStockListadoBodegasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetSTOCK = New GestionVivero.DataSetSTOCK()
        Me.SP_StockListadoBodegasTableAdapter = New GestionVivero.DataSetSTOCKTableAdapters.SP_StockListadoBodegasTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGrilla = New System.Windows.Forms.DataGridView()
        Me.SPStockConsultaInventariosProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Stock_ConsultaInventariosProductosTableAdapter = New GestionVivero.DataSetSTOCKTableAdapters.SP_Stock_ConsultaInventariosProductosTableAdapter()
        Me.BodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoPrecioCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsumoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaUltCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BodegaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesProdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsumoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoPrecioCompraDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaUltCompraDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoPrecioVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BodegaDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProdDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesProdDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoPrecioCompraDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsumoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaUltCompraDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoPrecioVentaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorTotalVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaUltVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ver = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.SPStockListadoBodegasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSTOCK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPStockConsultaInventariosProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(475, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bodega"
        '
        'cmbBodega
        '
        Me.cmbBodega.DataSource = Me.SPStockListadoBodegasBindingSource
        Me.cmbBodega.DisplayMember = "Descripcion"
        Me.cmbBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBodega.FormattingEnabled = True
        Me.cmbBodega.Location = New System.Drawing.Point(520, 27)
        Me.cmbBodega.Name = "cmbBodega"
        Me.cmbBodega.Size = New System.Drawing.Size(226, 21)
        Me.cmbBodega.TabIndex = 1
        Me.cmbBodega.ValueMember = "IdBodega"
        '
        'SPStockListadoBodegasBindingSource
        '
        Me.SPStockListadoBodegasBindingSource.DataMember = "SP_StockListadoBodegas"
        Me.SPStockListadoBodegasBindingSource.DataSource = Me.DataSetSTOCK
        '
        'DataSetSTOCK
        '
        Me.DataSetSTOCK.DataSetName = "DataSetSTOCK"
        Me.DataSetSTOCK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_StockListadoBodegasTableAdapter
        '
        Me.SP_StockListadoBodegasTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(752, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 32)
        Me.Button3.TabIndex = 19
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGrilla
        '
        Me.DataGrilla.AllowUserToAddRows = False
        Me.DataGrilla.AllowUserToDeleteRows = False
        Me.DataGrilla.AutoGenerateColumns = False
        Me.DataGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BodegaDataGridViewTextBoxColumn2, Me.IdProdDataGridViewTextBoxColumn2, Me.DesProdDataGridViewTextBoxColumn2, Me.UnidadDataGridViewTextBoxColumn2, Me.UltimoPrecioCompraDataGridViewTextBoxColumn2, Me.MarcaDataGridViewTextBoxColumn2, Me.InsumoDataGridViewTextBoxColumn2, Me.FechaUltCompraDataGridViewTextBoxColumn2, Me.StockDataGridViewTextBoxColumn2, Me.UltimoPrecioVentaDataGridViewTextBoxColumn1, Me.ValorTotalVentaDataGridViewTextBoxColumn, Me.FechaUltVentaDataGridViewTextBoxColumn, Me.ver})
        Me.DataGrilla.DataSource = Me.SPStockConsultaInventariosProductosBindingSource
        Me.DataGrilla.Location = New System.Drawing.Point(1, 77)
        Me.DataGrilla.Name = "DataGrilla"
        Me.DataGrilla.ReadOnly = True
        Me.DataGrilla.Size = New System.Drawing.Size(1413, 633)
        Me.DataGrilla.TabIndex = 21
        '
        'SPStockConsultaInventariosProductosBindingSource
        '
        Me.SPStockConsultaInventariosProductosBindingSource.DataMember = "SP_Stock_ConsultaInventariosProductos"
        Me.SPStockConsultaInventariosProductosBindingSource.DataSource = Me.DataSetSTOCK
        '
        'SP_Stock_ConsultaInventariosProductosTableAdapter
        '
        Me.SP_Stock_ConsultaInventariosProductosTableAdapter.ClearBeforeFill = True
        '
        'BodegaDataGridViewTextBoxColumn
        '
        Me.BodegaDataGridViewTextBoxColumn.DataPropertyName = "Bodega"
        Me.BodegaDataGridViewTextBoxColumn.HeaderText = "Bodega"
        Me.BodegaDataGridViewTextBoxColumn.Name = "BodegaDataGridViewTextBoxColumn"
        Me.BodegaDataGridViewTextBoxColumn.Width = 150
        '
        'IdProdDataGridViewTextBoxColumn
        '
        Me.IdProdDataGridViewTextBoxColumn.DataPropertyName = "IdProd"
        Me.IdProdDataGridViewTextBoxColumn.HeaderText = "IdProd"
        Me.IdProdDataGridViewTextBoxColumn.Name = "IdProdDataGridViewTextBoxColumn"
        '
        'DesProdDataGridViewTextBoxColumn
        '
        Me.DesProdDataGridViewTextBoxColumn.DataPropertyName = "DesProd"
        Me.DesProdDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.DesProdDataGridViewTextBoxColumn.Name = "DesProdDataGridViewTextBoxColumn"
        Me.DesProdDataGridViewTextBoxColumn.Width = 200
        '
        'UnidadDataGridViewTextBoxColumn
        '
        Me.UnidadDataGridViewTextBoxColumn.DataPropertyName = "Unidad"
        Me.UnidadDataGridViewTextBoxColumn.HeaderText = "Unidad"
        Me.UnidadDataGridViewTextBoxColumn.Name = "UnidadDataGridViewTextBoxColumn"
        '
        'UltimoPrecioCompraDataGridViewTextBoxColumn
        '
        Me.UltimoPrecioCompraDataGridViewTextBoxColumn.DataPropertyName = "Ultimo Precio Compra"
        Me.UltimoPrecioCompraDataGridViewTextBoxColumn.HeaderText = "Ultimo Precio Compra"
        Me.UltimoPrecioCompraDataGridViewTextBoxColumn.Name = "UltimoPrecioCompraDataGridViewTextBoxColumn"
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        Me.MarcaDataGridViewTextBoxColumn.Width = 200
        '
        'InsumoDataGridViewTextBoxColumn
        '
        Me.InsumoDataGridViewTextBoxColumn.DataPropertyName = "Insumo"
        Me.InsumoDataGridViewTextBoxColumn.HeaderText = "Insumo"
        Me.InsumoDataGridViewTextBoxColumn.Name = "InsumoDataGridViewTextBoxColumn"
        '
        'FechaUltCompraDataGridViewTextBoxColumn
        '
        Me.FechaUltCompraDataGridViewTextBoxColumn.DataPropertyName = "Fecha Ult_Compra"
        Me.FechaUltCompraDataGridViewTextBoxColumn.HeaderText = "Fecha Ult_Compra"
        Me.FechaUltCompraDataGridViewTextBoxColumn.Name = "FechaUltCompraDataGridViewTextBoxColumn"
        Me.FechaUltCompraDataGridViewTextBoxColumn.Width = 120
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.StockDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        '
        'BodegaDataGridViewTextBoxColumn1
        '
        Me.BodegaDataGridViewTextBoxColumn1.DataPropertyName = "Bodega"
        Me.BodegaDataGridViewTextBoxColumn1.HeaderText = "Bodega"
        Me.BodegaDataGridViewTextBoxColumn1.Name = "BodegaDataGridViewTextBoxColumn1"
        '
        'IdProdDataGridViewTextBoxColumn1
        '
        Me.IdProdDataGridViewTextBoxColumn1.DataPropertyName = "IdProd"
        Me.IdProdDataGridViewTextBoxColumn1.HeaderText = "IdProd"
        Me.IdProdDataGridViewTextBoxColumn1.Name = "IdProdDataGridViewTextBoxColumn1"
        Me.IdProdDataGridViewTextBoxColumn1.Visible = False
        '
        'DesProdDataGridViewTextBoxColumn1
        '
        Me.DesProdDataGridViewTextBoxColumn1.DataPropertyName = "DesProd"
        Me.DesProdDataGridViewTextBoxColumn1.HeaderText = "Descripción"
        Me.DesProdDataGridViewTextBoxColumn1.Name = "DesProdDataGridViewTextBoxColumn1"
        Me.DesProdDataGridViewTextBoxColumn1.Width = 150
        '
        'UnidadDataGridViewTextBoxColumn1
        '
        Me.UnidadDataGridViewTextBoxColumn1.DataPropertyName = "Unidad"
        Me.UnidadDataGridViewTextBoxColumn1.HeaderText = "Unidad"
        Me.UnidadDataGridViewTextBoxColumn1.Name = "UnidadDataGridViewTextBoxColumn1"
        '
        'MarcaDataGridViewTextBoxColumn1
        '
        Me.MarcaDataGridViewTextBoxColumn1.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn1.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn1.Name = "MarcaDataGridViewTextBoxColumn1"
        Me.MarcaDataGridViewTextBoxColumn1.Width = 150
        '
        'InsumoDataGridViewTextBoxColumn1
        '
        Me.InsumoDataGridViewTextBoxColumn1.DataPropertyName = "Insumo"
        Me.InsumoDataGridViewTextBoxColumn1.HeaderText = "Insumo"
        Me.InsumoDataGridViewTextBoxColumn1.Name = "InsumoDataGridViewTextBoxColumn1"
        Me.InsumoDataGridViewTextBoxColumn1.Width = 150
        '
        'StockDataGridViewTextBoxColumn1
        '
        Me.StockDataGridViewTextBoxColumn1.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn1.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn1.Name = "StockDataGridViewTextBoxColumn1"
        '
        'UltimoPrecioCompraDataGridViewTextBoxColumn1
        '
        Me.UltimoPrecioCompraDataGridViewTextBoxColumn1.DataPropertyName = "Ultimo Precio Compra"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.UltimoPrecioCompraDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle6
        Me.UltimoPrecioCompraDataGridViewTextBoxColumn1.HeaderText = "Ultimo Precio Compra"
        Me.UltimoPrecioCompraDataGridViewTextBoxColumn1.Name = "UltimoPrecioCompraDataGridViewTextBoxColumn1"
        '
        'FechaUltCompraDataGridViewTextBoxColumn1
        '
        Me.FechaUltCompraDataGridViewTextBoxColumn1.DataPropertyName = "Fecha Ult_Compra"
        Me.FechaUltCompraDataGridViewTextBoxColumn1.HeaderText = "Fecha Ult_Compra"
        Me.FechaUltCompraDataGridViewTextBoxColumn1.Name = "FechaUltCompraDataGridViewTextBoxColumn1"
        '
        'UltimoPrecioVentaDataGridViewTextBoxColumn
        '
        Me.UltimoPrecioVentaDataGridViewTextBoxColumn.DataPropertyName = "Ultimo Precio Venta"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.UltimoPrecioVentaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.UltimoPrecioVentaDataGridViewTextBoxColumn.HeaderText = "Ultimo Precio Venta"
        Me.UltimoPrecioVentaDataGridViewTextBoxColumn.Name = "UltimoPrecioVentaDataGridViewTextBoxColumn"
        '
        'BodegaDataGridViewTextBoxColumn2
        '
        Me.BodegaDataGridViewTextBoxColumn2.DataPropertyName = "Bodega"
        Me.BodegaDataGridViewTextBoxColumn2.HeaderText = "Bodega"
        Me.BodegaDataGridViewTextBoxColumn2.Name = "BodegaDataGridViewTextBoxColumn2"
        Me.BodegaDataGridViewTextBoxColumn2.ReadOnly = True
        Me.BodegaDataGridViewTextBoxColumn2.Width = 120
        '
        'IdProdDataGridViewTextBoxColumn2
        '
        Me.IdProdDataGridViewTextBoxColumn2.DataPropertyName = "IdProd"
        Me.IdProdDataGridViewTextBoxColumn2.HeaderText = "IdProd"
        Me.IdProdDataGridViewTextBoxColumn2.Name = "IdProdDataGridViewTextBoxColumn2"
        Me.IdProdDataGridViewTextBoxColumn2.ReadOnly = True
        Me.IdProdDataGridViewTextBoxColumn2.Width = 50
        '
        'DesProdDataGridViewTextBoxColumn2
        '
        Me.DesProdDataGridViewTextBoxColumn2.DataPropertyName = "DesProd"
        Me.DesProdDataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DesProdDataGridViewTextBoxColumn2.Name = "DesProdDataGridViewTextBoxColumn2"
        Me.DesProdDataGridViewTextBoxColumn2.ReadOnly = True
        Me.DesProdDataGridViewTextBoxColumn2.Width = 150
        '
        'UnidadDataGridViewTextBoxColumn2
        '
        Me.UnidadDataGridViewTextBoxColumn2.DataPropertyName = "Unidad"
        Me.UnidadDataGridViewTextBoxColumn2.HeaderText = "Unidad"
        Me.UnidadDataGridViewTextBoxColumn2.Name = "UnidadDataGridViewTextBoxColumn2"
        Me.UnidadDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'UltimoPrecioCompraDataGridViewTextBoxColumn2
        '
        Me.UltimoPrecioCompraDataGridViewTextBoxColumn2.DataPropertyName = "Ultimo Precio Compra"
        Me.UltimoPrecioCompraDataGridViewTextBoxColumn2.HeaderText = "Ultimo Precio Compra"
        Me.UltimoPrecioCompraDataGridViewTextBoxColumn2.Name = "UltimoPrecioCompraDataGridViewTextBoxColumn2"
        Me.UltimoPrecioCompraDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'MarcaDataGridViewTextBoxColumn2
        '
        Me.MarcaDataGridViewTextBoxColumn2.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn2.HeaderText = "Descripción"
        Me.MarcaDataGridViewTextBoxColumn2.Name = "MarcaDataGridViewTextBoxColumn2"
        Me.MarcaDataGridViewTextBoxColumn2.ReadOnly = True
        Me.MarcaDataGridViewTextBoxColumn2.Width = 200
        '
        'InsumoDataGridViewTextBoxColumn2
        '
        Me.InsumoDataGridViewTextBoxColumn2.DataPropertyName = "Insumo"
        Me.InsumoDataGridViewTextBoxColumn2.HeaderText = "Insumo"
        Me.InsumoDataGridViewTextBoxColumn2.Name = "InsumoDataGridViewTextBoxColumn2"
        Me.InsumoDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'FechaUltCompraDataGridViewTextBoxColumn2
        '
        Me.FechaUltCompraDataGridViewTextBoxColumn2.DataPropertyName = "Fecha Ult_Compra"
        Me.FechaUltCompraDataGridViewTextBoxColumn2.HeaderText = "Fecha Ult_Compra"
        Me.FechaUltCompraDataGridViewTextBoxColumn2.Name = "FechaUltCompraDataGridViewTextBoxColumn2"
        Me.FechaUltCompraDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'StockDataGridViewTextBoxColumn2
        '
        Me.StockDataGridViewTextBoxColumn2.DataPropertyName = "Stock"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.StockDataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle1
        Me.StockDataGridViewTextBoxColumn2.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn2.Name = "StockDataGridViewTextBoxColumn2"
        Me.StockDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'UltimoPrecioVentaDataGridViewTextBoxColumn1
        '
        Me.UltimoPrecioVentaDataGridViewTextBoxColumn1.DataPropertyName = "Ultimo Precio Venta"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.UltimoPrecioVentaDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.UltimoPrecioVentaDataGridViewTextBoxColumn1.HeaderText = "Ultimo Precio Venta"
        Me.UltimoPrecioVentaDataGridViewTextBoxColumn1.Name = "UltimoPrecioVentaDataGridViewTextBoxColumn1"
        Me.UltimoPrecioVentaDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ValorTotalVentaDataGridViewTextBoxColumn
        '
        Me.ValorTotalVentaDataGridViewTextBoxColumn.DataPropertyName = "Valor Total Venta"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ValorTotalVentaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.ValorTotalVentaDataGridViewTextBoxColumn.HeaderText = "Valor Total Venta"
        Me.ValorTotalVentaDataGridViewTextBoxColumn.Name = "ValorTotalVentaDataGridViewTextBoxColumn"
        Me.ValorTotalVentaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaUltVentaDataGridViewTextBoxColumn
        '
        Me.FechaUltVentaDataGridViewTextBoxColumn.DataPropertyName = "Fecha Ult_Venta"
        Me.FechaUltVentaDataGridViewTextBoxColumn.HeaderText = "Fecha Ult_Venta"
        Me.FechaUltVentaDataGridViewTextBoxColumn.Name = "FechaUltVentaDataGridViewTextBoxColumn"
        Me.FechaUltVentaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ver
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.NullValue = " "
        Me.ver.DefaultCellStyle = DataGridViewCellStyle4
        Me.ver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ver.HeaderText = "Ver Ficha"
        Me.ver.Name = "ver"
        Me.ver.ReadOnly = True
        Me.ver.Text = "  "
        Me.ver.Width = 50
        '
        'StockProductoBodega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1415, 711)
        Me.Controls.Add(Me.DataGrilla)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.cmbBodega)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StockProductoBodega"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA STOCK DE PRODUCTOS"
        CType(Me.SPStockListadoBodegasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSTOCK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPStockConsultaInventariosProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbBodega As ComboBox
    Friend WithEvents DataSetSTOCK As DataSetSTOCK
    Friend WithEvents SPStockListadoBodegasBindingSource As BindingSource
    Friend WithEvents SP_StockListadoBodegasTableAdapter As DataSetSTOCKTableAdapters.SP_StockListadoBodegasTableAdapter
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGrilla As DataGridView
    Friend WithEvents SPStockConsultaInventariosProductosBindingSource As BindingSource
    Friend WithEvents SP_Stock_ConsultaInventariosProductosTableAdapter As DataSetSTOCKTableAdapters.SP_Stock_ConsultaInventariosProductosTableAdapter
    Friend WithEvents BodegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdProdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DesProdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UltimoPrecioCompraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InsumoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaUltCompraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BodegaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdProdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DesProdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents UnidadDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents InsumoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents UltimoPrecioCompraDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FechaUltCompraDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents UltimoPrecioVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BodegaDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IdProdDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DesProdDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents UnidadDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents UltimoPrecioCompraDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents InsumoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents FechaUltCompraDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents UltimoPrecioVentaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ValorTotalVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaUltVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ver As DataGridViewButtonColumn
End Class
