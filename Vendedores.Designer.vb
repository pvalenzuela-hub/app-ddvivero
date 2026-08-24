<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vendedores
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txt_Codigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtporcomis = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkEsCajero = New System.Windows.Forms.CheckBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnRestablecerPassword = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Vendedor = New System.Windows.Forms.TextBox()
        Me.DataVendedor = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPerfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Perfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbPerfil = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Codigo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtporcomis)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtUsuario)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbPerfil)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPassword)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkEsCajero)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnRestablecerPassword)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Vendedor)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataVendedor)
        Me.SplitContainer1.Size = New System.Drawing.Size(681, 546)
        Me.SplitContainer1.SplitterDistance = 220
        Me.SplitContainer1.TabIndex = 0
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Location = New System.Drawing.Point(207, 138)
        Me.txt_Codigo.MaxLength = 10
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.ReadOnly = True
        Me.txt_Codigo.Size = New System.Drawing.Size(259, 20)
        Me.txt_Codigo.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(166, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Código"
        '
        'txtporcomis
        '
        Me.txtporcomis.Location = New System.Drawing.Point(207, 105)
        Me.txtporcomis.MaxLength = 50
        Me.txtporcomis.Name = "txtporcomis"
        Me.txtporcomis.Size = New System.Drawing.Size(43, 20)
        Me.txtporcomis.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "% Comisión"
        '
        'Button5
        '
        Me.Button5.Image = Global.GestionVivero.My.Resources.Resources.Notes
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(589, 75)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(82, 32)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Editar"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(207, 69)
        Me.txtUsuario.MaxLength = 10
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(259, 20)
        Me.txtUsuario.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Usuario"
        '
        'chkEsCajero
        '
        Me.chkEsCajero.AutoSize = True
        Me.chkEsCajero.Location = New System.Drawing.Point(207, 199)
        Me.chkEsCajero.Name = "chkEsCajero"
        Me.chkEsCajero.Size = New System.Drawing.Size(77, 17)
        Me.chkEsCajero.TabIndex = 13
        Me.chkEsCajero.Text = "Es Cajero"
        Me.chkEsCajero.UseVisualStyleBackColor = True
        '
        'cmbPerfil
        '
        Me.cmbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPerfil.FormattingEnabled = True
        Me.cmbPerfil.Location = New System.Drawing.Point(48, 138)
        Me.cmbPerfil.Name = "cmbPerfil"
        Me.cmbPerfil.Size = New System.Drawing.Size(110, 21)
        Me.cmbPerfil.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Perfil"
        '
        'txtPassword
        '
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(207, 170)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(259, 20)
        Me.txtPassword.TabIndex = 16
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(138, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Contraseña"
        '
        'Button4
        '
        Me.Button4.Image = Global.GestionVivero.My.Resources.Resources.Close
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(589, 139)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(82, 32)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Salir"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.GestionVivero.My.Resources.Resources.Delete
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(589, 107)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 32)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Eliminar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnRestablecerPassword
        '
        Me.btnRestablecerPassword.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.btnRestablecerPassword.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRestablecerPassword.Location = New System.Drawing.Point(589, 171)
        Me.btnRestablecerPassword.Name = "btnRestablecerPassword"
        Me.btnRestablecerPassword.Size = New System.Drawing.Size(82, 40)
        Me.btnRestablecerPassword.TabIndex = 18
        Me.btnRestablecerPassword.Text = "Reset Clave"
        Me.btnRestablecerPassword.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRestablecerPassword.UseVisualStyleBackColor = True
        Me.btnRestablecerPassword.Visible = False
        '
        'Button2
        '
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(589, 43)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 32)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Actualizar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Add
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(589, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Nuevo"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Vendedor"
        '
        'txt_Vendedor
        '
        Me.txt_Vendedor.Location = New System.Drawing.Point(207, 37)
        Me.txt_Vendedor.MaxLength = 50
        Me.txt_Vendedor.Name = "txt_Vendedor"
        Me.txt_Vendedor.Size = New System.Drawing.Size(259, 20)
        Me.txt_Vendedor.TabIndex = 0
        '
        'DataVendedor
        '
        Me.DataVendedor.AllowUserToAddRows = False
        Me.DataVendedor.AllowUserToDeleteRows = False
        Me.DataVendedor.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataVendedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.Vendedor, Me.Column1, Me.Column2, Me.Column3, Me.IdPerfil, Me.Perfil})
        Me.DataVendedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataVendedor.Location = New System.Drawing.Point(0, 0)
        Me.DataVendedor.Name = "DataVendedor"
        Me.DataVendedor.ReadOnly = True
        Me.DataVendedor.Size = New System.Drawing.Size(681, 352)
        Me.DataVendedor.TabIndex = 0
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'Vendedor
        '
        Me.Vendedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Vendedor.HeaderText = "Vendedor"
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.ReadOnly = True
        '
        'Column1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.HeaderText = "% Comisión"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "IdUsuario"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "EsCajero"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'IdPerfil
        '
        Me.IdPerfil.HeaderText = "IdPerfil"
        Me.IdPerfil.Name = "IdPerfil"
        Me.IdPerfil.ReadOnly = True
        Me.IdPerfil.Visible = False
        '
        'Perfil
        '
        Me.Perfil.HeaderText = "Perfil"
        Me.Perfil.Name = "Perfil"
        Me.Perfil.ReadOnly = True
        '
        'Vendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 546)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Vendedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnRestablecerPassword As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Vendedor As System.Windows.Forms.TextBox
    Friend WithEvents DataVendedor As System.Windows.Forms.DataGridView
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txtporcomis As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Codigo As TextBox
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents Vendedor As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents chkEsCajero As CheckBox
    Friend WithEvents IdPerfil As DataGridViewTextBoxColumn
    Friend WithEvents Perfil As DataGridViewTextBoxColumn
    Friend WithEvents cmbPerfil As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label6 As Label
End Class
