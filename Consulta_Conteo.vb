Public Class Consulta_Conteo

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Ejecuta_Reporte()

    End Sub
    Private Sub Ejecuta_Reporte()
        Dim sparametro As String = ""

        If chk_0.Checked Then
            sparametro = "0"
        End If
        If chk_1.Checked Then
            If sparametro = "" Then
                sparametro = "1"
            Else
                sparametro += ",1"
            End If
        End If
        If chk_2.Checked Then
            If sparametro = "" Then
                sparametro = "2"
            Else
                sparametro += ",2"
            End If
        End If
        If chk_3.Checked Then
            If sparametro = "" Then
                sparametro = "3"
            Else
                sparametro += ",3"
            End If
        End If

        Me.SP_CONSULTA_LOTE_CONTEOTableAdapter.Fill(Me.GESTDataSet.SP_CONSULTA_LOTE_CONTEO, sparametro)

        Me.ReportViewer1.RefreshReport()

    End Sub
    Private Sub Carga_Consulta()
        'Dim i As Integer
        'Dim iSiembra As Integer
        'Dim iPlantas As Integer
        'Dim iCantBandCInicial As Integer
        'Dim iParametroSaldo As Integer

        ''Ejecutar Consulta

        'If rdb_concontsiembra.Checked = True Then
        '    iSiembra = 1
        'End If
        'If rdb_SinContSiembra.Checked = True Then
        '    iSiembra = 0
        'End If
        'If rdb_SiembraTodos.Checked = True Then
        '    iSiembra = -1
        'End If

        'If rdb_ConContPlantas.Checked = True Then
        '    iPlantas = 1
        'End If
        'If rdb_SinContPlantas.Checked = True Then
        '    iPlantas = 0
        'End If
        'If rdb_PlantasTodos.Checked = True Then
        '    iPlantas = -1
        'End If

        'If chk_Todo.Checked = True Then
        '    iParametroSaldo = 0
        'Else
        '    iParametroSaldo = 1
        'End If

        'sSsql = "SP_CONSULTA_LOTE_CONTEO " + Str(iSiembra) + "," + Str(iPlantas) + "," + Str(iParametroSaldo) + ","
        'sSsql += txt_NumDias.Value.ToString
        'open()
        'command = connection.CreateCommand()
        'command.CommandText = sSsql
        'datatbl = command.ExecuteReader()

        'GrillaLote.Rows.Clear()
        'i = 0
        'If datatbl.HasRows Then
        '    While datatbl.Read = True
        '        GrillaLote.Rows.Add()
        '        GrillaLote.Rows(i).Cells(0).Value = datatbl(0)
        '        GrillaLote.Rows(i).Cells(1).Value = datatbl(1)
        '        GrillaLote.Rows(i).Cells(2).Value = datatbl(2)
        '        GrillaLote.Rows(i).Cells(3).Value = datatbl(34)
        '        GrillaLote.Rows(i).Cells(4).Value = datatbl(35)
        '        GrillaLote.Rows(i).Cells(5).Value = datatbl(36)
        '        GrillaLote.Rows(i).Cells(6).Value = datatbl(7)
        '        GrillaLote.Rows(i).Cells(7).Value = Format(datatbl(6), "###,###.00")
        '        GrillaLote.Rows(i).Cells(8).Value = Format(datatbl(8), "###,###")
        '        GrillaLote.Rows(i).Cells(9).Value = datatbl(19)
        '        GrillaLote.Rows(i).Cells(10).Value = datatbl(12)
        '        GrillaLote.Rows(i).Cells(11).Value = datatbl(13)
        '        If IsDBNull(datatbl(14)) Then
        '            iCantBandCInicial = 0
        '        Else
        '            iCantBandCInicial = datatbl(14)
        '        End If

        '        GrillaLote.Rows(i).Cells(12).Value = Format(iCantBandCInicial, "###")
        '        GrillaLote.Rows(i).Cells(13).Value = datatbl(16)
        '        GrillaLote.Rows(i).Cells(14).Value = Format(datatbl(18), "###,###")
        '        GrillaLote.Rows(i).Cells(15).Value = datatbl(19)
        '        GrillaLote.Rows(i).Cells(16).Value = Format(datatbl(22), "###,###")
        '        GrillaLote.Rows(i).Cells(17).Value = Format(datatbl(22), "###,###")
        '        GrillaLote.Rows(i).Cells(18).Value = datatbl(23)
        '        GrillaLote.Rows(i).Cells(19).Value = Format(datatbl(24), "##,###")
        '        GrillaLote.Rows(i).Cells(20).Value = Format(datatbl(28), "###,###")
        '        GrillaLote.Rows(i).Cells(21).Value = datatbl(29)
        '        GrillaLote.Rows(i).Cells(22).Value = datatbl(30)
        '        GrillaLote.Rows(i).Cells(23).Value = datatbl(31)
        '        GrillaLote.Rows(i).Cells(24).Value = datatbl(32)
        '        GrillaLote.Rows(i).Cells(25).Value = datatbl(33)
        '        i += 1

        '        '-- 19 fecha siembra
        '        '-- 20 cont. plantas
        '        '-- 21   saldo plantas
        '        '-- 22   fec.conteo
        '        '-- 23   band. conteo
        '        '-- 27   total lote
        '        '-- 28   ident. semilla
        '        '-- 29   batch
        '        '-- 30   fec.envasdo
        '        '-- 31   aporta semilla
        '        '-- 32   lote orig.

        '    End While

        'Else
        '    MessageBox.Show("NO EXISTEN DATOS ASOCIADOS A LA CONSULTA")
        'End If
        'close_conexion()

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub



End Class