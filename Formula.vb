Public Class Formula
    Dim txt_tipobandeja As String
    Dim txt_insumo As String
    Dim txt_tipounidad As String
    Private Sub Formula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Carga_Tipo_Bandeja(Me.cmb_TipoBandeja)
        Carga_Tipo_Unidad(Me.cmb_TipoUnidad)
        Carga_Combo_Insumos(Me.cmb_Insumo)
        Consulta_Formulas()
    End Sub
    Private Sub Consulta_Formulas()
        Dim i As Integer
        Dim dCostoTotal As Double
        sSsql = "SP_CONSULTA_FULL_FORMULAS"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        DataGrilla.Rows.Clear()
        'Id(0)	IdForm(1) Idtipobandeja(2) idInsumo(3) Unidades(4) IdUnidad(5) Insumo(6) PrecioCosto(7) Un_costo(8) Un_Compra(9) Costo_Unitario(10)

        While datatbl.Read = True
            DataGrilla.Rows.Add()
            DataGrilla.Rows(i).Cells(0).Value = datatbl(0)
            DataGrilla.Rows(i).Cells(1).Value = datatbl(1)
            DataGrilla.Rows(i).Cells(2).Value = datatbl(11)
            DataGrilla.Rows(i).Cells(3).Value = datatbl(6)
            DataGrilla.Rows(i).Cells(4).Value = Format(datatbl(7), "###,##0.00")
            DataGrilla.Rows(i).Cells(5).Value = datatbl(9)
            DataGrilla.Rows(i).Cells(6).Value = Format(datatbl(4), "###,##0.0000000")
            DataGrilla.Rows(i).Cells(7).Value = datatbl(8)
            DataGrilla.Rows(i).Cells(8).Value = Format(datatbl(10), "###,##0.00")
            dCostoTotal = Math.Round(datatbl(4) * datatbl(10), 6, MidpointRounding.AwayFromZero)
            DataGrilla.Rows(i).Cells(9).Value = Format(dCostoTotal, "###,##0.00000")
            i += 1
        End While
   
        close_conexion()

    End Sub
  

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Graba_Formula()
    End Sub
    Private Sub Graba_Formula()
        sSsql = "SP_GRABA_FORMULA "
        '@Num_Formula int,
        sSsql += Str(Me.ident_formula.Value) + ","
        '@IdTipoBandeja int,
        sSsql += Str(TB_CODIGO(Me.cmb_TipoBandeja.SelectedIndex)) + ","
        '@IdInsumo int,
        sSsql += Str(TI_ID(Me.cmb_Insumo.SelectedIndex)) + ","
        '@Unidades numeric(18,2),
        sSsql += Str(Val(txt_Unidades.Text)) + ","
        '@IdUnidad int
        sSsql += Str(TU_ID(Me.cmb_TipoUnidad.SelectedIndex))
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()
        close_conexion()
        Consulta_Formulas()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Modifica_Datos()

    End Sub
    Private Sub Modifica_Datos()
        '' Edición de datos
        Dim i As Integer
        Dim j As Integer
        i = DataGrilla.CurrentRow.Index


        txt_TipoBandeja = DataGrilla.Rows(i).Cells(1).Value
        txt_tipounidad = DataGrilla.Rows(i).Cells(7).Value
        txt_insumo = DataGrilla.Rows(i).Cells(3).Value
        For j = 0 To cmb_TipoBandeja.Items.Count
            If txt_tipobandeja = cmb_TipoBandeja.Items(j) Then
                cmb_TipoBandeja.SelectedIndex = j
                Exit For
            End If
        Next

        For j = 0 To cmb_Insumo.Items.Count
            If txt_insumo = cmb_Insumo.Items(j) Then
                cmb_Insumo.SelectedIndex = j
                Exit For
            End If
        Next

        For j = 0 To cmb_TipoUnidad.Items.Count
            If txt_tipounidad = cmb_TipoUnidad.Items(j) Then
                cmb_TipoUnidad.SelectedIndex = j
                Exit For
            End If
        Next


        'txt_PrecioVenta.Text = DataGrilla.Rows(i).Cells(3).Value
        txt_IDRegistro.Text = DataGrilla.Rows(i).Cells(0).Value
        txt_Unidades.Text = DataGrilla.Rows(i).Cells(6).Value
    End Sub
    Private Sub Elimina_formula()

        Dim i As Integer
        '' Elimina registro de formula por insumo

        i = DataGrilla.CurrentRow.Index

        sSsql = "SP_ELIMINA_REG_FORMULA "
        sSsql += Str(DataGrilla.Rows(i).Cells(0).Value)
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()
        close_conexion()
        Consulta_Formulas()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Elimina_formula()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class