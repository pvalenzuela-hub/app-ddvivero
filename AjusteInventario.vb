Public Class AjusteInventario

    Private Sub cmb_Especie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Especie.SelectedIndexChanged
        If cmb_Especie.SelectedIndex > -1 Then
            Consulta_Kardex()
            Carga_Variedad_Filtro(cmb_Variedad, cmb_Especie.Text)
        End If
    End Sub
    Private Sub Limpia_Campos()
        cmb_Especie.SelectedIndex = -1
        cmb_Variedad.SelectedIndex = -1
        cmb_TipoMovto.SelectedIndex = -1
        txt_Cantidad.Clear()
        txt_Concepto.Clear()
        txt_NumLote.Clear()
    End Sub
    Private Sub Consulta_Kardex()
        Dim i As Integer
        sSsql = "SP_CONSULTA_MovimientoKardex "
        sSsql += "'" + cmb_Especie.Text + "'"
        open()

        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        DataGrilla.Rows.Clear()
        If datatbl.HasRows Then
            i = 0

            While datatbl.Read = True
                DataGrilla.Rows.Add()
                DataGrilla.Rows(i).Cells(0).Value = datatbl(0)
                DataGrilla.Rows(i).Cells(1).Value = datatbl(1)
                DataGrilla.Rows(i).Cells(2).Value = datatbl(2)
                DataGrilla.Rows(i).Cells(3).Value = datatbl(3)
                DataGrilla.Rows(i).Cells(4).Value = datatbl(4)
                DataGrilla.Rows(i).Cells(5).Value = datatbl(5)
                DataGrilla.Rows(i).Cells(6).Value = datatbl(6)
                DataGrilla.Rows(i).Cells(7).Value = datatbl(7)
                DataGrilla.Rows(i).Cells(8).Value = datatbl(8)
                i += 1
            End While

        End If
        close_conexion()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Agregar_Datos_Movimiento()
    End Sub


    Private Sub Agregar_Datos_Movimiento()
        Dim i As Integer

        If cmb_Especie.SelectedIndex = -1 Then
            MsgBox("Seleccione Especie")
            Exit Sub
        End If

        If cmb_Variedad.SelectedIndex = -1 Then
            MsgBox("Seleccione Variedad")
            Exit Sub
        End If

        If cmb_TipoMovto.SelectedIndex = -1 Then
            MsgBox("Seleccione Tipo de Movimiento")
            Exit Sub
        End If

        If Val(txt_Cantidad.Text) = 0 Then
            MsgBox("Cantidad debe ser mayor a Cero")
            Exit Sub
        End If

        If txt_Concepto.Text = Nothing Or txt_Concepto.Text = "" Then
            MsgBox("Debe Ingresar Concepto para el Movimiento de Inventario")
            Exit Sub
        End If

        If txt_NumLote.Text <> Nothing Or Val(txt_NumLote.Text) > 0 Then
            If Not Valida_Lote(Val(txt_NumLote.Text)) Then
                Exit Sub
            End If
        End If
        Try
            DataGrilla.Rows.Add()
            i = DataGrilla.Rows.Count - 1
            DataGrilla.Rows(i).Cells(0).Value = "0"
            DataGrilla.Rows(i).Cells(1).Value = Now.Date
            DataGrilla.Rows(i).Cells(2).Value = cmb_Especie.Text
            DataGrilla.Rows(i).Cells(3).Value = cmb_Variedad.Text
            DataGrilla.Rows(i).Cells(4).Value = Mid(cmb_TipoMovto.Text, 1, 1)
            DataGrilla.Rows(i).Cells(5).Value = txt_Cantidad.Text
            DataGrilla.Rows(i).Cells(6).Value = txt_Concepto.Text
            DataGrilla.Rows(i).Cells(7).Value = txt_NumLote.Text
            DataGrilla.Rows(i).Cells(8).Value = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Valida_Lote(iNumLote As Integer) As Boolean
        Dim bRetorno As Boolean = False

        sSsql = "SP_CONSULTA_DETALLE_LOTE "
        sSsql += iNumLote.ToString
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            bRetorno = True
        Else
            bRetorno = False
            MsgBox("No Existe N° de Lote")
        End If

        close_conexion()

        Valida_Lote = bRetorno
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Elimina_Movimieto()
    End Sub

    Private Sub Elimina_Movimieto()
        Dim fila As Integer
        Try
            fila = DataGrilla.CurrentCell.RowIndex
            If DataGrilla.Rows(fila).Cells(8).Value = 0 Then
                If fila > -1 AndAlso DataGrilla.Rows.Count > 0 Then
                    'Dim idKardex As Integer = DataGrilla.Rows(fila).Cells(0).Value
                    'If (idKardex > 0) Then
                    '    'sSsql = "SP_Actualiza_Elimina_Variedad_MovimientoKardex "
                    '    'sSsql += idKardex.ToString()
                    '    'open()
                    '    'command = connection.CreateCommand
                    '    'command.CommandText = sSsql
                    '    'command.ExecuteNonQuery()
                    '    'close_conexion()
                    'End If
                    DataGrilla.Rows.RemoveAt(fila)
                End If
            Else
                MsgBox("No es posible Eliminar Movimiento Actualizado. Debe Corregir Inventario en forma manual.")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Graba_Movimientos_Kardex()
    End Sub


    Private Sub Graba_Movimientos_Kardex()
        Dim i As Integer
        open()
        For i = 0 To DataGrilla.Rows.Count - 1
            If DataGrilla.Rows(i).Cells(0).Value = 0 Then
                sSsql = "SP_Actualiza_MovimientoKardex "
                sSsql += "'" & DataGrilla.Rows(i).Cells(3).Value & "',"
                sSsql += "'" & DataGrilla.Rows(i).Cells(2).Value & "',"
                sSsql += "'" & DataGrilla.Rows(i).Cells(4).Value & "',"
                sSsql += Val(DataGrilla.Rows(i).Cells(5).Value).ToString & ","
                sSsql += "'" & DataGrilla.Rows(i).Cells(6).Value & "',"
                sSsql += Val(DataGrilla.Rows(i).Cells(7).Value).ToString
                command = connection.CreateCommand
                command.CommandText = sSsql
                command.ExecuteNonQuery()
            End If
        Next
        close_conexion()
        Consulta_Kardex()
        Limpia_Campos()
        MsgBox("Movimiento de Invetario ha sido Actualizado")
    End Sub



    Private Sub AjusteInventario_Load(sender As Object, e As EventArgs) Handles Me.Load
        Carga_Familia_Prod(cmb_Especie)
    End Sub

    Private Sub cmb_Variedad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Variedad.SelectedIndexChanged
        If cmb_Variedad.SelectedIndex > -1 Then
            sSsql = "SP_Consulta_Stock_Variedad "
            sSsql += "'" + cmb_Variedad.Text + "',"
            sSsql += "'" + cmb_Especie.Text + "'"
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                datatbl.Read()
                txt_StockActual.Text = datatbl(0)
                txt_StockReservado.Text = datatbl(1)
                txt_StockDisponible.Text = datatbl(0) - datatbl(1)
            End If
            close_conexion()
        End If
    End Sub

    Private Sub cmb_TipoMovto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_TipoMovto.SelectedIndexChanged

    End Sub
End Class