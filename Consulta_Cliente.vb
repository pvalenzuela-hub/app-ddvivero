
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class Consulta_Cliente
    Dim sNumLotes As String
    Dim dPrinterName As New PrintDialog

    '********Impresión Guía
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
    Dim sNumNave As String
    Dim sUbicacion As String

    Private Sub HabilitaCampos()
        txt_NOMBRES.ReadOnly = False
        txt_APELLIDOS.ReadOnly = False
        txt_dircli.ReadOnly = False
        txt_comuna.ReadOnly = False
        txt_ciudad.ReadOnly = False
        txt_telefonos.ReadOnly = False
        txt_email.ReadOnly = False
        txt_FECHANAC.Enabled = True
        TXT_Contacto.ReadOnly = False
        TXT_Giro.ReadOnly = False

        cmb_Sector.Enabled = True
        txtPorcDescuento.ReadOnly = False
        txtNotas.ReadOnly = False
        txt_rutcliente.ReadOnly = False
        txt_digitorut.ReadOnly = False
        txtLineaCredito.ReadOnly = False
        txtLineaCredito.Text = Extrae_comas(txtLineaCredito.Text)
    End Sub
    Private Sub DEShabilitaCampos()
        txt_rutcliente.ReadOnly = True
        txt_digitorut.ReadOnly = True
        txt_NOMBRES.ReadOnly = True
        txt_APELLIDOS.ReadOnly = True
        txt_dircli.ReadOnly = True
        txt_comuna.ReadOnly = True
        txt_ciudad.ReadOnly = True
        txt_telefonos.ReadOnly = True
        txt_email.ReadOnly = True
        txt_FECHANAC.Enabled = False
        TXT_Contacto.ReadOnly = True
        TXT_Giro.ReadOnly = True

        cmb_Sector.Enabled = False
        txtPorcDescuento.ReadOnly = True
        txtNotas.ReadOnly = True
        btnNew.Enabled = True
        btnSave.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnGuias.Enabled = False
        btnUpdate.Enabled = False
        txtLineaCredito.ReadOnly = True
    End Sub
    Private Sub LimpiaCampos()
        gIDCliente = 0
        cmb_Sector.SelectedIndex = -1
        txt_rutcliente.Text = ""
        txt_digitorut.Text = ""
        txt_NOMBRES.Text = ""
        txt_APELLIDOS.Text = ""
        txt_dircli.Text = ""
        txt_comuna.Text = ""
        txt_ciudad.Text = ""
        txt_telefonos.Text = ""
        txt_email.Text = ""
        TXT_Contacto.Text = ""
        TXT_Giro.Text = ""
        txt_FECHANAC.ResetText()
        txt_NombreCliente.Clear()
        txt_clientebuscar.Clear()

        txtPorcDescuento.Clear()
        DataCartola.Rows.Clear()
        txtNotas.Clear()
        txtIdcliente.Clear()
        txt_Deuda.Clear()
        txtLineaCredito.Clear()
        txtEstadoCliente.Clear()
        'cmbVendedor.SelectedIndex = -1
    End Sub
    Private Sub Consulta_Cliente_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        close_conexion()
    End Sub

    Private Sub Consulta_Cliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtVendedor.Text = gUSER
        Me.SP_CONSULTA_FULL_VENDEDORTableAdapter.Connection.ConnectionString = gSOURCE
        Me.SP_CONSULTA_FULL_VENDEDORTableAdapter.Fill(Me.GESTDataSet34.SP_CONSULTA_FULL_VENDEDOR)

        Carga_Sector(Me.cmb_Sector)

        txtUsuario.Text = gUSER
        If gIdPerfil = 1 Then
            btnActivarCliente.Visible = True
        Else
            btnActivarCliente.Visible = False
        End If
    End Sub
    Public Sub CargaCartola(ByVal IdCliente As Integer, ByVal iOpcion As Integer)
        Dim i As Integer
        Dim iTotalReg As Integer = 0
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 0
        RecuperaDatosCliente(IdCliente, True)
        DataCartola.Rows.Clear()
        If iOpcion = 1 Then
            sSsql = "SP_CONSULTA_LOTE_CLIENTE_Vigente " & Str(IdCliente)
        Else
            sSsql = "SP_CONSULTA_Cuenta_LOTE_CLIENTE "
            sSsql += IdCliente.ToString
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            datatbl.Read()
            iTotalReg = datatbl(0)
            close_conexion()
            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = iTotalReg
            ProgressBar1.Value = 0
            sSsql = "SP_CONSULTA_LOTE_CLIENTE " & Str(IdCliente)
        End If

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            While datatbl.Read
                DataCartola.Rows.Add()
                DataCartola.Rows(i).Cells("IdPedidodet").Value = datatbl("IdPedidodet")
                DataCartola.Rows(i).Cells("Nro_Lote_Original").Value = datatbl("Nro_Lote_Original")
                DataCartola.Rows(i).Cells("IdPedido").Value = datatbl("IdPedido")
                DataCartola.Rows(i).Cells("Fecha_Emi").Value = datatbl("Fecha_Emi")
                DataCartola.Rows(i).Cells("DESCRIP").Value = datatbl("DESCRIP")
                DataCartola.Rows(i).Cells("Descripcion").Value = datatbl("Descripcion")
                DataCartola.Rows(i).Cells("Fecha_Ent").Value = datatbl("Fecha_Ent")
                DataCartola.Rows(i).Cells("Cantidad").Value = datatbl("Cantidad")
                DataCartola.Rows(i).Cells("TipoBandeja").Value = datatbl("TipoBandeja")
                DataCartola.Rows(i).Cells("Fecha_Conteo1").Value = datatbl("Fecha_Conteo1")
                DataCartola.Rows(i).Cells("Saldo_Plantas").Value = datatbl("Saldo_Plantas")
                DataCartola.Rows(i).Cells("Saldo_Bandeja").Value = datatbl("Saldo_Bandeja")
                DataCartola.Rows(i).Cells("estado").Value = datatbl("Estado")
                DataCartola.Rows(i).Cells("TOTAL_LOTE").Value = datatbl("TOTAL_LOTE")
                DataCartola.Rows(i).Cells("Vendedor").Value = datatbl("Vendedor")
                DataCartola.Rows(i).Cells("Diasvivero").Value = datatbl("Diasvivero")
                DataCartola.Rows(i).Cells("Fechaautorizacioncliente").Value = datatbl("Fechaautorizacioncliente")
                DataCartola.Rows(i).Cells("Nro_Guias").Value = datatbl("Nro_Guias")
                DataCartola.Rows(i).Cells("Facturas").Value = datatbl("Facturas")
                DataCartola.Rows(i).Cells("Ubicacion").Value = datatbl("Ubicacion")
                DataCartola.Rows(i).Cells("Num_Nave").Value = datatbl("Num_Nave")

                If datatbl("numDiasAutorizacionCliente") <= 0 AndAlso datatbl("numDiasAutorizacionCliente") > -10000 Then
                    DataCartola.Rows(i).DefaultCellStyle.BackColor = Color.Green
                    DataCartola.Rows(i).DefaultCellStyle.ForeColor = Color.White
                End If

                DataCartola.Rows(i).Cells("EsPreventa").Value = datatbl("EsPreventa")

                i += 1
                If iOpcion = 2 Then
                    ProgressBar1.Value = i
                End If
            End While
        End If
        DataCartola.Focus()
        close_conexion()
    End Sub
    Function RecuperaDatosCliente(ByVal Id As Integer, ByVal bshow As Boolean) As Boolean
        Dim sRutCliente As String = ""

        sSsql = "SP_LECTURA_CLIENTE " & Str(Id)
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            If bshow Then
                sRutCliente = datatbl(0)
                txt_rutcliente.Text = Mid(datatbl(0), 1, 11)
                txt_digitorut.Text = Mid(datatbl(0), 12)
                txt_NOMBRES.Text = datatbl(1)
                txt_APELLIDOS.Text = datatbl(2)
                txt_dircli.Text = datatbl(3).ToString
                txt_comuna.Text = datatbl(4).ToString
                txt_ciudad.Text = datatbl(5).ToString
                txt_telefonos.Text = datatbl(6).ToString
                txt_email.Text = datatbl(7).ToString
                txt_FECHANAC.Text = datatbl(8).ToString
                TXT_Contacto.Text = datatbl(9).ToString
                TXT_Giro.Text = datatbl(10).ToString
                cmb_Sector.Text = datatbl(12)
                txt_SaldoAbonos.Text = Format(datatbl(13), "$ ###,###,##0")
                txt_Deuda.Text = Format(datatbl(14), "$ ###,###,##0")
                txtVendedor.Text = datatbl(15)
                txtPorcDescuento.Text = datatbl(16)
                txtNotas.Text = IIf(IsDBNull(datatbl(17)), "", datatbl(17))
                txt_digitorut.Text = datatbl(18)
                txtLineaCredito.Text = Format(datatbl("LineaCredito"), "$ ###,###,##0")
                txtEstadoCliente.Text = datatbl("EstadoCliente")
                txtTotalLoteActivo.Text = Format(datatbl("TotalLoteActivo"), "$ ###,###,##0")
                txtAbonoPendiente.Text = Format(datatbl("TotalAbonoPendiente"), "$ ###,###,##0")

                If Trim(datatbl("EstadoCliente")) = "BLOQUEADO" Then
                    btnActivarCliente.Visible = True
                Else
                    btnActivarCliente.Visible = False
                End If
            End If
            'gRUTCLIENTE = datatbl(0)
            bOK = True
        Else
            bOK = False
        End If
        datatbl.Close()
        'RecuperaDatosCliente = bOK
        close_conexion()
        Return bOK
    End Function

    Function ValidarDatos() As Boolean
        Dim sMensaje As String
        bOK = True
        sMensaje = ""
        If txt_rutcliente.Text = "" Then
            bOK = False
            sMensaje = "Debe ingresar RUT del Cliente"
        End If
        If txt_NOMBRES.Text = "" Then
            bOK = False
            sMensaje = "Debe Ingresar Nombres del Cliente"
        End If
        If txt_APELLIDOS.Text = "" Then
            bOK = False
            sMensaje = "Debe Ingresar Apellidos del Cliente"
        End If
        If txt_dircli.Text = "" Then
            bOK = False
            sMensaje = "Debe ingresar Dirección del Cliente"
        End If
        If txt_telefonos.Text = "" Then
            bOK = False
            sMensaje = "Debe ingresar al menos un Teléfono de Contacto"
        End If
        If Me.cmb_Sector.SelectedIndex = -1 Then
            bOK = False
            sMensaje = "Debe seleccionar sector"
        End If
        'If cmb_Vendedor.SelectedIndex = -1 Then
        '    bOK = False
        '    sMensaje = "Debe Seleecionar Vendedor"
        'End If

        If Not bOK Then
            MessageBox.Show(sMensaje)
        End If
        Return bOK
    End Function

    Function FormateaRUT() As String
        Dim sRUT As String
        sRUT = Format(Val(Mid(txt_rutcliente.Text, 1, 11)), "00000000000") + UCase(txt_digitorut.Text)

        FormateaRUT = sRUT

    End Function
    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        gNOMBRE = txt_clientebuscar.Text
        gQuienLlama = 7
        If chkCliente.Checked = True Then
            BusquedaCliente.chkIncluyePrimerNombre.Checked = True
        Else
            BusquedaCliente.chkIncluyePrimerNombre.Checked = False
        End If
        BusquedaCliente.Visible = True
    End Sub
    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If gIDCliente <> 0 Then
            CargaCartola(gIDCliente, 2)
        End If
    End Sub

    Private Sub DataCartola_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataCartola.CellDoubleClick
        If e.ColumnIndex > 0 Then
            Dim iNumLote As Integer
            Dim iFilaActual As Integer

            iFilaActual = DataCartola.CurrentRow.Index
            iNumLote = DataCartola.Rows(iFilaActual).Cells("IdPedidodet").Value
            Cambio_Estado.txt_NumLote.ReadOnly = True
            Cambio_Estado.Button1.Enabled = False
            Cambio_Estado.ArchivoToolStripMenuItem.Enabled = False
            Cambio_Estado.txt_NumLote.Text = iNumLote
            Call Cambio_Estado.EjecutaConsultaLote()
            Cambio_Estado.Show()
        End If

    End Sub

    Private Sub DataCartola_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataCartola.CellBeginEdit
        If e.ColumnIndex = 0 Then
            If DataCartola.Rows(e.RowIndex).Cells(0).Value = True Then
                If Not IsDBNull(DataCartola.Rows(e.RowIndex).Cells("Nro_Guias").Value) Then
                    If DataCartola.Rows(e.RowIndex).Cells("Nro_Guias").Value <> Nothing Then
                        MsgBox("Lote tiene Guía Emitida.")
                        DataCartola.Rows(e.RowIndex).Cells(0).Value = False
                    End If

                End If
            End If
        End If

    End Sub

    Private Sub DataCartola_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataCartola.CellEndEdit
        If e.ColumnIndex = 0 Then
            If DataCartola.Rows(e.RowIndex).Cells("guia").Value = True Then
                If Not IsDBNull(DataCartola.Rows(e.RowIndex).Cells("Nro_Guias").Value) Then

                    If DataCartola.Rows(e.RowIndex).Cells("Nro_Guias").Value <> Nothing Then
                        MsgBox("Lote tiene Guía Emitida.")
                        DataCartola.Rows(e.RowIndex).Cells("Nro_Guias").Value = False
                    End If
                End If
            End If
        End If
        If e.ColumnIndex = 1 Then ' Marca/Descmarca como Preventa
            If DataCartola.Rows(e.RowIndex).Cells("Saldo_Bandeja").Value = 0 _
                And DataCartola.Rows(e.RowIndex).Cells("EsPreventa").Value = True Then
                MsgBox("Lote no tiene Saldo de Bandejas!!", MsgBoxStyle.Exclamation)
                DataCartola.Rows(e.RowIndex).Cells("EsPreventa").Value = False
            End If
        End If
    End Sub
    Private Sub Crear_Guia()
        REM ************
        REM EMISION GUIA
        REM ************
        Dim idCliente As Integer
        Dim idVendedor As Integer
        Dim dFechaGuia As Date = Now
        Dim dPlantasRetiro As Double
        Dim dSaldoBandeja As Double
        Dim dPrecioNeto As Double
        Dim dValorNetoGuia As Double
        Dim dTotalAbonos As Double
        Dim dValorTotalGuiaIVA As Double

        REM Consulta datos del Lote
        open()
        sSsql = "SP_CONSULTA_DETALLE_LOTE "
        sSsql += iNumLote.ToString

        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            idCliente = datatbl(30)
            idVendedor = gIdVendedor
            dPlantasRetiro = datatbl(31)
            dSaldoBandeja = datatbl(76)
            dPrecioNeto = datatbl(11)
            dValorNetoGuia = Math.Round(dPlantasRetiro * dPrecioNeto, 0, MidpointRounding.AwayFromZero)
            dTotalAbonos = datatbl(68)
            dValorTotalGuiaIVA = Math.Round(dValorNetoGuia + (dValorNetoGuia * GIVA / 100), 0, MidpointRounding.AwayFromZero)
            sNumNave = datatbl(40)
            sUbicacion = datatbl(52)
        Else

            MsgBox("No Existe Lote N°:" & iNumLote.ToString)
            close_conexion()
            Exit Sub
        End If

        close_conexion()

        sSsql = "SP_INSERTA_GUIA "
        sSsql += iNumLote.ToString & ","
        sSsql += idCliente.ToString & ","
        sSsql += idVendedor.ToString & ","
        sSsql += "'" + dFechaGuia.Date & "',"
        sSsql += dPlantasRetiro.ToString & ","
        sSsql += dSaldoBandeja.ToString & ","
        sSsql += "0" & ","
        sSsql += "'',"
        sSsql += Reemplaza_Comas(dPrecioNeto.ToString) & ","
        sSsql += "'" & "N" & "',"
        sSsql += dValorNetoGuia.ToString & ","
        sSsql += "0,"
        sSsql += dValorTotalGuiaIVA.ToString & ","
        sSsql += "0"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        datatbl.Read()
        iNumGuia = datatbl(0)
        close_conexion()
        Print_Guia_Individual.NumGuia.Text = iNumGuia
        Print_Guia_Individual.Show()
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

    Private Sub chkHistoriaLote_CheckedChanged(sender As Object, e As EventArgs) Handles chkHistoriaLote.CheckedChanged
        If chkHistoriaLote.Checked Then
            If gIDCliente <> 0 Then
                CargaCartola(gIDCliente, 2)
            End If
        Else
            If gIDCliente <> 0 Then
                CargaCartola(gIDCliente, 1)
            End If
        End If
    End Sub

    Private Sub txtIdcliente_TextChanged(sender As Object, e As EventArgs) Handles txtIdcliente.TextChanged
        If txtIdcliente.Text <> Nothing Then
            LecturaCliente(Val(txtIdcliente.Text))
        End If
    End Sub

    Private Sub LecturaCliente(idcliente As Integer)
        If idcliente <> Nothing Then
            CargaCartola(idcliente, 1)
            DEShabilitaCampos()

            btnSave.Enabled = True
            btnEdit.Enabled = True
            btnDelete.Enabled = True
            btnGuias.Enabled = True
            btnUpdate.Enabled = True
        End If

    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Preventa_Popup.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Val(gIDCliente) = 0 Then
            MsgBox("Seleccione Cliente!")
        Else
            open()
            command = connection.CreateCommand()
            sSsql = "SP_Actualiza_Abono_Inicial_Cliente " & gIDCliente.ToString()
            command.CommandText = sSsql
            command.ExecuteNonQuery()
            close_conexion()
            MsgBox("Abono Inicial ha sido Actualizado!")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnGuias.Click
        Dim i As Integer
        sNumLotes = ""
        For i = 0 To DataCartola.Rows.Count - 1
            If DataCartola.Rows(i).Cells(0).Value = True And DataCartola.Rows(i).Cells("Nro_Guias").Value = Nothing Then
                If sNumLotes <> "" Then
                    sNumLotes += "," & DataCartola.Rows(i).Cells("IdPedidodet").Value.ToString
                Else
                    sNumLotes += DataCartola.Rows(i).Cells("IdPedidodet").Value.ToString
                End If
            End If
        Next
        txtSerieLotes.Text = sNumLotes
        If txtSerieLotes.Text = "" Then
            MsgBox("No existen Lotes seleccionados para Emisión de Guías.")
        Else
            Dim sResp = MsgBox("Confirmar Emisión de Guías", MsgBoxStyle.YesNo, "Confirma Emisión de Guías")
            If sResp = MsgBoxResult.Yes Then
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                For i = 0 To DataCartola.Rows.Count - 1
                    If DataCartola.Rows(i).Cells(0).Value = True Then
                        iNumLote = DataCartola.Rows(i).Cells("IdPedidodet").Value
                        Crear_Guia()
                    End If
                Next
                CargaCartola(gIDCliente, 1)
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' grabar datos del cliente
        Dim sRUT As String
        sRUT = FormateaRUT()
        If ValidarDatos() Then
            Try
                open()
                sSsql = "SP_GRABA_CLIENTE_NEW "
                sSsql += gIDCliente.ToString() + ","
                sSsql += "'" & sRUT & "','" & UCase(txt_NOMBRES.Text) & "','" & UCase(txt_APELLIDOS.Text) & "','" & txt_dircli.Text & "',"
                sSsql += "'" & txt_comuna.Text & "','" & txt_ciudad.Text & "','" & txt_telefonos.Text.ToString & "',"
                sSsql += "'" & txt_email.Text & "','" & CDate(txt_FECHANAC.Text) & "',"
                sSsql += "'" & gUSER & "','" & TXT_Contacto.Text & "','" & TXT_Giro.Text & "',"
                sSsql += Str(TS_ID(Me.cmb_Sector.SelectedIndex)) & ","
                sSsql += "'" & txtVendedor.Text & "',"
                If txtPorcDescuento.Text = Nothing Then
                    txtPorcDescuento.Text = "0"
                End If
                sSsql += Reemplaza_Comas(txtPorcDescuento.Text) & ","

                sSsql += "'" & txtNotas.Text & "',"
                sSsql += Val(txtLineaCredito.Text).ToString

                command = connection.CreateCommand()
                command.CommandText = sSsql
                command.ExecuteNonQuery()
                LimpiaCampos()
                DEShabilitaCampos()

            Catch ex As Exception
                MsgBox("No es posible Actualizar datos del Cliente. Revise si el RUT ya existe." + ex.Message)
            End Try
            close_conexion()
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        LimpiaCampos()
        txt_rutcliente.ReadOnly = False
        txt_digitorut.ReadOnly = False
        HabilitaCampos()
        txt_rutcliente.Focus()
        btnSave.Enabled = True
        txtVendedor.Text = gUSER
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If ValidarDatos() Then
            HabilitaCampos()
            txt_APELLIDOS.Focus()
            btnEdit.Enabled = False
            btnDelete.Enabled = False

        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If gIDCliente > 0 Then
            Dim sResp = MsgBox("Confirmar Eliminación de Cliente", MsgBoxStyle.YesNo, "Elimina Cliente")
            If sResp = MsgBoxResult.Yes Then
                sSsql = "SP_ELIMINA_CLIENTE_NEW " + gIDCliente.ToString()
                open()
                command = connection.CreateCommand()
                command.CommandText = sSsql
                datatbl = command.ExecuteReader()
                If datatbl.HasRows Then
                    datatbl.Read()
                    If datatbl(0) = 0 Then
                        MsgBox("Cliente ha sido Eliminado!!!")
                    Else
                        MsgBox("Cliente No puede ser Eliminado porque tiene pedidos.")
                    End If
                End If
                LimpiaCampos()
                DEShabilitaCampos()
                close_conexion()
            End If
        End If
    End Sub

    Private Sub txtLineaCredito_GotFocus(sender As Object, e As EventArgs) Handles txtLineaCredito.GotFocus
        txtLineaCredito.Select()
    End Sub

    Private Sub btnActivarCliente_Click(sender As Object, e As EventArgs) Handles btnActivarCliente.Click
        Dim idCliente As Integer = Val(txtIdcliente.Text)
        If idCliente > 0 Then
            Try
                open()
                Dim sql As String = "UPDATE CLIENTE " &
                                "SET EstadoclienteId = 1, " &
                                "    FechaCambiaEstado = GETDATE(), " &
                                "    UsuarioCambiaEstado = @usuario " &
                                $"WHERE IdCliente = {idCliente}"

                Dim command As SqlCommand = connection.CreateCommand()
                command.CommandText = sql
                command.Parameters.AddWithValue("@usuario", gUSER) ' gUser = usuario público que autoriza

                Dim rowsAffected = command.ExecuteNonQuery()

                MessageBox.Show($"Se activó cliente correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al activar cliente(s): " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                close_conexion()
                LecturaCliente(idCliente)
            End Try
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If DataCartola.Rows.Count > 0 Then
            ImprimeLotesCliente.txtIdCliente.Text = txtIdcliente.Text
            ImprimeLotesCliente.Show()
        End If
    End Sub
End Class