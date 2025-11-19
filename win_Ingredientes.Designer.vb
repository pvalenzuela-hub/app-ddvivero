<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class win_Ingredientes
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_PrecioCompra = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGrilla = New System.Windows.Forms.DataGridView()
        Me.cmb_UNCompra = New System.Windows.Forms.ComboBox()
        Me.cmb_UNMedida = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_CantMedida = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_UN_COSTO = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_CodIngrediente = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmb_InsumosDirectos = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_IdInsumo = New System.Windows.Forms.MaskedTextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.IdIngrediente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idInsumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uncompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pcompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantmedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FultCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_NumUsos = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(436, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 14)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Unidad de Compra"
        '
        'Button1
        '
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(430, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 31)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Actualizar Material"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_PrecioCompra
        '
        Me.txt_PrecioCompra.HidePromptOnLeave = True
        Me.txt_PrecioCompra.Location = New System.Drawing.Point(536, 49)
        Me.txt_PrecioCompra.Name = "txt_PrecioCompra"
        Me.txt_PrecioCompra.Size = New System.Drawing.Size(82, 20)
        Me.txt_PrecioCompra.TabIndex = 55
        Me.txt_PrecioCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(161, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 14)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Descripción"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(540, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 14)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Precio Compra"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(329, 412)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 24)
        Me.Button3.TabIndex = 61
        Me.Button3.Text = "Modificar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(583, 412)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(105, 24)
        Me.Button4.TabIndex = 62
        Me.Button4.Text = "Eliminar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGrilla
        '
        Me.DataGrilla.AllowUserToAddRows = False
        Me.DataGrilla.AllowUserToDeleteRows = False
        Me.DataGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdIngrediente, Me.idInsumo, Me.Item, Me.uncompra, Me.pcompra, Me.UnMedida, Me.cantmedida, Me.unCosto, Me.pCosto, Me.stock, Me.FultCompra, Me.usos})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrilla.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGrilla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGrilla.Location = New System.Drawing.Point(1, 109)
        Me.DataGrilla.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGrilla.Name = "DataGrilla"
        Me.DataGrilla.ReadOnly = True
        Me.DataGrilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataGrilla.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGrilla.Size = New System.Drawing.Size(983, 301)
        Me.DataGrilla.TabIndex = 63
        '
        'cmb_UNCompra
        '
        Me.cmb_UNCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_UNCompra.FormattingEnabled = True
        Me.cmb_UNCompra.Location = New System.Drawing.Point(441, 49)
        Me.cmb_UNCompra.Name = "cmb_UNCompra"
        Me.cmb_UNCompra.Size = New System.Drawing.Size(84, 21)
        Me.cmb_UNCompra.TabIndex = 66
        '
        'cmb_UNMedida
        '
        Me.cmb_UNMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_UNMedida.FormattingEnabled = True
        Me.cmb_UNMedida.Location = New System.Drawing.Point(628, 49)
        Me.cmb_UNMedida.Name = "cmb_UNMedida"
        Me.cmb_UNMedida.Size = New System.Drawing.Size(84, 21)
        Me.cmb_UNMedida.TabIndex = 67
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(623, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 14)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Unidad de Medida"
        '
        'txt_CantMedida
        '
        Me.txt_CantMedida.HidePromptOnLeave = True
        Me.txt_CantMedida.Location = New System.Drawing.Point(721, 49)
        Me.txt_CantMedida.Name = "txt_CantMedida"
        Me.txt_CantMedida.Size = New System.Drawing.Size(82, 20)
        Me.txt_CantMedida.TabIndex = 69
        Me.txt_CantMedida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(724, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 14)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Cant.Compra"
        '
        'cmb_UN_COSTO
        '
        Me.cmb_UN_COSTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_UN_COSTO.FormattingEnabled = True
        Me.cmb_UN_COSTO.Location = New System.Drawing.Point(813, 49)
        Me.cmb_UN_COSTO.Name = "cmb_UN_COSTO"
        Me.cmb_UN_COSTO.Size = New System.Drawing.Size(84, 21)
        Me.cmb_UN_COSTO.TabIndex = 71
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(809, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 14)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Unidad de Costo"
        '
        'txt_CodIngrediente
        '
        Me.txt_CodIngrediente.HidePromptOnLeave = True
        Me.txt_CodIngrediente.Location = New System.Drawing.Point(5, 49)
        Me.txt_CodIngrediente.Name = "txt_CodIngrediente"
        Me.txt_CodIngrediente.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_CodIngrediente.Size = New System.Drawing.Size(46, 20)
        Me.txt_CodIngrediente.TabIndex = 74
        Me.txt_CodIngrediente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 14)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Cód. Item"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(837, 412)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 24)
        Me.Button2.TabIndex = 77
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmb_InsumosDirectos
        '
        Me.cmb_InsumosDirectos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_InsumosDirectos.FormattingEnabled = True
        Me.cmb_InsumosDirectos.Location = New System.Drawing.Point(140, 49)
        Me.cmb_InsumosDirectos.Name = "cmb_InsumosDirectos"
        Me.cmb_InsumosDirectos.Size = New System.Drawing.Size(291, 21)
        Me.cmb_InsumosDirectos.TabIndex = 78
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(69, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 14)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Cód. Insumo"
        '
        'txt_IdInsumo
        '
        Me.txt_IdInsumo.HidePromptOnLeave = True
        Me.txt_IdInsumo.Location = New System.Drawing.Point(61, 49)
        Me.txt_IdInsumo.Name = "txt_IdInsumo"
        Me.txt_IdInsumo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_IdInsumo.Size = New System.Drawing.Size(72, 20)
        Me.txt_IdInsumo.TabIndex = 81
        Me.txt_IdInsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(75, 412)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(105, 24)
        Me.Button5.TabIndex = 82
        Me.Button5.Text = "Nuevo Item"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'IdIngrediente
        '
        Me.IdIngrediente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IdIngrediente.HeaderText = "Cód. Item"
        Me.IdIngrediente.Name = "IdIngrediente"
        Me.IdIngrediente.ReadOnly = True
        Me.IdIngrediente.Width = 77
        '
        'idInsumo
        '
        Me.idInsumo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.idInsumo.HeaderText = "Cód. Insumo"
        Me.idInsumo.Name = "idInsumo"
        Me.idInsumo.ReadOnly = True
        Me.idInsumo.Width = 91
        '
        'Item
        '
        Me.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Item.HeaderText = "Descripción"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.Width = 88
        '
        'uncompra
        '
        Me.uncompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.uncompra.HeaderText = "Un.Compra"
        Me.uncompra.Name = "uncompra"
        Me.uncompra.ReadOnly = True
        Me.uncompra.Width = 85
        '
        'pcompra
        '
        Me.pcompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.pcompra.DefaultCellStyle = DataGridViewCellStyle1
        Me.pcompra.HeaderText = "P.Compra"
        Me.pcompra.Name = "pcompra"
        Me.pcompra.ReadOnly = True
        Me.pcompra.Width = 78
        '
        'UnMedida
        '
        Me.UnMedida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UnMedida.HeaderText = "Un.Medida"
        Me.UnMedida.Name = "UnMedida"
        Me.UnMedida.ReadOnly = True
        Me.UnMedida.Width = 84
        '
        'cantmedida
        '
        Me.cantmedida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cantmedida.DefaultCellStyle = DataGridViewCellStyle2
        Me.cantmedida.HeaderText = "Cantidad"
        Me.cantmedida.Name = "cantmedida"
        Me.cantmedida.ReadOnly = True
        Me.cantmedida.Width = 74
        '
        'unCosto
        '
        Me.unCosto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.unCosto.HeaderText = "Un.Costo"
        Me.unCosto.Name = "unCosto"
        Me.unCosto.ReadOnly = True
        Me.unCosto.Width = 76
        '
        'pCosto
        '
        Me.pCosto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.pCosto.DefaultCellStyle = DataGridViewCellStyle3
        Me.pCosto.HeaderText = "Precio Costo"
        Me.pCosto.Name = "pCosto"
        Me.pCosto.ReadOnly = True
        Me.pCosto.Width = 92
        '
        'stock
        '
        Me.stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.stock.DefaultCellStyle = DataGridViewCellStyle4
        Me.stock.HeaderText = "Stock"
        Me.stock.Name = "stock"
        Me.stock.ReadOnly = True
        Me.stock.Width = 60
        '
        'FultCompra
        '
        Me.FultCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FultCompra.HeaderText = "Fecha Ult.Compra"
        Me.FultCompra.Name = "FultCompra"
        Me.FultCompra.ReadOnly = True
        Me.FultCompra.Width = 117
        '
        'usos
        '
        Me.usos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.usos.HeaderText = "Nº Usos"
        Me.usos.Name = "usos"
        Me.usos.ReadOnly = True
        Me.usos.Width = 71
        '
        'txt_NumUsos
        '
        Me.txt_NumUsos.HidePromptOnLeave = True
        Me.txt_NumUsos.Location = New System.Drawing.Point(906, 49)
        Me.txt_NumUsos.Name = "txt_NumUsos"
        Me.txt_NumUsos.Size = New System.Drawing.Size(68, 20)
        Me.txt_NumUsos.TabIndex = 83
        Me.txt_NumUsos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(915, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 14)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "Nº Usos"
        '
        'win_Ingredientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 437)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_NumUsos)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txt_IdInsumo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmb_InsumosDirectos)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_CodIngrediente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmb_UN_COSTO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_CantMedida)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_UNMedida)
        Me.Controls.Add(Me.cmb_UNCompra)
        Me.Controls.Add(Me.DataGrilla)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_PrecioCompra)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "win_Ingredientes"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantención Tabla Material Directo"
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_PrecioCompra As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DataGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_UNCompra As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_UNMedida As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_CantMedida As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_UN_COSTO As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_CodIngrediente As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmb_InsumosDirectos As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_IdInsumo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents IdIngrediente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idInsumo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents uncompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pcompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnMedida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantmedida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FultCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents usos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_NumUsos As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
