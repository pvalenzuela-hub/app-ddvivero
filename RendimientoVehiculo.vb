Public Class RendimientoVehiculo

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        If ValidaDatos() = True Then
            GrabarGuias()
        End If

    End Sub
    Function ValidaDatos() As Boolean
        Dim bRetorno As Boolean = True

        If Val(txtFolio.Text) <= 0 Then
            MsgBox("Debe Ingresar N° de Guía Válido.", MsgBoxStyle.Critical)
            bRetorno = False
        End If

        If cmbPatente.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Vehículo.", MsgBoxStyle.Critical)
            bRetorno = False
        End If

        If Val(txtLtsConsumo.Text) <= 0 Then
            MsgBox("Debe Ingresar Carga de Combustible en Litros.", MsgBoxStyle.Critical)
            bRetorno = False
        End If

        If Val(txtKmFinal.Text) <= 0 Then
            MsgBox("Kilometraje actual no es válido.", MsgBoxStyle.Critical)
            bRetorno = False
        End If

        ValidaDatos = bRetorno

    End Function
    Private Sub GrabarGuias()
        '@Folio numeric(18,0),
        '@Patente varchar(6),
        '@Fecha date,
        '@KmFinal numeric(10,2),
        '@LtsConsumo numeric(10,2)


        sSsql = "SP_ActualizaConsumoPetroleo "
        sSsql += Val(txtFolio.Text).ToString + ","
        sSsql += "'" + cmbPatente.Text + "',"
        sSsql += "'" + dtpFecha.Value + "',"
        sSsql += Reemplaza_Comas(txtKmFinal.Text) + ","
        sSsql += Reemplaza_Comas(txtLtsConsumo.Text)

        open()

        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()

        close_conexion()

        MsgBox("Datos han sido actualizados.", MsgBoxStyle.Information)
        ConsultaguiasCombustible(cmbPatente.Text)
        MsgBox("Revise Rendimiento Promedio de la tabla de vehículos.")
        ConsultaVehiculo()
    End Sub

    Private Sub RendimientoVehiculo_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet45.SP_ConsultaGuiaCombustible' Puede moverla o quitarla según sea necesario.
        Me.SP_ConsultaGuiaCombustibleTableAdapter.Connection.ConnectionString = gSOURCE
        CargaVehiculo(cmbPatente)
        CargaVehiculo(cmbPatenteFiltro)
        ConsultaguiasCombustible("")

    End Sub

    Private Sub ConsultaVehiculo()
        Dim i As Integer = 0
        sSsql = "SP_ConsultaVehiculo"

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        GrillaVehiculo.Rows.Clear()
        If datatbl.HasRows Then
            While datatbl.Read = True
                GrillaVehiculo.Rows.Add()
                GrillaVehiculo.Rows(i).Cells(0).Value = datatbl(0)
                GrillaVehiculo.Rows(i).Cells(1).Value = datatbl(1)
                GrillaVehiculo.Rows(i).Cells(2).Value = datatbl(2)
                GrillaVehiculo.Rows(i).Cells(3).Value = datatbl(3)
                GrillaVehiculo.Rows(i).Cells(4).Value = datatbl(4)
                i += 1
            End While
        End If

    End Sub

    Private Sub ConsultaguiasCombustible(sPatente As String)
        Dim i As Integer = 0
        sSsql = "SP_ConsultaGuiaCombustible "
        If sPatente = "" Then
            sSsql += "Null"
        Else
            sSsql += "'" + sPatente + "'"
        End If

        open()

        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        GrillaConsumo.Rows.Clear()
        If datatbl.HasRows Then
            While datatbl.Read = True
                GrillaConsumo.Rows.Add()
                GrillaConsumo.Rows(i).Cells(0).Value = datatbl(0)
                GrillaConsumo.Rows(i).Cells(1).Value = datatbl(1)
                GrillaConsumo.Rows(i).Cells(2).Value = datatbl(2)
                GrillaConsumo.Rows(i).Cells(3).Value = datatbl(3)
                GrillaConsumo.Rows(i).Cells(4).Value = datatbl(4)
                GrillaConsumo.Rows(i).Cells(5).Value = datatbl(5)
                i += 1
            End While
        End If
        close_conexion()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If ValidaDatos() = True Then
            GrabarGuias()
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        REM limpa campos
        LimpiaCampos()
    End Sub
    Private Sub LimpiaCampos()
        txtFolio.Clear()
        dtpFecha.Value = Now.Date
        cmbPatente.SelectedIndex = -1
        txtLtsConsumo.Clear()
        txtKmFinal.Clear()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim iFilaActual As Integer
        iFilaActual = GrillaConsumo.CurrentRow.Index
        txtFolio.Text = GrillaConsumo.Rows(iFilaActual).Cells(0).Value
        dtpFecha.Value = GrillaConsumo.Rows(iFilaActual).Cells(1).Value
        cmbPatente.Text = GrillaConsumo.Rows(iFilaActual).Cells(2).Value
        txtLtsConsumo.Text = GrillaConsumo.Rows(iFilaActual).Cells(3).Value
        txtKmFinal.Text = GrillaConsumo.Rows(iFilaActual).Cells(4).Value
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        REM Delete
        Dim iFilaActual As Integer
        iFilaActual = GrillaConsumo.CurrentRow.Index

        Dim sResp = MsgBox("Confirme Eliminación de Guía: " & GrillaConsumo.Rows(iFilaActual).Cells(0).Value, MsgBoxStyle.YesNo, "Registro Rendimiento")
        If sResp = MsgBoxResult.Yes Then
            sSsql = "SP_EliminaGuiaConsumoPetroleo "
            sSsql += GrillaConsumo.Rows(iFilaActual).Cells(0).Value.ToString
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            command.ExecuteNonQuery()
            close_conexion()
            MsgBox("Guía ha sido Eliminada, Los rendimientos Promedios serán Recalculados.", MsgBoxStyle.Information)
            ConsultaguiasCombustible("")
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ConsultaguiasCombustible(cmbPatenteFiltro.Text)
        Me.SP_ConsultaGuiaCombustibleTableAdapter.Fill(Me.GESTDataSet45.SP_ConsultaGuiaCombustible, cmbPatenteFiltro.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class