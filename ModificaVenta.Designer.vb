<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificaVenta
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
        Me.btnBuscaCliente = New System.Windows.Forms.Button()
        Me.txt_clientebuscar = New System.Windows.Forms.TextBox()
        Me.txt_NOM_CLI = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataDocumento = New System.Windows.Forms.DataGridView()
        Me.tipodoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numdoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipodocsii = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numdocsii = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valortotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalpagos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idvtahead = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkCliente
        '
        Me.chkCliente.AutoSize = True
        Me.chkCliente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCliente.Location = New System.Drawing.Point(446, 13)
        Me.chkCliente.Name = "chkCliente"
        Me.chkCliente.Size = New System.Drawing.Size(81, 18)
        Me.chkCliente.TabIndex = 117
        Me.chkCliente.Text = "por nombre"
        Me.chkCliente.UseVisualStyleBackColor = True
        '
        'txt_Rut_Cli
        '
        Me.txt_Rut_Cli.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_Rut_Cli.Location = New System.Drawing.Point(630, 59)
        Me.txt_Rut_Cli.Name = "txt_Rut_Cli"
        Me.txt_Rut_Cli.ReadOnly = True
        Me.txt_Rut_Cli.Size = New System.Drawing.Size(98, 22)
        Me.txt_Rut_Cli.TabIndex = 116
        '
        'btnBuscaCliente
        '
        Me.btnBuscaCliente.BackColor = System.Drawing.Color.White
        Me.btnBuscaCliente.Image = Global.GestionVivero.My.Resources.Resources.PREVIEW
        Me.btnBuscaCliente.Location = New System.Drawing.Point(527, 10)
        Me.btnBuscaCliente.Name = "btnBuscaCliente"
        Me.btnBuscaCliente.Size = New System.Drawing.Size(30, 30)
        Me.btnBuscaCliente.TabIndex = 115
        Me.btnBuscaCliente.UseVisualStyleBackColor = False
        '
        'txt_clientebuscar
        '
        Me.txt_clientebuscar.BackColor = System.Drawing.Color.White
        Me.txt_clientebuscar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clientebuscar.ForeColor = System.Drawing.Color.Black
        Me.txt_clientebuscar.Location = New System.Drawing.Point(111, 11)
        Me.txt_clientebuscar.Name = "txt_clientebuscar"
        Me.txt_clientebuscar.Size = New System.Drawing.Size(331, 21)
        Me.txt_clientebuscar.TabIndex = 112
        '
        'txt_NOM_CLI
        '
        Me.txt_NOM_CLI.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_NOM_CLI.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NOM_CLI.ForeColor = System.Drawing.Color.Navy
        Me.txt_NOM_CLI.Location = New System.Drawing.Point(15, 63)
        Me.txt_NOM_CLI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_NOM_CLI.Name = "txt_NOM_CLI"
        Me.txt_NOM_CLI.ReadOnly = True
        Me.txt_NOM_CLI.Size = New System.Drawing.Size(542, 27)
        Me.txt_NOM_CLI.TabIndex = 114
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 14)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Cliente a buscar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataDocumento)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(723, 141)
        Me.GroupBox1.TabIndex = 119
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Documentos de Venta"
        '
        'DataDocumento
        '
        Me.DataDocumento.AllowUserToAddRows = False
        Me.DataDocumento.AllowUserToDeleteRows = False
        Me.DataDocumento.AllowUserToResizeColumns = False
        Me.DataDocumento.AllowUserToResizeRows = False
        Me.DataDocumento.BackgroundColor = System.Drawing.Color.White
        Me.DataDocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataDocumento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tipodoc, Me.numdoc, Me.tipodocsii, Me.numdocsii, Me.fecha, Me.valortotal, Me.totalpagos, Me.idvtahead})
        Me.DataDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataDocumento.Location = New System.Drawing.Point(3, 18)
        Me.DataDocumento.Name = "DataDocumento"
        Me.DataDocumento.ReadOnly = True
        Me.DataDocumento.RowHeadersVisible = False
        Me.DataDocumento.Size = New System.Drawing.Size(717, 120)
        Me.DataDocumento.TabIndex = 2
        '
        'tipodoc
        '
        Me.tipodoc.HeaderText = "Tipo Doc."
        Me.tipodoc.Name = "tipodoc"
        Me.tipodoc.ReadOnly = True
        '
        'numdoc
        '
        Me.numdoc.HeaderText = "N° Doc."
        Me.numdoc.Name = "numdoc"
        Me.numdoc.ReadOnly = True
        '
        'tipodocsii
        '
        Me.tipodocsii.HeaderText = "Tipo Doc.SII"
        Me.tipodocsii.Name = "tipodocsii"
        Me.tipodocsii.ReadOnly = True
        '
        'numdocsii
        '
        Me.numdocsii.HeaderText = "N° Doc.SII"
        Me.numdocsii.Name = "numdocsii"
        Me.numdocsii.ReadOnly = True
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'valortotal
        '
        Me.valortotal.HeaderText = "Valor Total"
        Me.valortotal.Name = "valortotal"
        Me.valortotal.ReadOnly = True
        '
        'totalpagos
        '
        Me.totalpagos.HeaderText = "Total Pagos"
        Me.totalpagos.Name = "totalpagos"
        Me.totalpagos.ReadOnly = True
        '
        'idvtahead
        '
        Me.idvtahead.HeaderText = "IdVtaHead"
        Me.idvtahead.Name = "idvtahead"
        Me.idvtahead.ReadOnly = True
        Me.idvtahead.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(598, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 14)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "RUT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(593, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 14)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "N° Id"
        '
        'txtIdCliente
        '
        Me.txtIdCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtIdCliente.Location = New System.Drawing.Point(630, 84)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.ReadOnly = True
        Me.txtIdCliente.Size = New System.Drawing.Size(98, 22)
        Me.txtIdCliente.TabIndex = 122
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Cyan
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(301, 268)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 42)
        Me.Button1.TabIndex = 123
        Me.Button1.Text = "Seleccionar Documento"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.GestionVivero.My.Resources.Resources.salir_40x40
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Location = New System.Drawing.Point(677, 268)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(49, 49)
        Me.Button2.TabIndex = 124
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ModificaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(733, 326)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkCliente)
        Me.Controls.Add(Me.txt_Rut_Cli)
        Me.Controls.Add(Me.btnBuscaCliente)
        Me.Controls.Add(Me.txt_clientebuscar)
        Me.Controls.Add(Me.txt_NOM_CLI)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ModificaVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modifica Documento Venta"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkCliente As CheckBox
    Friend WithEvents txt_Rut_Cli As TextBox
    Friend WithEvents btnBuscaCliente As Button
    Friend WithEvents txt_clientebuscar As TextBox
    Friend WithEvents txt_NOM_CLI As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents DataDocumento As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents tipodoc As DataGridViewTextBoxColumn
    Friend WithEvents numdoc As DataGridViewTextBoxColumn
    Friend WithEvents tipodocsii As DataGridViewTextBoxColumn
    Friend WithEvents numdocsii As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents valortotal As DataGridViewTextBoxColumn
    Friend WithEvents totalpagos As DataGridViewTextBoxColumn
    Friend WithEvents idvtahead As DataGridViewTextBoxColumn
End Class
