Imports System.Data.SqlClient
Public Class Costo_Semilla
    Dim dPrecioCompraSemillas As Double
    Dim dPCTGerminacion As Double
    Dim dPrecioCostoNeto As Double
    Dim dPCTMargen As Double
    Dim dPrecioVentaSemilla As Double
    Dim dPrecioVentaIVA As Double

    Private Sub Costo_Semilla_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Carga_Familia_Prod(Me.cmb_Familia_Prod)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dCostoNeto As Double
        Dim dMargen As Double
        If cmb_Familia_Prod.SelectedIndex = -1 Then
            MsgBox("DEBE SELECCIONAR SEMILLA")
            Exit Sub
        End If
        If cmb_Variedad.SelectedIndex = -1 Then
            MsgBox("DEBE SELECCIONAR VARIEDAD")
            Exit Sub
        End If
        dCostoNeto = Val(Reemplaza_Comas(txt_PCostoNeto.Text))
        dMargen = Val(Reemplaza_Comas(txt_MargenPCT.Text))
        '@Familia varchar(50),
        '@Variedad varchar(50),
        '@Precio_Costo_Neto float,
        '@Margen_Porc float,
        '@Precio_Neto float,
        '@PCT_Germinacion float,
        '@Precio_Venta_Neto float
        sSsql = "SP_GRABA_COSTO_SEMILLA "
        sSsql += "'" + cmb_Familia_Prod.Text + "',"
        sSsql += "'" + cmb_Variedad.Text + "',"
        sSsql += Reemplaza_Comas(txt_PrecioCompraSemilla.Text) + ","
        sSsql += Reemplaza_Comas(dMargen).ToString + ","
        sSsql += Reemplaza_Comas(dCostoNeto).ToString + ","
        sSsql += Reemplaza_Comas(txt_Germinacion.Text) + ","
        sSsql += Reemplaza_Comas(txt_PVentaFinal.Text)
        'sSsql += Reemplaza_Comas(Val(txt_Stock_Inicial.Text).ToString)

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()
        close_conexion()
        MsgBox("COSTO DE SEMILLA GRABADO")
        Reset_Campos()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        sSsql = "SP_ELIMINA_COSTO_SEMILLA "
        sSsql += Str(aID_FAMILIA_PROD(Me.cmb_Familia_Prod.SelectedIndex))
        sSsql += ","
        sSsql += Str(aID_VARIEDAD(Me.cmb_Variedad.SelectedIndex))
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        command.ExecuteNonQuery()
        close_conexion()
        MsgBox("COSTO DE SEMILLA ELIMINADO")
        Reset_Campos()
    End Sub

    Private Sub Calcula_Precio_Final()
        Dim dUtilidad As Integer
        If dPrecioCompraSemillas > 0 And dPCTGerminacion > 0 Then
            dPrecioCostoNeto = dPrecioCompraSemillas + (dPrecioCompraSemillas * ((100 - dPCTGerminacion) / 100))
        End If

        If dPrecioVentaIVA > 0 And dPrecioCostoNeto > 0 Then
            dPrecioVentaSemilla = Math.Round(dPrecioVentaIVA / 1.19, 2, MidpointRounding.AwayFromZero)
            dUtilidad = dPrecioVentaSemilla - dPrecioCostoNeto
            dPCTMargen = Math.Round(dUtilidad / dPrecioCostoNeto * 100, 2, MidpointRounding.AwayFromZero)
            txt_MargenPCT.Text = Format(dPCTMargen, "##0.00")
            txt_PVentaFinal.Text = Format(dPrecioVentaSemilla, "###,##0.00")
        Else
            dPrecioVentaSemilla = 0
        End If

        txt_PCostoNeto.Text = Format(dPrecioCostoNeto, "###,##0.00")
        txt_PVentaFinal.Text = Format(dPrecioVentaSemilla, "###,##0.00")

        'dPrecioNeto = Val(Reemplaza_Comas(txt_PCostoNeto.Text))
        'dPrecioFinal = Val(Reemplaza_Comas(txt_PVentaFinal.Text))

        'If dPrecioNeto > 0 And dPrecioFinal > 0 Then
        '    dporct = (dPrecioFinal - dPrecioNeto) / dPrecioNeto * 100
        '    txt_MargenPCT.Text = Format(dporct, "###,##0.00")
        'End If
    End Sub
    Private Sub Reset_Campos()
        txt_PrecioCompraSemilla.Clear()
        txt_Germinacion.Clear()
        txt_MargenPCT.Clear()
        txt_PCostoNeto.Clear()
        txt_PVentaFinal.Clear()
        txt_Stock.Clear()
        txt_TotalCompras.Clear()
        txt_TotalConsumo.Clear()
        txtUltimaActualizacion.Clear()
        txtHoraActualizacion.Clear()
        txtPrecioVentaIVA.Clear()
        'txt_Stock_Inicial.Clear()
        cmb_Familia_Prod.SelectedIndex = -1
        cmb_Variedad.SelectedIndex = -1
    End Sub
    Private Sub Lectura_Costo_Semilla()

        If cmb_Familia_Prod.SelectedIndex > -1 And cmb_Variedad.SelectedIndex > -1 Then
            sSsql = "SP_LECTURA_COSTO_SEMILLA "
            sSsql += "'" + cmb_Familia_Prod.SelectedItem + "',"
            sSsql += "'" + cmb_Variedad.SelectedItem + "'"

            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                datatbl.Read()
                txt_PrecioCompraSemilla.Text = Format(datatbl(0), "###,##0.00")
                txt_Germinacion.Text = datatbl(3)
                txt_PCostoNeto.Text = Format(datatbl(2), "###,##0.00")
                txt_MargenPCT.Text = Format(datatbl(1), "###,##0.00")
                txt_PVentaFinal.Text = Format(datatbl(4), "###,##0.00")
                txt_Stock.Text = Format(datatbl(5), "###,###,###")
                'txt_Stock_Inicial.Text = datatbl(6)
                txt_TotalConsumo.Text = Format(datatbl(7), "###,###,##0")
                txt_TotalCompras.Text = Format(datatbl(8), "###,###,##0")
                txtUltimaActualizacion.Text = datatbl(12)
                txtHoraActualizacion.Text = datatbl(13)
                dPrecioCompraSemillas = datatbl(0)
                dPCTGerminacion = datatbl(3)
                dPrecioCostoNeto = datatbl(4)
                dPCTMargen = datatbl(1)
                dPrecioVentaSemilla = datatbl(2)
                dPrecioVentaIVA = datatbl("PrecioVentaIva")
                txtPrecioVentaIVA.Text = dPrecioVentaIVA
            Else

                txt_PrecioCompraSemilla.Clear()
                txt_Germinacion.Clear()
                txt_PCostoNeto.Clear()
                txt_MargenPCT.Clear()
                txt_PVentaFinal.Clear()
                txt_Stock.Clear()
                'txt_Stock_Inicial.Clear()
                txt_TotalCompras.Clear()
                txt_TotalConsumo.Clear()
                dPrecioCompraSemillas = 0
                dPCTGerminacion = 0
                dPrecioCostoNeto = 0
                dPCTMargen = 0
                dPrecioVentaSemilla = 0
                dPrecioVentaIVA = 0
                MsgBox("Variedad no tiene precio de costo definido.")
                'Reset_Campos()
            End If
            close_conexion()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub cmb_Familia_Prod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Familia_Prod.SelectedIndexChanged
        'Lectura_Costo_Semilla()
        Carga_Variedad_Filtro(Me.cmb_Variedad, Me.cmb_Familia_Prod.Text)
    End Sub

    Private Sub cmb_Variedad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Variedad.SelectedIndexChanged
        Lectura_Costo_Semilla()
    End Sub

    Private Sub txt_PCostoNeto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_PCostoNeto.TextChanged
        'Calcula_Precio_Final()
    End Sub

    Private Sub txt_PVentaFinal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_PVentaFinal.TextChanged
        'Calcula_Precio_Final()
    End Sub

    Private Sub txt_Germinacion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Germinacion.TextChanged
        If Val(txt_Germinacion.Text) > 0 Then
            dPCTGerminacion = Val(txt_Germinacion.Text)
            Calcula_Precio_Final()
        End If
    End Sub




    Private Sub txt_PrecioCompraSemilla_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_PrecioCompraSemilla.TextChanged
        If Val(txt_PrecioCompraSemilla.Text) > 0 Then
            dPrecioCompraSemillas = Val(txt_PrecioCompraSemilla.Text)
        End If
    End Sub



    Private Sub txtPrecioVentaIVA_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioVentaIVA.TextChanged
        ' Precio de Venta con IVA - Input
        If Val(txtPrecioVentaIVA.Text) > 0 Then
            dPrecioVentaIVA = Val(txtPrecioVentaIVA.Text)
            Calcula_Precio_Final()
        End If
    End Sub

    Private Sub txtPrecioVentaIVA_LostFocus(sender As Object, e As EventArgs) Handles txtPrecioVentaIVA.LostFocus

    End Sub
End Class