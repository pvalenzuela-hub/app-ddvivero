Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.FileIO
Public Class AutorizacionPedidos
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub CargaGrillaPedidos(iNumPedido As Integer, iOpcion As Integer)
        Dim hayFiltros As Boolean = False
        sSsql = "[dbo].[P001_CONSULTAPedidosPendientes] "
        sSsql += iNumPedido.ToString & ","
        sSsql += iOpcion.ToString & ",1"

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql

        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            Dim dt As New DataTable()
            dt.Load(reader)
            Dim dv As New DataView(dt)
            GrillaPedidos.DataSource = dv
            cmbfiltros.Items.Clear()

            If GrillaPedidos.Columns.Contains("estadopedidoid") Then
                GrillaPedidos.Columns("estadopedidoid").Visible = False
            End If

            If Not gEsAutorizador Then
                Dim datav As DataView = CType(GrillaPedidos.DataSource, DataView)
                Dim campo As String = "Vendedor"
                Dim filtro As String = gUSER
                datav.RowFilter = $"[{campo}] LIKE '%{filtro}%'"
            End If

            For Each col As DataGridViewColumn In GrillaPedidos.Columns
                If gEsAutorizador AndAlso col.Visible Then
                    Select Case col.HeaderText.Trim().ToLower()
                        Case "vendedor", "cliente", "estado pedido"
                            cmbfiltros.Items.Add(col.HeaderText)
                            hayFiltros = True
                    End Select
                End If

                Select Case col.HeaderText.Trim().ToLower()
                    Case "n° pedido"
                        col.Width = 50
                    Case "monto pedido", "monto mínimo", "monto abonado", "saldo"
                        col.Width = 70
                    Case "% abono"
                        col.Width = 60
                    Case "cant. lotes"
                        col.Width = 35
                    Case "estado pedido"
                        col.Width = 80
                    Case "cliente"
                        col.Width = 255
                    Case "fecha pedido"
                        col.Width = 70
                    Case "vendedor"
                        col.Width = 75
                    Case "motivo excepción"
                        col.Width = 80
                    Case "lotes hijos"
                        col.Width = 35
                End Select
                If col.Name <> "Seleccionar" Then
                    col.ReadOnly = True
                End If
            Next
            If hayFiltros Then
                cmbfiltros.SelectedIndex = 0
            End If

        Else
            MsgBox("No Existen Pedidos con filtro aplicado.", MsgBoxStyle.Information, "Autoriza Pedidos")
        End If
        close_conexion()
    End Sub

    Private Sub AutorizacionPedidos_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not GrillaPedidos.Columns.Contains("Seleccionar") Then
            Dim colCheck As New DataGridViewCheckBoxColumn()
            colCheck.Name = "Seleccionar"
            colCheck.HeaderText = "✔"
            colCheck.Width = 35
            colCheck.TrueValue = True
            colCheck.FalseValue = False
            colCheck.ThreeState = False
            If gEsAutorizador Then
                colCheck.ReadOnly = False
            Else
                colCheck.ReadOnly = True
            End If
            colCheck.Frozen = True ' opcional: mantiene visible al hacer scroll
            GrillaPedidos.Columns.Insert(0, colCheck) ' Insertar en la primera columna
        End If
        ' Habilitar edición general si fuera necesario
        GrillaPedidos.ReadOnly = False
        GrillaPedidos.EditMode = DataGridViewEditMode.EditOnEnter

        If Not gEsAutorizador Then
            cmbfiltros.Visible = False
            Label2.Visible = False
            txtFiltroValor.Visible = False
            Button6.Visible = False
            btnAprobar.Visible = False
            btnCerrarPedido.Visible = False
            btnPendiente.Visible = False
            btnRechazar.Visible = False
            ChkSeleccion.Visible = False
        End If

        RecuperaPedidos()

    End Sub

    Private Sub GrillaPedidos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles GrillaPedidos.CellFormatting
        Dim dgv As DataGridView = CType(sender, DataGridView)
        Dim colName As String = dgv.Columns(e.ColumnIndex).HeaderText.ToLower().Trim()
        Dim nombresNumericos As String() = {"monto pedido", "cant. lotes", "monto mínimo", "monto abonado", "saldo"}
        ' ----- FORMATO NUMÉRICO -----
        If nombresNumericos.Any(Function(n) n.ToLower() = colName) AndAlso IsNumeric(e.Value) Then
            e.Value = Format(e.Value, "###,###,##0")
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            e.FormattingApplied = True
        End If

        If GrillaPedidos.Columns(e.ColumnIndex).Name = "% Abono" AndAlso IsNumeric(e.Value) Then
            e.Value = Format(e.Value, "###0.00")
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            e.FormattingApplied = True
        End If

        If GrillaPedidos.Columns(e.ColumnIndex).Name = "fecha pedido" Then
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            e.FormattingApplied = True
        End If

        If colName = "estado pedido" Then
            Dim valorEstado = Trim(e.Value)

            If valorEstado = "EXCEPCION: Solicita Aprobación" Then
                dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightSalmon
            End If
            If valorEstado = "PENDIENTE" Then
                dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightYellow
            End If
            If valorEstado = "APROBADO" Then
                dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
            End If
            If valorEstado = "RECHAZADO" Then
                dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
                dgv.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
            End If
            If valorEstado = "CERRADO" Then
                dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Blue
                dgv.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
            End If
            e.FormattingApplied = True
        End If

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAprobar.Click
        'Botón Autoriza Pedido
        Dim bControlAutoriza As Boolean = True

        'Declarar lista de pedidos separado por comas Ejemplo: 2515, 6251, 3051, 2890
        Dim ListaPedidos As New List(Of String)

        For Each fila As DataGridViewRow In GrillaPedidos.Rows
            ' Verifica si está marcada (columna CheckBox debe estar en posición 0)
            If Convert.ToBoolean(fila.Cells(0).Value) Then
                Dim idPedido = fila.Cells("N° Pedido").Value?.ToString()
                If Not String.IsNullOrEmpty(idPedido) Then
                    ListaPedidos.Add(idPedido)
                End If
            End If
        Next

        ' Verifica si hay elementos en la lista
        If ListaPedidos.Count = 0 Then
            MessageBox.Show("No hay pedidos seleccionados para aprobar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            bControlAutoriza = False
        End If

        ' Confirmación
        If MessageBox.Show("¿Está seguro de aprobar los pedidos seleccionados?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            bControlAutoriza = False
        End If
        ' Armar la cadena para SQL
        If bControlAutoriza Then
            Dim listaSQL As String = String.Join(",", ListaPedidos)
            Try
                open()
                Dim sql As String = "UPDATE PEDIDO_HEADER " &
                                    "SET estadopedidoid = 3, " &
                                    "    FechaAutorizacion = GETDATE(), " &
                                    "    CodUsuarioAutoriza = @usuario " &
                                    $"WHERE IdPedido IN ({listaSQL})"

                Dim command As SqlCommand = connection.CreateCommand()
                command.CommandText = sql
                command.Parameters.AddWithValue("@usuario", gUSER) ' gUser = usuario público que autoriza

                Dim rowsAffected = command.ExecuteNonQuery()

                MessageBox.Show($"Se aprobaron {rowsAffected} pedidos correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al aprobar pedidos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                close_conexion()
            End Try
            RecuperaPedidos()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCerrarPedido.Click
        'Botón Cerrar Pedido
        Dim bControlRechazo As Boolean = True
        Dim ListaPedidos As New List(Of String)
        For Each fila As DataGridViewRow In GrillaPedidos.Rows
            If Convert.ToBoolean(fila.Cells(0).Value) Then
                Dim idPedido = fila.Cells("N° Pedido").Value?.ToString()
                If Not String.IsNullOrEmpty(idPedido) Then
                    ListaPedidos.Add(idPedido)
                End If
            End If
        Next

        ' Verifica si hay elementos en la lista
        If ListaPedidos.Count = 0 Then
            MessageBox.Show("No hay pedidos seleccionados para cerrar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            bControlRechazo = False
        End If

        ' Confirmación
        If MessageBox.Show("¿Está seguro de cerrar los pedidos seleccionados?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            bControlRechazo = False
        End If
        ' Armar la cadena para SQL
        If bControlRechazo Then
            Dim listaSQL As String = String.Join(",", ListaPedidos)
            Try
                open()
                Dim sql As String = "UPDATE PEDIDO_HEADER " &
                                    "SET estadopedidoid = 5, " &
                                    "    FechaRechazo = GETDATE(), " &
                                    "    CodUsuarioRechazo = @usuario " &
                                    $"WHERE IdPedido IN ({listaSQL})"

                Dim command As SqlCommand = connection.CreateCommand()
                command.CommandText = sql
                command.Parameters.AddWithValue("@usuario", gUSER)

                Dim rowsAffected = command.ExecuteNonQuery()

                MessageBox.Show($"Se cerraron {rowsAffected} pedidos correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al cerrar pedidos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                close_conexion()
            End Try
            RecuperaPedidos()
        End If
    End Sub

    Private Sub btnBusca_Click(sender As Object, e As EventArgs) Handles btnBusca.Click
        RecuperaPedidos()
    End Sub

    Private Sub RecuperaPedidos()
        If Val(txtNumPedido.Text) > 0 Then
            CargaGrillaPedidos(Val(txtNumPedido.Text), 1)
        ElseIf rbUltimos.Checked Then
            CargaGrillaPedidos(0, 2)
        ElseIf rbTodos.Checked Then
            CargaGrillaPedidos(0, 3)
        ElseIf rbPendientes.Checked Then
            CargaGrillaPedidos(0, 4)
        End If
    End Sub

    Private Sub ChkSeleccion_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSeleccion.CheckedChanged
        Dim i As Integer = 0
        If ChkSeleccion.Checked Then
            For i = 0 To GrillaPedidos.Rows.Count() - 1
                GrillaPedidos.Rows(i).Cells(0).Value = True
            Next
        Else
            For i = 0 To GrillaPedidos.Rows.Count() - 1
                GrillaPedidos.Rows(i).Cells(0).Value = False
            Next
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnRechazar.Click
        'Botón Rechazar Pedido
        Dim bControlAutoriza As Boolean = True

        'Declarar lista de pedidos separado por comas Ejemplo: 2515, 6251, 3051, 2890
        Dim ListaPedidos As New List(Of String)

        For Each fila As DataGridViewRow In GrillaPedidos.Rows
            ' Verifica si está marcada (columna CheckBox debe estar en posición 0)
            If Convert.ToBoolean(fila.Cells(0).Value) Then
                Dim idPedido = fila.Cells("N° Pedido").Value?.ToString()
                If Not String.IsNullOrEmpty(idPedido) Then
                    ListaPedidos.Add(idPedido)
                End If
            End If
        Next

        ' Verifica si hay elementos en la lista
        If ListaPedidos.Count = 0 Then
            MessageBox.Show("No hay pedidos seleccionados para rechazar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            bControlAutoriza = False
        End If

        ' Confirmación
        If MessageBox.Show("¿Está seguro de rechazar los pedidos seleccionados?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            bControlAutoriza = False
        End If
        ' Armar la cadena para SQL
        If bControlAutoriza Then
            Dim listaSQL As String = String.Join(",", ListaPedidos)
            Try
                open()
                Dim sql As String = "UPDATE PEDIDO_HEADER " &
                                    "SET estadopedidoid = 4, " &
                                    "    FechaAutorizacion = GETDATE(), " &
                                    "    CodUsuarioAutoriza = @usuario " &
                                    $"WHERE IdPedido IN ({listaSQL})"

                Dim command As SqlCommand = connection.CreateCommand()
                command.CommandText = sql
                command.Parameters.AddWithValue("@usuario", gUSER) ' gUser = usuario público que autoriza

                Dim rowsAffected = command.ExecuteNonQuery()

                MessageBox.Show($"Se rechazaron {rowsAffected} pedidos correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al rechazar pedidos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                close_conexion()
            End Try
            RecuperaPedidos()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnPendiente.Click
        'Botón Pendiente Pedido
        Dim bControlAutoriza As Boolean = True

        'Declarar lista de pedidos separado por comas Ejemplo: 2515, 6251, 3051, 2890
        Dim ListaPedidos As New List(Of String)

        For Each fila As DataGridViewRow In GrillaPedidos.Rows
            ' Verifica si está marcada (columna CheckBox debe estar en posición 0)
            If Convert.ToBoolean(fila.Cells(0).Value) Then
                Dim idPedido = fila.Cells("N° Pedido").Value?.ToString()
                If Not String.IsNullOrEmpty(idPedido) Then
                    ListaPedidos.Add(idPedido)
                End If
            End If
        Next

        ' Verifica si hay elementos en la lista
        If ListaPedidos.Count = 0 Then
            MessageBox.Show("No hay pedidos seleccionados para dejar pendiente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            bControlAutoriza = False
        End If

        ' Confirmación
        If MessageBox.Show("¿Está seguro de dejar pendiente los pedidos seleccionados?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            bControlAutoriza = False
        End If
        ' Armar la cadena para SQL
        If bControlAutoriza Then
            Dim listaSQL As String = String.Join(",", ListaPedidos)
            Try
                open()
                Dim sql As String = "UPDATE PEDIDO_HEADER " &
                                    "SET estadopedidoid = 2, " &
                                    "    FechaAutorizacion = GETDATE(), " &
                                    "    CodUsuarioAutoriza = @usuario " &
                                    $"WHERE IdPedido IN ({listaSQL})"

                Dim command As SqlCommand = connection.CreateCommand()
                command.CommandText = sql
                command.Parameters.AddWithValue("@usuario", gUSER) ' gUser = usuario público que autoriza

                Dim rowsAffected = command.ExecuteNonQuery()

                MessageBox.Show($"Se dejaron pediente {rowsAffected} pedidos correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al dejar pendiente pedidos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                close_conexion()
            End Try
            RecuperaPedidos()
        End If
    End Sub

    Private Sub GrillaPedidos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaPedidos.CellDoubleClick
        If GrillaPedidos.Rows.Count > 0 AndAlso e.ColumnIndex = 1 Then

            gNumPedido = GrillaPedidos.Rows(e.RowIndex).Cells(1).Value
            DetalleVenta.Show()

        End If
    End Sub

    Private Sub txtFiltroValor_TextChanged(sender As Object, e As EventArgs) Handles txtFiltroValor.TextChanged
        Try

            Dim dv As DataView = CType(GrillaPedidos.DataSource, DataView)
            Dim campo As String = cmbfiltros.SelectedItem.ToString()

            If txtFiltroValor.Text = "" Then
                dv.RowFilter = ""
            Else
                dv.RowFilter = $"[{campo}] LIKE '%{txtFiltroValor.Text}%'"
            End If

        Catch ex As Exception
            MsgBox("Error al filtrar: " & ex.Message)
        End Try
    End Sub


End Class