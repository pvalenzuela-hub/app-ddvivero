Public Class Mant_Eventos
    Private Sub Eventos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet.TBL_EVENTO' Puede moverla o quitarla según sea necesario.


        Me.SP_CONSULTA_TBL_EVENTOSTableAdapter.Connection.ConnectionString = gSOURCE
        Me.SP_CONSULTA_TBL_EVENTOSTableAdapter.Fill(Me.GESTDataSet2.SP_CONSULTA_TBL_EVENTOS, "A")


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
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
        Limpia_Campos()
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
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Graba_Evento()
        Limpia_Campos()
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
            Limpia_Campos()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Elimina_Evento()
    End Sub

  
    Private Sub Limpia_Campos()
        txt_Descripcion.Clear()
        txt_Detalle.Clear()
        txt_Orden.Clear()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Limpia_Campos()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Elimina_Evento()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Me.SP_CONSULTA_TBL_EVENTOSTableAdapter.Fill(Me.GESTDataSet2.SP_CONSULTA_TBL_EVENTOS, "A")

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Me.SP_CONSULTA_TBL_EVENTOSTableAdapter.Fill(Me.GESTDataSet2.SP_CONSULTA_TBL_EVENTOS, "B")
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Me.SP_CONSULTA_TBL_EVENTOSTableAdapter.Fill(Me.GESTDataSet2.SP_CONSULTA_TBL_EVENTOS, "T")
        End If
    End Sub
End Class