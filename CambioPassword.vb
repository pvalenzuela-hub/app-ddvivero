Imports System.Windows.Forms

Public Class CambioPassword

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        If ValidaPassword() Then
            If ValidaNuevaPassWord() Then
                GrabaNuevaPassWord()
                Me.Close()
            End If
        End If
        txtpasswordActual.Focus()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Function ValidaNuevaPassWord() As Boolean
        Dim bRetorno As Boolean = True

        If String.IsNullOrWhiteSpace(txtNuevaPassword.Text) Then
            MsgBox("La nueva contraseña no puede estar vacía.", MsgBoxStyle.Exclamation)
            bRetorno = False
        End If

        If txtNuevaPassword.Text <> txtNuevaPassword2.Text Then
            MsgBox(" Contraseñas nuevas no coinciden!!!.", MsgBoxStyle.Exclamation)
            bRetorno = False
        End If

        ValidaNuevaPassWord = bRetorno

    End Function
    Function ValidaPassword() As Boolean
        Dim resultado = ValidaUsuarioSP(gUSER, txtpasswordActual.Text)

        Select Case resultado
            Case ResultadoValidaUsuario.Correcto
                Return True
            Case ResultadoValidaUsuario.UsuarioNoRegistrado
                MsgBox("Usuario no registrado.", MsgBoxStyle.Exclamation)
            Case Else
                MsgBox("Contraseña Actual no coincide.", MsgBoxStyle.Exclamation)
        End Select

        Return False
    End Function
    Private Sub GrabaNuevaPassWord()
        open()

        Try
            command = connection.CreateCommand()
            command.CommandText = "SP_CambioPassword"
            command.CommandType = System.Data.CommandType.StoredProcedure
            command.Parameters.Add("@IdUsuario", System.Data.SqlDbType.VarChar, 10).Value = gUSER.Trim()
            command.Parameters.Add("@NuevaPassWord", System.Data.SqlDbType.VarChar, 50).Value = txtNuevaPassword.Text
            command.ExecuteNonQuery()
            MsgBox("La nueva contraseña ha sido actualizada.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            close_conexion()
        End Try

    End Sub

    Private Sub CambioPassword_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtpasswordActual.Focus()
    End Sub
End Class
