Public Class Vendedores

    Private Sub Vendedores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaVendedores()
    End Sub

    Private Sub CargaVendedores()
        Dim i As Integer
        DataVendedor.Rows.Clear()
        sSsql = "SP_CONSULTA_FULL_VENDEDOR"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            While datatbl.Read = True
                DataVendedor.Rows.Add()
                DataVendedor.Rows(i).Cells(0).Value = datatbl(0)
                DataVendedor.Rows(i).Cells(1).Value = datatbl(3)
                DataVendedor.Rows(i).Cells(2).Value = datatbl(1)
                DataVendedor.Rows(i).Cells(3).Value = datatbl(4)
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
        txt_Vendedor.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ActualizaVendedor()
        LimpiaCampos()
    End Sub

    Private Sub ActualizaVendedor()
        sSsql = "SP_ActualizaVendedor "
        sSsql += Val(txt_Codigo.Text).ToString + ","
        sSsql += "'" + txt_Vendedor.Text + "',"
        sSsql += "'" + txtUsuario.Text + "',"
        sSsql += Reemplaza_Comas(Val(txtporcomis.Text).ToString)
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()
        close_conexion()
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
        txtUsuario.Text = DataVendedor.Rows(FilaGrilla).Cells(0).Value
        txt_Vendedor.Text = DataVendedor.Rows(FilaGrilla).Cells(1).Value
        txtporcomis.Text = DataVendedor.Rows(FilaGrilla).Cells(2).Value
        txtUsuario.Text = DataVendedor.Rows(FilaGrilla).Cells(3).Value
    End Sub

    Private Sub DataVendedor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataVendedor.CellContentClick

    End Sub
End Class