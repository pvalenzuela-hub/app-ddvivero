Public Class Trabajadores
    Private Sub Trabajadores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Carga_Personal()
    End Sub
    Private Sub Carga_Personal()
        DataPersonal.Rows.Clear()
        Dim i As Integer
        sSsql = "SP_CONSULTA_FULL_Personal"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            While datatbl.Read = True
                DataPersonal.Rows.Add()
                DataPersonal.Rows(i).Cells(0).Value = datatbl(1)
                DataPersonal.Rows(i).Cells(1).Value = datatbl(2)
                DataPersonal.Rows(i).Cells(2).Value = datatbl(3)
                DataPersonal.Rows(i).Cells(3).Value = datatbl(4)
                DataPersonal.Rows(i).Cells(4).Value = datatbl(5)
                i += 1
            End While
        End If
        close_conexion()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Private Sub EliminaEmpleado()
        Dim sResp As String
        Dim iCodigo As Integer
        Dim FilaGrilla As Integer
        sResp = InputBox("Confirmación Eliminación de Empleado", "Eliminación de Empleado", "S")
        If UCase(sResp) = "S" Then
            FilaGrilla = DataPersonal.CurrentRow.Index
            iCodigo = DataPersonal.Rows(FilaGrilla).Cells(0).Value
        
            If iCodigo = 0 Then
                MsgBox("Código de Empleado no es válido. Debe Seleccionar Empleado a Eliminar.")
                Exit Sub
            End If
            sSsql = "SP_EliminaEmpleado "
            sSsql += iCodigo.ToString
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                datatbl.Read()
                If datatbl(0) = -1 Then
                    MsgBox("No ha sido posible Eliminar Empleado: " & iCodigo.ToString & ". porque tiene actividades registradas.")
                Else
                    MsgBox("Empleado ha sido Eliminado del sistema.")
                End If
            End If
            close_conexion()
            Carga_Personal()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        EliminaEmpleado()
        LimpiaCampos()
    End Sub

    Private Sub LimpiaCampos()
        txt_Apellido.Clear()
        txt_Codigo.Clear()
        txt_Nombre.Clear()
        txt_Rut.Clear()
        dtp_FechaNac.Value = Now.Date
    End Sub
    Private Sub ActualizaEmpleado()
        sSsql = "SP_ActualizaEmpleado "
        sSsql += Val(txt_Codigo.Text).ToString + ","
        sSsql += "'" + txt_Rut.Text + "',"
        sSsql += "'" + RTrim(UCase(txt_Nombre.Text)) + "',"
        sSsql += "'" + RTrim(UCase(txt_Apellido.Text)) + "',"
        sSsql += "'" + dtp_FechaNac.Value + "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()
        close_conexion()
        MsgBox("Empleado ha sido Actualizado.")
        Carga_Personal()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ActualizaEmpleado()
        LimpiaCampos()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim FilaGrilla As Integer
        FilaGrilla = DataPersonal.CurrentRow.Index
        txt_Codigo.Text = DataPersonal.Rows(FilaGrilla).Cells(0).Value
        txt_Apellido.Text = DataPersonal.Rows(FilaGrilla).Cells(1).Value
        txt_Nombre.Text = DataPersonal.Rows(FilaGrilla).Cells(2).Value
        txt_Rut.Text = DataPersonal.Rows(FilaGrilla).Cells(3).Value
        dtp_FechaNac.Value = CDate(DataPersonal.Rows(FilaGrilla).Cells(4).Value)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LimpiaCampos()
        txt_Apellido.Focus()
    End Sub
End Class