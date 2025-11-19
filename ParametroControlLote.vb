Public Class ParametroControlLote

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sTipoTabla As String = ""

        If RadioButton1.Checked = True Then
            sTipoTabla = "CTL01"
        End If
        If RadioButton2.Checked = True Then
            sTipoTabla = "CTL02"
        End If
        If RadioButton3.Checked = True Then
            sTipoTabla = "CTL03"
        End If
        If RadioButton4.Checked = True Then
            sTipoTabla = "CTL04"
        End If

        If Val(txt_Codigo.Text) <= 0 Then
            MsgBox("Código de Tabla Incorrecto. Vuelva a ingresar", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If txt_Descripcion.Text = Nothing Then
            MsgBox("Descripción incorrecta. vuelva a ingresar", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        sSsql = "SP_GrabaReporteParametroControlLote "
        sSsql += "'" & sTipoTabla & "',"
        sSsql += txt_Codigo.Text.ToString & ","
        sSsql += "'" & txt_Descripcion.Text & "'"

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()
        close_conexion()
        Inicializa_Grilla(sTipoTabla)
        MsgBox("Datos Actualizados.", MsgBoxStyle.Information)
        Limpia_Campos()
    End Sub

    Private Sub Inicializa_Grilla(sTipoTabla As String)
        Me.SP_ReporteParametroControlLoteTableAdapter.Fill(Me.SpReporteLotesSinGuia.SP_ReporteParametroControlLote, sTipoTabla)
        DataGridView1.Show()
    End Sub
    Private Sub Limpia_Campos()
        
        txt_Codigo.Clear()
        txt_Descripcion.Clear()
    End Sub

    Private Sub ParametroControlLote_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Carga Inicial grilla
        'Me.SP_ReporteCostoMOMensualTableAdapter.Fill(Me.DataSetPlantaEntregada.SP_ReporteCostoMOMensual, Format(DateTimePicker1.Value, "d"), Format(DateTimePicker2.Value, "d"))

        Me.SP_ReporteParametroControlLoteTableAdapter.Connection.ConnectionString = gSOURCE

        Inicializa_Grilla("CTL01")


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        REM Elimina Registro
        Dim idTabla As Integer
        Dim sTipo_Tabla As String = Tipo_Tabla()

        If DataGridView1.Rows.Count > 0 Then
            idTabla = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value

            sSsql = "SP_EliminaParametroReporteParametroControlLote "
            sSsql += idTabla.ToString
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            command.ExecuteNonQuery()
            close_conexion()
            MsgBox("Datos Actualizados.", MsgBoxStyle.Information)
            Inicializa_Grilla(sTipo_Tabla)
        End If

        
    End Sub
    Function Tipo_Tabla() As String
        Dim sTipoTabla As String = ""

        If RadioButton1.Checked = True Then
            sTipoTabla = "CTL01"
        End If
        If RadioButton2.Checked = True Then
            sTipoTabla = "CTL02"
        End If
        If RadioButton3.Checked = True Then
            sTipoTabla = "CTL03"
        End If
        If RadioButton4.Checked = True Then
            sTipoTabla = "CTL04"
        End If

        Tipo_Tabla = sTipoTabla
    End Function

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Inicializa_Grilla("CTL01")
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Inicializa_Grilla("CTL02")
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Inicializa_Grilla("CTL03")
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            Inicializa_Grilla("CTL04")
        End If
    End Sub
End Class