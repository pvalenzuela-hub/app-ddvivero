Public Class Aplic_Producto

    Private Sub Aplic_Producto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Carga_Evento(Me.cmb_Evento, "A")
        Carga_lista_Vendedor(Me.cmb_usuario)
        Carga_Insumo_Productos(Me.cmb_Insumo)
        Carga_Tipo_Unidad(Me.cmb_Unidad)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txt_NumNave.Text <> Nothing Then
            Consulta_Nros_Lote()
            DataLoteManual.Rows.Clear()
        End If

    End Sub
    Private Sub Consulta_Nros_Lote()
        ''SP_CONSULTA_LOTE_NAVE
        Dim i As Integer = 0
        sSsql = "SP_CONSULTA_LOTE_NAVE "
        sSsql += "'" + txt_NumNave.Text + "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        DataLote.Rows.Clear()

        If datatbl.HasRows Then
            While datatbl.Read = True
                DataLote.Rows.Add()
                DataLote.Rows(i).Cells(0).Value = datatbl(0)
                DataLote.Rows(i).Cells(1).Value = datatbl(3).ToString + "-" + datatbl(1)
                DataLote.Rows(i).Cells(3).Value = datatbl(2)
                i += 1
            End While
        End If
        close_conexion()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If Valida_Fase1() Then
            Agrega_Lote_Final()
        End If

    End Sub
    Function Valida_Fase1()
        Dim bRetorno As Boolean = True
        If cmb_usuario.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Usuario", MsgBoxStyle.Critical)
            bRetorno = False
        End If
        If cmb_Evento.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Evento", MsgBoxStyle.Critical)
            bRetorno = False
        End If
        If cmb_Insumo.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Insumo", MsgBoxStyle.Critical)
            bRetorno = False
        End If
        If rdb_PorNave.Checked = True Then
            If txt_NumNave.Text = Nothing Then
                MsgBox("Debe Ingresar N° Nave", MsgBoxStyle.Critical)
                bRetorno = False
            End If
        End If
      
        Valida_Fase1 = bRetorno
    End Function
    Private Sub Agrega_Lote_Final()
        Dim i, j As Integer
        j = DataLoteFinal.Rows.Count
        If j = -1 Then
            j = 0
        End If
        For i = 0 To DataLote.Rows.Count - 1
            If DataLote.Rows(i).Cells(2).Value = True Then
                If Chequea_Lote_Repetido(DataLote.Rows(i).Cells(0).Value) Then
                    DataLoteFinal.Rows.Add()
                    DataLoteFinal.Rows(j).Cells(0).Value = DataLote.Rows(i).Cells(0).Value
                    DataLoteFinal.Rows(j).Cells(1).Value = DataLote.Rows(i).Cells(1).Value
                    DataLoteFinal.Rows(j).Cells(3).Value = txt_Comentario.Text
                    DataLoteFinal.Rows(j).Cells(4).Value = DataLote.Rows(i).Cells(3).Value
                    j += 1
                End If
            End If
        Next
    End Sub
    Function Chequea_Lote_Repetido(ByVal sNumLote As String)
        Dim bRetorno As Boolean = True

        For x As Integer = 0 To DataLoteFinal.Rows.Count - 1
            If sNumLote = DataLoteFinal.Rows(x).Cells(0).Value Then
                MsgBox("No se Permite Repetir N° de Lote, ya seleccionado", MsgBoxStyle.Critical)
                bRetorno = False
                Exit For
            End If
        Next

        Chequea_Lote_Repetido = bRetorno
    End Function
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        REM Marcar Todos
        For i As Integer = 0 To DataLote.Rows.Count - 1
            DataLote.Rows(i).Cells(2).Value = True
        Next
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        REM Desmarcar Todos
        For i As Integer = 0 To DataLote.Rows.Count - 1
            DataLote.Rows(i).Cells(2).Value = False
        Next
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        DataLoteFinal.Rows.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If cmb_Unidad.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Tipo de Unidad", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Distribucion_Plantas()
    End Sub
    Private Sub Distribucion_Plantas()
        Dim dCantTotal As Double = 0
        Dim dTotalPlantas As Double = 0
        Dim dFactor As Double = 0

        dCantTotal = Val(txt_CantidadTotal.Text)
        If dCantTotal > 0 Then
            For i As Integer = 0 To DataLoteFinal.Rows.Count - 1
                dTotalPlantas += DataLoteFinal.Rows(i).Cells(4).Value
            Next
            dFactor = dCantTotal / dTotalPlantas

            For i As Integer = 0 To DataLoteFinal.Rows.Count - 1
                DataLoteFinal.Rows(i).Cells(2).Value = Math.Round(dFactor * DataLoteFinal.Rows(i).Cells(4).Value, 6, MidpointRounding.AwayFromZero)
            Next

        End If
       
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim i As Integer = 0
        Try
            i = DataLoteFinal.CurrentCell.RowIndex

            If i > -1 And DataLoteFinal.Rows.Count > 0 Then
                DataLoteFinal.Rows.RemoveAt(i)
            End If
            Distribucion_Plantas()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Valida_Fase1() And Valida_Fase2() Then
            Graba_Aplicacion()
        End If
    End Sub
    Function Valida_Fase2()
        Dim bretorno As Boolean = True

        If DataLoteFinal.Rows.Count < 0 Then
            MsgBox("No existen Lotes Asignados", MsgBoxStyle.Critical)
            bretorno = False
        End If

        If txt_CantidadTotal.Text = Nothing Then
            MsgBox("Cantidad de Producto Aplicada no definida.", MsgBoxStyle.Critical)
            bretorno = False
        End If

        If cmb_Unidad.SelectedIndex = -1 Then
            MsgBox("Unidad de Producto No identificada.", MsgBoxStyle.Critical)
            bretorno = False
        End If

        For i As Integer = 0 To DataLoteFinal.Rows.Count - 1
            If DataLoteFinal.Rows(i).Cells(2).Value = Nothing Or DataLoteFinal.Rows(i).Cells(2).Value = 0 Then
                MsgBox("Falta Distribuir Producto aplicado en Lotes", MsgBoxStyle.Critical)
                bretorno = False
                Exit For
            End If
        Next

        Valida_Fase2 = bretorno
    End Function
    Private Sub Graba_Aplicacion()
        '@NumLote numeric(18,0),
        '@Evento varchar(50),
        '@Insumo varchar(50),
        '@Fecha datetime,
        '@Hora varchar(5),
        '@Usuario varchar(50),
        '@Cantidad float,
        '@Unidad varchar(50),
        '@Comentarios varchar(200)
        open()
        For i As Integer = 0 To DataLoteFinal.Rows.Count - 1

            sSsql = "SP_Graba_Aplic_Prod "
            sSsql += DataLoteFinal.Rows(i).Cells(0).Value.ToString + ","
            sSsql += "'" + cmb_Evento.Text + "',"
            sSsql += "'" + cmb_Insumo.Text + "',"
            sSsql += "'" + Format(dtp_FechaAplic.Value, "dd/MM/yyyy") + "',"
            sSsql += "'" + Format(dtp_HoraAplic.Value, "T") + "',"
            sSsql += "'" + cmb_usuario.Text + "',"
            sSsql += Reemplaza_Comas(DataLoteFinal.Rows(i).Cells(2).Value.ToString) + ","
            sSsql += "'" + cmb_Unidad.Text + "',"
            sSsql += "'" + txt_Comentario.Text + "'"
            command = connection.CreateCommand()
            command.CommandText = sSsql
            command.ExecuteNonQuery()

        Next
        close_conexion()
        MsgBox("Registro de Aplicación de Productos ha sido guardado.", MsgBoxStyle.Information)
        'Limpia_Campos()
    End Sub
    Private Sub Limpia_Campos()
        cmb_Evento.SelectedIndex = -1
        cmb_Insumo.SelectedIndex = -1
        cmb_Unidad.SelectedIndex = -1
        cmb_usuario.SelectedIndex = -1
        txt_CantidadTotal.Clear()
        txt_Comentario.Clear()
        txt_NumNave.Clear()
        DataLote.Rows.Clear()
        DataLoteFinal.Rows.Clear()
        DataLoteManual.Rows.Clear()
        txt_NumFilas.Value = 0
        dtp_FechaAplic.Value = Now
        dtp_HoraAplic.Value = Now
    End Sub

    Private Sub cmb_Insumo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Insumo.SelectedIndexChanged
        sSsql = "SP_CONSULTA_Insumo "
        sSsql += "'" + cmb_Insumo.Text + "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        
        If datatbl.HasRows Then
            datatbl.Read()
            txt_Comentario.Text = datatbl(2)
        End If
        close_conexion()
    End Sub



    Private Sub cmb_usuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_usuario.SelectedIndexChanged
      
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim i, j As Integer
        If DataLoteManual.Rows.Count >= 0 Then
            ' open()
            command = connection.CreateCommand()

            j = DataLoteFinal.Rows.Count
            If j = -1 Then
                j = 0
            End If

            For i = 0 To DataLoteManual.Rows.Count - 1
                If DataLoteManual.Rows(i).Cells(0).Value > 0 Then
                    If Chequea_Lote_Repetido(DataLoteManual.Rows(i).Cells(0).Value) Then
                        sSsql = "SP_CONSULTA_DETALLE_LOTE "
                        sSsql += DataLoteManual.Rows(i).Cells(0).Value.ToString
                        open()
                        command = connection.CreateCommand()
                        command.CommandText = sSsql
                        datatbl = command.ExecuteReader()
                        If datatbl.HasRows Then
                            datatbl.Read()
                            If datatbl(31) = 0 Then
                                MsgBox("Lote N° " & DataLoteManual.Rows(i).Cells(0).Value.ToString & ". No Tiene Saldo de Plantas.", MsgBoxStyle.Exclamation)
                            Else

                                DataLoteFinal.Rows.Add()
                                DataLoteFinal.Rows(j).Cells(0).Value = DataLoteManual.Rows(i).Cells(0).Value
                                DataLoteFinal.Rows(j).Cells(1).Value = datatbl(40).ToString + "-" + datatbl(52)
                                DataLoteFinal.Rows(j).Cells(3).Value = txt_Comentario.Text
                                DataLoteFinal.Rows(j).Cells(4).Value = datatbl(31)
                                j += 1
                            End If
                        Else
                            MsgBox("N° de Lote " & DataLoteManual.Rows(i).Cells(0).Value.ToString & ". No Existe.", MsgBoxStyle.Exclamation)
                        End If
                        close_conexion()
                    End If
                Else
                    Exit For
                End If
            Next

        End If

      
       
    End Sub

    Private Sub rdb_PorNave_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_PorNave.CheckedChanged
        If rdb_PorNave.Checked = True Then
            DataLoteManual.Rows.Clear()
        End If
    End Sub

    Private Sub rdb_PorLote_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_PorLote.CheckedChanged
        If rdb_PorLote.Checked = True Then
            DataLote.Rows.Clear()
            DataLoteManual.Rows.Clear()
            For i As Integer = 1 To 100
                DataLoteManual.Rows.Add()
            Next
        End If
    End Sub

    Private Sub cmb_Evento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Evento.SelectedIndexChanged

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        For i As Integer = 1 To txt_NumFilas.Value
            DataLoteManual.Rows.Add()
        Next
    End Sub
End Class