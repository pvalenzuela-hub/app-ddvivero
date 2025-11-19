Imports System.Data.SqlClient
Public Class Consulta_Boleta_Pendiente
    Dim datatbl As SqlClient.SqlDataReader = Nothing
    Dim command As SqlCommand = Nothing
    Private detalle As New DataTable("Grilla_Venta")
    Dim gFiltro As Integer
    Private Sub CargaGrilla()

        Dim dSaldo As Double
        Dim dVenta As Double
        Dim dPago As Double
        Dim dDescto As Double

        Dim dTotal_Venta As Double
        Dim dTotal_Descto As Double
        Dim dTotal_Pendiente As Double
        Dim dTotal_Pagado As Double
        Dim i As Integer

        'Ejecutar Consulta

        DataGrilla.Rows.Clear()

        sSsql = "SP_CONSULTA_VENTAS_SALDOS '" + Format(CDate(txt_Fecha1.Text), "yyyyMMdd") + "','"
        sSsql += Format(CDate(txt_Fecha2.Text), "yyyyMMdd") + "',"
        sSsql += Str(gFiltro)
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()


        If datatbl.HasRows Then
            While datatbl.Read = True

                DataGrilla.Rows.Add()
                i = DataGrilla.Rows.Count - 1

                dVenta = datatbl(3)
                dPago = datatbl(5)
                dDescto = datatbl(4)
                dSaldo = dVenta - dPago

                DataGrilla.Rows(i).Cells(0).Value = datatbl(0)
                DataGrilla.Rows(i).Cells(1).Value = datatbl(1)
                DataGrilla.Rows(i).Cells(2).Value = datatbl(2)
                DataGrilla.Rows(i).Cells(3).Value = Trim(datatbl(6)) + " " + Trim(datatbl(7))
                DataGrilla.Rows(i).Cells(4).Value = datatbl(12)
                DataGrilla.Rows(i).Cells(5).Value = datatbl(11)
                DataGrilla.Rows(i).Cells(6).Value = Format(dVenta, "###,###,###")
                DataGrilla.Rows(i).Cells(7).Value = Format(dDescto, "###,###,##0")
                DataGrilla.Rows(i).Cells(8).Value = Format(dPago, "###,###,##0")
                DataGrilla.Rows(i).Cells(9).Value = Format(dSaldo, "###,###,###")
                DataGrilla.Rows(i).Cells(10).Value = datatbl(14)

                dTotal_Descto += dDescto
                dTotal_Pendiente += dSaldo
                dTotal_Venta += dVenta
                dTotal_Pagado += dPago

            End While
            Me.txt_Venta.Text = Format(dTotal_Venta, "###,###,##0")
            Me.txt_Descto.Text = Format(dTotal_Descto, "###,###,##0")
            Me.txt_Pagado.Text = Format(dTotal_Pagado, "###,###,##0")
            Me.txt_Saldo.Text = Format(dTotal_Pendiente, "###,###,##0")
        Else
            MessageBox.Show("NO EXISTEN DATOS ASOCIADOS A LA CONSULTA")
        End If
        datatbl.Close()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CargaGrilla()
    End Sub

    Private Sub Consulta_Boleta_Pendiente_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        close_conexion()
        Me.Close()
    End Sub

    Private Sub Consulta_Boleta_Pendiente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open()

        gFiltro = 0
    End Sub

    Private Sub CerrarVentanaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarVentanaToolStripMenuItem.Click
        close_conexion()
        Me.Close()
    End Sub


    Private Sub rb1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb1.CheckedChanged
        If rb1.Checked Then
            gFiltro = 0
        End If
    End Sub

    Private Sub rb2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb2.CheckedChanged
        If rb2.Checked Then
            gFiltro = 1
        End If
    End Sub

    Private Sub rb3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb3.CheckedChanged
        If rb3.Checked Then
            gFiltro = 2
        End If
    End Sub

    Private Sub rb4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb4.CheckedChanged
        If rb4.Checked Then
            gFiltro = 3
        End If
    End Sub
End Class