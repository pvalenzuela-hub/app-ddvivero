<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanCuentas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cmb_SaldoDiario = New System.Windows.Forms.ComboBox()
        Me.txt_ReferTipo = New System.Windows.Forms.TextBox()
        Me.txt_SaldoHaber = New System.Windows.Forms.TextBox()
        Me.txt_SaldoDebe = New System.Windows.Forms.TextBox()
        Me.txt_SaldoInicial = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_TipoCta = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Descrip = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Cta_Ctble = New System.Windows.Forms.TextBox()
        Me.DataPlan = New System.Windows.Forms.DataGridView()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldoinicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoDebe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldohaber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tiporefer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EsSaldodiario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 1)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmb_SaldoDiario)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_ReferTipo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_SaldoHaber)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_SaldoDebe)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_SaldoInicial)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmb_TipoCta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Descrip)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Cta_Ctble)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataPlan)
        Me.SplitContainer1.Size = New System.Drawing.Size(932, 563)
        Me.SplitContainer1.SplitterDistance = 247
        Me.SplitContainer1.TabIndex = 0
        '
        'cmb_SaldoDiario
        '
        Me.cmb_SaldoDiario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_SaldoDiario.FormattingEnabled = True
        Me.cmb_SaldoDiario.Items.AddRange(New Object() {"S", "N"})
        Me.cmb_SaldoDiario.Location = New System.Drawing.Point(178, 198)
        Me.cmb_SaldoDiario.Name = "cmb_SaldoDiario"
        Me.cmb_SaldoDiario.Size = New System.Drawing.Size(50, 21)
        Me.cmb_SaldoDiario.TabIndex = 15
        '
        'txt_ReferTipo
        '
        Me.txt_ReferTipo.Location = New System.Drawing.Point(178, 159)
        Me.txt_ReferTipo.MaxLength = 1
        Me.txt_ReferTipo.Name = "txt_ReferTipo"
        Me.txt_ReferTipo.Size = New System.Drawing.Size(25, 20)
        Me.txt_ReferTipo.TabIndex = 14
        '
        'txt_SaldoHaber
        '
        Me.txt_SaldoHaber.Location = New System.Drawing.Point(381, 128)
        Me.txt_SaldoHaber.Name = "txt_SaldoHaber"
        Me.txt_SaldoHaber.Size = New System.Drawing.Size(100, 20)
        Me.txt_SaldoHaber.TabIndex = 13
        '
        'txt_SaldoDebe
        '
        Me.txt_SaldoDebe.Location = New System.Drawing.Point(178, 124)
        Me.txt_SaldoDebe.Name = "txt_SaldoDebe"
        Me.txt_SaldoDebe.Size = New System.Drawing.Size(100, 20)
        Me.txt_SaldoDebe.TabIndex = 12
        '
        'txt_SaldoInicial
        '
        Me.txt_SaldoInicial.Location = New System.Drawing.Point(178, 94)
        Me.txt_SaldoInicial.Name = "txt_SaldoInicial"
        Me.txt_SaldoInicial.Size = New System.Drawing.Size(100, 20)
        Me.txt_SaldoInicial.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(44, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Requiere Saldo Diario?"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Tipo Referencia"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(312, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Saldo Haber"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Saldo Debe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Saldo Inicial"
        '
        'cmb_TipoCta
        '
        Me.cmb_TipoCta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoCta.FormattingEnabled = True
        Me.cmb_TipoCta.Items.AddRange(New Object() {"A", "P", "I", "E", "O"})
        Me.cmb_TipoCta.Location = New System.Drawing.Point(178, 59)
        Me.cmb_TipoCta.Name = "cmb_TipoCta"
        Me.cmb_TipoCta.Size = New System.Drawing.Size(50, 21)
        Me.cmb_TipoCta.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tipo Cuenta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(312, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descripción"
        '
        'txt_Descrip
        '
        Me.txt_Descrip.Location = New System.Drawing.Point(381, 28)
        Me.txt_Descrip.MaxLength = 100
        Me.txt_Descrip.Name = "txt_Descrip"
        Me.txt_Descrip.Size = New System.Drawing.Size(309, 20)
        Me.txt_Descrip.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cuenta"
        '
        'txt_Cta_Ctble
        '
        Me.txt_Cta_Ctble.Location = New System.Drawing.Point(178, 31)
        Me.txt_Cta_Ctble.MaxLength = 7
        Me.txt_Cta_Ctble.Name = "txt_Cta_Ctble"
        Me.txt_Cta_Ctble.Size = New System.Drawing.Size(100, 20)
        Me.txt_Cta_Ctble.TabIndex = 0
        '
        'DataPlan
        '
        Me.DataPlan.AllowUserToAddRows = False
        Me.DataPlan.AllowUserToDeleteRows = False
        Me.DataPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataPlan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cuenta, Me.descrip, Me.tipo, Me.Saldoinicial, Me.SaldoDebe, Me.Saldohaber, Me.tiporefer, Me.EsSaldodiario})
        Me.DataPlan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataPlan.Location = New System.Drawing.Point(0, 0)
        Me.DataPlan.Name = "DataPlan"
        Me.DataPlan.ReadOnly = True
        Me.DataPlan.Size = New System.Drawing.Size(932, 312)
        Me.DataPlan.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(164, 580)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(149, 23)
        Me.Button5.TabIndex = 103
        Me.Button5.Text = "Nueva Cuenta"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(637, 580)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(132, 23)
        Me.Button4.TabIndex = 102
        Me.Button4.Text = "Volver"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(482, 580)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 23)
        Me.Button3.TabIndex = 101
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(327, 580)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 23)
        Me.Button2.TabIndex = 100
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(789, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 28)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Actualizar Cuenta"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cuenta
        '
        Me.cuenta.HeaderText = "Cuenta"
        Me.cuenta.Name = "cuenta"
        Me.cuenta.ReadOnly = True
        '
        'descrip
        '
        Me.descrip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.descrip.HeaderText = "Descripción"
        Me.descrip.Name = "descrip"
        Me.descrip.ReadOnly = True
        '
        'tipo
        '
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        '
        'Saldoinicial
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Saldoinicial.DefaultCellStyle = DataGridViewCellStyle1
        Me.Saldoinicial.HeaderText = "Saldo Inicial"
        Me.Saldoinicial.Name = "Saldoinicial"
        Me.Saldoinicial.ReadOnly = True
        '
        'SaldoDebe
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.SaldoDebe.DefaultCellStyle = DataGridViewCellStyle2
        Me.SaldoDebe.HeaderText = "Saldo Debe"
        Me.SaldoDebe.Name = "SaldoDebe"
        Me.SaldoDebe.ReadOnly = True
        '
        'Saldohaber
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Saldohaber.DefaultCellStyle = DataGridViewCellStyle3
        Me.Saldohaber.HeaderText = "Saldo Haber"
        Me.Saldohaber.Name = "Saldohaber"
        Me.Saldohaber.ReadOnly = True
        '
        'tiporefer
        '
        Me.tiporefer.HeaderText = "Tipo Referencia"
        Me.tiporefer.Name = "tiporefer"
        Me.tiporefer.ReadOnly = True
        '
        'EsSaldodiario
        '
        Me.EsSaldodiario.HeaderText = "Saldo Diario?"
        Me.EsSaldodiario.Name = "EsSaldodiario"
        Me.EsSaldodiario.ReadOnly = True
        '
        'PlanCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 615)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PlanCuentas"
        Me.Text = "Plan de Cuentas"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataPlan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents cmb_SaldoDiario As System.Windows.Forms.ComboBox
    Friend WithEvents txt_ReferTipo As System.Windows.Forms.TextBox
    Friend WithEvents txt_SaldoHaber As System.Windows.Forms.TextBox
    Friend WithEvents txt_SaldoDebe As System.Windows.Forms.TextBox
    Friend WithEvents txt_SaldoInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoCta As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Descrip As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Cta_Ctble As System.Windows.Forms.TextBox
    Friend WithEvents DataPlan As System.Windows.Forms.DataGridView
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descrip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Saldoinicial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoDebe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Saldohaber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tiporefer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EsSaldodiario As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
