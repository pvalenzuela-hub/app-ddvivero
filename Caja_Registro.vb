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

        GrillaCaja.Rows.Clear()
        open()

        Try
            Using cmd As SqlCommand = connection.CreateCommand()
                cmd.CommandText = "SP_CONSULTA_CONTA_SaldosdiariosApertura"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@FechaApertura", SqlDbType.DateTime).Value = dtp_FechaApertura.Value.Date
                cmd.Parameters.Add("@Cta_Ctble", SqlDbType.VarChar, 7).Value = txt_Cta_Ctble.Text.Trim()

                Using reader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            GrillaCaja.Rows.Add()
                            GrillaCaja.Rows(i).Cells(0).Value = reader(0)
                            GrillaCaja.Rows(i).Cells(1).Value = reader(1)
                            GrillaCaja.Rows(i).Cells(2).Value = Format(reader(2), "###,###,###")
                            GrillaCaja.Rows(i).Cells(3).Value = reader(3)
                            i += 1
                        End While
                    End If
                End Using
            End Using
        Finally
            close_conexion()
        End Try
    End Sub
End Class
