Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Text

Imports System.Data
Imports System.Data.SqlClient
Imports System.Globalization

Public Class CarritoCliente

    Private _textoTicket As String = ""
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            _textoTicket = ConstruirTicket()

            Dim pd As New PrintDocument()
            pd.PrinterSettings.PrinterName = "" ' opcional: nombre exacto de la impresora térmica
            pd.DefaultPageSettings.Margins = New Margins(5, 5, 5, 5)

            AddHandler pd.PrintPage, AddressOf ImprimirTicket

            Dim dlg As New PrintDialog()
            dlg.Document = pd

            If dlg.ShowDialog() = DialogResult.OK Then
                pd.Print()
            End If

        Catch ex As Exception
            MessageBox.Show("Error al imprimir: " & ex.Message, "Impresión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ConstruirTicket() As String
        Dim sb As New StringBuilder()

        Dim fechaHora As String = DateTime.Now.ToString("dd-MM-yyyy HH:mm")
        Dim cliente As String = txtCliente.Text.Trim()
        Dim preparadoPor As String = gNomUsuario.Trim()

        Dim totalLotes As Integer = 0
        Dim totalBandejas As Integer = 0

        sb.AppendLine("================================")
        sb.AppendLine(CentrarTexto("VIVEROS DYD", 32))
        sb.AppendLine(CentrarTexto("ORDEN INTERNA CARGA", 32))
        sb.AppendLine("================================")
        sb.AppendLine("Fecha: " & fechaHora)
        sb.AppendLine("Cliente: " & cliente)
        sb.AppendLine("Preparado por: " & preparadoPor)
        sb.AppendLine("================================")
        sb.AppendLine()

        For Each row As DataGridViewRow In CarritoLotes.Rows
            If row.IsNewRow Then Continue For

            Dim lote As String = ValorCelda(row, "lote")
            Dim variedad As String = ValorCelda(row, "semilla") & " " & ValorCelda(row, "variedad")
            Dim bandejas As Integer = EnteroCelda(row, "saldobandeja")
            Dim tipo As String = ValorCelda(row, "tipobandeja")
            Dim plantas As String = ValorCelda(row, "saldoplantas")
            Dim nave As String = ValorCelda(row, "nave")
            Dim mesa As String = ValorCelda(row, "ubicacion")

            totalLotes += 1
            totalBandejas += bandejas

            sb.AppendLine("[  ] LOTE: " & lote)
            sb.AppendLine("Var : " & AjustarTexto(variedad, 22))
            sb.AppendLine("Bjs : " & bandejas.ToString() & "   Tipo: " & tipo)
            sb.AppendLine("Plts: " & Format(Val(plantas), "###,###"))
            sb.AppendLine("Nave: " & nave & "   Mesa: " & mesa)
            sb.AppendLine("--------------------------------")
            sb.AppendLine()
        Next

        sb.AppendLine("TOTAL LOTES    : " & Format(totalLotes, "###,###"))
        sb.AppendLine("TOTAL BANDEJAS : " & Format(totalBandejas, "###,###"))
        sb.AppendLine("================================")
        sb.AppendLine("Documento interno - Apoyo carga")
        sb.AppendLine("Verificar contra Documento Venta")
        sb.AppendLine("================================")

        Return sb.ToString()
    End Function

    Private Sub ImprimirTicket(sender As Object, e As PrintPageEventArgs)
        Dim fuente As New Font("Consolas", 9, FontStyle.Regular)
        Dim brush As Brush = Brushes.Black

        Dim x As Integer = 5
        Dim y As Integer = 5
        Dim lineHeight As Integer = CInt(fuente.GetHeight(e.Graphics)) + 1

        For Each linea As String In _textoTicket.Split({Environment.NewLine}, StringSplitOptions.None)
            e.Graphics.DrawString(linea, fuente, brush, x, y)
            y += lineHeight
        Next

        e.HasMorePages = False
    End Sub

    Private Function ValorCelda(row As DataGridViewRow, nombreColumna As String) As String
        If row.Cells(nombreColumna).Value Is Nothing OrElse IsDBNull(row.Cells(nombreColumna).Value) Then
            Return ""
        End If
        Return row.Cells(nombreColumna).Value.ToString().Trim()
    End Function

    Private Function EnteroCelda(row As DataGridViewRow, nombreColumna As String) As Integer
        Dim n As Integer = 0
        Integer.TryParse(ValorCelda(row, nombreColumna), n)
        Return n
    End Function

    Private Function CentrarTexto(texto As String, ancho As Integer) As String
        If String.IsNullOrEmpty(texto) Then Return ""
        If texto.Length >= ancho Then Return texto

        Dim espacios As Integer = (ancho - texto.Length) \ 2
        Return New String(" "c, espacios) & texto
    End Function

    Private Function AjustarTexto(texto As String, largo As Integer) As String
        If String.IsNullOrEmpty(texto) Then Return ""
        If texto.Length <= largo Then Return texto
        Return texto.Substring(0, largo)
    End Function

    Private Sub btnGuias_Click(sender As Object, e As EventArgs) Handles btnGuias.Click

        Dim idCliente As Integer
        Dim idVendedor As Integer = gIdVendedor

        If CarritoLotes.Rows.Count = 0 Then
            MessageBox.Show("No hay lotes para emitir.", "Emisión de Guías", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not Integer.TryParse(txtIdCliente.Text.Trim(), idCliente) OrElse idCliente <= 0 Then
            MessageBox.Show("Debe seleccionar un cliente válido.", "Emisión de Guías", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If idVendedor <= 0 Then
            MessageBox.Show("No existe un vendedor válido.", "Emisión de Guías", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim resp = MessageBox.Show("¿Confirmar emisión de guías?",
                                   "Confirma Emisión de Guías",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question)

        If resp <> DialogResult.Yes Then Exit Sub

        btnGuias.Enabled = False
        Cursor = Cursors.WaitCursor

        Try
            EmitirGuias(idCliente, idVendedor)
            MessageBox.Show("Guías emitidas correctamente.", "Emisión de Guías", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al emitir las guías:" & Environment.NewLine & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btnGuias.Enabled = True
            Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub EmitirGuias(idCliente As Integer, idVendedor As Integer)

        Dim fechaGuia As Date = Date.Now
        Dim tran As SqlTransaction = Nothing
        Dim idPedidoDetActual As Decimal = 0

        Try
            open()
            tran = connection.BeginTransaction()

            For Each row As DataGridViewRow In CarritoLotes.Rows

                If row.IsNewRow Then Continue For

                idPedidoDetActual = GetDecimalValue(row.Cells("lote").Value)

                Dim precioNeto As Decimal = GetDecimalValue(row.Cells("precio").Value)
                Dim cantPlantas As Integer = GetIntValue(row.Cells("saldoplantas").Value)
                Dim cantBandRetiro As Integer = GetIntValue(row.Cells("saldobandeja").Value)

                ValidarFilaGuia(idPedidoDetActual, precioNeto, cantPlantas, cantBandRetiro)

                Dim idGuia As Integer = CrearGuia(
                    idPedidoDet:=idPedidoDetActual,
                    idCliente:=idCliente,
                    idVendedor:=idVendedor,
                    fechaGuia:=fechaGuia,
                    cantPlantas:=cantPlantas,
                    cantBandRetiro:=cantBandRetiro,
                    precioNeto:=precioNeto,
                    tran:=tran
                )

                row.Cells("guia").Value = idGuia
            Next

            tran.Commit()

        Catch ex As Exception

            If tran IsNot Nothing Then
                Try
                    tran.Rollback()
                Catch
                End Try
            End If

            If idPedidoDetActual > 0 Then
                Throw New Exception($"Error al emitir la guía del lote/IdPedidodet {idPedidoDetActual}. Detalle: {ex.Message}", ex)
            Else
                Throw
            End If

        Finally
            close_conexion()
        End Try

    End Sub

    Private Function CrearGuia(idPedidoDet As Decimal,
                               idCliente As Integer,
                               idVendedor As Integer,
                               fechaGuia As Date,
                               cantPlantas As Integer,
                               cantBandRetiro As Integer,
                               precioNeto As Decimal,
                               tran As SqlTransaction) As Integer

        Dim totalGuia As Decimal =
            Math.Round(cantPlantas * precioNeto, 0, MidpointRounding.AwayFromZero)

        Dim totalGuiaIVA As Decimal =
            Math.Round(totalGuia * (1D + (CDec(GIVA) / 100D)), 0, MidpointRounding.AwayFromZero)

        Using cmd As New SqlCommand("G001_NUEVA_GUIA", connection, tran)

            cmd.CommandType = CommandType.StoredProcedure

            Dim pIdPedidoDet = cmd.Parameters.Add("@IDPedidodet", SqlDbType.Decimal)
            pIdPedidoDet.Precision = 18
            pIdPedidoDet.Scale = 0
            pIdPedidoDet.Value = idPedidoDet

            Dim pIdCliente = cmd.Parameters.Add("@IDCliente", SqlDbType.Decimal)
            pIdCliente.Precision = 18
            pIdCliente.Scale = 0
            pIdCliente.Value = idCliente

            cmd.Parameters.Add("@IdVendedor", SqlDbType.Int).Value = idVendedor
            cmd.Parameters.Add("@Fecha_Guia", SqlDbType.DateTime).Value = fechaGuia
            cmd.Parameters.Add("@Cant_Plantas", SqlDbType.Int).Value = cantPlantas
            cmd.Parameters.Add("@Cant_Band_Retiro", SqlDbType.Int).Value = cantBandRetiro
            cmd.Parameters.Add("@Cant_Band_Devol", SqlDbType.Int).Value = 0
            cmd.Parameters.Add("@Fecha_Devol", SqlDbType.DateTime).Value = DBNull.Value

            Dim pPrecioNeto = cmd.Parameters.Add("@Precio_Neto", SqlDbType.Decimal)
            pPrecioNeto.Precision = 18
            pPrecioNeto.Scale = 2
            pPrecioNeto.Value = precioNeto

            cmd.Parameters.Add("@Facturado_Ind", SqlDbType.VarChar, 1).Value = "N"

            Dim pTotalGuia = cmd.Parameters.Add("@Total_Guia", SqlDbType.Decimal)
            pTotalGuia.Precision = 18
            pTotalGuia.Scale = 0
            pTotalGuia.Value = totalGuia

            Dim pTotalPagos = cmd.Parameters.Add("@Total_Pagos", SqlDbType.Decimal)
            pTotalPagos.Precision = 18
            pTotalPagos.Scale = 0
            pTotalPagos.Value = 0D

            Dim pTotalGuiaIVA = cmd.Parameters.Add("@Total_GuiaIVA", SqlDbType.Decimal)
            pTotalGuiaIVA.Precision = 18
            pTotalGuiaIVA.Scale = 0
            pTotalGuiaIVA.Value = totalGuiaIVA

            Dim pGarantiaBand = cmd.Parameters.Add("@Garantia_Band", SqlDbType.Decimal)
            pGarantiaBand.Precision = 18
            pGarantiaBand.Scale = 0
            pGarantiaBand.Value = 0D

            cmd.Parameters.Add("@idDesp", SqlDbType.Int).Value = DBNull.Value

            Dim resultado As Object = cmd.ExecuteScalar()

            If resultado Is Nothing OrElse IsDBNull(resultado) Then
                Throw New Exception("El procedimiento no devolvió el ID de la guía.")
            End If

            Return Convert.ToInt32(resultado)

        End Using

    End Function

    Private Sub ValidarFilaGuia(idPedidoDet As Decimal,
                                precioNeto As Decimal,
                                cantPlantas As Integer,
                                cantBandRetiro As Integer)

        If idPedidoDet <= 0 Then
            Throw New Exception("Se encontró un IdPedidodet inválido.")
        End If

        If precioNeto < 0 Then
            Throw New Exception("El precio neto no puede ser negativo.")
        End If

        If cantPlantas < 0 Then
            Throw New Exception("La cantidad de plantas no puede ser negativa.")
        End If

        If cantBandRetiro < 0 Then
            Throw New Exception("La cantidad de bandejas no puede ser negativa.")
        End If

    End Sub

    Private Function GetIntValue(valor As Object) As Integer
        If valor Is Nothing OrElse IsDBNull(valor) OrElse String.IsNullOrWhiteSpace(valor.ToString()) Then
            Return 0
        End If
        Return Convert.ToInt32(valor)
    End Function

    Private Function GetDecimalValue(valor As Object) As Decimal
        If valor Is Nothing OrElse IsDBNull(valor) OrElse String.IsNullOrWhiteSpace(valor.ToString()) Then
            Return 0D
        End If
        Return Convert.ToDecimal(valor, CultureInfo.CurrentCulture)
    End Function

End Class