<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LotesPorSembrar
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGrilla = New System.Windows.Forms.DataGridView()
        Me.IdPedidodetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPedidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaSiembraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDADDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BandejasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComentarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aporta_Semilla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SPCONSULTALOTESINSEMBRARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetReporteInventario = New GestionVivero.DataSetReporteInventario()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaSiembra = New System.Windows.Forms.DateTimePicker()
        Me.SP_CONSULTA_LOTE_SIN_SEMBRARTableAdapter = New GestionVivero.DataSetReporteInventarioTableAdapters.SP_CONSULTA_LOTE_SIN_SEMBRARTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPCONSULTALOTESINSEMBRARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetReporteInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrilla
        '
        Me.DataGrilla.AllowUserToAddRows = False
        Me.DataGrilla.AllowUserToDeleteRows = False
        Me.DataGrilla.AutoGenerateColumns = False
        Me.DataGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGrilla.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrilla.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPedidodetDataGridViewTextBoxColumn, Me.IdPedidoDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.DescripDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.FechaSiembraDataGridViewTextBoxColumn, Me.CANTIDADDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.BandejasDataGridViewTextBoxColumn, Me.ComentarioDataGridViewTextBoxColumn, Me.Aporta_Semilla})
        Me.DataGrilla.DataSource = Me.SPCONSULTALOTESINSEMBRARBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrilla.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrilla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGrilla.Location = New System.Drawing.Point(0, 41)
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
        Me.DataGrilla.Size = New System.Drawing.Size(1109, 638)
        Me.DataGrilla.TabIndex = 27
        '
        'IdPedidodetDataGridViewTextBoxColumn
        '
        Me.IdPedidodetDataGridViewTextBoxColumn.DataPropertyName = "IdPedidodet"
        Me.IdPedidodetDataGridViewTextBoxColumn.HeaderText = "N° Lote"
        Me.IdPedidodetDataGridViewTextBoxColumn.Name = "IdPedidodetDataGridViewTextBoxColumn"
        Me.IdPedidodetDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPedidodetDataGridViewTextBoxColumn.Width = 68
        '
        'IdPedidoDataGridViewTextBoxColumn
        '
        Me.IdPedidoDataGridViewTextBoxColumn.DataPropertyName = "IdPedido"
        Me.IdPedidoDataGridViewTextBoxColumn.HeaderText = "N° Pedido"
        Me.IdPedidoDataGridViewTextBoxColumn.Name = "IdPedidoDataGridViewTextBoxColumn"
        Me.IdPedidoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPedidoDataGridViewTextBoxColumn.Width = 80
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClienteDataGridViewTextBoxColumn.Width = 300
        '
        'DescripDataGridViewTextBoxColumn
        '
        Me.DescripDataGridViewTextBoxColumn.DataPropertyName = "Descrip"
        Me.DescripDataGridViewTextBoxColumn.HeaderText = "Semilla"
        Me.DescripDataGridViewTextBoxColumn.Name = "DescripDataGridViewTextBoxColumn"
        Me.DescripDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripDataGridViewTextBoxColumn.Width = 65
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Variedad"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 74
        '
        'FechaSiembraDataGridViewTextBoxColumn
        '
        Me.FechaSiembraDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Siembra"
        Me.FechaSiembraDataGridViewTextBoxColumn.HeaderText = "Fecha Siembra"
        Me.FechaSiembraDataGridViewTextBoxColumn.Name = "FechaSiembraDataGridViewTextBoxColumn"
        Me.FechaSiembraDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaSiembraDataGridViewTextBoxColumn.Width = 103
        '
        'CANTIDADDataGridViewTextBoxColumn
        '
        Me.CANTIDADDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD"
        Me.CANTIDADDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CANTIDADDataGridViewTextBoxColumn.Name = "CANTIDADDataGridViewTextBoxColumn"
        Me.CANTIDADDataGridViewTextBoxColumn.ReadOnly = True
        Me.CANTIDADDataGridViewTextBoxColumn.Width = 74
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoDataGridViewTextBoxColumn.Width = 53
        '
        'BandejasDataGridViewTextBoxColumn
        '
        Me.BandejasDataGridViewTextBoxColumn.DataPropertyName = "Bandejas"
        Me.BandejasDataGridViewTextBoxColumn.HeaderText = "Bandejas"
        Me.BandejasDataGridViewTextBoxColumn.Name = "BandejasDataGridViewTextBoxColumn"
        Me.BandejasDataGridViewTextBoxColumn.ReadOnly = True
        Me.BandejasDataGridViewTextBoxColumn.Width = 76
        '
        'ComentarioDataGridViewTextBoxColumn
        '
        Me.ComentarioDataGridViewTextBoxColumn.DataPropertyName = "Comentario"
        Me.ComentarioDataGridViewTextBoxColumn.HeaderText = "Comentario"
        Me.ComentarioDataGridViewTextBoxColumn.Name = "ComentarioDataGridViewTextBoxColumn"
        Me.ComentarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.ComentarioDataGridViewTextBoxColumn.Width = 85
        '
        'Aporta_Semilla
        '
        Me.Aporta_Semilla.DataPropertyName = "Aporta_Semilla"
        Me.Aporta_Semilla.HeaderText = "Aporta Semilla"
        Me.Aporta_Semilla.Name = "Aporta_Semilla"
        Me.Aporta_Semilla.ReadOnly = True
        Me.Aporta_Semilla.Width = 99
        '
        'SPCONSULTALOTESINSEMBRARBindingSource
        '
        Me.SPCONSULTALOTESINSEMBRARBindingSource.DataMember = "SP_CONSULTA_LOTE_SIN_SEMBRAR"
        Me.SPCONSULTALOTESINSEMBRARBindingSource.DataSource = Me.DataSetReporteInventario
        '
        'DataSetReporteInventario
        '
        Me.DataSetReporteInventario.DataSetName = "DataSetReporteInventario"
        Me.DataSetReporteInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(387, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Hasta Fecha de Siembra:"
        '
        'dtpFechaSiembra
        '
        Me.dtpFechaSiembra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaSiembra.Location = New System.Drawing.Point(516, 11)
        Me.dtpFechaSiembra.Name = "dtpFechaSiembra"
        Me.dtpFechaSiembra.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaSiembra.TabIndex = 29
        '
        'SP_CONSULTA_LOTE_SIN_SEMBRARTableAdapter
        '
        Me.SP_CONSULTA_LOTE_SIN_SEMBRARTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button1.Location = New System.Drawing.Point(633, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 40)
        Me.Button1.TabIndex = 30
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LotesPorSembrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 679)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtpFechaSiembra)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGrilla)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LotesPorSembrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Siembra"
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPCONSULTALOTESINSEMBRARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetReporteInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGrilla As DataGridView
    Friend WithEvents DataSetReporteInventario As DataSetReporteInventario
    Friend WithEvents SPCONSULTALOTESINSEMBRARBindingSource As BindingSource
    Friend WithEvents SP_CONSULTA_LOTE_SIN_SEMBRARTableAdapter As DataSetReporteInventarioTableAdapters.SP_CONSULTA_LOTE_SIN_SEMBRARTableAdapter
    Friend WithEvents IdPedidodetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdPedidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaSiembraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDADDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BandejasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComentarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Aporta_Semilla As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFechaSiembra As DateTimePicker
    Friend WithEvents Button1 As Button
End Class
