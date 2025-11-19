Public Class Devolucion_Bandejas
    Dim iSaldoporDevolver As Integer

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Recupera_Guia()
    End Sub
    Private Sub Limpia_Campos()
        'txt_FECHA_GUIA.Text = ""
        'txt_NumLote.Text = ""
        'txt_CantPlantas.Text = ""
        'txt_BandRetiradas.Text = ""
        'txt_BandDevol.Text = ""
        'txt_FechaDevol.Text = ""
        'txt_NombreCliente.Text = ""
        'txt_Semilla.Text = ""
        'txt_Variedad.Text = ""
        txt_NuevaBandDevol.Text = ""
        'txt_NuevaFechaDevol.Text = ""
        'txt_SaldoBandejas.Text = ""
        DataGuia.Rows.Clear()
        'txt_Cliente.Clear()
        'txt_clientebuscar.Clear()
        'txt_IdCliente.Clear()
        txt_TotalBandPendientes.Clear()
        txt_TotalDevueltas.Clear()
        txtTotBandRet.Clear()
        cmb_TipoBandeja.SelectedIndex = -1

    End Sub
   
   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If Val(txt_NuevaBandDevol.Text) > iSaldoporDevolver Then
        '    MsgBox("BANDEJAS PENDIENTES : " & Format(iSaldoporDevolver, "###"))
        '    Exit Sub
        'End If
        'Grabar_Devolucion()
        GrabaDevolucion()
    End Sub
    Private Sub GrabaDevolucion()
        open()
        command = connection.CreateCommand()
        Try
            For i As Integer = 0 To DataGuia.Rows.Count - 1
                If DataGuia.Rows(i).Cells(11).Value > 0 Then
                    sSsql = "SP_GRABA_DEVOLUCION_BANDEJA "
                    sSsql += DataGuia.Rows(i).Cells(0).Value.ToString + ","
                    sSsql += "'" + dtp_FechaDevol.Value + "',"
                    sSsql += DataGuia.Rows(i).Cells(11).Value.ToString

                    command.CommandText = sSsql
                    command.ExecuteNonQuery()

                End If
            Next
            MsgBox("Datos han sido Actualizados", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        close_conexion()
        Limpia_Campos()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Buscar_Cliente(Me.cmb_clientebuscar, txt_clientebuscar.Text)
        gNOMBRE = txt_clientebuscar.Text
        If chkCliente.Checked = True Then
            BusquedaCliente.chkIncluyePrimerNombre.Checked = True
        Else
            BusquedaCliente.chkIncluyePrimerNombre.Checked = False
        End If
        gQuienLlama = 6
        BusquedaCliente.Visible = True
        'Limpia_Campos()
    End Sub

    Private Sub cmb_clientebuscar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'gID_cliente = zIDCliente(Me.cmb_clientebuscar.SelectedIndex)
        Carga_Guias_Cliente()
    End Sub
    Private Sub Carga_Guias_Cliente()
        Dim iTotalBandReti As Integer = 0
        Dim iTotalBandPend As Integer = 0
        Dim iTotalBandDevol As Integer = 0
        Dim i As Integer = 0
        open()
        sSsql = "SP_CONSULTA_GUIA_CLIENTE "
        sSsql += Val(txt_IdCliente.Text).ToString + ","
        sSsql += "'" + cmb_TipoBandeja.Text + "',"
        If chk_Todo.Checked = False Then
            sSsql += "1"
        Else
            sSsql += "0"
        End If
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        DataGuia.Rows.Clear()


        If datatbl.HasRows Then
            While datatbl.Read()
                DataGuia.Rows.Add()
                DataGuia.Rows(i).Cells(0).Value = datatbl(0)
                DataGuia.Rows(i).Cells(1).Value = datatbl(1)
                DataGuia.Rows(i).Cells(2).Value = datatbl(2)
                DataGuia.Rows(i).Cells(3).Value = datatbl(3)
                DataGuia.Rows(i).Cells(4).Value = datatbl(4)
                DataGuia.Rows(i).Cells(5).Value = datatbl(5)
                DataGuia.Rows(i).Cells(6).Value = datatbl(6)
                DataGuia.Rows(i).Cells(7).Value = datatbl(7)
                DataGuia.Rows(i).Cells(8).Value = datatbl(8)
                DataGuia.Rows(i).Cells(9).Value = datatbl(10)
                DataGuia.Rows(i).Cells(10).Value = datatbl(9)
                i += 1
                iTotalBandReti += datatbl(4)
                iTotalBandDevol += datatbl(5)
                iTotalBandPend += datatbl(9)

            End While
        Else
            MsgBox("CLIENTE NO TIENE GUIAS VIGENTES")
        End If
        datatbl.Close()
        close_conexion()
        txtTotBandRet.Text = iTotalBandReti.ToString("###,##0")
        txt_TotalDevueltas.Text = Format(iTotalBandDevol, "###,##0")
        txt_TotalBandPendientes.Text = Format(iTotalBandPend, "###,##0")
    End Sub

 

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        'If Val(txt_Nguia.Text) = 0 Then
        ' MsgBox("Debe Seleccionar Nº de Guía.")
        'Exit Sub
        'End If
        'Grabar_Devolucion()
        Dim sSaldoBandeja As Integer = 0
        sSaldoBandeja = Val(txt_NuevaBandDevol.Text)
        ' Limpiar columna bandejas
        For i As Integer = 0 To DataGuia.Rows.Count - 1
            DataGuia.Rows(i).Cells(11).Value = 0

        Next
        For i As Integer = 0 To DataGuia.Rows.Count - 1
            If sSaldoBandeja > 0 Then
                If sSaldoBandeja >= DataGuia.Rows(i).Cells(10).Value Then
                    DataGuia.Rows(i).Cells(11).Value = DataGuia.Rows(i).Cells(10).Value
                    sSaldoBandeja -= DataGuia.Rows(i).Cells(10).Value
                Else
                    DataGuia.Rows(i).Cells(11).Value = sSaldoBandeja
                    sSaldoBandeja = 0
                End If
            End If
        Next
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cmb_TipoBandeja.SelectedIndex = -1 Then
            MsgBox("Selecione Tipo de Bandeja", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Carga_Guias_Cliente()
    End Sub

    Private Sub Devolucion_Bandejas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Carga_Tipo_Bandeja(Me.cmb_TipoBandeja)
        txt_IdCliente.Text = 0
    End Sub

    Private Sub btnEmiteGuia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmiteGuia.Click

        If Val(txt_IdCliente.Text) = 0 Then
            MsgBox("Ingrese Cliente al que desea realizar devolución de Bandejas.")
            Exit Sub
        End If
        If cmb_TipoBandeja.SelectedIndex = -1 Then
            MsgBox("Selecione Tipo de Bandeja", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Carga_Guias_Cliente()
    End Sub

 

End Class