Public Class Consulta_Cmpbte
    Dim gNumCmpbte As Integer
    Private Sub dtp_Fecha1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_Fecha1.LostFocus
        dtp_Fecha2.Value = dtp_Fecha1.Value
    End Sub

    Private Sub dtp_Fecha2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_Fecha2.LostFocus
        If dtp_Fecha1.Value > dtp_Fecha2.Value Then
            MsgBox("Corriga Rango de Fecha", MsgBoxStyle.Exclamation)
            dtp_Fecha2.Focus()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Public Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Consulta_Comprobantes()
    End Sub
    Private Sub Consulta_Comprobantes()
        Dim i As Integer = 0
        Dim dTotalDEBE As Double = 0
        Dim dTotalHABER As Double = 0
        Dim dTotalDEBECta As Double = 0
        Dim dTotalHABERCta As Double = 0
        Dim dSaldoCuenta As Double = 0

        sSsql = "SP_CONSULTA_CONTA_Cpmbte_Head_fecha "

        If txt_IdCmpbte.Text <> Nothing Then
            sSsql += "'','',''," + txt_IdCmpbte.Text.ToString()
        Else
            sSsql += "'" + Format(dtp_Fecha1.Value, "d") + "',"
            If txt_Cta_Ctble.Text = Nothing Then
                sSsql += "'" + Format(dtp_Fecha2.Value, "d") + "',"
            Else
                sSsql += "'" + Format(dtp_Fecha2.Value, "d") + "',"
                sSsql += "'" + txt_Cta_Ctble.Text + "',"
            End If
            sSsql += "Null"

        End If



        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            DataCmpbte.Rows.Clear()
            DataMovto.Rows.Clear()
            While datatbl.Read
                DataCmpbte.Rows.Add()
                DataCmpbte.Rows(i).Cells(0).Value = datatbl(0)
                DataCmpbte.Rows(i).Cells(1).Value = datatbl(1)
                DataCmpbte.Rows(i).Cells(2).Value = datatbl(2)
                DataCmpbte.Rows(i).Cells(3).Value = datatbl(3)
                DataCmpbte.Rows(i).Cells(4).Value = Format(datatbl(4), "###,###,###")
                DataCmpbte.Rows(i).Cells(5).Value = Format(datatbl(5), "###,###,###")
                DataCmpbte.Rows(i).Cells(6).Value = datatbl(7)
                DataCmpbte.Rows(i).Cells(7).Value = datatbl(8)
                DataCmpbte.Rows(i).Cells(8).Value = datatbl(6)
                i += 1
                dTotalDEBE += datatbl(4)
                dTotalHABER += datatbl(5)
                If txt_Cta_Ctble.Text <> Nothing And txt_IdCmpbte.Text = Nothing Then
                    dTotalDEBECta += datatbl(9)
                    dTotalHABERCta += datatbl(10)
                    txt_Descripcion.Text = datatbl(11)
                End If


            End While
            txt_TotalDEBE.Text = Format(dTotalDEBE, "###,###,###")
            txt_TotalHABER.Text = Format(dTotalHABER, "###,###,###")

            txt_TotalDEBECTA.Text = Format(dTotalDEBECta, "###,###,###")
            txt_TotalHABERCTA.Text = Format(dTotalHABERCta, "###,###,###")
            dSaldoCuenta = dTotalDEBECta - dTotalHABERCta
            If dSaldoCuenta < 0 Then
                txt_SaldoCuenta.Text = Format(Math.Abs(dSaldoCuenta), "CR ###,###,###")
            Else
                txt_SaldoCuenta.Text = Format(dSaldoCuenta, "DB ###,###,###")
            End If
        Else
            MsgBox("No Existen Comprobantes para las fechas seleccionadas.", MsgBoxStyle.Information)

        End If
        close_conexion()
        txt_IdCmpbte.Clear()
    End Sub

    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Fila As Integer
        Dim i As Integer = 0

        If DataCmpbte.Rows.Count > 0 Then

            DataMovto.Rows.Clear()

            Fila = DataCmpbte.CurrentCell.RowIndex
            gNumCmpbte = DataCmpbte.Rows(Fila).Cells(0).Value

            sSsql = "SP_CONSULTA_CONTA_Cpmbte_Det "
            sSsql += gNumCmpbte.ToString
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                While datatbl.Read
                    DataMovto.Rows.Add()
                    DataMovto.Rows(i).Cells(0).Value = datatbl(0)
                    DataMovto.Rows(i).Cells(1).Value = datatbl(2)
                    DataMovto.Rows(i).Cells(2).Value = datatbl(12)
                    DataMovto.Rows(i).Cells(3).Value = Format(datatbl(4), "###,###,###")
                    DataMovto.Rows(i).Cells(4).Value = Format(datatbl(5), "###,###,###")
                    DataMovto.Rows(i).Cells(5).Value = datatbl(8)
                    DataMovto.Rows(i).Cells(6).Value = datatbl(3)
                    DataMovto.Rows(i).Cells(7).Value = datatbl(6)
                    DataMovto.Rows(i).Cells(8).Value = datatbl(11)

                    i += 1
                End While
            End If
            close_conexion()

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Fila As Integer
        Fila = DataCmpbte.CurrentCell.RowIndex
        If DataCmpbte.Rows.Count > 0 Then

            Dim sResp = MsgBox("CONFIRME ELIMINACION DE COMPROBANTE N° " + DataCmpbte.Rows(Fila).Cells(0).Value.ToString(), MsgBoxStyle.YesNo)
            If sResp = MsgBoxResult.Yes Then

                sSsql = "[dbo].[SP_EliminaComprobanteContable] " + DataCmpbte.Rows(Fila).Cells(0).Value.ToString()
                open()
                command = connection.CreateCommand()
                command.CommandText = sSsql
                command.ExecuteNonQuery()
                close_conexion()
                MsgBox("Comprobante N° " + DataCmpbte.Rows(Fila).Cells(0).Value.ToString() + " ha sido Eliminado del sistema!")
                Me.Close()
                Exit Sub
            Else
                Exit Sub
            End If



        End If


    End Sub
End Class