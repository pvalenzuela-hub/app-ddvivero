Public Class Libro_Compras

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub BTN_BUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_BUSCAR.Click
        Busca_Proveedor(Me.cmb_PROVEEDOR, txt_BUSCARPROVEEDOR.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Libro_Compras()
    End Sub
    Private Sub Libro_Compras()
        'SP_LIBRO_COMPRA '01-03-2011','31-03-2011',''
        Dim i As Integer = 0
        Dim dTotalNeto As Double = 0
        Dim dImpEspec As Double = 0
        Dim dTotalIVA As Double = 0
        Dim dTotalFinal As Double = 0
        Dim iDocNormal As Integer = 0
        Dim iDocElect As Integer = 0

        sSsql = "SP_LIBRO_COMPRA "
        sSsql += "'" + Format(txt_Fecha1.Value, "d") + "',"
        sSsql += "'" + Format(txt_Fecha2.Value, "d") + "',"

        If chk_FiltroProv.Checked Then
            'Consulta por proveedor
            If cmb_PROVEEDOR.SelectedIndex = -1 Then
                MsgBox("Debe Seleccionar Proveedor", MsgBoxStyle.Information)
                Exit Sub
            End If
            sSsql += "'" + cmb_PROVEEDOR.Text + "'"
        Else
            sSsql += "''"
        End If
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        DataGrilla.Rows.Clear()

        If datatbl.HasRows Then
            While datatbl.Read = True
                DataGrilla.Rows.Add()
                DataGrilla.Rows(i).Cells(0).Value = datatbl(0)
                DataGrilla.Rows(i).Cells(1).Value = datatbl(1)
                DataGrilla.Rows(i).Cells(2).Value = datatbl(2)
                DataGrilla.Rows(i).Cells(3).Value = datatbl(3)
                DataGrilla.Rows(i).Cells(4).Value = datatbl(4)
                DataGrilla.Rows(i).Cells(5).Value = Format(datatbl(5), "###,###,###")
                DataGrilla.Rows(i).Cells(6).Value = Format(datatbl(6), "###,###,###")
                DataGrilla.Rows(i).Cells(7).Value = Format(datatbl(7), "###,###,###")
                DataGrilla.Rows(i).Cells(8).Value = Format(datatbl(8), "###,###,###")
                DataGrilla.Rows(i).Cells(9).Value = datatbl(9)
                
                dTotalNeto += datatbl(5)
                dImpEspec += datatbl(6)
                dTotalIVA += datatbl(7)
                dTotalFinal += datatbl(8)

                If datatbl(9) = "N" Then
                    iDocNormal += 1
                Else
                    iDocElect += 1
                End If

                i += 1

            End While
            

            Me.txt_TOTALNETO.Text = Format(dTotalNeto, "###,###,##0")
            Me.txt_ImpEspec.Text = Format(dImpEspec, "###,###,##0")
            Me.txt_IVA.Text = Format(dTotalIVA, "###,###,##0")
            Me.txt_TOTALFINAL.Text = Format(dTotalFinal, "###,###,##0")
            Me.txt_DocElect.Text = Format(iDocElect, "###,###")
            Me.txt_DocNormal.Text = Format(iDocNormal, "###,###")
        Else
            MessageBox.Show("NO EXISTEN COMPORAS EN EL PERIODO SELECCIONADO")
        End If
        datatbl.Close()
        close_conexion()
    End Sub


End Class