Imports System.Data.SqlClient
Public Class Consulta_Proveedor
    'Private doc_h As New DataTable("Doc_header")
    'Private doc_d As New DataTable("Doc_detalle")
    'Private doc_p As New DataTable("Doc_pagos")
    Dim sRUT(0 To 0) As String
    Dim gRUTproveedor As String
    Dim datatbl As SqlClient.SqlDataReader = Nothing
    Dim command As SqlCommand = Nothing
    Dim aTipo_Doc(0 To 0)
    Dim aNum_Doc(0 To 0)
    Dim aFecha_Doc(0 To 0)
    Dim aValor_Doc(0 To 0)
    Dim aTipo_Compra(0 To 0)
    Dim aIdInsumo(0 To 0)
    Dim aInsumo(0 To 0)
    Dim aSemilla(0 To 0)
    Dim aVariedad(0 To 0)
    Dim aCantidad(0 To 0)
    Dim aPrecio_Unitario(0 To 0)
    Dim aUnidad(0 To 0)
    Dim aTipo_Pago(0 To 0)
    Dim aNum_Docpago(0 To 0)
    Dim aBanco(0 To 0)
    Dim aFecha_Vcto(0 To 0)
    Dim aValor_Pago(0 To 0)


    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Visible = False
    End Sub
    Private Sub SeleccionProveedor()
        Dim sRutaBuscar As String
        Dim sBuscar As String
        Dim i, iArg As Integer
        Dim sRespuesta As String

        sBuscar = ""
        'cmb_cliente.
        If RadioButton1.Checked = True Then
            ' busca por rut
            If txt_Rut.Text = "" Or txt_digrut.Text = "" Then
                MessageBox.Show("Debe ingresar Rut Proveedor a buscar")
                Exit Sub
            End If
            sRutaBuscar = Format(Val(txt_Rut.Text), "00000000000") + UCase(txt_digrut.Text)
            sBuscar = sRutaBuscar
            gRUTproveedor = sRutaBuscar
            iArg = 1
        End If
        If RadioButton2.Checked = True Then
            If txt_nombre.Text = "" Then
                MessageBox.Show("Debe ingresar Nombre o parte del nombre del Proveedor a buscar")
                Exit Sub
            End If
            sBuscar = Trim(UCase(txt_nombre.Text))
            iArg = 2
        End If
        If sBuscar = "" Then
            MessageBox.Show("Seleccione búsqueda por RUT o Nombre de Proveedor")
            Exit Sub
        End If
        cmb_proveedor.Items.Clear()
        'SP_CONSULTA_CLIENTE_NOMBRE '00009976189K',1
        sSsql = "SP_CONSULTA_PROVEEDOR_NOMBRE '" + sBuscar + "'," + Str(iArg)
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            While datatbl.Read = True
                ReDim Preserve sRUT(0 To i)
                sRUT(i) = datatbl(0).ToString
                cmb_proveedor.Items.Add(Trim(datatbl(1)))
                i += 1
            End While
        Else
            sRespuesta = InputBox("Proveedor no registrado en la Base de Datos, Crear Proveedor <S/N>?", "Registro de Proveedor", "S")
            If sRespuesta = "S" Then
                LimpiaCampos()
                txt_rutproveedor.ReadOnly = False
                txt_digitorut.ReadOnly = False

                HabilitaCampos()
                txt_rutproveedor.Focus()
            End If

        End If
        '    cmb_cliente.Items.Add(Trim(datatbl(3)) & " " & datatbl(2))
        datatbl.Close()
        close_conexion()
        cmb_proveedor.Focus()
        cmb_proveedor.Show()

    End Sub
    Private Sub HabilitaCampos()
        txt_NOMBRES.ReadOnly = False
        txt_dircli.ReadOnly = False
        txt_comuna.ReadOnly = False
        txt_ciudad.ReadOnly = False
        txt_telcasa.ReadOnly = False
        txt_teloficina.ReadOnly = False
        txt_telcelular.ReadOnly = False
        txt_fax.ReadOnly = False
        txt_email.ReadOnly = False
        TXT_Comentarios.ReadOnly = False
        TXT_Contacto.ReadOnly = False
        TXT_Giro.ReadOnly = False
    End Sub
    Private Sub DEShabilitaCampos()
        txt_rutproveedor.ReadOnly = True
        txt_digitorut.ReadOnly = True
        txt_NOMBRES.ReadOnly = True
        txt_dircli.ReadOnly = True
        txt_comuna.ReadOnly = True
        txt_ciudad.ReadOnly = True
        txt_telcasa.ReadOnly = True
        txt_teloficina.ReadOnly = True
        txt_telcelular.ReadOnly = True
        txt_fax.ReadOnly = True
        txt_email.ReadOnly = True
        TXT_Comentarios.ReadOnly = True
        TXT_Contacto.ReadOnly = True
        TXT_Giro.ReadOnly = True
    End Sub
    Private Sub LimpiaCampos()
        txt_rutproveedor.Clear()
        txt_digitorut.Clear()
        txt_NOMBRES.Clear()
        txt_dircli.Clear()
        txt_comuna.Clear()
        txt_ciudad.Clear()
        txt_telcasa.Clear()
        txt_teloficina.Clear()
        txt_telcelular.Clear()
        txt_fax.Clear()
        txt_email.Clear()
        TXT_Comentarios.Clear()
        TXT_Contacto.Clear()
        TXT_Giro.Clear()
        txt_TotalCompra.Clear()
        doc_header.Rows.Clear()
        doc_detalle.Rows.Clear()
        doc_pagos.Rows.Clear()
    End Sub
    Private Sub CargaCartola(ByVal sRut As String)

        Dim x As Integer
        Dim iRow As Integer

        RecuperaDatosProveedor(sRut, True)

        doc_header.Rows.Clear()
        doc_detalle.Rows.Clear()
        doc_pagos.Rows.Clear()
        'doc_h.Rows.Clear()
        'doc_d.Rows.Clear()
        'doc_p.Rows.Clear()
        txt_Documento.Text = ""
        sSsql = "SP_CREA_CARTOLA_PROVEEDOR '" + sRut + "'"
        '0  a.tipo_doc,
        '1  a.num_doc,
        '2  Convert(char,a.fecha_doc,103) fecha_doc,
        '3  a.valor_doc,
        '4  a.tipo_compra,
        '5  b.IdInsumo,
        '6  d.Descripcion,
        '7  b.cantidad,
        '8  e.Descripcion,
        '9  b.precio_unitario,
        '10 c.tipo_pago,
        '11 c.num_docpago,
        '12 c.banco,
        '13 Convert(char,c.fecha_vcto,103) fecha_vcto,
        '14 c.valor_doc()


        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then
            While datatbl.Read = True
                ReDim Preserve aTipo_Doc(0 To x)
                ReDim Preserve aNum_Doc(0 To x)
                ReDim Preserve afecha_doc(0 To x)
                ReDim Preserve avalor_doc(0 To x)
                ReDim Preserve atipo_compra(0 To x)
                ReDim Preserve aIdInsumo(0 To x)
                ReDim Preserve aInsumo(0 To x)
                ReDim Preserve acantidad(0 To x)
                ReDim Preserve aUnidad(0 To x)
                ReDim Preserve aPrecio_Unitario(0 To x)
                ReDim Preserve aTipo_Pago(0 To x)
                ReDim Preserve anum_docpago(0 To x)
                ReDim Preserve abanco(0 To x)
                ReDim Preserve afecha_vcto(0 To x)
                ReDim Preserve aValor_Pago(0 To x)
                ReDim Preserve aSemilla(0 To x)
                ReDim Preserve aVariedad(0 To x)


                aTipo_Doc(x) = datatbl(0)
                aNum_Doc(x) = datatbl(1)
                aFecha_Doc(x) = datatbl(2)
                aValor_Doc(x) = datatbl(3)
                aTipo_Compra(x) = datatbl(4)
                aIdInsumo(x) = datatbl(5)
                aInsumo(x) = datatbl(6)
                aCantidad(x) = datatbl(7)
                aUnidad(x) = datatbl(8)
                aPrecio_Unitario(x) = datatbl(9)
                aTipo_Pago(x) = datatbl(10)
                aNum_Docpago(x) = datatbl(11)
                aBanco(x) = datatbl(12)
                aFecha_Vcto(x) = datatbl(13)
                aValor_Pago(x) = datatbl(14)
                aSemilla(x) = datatbl(15)
                aVariedad(x) = datatbl(16)
                x += 1


                'dr = doc_h.NewRow

            End While

            close_conexion()

            'CABECERA
            'Fecha,Nro.Doc.,Monto,Tipo
            iRow = 0
            For i As Integer = 0 To UBound(aTipo_Doc)

                If i > 0 Then
                    If aTipo_Doc(i) <> aTipo_Doc(i - 1) Or aNum_Doc(i) <> aNum_Doc(i - 1) Then
                        doc_header.Rows.Add()
                        doc_header.Rows(iRow).Cells(0).Value = aFecha_Doc(i)
                        doc_header.Rows(iRow).Cells(1).Value = aTipo_Doc(i)
                        doc_header.Rows(iRow).Cells(2).Value = Format(Val(aNum_Doc(i)), "############")
                        doc_header.Rows(iRow).Cells(3).Value = Format(aValor_Doc(i), "###,###,###")
                        doc_header.Rows(iRow).Cells(4).Value = aTipo_Compra(i)
                        iRow += 1

                    End If
                Else
                    doc_header.Rows.Add()
                    doc_header.Rows(iRow).Cells(0).Value = aFecha_Doc(i)
                    doc_header.Rows(iRow).Cells(1).Value = aTipo_Doc(i)
                    doc_header.Rows(iRow).Cells(2).Value = Format(Val(aNum_Doc(i)), "############")
                    doc_header.Rows(iRow).Cells(3).Value = Format(aValor_Doc(i), "###,###,###")
                    doc_header.Rows(iRow).Cells(4).Value = aTipo_Compra(i)
                    iRow += 1

                    '                    dr = doc_h.NewRow
                    '                    dr(0) = Format(aFecha_Doc(i), "dd-MM-yyyy")
                    '                    dr(1) = aTipo_Doc(i) + ":" + Format(Val(aNum_Doc(i)), "############")
                    '                    dr(2) = Format(aValor_Doc(i), "###,###,###")
                    '                    dr(3) = aTipo_Compra(i)
                    '                    doc_h.Rows.Add(dr)

                End If
            Next


            '        Me.txt_Saldo_Abono.Text = Format(dSaldo_Abono, "###,##0")
            '        Me.txt_Saldo_Canje.Text = Format(dSaldo_Canje, "###,##0")

            '        Me.TXT_Saldo_Puntaje_Cartola.Text = Format(dSaldo, "###,##0")


            doc_header.Focus()
        End If

    End Sub
    Function RecuperaDatosProveedor(ByVal sRUT As String, ByVal bshow As Boolean) As Boolean
        sSsql = "SP_LECTURA_PROVEEDOR '" + sRUT + "'"

        '0  rut,
        '1  Nombre,
        '2  Direccion,
        '3  Comuna,
        '4  Ciudad,
        '5  Tel_Casa,
        '6  Tel_Oficina,
        '7  Tel_Celular,
        '8  Tel_Fax,
        '9  eMail,
        '10 Comentario,
        '11 Contacto,
        '12 Giro

        ' command.Dispose()
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        'command = connection.CreateCommand()
        'command.CommandText = sSsql
        'datatbl = command.ExecuteReader()

        If datatbl.HasRows Then
            datatbl.Read()
            If bshow Then
                txt_rutproveedor.Text = Mid(sRUT, 1, 11)
                txt_digitorut.Text = Mid(sRUT, 12)
                txt_NOMBRES.Text = datatbl(1)
                txt_dircli.Text = datatbl(2).ToString
                txt_comuna.Text = datatbl(3).ToString
                txt_ciudad.Text = datatbl(4).ToString
                txt_telcasa.Text = datatbl(5).ToString
                txt_teloficina.Text = datatbl(6).ToString
                txt_telcelular.Text = datatbl(7).ToString
                txt_fax.Text = datatbl(8).ToString
                txt_email.Text = datatbl(9).ToString
                TXT_Comentarios.Text = datatbl(10).ToString
                TXT_Contacto.Text = datatbl(11).ToString
                TXT_Giro.Text = datatbl(12).ToString
            End If
            gRUTproveedor = sRUT
            bOK = True
        Else
            bOK = False
        End If
        datatbl.Close()
        close_conexion()
        RecuperaDatosProveedor = bOK
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarProveedor.Click
        SeleccionProveedor()
    End Sub
    Private Sub CreaTablaCartola()
        ' Setea tablas de documentos para Cabecera y Detalle

        'Tabla Cabecera
        Dim dc0 As New DataColumn("Fecha", System.Type.GetType("System.String"))
        Dim dc1 As New DataColumn("Nro.Doc.", System.Type.GetType("System.String"))
        Dim dc2 As New DataColumn("Monto", System.Type.GetType("System.String"))
        Dim dc3 As New DataColumn("Tipo", System.Type.GetType("System.String"))

        'With doc_h.Columns
        '.Add(dc0)
        '.Add(dc1)
        '.Add(dc2)
        '.Add(dc3)
        'End With


        'doc_header.DataSource = doc_h

        'Tabla Detalle
        Dim dd0 As New DataColumn("Insumo", System.Type.GetType("System.String"))
        Dim dd1 As New DataColumn("Cantidad", System.Type.GetType("System.String"))
        Dim dd2 As New DataColumn("Unidad", System.Type.GetType("System.String"))
        Dim dd3 As New DataColumn("Precio Unitario", System.Type.GetType("System.String"))
        Dim dd4 As New DataColumn("Total", System.Type.GetType("System.String"))

        'With doc_d.Columns
        ' .Add(dd0)
        ' .Add(dd1)
        ' .Add(dd2)
        ' .Add(dd3)
        ' .Add(dd4)
        'End With

        'doc_detalle.DataSource = doc_d

        'Tabla Pagos
        Dim dp0 As New DataColumn("Doc.Pago", System.Type.GetType("System.String"))
        Dim dp1 As New DataColumn("Banco", System.Type.GetType("System.String"))
        Dim dp2 As New DataColumn("Fecha Vcto.", System.Type.GetType("System.String"))
        Dim dp3 As New DataColumn("Valor Docto.", System.Type.GetType("System.String"))

        'With doc_p.Columns
        '.Add(dp0)
        '.Add(dp1)
        '.Add(dp2)
        '.Add(dp3)
        'End With

        'doc_pagos.DataSource = doc_p




    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        ' Busca por Nombre
        txt_nombre.Enabled = True
        txt_nombre.ReadOnly = False
        txt_Rut.Enabled = False
        txt_Rut.ReadOnly = True
        txt_digrut.Enabled = False
        txt_digrut.ReadOnly = True
        txt_nombre.Focus()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        'busca por rut
        txt_nombre.Enabled = False
        txt_nombre.ReadOnly = True
        txt_Rut.Enabled = True
        txt_Rut.ReadOnly = False
        txt_digrut.Enabled = True
        txt_digrut.ReadOnly = False
        txt_Rut.Focus()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

        Dim sRUT As String
        sRUT = FormateaRUT()
        If ValidarDatos() Then

            '@RUT,@NOMBRE,@DIRECCION,@COMUNA,@CIUDAD,@TEL_CASA,@TEL_OFICINA,@TEL_CELULAR,@TEL_FAX,@EMAIL,
            '@COMENTARIO,@USR_NAME,@CONTACTO,@GIRO varchar(50)

            sSsql = "SP_GRABA_PROVEEDOR '" + sRUT + "','" + UCase(txt_NOMBRES.Text) + "','" + txt_dircli.Text + "','"
            sSsql += txt_comuna.Text + "','" + txt_ciudad.Text + "','" + txt_telcasa.Text.ToString + "','"
            sSsql += txt_teloficina.Text.ToString + "','" + txt_telcelular.Text.ToString + "','" + txt_fax.Text + "','"
            sSsql += txt_email.Text + "','" + TXT_Comentarios.Text + "','" + gUSER + "','" + TXT_Contacto.Text + "','"
            sSsql += TXT_Giro.Text + "'"
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            command.ExecuteNonQuery()

            DEShabilitaCampos()
            LimpiaCampos()

            txt_Rut.Focus()

            ' limpiar grilla
            'puntaje.Rows.Clear()
            close_conexion()
        End If
    End Sub
    Function ValidarDatos() As Boolean
        Dim sMensaje As String
        bOK = True
        sMensaje = ""
        If txt_rutproveedor.Text = "" Then
            bOK = False
            sMensaje = "Debe ingresar RUT del Proveedor"
        End If
        If txt_NOMBRES.Text = "" Then
            bOK = False
            sMensaje = "Debe Ingresar Nombres del Proveedor"
        End If
        If txt_dircli.Text = "" Then
            bOK = False
            sMensaje = "Debe ingresar Dirección del Proveedor"
        End If
        If txt_telcasa.Text = "" And txt_telcelular.Text = "" And txt_teloficina.Text = "" Then
            bOK = False
            sMensaje = "Debe ingresar al menos un Teléfono de Contacto"
        End If
        If Not bOK Then
            MessageBox.Show(sMensaje)
        End If
        ValidarDatos = bOK
    End Function

    Private Sub txt_digitorut_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        ' validar existencia del rut en la BD
        Dim sRUT As String
        gRUTproveedor = txt_rutproveedor.Text + txt_digitorut.Text
        sRUT = FormateaRUT()
        If RecuperaDatosProveedor(sRUT, True) Then

        End If
    End Sub

    Function FormateaRUT() As String
        Dim sRUT As String
        sRUT = Format(Val(Mid(txt_rutproveedor.Text, 1, 11)), "00000000000") + UCase(txt_digitorut.Text)

        FormateaRUT = sRUT

    End Function

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        LimpiaCampos()
        txt_rutproveedor.ReadOnly = False
        txt_digitorut.ReadOnly = False
        HabilitaCampos()
        txt_rutproveedor.Focus()
        'puntaje.Rows.Clear()
    End Sub

    Private Sub CerrarToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        close_conexion()
        'Me.Visible = False
        Me.Close()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim sRespuesta As String
        Dim SRUTELIMINAR As String

        SRUTELIMINAR = ""

        SRUTELIMINAR = FormateaRUT()

        If SRUTELIMINAR = "00000000000" Then
            MessageBox.Show("Debe seleccionar Proveedor a Eliminar")
        Else
            sRespuesta = InputBox("Está Seguro de Eliminar Proveedor RUT:" + Format(Val(Mid(SRUTELIMINAR, 1, 11)), "##,###,###") + "-" + Mid(SRUTELIMINAR, 12, 1), "ELIMINAR PROVEEDOR", "N")
            If UCase(sRespuesta) = "S" Then
                sSsql = "SP_ELIMINA_PROVEEDOR '" + SRUTELIMINAR + "'"
                open()
                command = connection.CreateCommand()
                command.CommandText = sSsql
                command.ExecuteNonQuery()
                close_conexion()
                LimpiaCampos()
                DEShabilitaCampos()
                doc_header.Rows.Clear()
                doc_detalle.Rows.Clear()
                doc_pagos.Rows.Clear()
                cmb_proveedor.Items.Clear()
                MessageBox.Show("Proveedor ha sido Eliminado de la Base de Datos")
            End If
        End If

    End Sub

    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
        If ValidarDatos() Then
            HabilitaCampos()
            txt_nombre.Focus()
        End If

    End Sub

    Private Sub cmb_proveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_proveedor.SelectedIndexChanged
        CargaCartola(sRUT(Me.cmb_proveedor.SelectedIndex))
    End Sub

    Private Sub Consulta_Proveedor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave

        Me.Close()
    End Sub

    Private Sub Consulta_Proveedor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'CreaTablaCartola()
        cmb_proveedor.Items.Clear()

    End Sub


    Private Sub txt_rutproveedor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_rutproveedor.Leave
        ' validar existencia del rut en la BD
        Dim sRUT As String
        If txt_digitorut.Text <> "" Then
            gRUTproveedor = txt_rutproveedor.Text + txt_digitorut.Text
            sRUT = FormateaRUT()
            RecuperaDatosProveedor(sRUT, True)
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i, j As Integer
        Dim sTipoPago As String
        Dim sNumPago As Double
        Dim dTotalCompra As Double
        Dim dTotalPagos As Double
        Dim bControl As Boolean
        Dim IndiceHeader As Integer
        Dim iRows As Integer

        IndiceHeader = doc_header.CurrentRow.Index
        sTipoPago = doc_header.Rows(IndiceHeader).Cells(1).Value
        sNumPago = doc_header.Rows(IndiceHeader).Cells(2).Value
        'MsgBox(Str(doc_header.CurrentRow.Index))
        'MsgBox(doc_h.Rows(doc_header.CurrentRow.Index)(1))

        txt_Documento.Text = sTipoPago + Str(sNumPago)

        doc_detalle.Rows.Clear()
        doc_pagos.Rows.Clear()
        dTotalCompra = 0
        dTotalPagos = 0
        ' Carga Grilla Productos
        iRows = 0
        For i = 0 To UBound(aTipo_Pago)
            If aTipo_Doc(i) = sTipoPago And Val(aNum_Doc(i)) = sNumPago Then
                'dr = doc_d.NewRow
                'dr(0) = aNombre(i)
                doc_detalle.Rows.Add()
                doc_detalle.Rows(iRows).Cells(0).Value = aInsumo(i)
                doc_detalle.Rows(iRows).Cells(1).Value = aSemilla(i)
                doc_detalle.Rows(iRows).Cells(2).Value = aVariedad(i)
                doc_detalle.Rows(iRows).Cells(3).Value = Format(aCantidad(i), "###")
                doc_detalle.Rows(iRows).Cells(4).Value = aUnidad(i)
                doc_detalle.Rows(iRows).Cells(5).Value = Format(aPrecio_Unitario(i), "###.##")
                doc_detalle.Rows(iRows).Cells(6).Value = Format(aCantidad(i) * aPrecio_Unitario(i), "###,###,###")
                dTotalCompra += (aCantidad(i) * aPrecio_Unitario(i))
                iRows += 1
                'doc_d.Rows.Add(dr)
            End If
        Next

        ' Carga Grilla Pagos
        iRows = 0
        For i = 0 To UBound(aTipo_Pago)
            If Not IsDBNull(aTipo_Pago(i)) Then
                If aTipo_Doc(i) = sTipoPago And Val(aNum_Doc(i)) = sNumPago Then
                    bControl = False
                    'If doc_p.Rows.Count > 0 Then
                    For j = 0 To doc_pagos.Rows.Count - 1
                        If doc_pagos.Rows(j).Cells(0).Value = aTipo_Pago(i) And doc_pagos.Rows(j).Cells(1).Value = aBanco(i) And doc_pagos.Rows(j).Cells(3).Value = Format(aValor_Pago(i), "###,###,###") Then
                            bControl = True
                            Exit For
                        End If
                    Next
                    'End If
                    If Not bControl Then
                        If Not IsDBNull(aTipo_Pago(i)) Then
                            'dr = doc_p.NewRow
                            doc_pagos.Rows.Add()
                            doc_pagos.Rows(iRows).Cells(0).Value = aTipo_Pago(i)
                            doc_pagos.Rows(iRows).Cells(1).Value = aBanco(i)
                            doc_pagos.Rows(iRows).Cells(2).Value = aNum_Docpago(i)
                            doc_pagos.Rows(iRows).Cells(3).Value = aFecha_Vcto(i)
                            doc_pagos.Rows(iRows).Cells(4).Value = Format(aValor_Pago(i), "###,###,###")
                            dTotalPagos += aValor_Pago(i)
                            iRows += 1
                        End If
                    End If

                End If

            End If
        Next
        txt_TotalCompra.Text = Format(dTotalCompra, "###,###,###")
        txt_TotalPagos.Text = Format(dTotalPagos, "###,###,###")

    End Sub

    Private Sub txt_digitorut_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_digitorut.LostFocus
        Valida_Proveedor()
    End Sub
    Private Sub Valida_Proveedor()
        Dim sRut As String
        sRut = FormateaRUT()
        RecuperaDatosProveedor(sRut, True)
    End Sub

 
End Class