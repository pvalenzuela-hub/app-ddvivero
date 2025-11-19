Public Class Consulta_Pedido_Especie_Cliente

    Private Sub Consulta_Pedido_Especie_Cliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Carga_Familia_Prod(Me.cmb_Especie)
        Carga_Sector(Me.cmb_Sector)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If cmb_Especie.SelectedIndex = -1 Then
            MsgBox("Seleccione Especie", MsgBoxStyle.Exclamation)
            Exit Sub
        End If



        Dim dTotalPlantas As Double = 0
        Dim i As Integer = 0

        GrillaRepo.Rows.Clear()

        sSsql = "SP_CONSULTA_Siembra_Cliente "
        sSsql += "'" + Format(dtp_Fecha1.Value, "d") + "',"
        sSsql += "'" + Format(dtp_Fecha2.Value, "d") + "',"
        sSsql += "'" + cmb_Especie.Text + "',"
        If cmb_Sector.SelectedIndex = -1 Or RTrim(cmb_Sector.Text) = "" Then
            sSsql += "Null"
        Else
            sSsql += "'" + cmb_Sector.Text + "'"
        End If

        open()

        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        i = 0
        If datatbl.HasRows Then
            While datatbl.Read = True
                GrillaRepo.Rows.Add()
                GrillaRepo.Rows(i).Cells(0).Value = datatbl(0)
                GrillaRepo.Rows(i).Cells(1).Value = datatbl(1)
                GrillaRepo.Rows(i).Cells(2).Value = datatbl(2)
                GrillaRepo.Rows(i).Cells(3).Value = datatbl(6)
                GrillaRepo.Rows(i).Cells(4).Value = RTrim(datatbl(3))
                GrillaRepo.Rows(i).Cells(5).Value = datatbl(5)
                GrillaRepo.Rows(i).Cells(6).Value = Format(datatbl(7), "###,###")
                i += 1
                dTotalPlantas += datatbl(7)
            End While
        Else
            MessageBox.Show("NO EXISTEN DATOS ASOCIADOS A LA CONSULTA")
        End If
        close_conexion()
        txt_TotPlantas.Text = Format(dTotalPlantas, "###,###,###")


    End Sub
End Class