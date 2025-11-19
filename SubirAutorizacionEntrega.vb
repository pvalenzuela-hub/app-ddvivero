Imports ClosedXML.Excel
Public Class SubirAutorizacionEntrega
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()

        If OP_Ajuste.Checked = False And OP_Conteo.Checked = False And OP_FechaAutorizacion.Checked = False And OP_Pedido.Checked = False And OP_Siembra.Checked = False And OP_FechaRetiroCliente.Checked = False And OP_RegistroUbicacion.Checked = False Then
            MsgBox("Debe Seleccionar Tipo de Archivo a subir.", MsgBoxStyle.Exclamation, "Error en Subir Información al Sistemas")
            Exit Sub
        End If

        Dim Archivo As New OpenFileDialog With {
            .Filter = "Archivos Excel (*.xlsx)|*.xlsx|(*.xls)|*.xls",
            .Title = "Selecione archivo Excel",
            .InitialDirectory = "C:\",
            .Multiselect = False
        }

        If Archivo.ShowDialog = DialogResult.OK Then
            Dim filepath As String = Archivo.FileName
            txtFileName.Text = filepath

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Abre Archivo Excel

        If txtFileName.Text <> Nothing Then
            Dim filepath As String = txtFileName.Text
            Using workbook = New XLWorkbook(filepath)
                Dim worksheet = workbook.Worksheet(1) ' seleccionamos la hoja 1
                'leemos el archivo
                ' suponemos que todo comienza en A1 con títulos
                Dim cellValueLote As String
                Dim cellValueFecha As Date
                Dim Fechatxt As String
                Dim FechaProceso As String
                Dim cellValueNave As String
                Dim cellValueMesa As String
                Dim cellValueTipoDespacho As String
                Dim cellValueObsDespacho As String
                open()
                command = connection.CreateCommand()
                ListBox1.Items.Clear()
                Dim row As Integer = 2
                While Not String.IsNullOrEmpty(worksheet.Cell(row, 1).GetValue(Of String)())
                    cellValueLote = worksheet.Cell(row, 1).GetValue(Of String)()
                    If OP_FechaAutorizacion.Checked = True Then
                        cellValueFecha = worksheet.Cell(row, 2).GetValue(Of String)()
                        Fechatxt = Format(cellValueFecha, "dd/MM/yyyy")
                        command.CommandText = "Update PEDIDO_DETALLE set FechaAutorizacionCliente='" + Fechatxt + "' Where idpedidodet=" + cellValueLote
                    End If

                    If OP_Pedido.Checked = True Then
                        command.CommandText = "Update PEDIDO_DETALLE set EsAprobPedido = 1 Where idpedidodet=" + cellValueLote
                    End If

                    If OP_Siembra.Checked = True Then
                        command.CommandText = "Update PEDIDO_DETALLE set EsAprobSiembra = 1 Where idpedidodet=" + cellValueLote
                    End If

                    If OP_Conteo.Checked = True Then
                        command.CommandText = "Update PEDIDO_DETALLE set EsAprobConteo = 1 Where idpedidodet=" + cellValueLote
                    End If

                    If OP_Ajuste.Checked = True Then
                        command.CommandText = "Update PEDIDO_DETALLE set EsAprobAjuste = 1 Where idpedidodet=" + cellValueLote
                    End If

                    If OP_FechaRetiroCliente.Checked = True Then
                        cellValueFecha = worksheet.Cell(row, 2).GetValue(Of String)()
                        Fechatxt = Format(cellValueFecha, "dd/MM/yyyy")
                        cellValueTipoDespacho = worksheet.Cell(row, 3).GetValue(Of String)()
                        cellValueObsDespacho = worksheet.Cell(row, 4).GetValue(Of String)()
                        FechaProceso = Format(Now, "dd/MM/yyyy")
                        ' agregar 3ra columna: texto que indica la forma de retiro: TipoDespacho
                        ' agregar 4ta columna: texto indicaciones del retiro : ObsDespacho
                        command.CommandText = "Update PEDIDO_DETALLE set FechaRetiroCliente='" + Fechatxt + "',TipoDespacho='" + cellValueTipoDespacho + "',ObsDespacho=ObsDespacho+'" + "(" + FechaProceso + "):" + cellValueObsDespacho + ". ' Where idpedidodet=" + cellValueLote
                    End If

                    If OP_RegistroUbicacion.Checked = True Then
                        cellValueNave = worksheet.Cell(row, 2).GetValue(Of String)()
                        cellValueMesa = worksheet.Cell(row, 3).GetValue(Of String)()
                        command.CommandText = "Update PEDIDO_DETALLE Set Num_Nave='" + cellValueNave + "',Ubicacion='" + cellValueMesa + "' Where IdPedidodet=" + cellValueLote
                    End If

                    command.ExecuteNonQuery()
                    ListBox1.Items.Add(cellValueLote)
                    row += 1
                End While
                close_conexion()
                MsgBox("Lotes han sido actualizados!", MsgBoxStyle.Information, "Subir Información al Sistema")
            End Using
        Else
            MsgBox("Debe Seleccionar archivo Excel desde su equipo!", MsgBoxStyle.Exclamation, "Error Subir Información al Sistema")
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
