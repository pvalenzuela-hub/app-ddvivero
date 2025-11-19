Imports System.Data.SqlClient
Public Class Ranking
    Dim datatbl As SqlClient.SqlDataReader = Nothing
    Dim command As SqlCommand = Nothing

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Genera_Consulta()
    End Sub
    Private Sub Genera_Consulta()
        Dim i As Integer
        Dim dTotMonto As Double = 0
        Dim dTotCanti As Double = 0
        sSsql = ""
        If rdb_cliente.Checked = True Then
            If rdb_Monto.Checked = True Then
                sSsql = "SP_RANKING_CLIENTE '" + Format(CDate(DateDesde.Text), "dd/MM/yyyy") + "','"
                sSsql += Format(CDate(DateHasta.Text), "dd/MM/yyyy") + "',1"
            Else
                sSsql = "SP_RANKING_CLIENTE '" + Format(CDate(DateDesde.Text), "dd/MM/yyyy") + "','"
                sSsql += Format(DateHasta.Value, "dd/MM/yyyy") + "',2"
            End If
            DataConsulta.Columns(0).HeaderText = "Clientes"
        End If
        If rdb_Variedad.Checked = True Then
            If rdb_Monto.Checked = True Then
                sSsql = "SP_RANKING_VARIEDAD '" + Format(CDate(DateDesde.Text), "dd/MM/yyyy") + "','"
                sSsql += Format(CDate(DateHasta.Text), "dd/MM/yyyy") + "',1"
            Else
                sSsql = "SP_RANKING_VARIEDAD '" + Format(CDate(DateDesde.Text), "dd/MM/yyyy") + "','"
                sSsql += Format(CDate(DateHasta.Text), "dd/MM/yyyy") + "',2"
            End If
        End If
        If rdb_semilla.Checked Then
            If rdb_Monto.Checked = True Then
                sSsql = "SP_RANKING_SEMILLA '" + Format(CDate(DateDesde.Text), "dd/MM/yyyy") + "','"
                sSsql += Format(CDate(DateHasta.Text), "dd/MM/yyyy") + "',1"
            Else
                sSsql = "SP_RANKING_SEMILLA '" + Format(CDate(DateDesde.Text), "dd/MM/yyyy") + "','"
                sSsql += Format(DateHasta.Value, "dd/MM/yyyy") + "',2"
            End If
            DataConsulta.Columns(0).HeaderText = "Semilla"

        End If
        i = 0
        If sSsql <> "" Then
            DataConsulta.Rows.Clear()
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                dTotCanti = 0
                dTotMonto = 0
                While datatbl.Read = True
                    DataConsulta.Rows.Add()
                    DataConsulta.Rows(i).Cells(0).Value = datatbl(0)
                    DataConsulta.Rows(i).Cells(1).Value = Format(datatbl(1), "###,###,###")
                    DataConsulta.Rows(i).Cells(2).Value = Format(datatbl(2), "###,###,###")
                    dTotMonto += datatbl(1)
                    dTotCanti += datatbl(2)
                    i += 1
                End While
                DataConsulta.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                DataConsulta.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
            datatbl.Close()
            close_conexion()
            txt_TotCant.Text = Format(dTotCanti, "###,###,###,###")
            txt_TotMonto.Text = Format(dTotMonto, "###,###,###,###")
        End If
    End Sub
End Class