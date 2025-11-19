Imports System.Data.SqlClient
Public Class Consulta_Caja
    Dim datatbl As SqlClient.SqlDataReader = Nothing
    Dim command As SqlCommand = Nothing
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Consulta_Caja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Recupera_Detalle_Movimientos()
    End Sub
    Private Sub Recupera_Detalle_Movimientos()

        Dim dSaldoInicial As Double
        Dim dSaldomov As Double
        Dim i As Integer

        GrillaCaja.Rows.Clear()

        sSsql = "SP_CONSULTA_FULL_MOVIMIENTO_CAJA "
        sSsql += "'" + Format(dtp_fechadesde.Value, "dd/MM/yyyy") + "',"
        sSsql += "'" + Format(dtp_fechahasta.Value, "dd/MM/yyyy") + "',"
        sSsql += "1"
        open()

        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        dSaldomov = 0
        If datatbl.HasRows Then
            datatbl.Read()

            '0	A.IdCajaDet,
            '1	A.Fecha_Movto,
            '2  A.Valor_ingreso,
            '3	A.Valor_egreso,
            '4	A.Glosa,
            '5	B.Saldo_Inicial,
            '6  B.Saldo_Actual

            dSaldoInicial = datatbl(5)
            GrillaCaja.Rows.Add()
            GrillaCaja.Rows(0).Cells(2).Value = Format(dSaldoInicial, "###,###,##0")
            dSaldomov += dSaldoInicial
            GrillaCaja.Rows(0).Cells(4).Value = Format(dSaldomov, "###,###,##0")
            GrillaCaja.Rows(0).Cells(5).Value = "SALDO INICIAL"

            GrillaCaja.Rows.Add()
            GrillaCaja.Rows(1).Cells(0).Value = datatbl(0)
            GrillaCaja.Rows(1).Cells(1).Value = RTrim(datatbl(1))
            GrillaCaja.Rows(1).Cells(2).Value = Format(datatbl(2), "###,###,##0")
            dSaldomov += datatbl(2)
            GrillaCaja.Rows(1).Cells(3).Value = Format(datatbl(3), "###,###,##0")
            dSaldomov -= datatbl(3)
            GrillaCaja.Rows(1).Cells(4).Value = Format(dSaldomov, "###,###,##0")
            GrillaCaja.Rows(1).Cells(5).Value = datatbl(4)
            i = 2
            While datatbl.Read = True
                GrillaCaja.Rows.Add()
                GrillaCaja.Rows(i).Cells(0).Value = datatbl(0)
                GrillaCaja.Rows(i).Cells(1).Value = datatbl(1)
                GrillaCaja.Rows(i).Cells(2).Value = Format(datatbl(2), "###,###,##0")
                dSaldomov += datatbl(2)
                GrillaCaja.Rows(i).Cells(3).Value = Format(datatbl(3), "###,###,##0")
                dSaldomov -= datatbl(3)
                GrillaCaja.Rows(i).Cells(4).Value = Format(dSaldomov, "###,###,##0")
                GrillaCaja.Rows(i).Cells(5).Value = datatbl(4)
                GrillaCaja.Rows(i).Cells(6).Value = Mid(datatbl(7), 7, 2) + "/" + Mid(datatbl(7), 5, 2) + "/" + Mid(datatbl(7), 1, 4) 'AAAAMMDD
                GrillaCaja.Rows(i).Cells(7).Value = datatbl(8)
                i += 1
            End While


            txt_SaldoInicial.Text = Format(dSaldoInicial, "###,###,##0")
            txt_SaldoFinal.Text = Format(dSaldomov, "###,###,##0")

        End If
        close_conexion()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Recupera_Detalle_Movimientos()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Dim ifila As Integer
        'If GrillaCaja.Rows.Count > 0 Then
        '    gQuienLlama = 1
        '    ifila = GrillaCaja.CurrentRow.Index
        '    Caja_Registro.txt_NumMovto.Text = GrillaCaja.Rows(ifila).Cells(0).Value
        '    Registro_Apertura.Visible = True
        'End If


    End Sub
End Class