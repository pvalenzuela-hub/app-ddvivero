<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizaLote
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
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.txtComentarios = New System.Windows.Forms.TextBox()
        Me.cmbTipoBandeja = New System.Windows.Forms.ComboBox()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.txtFechaEnvasado = New System.Windows.Forms.TextBox()
        Me.txtBatch = New System.Windows.Forms.TextBox()
        Me.txtLoteSemilla = New System.Windows.Forms.TextBox()
        Me.txtNave = New System.Windows.Forms.TextBox()
        Me.txtVariedad = New System.Windows.Forms.TextBox()
        Me.txtSemilla = New System.Windows.Forms.TextBox()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.btnSeleccionarVariedad = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblComentarios = New System.Windows.Forms.Label()
        Me.lblTipoBandeja = New System.Windows.Forms.Label()
        Me.lblUbicacion = New System.Windows.Forms.Label()
        Me.lblFechaEnvasado = New System.Windows.Forms.Label()
        Me.lblBatch = New System.Windows.Forms.Label()
        Me.lblLoteSemilla = New System.Windows.Forms.Label()
        Me.lblNave = New System.Windows.Forms.Label()
        Me.lblVariedad = New System.Windows.Forms.Label()
        Me.lblSemilla = New System.Windows.Forms.Label()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.grpDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.txtComentarios)
        Me.grpDatos.Controls.Add(Me.cmbTipoBandeja)
        Me.grpDatos.Controls.Add(Me.txtUbicacion)
        Me.grpDatos.Controls.Add(Me.txtFechaEnvasado)
        Me.grpDatos.Controls.Add(Me.txtBatch)
        Me.grpDatos.Controls.Add(Me.txtLoteSemilla)
        Me.grpDatos.Controls.Add(Me.txtNave)
        Me.grpDatos.Controls.Add(Me.txtVariedad)
        Me.grpDatos.Controls.Add(Me.txtSemilla)
        Me.grpDatos.Controls.Add(Me.txtLote)
        Me.grpDatos.Controls.Add(Me.btnSeleccionarVariedad)
        Me.grpDatos.Controls.Add(Me.lblComentarios)
        Me.grpDatos.Controls.Add(Me.lblTipoBandeja)
        Me.grpDatos.Controls.Add(Me.lblUbicacion)
        Me.grpDatos.Controls.Add(Me.lblFechaEnvasado)
        Me.grpDatos.Controls.Add(Me.lblBatch)
        Me.grpDatos.Controls.Add(Me.lblLoteSemilla)
        Me.grpDatos.Controls.Add(Me.lblNave)
        Me.grpDatos.Controls.Add(Me.lblVariedad)
        Me.grpDatos.Controls.Add(Me.lblSemilla)
        Me.grpDatos.Controls.Add(Me.lblLote)
        Me.grpDatos.Location = New System.Drawing.Point(12, 12)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(596, 302)
        Me.grpDatos.TabIndex = 0
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "Datos modificables del lote"
        '
        'txtLote
        '
        Me.txtLote.Location = New System.Drawing.Point(99, 25)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.ReadOnly = True
        Me.txtLote.Size = New System.Drawing.Size(90, 23)
        Me.txtLote.TabIndex = 0
        '
        'txtSemilla
        '
        Me.txtSemilla.Location = New System.Drawing.Point(317, 25)
        Me.txtSemilla.Name = "txtSemilla"
        Me.txtSemilla.ReadOnly = True
        Me.txtSemilla.Size = New System.Drawing.Size(260, 23)
        Me.txtSemilla.TabIndex = 1
        '
        'txtVariedad
        '
        Me.txtVariedad.Location = New System.Drawing.Point(99, 62)
        Me.txtVariedad.Name = "txtVariedad"
        Me.txtVariedad.ReadOnly = True
        Me.txtVariedad.Size = New System.Drawing.Size(430, 23)
        Me.txtVariedad.TabIndex = 2
        '
        'btnSeleccionarVariedad
        '
        Me.btnSeleccionarVariedad.Location = New System.Drawing.Point(535, 61)
        Me.btnSeleccionarVariedad.Name = "btnSeleccionarVariedad"
        Me.btnSeleccionarVariedad.Size = New System.Drawing.Size(42, 25)
        Me.btnSeleccionarVariedad.TabIndex = 3
        Me.btnSeleccionarVariedad.Text = "..."
        Me.btnSeleccionarVariedad.UseVisualStyleBackColor = True
        '
        'txtNave
        '
        Me.txtNave.Location = New System.Drawing.Point(99, 100)
        Me.txtNave.Name = "txtNave"
        Me.txtNave.Size = New System.Drawing.Size(90, 23)
        Me.txtNave.TabIndex = 4
        '
        'txtLoteSemilla
        '
        Me.txtLoteSemilla.Location = New System.Drawing.Point(317, 100)
        Me.txtLoteSemilla.Name = "txtLoteSemilla"
        Me.txtLoteSemilla.Size = New System.Drawing.Size(260, 23)
        Me.txtLoteSemilla.TabIndex = 5
        '
        'txtBatch
        '
        Me.txtBatch.Location = New System.Drawing.Point(99, 138)
        Me.txtBatch.Name = "txtBatch"
        Me.txtBatch.Size = New System.Drawing.Size(170, 23)
        Me.txtBatch.TabIndex = 6
        '
        'txtFechaEnvasado
        '
        Me.txtFechaEnvasado.Location = New System.Drawing.Point(443, 138)
        Me.txtFechaEnvasado.Name = "txtFechaEnvasado"
        Me.txtFechaEnvasado.Size = New System.Drawing.Size(134, 23)
        Me.txtFechaEnvasado.TabIndex = 7
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Location = New System.Drawing.Point(99, 176)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(170, 23)
        Me.txtUbicacion.TabIndex = 8
        '
        'cmbTipoBandeja
        '
        Me.cmbTipoBandeja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoBandeja.FormattingEnabled = True
        Me.cmbTipoBandeja.Location = New System.Drawing.Point(443, 176)
        Me.cmbTipoBandeja.Name = "cmbTipoBandeja"
        Me.cmbTipoBandeja.Size = New System.Drawing.Size(134, 23)
        Me.cmbTipoBandeja.TabIndex = 9
        '
        'txtComentarios
        '
        Me.txtComentarios.Location = New System.Drawing.Point(99, 214)
        Me.txtComentarios.Multiline = True
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComentarios.Size = New System.Drawing.Size(478, 70)
        Me.txtComentarios.TabIndex = 10
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(202, 327)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(98, 30)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(319, 327)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(98, 30)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'labels
        '
        Me.lblLote.AutoSize = True
        Me.lblLote.Location = New System.Drawing.Point(19, 29)
        Me.lblLote.Text = "N° Lote"
        Me.lblSemilla.AutoSize = True
        Me.lblSemilla.Location = New System.Drawing.Point(252, 29)
        Me.lblSemilla.Text = "Especie"
        Me.lblVariedad.AutoSize = True
        Me.lblVariedad.Location = New System.Drawing.Point(19, 66)
        Me.lblVariedad.Text = "Variedad"
        Me.lblNave.AutoSize = True
        Me.lblNave.Location = New System.Drawing.Point(19, 104)
        Me.lblNave.Text = "N° Nave"
        Me.lblLoteSemilla.AutoSize = True
        Me.lblLoteSemilla.Location = New System.Drawing.Point(238, 104)
        Me.lblLoteSemilla.Text = "Lote semilla"
        Me.lblBatch.AutoSize = True
        Me.lblBatch.Location = New System.Drawing.Point(19, 142)
        Me.lblBatch.Text = "Batch"
        Me.lblFechaEnvasado.AutoSize = True
        Me.lblFechaEnvasado.Location = New System.Drawing.Point(340, 142)
        Me.lblFechaEnvasado.Text = "Fecha envasado"
        Me.lblUbicacion.AutoSize = True
        Me.lblUbicacion.Location = New System.Drawing.Point(19, 180)
        Me.lblUbicacion.Text = "Ubicación"
        Me.lblTipoBandeja.AutoSize = True
        Me.lblTipoBandeja.Location = New System.Drawing.Point(341, 180)
        Me.lblTipoBandeja.Text = "Tipo bandeja"
        Me.lblComentarios.AutoSize = True
        Me.lblComentarios.Location = New System.Drawing.Point(19, 218)
        Me.lblComentarios.Text = "Comentarios"
        '
        'ActualizaLote
        '
        Me.AcceptButton = Me.btnGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(620, 370)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.grpDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ActualizaLote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modificar datos del lote"
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents grpDatos As GroupBox
    Friend WithEvents txtLote As TextBox
    Friend WithEvents txtSemilla As TextBox
    Friend WithEvents txtVariedad As TextBox
    Friend WithEvents btnSeleccionarVariedad As Button
    Friend WithEvents txtNave As TextBox
    Friend WithEvents txtLoteSemilla As TextBox
    Friend WithEvents txtBatch As TextBox
    Friend WithEvents txtFechaEnvasado As TextBox
    Friend WithEvents txtUbicacion As TextBox
    Friend WithEvents cmbTipoBandeja As ComboBox
    Friend WithEvents txtComentarios As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblLote As Label
    Friend WithEvents lblSemilla As Label
    Friend WithEvents lblVariedad As Label
    Friend WithEvents lblNave As Label
    Friend WithEvents lblLoteSemilla As Label
    Friend WithEvents lblBatch As Label
    Friend WithEvents lblFechaEnvasado As Label
    Friend WithEvents lblUbicacion As Label
    Friend WithEvents lblTipoBandeja As Label
    Friend WithEvents lblComentarios As Label
End Class
