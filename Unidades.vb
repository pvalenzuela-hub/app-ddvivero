Public Class Unidades

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
    Private Sub Carga_Lista_Full_Unidades()
        Dim i As Integer
        sSsql = "SP_CONSULTA_FULL_UNIDADES"
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
    Private Sub Graba_Unidades()
        sSsql = "SP_GRABA_UNIDADES "
        sSsql += Str(Val(txt_IDUnidad.Text)) + ","
        sSsql += "'" + txt_Descripcion.Text + "'"

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()
        close_conexion()
        Carga_Lista_Full_Unidades()
        Limpia_campos()
    End Sub
    Private Sub Limpia_campos()
        txt_IDUnidad.Text = ""
        txt_Descripcion.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Graba_Unidades()
    End Sub
    Private Sub Modifica_Unidades()
        Dim FilaGrilla As Integer
        FilaGrilla = DataGrilla.CurrentRow.Index
        txt_IDUnidad.Text = DataGrilla.Rows(FilaGrilla).Cells(0).Value
        txt_Descripcion.Text = DataGrilla.Rows(FilaGrilla).Cells(1).Value
        txt_Descripcion.Focus()
    End Sub
    Private Sub Elimina_Unidades()
        Dim sResp As String
        Dim IdUnidad As Integer
        Dim FilaGrilla As Integer
        sResp = InputBox("CONFIRME ELIMINACION DE UNIDADES EN EL SISTEMA", "ELIMINACION DE UNIDADES", "S")
        If UCase(sResp) = "S" Then
            FilaGrilla = DataGrilla.CurrentRow.Index
            IdUnidad = DataGrilla.Rows(FilaGrilla).Cells(0).Value
            If IdUnidad <= 0 Then
                MsgBox("IDENTIFICADOR DE UNIDAD NO ES VALIDO. DEBE SELECCIONAR UNIDAD A ELIMINAR.")
                Exit Sub
            End If
            sSsql = "SP_ELIMINA_UNIDAD "
            sSsql += Str(IdUnidad)
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                datatbl.Read()
                If datatbl(0) = -1 Then
                    MsgBox("NO ES POSIBLE ELIMINAR UNIDAD ID.:" + Format(IdUnidad, "####") + ". EXISTEN FORMULAS UTILIZANDO ESTE TIPO DE UNIDAD.")
                End If
            End If
            close_conexion()
            Carga_Lista_Full_Unidades()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Elimina_Unidades()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Modifica_Unidades()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Limpia_campos()
        txt_Descripcion.Focus()
    End Sub

    Private Sub Unidades_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Carga_Lista_Full_Unidades()
        txt_Descripcion.Focus()
    End Sub
End Class