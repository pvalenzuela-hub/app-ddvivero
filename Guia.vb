Imports System.Drawing.Printing
Public Class Guia
    Dim gEstado_Actual As Integer
    Dim gValorTotalGuiaNeto As Double
    Dim gValorTotalGuiaIVA As Double
    Dim dPrecioNeto As Double
    Dim dSaldoPlantas As Double
    Dim dBandConteoPlantas As Double
    Dim IdCliente As Double
    Dim IDVendedor As Integer
    Dim dNumeroGuia As Double
    Dim sDireccion As String
    Dim sCiudad As String
    Dim sComuna As String
    Dim sTelefonos As String
    Dim sGiro As String
    Dim sFechaSiembra As String
    Dim dConteoSiembra As Double
    Dim dConteoPlantas As Double
    Dim dPlantasTerminadas As Double
    Dim dPlantasRetiro As Double
    Dim dPromedioPlantas As Decimal
    ' Dim dTotalAbonos As Double

    Dim dAbonoInicial As Double
    Dim dSaldoBandeja As Integer


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Limpia_Campos()
        Buscar_Lote()
        'txt_FechaGuia.Text = Now.Date
    End Sub

    Private Sub Limpia_Campos()
        txt_Familia.Text = ""
        txt_Variedad.Text = ""
        txt_BandConteoPlantas.Text = ""
        txt_BandConteoSiembra.Text = ""
        txt_BandejasPedido.Text = ""
        txt_CantidadBandejasRetiro.Text = ""
        txt_CantPlantasPedido.Text = ""
        txt_FechaConteoPlantas.Text = ""
        txt_FechaConteoSiembra.Text = ""
        txt_FechaEntregaLote.Text = ""
        txt_FechaGuia.Text = ""
        txt_FechaInicioLote.Text = ""
        txt_AvisoCliente.Text = ""
        txt_Cliente.Text = ""
        'txt_clientebuscar.Text = ""
        txt_ConteoPlantas.Text = ""
        txt_ConteoSiembra.Text = ""
        txt_DIGRUT.Text = ""
        txt_estado.Text = ""
        txt_NumPedido.Text = ""
        txt_PlantasRetiro.Text = ""
        txt_PrecioNeto.Text = ""
        txt_PromedioPlantas.Text = ""
        txt_RUT_CLI.Text = ""
        txt_SaldoPlantas.Text = ""
        txt_TipoBandeja.Text = ""
        'txt_TotalAbonos.Text = ""
        txt_TotalLote.Text = ""
        txt_UbicacionLote.Text = ""
        txt_ValorTotalLote.Text = ""
        txt_Vendedor.Text = ""
        txt_Ubicacion.Clear()
        txt_ValorFinalGuia.Clear()
        txt_comentarios.Clear()
        txt_FechaGuia.Clear()
        txt_ValorNetoGuia.Clear()
        txt_IvaGuia.Clear()
        'txt_TotalGuia.Clear()
        txt_Band_Nuevas.Clear()
        txt_Band_Usadas.Clear()
        txt_ValorUnitBandeja.Clear()
        Lbl_Estado_Lote.Text = Nothing

    End Sub

    Private Sub Buscar_Lote()


        'Limpia_Campos()
        open()
        sSsql = "SP_CONSULTA_DETALLE_LOTE " + Str(Val(txt_NumLote.Text))
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then

            txt_FechaGuia.Text = Now.Date

            datatbl.Read()
            gEstado_Actual = datatbl(26)
            dAbonoInicial = datatbl(7)
            REM Abono Inicial Pedido, solo se mostrará en la Guia como REFERENCIA
            txtAbonoInicial.Text = dAbonoInicial.ToString("####,###")

            txt_BandejasPedido.Text = IIf(IsDBNull(datatbl(38)), "0", datatbl(38))

            'dTotalPedido = datatbl(6) + dIVA
            'dSaldoPendiente = dTotalPedido + datatbl(7) - datatbl(8) - datatbl(9)
            txt_Cliente.Text = datatbl(0)
            txt_RUT_CLI.Text = Mid(datatbl(1), 1, 11)
            txt_DIGRUT.Text = Mid(datatbl(1), 12, 1)
            txt_Vendedor.Text = datatbl(2)
            txt_Familia.Text = datatbl(28)
            txt_Variedad.Text = datatbl(29)
            txt_NumPedido.Text = datatbl(23)
            txt_CantPlantasPedido.Text = Format(datatbl(10), "###,###")
            txt_ConteoSiembra.Text = Format(datatbl(16), "###,###")
            txt_TipoBandeja.Text = datatbl(25)
            txt_FechaInicioLote.Text = datatbl(14)
            txt_FechaEntregaLote.Text = datatbl(15)

            dPromedioPlantas = 0

            If IsDBNull(datatbl(17)) Then
                txt_FechaConteoSiembra.Text = ""
                txt_BandConteoSiembra.Text = "0"
                dConteoSiembra = 0
            Else
                dConteoSiembra = datatbl(16)
                txt_FechaConteoSiembra.Text = datatbl(17)
                txt_BandConteoSiembra.Text = Format(IIf(IsDBNull(datatbl(38)), "0", datatbl(38)), "###,###")
                If Not IsDBNull(datatbl(38)) Then
                    dPromedioPlantas = dConteoSiembra / datatbl(38)
                End If
            End If
            txt_ConteoSiembra.Text = Format(dConteoSiembra, "###,###")
            'Información del Lote
            ''verifica si tiene conteo de plantas
            dConteoPlantas = 0


            dBandConteoPlantas = 0
            If Not IsDBNull(datatbl(32)) Then
                If datatbl(32) > 0 Then
                    dConteoPlantas = datatbl(18)
                    dBandConteoPlantas = datatbl(32)
                    dPromedioPlantas = dConteoPlantas / dBandConteoPlantas
                    txt_FechaConteoPlantas.Text = datatbl(19)
                    'txt_BandConteoPlantas.Text = Format(dBandConteoPlantas, "###,###")
                End If
            End If

            If Not IsDBNull(datatbl(76)) Then
                dSaldoBandeja = datatbl(76)
            Else
                dSaldoBandeja = 0
            End If

            txt_CantidadBandejasRetiro.Text = dSaldoBandeja

            txt_ConteoPlantas.Text = Format(dConteoPlantas, "###,##0")
            txt_BandConteoPlantas.Text = Format(dBandConteoPlantas, "###,##0")
            txt_estado.Text = datatbl(22)
            gEstado_Actual = datatbl(26)

            dPrecioNeto = datatbl(11)
            txt_PrecioNeto.Text = Format(dPrecioNeto, "###,##0.00")
            txt_TotalLote.Text = Format(datatbl(6), "###,###,##0")
            txt_Vendedor.Text = datatbl(2)
            txt_AvisoCliente.Text = datatbl(20).ToString
            IdCliente = datatbl(30)
            dSaldoPlantas = datatbl(31)
            txt_PlantasRetiro.Text = datatbl(31)

            REM SE REEMPLAZA POR SALDO BANDEJA
            'If dConteoPlantas > 0 Then
            'txt_CantidadBandejasRetiro.Text = dSaldoBandeja
            'Else
            'txt_CantidadBandejasRetiro.Text = IIf(IsDBNull(datatbl(38)), "0", datatbl(38))
            'End If

            txt_UbicacionLote.Text = IIf(IsDBNull(datatbl(40)), "", datatbl(40))
            txt_Ubicacion.Text = datatbl(52)

            txt_SaldoPlantas.Text = Format(dSaldoPlantas, "###,###,##0")

            sDireccion = datatbl(33)
            sCiudad = datatbl(35).ToString
            sComuna = datatbl(34).ToString
            sTelefonos = datatbl(46).ToString
            sGiro = datatbl(37).ToString

            dPlantasTerminadas = Math.Round(dConteoPlantas / dConteoSiembra * 100, 2, MidpointRounding.AwayFromZero)
            txt_PromedioPlantas.Text = Format(dPromedioPlantas, "###0.00")
            'dTotalAbonos = datatbl(68)
            'txt_TotalAbonos.Text = Format(dTotalAbonos, "###,###,##0")
            txt_comentarios.Text = datatbl(51)
            txt_Band_Usadas.Text = datatbl(69)
            txt_Band_Nuevas.Text = datatbl(70)
            txt_ValorUnitBandeja.Text = datatbl(71)

            Calcula_Total_Guia()

            If dConteoPlantas = 0 Then
                MsgBox("NO ES POSIBLE EMITIR GUIA SIN CONTEO DE PLANTAS O REVISE SI GUIA YA FUE EMITIDA POR EL TOTAL.")
                Limpia_Campos()
                close_conexion()
                Exit Sub
            End If

            Lbl_Estado_Lote.Text = datatbl(22)
            If datatbl(26) <> 3 Then
                MsgBox("Estado del Lote, no permite emitir Guía. Debe actualizar Despacho. Estado del Lote debe corresponder a AVISO CLIENTE.")

                If datatbl(26) = 2 Then
                    Dim sResp = MsgBox("Confirme si desea cambiar estado del Lote a AVISO CLIENTE.", MsgBoxStyle.YesNo, "Emisión de Guías")
                    If sResp = MsgBoxResult.Yes Then
                        open()
                        sSsql = "SP_ACTUALIZA_DETALLE_PEDIDO "
                        sSsql += Val(txt_NumLote.Text).ToString + ","
                        sSsql += "3,"
                        sSsql += "'',"
                        sSsql += "0,"
                        sSsql += "'',"
                        sSsql += "0,"
                        sSsql += "'',"
                        sSsql += "'" + Format(Date.Now, "d") + "',"
                        sSsql += "'AVISO CLIENTE PARA EMISION DE GUIA',"
                        sSsql += "0,"
                        sSsql += "0,"
                        sSsql += "0"

                        '@NumLote int,
                        '@ESTADO int,
                        '@FechaConteoSiembra datetime,
                        '@ConteoSiembra int,
                        '@FechaConteoPlantas datetime,
                        '@ConteoPlantas int,
                        '@FechaEntregaLote datetime,
                        '@FechaAvisoCliente datetime,
                        '@AvisoCliente varchar(100),
                        '@Cant_Band_CInicial int,
                        '@Cant_Celdas_Vacias_Cinicial int,
                        '@Num_Nave int

                        command = connection.CreateCommand
                        command.CommandText = sSsql
                        command.ExecuteNonQuery()

                    End If
                End If


                txt_NumLote.Clear()
                Limpia_Campos()

            End If
        Else
            MsgBox("NO EXISTE N° DE LOTE")
            Limpia_Campos()
        End If

        close_conexion()
    End Sub

    Private Sub Guia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        MsgBox("Recuerde que ahora las Guías deben ser emitidas mediante el proceso de Despacho.", MsgBoxStyle.Exclamation)
        Me.Close()

        Carga_lista_Vendedor(Me.cmb_IDVENDEDOR)
        LOTES_ESTADO_3()

    End Sub
    Private Sub LOTES_ESTADO_3()
        sSsql = "SP_CONSULTA_LOTE_ESTADO_3"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        Cmb_LoteEstado_3.Items.Clear()

        If datatbl.HasRows Then

            While datatbl.Read = True
                Cmb_LoteEstado_3.Items.Add(datatbl(0))
            End While

        End If

        close_conexion()

        If Cmb_LoteEstado_3.Items.Count > 0 Then
            lbl_AlertaLotes.Visible = True
            Cmb_LoteEstado_3.Visible = True
        Else
            lbl_AlertaLotes.Visible = False
            Cmb_LoteEstado_3.Visible = False
        End If


    End Sub
    Private Sub btn_grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_grabar.Click
        Crear_Guia()

    End Sub
    Private Sub Crear_Guia()
        '' EMISION GUIA
        Dim iBandejasRetiradas As Integer
        Dim prnTxt As New PrintDocument
        Dim sResp = MsgBox("Emitir Guía de Entrega", MsgBoxStyle.YesNo, "Emisión Guía de Entrega")

        If sResp = MsgBoxResult.Yes Then
            sResp = MsgBox("Está Seguro de Emitir Guía de Entrega", MsgBoxStyle.YesNo, "Emisión Guía de Entrega")

            If sResp = MsgBoxResult.Yes Then

                If Val(txt_NumLote.Text) = 0 Then
                    MsgBox("N° DE LOTE NO VALIDO")
                    Limpia_Campos()
                    Exit Sub
                End If

                'If gEstado_Actual <> 3 Then
                'MsgBox("LOTE DEBE ESTAR EN ESTADO 3 : AVISO DE CLIENTE")
                'Exit Sub
                'End If

                If dSaldoPlantas <= 0 Then
                    MsgBox("LOTE NO TIENE SALDO DE PLANTAS")
                    Limpia_Campos()
                    Exit Sub
                End If

                If Val(txt_CantidadBandejasRetiro.Text) <= 0 Then
                    MsgBox("CANTIDAD DE BANDEJAS DEBE SER MAYOR A CERO")
                    Limpia_Campos()
                    Exit Sub

                End If

                If gValorTotalGuiaNeto = 0 Then
                    MsgBox("VALOR TOTAL GUIA DEBE SER MAYOR A CERO")
                    Limpia_Campos()
                    Exit Sub
                End If

                If cmb_IDVENDEDOR.Text = "" Then
                    MsgBox("VENDEDOR NO INGRESADO")

                    Exit Sub
                End If

                If txt_Cliente.Text = "" Then
                    MsgBox("CLIENTE NO INGRESADO")
                    Exit Sub
                End If

                If txt_RUT_CLI.Text = "" Then
                    MsgBox("RUT DEL CLIENTE NO INGRESADO")
                    Exit Sub
                End If

                gValorTotalGuiaIVA = Math.Round(gValorTotalGuiaNeto + (gValorTotalGuiaNeto * GIVA / 100), 0, MidpointRounding.AwayFromZero)
                'iBandejasRetiradas = Calculo_Bandejas(dPlantasRetiro, Val(txt_TipoBandeja.Text))
                iBandejasRetiradas = Val(txt_CantidadBandejasRetiro.Text)

                sSsql = "SP_INSERTA_GUIA "
                sSsql += Str(Val(txt_NumLote.Text)) + ","
                sSsql += Str(IdCliente) + ","
                sSsql += Str(ID_Vendedor(Me.cmb_IDVENDEDOR.SelectedIndex)) + ","
                sSsql += "'" + CDate(txt_FechaGuia.Text) + "',"
                sSsql += Str(dPlantasRetiro) + ","
                sSsql += Str(iBandejasRetiradas) + ","
                sSsql += "0" + ","
                sSsql += "'',"
                sSsql += Str(dPrecioNeto) + ","
                sSsql += "'" + "N" + "',"
                sSsql += Str(gValorTotalGuiaNeto) + ","
                sSsql += "0,"
                sSsql += Str(gValorTotalGuiaIVA) + ","
                sSsql += Str(Val(txt_garantiaband.Text))
                open()

                command = connection.CreateCommand()
                command.CommandText = sSsql
                datatbl = command.ExecuteReader()

                datatbl.Read()

                dNumeroGuia = datatbl(0)

                close_conexion()


                AddHandler prnTxt.PrintPage, AddressOf Me.Genera_Guia_Entrega

                'prnTxt.PrinterSettings.PrinterName = gPrinter
                'prnTxt.PrinterSettings.Copies = 2
                'prnTxt.Print()
                If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    prnTxt.PrinterSettings.PrinterName = PrintDialog1.PrinterSettings.PrinterName
                    prnTxt.PrinterSettings.Copies = 2
                    prnTxt.Print()
                    Genera_Voucher()
                End If

                Me.Close()


            End If
        End If

    End Sub
    Private Sub Genera_Voucher()
        Dim prnTxt As New PrintDocument

        AddHandler prnTxt.PrintPage, AddressOf Me.Imprime_Voucher_Bandeja
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            prnTxt.PrinterSettings.PrinterName = PrintDialog1.PrinterSettings.PrinterName
            prnTxt.PrinterSettings.Copies = 1
            prnTxt.Print()
        End If


    End Sub
    Private Sub Genera_Guia_Entrega(ByVal sender As System.Object, ByVal ePrint As PrintPageEventArgs)

        '' Impresión Guia de Entrega
        Dim sTitulo As String
        Dim iTamanoLetra1 As Integer
        Dim iTamanoLetra2 As Integer
        Dim iTamanoLetra3 As Integer
        Dim iLinea As Integer
        Dim iCol As Integer

        Dim dTotalIVA As Double
        Dim dTotalMasIVA As Double

        Dim sTipoLetra As String
        Dim dAbonos As Double
        Dim dValorFinalGuia As Double

        ' dAbonos = dTotalAbonos + dAbonoInicial

        'dPlantasRetiro = Val(txt_PlantasRetiro.Text)
        'dTotalGuia = Math.Round(dPlantasRetiro * dPrecioNeto, 0, MidpointRounding.AwayFromZero)
        dTotalIVA = Math.Round(gValorTotalGuiaNeto * GIVA / 100, 0, MidpointRounding.AwayFromZero)
        dTotalMasIVA = gValorTotalGuiaNeto + dTotalIVA
        dValorFinalGuia = gValorTotalGuiaIVA - dAbonos

        iCol = 5
        iLinea = 25
        sTitulo = "GUIA DE ENTREGA N° : " & Str(dNumeroGuia)

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
        ePrint.Graphics.DrawString("N° LOTE: " & txt_NumLote.Text, New Font("Arial Narrow", iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 60
        iCol = 5
        ePrint.Graphics.DrawString("Fecha: " & Format(Now, "dd-MMM-yyyy"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 350
        ePrint.Graphics.DrawString("Rut: " & Format(Val(txt_RUT_CLI.Text), "###,###,###") & "-" & txt_DIGRUT.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20
        iCol = 5
        ePrint.Graphics.DrawString("Cliente: " & txt_Cliente.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20
        iCol = 5
        ePrint.Graphics.DrawString("Dirección: " & sDireccion, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 350
        ePrint.Graphics.DrawString("Comuna: " & sComuna, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20
        iCol = 5
        ePrint.Graphics.DrawString("Teléfono: " & sTelefonos, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 350
        ePrint.Graphics.DrawString("Ciudad: " & sCiudad, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 5
        iLinea += 20
        ePrint.Graphics.DrawString("Giro: " & sGiro, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        'iLinea += 20
        'ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 750, iLinea)
        iLinea += 20
        ePrint.Graphics.DrawString("Semilla: " & RTrim(txt_Familia.Text) & " Variedad: " & txt_Variedad.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 5
        iLinea += 20
        ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 595, iLinea)
        ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 5, iLinea + 105)
        ePrint.Graphics.DrawLine(Pens.Black, 200, iLinea, 200, iLinea + 105)
        ePrint.Graphics.DrawLine(Pens.Black, 395, iLinea, 395, iLinea + 105)
        ePrint.Graphics.DrawLine(Pens.Black, 595, iLinea, 595, iLinea + 105)
        ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea + 105, 595, iLinea + 105)
        iLinea += 10
        ePrint.Graphics.DrawString("PEDIDO: " & txt_NumPedido.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 200
        ePrint.Graphics.DrawString("SIEMBRA", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 395
        ePrint.Graphics.DrawString("CONTEO FINAL", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20
        '---
        iCol = 5
        ePrint.Graphics.DrawString("Fecha: " & txt_FechaInicioLote.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 205
        ePrint.Graphics.DrawString("Fecha: " & txt_FechaConteoSiembra.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 400
        ePrint.Graphics.DrawString("Fecha: " & txt_FechaConteoPlantas.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20
        '---
        iCol = 5
        ePrint.Graphics.DrawString("Bandejas: " & txt_BandejasPedido.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 205
        ePrint.Graphics.DrawString("Bandejas: " & txt_BandConteoSiembra.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 400
        ePrint.Graphics.DrawString("Bandejas: " & txt_BandConteoPlantas.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20
        '----
        iCol = 5
        ePrint.Graphics.DrawString("Plantas: " & txt_CantPlantasPedido.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 205
        ePrint.Graphics.DrawString("Plantas: " & txt_ConteoSiembra.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 400
        ePrint.Graphics.DrawString("Plantas: " & txt_ConteoPlantas.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20
        '---
        iCol = 5
        ePrint.Graphics.DrawString("Tipo Bandeja: " & txt_TipoBandeja.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 400
        ePrint.Graphics.DrawString("% Terminadas: " & Format(dPlantasTerminadas, "##0.00"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20
        '--
        iCol = 5
        ePrint.Graphics.DrawString("Abono Inicial: " & Format(dAbonoInicial, "#,###,##0"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20

        ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 595, iLinea)
        ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 5, iLinea + 45)
        ePrint.Graphics.DrawLine(Pens.Black, 595, iLinea, 595, iLinea + 45)
        'ePrint.Graphics.DrawLine(Pens.Black, iLeftMargin, iLinea + 45, 595, iLinea + 45)

        'ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 595, iLinea)
        'ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 5, iLinea + 25)
        'ePrint.Graphics.DrawLine(Pens.Black, 595, iLinea, 595, iLinea + 25)
        'ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea + 25, 595, iLinea + 25)
        iLinea += 10
        ePrint.Graphics.DrawString("RETIRO DE PLANTAS", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 200
        ePrint.Graphics.DrawString("Entregadas: " & txt_PlantasRetiro.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 330
        ePrint.Graphics.DrawString("Valor Unit.: " & Format(dPrecioNeto, "###,##0.00"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 430
        ePrint.Graphics.DrawString("Cant. Bandejas: " & Format(Val(txt_CantidadBandejasRetiro.Text), "##0"), New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 15
        ePrint.Graphics.DrawString("Observaciones: " & txt_comentarios.Text, New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, 5, iLinea)

        iCol = 10
        iLinea += 15

        ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 595, iLinea)
        ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea, 5, iLinea + 50)
        ePrint.Graphics.DrawLine(Pens.Black, 595, iLinea, 595, iLinea + 50)
        ePrint.Graphics.DrawLine(Pens.Black, 5, iLinea + 50, 595, iLinea + 50)
        iLinea += 10
        ePrint.Graphics.DrawString("Total Neto: " & Format(gValorTotalGuiaNeto, "###,###,##0"), New Font(sTipoLetra, iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 150
        ePrint.Graphics.DrawString("IVA: " & Format(dTotalIVA, "###,###,##0"), New Font(sTipoLetra, iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iCol = 300
        ePrint.Graphics.DrawString("Total Guía: " & Format(dTotalMasIVA, "###,###,##0"), New Font(sTipoLetra, iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        'iCol = 400
        'ePrint.Graphics.DrawString("Abonos: " & Format(dAbonos, "###,###,##0"), New Font(sTipoLetra, iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 20
        'iCol = 300
        'ePrint.Graphics.DrawString("Total Guía: " & Format(dValorFinalGuia, "###,###,##0"), New Font(sTipoLetra, iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 30
        iCol = 10
        ePrint.Graphics.DrawString("Atendido por: " & cmb_IDVENDEDOR.Text, New Font(sTipoLetra, iTamanoLetra2, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
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
    Private Sub Imprime_Voucher_Bandeja(ByVal sender As System.Object, ByVal ePrint As PrintPageEventArgs)
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

  
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Calcula_Total_Guia()
        Dim dIvaGuia As Double

        'dTotalAbonos
        'ultimos 2 cambios 21/02/2013
        '1) 2 siguientes se comentan
        'dPlantasRetiro = Math.Round(Val(txt_CantidadBandejasRetiro.Text) * dPromedioPlantas, 0, MidpointRounding.AwayFromZero)
        'txt_PlantasRetiro.Text = Format(dPlantasRetiro, "###,###")
        '2) siguiente linea se agrega ==> dPlantasRetiro = txt_PlantasRetiro.Text
        dPlantasRetiro = txt_PlantasRetiro.Text

        gValorTotalGuiaNeto = Math.Round(dPlantasRetiro * dPrecioNeto, 0, MidpointRounding.AwayFromZero)
        txt_ValorTotalLote.Text = Format(gValorTotalGuiaNeto, "###,###,##0")
        txt_ValorNetoGuia.Text = Format(gValorTotalGuiaNeto, "###,###,##0")
        dIvaGuia = Math.Round(gValorTotalGuiaNeto * GIVA / 100, 0, MidpointRounding.AwayFromZero)
        txt_IvaGuia.Text = Format(dIvaGuia, "###,###,##0")
        gValorTotalGuiaIVA = gValorTotalGuiaNeto + dIvaGuia
        'txt_TotalGuia.Text = Format(gValorTotalGuiaIVA, "###,###,##0")
        txt_ValorFinalGuia.Text = Format(gValorTotalGuiaIVA, "###,###,##0")
    End Sub
 

    Private Sub txt_CantidadBandejasRetiro_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_CantidadBandejasRetiro.LostFocus
        Calcula_Total_Guia()
    End Sub

    Private Sub txt_PlantasRetiro_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_PlantasRetiro.LostFocus
        Calcula_Total_Guia()
    End Sub


    Private Sub Cmb_LoteEstado_3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_LoteEstado_3.SelectedIndexChanged
        If Cmb_LoteEstado_3.SelectedIndex > -1 Then
            txt_NumLote.Text = Cmb_LoteEstado_3.Text
            Buscar_Lote()
        End If
    End Sub
End Class