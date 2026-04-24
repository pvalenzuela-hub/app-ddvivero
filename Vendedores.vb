Public Class Vendedores

    Private Sub Vendedores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaVendedores()
    End Sub

    Private Sub CargaVendedores()
        Dim i As Integer
        DataVendedor.Rows.Clear()
        sSsql = "SELECT IdVendedor, NOMBRE, PorComision, IdUsuario, ISNULL(EsCajero,0) AS EsCajero FROM VENDEDOR ORDER BY NOMBRE"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            While datatbl.Read = True
                DataVendedor.Rows.Add()
                DataVendedor.Rows(i).Cells(0).Value = datatbl(0)
                DataVendedor.Rows(i).Cells(1).Value = datatbl(1)
                DataVendedor.Rows(i).Cells(2).Value = datatbl(2)
                DataVendedor.Rows(i).Cells(3).Value = datatbl(3)
                DataVendedor.Rows(i).Cells(4).Value = If(Convert.ToInt32(datatbl(4)) = 1, "Si", "No")
                i += 1
            End While
        End If
        close_conexion()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LimpiaCampos()
    End Sub

    Private Sub LimpiaCampos()
        txt_Vendedor.Clear()
        txtUsuario.Clear()
        txtporcomis.Clear()
        chkEsCajero.Checked = False
        txt_Vendedor.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ActualizaVendedor()
        LimpiaCampos()
    End Sub

    Private Sub ActualizaVendedor()
        open()
        Try
            command = connection.CreateCommand()
            command.CommandText = "UPDATE VENDEDOR SET NOMBRE=@NOMBRE, PorComision=@PorComision, EsCajero=@EsCajero WHERE IdVendedor=@IdVendedor"
            command.Parameters.AddWithValue("@IdVendedor", Val(txt_Codigo.Text))
            command.Parameters.AddWithValue("@NOMBRE", txt_Vendedor.Text.Trim())
            command.Parameters.AddWithValue("@PorComision", Val(txtporcomis.Text))
            command.Parameters.AddWithValue("@EsCajero", If(chkEsCajero.Checked, 1, 0))
            command.ExecuteNonQuery()
        Finally
            close_conexion()
        End Try
        MsgBox("Vendedor ha sido Actualizado.")
        CargaVendedores()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        EliminaVendedor()
        LimpiaCampos()
    End Sub

    Private Sub EliminaVendedor()
        Dim sResp As String
        Dim sVendedor As String
        Dim iCodigo As Integer
        Dim FilaGrilla As Integer
        sResp = InputBox("Confirmación Eliminación de Vendedor", "Eliminación de Vendedor", "S")
        If UCase(sResp) = "S" Then
            FilaGrilla = DataVendedor.CurrentRow.Index
            iCodigo = DataVendedor.Rows(FilaGrilla).Cells(0).Value
            sVendedor = DataVendedor.Rows(FilaGrilla).Cells(1).Value

            If iCodigo = 0 Then
                MsgBox("Código de Vendedor no válido. Debe Seleccionar Vendedor a Eliminar.")
                Exit Sub
            End If
            sSsql = "SP_EliminaVendedor "
            sSsql += iCodigo.ToString
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                datatbl.Read()
                If datatbl(0) = -1 Then
                    MsgBox("No ha sido posible Eliminar Vendedor: " & sVendedor & ". Vendedor tiene transacciones en el Sistema.")
                Else
                    MsgBox("Vendedor ha sido Eliminado del sistema.")
                End If
            End If
            close_conexion()
            CargaVendedores()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim FilaGrilla As Integer
        FilaGrilla = DataVendedor.CurrentRow.Index
        txt_Codigo.Text = DataVendedor.Rows(FilaGrilla).Cells(0).Value
        txt_Vendedor.Text = DataVendedor.Rows(FilaGrilla).Cells(1).Value
        txtUsuario.Text = DataVendedor.Rows(FilaGrilla).Cells(2).Value
        txtporcomis.Text = DataVendedor.Rows(FilaGrilla).Cells(3).Value
        chkEsCajero.Checked = String.Equals(Convert.ToString(DataVendedor.Rows(FilaGrilla).Cells(4).Value), "Si", StringComparison.OrdinalIgnoreCase)
    End Sub

    Private Sub DataVendedor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataVendedor.CellContentClick

    End Sub
End Class
