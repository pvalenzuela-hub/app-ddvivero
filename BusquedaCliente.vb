Imports System.Data.SqlClient
Public Class BusquedaCliente
    Dim datatbl As SqlClient.SqlDataReader = Nothing
    Dim command As SqlCommand = Nothing

    Private Sub Buscar_Cliente()
        Dim i As Integer
        DataClientes.Rows.Clear()
        If gQuienLlama = 9 Then
            open()
            sSsql = "SP_CONSULTA_Personal_NOMBRE "
            sSsql += "'" & gNOMBRE & "'"
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                While datatbl.Read
                    DataClientes.Rows.Add()
                    DataClientes.Rows(i).Cells(0).Value = Format(Val(Mid(datatbl(0), 1, 11)), "#####,###,###") & "-" & Mid(datatbl(0), 12, 1)
                    DataClientes.Rows(i).Cells(1).Value = datatbl(1) & " " & datatbl(2)
                    DataClientes.Rows(i).Cells(2).Value = datatbl(4)
                    DataClientes.Rows(i).Cells(3).Value = datatbl(5)
                    DataClientes.Rows(i).Cells(4).Value = datatbl(0)
                    DataClientes.Rows(i).Cells(5).Value = datatbl(3)

                    i += 1
                End While
            End If
            close_conexion()


        Else
            If gQuienLlama = 14 Then
                ' Listado de Proveedores
                open()
                sSsql = "[dbo].[SP_CONSULTA_PROVEEDOR_NOMBRE] "
                sSsql += "'" & gNOMBRE & "',2"

                command = connection.CreateCommand()
                command.CommandText = sSsql
                datatbl = command.ExecuteReader()
                If datatbl.HasRows Then
                    While datatbl.Read
                        DataClientes.Rows.Add()
                        DataClientes.Rows(i).Cells(0).Value = Format(Val(Mid(datatbl(0), 1, 11)), "#####,###,###") & "-" & Mid(datatbl(0), 12, 1)
                        DataClientes.Rows(i).Cells(1).Value = datatbl(1)
                        DataClientes.Rows(i).Cells(2).Value = datatbl(2)
                        DataClientes.Rows(i).Cells(3).Value = datatbl(5)
                        DataClientes.Rows(i).Cells(4).Value = datatbl(0)
                        DataClientes.Rows(i).Cells(5).Value = datatbl(10)
                        i += 1
                    End While
                End If
                close_conexion()
            Else
                open()
                sSsql = "SP_CONSULTA_CLIENTE_NOMBRE_NEW '" & gNOMBRE & "',2,"
                If chkIncluyePrimerNombre.Checked Then
                    sSsql += "1"
                Else
                    sSsql += "0"
                End If
                command = connection.CreateCommand()
                command.CommandText = sSsql
                datatbl = command.ExecuteReader()
                If datatbl.HasRows Then
                    While datatbl.Read
                        DataClientes.Rows.Add()
                        DataClientes.Rows(i).Cells(0).Value = Format(Val(Mid(datatbl(0), 1, 11)), "#####,###,###") & "-" & Mid(datatbl(0), 12, 1)
                        DataClientes.Rows(i).Cells(1).Value = datatbl(1) & " " & datatbl(2)
                        DataClientes.Rows(i).Cells(2).Value = datatbl(5)
                        DataClientes.Rows(i).Cells(3).Value = datatbl(6)
                        DataClientes.Rows(i).Cells(4).Value = datatbl(0)
                        DataClientes.Rows(i).Cells(5).Value = datatbl(3)
                        DataClientes.Rows(i).Cells(6).Value = datatbl(7)
                        DataClientes.Rows(i).Cells(7).Value = datatbl(8)
                        DataClientes.Rows(i).Cells(8).Value = datatbl(12)
                        DataClientes.Rows(i).Cells("EstadoclienteId").Value = datatbl("EstadoclienteId")
                        i += 1
                    End While
                Else
                    MsgBox("No existen Clientes con el filtro aplicado", MsgBoxStyle.Information)
                End If
                close_conexion()
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Variable gQuienLlama
        '0 = Cartola de Cliente
        '1 = Reporte Lotes Clientes/Especie/Variedad
        '2 = Pedidos
        '3 = Cotización
        '4 = Cambio de Nombre
        '5 = Pagos Documentos en Cartera
        '6 = Devolución de Bandejas
        '7 = Mantención Cliente
        '8 = Comprobante Contable - Cliente
        '9 = Comprobante Contable - Personal
        '10 = Análisis de Cuenta Contable
        '11 = Control de Despachos
        '12 = VENTAS
        '13 = Abono Deuda Cliente
        '14 = Comprobante Contable - Proveedores
        '15 = Devolución de Plantas
        '16 = Modifica Venta
        '17 = Crear Lote Hijo
        Dim iFilaActual As Integer

        If DataClientes.Rows.Count > 0 Then
            iFilaActual = DataClientes.CurrentCell.RowIndex
            Select Case gQuienLlama
                Case 0
                    Dim i As Integer
                    Cartola_Cliente.txt_RutDisplay.Text = DataClientes.Rows(iFilaActual).Cells(0).Value
                    Cartola_Cliente.txt_NombreDisplay.Text = DataClientes.Rows(iFilaActual).Cells(1).Value
                    Cartola_Cliente.txt_direccion.Text = DataClientes.Rows(iFilaActual).Cells(2).Value
                    Cartola_Cliente.txt_telefono.Text = DataClientes.Rows(iFilaActual).Cells(3).Value
                    gRUT = DataClientes.Rows(iFilaActual).Cells(4).Value
                    gIDCliente = DataClientes.Rows(iFilaActual).Cells(5).Value
                    open()
                    sSsql = "SP_CONSULTA_DOCVENTA_CLIENTE_Pendientes "
                    sSsql += "'" & gRUT & "'"
                    command = connection.CreateCommand()
                    command.CommandText = sSsql
                    datatbl = command.ExecuteReader()
                    If datatbl.HasRows Then
                        i = 0
                        While datatbl.Read
                            Cartola_Cliente.DataCartola.Rows.Add()
                            Cartola_Cliente.DataCartola.Rows(i).Cells(0).Value = datatbl(2)
                            Cartola_Cliente.DataCartola.Rows(i).Cells(1).Value = datatbl(0)
                            Cartola_Cliente.DataCartola.Rows(i).Cells(2).Value = datatbl(1)
                            Cartola_Cliente.DataCartola.Rows(i).Cells(3).Value = Format(datatbl(3), "###,###,###")
                            Cartola_Cliente.DataCartola.Rows(i).Cells(4).Value = Format(datatbl(4), "###,###,###")
                            i += 1
                        End While
                    End If
                    close_conexion()
                    REM Resumen Deuda Cliente
                    sSsql = "[dbo].[SP_Consulta_Resumen_Deuda_Cliente_IdCliente] "
                    sSsql += gIDCliente.ToString
                    open()
                    command = connection.CreateCommand()
                    command.CommandText = sSsql
                    datatbl = command.ExecuteReader()
                    If datatbl.HasRows Then
                        datatbl.Read()
                        Cartola_Cliente.txt_docpendientes.Text = Format(datatbl("DocPendientes"), "###,###,##0")
                        Cartola_Cliente.txt_CHxcobrar.Text = Format(datatbl("DocxCobrar"), "###,###,##0")
                        Cartola_Cliente.txt_LetrasxCobrar.Text = Format(datatbl("LetrasxCobrar"), "###,###,##0")
                        Cartola_Cliente.txt_TotalAbonos.Text = Format(datatbl("SaldoAbonos"), "###,###,##0")
                        Cartola_Cliente.txt_DeudaTotal.Text = Format(datatbl("DeudaTotal"), "###,###,##0")
                        Cartola_Cliente.txtValorDAI.Text = Format(datatbl("SaldoDAI"), "###,###,##0")
                    End If
                    close_conexion()
                Case 1
                    ReporteLotes.txt_nombre.Text = DataClientes.Rows(iFilaActual).Cells(1).Value
                    'Consulta_Lotes.txt_nombre.Text = DataClientes.Rows(iFilaActual).Cells(1).Value
                    gIDCliente = DataClientes.Rows(iFilaActual).Cells(5).Value
                Case 2
                    Pedidos.txt_RUT_CLI.Text = DataClientes.Rows(iFilaActual).Cells(0).Value
                    Pedidos.txt_NombreCliente.Text = DataClientes.Rows(iFilaActual).Cells(1).Value
                    Pedidos.txtNotas.Text = DataClientes.Rows(iFilaActual).Cells(8).Value
                    Pedidos.txtEstadoclienteId.Text = DataClientes.Rows(iFilaActual).Cells("EstadoclienteId").Value
                    gSectorDireccion = DataClientes.Rows(iFilaActual).Cells(6).Value
                    Pedidos.txt_IDCliente.Text = DataClientes.Rows(iFilaActual).Cells(5).Value
                Case 3
                    Cotizacion.txt_RUT_CLI.Text = DataClientes.Rows(iFilaActual).Cells(0).Value
                    Cotizacion.txt_NombreCliente.Text = DataClientes.Rows(iFilaActual).Cells(1).Value
                    gSectorDireccion = DataClientes.Rows(iFilaActual).Cells(6).Value
                    Cotizacion.txt_IDCliente.Text = DataClientes.Rows(iFilaActual).Cells(5).Value
                Case 4
                    Cambio_Nombre.txt_NuevoCliente.Text = DataClientes.Rows(iFilaActual).Cells(1).Value
                    Cambio_Nombre.txt_NuevoRUT.Text = DataClientes.Rows(iFilaActual).Cells(0).Value
                    Cambio_Nombre.txt_NuevoID.Text = DataClientes.Rows(iFilaActual).Cells(5).Value
                Case 5
                    DepositoDoc.txt_nombre.Text = DataClientes.Rows(iFilaActual).Cells(1).Value
                    gRUT = DataClientes.Rows(iFilaActual).Cells(4).Value
                    DepositoDoc.txt_RutCliente.Text = DataClientes.Rows(iFilaActual).Cells(0).Value
                    DepositoDoc.txtIdCliente.Text = DataClientes.Rows(iFilaActual).Cells(5).Value
                Case 6
                    Devolucion_Bandejas.txt_IdCliente.Text = DataClientes.Rows(iFilaActual).Cells(5).Value
                    Devolucion_Bandejas.txt_Cliente.Text = DataClientes.Rows(iFilaActual).Cells(1).Value
                Case 7

                    gIDCliente = DataClientes.Rows(iFilaActual).Cells(5).Value
                    Consulta_Cliente.txt_NombreCliente.Text = DataClientes.Rows(iFilaActual).Cells(1).Value
                    Consulta_Cliente.txtIdcliente.Text = gIDCliente
                Case 8
                    Cmpbt_Ctbl.txt_NombreCliente.Text = DataClientes.Rows(iFilaActual).Cells(1).Value
                    Cmpbt_Ctbl.txt_Rut.Text = DataClientes.Rows(iFilaActual).Cells(4).Value
                Case 9
                    Cmpbt_Ctbl.txt_NombreCliente.Text = DataClientes.Rows(iFilaActual).Cells(1).Value
                    Cmpbt_Ctbl.txt_Rut.Text = DataClientes.Rows(iFilaActual).Cells(4).Value
                Case 10
                    Analisis_Cuenta.txt_RutCliente.Text = DataClientes.Rows(iFilaActual).Cells(4).Value
                    Analisis_Cuenta.txtCliente.Text = DataClientes.Rows(iFilaActual).Cells(1).Value
                Case 11
                    CtlDesp.txtIDcliente.Text = DataClientes.Rows(iFilaActual).Cells(5).Value
                Case 12

                    If frmtablavirtual.chk_CLienteFactura.Checked Then
                        frmtablavirtual.txt_RutFactura.Text = FormatoRut(DataClientes.Rows(iFilaActual).Cells(4).Value)
                        frmtablavirtual.txt_NombreClienteFactura.Text = DataClientes.Rows(iFilaActual).Cells(1).Value
                        frmtablavirtual.txtIdClienteFactura.Text = DataClientes.Rows(iFilaActual).Cells(5).Value
                    Else
                        frmtablavirtual.txt_Rut_Cli.Text = FormatoRut(DataClientes.Rows(iFilaActual).Cells(4).Value)
                        frmtablavirtual.txt_IDcliente.Text = DataClientes.Rows(iFilaActual).Cells(5).Value
                        frmtablavirtual.txt_NOM_CLI.Text = DataClientes.Rows(iFilaActual).Cells(1).Value
                        frmtablavirtual.txtSaldoAbono.Text = DataClientes.Rows(iFilaActual).Cells(7).Value
                    End If
                Case 13

                    gRutCli = DataClientes.Rows(iFilaActual).Cells(4).Value
                    Abono_Deuda.txtRutCli.Text = gRutCli
                    Abono_Deuda.txt_RUT_CLI.Text = FormatoRut(gRutCli)
                    Abono_Deuda.txt_IdCliente.Text = DataClientes.Rows(iFilaActual).Cells(5).Value
                    Abono_Deuda.txt_NombreCliente.Text = DataClientes.Rows(iFilaActual).Cells(1).Value
                    Abono_Deuda.txtTelefonos.Text = DataClientes.Rows(iFilaActual).Cells("telefono").Value
                Case 14
                    Cmpbt_Ctbl.txt_NombreCliente.Text = DataClientes.Rows(iFilaActual).Cells(1).Value
                    Cmpbt_Ctbl.txt_Rut.Text = DataClientes.Rows(iFilaActual).Cells(4).Value
                Case 15

                    gRutCli = DataClientes.Rows(iFilaActual).Cells(4).Value
                    DevolucionPlantas.txt_Rut_Cli.Text = FormatoRut(gRutCli)
                    DevolucionPlantas.txt_IDcliente.Text = DataClientes.Rows(iFilaActual).Cells(5).Value
                    DevolucionPlantas.txt_NOM_CLI.Text = DataClientes.Rows(iFilaActual).Cells(1).Value
                Case 16

                    gRutCli = DataClientes.Rows(iFilaActual).Cells(4).Value
                    ModificaVenta.txt_Rut_Cli.Text = FormatoRut(gRutCli)
                    ModificaVenta.txtIdCliente.Text = DataClientes.Rows(iFilaActual).Cells(5).Value
                    ModificaVenta.txt_NOM_CLI.Text = DataClientes.Rows(iFilaActual).Cells(1).Value
                    ModificaVenta.TopMost = True
                Case 17
                    CreaLoteHijo.txt_IDCliente.Text = DataClientes.Rows(iFilaActual).Cells(5).Value
                    CreaLoteHijo.txt_NombreCliente.Text = DataClientes.Rows(iFilaActual).Cells(1).Value
                Case 18
                    ReporteLotes.txt_Cliente.Text = DataClientes.Rows(iFilaActual).Cells(1).Value
                    gIDCliente = DataClientes.Rows(iFilaActual).Cells(5).Value
            End Select
        End If

        Me.Close()


    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub BusquedaCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If gQuienLlama = 17 Then
            gNOMBRE = ""
        End If
        Buscar_Cliente()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If txt_clientebuscar.Text <> Nothing Then
            gNOMBRE = txt_clientebuscar.Text
            Buscar_Cliente()
        End If
    End Sub
End Class
