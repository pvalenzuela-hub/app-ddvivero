Public Class Conteo_Plantas
    Private Sub Conteo_Plantas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nUD_Cant_Band.Minimum = 1
        nUD_Cant_Band.Maximum = Bitacora.txt_CantBandejas.Text
    End Sub

    Private Sub Lllena_Tabla()
        Dim i As Integer
        Dim iCantBand As Integer
        iCantBand = txt_BandIng.Value

        GrillaConteo.Rows.Clear()
        If iCantBand = 0 Then
            MsgBox("Ingrese Bandejas a Contar", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        For i = 0 To iCantBand - 1
            GrillaConteo.Rows.Add()
            GrillaConteo.Rows(i).Cells(0).Value = i + 1
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        REM CALCULO SALDO DE PLANTAS
        Dim i As Integer
        Dim iSuma As Integer
        Dim iTotalConteo As Integer
        Dim dTotalVacias As Decimal
        Dim dPromedioVacias As Decimal
        Dim iCantTotalPlantas As Integer
        Dim dPromedioConteoSiembra As Double
        iSuma = 0
        REM ******************************************************************************************************
        REM Modificado 05/11/2014                                                                                *
        REM El Promedio de Plantas del Conteo de siembra no será considerado para calcular el Conteo de Plantas  *
        REM Por lo tanto se considerará como Promedio = Tipo de Bandeja                                          *
        REM Es decir, se considera que las Bandejas vienen Completas y se cuentan de nuevo                       *
        REM ******************************************************************************************************
        dPromedioConteoSiembra = Bitacora.txt_CantidadCeldas.Text
        For i = 0 To GrillaConteo.Rows.Count - 1
            iSuma += GrillaConteo.Rows(i).Cells(1).Value
            If i = txt_BandIng.Value Then
                Exit For
            End If
        Next
        iCantTotalPlantas = dPromedioConteoSiembra * nUD_Cant_Band.Value

        If i > 0 Then
            dPromedioVacias = Math.Round(iSuma / i, 2, MidpointRounding.AwayFromZero)
            If Bitacora.txt_NumConteo.Text = 1 Then
                dTotalVacias = dPromedioVacias * nUD_Cant_Band.Value
                iTotalConteo = iCantTotalPlantas - dTotalVacias
                Bitacora.txt_BandConteo1.Text = nUD_Cant_Band.Value
                Bitacora.txt_BandIng1.Text = i
                Bitacora.txt_PromVaciasxBand1.Text = dPromedioVacias
                Bitacora.txt_TotalCeldasVacias1.Text = dTotalVacias
                Bitacora.txt_PlsegunPromConteo1.Text = iCantTotalPlantas
                Bitacora.txt_TotalPlConteo1.Text = iTotalConteo
                Bitacora.txt_Germ1.Text = Math.Round(iTotalConteo / Val(Bitacora.txt_conteosiembra.Text) * 100, 2, MidpointRounding.AwayFromZero)
            Else
                dTotalVacias = dPromedioVacias * nUD_Cant_Band.Value
                iTotalConteo = iCantTotalPlantas - dTotalVacias
                Bitacora.txt_BandConteo2.Text = nUD_Cant_Band.Value
                Bitacora.txt_BandIng2.Text = i
                Bitacora.txt_PromVaciasxBand2.Text = dPromedioVacias
                Bitacora.txt_TotalCeldasVacias2.Text = dTotalVacias
                Bitacora.txt_PlsegunPromConteo2.Text = iCantTotalPlantas
                Bitacora.txt_TotalPlConteo2.Text = iTotalConteo
                Bitacora.txt_Germ2.Text = Math.Round(iTotalConteo / Val(Bitacora.txt_conteosiembra.Text) * 100, 2, MidpointRounding.AwayFromZero)

            End If
            Bitacora.txt_Cantidad.Text = Format(Val(Bitacora.txt_TotalPlConteo1.Text) + Val(Bitacora.txt_TotalPlConteo2.Text), "#########")
        End If
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Lllena_Tabla()
    End Sub
End Class