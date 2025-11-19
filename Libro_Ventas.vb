Public Class Libro_Ventas
    Dim gFiltro As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CargaGrilla()
    End Sub
    Private Sub CargaGrilla()

        Dim dTotal_Neto As Double
        Dim dTotal_IVA As Double
        Dim dTotal_Venta As Double
        Dim dDetIva As Double
        Dim i As Integer

        'Ejecutar Consulta

        DataGrilla.Rows.Clear()

        sSsql = "SP_LIBRO_VENTA '" + Format(txt_Fecha1.Value, "d") + "','"
        sSsql += Format(txt_Fecha2.Value, "d") + "',"
        sSsql += "'" + gFiltro + "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()


        If datatbl.HasRows Then
            While datatbl.Read = True

                DataGrilla.Rows.Add()
                i = DataGrilla.Rows.Count - 1
                dDetIva = datatbl(5) - datatbl(6)
                DataGrilla.Rows(i).Cells(0).Value = datatbl(0)
                DataGrilla.Rows(i).Cells(1).Value = datatbl(1)
                DataGrilla.Rows(i).Cells(2).Value = RTrim(datatbl(2))

                If gFiltro <> "XX" Then
                    DataGrilla.Rows(i).Cells(3).Value = Format(Val(Mid(datatbl(3), 1, 11)), "###,###,###") + "-" + Mid(datatbl(3), 12, 1)
                Else
                    DataGrilla.Rows(i).Cells(3).Value = datatbl(3)
                End If
                DataGrilla.Rows(i).Cells(4).Value = datatbl(4)
                DataGrilla.Rows(i).Cells(5).Value = Format(datatbl(6), "###,###,###")
                DataGrilla.Rows(i).Cells(6).Value = Format(dDetIva, "###,###,###")
                DataGrilla.Rows(i).Cells(7).Value = Format(datatbl(5), "###,###,###")

                dTotal_Neto += datatbl(6)
                dTotal_IVA += dDetIva
                dTotal_Venta += datatbl(5)


            End While
         

            Me.txt_TOTALNETO.Text = Format(dTotal_Neto, "###,###,##0")
            Me.txt_IVA.Text = Format(dTotal_IVA, "###,###,##0")
            Me.txt_TOTALFINAL.Text = Format(dTotal_Venta, "###,###,##0")

        Else
            MessageBox.Show("NO EXISTEN VENTAS EN EL PERIODO SELECCIONADO")
        End If
        datatbl.Close()
        close_conexion()

    End Sub

    

    Private Sub rb1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb1.CheckedChanged
        If rb1.Checked Then
            gFiltro = "FA"
        End If
    End Sub

    Private Sub rb2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb2.CheckedChanged
        If rb2.Checked Then
            gFiltro = "BO"
        End If
    End Sub

    Private Sub rb3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb3.CheckedChanged
        If rb3.Checked Then
            gFiltro = "BE"
        End If
    End Sub

    Private Sub rb4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb4.CheckedChanged
        If rb4.Checked Then
            gFiltro = "NC"
        End If
    End Sub

    Private Sub rb5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb5.CheckedChanged
        If rb5.Checked Then
            gFiltro = "XX"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rb6.CheckedChanged
        If rb6.Checked = True Then
            gFiltro = "BL"
        End If
    End Sub
End Class