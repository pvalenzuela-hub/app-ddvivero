Public Class RebajaAbonoInicial
    Private Sub RebajaAbonoInicial_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.BANCOTableAdapter.Fill(Me.GESTDataSet.BANCO)
        Dim i As Integer = 0
        sSsql = "NEWSP_ConsultaDevoluciones "
        sSsql += Val(txtIdCliente.Text).ToString
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            While datatbl.Read()
                DataDevoluciones.Rows.Add()
                DataDevoluciones.Rows(i).Cells("fecha").Value = datatbl("Fecha")
                DataDevoluciones.Rows(i).Cells("monto").Value = datatbl("MontoDevolucion")
                DataDevoluciones.Rows(i).Cells("nombrecuenta").Value = datatbl("Nombre")
                DataDevoluciones.Rows(i).Cells("cuenta").Value = datatbl("Cta_Ctble")
                DataDevoluciones.Rows(i).Cells("usuario").Value = datatbl("Vendedor")
                i += 1
            End While
        End If

        close_conexion()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub txtMontoDevolucion_LostFocus(sender As Object, e As EventArgs) Handles txtMontoDevolucion.LostFocus
        If Val(txtMontoDevolucion.Text) > Val(txtMontoAbono.Text) Then
            MsgBox("Valor de Devolución no puede ser mayor al Saldo de Abono!!!", MsgBoxStyle.Critical, "Devolución Abono")
            txtMontoDevolucion.Clear()
            txtMontoDevolucion.Select()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cmb_TIPO_PAGO.SelectedIndex > -1 AndAlso Val(txtMontoDevolucion.Text) > 0 AndAlso Val(txtIdCliente.Text) > 0 AndAlso Val(txtMontoAbono.Text) > 0 Then
            Dim idBanco As Integer = cmb_TIPO_PAGO.SelectedValue
            Dim idCliente As Integer = Val(txtIdCliente.Text)
            Dim idVendedor As Integer = gIdVendedor

            sSsql = "NEWSP_INSERTA_DevolucionAbonoInicial "
            sSsql += idCliente.ToString & ","
            sSsql += Val(txtMontoDevolucion.Text).ToString & ","
            sSsql += idBanco.ToString & ","
            sSsql += idVendedor.ToString

            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            command.ExecuteNonQuery()
            close_conexion()
            MsgBox("El Monto de Devolución de Abono ha sido almacenado y contabilizado.", MsgBoxStyle.Information, "Devolución Abono")
            Abono_Deuda.Rescata_Resumen_Cliente()
            Me.Close()
        Else
            MsgBox("Algo salió mal, revise Selección de Cuenta, Monto a devolver, verifique si Cliente tiene saldo de Abono", MsgBoxStyle.Critical, "Devolución Abono")

        End If
    End Sub
End Class