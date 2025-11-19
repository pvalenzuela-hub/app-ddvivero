Public Class TipoBandeja

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
    Private Sub Carga_Lista_Full_Tipo_Bandeja()
        Dim i As Integer
        sSsql = "SP_CONSULTA_FULL_TIPOBANDEJA"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        DataGrilla.Rows.Clear()

        While datatbl.Read = True
            DataGrilla.Rows.Add()
            DataGrilla.Rows(i).Cells(0).Value = datatbl(0)
            DataGrilla.Rows(i).Cells(1).Value = datatbl(1)
            DataGrilla.Rows(i).Cells(2).Value = Format(datatbl(2), "###,##0")
            i += 1
        End While

        close_conexion()
    End Sub

    Private Sub TipoBandeja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Carga_Lista_Full_Tipo_Bandeja()
    End Sub
    Private Sub Graba_Tipo_Bandeja()
        sSsql = "SP_GRABA_TIPO_BANDEJA "
        sSsql += Str(Val(txt_IDTipoBandeja.Text)) + ","
        sSsql += "'" + txt_Descripcion.Text + "',"
        sSsql += Str(Val(txt_Cantidad.Text))

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()
        close_conexion()
        Carga_Lista_Full_Tipo_Bandeja()
        Limpia_campos()
    End Sub
    Private Sub Modifica_Tipo_Bandeja()
        Dim FilaGrilla As Integer
        FilaGrilla = DataGrilla.CurrentRow.Index
        txt_IDTipoBandeja.Text = DataGrilla.Rows(FilaGrilla).Cells(0).Value
        txt_Descripcion.Text = DataGrilla.Rows(FilaGrilla).Cells(1).Value
        txt_Cantidad.Text = DataGrilla.Rows(FilaGrilla).Cells(2).Value
        txt_Descripcion.Focus()
    End Sub
    Private Sub Elimina_Tipo_Bandeja()
        Dim sResp As String
        Dim IdTipoBandeja As Integer
        Dim FilaGrilla As Integer
        sResp = InputBox("CONFIRME ELIMINACION TIPO DE BANDEJA.", "ELIMINACION TIPO DE BANDEJA", "S")
        If UCase(sResp) = "S" Then
            FilaGrilla = DataGrilla.CurrentRow.Index
            IdTipoBandeja = DataGrilla.Rows(FilaGrilla).Cells(0).Value
            If IdTipoBandeja <= 0 Then
                MsgBox("IDENTIFICADOR DE TIPO DE BANDEJA NO ES VALIDO. DEBE SELECCIONAR TIPO DE BANDEJA A ELIMINAR.")
                Exit Sub
            End If
            sSsql = "SP_ELIMINA_TIPO_BANDEJA "
            sSsql += Str(IdTipoBandeja)
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                datatbl.Read()
                If datatbl(0) = -1 Then
                    MsgBox("NO ES POSIBLE ELIMINAR TIPO DE BANDEJA ID.:" + Format(IdTipoBandeja, "####") + ". EXISTEN PEDIDOS UTILIZANDO ESTE TIPO DE BANDEJA.")
                End If
            End If
            close_conexion()
            Carga_Lista_Full_Tipo_Bandeja()
        End If
    End Sub
    Private Sub Limpia_campos()
        txt_IDTipoBandeja.Text = ""
        txt_Descripcion.Text = ""
        txt_Cantidad.Text = ""
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Limpia_campos()
        txt_Descripcion.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Modifica_Tipo_Bandeja()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Elimina_Tipo_Bandeja()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Graba_Tipo_Bandeja()
    End Sub
End Class