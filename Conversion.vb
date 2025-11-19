Public Class Conversion

    Private Sub Conversion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Consulta_Full_Conversion()
        Carga_Tipo_Unidad(Me.cmb_Unidad1)
        Carga_Tipo_Unidad(Me.cmb_Unidad2)
    End Sub
    Private Sub Consulta_Full_Conversion()
        Dim i As Integer
        sSsql = "SP_CONSULTA_FULL_CONVERSION"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        DataGrilla.Rows.Clear()

        While datatbl.Read = True
            DataGrilla.Rows.Add()
            DataGrilla.Rows(i).Cells(0).Value = datatbl(0)
            DataGrilla.Rows(i).Cells(1).Value = datatbl(1)
            DataGrilla.Rows(i).Cells(2).Value = datatbl(2)
            DataGrilla.Rows(i).Cells(3).Value = datatbl(3)
            DataGrilla.Rows(i).Cells(4).Value = Format(datatbl(4), "###,##0.00")
            DataGrilla.Rows(i).Cells(5).Value = datatbl(5)
            DataGrilla.Rows(i).Cells(6).Value = datatbl(6)
            i += 1
        End While

        close_conexion()
    End Sub
    Private Sub Graba_Conversion()
        Dim iTipoOperacion As Integer
        iTipoOperacion = 0
        If rb_TO1.Checked Then
            iTipoOperacion = 1
        End If
        If rb_TO2.Checked Then
            iTipoOperacion = 2
        End If
        If rb_TO3.Checked Then
            iTipoOperacion = 3
        End If
        If rb_TO4.Checked Then
            iTipoOperacion = 4
        End If

        If Val(txt_Tasa.Text) <= 0 Then
            MsgBox("DEBE INGRESAR VALOR MAYOR A CERO.")
            Exit Sub
        End If

        If iTipoOperacion = 0 Then
            MsgBox("DEBE SELECCIONAR TIPO DE OPERACION.")
            Exit Sub
        End If

        If Me.cmb_Unidad1.SelectedIndex = -1 Then
            MsgBox("DEBE SELECCIONAR UNIDAD DE:")
            Exit Sub
        End If

        If Me.cmb_Unidad2.SelectedIndex = -1 Then
            MsgBox("DEBE SELECCIONAR UNIDAD A:")
            Exit Sub
        End If

        sSsql = "SP_GRABA_CONVERSION_UNIDADES "
        sSsql += Str(Val(txt_IDConversion.Text)) + ","
        sSsql += Str(iTipoOperacion) + ","
        sSsql += Str(Val(txt_Tasa.Text)) + ","
        sSsql += Str(TU_ID(Me.cmb_Unidad1.SelectedIndex)) + ","
        sSsql += Str(TU_ID(Me.cmb_Unidad2.SelectedIndex))

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()
        close_conexion()
        Consulta_Full_Conversion()
        Limpia_campos()
    End Sub
    Private Sub Elimina_Conversion()
        Dim sResp As String
        Dim IdConversion As Integer
        Dim FilaGrilla As Integer
        sResp = InputBox("CONFIRME ELIMINACION DE CONVERSION.", "ELIMINACION DE CONVERSION", "S")
        If UCase(sResp) = "S" Then
            FilaGrilla = DataGrilla.CurrentRow.Index
            IdConversion = DataGrilla.Rows(FilaGrilla).Cells(0).Value
            If IdConversion <= 0 Then
                MsgBox("IDENTIFICADOR DE CONVERSION NO ES VALIDO. DEBE SELECCIONAR CONVERSION A ELIMINAR.")
                Exit Sub
            End If
            sSsql = "SP_ELIMINA_CONVERSION "
            sSsql += Str(IdConversion)
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                datatbl.Read()
                If datatbl(0) = -1 Then
                    MsgBox("NO ES POSIBLE ELIMINAR CONVERSION ID.:" + Format(IdConversion, "####") + ". EXISTEN INSUMOS CON FORMULAS ASOCIADAS A ESTAS UNIDADES DE CONVERSION.")
                End If
            End If
            close_conexion()
            Consulta_Full_Conversion()
        End If
    End Sub
    Private Sub Limpia_campos()
        txt_IDConversion.Text = ""
        cmb_Unidad1.Text = ""
        cmb_Unidad2.Text = ""
        txt_Tasa.Text = ""
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Elimina_Conversion()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Graba_Conversion()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Limpia_campos()
        cmb_Unidad1.Focus()
    End Sub
End Class