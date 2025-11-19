<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DevolucionPlantas
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
        Me.chkCliente = New System.Windows.Forms.CheckBox()
        Me.txt_Rut_Cli = New System.Windows.Forms.TextBox()
        Me.txt_clientebuscar = New System.Windows.Forms.TextBox()
        Me.txt_NOM_CLI = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnBuscaCliente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_IDcliente = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGuias = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGuiaSeleccionada = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaGuia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BandejasGuia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EspecieGuia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VariedadGuia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioGuia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadGuia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldoplantas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSaldoPlantas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPlantasDevolucion = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGuias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkCliente
        '
        Me.chkCliente.AutoSize = True
        Me.chkCliente.Enabled = False
        Me.chkCliente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCliente.Location = New System.Drawing.Point(333, 22)
        Me.chkCliente.Name = "chkCliente"
        Me.chkCliente.Size = New System.Drawing.Size(114, 18)
        Me.chkCliente.TabIndex = 117
        Me.chkCliente.Text = "busca por nombre"
        Me.chkCliente.UseVisualStyleBackColor = True
        '
        'txt_Rut_Cli
        '
        Me.txt_Rut_Cli.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_Rut_Cli.Location = New System.Drawing.Point(995, 16)
        Me.txt_Rut_Cli.Name = "txt_Rut_Cli"
        Me.txt_Rut_Cli.ReadOnly = True
        Me.txt_Rut_Cli.Size = New System.Drawing.Size(91, 22)
        Me.txt_Rut_Cli.TabIndex = 116
        '
        'txt_clientebuscar
        '
        Me.txt_clientebuscar.BackColor = System.Drawing.Color.White
        Me.txt_clientebuscar.Enabled = False
        Me.txt_clientebuscar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clientebuscar.ForeColor = System.Drawing.Color.Black
        Me.txt_clientebuscar.Location = New System.Drawing.Point(185, 18)
        Me.txt_clientebuscar.Name = "txt_clientebuscar"
        Me.txt_clientebuscar.Size = New System.Drawing.Size(106, 21)
        Me.txt_clientebuscar.TabIndex = 112
        '
        'txt_NOM_CLI
        '
        Me.txt_NOM_CLI.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_NOM_CLI.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NOM_CLI.ForeColor = System.Drawing.Color.Navy
        Me.txt_NOM_CLI.Location = New System.Drawing.Point(539, 16)
        Me.txt_NOM_CLI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_NOM_CLI.Name = "txt_NOM_CLI"
        Me.txt_NOM_CLI.ReadOnly = True
        Me.txt_NOM_CLI.Size = New System.Drawing.Size(450, 22)
        Me.txt_NOM_CLI.TabIndex = 114
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(472, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 14)
        Me.Label13.TabIndex = 113
        Me.Label13.Text = "Cliente"
        '
        'btnBuscaCliente
        '
        Me.btnBuscaCliente.BackColor = System.Drawing.Color.White
        Me.btnBuscaCliente.Enabled = False
        Me.btnBuscaCliente.Image = Global.GestionVivero.My.Resources.Resources.PREVIEW
        Me.btnBuscaCliente.Location = New System.Drawing.Point(297, 13)
        Me.btnBuscaCliente.Name = "btnBuscaCliente"
        Me.btnBuscaCliente.Size = New System.Drawing.Size(30, 32)
        Me.btnBuscaCliente.TabIndex = 115
        Me.btnBuscaCliente.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 14)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "Seleccione Cliente"
        '
        'txt_IDcliente
        '
        Me.txt_IDcliente.Location = New System.Drawing.Point(1092, 16)
        Me.txt_IDcliente.Name = "txt_IDcliente"
        Me.txt_IDcliente.Size = New System.Drawing.Size(100, 22)
        Me.txt_IDcliente.TabIndex = 119
        Me.txt_IDcliente.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGuias)
        Me.GroupBox1.Location = New System.Drawing.Point(74, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1138, 254)
        Me.GroupBox1.TabIndex = 121
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Guías Emitidas"
        '
        'DataGuias
        '
        Me.DataGuias.AllowUserToAddRows = False
        Me.DataGuias.AllowUserToDeleteRows = False
        Me.DataGuias.AllowUserToResizeColumns = False
        Me.DataGuias.AllowUserToResizeRows = False
        Me.DataGuias.BackgroundColor = System.Drawing.Color.White
        Me.DataGuias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGuias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Guia, Me.FechaGuia, Me.BandejasGuia, Me.EspecieGuia, Me.VariedadGuia, Me.PrecioGuia, Me.CantidadGuia, Me.saldoplantas})
        Me.DataGuias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGuias.Enabled = False
        Me.DataGuias.Location = New System.Drawing.Point(3, 18)
        Me.DataGuias.Name = "DataGuias"
        Me.DataGuias.RowHeadersVisible = False
        Me.DataGuias.Size = New System.Drawing.Size(1132, 233)
        Me.DataGuias.TabIndex = 121
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(256, 349)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 14)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "N° Guía Seleccionada:"
        '
        'txtGuiaSeleccionada
        '
        Me.txtGuiaSeleccionada.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtGuiaSeleccionada.Enabled = False
        Me.txtGuiaSeleccionada.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuiaSeleccionada.ForeColor = System.Drawing.Color.Black
        Me.txtGuiaSeleccionada.Location = New System.Drawing.Point(388, 346)
        Me.txtGuiaSeleccionada.Name = "txtGuiaSeleccionada"
        Me.txtGuiaSeleccionada.ReadOnly = True
        Me.txtGuiaSeleccionada.Size = New System.Drawing.Size(106, 21)
        Me.txtGuiaSeleccionada.TabIndex = 123
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(527, 349)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 14)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "Saldo Plantas:"
        '
        'Guia
        '
        Me.Guia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Guia.HeaderText = "N° Guía"
        Me.Guia.Name = "Guia"
        Me.Guia.ReadOnly = True
        Me.Guia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'FechaGuia
        '
        Me.FechaGuia.HeaderText = "Fecha"
        Me.FechaGuia.Name = "FechaGuia"
        '
        'BandejasGuia
        '
        Me.BandejasGuia.HeaderText = "Bandejas"
        Me.BandejasGuia.Name = "BandejasGuia"
        '
        'EspecieGuia
        '
        Me.EspecieGuia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EspecieGuia.HeaderText = "Especie"
        Me.EspecieGuia.Name = "EspecieGuia"
        '
        'VariedadGuia
        '
        Me.VariedadGuia.HeaderText = "Variedad"
        Me.VariedadGuia.Name = "VariedadGuia"
        '
        'PrecioGuia
        '
        Me.PrecioGuia.HeaderText = "Precio Venta"
        Me.PrecioGuia.Name = "PrecioGuia"
        '
        'CantidadGuia
        '
        Me.CantidadGuia.HeaderText = "Cantidad"
        Me.CantidadGuia.Name = "CantidadGuia"
        '
        'saldoplantas
        '
        Me.saldoplantas.HeaderText = "Saldo Plantas"
        Me.saldoplantas.Name = "saldoplantas"
        '
        'txtSaldoPlantas
        '
        Me.txtSaldoPlantas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSaldoPlantas.Enabled = False
        Me.txtSaldoPlantas.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoPlantas.ForeColor = System.Drawing.Color.Black
        Me.txtSaldoPlantas.Location = New System.Drawing.Point(618, 346)
        Me.txtSaldoPlantas.Name = "txtSaldoPlantas"
        Me.txtSaldoPlantas.ReadOnly = True
        Me.txtSaldoPlantas.Size = New System.Drawing.Size(106, 21)
        Me.txtSaldoPlantas.TabIndex = 125
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(781, 349)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 14)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "Cantidad Plantas Devolución:"
        '
        'txtPlantasDevolucion
        '
        Me.txtPlantasDevolucion.BackColor = System.Drawing.Color.White
        Me.txtPlantasDevolucion.Enabled = False
        Me.txtPlantasDevolucion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlantasDevolucion.ForeColor = System.Drawing.Color.Black
        Me.txtPlantasDevolucion.Location = New System.Drawing.Point(953, 346)
        Me.txtPlantasDevolucion.Name = "txtPlantasDevolucion"
        Me.txtPlantasDevolucion.Size = New System.Drawing.Size(106, 21)
        Me.txtPlantasDevolucion.TabIndex = 127
        '
        'DevolucionPlantas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1271, 485)
        Me.Controls.Add(Me.txtPlantasDevolucion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSaldoPlantas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtGuiaSeleccionada)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_IDcliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkCliente)
        Me.Controls.Add(Me.txt_Rut_Cli)
        Me.Controls.Add(Me.btnBuscaCliente)
        Me.Controls.Add(Me.txt_clientebuscar)
        Me.Controls.Add(Me.txt_NOM_CLI)
        Me.Controls.Add(Me.Label13)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "DevolucionPlantas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Devolucion Plantas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGuias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkCliente As CheckBox
    Friend WithEvents txt_Rut_Cli As TextBox
    Friend WithEvents btnBuscaCliente As Button
    Friend WithEvents txt_clientebuscar As TextBox
    Friend WithEvents txt_NOM_CLI As MaskedTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_IDcliente As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGuias As DataGridView
    Friend WithEvents Guia As DataGridViewTextBoxColumn
    Friend WithEvents FechaGuia As DataGridViewTextBoxColumn
    Friend WithEvents BandejasGuia As DataGridViewTextBoxColumn
    Friend WithEvents EspecieGuia As DataGridViewTextBoxColumn
    Friend WithEvents VariedadGuia As DataGridViewTextBoxColumn
    Friend WithEvents PrecioGuia As DataGridViewTextBoxColumn
    Friend WithEvents CantidadGuia As DataGridViewTextBoxColumn
    Friend WithEvents saldoplantas As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGuiaSeleccionada As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSaldoPlantas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPlantasDevolucion As TextBox
End Class
