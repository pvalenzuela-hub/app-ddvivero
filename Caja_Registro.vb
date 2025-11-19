Imports System.Data.SqlClient
Public Class Caja_Registro


   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

   
   
    Private Sub Graba_Movimiento_Caja()

        'Dim dValor_ingreso As Double
        'Dim dValor_egreso As Double
        'If cmb_TipoMovto.SelectedIndex = 0 Then
        '    dValor_ingreso = Val(txt_MontoMovto.Text)
        '    dValor_egreso = 0
        'Else
        '    dValor_egreso = Val(txt_MontoMovto.Text)
        '    dValor_ingreso = 0
        'End If
        'sSsql = "SP_GRABA_MOVIMIENTO_CAJA_DETALLE "
        ''@IdCajaDet numeric(18,0),"
        'sSsql += Str(dNumMovimiento) + ","
        ''@Fecha_Movto datetime,
        'sSsql += "'" + dtp_FechaApertura.Value + "',"
        ''@Valor_ingreso numeric(18,0),
        'sSsql += Str(dValor_ingreso) + ","
        ''@Valor_egreso  numeric(18,0),
        'sSsql += Str(dValor_egreso) + ","
        ''@Glosa varchar(100)
        'sSsql += "'" + txt_Glosa.Text + "'"

        'open()
        'command = connection.CreateCommand()
        'command.CommandText = sSsql
        'command.ExecuteNonQuery()

        'close_conexion()
        'Limpia_Campos()
        'Recupera_Saldo_Caja()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
    
    End Sub

   

    Private Sub Caja_Registro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      
    End Sub

   

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Lectura_Saldo_Apertura()
    End Sub
    Private Sub Lectura_Saldo_Apertura()
        Dim i As Integer = 0
        sSsql = "SP_CONSULTA_CONTA_SaldosdiariosApertura "
        sSsql += "'" + Format(dtp_FechaApertura.Value, "d") + "'"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then
            While datatbl.Read
                GrillaCaja.Rows.Add()
                GrillaCaja.Rows(i).Cells(0).Value = datatbl(0)
                GrillaCaja.Rows(i).Cells(1).Value = datatbl(1)
                GrillaCaja.Rows(i).Cells(2).Value = Format(datatbl(2), "###,###,###")
                GrillaCaja.Rows(i).Cells(3).Value = datatbl(3)
                i += 1
            End While
        End If
        close_conexion()
    End Sub
End Class