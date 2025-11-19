<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaLotesPantalla
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
        Me.GrillaLotes = New System.Windows.Forms.DataGridView()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmbVariedad = New System.Windows.Forms.ComboBox()
        Me.SPCONSULTAFULLVARIEDADIdFamiliaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GESTDataSet = New GestionVivero.GESTDataSet()
        Me.cmbSemilla = New System.Windows.Forms.ComboBox()
        Me.SPCONSULTAFULLFAMILIAPRODUCTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SP_CONSULTA_FULL_FAMILIA_PRODUCTOTableAdapter = New GestionVivero.GESTDataSetTableAdapters.SP_CONSULTA_FULL_FAMILIA_PRODUCTOTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SP_CONSULTA_FULL_VARIEDAD_IdFamiliaTableAdapter = New GestionVivero.GESTDataSetTableAdapters.SP_CONSULTA_FULL_VARIEDAD_IdFamiliaTableAdapter()
        Me.nlote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.semilla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.variedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.aportasemilla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaconteos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldoplanta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldobandeja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechasiembra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaentrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estadolote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ubicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numnave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diasvivero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAutorizacionCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GrillaLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SPCONSULTAFULLVARIEDADIdFamiliaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPCONSULTAFULLFAMILIAPRODUCTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrillaLotes
        '
        Me.GrillaLotes.AllowUserToAddRows = False
        Me.GrillaLotes.AllowUserToDeleteRows = False
        Me.GrillaLotes.AllowUserToResizeRows = False
        Me.GrillaLotes.BackgroundColor = System.Drawing.Color.White
        Me.GrillaLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaLotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nlote, Me.cliente, Me.semilla, Me.variedad, Me.aportasemilla, Me.pedido, Me.fechaconteos, Me.tipo, Me.saldoplanta, Me.saldobandeja, Me.fechasiembra, Me.fechaentrega, Me.estadolote, Me.ubicacion, Me.numnave, Me.diasvivero, Me.FechaAutorizacionCliente})
        Me.GrillaLotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaLotes.Location = New System.Drawing.Point(0, 0)
        Me.GrillaLotes.Name = "GrillaLotes"
        Me.GrillaLotes.ReadOnly = True
        Me.GrillaLotes.RowHeadersVisible = False
        Me.GrillaLotes.Size = New System.Drawing.Size(1234, 632)
        Me.GrillaLotes.TabIndex = 0
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbVariedad)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbSemilla)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GrillaLotes)
        Me.SplitContainer1.Size = New System.Drawing.Size(1234, 679)
        Me.SplitContainer1.SplitterDistance = 43
        Me.SplitContainer1.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Image = Global.GestionVivero.My.Resources.Resources.eliminar_40x40
        Me.Button3.Location = New System.Drawing.Point(1191, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(39, 39)
        Me.Button3.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.Button3, "Limpiar Filtros")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button2.Location = New System.Drawing.Point(1150, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 39)
        Me.Button2.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.Button2, "Aplicar Filtros")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'cmbVariedad
        '
        Me.cmbVariedad.DataSource = Me.SPCONSULTAFULLVARIEDADIdFamiliaBindingSource
        Me.cmbVariedad.DisplayMember = "Descripcion"
        Me.cmbVariedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVariedad.FormattingEnabled = True
        Me.cmbVariedad.Location = New System.Drawing.Point(732, 12)
        Me.cmbVariedad.Name = "cmbVariedad"
        Me.cmbVariedad.Size = New System.Drawing.Size(374, 21)
        Me.cmbVariedad.TabIndex = 4
        Me.cmbVariedad.ValueMember = "IdVariedad"
        '
        'SPCONSULTAFULLVARIEDADIdFamiliaBindingSource
        '
        Me.SPCONSULTAFULLVARIEDADIdFamiliaBindingSource.DataMember = "SP_CONSULTA_FULL_VARIEDAD_IdFamilia"
        Me.SPCONSULTAFULLVARIEDADIdFamiliaBindingSource.DataSource = Me.GESTDataSet
        '
        'GESTDataSet
        '
        Me.GESTDataSet.DataSetName = "GESTDataSet"
        Me.GESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbSemilla
        '
        Me.cmbSemilla.DataSource = Me.SPCONSULTAFULLFAMILIAPRODUCTOBindingSource
        Me.cmbSemilla.DisplayMember = "DESCRIP"
        Me.cmbSemilla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSemilla.FormattingEnabled = True
        Me.cmbSemilla.Location = New System.Drawing.Point(281, 12)
        Me.cmbSemilla.Name = "cmbSemilla"
        Me.cmbSemilla.Size = New System.Drawing.Size(377, 21)
        Me.cmbSemilla.TabIndex = 3
        Me.cmbSemilla.ValueMember = "idFamilia"
        '
        'SPCONSULTAFULLFAMILIAPRODUCTOBindingSource
        '
        Me.SPCONSULTAFULLFAMILIAPRODUCTOBindingSource.DataMember = "SP_CONSULTA_FULL_FAMILIA_PRODUCTO"
        Me.SPCONSULTAFULLFAMILIAPRODUCTOBindingSource.DataSource = Me.GESTDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(682, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Variedad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(237, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Semilla"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LimeGreen
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(9, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(198, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Reporte Excel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'SP_CONSULTA_FULL_FAMILIA_PRODUCTOTableAdapter
        '
        Me.SP_CONSULTA_FULL_FAMILIA_PRODUCTOTableAdapter.ClearBeforeFill = True
        '
        'SP_CONSULTA_FULL_VARIEDAD_IdFamiliaTableAdapter
        '
        Me.SP_CONSULTA_FULL_VARIEDAD_IdFamiliaTableAdapter.ClearBeforeFill = True
        '
        'nlote
        '
        Me.nlote.HeaderText = "N° Lote"
        Me.nlote.Name = "nlote"
        Me.nlote.ReadOnly = True
        Me.nlote.Width = 50
        '
        'cliente
        '
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        Me.cliente.Width = 64
        '
        'semilla
        '
        Me.semilla.HeaderText = "Semilla"
        Me.semilla.Name = "semilla"
        Me.semilla.ReadOnly = True
        Me.semilla.Width = 65
        '
        'variedad
        '
        Me.variedad.HeaderText = "Variedad"
        Me.variedad.Name = "variedad"
        Me.variedad.ReadOnly = True
        Me.variedad.Width = 74
        '
        'aportasemilla
        '
        Me.aportasemilla.HeaderText = "Aporta Semilla"
        Me.aportasemilla.Name = "aportasemilla"
        Me.aportasemilla.ReadOnly = True
        Me.aportasemilla.Width = 91
        '
        'pedido
        '
        Me.pedido.HeaderText = "Pedido"
        Me.pedido.Name = "pedido"
        Me.pedido.ReadOnly = True
        Me.pedido.Width = 65
        '
        'fechaconteos
        '
        Me.fechaconteos.HeaderText = "Fec.Conteo Siembra"
        Me.fechaconteos.Name = "fechaconteos"
        Me.fechaconteos.ReadOnly = True
        Me.fechaconteos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fechaconteos.Width = 98
        '
        'tipo
        '
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        Me.tipo.Width = 53
        '
        'saldoplanta
        '
        Me.saldoplanta.HeaderText = "Saldo Planta"
        Me.saldoplanta.Name = "saldoplanta"
        Me.saldoplanta.ReadOnly = True
        Me.saldoplanta.Width = 85
        '
        'saldobandeja
        '
        Me.saldobandeja.HeaderText = "Saldo Bandeja"
        Me.saldobandeja.Name = "saldobandeja"
        Me.saldobandeja.ReadOnly = True
        Me.saldobandeja.Width = 93
        '
        'fechasiembra
        '
        Me.fechasiembra.HeaderText = "Fecha Siembra"
        Me.fechasiembra.Name = "fechasiembra"
        Me.fechasiembra.ReadOnly = True
        Me.fechasiembra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fechasiembra.Width = 76
        '
        'fechaentrega
        '
        Me.fechaentrega.HeaderText = "Fecha Entrega"
        Me.fechaentrega.Name = "fechaentrega"
        Me.fechaentrega.ReadOnly = True
        Me.fechaentrega.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fechaentrega.Width = 80
        '
        'estadolote
        '
        Me.estadolote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.estadolote.HeaderText = "Estado Lote"
        Me.estadolote.Name = "estadolote"
        Me.estadolote.ReadOnly = True
        Me.estadolote.Width = 82
        '
        'ubicacion
        '
        Me.ubicacion.HeaderText = "Ubicación"
        Me.ubicacion.Name = "ubicacion"
        Me.ubicacion.ReadOnly = True
        Me.ubicacion.Width = 80
        '
        'numnave
        '
        Me.numnave.HeaderText = "N° Nave"
        Me.numnave.Name = "numnave"
        Me.numnave.ReadOnly = True
        Me.numnave.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.numnave.Width = 49
        '
        'diasvivero
        '
        Me.diasvivero.HeaderText = "Días en Vivero"
        Me.diasvivero.Name = "diasvivero"
        Me.diasvivero.ReadOnly = True
        Me.diasvivero.Width = 95
        '
        'FechaAutorizacionCliente
        '
        Me.FechaAutorizacionCliente.DataPropertyName = "FechaAutorizacionCliente"
        Me.FechaAutorizacionCliente.HeaderText = "Fec.Autorización Cliente"
        Me.FechaAutorizacionCliente.Name = "FechaAutorizacionCliente"
        Me.FechaAutorizacionCliente.ReadOnly = True
        Me.FechaAutorizacionCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.FechaAutorizacionCliente.Width = 114
        '
        'ConsultaLotesPantalla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 679)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ConsultaLotesPantalla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Lotes"
        CType(Me.GrillaLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.SPCONSULTAFULLVARIEDADIdFamiliaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPCONSULTAFULLFAMILIAPRODUCTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrillaLotes As DataGridView
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbSemilla As ComboBox
    Friend WithEvents GESTDataSet As GESTDataSet
    Friend WithEvents SPCONSULTAFULLFAMILIAPRODUCTOBindingSource As BindingSource
    Friend WithEvents SP_CONSULTA_FULL_FAMILIA_PRODUCTOTableAdapter As GESTDataSetTableAdapters.SP_CONSULTA_FULL_FAMILIA_PRODUCTOTableAdapter
    Friend WithEvents Button3 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button2 As Button
    Friend WithEvents cmbVariedad As ComboBox
    Friend WithEvents SPCONSULTAFULLVARIEDADIdFamiliaBindingSource As BindingSource
    Friend WithEvents SP_CONSULTA_FULL_VARIEDAD_IdFamiliaTableAdapter As GESTDataSetTableAdapters.SP_CONSULTA_FULL_VARIEDAD_IdFamiliaTableAdapter
    Friend WithEvents nlote As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents semilla As DataGridViewTextBoxColumn
    Friend WithEvents variedad As DataGridViewTextBoxColumn
    Friend WithEvents aportasemilla As DataGridViewTextBoxColumn
    Friend WithEvents pedido As DataGridViewTextBoxColumn
    Friend WithEvents fechaconteos As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents saldoplanta As DataGridViewTextBoxColumn
    Friend WithEvents saldobandeja As DataGridViewTextBoxColumn
    Friend WithEvents fechasiembra As DataGridViewTextBoxColumn
    Friend WithEvents fechaentrega As DataGridViewTextBoxColumn
    Friend WithEvents estadolote As DataGridViewTextBoxColumn
    Friend WithEvents ubicacion As DataGridViewTextBoxColumn
    Friend WithEvents numnave As DataGridViewTextBoxColumn
    Friend WithEvents diasvivero As DataGridViewTextBoxColumn
    Friend WithEvents FechaAutorizacionCliente As DataGridViewTextBoxColumn
End Class
