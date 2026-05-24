<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaControlSiembra
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GrillaTotales = New System.Windows.Forms.DataGridView()
        Me.SPReporteControlSiembraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_ReporteControlSiembraTableAdapter = New GestionVivero.GESTDataSetControlSiembraTableAdapters.SP_ReporteControlSiembraTableAdapter()
        CType(Me.GrillaTotales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPReporteControlSiembraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrillaTotales
        '
        Me.GrillaTotales.AllowUserToAddRows = False
        Me.GrillaTotales.AllowUserToDeleteRows = False
        Me.GrillaTotales.AllowUserToOrderColumns = True
        Me.GrillaTotales.BackgroundColor = System.Drawing.Color.White
        Me.GrillaTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaTotales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaTotales.Location = New System.Drawing.Point(0, 0)
        Me.GrillaTotales.Name = "GrillaTotales"
        Me.GrillaTotales.ReadOnly = True
        Me.GrillaTotales.Size = New System.Drawing.Size(1234, 718)
        Me.GrillaTotales.TabIndex = 0
        '
        'SPReporteControlSiembraBindingSource
        '
        Me.SPReporteControlSiembraBindingSource.DataMember = "SP_ReporteControlSiembra"
        '
        'SP_ReporteControlSiembraTableAdapter
        '
        Me.SP_ReporteControlSiembraTableAdapter.ClearBeforeFill = True
        '
        'ConsultaControlSiembra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 718)
        Me.Controls.Add(Me.GrillaTotales)
        Me.Name = "ConsultaControlSiembra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Siembras Próximos 60 días"
        CType(Me.GrillaTotales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPReporteControlSiembraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrillaTotales As System.Windows.Forms.DataGridView
    Friend WithEvents SPReporteControlSiembraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SP_ReporteControlSiembraTableAdapter As GestionVivero.GESTDataSetControlSiembraTableAdapters.SP_ReporteControlSiembraTableAdapter
End Class
