Public Class ConsultaLotesPantalla
    Private Sub ConsultaLotesPantalla_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.SP_CONSULTA_FULL_FAMILIA_PRODUCTOTableAdapter.Fill(Me.GESTDataSet.SP_CONSULTA_FULL_FAMILIA_PRODUCTO)
        cmbVariedad.SelectedIndex = -1
        cmbSemilla.SelectedIndex = -1
        CargaGrillaLotes()



    End Sub

    Private Sub CargaGrillaLotes()
        Dim i As Integer = 0

        GrillaLotes.Rows.Clear()
        sSsql = "[dbo].[NEWSP_CONSULTA_LOTES] "
        If cmbSemilla.SelectedIndex > -1 Then
            sSsql += cmbSemilla.SelectedValue.ToString & ","
        Else
            sSsql += "0,"
        End If
        If cmbVariedad.SelectedIndex > -1 Then
            sSsql += cmbVariedad.SelectedValue.ToString
        Else
            sSsql += "0"
        End If


        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            While datatbl.Read
                GrillaLotes.Rows.Add()
                GrillaLotes.Rows(i).Cells("nlote").Value = datatbl("NLote")
                GrillaLotes.Rows(i).Cells("cliente").Value = datatbl("Cliente")
                GrillaLotes.Rows(i).Cells("semilla").Value = datatbl("Semilla")
                GrillaLotes.Rows(i).Cells("variedad").Value = datatbl("Variedad")
                GrillaLotes.Rows(i).Cells("semilla").Value = datatbl("Semilla")
                GrillaLotes.Rows(i).Cells("aportasemilla").Value = datatbl("AportaSemilla")
                GrillaLotes.Rows(i).Cells("pedido").Value = datatbl("Pedido")
                GrillaLotes.Rows(i).Cells("fechaconteos").Value = datatbl("FechaConteoSiembra")
                GrillaLotes.Rows(i).Cells("tipo").Value = datatbl("Tipo")
                GrillaLotes.Rows(i).Cells("saldoplanta").Value = datatbl("SaldoPlantas")
                GrillaLotes.Rows(i).Cells("saldobandeja").Value = datatbl("SaldoBandejas")
                GrillaLotes.Rows(i).Cells("fechasiembra").Value = datatbl("FechaSiembra")
                GrillaLotes.Rows(i).Cells("fechaentrega").Value = datatbl("FechaEntrega")
                GrillaLotes.Rows(i).Cells("estadolote").Value = datatbl("EstadoLote")
                GrillaLotes.Rows(i).Cells("ubicacion").Value = datatbl("Ubicacion")
                GrillaLotes.Rows(i).Cells("numnave").Value = datatbl("Nave")
                GrillaLotes.Rows(i).Cells("diasvivero").Value = datatbl("DiasVivero")
                GrillaLotes.Rows(i).Cells("FechaAutorizacionCliente").Value = datatbl("FechaAutorizacionCliente")

                If datatbl("Atraso") = 1 Then
                    GrillaLotes.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                End If
                i += 1
            End While
        End If
        close_conexion()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cmbSemilla.SelectedIndex > -1 Then
            Consulta_Lotes.txtIdSemilla.Text = cmbSemilla.SelectedValue
        Else
            Consulta_Lotes.txtIdSemilla.Text = 0
        End If
        If cmbVariedad.SelectedIndex > -1 Then
            Consulta_Lotes.txtIdVariedad.Text = cmbVariedad.SelectedValue
        Else
            Consulta_Lotes.txtIdVariedad.Text = 0
        End If
        Consulta_Lotes.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cmbSemilla.SelectedIndex = -1
        cmbVariedad.SelectedIndex = -1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CargaGrillaLotes()
    End Sub

    Private Sub cmbSemilla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSemilla.SelectedIndexChanged
        If cmbSemilla.SelectedIndex > -1 Then
            Me.SP_CONSULTA_FULL_VARIEDAD_IdFamiliaTableAdapter.Fill(Me.GESTDataSet.SP_CONSULTA_FULL_VARIEDAD_IdFamilia, cmbSemilla.SelectedValue)
            cmbVariedad.SelectedIndex = -1
        End If
    End Sub
End Class