<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RebajaAbonoInicial
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMontoDevolucion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSaldoAbono = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmb_TIPO_PAGO = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtMontoAbono = New System.Windows.Forms.TextBox()
        Me.GESTDataSet = New GestionVivero.GESTDataSet()
        Me.BANCOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BANCOTableAdapter = New GestionVivero.GESTDataSetTableAdapters.BANCOTableAdapter()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataDevoluciones = New System.Windows.Forms.DataGridView()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombrecuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GESTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BANCOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataDevoluciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 148)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monto a Devolver"
        '
        'txtMontoDevolucion
        '
        Me.txtMontoDevolucion.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoDevolucion.Location = New System.Drawing.Point(179, 145)
        Me.txtMontoDevolucion.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtMontoDevolucion.Name = "txtMontoDevolucion"
        Me.txtMontoDevolucion.Size = New System.Drawing.Size(306, 27)
        Me.txtMontoDevolucion.TabIndex = 1
        Me.txtMontoDevolucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Saldo Abono"
        '
        'txtSaldoAbono
        '
        Me.txtSaldoAbono.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoAbono.Location = New System.Drawing.Point(179, 31)
        Me.txtSaldoAbono.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSaldoAbono.Name = "txtSaldoAbono"
        Me.txtSaldoAbono.ReadOnly = True
        Me.txtSaldoAbono.Size = New System.Drawing.Size(306, 27)
        Me.txtSaldoAbono.TabIndex = 3
        Me.txtSaldoAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(197, 204)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(250, 39)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Aplicar Devolución"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmb_TIPO_PAGO
        '
        Me.cmb_TIPO_PAGO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_TIPO_PAGO.DataSource = Me.BANCOBindingSource
        Me.cmb_TIPO_PAGO.DisplayMember = "Nombre"
        Me.cmb_TIPO_PAGO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TIPO_PAGO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_TIPO_PAGO.FormattingEnabled = True
        Me.cmb_TIPO_PAGO.Location = New System.Drawing.Point(179, 89)
        Me.cmb_TIPO_PAGO.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmb_TIPO_PAGO.Name = "cmb_TIPO_PAGO"
        Me.cmb_TIPO_PAGO.Size = New System.Drawing.Size(306, 24)
        Me.cmb_TIPO_PAGO.TabIndex = 6
        Me.cmb_TIPO_PAGO.ValueMember = "idcodigo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 90)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cuenta"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.salir_40x401
        Me.Button2.Location = New System.Drawing.Point(584, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(49, 49)
        Me.Button2.TabIndex = 8
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtMontoAbono
        '
        Me.txtMontoAbono.Location = New System.Drawing.Point(511, 201)
        Me.txtMontoAbono.Name = "txtMontoAbono"
        Me.txtMontoAbono.Size = New System.Drawing.Size(100, 23)
        Me.txtMontoAbono.TabIndex = 9
        Me.txtMontoAbono.Visible = False
        '
        'GESTDataSet
        '
        Me.GESTDataSet.DataSetName = "GESTDataSet"
        Me.GESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BANCOBindingSource
        '
        Me.BANCOBindingSource.DataMember = "BANCO"
        Me.BANCOBindingSource.DataSource = Me.GESTDataSet
        '
        'BANCOTableAdapter
        '
        Me.BANCOTableAdapter.ClearBeforeFill = True
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(511, 172)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(100, 23)
        Me.txtIdCliente.TabIndex = 10
        Me.txtIdCliente.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataDevoluciones)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 265)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(625, 145)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Historial de Devoluciones"
        '
        'DataDevoluciones
        '
        Me.DataDevoluciones.AllowUserToAddRows = False
        Me.DataDevoluciones.AllowUserToDeleteRows = False
        Me.DataDevoluciones.BackgroundColor = System.Drawing.Color.White
        Me.DataDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataDevoluciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha, Me.monto, Me.nombrecuenta, Me.cuenta, Me.usuario})
        Me.DataDevoluciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataDevoluciones.Location = New System.Drawing.Point(3, 19)
        Me.DataDevoluciones.MultiSelect = False
        Me.DataDevoluciones.Name = "DataDevoluciones"
        Me.DataDevoluciones.ReadOnly = True
        Me.DataDevoluciones.RowHeadersVisible = False
        Me.DataDevoluciones.Size = New System.Drawing.Size(619, 123)
        Me.DataDevoluciones.TabIndex = 12
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'monto
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.monto.DefaultCellStyle = DataGridViewCellStyle1
        Me.monto.HeaderText = "Monto"
        Me.monto.Name = "monto"
        Me.monto.ReadOnly = True
        Me.monto.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.monto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'nombrecuenta
        '
        Me.nombrecuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombrecuenta.HeaderText = "Nombre Cuenta"
        Me.nombrecuenta.Name = "nombrecuenta"
        Me.nombrecuenta.ReadOnly = True
        Me.nombrecuenta.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.nombrecuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cuenta
        '
        Me.cuenta.HeaderText = "Cuenta Contable"
        Me.cuenta.Name = "cuenta"
        Me.cuenta.ReadOnly = True
        Me.cuenta.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'usuario
        '
        Me.usuario.HeaderText = "Usuario"
        Me.usuario.Name = "usuario"
        Me.usuario.ReadOnly = True
        Me.usuario.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.usuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'RebajaAbonoInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(634, 413)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.txtMontoAbono)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_TIPO_PAGO)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtSaldoAbono)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMontoDevolucion)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "RebajaAbonoInicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DEVOLUCIÓN ABONO"
        CType(Me.GESTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BANCOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataDevoluciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtMontoDevolucion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSaldoAbono As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cmb_TIPO_PAGO As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents txtMontoAbono As TextBox
    Friend WithEvents GESTDataSet As GESTDataSet
    Friend WithEvents BANCOBindingSource As BindingSource
    Friend WithEvents BANCOTableAdapter As GESTDataSetTableAdapters.BANCOTableAdapter
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataDevoluciones As DataGridView
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents monto As DataGridViewTextBoxColumn
    Friend WithEvents nombrecuenta As DataGridViewTextBoxColumn
    Friend WithEvents cuenta As DataGridViewTextBoxColumn
    Friend WithEvents usuario As DataGridViewTextBoxColumn
End Class
