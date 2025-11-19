Public Class Tabla_Zona


    Private Sub Tabla_Zona_Load(sender As Object, e As EventArgs) Handles Me.Load
        Carga_Zona()
    End Sub

    Private Sub Carga_Zona()
        Dim i As Integer
        sSsql = "SP_CONSULTA_FULL_ZONA"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        DataGrilla.Rows.Clear()

        While datatbl.Read = True
            DataGrilla.Rows.Add()
            DataGrilla.Rows(i).Cells(0).Value = datatbl(0)
            DataGrilla.Rows(i).Cells(1).Value = datatbl(1)
            i += 1
        End While

        close_conexion()
    End Sub
    Private Sub Elimina_Zona()
        Dim sResp As String
        Dim IdZona As Integer
        Dim FilaGrilla As Integer
        sResp = InputBox("CONFIRME ELIMINACION DE ZONA.", "ELIMINACION DE ZONA", "S")
        If UCase(sResp) = "S" Then
            FilaGrilla = DataGrilla.CurrentRow.Index
            IdZona = DataGrilla.Rows(FilaGrilla).Cells(0).Value
            If IdZona <= 0 Then
                MsgBox("CODIGO DE ZONA NO ES VALIDO. DEBE SELECCIONAR ZONA A ELIMINAR.")
                Exit Sub
            End If
            sSsql = "SP_ELIMINA_ZONA "
            sSsql += Str(IdZona)
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                datatbl.Read()
                If datatbl(0) = -1 Then
                    MsgBox("NO ES POSIBLE ELIMINAR ZONA COD.:" + Format(IdZona, "####") + ". ZONA ESTA SIENDO UTILIZADA POR ALGUN SECTOR.")
                End If
            End If
            close_conexion()
            Carga_Zona()
        End If
    End Sub
    Private Sub Limpia_campos()
        txt_IDZona.Clear()
        txt_Descripcion.Clear()
    End Sub
    Private Sub Modifica_Zona()
        Dim FilaGrilla As Integer
        FilaGrilla = DataGrilla.CurrentRow.Index
        txt_IDZona.Text = DataGrilla.Rows(FilaGrilla).Cells(0).Value
        txt_Descripcion.Text = DataGrilla.Rows(FilaGrilla).Cells(1).Value
        txt_Descripcion.Focus()
    End Sub
    Private Sub Graba_Zona()
        sSsql = "SP_GRABA_ZONA "
        sSsql += Str(Val(txt_IDZona.Text)) + ","
        sSsql += "'" + txt_Descripcion.Text + "'"

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()
        close_conexion()

        MsgBox("Zona ha sido Actualizada")
        Carga_Zona()
        Limpia_campos()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Limpia_campos()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Modifica_Zona()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Elimina_Zona()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Graba_Zona()
    End Sub
End Class