Imports System.Data.SqlClient
Imports Microsoft.Internal.VisualStudio.Shell.Interop

Public Class ListaPedidos
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Me.Close()
    End Sub

    Private Sub CargaPedidos(iNumPedido As String, iOpcion As Integer, sTitulo As String)
        'GrillaPedidos.Rows.Clear()
        sSsql = "[dbo].[NEWSP_CONSULTAPedidosPendientes] "
        sSsql += iNumPedido.ToString & ","
        sSsql += iOpcion.ToString
        lblTitulo.Text = sTitulo
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            Dim dt As New DataTable()
            dt.Load(reader)
            GrillaPedidos.DataSource = dt
            If GrillaPedidos.Columns.Contains("estadopedidoid") Then
                GrillaPedidos.Columns("estadopedidoid").Visible = False
            End If

            For Each col As DataGridViewColumn In GrillaPedidos.Columns
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
                        col.Width = 75
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

            If iOpcion = 1 Then
                close_conexion()
                RecuperaPedido()
            End If
        Else
            MsgBox("No Existen Pedidos!!!", MsgBoxStyle.Information, "Lista Pedidos")
        End If
        close_conexion()
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
            Dim valorEstado = e.Value

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

        End If
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If GrillaPedidos.Rows.Count > 0 Then
            RecuperaPedido()
        End If
    End Sub

    Private Sub RecuperaPedido()
        Dim i As Integer = GrillaPedidos.CurrentRow.Index
        Dim idPedido As Integer = GrillaPedidos.Rows(i).Cells(0).Value
        Pedidos.txtIdPedido.Text = idPedido
        Pedidos.Recupera_Pedido(idPedido)
        Me.Close()
    End Sub

    Private Sub btnBusca_Click(sender As Object, e As EventArgs) Handles btnBusca.Click
        If Val(txtNumPedido.Text) > 0 Then
            CargaPedidos(Val(txtNumPedido.Text), 1, "N° Pedido")
        End If
        If rbUltimos.Checked Then
            CargaPedidos(0, 2, "PEDIDOS DE LOS ULTIMOS 6 MESES")
        End If
        If rbTodos.Checked Then
            CargaPedidos(0, 3, "TODOS LOS PEDIDOS REGISTRADOS")
        End If
    End Sub

    Private Sub rbUltimos_CheckedChanged(sender As Object, e As EventArgs) Handles rbUltimos.CheckedChanged
        txtNumPedido.Clear()
    End Sub

    Private Sub rbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodos.CheckedChanged
        txtNumPedido.Clear()
    End Sub
End Class