<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificaDocumentoVenta
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumDoc = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataDocVenta = New System.Windows.Forms.DataGridView()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numdoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numdocsii = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipodocsii = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idVtaHead = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbsindoc = New System.Windows.Forms.RadioButton()
        Me.rbcondoc = New System.Windows.Forms.RadioButton()
        Me.rbtodosdoc = New System.Windows.Forms.RadioButton()
        CType(Me.DataDocVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "N°"
        '
        'txtNumDoc
        '
        Me.txtNumDoc.Location = New System.Drawing.Point(56, 20)
        Me.txtNumDoc.Name = "txtNumDoc"
        Me.txtNumDoc.Size = New System.Drawing.Size(100, 20)
        Me.txtNumDoc.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.buscar_40x40
        Me.Button1.Location = New System.Drawing.Point(810, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 49)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataDocVenta
        '
        Me.DataDocVenta.AllowUserToAddRows = False
        Me.DataDocVenta.AllowUserToDeleteRows = False
        Me.DataDocVenta.AllowUserToResizeColumns = False
        Me.DataDocVenta.AllowUserToResizeRows = False
        Me.DataDocVenta.BackgroundColor = System.Drawing.Color.White
        Me.DataDocVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataDocVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.Cliente, Me.Tipo, Me.Numdoc, Me.Monto, Me.Numdocsii, Me.Tipodocsii, Me.idVtaHead})
        Me.DataDocVenta.Location = New System.Drawing.Point(12, 74)
        Me.DataDocVenta.Name = "DataDocVenta"
        Me.DataDocVenta.ReadOnly = True
        Me.DataDocVenta.RowHeadersVisible = False
        Me.DataDocVenta.Size = New System.Drawing.Size(847, 364)
        Me.DataDocVenta.TabIndex = 6
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Cliente
        '
        Me.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        '
        'Numdoc
        '
        Me.Numdoc.HeaderText = "N°"
        Me.Numdoc.Name = "Numdoc"
        Me.Numdoc.ReadOnly = True
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto Documento"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        '
        'Numdocsii
        '
        Me.Numdocsii.HeaderText = "N° SII"
        Me.Numdocsii.Name = "Numdocsii"
        Me.Numdocsii.ReadOnly = True
        Me.Numdocsii.Width = 120
        '
        'Tipodocsii
        '
        Me.Tipodocsii.HeaderText = "Tipo Doc.SII"
        Me.Tipodocsii.Name = "Tipodocsii"
        Me.Tipodocsii.ReadOnly = True
        '
        'idVtaHead
        '
        Me.idVtaHead.HeaderText = "IdVtaHead"
        Me.idVtaHead.Name = "idVtaHead"
        Me.idVtaHead.ReadOnly = True
        Me.idVtaHead.Visible = False
        '
        'cmbTipoDoc
        '
        Me.cmbTipoDoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoDoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbTipoDoc.FormattingEnabled = True
        Me.cmbTipoDoc.Items.AddRange(New Object() {"", "FE", "BL"})
        Me.cmbTipoDoc.Location = New System.Drawing.Point(243, 19)
        Me.cmbTipoDoc.Name = "cmbTipoDoc"
        Me.cmbTipoDoc.Size = New System.Drawing.Size(55, 21)
        Me.cmbTipoDoc.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(189, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Tipo Doc."
        '
        'rbsindoc
        '
        Me.rbsindoc.AutoSize = True
        Me.rbsindoc.Location = New System.Drawing.Point(345, 22)
        Me.rbsindoc.Name = "rbsindoc"
        Me.rbsindoc.Size = New System.Drawing.Size(82, 17)
        Me.rbsindoc.TabIndex = 10
        Me.rbsindoc.TabStop = True
        Me.rbsindoc.Text = "Sin Doc. SII"
        Me.rbsindoc.UseVisualStyleBackColor = True
        '
        'rbcondoc
        '
        Me.rbcondoc.AutoSize = True
        Me.rbcondoc.Location = New System.Drawing.Point(434, 22)
        Me.rbcondoc.Name = "rbcondoc"
        Me.rbcondoc.Size = New System.Drawing.Size(86, 17)
        Me.rbcondoc.TabIndex = 11
        Me.rbcondoc.TabStop = True
        Me.rbcondoc.Text = "Con Doc. SII"
        Me.rbcondoc.UseVisualStyleBackColor = True
        '
        'rbtodosdoc
        '
        Me.rbtodosdoc.AutoSize = True
        Me.rbtodosdoc.Location = New System.Drawing.Point(526, 22)
        Me.rbtodosdoc.Name = "rbtodosdoc"
        Me.rbtodosdoc.Size = New System.Drawing.Size(97, 17)
        Me.rbtodosdoc.TabIndex = 12
        Me.rbtodosdoc.TabStop = True
        Me.rbtodosdoc.Text = "Todos Doc. SII"
        Me.rbtodosdoc.UseVisualStyleBackColor = True
        '
        'ModificaDocumentoVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(871, 450)
        Me.Controls.Add(Me.rbtodosdoc)
        Me.Controls.Add(Me.rbcondoc)
        Me.Controls.Add(Me.rbsindoc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbTipoDoc)
        Me.Controls.Add(Me.DataDocVenta)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtNumDoc)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ModificaDocumentoVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modifica Documento Venta"
        CType(Me.DataDocVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumDoc As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataDocVenta As DataGridView
    Friend WithEvents cmbTipoDoc As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rbsindoc As RadioButton
    Friend WithEvents rbcondoc As RadioButton
    Friend WithEvents rbtodosdoc As RadioButton
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Numdoc As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents Numdocsii As DataGridViewTextBoxColumn
    Friend WithEvents Tipodocsii As DataGridViewTextBoxColumn
    Friend WithEvents idVtaHead As DataGridViewTextBoxColumn
End Class
