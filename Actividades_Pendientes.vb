Public Class Actividades_Pendientes
    Dim iEstado_Bitacora As Integer
    Private Sub Actividades_Pendientes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Carga_lista_Vendedor(Me.cmb_IDVENDEDOR)
        Carga_Tipo_Unidad(Me.cmb_Unidad)
    End Sub
    Private Sub Limpia_Campos()
        DataGrilla.Rows.Clear()
        txt_Cantidad.Clear()
        txt_FechaEvento.Clear()
        txt_fechaRegistro.Clear()
        'txt_Hora.Clear()
        txt_IdBitacora.Clear()
        txt_respuesta.Clear()
        cmb_Estado.SelectedIndex = -1
        cmb_IDVENDEDOR.SelectedIndex = -1
        cmb_NuevoEstado.SelectedIndex = -1
        cmb_Unidad.SelectedIndex = -1
    End Sub
    Private Sub Consulta_Pendientes()
        Dim i As Integer
        Select Case cmb_Estado.Text
            Case "PENDIENTE"
                iEstado_Bitacora = 0
            Case "EN PROCESO"
                iEstado_Bitacora = 1
            Case "FINALIZADO"
                iEstado_Bitacora = 2
            Case Else
                iEstado_Bitacora = 99
        End Select
        sSsql = "SP_CONSULTA_FULL_BITACORA "
        sSsql += Str(ID_Vendedor(Me.cmb_IDVENDEDOR.SelectedIndex)) + ","
        sSsql += Str(iEstado_Bitacora)
        open()

        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        DataGrilla.Rows.Clear()

        While datatbl.Read = True
            DataGrilla.Rows.Add()
            DataGrilla.Rows(i).Cells(0).Value = datatbl(0)
            DataGrilla.Rows(i).Cells(1).Value = datatbl(2)
            DataGrilla.Rows(i).Cells(2).Value = datatbl(4)
            DataGrilla.Rows(i).Cells(3).Value = datatbl(12)
            DataGrilla.Rows(i).Cells(4).Value = datatbl(11)
            DataGrilla.Rows(i).Cells(5).Value = datatbl(5)
            DataGrilla.Rows(i).Cells(6).Value = datatbl(7)
            DataGrilla.Rows(i).Cells(7).Value = datatbl(1)
            DataGrilla.Rows(i).Cells(8).Value = datatbl(8)
            i += 1
        End While

        close_conexion()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Graba_Respuesta()
    End Sub
    Private Sub Graba_Respuesta()
        ''SP_GRABA_BITACORA_RESPUESTA
        Dim idTipoUnidad As Integer
        Dim iEstado As Integer


        If txt_respuesta.Text = "" Then
            MsgBox("DEBE INGRESAR DETALLE DE ACTIVIDADES REALIZADAS", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Val(txt_IdBitacora.Text) = 0 Then
            MsgBox("DEBE SELECCIONAR EVENTO A RESPONDER.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If cmb_NuevoEstado.SelectedIndex = -1 Then
            MsgBox("DEBE SELECCIONAR ESTADO ACTUAL DEL EVENTO.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If cmb_Unidad.SelectedIndex = -1 Then
            idTipoUnidad = 0
        Else
            idTipoUnidad = TU_ID(Me.cmb_Unidad.SelectedIndex)
        End If

        'PENDIENTE
        'EN PROCESO
        'FINALIZADO

        Select Case cmb_NuevoEstado.Text
            Case "PENDIENTE"
                iEstado = 0
            Case "EN PROCESO"
                iEstado = 1
            Case "FINALIZADO"
                iEstado = 2
        End Select

        open()
        sSsql = "SP_GRABA_BITACORA_RESPUESTA "
        sSsql += Str(txt_IdBitacora.Text) + ","
        sSsql += "'" + txt_fechaRegistro.Text + "',"
        sSsql += "'" + dtp_HoraEvento.Text + "',"
        sSsql += Str(Val(txt_Cantidad.Text)) + ","
        sSsql += Str(idTipoUnidad) + ","
        sSsql += "'" + txt_respuesta.Text + "',"
        sSsql += Str(iEstado)
        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()
        close_conexion()
        Limpia_Campos()
        MsgBox("EVENTO HA SIDO ACTUALIZADO.", MsgBoxStyle.Information)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim FilaGrilla As Integer
        If DataGrilla.Rows.Count > 0 Then
            FilaGrilla = DataGrilla.CurrentRow.Index
            txt_IdBitacora.Text = DataGrilla.Rows(FilaGrilla).Cells(0).Value
            Consulta_Bitacora_ID()
        Else
            MsgBox("No existen detalle de actividades pendientes para registrar", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub Consulta_Bitacora_ID()
        ''SP_CONSULTA_BITACORA_ID
        Dim i As Integer
        sSsql = "SP_CONSULTA_BITACORA_ID "
        sSsql += Str(Val(txt_IdBitacora.Text))

        open()

        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        datatbl.Read()

        txt_fechaRegistro.Text = datatbl(5)
        txt_FechaEvento.Text = datatbl(9).ToString

        dtp_HoraEvento.Text = datatbl(6)
        txt_Cantidad.Text = datatbl(7)

        If Val(datatbl(8)) <> 0 Then
            For i = 0 To UBound(TU_DESCRIP)
                If TU_ID(i) = datatbl(8) Then
                    cmb_Unidad.Text = TU_DESCRIP(i)
                    Exit For
                End If
            Next
        End If
        txt_respuesta.Text = datatbl(11).ToString
        txt_respuesta.Focus()
        close_conexion()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Me.cmb_IDVENDEDOR.SelectedIndex = -1 Then

            MsgBox("Debe Seleccionar Vendedor.", MsgBoxStyle.Exclamation)

            Exit Sub
        End If
        Consulta_Pendientes()
    End Sub
End Class