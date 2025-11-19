Public Class RegistroCuentaContableEstadoResultado

    Private Sub RegistroCuentaContableEstadoResultado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Me.CuentaContableEstadoResultadoTableAdapter.Connection.ConnectionString = gSOURCE
        Me.CuentaContableFlujoIngresosEgresosPresupuestoTableAdapter.Connection.ConnectionString = gSOURCE

        Me.CuentaContableFlujoIngresosEgresosPresupuestoTableAdapter.Fill(Me.GESTDataSet16.CuentaContableFlujoIngresosEgresosPresupuesto)
        'Me.CuentaContableEstadoResultadoTableAdapter.Fill(Me.GESTDataSet15.CuentaContableEstadoResultado)



    End Sub



    Private Sub DataGridView3_RowEnter1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.RowEnter
        REM Edicion Cuenta Estado de Resultados
        Try
            Me.Validate()
            Me.CuentaContableEstadoResultadoBindingSource.EndEdit()
            'Me.CuentaContableEstadoResultadoTableAdapter.Update(Me.GESTDataSet15.CuentaContableEstadoResultado)

            'MsgBox("Datos Actualizados correctamente")

        Catch ex As Exception
            MsgBox("Falló la actualizaci{on, intente nuevamente!!!")
        End Try
    End Sub



    Private Sub DataGridView4_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.RowEnter
        REM Cuentas Contables Flujo Ingreso, Egreso, Presupuesto
        Try
            Me.Validate()
            Me.CuentaContableFlujoIngresosEgresosPresupuestoBindingSource.EndEdit()
            Me.CuentaContableFlujoIngresosEgresosPresupuestoTableAdapter.Update(Me.GESTDataSet16.CuentaContableFlujoIngresosEgresosPresupuesto)

        Catch ex As Exception
            MsgBox("Falló la actualización, intente nuevamente!!!")
        End Try
    End Sub
End Class