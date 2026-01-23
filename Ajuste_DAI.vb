Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Office2010.Excel

Public Class Ajuste_DAI
    Dim gValorDAI As Integer = 0
    Dim gSaldoDoc As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gNOMBRE = txt_clientebuscar.Text
        gQuienLlama = 19

        If chkCliente.Checked Then
            BusquedaCliente.chkIncluyePrimerNombre.Checked = True
        Else
            BusquedaCliente.chkIncluyePrimerNombre.Checked = False
        End If
        BusquedaCliente.Visible = True
    End Sub

    Private Sub txt_NombreCliente_TextChanged(sender As Object, e As EventArgs) Handles txt_NombreCliente.TextChanged
        If Val(txt_IdCliente.Text) > 0 Then
            gRutCli = txtRutCli.Text
            Recupera_Datos_Cliente()
        End If
    End Sub

    Public Sub Recupera_Datos_Cliente()
        Rescata_Documentos_Ventas(txt_IdCliente.Text)
        gIDCliente = Val(txt_IdCliente.Text)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Rescata_Documentos_Ventas(ByVal idcliente As Integer)
        '' Recupera Datos de Documentos pendientes de pago
        Dim i As Integer
        open()
        sSsql = "[dbo].[V001_CONSULTA_DocumentosVentaCliente] " & idcliente.ToString()

        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        GrillaDocumentos.Rows.Clear()
        If datatbl.HasRows Then
            i = 0
            While datatbl.Read
                GrillaDocumentos.Rows.Add()
                GrillaDocumentos.Rows(i).Cells("Tipo").Value = datatbl("TIPO_DOC")
                GrillaDocumentos.Rows(i).Cells("Nro").Value = datatbl("NUM_DOC")
                GrillaDocumentos.Rows(i).Cells("Tipodocsii").Value = datatbl("TipoDocSII")
                GrillaDocumentos.Rows(i).Cells("Numdocsii").Value = datatbl("NumDocSII")
                GrillaDocumentos.Rows(i).Cells("ValorDocumento").Value = Format(datatbl("Valor_Doc"), "###,###,###")
                GrillaDocumentos.Rows(i).Cells("saldodoc").Value = datatbl("Saldo_doc")
                GrillaDocumentos.Rows(i).Cells("totalpago").Value = datatbl("totalpago")
                GrillaDocumentos.Rows(i).Cells("obs").Value = datatbl("obs")
                GrillaDocumentos.Rows(i).Cells("FechaDoc").Value = datatbl("fecha_doc")
                i += 1
            End While
        End If
        close_conexion()
    End Sub

    Private Sub GrillaDocumentos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaDocumentos.CellClick
        'cellclick
        If GrillaDocumentos.Rows.Count > 0 Then
            gSaldoDoc = GrillaDocumentos.Rows(e.RowIndex).Cells("saldodoc").Value

            Rescata_Pago_Documento(txt_IdCliente.Text, GrillaDocumentos.Rows(e.RowIndex).Cells("Tipo").Value,
                               GrillaDocumentos.Rows(e.RowIndex).Cells("Nro").Value)


        End If
    End Sub

    Private Sub Rescata_Pago_Documento(ByVal Id_Cliente As Integer, doc_refer As String, num_refer As Integer)
        txtDocRefer.Text = doc_refer
        txtNumRefer.Text = num_refer
        Dim i As Integer
        open()
        sSsql = "[dbo].[V002_CONSULTA_PAGO_DOCUMENTO] " & Str(Id_Cliente) & ",'" & doc_refer & "'," & num_refer.ToString
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        GrillaPagos.Rows.Clear()

        If datatbl.HasRows Then
            i = 0
            While datatbl.Read
                GrillaPagos.Rows.Add()
                GrillaPagos.Rows(i).Cells("id_pago").Value = datatbl("IdPago")
                GrillaPagos.Rows(i).Cells("FechaPago").Value = datatbl("FechaPago")
                GrillaPagos.Rows(i).Cells("docpago").Value = datatbl("FormaPago")
                GrillaPagos.Rows(i).Cells("num").Value = datatbl("Num_Doc_Pago")
                GrillaPagos.Rows(i).Cells("tipodoc").Value = datatbl("Doc_Refer")
                GrillaPagos.Rows(i).Cells("numdoc").Value = datatbl("Num_Refer")
                GrillaPagos.Rows(i).Cells("IdPedido").Value = datatbl("pedido")
                GrillaPagos.Rows(i).Cells("ValorPagado").Value = Format(datatbl("Valor_Pago"), "###,###,###")
                GrillaPagos.Rows(i).Cells("Glosa").Value = datatbl("Glosa_Referencia")
                GrillaPagos.Rows(i).Cells("AbonoPedido").Value = datatbl("Abono_Pedido")
                GrillaPagos.Rows(i).Cells("PagoNoEditado").Value = datatbl("Valor_Pago")
                GrillaPagos.Rows(i).Cells("ValorDAI").Value = Format(datatbl("ValorDAI"), "###,###,###")
                GrillaPagos.Rows(i).Cells("rebajaDAI").Value = datatbl("RebajaDAI")
                GrillaPagos.Rows(i).Cells("ValorDaiNoEditado").Value = datatbl("ValorDAI")
                i += 1
            End While
        End If
        close_conexion()
    End Sub


    Private Sub GrillaPagos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaPagos.CellClick
        'CellClick
        If GrillaPagos.Rows.Count > 0 Then
            Dim SaldoDoc As Integer = Math.Abs(gSaldoDoc)
            If Val(GrillaPagos.Rows(e.RowIndex).Cells("PagoNoEditado").Value) > SaldoDoc Then
                MessageBox.Show("Monto Seleccionado excede el sobre pago del cliente", "Ajuste DAI",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                gValorDAI = Val(GrillaPagos.Rows(e.RowIndex).Cells("PagoNoEditado").Value)
                txt_DiferenciaDAI.Text = GrillaPagos.Rows(e.RowIndex).Cells("PagoNoEditado").Value
                nud_ValorPagado.Maximum = GrillaPagos.Rows(e.RowIndex).Cells("PagoNoEditado").Value
                nud_ValorPagado.Minimum = 0
                nud_ValorPagado.Value = 0
                txtIdPago.Text = GrillaPagos.Rows(e.RowIndex).Cells("id_pago").Value
            End If
        End If


    End Sub

    Private Sub nud_ValorPagado_ValueChanged(sender As Object, e As EventArgs) Handles nud_ValorPagado.ValueChanged
        If gSaldoDoc > 0 Then
            txt_DiferenciaDAI.Text = gValorDAI - nud_ValorPagado.Value
        End If
    End Sub

    Private Sub chkPasarTotal_CheckedChanged(sender As Object, e As EventArgs) Handles chkPasarTotal.CheckedChanged
        If chkPasarTotal.Checked Then
            txt_DiferenciaDAI.Text = nud_ValorPagado.Value
            nud_ValorPagado.Value = 0
        Else
            nud_ValorPagado.Value = txt_DiferenciaDAI.Text
            txt_DiferenciaDAI.Text = 0
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Val(txtIdPago.Text) > 0 Then

            open()

            Try
                ' 1) UPDATE a PAGOS_PARCIALES
                Dim sql As String =
                "UPDATE PAGOS_PARCIALES SET " &
                "    Valor_Pago = @valorpago, " &
                "    Valor_DAI = @valordai, " &
                "    Concepto = 'Ajusta Valor DAI', " &
                "    FechaAjusteDAI = GETDATE() " &
                "WHERE IdPago = @IdPago"

                Dim command As SqlCommand = connection.CreateCommand()
                command.CommandText = sql

                ' Mejor pasar los valores numéricos como tal, no con Str()
                command.Parameters.AddWithValue("@valorpago", nud_ValorPagado.Value)
                command.Parameters.AddWithValue("@valordai", CDbl(Val(txt_DiferenciaDAI.Text)))
                command.Parameters.AddWithValue("@IdPago", CInt(Val(txtIdPago.Text)))

                command.ExecuteNonQuery()

                ' 2) Ejecutar SP CALC_ValorAjusteDAI para ese cliente
                Dim cmdCalc As SqlCommand = connection.CreateCommand()
                cmdCalc.CommandText = "CALC_ValorAjusteDAI"
                cmdCalc.CommandType = CommandType.StoredProcedure
                cmdCalc.Parameters.Add("@IdCliente", SqlDbType.Int).Value = CInt(Val(txt_IdCliente.Text))

                cmdCalc.ExecuteNonQuery()

                ' 3) Ejecutar [vivero].[SP_Actualiza_PagosDocumentosCliente]
                Dim cmdpagos As SqlCommand = connection.CreateCommand()
                cmdpagos.CommandText = "[vivero].[SP_Actualiza_PagosDocumentosCliente]"
                cmdpagos.CommandType = CommandType.StoredProcedure
                cmdpagos.Parameters.Add("@IdCliente", SqlDbType.Int).Value = CInt(Val(txt_IdCliente.Text))

                cmdpagos.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show("Error al actualizar el pago y recalcular ValorAjuste: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                close_conexion()
                MessageBox.Show("Se ha actualizado el ajuste DAI correctamente.", "Ajuste DAI",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Rescata_Documentos_Ventas(txt_IdCliente.Text.ToString())
                LimpiaCampos()
            End Try

            ' 3) Limpieza de controles y recarga de datos
            nud_ValorPagado.Value = 0
            txt_DiferenciaDAI.Clear()
            txtIdPago.Clear()

        End If
    End Sub
    Private Sub LimpiaCampos()
        txtRutCli.Clear()
        txt_RUT_CLI.Clear()
        txt_IdCliente.Clear()
        txt_NombreCliente.Clear()
        txtTelefonos.Clear()
        txtValorAjuste.Clear()
        txtDocRefer.Clear()
        txtNumRefer.Clear()
        txtIdPago.Clear()
        txt_DiferenciaDAI.Clear()
        nud_ValorPagado.Value = 0
        nud_ValorPagado.Minimum = 0
        nud_ValorPagado.Maximum = 0
        GrillaDocumentos.Rows.Clear()
        GrillaPagos.Rows.Clear()
        txt_clientebuscar.Clear()
        chkCliente.Checked = False
        gValorDAI = 0
        gSaldoDoc = 0
    End Sub

End Class