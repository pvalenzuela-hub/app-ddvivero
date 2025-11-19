Public Class PrepDespLote

    Private Sub DataGridView5_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles GrillaDespacho.CellBeginEdit
        REM Valida Inicio de Edicion
        Dim iCol As Integer = e.ColumnIndex
        If iCol = 0 Or iCol = 7 Or iCol = 8 Then
            If GrillaDespacho.Rows(e.RowIndex).Cells(1).Value = Nothing Then
                MsgBox("Debe Ingresar Nº de Lote")
                e.Cancel = True
            End If
            If GrillaDespacho.Rows(e.RowIndex).Cells(6).Value = 0 Then
                MsgBox("Lote debe contener Saldo de Bandejas para preparar despacho!!!")
                e.Cancel = True
            End If

        End If

    End Sub

    Private Sub DataGridView5_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrillaDespacho.CellEndEdit
        REM **************************************************************************************************************************************************
        REM                                                              ENTRADA DE DATOS
        REM **************************************************************************************************************************************************

        Dim iCol As Integer = e.ColumnIndex
        Dim ctodate As Date

        REM Valida Check Confirmación
        If iCol = 0 Then

            GrillaDespacho.Rows(e.RowIndex).Cells(7).Value = Format(Now.Date, "dd/MM/yyyy")

            If GrillaDespacho.Rows(e.RowIndex).Cells(7).Value = #1/1/1900# Or Not IsDate(GrillaDespacho.Rows(e.RowIndex).Cells(7).Value) = True Then
                'MsgBox("Fecha de Despacho No Válida!!!")
                GrillaDespacho.Rows(e.RowIndex).Cells(0).Value = False
            End If



        End If


        Try
            REM Valida Ingreso de Nº De Lote
            If iCol = 1 Then
                If GrillaDespacho.Rows(e.RowIndex).Cells(1).Value <> Nothing Then
                    If ValidaNumLote(GrillaDespacho.Rows(e.RowIndex).Cells(1).Value, e.RowIndex) Then
                    Else
                        'DataGridView5.ClearSelection()
                        GrillaDespacho.Rows.RemoveAt(e.RowIndex)
                    End If
                End If
            End If
            REM Valida Ingreso Fecha Valida
            If iCol = 7 Then
                If Not IsDate(GrillaDespacho.Rows(e.RowIndex).Cells(iCol).Value) Then
                    MsgBox("Fecha No Válida. Vuelva a ingresar Fecha de Despacho")
                    GrillaDespacho.Rows(e.RowIndex).Cells(iCol).Value = Nothing
                    If GrillaDespacho.Rows(e.RowIndex).Cells(1).Value = Nothing Then
                        MsgBox("No ha ingresado Nº de Lote. Debe ingresar este dato primero")
                        If e.RowIndex > 0 Then
                            GrillaDespacho.Rows.RemoveAt(e.RowIndex)
                        End If
                    End If
                Else
                    ctodate = GrillaDespacho.Rows(e.RowIndex).Cells(iCol).Value
                    GrillaDespacho.Rows(e.RowIndex).Cells(iCol).Value = ctodate.ToString("d/MM/yyyy")
                End If
                ' termino de registrar la fecha
                'verificar si se marcó el ticket


            End If

        Catch ex As Exception

        End Try




    End Sub

    Function ValidaNumLote(ByVal iNumLote As Integer, ByVal iFila As Integer) As Boolean
        Dim i As Integer
        Dim j As Integer
        REM ****************************************************************************
        REM                              Valida Lote Ingresado
        REM ****************************************************************************
        Dim bRetorno As Boolean = True
        sSsql = "SP_CONSULTA_DETALLE_LOTE "
        sSsql += iNumLote.ToString
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            GrillaDespacho.Rows(iFila).Cells(2).Value = datatbl(0) 'Cliente 0
            GrillaDespacho.Rows(iFila).Cells(3).Value = datatbl(46) 'Fono 46
            GrillaDespacho.Rows(iFila).Cells(4).Value = datatbl(10) 'Plantas Pedido 10
            GrillaDespacho.Rows(iFila).Cells(5).Value = datatbl(31) 'Saldo Plantas 31
            GrillaDespacho.Rows(iFila).Cells(6).Value = datatbl(76) 'Saldo Bandejas 76
            GrillaDespacho.Rows(iFila).Cells(9).Value = datatbl(28) 'Especie 28
            GrillaDespacho.Rows(iFila).Cells(10).Value = datatbl(29) 'Variedad 29
            GrillaDespacho.Rows(iFila).Cells(11).Value = datatbl(78) 'Sector 78
            GrillaDespacho.Rows(iFila).Cells(12).Value = datatbl(79) 'Zona 79
            If datatbl(76) = 0 Then
                MsgBox("Lote no tiene Saldo de Bandejas!!!", MsgBoxStyle.Critical, "Preparación de Lote")
                bRetorno = False
            End If

            If datatbl(18) <= 0 Then
                MsgBox("Lote no tiene Conteo de Plantas!!!", MsgBoxStyle.Critical, "Preparación de Lote")
                bRetorno = False
            End If


        Else
            MsgBox("Nº de Lote ingresado No Existe.")
            bRetorno = False
        End If


        REM **************************************************************************
        REM     Verifica que Lote no se encuentre Confirmado en Ingresos anteriores
        REM **************************************************************************
        sSsql = "SP_ConsultaLoteCtlDesp "
        sSsql += iNumLote.ToString
        datatbl.Close()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            MsgBox("Lote ya existe en Estado de Confirmación. Revise Estado de los Despachos")
            bRetorno = False
        End If

        close_conexion()

        REM **************************************************************************
        REM                     Valida Ingreso Repetido de Lote
        REM **************************************************************************
        For i = 0 To GrillaDespacho.Rows.Count - 2
            For j = i + 1 To GrillaDespacho.Rows.Count - 1
                If GrillaDespacho.Rows(i).Cells(1).Value = GrillaDespacho.Rows(j).Cells(1).Value Then
                    MsgBox("Nº de Lote Repetido, solo se permite ingresar una sola vez el Lote a despachar.")
                    bRetorno = False
                    Exit For
                End If
            Next
            If bRetorno = False Then
                Exit For
            End If
        Next

        ValidaNumLote = bRetorno
    End Function

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click

        Me.Close()
    End Sub

    Private Sub DataGridView5_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrillaDespacho.CellEnter
        REM valida tecla ENTER
        'If DataGridView5.Rows(e.RowIndex).Cells(1).Value = Nothing Then
        '    '        DataGridView5.Rows.RemoveAt(e.RowIndex)
        '    MsgBox("Sin Numero de Lote en la fila" & e.RowIndex.ToString)
        'End If
        'End If

    End Sub

    Private Sub DataGridView5_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles GrillaDespacho.CellValidating
        REM valida num lote
        'Dim iCol As Integer = e.ColumnIndex
        'If iCol = 1 Then
        '    REM Validar Numero de Lote Ingresado
        '    If ValidaNumLote(DataGridView5.Rows(e.RowIndex).Cells(1).Value, e.RowIndex) Then
        '    Else

        '        DataGridView5.ClearSelection()


        '    End If

        'End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        REM Elimina Fila Actual
        Dim ifila As Integer = GrillaDespacho.CurrentRow.Index
        GrillaDespacho.Rows.RemoveAt(ifila)
    End Sub

    Private Sub PrepDespLote_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Dim sResp = MsgBox("Desea Guardar los Datos antes de Salir?", MsgBoxStyle.YesNo, "Preparación Despachos")
        'If sResp = MsgBoxResult.Yes Then
        '    GuardarDatos()
        'End If

    End Sub

    Private Sub PrepDespLote_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        REM ***********************************************
        REM Lee Lotes Revisados en el Vivero No Confirmados
        REM ***********************************************
        GrillaDespacho.Rows.Clear()

        Dim i As Integer = 0
        sSsql = "SP_ConsultaCtlDesp "
        sSsql += "0"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then

            While datatbl.Read
                GrillaDespacho.Rows.Add()
                GrillaDespacho.Rows(i).Cells(1).Value = datatbl(1)
                GrillaDespacho.Rows(i).Cells(2).Value = datatbl(2)
                GrillaDespacho.Rows(i).Cells(3).Value = datatbl(3)
                GrillaDespacho.Rows(i).Cells(4).Value = datatbl(4)
                GrillaDespacho.Rows(i).Cells(5).Value = datatbl(5)
                GrillaDespacho.Rows(i).Cells(6).Value = datatbl(6)
                GrillaDespacho.Rows(i).Cells(7).Value = datatbl(7)
                GrillaDespacho.Rows(i).Cells(8).Value = datatbl(8)
                GrillaDespacho.Rows(i).Cells(9).Value = datatbl(9)
                GrillaDespacho.Rows(i).Cells(10).Value = datatbl(10)
                GrillaDespacho.Rows(i).Cells(11).Value = datatbl(11)
                GrillaDespacho.Rows(i).Cells(12).Value = datatbl(12)
                i += 1
            End While
        End If
        close_conexion()
        ResumenLotePrepSector()
        'ResumenLoteConfFechaDesp()
        'ResumenLoteConfSector()

    End Sub

    Private Sub GuardarDatos()

        GrillaDespacho.EndEdit()

        Dim iEstCtl As Integer
        open()
        command = connection.CreateCommand()

        Try

            If GrillaDespacho.Rows.Count >= 0 Then

                For i As Integer = 0 To GrillaDespacho.Rows.Count - 1
                    If GrillaDespacho.Rows(i).Cells(1).Value <> Nothing Then

                        If GrillaDespacho.Rows(i).Cells(0).Value = True Then
                            iEstCtl = 1
                        Else
                            iEstCtl = 0
                        End If

                        sSsql = "SP_ActualizaCtlDesp "
                        sSsql += iEstCtl.ToString + ","
                        sSsql += GrillaDespacho.Rows(i).Cells(1).Value.ToString + ","
                        sSsql += "'" + GrillaDespacho.Rows(i).Cells(7).Value + "',"
                        sSsql += "'" + GrillaDespacho.Rows(i).Cells(8).Value + "',"
                        sSsql += GrillaDespacho.Rows(i).Cells(6).Value.ToString

                        command.CommandText = sSsql
                        command.ExecuteNonQuery()



                    End If
                Next

                MsgBox("Datos fueron actualizados")
                ResumenLotePrepSector()
                ResumenLoteConfFechaDesp()
                ResumenLoteConfSector()

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        close_conexion()
    End Sub

    Private Sub GuardarDatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarDatosToolStripMenuItem.Click
        GuardarDatos()
    End Sub
    Private Sub ResumenLotePrepSector()
        Dim i As Integer
        Dim dTotBand As Integer = 0
        sSsql = "SP_ConsultaLotePrepSector"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            GrillaPreparacion.Rows.Clear()
            While datatbl.Read
                GrillaPreparacion.Rows.Add()
                GrillaPreparacion.Rows(i).Cells(0).Value = datatbl(0)
                GrillaPreparacion.Rows(i).Cells(1).Value = datatbl(1)
                GrillaPreparacion.Rows(i).Cells(2).Value = datatbl(2)
                dTotBand += datatbl(2)
                i += 1
            End While
            GrillaPreparacion.Rows.Add()
            GrillaPreparacion.Rows(i).Cells(1).Value = "TOTAL BANDEJAS:"
            GrillaPreparacion.Rows(i).Cells(2).Value = dTotBand
        End If
        close_conexion()

    End Sub
    Private Sub ResumenLoteConfSector()
        Dim i As Integer

        Dim ASector(0) As String
        Dim AZona(0) As String
        Dim j As Integer = 0
        Dim ABandejas(0) As Integer
        Dim Indice As Integer = 0
        Dim TotalBand As Integer = 0
        Dim bFound As Boolean = False

        'sSsql = "SP_ConsultaLoteConfZona"
        'open()
        'command = connection.CreateCommand()
        'command.CommandText = sSsql
        'datatbl = command.ExecuteReader()
        'If datatbl.HasRows Then
        '    GrillaSector.Rows.Clear()
        '    While datatbl.Read
        '        GrillaSector.Rows.Add()
        '        GrillaSector.Rows(i).Cells(0).Value = datatbl(0)
        '        GrillaSector.Rows(i).Cells(1).Value = datatbl(1)
        '        GrillaSector.Rows(i).Cells(2).Value = datatbl(2)
        '        dTotBand += datatbl(2)
        '        i += 1
        '    End While
        '    GrillaSector.Rows.Add()
        '    GrillaSector.Rows(i).Cells(1).Value = "TOTAL:"
        '    GrillaSector.Rows(i).Cells(2).Value = dTotBand
        'End If
        'close_conexion()



        Indice = 0
        For i = 0 To GrillaDespacho.Rows.Count - 1
            If GrillaDespacho.Rows(i).Cells(0).Value = True Then
                bFound = False
                For j = 0 To UBound(ASector)
                    If GrillaDespacho.Rows(i).Cells(11).Value = ASector(j) And GrillaDespacho.Rows(i).Cells(12).Value = AZona(j) Then
                        ABandejas(j) += GrillaDespacho.Rows(i).Cells(6).Value
                        bFound = True
                        Exit For
                    End If
                Next

                If bFound = False Then
                    'MsgBox(Indice)
                    If GrillaDespacho.Rows(i).Cells(7).Value <> #1/1/1900# And GrillaDespacho.Rows(i).Cells(7).Value <> #1/1/0001# Then
                        ReDim Preserve ASector(Indice)
                        ReDim Preserve AZona(Indice)
                        ReDim Preserve ABandejas(Indice)
                        ASector(Indice) = GrillaDespacho.Rows(i).Cells(11).Value
                        AZona(Indice) = GrillaDespacho.Rows(i).Cells(12).Value
                        ABandejas(Indice) = GrillaDespacho.Rows(i).Cells(6).Value
                        Indice += 1
                    End If

                End If
            End If

        Next
        TotalBand = 0
        GrillaSector.Rows.Clear()

        If Indice > 0 Then
            For i = 0 To UBound(ASector)
                GrillaSector.Rows.Add()
                GrillaSector.Rows(i).Cells(0).Value = ASector(i)
                GrillaSector.Rows(i).Cells(1).Value = AZona(i)
                GrillaSector.Rows(i).Cells(2).Value = ABandejas(i)
                TotalBand += ABandejas(i)
            Next
            GrillaSector.Rows.Add()
            i = GrillaSector.Rows.Count - 1

            GrillaSector.Rows(i).Cells(0).Value = "Total Bandejas:"
            GrillaSector.Rows(i).Cells(2).Value = TotalBand

        End If




    End Sub
    Private Sub ResumenLoteConfFechaDesp()

        Dim i As Integer
        Dim dTotBand As Integer = 0
        Dim AFecha(0) As Date
        Dim j As Integer = 0
        Dim ABandejas(0) As Integer
        Dim Indice As Integer = 0
        Dim TotalBand As Integer = 0
        Dim bFound As Boolean = False

        'sSsql = "SP_ConsultaLoteConfDesp"
        'open()
        'command = connection.CreateCommand()
        'command.CommandText = sSsql
        'datatbl = command.ExecuteReader()
        'If datatbl.HasRows Then
        '    GrillaFecha.Rows.Clear()
        '    While datatbl.Read
        '        GrillaFecha.Rows.Add()
        '        GrillaFecha.Rows(i).Cells(0).Value = datatbl(0)
        '        GrillaFecha.Rows(i).Cells(1).Value = datatbl(1)
        '        dTotBand += datatbl(1)
        '        i += 1
        '    End While
        '    GrillaFecha.Rows.Add()
        '    GrillaFecha.Rows(i).Cells(0).Value = "TOTAL:"
        '    GrillaFecha.Rows(i).Cells(1).Value = dTotBand
        'End If
        'close_conexion()


        Indice = 0
        For i = 0 To GrillaDespacho.Rows.Count - 1
            If GrillaDespacho.Rows(i).Cells(0).Value = True Then
                'sumar por fecha de despacho


                bFound = False



                For j = 0 To UBound(AFecha)
                    If GrillaDespacho.Rows(i).Cells(7).Value = AFecha(j) Then
                        ABandejas(j) += GrillaDespacho.Rows(i).Cells(6).Value
                        bFound = True
                        Exit For
                    End If
                Next

                If bFound = False Then
                    'MsgBox(Indice)
                    If GrillaDespacho.Rows(i).Cells(7).Value <> #1/1/1900# And GrillaDespacho.Rows(i).Cells(7).Value <> #1/1/0001# Then
                        ReDim Preserve AFecha(Indice)
                        ReDim Preserve ABandejas(Indice)
                        AFecha(Indice) = GrillaDespacho.Rows(i).Cells(7).Value
                        ABandejas(Indice) = GrillaDespacho.Rows(i).Cells(6).Value
                        Indice += 1
                    End If

                    '                TotalBand += GrillaDespacho.Rows(i).Cells(6).Value

                End If
            End If

        Next
        TotalBand = 0
        GrillaFecha.Rows.Clear()

        If Indice > 0 Then
            For i = 0 To UBound(AFecha)
                GrillaFecha.Rows.Add()
                GrillaFecha.Rows(i).Cells(0).Value = AFecha(i)
                GrillaFecha.Rows(i).Cells(1).Value = ABandejas(i)
                TotalBand += ABandejas(i)
            Next
            GrillaFecha.Rows.Add()
            i = GrillaFecha.Rows.Count - 1

            GrillaFecha.Rows(i).Cells(0).Value = "Total Bandejas:"
            GrillaFecha.Rows(i).Cells(1).Value = TotalBand

        End If



    End Sub

    Private Sub LotesConfirmadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LotesConfirmadosToolStripMenuItem.Click
        REM Carga Lotes Confirmados
        Dim i As Integer = 0
        sSsql = "SP_ConsultaCtlDesp "
        sSsql += "1"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            GrillaDespacho.Rows.Clear()
            While datatbl.Read
                GrillaDespacho.Rows.Add()
                GrillaDespacho.Rows(i).Cells(0).Value = True
                GrillaDespacho.Rows(i).Cells(1).Value = datatbl(1)
                GrillaDespacho.Rows(i).Cells(2).Value = datatbl(2)
                GrillaDespacho.Rows(i).Cells(3).Value = datatbl(3)
                GrillaDespacho.Rows(i).Cells(4).Value = datatbl(4)
                GrillaDespacho.Rows(i).Cells(5).Value = datatbl(5)
                GrillaDespacho.Rows(i).Cells(6).Value = datatbl(6)
                GrillaDespacho.Rows(i).Cells(7).Value = datatbl(7)
                GrillaDespacho.Rows(i).Cells(8).Value = datatbl(8)
                GrillaDespacho.Rows(i).Cells(9).Value = datatbl(9)
                GrillaDespacho.Rows(i).Cells(10).Value = datatbl(10)
                GrillaDespacho.Rows(i).Cells(11).Value = datatbl(11)
                GrillaDespacho.Rows(i).Cells(12).Value = datatbl(12)
                i += 1
            End While
        End If
        close_conexion()
    End Sub

    Private Sub LotesPreparadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LotesPreparadosToolStripMenuItem.Click
        REM Carga Lotes Confirmados
        Dim i As Integer = 0
        sSsql = "SP_ConsultaCtlDesp "
        sSsql += "0"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            GrillaDespacho.Rows.Clear()
            While datatbl.Read
                GrillaDespacho.Rows.Add()

                GrillaDespacho.Rows(i).Cells(1).Value = datatbl(1)
                GrillaDespacho.Rows(i).Cells(2).Value = datatbl(2)
                GrillaDespacho.Rows(i).Cells(3).Value = datatbl(3)
                GrillaDespacho.Rows(i).Cells(4).Value = datatbl(4)
                GrillaDespacho.Rows(i).Cells(5).Value = datatbl(5)
                GrillaDespacho.Rows(i).Cells(6).Value = datatbl(6)
                GrillaDespacho.Rows(i).Cells(7).Value = datatbl(7)
                GrillaDespacho.Rows(i).Cells(8).Value = datatbl(8)
                GrillaDespacho.Rows(i).Cells(9).Value = datatbl(9)
                GrillaDespacho.Rows(i).Cells(10).Value = datatbl(10)
                GrillaDespacho.Rows(i).Cells(11).Value = datatbl(11)
                GrillaDespacho.Rows(i).Cells(12).Value = datatbl(12)
                i += 1
            End While
        End If
        close_conexion()
    End Sub

    Private Sub ReporteLotesPreparadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteLotesPreparadosToolStripMenuItem.Click
        REM Reporte Lotes Confirmados para Colocación de Banderas
        Dim ifila As Integer = GrillaDespacho.CurrentRow.Index
        dtpFecRepLotesConf.Value = GrillaDespacho.Rows(ifila).Cells(7).Value
        RepLotConf.Visible = True
    End Sub



    Private Sub IrAToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IrAToolStripMenuItem.Click
        Me.Close()
        CtlDesp.Show()
    End Sub



    Private Sub ConsultaLoteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultaLoteToolStripMenuItem.Click
        If GrillaDespacho.Rows.Count > 0 Then
            Dim iCurrent As Integer
            iCurrent = GrillaDespacho.CurrentRow.Index
            Cambio_Estado.txt_NumLote.Text = GrillaDespacho.Rows(iCurrent).Cells(1).Value
            gQuienLlama = 2
            Cambio_Estado.Show()
        End If
    End Sub

    Private Sub btnBuscaLote_Click(sender As Object, e As EventArgs) Handles btnBuscaLote.Click
        If Val(txtNumLote.Text) > 0 Then
            Dim bEncontro As Boolean = False
            Dim NumFilas As Integer = GrillaDespacho.RowCount
            Dim i As Integer
            For i = 0 To GrillaDespacho.Rows.Count - 1
                If txtNumLote.Text = GrillaDespacho.Rows(i).Cells(1).Value Then
                    'this.dataGridView1.CurrentCell = this.dataGridView1[1,0];
                    GrillaDespacho.CurrentCell = GrillaDespacho(0, i)
                    bEncontro = True
                End If
            Next
            If bEncontro = False Then
                'DataGridView5.Rows.Add()
                GrillaDespacho.CurrentCell = GrillaDespacho(1, NumFilas - 1)
                GrillaDespacho.Rows(NumFilas - 1).Cells(1).Value = txtNumLote.Text
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GuardarDatos()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ResumenLoteConfFechaDesp()
        ResumenLoteConfSector()
    End Sub

    Private Sub GrillaDespacho_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaDespacho.CellContentClick

    End Sub
End Class