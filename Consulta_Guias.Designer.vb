<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta_Guias
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateDesde = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateHasta = New System.Windows.Forms.DateTimePicker
        Me.DataConsulta = New System.Windows.Forms.DataGridView
        Me.guia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lote = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bandretiro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.banddevol = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fechdevol = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.indicador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.totalguia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.garantiaband = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.saldoplantas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.chk_PendientesFactura = New System.Windows.Forms.CheckBox
        CType(Me.DataConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(160, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Desde:"
        '
        'DateDesde
        '
        Me.DateDesde.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDesde.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDesde.Location = New System.Drawing.Point(198, 31)
        Me.DateDesde.Name = "DateDesde"
        Me.DateDesde.Size = New System.Drawing.Size(92, 21)
        Me.DateDesde.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(421, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hasta:"
        '
        'DateHasta
        '
        Me.DateHasta.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateHasta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateHasta.Location = New System.Drawing.Point(456, 31)
        Me.DateHasta.Name = "DateHasta"
        Me.DateHasta.Size = New System.Drawing.Size(98, 21)
        Me.DateHasta.TabIndex = 6
        '
        'DataConsulta
        '
        Me.DataConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataConsulta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataConsulta.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataConsulta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.guia, Me.lote, Me.cliente, Me.vendedor, Me.fecha, Me.Cantidad, Me.bandretiro, Me.banddevol, Me.fechdevol, Me.precio, Me.indicador, Me.totalguia, Me.garantiaband, Me.saldoplantas})
        Me.DataConsulta.Location = New System.Drawing.Point(25, 94)
        Me.DataConsulta.Name = "DataConsulta"
        Me.DataConsulta.ReadOnly = True
        Me.DataConsulta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataConsulta.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataConsulta.Size = New System.Drawing.Size(749, 311)
        Me.DataConsulta.TabIndex = 13
        '
        'guia
        '
        Me.guia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.guia.HeaderText = "N° Guía"
        Me.guia.Name = "guia"
        Me.guia.ReadOnly = True
        Me.guia.Width = 71
        '
        'lote
        '
        Me.lote.HeaderText = "N° Lote"
        Me.lote.Name = "lote"
        Me.lote.ReadOnly = True
        Me.lote.Width = 68
        '
        'cliente
        '
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        Me.cliente.Width = 64
        '
        'vendedor
        '
        Me.vendedor.HeaderText = "Vendedor"
        Me.vendedor.Name = "vendedor"
        Me.vendedor.ReadOnly = True
        Me.vendedor.Width = 78
        '
        'fecha
        '
        Me.fecha.HeaderText = "Emisión"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 68
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 74
        '
        'bandretiro
        '
        Me.bandretiro.HeaderText = "Band.Retiro"
        Me.bandretiro.Name = "bandretiro"
        Me.bandretiro.ReadOnly = True
        Me.bandretiro.Width = 88
        '
        'banddevol
        '
        Me.banddevol.HeaderText = "Band.Devol."
        Me.banddevol.Name = "banddevol"
        Me.banddevol.ReadOnly = True
        Me.banddevol.Width = 91
        '
        'fechdevol
        '
        Me.fechdevol.HeaderText = "Fecha Devol."
        Me.fechdevol.Name = "fechdevol"
        Me.fechdevol.ReadOnly = True
        Me.fechdevol.Width = 96
        '
        'precio
        '
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        Me.precio.Width = 62
        '
        'indicador
        '
        Me.indicador.HeaderText = "Ind.fact"
        Me.indicador.Name = "indicador"
        Me.indicador.ReadOnly = True
        Me.indicador.Width = 68
        '
        'totalguia
        '
        Me.totalguia.HeaderText = "Valor Neto"
        Me.totalguia.Name = "totalguia"
        Me.totalguia.ReadOnly = True
        Me.totalguia.Width = 82
        '
        'garantiaband
        '
        Me.garantiaband.HeaderText = "Gtía.Band."
        Me.garantiaband.Name = "garantiaband"
        Me.garantiaband.ReadOnly = True
        Me.garantiaband.Width = 84
        '
        'saldoplantas
        '
        Me.saldoplantas.HeaderText = "Saldo Plantas"
        Me.saldoplantas.Name = "saldoplantas"
        Me.saldoplantas.ReadOnly = True
        Me.saldoplantas.Width = 97
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(325, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 32)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(355, 411)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 32)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'chk_PendientesFactura
        '
        Me.chk_PendientesFactura.AutoSize = True
        Me.chk_PendientesFactura.Location = New System.Drawing.Point(607, 34)
        Me.chk_PendientesFactura.Name = "chk_PendientesFactura"
        Me.chk_PendientesFactura.Size = New System.Drawing.Size(136, 17)
        Me.chk_PendientesFactura.TabIndex = 16
        Me.chk_PendientesFactura.Text = "Pendientes de Facturar"
        Me.chk_PendientesFactura.UseVisualStyleBackColor = True
        '
        'Consulta_Guias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 446)
        Me.ControlBox = False
        Me.Controls.Add(Me.chk_PendientesFactura)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataConsulta)
        Me.Controls.Add(Me.DateHasta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateDesde)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Consulta_Guias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Guias Emitidas"
        CType(Me.DataConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataConsulta As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents guia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vendedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bandretiro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents banddevol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechdevol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents indicador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalguia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents garantiaband As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents saldoplantas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chk_PendientesFactura As System.Windows.Forms.CheckBox
End Class
