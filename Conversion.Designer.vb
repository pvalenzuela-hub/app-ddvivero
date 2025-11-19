<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conversion
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
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_Tasa = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_Unidad1 = New System.Windows.Forms.ComboBox
        Me.cmb_Unidad2 = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rb_TO4 = New System.Windows.Forms.RadioButton
        Me.rb_TO3 = New System.Windows.Forms.RadioButton
        Me.rb_TO2 = New System.Windows.Forms.RadioButton
        Me.rb_TO1 = New System.Windows.Forms.RadioButton
        Me.txt_IDConversion = New System.Windows.Forms.MaskedTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.DataGrilla = New System.Windows.Forms.DataGridView
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DesUnidad1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DesUnidad2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoOperacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdUniOri = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdUniDestino = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_Tasa)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txt_IDConversion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(848, 104)
        Me.GroupBox1.TabIndex = 96
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos para crear Conversiones"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(581, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 15)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Valor :"
        '
        'txt_Tasa
        '
        Me.txt_Tasa.Location = New System.Drawing.Point(628, 45)
        Me.txt_Tasa.Name = "txt_Tasa"
        Me.txt_Tasa.Size = New System.Drawing.Size(100, 20)
        Me.txt_Tasa.TabIndex = 103
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.cmb_Unidad1)
        Me.GroupBox3.Controls.Add(Me.cmb_Unidad2)
        Me.GroupBox3.Location = New System.Drawing.Point(124, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 82)
        Me.GroupBox3.TabIndex = 102
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Unidades de Medida"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 15)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "A:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 15)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "De:"
        '
        'cmb_Unidad1
        '
        Me.cmb_Unidad1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Unidad1.FormattingEnabled = True
        Me.cmb_Unidad1.Location = New System.Drawing.Point(38, 20)
        Me.cmb_Unidad1.Name = "cmb_Unidad1"
        Me.cmb_Unidad1.Size = New System.Drawing.Size(132, 21)
        Me.cmb_Unidad1.TabIndex = 98
        '
        'cmb_Unidad2
        '
        Me.cmb_Unidad2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Unidad2.FormattingEnabled = True
        Me.cmb_Unidad2.Location = New System.Drawing.Point(38, 46)
        Me.cmb_Unidad2.Name = "cmb_Unidad2"
        Me.cmb_Unidad2.Size = New System.Drawing.Size(132, 21)
        Me.cmb_Unidad2.TabIndex = 100
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(747, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 45)
        Me.Button1.TabIndex = 97
        Me.Button1.Text = "Actualizar Datos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_TO4)
        Me.GroupBox2.Controls.Add(Me.rb_TO3)
        Me.GroupBox2.Controls.Add(Me.rb_TO2)
        Me.GroupBox2.Controls.Add(Me.rb_TO1)
        Me.GroupBox2.Location = New System.Drawing.Point(330, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(232, 79)
        Me.GroupBox2.TabIndex = 99
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo Operación"
        '
        'rb_TO4
        '
        Me.rb_TO4.AutoSize = True
        Me.rb_TO4.Location = New System.Drawing.Point(128, 47)
        Me.rb_TO4.Name = "rb_TO4"
        Me.rb_TO4.Size = New System.Drawing.Size(62, 17)
        Me.rb_TO4.TabIndex = 3
        Me.rb_TO4.Text = "4 Resta"
        Me.rb_TO4.UseVisualStyleBackColor = True
        '
        'rb_TO3
        '
        Me.rb_TO3.AutoSize = True
        Me.rb_TO3.Location = New System.Drawing.Point(6, 47)
        Me.rb_TO3.Name = "rb_TO3"
        Me.rb_TO3.Size = New System.Drawing.Size(61, 17)
        Me.rb_TO3.TabIndex = 2
        Me.rb_TO3.Text = "3 Suma"
        Me.rb_TO3.UseVisualStyleBackColor = True
        '
        'rb_TO2
        '
        Me.rb_TO2.AutoSize = True
        Me.rb_TO2.Checked = True
        Me.rb_TO2.Location = New System.Drawing.Point(128, 19)
        Me.rb_TO2.Name = "rb_TO2"
        Me.rb_TO2.Size = New System.Drawing.Size(71, 17)
        Me.rb_TO2.TabIndex = 1
        Me.rb_TO2.TabStop = True
        Me.rb_TO2.Text = "2 División"
        Me.rb_TO2.UseVisualStyleBackColor = True
        '
        'rb_TO1
        '
        Me.rb_TO1.AutoSize = True
        Me.rb_TO1.Location = New System.Drawing.Point(6, 19)
        Me.rb_TO1.Name = "rb_TO1"
        Me.rb_TO1.Size = New System.Drawing.Size(98, 17)
        Me.rb_TO1.TabIndex = 0
        Me.rb_TO1.Text = "1 Multiplicación"
        Me.rb_TO1.UseVisualStyleBackColor = True
        '
        'txt_IDConversion
        '
        Me.txt_IDConversion.HidePromptOnLeave = True
        Me.txt_IDConversion.Location = New System.Drawing.Point(22, 32)
        Me.txt_IDConversion.Name = "txt_IDConversion"
        Me.txt_IDConversion.ReadOnly = True
        Me.txt_IDConversion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_IDConversion.Size = New System.Drawing.Size(53, 20)
        Me.txt_IDConversion.TabIndex = 91
        Me.txt_IDConversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 15)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "ID"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGrilla)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 122)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(848, 231)
        Me.GroupBox4.TabIndex = 102
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Listado de Fórmulas"
        '
        'DataGrilla
        '
        Me.DataGrilla.AllowUserToAddRows = False
        Me.DataGrilla.AllowUserToDeleteRows = False
        Me.DataGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.DesUnidad1, Me.DesUnidad2, Me.TipoOperacion, Me.Valor, Me.IdUniOri, Me.IdUniDestino})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrilla.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGrilla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGrilla.Location = New System.Drawing.Point(6, 21)
        Me.DataGrilla.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.DataGrilla.Name = "DataGrilla"
        Me.DataGrilla.ReadOnly = True
        Me.DataGrilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataGrilla.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.DataGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGrilla.Size = New System.Drawing.Size(836, 202)
        Me.DataGrilla.TabIndex = 65
        '
        'Id
        '
        Me.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Id.FillWeight = 25.0!
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        '
        'DesUnidad1
        '
        Me.DesUnidad1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DesUnidad1.FillWeight = 150.0!
        Me.DesUnidad1.HeaderText = "De Unidad"
        Me.DesUnidad1.Name = "DesUnidad1"
        Me.DesUnidad1.ReadOnly = True
        '
        'DesUnidad2
        '
        Me.DesUnidad2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DesUnidad2.FillWeight = 150.0!
        Me.DesUnidad2.HeaderText = "A Unidad"
        Me.DesUnidad2.Name = "DesUnidad2"
        Me.DesUnidad2.ReadOnly = True
        '
        'TipoOperacion
        '
        Me.TipoOperacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.TipoOperacion.DefaultCellStyle = DataGridViewCellStyle13
        Me.TipoOperacion.FillWeight = 50.0!
        Me.TipoOperacion.HeaderText = "Tipo Operación"
        Me.TipoOperacion.MinimumWidth = 100
        Me.TipoOperacion.Name = "TipoOperacion"
        Me.TipoOperacion.ReadOnly = True
        '
        'Valor
        '
        Me.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        Me.Valor.ReadOnly = True
        '
        'IdUniOri
        '
        Me.IdUniOri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdUniOri.FillWeight = 50.0!
        Me.IdUniOri.HeaderText = "Id.Uni.1"
        Me.IdUniOri.Name = "IdUniOri"
        Me.IdUniOri.ReadOnly = True
        '
        'IdUniDestino
        '
        Me.IdUniDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdUniDestino.FillWeight = 50.0!
        Me.IdUniDestino.HeaderText = "Id.Uni.2"
        Me.IdUniDestino.Name = "IdUniDestino"
        Me.IdUniDestino.ReadOnly = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(137, 372)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(149, 23)
        Me.Button5.TabIndex = 107
        Me.Button5.Text = "Nueva Conversión"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(610, 372)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(132, 23)
        Me.Button4.TabIndex = 106
        Me.Button4.Text = "Volver"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(455, 372)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 23)
        Me.Button3.TabIndex = 105
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(300, 372)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 23)
        Me.Button2.TabIndex = 104
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Conversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 410)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Conversion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de Conversion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_TO4 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_TO3 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_TO2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_TO1 As System.Windows.Forms.RadioButton
    Friend WithEvents cmb_Unidad1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_IDConversion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Tasa As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_Unidad2 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesUnidad1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesUnidad2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoOperacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdUniOri As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdUniDestino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
