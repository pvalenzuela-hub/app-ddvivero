Public Class Vendedores
    Private esNuevoUsuario As Boolean

    Private Sub Vendedores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If gIdPerfil <> 1 Then
            MsgBox("Solo el perfil Administrador puede acceder al módulo Usuarios.", MsgBoxStyle.Exclamation, "Usuarios")
            Me.Close()
            Exit Sub
        End If
        CargaPerfiles()
        CargaVendedores()
        btnRestablecerPassword.Visible = True
    End Sub

    Private Sub CargaVendedores()
        Dim i As Integer
        DataVendedor.Rows.Clear()
        sSsql = "SELECT V.IdVendedor, V.NOMBRE, V.PorComision, V.IdUsuario, ISNULL(V.EsCajero,0) AS EsCajero, V.IdPerfil, ISNULL(P.DescPerfil,'') AS Perfil FROM VENDEDOR V LEFT JOIN Perfil P ON P.IdPerfil = V.IdPerfil ORDER BY V.NOMBRE"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            While datatbl.Read = True
                DataVendedor.Rows.Add()
                DataVendedor.Rows(i).Cells(0).Value = datatbl(0)
                DataVendedor.Rows(i).Cells(1).Value = datatbl(1)
                DataVendedor.Rows(i).Cells(2).Value = datatbl(2)
                DataVendedor.Rows(i).Cells(3).Value = datatbl(3)
                DataVendedor.Rows(i).Cells(4).Value = If(Convert.ToInt32(datatbl(4)) = 1, "Si", "No")
                DataVendedor.Rows(i).Cells(5).Value = datatbl(5)
                DataVendedor.Rows(i).Cells(6).Value = datatbl(6)
                i += 1
            End While
        End If
        close_conexion()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LimpiaCampos()
        esNuevoUsuario = True
        txtUsuario.ReadOnly = False
        txtPassword.Enabled = True
    End Sub

    Private Sub LimpiaCampos()
        esNuevoUsuario = False
        txt_Codigo.Clear()
        txt_Vendedor.Clear()
        txtUsuario.Clear()
        txtPassword.Clear()
        txtPassword.Enabled = False
        txtUsuario.ReadOnly = True
        txtporcomis.Clear()
        cmbPerfil.SelectedIndex = -1
        chkEsCajero.Checked = False
        txt_Vendedor.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If esNuevoUsuario Then
            If RegistraNuevoUsuario() Then
                LimpiaCampos()
            End If
        ElseIf ActualizaVendedor() Then
            LimpiaCampos()
        End If
    End Sub

    Private Function ActualizaVendedor() As Boolean
        Dim idVendedor As Integer = Val(txt_Codigo.Text)
        If idVendedor = 0 Then
            MsgBox("Debe seleccionar un usuario antes de actualizarlo.", MsgBoxStyle.Exclamation, "Usuarios")
            Return False
        End If
        If Not DatosUsuarioValidos(False) Then
            Return False
        End If

        open()
        Try
            command = connection.CreateCommand()
            command.CommandText = "UPDATE VENDEDOR SET NOMBRE=@NOMBRE, PorComision=@PorComision, IdPerfil=@IdPerfil, EsCajero=@EsCajero WHERE IdVendedor=@IdVendedor"
            command.Parameters.AddWithValue("@IdVendedor", idVendedor)
            command.Parameters.AddWithValue("@NOMBRE", txt_Vendedor.Text.Trim())
            command.Parameters.AddWithValue("@PorComision", Val(txtporcomis.Text))
            command.Parameters.AddWithValue("@IdPerfil", Convert.ToInt32(cmbPerfil.SelectedValue))
            command.Parameters.AddWithValue("@EsCajero", If(chkEsCajero.Checked, 1, 0))
            command.ExecuteNonQuery()
        Finally
            close_conexion()
        End Try
        MsgBox("Vendedor ha sido Actualizado.")
        CargaVendedores()
        Return True
    End Function

    Private Function RegistraNuevoUsuario() As Boolean
        If Not DatosUsuarioValidos(True) Then
            Return False
        End If

        open()
        Try
            command = connection.CreateCommand()
            command.CommandText = "INSERT INTO VENDEDOR (IdUsuario, NOMBRE, PorComision, Contrasena, IdPerfil, EsAutorizador, EsCajero) VALUES (@IdUsuario, @NOMBRE, @PorComision, HASHBYTES('SHA2_256', @Contrasena), @IdPerfil, 0, @EsCajero)"
            command.Parameters.AddWithValue("@IdUsuario", txtUsuario.Text.Trim())
            command.Parameters.AddWithValue("@NOMBRE", txt_Vendedor.Text.Trim())
            command.Parameters.AddWithValue("@PorComision", Val(txtporcomis.Text))
            command.Parameters.AddWithValue("@Contrasena", txtPassword.Text)
            command.Parameters.AddWithValue("@IdPerfil", Convert.ToInt32(cmbPerfil.SelectedValue))
            command.Parameters.AddWithValue("@EsCajero", If(chkEsCajero.Checked, 1, 0))
            command.ExecuteNonQuery()
        Catch ex As System.Data.SqlClient.SqlException When ex.Number = 2601 OrElse ex.Number = 2627
            MsgBox("El nombre de usuario ya está registrado.", MsgBoxStyle.Exclamation, "Usuarios")
            Return False
        Finally
            close_conexion()
        End Try

        MsgBox("Usuario registrado correctamente.", MsgBoxStyle.Information, "Usuarios")
        CargaVendedores()
        Return True
    End Function

    Private Function DatosUsuarioValidos(ByVal esNuevo As Boolean) As Boolean
        If txt_Vendedor.Text.Trim() = "" Then
            MsgBox("Debe ingresar el nombre del usuario.", MsgBoxStyle.Exclamation, "Usuarios")
            Return False
        End If
        If cmbPerfil.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un perfil para el usuario.", MsgBoxStyle.Exclamation, "Usuarios")
            Return False
        End If
        If esNuevo AndAlso txtUsuario.Text.Trim() = "" Then
            MsgBox("Debe ingresar el nombre de usuario.", MsgBoxStyle.Exclamation, "Usuarios")
            Return False
        End If
        If esNuevo AndAlso txtPassword.Text = "" Then
            MsgBox("Debe ingresar una contraseña.", MsgBoxStyle.Exclamation, "Usuarios")
            Return False
        End If
        Return True
    End Function

    Private Sub CargaPerfiles()
        Dim perfiles As New DataTable()
        open()
        Try
            command = connection.CreateCommand()
            command.CommandText = "SELECT IdPerfil, DescPerfil FROM Perfil ORDER BY DescPerfil"
            datatbl = command.ExecuteReader()
            perfiles.Load(datatbl)
        Finally
            close_conexion()
        End Try

        cmbPerfil.DataSource = perfiles
        cmbPerfil.DisplayMember = "DescPerfil"
        cmbPerfil.ValueMember = "IdPerfil"
        cmbPerfil.SelectedIndex = -1
    End Sub

    Private Sub btnRestablecerPassword_Click(sender As Object, e As EventArgs) Handles btnRestablecerPassword.Click
        If gIdPerfil <> 1 Then
            MsgBox("Solo el perfil Administrador puede restablecer contraseñas.", MsgBoxStyle.Exclamation, "Usuarios")
            Exit Sub
        End If
        If DataVendedor.CurrentRow Is Nothing Then
            MsgBox("Debe seleccionar un usuario.", MsgBoxStyle.Exclamation, "Usuarios")
            Exit Sub
        End If

        Dim fila As Integer = DataVendedor.CurrentRow.Index
        Dim idUsuario As String = Convert.ToString(DataVendedor.Rows(fila).Cells(3).Value).Trim()
        Dim nuevaContrasena As String = String.Empty
        If Not SolicitaNuevaContrasena(nuevaContrasena) Then
            Exit Sub
        End If
        If MsgBox("Confirma restablecer la contraseña de " & idUsuario & "?", MsgBoxStyle.YesNo, "Usuarios") <> MsgBoxResult.Yes Then
            Exit Sub
        End If

        Dim resultado As Integer = -99
        open()
        Try
            command = connection.CreateCommand()
            command.CommandText = "SP_RESTABLECE_PASSWORD_USUARIO"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@IdAdministrador", gUSER.Trim())
            command.Parameters.AddWithValue("@IdUsuario", idUsuario)
            command.Parameters.AddWithValue("@NuevaContrasena", nuevaContrasena)
            datatbl = command.ExecuteReader()
            If datatbl.Read() Then
                resultado = Convert.ToInt32(datatbl(0))
            End If
        Finally
            close_conexion()
        End Try

        Select Case resultado
            Case 0
                MsgBox("Contraseña restablecida correctamente.", MsgBoxStyle.Information, "Usuarios")
            Case -1
                MsgBox("Solo el perfil Administrador puede restablecer contraseñas.", MsgBoxStyle.Exclamation, "Usuarios")
            Case Else
                MsgBox("No fue posible restablecer la contraseña del usuario.", MsgBoxStyle.Critical, "Usuarios")
        End Select
    End Sub

    Private Function SolicitaNuevaContrasena(ByRef nuevaContrasena As String) As Boolean
        Dim dialogo As New Form() With {
            .Text = "Restablecer contraseña",
            .ClientSize = New Size(310, 130),
            .FormBorderStyle = FormBorderStyle.FixedDialog,
            .MaximizeBox = False,
            .MinimizeBox = False,
            .ShowInTaskbar = False,
            .StartPosition = FormStartPosition.CenterParent
        }
        Dim lblContrasena As New Label() With {.Text = "Nueva contraseña", .AutoSize = True, .Location = New Point(12, 18)}
        Dim txtContrasena As New TextBox() With {.Location = New Point(130, 15), .Size = New Size(165, 20), .UseSystemPasswordChar = True, .MaxLength = 50}
        Dim lblConfirmacion As New Label() With {.Text = "Confirmar", .AutoSize = True, .Location = New Point(12, 51)}
        Dim txtConfirmacion As New TextBox() With {.Location = New Point(130, 48), .Size = New Size(165, 20), .UseSystemPasswordChar = True, .MaxLength = 50}
        Dim btnAceptar As New Button() With {.Text = "Aceptar", .Location = New Point(130, 88), .Size = New Size(75, 27), .DialogResult = DialogResult.OK}
        Dim btnCancelar As New Button() With {.Text = "Cancelar", .Location = New Point(220, 88), .Size = New Size(75, 27), .DialogResult = DialogResult.Cancel}

        dialogo.Controls.AddRange(New Control() {lblContrasena, txtContrasena, lblConfirmacion, txtConfirmacion, btnAceptar, btnCancelar})
        dialogo.AcceptButton = btnAceptar
        dialogo.CancelButton = btnCancelar

        If dialogo.ShowDialog(Me) <> DialogResult.OK Then
            Return False
        End If
        If txtContrasena.Text = "" Then
            MsgBox("La contraseña no puede estar vacía.", MsgBoxStyle.Exclamation, "Usuarios")
            Return False
        End If
        If txtContrasena.Text <> txtConfirmacion.Text Then
            MsgBox("Las contraseñas no coinciden.", MsgBoxStyle.Exclamation, "Usuarios")
            Return False
        End If

        nuevaContrasena = txtContrasena.Text
        Return True
    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        EliminaVendedor()
        LimpiaCampos()
    End Sub

    Private Sub EliminaVendedor()
        Dim sResp As String
        Dim sVendedor As String
        Dim iCodigo As Integer
        Dim FilaGrilla As Integer
        sResp = InputBox("Confirmación Eliminación de Vendedor", "Eliminación de Vendedor", "S")
        If UCase(sResp) = "S" Then
            FilaGrilla = DataVendedor.CurrentRow.Index
            iCodigo = DataVendedor.Rows(FilaGrilla).Cells(0).Value
            sVendedor = DataVendedor.Rows(FilaGrilla).Cells(1).Value

            If iCodigo = 0 Then
                MsgBox("Código de Vendedor no válido. Debe Seleccionar Vendedor a Eliminar.")
                Exit Sub
            End If
            sSsql = "SP_EliminaVendedor "
            sSsql += iCodigo.ToString
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                datatbl.Read()
                If datatbl(0) = -1 Then
                    MsgBox("No ha sido posible Eliminar Vendedor: " & sVendedor & ". Vendedor tiene transacciones en el Sistema.")
                Else
                    MsgBox("Vendedor ha sido Eliminado del sistema.")
                End If
            End If
            close_conexion()
            CargaVendedores()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim FilaGrilla As Integer
        esNuevoUsuario = False
        FilaGrilla = DataVendedor.CurrentRow.Index
        txt_Codigo.Text = DataVendedor.Rows(FilaGrilla).Cells(0).Value
        txt_Vendedor.Text = DataVendedor.Rows(FilaGrilla).Cells(1).Value
        txtUsuario.Text = DataVendedor.Rows(FilaGrilla).Cells(3).Value
        txtPassword.Clear()
        txtPassword.Enabled = False
        txtUsuario.ReadOnly = True
        txtporcomis.Text = DataVendedor.Rows(FilaGrilla).Cells(2).Value
        cmbPerfil.SelectedValue = Val(DataVendedor.Rows(FilaGrilla).Cells(5).Value)
        chkEsCajero.Checked = String.Equals(Convert.ToString(DataVendedor.Rows(FilaGrilla).Cells(4).Value), "Si", StringComparison.OrdinalIgnoreCase)
    End Sub

    Private Sub DataVendedor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataVendedor.CellContentClick

    End Sub
End Class
