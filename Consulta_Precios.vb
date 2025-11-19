Public Class Consulta_Precios
    Dim dPrecioFinal As Double
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        txt_PrecioNeto.Text = ""
        Consulta_Precios()
    End Sub
    Private Sub Consulta_Precios()
        Dim i As Integer
        Dim dPrecioCostoHechura As Double = 0
        Dim dPrecioVentaNeto As Double = 0
        Dim dPrecioMargenTipoBandeja As Double = 0

        If cmb_Familia.SelectedIndex = -1 Then
            MsgBox("DEBE SELECCIONAR SEMILLA A CONSULTAR")
            Exit Sub
        End If
        REM PRECIOS DE VENTAS PLANTAS
        sSsql = "SP_CONSULTA_Precio_Planta_Hechura "
        sSsql += "'" + cmb_Familia.Text + "'"

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        GrillaHechura.Rows.Clear()
        If datatbl.HasRows Then
            While datatbl.Read = True

                dPrecioCostoHechura = datatbl(3)
                'dPrecioVentaNeto = dPrecioCostoHechura + (dPrecioCostoHechura * datatbl(4))
                dPrecioVentaNeto = dPrecioCostoHechura + (dPrecioCostoHechura * datatbl(5))
                GrillaHechura.Rows.Add()
                GrillaHechura.Rows(i).Cells(0).Value = datatbl(0)
                GrillaHechura.Rows(i).Cells(1).Value = Format(dPrecioCostoHechura, "###0.00")
                'GrillaHechura.Rows(i).Cells(2).Value = Format(datatbl(4) * 100, "###0.00")
                GrillaHechura.Rows(i).Cells(2).Value = Format(datatbl(5) * 100, "###0.00")
                GrillaHechura.Rows(i).Cells(3).Value = Format(dPrecioVentaNeto, "###,##0.00")
                GrillaHechura.Rows(i).Cells(4).Value = Format(datatbl(6), "###,##0.00")

                i += 1
            End While
        Else
            MsgBox("SEMILLA NO TIENE PRECIO DE HECHURA ASOCIADO")
        End If
        datatbl.Close()

        sSsql = "SP_CONSULTA_PRECIO_SEMILLA "
        sSsql += "'" + cmb_Familia.Text + "'"

        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        GrillaSemilla.Rows.Clear()
        If datatbl.HasRows Then
            i = 0
            While datatbl.Read = True
                GrillaSemilla.Rows.Add()
                GrillaSemilla.Rows(i).Cells(0).Value = datatbl(0)
                If IsDBNull(datatbl(1)) Then
                    GrillaSemilla.Rows(i).Cells(1).Value = 0
                Else
                    GrillaSemilla.Rows(i).Cells(1).Value = Format(datatbl(1), "###0.00")
                End If

                GrillaSemilla.Rows(i).Cells(2).Value = Format(datatbl(2), "###0.00")
                GrillaSemilla.Rows(i).Cells(3).Value = Format(datatbl(3), "###0.00")
                i += 1
            End While
        Else
            MsgBox("SEMILLA NO TIENE COSTOS ASOCIADOS")
        End If

        close_conexion()

    End Sub

    Private Sub Consulta_Precios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Carga_Familia_Prod(Me.cmb_Familia)
    End Sub

  
    Private Sub GrillaHechura_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrillaHechura.CellContentClick
        Calcula_Precio_final()
    End Sub
    Private Sub Calcula_Precio_final()
        Dim i As Integer
        Dim j As Integer
        dPrecioFinal = 0
        If GrillaHechura.Rows.Count > 0 Then
            i = GrillaHechura.CurrentRow.Index
            dPrecioFinal = Val(Reemplaza_Comas(GrillaHechura.Rows(i).Cells(4).Value))
        End If
        If GrillaSemilla.Rows.Count > 0 Then
            j = GrillaSemilla.CurrentRow.Index
            dPrecioFinal += Val(Reemplaza_Comas(GrillaSemilla.Rows(j).Cells(3).Value))

        End If
        'j = GrillaSemilla.CurrentRow.Index

        txt_PrecioNeto.Text = Format(dPrecioFinal, "##,###.00")
    End Sub

    Private Sub GrillaSemilla_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrillaSemilla.CellContentClick
        Calcula_Precio_final()
    End Sub

    Private Sub GrillaHechura_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrillaHechura.Click
        Calcula_Precio_final()
    End Sub

    Private Sub GrillaSemilla_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrillaSemilla.Click
        Calcula_Precio_final()
    End Sub
End Class