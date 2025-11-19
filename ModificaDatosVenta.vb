Imports System.Windows.Threading

Public Class ModificaDatosVenta

    Private Sub ModificaDatosVenta_Load(sender As Object, e As EventArgs) Handles Me.Load
        If gQuienLlama = 5 Then
            lbltitulo.Text = "Modifica N° Documento SII"
            txtDocSII.ReadOnly = False
            txtDocSII.Select()

        End If

        If gQuienLlama = 6 Then
            lbltitulo.Text = "Modifica Tipo de Documento SII"
            cmbTipoDocSII.Enabled = True
            cmbTipoDocSII.Select()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ActualizaDatos()
        sSsql = "[SP_ACTUALIZA_TipoDoc_DocSII] "
        sSsql += txtIdVtaHead.Text.ToString() & ","
        sSsql += gQuienLlama.ToString() & ","
        If gQuienLlama = 5 Then
            sSsql += "'" & txtDocSII.Text & "',Null"
        Else
            sSsql += "Null,'" & cmbTipoDocSII.Text & "'"
        End If
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()

        close_conexion()
        ModificaDocumentoVenta.EjecutaBusqueda()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sTituloVentana As String = "Modifica Datos Documento de Venta"
        Dim bGRaba As Boolean = True

        If gQuienLlama = 6 AndAlso (cmbTipoDocSII.Text = Nothing OrElse cmbTipoDocSII.Text = "") Then
            MsgBox("No ha seleccionado Tipo de documento SII. no se actualizarán los datos", MsgBoxStyle.Exclamation, sTituloVentana)
            bGRaba = False
        End If

        If gQuienLlama = 5 AndAlso Val(txtDocSII.Text) = 0 Then
            MsgBox("Debe Ingresar N° doc. SII.", MsgBoxStyle.Exclamation, sTituloVentana)
            bGRaba = False
        End If

        If bGRaba Then
            ActualizaDatos()
        End If

    End Sub
End Class