Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class Cartola_Cliente
    Dim FormatoImpresion As New StringFormat

    Dim datatbl As SqlClient.SqlDataReader = Nothing
    Dim command As SqlCommand = Nothing
    Private Sub CargaCartola()

        DataCartola.Rows.Clear()
        BusquedaCliente.Visible = True
    
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        If chkCliente.Checked Then
            BusquedaCliente.chkIncluyePrimerNombre.Checked = True
        Else
            BusquedaCliente.chkIncluyePrimerNombre.Checked = False
        End If

        DataCartola.Rows.Clear()
        gNOMBRE = txt_clientebuscar.Text
        gQuienLlama = 0
        BusquedaCliente.Visible = True




    End Sub
    Private Sub CargaCartolaporRut()
        Dim i As Integer
        Dim rutF As String
        DataCartola.Rows.Clear()
        rutF = "000000000000" + txt_RutCliente.Text
        rutF = Microsoft.VisualBasic.Right(rutF, 12)
        open()
        sSsql = "SP_CONSULTA_CLIENTE_RUT '" & rutF & "'"
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            txt_RutDisplay.Text = Format(Val(Mid(datatbl(0), 1, 11)), "#####,###,###") + "-" + Mid(datatbl(0), 12, 1)
            txt_NombreDisplay.Text = datatbl(1) + " " + datatbl(2)
            txt_direccion.Text = datatbl(4)
            txt_telefono.Text = datatbl(5)
            gRUT = datatbl(0)
            gIDCliente = datatbl(3)
        End If
        close_conexion()

        open()
        sSsql = "SP_CONSULTA_DOCVENTA_CLIENTE_Pendientes "
        sSsql += "'" & gRUT & "'"
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            i = 0
            While datatbl.Read
                If datatbl("ESTADO") < 9 Then
                    DataCartola.Rows.Add()
                    DataCartola.Rows(i).Cells(0).Value = datatbl(2)
                    DataCartola.Rows(i).Cells(1).Value = datatbl(0)
                    DataCartola.Rows(i).Cells(2).Value = datatbl(1)
                    DataCartola.Rows(i).Cells(3).Value = Format(datatbl(3), "###,###,###")
                    DataCartola.Rows(i).Cells(4).Value = Format(datatbl(4), "###,###,###")
                    i += 1
                End If
            End While

        End If
        close_conexion()

        REM Resumen Deuda Cliente
        sSsql = "SP_Consulta_Resumen_Deuda_Cliente "
        sSsql += "'" + gRUT + "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            txt_docpendientes.Text = Format(datatbl(0), "###,###,##0")
            txt_CHxcobrar.Text = Format(datatbl(1), "###,###,##0")
            txt_LetrasxCobrar.Text = Format(datatbl(2), "###,###,##0")
            txt_TotalAbonos.Text = Format(datatbl(3), "###,###,##0")
            txt_DeudaTotal.Text = Format(datatbl(4), "###,###,##0")
        End If
        close_conexion()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ImprimirCartolaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirCartolaToolStripMenuItem.Click
        Imprime_Cartola()
    End Sub
    Private Sub Imprime_Cartola()
        Dim prnTxt As New PrintDocument
        AddHandler prnTxt.PrintPage, AddressOf Me.Genera_Cartola

        'prnTxt.PrinterSettings.Copies = 2
        'prnTxt.PrinterSettings.PrinterName = gPrinter
        'prnTxt.Print()

        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            prnTxt.PrinterSettings.PrinterName = PrintDialog1.PrinterSettings.PrinterName
            'prnTxt.PrinterSettings.Copies = 2
            prnTxt.Print()
        End If
    End Sub
    Private Sub Genera_Cartola(ByVal sender As System.Object, ByVal ePrint As PrintPageEventArgs)
        '' Impresión Comprobante de Pago
        Dim i As Integer = 0
        Dim sTitulo As String
        Dim iTamanoLetra1 As Integer
        Dim iTamanoLetra2 As Integer
        Dim iTamanoLetra3 As Integer
        Dim iLinea As Integer
        Dim iCol As Integer
        Dim sTipoLetra As String
        Dim sLogo As String
        Dim sTexto1 As String = ""
        Dim sTexto2 As String = ""
        Dim sTexto3 As String = ""
        Dim sTexto4 As String = ""
        Dim sTexto5 As String = ""
        Dim sTexto6 As String = ""
        Dim sTexto7 As String = ""
        Dim sTexto8 As String = ""
        Dim sTexto9 As String = ""
        Dim sTexto10 As String = ""
        Dim sTexto11 As String = ""
        Dim sTexto12 As String = ""
        Dim sCorte1 As String = ""
        Dim sCorte2 As String = ""

        Dim dTotalValorDoc As Double = 0
        Dim dSaldoPendiente As Double = 0

        Dim dValorDocPago As Double = 0
        Dim dSaldoDocPago As Double = 0

        'Dim sTextoMonto As String
        iCol = 10

        sTitulo = "C A R T O L A  -   C L I E N T E"
        sLogo = gDataEmp
        iTamanoLetra1 = 8
        iTamanoLetra2 = 10
        iTamanoLetra3 = 12
        sTipoLetra = "Arial"
        ePrint.Graphics.DrawString(sLogo, New Font("High Tower Text", 14, FontStyle.Bold, GraphicsUnit.Point), Brushes.Green, 10, 1)
        ePrint.Graphics.DrawString(Format(Now.Date, "dd/MMM/yyyy"), New Font("Arial Narrow", iTamanoLetra3, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, 700, 1)
        ePrint.Graphics.DrawString(gDataEmpFono, New Font("Arial Narrow", iTamanoLetra1, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, 20, 25)
        ePrint.Graphics.DrawString(sTitulo, New Font("Arial Narrow", iTamanoLetra3, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, 300, 25)
        iLinea = 100
        ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 815, iLinea)
        iLinea += 15
        iCol = 10
   
        REM Encabezado

        sSsql = "SP_CONSULTA_CLIENTE_NOMBRE "
        sSsql += "'" + gRUT + "',"
        sSsql += "1"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            sTexto1 = "Cliente   : " + RTrim(datatbl(1)) + " " + datatbl(2)
            sTexto2 = "Rut: " + Format(Val(Mid(gRUT, 1, 11)), "###,###,###") + "-" + Mid(gRUT, 12, 1)
            sTexto3 = "Dirección : " + datatbl(4)
            sTexto4 = "Comuna: " + datatbl(9)
            sTexto5 = "Ciudad: " + datatbl(10)
            sTexto6 = "Teléfono: " + datatbl(6)
            sTexto7 = "Giro      : " + datatbl(11)
        End If
        close_conexion()
        ePrint.Graphics.DrawString(sTexto1, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 380
        ePrint.Graphics.DrawString(sTexto2, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 10
        iLinea += 20
        ePrint.Graphics.DrawString(sTexto3, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 380
        ePrint.Graphics.DrawString(sTexto4, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 600
        ePrint.Graphics.DrawString(sTexto5, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20
        iCol = 10
        ePrint.Graphics.DrawString(sTexto7, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 380
        ePrint.Graphics.DrawString(sTexto6, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20
        ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 815, iLinea)
        sTexto8 = "Documentos Pendientes"
        sTexto9 = "Fecha Doc.  Documento         Valor Doc.  Saldo Pendiente   N° Guía  Fecha       Semilla                 Variedad                Ot.Producto              Cantidad  P.Unitario"
        iLinea += 25
        iCol = 20
        ePrint.Graphics.DrawString(sTexto8, New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 25
        iCol = 10
        ePrint.Graphics.DrawString(sTexto9, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 15
        ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 815, iLinea)
        REM Documentos Pendientes
        sSsql = "SP_Cartola_Cliente "
        sSsql += "'" + gRUT + "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then

            iLinea += 15
            dTotalValorDoc = 0
            dSaldoPendiente = 0
            While datatbl.Read
                If sCorte1 <> datatbl(1) Then
                    sCorte1 = datatbl(1)
                    iCol = 15
                    ePrint.Graphics.DrawString(datatbl(0), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
                    iCol = 80
                    ePrint.Graphics.DrawString(datatbl(1), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
                    iCol = 205
                    ePrint.Graphics.DrawString(Format(datatbl(2), "###,###,###"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea, FormatoImpresion)
                    iCol = 290
                    ePrint.Graphics.DrawString(Format(datatbl(3), "###,###,###"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea, FormatoImpresion)
                    dTotalValorDoc += datatbl(2)
                    dSaldoPendiente += datatbl(3)
                End If
                iCol = 310
                ePrint.Graphics.DrawString(datatbl(4), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
                iCol = 350
                ePrint.Graphics.DrawString(datatbl(5), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
                iCol = 415
                ePrint.Graphics.DrawString(datatbl(6), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
                iCol = 500
                ePrint.Graphics.DrawString(datatbl(7), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
                iCol = 590
                ePrint.Graphics.DrawString(datatbl(8), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
                iCol = 752
                ePrint.Graphics.DrawString(Format(datatbl(9), "###,###,###"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea, FormatoImpresion)
                iCol = 805
                ePrint.Graphics.DrawString(Format(datatbl(10), "###,###.00"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea, FormatoImpresion)
                iLinea += 20
                
            End While
        End If
        close_conexion()
        iCol = 10
        ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 815, iLinea)
        iLinea += 5
        ePrint.Graphics.DrawString("Total", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 205
        ePrint.Graphics.DrawString(Format(dTotalValorDoc, "###,###,###"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea, FormatoImpresion)
        iCol = 290
        ePrint.Graphics.DrawString(Format(dSaldoPendiente, "###,###,###"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea, FormatoImpresion)
        iCol = 10
        iLinea += 20
        ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 815, iLinea)

        sCorte1 = ""

        REM Documentos x Cobrar
        sTexto9 = "Documentos por Cobrar"
        sTexto10 = "Tipo Documento                N°   Glosa                                                                       Fecha Vcto.                                                        Valor Pagado           Saldo"
        iLinea += 25
        iCol = 20
        ePrint.Graphics.DrawString(sTexto9, New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 25
        iCol = 10
        ePrint.Graphics.DrawString(sTexto10, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 15
        ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 815, iLinea)
        sSsql = "SP_Cartola_Cliente_DocXcobrar "
        sSsql += "'" + gRUT + "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then

            iLinea += 15
            dSaldoDocPago = 0
            dValorDocPago = 0
            While datatbl.Read
                If sCorte1 <> datatbl(0) + datatbl(1) Then

                End If
                iCol = 15
                ePrint.Graphics.DrawString(datatbl(0), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
                iCol = 120
                ePrint.Graphics.DrawString(datatbl(1), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
                iCol = 300
                ePrint.Graphics.DrawString(datatbl(2), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
                iCol = 410
                ePrint.Graphics.DrawString(datatbl(3), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
                iCol = 745
                ePrint.Graphics.DrawString(Format(datatbl(4), "###,###,###"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea, FormatoImpresion)
                iCol = 800
                ePrint.Graphics.DrawString(Format(datatbl(5), "###,###,###"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea, FormatoImpresion)
                dSaldoDocPago += datatbl(4)
                dValorDocPago += datatbl(5)
                iLinea += 20

            End While
        End If
        close_conexion()
        iCol = 10
        ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 815, iLinea)
        iLinea += 5
        ePrint.Graphics.DrawString("Total", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 745
        ePrint.Graphics.DrawString(Format(dSaldoDocPago, "###,###,###"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea, FormatoImpresion)
        iCol = 800
        ePrint.Graphics.DrawString(Format(dValorDocPago, "###,###,###"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea, FormatoImpresion)
        iCol = 10
        iLinea += 20
        ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 815, iLinea)


        sTexto11 = "Resumen Cartola"
        iLinea += 20
        iCol = 20
        ePrint.Graphics.DrawString(sTexto11, New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20
        ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 815, iLinea)

        REM Resumen Deuda
        sSsql = "SP_Consulta_Resumen_Deuda_Cliente "
        sSsql += "'" + gRUT + "'"
   
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            iCol = 10
            ePrint.Graphics.DrawString("Doc. Pendientes :", New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol = 400
            ePrint.Graphics.DrawString("Documentos x Cobrar :", New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)

            iCol = 300
            ePrint.Graphics.DrawString(Format(datatbl(0), "###,###,##0"), New Font(sTipoLetra, iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea, FormatoImpresion)
            iCol = 700
            ePrint.Graphics.DrawString(Format(datatbl(1) + datatbl(2), "###,###,##0"), New Font(sTipoLetra, iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea, FormatoImpresion)

            iLinea += 20
            iCol = 10
            ePrint.Graphics.DrawString("Saldo Abonos a Pedidos :", New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol = 400
            ePrint.Graphics.DrawString("Total Deuda :", New Font(sTipoLetra, iTamanoLetra2, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)

            iCol = 300
            ePrint.Graphics.DrawString(Format(datatbl(3), "###,###,##0"), New Font(sTipoLetra, iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea, FormatoImpresion)
            iCol = 700
            ePrint.Graphics.DrawString(Format(datatbl(4), "###,###,##0"), New Font(sTipoLetra, iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea, FormatoImpresion)
        End If
        close_conexion()
        iLinea += 20
        ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 815, iLinea)

        REM 
        REM 99/99/9999
        REM Pag.: 9999
        REM
        REM
        REM                                                              C A R T O L A      C L I E N T E S
        REM ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        REM Cliente   : xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx            Rut: 9999999-9
        REM Dirección : xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx            Comuna: xxxxxxxxxxxxxxxxxxxxxx           Ciudad: xxxxxxxxxxxxxxxx         Teléfono: 9999999999999
        REM Giro      : xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        REM ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        REM
        REM Documentos Pendientes
        REM 
        REM Fecha Doc.  Documento         Valor Doc.  Saldo Pendiente   N° Guía  Fecha       Semilla                   Variedad                  Ot.Producto                   Cantidad  P.Unitario
        REM ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        REM 99/99/9999  XX-9999999999   999.999.999       999.999.999   9999999  99/99/9999  xxxxxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxxxxxxxxx  999.999.999  999.999,99
        REM 99/99/9999  XX-9999999999   999.999.999       999.999.999   9999999  99/99/9999  xxxxxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxxxxxxxxx  999.999.999  999.999,99
        REM 99/99/9999  XX-9999999999   999.999.999       999.999.999   9999999  99/99/9999  xxxxxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxxxxxxxxx  999.999.999  999.999,99
        REM ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        REM Total                       999.999.999       999.999.999
        REM ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        REM 
        REM Documentos por Cobrar
        REM 
        REM Tipo                 N°   Glosa                                                                       Fecha Vcto.  Valor Pagado        Saldo
        REM ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        REM CHEQUES x COBRAR  999999  xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  99/99/9999    999.999.999  999.999.999 
        REM ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        REM Total                                                                                                               999.999.999  999.999.999
        REM ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        REM 
        REM Resumen
        REM 
        REM ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        REM           Doc. Pendientes : 999.999.999               Documentos x Cobrar : 999.999.999             Saldo Abonos a Pedidos : 999.999.999                  Total Deuda : 999.999.999
        REM ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



       
        ePrint.HasMorePages = False


    End Sub

    Private Sub Cartola_Cliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FormatoImpresion.Alignment = StringAlignment.Far

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '        Imprime_Cartola()
        Imprime_Cartola_Cliente.Show()
    End Sub

    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs)
        txt_RutCliente.Clear()
    End Sub

End Class