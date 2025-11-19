Imports System.Drawing.Printing
Imports System.Windows.Controls

Public Class DepositoDoc
    Dim dLastValue As Double
    Dim gFechaContable As Date
    Dim gAbonoActual As Double
    Dim gCliente As String
    Dim gRUT As String
    Dim gIdCliente As Integer

    Private Sub Consulta_Documentos()
        Dim sFiltro As String = ""
        Dim i As Integer = 0

        If chk_Rut.Checked Then
            If txtIdCliente.Text = Nothing Then
                MsgBox("Debe Seleccionar Cliente si ha seleccionado el filtro Cliente", MsgBoxStyle.Critical)
                Exit Sub
            End If
            sFiltro = "'" & txtIdCliente.Text.ToString() & "',"
        Else
            sFiltro = "Null,"
        End If

        If Chk_Fpago.Checked Then
            If cmb_TIPO_PAGO.SelectedIndex = -1 Then
                MsgBox("Debe Seleccionar forma de pago si ha seleccionado el filtro Forma de Pago", MsgBoxStyle.Critical)
                Exit Sub
            End If

            sFiltro += "'" & cmb_TIPO_PAGO.Text & "',"
        Else
            sFiltro += "Null,"
        End If

        If Chk_Fechas.Checked Then
            sFiltro += "'" & dtp_fecha1.Value + "','" & dtp_fecha2.Value + "'"
        Else
            sFiltro += "Null,Null"
        End If

        sSsql = "SP_Documentos_En_Cartera "
        sSsql += sFiltro

        GrillaPagos.Rows.Clear()

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            While datatbl.Read
                GrillaPagos.Rows.Add()
                GrillaPagos.Rows(i).Cells("numdocpago").Value = datatbl("Num_Doc_Pago")
                GrillaPagos.Rows(i).Cells("cliente").Value = datatbl("cliente")
                GrillaPagos.Rows(i).Cells("formapago").Value = datatbl("FormaPago")
                GrillaPagos.Rows(i).Cells("fechavcto").Value = datatbl("FechaVcto")
                GrillaPagos.Rows(i).Cells("Valor").Value = Format(datatbl("Valor"), "###,###,###")
                GrillaPagos.Rows(i).Cells("pagos").Value = Format(datatbl("Pagos"), "###,###,###")
                GrillaPagos.Rows(i).Cells("saldo").Value = Format(datatbl("Saldo"), "###,###,###")
                GrillaPagos.Rows(i).Cells("IdCliente").Value = datatbl("IdCliente")
                i += 1
            End While
        End If
        close_conexion()
    End Sub

    Private Sub DepositoDoc_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Carga_FormaPago(Me.cmb_TIPO_PAGO, 2)
        Carga_Full_Bancos(Me.cmb_Banco)
    End Sub
    Private Sub txt_ValorDeposito_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Val(txt_ValorDeposito.Text) > 0 Then
            If Val(txt_ValorDeposito.Text) > dLastValue Then
                MsgBox("Valor Depósito no puede ser mayor a valor documento", MsgBoxStyle.Critical)
                txt_ValorDeposito.Text = Nothing
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim iCurrentFila As Integer
        If GrillaPagos.Rows.Count > 0 Then
            iCurrentFila = GrillaPagos.CurrentCell.RowIndex
            txtNumDocPago.Text = GrillaPagos.Rows(iCurrentFila).Cells("numdocpago").Value
            dLastValue = Extrae_comas(GrillaPagos.Rows(iCurrentFila).Cells("Valor").Value)
            txt_ValorDeposito.Text = Extrae_comas(GrillaPagos.Rows(iCurrentFila).Cells("saldo").Value)
            'txt_Glosa.Text = RTrim(GrillaPagos.Rows(iCurrentFila).Cells(3).Value) + " " + RTrim(GrillaPagos.Rows(iCurrentFila).Cells(4).Value)
            txt_FPago.Text = GrillaPagos.Rows(iCurrentFila).Cells("formapago").Value
            txtIdClienteDocumento.Text = GrillaPagos.Rows(iCurrentFila).Cells("IdCliente").Value
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Val(txtNumDocPago.Text) <= 0 Then
            MsgBox("Debe Seleccionar Documento para el Depósito", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Val(txt_ValorDeposito.Text) = 0 Then
            MsgBox("Debe Ingresar Valor a Depositar", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If cmb_Banco.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Cuenta Bancaria", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If txt_Glosa.Text = Nothing Or Trim(txt_Glosa.Text) = "" Then
            MsgBox("Debe ingresar glosa.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Val(txtIdClienteDocumento.Text) = 0 Then
            MsgBox("Debe Seleccionar documento a Depositar!!!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If txt_FPago.Text = Nothing OrElse txt_FPago.Text = "" Then
            MsgBox("Debe Seleccionar documento a Depositar!!!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        '@Num_Doc_Pago varchar(50),
        '@IdCliente int,
        '@Fecha_Deposito datetime,
        '@Valor_Depositado float,
        '@Banco varchar(50),
        '@DESCRIPCION varchar(50),
        '@Glosa varchar(100)


        sSsql = "SP_Actualiza_Documentos_X_Cobrar_Nuevo "
        sSsql += Val(txtNumDocPago.Text).ToString() & ","
        sSsql += txtIdClienteDocumento.Text.ToString() & ","
        sSsql += "'" & Format(dtp_FechaDeposito.Value, "dd/MM/yyyy") & "',"
        sSsql += Val(txt_ValorDeposito.Text).ToString & ","
        sSsql += "'" & cmb_Banco.Text & "',"
        sSsql += "'" & txt_FPago.Text & "',"
        sSsql += "'" & txt_Glosa.Text & "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()
        close_conexion()

        ' Imprime Comprobante de pago
        If Val(txt_ValorDeposito.Text) > 0 AndAlso Val(txtIdCliente.Text) > 0 Then
            Dim sResp = MsgBox("Imprime Comprobante de Pago?", MsgBoxStyle.YesNo)
            If sResp = MsgBoxResult.Yes Then
                gIdCliente = Val(txtIdCliente.Text)
                Emision_Comprobante(Val(txt_ValorDeposito.Text), Now.Date)
            End If
        End If


        MsgBox("Depósito Actualizado.", MsgBoxStyle.Information)
        txt_Glosa.Clear()
        txtNumDocPago.Clear()
        txt_ValorDeposito.Clear()
        cmb_Banco.SelectedIndex = -1
        dLastValue = 0

        Consulta_Documentos()
    End Sub


    Private Sub Emision_Comprobante(AbonoActual As Double, FechaContable As Date)
        gAbonoActual = AbonoActual
        gFechaContable = FechaContable
        Dim prnTxt As New PrintDocument
        AddHandler prnTxt.PrintPage, AddressOf Me.Genera_Comprobante_Pago
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            prnTxt.PrinterSettings.PrinterName = PrintDialog1.PrinterSettings.PrinterName
            prnTxt.PrinterSettings.Copies = 1
            prnTxt.Print()
        End If
    End Sub

    Private Sub Genera_Comprobante_Pago(ByVal sender As System.Object, ByVal ePrint As PrintPageEventArgs)
        Dim sTitulo As String
        Dim iTamanoLetra1 As Integer
        Dim iTamanoLetra2 As Integer
        Dim iTamanoLetra3 As Integer
        Dim iLinea As Integer
        Dim iCol As Integer
        Dim sTipoLetra As String
        Dim sLogo As String
        Dim sTexto00 As String
        Dim sTexto01 As String
        Dim sTexto02 As String
        Dim sTexto03 As String
        Dim sTexto04 As String
        Dim sTexto05 As String
        Dim sTexto06 As String
        RescataCliente(gIdCliente)
        sTexto00 = "Con fecha " & Format(gFechaContable, "dd") & " de " & Format(gFechaContable, "MMMM") & " de " & Format(gFechaContable, "yyyy")
        sTexto01 = "Hemos recibido del Señor;"
        sTexto02 = gCliente
        sTexto03 = "RUT: " & gRUT
        sTexto04 = "La suma de $" & Format(gAbonoActual, "###,###,###")
        sTexto05 = "por concepto de Abono : " & txt_FPago.Text & " N°:" & txtNumDocPago.Text
        sTexto06 = ""
        iCol = 10
        sTitulo = "RECIBO DE DINERO"
        sLogo = gDataEmp
        iTamanoLetra1 = 8
        iTamanoLetra2 = 10
        iTamanoLetra3 = 8
        sTipoLetra = "Arial"
        ePrint.Graphics.DrawString(sLogo, New Font("High Tower Text", 14, FontStyle.Bold, GraphicsUnit.Point), Brushes.Green, 0, 1)
        iLinea += 25
        ePrint.Graphics.DrawString(gDataEmpFono, New Font("Arial Narrow", iTamanoLetra1, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 30
        iCol = 30
        ePrint.Graphics.DrawString(sTitulo, New Font("Arial Narrow", iTamanoLetra3, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 40
        iCol = 0
        ePrint.Graphics.DrawString(sTexto00, New Font(sTipoLetra, iTamanoLetra3, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 30
        ePrint.Graphics.DrawString(sTexto01, New Font(sTipoLetra, iTamanoLetra3, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 15
        ePrint.Graphics.DrawString(sTexto02, New Font("Arial Narrow", iTamanoLetra3, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 15
        ePrint.Graphics.DrawString(sTexto03, New Font(sTipoLetra, iTamanoLetra3, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 15
        ePrint.Graphics.DrawString(sTexto04, New Font(sTipoLetra, iTamanoLetra3, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 15
        ePrint.Graphics.DrawString(sTexto05, New Font(sTipoLetra, iTamanoLetra3, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 30
        ePrint.Graphics.DrawString(sTexto06, New Font(sTipoLetra, iTamanoLetra3, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol, iLinea)
        iLinea += 30
        ePrint.Graphics.DrawString(".....................................", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol + 20, iLinea)
        iLinea += 10
        ePrint.Graphics.DrawString("Firma Cliente", New Font(sTipoLetra, iTamanoLetra1, FontStyle.Regular, GraphicsUnit.Point), Brushes.Black, iCol + 35, iLinea)
        ePrint.HasMorePages = False
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        gNOMBRE = txt_nombre.Text
        BusquedaCliente.chkIncluyePrimerNombre.Checked = chk_Rut.Checked
        gQuienLlama = 5
        'GrillaPagos.Rows.Clear()
        BusquedaCliente.Visible = True
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Consulta_Documentos()
    End Sub

    Public Sub RescataCliente(IdCliente As Integer)

        open()
        command = connection.CreateCommand()
        sSsql = "SELECT FORMAT(CONVERT(numeric,SUBSTRING(RUT,1,11)),'##,###,###,###')+'-'+SUBSTRING(RUT,12,1) rutcli,rtrim(NOMBRE)+' '+APELLIDO FROM Cliente "
        sSsql += "WHERE IdCLiente=" & IdCliente.ToString
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        datatbl.Read()
        gRUT = datatbl(0)
        gCliente = datatbl(1)
        close_conexion()

    End Sub
End Class