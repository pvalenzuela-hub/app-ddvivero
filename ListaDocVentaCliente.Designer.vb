<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaDocVentaCliente
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
        Me.DataDocVentaNC = New System.Windows.Forms.DataGridView()
        Me.documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechadoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numguia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_Guia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Familia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Variedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Neto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant_Band_Retiro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant_Plantas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idvtadet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdFamilia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdVariedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipodoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numdoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numnc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataDocVentaNC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataDocVentaNC
        '
        Me.DataDocVentaNC.AllowUserToAddRows = False
        Me.DataDocVentaNC.AllowUserToDeleteRows = False
        Me.DataDocVentaNC.AllowUserToResizeColumns = False
        Me.DataDocVentaNC.AllowUserToResizeRows = False
        Me.DataDocVentaNC.BackgroundColor = System.Drawing.Color.White
        Me.DataDocVentaNC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataDocVentaNC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.documento, Me.fechadoc, Me.valor, Me.numguia, Me.Fecha_Guia, Me.Familia, Me.Variedad, Me.Precio_Neto, Me.Cant_Band_Retiro, Me.Cant_Plantas, Me.idvtadet, Me.IdFamilia, Me.IdVariedad, Me.tipodoc, Me.numdoc, Me.numnc})
        Me.DataDocVentaNC.Location = New System.Drawing.Point(1, 1)
        Me.DataDocVentaNC.Name = "DataDocVentaNC"
        Me.DataDocVentaNC.ReadOnly = True
        Me.DataDocVentaNC.RowHeadersVisible = False
        Me.DataDocVentaNC.Size = New System.Drawing.Size(1057, 150)
        Me.DataDocVentaNC.TabIndex = 0
        '
        'documento
        '
        Me.documento.HeaderText = "Documento"
        Me.documento.Name = "documento"
        Me.documento.ReadOnly = True
        '
        'fechadoc
        '
        Me.fechadoc.HeaderText = "Fecha"
        Me.fechadoc.Name = "fechadoc"
        Me.fechadoc.ReadOnly = True
        '
        'valor
        '
        Me.valor.HeaderText = "Valor"
        Me.valor.Name = "valor"
        Me.valor.ReadOnly = True
        '
        'numguia
        '
        Me.numguia.HeaderText = "N° Guía"
        Me.numguia.Name = "numguia"
        Me.numguia.ReadOnly = True
        Me.numguia.Width = 50
        '
        'Fecha_Guia
        '
        Me.Fecha_Guia.HeaderText = "Fecha Retiro"
        Me.Fecha_Guia.Name = "Fecha_Guia"
        Me.Fecha_Guia.ReadOnly = True
        '
        'Familia
        '
        Me.Familia.HeaderText = "Semilla"
        Me.Familia.Name = "Familia"
        Me.Familia.ReadOnly = True
        '
        'Variedad
        '
        Me.Variedad.HeaderText = "Variedad"
        Me.Variedad.Name = "Variedad"
        Me.Variedad.ReadOnly = True
        '
        'Precio_Neto
        '
        Me.Precio_Neto.HeaderText = "Precio Unit."
        Me.Precio_Neto.Name = "Precio_Neto"
        Me.Precio_Neto.ReadOnly = True
        '
        'Cant_Band_Retiro
        '
        Me.Cant_Band_Retiro.HeaderText = "Bandejas Retiro"
        Me.Cant_Band_Retiro.Name = "Cant_Band_Retiro"
        Me.Cant_Band_Retiro.ReadOnly = True
        '
        'Cant_Plantas
        '
        Me.Cant_Plantas.HeaderText = "Plantas Retiro"
        Me.Cant_Plantas.Name = "Cant_Plantas"
        Me.Cant_Plantas.ReadOnly = True
        '
        'idvtadet
        '
        Me.idvtadet.HeaderText = "IdVtaDet"
        Me.idvtadet.Name = "idvtadet"
        Me.idvtadet.ReadOnly = True
        Me.idvtadet.Visible = False
        '
        'IdFamilia
        '
        Me.IdFamilia.HeaderText = "IdFamilia"
        Me.IdFamilia.Name = "IdFamilia"
        Me.IdFamilia.ReadOnly = True
        Me.IdFamilia.Visible = False
        '
        'IdVariedad
        '
        Me.IdVariedad.HeaderText = "IdVariedad"
        Me.IdVariedad.Name = "IdVariedad"
        Me.IdVariedad.ReadOnly = True
        Me.IdVariedad.Visible = False
        '
        'tipodoc
        '
        Me.tipodoc.HeaderText = "tipodoc"
        Me.tipodoc.Name = "tipodoc"
        Me.tipodoc.ReadOnly = True
        Me.tipodoc.Visible = False
        '
        'numdoc
        '
        Me.numdoc.HeaderText = "numdoc"
        Me.numdoc.Name = "numdoc"
        Me.numdoc.ReadOnly = True
        Me.numdoc.Visible = False
        '
        'numnc
        '
        Me.numnc.HeaderText = "Nota Crédito"
        Me.numnc.Name = "numnc"
        Me.numnc.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Cyan
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(440, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Seleccione Guía a Devolver"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.salir_40x40
        Me.Button2.Location = New System.Drawing.Point(999, 157)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(49, 49)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListaDocVentaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1060, 217)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataDocVentaNC)
        Me.Name = "ListaDocVentaCliente"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selección Documentos Venta  para Nota de Crédito"
        Me.TopMost = True
        CType(Me.DataDocVentaNC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataDocVentaNC As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents documento As DataGridViewTextBoxColumn
    Friend WithEvents fechadoc As DataGridViewTextBoxColumn
    Friend WithEvents valor As DataGridViewTextBoxColumn
    Friend WithEvents numguia As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Guia As DataGridViewTextBoxColumn
    Friend WithEvents Familia As DataGridViewTextBoxColumn
    Friend WithEvents Variedad As DataGridViewTextBoxColumn
    Friend WithEvents Precio_Neto As DataGridViewTextBoxColumn
    Friend WithEvents Cant_Band_Retiro As DataGridViewTextBoxColumn
    Friend WithEvents Cant_Plantas As DataGridViewTextBoxColumn
    Friend WithEvents idvtadet As DataGridViewTextBoxColumn
    Friend WithEvents IdFamilia As DataGridViewTextBoxColumn
    Friend WithEvents IdVariedad As DataGridViewTextBoxColumn
    Friend WithEvents tipodoc As DataGridViewTextBoxColumn
    Friend WithEvents numdoc As DataGridViewTextBoxColumn
    Friend WithEvents numnc As DataGridViewTextBoxColumn
End Class
