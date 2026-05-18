Imports ClosedXML.Excel
Imports System.Data
Imports System.Linq

Public Class ReporteListadoPrecios

    Private _dtPrecios As DataTable
    Private _cargando As Boolean

    Private Sub ReporteListadoPrecios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _cargando = True
        Me.SP_ReporteListadoPrecioVentaTableAdapter.Connection.ConnectionString = gSOURCE
        Me.SP_ReporteListadoPrecioVentaTableAdapter.Fill(Me.GESTDataSet24.SP_ReporteListadoPrecioVenta)
        _dtPrecios = Me.GESTDataSet24.SP_ReporteListadoPrecioVenta.Copy()

        ConfiguraUI()
        CargaCombos()
        MostrarDatos()
        _cargando = False
    End Sub

    Private Sub ConfiguraUI()
        cboModoFiltro.Items.Clear()
        cboModoFiltro.Items.AddRange(New Object() {"Especie y Variedad", "Solo Especie", "Solo Variedad"})
        cboModoFiltro.SelectedIndex = 0
    End Sub

    Private Sub CargaCombos()
        cboEspecie.DisplayMember = "Text"
        cboEspecie.ValueMember = "Value"
        cboVariedad.DisplayMember = "Text"
        cboVariedad.ValueMember = "Value"

        Dim especies = _dtPrecios.DefaultView.ToTable(True, "DESCRIP")
        especies.DefaultView.Sort = "DESCRIP ASC"
        cboEspecie.DataSource = especies.DefaultView
        cboEspecie.DisplayMember = "DESCRIP"
        cboEspecie.ValueMember = "DESCRIP"
        cboEspecie.SelectedIndex = -1

        Dim variedades = _dtPrecios.DefaultView.ToTable(True, "Descripcion")
        variedades.DefaultView.Sort = "Descripcion ASC"
        cboVariedad.DataSource = variedades.DefaultView
        cboVariedad.DisplayMember = "Descripcion"
        cboVariedad.ValueMember = "Descripcion"
        cboVariedad.SelectedIndex = -1
    End Sub

    Private Sub MostrarDatos()
        If _dtPrecios Is Nothing Then
            Return
        End If

        Dim vista As New DataView(_dtPrecios)
        Dim filtros As New List(Of String)

        Dim especie = If(cboEspecie.SelectedIndex >= 0, cboEspecie.Text, String.Empty)
        Dim variedad = If(cboVariedad.SelectedIndex >= 0, cboVariedad.Text, String.Empty)

        If Not String.IsNullOrWhiteSpace(especie) AndAlso cboModoFiltro.SelectedIndex <> 2 Then
            filtros.Add($"DESCRIP = '{especie.Replace("'", "''")}'")
        End If

        If Not String.IsNullOrWhiteSpace(variedad) AndAlso cboModoFiltro.SelectedIndex <> 1 Then
            filtros.Add($"Descripcion = '{variedad.Replace("'", "''")}'")
        End If

        vista.RowFilter = String.Join(" AND ", filtros)

        Dim tabla = vista.ToTable()
        If Not tabla.Columns.Contains("Precio_Venta_Con_IVA") Then
            tabla.Columns.Add("Precio_Venta_Con_IVA", GetType(Decimal))
        End If

        For Each row As DataRow In tabla.Rows
            Dim totalNeto = If(IsDBNull(row("Total")), 0D, Convert.ToDecimal(row("Total")))
            row("Precio_Venta_Con_IVA") = Math.Round(totalNeto * 1.19D, 0)
        Next

        dgvPrecios.DataSource = tabla
        FormateaGrilla()
    End Sub

    Private Sub FormateaGrilla()
        If dgvPrecios.Columns.Contains("DESCRIP") Then dgvPrecios.Columns("DESCRIP").HeaderText = "Especie"
        If dgvPrecios.Columns.Contains("Descripcion") Then dgvPrecios.Columns("Descripcion").HeaderText = "Variedad"
        If dgvPrecios.Columns.Contains("Descripcion1") Then dgvPrecios.Columns("Descripcion1").HeaderText = "Tipo de Bandeja"
        If dgvPrecios.Columns.Contains("Precio_Hechura") Then dgvPrecios.Columns("Precio_Hechura").HeaderText = "Precio Hechura"
        If dgvPrecios.Columns.Contains("Precio_Venta_Neto") Then dgvPrecios.Columns("Precio_Venta_Neto").HeaderText = "Precio Venta Neto"
        If dgvPrecios.Columns.Contains("Precio_Venta_Con_IVA") Then dgvPrecios.Columns("Precio_Venta_Con_IVA").HeaderText = "Precio Venta Final (IVA)"
        If dgvPrecios.Columns.Contains("Total") Then dgvPrecios.Columns("Total").HeaderText = "Total"
        If dgvPrecios.Columns.Contains("DESCRIP") Then dgvPrecios.Columns("DESCRIP").DisplayIndex = 0
        If dgvPrecios.Columns.Contains("Descripcion") Then dgvPrecios.Columns("Descripcion").DisplayIndex = 1
        If dgvPrecios.Columns.Contains("Descripcion1") Then dgvPrecios.Columns("Descripcion1").DisplayIndex = 2

        For Each colName In New String() {"DESCRIP", "Descripcion", "Descripcion1"}
            If dgvPrecios.Columns.Contains(colName) Then
                dgvPrecios.Columns(colName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            End If
        Next
        For Each colName In New String() {"Precio_Hechura", "Precio_Venta_Neto", "Precio_Venta_Con_IVA", "Total"}
            If dgvPrecios.Columns.Contains(colName) Then
                dgvPrecios.Columns(colName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        Next
        dgvPrecios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub cboModoFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboModoFiltro.SelectedIndexChanged
        If _cargando Then Return
        MostrarDatos()
    End Sub

    Private Sub cboEspecie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEspecie.SelectedIndexChanged
        If _cargando Then Return
        MostrarDatos()
    End Sub

    Private Sub cboVariedad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVariedad.SelectedIndexChanged
        If _cargando Then Return
        MostrarDatos()
    End Sub

    Private Sub btnExportarExcel_Click(sender As Object, e As EventArgs) Handles btnExportarExcel.Click
        Using sfd As New SaveFileDialog()
            sfd.Filter = "Excel (*.xlsx)|*.xlsx"
            sfd.FileName = "Listado_Precios.xlsx"
            If sfd.ShowDialog() <> DialogResult.OK Then Return

            Using wb As New XLWorkbook()
                Dim ws = wb.Worksheets.Add("Listado Precios")
                Dim tablaExportacion = PrepararTablaExportacion(CType(dgvPrecios.DataSource, DataTable))
                ws.Cell(1, 1).InsertTable(tablaExportacion, True)
                wb.SaveAs(sfd.FileName)
            End Using
        End Using
    End Sub

    Private Function PrepararTablaExportacion(ByVal origen As DataTable) As DataTable
        Dim tabla As New DataTable()

        Dim columnasOrdenadas = dgvPrecios.Columns.Cast(Of DataGridViewColumn)().Where(Function(c) c.Visible).OrderBy(Function(c) c.DisplayIndex).ToList()

        For Each col In columnasOrdenadas
            If origen.Columns.Contains(col.DataPropertyName) Then
                tabla.Columns.Add(col.HeaderText, origen.Columns(col.DataPropertyName).DataType)
            End If
        Next

        For Each row As DataRow In origen.Rows
            Dim nuevaFila = tabla.NewRow()
            For Each col As DataColumn In tabla.Columns
                Dim origenCol = columnasOrdenadas.FirstOrDefault(Function(c) c.HeaderText = col.ColumnName)
                If origenCol IsNot Nothing AndAlso origen.Columns.Contains(origenCol.DataPropertyName) Then
                    nuevaFila(col.ColumnName) = row(origenCol.DataPropertyName)
                End If
            Next
            tabla.Rows.Add(nuevaFila)
        Next

        Return tabla
    End Function
End Class
