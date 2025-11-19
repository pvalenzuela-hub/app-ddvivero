<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BusquedaCliente))
        Me.DataClientes = New System.Windows.Forms.DataGridView()
        Me.rut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rutnoedit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idcliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idSector = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoclienteId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.chkIncluyePrimerNombre = New System.Windows.Forms.CheckBox()
        Me.txt_clientebuscar = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.DataClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataClientes
        '
        Me.DataClientes.AllowUserToAddRows = False
        Me.DataClientes.AllowUserToDeleteRows = False
        Me.DataClientes.AllowUserToResizeColumns = False
        Me.DataClientes.AllowUserToResizeRows = False
        Me.DataClientes.BackgroundColor = System.Drawing.Color.White
        Me.DataClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rut, Me.Nombre, Me.direccion, Me.telefono, Me.rutnoedit, Me.idcliente, Me.idSector, Me.Column1, Me.Column2, Me.EstadoclienteId})
        Me.DataClientes.Location = New System.Drawing.Point(3, 58)
        Me.DataClientes.Name = "DataClientes"
        Me.DataClientes.RowHeadersVisible = False
        Me.DataClientes.Size = New System.Drawing.Size(828, 461)
        Me.DataClientes.TabIndex = 0
        '
        'rut
        '
        Me.rut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.rut.HeaderText = "Rut"
        Me.rut.Name = "rut"
        Me.rut.Width = 49
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 398
        '
        'direccion
        '
        Me.direccion.HeaderText = "Dirección"
        Me.direccion.Name = "direccion"
        Me.direccion.Width = 77
        '
        'telefono
        '
        Me.telefono.HeaderText = "Teléfono"
        Me.telefono.Name = "telefono"
        '
        'rutnoedit
        '
        Me.rutnoedit.HeaderText = "Rut noedit"
        Me.rutnoedit.Name = "rutnoedit"
        Me.rutnoedit.Width = 5
        '
        'idcliente
        '
        Me.idcliente.HeaderText = "Id cliente"
        Me.idcliente.Name = "idcliente"
        Me.idcliente.Width = 5
        '
        'idSector
        '
        Me.idSector.HeaderText = "IdSector"
        Me.idSector.Name = "idSector"
        Me.idSector.Width = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "Abono"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Notas"
        Me.Column2.Name = "Column2"
        Me.Column2.Visible = False
        '
        'EstadoclienteId
        '
        Me.EstadoclienteId.HeaderText = "EstadoclienteId"
        Me.EstadoclienteId.Name = "EstadoclienteId"
        Me.EstadoclienteId.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button1.Location = New System.Drawing.Point(838, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 53)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.Delete1
        Me.Button2.Location = New System.Drawing.Point(838, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 53)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = False
        '
        'chkIncluyePrimerNombre
        '
        Me.chkIncluyePrimerNombre.AutoSize = True
        Me.chkIncluyePrimerNombre.Location = New System.Drawing.Point(12, 24)
        Me.chkIncluyePrimerNombre.Name = "chkIncluyePrimerNombre"
        Me.chkIncluyePrimerNombre.Size = New System.Drawing.Size(220, 17)
        Me.chkIncluyePrimerNombre.TabIndex = 3
        Me.chkIncluyePrimerNombre.Text = "incluye primer nombre (solo para Clientes)"
        Me.chkIncluyePrimerNombre.UseVisualStyleBackColor = True
        '
        'txt_clientebuscar
        '
        Me.txt_clientebuscar.BackColor = System.Drawing.SystemColors.Window
        Me.txt_clientebuscar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clientebuscar.ForeColor = System.Drawing.Color.Navy
        Me.txt_clientebuscar.Location = New System.Drawing.Point(238, 22)
        Me.txt_clientebuscar.Name = "txt_clientebuscar"
        Me.txt_clientebuscar.Size = New System.Drawing.Size(186, 21)
        Me.txt_clientebuscar.TabIndex = 4
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button6.Location = New System.Drawing.Point(430, 21)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(66, 23)
        Me.Button6.TabIndex = 23
        Me.Button6.Text = "Buscar"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'BusquedaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(928, 522)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.txt_clientebuscar)
        Me.Controls.Add(Me.chkIncluyePrimerNombre)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataClientes)
        Me.Name = "BusquedaCliente"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nómina"
        CType(Me.DataClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataClientes As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents chkIncluyePrimerNombre As CheckBox
    Friend WithEvents txt_clientebuscar As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents rut As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents rutnoedit As DataGridViewTextBoxColumn
    Friend WithEvents idcliente As DataGridViewTextBoxColumn
    Friend WithEvents idSector As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents EstadoclienteId As DataGridViewTextBoxColumn
End Class
