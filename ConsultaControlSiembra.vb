Public Class ConsultaControlSiembra

    Private dtResumen As DataTable

    Private Sub ConsultaControlSiembra_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSetControlSiembra.SP_ReporteControlSiembra' Puede moverla o quitarla según sea necesario.

        Me.SP_ReporteControlSiembraTableAdapter.Connection.ConnectionString = gSOURCE
        CargarGrillaSuperior()
    End Sub

    Private Sub CargarGrillaSuperior()
        dtResumen = New DataTable()
        sSsql = "SP_ReporteEstadSiembra60dias"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql

        Using reader As System.Data.Common.DbDataReader = command.ExecuteReader()
            dtResumen.Load(reader)
        End Using

        close_conexion()

        GrillaTotales.AutoGenerateColumns = True
        GrillaTotales.Columns.Clear()
        GrillaTotales.DataSource = dtResumen
    End Sub


    Private Sub GrillaTotales_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrillaTotales.CellDoubleClick
        Dim iNumLote As Integer
        Dim iFilaActual As Integer

        If GrillaTotales.CurrentRow Is Nothing Then
            Return
        End If

        iFilaActual = GrillaTotales.CurrentRow.Index

        iNumLote = GrillaTotales.Rows(iFilaActual).Cells(0).Value

        Cambio_Estado.txt_NumLote.ReadOnly = True
        Cambio_Estado.Button1.Enabled = False
        Cambio_Estado.ArchivoToolStripMenuItem.Enabled = False

        Cambio_Estado.txt_NumLote.Text = iNumLote

        Call Cambio_Estado.EjecutaConsultaLote()


        'Cambio_Estado.Button1
        'Cambio_Estado.Button1.PerformClick()
        Cambio_Estado.Show()
    End Sub
End Class
