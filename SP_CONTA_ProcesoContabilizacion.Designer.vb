<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SP_CONTA_ProcesoContabilizacion
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_MesProceso = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_AgnoProceso = New System.Windows.Forms.NumericUpDown()
        CType(Me.txt_MesProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_AgnoProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(108, 244)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(210, 65)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Contabiliza Facturas, Boletas Compras-Ventas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Mes de Proceso:"
        '
        'txt_MesProceso
        '
        Me.txt_MesProceso.Location = New System.Drawing.Point(201, 70)
        Me.txt_MesProceso.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.txt_MesProceso.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_MesProceso.Name = "txt_MesProceso"
        Me.txt_MesProceso.Size = New System.Drawing.Size(71, 20)
        Me.txt_MesProceso.TabIndex = 5
        Me.txt_MesProceso.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Año Proceso:"
        '
        'txt_AgnoProceso
        '
        Me.txt_AgnoProceso.Location = New System.Drawing.Point(201, 118)
        Me.txt_AgnoProceso.Maximum = New Decimal(New Integer() {2999, 0, 0, 0})
        Me.txt_AgnoProceso.Minimum = New Decimal(New Integer() {2013, 0, 0, 0})
        Me.txt_AgnoProceso.Name = "txt_AgnoProceso"
        Me.txt_AgnoProceso.Size = New System.Drawing.Size(71, 20)
        Me.txt_AgnoProceso.TabIndex = 7
        Me.txt_AgnoProceso.Value = New Decimal(New Integer() {2013, 0, 0, 0})
        '
        'SP_CONTA_ProcesoContabilizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 331)
        Me.Controls.Add(Me.txt_AgnoProceso)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_MesProceso)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "SP_CONTA_ProcesoContabilizacion"
        Me.Text = "SP_CONTA_ProcesoContabilizacion"
        CType(Me.txt_MesProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_AgnoProceso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_MesProceso As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_AgnoProceso As System.Windows.Forms.NumericUpDown
End Class
