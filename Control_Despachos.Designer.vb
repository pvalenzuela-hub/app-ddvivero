<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Control_Despachos
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Control_Despachos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtp_fecha1 = New System.Windows.Forms.DateTimePicker
        Me.dtp_fecha2 = New System.Windows.Forms.DateTimePicker
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmb_Zona = New System.Windows.Forms.ComboBox
        Me.cmb_Sector = New System.Windows.Forms.ComboBox
        Me.DataGrilla = New System.Windows.Forms.DataGridView
        Me.txt_TotalBandejas = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.btn_Confirmar = New System.Windows.Forms.Button
        Me.cmb_Estado = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.numguia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Semilla = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Insumo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.punit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cant = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Variedad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fono = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Glosa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id_semilla = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ubic = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Selec = New System.Windows.Forms.DataGridViewCheckBoxColumn
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Zona"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sector"
        '
        'dtp_fecha1
        '
        Me.dtp_fecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha1.Location = New System.Drawing.Point(459, 23)
        Me.dtp_fecha1.Name = "dtp_fecha1"
        Me.dtp_fecha1.Size = New System.Drawing.Size(95, 20)
        Me.dtp_fecha1.TabIndex = 2
        '
        'dtp_fecha2
        '
        Me.dtp_fecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha2.Location = New System.Drawing.Point(459, 58)
        Me.dtp_fecha2.Name = "dtp_fecha2"
        Me.dtp_fecha2.Size = New System.Drawing.Size(95, 20)
        Me.dtp_fecha2.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(725, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 38)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Consulta Lotes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmb_Zona
        '
        Me.cmb_Zona.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_Zona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Zona.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Zona.ForeColor = System.Drawing.Color.White
        Me.cmb_Zona.FormattingEnabled = True
        Me.cmb_Zona.Location = New System.Drawing.Point(71, 19)
        Me.cmb_Zona.Name = "cmb_Zona"
        Me.cmb_Zona.Size = New System.Drawing.Size(262, 23)
        Me.cmb_Zona.TabIndex = 29
        '
        'cmb_Sector
        '
        Me.cmb_Sector.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_Sector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Sector.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Sector.ForeColor = System.Drawing.Color.White
        Me.cmb_Sector.FormattingEnabled = True
        Me.cmb_Sector.Location = New System.Drawing.Point(71, 54)
        Me.cmb_Sector.Name = "cmb_Sector"
        Me.cmb_Sector.Size = New System.Drawing.Size(262, 23)
        Me.cmb_Sector.TabIndex = 30
        '
        'DataGrilla
        '
        Me.DataGrilla.AllowUserToAddRows = False
        Me.DataGrilla.AllowUserToDeleteRows = False
        Me.DataGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGrilla.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numguia, Me.Semilla, Me.Insumo, Me.punit, Me.Cant, Me.Variedad, Me.Total, Me.Fono, Me.Glosa, Me.id_semilla, Me.ubic, Me.Selec})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrilla.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGrilla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.DataGrilla.Location = New System.Drawing.Point(0, 95)
        Me.DataGrilla.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGrilla.Name = "DataGrilla"
        Me.DataGrilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataGrilla.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGrilla.Size = New System.Drawing.Size(829, 379)
        Me.DataGrilla.TabIndex = 31
        '
        'txt_TotalBandejas
        '
        Me.txt_TotalBandejas.Location = New System.Drawing.Point(683, 488)
        Me.txt_TotalBandejas.Name = "txt_TotalBandejas"
        Me.txt_TotalBandejas.ReadOnly = True
        Me.txt_TotalBandejas.Size = New System.Drawing.Size(100, 20)
        Me.txt_TotalBandejas.TabIndex = 32
        Me.txt_TotalBandejas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(598, 491)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Total Bandejas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(372, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Rango Fechas"
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(336, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 23)
        Me.Button2.TabIndex = 35
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(336, 54)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(27, 23)
        Me.Button3.TabIndex = 36
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btn_Confirmar
        '
        Me.btn_Confirmar.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.btn_Confirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Confirmar.Location = New System.Drawing.Point(146, 480)
        Me.btn_Confirmar.Name = "btn_Confirmar"
        Me.btn_Confirmar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Confirmar.TabIndex = 37
        Me.btn_Confirmar.Text = "Confirmar Despacho"
        Me.btn_Confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Confirmar.UseVisualStyleBackColor = True
        '
        'cmb_Estado
        '
        Me.cmb_Estado.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Estado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Estado.ForeColor = System.Drawing.Color.White
        Me.cmb_Estado.FormattingEnabled = True
        Me.cmb_Estado.Items.AddRange(New Object() {"Lotes Pendientes", "Lotes Avisados"})
        Me.cmb_Estado.Location = New System.Drawing.Point(577, 40)
        Me.cmb_Estado.Name = "cmb_Estado"
        Me.cmb_Estado.Size = New System.Drawing.Size(125, 23)
        Me.cmb_Estado.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(578, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Estado Lotes"
        '
        'numguia
        '
        Me.numguia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.numguia.Frozen = True
        Me.numguia.HeaderText = "Zona"
        Me.numguia.Name = "numguia"
        Me.numguia.ReadOnly = True
        Me.numguia.Width = 57
        '
        'Semilla
        '
        Me.Semilla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Semilla.Frozen = True
        Me.Semilla.HeaderText = "Sector"
        Me.Semilla.Name = "Semilla"
        Me.Semilla.ReadOnly = True
        Me.Semilla.Width = 63
        '
        'Insumo
        '
        Me.Insumo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Insumo.Frozen = True
        Me.Insumo.HeaderText = "N° Lote"
        Me.Insumo.Name = "Insumo"
        Me.Insumo.ReadOnly = True
        Me.Insumo.Width = 68
        '
        'punit
        '
        Me.punit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.punit.HeaderText = "Especie"
        Me.punit.Name = "punit"
        Me.punit.ReadOnly = True
        Me.punit.Width = 70
        '
        'Cant
        '
        Me.Cant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Cant.HeaderText = "Variedad"
        Me.Cant.Name = "Cant"
        Me.Cant.ReadOnly = True
        Me.Cant.Width = 74
        '
        'Variedad
        '
        Me.Variedad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Variedad.HeaderText = "Fecha Entrega"
        Me.Variedad.Name = "Variedad"
        Me.Variedad.ReadOnly = True
        Me.Variedad.Width = 102
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Total.HeaderText = "Cliente"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 64
        '
        'Fono
        '
        Me.Fono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Fono.HeaderText = "Fono"
        Me.Fono.Name = "Fono"
        Me.Fono.Width = 56
        '
        'Glosa
        '
        Me.Glosa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Glosa.DefaultCellStyle = DataGridViewCellStyle1
        Me.Glosa.HeaderText = "Plantas"
        Me.Glosa.Name = "Glosa"
        Me.Glosa.ReadOnly = True
        Me.Glosa.Width = 67
        '
        'id_semilla
        '
        Me.id_semilla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.id_semilla.DefaultCellStyle = DataGridViewCellStyle2
        Me.id_semilla.FillWeight = 50.0!
        Me.id_semilla.HeaderText = "Bandejas"
        Me.id_semilla.Name = "id_semilla"
        Me.id_semilla.ReadOnly = True
        Me.id_semilla.Width = 76
        '
        'ubic
        '
        Me.ubic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ubic.HeaderText = "Ubicación"
        Me.ubic.Name = "ubic"
        Me.ubic.ReadOnly = True
        Me.ubic.Width = 80
        '
        'Selec
        '
        Me.Selec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Selec.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Selec.HeaderText = "Selec."
        Me.Selec.Name = "Selec"
        Me.Selec.ToolTipText = "Marcar para seleccionar Lote"
        Me.Selec.Width = 43
        '
        'Control_Despachos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 512)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_Estado)
        Me.Controls.Add(Me.btn_Confirmar)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_TotalBandejas)
        Me.Controls.Add(Me.DataGrilla)
        Me.Controls.Add(Me.cmb_Sector)
        Me.Controls.Add(Me.cmb_Zona)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtp_fecha2)
        Me.Controls.Add(Me.dtp_fecha1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Control_Despachos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control Despachos"
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmb_Zona As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Sector As System.Windows.Forms.ComboBox
    Friend WithEvents DataGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents txt_TotalBandejas As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btn_Confirmar As System.Windows.Forms.Button
    Friend WithEvents cmb_Estado As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents numguia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Semilla As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Insumo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents punit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Variedad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Glosa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_semilla As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ubic As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Selec As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
