Public Class Control_Despachos

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If cmb_Estado.SelectedIndex = -1 Then
            MsgBox("Seleccione Estado Lote", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If cmb_Estado.SelectedIndex = 0 Then
            btn_Confirmar.Enabled = True
        Else
            btn_Confirmar.Enabled = False
        End If

        Consulta_Despachos()

    End Sub
    Private Sub Consulta_Despachos()
        Dim dTotalBandejas As Integer = 0
        Dim i As Integer = 0

        sSsql = "SP_CONSULTA_DESPACHOS "
        If cmb_Zona.SelectedIndex = -1 Then
            sSsql += "Null,"
        Else
            sSsql += "'" + cmb_Zona.Text + "',"
        End If

        If cmb_Sector.SelectedIndex = -1 Then
            sSsql += "Null,"
        Else
            sSsql += "'" + cmb_Sector.Text + "',"
        End If

        sSsql += "'" + Format(dtp_fecha1.Value, "d") + "',"
        sSsql += "'" + Format(dtp_fecha2.Value, "d") + "',"

        If cmb_Estado.SelectedIndex = 0 Then
            sSsql += "1,2"
        Else
            sSsql += "3,3"
        End If

        open()

        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        DataGrilla.Rows.Clear()

        If datatbl.HasRows Then
            i = 0
            While datatbl.Read = True
                DataGrilla.Rows.Add()
                DataGrilla.Rows(i).Cells(0).Value = datatbl(0)
                DataGrilla.Rows(i).Cells(1).Value = datatbl(1)
                DataGrilla.Rows(i).Cells(2).Value = datatbl(2)
                DataGrilla.Rows(i).Cells(3).Value = datatbl(3)
                DataGrilla.Rows(i).Cells(4).Value = datatbl(4)
                DataGrilla.Rows(i).Cells(5).Value = datatbl(5)
                DataGrilla.Rows(i).Cells(6).Value = datatbl(6)
                DataGrilla.Rows(i).Cells(7).Value = datatbl(7)
                DataGrilla.Rows(i).Cells(8).Value = Format(datatbl(8), "###,###,###")
                DataGrilla.Rows(i).Cells(9).Value = Format(datatbl(9), "###,###")
                DataGrilla.Rows(i).Cells(10).Value = datatbl(10)
                dTotalBandejas += datatbl(9)
                i += 1

            End While
        Else
            MsgBox("No Existen registros para los datos consultados.")

        End If
        close_conexion()
        txt_TotalBandejas.Text = Format(dTotalBandejas, "###,###")
    End Sub

    Private Sub Control_Despachos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Carga_Full_Zona(Me.cmb_Zona)

    End Sub

    Private Sub cmb_Zona_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Zona.SelectedIndexChanged
        If cmb_Zona.SelectedIndex > -1 Then
            Carga_Sector_x_Zona()
        Else
            cmb_Sector.Items.Clear()
        End If
    End Sub
    Private Sub Carga_Sector_x_Zona()
        sSsql = "SP_CONSULTA_FULL_SECTOR_ZONA "
        sSsql += "'" + cmb_Zona.Text + "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        cmb_Sector.Items.Clear()

        If datatbl.HasRows Then

            While datatbl.Read = True
                Me.cmb_Sector.Items.Add(datatbl(1))
            End While

        End If
 
        close_conexion()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cmb_Zona.Items.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cmb_Sector.Items.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Confirmar.Click

        Dim sResp = MsgBox("Confirme que los Lotes marcados pasarán al estado de Emisión de Guías.", MsgBoxStyle.YesNo, "Actualizar Control Despachos")

        If sResp = MsgBoxResult.Yes Then
            Dim sResp2 = MsgBox("Debe Confirmar este proceso. Esta seguro que va a Despachar los Lotes seleccionados?", MsgBoxStyle.YesNo, "Actualizar Control Despachos")
            If sResp2 = MsgBoxResult.Yes Then
                Actualiza_Lote()
            End If
        End If

    End Sub
    Private Sub Actualiza_Lote()
        Dim iContador_Grabados As Integer = 0

        open()
        For i As Integer = 0 To DataGrilla.Rows.Count - 1
            If DataGrilla.Rows(i).Cells(11).Value = True Then
                sSsql = "SP_ACTUALIZA_DETALLE_PEDIDO "
                sSsql += DataGrilla.Rows(i).Cells(2).Value.ToString + ","
                sSsql += "3,"
                sSsql += "'',"
                sSsql += "0,"
                sSsql += "'',"
                sSsql += "0,"
                sSsql += "'',"
                sSsql += "'" + Format(Date.Now, "d") + "',"
                sSsql += "'AVISO DE ENTREGA/RETIRO DE PLANTAS',"
                sSsql += "0,"
                sSsql += "0,"
                sSsql += "0"

                '@NumLote int,
                '@ESTADO int,
                '@FechaConteoSiembra datetime,
                '@ConteoSiembra int,
                '@FechaConteoPlantas datetime,
                '@ConteoPlantas int,
                '@FechaEntregaLote datetime,
                '@FechaAvisoCliente datetime,
                '@AvisoCliente varchar(100),
                '@Cant_Band_CInicial int,
                '@Cant_Celdas_Vacias_Cinicial int,
                '@Num_Nave int

                command = connection.CreateCommand
                command.CommandText = sSsql
                command.ExecuteNonQuery()

                iContador_Grabados += 1

            End If
        Next
        close_conexion()
        If iContador_Grabados > 0 Then
            MsgBox("Lotes han sido actualizados y se encuentran listos para Emisión de Guías.")
        Else
            MsgBox("No se ha seleccionado ningún Lote para cambiar al estado Emisión de Guías.")
        End If
        DataGrilla.Rows.Clear()
        cmb_Sector.SelectedIndex = -1
        cmb_Zona.SelectedIndex = -1
    End Sub
End Class