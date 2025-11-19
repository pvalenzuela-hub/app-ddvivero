Public Class PreSEMAct

    Private Sub PreSEMAct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet30.SP_ConsultaPreSE' Puede moverla o quitarla según sea necesario.

        Me.SP_ConsultaPreSETableAdapter.Connection.ConnectionString = gSOURCE

        Me.SP_ConsultaPreSETableAdapter.Fill(Me.GESTDataSet30.SP_ConsultaPreSE)
        Carga_Familia_Prod(Me.cmb_Familia)
        'Carga_Variedad(Me.cmb_Variedad)
    End Sub

    Private Sub ToolStripDropDownButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDropDownButton3.Click
        REM Elimina Precio de la lista de Precios de Semilla
        Dim iFila As Integer
        '@Familia varchar(50),
        '@Variedad varchar(50),
        '@Precio_Costo_Neto float,
        '@PCT_Germinacion float,
        '@Precio_Neto float,
        '@Margen_Porc float,
        '@Precio_Venta_Neto float,
        '@FactorInter real,
        '@FactorDetalle real,
        '@ValorAdicNoSemilla float,
        '@TipoTransac varchar(1)
        Dim sResp = MsgBox("Esta seguro de Eliminar Precio?", MsgBoxStyle.YesNo, "Lista de Precios")
        If sResp = MsgBoxResult.Yes Then

            sResp = MsgBox("Confirme Eliminación de Precios", MsgBoxStyle.YesNo, "Lista de Precios")
            If sResp = MsgBoxResult.Yes Then
                If GrillaPrecios.Rows.Count > -1 Then
                    iFila = GrillaPrecios.CurrentRow.Index
                    If iFila >= 0 Then
                        Try

                            sSsql = "SP_ActPreSE "
                            sSsql += "'" + GrillaPrecios.Rows(iFila).Cells(0).Value + "',"
                            sSsql += "'" + GrillaPrecios.Rows(iFila).Cells(1).Value + "',"
                            sSsql += "0,"
                            sSsql += "0,"
                            sSsql += "0,"
                            sSsql += "0,"
                            sSsql += "0,"
                            sSsql += "0,"
                            sSsql += "0,"
                            sSsql += "0,"
                            sSsql += "'E'"
                            open()
                            command = connection.CreateCommand()
                            command.CommandText = sSsql
                            command.ExecuteNonQuery()
                            close_conexion()

                            MsgBox("Precios Eliminados.")
                            LimpiaCampos()
                            cmb_Familia.Enabled = False
                            cmb_Variedad.Enabled = False

                            Me.SP_ConsultaPreSETableAdapter.Fill(Me.GESTDataSet30.SP_ConsultaPreSE)

                        Catch ex As Exception

                            MsgBox("Ha ocurrido un error en la actualización de la base de datos. Vuelva a intentarlo más tarde y registre el siguiente mensaje ==> " + (ex.Message))

                        End Try
                    End If
                End If

            End If



        End If

    End Sub
    Private Sub LimpiaCampos()
        cmb_Familia.SelectedIndex = -1
        cmb_Variedad.SelectedIndex = -1
        txt_Germinacion.Text = Nothing
        txt_MargenPCT.Text = Nothing
        txt_PCostoNeto.Text = Nothing
        txt_PrecioCompraSemilla.Text = Nothing
        txt_PVentaFinal.Text = Nothing
        txtfactordetalle.Text = Nothing
        txtfactorintermedio.Text = Nothing
        txtHoraActualizacion.Text = Nothing
        txtUltimaActualizacion.Text = Nothing
        txtValorAdicNoSemilla.Text = Nothing

        
    End Sub

    Private Sub ToolStripDropDownButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDropDownButton1.Click
        REM editar
        Dim iFila As Integer

        If GrillaPrecios.Rows.Count > -1 Then
            iFila = GrillaPrecios.CurrentRow.Index
            cmb_Familia.Text = GrillaPrecios.Rows(iFila).Cells(0).Value
            cmb_Variedad.Text = GrillaPrecios.Rows(iFila).Cells(1).Value
            txt_PrecioCompraSemilla.Text = GrillaPrecios.Rows(iFila).Cells(2).Value
            txt_Germinacion.Text = GrillaPrecios.Rows(iFila).Cells(3).Value
            txt_PCostoNeto.Text = GrillaPrecios.Rows(iFila).Cells(4).Value
            txt_MargenPCT.Text = GrillaPrecios.Rows(iFila).Cells(5).Value
            txt_PVentaFinal.Text = GrillaPrecios.Rows(iFila).Cells(6).Value
            txtfactorintermedio.Text = IIf(IsDBNull(GrillaPrecios.Rows(iFila).Cells(7).Value), "", GrillaPrecios.Rows(iFila).Cells(7).Value)
            txtfactordetalle.Text = GrillaPrecios.Rows(iFila).Cells(8).Value
            txtValorAdicNoSemilla.Text = GrillaPrecios.Rows(iFila).Cells(9).Value
            txtUltimaActualizacion.Text = IIf(IsDBNull(GrillaPrecios.Rows(iFila).Cells(10).Value), "", GrillaPrecios.Rows(iFila).Cells(10).Value)
            txtHoraActualizacion.Text = IIf(IsDBNull(GrillaPrecios.Rows(iFila).Cells(11).Value), "", GrillaPrecios.Rows(iFila).Cells(11).Value)

            cmb_Familia.Enabled = False
            cmb_Variedad.Enabled = False

        End If
    End Sub

    Private Sub ToolStripDropDownButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDropDownButton2.Click
        REM Agregar Registro de Precio
        LimpiaCampos()

        cmb_Familia.Enabled = True
        cmb_Variedad.Enabled = True
        cmb_Familia.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        REM Boton Actualiza Datos
        Dim bValida As Boolean = True

        REM Valida Datos
        If cmb_Familia.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Especie")
            bValida = False
        End If

        If cmb_Variedad.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Variedad")
            bValida = False
        End If

        If Val(txt_PrecioCompraSemilla.Text) <= 0 Then
            MsgBox("Precio Compra o de Lista debe ser mayor a cero")
            bValida = False
        End If

        If Val(txt_Germinacion.Text) <= 0 Then
            MsgBox("% de Germinación debe ser mayor a cero")
            bValida = False
        End If


        If Val(txt_MargenPCT.Text) <= 0 Then
            MsgBox("% margen de contribución debe ser mayor a cero")
            bValida = False
        End If

        If Val(txtfactorintermedio.Text) <= 0 Then
            MsgBox("Factor Intermedio debe ser mayor a cero")
            bValida = False
        End If

        If Val(txtfactordetalle.Text) <= 0 Then
            MsgBox("Factor Detalle debe ser mayor a cero")
            bValida = False
        End If

        If Val(txtValorAdicNoSemilla.Text) <= 0 Then
            MsgBox("Valor Adicional sin compra de Semilla, debe ser superior a cero.")
            bValida = False
        End If


        If bValida = True Then
            ActualizaDatos()
        End If
    End Sub
    Private Sub ActualizaDatos()

        REM Graba Datos

        '@Familia varchar(50),
        '@Variedad varchar(50),
        '@Precio_Costo_Neto float,
        '@PCT_Germinacion float,
        '@Precio_Neto float,
        '@Margen_Porc float,
        '@Precio_Venta_Neto float,
        '@FactorInter real,
        '@FactorDetalle real,
        '@ValorAdicNoSemilla float,
        '@TipoTransac varchar(1)


        Try

            sSsql = "SP_ActPreSE "
            sSsql += "'" + cmb_Familia.Text + "',"
            sSsql += "'" + cmb_Variedad.Text + "',"
            sSsql += Reemplaza_Comas(txt_PrecioCompraSemilla.Text) + ","
            sSsql += Reemplaza_Comas(txt_Germinacion.Text) + ","
            sSsql += Reemplaza_Comas(txt_PCostoNeto.Text) + ","
            sSsql += Reemplaza_Comas(txt_MargenPCT.Text) + ","
            sSsql += Reemplaza_Comas(txt_PVentaFinal.Text) + ","
            sSsql += Reemplaza_Comas(txtfactorintermedio.Text) + ","
            sSsql += Reemplaza_Comas(txtfactordetalle.Text) + ","
            sSsql += Reemplaza_Comas(txtValorAdicNoSemilla.Text) + ","
            sSsql += "'I'"
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            command.ExecuteNonQuery()
            close_conexion()

            MsgBox("Precios de Semilla han sido actualizados.")
            LimpiaCampos()
            cmb_Familia.Enabled = False
            cmb_Variedad.Enabled = False
            Me.SP_ConsultaPreSETableAdapter.Fill(Me.GESTDataSet30.SP_ConsultaPreSE)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error en la actualización de la base de datos. Vuelva a intentarlo más tarde y registre el siguiente mensaje ==> " + (ex.Message))
        End Try



    End Sub

    Private Sub txt_Germinacion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Germinacion.LostFocus
        REM Calculo Rendimiento

        If Val(txt_PrecioCompraSemilla.Text) > 0 And Val(txt_Germinacion.Text) > 0 Then
            txt_PCostoNeto.Text = Math.Round(txt_PrecioCompraSemilla.Text * txt_Germinacion.Text / 100, 0, MidpointRounding.AwayFromZero)
        End If
    End Sub

    Private Sub txt_MargenPCT_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MargenPCT.LostFocus
        REM Calculo Margen de Contribucion
        Dim dPorcionPrecio As Double
        If Val(txt_PCostoNeto.Text) > 0 And Val(txt_MargenPCT.Text) > 0 Then
            dPorcionPrecio = Math.Round(txt_PCostoNeto.Text * txt_MargenPCT.Text / 100, 0, MidpointRounding.AwayFromZero)
            txt_PVentaFinal.Text = Val(txt_PCostoNeto.Text) + dPorcionPrecio
        End If
    End Sub


 
    Private Sub cmb_Familia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Familia.SelectedIndexChanged
        If cmb_Familia.SelectedIndex > -1 Then
            Carga_Variedad_Filtro(Me.cmb_Variedad, cmb_Familia.Text)
        End If
    End Sub
End Class