<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificaDatosVenta
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cmbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.txtNumDoc = New System.Windows.Forms.TextBox()
        Me.txtDocSII = New System.Windows.Forms.TextBox()
        Me.txtMontoDocumento = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtIdVtaHead = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbTipoDocSII = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(146, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo Doc."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(146, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "N° Doc."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(146, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "N° Doc. SII"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(146, 277)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Monto Documento"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(271, 103)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(103, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'cmbTipoDoc
        '
        Me.cmbTipoDoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoDoc.Enabled = False
        Me.cmbTipoDoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbTipoDoc.FormattingEnabled = True
        Me.cmbTipoDoc.Items.AddRange(New Object() {"FE", "BL"})
        Me.cmbTipoDoc.Location = New System.Drawing.Point(271, 137)
        Me.cmbTipoDoc.Name = "cmbTipoDoc"
        Me.cmbTipoDoc.Size = New System.Drawing.Size(103, 21)
        Me.cmbTipoDoc.TabIndex = 8
        '
        'txtNumDoc
        '
        Me.txtNumDoc.Location = New System.Drawing.Point(271, 171)
        Me.txtNumDoc.Name = "txtNumDoc"
        Me.txtNumDoc.ReadOnly = True
        Me.txtNumDoc.Size = New System.Drawing.Size(103, 20)
        Me.txtNumDoc.TabIndex = 9
        '
        'txtDocSII
        '
        Me.txtDocSII.Location = New System.Drawing.Point(271, 205)
        Me.txtDocSII.Name = "txtDocSII"
        Me.txtDocSII.ReadOnly = True
        Me.txtDocSII.Size = New System.Drawing.Size(103, 20)
        Me.txtDocSII.TabIndex = 10
        '
        'txtMontoDocumento
        '
        Me.txtMontoDocumento.Location = New System.Drawing.Point(271, 273)
        Me.txtMontoDocumento.Name = "txtMontoDocumento"
        Me.txtMontoDocumento.ReadOnly = True
        Me.txtMontoDocumento.Size = New System.Drawing.Size(103, 20)
        Me.txtMontoDocumento.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.guardar_40x40
        Me.Button1.Location = New System.Drawing.Point(271, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 49)
        Me.Button1.TabIndex = 12
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.salir_40x40
        Me.Button2.Location = New System.Drawing.Point(530, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(49, 49)
        Me.Button2.TabIndex = 13
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtIdVtaHead
        '
        Me.txtIdVtaHead.Location = New System.Drawing.Point(12, 340)
        Me.txtIdVtaHead.Name = "txtIdVtaHead"
        Me.txtIdVtaHead.Size = New System.Drawing.Size(100, 20)
        Me.txtIdVtaHead.TabIndex = 14
        Me.txtIdVtaHead.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 15)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Cliente:"
        '
        'txtCliente
        '
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(75, 6)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(449, 21)
        Me.txtCliente.TabIndex = 16
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.Color.Blue
        Me.lbltitulo.Location = New System.Drawing.Point(75, 50)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(51, 15)
        Me.lbltitulo.TabIndex = 17
        Me.lbltitulo.Text = "Label7"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(146, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Tipo Doc. SII"
        '
        'cmbTipoDocSII
        '
        Me.cmbTipoDocSII.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipoDocSII.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoDocSII.Enabled = False
        Me.cmbTipoDocSII.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbTipoDocSII.FormattingEnabled = True
        Me.cmbTipoDocSII.Items.AddRange(New Object() {"FE", "BL", "NF"})
        Me.cmbTipoDocSII.Location = New System.Drawing.Point(271, 239)
        Me.cmbTipoDocSII.Name = "cmbTipoDocSII"
        Me.cmbTipoDocSII.Size = New System.Drawing.Size(103, 21)
        Me.cmbTipoDocSII.TabIndex = 20
        '
        'ModificaDatosVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(580, 389)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbTipoDocSII)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtIdVtaHead)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtMontoDocumento)
        Me.Controls.Add(Me.txtDocSII)
        Me.Controls.Add(Me.txtNumDoc)
        Me.Controls.Add(Me.cmbTipoDoc)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ModificaDatosVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modifica Datos Venta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cmbTipoDoc As ComboBox
    Friend WithEvents txtNumDoc As TextBox
    Friend WithEvents txtDocSII As TextBox
    Friend WithEvents txtMontoDocumento As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtIdVtaHead As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents lbltitulo As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbTipoDocSII As ComboBox
End Class
