<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conteo_Plantas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GrillaConteo = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.nUD_Cant_Band = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_BandIng = New System.Windows.Forms.NumericUpDown()
        Me.nband = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.celdasvacias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GrillaConteo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nUD_Cant_Band, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_BandIng, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrillaConteo
        '
        Me.GrillaConteo.AllowUserToAddRows = False
        Me.GrillaConteo.AllowUserToDeleteRows = False
        Me.GrillaConteo.BackgroundColor = System.Drawing.Color.SeaShell
        Me.GrillaConteo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrillaConteo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GrillaConteo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaConteo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nband, Me.celdasvacias})
        Me.GrillaConteo.Location = New System.Drawing.Point(12, 37)
        Me.GrillaConteo.Name = "GrillaConteo"
        Me.GrillaConteo.RowHeadersVisible = False
        Me.GrillaConteo.Size = New System.Drawing.Size(404, 300)
        Me.GrillaConteo.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.ForestGreen
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(30, 353)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(347, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Calcular Conteo de Plantas"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'nUD_Cant_Band
        '
        Me.nUD_Cant_Band.Location = New System.Drawing.Point(88, 12)
        Me.nUD_Cant_Band.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.nUD_Cant_Band.Name = "nUD_Cant_Band"
        Me.nUD_Cant_Band.Size = New System.Drawing.Size(66, 20)
        Me.nUD_Cant_Band.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Band. Totales"
        '
        'Button2
        '
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button2.Location = New System.Drawing.Point(307, -1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(55, 37)
        Me.Button2.TabIndex = 4
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Band. Ing."
        '
        'txt_BandIng
        '
        Me.txt_BandIng.Location = New System.Drawing.Point(216, 12)
        Me.txt_BandIng.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.txt_BandIng.Name = "txt_BandIng"
        Me.txt_BandIng.Size = New System.Drawing.Size(66, 20)
        Me.txt_BandIng.TabIndex = 6
        '
        'nband
        '
        Me.nband.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nband.HeaderText = "N° Bandeja"
        Me.nband.Name = "nband"
        '
        'celdasvacias
        '
        Me.celdasvacias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.celdasvacias.HeaderText = "Cant. Celdas Vacías"
        Me.celdasvacias.Name = "celdasvacias"
        '
        'Conteo_Plantas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(449, 399)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_BandIng)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nUD_Cant_Band)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GrillaConteo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimizeBox = False
        Me.Name = "Conteo_Plantas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conteo_Plantas"
        Me.TopMost = True
        CType(Me.GrillaConteo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nUD_Cant_Band, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_BandIng, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrillaConteo As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents nUD_Cant_Band As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_BandIng As System.Windows.Forms.NumericUpDown
    Friend WithEvents nband As DataGridViewTextBoxColumn
    Friend WithEvents celdasvacias As DataGridViewTextBoxColumn
End Class
