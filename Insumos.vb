Public Class Insumos
    Private Sub Insumos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Carga_Lista_Full_Insumos()
        Carga_Tipo_Unidad(Me.cmb_Unidad)
    End Sub

    Private Sub Carga_Lista_Full_Insumos()
        Dim i As Integer
        sSsql = "SP_CONSULTA_FULL_INSUMOS"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        DataGrilla.Rows.Clear()

        While datatbl.Read = True
            DataGrilla.Rows.Add()
            DataGrilla.Rows(i).Cells(0).Value = datatbl(0)
            DataGrilla.Rows(i).Cells(1).Value = datatbl(1)
            DataGrilla.Rows(i).Cells(2).Value = datatbl(5)
            DataGrilla.Rows(i).Cells(3).Value = datatbl(2)
            DataGrilla.Rows(i).Cells(4).Value = datatbl(4)
            DataGrilla.Rows(i).Cells(5).Value = datatbl(6)
            DataGrilla.Rows(i).Cells(6).Value = datatbl(7)
            DataGrilla.Rows(i).Cells(7).Value = datatbl(12)
            DataGrilla.Rows(i).Cells(8).Value = datatbl(14)
            DataGrilla.Rows(i).Cells(9).Value = datatbl(8)
            DataGrilla.Rows(i).Cells(10).Value = datatbl(10)
            DataGrilla.Rows(i).Cells(11).Value = datatbl(15)
            DataGrilla.Rows(i).Cells(12).Value = datatbl(9)
            DataGrilla.Rows(i).Cells(13).Value = datatbl(16)
            DataGrilla.Rows(i).Cells(14).Value = datatbl(13)
            DataGrilla.Rows(i).Cells(15).Value = datatbl(17)
            DataGrilla.Rows(i).Cells(16).Value = datatbl(11)
            DataGrilla.Rows(i).Cells(17).Value = datatbl(18)
            DataGrilla.Rows(i).Cells(18).Value = datatbl(3)
            i += 1
        End While

        close_conexion()
    End Sub
    Function ValidaDatos() As Boolean
        Dim bRetorno As Boolean = True
        If cmb_Unidad.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Unidad", MsgBoxStyle.Exclamation)
            bRetorno = False
        End If
        If cmbTipoCosto.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Tipo de Costo", MsgBoxStyle.Exclamation)
            bRetorno = False
        End If
        If cmbTipoInsumo.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Tipo de Insumo", MsgBoxStyle.Exclamation)
            bRetorno = False
        End If
        If cmbTipoTransac.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Tipo de Transacción", MsgBoxStyle.Exclamation)
            bRetorno = False
        Else
            If Mid(cmbTipoTransac.Text, 1, 1) = "T" Or Mid(cmbTipoTransac.Text, 1, 1) = "I" Then
                If Val(txtPrecioVta.Text) = 0 Then
                    MsgBox("Debe Definir Precio de Venta del Insumo")
                    bRetorno = False
                End If
            End If
        End If
        If txt_Descripcion.Text = Nothing Then
            MsgBox("Debe Ingresar Nombre Insumo", MsgBoxStyle.Exclamation)
            bRetorno = False
        End If
        If txtCtaCtble.Text = Nothing Then
            MsgBox("Debe Ingresar Cuenta Contable Principal", MsgBoxStyle.Exclamation)
            bRetorno = False
        End If
        If txtCtaIngreso.Text = Nothing Then
            MsgBox("Debe Ingresar Cuenta Contable de Ingreso", MsgBoxStyle.Exclamation)
            bRetorno = False
        End If
        If txtCCosto.Text = Nothing Then
            MsgBox("Debe Ingresar Código Costo Principal", MsgBoxStyle.Exclamation)
            bRetorno = False
        End If

        If bRetorno = True Then
            REM Valida que no se repitan los nombres de Insumos para Registros Nuevos
            If Val(txt_IDInsumo.Text) = 0 Then
                sSsql = "SP_CONSULTA_Insumo "
                sSsql += "'" + txt_Descripcion.Text + "'"
                open()
                command = connection.CreateCommand()
                command.CommandText = sSsql
                datatbl = command.ExecuteReader()
                If datatbl.HasRows Then
                    MsgBox("Ya existe Insumo con este nombre " & txt_Descripcion.Text & Chr(10) & "Debe revisar datos del Insumo existente o Modificar Nombre.", MsgBoxStyle.Exclamation)
                    bRetorno = False
                End If
                close_conexion()
            End If
        End If


        ValidaDatos = bRetorno
    End Function
    Private Sub Graba_Insumos()
        REM @IdInsumo int,
        '@Descripcion varchar(50),
        '@Precio_Costo float,
        '@IdUnidad int,
        '@Comentario varchar(200),
        '@Precio_Venta float,
        '@Tipo_Costo varchar(1),
        '@CodCCosto int,
        '@Cta_Ctble varchar(7),
        '@CodCCosto_I int = Null,
        '@Tipo_Transac varchar(1),
        '@Cta_Ctble_I varchar(7) = Null,
        '@Tipo_Insumo varchar(1),
        '@Stock float
        sSsql = "SP_GRABA_INSUMOS "
        sSsql += Str(Val(txt_IDInsumo.Text)) + ","
        sSsql += "'" + txt_Descripcion.Text + "',"
        If Val(txt_PrecioCosto.Text) = 0 Then
            sSsql += "0,"
        Else
            sSsql += Reemplaza_Comas(txt_PrecioCosto.Text) + ","
        End If
        sSsql += Str(TU_ID(Me.cmb_Unidad.SelectedIndex)) + ","
        sSsql += "'" + txt_Comentario.Text + "',"
        If Val(txtPrecioVta.Text) = 0 Then
            sSsql += "0,"
        Else
            sSsql += Reemplaza_Comas(txtPrecioVta.Text) + ","
        End If
        sSsql += "'" + Mid(cmbTipoCosto.Text, 1, 1) + "',"
        sSsql += txtCCosto.Text.ToString + ","
        If txtCtaCtble.Text = "" Or txtCtaCtble.Text = Nothing Then
            MsgBox("Falta Ingresar Cuenta Contable Principal", MsgBoxStyle.Critical)
            Exit Sub
        End If
        sSsql += "'" + txtCtaCtble.Text + "',"
        If txtCCostoIng.Text = Nothing Then
            sSsql += "Null,"
        Else
            sSsql += txtCCostoIng.Text.ToString + ","
        End If
        sSsql += "'" + Mid(cmbTipoTransac.SelectedItem, 1, 1) + "',"
        If txtCtaIngreso.Text = Nothing Then
            sSsql += "Null,"
        Else
            sSsql += "'" + txtCtaIngreso.Text + "',"
        End If
        sSsql += "'" + Mid(cmbTipoInsumo.SelectedItem, 1, 1) + "',"
        sSsql += Val(txtStockInsumo.Text).ToString
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()
        close_conexion()
        Carga_Lista_Full_Insumos()
        Limpia_campos()
    End Sub
    Private Sub Limpia_campos()
        txt_IDInsumo.Clear()
        txt_Descripcion.Clear()
        txt_PrecioCosto.Clear()
        cmb_Unidad.SelectedIndex = -1
        txt_Comentario.Clear()
        txtPrecioVta.Clear()
        txtCCosto.Clear()
        txtCCostoIng.Clear()
        txtCtaCtble.Clear()
        txtCtaIngreso.Clear()
        txtDescCCosto.Clear()
        txtDescCCostoIngreso.Clear()
        txtDescCtaDirecta.Clear()
        txtDescCtaIngreso.Clear()
        cmbTipoCosto.SelectedIndex = -1
        cmbTipoInsumo.SelectedIndex = -1
        cmbTipoTransac.SelectedIndex = -1
        txtStockInsumo.Clear()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Limpia_campos()
        txt_Descripcion.Focus()
    End Sub
    Private Sub Modifica_Insumo()
        Dim FilaGrilla As Integer
        FilaGrilla = DataGrilla.CurrentRow.Index
        txt_IDInsumo.Text = DataGrilla.Rows(FilaGrilla).Cells(0).Value
        txt_Descripcion.Text = DataGrilla.Rows(FilaGrilla).Cells(1).Value
        If IsDBNull(DataGrilla.Rows(FilaGrilla).Cells(2).Value) Then
            txt_Comentario.Text = ""
        Else
            txt_Comentario.Text = DataGrilla.Rows(FilaGrilla).Cells(2).Value
        End If

        txt_PrecioCosto.Text = DataGrilla.Rows(FilaGrilla).Cells(3).Value
        cmb_Unidad.SelectedItem = DataGrilla.Rows(FilaGrilla).Cells(4).Value
        txtPrecioVta.Text = DataGrilla.Rows(FilaGrilla).Cells(5).Value
        txtStockInsumo.Text = DataGrilla.Rows(FilaGrilla).Cells(6).Value
        'Tipo de Transacción
        'E: Compras
        'I: Ventas
        'T: Compras y Ventas
        Select Case DataGrilla.Rows(FilaGrilla).Cells(7).Value
            Case "E"
                cmbTipoTransac.SelectedItem = "E: Compras"
            Case "I"
                cmbTipoTransac.SelectedItem = "I: Ventas"
            Case "T"
                cmbTipoTransac.SelectedItem = "T: Compras y Ventas"
        End Select
        'Tipo de Insumo
        'G: Item de Gasto
        'P: Productos Inventariables
        Select Case DataGrilla.Rows(FilaGrilla).Cells(8).Value
            Case "G"
                cmbTipoInsumo.SelectedItem = "G: Item de Gasto"
            Case "P"
                cmbTipoInsumo.SelectedItem = "P: Productos Inventariables"
        End Select
        'Tipo de Costo
        'D: Directo
        'I: Indirecto
        Select Case DataGrilla.Rows(FilaGrilla).Cells(9).Value
            Case "D"
                cmbTipoCosto.SelectedItem = "D: Directo"
            Case "I"
                cmbTipoCosto.SelectedItem = "I: Indirecto"
        End Select
        txtCtaCtble.Text = DataGrilla.Rows(FilaGrilla).Cells(10).Value
        txtDescCtaDirecta.Text = DataGrilla.Rows(FilaGrilla).Cells(11).Value
        txtCCosto.Text = DataGrilla.Rows(FilaGrilla).Cells(12).Value
        txtDescCCosto.Text = DataGrilla.Rows(FilaGrilla).Cells(13).Value
        txtCtaIngreso.Text = IIf(IsDBNull(DataGrilla.Rows(FilaGrilla).Cells(14).Value), "", DataGrilla.Rows(FilaGrilla).Cells(14).Value)
        txtDescCtaIngreso.Text = IIf(IsDBNull(DataGrilla.Rows(FilaGrilla).Cells(15).Value), "", DataGrilla.Rows(FilaGrilla).Cells(15).Value)
        txtCCostoIng.Text = IIf(IsDBNull(DataGrilla.Rows(FilaGrilla).Cells(16).Value), "", DataGrilla.Rows(FilaGrilla).Cells(16).Value)
        txtDescCCostoIngreso.Text = IIf(IsDBNull(DataGrilla.Rows(FilaGrilla).Cells(17).Value), "", DataGrilla.Rows(FilaGrilla).Cells(17).Value)
        txt_Descripcion.Focus()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Modifica_Insumo()
    End Sub
    Private Sub Elimina_Insumo()
        Dim sResp As String
        Dim IdInsumo As Integer
        Dim FilaGrilla As Integer
        sResp = InputBox("CONFIRME ELIMINACION DE INSUMO.", "ELIMINACION DE INSUMO", "S")
        If UCase(sResp) = "S" Then
            FilaGrilla = DataGrilla.CurrentRow.Index
            IdInsumo = DataGrilla.Rows(FilaGrilla).Cells(0).Value
            If IdInsumo <= 0 Then
                MsgBox("Código de Insumo NO ES VALIDO. DEBE SELECCIONAR INSUMO A ELIMINAR.")
                Exit Sub
            End If
            sSsql = "SP_ELIMINA_INSUMO "
            sSsql += Str(IdInsumo)
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                datatbl.Read()
                If datatbl(0) = -1 Then
                    MsgBox("No es posible Eliminar Código :" + Format(IdInsumo, "####") + ". Existen fórmulas vinculadas a este Insumo.")
                End If
            End If
            close_conexion()
            Carga_Lista_Full_Insumos()
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Elimina_Insumo()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ValidaDatos() Then
            Graba_Insumos()
        End If
    End Sub

    Private Sub txtCtaCtble_LostFocus(sender As Object, e As System.EventArgs) Handles txtCtaCtble.LostFocus
        If BuscaCuentaCtble(txtCtaCtble.Text, txtDescCtaDirecta) = False Then
            txtCtaCtble.Clear()
            txtCtaCtble.Focus()
        End If
    End Sub
    Function BuscaCuentaCtble(sCuenta As String, ByRef sTxtDescrip As TextBox) As Boolean
        Dim bRetorno As Boolean = True

        sSsql = "SP_CONSULTA_CONTA_CodigoCuenta "
        sSsql += "'" + sCuenta + "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            sTxtDescrip.Text = datatbl(1)
        Else
            MsgBox("No Existe Cuenta Contable")
            bRetorno = False
        End If
        close_conexion()

        BuscaCuentaCtble = bRetorno
    End Function
    Function BuscaCCosto(CCosto As Integer, ByRef sTxtDescrip As TextBox) As Boolean
        Dim bRetorno As Boolean = True
        sSsql = "SP_CONSULTA_CONTA_CCosto "
        sSsql += CCosto.ToString
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            sTxtDescrip.Text = datatbl(1)
        Else
            MsgBox("No Existe Centro de Costo.", MsgBoxStyle.Exclamation)
            bRetorno = False
        End If
        BuscaCCosto = bRetorno
    End Function


    Private Sub txtCCosto_LostFocus(sender As Object, e As System.EventArgs) Handles txtCCosto.LostFocus

        If txtCCosto.Text <> Nothing Then
            If BuscaCCosto(txtCCosto.Text, txtDescCCosto) = False Then
                txtCCosto.Clear()
                txtCCosto.Focus()
            End If
        End If
    End Sub

    Private Sub txtCtaIngreso_LostFocus(sender As Object, e As System.EventArgs) Handles txtCtaIngreso.LostFocus
        If txtCtaIngreso.Text <> Nothing Then
            If BuscaCuentaCtble(txtCtaIngreso.Text, txtDescCtaIngreso) = False Then
                txtCtaIngreso.Clear()
                txtCtaIngreso.Focus()
            End If
        End If
    End Sub

    Private Sub txtCCostoIng_LostFocus(sender As Object, e As System.EventArgs) Handles txtCCostoIng.LostFocus
        If txtCCostoIng.Text <> Nothing Then
            If BuscaCCosto(txtCCostoIng.Text, txtDescCCostoIngreso) = False Then
                txtCCostoIng.Clear()
                txtCCostoIng.Focus()
            End If
        End If
    End Sub

    Private Sub txt_Descripcion_LostFocus(sender As Object, e As System.EventArgs) Handles txt_Descripcion.LostFocus
        If txt_Descripcion.Text = Nothing Then
            MsgBox("Debe Ingresar Nombre del Insumo", MsgBoxStyle.Exclamation)
            txt_Descripcion.Focus()
        End If
    End Sub


   
    Private Sub BuscarInsumoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BuscarInsumoToolStripMenuItem.Click
        BuscaInsumo.Visible = True
        BuscaInsumo.txtBuscaInsumo.Focus()

    End Sub
End Class