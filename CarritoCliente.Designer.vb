<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarritoCliente
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CarritoLotes = New System.Windows.Forms.DataGridView()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnGuias = New System.Windows.Forms.Button()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.txtTotalBandeja = New System.Windows.Forms.TextBox()
        Me.txtTotalPlantas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalFinal = New System.Windows.Forms.TextBox()
        Me.lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.semilla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.variedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipobandeja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldobandeja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldoplantas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ubicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.guia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.CarritoLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Image = Global.GestionVivero.My.Resources.Resources.salir_40x40
        Me.Button4.Location = New System.Drawing.Point(918, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(49, 49)
        Me.Button4.TabIndex = 140
        Me.Button4.UseVisualStyleBackColor = False
        '
        'CarritoLotes
        '
        Me.CarritoLotes.AllowUserToAddRows = False
        Me.CarritoLotes.AllowUserToDeleteRows = False
        Me.CarritoLotes.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CarritoLotes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.CarritoLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CarritoLotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.lote, Me.semilla, Me.variedad, Me.tipobandeja, Me.saldobandeja, Me.saldoplantas, Me.nave, Me.ubicacion, Me.precio, Me.guia})
        Me.CarritoLotes.Location = New System.Drawing.Point(6, 50)
        Me.CarritoLotes.Name = "CarritoLotes"
        Me.CarritoLotes.ReadOnly = True
        Me.CarritoLotes.RowHeadersVisible = False
        Me.CarritoLotes.Size = New System.Drawing.Size(906, 314)
        Me.CarritoLotes.TabIndex = 141
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.White
        Me.btnImprimir.Image = Global.GestionVivero.My.Resources.Resources.imprimir_40x40
        Me.btnImprimir.Location = New System.Drawing.Point(918, 60)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(49, 49)
        Me.btnImprimir.TabIndex = 142
        Me.ToolTip1.SetToolTip(Me.btnImprimir, "Nota de Entrega")
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'btnGuias
        '
        Me.btnGuias.Image = Global.GestionVivero.My.Resources.Resources.Guias
        Me.btnGuias.Location = New System.Drawing.Point(918, 115)
        Me.btnGuias.Name = "btnGuias"
        Me.btnGuias.Size = New System.Drawing.Size(49, 49)
        Me.btnGuias.TabIndex = 143
        Me.ToolTip1.SetToolTip(Me.btnGuias, "Emisión de Guía")
        Me.btnGuias.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.SystemColors.HotTrack
        Me.txtCliente.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.ForeColor = System.Drawing.Color.White
        Me.txtCliente.Location = New System.Drawing.Point(12, 13)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(900, 33)
        Me.txtCliente.TabIndex = 144
        Me.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(13, 418)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtIdCliente.TabIndex = 145
        Me.txtIdCliente.Visible = False
        '
        'txtTotalBandeja
        '
        Me.txtTotalBandeja.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalBandeja.Location = New System.Drawing.Point(233, 414)
        Me.txtTotalBandeja.Name = "txtTotalBandeja"
        Me.txtTotalBandeja.Size = New System.Drawing.Size(100, 23)
        Me.txtTotalBandeja.TabIndex = 146
        Me.txtTotalBandeja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalPlantas
        '
        Me.txtTotalPlantas.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPlantas.Location = New System.Drawing.Point(429, 414)
        Me.txtTotalPlantas.Name = "txtTotalPlantas"
        Me.txtTotalPlantas.Size = New System.Drawing.Size(100, 23)
        Me.txtTotalPlantas.TabIndex = 147
        Me.txtTotalPlantas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(255, 398)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 148
        Me.Label1.Text = "Total Bandejas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(460, 398)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 149
        Me.Label2.Text = "Total Plantas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(806, 398)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "Total $"
        '
        'txtTotalFinal
        '
        Me.txtTotalFinal.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalFinal.Location = New System.Drawing.Point(806, 414)
        Me.txtTotalFinal.Name = "txtTotalFinal"
        Me.txtTotalFinal.Size = New System.Drawing.Size(100, 23)
        Me.txtTotalFinal.TabIndex = 151
        Me.txtTotalFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lote
        '
        Me.lote.HeaderText = "N° Lote"
        Me.lote.Name = "lote"
        Me.lote.ReadOnly = True
        '
        'semilla
        '
        Me.semilla.HeaderText = "Semilla"
        Me.semilla.Name = "semilla"
        Me.semilla.ReadOnly = True
        '
        'variedad
        '
        Me.variedad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.variedad.HeaderText = "Variedad"
        Me.variedad.Name = "variedad"
        Me.variedad.ReadOnly = True
        '
        'tipobandeja
        '
        Me.tipobandeja.HeaderText = "Tipo"
        Me.tipobandeja.Name = "tipobandeja"
        Me.tipobandeja.ReadOnly = True
        '
        'saldobandeja
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.saldobandeja.DefaultCellStyle = DataGridViewCellStyle5
        Me.saldobandeja.HeaderText = "Saldo Bandeja"
        Me.saldobandeja.Name = "saldobandeja"
        Me.saldobandeja.ReadOnly = True
        '
        'saldoplantas
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.saldoplantas.DefaultCellStyle = DataGridViewCellStyle6
        Me.saldoplantas.HeaderText = "Saldo Plantas"
        Me.saldoplantas.Name = "saldoplantas"
        Me.saldoplantas.ReadOnly = True
        '
        'nave
        '
        Me.nave.HeaderText = "N° Nave"
        Me.nave.Name = "nave"
        Me.nave.ReadOnly = True
        '
        'ubicacion
        '
        Me.ubicacion.HeaderText = "Ubicación"
        Me.ubicacion.Name = "ubicacion"
        Me.ubicacion.ReadOnly = True
        '
        'precio
        '
        Me.precio.HeaderText = "precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        Me.precio.Visible = False
        '
        'guia
        '
        Me.guia.HeaderText = "N° Guía"
        Me.guia.Name = "guia"
        Me.guia.ReadOnly = True
        '
        'CarritoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(969, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtTotalFinal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalPlantas)
        Me.Controls.Add(Me.txtTotalBandeja)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.btnGuias)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.CarritoLotes)
        Me.Controls.Add(Me.Button4)
        Me.Name = "CarritoCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carrito de Lotes"
        Me.TopMost = True
        CType(Me.CarritoLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button4 As Button
    Friend WithEvents CarritoLotes As DataGridView
    Friend WithEvents btnImprimir As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnGuias As Button
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents txtTotalBandeja As TextBox
    Friend WithEvents txtTotalPlantas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotalFinal As TextBox
    Friend WithEvents lote As DataGridViewTextBoxColumn
    Friend WithEvents semilla As DataGridViewTextBoxColumn
    Friend WithEvents variedad As DataGridViewTextBoxColumn
    Friend WithEvents tipobandeja As DataGridViewTextBoxColumn
    Friend WithEvents saldobandeja As DataGridViewTextBoxColumn
    Friend WithEvents saldoplantas As DataGridViewTextBoxColumn
    Friend WithEvents nave As DataGridViewTextBoxColumn
    Friend WithEvents ubicacion As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents guia As DataGridViewTextBoxColumn
End Class
