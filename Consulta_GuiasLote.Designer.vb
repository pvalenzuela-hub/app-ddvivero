<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta_GuiasLote
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_FechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataLotes = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fsiembra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.especie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.variedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldoplantas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_FechaDesde
        '
        Me.txt_FechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_FechaDesde.Location = New System.Drawing.Point(469, 22)
        Me.txt_FechaDesde.Name = "txt_FechaDesde"
        Me.txt_FechaDesde.Size = New System.Drawing.Size(95, 20)
        Me.txt_FechaDesde.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(347, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha Siembra (desde)"
        '
        'DataLotes
        '
        Me.DataLotes.AllowUserToAddRows = False
        Me.DataLotes.AllowUserToDeleteRows = False
        Me.DataLotes.AllowUserToResizeColumns = False
        Me.DataLotes.AllowUserToResizeRows = False
        Me.DataLotes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataLotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.lote, Me.Fsiembra, Me.FEntrega, Me.Cliente, Me.especie, Me.variedad, Me.saldoplantas})
        Me.DataLotes.Location = New System.Drawing.Point(3, 69)
        Me.DataLotes.Name = "DataLotes"
        Me.DataLotes.ReadOnly = True
        Me.DataLotes.Size = New System.Drawing.Size(983, 460)
        Me.DataLotes.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(451, 534)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lote
        '
        Me.lote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.lote.HeaderText = "Nº Lote"
        Me.lote.Name = "lote"
        Me.lote.ReadOnly = True
        Me.lote.Width = 68
        '
        'Fsiembra
        '
        Me.Fsiembra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Fsiembra.HeaderText = "Fecha Siembra"
        Me.Fsiembra.Name = "Fsiembra"
        Me.Fsiembra.ReadOnly = True
        Me.Fsiembra.Width = 95
        '
        'FEntrega
        '
        Me.FEntrega.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FEntrega.HeaderText = "Fecha Entrega"
        Me.FEntrega.Name = "FEntrega"
        Me.FEntrega.ReadOnly = True
        Me.FEntrega.Width = 94
        '
        'Cliente
        '
        Me.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        '
        'especie
        '
        Me.especie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.especie.HeaderText = "Especie"
        Me.especie.Name = "especie"
        Me.especie.ReadOnly = True
        '
        'variedad
        '
        Me.variedad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.variedad.HeaderText = "Variedad"
        Me.variedad.Name = "variedad"
        Me.variedad.ReadOnly = True
        '
        'saldoplantas
        '
        Me.saldoplantas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.saldoplantas.DefaultCellStyle = DataGridViewCellStyle4
        Me.saldoplantas.HeaderText = "Saldo Plantas"
        Me.saldoplantas.Name = "saldoplantas"
        Me.saldoplantas.ReadOnly = True
        Me.saldoplantas.Width = 89
        '
        'Button2
        '
        Me.Button2.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button2.Location = New System.Drawing.Point(590, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 31)
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Consulta_GuiasLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataLotes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_FechaDesde)
        Me.Name = "Consulta_GuiasLote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Lote sin Guía"
        CType(Me.DataLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_FechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataLotes As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fsiembra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FEntrega As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents especie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents variedad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents saldoplantas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
