<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HojaTrabajo
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
        Me.DataGrilla = New System.Windows.Forms.DataGridView()
        Me.numlin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trabaj = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.naves = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bandejas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora_ini = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora_ter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_Personal = New System.Windows.Forms.ComboBox()
        Me.cmb_Actividad = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_Nave = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_HoraInicio = New System.Windows.Forms.MaskedTextBox()
        Me.txt_HoraTermino = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_NumBand = New System.Windows.Forms.MaskedTextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GrillaLote = New System.Windows.Forms.DataGridView()
        Me.lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrillaNave = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_NumLinea = New System.Windows.Forms.MaskedTextBox()
        Me.rdb_Lotes = New System.Windows.Forms.RadioButton()
        Me.rdb_Naves = New System.Windows.Forms.RadioButton()
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaLote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaNave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrilla
        '
        Me.DataGrilla.AllowUserToAddRows = False
        Me.DataGrilla.AllowUserToDeleteRows = False
        Me.DataGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGrilla.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numlin, Me.fecha, Me.trabaj, Me.Activ, Me.lotes, Me.naves, Me.Bandejas, Me.hora_ini, Me.hora_ter})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrilla.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrilla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGrilla.Location = New System.Drawing.Point(1, 200)
        Me.DataGrilla.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGrilla.Name = "DataGrilla"
        Me.DataGrilla.ReadOnly = True
        Me.DataGrilla.RowHeadersVisible = False
        Me.DataGrilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataGrilla.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGrilla.Size = New System.Drawing.Size(982, 371)
        Me.DataGrilla.TabIndex = 27
        '
        'numlin
        '
        Me.numlin.HeaderText = "Nº Línea"
        Me.numlin.Name = "numlin"
        Me.numlin.ReadOnly = True
        Me.numlin.Width = 75
        '
        'fecha
        '
        Me.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.fecha.FillWeight = 40.0!
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 62
        '
        'trabaj
        '
        Me.trabaj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.trabaj.FillWeight = 50.0!
        Me.trabaj.HeaderText = "Trabajador"
        Me.trabaj.Name = "trabaj"
        Me.trabaj.ReadOnly = True
        '
        'Activ
        '
        Me.Activ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Activ.FillWeight = 50.0!
        Me.Activ.HeaderText = "Actividad"
        Me.Activ.Name = "Activ"
        Me.Activ.ReadOnly = True
        '
        'lotes
        '
        Me.lotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.lotes.FillWeight = 80.0!
        Me.lotes.HeaderText = "Nº Lotes"
        Me.lotes.Name = "lotes"
        Me.lotes.ReadOnly = True
        Me.lotes.Width = 73
        '
        'naves
        '
        Me.naves.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.naves.FillWeight = 80.0!
        Me.naves.HeaderText = "Nº Naves"
        Me.naves.Name = "naves"
        Me.naves.ReadOnly = True
        Me.naves.Width = 78
        '
        'Bandejas
        '
        Me.Bandejas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Bandejas.FillWeight = 60.0!
        Me.Bandejas.HeaderText = "Nº Bandejas"
        Me.Bandejas.Name = "Bandejas"
        Me.Bandejas.ReadOnly = True
        Me.Bandejas.Width = 91
        '
        'hora_ini
        '
        Me.hora_ini.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.hora_ini.FillWeight = 60.0!
        Me.hora_ini.HeaderText = "H.Inicio"
        Me.hora_ini.Name = "hora_ini"
        Me.hora_ini.ReadOnly = True
        Me.hora_ini.Width = 68
        '
        'hora_ter
        '
        Me.hora_ter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.hora_ter.FillWeight = 60.0!
        Me.hora_ter.HeaderText = "Hora Término"
        Me.hora_ter.Name = "hora_ter"
        Me.hora_ter.ReadOnly = True
        Me.hora_ter.Width = 96
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(438, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(199, 20)
        Me.DateTimePicker1.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(331, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Actividades del día:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Trabajador"
        '
        'cmb_Personal
        '
        Me.cmb_Personal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Personal.FormattingEnabled = True
        Me.cmb_Personal.Location = New System.Drawing.Point(79, 81)
        Me.cmb_Personal.Name = "cmb_Personal"
        Me.cmb_Personal.Size = New System.Drawing.Size(340, 21)
        Me.cmb_Personal.TabIndex = 0
        '
        'cmb_Actividad
        '
        Me.cmb_Actividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Actividad.FormattingEnabled = True
        Me.cmb_Actividad.Location = New System.Drawing.Point(79, 108)
        Me.cmb_Actividad.Name = "cmb_Actividad"
        Me.cmb_Actividad.Size = New System.Drawing.Size(340, 21)
        Me.cmb_Actividad.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Actividad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(827, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Nº Bandejas"
        '
        'cmb_Nave
        '
        Me.cmb_Nave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Nave.Enabled = False
        Me.cmb_Nave.FormattingEnabled = True
        Me.cmb_Nave.Location = New System.Drawing.Point(714, 42)
        Me.cmb_Nave.Name = "cmb_Nave"
        Me.cmb_Nave.Size = New System.Drawing.Size(81, 21)
        Me.cmb_Nave.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(835, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Hora Inicio"
        '
        'txt_HoraInicio
        '
        Me.txt_HoraInicio.Location = New System.Drawing.Point(899, 91)
        Me.txt_HoraInicio.Mask = "99:99"
        Me.txt_HoraInicio.Name = "txt_HoraInicio"
        Me.txt_HoraInicio.Size = New System.Drawing.Size(47, 20)
        Me.txt_HoraInicio.TabIndex = 10
        '
        'txt_HoraTermino
        '
        Me.txt_HoraTermino.Location = New System.Drawing.Point(899, 122)
        Me.txt_HoraTermino.Mask = "99:99"
        Me.txt_HoraTermino.Name = "txt_HoraTermino"
        Me.txt_HoraTermino.Size = New System.Drawing.Size(47, 20)
        Me.txt_HoraTermino.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(822, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Hora Término"
        '
        'txt_NumBand
        '
        Me.txt_NumBand.Culture = New System.Globalization.CultureInfo("es-CL")
        Me.txt_NumBand.Location = New System.Drawing.Point(899, 60)
        Me.txt_NumBand.Mask = "999999999999"
        Me.txt_NumBand.Name = "txt_NumBand"
        Me.txt_NumBand.Size = New System.Drawing.Size(81, 20)
        Me.txt_NumBand.TabIndex = 56
        Me.txt_NumBand.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(18, 580)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(158, 32)
        Me.Button8.TabIndex = 57
        Me.Button8.Text = "Consulta Detalle de Registros"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'GrillaLote
        '
        Me.GrillaLote.AllowUserToOrderColumns = True
        Me.GrillaLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaLote.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.lote})
        Me.GrillaLote.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.GrillaLote.Enabled = False
        Me.GrillaLote.Location = New System.Drawing.Point(518, 60)
        Me.GrillaLote.Name = "GrillaLote"
        Me.GrillaLote.RowHeadersVisible = False
        Me.GrillaLote.Size = New System.Drawing.Size(97, 136)
        Me.GrillaLote.TabIndex = 59
        '
        'lote
        '
        Me.lote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.NullValue = Nothing
        Me.lote.DefaultCellStyle = DataGridViewCellStyle3
        Me.lote.HeaderText = "Nº Lote"
        Me.lote.MaxInputLength = 7
        Me.lote.Name = "lote"
        '
        'GrillaNave
        '
        Me.GrillaNave.AllowUserToAddRows = False
        Me.GrillaNave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaNave.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.GrillaNave.Enabled = False
        Me.GrillaNave.Location = New System.Drawing.Point(714, 60)
        Me.GrillaNave.Name = "GrillaNave"
        Me.GrillaNave.ReadOnly = True
        Me.GrillaNave.RowHeadersVisible = False
        Me.GrillaNave.Size = New System.Drawing.Size(81, 136)
        Me.GrillaNave.TabIndex = 61
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nº Nave"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.New_document
        Me.Button1.Location = New System.Drawing.Point(27, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 35)
        Me.Button1.TabIndex = 63
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Image = Global.GestionVivero.My.Resources.Resources.Notes
        Me.Button9.Location = New System.Drawing.Point(199, 156)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(52, 35)
        Me.Button9.TabIndex = 58
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(410, 580)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(182, 37)
        Me.Button7.TabIndex = 53
        Me.Button7.Text = "Actualizar Registros"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button6.Location = New System.Drawing.Point(83, 155)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(52, 35)
        Me.Button6.TabIndex = 12
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = Global.GestionVivero.My.Resources.Resources.Delete
        Me.Button5.Location = New System.Drawing.Point(141, 156)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(52, 35)
        Me.Button5.TabIndex = 13
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Nº Línea"
        '
        'txt_NumLinea
        '
        Me.txt_NumLinea.Culture = New System.Globalization.CultureInfo("es-CL")
        Me.txt_NumLinea.Location = New System.Drawing.Point(79, 55)
        Me.txt_NumLinea.Name = "txt_NumLinea"
        Me.txt_NumLinea.ReadOnly = True
        Me.txt_NumLinea.Size = New System.Drawing.Size(81, 20)
        Me.txt_NumLinea.TabIndex = 65
        Me.txt_NumLinea.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'rdb_Lotes
        '
        Me.rdb_Lotes.AutoSize = True
        Me.rdb_Lotes.Checked = True
        Me.rdb_Lotes.Location = New System.Drawing.Point(463, 122)
        Me.rdb_Lotes.Name = "rdb_Lotes"
        Me.rdb_Lotes.Size = New System.Drawing.Size(51, 17)
        Me.rdb_Lotes.TabIndex = 66
        Me.rdb_Lotes.TabStop = True
        Me.rdb_Lotes.Text = "Lotes"
        Me.rdb_Lotes.UseVisualStyleBackColor = True
        '
        'rdb_Naves
        '
        Me.rdb_Naves.AutoSize = True
        Me.rdb_Naves.Location = New System.Drawing.Point(653, 123)
        Me.rdb_Naves.Name = "rdb_Naves"
        Me.rdb_Naves.Size = New System.Drawing.Size(56, 17)
        Me.rdb_Naves.TabIndex = 67
        Me.rdb_Naves.Text = "Naves"
        Me.rdb_Naves.UseVisualStyleBackColor = True
        '
        'HojaTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 624)
        Me.Controls.Add(Me.rdb_Naves)
        Me.Controls.Add(Me.rdb_Lotes)
        Me.Controls.Add(Me.txt_NumLinea)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GrillaNave)
        Me.Controls.Add(Me.GrillaLote)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.txt_NumBand)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txt_HoraTermino)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_HoraInicio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmb_Nave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_Actividad)
        Me.Controls.Add(Me.cmb_Personal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DataGrilla)
        Me.Name = "HojaTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planilla de Trabajo"
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaLote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaNave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_Personal As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Actividad As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_Nave As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_HoraInicio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_HoraTermino As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents txt_NumBand As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents GrillaLote As System.Windows.Forms.DataGridView
    Friend WithEvents GrillaNave As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numlin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trabaj As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Activ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lotes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents naves As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bandejas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hora_ini As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hora_ter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_NumLinea As System.Windows.Forms.MaskedTextBox
    Friend WithEvents rdb_Lotes As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Naves As System.Windows.Forms.RadioButton
End Class
