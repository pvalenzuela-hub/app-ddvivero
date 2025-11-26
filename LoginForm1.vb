Public Class LoginForm1

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If ValidaAcceso() Then
            Principal.Visible = True
            Me.Visible = False
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
    Function ValidaAcceso() As Boolean
        Dim bRetorno As Boolean = True

        sSsql = "SP_ValidaUsuario "
        sSsql += "'" & txtIdusuario.Text & "',"
        sSsql += "'" & txtPassWord.Text & "'"

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            datatbl.Read()
            If datatbl(0) = 1 Then
                MsgBox("Usuario no registrado.", MsgBoxStyle.Exclamation)
                bRetorno = False
            Else
                gIdVendedor = datatbl(1)
                gUSER = datatbl(2)
                gNomUsuario = datatbl(3)
                gIdPerfil = datatbl(5)
                gEsAutorizador = datatbl("EsAutorizador")
            End If
        Else
            MsgBox("Contraseña no coincide.", MsgBoxStyle.Exclamation)
            bRetorno = False
        End If

        close_conexion()

        Return bRetorno
    End Function

    Private Sub LoginForm1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LecturaINI()
    End Sub

End Class
