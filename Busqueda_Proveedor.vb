Public Class Busqueda_Proveedor



    Private Sub Buscar_Proveedor()

        Dim i As Integer

        DataProveedor.Rows.Clear()
        open()
        sSsql = "SP_Consulta_Proveedor_Nomnbre '" + gNOMBRE + "'"
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            While datatbl.Read = True
                DataProveedor.Rows.Add()
                DataProveedor.Rows(i).Cells(0).Value = datatbl(0)
                DataProveedor.Rows(i).Cells(1).Value = datatbl(1)
                DataProveedor.Rows(i).Cells(2).Value = datatbl(2)
                DataProveedor.Rows(i).Cells(3).Value = datatbl(3)
                DataProveedor.Rows(i).Cells(4).Value = datatbl(4)
                DataProveedor.Rows(i).Cells(5).Value = datatbl(5)
                i += 1
            End While
        End If
        datatbl.Close()
        close_conexion()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Recupera_Cartola_Proveedor()
    End Sub
    Private Sub Recupera_Cartola_Proveedor()
        'Variable gQuienLlama
        '0 = Cartola de Cliente
        '1 = Factura Compra
        '2 = Pedidos
        '3 = Cotización
        '4 = Cambio de Nombre
        '5 = Analisis de Cuenta Contable
        Dim iFilaActual As Integer
        Dim sRutProv As String
        iFilaActual = DataProveedor.CurrentCell.RowIndex

        Select Case gQuienLlama
            Case 0

                'Dim i As Integer
                'Dim dTotalCompras As Double
                'Dim dTotalPagos As Double
                'Dim dTotalDeuda As Double

                Cartola_Proveedor.txt_RutProveedor.Text = DataProveedor.Rows(iFilaActual).Cells(0).Value
                Cartola_Proveedor.txt_nombre.Text = DataProveedor.Rows(iFilaActual).Cells(1).Value
                Cartola_Proveedor.txt_direccion.Text = DataProveedor.Rows(iFilaActual).Cells(2).Value
                Cartola_Proveedor.txt_Comuna.Text = DataProveedor.Rows(iFilaActual).Cells(3).Value
                Cartola_Proveedor.txt_Ciudad.Text = DataProveedor.Rows(iFilaActual).Cells(4).Value
                Cartola_Proveedor.txt_telefono.Text = DataProveedor.Rows(iFilaActual).Cells(5).Value
                sRutProv = DataProveedor.Rows(iFilaActual).Cells(0).Value

                Cartola_Proveedor.DataCartola.Rows.Clear()


                'open()
                'sSsql = "SP_CONSULTA_COMPRAS_PENDIENTES_Proveedor '" + sRutProv + "'"
                'command = connection.CreateCommand()
                'command.CommandText = sSsql
                'datatbl = command.ExecuteReader()
                'If datatbl.HasRows Then
                '    i = 0
                '    While datatbl.Read = True
                '        Cartola_Proveedor.DataCartola.Rows.Add()
                '        Cartola_Proveedor.DataCartola.Rows(i).Cells(0).Value = datatbl(0)
                '        Cartola_Proveedor.DataCartola.Rows(i).Cells(1).Value = datatbl(1)
                '        Cartola_Proveedor.DataCartola.Rows(i).Cells(2).Value = datatbl(2)
                '        Cartola_Proveedor.DataCartola.Rows(i).Cells(3).Value = datatbl(3)
                '        Cartola_Proveedor.DataCartola.Rows(i).Cells(4).Value = Format(datatbl(4), "###,###,###")
                '        Cartola_Proveedor.DataCartola.Rows(i).Cells(5).Value = Format(datatbl(5), "###,###,###")
                '        Cartola_Proveedor.DataCartola.Rows(i).Cells(6).Value = Format(datatbl(6), "###,###,###")

                '        i += 1
                '        dTotalCompras += datatbl(4)
                '        dTotalPagos += datatbl(5)
                '        dTotalDeuda += datatbl(6)

                '    End While
                'End If
                'Cartola_Proveedor.txt_totalCompras.Text = Format(dTotalCompras, "###,###,###")
                'Cartola_Proveedor.txt_totalPagos.Text = Format(dTotalPagos, "###,###,###")
                'Cartola_Proveedor.TXT_TotalDeuda.Text = Format(dTotalDeuda, "###,###,###")

                'close_conexion()
            Case 1
                facturaCompra.txt_RUT_PRO.Text = Mid(DataProveedor.Rows(iFilaActual).Cells(0).Value, 1, 11)
                facturaCompra.txt_DIGPRO.Text = Mid(DataProveedor.Rows(iFilaActual).Cells(0).Value, 12, 1)
                facturaCompra.txt_NOM_PRO.Text = DataProveedor.Rows(iFilaActual).Cells(1).Value
                gRUT = DataProveedor.Rows(iFilaActual).Cells(0).Value
            Case 5
                Analisis_Cuenta.txtRutProv.Text = DataProveedor.Rows(iFilaActual).Cells(0).Value
                Analisis_Cuenta.txtNombreProv.Text = DataProveedor.Rows(iFilaActual).Cells(1).Value
        End Select
        Me.Close()
    End Sub

    Private Sub Busqueda_Proveedor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Buscar_Proveedor()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class