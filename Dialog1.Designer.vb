<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog1
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDespDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDespDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomChofDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KminicialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KmfinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorainiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorafinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaActualizacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DespHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GESTDataSet32 = New GestionVivero.GESTDataSet32()
        Me.DespHTableAdapter = New GestionVivero.GESTDataSet32TableAdapters.DespHTableAdapter()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DespHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTDataSet32, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(353, 274)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(508, 268)
        Me.Panel1.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDespDataGridViewTextBoxColumn, Me.FechaDespDataGridViewTextBoxColumn, Me.NomChofDataGridViewTextBoxColumn, Me.PatenteDataGridViewTextBoxColumn, Me.KminicialDataGridViewTextBoxColumn, Me.KmfinalDataGridViewTextBoxColumn, Me.HorainiDataGridViewTextBoxColumn, Me.HorafinDataGridViewTextBoxColumn, Me.FechaActualizacionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DespHBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(508, 268)
        Me.DataGridView1.TabIndex = 0
        '
        'IdDespDataGridViewTextBoxColumn
        '
        Me.IdDespDataGridViewTextBoxColumn.DataPropertyName = "idDesp"
        Me.IdDespDataGridViewTextBoxColumn.HeaderText = "Nº Despacho"
        Me.IdDespDataGridViewTextBoxColumn.Name = "IdDespDataGridViewTextBoxColumn"
        Me.IdDespDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDespDataGridViewTextBoxColumn
        '
        Me.FechaDespDataGridViewTextBoxColumn.DataPropertyName = "FechaDesp"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FechaDespDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.FechaDespDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDespDataGridViewTextBoxColumn.Name = "FechaDespDataGridViewTextBoxColumn"
        Me.FechaDespDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomChofDataGridViewTextBoxColumn
        '
        Me.NomChofDataGridViewTextBoxColumn.DataPropertyName = "NomChof"
        Me.NomChofDataGridViewTextBoxColumn.HeaderText = "Chofer"
        Me.NomChofDataGridViewTextBoxColumn.Name = "NomChofDataGridViewTextBoxColumn"
        Me.NomChofDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PatenteDataGridViewTextBoxColumn
        '
        Me.PatenteDataGridViewTextBoxColumn.DataPropertyName = "Patente"
        Me.PatenteDataGridViewTextBoxColumn.HeaderText = "Patente"
        Me.PatenteDataGridViewTextBoxColumn.Name = "PatenteDataGridViewTextBoxColumn"
        Me.PatenteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KminicialDataGridViewTextBoxColumn
        '
        Me.KminicialDataGridViewTextBoxColumn.DataPropertyName = "kminicial"
        Me.KminicialDataGridViewTextBoxColumn.HeaderText = "Km Inicial"
        Me.KminicialDataGridViewTextBoxColumn.Name = "KminicialDataGridViewTextBoxColumn"
        Me.KminicialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KmfinalDataGridViewTextBoxColumn
        '
        Me.KmfinalDataGridViewTextBoxColumn.DataPropertyName = "kmfinal"
        Me.KmfinalDataGridViewTextBoxColumn.HeaderText = "Km Final"
        Me.KmfinalDataGridViewTextBoxColumn.Name = "KmfinalDataGridViewTextBoxColumn"
        Me.KmfinalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HorainiDataGridViewTextBoxColumn
        '
        Me.HorainiDataGridViewTextBoxColumn.DataPropertyName = "horaini"
        Me.HorainiDataGridViewTextBoxColumn.HeaderText = "Hora Salida"
        Me.HorainiDataGridViewTextBoxColumn.Name = "HorainiDataGridViewTextBoxColumn"
        Me.HorainiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HorafinDataGridViewTextBoxColumn
        '
        Me.HorafinDataGridViewTextBoxColumn.DataPropertyName = "horafin"
        Me.HorafinDataGridViewTextBoxColumn.HeaderText = "Hora Llegada"
        Me.HorafinDataGridViewTextBoxColumn.Name = "HorafinDataGridViewTextBoxColumn"
        Me.HorafinDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaActualizacionDataGridViewTextBoxColumn
        '
        Me.FechaActualizacionDataGridViewTextBoxColumn.DataPropertyName = "FechaActualizacion"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.FechaActualizacionDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.FechaActualizacionDataGridViewTextBoxColumn.HeaderText = "Actualizacion"
        Me.FechaActualizacionDataGridViewTextBoxColumn.Name = "FechaActualizacionDataGridViewTextBoxColumn"
        Me.FechaActualizacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DespHBindingSource
        '
        Me.DespHBindingSource.DataMember = "DespH"
        Me.DespHBindingSource.DataSource = Me.GESTDataSet32
        '
        'GESTDataSet32
        '
        Me.GESTDataSet32.DataSetName = "GESTDataSet32"
        Me.GESTDataSet32.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DespHTableAdapter
        '
        Me.DespHTableAdapter.ClearBeforeFill = True
        '
        'Dialog1
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(511, 315)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Despachos"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DespHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTDataSet32, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GESTDataSet32 As GestionVivero.GESTDataSet32
    Friend WithEvents DespHBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DespHTableAdapter As GestionVivero.GESTDataSet32TableAdapters.DespHTableAdapter
    Friend WithEvents IdDespDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDespDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomChofDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatenteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KminicialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KmfinalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HorainiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HorafinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaActualizacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
