Public Class RegistroVehiculo

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        LimpiaCampos()
    End Sub


    Private Sub LimpiaCampos()
        txtPatente.Clear()
        txtkminicial.Clear()
        txtLtsinicial.Clear()
        txtVehiculo.Clear()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        REM graba datos
        If ValidaDatos() = True Then
            GrabaDatos()
        End If
    End Sub

    Function ValidaDatos() As Boolean
        Dim bRetorno As Boolean = True

        If Len(txtPatente.Text) <> 6 Then
            MsgBox("Patente no es válida. Debe contener 6 caracteres.", MsgBoxStyle.Exclamation)
            bRetorno = False
        End If

        If txtVehiculo.Text = Nothing Then
            MsgBox("Debe Ingresar descripción del Vehículo", MsgBoxStyle.Exclamation)
            bRetorno = False
        End If

        If Val(txtkminicial.Text) = 0 Then
            MsgBox("Debe Ingresar Kilometraje inicial del Vehículo, corresponde a la fecha anterior a la primera Guía de Combustible que se va a ingresar.", MsgBoxStyle.Exclamation)
            bRetorno = False
        End If

        ValidaDatos = bRetorno

    End Function

    Private Sub GrabaDatos()
        '@Patente varchar(6),
        '@Vehiculo varchar(50),
        '@KMInicial numeric(10,2),
        '@LtsInicial numeric(10,2),
        '@Transaccion varchar(1)
        sSsql = "SP_ActualizaVehiculo "
        sSsql += "'" + txtPatente.Text + "',"
        sSsql += "'" + txtVehiculo.Text + "',"
        sSsql += Reemplaza_Comas(txtkminicial.Text) + ","
        sSsql += Reemplaza_Comas(Val(txtLtsinicial.Text)) + ","
        sSsql += "'A'"


        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()
        close_conexion()
        LeetVehiculo()

    End Sub

    Private Sub LeetVehiculo()
        Dim i As Integer
        sSsql = "SP_ConsultaVehiculo"
        open()

        i = 0
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

        close_conexion()
    End Sub

    Private Sub RegistroVehiculo_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        LeetVehiculo()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim iFilaActual As Integer
        iFilaActual = GrillaVehiculo.CurrentRow.Index
        txtPatente.Text = GrillaVehiculo.Rows(iFilaActual).Cells(0).Value
        txtVehiculo.Text = GrillaVehiculo.Rows(iFilaActual).Cells(1).Value
        txtkminicial.Text = GrillaVehiculo.Rows(iFilaActual).Cells(2).Value
        txtLtsinicial.Text = GrillaVehiculo.Rows(iFilaActual).Cells(3).Value
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        REM Delete
        Dim iFilaActual As Integer
        iFilaActual = GrillaVehiculo.CurrentRow.Index

        Dim sResp = MsgBox("Confirme Eliminación de Vehículo: " & GrillaVehiculo.Rows(iFilaActual).Cells(1).Value, MsgBoxStyle.YesNo, "Registro de Vehículos")
        If sResp = MsgBoxResult.Yes Then
            sSsql = "SP_ActualizaVehiculo "
            sSsql += "'" + GrillaVehiculo.Rows(iFilaActual).Cells(0).Value + "',"
            sSsql += "'',"
            sSsql += "0,"
            sSsql += "0,"
            sSsql += "'E'"
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            command.ExecuteNonQuery()
            close_conexion()
            MsgBox("Vehículo será Eliminado solo si no tiene registros de Guías de Combustible.", MsgBoxStyle.Information)
            LeetVehiculo()
        End If
    End Sub
End Class