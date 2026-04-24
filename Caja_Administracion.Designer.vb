<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Caja_Administracion
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnLiberar = New System.Windows.Forms.Button()
        Me.btnReasignar = New System.Windows.Forms.Button()
        Me.cmbCaja = New System.Windows.Forms.ComboBox()
        Me.lblCaja = New System.Windows.Forms.Label()
        Me.grdCajeros = New System.Windows.Forms.DataGridView()
        Me.btnCerrar = New System.Windows.Forms.Button()
        CType(Me.grdCajeros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLiberar
        '
        Me.btnLiberar.Location = New System.Drawing.Point(12, 12)
        Me.btnLiberar.Name = "btnLiberar"
        Me.btnLiberar.Size = New System.Drawing.Size(96, 30)
        Me.btnLiberar.TabIndex = 0
        Me.btnLiberar.Text = "Liberar"
        Me.btnLiberar.UseVisualStyleBackColor = True
        '
        'btnReasignar
        '
        Me.btnReasignar.Location = New System.Drawing.Point(114, 12)
        Me.btnReasignar.Name = "btnReasignar"
        Me.btnReasignar.Size = New System.Drawing.Size(96, 30)
        Me.btnReasignar.TabIndex = 1
        Me.btnReasignar.Text = "Reasignar"
        Me.btnReasignar.UseVisualStyleBackColor = True
        '
        'cmbCaja
        '
        Me.cmbCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCaja.FormattingEnabled = True
        Me.cmbCaja.Location = New System.Drawing.Point(276, 17)
        Me.cmbCaja.Name = "cmbCaja"
        Me.cmbCaja.Size = New System.Drawing.Size(214, 21)
        Me.cmbCaja.TabIndex = 2
        '
        'lblCaja
        '
        Me.lblCaja.AutoSize = True
        Me.lblCaja.Location = New System.Drawing.Point(228, 20)
        Me.lblCaja.Name = "lblCaja"
        Me.lblCaja.Size = New System.Drawing.Size(31, 13)
        Me.lblCaja.TabIndex = 3
        Me.lblCaja.Text = "Caja"
        '
        'grdCajeros
        '
        Me.grdCajeros.AllowUserToAddRows = False
        Me.grdCajeros.AllowUserToDeleteRows = False
        Me.grdCajeros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdCajeros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdCajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCajeros.Location = New System.Drawing.Point(12, 54)
        Me.grdCajeros.MultiSelect = False
        Me.grdCajeros.Name = "grdCajeros"
        Me.grdCajeros.ReadOnly = True
        Me.grdCajeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdCajeros.Size = New System.Drawing.Size(868, 404)
        Me.grdCajeros.TabIndex = 4
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Location = New System.Drawing.Point(784, 468)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(96, 30)
        Me.btnCerrar.TabIndex = 5
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Caja_Administracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 510)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.grdCajeros)
        Me.Controls.Add(Me.lblCaja)
        Me.Controls.Add(Me.cmbCaja)
        Me.Controls.Add(Me.btnReasignar)
        Me.Controls.Add(Me.btnLiberar)
        Me.Name = "Caja_Administracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Administración de Caja"
        CType(Me.grdCajeros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents btnLiberar As Button
    Friend WithEvents btnReasignar As Button
    Friend WithEvents cmbCaja As ComboBox
    Friend WithEvents lblCaja As Label
    Friend WithEvents grdCajeros As DataGridView
    Friend WithEvents btnCerrar As Button
End Class
