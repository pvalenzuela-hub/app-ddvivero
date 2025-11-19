Imports System.Drawing.Printing

Public Class Reporte_Control_Lote

    Dim iCorte1 As String = ""
    Dim sCorte2 As String = ""
    Dim bFirstTime As Boolean = True
    Dim dTotalBandejas As Double
    Dim bFinMesa As Boolean
    REM Parametros Impresión
    Dim bControlLectura As Boolean
    Dim sEncabezado2 As String
    Dim iNumPag As Integer
    Dim sTituloReporte As String
    Dim sSubTituloReporte As String
    Dim aEncabezado(0 To 0) As String
    Dim FormatoImpresion As New StringFormat
    Dim iFilasImpresion As Integer
    Dim iLargoPagina As Integer = 50
    Dim iPageNumber As Integer = 0
    Dim iTamanoLetra1 As Integer
    Dim iTamanoLetra2 As Integer
    Dim iTamanoLetra3 As Integer
    Dim iLinea As Integer
    Dim iCol As Integer
    Dim sTipoLetra As String
    Dim iLeftMargin As Integer
    Dim iTopMargin As Integer
    Dim iLargoFactura As Integer = 560
    Dim iLineasPendientes As Integer = 0
    Private Sub Reporte_Control_Lote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetReporteInventario.SP_Reporte_CTL_Lotes' Puede moverla o quitarla según sea necesario.

        Me.SP_Reporte_CTL_LotesTableAdapter.Connection.ConnectionString = gSOURCE

        Me.SP_Reporte_CTL_LotesTableAdapter.Fill(Me.DataSetReporteInventario.SP_Reporte_CTL_Lotes)

        Me.ReportViewer1.RefreshReport()

        FormatoImpresion.Alignment = StringAlignment.Far
    End Sub

    Private Sub Control_Lotes()
        Dim prnTxt As New PrintDocument
        ReDim aEncabezado(0 To 11)
        iFilasImpresion = 0
        iPageNumber = 0
        iLeftMargin = 70
        iTopMargin = 225

        iTamanoLetra1 = 6
        iTamanoLetra2 = 8
        iTamanoLetra3 = 10
        iNumPag = 1
        bFinMesa = False
        sTituloReporte = "Control de Lotes"
        sSubTituloReporte = ""
        aEncabezado(0) = "N°Lote"
        aEncabezado(1) = "CLIENTE"
        aEncabezado(2) = "Especie"
        aEncabezado(3) = "Variedad"
        aEncabezado(4) = "N°Band."
        aEncabezado(5) = "Conteo"
        aEncabezado(6) = "F.Entrega"
        aEncabezado(7) = "F.Control"
        aEncabezado(8) = "C.Ent."
        aEncabezado(9) = "C.Cli."
        aEncabezado(10) = "C.Enf."
        aEncabezado(11) = "C.Obs."

        iCorte1 = ""
        sCorte2 = ""
        sEncabezado2 = ""

        sTipoLetra = "Arial"
        sSsql = "SP_Reporte_CTL_Lotes"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        bControlLectura = True
        If datatbl.HasRows Then
            datatbl.Read()
            AddHandler prnTxt.PrintPage, AddressOf Me.Genera_Reporte_Control_Lotes
            If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                prnTxt.PrinterSettings.PrinterName = PrintDialog1.PrinterSettings.PrinterName
                prnTxt.Print()
            End If
        End If

    End Sub


    Private Sub Genera_Reporte_Control_Lotes(ByVal sender As System.Object, ByVal ePrint As PrintPageEventArgs)
        REM Encabezado
        REM REPORTE CONTROL DE LOTES
        iLinea = 10
        ePrint.Graphics.DrawString(sTituloReporte, New Font(sTipoLetra, iTamanoLetra3, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, 250, iLinea)
        ePrint.Graphics.DrawString(Format(Now.Date, "dd/MMM/yyyy"), New Font(sTipoLetra, iTamanoLetra3, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, 800, iLinea, FormatoImpresion)

        iLinea = 25
        ePrint.Graphics.DrawString(sSubTituloReporte, New Font(sTipoLetra, iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, 150, iLinea)
        ePrint.Graphics.DrawString("Pág.:" & Format(iNumPag, "###"), New Font(sTipoLetra, iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, 800, iLinea, FormatoImpresion)
        iNumPag += 1

        iLinea += 30

        For i As Integer = 0 To 11
            Select Case i
                Case 0
                    iCol = 12
                Case 1
                    iCol = 50
                Case 2
                    iCol = 270
                Case 3
                    iCol = 350
                Case 4
                    iCol = 460
                Case 5
                    iCol = 510
                Case 6
                    iCol = 550
                Case 7
                    iCol = 600
                Case 8
                    iCol = 680
                Case 9
                    iCol = 710
                Case 10
                    iCol = 740
                Case 11
                    iCol = 770

            End Select
            ePrint.Graphics.DrawString(aEncabezado(i), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            ePrint.Graphics.DrawLine(Pens.Black, 10, iLinea + 15, 840, iLinea + 15)

        Next
        iLinea += 15

        sEncabezado2 = "NAVE : " & datatbl(0) & "-" & datatbl(1)
        ePrint.Graphics.DrawString(sEncabezado2, New Font(sTipoLetra, iTamanoLetra3, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, 50, iLinea)
        ePrint.Graphics.DrawLine(Pens.Black, 10, iLinea + 15, 840, iLinea + 15)

        iLinea += 20

        iCorte1 = datatbl(0)
        sCorte2 = datatbl(1)

        iFilasImpresion = 0
        ePrint.Graphics.DrawRectangle(Pens.Black, 10, 50, 830, 1000)

        While bControlLectura

            Try
                sEncabezado2 = "NAVE : " & datatbl(0) & "-" & datatbl(1)

                If iLinea > 1000 Then
                    ePrint.HasMorePages = True
                    Exit Sub
                End If

                If iCorte1 <> datatbl(0) Then

                    ePrint.Graphics.DrawLine(Pens.Black, 10, iLinea - 3, 840, iLinea - 3)
                    ePrint.Graphics.DrawString(sEncabezado2, New Font(sTipoLetra, iTamanoLetra3, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, 50, iLinea)
                    ePrint.Graphics.DrawLine(Pens.Black, 10, iLinea + 15, 840, iLinea + 15)

                    iLinea += 20
                    iCorte1 = datatbl(0)
                    sCorte2 = datatbl(1)

                End If

                If sCorte2 <> datatbl(1) Then

                    ePrint.Graphics.DrawLine(Pens.Black, 10, iLinea - 3, 840, iLinea - 3)
                    ePrint.Graphics.DrawString(sEncabezado2, New Font(sTipoLetra, iTamanoLetra3, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, 50, iLinea)
                    ePrint.Graphics.DrawLine(Pens.Black, 10, iLinea + 15, 840, iLinea + 15)

                    iLinea += 20
                    sCorte2 = datatbl(1)

                End If
                iCol = 35
                ePrint.Graphics.DrawString(Format(datatbl(2), "#####"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea, FormatoImpresion)
                iCol += 5
                ePrint.Graphics.DrawString(datatbl(6), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
                iCol += 230
                ePrint.Graphics.DrawString(datatbl(7), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
                iCol += 80
                ePrint.Graphics.DrawString(datatbl(8), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
                iCol += 140
                ePrint.Graphics.DrawString(Format(datatbl(5), "###,###"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea, FormatoImpresion)
                iCol += 50
                ePrint.Graphics.DrawString(Format(datatbl(9), "###,###"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea, FormatoImpresion)
                iCol += 5
                ePrint.Graphics.DrawString(datatbl(12), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
                iCol += 50
                ePrint.Graphics.DrawString(datatbl(17), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
                iCol = 680
                ePrint.Graphics.DrawString(datatbl(18), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
                iCol = 710
                ePrint.Graphics.DrawString(datatbl(19), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
                iCol = 740
                ePrint.Graphics.DrawString(datatbl(20), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
                iCol = 770
                ePrint.Graphics.DrawString(datatbl(21), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)

                iFilasImpresion += 1
                iLinea += 15

                datatbl.Read()

            Catch ex As Exception
                Exit While
            End Try


        End While

        ePrint.HasMorePages = False

        close_conexion()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Control_Lotes()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txt_Num_Nave.Text = Nothing Then
            MsgBox("Debe Ingresar Nº Nave para emitir Informe de Lotes por Ubicación", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Imprime_Inventario_Lotes_Ubicacion()
    End Sub



    Private Sub Imprime_Inventario_Lotes_Ubicacion()
        Dim prnTxt As New PrintDocument

        iFilasImpresion = 0
        iPageNumber = 0

        iTopMargin = 225

        iTamanoLetra1 = 12
        iTamanoLetra2 = 14
        iTamanoLetra3 = 20
        bFinMesa = False
        sTipoLetra = "Microsoft Sans Serif"

        bControlLectura = True
        sSsql = "SP_Reporte_INV_Lotes_Ubicacion "
        sSsql += txt_Num_Nave.Text
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            AddHandler prnTxt.PrintPage, AddressOf Me.Genera_Reporte_Inventario_Lotes_Mesas
            If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                prnTxt.PrinterSettings.PrinterName = PrintDialog1.PrinterSettings.PrinterName
                prnTxt.Print()
            End If
        End If


    End Sub

    Private Sub Genera_Reporte_Inventario_Lotes_Mesas(ByVal sender As System.Object, ByVal ePrint As PrintPageEventArgs)
        Dim iPosicion As Integer
        Dim sUbicacion As String
        iLinea = 50
        iCol = 20
        sTituloReporte = "REPORTE DE UBICACION NAVE : " & datatbl(0) & " (N° Lote/Bandejas)"
        ePrint.Graphics.DrawString(sTituloReporte, New Font(sTipoLetra, iTamanoLetra3, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea + 10)

        sUbicacion = "UBICACION : " & datatbl(1)
        iLinea += 45
        ePrint.Graphics.DrawString(sUbicacion, New Font(sTipoLetra, iTamanoLetra3, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, 20, iLinea)


        iLinea += 50
        iCorte1 = datatbl(0)
        sCorte2 = datatbl(1)

        ePrint.Graphics.DrawRectangle(Pens.Black, 10, 50, 790, 1100)


        iCol = 10
        iPosicion = 0
        While bControlLectura
            Try
                If iLinea > 990 Then
                    ePrint.HasMorePages = True
                    Exit Sub
                End If

                'If iCorte1 <> datatbl(0) Then
                '    iCorte1 = datatbl(0)
                '    sCorte2 = datatbl(1)
                '    iLinea += 20
                '    ePrint.Graphics.DrawString(Format(dTotalBandejas, "Total Band:####"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, 150, iLinea, FormatoImpresion)
                '    iLinea += 20
                '    sTituloReporte = "NAVE : " & datatbl(0) & " - " & datatbl(1)
                '    ePrint.Graphics.DrawString(sTituloReporte, New Font(sTipoLetra, iTamanoLetra3, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, 20, iLinea + 10)
                '    dTotalBandejas = 0
                '    iPosicion = 0
                '    REM SALTO DE PAGINA
                '    ePrint.HasMorePages = True
                '    Exit Sub
                'End If

                If sCorte2 <> datatbl(1) Then
                    If bFinMesa Then
                        iLinea += 20
                        ePrint.Graphics.DrawString(Format(dTotalBandejas, "Total Band:####"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, 150, iLinea, FormatoImpresion)

                        sUbicacion = "UBICACION : " & datatbl(1)
                        iLinea += 40
                        ePrint.Graphics.DrawString(sUbicacion, New Font(sTipoLetra, iTamanoLetra3, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, 20, iLinea)

                        bFinMesa = False
                        dTotalBandejas = 0
                        iLinea += 30
                        sCorte2 = datatbl(1)
                        iPosicion = 0
                    End If
                End If

                If iPosicion = 7 Then
                    iPosicion = 0
                    iLinea += 20
                End If

                Select Case iPosicion
                    Case 0
                        iCol = 10
                    Case 1
                        iCol = 120
                    Case 2
                        iCol = 230
                    Case 3
                        iCol = 340
                    Case 4
                        iCol = 450
                    Case 5
                        iCol = 560
                    Case 6
                        iCol = 670
                End Select
                ePrint.Graphics.DrawString(Format(datatbl(2), "#######/") + Format(datatbl(22), "####"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol + 50, iLinea)

                dTotalBandejas += datatbl(22)
                bFinMesa = True

                iPosicion += 1


                REM LEER SIGUIENTE REGISTRO
                datatbl.Read()
            Catch ex As Exception
                Exit While
            End Try


        End While
        iLinea += 20
        ePrint.Graphics.DrawString(Format(dTotalBandejas, "Total Band:####"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, 150, iLinea, FormatoImpresion)


        ePrint.HasMorePages = False

        close_conexion()

    End Sub

    Private Sub Genera_Reporte_Inventario_Lotes(ByVal sender As System.Object, ByVal ePrint As PrintPageEventArgs)
        Dim iMesa As Integer
        iLinea = 50

        sTituloReporte = "NAVE : " & datatbl(0)
        iCol = 20
        ePrint.Graphics.DrawString(sTituloReporte, New Font(sTipoLetra, iTamanoLetra3, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea + 10)

        iLinea = 100

        For i As Integer = 0 To 4
            Select Case i
                Case 0
                    iCol = 150
                Case 1
                    iCol = 300
                Case 2
                    iCol = 450
                Case 3
                    iCol = 600
                Case 4
                    iCol = 750
            End Select
            ePrint.Graphics.DrawString(aEncabezado(i), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol + 40, iLinea, FormatoImpresion)
        Next

        iLinea += 50
        iCorte1 = datatbl(0)
        sCorte2 = datatbl(1)

        ePrint.Graphics.DrawRectangle(Pens.Black, 20, 50, 780, 950)
        ePrint.Graphics.DrawLine(Pens.Black, 20, 95, 800, 95)
        ePrint.Graphics.DrawLine(Pens.Black, 20, 120, 800, 120)
        ePrint.Graphics.DrawLine(Pens.Black, 200, 95, 200, 1000)
        ePrint.Graphics.DrawLine(Pens.Black, 350, 95, 350, 1000)
        ePrint.Graphics.DrawLine(Pens.Black, 500, 95, 500, 1000)
        ePrint.Graphics.DrawLine(Pens.Black, 650, 95, 650, 1000)
        iCol = 20

        While bControlLectura
            Try

                If iCorte1 <> datatbl(0) Then
                    iCorte1 = datatbl(0)

                    ePrint.Graphics.DrawString(Format(dTotalBandejas, "Total Band:####"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol + 40, 950, FormatoImpresion)
                    dTotalBandejas = 0
                    REM SALTO DE PAGINA
                    ePrint.HasMorePages = True
                    Exit Sub
                End If

                If sCorte2 <> datatbl(1) Then
                    If bFinMesa Then
                        ePrint.Graphics.DrawString(Format(dTotalBandejas, "Total Band:####"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol + 40, 950, FormatoImpresion)
                        bFinMesa = False
                        dTotalBandejas = 0
                        iLinea = 150
                        sCorte2 = datatbl(1)
                    End If

                    'iLinea = 100
                    'sCorte2 = datatbl(1)
                    'iCol += 150
                    'ePrint.Graphics.DrawString("MESA : " & sCorte2, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol + 40, iLinea, FormatoImpresion)
                    'iLinea += 50
                End If

                iMesa = Mid(datatbl(1), 2)
                Select Case iMesa
                    Case 1
                        iCol = 150
                    Case 2
                        iCol = 300
                    Case 3
                        iCol = 450
                    Case 4
                        iCol = 600
                    Case 5
                        iCol = 750
                End Select
                ePrint.Graphics.DrawString(Format(datatbl(2), "###,###,###"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea, FormatoImpresion)
                ePrint.Graphics.DrawString(Format(datatbl(5), "####"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol + 40, iLinea, FormatoImpresion)
                dTotalBandejas += datatbl(5)
                bFinMesa = True
                iLinea += 20

                REM LEER SIGUIENTE REGISTRO
                datatbl.Read()
            Catch ex As Exception
                Exit While
            End Try


        End While
        ePrint.Graphics.DrawString(Format(dTotalBandejas, "Total Band:####"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol + 40, 950, FormatoImpresion)

        ePrint.Graphics.DrawRectangle(Pens.Black, 20, 50, 780, 950)
        ePrint.Graphics.DrawLine(Pens.Black, 20, 95, 800, 95)
        ePrint.Graphics.DrawLine(Pens.Black, 20, 120, 800, 120)
        ePrint.Graphics.DrawLine(Pens.Black, 200, 95, 200, 1000)
        ePrint.Graphics.DrawLine(Pens.Black, 350, 95, 350, 1000)
        ePrint.Graphics.DrawLine(Pens.Black, 500, 95, 500, 1000)
        ePrint.Graphics.DrawLine(Pens.Black, 650, 95, 650, 1000)

        ePrint.HasMorePages = False

        close_conexion()

    End Sub


  
   
End Class