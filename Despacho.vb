Public Class Despacho
    Dim sNumLotes As String
    Private Sub LecturaDespacho()
        btncarga.Enabled = False
        btndespacho.Enabled = False
        btnEmiteGuia.Enabled = False
        chkGuias.Enabled = False
        'datatbl(7) = Estado

        sSsql = "SP_ConsultaDespH "
        sSsql += txtNumDesp.Text
        open()

        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            DateTimePicker1.Value = datatbl(1)
            txtNomChofer.Text = datatbl(2)
            txtPatente.Text = datatbl(3)
            cmbEstado.SelectedIndex = datatbl(7)
            txtkmini.Text = datatbl(4)
            txtkmfin.Text = datatbl(5)
            txthoraini.Text = datatbl(8)
            txthorafin.Text = datatbl(9)

            If datatbl(7) = 0 Or datatbl(7) = 1 Then
                btncarga.Enabled = True
            End If

            If datatbl(7) = 1 Or datatbl(7) = 2 Then
                btndespacho.Enabled = True
            End If

            If datatbl(7) = 1 Then
                btnEmiteGuia.Enabled = True
                chkGuias.Enabled = True
            End If

        Else
            close_conexion()
            Me.SP_ConsultaDespDTableAdapter.Fill(Me.GESTDataSet33.SP_ConsultaDespD, txtNumDesp.Text)
            MsgBox("No Existe Nº de Despacho")
            txtNumDesp.Text = Nothing
            txtNumDesp.Focus()
            Exit Sub
        End If
        close_conexion()
        Me.SP_ConsultaDespDTableAdapter.Fill(Me.GESTDataSet33.SP_ConsultaDespD, txtNumDesp.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dialog1.Visible = True
    End Sub
    Private Sub LimpiaCampos()
        txtNomChofer.Clear()
        txtPatente.Clear()
        cmbEstado.SelectedIndex = -1
        txtkmini.Clear()
        txthoraini.Clear()
        txtkmfin.Clear()
        txthorafin.Clear()
        txtTotalBand.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        REM actualiza datos del Despacho
        If ValidaDatos() Then
            ActualizaDespacho()
        End If
    End Sub
    Private Sub ActualizaDespacho()
        '@idDesp int,
        '@FechaDesp date,
        '@NomChof varchar(50),
        '@Patente varchar(10),
        '@EstDesp int,
        '@kminicial float = Null,
        '@kmfinal float = Null,
        '@horaini varchar(5) = Null,
        '@horafin varchar(5) = Null

        If cmbEstado.SelectedIndex = 1 Then
            REM Despacho


            Dim sResp = MsgBox("El estado de DESPACHADO permitirá posteriormente emitir las Guías a lotes del Despacho.", MsgBoxStyle.YesNo, "Lotes Despachados")
            If sResp = MsgBoxResult.Yes Then

                open()

                Try

                    sSsql = "SP_ActualizaDespH "
                    sSsql += txtNumDesp.Text.ToString + ","
                    sSsql += "Null,"
                    sSsql += "'" + txtNomChofer.Text + "',"
                    sSsql += "'" + txtPatente.Text + "',"
                    sSsql += cmbEstado.SelectedIndex.ToString + ","
                    sSsql += Val(txtkmini.Text).ToString + ","
                    sSsql += Val(txtkmfin.Text).ToString + ","
                    sSsql += "'" + txthoraini.Text + "',"
                    sSsql += "'" + txthorafin.Text + "'"

                    command = connection.CreateCommand()
                    command.CommandText = sSsql
                    command.ExecuteNonQuery()

                    MsgBox("Despacho ha sido Actualizado.")

                    btncarga.Enabled = True
                    btndespacho.Enabled = True
                    btnEmiteGuia.Enabled = True
                    chkGuias.Enabled = True

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                close_conexion()

            End If

        End If


    End Sub
    Function ValidaDatos() As Boolean
        Dim bretorno As Boolean = True

        If cmbEstado.SelectedIndex = 1 Then
            REM Despacho
            If txthoraini.Text = Nothing Then
                MsgBox("Debe Ingresar Hora de Salida del Despacho")
                bretorno = False
            End If

            If txtkmini.Text = Nothing Then
                MsgBox("Debe Ingresar Km inicial.")
                bretorno = False
            End If
        End If

        If cmbEstado.SelectedIndex = 2 Then
            REM Retorno
            If txthorafin.Text = Nothing Then
                MsgBox("Debe Ingresar Hora de Llegada del Despacho")
                bretorno = False
            End If

            If txtkmfin.Text = Nothing Then
                MsgBox("Debe Ingresar Km final.")
                bretorno = False
            End If
        End If

        If txtNomChofer.Text = Nothing Then
            MsgBox("Nombre del Chofer no puede estar vacío.")
            bretorno = False
        End If

        If txtPatente.Text = Nothing Then
            MsgBox("Patente Vehículo no puede estar vacío.")
            bretorno = False
        End If
        ValidaDatos = bretorno
    End Function

    Private Sub cmbEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstado.SelectedIndexChanged

        txthorafin.ReadOnly = True
        txthoraini.ReadOnly = True
        txtkmfin.ReadOnly = True
        txtkmini.ReadOnly = True

        If cmbEstado.SelectedIndex = 1 Then
            txtkmini.ReadOnly = False
            txthoraini.ReadOnly = False
        End If

        If cmbEstado.SelectedIndex = 2 Then
            txtkmfin.ReadOnly = False
            txthorafin.ReadOnly = False
        End If
    End Sub
    Private Sub SumaBandejas()
        Dim iTotBand As Integer = 0
        For i As Integer = 0 To GrillaDespacho.Rows.Count - 1
            iTotBand += GrillaDespacho.Rows(i).Cells(8).Value
        Next
        txtTotalBand.Text = iTotBand.ToString("###,##0")
    End Sub


    Private Sub Despacho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SP_ConsultaDespDTableAdapter.Connection.ConnectionString = gSOURCE
    End Sub

    Private Sub btndespacho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndespacho.Click
        RepDespachos.Visible = True
    End Sub

    Private Sub btncarga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncarga.Click
        RepCarga.Visible = True
    End Sub

    Private Sub chkGuias_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGuias.CheckedChanged
        If chkGuias.Checked Then
            For i As Integer = 0 To GrillaDespacho.Rows.Count - 1
                If IsDBNull(GrillaDespacho.Rows(i).Cells(10).Value) > 0 Then
                    GrillaDespacho.Rows(i).Cells(0).Value = True
                Else
                    If Val(GrillaDespacho.Rows(i).Cells(10).Value) = 0 Then
                        GrillaDespacho.Rows(i).Cells(0).Value = True
                    End If
                End If
            Next
        Else
            For i As Integer = 0 To GrillaDespacho.Rows.Count - 1
                GrillaDespacho.Rows(i).Cells(0).Value = False
            Next
        End If
    End Sub

    Private Sub btnEmiteGuia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmiteGuia.Click
        'Dim sNumLotes As String
        sNumLotes = ""
        For i As Integer = 0 To GrillaDespacho.Rows.Count - 1
            If GrillaDespacho.Rows(i).Cells(0).Value = True Then
                If sNumLotes <> "" Then
                    sNumLotes += "," & GrillaDespacho.Rows(i).Cells(1).Value.ToString
                Else
                    sNumLotes += GrillaDespacho.Rows(i).Cells(1).Value.ToString
                End If
            End If
        Next

        txtSerieLotes.Text = sNumLotes

        If txtSerieLotes.Text = "" Then
            MsgBox("No existen Lotes seleccionados para Emisión de Guías.")
        Else
            ResumenDespacho.Show()
        End If


    End Sub

    Private Sub DataGridView1_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles GrillaDespacho.CellBeginEdit
        If GrillaDespacho.Rows(e.RowIndex).Cells(0).Value = True Then
            If Not IsDBNull(GrillaDespacho.Rows(e.RowIndex).Cells(10).Value) Then

                If GrillaDespacho.Rows(e.RowIndex).Cells(10).Value <> Nothing Then
                    MsgBox("Lote tiene Guía Emitida.")
                    e.Cancel = True
                End If

            End If

        End If

    End Sub


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrillaDespacho.CellDoubleClick
        REM DOBLE CLICK
        Dim iNumLote As Integer
        Dim iFilaActual As Integer

        iFilaActual = GrillaDespacho.CurrentRow.Index
        iNumLote = GrillaDespacho.Rows(iFilaActual).Cells(1).Value
        Cambio_Estado.txt_NumLote.ReadOnly = True
        Cambio_Estado.Button1.Enabled = False
        Cambio_Estado.ArchivoToolStripMenuItem.Enabled = False
        Cambio_Estado.txt_NumLote.Text = iNumLote

        Call Cambio_Estado.EjecutaConsultaLote()
        Cambio_Estado.Show()

    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrillaDespacho.CellEndEdit
        If GrillaDespacho.Rows(e.RowIndex).Cells(0).Value = True Then
            If Not IsDBNull(GrillaDespacho.Rows(e.RowIndex).Cells(10).Value) Then

                If GrillaDespacho.Rows(e.RowIndex).Cells(10).Value <> Nothing Then
                    MsgBox("Lote tiene Guía Emitida.")
                    GrillaDespacho.Rows(e.RowIndex).Cells(0).Value = False
                End If

            End If
        End If
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtNumDesp.Text <> Nothing Then
            LimpiaCampos()
            LecturaDespacho()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Try
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            For i As Integer = 0 To GrillaDespacho.Rows.Count - 1
                If GrillaDespacho.Rows(i).Cells(0).Value = True Then
                    sSsql = "SP_ActualizaCtlDesp_volverpreparacion_DESPACHO "
                    sSsql += GrillaDespacho.Rows(i).Cells(1).Value.ToString
                    command.CommandText = sSsql
                    command.ExecuteNonQuery()
                End If
            Next
            close_conexion()

            LecturaDespacho()
        Catch ex As Exception

        End Try

    End Sub
End Class