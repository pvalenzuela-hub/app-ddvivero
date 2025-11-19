Public Class HojaTrabajo

    Dim sModoForm As String

    Private Sub HojaTrabajo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Carga_Personal(Me.cmb_Personal)
        Carga_Evento(Me.cmb_Actividad, "T")
        Carga_Nave(Me.cmb_Nave)
        ' Carga_Lote_Activo(Me.cmb_Lote)
    End Sub



    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs)
        'If cmb_Nave.SelectedIndex > -1 Then

        '    If txt_Naves.Text = Nothing Then
        '        txt_Naves.Text = cmb_Nave.Text
        '    Else
        '        txt_Naves.Text = RTrim(txt_Naves.Text) & "/" & cmb_Nave.Text
        '    End If
        'Else
        '    MsgBox("Seleccione Nª de Nave", MsgBoxStyle.Exclamation)
        'End If
    End Sub



    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs)
        'txt_Naves.Clear()
    End Sub

    Private Sub Button6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button6.Click
        REM Validaciones

        sModoForm = "A"

        If Trim(Mid(txt_HoraInicio.Text, 1, 2)) = "" Then
            MsgBox("Ingrese Hora de Inicio")
            Exit Sub
        End If

        If Trim(Mid(txt_HoraInicio.Text, 4, 2)) = "" Then
            MsgBox("Ingrese Hora de Inicio")
            Exit Sub
        End If

        If Trim(Mid(txt_HoraTermino.Text, 1, 2)) = "" Then
            MsgBox("Ingrese Hora de Término")
            Exit Sub
        End If

        If Trim(Mid(txt_HoraTermino.Text, 4, 2)) = "" Then
            MsgBox("Ingrese Hora de Término")
            Exit Sub
        End If

        If cmb_Actividad.SelectedIndex = -1 Then
            MsgBox("Ingrese Faena o Actividad")
            Exit Sub
        End If


        If cmb_Personal.SelectedIndex = -1 Then
            MsgBox("Ingrese Trabajador")
            Exit Sub
        End If



        Agrega_Registro()
    End Sub
    Private Sub Agrega_Registro()
        REM Agregando Reigstro en Pantalla a la Grilal de Datos

        Dim i As Integer
        Dim j As Integer
        Dim sSerieLotes As String
        Dim sSerieNaves As String

        If Val(txt_NumLinea.Text) = 0 Then
            DataGrilla.Rows.Add()
            i = DataGrilla.Rows.Count - 1
        Else
            i = txt_NumLinea.Text - 1
        End If
        DataGrilla.Rows(i).Cells(0).Value = i + 1
        DataGrilla.Rows(i).Cells(1).Value = Format(DateTimePicker1.Value, "d")
        DataGrilla.Rows(i).Cells(2).Value = cmb_Personal.Text
        DataGrilla.Rows(i).Cells(3).Value = cmb_Actividad.Text

        REM Crea Variable de Lotes: Lote1/Lote2/Lote3....

        If GrillaLote.Rows.Count > 0 Then
            sSerieLotes = ""
            For j = 0 To GrillaLote.Rows.Count - 1
                If Val(GrillaLote.Rows(j).Cells(0).Value) > 0 Then
                    If Len(sSerieLotes) = 0 Then
                        sSerieLotes = GrillaLote.Rows(j).Cells(0).Value
                    Else
                        sSerieLotes += "/" + GrillaLote.Rows(j).Cells(0).Value
                    End If
                End If
            Next
            DataGrilla.Rows(i).Cells(4).Value = sSerieLotes
        Else
            DataGrilla.Rows(i).Cells(4).Value = ""
        End If

        REM Crea Variable de Nave: Nave1/Nave2/Nave3....

        If GrillaNave.Rows.Count > 0 Then
            sSerieNaves = ""
            For j = 0 To GrillaNave.Rows.Count - 1
                If Val(GrillaNave.Rows(j).Cells(0).Value) > 0 Then
                    If Len(sSerieNaves) = 0 Then
                        sSerieNaves = GrillaNave.Rows(j).Cells(0).Value
                    Else
                        sSerieNaves += "/" + GrillaNave.Rows(j).Cells(0).Value
                    End If
                End If
            Next
            DataGrilla.Rows(i).Cells(5).Value = sSerieNaves
        Else
            DataGrilla.Rows(i).Cells(5).Value = ""
        End If


        DataGrilla.Rows(i).Cells(6).Value = txt_NumBand.Text
        DataGrilla.Rows(i).Cells(7).Value = txt_HoraInicio.Text
        DataGrilla.Rows(i).Cells(8).Value = txt_HoraTermino.Text

        GrillaLote.Rows.Clear()
        GrillaNave.Rows.Clear()
        txt_NumBand.Clear()
        If txt_HoraTermino.Text = "12:00" Then
            txt_HoraInicio.Text = "13:30"
        Else
            txt_HoraInicio.Text = txt_HoraTermino.Text
        End If

        txt_HoraTermino.Clear()

    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
        REM elimina Registro
        sModoForm = "E"
        Elimina_Registro()
    End Sub
    Private Sub Elimina_Registro()
        Dim fila As Integer

        If DataGrilla.Rows.Count > 0 Then
            fila = DataGrilla.CurrentRow.Index
            If fila > -1 Then
                DataGrilla.Rows.RemoveAt(fila)
            End If
        End If

    End Sub

    Private Sub Graba_Registros()
        '@FechaActiv date,
        '@Nombre varchar(100),
        '@Evento varchar(50),
        '@Descrip varchar(100),
        '@Num_Lotes varchar(200),
        '@Num_Naves varchar(200),
        '@Num_Bandejas int,
        '@Hora_Ini time(7),
        '@Hora_Fin time(7)
        Dim bPermiteGrabar As Boolean = True

        sModoForm = "G"

        If DataGrilla.Rows.Count > 0 Then

            REM Encuentra cantidad de / en el string
            Dim aTodoslosLotes() As String
            Dim aTodaslasNaves() As String
            Dim sLotes As String
            Dim sNaves As String
            Dim iNumReg As Integer = 0
            Dim iCantLotes As Integer = 0

            open()
            command2 = connection.CreateCommand()

            REM validar Lotes Ingresados en la Grilla

            For i As Integer = 0 To DataGrilla.Rows.Count - 1
                If DataGrilla.Rows(i).Cells(4).Value <> "" Then
                    sLotes = DataGrilla.Rows(i).Cells(4).Value
                    aTodoslosLotes = Split(sLotes, "/", , CompareMethod.Text)
                    iCantLotes = UBound(aTodoslosLotes)
                    For j As Integer = 0 To iCantLotes
                        sSsql = "SP_CONSULTA_DETALLE_LOTE "
                        sSsql += aTodoslosLotes(j).ToString
                        command2 = connection.CreateCommand()
                        command2.CommandText = sSsql
                        datatbl = command2.ExecuteReader()

                        If Not datatbl.HasRows Then
                            MsgBox("Lote Nº " & aTodoslosLotes(j).ToString & " No Existe", MsgBoxStyle.Exclamation)
                            bPermiteGrabar = False
                        Else
                            datatbl.Read()
                            If datatbl(16) = 0 Then
                                MsgBox("Lote Nº " & aTodoslosLotes(j).ToString & " No Tiene Conteo de Siembra.", MsgBoxStyle.Exclamation)
                                bPermiteGrabar = False
                            End If
                        End If
                        datatbl.Close()
                    Next
                End If
            Next

            close_conexion()


            If bPermiteGrabar = True Then
                open()
                command = connection.CreateCommand()
                command2 = connection.CreateCommand()

                For i As Integer = 0 To DataGrilla.Rows.Count - 1

                    If DataGrilla.Rows(i).Cells(4).Value <> "" Then
                        REM GRaba Registros por cada Lote de la Cadena Ingresada
                        ReDim aTodoslosLotes(0)
                        sLotes = DataGrilla.Rows(i).Cells(4).Value
                        aTodoslosLotes = Split(sLotes, "/", , CompareMethod.Text)
                        iCantLotes = UBound(aTodoslosLotes)


                        For j As Integer = 0 To iCantLotes

                            sSsql = "SP_GRABA_RegistroActivTrabaj "
                            sSsql += "'" & DataGrilla.Rows(i).Cells(1).Value & "',"
                            sSsql += "'" & DataGrilla.Rows(i).Cells(2).Value & "',"
                            sSsql += "'" & DataGrilla.Rows(i).Cells(3).Value & "',"
                            sSsql += "'" & DataGrilla.Rows(i).Cells(4).Value & "',"
                            sSsql += "'" & DataGrilla.Rows(i).Cells(5).Value & "',"
                            sSsql += Val(DataGrilla.Rows(i).Cells(6).Value).ToString & ","
                            sSsql += "'" & DataGrilla.Rows(i).Cells(7).Value & "',"
                            sSsql += "'" & DataGrilla.Rows(i).Cells(8).Value & "',"
                            sSsql += aTodoslosLotes(j).ToString & ","
                            sSsql += (iCantLotes + 1).ToString
                            command.CommandText = sSsql
                            command.ExecuteNonQuery()
                        Next
                    End If

                    If DataGrilla.Rows(i).Cells(5).Value <> "" Then
                        REM Graba Registros para cada Lote dentro de cada Nave ingresada
                        sNaves = DataGrilla.Rows(i).Cells(5).Value
                        ReDim aTodaslasNaves(0)
                        aTodaslasNaves = Split(sNaves, "/", , CompareMethod.Text)
                        sLotes = ""
                        For j As Integer = 0 To UBound(aTodaslasNaves)
                            REM Buscar Lotes por Nave
                            sSsql = "SP_CONSULTA_LOTE_NAVE "
                            sSsql += aTodaslasNaves(j)
                            command2 = connection.CreateCommand()
                            command2.CommandText = sSsql
                            datatbl = command2.ExecuteReader()

                            If datatbl.HasRows Then
                                iNumReg = 0
                                ReDim aTodoslosLotes(iNumReg)
                                While datatbl.Read = True
                                    If sLotes = "" Then
                                        sLotes = RTrim(datatbl(0).ToString)
                                    Else
                                        sLotes += "/" + RTrim(datatbl(0).ToString)
                                    End If
                                    'ReDim Preserve aTodoslosLotes(iNumReg)
                                    'aTodoslosLotes(iNumReg) = datatbl(0)
                                    'iNumReg += 1
                                End While
                            End If
                            datatbl.Close()
                        Next

                        aTodoslosLotes = Split(sLotes, "/", , CompareMethod.Text)
                        iCantLotes = UBound(aTodoslosLotes)
                        For j As Integer = 0 To iCantLotes
                            sSsql = "SP_GRABA_RegistroActivTrabaj "
                            sSsql += "'" & DataGrilla.Rows(i).Cells(1).Value & "',"
                            sSsql += "'" & DataGrilla.Rows(i).Cells(2).Value & "',"
                            sSsql += "'" & DataGrilla.Rows(i).Cells(3).Value & "',"
                            sSsql += "'" & DataGrilla.Rows(i).Cells(4).Value & "',"
                            sSsql += "'" & DataGrilla.Rows(i).Cells(5).Value & "',"
                            sSsql += Val(DataGrilla.Rows(i).Cells(6).Value).ToString & ","
                            sSsql += "'" & DataGrilla.Rows(i).Cells(7).Value & "',"
                            sSsql += "'" & DataGrilla.Rows(i).Cells(8).Value & "',"
                            sSsql += aTodoslosLotes(j).ToString & ","
                            sSsql += (iCantLotes + 1).ToString
                            command.CommandText = sSsql
                            command.ExecuteNonQuery()
                        Next
                    End If

                    If DataGrilla.Rows(i).Cells(4).Value = "" And DataGrilla.Rows(i).Cells(5).Value = "" Then
                        REM Graba Registros de Actividades Generales no asociados a Lotes
                        sSsql = "SP_GRABA_RegistroActivTrabaj "
                        sSsql += "'" & DataGrilla.Rows(i).Cells(1).Value & "',"
                        sSsql += "'" & DataGrilla.Rows(i).Cells(2).Value & "',"
                        sSsql += "'" & DataGrilla.Rows(i).Cells(3).Value & "',"
                        sSsql += "'',"
                        sSsql += "'',"
                        sSsql += Val(DataGrilla.Rows(i).Cells(6).Value).ToString & ","
                        sSsql += "'" & DataGrilla.Rows(i).Cells(7).Value & "',"
                        sSsql += "'" & DataGrilla.Rows(i).Cells(8).Value & "',"
                        sSsql += "0,"
                        sSsql += "0"
                        command.CommandText = sSsql
                        command.ExecuteNonQuery()
                    End If

                Next
                close_conexion()
                MsgBox("Registros Actualizados.", MsgBoxStyle.Information)
                Me.Close()
            End If

        End If

    End Sub

    Private Sub Button7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button7.Click
        Graba_Registros()
    End Sub

    Private Sub cmb_Nave_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_Nave.SelectedIndexChanged
        Dim iRow As Integer
        If cmb_Nave.SelectedIndex > -1 Then
            GrillaNave.Rows.Add()
            iRow = GrillaNave.Rows.Count - 1
            GrillaNave.Rows(iRow).Cells(0).Value = cmb_Nave.Text
            txt_NumBand.Clear()
        End If

    End Sub

    Private Sub txt_NumBand_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles txt_NumBand.LostFocus
        If txt_NumBand.Text <> Nothing Then
            txt_NumBand.Text = Val(txt_NumBand.Text)
            GrillaLote.Rows.Clear()
            GrillaNave.Rows.Clear()
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button8.Click
        ReporteRegActivDiaria.Show()
    End Sub

   
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        REM EDITA CAMPOS
        Dim fila As Integer
        Dim aTodoslosLotes() As String
        Dim aTodaslasNaves() As String
        Dim iCantLotes As Integer
        Dim iCantNaves As Integer
        Dim iNumLinea As Integer

        sModoForm = "E"

        If DataGrilla.Rows.Count > 0 Then
            fila = DataGrilla.CurrentRow.Index
            iNumLinea = DataGrilla.Rows(fila).Cells(0).Value
            txt_NumLinea.Text = iNumLinea
            cmb_Personal.Text = DataGrilla.Rows(fila).Cells(2).Value
            cmb_Actividad.Text = DataGrilla.Rows(fila).Cells(3).Value
            txt_NumBand.Text = DataGrilla.Rows(fila).Cells(6).Value
            txt_HoraInicio.Text = DataGrilla.Rows(fila).Cells(7).Value
            txt_HoraTermino.Text = DataGrilla.Rows(fila).Cells(8).Value
            GrillaLote.Rows.Clear()
            GrillaNave.Rows.Clear()
            If Len(DataGrilla.Rows(fila).Cells(4).Value) > 0 Then
                REM Carga Grilla de Lotes para Editar

                rdb_Lotes.Checked = True
                GrillaLote.Enabled = True
                GrillaNave.Enabled = False
                cmb_Nave.Enabled = False

                aTodoslosLotes = Split(DataGrilla.Rows(fila).Cells(4).Value, "/", , CompareMethod.Text)
                iCantLotes = UBound(aTodoslosLotes)
                For j As Integer = 0 To iCantLotes
                    GrillaLote.Rows.Add()
                    GrillaLote.Rows(j).Cells(0).Value = aTodoslosLotes(j)
                Next
            End If
            If Len(DataGrilla.Rows(fila).Cells(5).Value) > 0 Then
                REM Carga Grilla de Naves para Editar

                rdb_Naves.Checked = True
                GrillaLote.Enabled = False
                GrillaNave.Enabled = True
                cmb_Nave.Enabled = True

                aTodaslasNaves = Split(DataGrilla.Rows(fila).Cells(5).Value, "/", , CompareMethod.Text)
                iCantNaves = UBound(aTodaslasNaves)
                For j As Integer = 0 To iCantNaves
                    GrillaNave.Rows.Add()
                    GrillaNave.Rows(j).Cells(0).Value = aTodaslasNaves(j)
                Next
            End If

        End If
        sModoForm = "N"
    End Sub





    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sModoForm = "N"
        txt_NumLinea.Text = 0
        cmb_Actividad.SelectedIndex = -1
        cmb_Personal.SelectedIndex = -1
        cmb_Nave.SelectedIndex = -1
        txt_HoraInicio.Clear()
        txt_HoraTermino.Clear()
        txt_NumBand.Clear()
        GrillaLote.Rows.Clear()
        GrillaNave.Rows.Clear()
    End Sub

    Private Sub rdb_Lotes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Lotes.CheckedChanged
        If rdb_Lotes.Checked Then

            If sModoForm <> "E" Then
                GrillaLote.Enabled = True
                GrillaNave.Enabled = False
                txt_NumBand.Clear()
                GrillaNave.Rows.Clear()
                cmb_Nave.Enabled = False
            End If
        End If
    End Sub

    Private Sub rdb_Naves_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Naves.CheckedChanged
        If rdb_Naves.Checked Then

            If sModoForm <> "E" Then
                GrillaNave.Enabled = True
                GrillaLote.Enabled = False
                GrillaLote.Rows.Clear()
                cmb_Nave.Enabled = True
            End If
        End If
    End Sub



    Private Sub GrillaNave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrillaNave.KeyDown

        Dim iCurrFila As Integer
        If e.KeyCode = 46 Then
            REM Tecla Suprimir
            If GrillaNave.Rows.Count > 0 Then
                iCurrFila = GrillaNave.CurrentRow.Index
                GrillaNave.Rows.RemoveAt(iCurrFila)
            End If
        End If


    End Sub

 
    Private Sub GrillaLote_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrillaLote.KeyDown
        Dim iCurrFila As Integer
        If e.KeyCode = 46 Then
            REM Tecla Suprimir
            If GrillaLote.Rows.Count > 0 Then
                iCurrFila = GrillaLote.CurrentRow.Index
                GrillaLote.Rows.RemoveAt(iCurrFila)
            End If
        End If

    End Sub
End Class