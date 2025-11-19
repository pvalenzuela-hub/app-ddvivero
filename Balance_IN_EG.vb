Public Class Balance_IN_EG

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Consulta_Balance()
    End Sub
    Private Sub Consulta_Balance()
        'SP_Balance_IN_EG '01-01-2009','31-12-2010'7
        Dim dTotal As Double
        Dim dIngreso As Double = 0
        Dim dEgresos As Double = 0
        Dim dTotalIngresos As Double = 0
        Dim dTotalEgresos As Double = 0
        Dim sConcepto As String = ""
        Dim sTipo As String = ""
        Dim bControl As Boolean = True
        Dim bControl2 As Boolean = True
        Dim sCorte As String = ""
        Dim i As Integer
        'Ejecutar Consulta
        sSsql = "SP_Balance_IN_EG "
        sSsql += "'" + Format(dtp_Fecha1.Value, "yyyyMM") + "',"
        sSsql += "'" + Format(dtp_fecha2.Value, "yyyyMM") + "'"

        DataCompras.Rows.Clear()
       
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        dTotal = 0
        i = 0
        If datatbl.HasRows Then
            datatbl.Read()


            While bControl
                Try
                    If sCorte <> datatbl(1).ToString() + datatbl(2).ToString() Then
                        DataCompras.Rows.Add()
                        DataCompras.Rows(i).Cells(0).Value = MestoTexto(datatbl(2)) + "-" + datatbl(1).ToString()
                        'DataCompras.Rows(i).Cells(4).Value = sConcepto
                        sCorte = datatbl(1).ToString() + datatbl(2).ToString()
                        bControl2 = True

                    End If

                    sConcepto = ""
                    dEgresos = 0
                    dIngreso = 0

                    While bControl2
                        If sConcepto <> "" Then
                            sConcepto += " y "
                        End If
                        Select Case datatbl(0)
                            Case "01"
                                sConcepto += "Ventas"
                                sTipo = "IN"
                            Case "02"
                                sConcepto += "Otros Ingresos"
                                sTipo = "IN"
                            Case "03"
                                sConcepto += "Compras"
                                sTipo = "EG"
                            Case "04"
                                sConcepto += "Otros Egresos"
                                sTipo = "EG"

                        End Select
                        If sTipo = "EG" Then
                            dEgresos += datatbl(3)
                            'DataCompras.Rows(i).Cells(2).Value = Format(datatbl(2), "###,###,###")
                            'dEgresos = datatbl(2)

                        Else
                            'DataCompras.Rows(i).Cells(1).Value = Format(datatbl(2), "###,###,###")
                            'dIngreso = datatbl(2)
                            dIngreso += datatbl(3)
                        End If

                        datatbl.Read()

                        If sCorte <> datatbl(1).ToString() + datatbl(2).ToString() Then
                            bControl2 = False
                        End If

                    End While
                    DataCompras.Rows(i).Cells(1).Value = Format(dIngreso, "###,###,###")
                    DataCompras.Rows(i).Cells(2).Value = Format(dEgresos, "###,###,###")
                    DataCompras.Rows(i).Cells(3).Value = Format(dIngreso - dEgresos, "###,###,###")
                    DataCompras.Rows(i).Cells(4).Value = sConcepto

                    dTotalIngresos += dIngreso
                    dTotalEgresos += dEgresos
                    dIngreso = 0
                    dEgresos = 0

                    i += 1

                Catch ex As Exception
                    ' Display error
                    bControl = False
                    Exit While
                Finally
                    ' finally
                   
                End Try


            End While
            'DataCompras.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Else
            MessageBox.Show("NO EXISTEN DATOS ASOCIADOS A LA CONSULTA")
        End If
        close_conexion()
        If dIngreso > 0 Or dEgresos > 0 Then
            DataCompras.Rows(i).Cells(1).Value = Format(dIngreso, "###,###,###")
            DataCompras.Rows(i).Cells(2).Value = Format(dEgresos, "###,###,###")
            DataCompras.Rows(i).Cells(3).Value = Format(dIngreso - dEgresos, "###,###,###")
            DataCompras.Rows(i).Cells(4).Value = sConcepto
            dTotalIngresos += dIngreso
            dTotalEgresos += dEgresos
            i += 1
        End If
        dTotal = dTotalIngresos - dTotalEgresos
        DataCompras.Rows.Add()
        DataCompras.Rows(i).Cells(0).Value = "TOTAL"
        DataCompras.Rows(i).Cells(1).Value = Format(dTotalIngresos, "###,###,###")
        DataCompras.Rows(i).Cells(2).Value = Format(dTotalEgresos, "###,###,###")
        DataCompras.Rows(i).Cells(3).Value = Format(dTotal, "###,###,###")

    End Sub
End Class