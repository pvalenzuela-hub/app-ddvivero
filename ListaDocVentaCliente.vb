Public Class ListaDocVentaCliente
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataDocVentaNC.Rows.Count > 0 Then
            Dim i As Integer = DataDocVentaNC.CurrentRow.Index
            If DataDocVentaNC.Rows(i).Cells("numnc").Value > 0 Then
                MsgBox("N° Guía seleccionada ya tiene una Nota de Crédito asociada!!!", MsgBoxStyle.Critical, "Selección Documento para Nota Crédito")
            Else
                Dim dPromedioPlantas = Math.Round(DataDocVentaNC.Rows(i).Cells("Cant_Plantas").Value / DataDocVentaNC.Rows(i).Cells("Cant_Band_Retiro").Value, 4, MidpointRounding.AwayFromZero)
                frmtablavirtual.txtTipoDocNC.Text = DataDocVentaNC.Rows(i).Cells("tipodoc").Value
                frmtablavirtual.txtNumDocNC.Text = DataDocVentaNC.Rows(i).Cells("numdoc").Value
                frmtablavirtual.txtGuiaNC.Text = DataDocVentaNC.Rows(i).Cells("numguia").Value
                frmtablavirtual.txtIdVtaDetNC.Text = DataDocVentaNC.Rows(i).Cells("idvtadet").Value
                frmtablavirtual.txtPromedioPlantasNC.Text = dPromedioPlantas
                frmtablavirtual.txtCantidadBandejasNC.Maximum = DataDocVentaNC.Rows(i).Cells("Cant_Band_Retiro").Value
                frmtablavirtual.txtPrecioNeto.Text = DataDocVentaNC.Rows(i).Cells("Precio_Neto").Value
                frmtablavirtual.txtFamilia.Text = DataDocVentaNC.Rows(i).Cells("Familia").Value
                frmtablavirtual.txtVariedad.Text = DataDocVentaNC.Rows(i).Cells("Variedad").Value
                Me.Close()
            End If
        End If
    End Sub

    Private Sub ListaDocVentaCliente_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim i As Integer = 0
        sSsql = "[dbo].[NEWSP_CONSULTA_DOCVENTA_CLIENTE_NC] " & frmtablavirtual.txt_IDcliente.Text.ToString()
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            DataDocVentaNC.Rows.Clear()
            While datatbl.Read
                DataDocVentaNC.Rows.Add()
                DataDocVentaNC.Rows(i).Cells("documento").Value = datatbl("TIPO_DOC") & " " & datatbl("NUM_DOC").ToString()
                DataDocVentaNC.Rows(i).Cells("numguia").Value = datatbl("IDGUIA")
                DataDocVentaNC.Rows(i).Cells("idvtadet").Value = datatbl("IdVtaDet")
                DataDocVentaNC.Rows(i).Cells("valor").Value = datatbl("Valor_Doc")
                DataDocVentaNC.Rows(i).Cells("Cant_Plantas").Value = datatbl("Cant_Plantas")
                DataDocVentaNC.Rows(i).Cells("Cant_Band_Retiro").Value = datatbl("Cant_Band_Retiro")
                DataDocVentaNC.Rows(i).Cells("Fecha_Guia").Value = datatbl("Fecha_Guia")
                DataDocVentaNC.Rows(i).Cells("fechadoc").Value = datatbl("fecha_doc")
                DataDocVentaNC.Rows(i).Cells("Precio_Neto").Value = datatbl("Precio_Neto")
                DataDocVentaNC.Rows(i).Cells("IdFamilia").Value = datatbl("IdFamilia")
                DataDocVentaNC.Rows(i).Cells("IdVariedad").Value = datatbl("IdVariedad")
                DataDocVentaNC.Rows(i).Cells("Familia").Value = datatbl("Familia")
                DataDocVentaNC.Rows(i).Cells("Variedad").Value = datatbl("Variedad")
                DataDocVentaNC.Rows(i).Cells("tipodoc").Value = datatbl("TIPO_DOC")
                DataDocVentaNC.Rows(i).Cells("numdoc").Value = datatbl("NUM_DOC")
                DataDocVentaNC.Rows(i).Cells("numnc").Value = datatbl("notacredito")
                i += 1
            End While
        End If
        close_conexion()
    End Sub
End Class