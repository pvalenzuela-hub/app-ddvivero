Public Class Ajuste_INV
    Dim STOCK(0 To 0) As Double
    Dim CODPROD(0 To 0) As String
    Dim gCODPROD As String

    Private Sub Ajuste_INV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AbreConexionDB()
        Me.txt_Fecha_Mov.Text = Now.Date
        sSsql = "SELECT CODIGO, NOMBRE, STOCK_TOTAL FROM PRODUCTO ORDER BY NOMBRE"
        'If EjecutaSQL(sSsql, "PRODUCTO") Then
        '    'X = ds.Tables("PRODUCTO").Rows.Count - 1

        '    ReDim CODPROD(0 To X)
        '    ReDim STOCK(0 To X)

        '    For i = 0 To X
        '        '   sProducto = ds.Tables("PRODUCTO").Rows(i).Item(1).ToString + Space(51 - Len(Trim(ds.Tables("PRODUCTO").Rows(i).Item(1).ToString))) + Trim(ds.Tables("PRODUCTO").Rows(i).Item(0).ToString)
        '        'cmb_Productos.Items.Add(sProducto)
        '        '  CODPROD(i) = ds.Tables("PRODUCTO").Rows(i).Item(0).ToString
        '        ' STOCK(i) = ds.Tables("PRODUCTO").Rows(i).Item(2).ToString
        '    Next
        'End If

    End Sub

    Private Sub CerrarVentanaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarVentanaToolStripMenuItem.Click

        Me.Close()
    End Sub

    Private Sub cmb_Productos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Productos.SelectedIndexChanged
        Me.txt_Stock.Text = STOCK(Me.cmb_Productos.SelectedIndex)
        gCODPROD = CODPROD(Me.cmb_Productos.SelectedIndex)
    End Sub

    Private Sub GuardarCambiosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarCambiosToolStripMenuItem.Click
        'Dim sRespuesta As String
        'Dim dStock_Original As Double
        'Dim iTipoMov As Integer

        'dStock_Original = Val(txt_Stock.Text)
        'iTipoMov = 0
        'If cmb_TipoAjuste.Text = "Entrada" Then
        '    txt_Stock.Text = dStock_Original + txt_Cantidad.Value
        '    iTipoMov = 4
        'Else
        '    txt_Stock.Text = dStock_Original - txt_Cantidad.Value
        '    iTipoMov = 3
        'End If

        'sRespuesta = InputBox("Confirme los cambios que va a guardar para ajuste de Inventario", "Ajuste Manual de Inventario", "N")
        'If sRespuesta = "S" Then
        '    ' Guarda los Cambios en la tabla de movimiento y Productos
        '    ' Graba Tabla de Movimientos de Inventario
        '    sSsql = "INSERT INTO INV_MOVTO (COD_PROD, TIPO_MOV, FEC_MOV, GLOSA, CANTIDAD) "
        '    sSsql += "VALUES ('" + gCODPROD + "'," + Str(iTipoMov) + ",'" + txt_Fecha_Mov.Text + "','" + txt_Glosa.Text + "',"
        '    sSsql += Format(txt_Cantidad.Value, "#######0") + ")"
        '    'EjecutaSQL(sSsql, "INV_MOVTO")

        '    ' Actualiza Stock en Maestro de Productos
        '    If iTipoMov = 4 Then
        '        sSsql = "UPDATE PRODUCTO SET STOCK_TOTAL = STOCK_TOTAL +" + Format(txt_Cantidad.Value, "######0")
        '    Else
        '        sSsql = "UPDATE PRODUCTO SET STOCK_TOTAL = STOCK_TOTAL -" + Format(txt_Cantidad.Value, "######0")
        '    End If
        '    sSsql += " WHERE CODIGO = '" + gCODPROD + "'"
        '    ' EjecutaSQL(sSsql, "PRODUCTO")

        'Else
        '    txt_Stock.Text = dStock_Original
        'End If
    End Sub
End Class