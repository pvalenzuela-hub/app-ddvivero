Public Class Cmpbt_Ctbl
    Dim gTipoCuenta As String
    Dim gTipoReferCta As Integer
    Dim gNumCpmbte As Double
    Dim gCompOK As Boolean
    Dim gCompValido As Boolean
    Private Sub Cmpbt_Ctbl_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Carga_Cuenta_Imputable(Me.cmb_CuentasImputables)
        'Carga_Centro_Costo(Me.cmb_CCosto)

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Agrega_Asiento()
    End Sub
    Private Sub Agrega_Asiento()
        Dim i As Integer


        Select Case gTipoReferCta
            Case 1
                REM RUT CLIENTE
                If rdb_RutCLi.Checked = False Then
                    MsgBox("Debe Registrar Datos del Cliente para Cuenta seleccionada.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                If rdb_RutCLi.Checked = True Then
                    If txt_Rut.Text = Nothing Then
                        MsgBox("Debe registrar RUT del CLiente para Cuenta seleccionada.", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If
                End If
                If cmb_Tipo_Doc.SelectedIndex = -1 Then
                    MsgBox("Debe Seleccionar Tipo de Documento, para registrar movimientos en esta cuenta contable.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                If txt_Num_Doc.Text = Nothing Then
                    MsgBox("Debe Especificar N° de documento asociado al movimiento contable para esta cuenta.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

            Case 2
                REM RUT PROVEEDOR
                If rdb_RutPRO.Checked = False Then
                    MsgBox("Debe Registrar Datos del Proveedor para cuenta seleccionada.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                If rdb_RutPRO.Checked = True Then
                    If txt_Rut.Text = Nothing Then
                        MsgBox("Debe registrar RUT del Proveedor para cuenta seleccionada.", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If
                End If
                If cmb_Tipo_Doc.SelectedIndex = -1 Then
                    MsgBox("Debe Seleccionar Tipo de Documento, para registrar movimientos en esta cuenta contable.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                If txt_Num_Doc.Text = Nothing Then
                    MsgBox("Debe Especificar N° de documento asociado al movimiento contable para esta cuenta.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            Case 3
                REM RUT PERSONAL
                If rdb_Personal.Checked = False Then
                    MsgBox("Debe Registrar datos del Personal para la cuenta seleccionada.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                If txt_Rut.Text = Nothing Then
                    MsgBox("Debe registrar RUT del personal para la cuenta seleccionada.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            Case 4
                REM VENCIMIENTOS POR PAGAR A PROVEEDORES
                If dtp_FechaVcto.Value = dtp_FechaVcto.MinDate Then
                    MsgBox("Ingrese Fecha de Vencimiento.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                If cmb_Tipo_Doc.SelectedIndex = -1 Then
                    MsgBox("Debe Seleccionar Tipo de Documento, para registrar movimientos en esta cuenta contable.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                If txt_Num_Doc.Text = Nothing Then
                    MsgBox("Debe Especificar N° de documento asociado al movimiento contable para esta cuenta.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            Case 5
                REM VENCIMIENTOS POR COBRAR A CLIENTES
                If dtp_FechaVcto.Value = dtp_FechaVcto.MinDate Then
                    MsgBox("Ingrese Fecha de Vencimiento.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                If cmb_Tipo_Doc.SelectedIndex = -1 Then
                    MsgBox("Debe Seleccionar Tipo de Documento, para registrar movimientos en esta cuenta contable.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                If txt_Num_Doc.Text = Nothing Then
                    MsgBox("Debe Especificar N° de documento asociado al movimiento contable para esta cuenta.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If


        End Select

        If txt_GlosaMovimiento.Text = Nothing Then
            MsgBox("Debe Ingresar Glosa Movimiento", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If txt_CtaTble.Text = Nothing Then
            MsgBox("Debe Ingresar Cuenta Contable", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Val(txt_MontoDebe.Text) = 0 And Val(txt_MontoHaber.Text) = 0 Then
            MsgBox("Debe Ingresar Monto Asiento.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Val(txt_MontoDebe.Text) > 0 And Val(txt_MontoHaber.Text) > 0 Then
            MsgBox("Solo se puede ingresar valores al Debe o al Haber a la vez.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If gTipoCuenta = "I" Or gTipoCuenta = "E" Then
            If txt_DescripCCosto.Text = Nothing Then
                MsgBox("Debe Seleccionar cuenta de Centro de Costo.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If



        If txt_DescripCuenta.Text = Nothing Then
            MsgBox("Debe Ingresar Cuenta Contable válida", MsgBoxStyle.Information)
            Exit Sub
        End If


        Try
            DataAsiento.Rows.Add()
            i = DataAsiento.Rows.Count - 1
            DataAsiento.Rows(i).Cells(0).Value = 0
            DataAsiento.Rows(i).Cells(1).Value = txt_CtaTble.Text
            DataAsiento.Rows(i).Cells(2).Value = txt_DescripCuenta.Text
            DataAsiento.Rows(i).Cells(3).Value = txt_MontoDebe.Text
            DataAsiento.Rows(i).Cells(4).Value = txt_MontoHaber.Text
            DataAsiento.Rows(i).Cells(5).Value = txt_Ccosto.Text
            DataAsiento.Rows(i).Cells(6).Value = txt_DescripCCosto.Text
            DataAsiento.Rows(i).Cells(8).Value = txt_GlosaMovimiento.Text

            Select Case gTipoReferCta
                Case 1
                    DataAsiento.Rows(i).Cells(7).Value = txt_Rut.Text
                    DataAsiento.Rows(i).Cells(9).Value = cmb_Tipo_Doc.Text
                    DataAsiento.Rows(i).Cells(10).Value = txt_Num_Doc.Text
                Case 2
                    DataAsiento.Rows(i).Cells(7).Value = txt_Rut.Text
                    DataAsiento.Rows(i).Cells(9).Value = cmb_Tipo_Doc.Text
                    DataAsiento.Rows(i).Cells(10).Value = txt_Num_Doc.Text
                Case 3
                    DataAsiento.Rows(i).Cells(7).Value = txt_Rut.Text
                Case 4
                    DataAsiento.Rows(i).Cells(9).Value = cmb_Tipo_Doc.Text
                    DataAsiento.Rows(i).Cells(10).Value = txt_Num_Doc.Text
                    DataAsiento.Rows(i).Cells(11).Value = dtp_FechaVcto.Value
                Case 5
                    DataAsiento.Rows(i).Cells(9).Value = cmb_Tipo_Doc.Text
                    DataAsiento.Rows(i).Cells(10).Value = txt_Num_Doc.Text
                    DataAsiento.Rows(i).Cells(11).Value = dtp_FechaVcto.Value

            End Select
         

            Total_Cpmbte()

            txt_Ccosto.Clear()
            txt_CtaTble.Clear()
            txt_MontoDebe.Clear()
            txt_MontoHaber.Clear()
            txt_DescripCCosto.Clear()
            txt_DescripCuenta.Clear()
            txt_Rut.Clear()
            txt_clientebuscar.Clear()
            txt_NombreCliente.Clear()
            txt_GlosaMovimiento.Clear()
            dtp_FechaVcto.Value = dtp_FechaVcto.MinDate
            cmb_Tipo_Doc.SelectedIndex = -1
            txt_Num_Doc.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub
    Function Total_Cpmbte()

        Dim i As Integer
        Dim dTotalHaber As Double = 0
        Dim dTotalDebe As Double = 0
        Dim dDiferencia As Double = 0
        For i = 0 To DataAsiento.Rows.Count - 1
            dTotalDebe += Val(DataAsiento.Rows(i).Cells(3).Value)
            dTotalHaber += Val(DataAsiento.Rows(i).Cells(4).Value)
        Next

        If dTotalDebe <> dTotalHaber Then
            'MsgBox("Comprobante Descuadrado!!!", MsgBoxStyle.Critical)
            gCompOK = False
            If dTotalDebe > dTotalHaber Then
                dDiferencia = dTotalDebe - dTotalHaber
                txtDiferencia.Text = Format(dDiferencia, "DB ###,###,###")
            Else
                dDiferencia = dTotalHaber - dTotalDebe
                txtDiferencia.Text = Format(dDiferencia, "CR ###,###,###")
            End If
        Else
            gCompOK = True
            dDiferencia = dTotalDebe - dTotalHaber
            txtDiferencia.Text = Format(dDiferencia, "###,###,###")
        End If

        If dTotalDebe = 0 And dTotalHaber = 0 Then
            'MsgBox("Total Comprobante no debe ser cero", MsgBoxStyle.Exclamation)
            gCompOK = False
        End If

        txt_TotalDEBE.Text = Format(dTotalDebe, "###,###,###,##0")
        txt_TotalHABER.Text = Format(dTotalHaber, "###,###,###,##0")

        Total_Cpmbte = gCompOK

    End Function

    Private Sub txt_CtaTble_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_CtaTble.LostFocus
        If txt_CtaTble.Text <> Nothing Then

            If Len(txt_CtaTble.Text) <> 7 Then
                MsgBox("Cuenta Contable Inválida", MsgBoxStyle.Exclamation)
                txt_CtaTble.Focus()
                Exit Sub
            End If

            dtp_FechaVcto.Value = dtp_FechaVcto.MinDate

            sSsql = "SP_CONSULTA_CONTA_CodigoCuenta "
            sSsql += "'" + txt_CtaTble.Text + "'"
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                datatbl.Read()
                txt_DescripCuenta.Text = datatbl(1)
                gTipoCuenta = datatbl(2)
                gTipoReferCta = datatbl(6)
                Select Case gTipoReferCta
                    Case 0
                        REM SIN REFERENCIA
                        txt_clientebuscar.Enabled = False
                        rdb_RutCLi.Enabled = False
                        rdb_RutPRO.Enabled = False
                        rdb_Personal.Enabled = False
                        rdb_RutCLi.Checked = False
                        rdb_Personal.Checked = False
                        rdb_RutPRO.Checked = False
                        txt_Rut.ReadOnly = True
                        txt_NombreCliente.ReadOnly = True
                        btn_BuscarRUT.Enabled = False
                        cmb_Tipo_Doc.Enabled = False
                        txt_Num_Doc.ReadOnly = True
                        dtp_FechaVcto.Enabled = False
                        chkCliente.Enabled = False
                    Case 1
                        REM RUT CLIENTE
                        txt_clientebuscar.Enabled = True
                        rdb_RutCLi.Enabled = True
                        rdb_RutPRO.Enabled = False
                        rdb_Personal.Enabled = False
                        rdb_RutCLi.Checked = True
                        rdb_Personal.Checked = False
                        rdb_RutPRO.Checked = False
                        txt_Rut.ReadOnly = False
                        txt_NombreCliente.ReadOnly = False
                        btn_BuscarRUT.Enabled = True
                        cmb_Tipo_Doc.Enabled = True
                        txt_Num_Doc.ReadOnly = False
                        dtp_FechaVcto.Enabled = False
                        chkCliente.Enabled = True


                    Case 2
                        REM RUT PROVEEDOR
                        txt_clientebuscar.Enabled = False
                        rdb_RutCLi.Enabled = False
                        rdb_RutPRO.Enabled = True
                        rdb_Personal.Enabled = False
                        rdb_RutCLi.Checked = False
                        rdb_Personal.Checked = False
                        rdb_RutPRO.Checked = True
                        txt_Rut.ReadOnly = False
                        txt_NombreCliente.ReadOnly = False
                        btn_BuscarRUT.Enabled = True
                        cmb_Tipo_Doc.Enabled = True
                        txt_Num_Doc.ReadOnly = False
                        dtp_FechaVcto.Enabled = False
                        chkCliente.Enabled = False
                    Case 3
                        REM RUT PERSONAL
                        txt_clientebuscar.Enabled = False
                        rdb_RutCLi.Enabled = False
                        rdb_RutPRO.Enabled = False
                        rdb_Personal.Enabled = True
                        rdb_RutCLi.Checked = False
                        rdb_Personal.Checked = True
                        rdb_RutPRO.Checked = False
                        txt_Rut.ReadOnly = False
                        txt_NombreCliente.ReadOnly = False
                        btn_BuscarRUT.Enabled = True
                        cmb_Tipo_Doc.Enabled = True
                        txt_Num_Doc.ReadOnly = False
                        dtp_FechaVcto.Enabled = False
                        chkCliente.Enabled = False
                    Case 4
                        REM VENCIMIENTOS POR PAGAR A PROVEEDORES
                        txt_clientebuscar.Enabled = False
                        rdb_RutCLi.Enabled = False
                        rdb_RutPRO.Enabled = False
                        rdb_Personal.Enabled = False
                        rdb_RutCLi.Checked = False
                        rdb_Personal.Checked = False
                        rdb_RutPRO.Checked = False
                        txt_Rut.ReadOnly = True
                        txt_NombreCliente.ReadOnly = True
                        btn_BuscarRUT.Enabled = False
                        cmb_Tipo_Doc.Enabled = True
                        txt_Num_Doc.ReadOnly = False
                        dtp_FechaVcto.Enabled = True
                        chkCliente.Enabled = False
                    Case 5
                        REM VENCIMIENTOS POR COBRAR A CLIENTES
                        txt_clientebuscar.Enabled = False
                        rdb_RutCLi.Enabled = False
                        rdb_RutPRO.Enabled = False
                        rdb_Personal.Enabled = False
                        rdb_RutCLi.Checked = False
                        rdb_Personal.Checked = False
                        rdb_RutPRO.Checked = False
                        txt_Rut.ReadOnly = True
                        txt_NombreCliente.ReadOnly = True
                        btn_BuscarRUT.Enabled = False
                        cmb_Tipo_Doc.Enabled = True
                        txt_Num_Doc.ReadOnly = False
                        dtp_FechaVcto.Enabled = True
                        chkCliente.Enabled = False
                End Select
              
            Else
                MsgBox("No Existe Cuenta Contable.", MsgBoxStyle.Exclamation)
                close_conexion()
                txt_CtaTble.Focus()
                Exit Sub
            End If


            close_conexion()
        End If

    End Sub

    Private Sub txt_Ccosto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Ccosto.LostFocus
        If txt_Ccosto.Text <> Nothing Then
            sSsql = "SP_CONSULTA_CONTA_CCosto "
            sSsql += txt_Ccosto.Text.ToString
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                datatbl.Read()
                txt_DescripCCosto.Text = datatbl(1)
            Else
                MsgBox("No Existe Centro de Costo.", MsgBoxStyle.Exclamation)
                close_conexion()
                Exit Sub
            End If
            close_conexion()
        End If
    End Sub

    Private Sub GrabarComprobanteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrabarComprobanteToolStripMenuItem.Click
        If Valida_Datos() = True Then
            If Total_Cpmbte() Then
                Grabar_Cmpbte()
            End If
        End If



    End Sub
    Function Valida_Datos()
        Dim i As Integer = 0
        Dim dSumaDebe As Double = 0
        Dim dSumaHaber As Double = 0

        gCompValido = True

        If cmb_TipoCmpbte.SelectedIndex = -1 Then
            MsgBox("Seleccione Tipo de Comprobante", MsgBoxStyle.Exclamation)
            gCompValido = False

        End If

        If txt_Glosa.Text = Nothing Then
            MsgBox("Ingrese una Glosa para el comprobante.", MsgBoxStyle.Exclamation)
            gCompValido = False

        End If

        If DataAsiento.Rows.Count = 0 Then
            MsgBox("Comprobante no contiene detalle de Cuentas", MsgBoxStyle.Exclamation)
            gCompValido = False

        End If

        For i = 0 To DataAsiento.Rows.Count - 1
            If Val(DataAsiento.Rows(i).Cells(3).Value) = 0 And Val(DataAsiento.Rows(i).Cells(4).Value) = 0 Then
                MsgBox("Error en detalle de Comprobante. Línea " & i.ToString & ". Valores DEBE y HABER no pueden estar en 0.", MsgBoxStyle.Exclamation)
                gCompValido = False
            End If
        Next
        dSumaDebe = 0
        dSumaHaber = 0
        For i = 0 To DataAsiento.Rows.Count - 1
            dSumaDebe += Val(DataAsiento.Rows(i).Cells(3).Value)
            dSumaHaber += Val(DataAsiento.Rows(i).Cells(4).Value)
        Next

        If dSumaDebe <> dSumaHaber Then
            MsgBox("Comprobante Descuadrado!!!", MsgBoxStyle.Critical)
            gCompValido = False
        End If

        Valida_Datos = gCompValido

    End Function
    Private Sub Grabar_Cmpbte()
        Dim i As Integer = 0

        sSsql = "SP_GRABA_CONTA_Cpmbte_Head "
        sSsql += Val(txt_NumCpmbte.Text).ToString + ","
        sSsql += "'" + Format(dtp_FechaCmpbte.Value, "d") + "',"
        sSsql += "'" + Mid(cmb_TipoCmpbte.Text, 1, 1) + "',"
        sSsql += "'" + txt_Glosa.Text + "'"
        open()

        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        datatbl.Read()
        gNumCpmbte = datatbl(0)
        close_conexion()
        open()
        REM Graba Detalle Comprobante
        For i = 0 To DataAsiento.Rows.Count - 1
            sSsql = "SP_GRABA_CONTA_Cpmbte_Det "
            sSsql += gNumCpmbte.ToString + ","
            sSsql += "'" + DataAsiento.Rows(i).Cells(1).Value + "',"
            sSsql += "'" + Format(dtp_FechaCmpbte.Value, "d") + "',"
            If DataAsiento.Rows(i).Cells(5).Value = Nothing Then
                sSsql += "Null,"
            Else
                sSsql += DataAsiento.Rows(i).Cells(5).Value.ToString + ","
            End If
            sSsql += Val(DataAsiento.Rows(i).Cells(3).Value).ToString + ","
            sSsql += Val(DataAsiento.Rows(i).Cells(4).Value).ToString + ","
            sSsql += "'" + DataAsiento.Rows(i).Cells(7).Value + "',"
            sSsql += "'" + DataAsiento.Rows(i).Cells(8).Value + "'"
            command = connection.CreateCommand
            command.CommandText = sSsql
            command.ExecuteNonQuery()
        Next
        close_conexion()
        MsgBox("Comprobante N° " & gNumCpmbte.ToString & " Ha sido actualizado.", MsgBoxStyle.Information)
        Limpia_Campos()
    End Sub
    Private Sub Limpia_Campos()
        DataAsiento.Rows.Clear()
        txt_Ccosto.Clear()
        txt_CtaTble.Clear()
        txt_Glosa.Clear()
        txt_MontoDebe.Clear()
        txt_MontoHaber.Clear()
        txt_NumCpmbte.Clear()
        txt_TotalDEBE.Clear()
        txt_TotalHABER.Clear()
        'dtp_FechaCmpbte.Value = Now.Date
        gNumCpmbte = 0
        txt_DescripCCosto.Clear()
        txt_DescripCuenta.Clear()
        cmb_TipoCmpbte.SelectedIndex = -1

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Consulta_Comprobantes.Show()
        If Val(txt_NumCpmbte.Text) > 0 Then
            Consulta_Cmpbte.txt_IdCmpbte.Text = txt_NumCpmbte.Text
            Consulta_Cmpbte.Button2_Click(sender, e)
            Consulta_Cmpbte.Show()
        End If

    End Sub
    Private Sub Buscar_Cpmbte()
        Dim i As Integer
        sSsql = "SP_CONSULTA_CONTA_Cpmbte_Head "
        sSsql += txt_NumCpmbte.Text.ToString

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            dtp_FechaCmpbte.Value = datatbl(0)
            Select Case datatbl(1)
                Case "I"
                    cmb_TipoCmpbte.Text = "Ingreso"
                Case "E"
                    cmb_TipoCmpbte.Text = "Egreso"
                Case "T"
                    cmb_TipoCmpbte.Text = "Traspaso"
            End Select
            txt_Glosa.Text = datatbl(2)
            txt_TotalDEBE.Text = Format(datatbl(3), "###,###,###,##0")
            txt_TotalHABER.Text = Format(datatbl(4), "###,###,###,##0")
        Else
            MsgBox("No Existe N° de Comprobante.", MsgBoxStyle.Exclamation)
            close_conexion()
            Exit Sub
        End If
        close_conexion()

        REM Muestra Detalle Comprobante
        sSsql = "SP_CONSULTA_CONTA_Cpmbte_Det "
        sSsql += txt_NumCpmbte.Text.ToString
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            i = 0
            While datatbl.Read
                DataAsiento.Rows.Add()

            End While
        End If
        close_conexion()

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Limpia_Campos()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub txt_CtaTble_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_CtaTble.TextChanged

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim fila As Integer
        Try
            fila = DataAsiento.CurrentCell.RowIndex

            If fila > -1 And DataAsiento.Rows.Count > 0 Then
                'dTotalPagos -= Single.Parse(DataGrilla.Item(4, fila).Value)
                DataAsiento.Rows.RemoveAt(fila)

                Total_Cpmbte()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarRUT.Click
        If chkCliente.Checked = True Then
            BusquedaCliente.chkIncluyePrimerNombre.Checked = True
        Else
            BusquedaCliente.chkIncluyePrimerNombre.Checked = False
        End If

        If rdb_RutCLi.Checked = True Then
            gQuienLlama = 8
        End If
        If rdb_Personal.Checked = True Then
            gQuienLlama = 9
        End If
        If rdb_RutPRO.Checked = True Then
            gQuienLlama = 14
        End If


        gNOMBRE = txt_clientebuscar.Text
        gQuienLlama = 8
        BusquedaCliente.Visible = True
    End Sub

    Private Sub txt_Ccosto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Ccosto.TextChanged

    End Sub

    Private Sub txt_MontoDebe_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_MontoDebe.TextChanged
        txt_MontoHaber.Clear()
    End Sub

    Private Sub txt_MontoHaber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_MontoHaber.TextChanged
        txt_MontoDebe.Clear()
    End Sub

    Private Sub rdb_CLiPro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_RutCLi.CheckedChanged
        If rdb_RutCLi.Checked = True Then
            txt_clientebuscar.ReadOnly = False
            btn_BuscarRUT.Enabled = True
        End If
    End Sub

    Private Sub rdb_RutPRO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_RutPRO.CheckedChanged
        If rdb_RutPRO.Checked = True Then
            txt_clientebuscar.ReadOnly = False
            btn_BuscarRUT.Enabled = True
        End If
    End Sub

    Private Sub rdb_Personal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Personal.CheckedChanged
        If rdb_Personal.Checked = True Then
            txt_clientebuscar.ReadOnly = False
            btn_BuscarRUT.Enabled = True
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class