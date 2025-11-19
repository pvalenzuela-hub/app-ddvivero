Imports System.Data.SqlClient
Public Class Semillas

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub


    Private Sub CargaGrillaFamilia()
        Dim i As Integer
        sSsql = "SP_CONSULTA_FULL_FAMILIA_PRODUCTO"
        command = connection.CreateCommand
        open()


        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        DataGrilla.Rows.Clear()
        If datatbl.HasRows Then

            While datatbl.Read = True
                DataGrilla.Rows.Add()
                DataGrilla.Rows(i).Cells(0).Value = datatbl(0)

                DataGrilla.Rows(i).Cells(1).Value = datatbl(1)
                DataGrilla.Rows(i).Cells(2).Value = datatbl(7)
                DataGrilla.Rows(i).Cells(3).Value = datatbl(8)
                DataGrilla.Rows(i).Cells(4).Value = datatbl(9)
                DataGrilla.Rows(i).Cells(5).Value = datatbl(10)
                DataGrilla.Rows(i).Cells(6).Value = datatbl(11)
                DataGrilla.Rows(i).Cells(7).Value = datatbl(12)
                DataGrilla.Rows(i).Cells(8).Value = datatbl(13)
                DataGrilla.Rows(i).Cells(9).Value = datatbl(14)
                DataGrilla.Rows(i).Cells(10).Value = datatbl(15)
                DataGrilla.Rows(i).Cells(11).Value = datatbl(16)
                DataGrilla.Rows(i).Cells(12).Value = datatbl(17)
                DataGrilla.Rows(i).Cells(13).Value = datatbl(18)

                i += 1
            End While
        End If
        close_conexion()
    End Sub
    Private Sub Carga_Lista_Full_Semillas()
        Dim i As Integer
        sSsql = "SP_CONSULTA_FULL_FAMILIA_PRODUCTO"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        DataGrilla.Rows.Clear()

        While datatbl.Read = True
            DataGrilla.Rows.Add()
            DataGrilla.Rows(i).Cells(0).Value = datatbl(0)
            DataGrilla.Rows(i).Cells(1).Value = datatbl(1)
            DataGrilla.Rows(i).Cells(2).Value = datatbl(7)
            DataGrilla.Rows(i).Cells(3).Value = datatbl(8)
            DataGrilla.Rows(i).Cells(4).Value = datatbl(9)
            DataGrilla.Rows(i).Cells(5).Value = datatbl(10)
            DataGrilla.Rows(i).Cells(6).Value = datatbl(11)
            DataGrilla.Rows(i).Cells(7).Value = datatbl(12)
            DataGrilla.Rows(i).Cells(8).Value = datatbl(13)
            DataGrilla.Rows(i).Cells(9).Value = datatbl(14)
            DataGrilla.Rows(i).Cells(10).Value = datatbl(15)
            DataGrilla.Rows(i).Cells(11).Value = datatbl(16)
            DataGrilla.Rows(i).Cells(12).Value = datatbl(17)
            DataGrilla.Rows(i).Cells(13).Value = datatbl(18)

            i += 1
        End While

        close_conexion()
    End Sub
    Private Sub Graba_Semilla()
        REM Actualiza Datos de Especie

        sSsql = "SP_GRABA_FAMILIA "
        sSsql += "'" + txt_Descripcion.Text + "',"
        sSsql += "'" + txt_CtaCtblePlantas.Text + "',"
        sSsql += "'" + txt_CtaCtbleExistencias.Text + "',"
        sSsql += "'" + txt_CtaCtbleVentas.Text + "',"
        sSsql += "'" + txt_CtaCtbleGastosProduccion.Text + "',"
        sSsql += "'" + txt_CtaCtbleCostoVenta.Text + "',"
        sSsql += "'" + cmb_CentroCosto.Text + "',"
        If Reemplaza_Comas(txtvolumenintermedio.Text) = "" Then
            sSsql += "0,"
        Else
            sSsql += Reemplaza_Comas(txtvolumenintermedio.Text) + ","
        End If
        If Reemplaza_Comas(txtvolumendetalle.Text) = "" Then
            sSsql += "0,"
        Else
            sSsql += Reemplaza_Comas(txtvolumendetalle.Text) + ","
        End If

        If (txt_DiasFab_OTO.Text = "") Then
            sSsql += "0,"
        Else
            sSsql += Val(txt_DiasFab_OTO.Text).ToString + ","
        End If

        If (txt_DiasFab_INV.Text = "") Then
            sSsql += "0,"
        Else
            sSsql += Val(txt_DiasFab_INV.Text).ToString + ","
        End If

        If (txt_DiasFab_PRI.Text = "") Then
            sSsql += "0,"
        Else
            sSsql += Val(txt_DiasFab_PRI.Text).ToString + ","
        End If

        If (txt_DiasFab_VER.Text = "") Then
            sSsql += "0"
        Else
            sSsql += Val(txt_DiasFab_VER.Text).ToString
        End If


        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()
        close_conexion()
        Carga_Lista_Full_Semillas()
    End Sub
    Private Sub Modifica_Semilla()
        Dim FilaGrilla As Integer
        Limpia_campos()
        FilaGrilla = DataGrilla.CurrentRow.Index
        'txt_idfamilia.Text = DataGrilla.Rows(FilaGrilla).Cells(0).Value
        txt_Descripcion.Text = DataGrilla.Rows(FilaGrilla).Cells(1).Value
        If Not IsDBNull(DataGrilla.Rows(FilaGrilla).Cells(2).Value) Then
            txt_CtaCtblePlantas.Text = DataGrilla.Rows(FilaGrilla).Cells(2).Value
        End If
        If Not IsDBNull(DataGrilla.Rows(FilaGrilla).Cells(3).Value) Then
            txt_CtaCtbleExistencias.Text = DataGrilla.Rows(FilaGrilla).Cells(3).Value
        End If
        If Not IsDBNull(DataGrilla.Rows(FilaGrilla).Cells(4).Value) Then
            txt_CtaCtbleVentas.Text = DataGrilla.Rows(FilaGrilla).Cells(4).Value
        End If
        If Not IsDBNull(DataGrilla.Rows(FilaGrilla).Cells(5).Value) Then
            txt_CtaCtbleGastosProduccion.Text = DataGrilla.Rows(FilaGrilla).Cells(5).Value
        End If
        If Not IsDBNull(DataGrilla.Rows(FilaGrilla).Cells(6).Value) Then
            txt_CtaCtbleCostoVenta.Text = DataGrilla.Rows(FilaGrilla).Cells(6).Value
        End If

        cmb_CentroCosto.Text = DataGrilla.Rows(FilaGrilla).Cells(7).Value
        If txt_CtaCtblePlantas.Text <> Nothing Then
            Valida_Cuenta(txt_CtaCtblePlantas.Text, txt_DesCtaPlantasTerminadas, txt_CtaCtblePlantas)
        End If
        If txt_CtaCtbleExistencias.Text <> Nothing Then
            Valida_Cuenta(txt_CtaCtbleExistencias.Text, txt_DesCtaExistencias, txt_CtaCtbleExistencias)
        End If
        If txt_CtaCtbleVentas.Text <> Nothing Then
            Valida_Cuenta(txt_CtaCtbleVentas.Text, txt_DesCtaVentas, txt_CtaCtbleVentas)
        End If
        If txt_CtaCtbleGastosProduccion.Text <> Nothing Then
            Valida_Cuenta(txt_CtaCtbleGastosProduccion.Text, txt_DesCtaGastoProduccion, txt_CtaCtbleGastosProduccion)
        End If
        If txt_CtaCtbleCostoVenta.Text <> Nothing Then
            Valida_Cuenta(txt_CtaCtbleCostoVenta.Text, txt_DesCtaCostoVenta, txt_CtaCtbleCostoVenta)
        End If
        If Not IsDBNull(DataGrilla.Rows(FilaGrilla).Cells(8).Value) Then
            txtvolumenintermedio.Text = DataGrilla.Rows(FilaGrilla).Cells(8).Value
        End If
        If Not IsDBNull(DataGrilla.Rows(FilaGrilla).Cells(9).Value) Then
            txtvolumendetalle.Text = DataGrilla.Rows(FilaGrilla).Cells(9).Value
        End If

        If Not IsDBNull(DataGrilla.Rows(FilaGrilla).Cells(10).Value) Then
            txt_DiasFab_OTO.Text = DataGrilla.Rows(FilaGrilla).Cells(10).Value
        End If

        If Not IsDBNull(DataGrilla.Rows(FilaGrilla).Cells(11).Value) Then
            txt_DiasFab_INV.Text = DataGrilla.Rows(FilaGrilla).Cells(11).Value
        End If

        If Not IsDBNull(DataGrilla.Rows(FilaGrilla).Cells(12).Value) Then
            txt_DiasFab_PRI.Text = DataGrilla.Rows(FilaGrilla).Cells(12).Value
        End If

        If Not IsDBNull(DataGrilla.Rows(FilaGrilla).Cells(13).Value) Then
            txt_DiasFab_VER.Text = DataGrilla.Rows(FilaGrilla).Cells(13).Value
        End If

        txt_Descripcion.Focus()
    End Sub
    Private Sub Elimina_Semilla()
        Dim sResp As String
        Dim IdFamilia As Integer
        Dim FilaGrilla As Integer
        sResp = InputBox("CONFIRME ELIMINACION DE SEMILLA DEL SISTEMA", "ELIMINACION DE SEMILLA", "S")
        If UCase(sResp) = "S" Then
            FilaGrilla = DataGrilla.CurrentRow.Index
            IdFamilia = DataGrilla.Rows(FilaGrilla).Cells(0).Value
            If IdFamilia <= 0 Then
                MsgBox("IDENTIFICADOR DE SEMILLA NO ES VALIDO. DEBE SELECCIONAR SEMILLA A ELIMINAR.")
                Exit Sub
            End If
            sSsql = "SP_ELIMINA_FAMILIA "
            'idFamilia numeric(18,0)
            sSsql += Str(IdFamilia)
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                datatbl.Read()
                If datatbl(0) = -1 Then
                    MsgBox("NO ES POSIBLE ELIMINAR SEMILLA CODIGO:" + Format(IdFamilia, "####") + ". EXISTEN PEDIDOS CON ESTA INFORMACION")
                End If
            End If
            close_conexion()
            Carga_Lista_Full_Semillas()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Elimina_Semilla()
        Carga_Lista_Full_Semillas()
        Limpia_campos()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Graba_Semilla()
        Limpia_campos()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Modifica_Semilla()
    End Sub
    Private Sub Limpia_campos()
        txt_Descripcion.Clear()
        txt_CtaCtblePlantas.Clear()
        txt_CtaCtbleExistencias.Clear()
        txt_CtaCtbleVentas.Clear()
        txt_CtaCtbleGastosProduccion.Clear()
        txt_CtaCtbleCostoVenta.Clear()
        cmb_CentroCosto.SelectedIndex = -1
        txt_DesCtaCostoVenta.Clear()
        txt_DesCtaExistencias.Clear()
        txt_DesCtaGastoProduccion.Clear()
        txt_DesCtaPlantasTerminadas.Clear()
        txt_DesCtaVentas.Clear()
        txtvolumendetalle.Clear()
        txtvolumenintermedio.Clear()
        txt_DiasFab_INV.Clear()
        txt_DiasFab_OTO.Clear()
        txt_DiasFab_PRI.Clear()
        txt_DiasFab_VER.Clear()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Limpia_campos()
        txt_Descripcion.Focus()
    End Sub

    Private Sub txt_CtaCtblePlantas_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_CtaCtblePlantas.Leave
        REM Productos Terminados
        If txt_CtaCtblePlantas.Text <> Nothing Then
            Valida_Cuenta(txt_CtaCtblePlantas.Text, txt_DesCtaPlantasTerminadas, txt_CtaCtblePlantas)
        End If
    End Sub
    Private Sub txt_CtaCtbleExistencias_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_CtaCtbleExistencias.Leave
        REM Existencias
        If txt_CtaCtbleExistencias.Text <> Nothing Then
            Valida_Cuenta(txt_CtaCtbleExistencias.Text, txt_DesCtaExistencias, txt_CtaCtbleExistencias)
        End If
    End Sub


    Private Sub Valida_Cuenta(ByVal xCuenta As String, ByVal xtexto As TextBox, ByVal xCampoCuenta As TextBox)
        If xCuenta <> "" Then
            sSsql = "SP_CONSULTA_CONTA_CodigoCuenta "
            sSsql += "'" + xCuenta + "'"
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                datatbl.Read()
                xtexto.Text = datatbl(1)
            Else
                MsgBox("No Existe Cuenta Contable")

            End If

            close_conexion()
        End If
    End Sub


    Private Sub txt_CtaCtbleExistencias_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_CtaCtbleExistencias.TextChanged

    End Sub

    Private Sub txt_CtaCtbleVentas_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_CtaCtbleVentas.Leave
        REM Ventas
        If txt_CtaCtbleVentas.Text <> Nothing Then
            Valida_Cuenta(txt_CtaCtbleVentas.Text, txt_DesCtaVentas, txt_CtaCtbleVentas)
        End If
    End Sub

    Private Sub txt_CtaCtbleVentas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_CtaCtbleVentas.TextChanged

    End Sub

    Private Sub txt_CtaCtbleGastosProduccion_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_CtaCtbleGastosProduccion.Leave
        REM Gastos de Producción
        If txt_CtaCtbleGastosProduccion.Text <> Nothing Then
            Valida_Cuenta(txt_CtaCtbleGastosProduccion.Text, txt_DesCtaGastoProduccion, txt_CtaCtbleGastosProduccion)
        End If
    End Sub

    Private Sub txt_CtaCtbleGastosProduccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_CtaCtbleGastosProduccion.TextChanged

    End Sub

    Private Sub txt_CtaCtbleCostoVenta_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_CtaCtbleCostoVenta.Leave
        REM Costos de Venta
        If txt_CtaCtbleCostoVenta.Text <> Nothing Then
            Valida_Cuenta(txt_CtaCtbleCostoVenta.Text, txt_DesCtaCostoVenta, txt_CtaCtbleCostoVenta)
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Semillas_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Carga_Lista_Full_Semillas()
        Carga_Centro_Costo(cmb_CentroCosto)
        CargaGrillaFamilia()
    End Sub
End Class