<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cotizacion_ReImpresion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GrillaCot = New System.Windows.Forms.DataGridView()
        Me.SPReporteCotizacionALLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Cotizacion = New GestionVivero.DataSet_Cotizacion()
        Me.SP_ReporteCotizacion_ALLTableAdapter = New GestionVivero.DataSet_CotizacionTableAdapters.SP_ReporteCotizacion_ALLTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.IdCotizacionDetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RUTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FamiliaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VariedadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaSiembraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEntregaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AportaSemillaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LugarEntregaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormaEntregaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GrillaCot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPReporteCotizacionALLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Cotizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Add
        Me.Button1.Location = New System.Drawing.Point(158, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 48)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GrillaCot
        '
        Me.GrillaCot.AllowUserToAddRows = False
        Me.GrillaCot.AllowUserToDeleteRows = False
        Me.GrillaCot.AllowUserToResizeColumns = False
        Me.GrillaCot.AllowUserToResizeRows = False
        Me.GrillaCot.AutoGenerateColumns = False
        Me.GrillaCot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaCot.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1, Me.IdCotizacionDetalleDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.APELLIDODataGridViewTextBoxColumn, Me.RUTDataGridViewTextBoxColumn, Me.FamiliaDataGridViewTextBoxColumn, Me.VariedadDataGridViewTextBoxColumn, Me.FechaSiembraDataGridViewTextBoxColumn, Me.FechaEntregaDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.AportaSemillaDataGridViewTextBoxColumn, Me.LugarEntregaDataGridViewTextBoxColumn, Me.FormaEntregaDataGridViewTextBoxColumn})
        Me.GrillaCot.DataSource = Me.SPReporteCotizacionALLBindingSource
        Me.GrillaCot.Location = New System.Drawing.Point(3, 111)
        Me.GrillaCot.Name = "GrillaCot"
        Me.GrillaCot.ReadOnly = True
        Me.GrillaCot.RowHeadersVisible = False
        Me.GrillaCot.Size = New System.Drawing.Size(958, 490)
        Me.GrillaCot.TabIndex = 2
        '
        'SPReporteCotizacionALLBindingSource
        '
        Me.SPReporteCotizacionALLBindingSource.DataMember = "SP_ReporteCotizacion_ALL"
        Me.SPReporteCotizacionALLBindingSource.DataSource = Me.DataSet_Cotizacion
        '
        'DataSet_Cotizacion
        '
        Me.DataSet_Cotizacion.DataSetName = "DataSet_Cotizacion"
        Me.DataSet_Cotizacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_ReporteCotizacion_ALLTableAdapter
        '
        Me.SP_ReporteCotizacion_ALLTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(328, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Listado histórico de Cotizaciones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Presione este botón"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(208, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "para crear nueva Cotización"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.GreenYellow
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column2.HeaderText = "Crea Pedido"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.Width = 45
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.DataPropertyName = "IdCotizacion"
        Me.Column1.HeaderText = "Imprimir"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'IdCotizacionDetalleDataGridViewTextBoxColumn
        '
        Me.IdCotizacionDetalleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IdCotizacionDetalleDataGridViewTextBoxColumn.DataPropertyName = "IdCotizacionDetalle"
        Me.IdCotizacionDetalleDataGridViewTextBoxColumn.HeaderText = "Id Detalle"
        Me.IdCotizacionDetalleDataGridViewTextBoxColumn.Name = "IdCotizacionDetalleDataGridViewTextBoxColumn"
        Me.IdCotizacionDetalleDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCotizacionDetalleDataGridViewTextBoxColumn.Width = 71
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.ReadOnly = True
        '
        'APELLIDODataGridViewTextBoxColumn
        '
        Me.APELLIDODataGridViewTextBoxColumn.DataPropertyName = "APELLIDO"
        Me.APELLIDODataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.APELLIDODataGridViewTextBoxColumn.Name = "APELLIDODataGridViewTextBoxColumn"
        Me.APELLIDODataGridViewTextBoxColumn.ReadOnly = True
        '
        'RUTDataGridViewTextBoxColumn
        '
        Me.RUTDataGridViewTextBoxColumn.DataPropertyName = "RUT"
        Me.RUTDataGridViewTextBoxColumn.HeaderText = "RUT"
        Me.RUTDataGridViewTextBoxColumn.Name = "RUTDataGridViewTextBoxColumn"
        Me.RUTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FamiliaDataGridViewTextBoxColumn
        '
        Me.FamiliaDataGridViewTextBoxColumn.DataPropertyName = "Familia"
        Me.FamiliaDataGridViewTextBoxColumn.HeaderText = "Familia/Semilla"
        Me.FamiliaDataGridViewTextBoxColumn.Name = "FamiliaDataGridViewTextBoxColumn"
        Me.FamiliaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VariedadDataGridViewTextBoxColumn
        '
        Me.VariedadDataGridViewTextBoxColumn.DataPropertyName = "Variedad"
        Me.VariedadDataGridViewTextBoxColumn.HeaderText = "Variedad"
        Me.VariedadDataGridViewTextBoxColumn.Name = "VariedadDataGridViewTextBoxColumn"
        Me.VariedadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaSiembraDataGridViewTextBoxColumn
        '
        Me.FechaSiembraDataGridViewTextBoxColumn.DataPropertyName = "FechaSiembra"
        Me.FechaSiembraDataGridViewTextBoxColumn.HeaderText = "Fecha Siembra"
        Me.FechaSiembraDataGridViewTextBoxColumn.Name = "FechaSiembraDataGridViewTextBoxColumn"
        Me.FechaSiembraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaEntregaDataGridViewTextBoxColumn
        '
        Me.FechaEntregaDataGridViewTextBoxColumn.DataPropertyName = "FechaEntrega"
        Me.FechaEntregaDataGridViewTextBoxColumn.HeaderText = "Fecha Entrega"
        Me.FechaEntregaDataGridViewTextBoxColumn.Name = "FechaEntregaDataGridViewTextBoxColumn"
        Me.FechaEntregaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Tipo Bandeja"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AportaSemillaDataGridViewTextBoxColumn
        '
        Me.AportaSemillaDataGridViewTextBoxColumn.DataPropertyName = "AportaSemilla"
        Me.AportaSemillaDataGridViewTextBoxColumn.HeaderText = "Aporta Semilla"
        Me.AportaSemillaDataGridViewTextBoxColumn.Name = "AportaSemillaDataGridViewTextBoxColumn"
        Me.AportaSemillaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LugarEntregaDataGridViewTextBoxColumn
        '
        Me.LugarEntregaDataGridViewTextBoxColumn.DataPropertyName = "LugarEntrega"
        Me.LugarEntregaDataGridViewTextBoxColumn.HeaderText = "Lugar Entrega"
        Me.LugarEntregaDataGridViewTextBoxColumn.Name = "LugarEntregaDataGridViewTextBoxColumn"
        Me.LugarEntregaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FormaEntregaDataGridViewTextBoxColumn
        '
        Me.FormaEntregaDataGridViewTextBoxColumn.DataPropertyName = "FormaEntrega"
        Me.FormaEntregaDataGridViewTextBoxColumn.HeaderText = "Forma Entrega"
        Me.FormaEntregaDataGridViewTextBoxColumn.Name = "FormaEntregaDataGridViewTextBoxColumn"
        Me.FormaEntregaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Cotizacion_ReImpresion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(963, 613)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrillaCot)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Cotizacion_ReImpresion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cotizacion_ReImpresion"
        CType(Me.GrillaCot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPReporteCotizacionALLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Cotizacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents GrillaCot As DataGridView
    Friend WithEvents DataSet_Cotizacion As DataSet_Cotizacion
    Friend WithEvents SPReporteCotizacionALLBindingSource As BindingSource
    Friend WithEvents SP_ReporteCotizacion_ALLTableAdapter As DataSet_CotizacionTableAdapters.SP_ReporteCotizacion_ALLTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Column2 As DataGridViewButtonColumn
    Friend WithEvents Column1 As DataGridViewButtonColumn
    Friend WithEvents IdCotizacionDetalleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RUTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FamiliaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VariedadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaSiembraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaEntregaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AportaSemillaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LugarEntregaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FormaEntregaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
