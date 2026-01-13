Imports Microsoft.VisualBasic.FileIO
Imports System.Data.SqlClient

Public Class DocumentosPendientes

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub ConsultaDocumentosPendientes()
        sSsql = "[dbo].[NEWSP_ConsultaDocumentosPendientes] "
        If chkSobrepago.Checked Then
            sSsql += "1,"
            Label1.Text = "Documentos con pagos a favor del cliente"
        Else
            sSsql += "0,"
            Label1.Text = "Documentos Pendientes de Pago"
        End If

        If gEsAutorizador Then
            sSsql += "Null"
        Else
            sSsql += "'" & gUSER & "'"
        End If

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            Dim dt As New DataTable()
            dt.Load(reader)

            Dim dv As New DataView(dt)
            DataGrilla.DataSource = dv

            cmbfiltros.Items.Clear()
            For Each col As DataGridViewColumn In DataGrilla.Columns

                If gEsAutorizador Then
                    If col.Visible AndAlso (col.HeaderText = "Usuario" OrElse col.HeaderText = "Cliente" OrElse col.HeaderText = "Fecha Doc") Then
                        cmbfiltros.Items.Add(col.HeaderText)
                    End If
                Else
                    If col.Visible AndAlso (col.HeaderText = "Cliente" OrElse col.HeaderText = "Fecha Doc") Then
                        cmbfiltros.Items.Add(col.HeaderText)
                    End If
                End If

                Select Case col.HeaderText.Trim().ToLower()
                    Case "valor doc", "saldo doc"
                        col.Width = 80
                    Case "cliente"
                        col.Width = 100
                    Case "estado cliente"
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    Case "idcliente"
                        col.Visible = False
                    Case Else
                        col.Width = 60
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                End Select
                If col.Name <> "Seleccionar" Then
                    col.ReadOnly = True
                End If
            Next
            cmbfiltros.SelectedIndex = 0
        Else
            MsgBox("No Existen Documentos Pendientes de pago!!!", MsgBoxStyle.Information, "Documentos Pendientes")
        End If
        close_conexion()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub DocumentosPendientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not DataGrilla.Columns.Contains("Seleccionar") Then
            Dim colCheck As New DataGridViewCheckBoxColumn()
            colCheck.Name = "Seleccionar"
            colCheck.HeaderText = "✔"
            colCheck.Width = 50
            colCheck.TrueValue = True
            colCheck.FalseValue = False
            colCheck.ThreeState = False
            colCheck.ReadOnly = False
            colCheck.Frozen = True ' opcional: mantiene visible al hacer scroll
            DataGrilla.Columns.Insert(0, colCheck) ' Insertar en la primera columna
        End If
        DataGrilla.ReadOnly = False
        DataGrilla.EditMode = DataGridViewEditMode.EditOnEnter
        ConsultaDocumentosPendientes()


        If gEsAutorizador Then
            btnActivar.Visible = True
            btnBloquear.Visible = True
        End If

    End Sub

    Private Sub DataGrilla_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGrilla.CellFormatting
        Dim dgv As DataGridView = CType(sender, DataGridView)
        Dim colName As String = dgv.Columns(e.ColumnIndex).HeaderText.ToLower().Trim()
        Dim nombresNumericos As String() = {"valor doc", "saldo doc"}
        ' ----- FORMATO NUMÉRICO -----
        If nombresNumericos.Any(Function(n) n.ToLower() = colName) AndAlso IsNumeric(e.Value) Then
            e.Value = Format(e.Value, "###,###,###")
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            e.FormattingApplied = True
        End If
        If colName = "estado cliente" Then
            Dim valorEstado = Trim(e.Value)
            If valorEstado = "ACTIVO" Then
                dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightYellow
            End If
            If valorEstado = "BLOQUEADO" Then
                dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
                dgv.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnActivar.Click
        'Botón Activar Cliente
        Dim bControlActiva As Boolean = True

        'Declarar lista de pedidos separado por comas Ejemplo: 2515, 6251, 3051, 2890
        Dim ListaClientes As New List(Of String)

        For Each fila As DataGridViewRow In DataGrilla.Rows
            If Convert.ToBoolean(fila.Cells(0).Value) Then
                Dim idCliente = fila.Cells("IdCliente").Value?.ToString()
                If Not String.IsNullOrEmpty(idCliente) Then
                    ListaClientes.Add(idCliente)
                End If
            End If
        Next

        ' Verifica si hay elementos en la lista
        If ListaClientes.Count = 0 Then
            MessageBox.Show("No hay clientes seleccionados para activar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            bControlActiva = False
        End If
        If bControlActiva Then
            ' Confirmación
            If MessageBox.Show("¿Está seguro de activar clientes seleccionados?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                bControlActiva = False
            End If

            If bControlActiva Then
                ' Armar la cadena para SQL

                Dim listaSQL As String = String.Join(",", ListaClientes)
                Try
                    open()
                    Dim sql As String = "UPDATE CLIENTE " &
                                    "SET EstadoclienteId = 1, " &
                                    "    FechaCambiaEstado = GETDATE(), " &
                                    "    UsuarioCambiaEstado = @usuario " &
                                    $"WHERE IdCliente IN ({listaSQL})"

                    Dim command As SqlCommand = connection.CreateCommand()
                    command.CommandText = sql
                    command.Parameters.AddWithValue("@usuario", gUSER) ' gUser = usuario público que autoriza

                    Dim rowsAffected = command.ExecuteNonQuery()

                    MessageBox.Show($"Se activaron {rowsAffected} cliente(s) correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error al activar cliente(s): " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    close_conexion()
                End Try
                ConsultaDocumentosPendientes()
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnBloquear.Click
        'Botón Bloquear Cliente
        Dim bControlActiva As Boolean = True

        'Declarar lista de pedidos separado por comas Ejemplo: 2515, 6251, 3051, 2890
        Dim ListaClientes As New List(Of String)

        For Each fila As DataGridViewRow In DataGrilla.Rows
            If Convert.ToBoolean(fila.Cells(0).Value) Then
                Dim idCliente = fila.Cells("IdCliente").Value?.ToString()
                If Not String.IsNullOrEmpty(idCliente) Then
                    ListaClientes.Add(idCliente)
                End If
            End If
        Next

        ' Verifica si hay elementos en la lista
        If ListaClientes.Count = 0 Then
            MessageBox.Show("No hay clientes seleccionados para bloquear.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            bControlActiva = False
        End If
        If bControlActiva Then
            ' Confirmación
            If MessageBox.Show("¿Está seguro de bloquear clientes seleccionados?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                bControlActiva = False
            End If
            ' Armar la cadena para SQL
            If bControlActiva Then
                Dim listaSQL As String = String.Join(",", ListaClientes)
                Try
                    open()
                    Dim sql As String = "UPDATE CLIENTE " &
                                    "SET EstadoclienteId = 2, " &
                                    "    FechaCambiaEstado = GETDATE(), " &
                                    "    UsuarioCambiaEstado = @usuario " &
                                    $"WHERE IdCliente IN ({listaSQL})"

                    Dim command As SqlCommand = connection.CreateCommand()
                    command.CommandText = sql
                    command.Parameters.AddWithValue("@usuario", gUSER) ' gUser = usuario público que autoriza

                    Dim rowsAffected = command.ExecuteNonQuery()

                    MessageBox.Show($"Se bloquearon {rowsAffected} cliente(s) correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error al bloquear cliente(s): " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    close_conexion()
                End Try
                ConsultaDocumentosPendientes()

            End If
        End If
    End Sub

    Private Sub chkSobrepago_CheckedChanged(sender As Object, e As EventArgs) Handles chkSobrepago.CheckedChanged
        ConsultaDocumentosPendientes()
    End Sub

    Private Sub txtFiltroValor_TextChanged(sender As Object, e As EventArgs) Handles txtFiltroValor.TextChanged
        Try

            Dim dv As DataView = CType(DataGrilla.DataSource, DataView)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dv As DataView = CType(DataGrilla.DataSource, DataView)
        dv.RowFilter = ""
        txtFiltroValor.Text = ""
    End Sub

    Private Sub DocumentosPendientes_ImeModeChanged(sender As Object, e As EventArgs) Handles Me.ImeModeChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class