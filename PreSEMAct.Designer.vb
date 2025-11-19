<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreSEMAct
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtValorAdicNoSemilla = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.txtfactordetalle = New System.Windows.Forms.TextBox()
        Me.txtfactorintermedio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHoraActualizacion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUltimaActualizacion = New System.Windows.Forms.TextBox()
        Me.txt_MargenPCT = New System.Windows.Forms.TextBox()
        Me.txt_Germinacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_PrecioCompraSemilla = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_PVentaFinal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_PCostoNeto = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_Variedad = New System.Windows.Forms.ComboBox()
        Me.cmb_Familia = New System.Windows.Forms.ComboBox()
        Me.GrillaPrecios = New System.Windows.Forms.DataGridView()
        Me.DESCRIPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioCostoNetoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCTGerminacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioNetoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MargenPorcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVentaNetoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FactorInterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FactorDetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorAdicNoSemillaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaActDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraActDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SPConsultaPreSEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GESTDataSet30 = New GestionVivero.GESTDataSet30()
        Me.SP_ConsultaPreSETableAdapter = New GestionVivero.GESTDataSet30TableAdapters.SP_ConsultaPreSETableAdapter()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.GrillaPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPConsultaPreSEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GESTDataSet30, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtValorAdicNoSemilla)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.StatusStrip1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtfactordetalle)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtfactorintermedio)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtHoraActualizacion)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtUltimaActualizacion)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_MargenPCT)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Germinacion)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_PrecioCompraSemilla)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_PVentaFinal)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_PCostoNeto)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label23)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmb_Variedad)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmb_Familia)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GrillaPrecios)
        Me.SplitContainer1.Size = New System.Drawing.Size(984, 562)
        Me.SplitContainer1.SplitterDistance = 239
        Me.SplitContainer1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Image = Global.GestionVivero.My.Resources.Resources.Apply
        Me.Button1.Location = New System.Drawing.Point(940, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 32)
        Me.Button1.TabIndex = 122
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtValorAdicNoSemilla
        '
        Me.txtValorAdicNoSemilla.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValorAdicNoSemilla.Location = New System.Drawing.Point(764, 141)
        Me.txtValorAdicNoSemilla.Name = "txtValorAdicNoSemilla"
        Me.txtValorAdicNoSemilla.Size = New System.Drawing.Size(71, 20)
        Me.txtValorAdicNoSemilla.TabIndex = 118
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(615, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 13)
        Me.Label10.TabIndex = 117
        Me.Label10.Text = "Precio adicional sin semilla"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripDropDownButton2, Me.ToolStripDropDownButton3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 217)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(984, 22)
        Me.StatusStrip1.TabIndex = 116
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.Image = Global.GestionVivero.My.Resources.Resources.Notes
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton2.Image = Global.GestionVivero.My.Resources.Resources.Add
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripDropDownButton2.Text = "ToolStripDropDownButton2"
        '
        'ToolStripDropDownButton3
        '
        Me.ToolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton3.Image = Global.GestionVivero.My.Resources.Resources.Delete
        Me.ToolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton3.Name = "ToolStripDropDownButton3"
        Me.ToolStripDropDownButton3.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripDropDownButton3.Text = "ToolStripDropDownButton3"
        '
        'txtfactordetalle
        '
        Me.txtfactordetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtfactordetalle.Location = New System.Drawing.Point(367, 141)
        Me.txtfactordetalle.Name = "txtfactordetalle"
        Me.txtfactordetalle.Size = New System.Drawing.Size(71, 20)
        Me.txtfactordetalle.TabIndex = 115
        '
        'txtfactorintermedio
        '
        Me.txtfactorintermedio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtfactorintermedio.Location = New System.Drawing.Point(367, 106)
        Me.txtfactorintermedio.Name = "txtfactorintermedio"
        Me.txtfactorintermedio.Size = New System.Drawing.Size(71, 20)
        Me.txtfactorintermedio.TabIndex = 114
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(290, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 113
        Me.Label5.Text = "Factor detalle"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(273, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 112
        Me.Label8.Text = "Factor intermedio"
        '
        'txtHoraActualizacion
        '
        Me.txtHoraActualizacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtHoraActualizacion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraActualizacion.Location = New System.Drawing.Point(197, 190)
        Me.txtHoraActualizacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHoraActualizacion.Name = "txtHoraActualizacion"
        Me.txtHoraActualizacion.ReadOnly = True
        Me.txtHoraActualizacion.Size = New System.Drawing.Size(71, 22)
        Me.txtHoraActualizacion.TabIndex = 80
        Me.txtHoraActualizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 13)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Ultima actualización"
        '
        'txtUltimaActualizacion
        '
        Me.txtUltimaActualizacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtUltimaActualizacion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUltimaActualizacion.Location = New System.Drawing.Point(115, 190)
        Me.txtUltimaActualizacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUltimaActualizacion.Name = "txtUltimaActualizacion"
        Me.txtUltimaActualizacion.ReadOnly = True
        Me.txtUltimaActualizacion.Size = New System.Drawing.Size(71, 22)
        Me.txtUltimaActualizacion.TabIndex = 78
        Me.txtUltimaActualizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_MargenPCT
        '
        Me.txt_MargenPCT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_MargenPCT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MargenPCT.Location = New System.Drawing.Point(764, 39)
        Me.txt_MargenPCT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_MargenPCT.Name = "txt_MargenPCT"
        Me.txt_MargenPCT.Size = New System.Drawing.Size(71, 22)
        Me.txt_MargenPCT.TabIndex = 77
        Me.txt_MargenPCT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Germinacion
        '
        Me.txt_Germinacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_Germinacion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Germinacion.Location = New System.Drawing.Point(367, 39)
        Me.txt_Germinacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Germinacion.Name = "txt_Germinacion"
        Me.txt_Germinacion.Size = New System.Drawing.Size(71, 22)
        Me.txt_Germinacion.TabIndex = 76
        Me.txt_Germinacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(284, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "% Rendimiento"
        '
        'txt_PrecioCompraSemilla
        '
        Me.txt_PrecioCompraSemilla.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_PrecioCompraSemilla.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PrecioCompraSemilla.Location = New System.Drawing.Point(177, 39)
        Me.txt_PrecioCompraSemilla.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_PrecioCompraSemilla.Name = "txt_PrecioCompraSemilla"
        Me.txt_PrecioCompraSemilla.Size = New System.Drawing.Size(71, 22)
        Me.txt_PrecioCompraSemilla.TabIndex = 74
        Me.txt_PrecioCompraSemilla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 13)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Precio Compra/Lista Producto"
        '
        'txt_PVentaFinal
        '
        Me.txt_PVentaFinal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_PVentaFinal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PVentaFinal.Location = New System.Drawing.Point(367, 72)
        Me.txt_PVentaFinal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_PVentaFinal.Name = "txt_PVentaFinal"
        Me.txt_PVentaFinal.ReadOnly = True
        Me.txt_PVentaFinal.Size = New System.Drawing.Size(71, 22)
        Me.txt_PVentaFinal.TabIndex = 72
        Me.txt_PVentaFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(267, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Precio Venta Neto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(655, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "% Margen Utilidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(463, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Precio Costo Neto"
        '
        'txt_PCostoNeto
        '
        Me.txt_PCostoNeto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_PCostoNeto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PCostoNeto.Location = New System.Drawing.Point(562, 39)
        Me.txt_PCostoNeto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_PCostoNeto.Name = "txt_PCostoNeto"
        Me.txt_PCostoNeto.ReadOnly = True
        Me.txt_PCostoNeto.Size = New System.Drawing.Size(71, 22)
        Me.txt_PCostoNeto.TabIndex = 68
        Me.txt_PCostoNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(440, 12)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(49, 13)
        Me.Label23.TabIndex = 57
        Me.Label23.Text = "Variedad"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Especie"
        '
        'cmb_Variedad
        '
        Me.cmb_Variedad.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_Variedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Variedad.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Variedad.ForeColor = System.Drawing.Color.White
        Me.cmb_Variedad.FormattingEnabled = True
        Me.cmb_Variedad.Location = New System.Drawing.Point(497, 7)
        Me.cmb_Variedad.Name = "cmb_Variedad"
        Me.cmb_Variedad.Size = New System.Drawing.Size(313, 23)
        Me.cmb_Variedad.TabIndex = 56
        '
        'cmb_Familia
        '
        Me.cmb_Familia.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_Familia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Familia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Familia.ForeColor = System.Drawing.Color.White
        Me.cmb_Familia.FormattingEnabled = True
        Me.cmb_Familia.Location = New System.Drawing.Point(73, 7)
        Me.cmb_Familia.Name = "cmb_Familia"
        Me.cmb_Familia.Size = New System.Drawing.Size(313, 23)
        Me.cmb_Familia.TabIndex = 55
        '
        'GrillaPrecios
        '
        Me.GrillaPrecios.AllowUserToAddRows = False
        Me.GrillaPrecios.AllowUserToDeleteRows = False
        Me.GrillaPrecios.AutoGenerateColumns = False
        Me.GrillaPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaPrecios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DESCRIPDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.PrecioCostoNetoDataGridViewTextBoxColumn, Me.PCTGerminacionDataGridViewTextBoxColumn, Me.PrecioNetoDataGridViewTextBoxColumn, Me.MargenPorcDataGridViewTextBoxColumn, Me.PrecioVentaNetoDataGridViewTextBoxColumn, Me.FactorInterDataGridViewTextBoxColumn, Me.FactorDetalleDataGridViewTextBoxColumn, Me.ValorAdicNoSemillaDataGridViewTextBoxColumn, Me.FechaActDataGridViewTextBoxColumn, Me.HoraActDataGridViewTextBoxColumn})
        Me.GrillaPrecios.DataSource = Me.SPConsultaPreSEBindingSource
        Me.GrillaPrecios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaPrecios.Location = New System.Drawing.Point(0, 0)
        Me.GrillaPrecios.Name = "GrillaPrecios"
        Me.GrillaPrecios.ReadOnly = True
        Me.GrillaPrecios.Size = New System.Drawing.Size(984, 319)
        Me.GrillaPrecios.TabIndex = 0
        '
        'DESCRIPDataGridViewTextBoxColumn
        '
        Me.DESCRIPDataGridViewTextBoxColumn.DataPropertyName = "DESCRIP"
        Me.DESCRIPDataGridViewTextBoxColumn.HeaderText = "Especie"
        Me.DESCRIPDataGridViewTextBoxColumn.Name = "DESCRIPDataGridViewTextBoxColumn"
        Me.DESCRIPDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Variedad"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioCostoNetoDataGridViewTextBoxColumn
        '
        Me.PrecioCostoNetoDataGridViewTextBoxColumn.DataPropertyName = "Precio_Costo_Neto"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.PrecioCostoNetoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.PrecioCostoNetoDataGridViewTextBoxColumn.HeaderText = "Costo Neto"
        Me.PrecioCostoNetoDataGridViewTextBoxColumn.Name = "PrecioCostoNetoDataGridViewTextBoxColumn"
        Me.PrecioCostoNetoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PCTGerminacionDataGridViewTextBoxColumn
        '
        Me.PCTGerminacionDataGridViewTextBoxColumn.DataPropertyName = "PCT_Germinacion"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.PCTGerminacionDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.PCTGerminacionDataGridViewTextBoxColumn.HeaderText = "% Germinación"
        Me.PCTGerminacionDataGridViewTextBoxColumn.Name = "PCTGerminacionDataGridViewTextBoxColumn"
        Me.PCTGerminacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioNetoDataGridViewTextBoxColumn
        '
        Me.PrecioNetoDataGridViewTextBoxColumn.DataPropertyName = "Precio_Neto"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.PrecioNetoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.PrecioNetoDataGridViewTextBoxColumn.HeaderText = "Costo Neto Final"
        Me.PrecioNetoDataGridViewTextBoxColumn.Name = "PrecioNetoDataGridViewTextBoxColumn"
        Me.PrecioNetoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MargenPorcDataGridViewTextBoxColumn
        '
        Me.MargenPorcDataGridViewTextBoxColumn.DataPropertyName = "Margen_Porc"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.MargenPorcDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.MargenPorcDataGridViewTextBoxColumn.HeaderText = "% Margen"
        Me.MargenPorcDataGridViewTextBoxColumn.Name = "MargenPorcDataGridViewTextBoxColumn"
        Me.MargenPorcDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioVentaNetoDataGridViewTextBoxColumn
        '
        Me.PrecioVentaNetoDataGridViewTextBoxColumn.DataPropertyName = "Precio_Venta_Neto"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.PrecioVentaNetoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.PrecioVentaNetoDataGridViewTextBoxColumn.HeaderText = "Precio Venta"
        Me.PrecioVentaNetoDataGridViewTextBoxColumn.Name = "PrecioVentaNetoDataGridViewTextBoxColumn"
        Me.PrecioVentaNetoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FactorInterDataGridViewTextBoxColumn
        '
        Me.FactorInterDataGridViewTextBoxColumn.DataPropertyName = "FactorInter"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.FactorInterDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.FactorInterDataGridViewTextBoxColumn.HeaderText = "Factor intermedio"
        Me.FactorInterDataGridViewTextBoxColumn.Name = "FactorInterDataGridViewTextBoxColumn"
        Me.FactorInterDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FactorDetalleDataGridViewTextBoxColumn
        '
        Me.FactorDetalleDataGridViewTextBoxColumn.DataPropertyName = "FactorDetalle"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.FactorDetalleDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.FactorDetalleDataGridViewTextBoxColumn.HeaderText = "Factor detalle"
        Me.FactorDetalleDataGridViewTextBoxColumn.Name = "FactorDetalleDataGridViewTextBoxColumn"
        Me.FactorDetalleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValorAdicNoSemillaDataGridViewTextBoxColumn
        '
        Me.ValorAdicNoSemillaDataGridViewTextBoxColumn.DataPropertyName = "ValorAdicNoSemilla"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.ValorAdicNoSemillaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.ValorAdicNoSemillaDataGridViewTextBoxColumn.HeaderText = "Valor adicional sin semilla"
        Me.ValorAdicNoSemillaDataGridViewTextBoxColumn.Name = "ValorAdicNoSemillaDataGridViewTextBoxColumn"
        Me.ValorAdicNoSemillaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaActDataGridViewTextBoxColumn
        '
        Me.FechaActDataGridViewTextBoxColumn.DataPropertyName = "FechaAct"
        DataGridViewCellStyle9.Format = "d"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.FechaActDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.FechaActDataGridViewTextBoxColumn.HeaderText = "fecha último cambio"
        Me.FechaActDataGridViewTextBoxColumn.Name = "FechaActDataGridViewTextBoxColumn"
        Me.FechaActDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HoraActDataGridViewTextBoxColumn
        '
        Me.HoraActDataGridViewTextBoxColumn.DataPropertyName = "HoraAct"
        DataGridViewCellStyle10.Format = "T"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.HoraActDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.HoraActDataGridViewTextBoxColumn.HeaderText = "Hora último cambio"
        Me.HoraActDataGridViewTextBoxColumn.Name = "HoraActDataGridViewTextBoxColumn"
        Me.HoraActDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SPConsultaPreSEBindingSource
        '
        Me.SPConsultaPreSEBindingSource.DataMember = "SP_ConsultaPreSE"
        Me.SPConsultaPreSEBindingSource.DataSource = Me.GESTDataSet30
        '
        'GESTDataSet30
        '
        Me.GESTDataSet30.DataSetName = "GESTDataSet30"
        Me.GESTDataSet30.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_ConsultaPreSETableAdapter
        '
        Me.SP_ConsultaPreSETableAdapter.ClearBeforeFill = True
        '
        'PreSEMAct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 562)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PreSEMAct"
        Me.Text = "PreSEMAct"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.GrillaPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPConsultaPreSEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GESTDataSet30, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmb_Variedad As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Familia As System.Windows.Forms.ComboBox
    Friend WithEvents txt_MargenPCT As System.Windows.Forms.TextBox
    Friend WithEvents txt_Germinacion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_PrecioCompraSemilla As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_PVentaFinal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_PCostoNeto As System.Windows.Forms.TextBox
    Friend WithEvents txtHoraActualizacion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtUltimaActualizacion As System.Windows.Forms.TextBox
    Friend WithEvents txtfactordetalle As System.Windows.Forms.TextBox
    Friend WithEvents txtfactorintermedio As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents GrillaPrecios As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripDropDownButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripDropDownButton3 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents txtValorAdicNoSemilla As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GESTDataSet30 As GestionVivero.GESTDataSet30
    Friend WithEvents SPConsultaPreSEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SP_ConsultaPreSETableAdapter As GestionVivero.GESTDataSet30TableAdapters.SP_ConsultaPreSETableAdapter
    Friend WithEvents DESCRIPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioCostoNetoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PCTGerminacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioNetoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MargenPorcDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioVentaNetoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FactorInterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FactorDetalleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorAdicNoSemillaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaActDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HoraActDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
