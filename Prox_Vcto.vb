Imports System.Data.SqlClient
Public Class Prox_Vcto
    Dim datatbl As SqlClient.SqlDataReader = Nothing
    Dim Command As SqlCommand = Nothing
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub CargaGrilla()

        Dim dTotal As Double
        Dim dSaldoTotalVencido As Double = 0
        Dim i As Integer
        'Ejecutar Consulta

        DataCompras.Rows.Clear()
        sSsql = ConsultaComprasPendientesSql()
        open()
        Command = connection.CreateCommand()
        Command.CommandText = sSsql
        datatbl = Command.ExecuteReader()

        dTotal = 0
        i = 0
        If datatbl.HasRows Then
            While datatbl.Read
                DataCompras.Rows.Add()
                DataCompras.Rows(i).Cells(0).Value = datatbl(0)
                DataCompras.Rows(i).Cells(1).Value = datatbl(1)
                DataCompras.Rows(i).Cells(2).Value = datatbl(2)
                DataCompras.Rows(i).Cells(3).Value = datatbl(3)
                DataCompras.Rows(i).Cells(4).Value = datatbl(4)
                DataCompras.Rows(i).Cells(5).Value = datatbl(5)
                DataCompras.Rows(i).Cells(6).Value = datatbl(6)
                DataCompras.Rows(i).Cells(7).Value = datatbl("Fecha_Vencimiento")

                If datatbl("Vencida") = 1 Then
                    dSaldoTotalVencido += datatbl("Saldo")
                    DataCompras.Rows(i).DefaultCellStyle.BackColor = Color.Red
                    DataCompras.Rows(i).DefaultCellStyle.ForeColor = Color.White
                End If
                i += 1
                dTotal += datatbl(6)
            End While

        Else
            MessageBox.Show("NO EXISTEN DATOS ASOCIADOS A LA CONSULTA")
        End If
        close_conexion()
        txt_Total.Text = Format(dTotal, "###,###,###")
        txt_SaldoVencido.Text = Format(dSaldoTotalVencido, "###,###,###")

    End Sub

    Private Function ConsultaComprasPendientesSql() As String
        Return "WITH CTE_PagosPagados AS (" &
               " SELECT CP.IDCOMPRAS, SUM(ISNULL(CP.VALOR_DOC, 0)) AS Total_pagado" &
               " FROM COMPRA_PAGOS CP" &
               " WHERE ISNULL(CP.PAGADO, 0) = 1" &
               " GROUP BY CP.IDCOMPRAS" &
               "), CTE_PagosPendientes AS (" &
               " SELECT CP.IDCOMPRAS, CP.VALOR_DOC AS Valor_Cuota_Pendiente, CP.FECHA_VCTO AS Fecha_Vencimiento" &
               " FROM COMPRA_PAGOS CP" &
               " WHERE ISNULL(CP.PAGADO, 0) <> 1" &
               "), CTE_Resultados AS (" &
               " SELECT A.IDCOMPRAS, A.Tipo_doc, A.Num_doc, CONVERT(varchar(10), A.fecha_doc, 103) AS Fecha, pro.NOMBRE AS Proveedor," &
               " A.Valor_doc AS Valor_Factura, ISNULL(PP.Total_pagado, 0) AS Total_pagado, A.Valor_doc - ISNULL(PP.Total_pagado, 0) AS Saldo," &
               " Pend.Valor_Cuota_Pendiente," &
               " CASE WHEN Pend.Fecha_Vencimiento IS NOT NULL THEN CONVERT(varchar(10), Pend.Fecha_Vencimiento, 103) ELSE 'Pendiente' END AS Fecha_Vencimiento," &
               " CASE WHEN Pend.Fecha_Vencimiento IS NOT NULL AND CONVERT(date, Pend.Fecha_Vencimiento) < CONVERT(date, GETDATE()) THEN 1 ELSE 0 END AS Vencida," &
               " Pend.Fecha_Vencimiento AS FechaOrden" &
               " FROM Compra_Header A" &
               " INNER JOIN Proveedor pro ON pro.RUT = A.RUT" &
               " LEFT JOIN CTE_PagosPagados PP ON PP.IDCOMPRAS = A.IDCOMPRAS" &
               " LEFT JOIN CTE_PagosPendientes Pend ON Pend.IDCOMPRAS = A.IDCOMPRAS" &
               " WHERE A.Tipo_doc IN ('FA', 'BE')" &
               " AND A.Valor_doc > ISNULL(PP.Total_pagado, 0)" &
               ")" &
               " SELECT Tipo_doc, Num_doc, Fecha, Proveedor, Saldo AS Valor_doc, Total_pagado, Saldo, Valor_Cuota_Pendiente, Fecha_Vencimiento, Vencida" &
               " FROM CTE_Resultados" &
               " ORDER BY Vencida DESC, CASE WHEN FechaOrden IS NULL THEN 1 ELSE 0 END, FechaOrden, Num_doc"
    End Function



    Private Sub Prox_Vcto_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargaGrilla()
    End Sub
End Class
