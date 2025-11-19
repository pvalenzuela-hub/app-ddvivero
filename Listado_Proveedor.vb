Public Class Listado_Proveedor

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Lectura_Proveedores(ByVal sParam As String)
        Dim i As Integer
        open()
        sSsql = "SP_CONSULTA_PROVEEDOR_NOMBRE '" + RTrim(sParam) + "',2"
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        GrillaProveedor.Rows.Clear()
        If datatbl.HasRows Then
            While datatbl.Read()
                GrillaProveedor.Rows.Add()
                GrillaProveedor.Rows(i).Cells(0).Value = datatbl(0)
                GrillaProveedor.Rows(i).Cells(1).Value = datatbl(1)
                GrillaProveedor.Rows(i).Cells(2).Value = datatbl(2)
                GrillaProveedor.Rows(i).Cells(3).Value = datatbl(3)
                GrillaProveedor.Rows(i).Cells(4).Value = datatbl(4)
                GrillaProveedor.Rows(i).Cells(5).Value = datatbl(5)
                GrillaProveedor.Rows(i).Cells(6).Value = datatbl(6)
                GrillaProveedor.Rows(i).Cells(7).Value = datatbl(7)
                GrillaProveedor.Rows(i).Cells(8).Value = datatbl(8)
                i += 1
            End While
        Else
            MsgBox("NO EXISTEN PROVEEDORES CON NOMBRE INGRESADO")
        End If
        close_conexion()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Lectura_Proveedores(Me.txt_nombre.Text)
    End Sub
End Class