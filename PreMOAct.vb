Public Class PreMOAct
   

    Private Sub PreMOAct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSet29.SP_ConsultaPreMO' Puede moverla o quitarla según sea necesario.

        Me.SP_ConsultaPreMOTableAdapter.Connection.ConnectionString = gSOURCE

        Me.SP_ConsultaPreMOTableAdapter.Fill(Me.GESTDataSet29.SP_ConsultaPreMO)
        Carga_Tipo_Bandeja(Me.cmb_TipoBandeja)
        Carga_Familia_Prod(Me.cmb_Familia)
    End Sub

    Private Sub ToolStripDropDownButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDropDownButton1.Click
        REM editar
        Dim iFila As Integer

        If GrillaPrecios.Rows.Count > -1 Then
            iFila = GrillaPrecios.CurrentRow.Index

            cmb_TipoBandeja.Text = GrillaPrecios.Rows(iFila).Cells(0).Value
            cmb_Familia.Text = GrillaPrecios.Rows(iFila).Cells(1).Value
            txtPrecioBase.Text = GrillaPrecios.Rows(iFila).Cells(2).Value
            txtFactorinvierno.Text = GrillaPrecios.Rows(iFila).Cells(3).Value
            txtpreciobaseinvierno.Text = GrillaPrecios.Rows(iFila).Cells(4).Value
            txtfactorintermedio.Text = GrillaPrecios.Rows(iFila).Cells(5).Value
            txtpreciointermedioverano.Text = GrillaPrecios.Rows(iFila).Cells(6).Value
            txtpreciointermedioinvierno.Text = GrillaPrecios.Rows(iFila).Cells(7).Value
            txtfactordetalle.Text = GrillaPrecios.Rows(iFila).Cells(8).Value
            txtpreciodetalleverano.Text = GrillaPrecios.Rows(iFila).Cells(9).Value
            txtpreciodetalleinvierno.Text = GrillaPrecios.Rows(iFila).Cells(10).Value
            'txtvolumenintermedio.Text = GrillaPrecios.Rows(iFila).Cells(11).Value
            'txtvolumendetalle.Text = GrillaPrecios.Rows(iFila).Cells(12).Value

            cmb_Familia.Enabled = False
            cmb_TipoBandeja.Enabled = False

        End If

    End Sub

    Private Sub ToolStripDropDownButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDropDownButton2.Click
        REM Agregar Registro de Precio
        cmb_Familia.Enabled = True
        cmb_TipoBandeja.Enabled = True
        txtfactordetalle.Text = Nothing
        txtfactorintermedio.Text = Nothing
        txtFactorinvierno.Text = Nothing
        txtPrecioBase.Text = Nothing
        txtpreciobaseinvierno.Text = Nothing
        txtpreciodetalleinvierno.Text = Nothing
        txtpreciodetalleverano.Text = Nothing
        txtpreciointermedioinvierno.Text = Nothing
        txtpreciointermedioverano.Text = Nothing
        'txtvolumendetalle.Text = Nothing
        'txtvolumenintermedio.Text = Nothing
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

        If cmb_TipoBandeja.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar Tipo de Bandeja")
            bValida = False
        End If

        If Val(txtPrecioBase.Text) <= 0 Then
            MsgBox("Precio Base debe ser mayor a cero")
            bValida = False
        End If

        If Val(txtFactorinvierno.Text) <= 0 Then
            MsgBox("Factor Invierno debe ser mayor a cero")
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

        'If txtvolumenintermedio.Text <= 0 Then
        '    MsgBox("Volúmen Intermedio debe ser mayor a cero")
        '    bValida = False
        'End If

        'If Val(txtvolumendetalle.Text) <= 0 Then
        '    MsgBox("Volúmen Detalle debe ser mayor a cero")
        '    bValida = False
        'End If

        'If Val(txtvolumenintermedio.Text) <= Val(txtvolumendetalle.Text) Then
        '    MsgBox("Volúmen Intermedio debe ser superior a Volúmen Detalle")
        '    bValida = False
        'End If

        If bValida = True Then
            ActualizaDatos()
        End If

    End Sub
    Private Sub ActualizaDatos()

        '@TipoBandeja varchar(50),
        '@Familia varchar(50),
        '@PrecioBase float,
        '@FactorINV real,
        '@FactorInter real,
        '@FactorDetalle real,
        '@VolumInter float,
        '@VolumDetalle float,
        '@TipoTransac varchar(1)


        Try

            sSsql = "SP_ActPreMO "
            sSsql += "'" + cmb_TipoBandeja.Text + "',"
            sSsql += "'" + cmb_Familia.Text + "',"
            sSsql += Reemplaza_Comas(txtPrecioBase.Text) + ","
            sSsql += Reemplaza_Comas(txtFactorinvierno.Text) + ","
            sSsql += Reemplaza_Comas(txtfactorintermedio.Text) + ","
            sSsql += Reemplaza_Comas(txtfactordetalle.Text) + ","
            sSsql += "'I'"
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            command.ExecuteNonQuery()
            close_conexion()

            MsgBox("Precios Actualizados.")
            LimpiaCampos()
            cmb_Familia.Enabled = False
            cmb_TipoBandeja.Enabled = False
            Me.SP_ConsultaPreMOTableAdapter.Fill(Me.GESTDataSet29.SP_ConsultaPreMO)
        Catch ex As Exception
            MsgBox("Ha ocirrido un error en la actualización de la base de datos. Vuelva a intentarlo más tarde y registre el siguiente mensaje ==> " + (ex.Message))
        End Try



    End Sub

    Private Sub LimpiaCampos()
        cmb_Familia.SelectedIndex = -1
        cmb_TipoBandeja.SelectedIndex = -1
        txtfactordetalle.Text = Nothing
        txtfactorintermedio.Text = Nothing
        txtFactorinvierno.Text = Nothing
        txtPrecioBase.Text = Nothing
        txtpreciobaseinvierno.Text = Nothing
        txtpreciodetalleinvierno.Text = Nothing
        txtpreciodetalleverano.Text = Nothing
        txtpreciointermedioinvierno.Text = Nothing
        txtpreciointermedioverano.Text = Nothing
        'txtvolumendetalle.Text = Nothing
        'txtvolumenintermedio.Text = Nothing
    End Sub

    Private Sub ToolStripDropDownButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDropDownButton3.Click
        REM Elimina Precio de la lista de Precios de Hechura
        Dim iFila As Integer

        Dim sResp = MsgBox("Esta seguro de Eliminar Precio?", MsgBoxStyle.YesNo, "Lista de Precios")
        If sResp = MsgBoxResult.Yes Then

            sResp = MsgBox("Confirme Eliminación de Precios", MsgBoxStyle.YesNo, "Lista de Precios")
            If sResp = MsgBoxResult.Yes Then
                If GrillaPrecios.Rows.Count > -1 Then
                    iFila = GrillaPrecios.CurrentRow.Index
                    If iFila >= 0 Then
                        Try

                            sSsql = "SP_ActPreMO "
                            sSsql += "'" + GrillaPrecios.Rows(iFila).Cells(0).Value + "',"
                            sSsql += "'" + GrillaPrecios.Rows(iFila).Cells(1).Value + "',"
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
                            cmb_TipoBandeja.Enabled = False
                            Me.SP_ConsultaPreMOTableAdapter.Fill(Me.GESTDataSet29.SP_ConsultaPreMO)

                        Catch ex As Exception

                            MsgBox("Ha ocirrido un error en la actualización de la base de datos. Vuelva a intentarlo más tarde y registre el siguiente mensaje ==> " + (ex.Message))

                        End Try
                    End If
                End If

            End If



        End If






    End Sub
End Class