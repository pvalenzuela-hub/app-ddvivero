Public Class ModificaDocumentoVenta
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EjecutaBusqueda

    End Sub

    Public Sub EjecutaBusqueda()
        Dim i As Integer = 0
        sSsql = "[dbo].[SP_CONSULTA_DOCVENTA_Modificacion] "
        If txtNumDoc.Text = Nothing Then
            sSsql += "Null,"
        Else
            sSsql += txtNumDoc.Text.ToString() + ","
        End If
        If cmbTipoDoc.SelectedIndex = -1 OrElse cmbTipoDoc.Text = "" Then
            sSsql += "Null,"
        Else
            sSsql += "'" & cmbTipoDoc.Text & "',"
        End If
        If rbsindoc.Checked Then
            sSsql += "0"
        ElseIf rbcondoc.Checked Then
            sSsql += "1"
        Else
            sSsql += "Null"
        End If

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        DataDocVenta.Rows.Clear()

        If datatbl.HasRows Then
            While datatbl.Read
                DataDocVenta.Rows.Add()
                DataDocVenta.Rows(i).Cells("Fecha").Value = datatbl("FechaDoc")
                DataDocVenta.Rows(i).Cells("Cliente").Value = datatbl("Cliente")
                DataDocVenta.Rows(i).Cells("Tipo").Value = datatbl("Tipo_Doc")
                DataDocVenta.Rows(i).Cells("Numdoc").Value = datatbl("Num_Doc")
                DataDocVenta.Rows(i).Cells("Monto").Value = datatbl("Valor_Doc")
                DataDocVenta.Rows(i).Cells("Numdocsii").Value = datatbl("NumDocSII")
                DataDocVenta.Rows(i).Cells("Tipodocsii").Value = datatbl("TipoDocSII")
                DataDocVenta.Rows(i).Cells("idVtaHead").Value = datatbl("IdvtaHead")
                i += 1
            End While
        End If
        close_conexion()

    End Sub

    Private Sub DataDocVenta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataDocVenta.CellDoubleClick
        'doble click
        Dim col As Integer = e.ColumnIndex
        If col = 5 OrElse col = 6 Then
            If col = 5 Then
                ' modifica N° SII
                gQuienLlama = 5
            End If

            If col = 6 Then
                ' modifica Tipo doc. SII
                gQuienLlama = 6
            End If

            ModificaDatosVenta.txtDocSII.Text = DataDocVenta.Rows(e.RowIndex).Cells("Numdocsii").Value
            ModificaDatosVenta.cmbTipoDocSII.Text = DataDocVenta.Rows(e.RowIndex).Cells("Tipodocsii").Value
            ModificaDatosVenta.txtMontoDocumento.Text = DataDocVenta.Rows(e.RowIndex).Cells("Monto").Value
            ModificaDatosVenta.txtNumDoc.Text = DataDocVenta.Rows(e.RowIndex).Cells("Numdoc").Value
            ModificaDatosVenta.cmbTipoDoc.Text = DataDocVenta.Rows(e.RowIndex).Cells("Tipo").Value
            ModificaDatosVenta.DateTimePicker1.Value = DataDocVenta.Rows(e.RowIndex).Cells("Fecha").Value
            ModificaDatosVenta.txtIdVtaHead.Text = DataDocVenta.Rows(e.RowIndex).Cells("idVtaHead").Value
            ModificaDatosVenta.txtCliente.Text = DataDocVenta.Rows(e.RowIndex).Cells("Cliente").Value

            ModificaDatosVenta.Show()
        End If
    End Sub

    Private Sub DataDocVenta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataDocVenta.CellContentClick

    End Sub
End Class