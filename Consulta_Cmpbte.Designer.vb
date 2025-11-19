<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta_Cmpbte
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtp_Fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.dtp_Fecha2 = New System.Windows.Forms.DateTimePicker()
        Me.DataCmpbte = New System.Windows.Forms.DataGridView()
        Me.ncomp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipocmpbte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Glosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totdebe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tothaber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataMovto = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_TotalDEBE = New System.Windows.Forms.MaskedTextBox()
        Me.txt_TotalHABER = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Cta_Ctble = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_TotalHABERCTA = New System.Windows.Forms.MaskedTextBox()
        Me.txt_TotalDEBECTA = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_SaldoCuenta = New System.Windows.Forms.MaskedTextBox()
        Me.txt_Descripcion = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txt_IdCmpbte = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.DataCmpbte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataMovto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtp_Fecha1
        '
        Me.dtp_Fecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha1.Location = New System.Drawing.Point(81, 14)
        Me.dtp_Fecha1.Name = "dtp_Fecha1"
        Me.dtp_Fecha1.Size = New System.Drawing.Size(96, 20)
        Me.dtp_Fecha1.TabIndex = 0
        '
        'dtp_Fecha2
        '
        Me.dtp_Fecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha2.Location = New System.Drawing.Point(255, 14)
        Me.dtp_Fecha2.Name = "dtp_Fecha2"
        Me.dtp_Fecha2.Size = New System.Drawing.Size(96, 20)
        Me.dtp_Fecha2.TabIndex = 1
        '
        'DataCmpbte
        '
        Me.DataCmpbte.AllowUserToAddRows = False
        Me.DataCmpbte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataCmpbte.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataCmpbte.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataCmpbte.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataCmpbte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataCmpbte.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ncomp, Me.Fecha, Me.tipocmpbte, Me.Glosa, Me.totdebe, Me.tothaber, Me.Item, Me.Tipo, Me.Estado})
        Me.DataCmpbte.Location = New System.Drawing.Point(2, 42)
        Me.DataCmpbte.Name = "DataCmpbte"
        Me.DataCmpbte.ReadOnly = True
        Me.DataCmpbte.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataCmpbte.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataCmpbte.RowTemplate.Height = 24
        Me.DataCmpbte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataCmpbte.Size = New System.Drawing.Size(1159, 253)
        Me.DataCmpbte.TabIndex = 3
        '
        'ncomp
        '
        Me.ncomp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ncomp.HeaderText = "N° Comp"
        Me.ncomp.Name = "ncomp"
        Me.ncomp.ReadOnly = True
        Me.ncomp.Width = 74
        '
        'Fecha
        '
        Me.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Fecha.HeaderText = "F.Comp"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 68
        '
        'tipocmpbte
        '
        Me.tipocmpbte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.tipocmpbte.HeaderText = "Tipo Comp."
        Me.tipocmpbte.Name = "tipocmpbte"
        Me.tipocmpbte.ReadOnly = True
        Me.tipocmpbte.Width = 86
        '
        'Glosa
        '
        Me.Glosa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Glosa.HeaderText = "Glosa"
        Me.Glosa.Name = "Glosa"
        Me.Glosa.ReadOnly = True
        Me.Glosa.Width = 59
        '
        'totdebe
        '
        Me.totdebe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.totdebe.DefaultCellStyle = DataGridViewCellStyle1
        Me.totdebe.HeaderText = "Total DEBE"
        Me.totdebe.Name = "totdebe"
        Me.totdebe.ReadOnly = True
        Me.totdebe.Width = 88
        '
        'tothaber
        '
        Me.tothaber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.tothaber.DefaultCellStyle = DataGridViewCellStyle2
        Me.tothaber.HeaderText = "Total HABER"
        Me.tothaber.Name = "tothaber"
        Me.tothaber.ReadOnly = True
        Me.tothaber.Width = 96
        '
        'Item
        '
        Me.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Item.HeaderText = "Item"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.Width = 52
        '
        'Tipo
        '
        Me.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Tipo.HeaderText = "Tipo Evento"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 90
        '
        'Estado
        '
        Me.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 65
        '
        'DataMovto
        '
        Me.DataMovto.AllowUserToAddRows = False
        Me.DataMovto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataMovto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataMovto.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataMovto.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataMovto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataMovto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.DataMovto.Location = New System.Drawing.Point(2, 344)
        Me.DataMovto.Name = "DataMovto"
        Me.DataMovto.ReadOnly = True
        Me.DataMovto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DataMovto.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataMovto.RowTemplate.Height = 24
        Me.DataMovto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataMovto.Size = New System.Drawing.Size(1159, 268)
        Me.DataMovto.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id.Movto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 74
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cta.Ctble."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 78
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 88
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn4.HeaderText = "Debe"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 58
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn5.HeaderText = "Haber"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 61
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cta. CC"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 68
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.HeaderText = "Centro Costo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 93
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.HeaderText = "Rut"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 49
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.HeaderText = "Glosa"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 59
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 301)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 29)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Ver Detalle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1039, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Consulta Comprobante"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Desde Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Hasta Fecha"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(993, 640)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 31)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Cerrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(312, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "TOTALES COMPROBANTES ====>"
        '
        'txt_TotalDEBE
        '
        Me.txt_TotalDEBE.Location = New System.Drawing.Point(598, 305)
        Me.txt_TotalDEBE.Name = "txt_TotalDEBE"
        Me.txt_TotalDEBE.ReadOnly = True
        Me.txt_TotalDEBE.Size = New System.Drawing.Size(100, 20)
        Me.txt_TotalDEBE.TabIndex = 11
        Me.txt_TotalDEBE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_TotalHABER
        '
        Me.txt_TotalHABER.Location = New System.Drawing.Point(752, 305)
        Me.txt_TotalHABER.Name = "txt_TotalHABER"
        Me.txt_TotalHABER.ReadOnly = True
        Me.txt_TotalHABER.Size = New System.Drawing.Size(100, 20)
        Me.txt_TotalHABER.TabIndex = 12
        Me.txt_TotalHABER.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(559, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Debe"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(710, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Haber"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(357, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Cuenta"
        '
        'txt_Cta_Ctble
        '
        Me.txt_Cta_Ctble.Location = New System.Drawing.Point(400, 14)
        Me.txt_Cta_Ctble.MaxLength = 7
        Me.txt_Cta_Ctble.Name = "txt_Cta_Ctble"
        Me.txt_Cta_Ctble.Size = New System.Drawing.Size(91, 20)
        Me.txt_Cta_Ctble.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(257, 655)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "TOTALES CUENTA ====>"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(561, 655)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Haber"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(410, 655)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Debe"
        '
        'txt_TotalHABERCTA
        '
        Me.txt_TotalHABERCTA.Location = New System.Drawing.Point(603, 651)
        Me.txt_TotalHABERCTA.Name = "txt_TotalHABERCTA"
        Me.txt_TotalHABERCTA.ReadOnly = True
        Me.txt_TotalHABERCTA.Size = New System.Drawing.Size(100, 20)
        Me.txt_TotalHABERCTA.TabIndex = 19
        Me.txt_TotalHABERCTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_TotalDEBECTA
        '
        Me.txt_TotalDEBECTA.Location = New System.Drawing.Point(449, 651)
        Me.txt_TotalDEBECTA.Name = "txt_TotalDEBECTA"
        Me.txt_TotalDEBECTA.ReadOnly = True
        Me.txt_TotalDEBECTA.Size = New System.Drawing.Size(100, 20)
        Me.txt_TotalDEBECTA.TabIndex = 18
        Me.txt_TotalDEBECTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(709, 654)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Saldo"
        '
        'txt_SaldoCuenta
        '
        Me.txt_SaldoCuenta.Location = New System.Drawing.Point(752, 651)
        Me.txt_SaldoCuenta.Name = "txt_SaldoCuenta"
        Me.txt_SaldoCuenta.ReadOnly = True
        Me.txt_SaldoCuenta.Size = New System.Drawing.Size(100, 20)
        Me.txt_SaldoCuenta.TabIndex = 23
        Me.txt_SaldoCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Descripcion
        '
        Me.txt_Descripcion.Location = New System.Drawing.Point(494, 14)
        Me.txt_Descripcion.MaxLength = 7
        Me.txt_Descripcion.Name = "txt_Descripcion"
        Me.txt_Descripcion.ReadOnly = True
        Me.txt_Descripcion.Size = New System.Drawing.Size(265, 20)
        Me.txt_Descripcion.TabIndex = 24
        '
        'Button4
        '
        Me.Button4.Image = Global.GestionVivero.My.Resources.Resources.Delete1
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(1056, 301)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(105, 38)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "ELIMINAR"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txt_IdCmpbte
        '
        Me.txt_IdCmpbte.Location = New System.Drawing.Point(855, 14)
        Me.txt_IdCmpbte.MaxLength = 7
        Me.txt_IdCmpbte.Name = "txt_IdCmpbte"
        Me.txt_IdCmpbte.Size = New System.Drawing.Size(91, 20)
        Me.txt_IdCmpbte.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(830, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "N°"
        '
        'Consulta_Cmpbte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 679)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_IdCmpbte)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txt_Descripcion)
        Me.Controls.Add(Me.txt_SaldoCuenta)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_TotalHABERCTA)
        Me.Controls.Add(Me.txt_TotalDEBECTA)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_Cta_Ctble)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_TotalHABER)
        Me.Controls.Add(Me.txt_TotalDEBE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataMovto)
        Me.Controls.Add(Me.DataCmpbte)
        Me.Controls.Add(Me.dtp_Fecha2)
        Me.Controls.Add(Me.dtp_Fecha1)
        Me.Name = "Consulta_Cmpbte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Comprobante"
        CType(Me.DataCmpbte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataMovto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtp_Fecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Fecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataCmpbte As System.Windows.Forms.DataGridView
    Friend WithEvents DataMovto As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ncomp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipocmpbte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Glosa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totdebe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tothaber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_TotalDEBE As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_TotalHABER As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Cta_Ctble As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_TotalHABERCTA As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_TotalDEBECTA As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_SaldoCuenta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents txt_IdCmpbte As TextBox
    Friend WithEvents Label11 As Label
End Class
