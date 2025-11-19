Imports System.Data.SqlClient
Public Class Variedad

    Private Sub Variedad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Carga_Familia_Prod(Me.cmb_Familia)
        Carga_Proveedores(Me.cmb_Proveedor)
        'Carga_Lista_Full_Variedad()

    End Sub
    Private Sub Carga_Lista_Full_Variedad()
        Dim i As Integer
        sSsql = "SP_CONSULTA_FULL_VARIEDAD_FILTRADO "
        sSsql += "'" & cmb_Familia.Text & "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        DataGrilla.Rows.Clear()

        While datatbl.Read
            DataGrilla.Rows.Add()
            DataGrilla.Rows(i).Cells(0).Value = datatbl(0)
            DataGrilla.Rows(i).Cells(1).Value = datatbl(1)
            DataGrilla.Rows(i).Cells(2).Value = datatbl(3)
            DataGrilla.Rows(i).Cells(3).Value = datatbl(2)
            DataGrilla.Rows(i).Cells(4).Value = IIf(IsDBNull(datatbl(4)), "", datatbl(4))
            DataGrilla.Rows(i).Cells(5).Value = datatbl(5)
            If IsDBNull(datatbl(6)) Then
                DataGrilla.Rows(i).Cells(6).Value = "No Def."
            Else
                Select Case datatbl(6)
                    Case 1
                        DataGrilla.Rows(i).Cells(6).Value = "Rápida"
                    Case 2
                        DataGrilla.Rows(i).Cells(6).Value = "Lenta"
                    Case Else
                        DataGrilla.Rows(i).Cells(6).Value = "No Def."
                End Select
            End If

            If IsDBNull(datatbl(7)) Then
                DataGrilla.Rows(i).Cells(7).Value = "No Def."
            Else
                Select Case datatbl(7)
                    Case 1
                        DataGrilla.Rows(i).Cells(7).Value = "Temprano"
                    Case 2
                        DataGrilla.Rows(i).Cells(7).Value = "Intermedia"
                    Case 3
                        DataGrilla.Rows(i).Cells(7).Value = "Tarde"
                    Case Else
                        DataGrilla.Rows(i).Cells(7).Value = "No Def."
                End Select
            End If

            DataGrilla.Rows(i).Cells(8).Value = datatbl(8)
            DataGrilla.Rows(i).Cells(9).Value = datatbl(9)

            i += 1
        End While

        close_conexion()
    End Sub
    Private Sub Graba_Variedad()
        Dim grabaOK As Boolean = False

        If txt_Descripcion.Text = Nothing Then
            MsgBox("Debe Ingresar Nombre Variedad", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If cmb_Familia.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Especie.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If cmb_Proveedor.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Proveedor.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If txt_Detalle.Text = Nothing Then
            MsgBox("Debe Ingresar Descripción Variedad.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Check_Variedad() Then
            open()

            Try
                sSsql = "SP_GRABA_VARIEDAD "
                sSsql += Str(Val(txt_IDvariedad.Text)) & ","
                sSsql += "'" & txt_Descripcion.Text & "',"
                sSsql += Str(aID_FAMILIA_PROD(Me.cmb_Familia.SelectedIndex)) & ","
                sSsql += "'" & Me.cmb_Proveedor.Text & "',"
                sSsql += "'" & txt_Detalle.Text & "',"
                If rdb_descarga1.Checked Then
                    sSsql += "1,"
                End If
                If rdb_Descarga2.Checked Then
                    sSsql += "2,"
                End If
                If rdb_Temporada1.Checked Then
                    sSsql += "1,"
                End If
                If rdb_Temporada2.Checked Then
                    sSsql += "2,"
                End If
                If rdb_Temporada3.Checked Then
                    sSsql += "3,"
                End If
                sSsql += NUD_nrodiasprecocidad.Value.ToString & ","
                sSsql += "''"
                command = connection.CreateCommand()
                command.CommandText = sSsql
                command.ExecuteNonQuery()
                grabaOK = True
            Catch ex As Exception
                MessageBox.Show("Revise si existe la Variedad que intenta guardar asociada a " & cmb_Familia.Text & "." & Chr(13) & Chr(13) & "Detalle del error:" & Chr(13) & ex.Message, "Grabar Datos")

            Finally
                close_conexion()
            End Try

            If grabaOK Then
                MsgBox("Datos de Variedad han sido Actualizados")
                Limpia_campos()
            End If

        End If
    End Sub
    Private Function Check_Variedad() As Boolean
        Dim bOk As Boolean = True
        Dim i As Integer = 0
        If Val(txt_IDvariedad.Text) = 0 Then
            For i = 0 To DataGrilla.Rows.Count - 1
                If DataGrilla.Rows(i).Cells(1).Value = txt_Descripcion.Text And DataGrilla.Rows(i).Cells(2).Value = cmb_Familia.Text Then
                    MsgBox("Variedad Existente con el Número de ID = " & DataGrilla.Rows(i).Cells(0).Value & " No es posible Repetir Variedad para la Especie Seleccionada. Si Necesita Modificar Variedad, debe utilizar el botón Modificar.", MsgBoxStyle.Exclamation)
                    bOk = False
                End If
            Next
        End If
        Check_Variedad = bOk
    End Function
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub Modifica_Variedad()
        Dim FilaGrilla As Integer
        If DataGrilla.Rows.Count > 0 Then
            FilaGrilla = DataGrilla.CurrentRow.Index
        End If

        If FilaGrilla > 0 Then
            txt_IDvariedad.Text = DataGrilla.Rows(FilaGrilla).Cells(0).Value
            txt_Descripcion.Text = DataGrilla.Rows(FilaGrilla).Cells(1).Value
            cmb_Familia.SelectedItem = DataGrilla.Rows(FilaGrilla).Cells(2).Value
            txt_Detalle.Text = DataGrilla.Rows(FilaGrilla).Cells(5).Value
            cmb_Proveedor.SelectedItem = DataGrilla.Rows(FilaGrilla).Cells(4).Value
            If DataGrilla.Rows(FilaGrilla).Cells(6).Value = "No Def." Then
                rdb_descarga1.Checked = True
            Else
                Select Case DataGrilla.Rows(FilaGrilla).Cells(6).Value
                    Case "Rápida"
                        rdb_descarga1.Checked = True
                    Case "Lenta"
                        rdb_Descarga2.Checked = True
                    Case Else
                        rdb_descarga1.Checked = True
                End Select
            End If
            If DataGrilla.Rows(FilaGrilla).Cells(7).Value = "No Def." Then
                rdb_Temporada1.Checked = True
            Else
                Select Case DataGrilla.Rows(FilaGrilla).Cells(7).Value
                    Case "Temprano"
                        rdb_Temporada1.Checked = True
                    Case "Intermedio"
                        rdb_Temporada2.Checked = True
                    Case "Tarde"
                        rdb_Temporada3.Checked = True
                    Case Else
                        rdb_Temporada1.Checked = True
                End Select

            End If
            If DataGrilla.Rows(FilaGrilla).Cells(8).Value > 0 Then
                NUD_nrodiasprecocidad.Value = DataGrilla.Rows(FilaGrilla).Cells(8).Value
            End If
            txt_Descripcion.Focus()
        End If
    End Sub
    Private Sub Elimina_Variedad()
        Dim IdVariedad As Integer
        Dim FilaGrilla As Integer
        Dim stitle As String = "Eliminación Variedad"

        If DataGrilla.Rows.Count > 0 Then
            FilaGrilla = DataGrilla.CurrentRow.Index
            Dim sResp = MsgBox("Confirme Eliminación de Variedad del Sistema.:" & DataGrilla.Rows(FilaGrilla).Cells(1).Value, MsgBoxStyle.YesNo, stitle)
            If sResp = MsgBoxResult.Yes Then
                IdVariedad = DataGrilla.Rows(FilaGrilla).Cells(0).Value
                If IdVariedad <= 0 Then
                    MsgBox("IDENTIFICADOR DE VARIEDAD NO ES VALIDO. DEBE SELECCIONAR VARIEDAD A ELIMINAR.")
                    Exit Sub
                End If
                Try
                    sSsql = "SP_ELIMINA_VARIEDAD "
                    sSsql += Str(IdVariedad)
                    open()
                    command = connection.CreateCommand()
                    command.CommandText = sSsql
                    datatbl = command.ExecuteReader()
                    If datatbl.HasRows Then
                        datatbl.Read()
                        If datatbl(0) = -1 Then
                            MsgBox("NO es posible eliminar Variedad código:" & Format(IdVariedad, "####") & ". Existen Pedidos asociados.")
                            close_conexion()
                            Exit Sub
                        End If
                    End If
                    close_conexion()
                    MsgBox("Variedad ha sido eliminada.")
                    Carga_Lista_Full_Variedad()
                Catch ex As Exception
                    MsgBox("No Es posible Eliminar Registro." & Chr(13) & Chr(13) & "Datos del error:" & Chr(13) & ex.Message)
                    close_conexion()
                End Try
            End If
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Modifica_Variedad()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Elimina_Variedad()
        Limpia_campos()
    End Sub
    Private Sub Limpia_campos()
        txt_IDvariedad.Clear()
        txt_Descripcion.Clear()
        cmb_Familia.SelectedIndex = -1
        cmb_Proveedor.SelectedIndex = -1
        txt_Detalle.Clear()
        DataGrilla.Rows.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Graba_Variedad()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ListaFamilias()
    End Sub

    Private Sub ListaFamilias()
        If cmb_Familia.SelectedIndex = -1 Then
            MsgBox("Seleccione Especie a Consultar.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Carga_Lista_Full_Variedad()

    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Limpia_campos()
    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ListaFamilias()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Limpia_campos()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Modifica_Variedad()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Elimina_Variedad()
    End Sub
End Class