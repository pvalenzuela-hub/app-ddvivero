Public Class Sector
    Private Sub Sector_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Carga_Lista_Full_Sectores()
        Carga_Full_Zona(cmb_Zona)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If cmb_Zona.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Zona")
            Exit Sub
        End If

        If txt_Descripcion.Text = Nothing Then
            MsgBox("Debe Ingresar Descripción")
            Exit Sub
        End If

        If Val(txtOrden.Text) <= 0 Then
            MsgBox("Debe Ingresar Orden")
            Exit Sub
        End If

        Graba_Sector()
    End Sub
    Private Sub Graba_Sector()
        sSsql = "SP_GRABA_SECTOR "
        sSsql += Str(Val(txt_IDSector.Text)) + ","
        sSsql += "'" + txt_Descripcion.Text + "',"
        sSsql += "'" + cmb_Zona.Text + "',"
        sSsql += Val(txtOrden.Text).ToString

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()
        close_conexion()

        MsgBox("Sector ha sido Actualizado")
        Carga_Lista_Full_Sectores()
        Limpia_campos()

    End Sub
    Private Sub Limpia_campos()
        txt_IDSector.Clear()
        txt_Descripcion.Clear()
        txtOrden.Clear()
        cmb_Zona.SelectedIndex = -1
    End Sub
    Private Sub Modifica_Sector()
        Dim FilaGrilla As Integer
        FilaGrilla = DataGrilla.CurrentRow.Index
        txt_IDSector.Text = DataGrilla.Rows(FilaGrilla).Cells(0).Value
        txt_Descripcion.Text = DataGrilla.Rows(FilaGrilla).Cells(1).Value
        cmb_Zona.SelectedItem = DataGrilla.Rows(FilaGrilla).Cells(2).Value
        If IsNumeric(DataGrilla.Rows(FilaGrilla).Cells(3).Value) = False Then
            txtOrden.Text = "0"
        Else
            txtOrden.Text = DataGrilla.Rows(FilaGrilla).Cells(3).Value
        End If

        txt_Descripcion.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Modifica_Sector()
    End Sub
    Private Sub Elimina_Sector()
        Dim sResp As String
        Dim IdSector As Integer
        Dim FilaGrilla As Integer
        sResp = InputBox("CONFIRME ELIMINACION DE SECTOR.", "ELIMINACION DE SECTOR", "S")
        If UCase(sResp) = "S" Then
            FilaGrilla = DataGrilla.CurrentRow.Index
            IdSector = DataGrilla.Rows(FilaGrilla).Cells(0).Value
            If IdSector <= 0 Then
                MsgBox("IDENTIFICADOR DE SECTOR NO ES VALIDO. DEBE SELECCIONAR SECTOR A ELIMINAR.")
                Exit Sub
            End If
            sSsql = "SP_ELIMINA_SECTOR "
            sSsql += Str(IdSector)
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                datatbl.Read()
                If datatbl(0) = -1 Then
                    MsgBox("NO ES POSIBLE ELIMINAR SECTOR ID.:" + Format(IdSector, "####") + ". EXISTEN DIRECCIONES DE CLIENTES ASOCIADAS A ESTE SECTOR.")
                End If
            End If
            close_conexion()
            Carga_Lista_Full_Sectores()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Elimina_Sector()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Private Sub Carga_Lista_Full_Sectores()
        Dim i As Integer
        sSsql = "SP_CONSULTA_FULL_SECTOR"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        DataGrilla.Rows.Clear()

        While datatbl.Read = True
            DataGrilla.Rows.Add()
            DataGrilla.Rows(i).Cells(0).Value = datatbl(0)
            DataGrilla.Rows(i).Cells(1).Value = datatbl(1)
            DataGrilla.Rows(i).Cells(2).Value = datatbl(2)
            DataGrilla.Rows(i).Cells(3).Value = datatbl(3)
            i += 1
        End While

        close_conexion()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Limpia_campos()
    End Sub
End Class