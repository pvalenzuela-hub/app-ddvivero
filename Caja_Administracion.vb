Imports System.Data
Imports System.Data.SqlClient

Public Class Caja_Administracion
    Private _currentUsuario As String = String.Empty

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Caja_Administracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaCajas()
        CargaCajeros()
    End Sub

    Private Sub CargaCajas()
        cmbCaja.Items.Clear()
        Carga_CajasDiarias(cmbCaja, gCuentaCaja)
        If cmbCaja.Items.Count > 0 Then cmbCaja.SelectedIndex = -1
    End Sub

    Private Sub CargaCajeros()
        Dim tabla As New DataTable()
        open()
        Try
            Using cmd As SqlCommand = connection.CreateCommand()
                cmd.CommandText = "SELECT IdUsuario, NOMBRE, ISNULL(Cta_Caja_Activa,'') AS Cta_Caja_Activa, CASE WHEN ISNULL(Cta_Caja_Activa,'')='' THEN 'SIN CAJA ASIGNADA' ELSE 'CAJA ASIGNADA' END AS Estado FROM VENDEDOR WHERE ISNULL(EsCajero,0)=1 ORDER BY NOMBRE"
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(tabla)
                End Using
            End Using
        Finally
            close_conexion()
        End Try

        grdCajeros.DataSource = tabla
        If grdCajeros.Columns.Contains("IdUsuario") Then grdCajeros.Columns("IdUsuario").HeaderText = "Usuario"
        If grdCajeros.Columns.Contains("NOMBRE") Then grdCajeros.Columns("NOMBRE").HeaderText = "Nombre"
        If grdCajeros.Columns.Contains("Cta_Caja_Activa") Then grdCajeros.Columns("Cta_Caja_Activa").HeaderText = "Caja Activa"
        If grdCajeros.Columns.Contains("Estado") Then grdCajeros.Columns("Estado").HeaderText = "Estado"
        If grdCajeros.Columns.Contains("IdUsuario") Then grdCajeros.Columns("IdUsuario").Width = 110
    End Sub

    Private Function UsuarioSeleccionado() As String
        If grdCajeros.CurrentRow Is Nothing Then Return String.Empty
        Return Convert.ToString(grdCajeros.CurrentRow.Cells("IdUsuario").Value)
    End Function

    Private Sub btnLiberar_Click(sender As Object, e As EventArgs) Handles btnLiberar.Click
        Dim usuario = UsuarioSeleccionado()
        If String.IsNullOrWhiteSpace(usuario) Then
            MessageBox.Show("Seleccione un cajero en la grilla.", "Caja", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim mensaje As String = String.Empty
        If LiberaCajaActivaUsuarioSP(usuario, mensaje) Then
            MessageBox.Show($"Usuario {usuario}: {mensaje}", "Caja", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargaCajeros()
        Else
            MessageBox.Show(mensaje, "Caja", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnReasignar_Click(sender As Object, e As EventArgs) Handles btnReasignar.Click
        Dim usuario = UsuarioSeleccionado()
        If String.IsNullOrWhiteSpace(usuario) Then
            MessageBox.Show("Seleccione un cajero en la grilla.", "Caja", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbCaja.SelectedValue Is Nothing Then
            MessageBox.Show("Debe seleccionar una caja.", "Caja", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim mensaje As String = String.Empty
        If Not EstableceCajaActivaUsuario(usuario, Convert.ToString(cmbCaja.SelectedValue), mensaje) Then
            If mensaje.IndexOf("duplicada", StringComparison.OrdinalIgnoreCase) >= 0 OrElse mensaje.IndexOf("asignada", StringComparison.OrdinalIgnoreCase) >= 0 Then
                mensaje = "La caja ya está asignada a otro usuario. Seleccione otra caja."
            End If
            MessageBox.Show(mensaje, "Caja", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        CargaCajeros()
        MessageBox.Show($"Usuario {usuario}: caja asignada correctamente.", "Caja", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub
End Class
