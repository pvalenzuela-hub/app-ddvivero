Imports System.Drawing.Printing
Public Class Impresion_Guia
    Dim gEstado_Actual As Integer
    Dim gValorTotalGuiaNeto As Double
    Dim gValorTotalGuiaIVA As Double
    Dim dTotalIVA As Double
    Dim dValorFinalGuia As Double
    Dim dPrecioNeto As Double
    Dim dSaldoPlantas As Double

    Dim IdCliente As Double
    Dim IDVendedor As Integer
    Dim sRutCliente As String
    Dim sDigRutCliente As String
    Dim sVendedor As String
    Dim dNumeroGuia As Double
    Dim dNumeroLote As Double
    Dim sDireccion As String
    Dim sCiudad As String
    Dim sComuna As String
    Dim sTelefonos As String
    Dim sGiro As String

    Dim sFechaInicio As String
    Dim sFechaSiembra As String
    Dim sFechaConteo As String

    Dim dCantidadPedido As Double
    Dim dConteoSiembra As Double
    Dim dConteoPlantas As Double

    Dim sFechaGuia As String

    Dim iTipoBandeja As Integer
    Dim dBandPedido As Integer
    Dim dBandSiembra As Integer
    Dim dBandConteo As Integer

    Dim dPlantasTerminadas As Double
    Dim dPlantasRetiro As Double
    Dim dBandRetiro As Double

    'Dim dTotalAbonos As Double
    Dim dAbonoInicial As Double
    Dim sNumNave As String
    Dim sUbicacion As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Recupera_Guia()
    End Sub
    Private Sub Recupera_Guia()

        open()
        dNumeroGuia = Val(txt_NumGuia.Text)
        sSsql = "SP_CONSULTA_GUIA " + Str(dNumeroGuia)
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then

            datatbl.Read()
            dNumeroLote = datatbl(1)
            sFechaGuia = datatbl(4)
            sRutCliente = Format(Val(Mid(datatbl(29), 1, 11)), "##,###,###,###")
            sDigRutCliente = Mid(datatbl(29), 12, 1)
            txt_FechaGuia.Text = sFechaGuia
            txt_Cliente.Text = datatbl(17)
            txt_RUT_CLI.Text = sRutCliente
            txt_DIGRUT.Text = sDigRutCliente
            sVendedor = datatbl(28)
            txt_vendedor.Text = sVendedor
            txt_Familia.Text = datatbl(15)
            txt_Variedad.Text = datatbl(16)
            txt_NumPedido.Text = datatbl(18)
            txt_NumLote.Text = dNumeroLote

            dPrecioNeto = datatbl(9)
            dPlantasRetiro = datatbl(5)
            dBandRetiro = datatbl(6)
            txt_PrecioNeto.Text = Format(dPrecioNeto, "###,##0.00")
            txt_PlantasRetiro.Text = Format(dPlantasRetiro, "###,###,###")
            txt_CantidadBandejasRetiro.Text = Format(dBandRetiro, "###,###")
            txt_garantiaband.Text = datatbl(35)

            dConteoPlantas = datatbl(27)
            dConteoSiembra = datatbl(24)

            sDireccion = datatbl(30)
            sCiudad = datatbl(32).ToString
            sComuna = datatbl(31).ToString
            sTelefonos = datatbl(33).ToString
            sGiro = datatbl(34).ToString

            dPlantasTerminadas = Math.Round(dConteoPlantas / dConteoSiembra * 100, 2, MidpointRounding.AwayFromZero)

            dAbonoInicial = datatbl(12)
            txtAbonoInicial.Text = Format(dAbonoInicial, "###,###,##0")

            'txt_TotalAbonos.Text = Format(dTotalAbonos, "###,###,##0")

            gValorTotalGuiaNeto = datatbl(11)
            dTotalIVA = Math.Round(gValorTotalGuiaNeto * GIVA / 100, 0, MidpointRounding.AwayFromZero)
            gValorTotalGuiaIVA = gValorTotalGuiaNeto + dTotalIVA
            ' dTotalAbonos = datatbl(12)
            dValorFinalGuia = gValorTotalGuiaIVA

            txt_ValorNetoGuia.Text = gValorTotalGuiaNeto
            txt_IvaGuia.Text = dTotalIVA
            ' txt_TotalGuia.Text = gValorTotalGuiaIVA
            ' txt_TotalAbonos.Text = dTotalAbonos
            txt_ValorFinalGuia.Text = dValorFinalGuia

            sFechaInicio = datatbl(19)
            sFechaSiembra = datatbl(23)
            sFechaConteo = IsDBNull(datatbl(25))

            iTipoBandeja = datatbl(22)
            txt_TipoBandeja.Text = iTipoBandeja
            dCantidadPedido = datatbl(21)
            dConteoSiembra = datatbl(24)
            dConteoPlantas = datatbl(27)

            dBandPedido = datatbl(20)
            dBandSiembra = Calculo_Bandejas(dConteoSiembra, iTipoBandeja)
            dBandConteo = datatbl(26)

            txt_comentarios.Text = datatbl(37)
            txt_EstadoBandejas.Text = datatbl(39)
            txt_ValorUnitBandeja.Text = datatbl(40)

            txt_Band_Usadas.Text = datatbl(41)
            txt_Band_Nuevas.Text = datatbl(42)
            txtAcuerdoCom.Text = datatbl(43)

            sNumNave = datatbl(46)
            sUbicacion = datatbl(47)


            If datatbl(10) = "S" Then
                txt_IndicadorFacturado.Text = "GUIA FACTURADA"
            Else
                txt_IndicadorFacturado.Text = "GUIA NO FACTURADA"
            End If

            dPlantasTerminadas = Math.Round(dConteoPlantas / dConteoSiembra * 100, 2, MidpointRounding.AwayFromZero)

            btn_grabar.Enabled = True
        Else
            btn_grabar.Enabled = False
            MsgBox("NO EXISTE N° DE GUIA")

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
        'Dim sLogo As String
        Dim iLeftMargin As Integer


        'dPlantasRetiro = Val(txt_PlantasRetiro.Text)
        'dTotalGuia = Math.Round(dPlantasRetiro * dPrecioNeto, 0, MidpointRounding.AwayFromZero)
        'dTotalIVA = Math.Round(gValorTotalGuiaNeto * GIVA / 100, 0, MidpointRounding.AwayFromZero)
        'dTotalMasIVA = gValorTotalGuiaNeto + dTotalIVA
        'dValorFinalGuia = gValorTotalGuiaIVA - dAbonos

        iLeftMargin = 10

        iCol = iLeftMargin
        iLinea = 25
        sTitulo = "GUIA DE ENTREGA N° : " & Str(dNumeroGuia)
        'sLogo = My.Settings.DatEMPLADFono
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
        ePrint.Graphics.DrawString("N° LOTE: " & dNumeroLote, New Font("Arial Narrow", iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 60
        iCol = iLeftMargin
        ePrint.Graphics.DrawString("Fecha: " & sFechaGuia, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 350
        ePrint.Graphics.DrawString("Rut: " & sRutCliente & "-" & txt_DIGRUT.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20
        iCol = iLeftMargin
        ePrint.Graphics.DrawString("Cliente: " & txt_Cliente.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
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
        ' iLinea += 20
        'ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 750, iLinea)
        iLinea += 20
        ePrint.Graphics.DrawString("Semilla: " & RTrim(txt_Familia.Text) & " Variedad: " & txt_Variedad.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = iLeftMargin
        iLinea += 20
        ePrint.Graphics.DrawLine(Pens.Black, iLeftMargin, iLinea, 595, iLinea)
        ePrint.Graphics.DrawLine(Pens.Black, iLeftMargin, iLinea, iLeftMargin, iLinea + 105)
        ePrint.Graphics.DrawLine(Pens.Black, 200, iLinea, 200, iLinea + 105)
        ePrint.Graphics.DrawLine(Pens.Black, 395, iLinea, 395, iLinea + 105)
        ePrint.Graphics.DrawLine(Pens.Black, 595, iLinea, 595, iLinea + 105)
        ePrint.Graphics.DrawLine(Pens.Black, iLeftMargin, iLinea + 105, 595, iLinea + 105)
        iLinea += 10
        ePrint.Graphics.DrawString("PEDIDO: " & txt_NumPedido.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
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
        ePrint.Graphics.DrawString("Bandejas: " & dBandPedido, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 205
        ePrint.Graphics.DrawString("Bandejas: " & dBandSiembra, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 400
        ePrint.Graphics.DrawString("Bandejas: " & dBandConteo, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20
        '----
        iCol = iLeftMargin
        ePrint.Graphics.DrawString("Plantas: " & Format(dCantidadPedido, "###,###,###"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 205
        ePrint.Graphics.DrawString("Plantas: " & Format(dConteoSiembra, "###,###,###"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 400
        ePrint.Graphics.DrawString("Plantas: " & Format(dConteoPlantas, "###,###,###"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20
        '---
        iCol = iLeftMargin
        ePrint.Graphics.DrawString("Tipo Bandeja: " & iTipoBandeja, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 400
        ePrint.Graphics.DrawString("% Terminadas: " & Format(dPlantasTerminadas, "##0.00"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20
        '--
        iCol = iLeftMargin
        ePrint.Graphics.DrawString("Abono Inicial: " & Format(dAbonoInicial, "#,###,##0"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        '---- nave y ubicación
        iLinea += 15
        ePrint.Graphics.DrawString("N° Nave: " & sNumNave, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 15
        ePrint.Graphics.DrawString("Ubicación: " & sUbicacion, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)

        iLinea += 20

        iCol = iLeftMargin
        ePrint.Graphics.DrawLine(Pens.Black, iLeftMargin, iLinea, 595, iLinea) ' Linea Horizontal desde punto inicial izquierdo
        ePrint.Graphics.DrawLine(Pens.Black, iLeftMargin, iLinea, iLeftMargin, iLinea + 65) ' Linea Vertical desde punto inicial izquierdo
        ePrint.Graphics.DrawLine(Pens.Black, 595, iLinea, 595, iLinea + 65) ' linea vertical desde posición punto inicial derecho

        'ePrint.Graphics.DrawLine(Pens.Black, iLeftMargin, iLinea + 45, 595, iLinea + 45)
        iLinea += 10
        ePrint.Graphics.DrawString("RETIRO DE PLANTAS", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 200
        ePrint.Graphics.DrawString("Entregadas: " & Format(dPlantasRetiro, "###,###,###"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 330
        ePrint.Graphics.DrawString("Valor Unit.: " & Format(Math.Round(dPrecioNeto * 1.19, 2, MidpointRounding.AwayFromZero), "###,##0.00"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 430
        ePrint.Graphics.DrawString("Cant. Bandejas: " & Format(dBandRetiro, "##0"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 15
        ePrint.Graphics.DrawString("Observaciones: " & txt_comentarios.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iLeftMargin, iLinea)

        iLinea += 25
        ePrint.Graphics.DrawString("Acuerdos: " & txtAcuerdoCom.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iLeftMargin, iLinea)


        iCol = 10 + iLeftMargin
        iLinea += 15
        ePrint.Graphics.DrawLine(Pens.Black, iLeftMargin, iLinea, 595, iLinea)
        ePrint.Graphics.DrawLine(Pens.Black, iLeftMargin, iLinea, iLeftMargin, iLinea + 50)
        ePrint.Graphics.DrawLine(Pens.Black, 595, iLinea, 595, iLinea + 50)
        ePrint.Graphics.DrawLine(Pens.Black, iLeftMargin, iLinea + 50, 595, iLinea + 50)

        iLinea += 10
        'ePrint.Graphics.DrawString("Total Neto: " & Format(gValorTotalGuiaNeto, "###,###,##0"), New Font(sTipoLetra, iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 200 + iLeftMargin
        'ePrint.Graphics.DrawString("IVA: " & Format(dTotalIVA, "###,###,##0"), New Font(sTipoLetra, iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 300 + iLeftMargin
        ePrint.Graphics.DrawString("Total Guía: " & Format(gValorTotalGuiaIVA, "###,###,##0"), New Font(sTipoLetra, iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 400 + iLeftMargin
        'ePrint.Graphics.DrawString("Abonos: " & Format(dTotalAbonos, "###,###,##0"), New Font(sTipoLetra, iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20
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


        sTitulo = "RETIRO DE BANDEJAS GUIA N° : " & Str(dNumeroGuia)

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
            ePrint.Graphics.DrawString("N° LOTE: " & txt_NumLote.Text, New Font("Arial Narrow", iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iLinea += 60
            iCol = 5
            ePrint.Graphics.DrawString("Fecha: " & txt_FechaGuia.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol = 5
            iLinea += 15
            ePrint.Graphics.DrawString("Cliente: " & txt_Cliente.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol = 300
            ePrint.Graphics.DrawString("Rut: " & txt_RUT_CLI.Text & "-" & txt_DIGRUT.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol = 5
            iLinea += 15
            ePrint.Graphics.DrawString("PEDIDO: " & txt_NumPedido.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol = 200
            ePrint.Graphics.DrawString("Cant. Bandejas Retiradas: " & Format(Val(txt_CantidadBandejasRetiro.Text), "##0"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol = 400
            ePrint.Graphics.DrawString("Tipo Bandeja: " & txt_TipoBandeja.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol = 5
            iLinea += 15
            ePrint.Graphics.DrawString("Nuevas: " & txt_Band_Nuevas.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol = 100
            ePrint.Graphics.DrawString("Usadas: " & txt_Band_Usadas.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol = 200
            ePrint.Graphics.DrawString("Valor Unit.: " & Format(Val(txt_ValorUnitBandeja.Text), "##,##0"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
            iCol = 400
            ePrint.Graphics.DrawString("Valor Total: " & Format(Val(txt_ValorUnitBandeja.Text) * Val(txt_CantidadBandejasRetiro.Text), "##,##0"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
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

    Private Sub Emite_Guia()
        Dim prnTxt As New PrintDocument
        AddHandler prnTxt.PrintPage, AddressOf Me.Imprime_Guia_Entrega


        'prnTxt.PrinterSettings.PrinterName = gPrinter
        'prnTxt.Print()

        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            prnTxt.PrinterSettings.PrinterName = PrintDialog1.PrinterSettings.PrinterName
            prnTxt.Print()
        End If




    End Sub
    Private Sub Imprime_Voucher()
        Dim prnTxt As New PrintDocument
        AddHandler prnTxt.PrintPage, AddressOf Me.Reimpresion_Voucher_Bandeja


        'prnTxt.PrinterSettings.PrinterName = gPrinter
        'prnTxt.Print()

        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            prnTxt.PrinterSettings.PrinterName = PrintDialog1.PrinterSettings.PrinterName
            prnTxt.Print()
        End If
    End Sub

    Private Sub btn_grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_grabar.Click
        Print_Guia_Individual.NumGuia.Text = dNumeroGuia
        Print_Guia_Individual.Show()
    End Sub

    Private Sub Impresion_Guia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        btn_grabar.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub EliminaGuiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminaGuiaToolStripMenuItem.Click
        If Val(txt_NumGuia.Text) > 0 Then
            Elimina_Guia()
        End If
    End Sub
    Private Sub Elimina_Guia()
        Dim sResp = MsgBox("Esta seguro de Eliminar Guía " & txt_NumGuia.Text.ToString, MsgBoxStyle.YesNo, "Guía de Entrega")
        If sResp = MsgBoxResult.Yes Then
            sSsql = "SP_Elimina_GUIA "
            sSsql += txt_NumGuia.Text.ToString
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()

            If datatbl.HasRows Then
                datatbl.Read()
                Select Case datatbl(0)
                    Case 0
                        MsgBox("Guia ha sido Eliminada.", MsgBoxStyle.Information, "Reimpresión de Guías")
                    Case 1
                        MsgBox("No es posible Eliminar Guía " & txt_NumGuia.Text.ToString & ". Guia se encuentra en Estado FACTURADA.", MsgBoxStyle.Exclamation, "Reimpresión de Guías")
                End Select
            End If
            close_conexion()
            Me.Close()
        End If
    End Sub
End Class