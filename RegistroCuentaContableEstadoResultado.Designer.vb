<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroCuentaContableEstadoResultado
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
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.CuentaContableEstadoResultadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.IdCuentaFlujoPresupuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtaCtbleDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SumaTipoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuentaContableFlujoIngresosEgresosPresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GESTDataSet16 = New GestionVivero.GESTDataSet16()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.CuentaContableFlujoIngresosEgresosPresupuestoTableAdapter = New GestionVivero.GESTDataSet16TableAdapters.CuentaContableFlujoIngresosEgresosPresupuestoTableAdapter()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentaContableEstadoResultadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentaContableFlujoIngresosEgresosPresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTDataSet16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1181, 547)
        Me.SplitContainer1.SplitterDistance = 63
        Me.SplitContainer1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(881, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(288, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CUENTA CONTABLE PRESUPUESTO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(374, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CUENTA CONTABLE ESTADO DE RESULTADOS"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.DataGridView3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.DataGridView1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.DataGridView4)
        Me.SplitContainer2.Panel2.Controls.Add(Me.DataGridView2)
        Me.SplitContainer2.Size = New System.Drawing.Size(1181, 480)
        Me.SplitContainer2.SplitterDistance = 596
        Me.SplitContainer2.TabIndex = 0
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.DataSource = Me.CuentaContableEstadoResultadoBindingSource
        Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView3.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(596, 480)
        Me.DataGridView3.TabIndex = 1
        '
        'CuentaContableEstadoResultadoBindingSource
        '
        Me.CuentaContableEstadoResultadoBindingSource.DataMember = "CuentaContableEstadoResultado"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(596, 480)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridView4
        '
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCuentaFlujoPresupuestoDataGridViewTextBoxColumn, Me.CtaCtbleDataGridViewTextBoxColumn1, Me.TipoDataGridViewTextBoxColumn1, Me.SumaTipoDataGridViewTextBoxColumn1})
        Me.DataGridView4.DataSource = Me.CuentaContableFlujoIngresosEgresosPresupuestoBindingSource
        Me.DataGridView4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView4.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(581, 480)
        Me.DataGridView4.TabIndex = 1
        '
        'IdCuentaFlujoPresupuestoDataGridViewTextBoxColumn
        '
        Me.IdCuentaFlujoPresupuestoDataGridViewTextBoxColumn.DataPropertyName = "IdCuentaFlujoPresupuesto"
        Me.IdCuentaFlujoPresupuestoDataGridViewTextBoxColumn.HeaderText = "IdCuentaFlujoPresupuesto"
        Me.IdCuentaFlujoPresupuestoDataGridViewTextBoxColumn.Name = "IdCuentaFlujoPresupuestoDataGridViewTextBoxColumn"
        Me.IdCuentaFlujoPresupuestoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CtaCtbleDataGridViewTextBoxColumn1
        '
        Me.CtaCtbleDataGridViewTextBoxColumn1.DataPropertyName = "Cta_Ctble"
        Me.CtaCtbleDataGridViewTextBoxColumn1.HeaderText = "Cta_Ctble"
        Me.CtaCtbleDataGridViewTextBoxColumn1.Name = "CtaCtbleDataGridViewTextBoxColumn1"
        '
        'TipoDataGridViewTextBoxColumn1
        '
        Me.TipoDataGridViewTextBoxColumn1.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn1.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn1.Name = "TipoDataGridViewTextBoxColumn1"
        '
        'SumaTipoDataGridViewTextBoxColumn1
        '
        Me.SumaTipoDataGridViewTextBoxColumn1.DataPropertyName = "Suma_Tipo"
        Me.SumaTipoDataGridViewTextBoxColumn1.HeaderText = "Suma_Tipo"
        Me.SumaTipoDataGridViewTextBoxColumn1.Name = "SumaTipoDataGridViewTextBoxColumn1"
        '
        'CuentaContableFlujoIngresosEgresosPresupuestoBindingSource
        '
        Me.CuentaContableFlujoIngresosEgresosPresupuestoBindingSource.DataMember = "CuentaContableFlujoIngresosEgresosPresupuesto"
        Me.CuentaContableFlujoIngresosEgresosPresupuestoBindingSource.DataSource = Me.GESTDataSet16
        '
        'GESTDataSet16
        '
        Me.GESTDataSet16.DataSetName = "GESTDataSet16"
        Me.GESTDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(581, 480)
        Me.DataGridView2.TabIndex = 0
        '
        'CuentaContableFlujoIngresosEgresosPresupuestoTableAdapter
        '
        Me.CuentaContableFlujoIngresosEgresosPresupuestoTableAdapter.ClearBeforeFill = True
        '
        'RegistroCuentaContableEstadoResultado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 547)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "RegistroCuentaContableEstadoResultado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Cuentas Contables para Reportes"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentaContableEstadoResultadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentaContableFlujoIngresosEgresosPresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTDataSet16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    ' Friend WithEvents GESTDataSet15 As GestionVivero.GESTDataSet15
    Friend WithEvents CuentaContableEstadoResultadoBindingSource As System.Windows.Forms.BindingSource
    '  Friend WithEvents CuentaContableEstadoResultadoTableAdapter As GestionVivero.GESTDataSet15TableAdapters.CuentaContableEstadoResultadoTableAdapter
    Friend WithEvents IdCuentaContableEstResultadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtaCtbleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SumaTipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents GESTDataSet16 As GestionVivero.GESTDataSet16
    Friend WithEvents CuentaContableFlujoIngresosEgresosPresupuestoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CuentaContableFlujoIngresosEgresosPresupuestoTableAdapter As GestionVivero.GESTDataSet16TableAdapters.CuentaContableFlujoIngresosEgresosPresupuestoTableAdapter
    Friend WithEvents IdCuentaFlujoPresupuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtaCtbleDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SumaTipoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
