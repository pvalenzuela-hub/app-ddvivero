Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports ClosedXML.Excel

' Registro de una aplicación de producto sobre varios lotes a la vez.
' Cada aplicación queda vinculada a todos los lotes seleccionados (APLICACION / APLICACION_LOTE).
Public Class AplicacionProductos

    Private Class LoteAplicacion
        Public IdPedidodet As Integer
        Public Cultivo As String
        Public Variedad As String
        Public Nave As String
        Public Mesa As String
        Public Bandejas As Integer
        Public Alveolos As Integer
        Public Plantas As Integer
        Public Estado As String
    End Class

    Private Const TODOS As String = "(Todos)"

    Private ReadOnly _lotes As New List(Of LoteAplicacion)
    Private ReadOnly _seleccion As New HashSet(Of Integer)
    Private _historial As DataTable
    Private _cargando As Boolean
    Private _historialCargado As Boolean

    Private Sub AplicacionProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _cargando = True
        Try
            dtpFecha.Value = Now
            dtpHora.Value = Now
            dtpDesde.Value = Today.AddMonths(-1)
            dtpHasta.Value = Today
            gridHistorial.AutoGenerateColumns = False
            hFecha.DefaultCellStyle.Format = "dd-MM-yyyy HH:mm"
            hPlantas.DefaultCellStyle.Format = "#,##0"
            colSel.ReadOnly = True

            CargarCombo(cmbAplicador, "SP_CONSULTA_FULL_VENDEDOR", "NOMBRE", "IdVendedor")
            CargarCombo(cmbTipo, "SP_APLICACION_TIPOS", "Descripcion", "idTipoInsumo")
            CargarCombo(cmbProducto, "SP_APLICACION_PRODUCTOS", "Descripcion", "IdInsumo")

            Dim unidades = CargarTabla("SP_APLICACION_UNIDADES")
            unidades.Columns.Add("Nombre", GetType(String))
            For Each fila As DataRow In unidades.Rows
                fila("Nombre") = NombreUnidad(fila("Descripcion").ToString())
            Next
            cmbUnidad.DisplayMember = "Nombre"
            cmbUnidad.ValueMember = "IdUnidad"
            cmbUnidad.DataSource = unidades

            Dim formas As New DataTable()
            formas.Columns.Add("Codigo", GetType(String))
            formas.Columns.Add("Nombre", GetType(String))
            formas.Rows.Add("L", "Dosis por litro de agua")
            formas.Rows.Add("C", "Dosis por 100 L de agua")
            formas.Rows.Add("T", "Cantidad total de producto")
            formas.Rows.Add("H", "Dosis por hectárea")
            cmbForma.DisplayMember = "Nombre"
            cmbForma.ValueMember = "Codigo"
            cmbForma.DataSource = formas

            cmbAplicador.SelectedIndex = -1
            cmbTipo.SelectedIndex = -1
            cmbProducto.SelectedIndex = -1
            cmbProducto.Text = ""

            CargarLotes()
        Catch ex As Exception
            MsgBox("No se pudo cargar el formulario de aplicaciones:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Aplicación de Productos")
        Finally
            _cargando = False
        End Try

        MostrarLotes()
        Calcular()
    End Sub

#Region "Carga de datos"

    Private Function CargarTabla(ByVal procedimiento As String) As DataTable
        open()
        Try
            Using cmd As SqlCommand = connection.CreateCommand()
                cmd.CommandText = procedimiento
                cmd.CommandType = CommandType.StoredProcedure
                Using adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        Finally
            close_conexion()
        End Try
    End Function

    Private Sub CargarCombo(ByVal cmb As ComboBox, ByVal procedimiento As String, ByVal texto As String, ByVal valor As String)
        cmb.DisplayMember = texto
        cmb.ValueMember = valor
        cmb.DataSource = CargarTabla(procedimiento)
    End Sub

    Private Sub CargarLotes()
        _lotes.Clear()
        For Each fila As DataRow In CargarTabla("SP_APLICACION_LOTES_ACTIVOS").Rows
            _lotes.Add(New LoteAplicacion With {
                .IdPedidodet = Convert.ToInt32(fila("IdPedidodet")),
                .Cultivo = fila("Cultivo").ToString().Trim(),
                .Variedad = fila("Variedad").ToString().Trim(),
                .Nave = fila("Nave").ToString().Trim().ToUpper(),
                .Mesa = NormalizarMesa(fila("Mesa").ToString()),
                .Bandejas = Convert.ToInt32(fila("Bandejas")),
                .Alveolos = Convert.ToInt32(fila("Alveolos")),
                .Plantas = Convert.ToInt32(fila("Plantas")),
                .Estado = fila("Estado").ToString().Trim()
            })
        Next

        ' Un lote seleccionado que ya no está en vivero sale de la selección.
        _seleccion.IntersectWith(_lotes.Select(Function(l) l.IdPedidodet))

        LlenarFiltro(cmbNave, _lotes.Select(Function(l) l.Nave))
        LlenarFiltro(cmbMesa, _lotes.Select(Function(l) l.Mesa))
        LlenarFiltro(cmbCultivo, _lotes.Select(Function(l) l.Cultivo))
    End Sub

    Private Sub LlenarFiltro(ByVal cmb As ComboBox, ByVal valores As IEnumerable(Of String))
        Dim actual As String = If(cmb.SelectedItem, TODOS).ToString()
        cmb.Items.Clear()
        cmb.Items.Add(TODOS)
        For Each v In valores.Where(Function(x) x <> "").Distinct().OrderBy(Function(x) ClaveOrden(x))
            cmb.Items.Add(v)
        Next
        cmb.SelectedItem = If(cmb.Items.Contains(actual), actual, TODOS)
    End Sub

    ' Ordena "M2" antes que "M10" y las naves numéricas antes que las de texto.
    Private Shared Function ClaveOrden(ByVal valor As String) As String
        Dim m = Regex.Match(valor, "^([^\d]*)(\d+)$")
        If m.Success Then
            Return m.Groups(1).Value & m.Groups(2).Value.PadLeft(6, "0"c)
        End If
        Return "~" & valor
    End Function

    ' Las mesas están escritas de distintas formas ("M02", "M2", "m 2"); se agrupan como "M2".
    Private Shared Function NormalizarMesa(ByVal mesa As String) As String
        Dim texto = mesa.Trim().ToUpper()
        Dim m = Regex.Match(texto, "^([A-Z]*)\s*0*(\d+)$")
        If m.Success Then
            Return m.Groups(1).Value & m.Groups(2).Value
        End If
        Return texto
    End Function

    Friend Shared Function NombreUnidad(ByVal descripcion As String) As String
        Select Case descripcion.Trim().ToUpper()
            Case "CC" : Return "mL"
            Case "GR" : Return "g"
            Case "LT" : Return "L"
            Case "KG" : Return "kg"
            Case Else : Return descripcion.Trim()
        End Select
    End Function

#End Region

#Region "Selección de lotes"

    Private Function LotesVisibles() As List(Of LoteAplicacion)
        Dim texto = txtBuscar.Text.Trim().ToLower()
        Dim nave = If(cmbNave.SelectedItem, TODOS).ToString()
        Dim mesa = If(cmbMesa.SelectedItem, TODOS).ToString()
        Dim cultivo = If(cmbCultivo.SelectedItem, TODOS).ToString()

        Return _lotes.Where(Function(l) (texto = "" OrElse (l.IdPedidodet.ToString() & " " & l.Cultivo & " " & l.Variedad).ToLower().Contains(texto)) _
                                AndAlso (nave = TODOS OrElse l.Nave = nave) _
                                AndAlso (mesa = TODOS OrElse l.Mesa = mesa) _
                                AndAlso (cultivo = TODOS OrElse l.Cultivo = cultivo)).ToList()
    End Function

    Private Sub MostrarLotes()
        If _cargando Then Exit Sub

        Dim visibles = LotesVisibles()
        gridLotes.SuspendLayout()
        gridLotes.Rows.Clear()
        For Each l In visibles
            Dim i = gridLotes.Rows.Add(_seleccion.Contains(l.IdPedidodet), l.IdPedidodet, (l.Cultivo & " " & l.Variedad).Trim(),
                                       l.Nave, l.Mesa, l.Bandejas, l.Alveolos, l.Plantas.ToString("#,##0"), l.Estado)
            gridLotes.Rows(i).Tag = l.IdPedidodet
            PintarFila(gridLotes.Rows(i))
        Next
        gridLotes.ResumeLayout()

        lblSeleccion.Text = _seleccion.Count & " seleccionados · " & visibles.Count & " visibles"
        ActualizarResumen()
    End Sub

    Private Sub PintarFila(ByVal fila As DataGridViewRow)
        fila.DefaultCellStyle.BackColor = If(_seleccion.Contains(CInt(fila.Tag)), Color.FromArgb(239, 247, 232), Color.White)
    End Sub

    Private Sub gridLotes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridLotes.CellClick
        If e.RowIndex < 0 OrElse e.ColumnIndex <> colSel.Index Then Exit Sub

        Dim fila = gridLotes.Rows(e.RowIndex)
        Dim id = CInt(fila.Tag)
        If Not _seleccion.Remove(id) Then _seleccion.Add(id)
        fila.Cells(colSel.Index).Value = _seleccion.Contains(id)
        PintarFila(fila)

        lblSeleccion.Text = _seleccion.Count & " seleccionados · " & gridLotes.Rows.Count & " visibles"
        ActualizarResumen()
    End Sub

    Private Sub btnSeleccionarResultados_Click(sender As Object, e As EventArgs) Handles btnSeleccionarResultados.Click
        _seleccion.UnionWith(LotesVisibles().Select(Function(l) l.IdPedidodet))
        MostrarLotes()
    End Sub

    Private Sub btnQuitarSeleccion_Click(sender As Object, e As EventArgs) Handles btnQuitarSeleccion.Click
        _seleccion.Clear()
        MostrarLotes()
    End Sub

    Private Sub Filtros_Changed(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged, cmbNave.SelectedIndexChanged, cmbMesa.SelectedIndexChanged, cmbCultivo.SelectedIndexChanged
        MostrarLotes()
    End Sub

#End Region

#Region "Cálculo de mezcla"

    Private Function FormaDosis() As String
        Return If(cmbForma.SelectedValue, "L").ToString()
    End Function

    Private Function Unidad() As String
        Return If(cmbUnidad.SelectedIndex >= 0, cmbUnidad.Text, "")
    End Function

    ' Acepta coma o punto como separador decimal.
    Private Shared Function LeerNumero(ByVal texto As String) As Double
        Dim valor As Double
        If Double.TryParse(texto.Trim().Replace(",", "."), NumberStyles.Float, CultureInfo.InvariantCulture, valor) Then
            Return valor
        End If
        Return 0
    End Function

    Private Shared Function Fmt(ByVal valor As Double) As String
        Return valor.ToString("#,##0.####", CultureInfo.CurrentCulture)
    End Function

    ' Misma fórmula que SP_APLICACION_GRABAR.
    Private Shared Function CalcularProductoTotal(ByVal forma As String, ByVal litros As Double, ByVal dosis As Double, ByVal superficieM2 As Double) As Double
        Select Case forma
            Case "C" : Return litros * dosis / 100
            Case "T" : Return dosis
            Case "H" : Return superficieM2 * dosis / 10000
            Case Else : Return litros * dosis
        End Select
    End Function

    Friend Shared Function SufijoDosis(ByVal forma As String) As String
        Select Case forma
            Case "C" : Return "/100 L"
            Case "T" : Return " en total"
            Case "H" : Return "/ha"
            Case Else : Return "/L"
        End Select
    End Function

    Private Sub Calcular()
        If _cargando Then Exit Sub

        If chkTodaMezcla.Checked Then txtLitrosUtilizados.Text = txtLitrosPreparados.Text
        txtLitrosUtilizados.Enabled = Not chkTodaMezcla.Checked

        Dim forma = FormaDosis()
        Dim u = Unidad()
        lblSuperficie.Visible = (forma = "H")
        txtSuperficie.Visible = (forma = "H")
        lblDosis.Text = If(forma = "T", "Total de producto (" & u & ")", "Dosis (" & u & SufijoDosis(forma) & ")")

        Dim litros = LeerNumero(txtLitrosPreparados.Text)
        Dim dosis = LeerNumero(txtDosis.Text)
        Dim superficie = LeerNumero(txtSuperficie.Text)
        Dim utilizados = LeerNumero(txtLitrosUtilizados.Text)
        Dim ok = litros > 0 AndAlso dosis > 0 AndAlso (forma <> "H" OrElse superficie > 0)
        Dim total = CalcularProductoTotal(forma, litros, dosis, superficie)

        lblTotal.Text = If(ok, Fmt(total) & " " & u, "—")
        lblEquiv.Text = If(ok, Fmt(total / litros) & " " & u & "/L", "—")
        lblSobrante.Text = If(litros > 0 AndAlso txtLitrosUtilizados.Text.Trim() <> "" AndAlso litros - utilizados >= 0, Fmt(litros - utilizados) & " L", "—")
        lblUtilizado.Text = If(ok AndAlso utilizados > 0 AndAlso utilizados <= litros, Fmt(total * utilizados / litros) & " " & u, "—")

        ActualizarResumen()
    End Sub

    Private Sub Mezcla_Changed(sender As Object, e As EventArgs) Handles txtLitrosPreparados.TextChanged, txtDosis.TextChanged, txtSuperficie.TextChanged, txtLitrosUtilizados.TextChanged, chkTodaMezcla.CheckedChanged, cmbForma.SelectedIndexChanged, cmbUnidad.SelectedIndexChanged
        Calcular()
    End Sub

    Private Sub cmbProducto_TextChanged(sender As Object, e As EventArgs) Handles cmbProducto.TextChanged, cmbProducto.SelectedIndexChanged
        If Not _cargando Then ActualizarResumen()
    End Sub

    Private Sub ActualizarResumen()
        Dim elegidos = _lotes.Where(Function(l) _seleccion.Contains(l.IdPedidodet)).ToList()
        lblCantLotes.Text = elegidos.Count.ToString()
        lblBandejas.Text = elegidos.Sum(Function(l) l.Bandejas).ToString("#,##0")
        lblPlantas.Text = elegidos.Sum(Function(l) l.Plantas).ToString("#,##0")
        lblResProducto.Text = If(cmbProducto.Text.Trim() = "", "Sin indicar", cmbProducto.Text.Trim())
        lblResTotal.Text = lblTotal.Text
        Dim utilizados = LeerNumero(txtLitrosUtilizados.Text)
        lblResLitros.Text = If(utilizados > 0, Fmt(utilizados) & " L", "—")
    End Sub

#End Region

#Region "Revisión y grabación"

    Private Function FechaAplicacion() As DateTime
        Dim hora = dtpHora.Value
        Return dtpFecha.Value.Date.AddHours(hora.Hour).AddMinutes(hora.Minute)
    End Function

    Private Function Validar() As List(Of String)
        Dim errores As New List(Of String)
        Dim litros = LeerNumero(txtLitrosPreparados.Text)
        Dim dosis = LeerNumero(txtDosis.Text)
        Dim utilizados = LeerNumero(txtLitrosUtilizados.Text)

        If FechaAplicacion() > Now.AddMinutes(5) Then errores.Add("La fecha y hora no pueden ser futuras.")
        If cmbAplicador.SelectedIndex < 0 Then errores.Add("Selecciona el aplicador.")
        If cmbTipo.SelectedIndex < 0 Then errores.Add("Selecciona el tipo de aplicación.")
        If cmbProducto.SelectedIndex < 0 OrElse cmbProducto.SelectedValue Is Nothing Then errores.Add("Selecciona el producto desde la lista.")
        If cmbUnidad.SelectedIndex < 0 Then errores.Add("Selecciona la unidad del producto.")
        If _seleccion.Count = 0 Then errores.Add("Selecciona al menos un lote.")
        If litros <= 0 OrElse dosis <= 0 OrElse (FormaDosis() = "H" AndAlso LeerNumero(txtSuperficie.Text) <= 0) Then
            errores.Add("Ingresa cantidades positivas para calcular la mezcla.")
        End If
        If utilizados <= 0 OrElse utilizados > litros Then
            errores.Add("Los litros utilizados deben ser mayores que cero y no superar los litros preparados.")
        End If

        Return errores
    End Function

    Private Sub btnRevisar_Click(sender As Object, e As EventArgs) Handles btnRevisar.Click
        Dim errores = Validar()
        lblErrores.Text = String.Join(vbCrLf, errores.Select(Function(x) "• " & x))
        If errores.Count > 0 Then Exit Sub

        If ConfirmarAplicacion(TextoConfirmacion()) Then
            Grabar()
        End If
    End Sub

    Private Function TextoConfirmacion() As String
        Dim forma = FormaDosis()
        Dim u = Unidad()
        Dim litros = LeerNumero(txtLitrosPreparados.Text)
        Dim utilizados = LeerNumero(txtLitrosUtilizados.Text)
        Dim total = CalcularProductoTotal(forma, litros, LeerNumero(txtDosis.Text), LeerNumero(txtSuperficie.Text))
        Dim elegidos = _lotes.Where(Function(l) _seleccion.Contains(l.IdPedidodet)).OrderBy(Function(l) l.IdPedidodet).ToList()

        Dim sb As New System.Text.StringBuilder()
        sb.AppendLine(cmbProducto.Text & " · " & cmbTipo.Text)
        sb.AppendLine(FechaAplicacion().ToString("dd-MM-yyyy HH:mm") & " · " & cmbAplicador.Text)
        sb.AppendLine()
        sb.AppendLine("Producto total: " & Fmt(total) & " " & u)
        sb.AppendLine("Dosis ingresada: " & txtDosis.Text.Trim() & " " & u & SufijoDosis(forma) &
                      If(forma = "H", " · Superficie: " & txtSuperficie.Text.Trim() & " m²", ""))
        sb.AppendLine("Litros preparados: " & Fmt(litros) & " L · Litros utilizados: " & Fmt(utilizados) & " L · Sobrante: " & Fmt(litros - utilizados) & " L")
        sb.AppendLine("Producto utilizado estimado: " & Fmt(total * utilizados / litros) & " " & u)
        sb.AppendLine()
        sb.AppendLine("Lotes: " & elegidos.Count & " · Bandejas: " & elegidos.Sum(Function(l) l.Bandejas).ToString("#,##0") &
                      " · Plantas: " & elegidos.Sum(Function(l) l.Plantas).ToString("#,##0"))
        sb.AppendLine(String.Join(", ", elegidos.Select(Function(l) l.IdPedidodet & " (" & (l.Cultivo & " " & l.Variedad).Trim() & ")")))
        If txtMotivo.Text.Trim() <> "" Then sb.AppendLine().AppendLine("Motivo: " & txtMotivo.Text.Trim())
        If txtObservaciones.Text.Trim() <> "" Then sb.AppendLine().AppendLine("Observaciones: " & txtObservaciones.Text.Trim())
        Return sb.ToString()
    End Function

    Private Function ConfirmarAplicacion(ByVal texto As String) As Boolean
        Using frm As New Form()
            frm.Text = "Confirmar aplicación conjunta"
            frm.Font = Me.Font
            frm.FormBorderStyle = FormBorderStyle.FixedDialog
            frm.StartPosition = FormStartPosition.CenterParent
            frm.MinimizeBox = False
            frm.MaximizeBox = False
            frm.ClientSize = New Size(640, 460)

            Dim txt As New TextBox With {
                .Multiline = True, .ReadOnly = True, .BackColor = Color.White,
                .ScrollBars = ScrollBars.Vertical, .Text = texto,
                .Location = New Point(12, 12), .Size = New Size(616, 390)
            }
            Dim btnVolver As New Button With {
                .Text = "Volver y corregir", .DialogResult = DialogResult.Cancel,
                .Location = New Point(318, 414), .Size = New Size(150, 32)
            }
            Dim btnGuardar As New Button With {
                .Text = "Guardar aplicación", .DialogResult = DialogResult.OK,
                .Location = New Point(478, 414), .Size = New Size(150, 32),
                .BackColor = btnRevisar.BackColor, .ForeColor = Color.White, .FlatStyle = FlatStyle.Flat
            }
            frm.Controls.AddRange(New Control() {txt, btnVolver, btnGuardar})
            frm.AcceptButton = btnGuardar
            frm.CancelButton = btnVolver
            txt.SelectionStart = 0

            Return frm.ShowDialog(Me) = DialogResult.OK
        End Using
    End Function

    Private Sub Grabar()
        Dim lotes As New DataTable()
        lotes.Columns.Add("IdPedidodet", GetType(Integer))
        For Each id In _seleccion
            lotes.Rows.Add(id)
        Next

        Dim forma = FormaDosis()
        Dim idAplicacion As Integer

        Try
            open()
            Using cmd As SqlCommand = connection.CreateCommand()
                cmd.CommandText = "SP_APLICACION_GRABAR"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@FechaAplicacion", SqlDbType.DateTime).Value = FechaAplicacion()
                cmd.Parameters.Add("@IdAplicador", SqlDbType.Int).Value = cmbAplicador.SelectedValue
                cmd.Parameters.Add("@IdTipoInsumo", SqlDbType.Int).Value = cmbTipo.SelectedValue
                cmd.Parameters.Add("@IdInsumo", SqlDbType.Int).Value = cmbProducto.SelectedValue
                cmd.Parameters.Add("@Motivo", SqlDbType.VarChar, 200).Value = txtMotivo.Text.Trim()
                cmd.Parameters.Add("@FormaDosis", SqlDbType.Char, 1).Value = forma
                cmd.Parameters.Add("@IdUnidad", SqlDbType.Int).Value = cmbUnidad.SelectedValue
                AgregarDecimal(cmd, "@Dosis", 6, LeerNumero(txtDosis.Text))
                AgregarDecimal(cmd, "@LitrosPreparados", 3, LeerNumero(txtLitrosPreparados.Text))
                AgregarDecimal(cmd, "@SuperficieM2", 3, If(forma = "H", LeerNumero(txtSuperficie.Text), 0))
                AgregarDecimal(cmd, "@LitrosUtilizados", 3, LeerNumero(txtLitrosUtilizados.Text))
                cmd.Parameters.Add("@UsoTotalMezcla", SqlDbType.Bit).Value = chkTodaMezcla.Checked
                cmd.Parameters.Add("@Observaciones", SqlDbType.VarChar, 1000).Value = txtObservaciones.Text.Trim()
                cmd.Parameters.Add("@IdUsuarioRegistro", SqlDbType.Int).Value = If(gIdVendedor > 0, CObj(gIdVendedor), DBNull.Value)
                Dim pLotes = cmd.Parameters.Add("@Lotes", SqlDbType.Structured)
                pLotes.TypeName = "dbo.TT_ListaLotes"
                pLotes.Value = lotes

                idAplicacion = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        Catch ex As SqlException
            MsgBox("No se pudo guardar la aplicación:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Aplicación de Productos")
            Exit Sub
        Finally
            close_conexion()
        End Try

        MsgBox("Aplicación N° " & idAplicacion & " guardada y vinculada a " & lotes.Rows.Count & " lotes.", MsgBoxStyle.Information, "Aplicación de Productos")
        LimpiarFormulario()
        tabPrincipal.SelectedTab = tpHistorial
        BuscarHistorial()
    End Sub

    Private Shared Sub AgregarDecimal(ByVal cmd As SqlCommand, ByVal nombre As String, ByVal escala As Byte, ByVal valor As Double)
        Dim p = cmd.Parameters.Add(nombre, SqlDbType.Decimal)
        p.Precision = 18
        p.Scale = escala
        p.Value = Math.Round(CDec(valor), escala)
    End Sub

    ' Conserva fecha, aplicador y tipo, que suelen repetirse en la siguiente aplicación.
    Private Sub LimpiarFormulario()
        _cargando = True
        cmbProducto.SelectedIndex = -1
        cmbProducto.Text = ""
        txtMotivo.Clear()
        txtDosis.Clear()
        txtSuperficie.Clear()
        txtLitrosPreparados.Clear()
        txtLitrosUtilizados.Clear()
        chkTodaMezcla.Checked = False
        txtObservaciones.Clear()
        lblErrores.Text = ""
        _seleccion.Clear()
        Try
            CargarLotes()
        Finally
            _cargando = False
        End Try
        MostrarLotes()
        Calcular()
    End Sub

#End Region

#Region "Historial"

    Private Sub tabPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabPrincipal.SelectedIndexChanged
        If tabPrincipal.SelectedTab Is tpHistorial AndAlso Not _historialCargado Then BuscarHistorial()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        BuscarHistorial()
    End Sub

    Private Sub txtBuscarHist_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscarHist.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            BuscarHistorial()
        End If
    End Sub

    Private Sub BuscarHistorial()
        Dim dt As New DataTable()
        Try
            open()
            Using cmd As SqlCommand = connection.CreateCommand()
                cmd.CommandText = "SP_APLICACION_HISTORIAL"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Desde", SqlDbType.Date).Value = dtpDesde.Value.Date
                cmd.Parameters.Add("@Hasta", SqlDbType.Date).Value = dtpHasta.Value.Date
                cmd.Parameters.Add("@Texto", SqlDbType.VarChar, 100).Value = txtBuscarHist.Text.Trim()
                cmd.Parameters.Add("@IncluirAnuladas", SqlDbType.Bit).Value = chkAnuladas.Checked
                Using adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch ex As SqlException
            MsgBox("No se pudo consultar el historial:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Aplicación de Productos")
            Exit Sub
        Finally
            close_conexion()
        End Try

        dt.Columns.Add("TotalTexto", GetType(String))
        dt.Columns.Add("UtilizadoTexto", GetType(String))
        dt.Columns.Add("LitrosTexto", GetType(String))
        dt.Columns.Add("EstadoTexto", GetType(String))
        For Each fila As DataRow In dt.Rows
            Dim u = NombreUnidad(fila("Unidad").ToString())
            fila("TotalTexto") = Fmt(Convert.ToDouble(fila("ProductoTotal"))) & " " & u
            fila("UtilizadoTexto") = Fmt(Convert.ToDouble(fila("ProductoUtilizado"))) & " " & u
            fila("LitrosTexto") = Fmt(Convert.ToDouble(fila("LitrosUtilizados"))) & " / " & Fmt(Convert.ToDouble(fila("LitrosPreparados"))) & " L"
            fila("EstadoTexto") = If(Convert.ToBoolean(fila("Anulada")), "ANULADA", "Vigente")
        Next

        _historial = dt
        _historialCargado = True
        gridHistorial.DataSource = _historial
        If gridHistorial.Rows.Count = 0 Then txtDetalle.Text = "No hay aplicaciones registradas con estos criterios."
    End Sub

    Private Function FilaHistorialActual() As DataRow
        If gridHistorial.CurrentRow Is Nothing Then Return Nothing
        Dim vista = TryCast(gridHistorial.CurrentRow.DataBoundItem, DataRowView)
        Return If(vista Is Nothing, Nothing, vista.Row)
    End Function

    Private Sub gridHistorial_SelectionChanged(sender As Object, e As EventArgs) Handles gridHistorial.SelectionChanged
        Dim fila = FilaHistorialActual()
        If fila IsNot Nothing Then txtDetalle.Text = DetalleAplicacion(fila)
    End Sub

    Private Shared Function DetalleAplicacion(ByVal r As DataRow) As String
        Dim u = NombreUnidad(r("Unidad").ToString())
        Dim forma = r("FormaDosis").ToString()
        Dim sb As New System.Text.StringBuilder()

        If Convert.ToBoolean(r("Anulada")) Then sb.AppendLine("*** APLICACIÓN ANULADA ***")
        sb.AppendLine("Aplicación N° " & r("IdAplicacion").ToString() & " · " & r("Producto").ToString() & " · " & r("Tipo").ToString())
        sb.AppendLine(Convert.ToDateTime(r("FechaAplicacion")).ToString("dd-MM-yyyy HH:mm") & " · " & r("Aplicador").ToString())
        sb.AppendLine("Producto total: " & Fmt(Convert.ToDouble(r("ProductoTotal"))) & " " & u &
                      " · Dosis ingresada: " & Fmt(Convert.ToDouble(r("Dosis"))) & " " & u & SufijoDosis(forma) &
                      If(forma = "H" AndAlso Not IsDBNull(r("SuperficieM2")), " · Superficie: " & Fmt(Convert.ToDouble(r("SuperficieM2"))) & " m²", ""))
        sb.AppendLine("Litros preparados: " & Fmt(Convert.ToDouble(r("LitrosPreparados"))) & " L · Litros utilizados: " & Fmt(Convert.ToDouble(r("LitrosUtilizados"))) &
                      " L · Sobrante: " & Fmt(Convert.ToDouble(r("LitrosSobrantes"))) & " L · Producto utilizado estimado: " & Fmt(Convert.ToDouble(r("ProductoUtilizado"))) & " " & u)
        sb.AppendLine("Lotes: " & r("CantLotes").ToString() & " · Bandejas: " & Convert.ToInt32(r("Bandejas")).ToString("#,##0") & " · Plantas: " & Convert.ToInt32(r("Plantas")).ToString("#,##0"))
        sb.AppendLine("N° de lotes: " & r("Lotes").ToString())
        If r("Motivo").ToString() <> "" Then sb.AppendLine("Motivo: " & r("Motivo").ToString())
        If r("Observaciones").ToString() <> "" Then sb.AppendLine("Observaciones: " & r("Observaciones").ToString())
        Return sb.ToString()
    End Function

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Dim fila = FilaHistorialActual()
        If fila Is Nothing Then
            MsgBox("Selecciona una aplicación del historial.", MsgBoxStyle.Exclamation, "Anular aplicación")
            Exit Sub
        End If
        If Convert.ToBoolean(fila("Anulada")) Then
            MsgBox("Esta aplicación ya está anulada.", MsgBoxStyle.Exclamation, "Anular aplicación")
            Exit Sub
        End If

        Dim resp = MsgBox("¿Anular la aplicación N° " & fila("IdAplicacion").ToString() & " (" & fila("Producto").ToString() & ", " &
                          fila("CantLotes").ToString() & " lotes)?" & vbCrLf & "Dejará de aparecer en la bitácora de esos lotes.",
                          MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Anular aplicación")
        If resp <> MsgBoxResult.Yes Then Exit Sub

        Try
            open()
            Using cmd As SqlCommand = connection.CreateCommand()
                cmd.CommandText = "SP_APLICACION_ANULAR"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@IdAplicacion", SqlDbType.Int).Value = fila("IdAplicacion")
                cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = If(gIdVendedor > 0, CObj(gIdVendedor), DBNull.Value)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As SqlException
            MsgBox("No se pudo anular la aplicación:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Anular aplicación")
            Exit Sub
        Finally
            close_conexion()
        End Try

        BuscarHistorial()
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        If _historial Is Nothing OrElse _historial.Rows.Count = 0 Then
            MsgBox("No hay aplicaciones para exportar con los filtros actuales.", MsgBoxStyle.Exclamation, "Exportar")
            Exit Sub
        End If

        Using sfd As New SaveFileDialog()
            sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx"
            sfd.FileName = "Aplicaciones_Viveros_DyD_" & DateTime.Now.ToString("yyyyMMdd_HHmm")
            If sfd.ShowDialog() <> DialogResult.OK Then Exit Sub

            Dim encabezados = {"N° aplicación", "Fecha", "Hora", "Producto", "Tipo", "Aplicador", "Forma de ingreso", "Dosis", "Unidad",
                               "Superficie (m²)", "Litros preparados", "Litros utilizados", "Litros sobrantes", "Producto total",
                               "Producto utilizado", "Cant. lotes", "Bandejas", "Plantas", "N° de lotes", "Motivo", "Observaciones", "Estado"}

            Using wb As New XLWorkbook()
                Dim ws = wb.Worksheets.Add("Aplicaciones")
                For c = 0 To encabezados.Length - 1
                    ws.Cell(1, c + 1).Value = encabezados(c)
                Next
                With ws.Range(1, 1, 1, encabezados.Length).Style
                    .Font.Bold = True
                    .Fill.BackgroundColor = XLColor.LightGray
                    .Border.OutsideBorder = XLBorderStyleValues.Thin
                End With

                Dim fila = 2
                For Each r As DataRow In _historial.Rows
                    Dim fecha = Convert.ToDateTime(r("FechaAplicacion"))
                    ws.Cell(fila, 1).Value = Convert.ToInt32(r("IdAplicacion"))
                    ws.Cell(fila, 2).Value = fecha.Date
                    ws.Cell(fila, 2).Style.DateFormat.Format = "dd-MM-yyyy"
                    ws.Cell(fila, 3).Value = fecha.ToString("HH:mm")
                    ws.Cell(fila, 4).Value = r("Producto").ToString()
                    ws.Cell(fila, 5).Value = r("Tipo").ToString()
                    ws.Cell(fila, 6).Value = r("Aplicador").ToString()
                    ws.Cell(fila, 7).Value = DescripcionForma(r("FormaDosis").ToString())
                    ws.Cell(fila, 8).Value = Convert.ToDouble(r("Dosis"))
                    ws.Cell(fila, 9).Value = NombreUnidad(r("Unidad").ToString())
                    If Not IsDBNull(r("SuperficieM2")) Then ws.Cell(fila, 10).Value = Convert.ToDouble(r("SuperficieM2"))
                    ws.Cell(fila, 11).Value = Convert.ToDouble(r("LitrosPreparados"))
                    ws.Cell(fila, 12).Value = Convert.ToDouble(r("LitrosUtilizados"))
                    ws.Cell(fila, 13).Value = Convert.ToDouble(r("LitrosSobrantes"))
                    ws.Cell(fila, 14).Value = Convert.ToDouble(r("ProductoTotal"))
                    ws.Cell(fila, 15).Value = Convert.ToDouble(r("ProductoUtilizado"))
                    ws.Cell(fila, 16).Value = Convert.ToInt32(r("CantLotes"))
                    ws.Cell(fila, 17).Value = Convert.ToInt32(r("Bandejas"))
                    ws.Cell(fila, 18).Value = Convert.ToInt32(r("Plantas"))
                    ws.Cell(fila, 19).Value = r("Lotes").ToString()
                    ws.Cell(fila, 20).Value = r("Motivo").ToString()
                    ws.Cell(fila, 21).Value = r("Observaciones").ToString()
                    ws.Cell(fila, 22).Value = r("EstadoTexto").ToString()
                    fila += 1
                Next

                ws.Columns().AdjustToContents()
                Try
                    wb.SaveAs(sfd.FileName)
                Catch ex As IO.IOException
                    MsgBox("No se pudo guardar el archivo. ¿Está abierto en Excel?" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Exportar")
                    Exit Sub
                End Try
            End Using
        End Using

        MsgBox("Historial exportado correctamente.", MsgBoxStyle.Information, "Exportar")
    End Sub

    Private Shared Function DescripcionForma(ByVal forma As String) As String
        Select Case forma
            Case "C" : Return "Dosis por 100 L de agua"
            Case "T" : Return "Cantidad total de producto"
            Case "H" : Return "Dosis por hectárea"
            Case Else : Return "Dosis por litro de agua"
        End Select
    End Function

#End Region

End Class
