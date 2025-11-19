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

        If txtNuevaPassword.Text <> txtNuevaPassword2.Text Then
            MsgBox(" Contraseñas nuevas no coinciden!!!.", MsgBoxStyle.Exclamation)
            bRetorno = False
        End If

        ValidaNuevaPassWord = bRetorno

    End Function
    Function ValidaPassword() As Boolean
        Dim bRetorno As Boolean = True

        sSsql = "SP_ValidaUsuario "
        sSsql += "'" + gUSER + "',"
        sSsql += "'" + txtpasswordActual.Text + "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            If datatbl(0) = 1 Then
                MsgBox("Usuario no registrado.", MsgBoxStyle.Exclamation)
                bRetorno = False
            End If
        Else
            MsgBox("Contraseña Actual no coincide.", MsgBoxStyle.Exclamation)
            bRetorno = False
        End If
        close_conexion()


        ValidaPassword = bRetorno
    End Function
    Private Sub GrabaNuevaPassWord()
        Try
            sSsql = "SP_CambioPassword "
            sSsql += "'" + gUSER + "',"
            sSsql += "'" + txtNuevaPassword.Text + "'"
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            command.ExecuteNonQuery()
            MsgBox("La nueva contraseña ha sido actualizada.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        close_conexion()

    End Sub

    Private Sub CambioPassword_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtpasswordActual.Focus()
    End Sub
End Class
