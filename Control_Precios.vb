Public Class Control_Precios
    Dim dCostoTotalBandeja As Double
    Dim dCostoUnitarioPlanta As Double
    Dim dPrecioVentaPlanta As Double
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Consulta_Precios()
    End Sub
    Private Sub Consulta_Precios()
        Dim i As Integer
        Dim dCostoTotal As Double
        sSsql = "SP_CONSULTA_FORMULA_NUM "
        sSsql += Str(Val(Me.cmb_Formulas.Text))
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        DataGrilla.Rows.Clear()
        'Id(0)	numform(1) Idtipobandeja(2) idInsumo(3) Unidades(4) IdUnidad(5) Insumo(6) PrecioCosto(7) Un_costo(8) Un_Compra(9) Costo_Unitario(10)
        dCostoTotalBandeja = 0
        If datatbl.HasRows Then
            While datatbl.Read = True
                DataGrilla.Rows.Add()
                DataGrilla.Rows(i).Cells(0).Value = datatbl(0)
                DataGrilla.Rows(i).Cells(1).Value = datatbl(6)
                DataGrilla.Rows(i).Cells(2).Value = Format(datatbl(7), "###,##0.00")
                DataGrilla.Rows(i).Cells(3).Value = datatbl(9)
                DataGrilla.Rows(i).Cells(4).Value = Format(datatbl(4), "###,##0.00000")
                DataGrilla.Rows(i).Cells(5).Value = datatbl(8)
                DataGrilla.Rows(i).Cells(6).Value = Format(datatbl(10), "###,##0.00")
                dCostoTotal = Math.Round(datatbl(4) * datatbl(10), 6, MidpointRounding.AwayFromZero)
                DataGrilla.Rows(i).Cells(7).Value = Format(dCostoTotal, "###,##0.00000")
                dCostoTotalBandeja += dCostoTotal
                i += 1
            End While
            txt_CostoTotalBandeja.Text = Format(dCostoTotalBandeja, "###,##0.00000")
            dCostoUnitarioPlanta = Math.Round(dCostoTotalBandeja / FO_Celdas(Me.cmb_Formulas.SelectedIndex), 6, MidpointRounding.AwayFromZero)
            txt_CostoUnitarioPlanta.Text = Format(dCostoUnitarioPlanta, "###,##0.00000")

        Else
            MsgBox("FORMULA NO CONTIENE INFORMACION DE COSTOS")
        End If
        datatbl.Close()
        '' Rescata Precio Venta Semilla
        sSsql = "SP_CONSULTA_FULL_PRECIOS "
        sSsql += Str(FO_IDTipoBandeja(Me.cmb_Formulas.SelectedIndex)) + ","
        sSsql += Str(aID_FAMILIA_PROD(Me.cmb_Semilla.SelectedIndex))
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        GrillaPrecios.Rows.Clear()
        If datatbl.HasRows Then
            i = 0
            While datatbl.Read = True
                GrillaPrecios.Rows.Add()
                GrillaPrecios.Rows(i).Cells(0).Value = datatbl(4)
                GrillaPrecios.Rows(i).Cells(1).Value = datatbl(5)
                GrillaPrecios.Rows(i).Cells(2).Value = Format(datatbl(3), "###,##0.00")
                i += 1
            End While
        Else
            MsgBox("NO EXISTEN PRECIOS DE VENTA PARA TIPO DE BANDEJA Y SEMILLA SELECCIONADA")
        End If
        close_conexion()
    End Sub

    Private Sub Control_Precios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Carga_Num_Formulas(Me.cmb_Formulas)
        Carga_Familia_Prod(Me.cmb_Semilla)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub cmb_Formulas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Formulas.SelectedIndexChanged
        txt_TipoBandeja.Text = FO_TipoBandeja(Me.cmb_Formulas.SelectedIndex)
        txt_NumCeldas.Text = FO_Celdas(Me.cmb_Formulas.SelectedIndex)
    End Sub
End Class