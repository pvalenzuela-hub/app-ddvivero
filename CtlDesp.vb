Public Class CtlDesp
    Dim iNumDesp As Integer
    Private Sub CtlDesp_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim sResp = MsgBox("Ir a Despachos?", MsgBoxStyle.YesNo, "Preparación Despachos")
        If sResp = MsgBoxResult.Yes Then
            Despacho.txtNumDesp.Text = iNumDesp
            Despacho.Show()
        End If
    End Sub
    Private Sub CtlDesp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub DateTimePicker1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker1.LostFocus

        LecturaDatosporFecha()

    End Sub

    Private Sub SumaBandejas()
        Dim iTotBand As Integer = 0
        For i As Integer = 0 To GrillaDespacho.Rows.Count - 1
            iTotBand += GrillaDespacho.Rows(i).Cells(9).Value
        Next
        txtTotalBand.Text = iTotBand.ToString("###,##0")
    End Sub
    Private Sub LimpiaCampos()
        DateTimePicker1.Value = Format(Now, "d")
        txtNomChofer.Clear()
        txtPatente.Clear()
        txtTotalBand.Clear()
        cmbEstado.SelectedIndex = -1
    End Sub
    Private Sub LecturaDatosporFecha()
        Dim i As Integer
        '0 EstCtl,

        '1 NumLote,
        '2 d.APELLIDO+' '+d.NOMBRE Nombre,
        '3 LTRIM(d.TELEFONOS) Fono,
        '4 b.CANTIDAD Pedido,
        '5 b.Saldo_Plantas,
        '6 a.Band,
        '7 IsNull(RTRIM(CONVERT(Char,a.FechaDesp,103)),'') FecDesp,
        '8 ISNULL(a.AcdoCom,'') Acuerdo,
        '9 f.DESCRIP,
        '10 e.Descripcion,
        '11 g.Nombre Sector,
        '12 h.Nombre Zona
        sSsql = "SP_ConsultaCtlDespConf "
        sSsql += "'" + DateTimePicker1.Value.ToString("d") + "'"
        GrillaDespacho.Rows.Clear()
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then

            While datatbl.Read
                GrillaDespacho.Rows.Add()
                GrillaDespacho.Rows(i).Cells(1).Value = datatbl(1)
                GrillaDespacho.Rows(i).Cells(2).Value = datatbl(11)
                GrillaDespacho.Rows(i).Cells(3).Value = datatbl(12)
                GrillaDespacho.Rows(i).Cells(4).Value = datatbl(2)
                GrillaDespacho.Rows(i).Cells(5).Value = datatbl(3)
                GrillaDespacho.Rows(i).Cells(6).Value = datatbl(8)
                GrillaDespacho.Rows(i).Cells(7).Value = datatbl(9)
                GrillaDespacho.Rows(i).Cells(8).Value = datatbl(10)
                GrillaDespacho.Rows(i).Cells(9).Value = datatbl(6)
                i += 1
            End While

            SumaBandejas()

        Else
            MsgBox("No existen Lotes para Despachar en la fecha seleccionada.")
            LimpiaCampos()
        End If
        close_conexion()
    End Sub



    Private Sub CompletaOrden()
        Dim dCont As Double
        For i As Integer = 0 To GrillaDespacho.Rows.Count - 1
            If GrillaDespacho.Rows(i).Cells(0).Value = Nothing Then
                dCont += 1
                For j = 0 To GrillaDespacho.Rows.Count - 1
                    If dCont = GrillaDespacho.Rows(j).Cells(0).Value Then
                        dCont += 1
                    End If
                Next
                GrillaDespacho.Rows(i).Cells(0).Value = dCont
            End If
        Next
        'DataGridView1.Columns(0).SortMode = DataGridViewColumnSortMode.Programmatic
        ' DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

    End Sub



    Private Sub GrabaDespacho()

        Dim i As Integer

        open()

        Try



            sSsql = "SP_ActualizaDespH "
            sSsql += "0,"
            sSsql += "'" + DateTimePicker1.Value + "',"
            sSsql += "'" + txtNomChofer.Text + "',"
            sSsql += "'" + txtPatente.Text + "',"
            sSsql += cmbEstado.SelectedIndex.ToString

            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                datatbl.Read()
                iNumDesp = datatbl(0)

                datatbl.Close()

                For i = 0 To GrillaDespacho.Rows.Count - 1
                    sSsql = "SP_ActualizaDespD "
                    sSsql += iNumDesp.ToString + ","
                    sSsql += GrillaDespacho.Rows(i).Cells(1).Value.ToString + ","
                    sSsql += GrillaDespacho.Rows(i).Cells(0).Value.ToString
                    command.CommandText = sSsql
                    command.ExecuteNonQuery()
                Next

                MsgBox("Se ha creado el Despacho Nº : " & iNumDesp.ToString)
                LimpiaCampos()
                GrillaDespacho.Rows.Clear()
            End If





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        close_conexion()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim bValida As Boolean = True
        Dim sMsgError As String = ""

        If txtNomChofer.Text = Nothing Then
            sMsgError += "Falta ingresar nombre del chofer."
            bValida = False
        End If
        If txtPatente.Text = Nothing Then
            sMsgError += "Falta ingresar Patente vehículo."
            bValida = False
        End If
        If Val(txtTotalBand.Text) = 0 Then
            sMsgError += "No existen Bandejas para el Despacho."
            bValida = False
        End If
        If cmbEstado.SelectedIndex = -1 Then
            sMsgError += "Debe seleccionar estado del despacho."
            bValida = False
        End If

        For i As Integer = 0 To GrillaDespacho.Rows.Count - 1
            If GrillaDespacho.Rows(i).Cells(0).Value = Nothing Then
                sMsgError += "Lote " & GrillaDespacho.Rows(i).Cells(1).Value.ToString + " sin orden definido."
                bValida = False
                Exit For
            End If
        Next
        If bValida = True Then
            GrabaDespacho()
        Else
            MsgBox(sMsgError)
        End If
    End Sub


    Private Sub OrdenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenToolStripMenuItem.Click
        CompletaOrden()
    End Sub


    Private Sub txtIDcliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIDcliente.TextChanged


        If txtIDcliente.Text <> Nothing Then
            Dim i As Integer

            sSsql = "SP_ConsultaCtlDespConfCli "
            sSsql += Val(txtIDcliente.Text).ToString
            open()
            GrillaDespacho.Rows.Clear()
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then

                While datatbl.Read
                    GrillaDespacho.Rows.Add()
                    GrillaDespacho.Rows(i).Cells(1).Value = datatbl(1)
                    GrillaDespacho.Rows(i).Cells(2).Value = datatbl(11)
                    GrillaDespacho.Rows(i).Cells(3).Value = datatbl(12)
                    GrillaDespacho.Rows(i).Cells(4).Value = datatbl(2)
                    GrillaDespacho.Rows(i).Cells(5).Value = datatbl(3)
                    GrillaDespacho.Rows(i).Cells(6).Value = datatbl(8)
                    GrillaDespacho.Rows(i).Cells(7).Value = datatbl(9)
                    GrillaDespacho.Rows(i).Cells(8).Value = datatbl(10)
                    GrillaDespacho.Rows(i).Cells(9).Value = datatbl(6)
                    i += 1
                End While
                SumaBandejas()


            Else
                MsgBox("No existen Lotes para Despachar asociados al Cliente.")
                txtbuscacli.Text = Nothing
                LimpiaCampos()
            End If
            close_conexion()
        End If
    End Sub

    Private Sub btnbuscacli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscacli.Click
        If txtbuscacli.Text <> Nothing Then
            gQuienLlama = 11
            gNOMBRE = txtbuscacli.Text
            DateTimePicker1.Value = Now
            BusquedaCliente.Show()
        End If
    End Sub

    Private Sub rdbfecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbfecha.CheckedChanged
        If rdbfecha.Checked = True Then
            txtbuscacli.ReadOnly = True
            txtbuscacli.Text = Nothing
            txtIDcliente.Text = Nothing
            DateTimePicker1.Enabled = True
        End If
    End Sub

    Private Sub rdbcli_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbcli.CheckedChanged
        If rdbcli.Checked = True Then
            txtbuscacli.ReadOnly = False
            DateTimePicker1.Enabled = True
        End If
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrillaDespacho.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrillaDespacho.CellDoubleClick
        'MsgBox("Presiono doble click")
        Dim iNumLote As Integer
        Dim iFilaActual As Integer

        iFilaActual = GrillaDespacho.CurrentRow.Index

        iNumLote = GrillaDespacho.Rows(iFilaActual).Cells(1).Value

        Cambio_Estado.txt_NumLote.ReadOnly = True
        Cambio_Estado.Button1.Enabled = False
        Cambio_Estado.ArchivoToolStripMenuItem.Enabled = False

        Cambio_Estado.txt_NumLote.Text = iNumLote

        Call Cambio_Estado.EjecutaConsultaLote()


        'Cambio_Estado.Button1
        'Cambio_Estado.Button1.PerformClick()
        Cambio_Estado.Show()

        'Cambio_Estado.Button1.PerformClick()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sSsql = "SP_ActualizaCtlDesp_volverpreparacion "
        Try
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            For i As Integer = 0 To GrillaDespacho.Rows.Count - 1
                If GrillaDespacho.Rows(i).Cells(10).Value = True Then
                    sSsql = "SP_ActualizaCtlDesp_volverpreparacion "
                    sSsql += GrillaDespacho.Rows(i).Cells(1).Value.ToString
                    command.CommandText = sSsql
                    command.ExecuteNonQuery()
                End If
            Next
            close_conexion()

            LecturaDatosporFecha()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class