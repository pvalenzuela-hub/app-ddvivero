Imports System.Windows.Forms
Imports System.Drawing.Printing

Public Class ResumenDespacho
    Dim iNumGuia As Integer
    Dim iNumLote As Integer
    Dim iNumPedido As String
    Dim sFechaGuia As String
    Dim sRutCliente As String
    Dim sDigitoRut As String
    Dim sNombreCliente As String
    Dim sVendedor As String
    Dim sDireccion As String
    Dim sComuna As String
    Dim sTelefonos As String
    Dim sCiudad As String
    Dim sGiro As String
    Dim sEspecie As String
    Dim sVariedad As String
    Dim sFechaInicio As String
    Dim sFechaSiembra As String
    Dim sFechaConteo As String
    Dim iBandPedido As Integer
    Dim iBandSiembra As Integer
    Dim iBandConteo As Integer
    Dim iCantPedido As Integer
    Dim iConteoSiembra As Integer
    Dim iConteoPlantas As Integer
    Dim iTipoBandeja As Integer
    Dim dPlantasTerminadas As Double
    Dim dAbonoInicial As Double
    Dim dPlantasRetiro As Double
    Dim dPrecioNeto As Double
    Dim iBandRetiro As Integer
    Dim sComentarios As String
    Dim dValorTotalGuiaNeto As Double
    Dim dTotalIVA As Double
    Dim dValorTotalGuiaIVA As Double
    Dim iBandNuevas As Integer
    Dim iBandUsadas As Integer
    Dim dValorUnitBandeja As Double
    Dim sAcuerdoCom As String
    Dim dDiferenciaSemCorr As Double
    Dim dPrinterName As New PrintDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim i As Integer
        'Dim iIdVendedor As Integer
        'open()
        'command = connection.CreateCommand()
        'sSsql = "Select IdVendedor From Vendedor Where IdUsuario='" & gUSER & "'"
        'command.CommandText = sSsql
        'datatbl = command.ExecuteReader()
        'datatbl.Read()
        'iIdVendedor = datatbl(0)
        'close_conexion()
        'cmbVendedor.SelectedValue = iIdVendedor

        Dim sResp = MsgBox("Confirmar Emisión de Guías", MsgBoxStyle.YesNo, "Confirma Emisión de Guías")
        If Val(Despacho.txtNumDesp.Text) <= 0 Then
            MsgBox("N° de Despacho debe ser un valor mayor a 0")
            Me.Close()
        End If
        If sResp = MsgBoxResult.Yes Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            REM Emite Guías para Lotes Seleccionados en formulario de Despacho
            If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                REM Setea Impresora
                dPrinterName.PrinterSettings.PrinterName = PrintDialog1.PrinterSettings.PrinterName
            End If
            For i = 0 To Despacho.GrillaDespacho.Rows.Count - 1
                If Despacho.GrillaDespacho.Rows(i).Cells(0).Value = True Then
                    iNumLote = Despacho.GrillaDespacho.Rows(i).Cells(1).Value
                    Crear_Guia(Val(Despacho.txtNumDesp.Text))
                End If
            Next
            Impresion_Guia_Despacho(Val(Despacho.txtNumDesp.Text))
        End If
        Despacho.SP_ConsultaDespDTableAdapter.Fill(Despacho.GESTDataSet33.SP_ConsultaDespD, Despacho.txtNumDesp.Text)
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub MostrarResumen(ByVal sListaLotes As String)
        Dim i As Integer = 0
        sSsql = "SP_consultaResumenLotesDespachos "
        sSsql += "'" + sListaLotes + "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then
            While datatbl.Read
                GrillaResumen.Rows.Add()
                GrillaResumen.Rows(i).Cells(0).Value = datatbl(0)
                GrillaResumen.Rows(i).Cells(1).Value = datatbl(1)
                GrillaResumen.Rows(i).Cells(2).Value = datatbl(2)
                GrillaResumen.Rows(i).Cells(3).Value = datatbl(3)
                i += 1
            End While
        Else
            MsgBox("No Existen datos para mostrar en la consulta de Lotes Despachados.")
        End If

        close_conexion()
    End Sub

    Private Sub ResumenDespacho_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet34.SP_CONSULTA_FULL_VENDEDOR' Puede moverla o quitarla según sea necesario.
        Me.SP_CONSULTA_FULL_VENDEDORTableAdapter.Connection.ConnectionString = gSOURCE

        Me.SP_CONSULTA_FULL_VENDEDORTableAdapter.Fill(Me.GESTDataSet34.SP_CONSULTA_FULL_VENDEDOR)
        MostrarResumen(Despacho.txtSerieLotes.Text)
        open()
        command = connection.CreateCommand()
        sSsql = "Select IdVendedor From Vendedor Where IdUsuario='" & gUSER & "'"
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        datatbl.Read()
        gIdVendedor = datatbl(0)
        close_conexion()
        cmbVendedor.SelectedValue = gIdVendedor

    End Sub

    Private Sub Imprime_Guia()
        Dim prnTxt As New PrintDocument
        AddHandler prnTxt.PrintPage, AddressOf Me.Imprime_Guia_Entrega


        'prnTxt.PrinterSettings.PrinterName = gPrinter
        'prnTxt.Print()


        prnTxt.PrinterSettings.PrinterName = dPrinterName.PrinterSettings.PrinterName
        prnTxt.PrinterSettings.Copies = 2
        prnTxt.Print()

        'If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    prnTxt.PrinterSettings.PrinterName = PrintDialog1.PrinterSettings.PrinterName
        '    prnTxt.Print()
        'End If




    End Sub
    Private Sub Imprime_Voucher()
        Dim prnTxt As New PrintDocument
        AddHandler prnTxt.PrintPage, AddressOf Me.Reimpresion_Voucher_Bandeja


        'prnTxt.PrinterSettings.PrinterName = gPrinter
        'prnTxt.Print()

        prnTxt.PrinterSettings.PrinterName = dPrinterName.PrinterSettings.PrinterName
        prnTxt.Print()

        'If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    prnTxt.PrinterSettings.PrinterName = PrintDialog1.PrinterSettings.PrinterName
        '    prnTxt.Print()
        'End If
    End Sub
    Private Sub Crear_Guia(nDespacho As Integer)
        REM ************
        REM EMISION GUIA
        REM ************
        Dim idCliente As Integer

        Dim dFechaGuia As Date = Now
        Dim dPlantasRetiro As Double
        Dim dSaldoBandeja As Double
        Dim dPrecioNeto As Double
        Dim dValorNetoGuia As Double
        Dim dTotalAbonos As Double
        Dim dValorTotalGuiaIVA As Double
        Dim dPlantasCobrar As Double
        REM Consulta datos del Lote
        open()
        sSsql = "SP_CONSULTA_DETALLE_LOTE "
        sSsql += iNumLote.ToString

        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then
            datatbl.Read()
            dPlantasRetiro = datatbl(31)
            dPlantasCobrar = dPlantasRetiro
            If datatbl(80) = "S" Then ' Aporte de Semilla
                If datatbl(81) = False Then ' Semilla NO CERTIFICADA, debe cobrar mìnimo 90% de germinación
                    If dPlantasRetiro / datatbl(16) < 0.9 Then
                        dPlantasCobrar = Math.Round(datatbl(16) * 0.9, 0, MidpointRounding.AwayFromZero)
                    End If
                End If
            End If

            idCliente = datatbl(30)
            dSaldoBandeja = datatbl(76)
            dPrecioNeto = datatbl(11)
            dValorNetoGuia = Math.Round(dPlantasCobrar * dPrecioNeto, 0, MidpointRounding.AwayFromZero)
            dTotalAbonos = datatbl(68)
            dValorTotalGuiaIVA = Math.Round(dValorNetoGuia + (dValorNetoGuia * GIVA / 100), 0, MidpointRounding.AwayFromZero)
        Else

            MsgBox("No Existe Lote N°:" & iNumLote.ToString)
            close_conexion()
            Exit Sub
        End If

        close_conexion()
        sSsql = "SP_INSERTA_GUIA "
        sSsql += iNumLote.ToString & ","
        sSsql += idCliente.ToString & ","
        sSsql += gIdVendedor.ToString & ","
        sSsql += "'" & dFechaGuia.Date & "',"
        sSsql += dPlantasCobrar.ToString & ","
        sSsql += dSaldoBandeja.ToString & ","
        sSsql += "0" & ","
        sSsql += "'',"
        sSsql += Reemplaza_Comas(dPrecioNeto.ToString) & ","
        sSsql += "'" & "N" & "',"
        sSsql += dValorNetoGuia.ToString & ","
        sSsql += "0,"
        sSsql += dValorTotalGuiaIVA.ToString & ","
        sSsql += "0,"
        sSsql += nDespacho.ToString()
        open()

        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        datatbl.Read()

        iNumGuia = datatbl(0)

        close_conexion()
    End Sub

    Private Sub Impresion_Guia_Despacho(nDespacho As Integer)
        Print_Guia.nDespacho.Text = nDespacho
        Print_Guia.Show()
    End Sub
    Private Sub Recupera_Guia()

        open()

        sSsql = "SP_CONSULTA_GUIA "
        sSsql += iNumGuia.ToString

        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then

            datatbl.Read()
            iNumLote = datatbl(1)
            sFechaGuia = datatbl(4)
            sRutCliente = Format(Val(Mid(datatbl(29), 1, 11)), "##,###,###,###")
            sDigitoRut = Mid(datatbl(29), 12, 1)
            sNombreCliente = datatbl(17)
            sVendedor = datatbl(28)
            sDireccion = datatbl(30)
            sComuna = datatbl(31).ToString
            sTelefonos = datatbl(33).ToString
            sCiudad = datatbl(32).ToString
            sGiro = datatbl(34).ToString
            sEspecie = RTrim(datatbl(15))
            sVariedad = RTrim(datatbl(16))
            iNumPedido = datatbl(18)
            sFechaInicio = datatbl(19)
            sFechaSiembra = datatbl(23)
            sFechaConteo = IsDBNull(datatbl(25))
            iBandPedido = datatbl(20)
            iConteoSiembra = datatbl(24)
            iTipoBandeja = datatbl(22)
            iBandSiembra = Calculo_Bandejas(iConteoSiembra, iTipoBandeja)
            iBandConteo = datatbl(26)
            iCantPedido = datatbl(21)
            iConteoSiembra = datatbl(24)
            iConteoPlantas = datatbl(27)
            dPlantasTerminadas = Math.Round(iConteoPlantas / iConteoSiembra * 100, 2, MidpointRounding.AwayFromZero)
            dAbonoInicial = datatbl(12)
            dPlantasRetiro = datatbl(5)
            dPrecioNeto = datatbl(9)
            iBandRetiro = datatbl(6)
            sComentarios = datatbl(37)
            dValorTotalGuiaNeto = datatbl(11)
            dTotalIVA = Math.Round(dValorTotalGuiaNeto * GIVA / 100, 0, MidpointRounding.AwayFromZero)
            dValorTotalGuiaIVA = dValorTotalGuiaNeto + dTotalIVA
            iBandUsadas = datatbl(41)
            iBandNuevas = datatbl(42)
            dValorUnitBandeja = datatbl(40)
            sAcuerdoCom = datatbl(43)
            dDiferenciaSemCorr = datatbl(45)
        Else
            MsgBox("NO EXISTE N° DE GUIA:" & iNumGuia.ToString)
        End If
        close_conexion()
    End Sub
    Private Sub Imprime_Guia_Entrega(ByVal sender As System.Object, ByVal ePrint As PrintPageEventArgs)
        '' Impresión Guia de Entrega
        Dim sTitulo As String
        Dim iTamanoLetra1 As Integer
        Dim iTamanoLetra2 As Integer
        Dim iTamanoLetra3 As Integer
        Dim iLinea As Integer
        Dim iCol As Integer
        Dim sTipoLetra As String
        Dim iLeftMargin As Integer

        'dPlantasRetiro = Val(txt_PlantasRetiro.Text)
        'dTotalGuia = Math.Round(dPlantasRetiro * dPrecioNeto, 0, MidpointRounding.AwayFromZero)
        'dTotalIVA = Math.Round(gValorTotalGuiaNeto * GIVA / 100, 0, MidpointRounding.AwayFromZero)
        'dTotalMasIVA = gValorTotalGuiaNeto + dTotalIVA
        'dValorFinalGuia = gValorTotalGuiaIVA - dAbonos

        iLeftMargin = 10

        iCol = iLeftMargin
        iLinea = 25
        sTitulo = "GUIA DE ENTREGA N° : " & iNumGuia.ToString

        iTamanoLetra1 = 8
        iTamanoLetra2 = 10
        iTamanoLetra3 = 12
        sTipoLetra = "Arial"
        ePrint.Graphics.DrawString(gDataEmp, New Font("High Tower Text", 14, FontStyle.Bold, GraphicsUnit.Point), Brushes.Green, 500, 1)
        ePrint.Graphics.DrawString(gDataEmpFono, New Font("Arial Narrow", iTamanoLetra1, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, 500, iLinea)
        iCol = 150
        ePrint.Graphics.DrawString(sTitulo, New Font("Arial Narrow", iTamanoLetra3, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20
        iCol = 200
        ePrint.Graphics.DrawString("N° LOTE: " & iNumLote.ToString, New Font("Arial Narrow", iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 60
        iCol = iLeftMargin
        ePrint.Graphics.DrawString("Fecha: " & sFechaGuia, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 350
        ePrint.Graphics.DrawString("Rut: " & sRutCliente & "-" & sDigitoRut, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20
        iCol = iLeftMargin
        ePrint.Graphics.DrawString("Cliente: " & sNombreCliente, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20
        iCol = iLeftMargin
        ePrint.Graphics.DrawString("Dirección: " & sDireccion, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 350
        ePrint.Graphics.DrawString("Comuna: " & sComuna, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20
        iCol = iLeftMargin
        ePrint.Graphics.DrawString("Teléfono: " & sTelefonos, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 350
        ePrint.Graphics.DrawString("Ciudad: " & sCiudad, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20
        iCol = iLeftMargin
        ePrint.Graphics.DrawString("Giro: " & sGiro, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        'iLinea += 20
        'ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 750, iLinea)
        iLinea += 20
        ePrint.Graphics.DrawString("Semilla: " & sEspecie & " Variedad: " & sVariedad, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = iLeftMargin
        iLinea += 20
        ePrint.Graphics.DrawLine(Pens.Black, iLeftMargin, iLinea, 595, iLinea)
        ePrint.Graphics.DrawLine(Pens.Black, iLeftMargin, iLinea, iLeftMargin, iLinea + 105)
        ePrint.Graphics.DrawLine(Pens.Black, 200, iLinea, 200, iLinea + 105)
        ePrint.Graphics.DrawLine(Pens.Black, 395, iLinea, 395, iLinea + 105)
        ePrint.Graphics.DrawLine(Pens.Black, 595, iLinea, 595, iLinea + 105)
        ePrint.Graphics.DrawLine(Pens.Black, iLeftMargin, iLinea + 105, 595, iLinea + 105)
        iLinea += 10
        ePrint.Graphics.DrawString("PEDIDO: " & iNumPedido.ToString, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 200
        ePrint.Graphics.DrawString("SIEMBRA", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 395
        ePrint.Graphics.DrawString("CONTEO FINAL", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20
        '---
        iCol = iLeftMargin
        ePrint.Graphics.DrawString("Fecha: " & sFechaInicio, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 205
        ePrint.Graphics.DrawString("Fecha: " & sFechaSiembra, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 400
        ePrint.Graphics.DrawString("Fecha: " & sFechaConteo, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20
        '---
        iCol = iLeftMargin
        ePrint.Graphics.DrawString("Bandejas: " & iBandPedido.ToString("###0"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 205
        ePrint.Graphics.DrawString("Bandejas: " & iBandSiembra.ToString("###0"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 400
        ePrint.Graphics.DrawString("Bandejas: " & iBandConteo.ToString("###0"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20
        '----
        iCol = iLeftMargin
        ePrint.Graphics.DrawString("Plantas: " & iCantPedido.ToString("###,###,###"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 205
        ePrint.Graphics.DrawString("Plantas: " & iConteoSiembra.ToString("###,###,###"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 400
        ePrint.Graphics.DrawString("Plantas: " & iConteoPlantas.ToString("###,###,###"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20
        '---
        iCol = iLeftMargin
        ePrint.Graphics.DrawString("Tipo Bandeja: " & iTipoBandeja, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 400
        ePrint.Graphics.DrawString("% Terminadas: " & dPlantasTerminadas.ToString("##0.00"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20
        '--
        iCol = iLeftMargin
        ePrint.Graphics.DrawString("Abono Inicial: " & dAbonoInicial.ToString("#,###,##0"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20

        iCol = iLeftMargin
        ePrint.Graphics.DrawLine(Pens.Black, iLeftMargin, iLinea, 595, iLinea) ' Linea Horizontal desde punto inicial izquierdo
        ePrint.Graphics.DrawLine(Pens.Black, iLeftMargin, iLinea, iLeftMargin, iLinea + 65) ' Linea Vertical desde punto inicial izquierdo
        ePrint.Graphics.DrawLine(Pens.Black, 595, iLinea, 595, iLinea + 65) ' linea vertical desde posición punto inicial derecho

        iLinea += 10
        ePrint.Graphics.DrawString("RETIRO DE PLANTAS", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 200
        ePrint.Graphics.DrawString("Entregadas: " & dPlantasRetiro.ToString("###,###,###"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 330
        ePrint.Graphics.DrawString("Valor Unit.: " & Math.Round(dPrecioNeto * 1.19, 2, MidpointRounding.AwayFromZero).ToString("###,##0.00"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 430
        ePrint.Graphics.DrawString("Cant. Bandejas: " & iBandRetiro.ToString("##0"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 15
        ePrint.Graphics.DrawString("Observaciones: " & sComentarios, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iLeftMargin, iLinea)
        iLinea += 25
        ePrint.Graphics.DrawString("Acuerdos: " & sAcuerdoCom, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iLeftMargin, iLinea)

        iCol = 10 + iLeftMargin
        iLinea += 15
        ePrint.Graphics.DrawLine(Pens.Black, iLeftMargin, iLinea, 595, iLinea)
        ePrint.Graphics.DrawLine(Pens.Black, iLeftMargin, iLinea, iLeftMargin, iLinea + 50)
        ePrint.Graphics.DrawLine(Pens.Black, 595, iLinea, 595, iLinea + 50)
        ePrint.Graphics.DrawLine(Pens.Black, iLeftMargin, iLinea + 50, 595, iLinea + 50)

        iLinea += 10
        'ePrint.Graphics.DrawString("Total Neto: " & dValorTotalGuiaNeto.ToString("###,###,##0"), New Font(sTipoLetra, iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 200 + iLeftMargin
        'ePrint.Graphics.DrawString("IVA: " & dTotalIVA.ToString("###,###,##0"), New Font(sTipoLetra, iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 300 + iLeftMargin
        ePrint.Graphics.DrawString("Total Guía: " & dValorTotalGuiaIVA.ToString("###,###,##0"), New Font(sTipoLetra, iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 400 + iLeftMargin
        'ePrint.Graphics.DrawString("Abonos: " & Format(dTotalAbonos, "###,###,##0"), New Font(sTipoLetra, iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20

        If dDiferenciaSemCorr > 0 Then
            iCol = 10 + iLeftMargin
            ePrint.Graphics.DrawString("Diferencia a cancelar por 90% Semilla Corriente (Valor Neto): " & dDiferenciaSemCorr.ToString("###,###,##0"), New Font(sTipoLetra, iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iLinea += 20
        End If

        'iCol = 300 + iLeftMargin
        'ePrint.Graphics.DrawString("Total Guía: " & Format(dValorFinalGuia, "###,###,##0"), New Font(sTipoLetra, iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 30
        iCol = 10 + iLeftMargin
        ePrint.Graphics.DrawString("Atendido por: " & sVendedor, New Font(sTipoLetra, iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 300
        ePrint.Graphics.DrawString("Firma certifica retiro conforme de plantas.", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)

        iCol = 300
        iLinea += 40
        ePrint.Graphics.DrawString("..............................", New Font(sTipoLetra, iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 15
        ePrint.Graphics.DrawString("  FIRMA CLIENTE", New Font(sTipoLetra, iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)

        ePrint.HasMorePages = False
        ePrint.Graphics.Dispose()
    End Sub
    Private Sub Reimpresion_Voucher_Bandeja(ByVal sender As System.Object, ByVal ePrint As PrintPageEventArgs)
        Dim i As Integer = 0
        Dim sTitulo As String
        Dim iTamanoLetra1 As Integer
        Dim iTamanoLetra2 As Integer
        Dim iTamanoLetra3 As Integer
        Dim iLinea As Integer
        Dim iCol As Integer


        Dim sTipoLetra As String


        Dim sNota1 As String = "Nota: Cliente acepta el estado y condiciones en que recibe las bandejas y se hace responsable"
        Dim sNota2 As String = "por la devocluión de las unidades retiradas o su valor correspondiente."


        sTitulo = "RETIRO DE BANDEJAS GUIA N° : " & iNumGuia.ToString
        'sLogo = My.Settings.DatEmpIDM
        'sDatEmpFono = My.Settings.DatEmpIDMFono
        iTamanoLetra1 = 8
        iTamanoLetra2 = 10
        iTamanoLetra3 = 12
        sTipoLetra = "Arial"

        iLinea = 1
        For i = 0 To 1
            iCol = 5
            ePrint.Graphics.DrawString(gDataEmp, New Font("High Tower Text", 14, FontStyle.Bold, GraphicsUnit.Point), Brushes.Green, iCol, iLinea)
            iLinea += 20
            ePrint.Graphics.DrawString(gDataEmpFono, New Font("Arial Narrow", iTamanoLetra1, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol = 150
            iLinea += 15
            ePrint.Graphics.DrawString(sTitulo, New Font("Arial Narrow", iTamanoLetra3, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iLinea += 20
            iCol = 200
            ePrint.Graphics.DrawString("N° LOTE: " & iNumLote.ToString, New Font("Arial Narrow", iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iLinea += 60
            iCol = 5
            ePrint.Graphics.DrawString("Fecha: " & sFechaGuia, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol = 5
            iLinea += 15
            ePrint.Graphics.DrawString("Cliente: " & sNombreCliente, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol = 300
            ePrint.Graphics.DrawString("Rut: " & sRutCliente & "-" & sDigitoRut, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol = 5
            iLinea += 15
            ePrint.Graphics.DrawString("PEDIDO: " & iNumPedido.ToString, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol = 200
            ePrint.Graphics.DrawString("Cant. Bandejas Retiradas: " & iBandRetiro.ToString("##0"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol = 400
            ePrint.Graphics.DrawString("Tipo Bandeja: " & iTipoBandeja.ToString, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol = 5
            iLinea += 15
            ePrint.Graphics.DrawString("Nuevas: " & iBandNuevas.ToString, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol = 100
            ePrint.Graphics.DrawString("Usadas: " & iBandUsadas.ToString, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol = 200
            ePrint.Graphics.DrawString("Valor Unit.: " & dValorUnitBandeja.ToString("##,##0"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol = 400
            ePrint.Graphics.DrawString("Valor Total: " & Format(Val(dValorUnitBandeja) * Val(iBandRetiro), "##,##0"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iLinea += 20
            iCol = 5
            ePrint.Graphics.DrawString(sNota1, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iLinea += 10
            ePrint.Graphics.DrawString(sNota2, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol = 300
            iLinea += 45
            ePrint.Graphics.DrawString("..............................", New Font(sTipoLetra, iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iLinea += 15
            ePrint.Graphics.DrawString("  FIRMA CLIENTE", New Font(sTipoLetra, iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iLinea += 25
        Next


        ePrint.HasMorePages = False
        ePrint.Graphics.Dispose()
    End Sub

    Private Sub GrillaResumen_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaResumen.CellContentClick

    End Sub
End Class
