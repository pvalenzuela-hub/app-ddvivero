Imports System.Collections.Generic
Imports System.Data

Public Class LotesPorSembrar
    Private Sub LotesPorSembrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EjecutaConsulta()
        Me.SP_CONSULTA_LOTE_SIN_SEMBRARTableAdapter.Fill(Me.DataSetReporteInventario.SP_CONSULTA_LOTE_SIN_SEMBRAR, dtpFechaSiembra.Value)
        CargarResumenBandejas()
    End Sub

    Private Sub CargarResumenBandejas()
        DataResumen.Rows.Clear()

        Dim resumen As New Dictionary(Of String, Decimal)()

        For Each fila As DataRow In Me.DataSetReporteInventario.SP_CONSULTA_LOTE_SIN_SEMBRAR.Rows
            If fila.IsNull("Tipo") OrElse fila.IsNull("TotalBandejas") Then
                Continue For
            End If

            Dim tipo As String = fila("Tipo").ToString().Trim()
            If tipo = String.Empty Then
                Continue For
            End If

            Dim bandejas As Decimal = 0D
            Decimal.TryParse(fila("TotalBandejas").ToString(), bandejas)

            If resumen.ContainsKey(tipo) Then
                resumen(tipo) += bandejas
            Else
                resumen(tipo) = bandejas
            End If
        Next

        Dim claves As New List(Of String)(resumen.Keys)
        claves.Sort()

        For Each clave As String In claves
            DataResumen.Rows.Add(clave, resumen(clave))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EjecutaConsulta()
    End Sub
End Class
