Public Class ModificaVenta
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtIdCliente.TextChanged
        '' busca documentos cliente
        Dim i As Integer = 0
        sSsql = "[dbo].[NEWSP_CONSULTA_DOCVENTA_CLIENTE] " & txtIdCliente.Text.ToString()
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            DataDocumento.Rows.Clear()
            While datatbl.Read
                DataDocumento.Rows.Add()
                DataDocumento.Rows(i).Cells("tipodoc").Value = datatbl("TIPO_DOC")
                DataDocumento.Rows(i).Cells("numdoc").Value = datatbl("NUM_DOC")
                DataDocumento.Rows(i).Cells("idvtahead").Value = datatbl("IdvtaHead")
                DataDocumento.Rows(i).Cells("numdocsii").Value = datatbl("NumDocSII")
                DataDocumento.Rows(i).Cells("tipodocsii").Value = datatbl("TipoDocSII")
                DataDocumento.Rows(i).Cells("valortotal").Value = datatbl("Valor_Doc")
                DataDocumento.Rows(i).Cells("totalpagos").Value = datatbl("TOTAL_PAGO")
                DataDocumento.Rows(i).Cells("fecha").Value = datatbl("fecha_doc")
                i += 1
            End While
        End If
        close_conexion()
    End Sub

    Private Sub btnBuscaCliente_Click(sender As Object, e As EventArgs) Handles btnBuscaCliente.Click

        Me.TopMost = False

        If chkCliente.Checked Then
            BusquedaCliente.chkIncluyePrimerNombre.Checked = True
        Else
            BusquedaCliente.chkIncluyePrimerNombre.Checked = False
        End If
        gQuienLlama = 16
        gNOMBRE = txt_clientebuscar.Text
        BusquedaCliente.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataDocumento.Rows.Count > 0 Then
            Dim i As Integer = DataDocumento.CurrentRow.Index
            'idvtahead
            frmtablavirtual.txtIdVtaHead.Text = DataDocumento.Rows(i).Cells("idvtahead").Value
            frmtablavirtual.txtTipoDocSII.Text = DataDocumento.Rows(i).Cells("tipodocsii").Value
            frmtablavirtual.txtNumDocSII.Text = DataDocumento.Rows(i).Cells("numdocsii").Value
            Me.Close()
        End If
    End Sub

    Private Sub ModificaVenta_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Val(frmtablavirtual.txt_IDcliente.Text) > 0 Then
            txtIdCliente.Text = frmtablavirtual.txt_IDcliente.Text
        End If
    End Sub
End Class