Imports System.Deployment.Application
Public Class LoginForm1

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
        Dim ver As String

        If ApplicationDeployment.IsNetworkDeployed Then
            ver = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
        Else
            ' Cuando ejecutas desde Visual Studio (F5) o exe suelto
            ver = My.Application.Info.Version.ToString()
        End If

        lblversion.Text = "Versión: " & ver
        ' lblversion.Text = "Versión: " & ObtenerVersionClickOnce()

    End Sub

    Public Function ObtenerVersionClickOnce() As String
        If ApplicationDeployment.IsNetworkDeployed Then
            Dim v = ApplicationDeployment.CurrentDeployment.CurrentVersion
            Return $"{v.Major}.{v.Minor}.{v.Build}.{v.Revision}"
        Else
            Return Application.ProductVersion
        End If
    End Function
End Class
