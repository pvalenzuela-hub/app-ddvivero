<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Actividades_Pendientes
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGrilla = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.evento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comentarios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actividades = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Insumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaMand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nlote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_IDVENDEDOR = New System.Windows.Forms.ComboBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.cmb_NuevoEstado = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_IdBitacora = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_FechaEvento = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_Unidad = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Cantidad = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_fechaRegistro = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txt_respuesta = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_Estado = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.dtp_HoraEvento = New System.Windows.Forms.MaskedTextBox()
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGrilla
        '
        Me.DataGrilla.AllowUserToAddRows = False
        Me.DataGrilla.AllowUserToDeleteRows = False
        Me.DataGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.evento, Me.Comentarios, Me.actividades, Me.Insumo, Me.Fecha, Me.FechaMand, Me.nlote, Me.Usuario})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrilla.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGrilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrilla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGrilla.Location = New System.Drawing.Point(3, 16)
        Me.DataGrilla.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.DataGrilla.Name = "DataGrilla"
        Me.DataGrilla.ReadOnly = True
        Me.DataGrilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataGrilla.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGrilla.Size = New System.Drawing.Size(1061, 173)
        Me.DataGrilla.TabIndex = 66
        '
        'Id
        '
        Me.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 41
        '
        'evento
        '
        Me.evento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.evento.HeaderText = "Evento"
        Me.evento.Name = "evento"
        Me.evento.ReadOnly = True
        Me.evento.Width = 66
        '
        'Comentarios
        '
        Me.Comentarios.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Comentarios.FillWeight = 200.0!
        Me.Comentarios.HeaderText = "Comentarios"
        Me.Comentarios.Name = "Comentarios"
        Me.Comentarios.ReadOnly = True
        Me.Comentarios.Width = 90
        '
        'actividades
        '
        Me.actividades.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.actividades.HeaderText = "Acvitidades Realizadas"
        Me.actividades.Name = "actividades"
        Me.actividades.ReadOnly = True
        Me.actividades.Width = 142
        '
        'Insumo
        '
        Me.Insumo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Insumo.HeaderText = "Insumo"
        Me.Insumo.Name = "Insumo"
        Me.Insumo.ReadOnly = True
        Me.Insumo.Width = 66
        '
        'Fecha
        '
        Me.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Fecha.FillWeight = 55.0!
        Me.Fecha.HeaderText = "Fecha Ing."
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 83
        '
        'FechaMand
        '
        Me.FechaMand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FechaMand.FillWeight = 70.0!
        Me.FechaMand.HeaderText = "Fecha Mand."
        Me.FechaMand.Name = "FechaMand"
        Me.FechaMand.ReadOnly = True
        Me.FechaMand.Width = 95
        '
        'nlote
        '
        Me.nlote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.nlote.DefaultCellStyle = DataGridViewCellStyle4
        Me.nlote.FillWeight = 70.0!
        Me.nlote.HeaderText = "N° Lote"
        Me.nlote.MinimumWidth = 100
        Me.nlote.Name = "nlote"
        Me.nlote.ReadOnly = True
        '
        'Usuario
        '
        Me.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Usuario.FillWeight = 50.0!
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        Me.Usuario.Width = 68
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGrilla)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1067, 192)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Actividades Pendientes"
        '
        'cmb_IDVENDEDOR
        '
        Me.cmb_IDVENDEDOR.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_IDVENDEDOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_IDVENDEDOR.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_IDVENDEDOR.ForeColor = System.Drawing.Color.Navy
        Me.cmb_IDVENDEDOR.FormattingEnabled = True
        Me.cmb_IDVENDEDOR.Location = New System.Drawing.Point(447, 22)
        Me.cmb_IDVENDEDOR.Name = "cmb_IDVENDEDOR"
        Me.cmb_IDVENDEDOR.Size = New System.Drawing.Size(260, 23)
        Me.cmb_IDVENDEDOR.TabIndex = 103
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.dtp_HoraEvento)
        Me.GroupBox7.Controls.Add(Me.cmb_NuevoEstado)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.txt_IdBitacora)
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Controls.Add(Me.Label9)
        Me.GroupBox7.Controls.Add(Me.txt_FechaEvento)
        Me.GroupBox7.Controls.Add(Me.cmb_Unidad)
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Controls.Add(Me.txt_Cantidad)
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Controls.Add(Me.Label8)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.txt_fechaRegistro)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 259)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(511, 247)
        Me.GroupBox7.TabIndex = 115
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Fechas del Registro"
        '
        'cmb_NuevoEstado
        '
        Me.cmb_NuevoEstado.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_NuevoEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_NuevoEstado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_NuevoEstado.ForeColor = System.Drawing.Color.Navy
        Me.cmb_NuevoEstado.FormattingEnabled = True
        Me.cmb_NuevoEstado.Items.AddRange(New Object() {"PENDIENTE", "EN PROCESO", "FINALIZADO"})
        Me.cmb_NuevoEstado.Location = New System.Drawing.Point(125, 192)
        Me.cmb_NuevoEstado.Name = "cmb_NuevoEstado"
        Me.cmb_NuevoEstado.Size = New System.Drawing.Size(142, 23)
        Me.cmb_NuevoEstado.TabIndex = 124
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 15)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "Estado"
        '
        'txt_IdBitacora
        '
        Me.txt_IdBitacora.Location = New System.Drawing.Point(126, 15)
        Me.txt_IdBitacora.Name = "txt_IdBitacora"
        Me.txt_IdBitacora.ReadOnly = True
        Me.txt_IdBitacora.Size = New System.Drawing.Size(87, 20)
        Me.txt_IdBitacora.TabIndex = 115
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 15)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Id.:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 15)
        Me.Label9.TabIndex = 113
        Me.Label9.Text = "Unidad"
        '
        'txt_FechaEvento
        '
        Me.txt_FechaEvento.Location = New System.Drawing.Point(126, 73)
        Me.txt_FechaEvento.Mask = "00/00/0000"
        Me.txt_FechaEvento.Name = "txt_FechaEvento"
        Me.txt_FechaEvento.Size = New System.Drawing.Size(87, 20)
        Me.txt_FechaEvento.TabIndex = 111
        Me.txt_FechaEvento.ValidatingType = GetType(Date)
        '
        'cmb_Unidad
        '
        Me.cmb_Unidad.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_Unidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Unidad.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Unidad.ForeColor = System.Drawing.Color.Navy
        Me.cmb_Unidad.FormattingEnabled = True
        Me.cmb_Unidad.Location = New System.Drawing.Point(125, 160)
        Me.cmb_Unidad.Name = "cmb_Unidad"
        Me.cmb_Unidad.Size = New System.Drawing.Size(100, 23)
        Me.cmb_Unidad.TabIndex = 112
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 15)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "Cantidad Insumo"
        '
        'txt_Cantidad
        '
        Me.txt_Cantidad.Location = New System.Drawing.Point(125, 131)
        Me.txt_Cantidad.Name = "txt_Cantidad"
        Me.txt_Cantidad.Size = New System.Drawing.Size(88, 20)
        Me.txt_Cantidad.TabIndex = 112
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 15)
        Me.Label12.TabIndex = 110
        Me.Label12.Text = "Fecha Evento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 15)
        Me.Label8.TabIndex = 106
        Me.Label8.Text = "Hora Evento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 15)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "Fecha Ingreso"
        '
        'txt_fechaRegistro
        '
        Me.txt_fechaRegistro.Location = New System.Drawing.Point(126, 44)
        Me.txt_fechaRegistro.Mask = "00/00/0000"
        Me.txt_fechaRegistro.Name = "txt_fechaRegistro"
        Me.txt_fechaRegistro.Size = New System.Drawing.Size(87, 20)
        Me.txt_fechaRegistro.TabIndex = 109
        Me.txt_fechaRegistro.ValidatingType = GetType(Date)
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txt_respuesta)
        Me.GroupBox6.Location = New System.Drawing.Point(529, 259)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(550, 247)
        Me.GroupBox6.TabIndex = 116
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Detalle de Actividades"
        '
        'txt_respuesta
        '
        Me.txt_respuesta.Location = New System.Drawing.Point(10, 19)
        Me.txt_respuesta.Multiline = True
        Me.txt_respuesta.Name = "txt_respuesta"
        Me.txt_respuesta.Size = New System.Drawing.Size(534, 213)
        Me.txt_respuesta.TabIndex = 103
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(514, 580)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 25)
        Me.Button1.TabIndex = 117
        Me.Button1.Text = "Actualizar Evento"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(175, 580)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 25)
        Me.Button2.TabIndex = 118
        Me.Button2.Text = "Trabajar Bitacora"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(820, 580)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 25)
        Me.Button3.TabIndex = 119
        Me.Button3.Text = "Volver"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(376, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(128, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Estado"
        '
        'cmb_Estado
        '
        Me.cmb_Estado.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Estado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Estado.ForeColor = System.Drawing.Color.Navy
        Me.cmb_Estado.FormattingEnabled = True
        Me.cmb_Estado.Items.AddRange(New Object() {"PENDIENTE", "EN PROCESO", "FINALIZADO"})
        Me.cmb_Estado.Location = New System.Drawing.Point(194, 22)
        Me.cmb_Estado.Name = "cmb_Estado"
        Me.cmb_Estado.Size = New System.Drawing.Size(142, 23)
        Me.cmb_Estado.TabIndex = 122
        '
        'Button4
        '
        Me.Button4.Image = Global.GestionVivero.My.Resources.Resources.Notes
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(914, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(165, 48)
        Me.Button4.TabIndex = 123
        Me.Button4.Text = "Consulta Actividades"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'dtp_HoraEvento
        '
        Me.dtp_HoraEvento.Location = New System.Drawing.Point(126, 102)
        Me.dtp_HoraEvento.Mask = "00:00"
        Me.dtp_HoraEvento.Name = "dtp_HoraEvento"
        Me.dtp_HoraEvento.Size = New System.Drawing.Size(87, 20)
        Me.dtp_HoraEvento.TabIndex = 125
        Me.dtp_HoraEvento.ValidatingType = GetType(Date)
        '
        'Actividades_Pendientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 617)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.cmb_Estado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.cmb_IDVENDEDOR)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Actividades_Pendientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actividades Pendientes"
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_IDVENDEDOR As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_FechaEvento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_fechaRegistro As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_Unidad As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents txt_IdBitacora As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_respuesta As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_Estado As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents evento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comentarios As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actividades As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Insumo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaMand As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nlote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmb_NuevoEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp_HoraEvento As MaskedTextBox
End Class
