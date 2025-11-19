Public Class Mantencion_Eventos

    Private Sub Mantencion_Eventos_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' MsgBox(gSOURCE)
        Me.SP_CONSULTA_TBL_EVENTOSTableAdapter.Connection.ConnectionString = gSOURCE

        ' Me.SP_CONSULTA_TBL_EVENTOSTableAdapter.Fill(Me.GESTDataSet2.SP_CONSULTA_TBL_EVENTOS, "A")

    End Sub

    Private Sub Inicializa_Grilla()
        If RadioButton1.Checked = True Then
            Me.SP_CONSULTA_TBL_EVENTOSTableAdapter.Fill(Me.GESTDataSet2.SP_CONSULTA_TBL_EVENTOS, "A")
        End If
        If RadioButton2.Checked = True Then
            Me.SP_CONSULTA_TBL_EVENTOSTableAdapter.Fill(Me.GESTDataSet2.SP_CONSULTA_TBL_EVENTOS, "B")
        End If
        If RadioButton3.Checked = True Then
            Me.SP_CONSULTA_TBL_EVENTOSTableAdapter.Fill(Me.GESTDataSet2.SP_CONSULTA_TBL_EVENTOS, "T")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Graba_Evento()
    End Sub

    Private Sub Graba_Evento()

        Dim sInsumo As String
        Dim sLote As String
        Dim sPlantas As String
        Dim sCamara As String
        Dim sIdentNave As String
        Dim sTipoEvento As String = ""


        If rb_Insumo.Checked Then
            sInsumo = "S"
        Else
            sInsumo = "N"
        End If
        If rb_Lote.Checked Then
            sLote = "S"
        Else
            sLote = "N"
        End If
        If rb_Plantas.Checked Then
            sPlantas = "S"
        Else
            sPlantas = "N"
        End If
        If rb_Camara.Checked Then
            sCamara = "S"
        Else
            sCamara = "N"
        End If
        If rb_identNave.Checked Then
            sIdentNave = "S"
        Else
            sIdentNave = "N"
        End If

        If RadioButton1.Checked = True Then
            sTipoEvento = "A"
        End If

        If RadioButton2.Checked = True Then
            sTipoEvento = "B"
        End If

        If RadioButton3.Checked = True Then
            sTipoEvento = "T"
        End If

        REM Chequea Duplicidad
        If DataGridView1.Rows.Count > 1 Then
            For i = 0 To DataGridView1.Rows.Count - 1

                If DataGridView1.Rows(i).Cells(1).Value = txt_Descripcion.Text Then
                    MsgBox("No se permite duplicar la descripción de un Evento. No es posible grabar descripción.")
                    Exit Sub
                End If
            Next
        End If


        sSsql = "SP_GRABA_TBL_EVENTO "
        sSsql += "'" + txt_Descripcion.Text + "',"
        sSsql += "'" + txt_Detalle.Text + "',"
        sSsql += "'" + sInsumo + "',"
        sSsql += "'" + sLote + "',"
        sSsql += "'" + sCamara + "',"
        sSsql += "'" + sPlantas + "',"
        sSsql += "'" + sIdentNave + "',"
        sSsql += "'" + sTipoEvento + "',"
        sSsql += Reemplaza_Comas(Val(txt_Orden.Text).ToString)

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()
        close_conexion()
        Inicializa_Grilla()
    End Sub

    Function ChequeaDuplicidadEvento() As Boolean
        Dim bRetorno As Boolean = True
        Dim i As Integer
        Dim j As Integer
        If DataGridView1.Rows.Count > 1 Then
            For i = 0 To DataGridView1.Rows.Count - 2
                For j = i + 1 To DataGridView1.Rows.Count - 1
                    If DataGridView1.Rows(i).Cells(1).Value = DataGridView1.Rows(j).Cells(1).Value Then
                        bRetorno = False
                    End If
                Next
            Next
        End If

        If bRetorno = False Then
            MsgBox("No se permite duplicar la descripción de un Evento. No ha sido posible actualizar los datos.")
        End If

        ChequeaDuplicidadEvento = bRetorno

    End Function

    Private Sub UpdateTblEvento()

        Dim IdEvento As Integer
        Dim FilaGrilla As Integer
        Dim dOrden As Double = 0
        FilaGrilla = DataGridView1.CurrentRow.Index
        IdEvento = DataGridView1.Rows(FilaGrilla).Cells(0).Value
        If IdEvento > 0 Then
            REM actualiza datos
            sSsql = "SP_Actualiza_TBL_EVENTO "
            sSsql += IdEvento.ToString + ","
            sSsql += "'" + DataGridView1.Rows(FilaGrilla).Cells(1).Value + "',"
            sSsql += "'" + DataGridView1.Rows(FilaGrilla).Cells(2).Value + "',"
            sSsql += "'" + DataGridView1.Rows(FilaGrilla).Cells(3).Value + "',"
            sSsql += "'" + DataGridView1.Rows(FilaGrilla).Cells(4).Value + "',"
            sSsql += "'" + DataGridView1.Rows(FilaGrilla).Cells(5).Value + "',"
            sSsql += "'" + DataGridView1.Rows(FilaGrilla).Cells(6).Value + "',"
            sSsql += "'" + DataGridView1.Rows(FilaGrilla).Cells(7).Value + "',"
            sSsql += "'" + DataGridView1.Rows(FilaGrilla).Cells(8).Value + "',"
            If IsDBNull(DataGridView1.Rows(FilaGrilla).Cells(9).Value) Then
                dOrden = 0
            Else
                dOrden = Val(DataGridView1.Rows(FilaGrilla).Cells(9).Value)
            End If
            sSsql += dOrden.ToString
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            close_conexion()
        End If
        Inicializa_Grilla()
    End Sub

    Private Sub Elimina_Evento()
        Dim sResp As String
        Dim IdEvento As Integer
        Dim FilaGrilla As Integer
        sResp = InputBox("CONFIRME ELIMINACION DE EVENTO", "ELIMINACION DE EVENTO", "S")
        If UCase(sResp) = "S" Then
            FilaGrilla = DataGridView1.CurrentRow.Index
            IdEvento = DataGridView1.Rows(FilaGrilla).Cells(0).Value
            If IdEvento <= 0 Then
                MsgBox("IDENTIFICADOR DE EVENTO NO ES VALIDO. DEBE SELECCIONAR EVENTO A ELIMINAR.")
                Exit Sub
            End If
            sSsql = "SP_ELIMINA_EVENTO "
            'idFamilia numeric(18,0)
            sSsql += Str(IdEvento)
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                datatbl.Read()
                If datatbl(0) = -1 Then
                    MsgBox("NO ES POSIBLE ELIMINAR EVENTO ID.:" + Format(IdEvento, "####") + ". ESTA SIENDO UTILIZADO EN BITACORA DE LOTES")
                End If
            End If
            close_conexion()
            Inicializa_Grilla()
        End If
    End Sub

    Private Sub Limpia_Campos()
        txt_Descripcion.Clear()
        txt_Detalle.Clear()
        txt_Orden.Clear()
    End Sub

  

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Elimina_Evento()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Inicializa_Grilla()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ChequeaDuplicidadEvento() = True Then
            UpdateTblEvento()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class