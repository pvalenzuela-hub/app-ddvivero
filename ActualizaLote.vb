Imports System.Data.SqlClient

Public Class ActualizaLote
    Private idTipoBandejaOriginal As Integer = -1

    Public Sub CargarDatos(ByVal lote As String, ByVal semilla As String, ByVal variedad As String,
                           ByVal nave As String, ByVal loteSemilla As String, ByVal batch As String,
                           ByVal fechaEnvasado As String, ByVal ubicacion As String, ByVal comentarios As String,
                           ByVal tiposBandeja As Object)
        txtLote.Text = lote
        txtSemilla.Text = semilla
        txtVariedad.Text = variedad
        txtNave.Text = nave
        txtLoteSemilla.Text = loteSemilla
        txtBatch.Text = batch
        txtFechaEnvasado.Text = fechaEnvasado
        txtUbicacion.Text = ubicacion
        txtComentarios.Text = comentarios
        cmbTipoBandeja.DataSource = tiposBandeja
        cmbTipoBandeja.DisplayMember = "Descripcion"
        cmbTipoBandeja.ValueMember = "IdTipoBandeja"
        cmbTipoBandeja.SelectedIndex = -1
        SeleccionaTipoBandejaActual()
    End Sub

    Private Sub btnSeleccionarVariedad_Click(sender As Object, e As EventArgs) Handles btnSeleccionarVariedad.Click
        Dim seleccion As New SeleccionVariedad()
        seleccion.Familia = txtSemilla.Text

        If seleccion.ShowDialog(Me) = DialogResult.OK Then
            txtVariedad.Text = seleccion.VariedadSeleccionada
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Val(txtLote.Text) <= 0 Then
            MsgBox("N° de lote no es válido.", MsgBoxStyle.Exclamation, "Modificar lote")
            Exit Sub
        End If

        If txtVariedad.Text.Trim() = "" Then
            MsgBox("Debe seleccionar una variedad.", MsgBoxStyle.Exclamation, "Modificar lote")
            Exit Sub
        End If

        sSsql = "SP_ACTUALIZAEDatosLote "
        sSsql += Val(txtLote.Text).ToString() & ","
        sSsql += "'" & TextoSql(txtSemilla.Text) & "',"
        sSsql += "'" & TextoSql(txtVariedad.Text) & "',"
        sSsql += "NULL,"
        sSsql += Val(txtNave.Text).ToString() & ","
        sSsql += "'" & TextoSql(txtLoteSemilla.Text) & "',"
        sSsql += "'" & TextoSql(txtBatch.Text) & "',"
        sSsql += "'" & TextoSql(txtFechaEnvasado.Text) & "',"
        sSsql += "'" & TextoSql(txtUbicacion.Text) & "',"
        sSsql += "'" & TextoSql(txtComentarios.Text) & "'"

        open()
        Dim comando As SqlCommand = connection.CreateCommand()
        comando.CommandText = sSsql
        comando.ExecuteNonQuery()
        close_conexion()

        If cmbTipoBandeja.SelectedIndex > -1 AndAlso CInt(cmbTipoBandeja.SelectedValue) <> idTipoBandejaOriginal Then
            sSsql = "UPDATE Pedido_Detalle SET IdTipoBandeja=" & cmbTipoBandeja.SelectedValue.ToString() &
                    " WHERE IdPedidodet=" & Val(txtLote.Text).ToString()
            open()
            comando = connection.CreateCommand()
            comando.CommandText = sSsql
            comando.ExecuteNonQuery()
            close_conexion()
        End If

        MsgBox("Los datos del lote han sido actualizados.", MsgBoxStyle.Information, "Modificar lote")
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Function TextoSql(ByVal texto As String) As String
        Return texto.Replace("'", "''")
    End Function

    Private Sub SeleccionaTipoBandejaActual()
        sSsql = "SELECT IdTipoBandeja FROM Pedido_Detalle WHERE IdPedidodet=" & Val(txtLote.Text).ToString()
        open()
        Dim comando As SqlCommand = connection.CreateCommand()
        comando.CommandText = sSsql
        Dim resultado As Object = comando.ExecuteScalar()
        close_conexion()

        If resultado IsNot Nothing AndAlso Not IsDBNull(resultado) Then
            idTipoBandejaOriginal = CInt(resultado)
            cmbTipoBandeja.SelectedValue = idTipoBandejaOriginal
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub
End Class
