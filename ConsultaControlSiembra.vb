Public Class ConsultaControlSiembra

    Private Sub ConsultaControlSiembra_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSetControlSiembra.SP_ReporteControlSiembra' Puede moverla o quitarla según sea necesario.

        Me.SP_ReporteControlSiembraTableAdapter.Connection.ConnectionString = gSOURCE

        ' Me.SP_ReporteControlSiembraTableAdapter.Fill(Me.GESTDataSetControlSiembra.SP_ReporteControlSiembra)
        'TODO: esta línea de código carga datos en la tabla 'GESTDataSetSiembra60dias.SP_ReporteEstadSiembra60dias' Puede moverla o quitarla según sea necesario.
        'Me.SP_ReporteEstadSiembra60diasTableAdapter.Fill(Me.GESTDataSetSiembra60dias.SP_ReporteEstadSiembra60dias)
        CargaGrillaTotales()
    End Sub

    Private Sub CargaGrillaTotales()
        Dim dTotalSembradoDia As Double
        Dim dtipo1 As Double = 0
        Dim dTipo2 As Double = 0
        Dim dTipo3 As Double = 0
        Dim dTipo4 As Double = 0
        Dim dTipo5 As Double = 0
        Dim dTipo6 As Double = 0
        Dim dTipo7 As Double = 0
        Dim dTipo8 As Double = 0

        Dim i As Integer = 0
        sSsql = "SP_ReporteEstadSiembra60dias"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        GrillaTotales.Rows.Clear()

        If datatbl.HasRows Then
            While datatbl.Read = True
                GrillaTotales.Rows.Add()
                dTotalSembradoDia = 0
                If IsDBNull(datatbl(1)) = False Then
                    dTotalSembradoDia += datatbl(1)
                    dtipo1 = datatbl(1)
                Else
                    dtipo1 = 0
                End If
                If IsDBNull(datatbl(2)) = False Then
                    dTotalSembradoDia += datatbl(2)
                    dTipo2 = datatbl(2)
                Else
                    dTipo2 = 0
                End If
                If IsDBNull(datatbl(3)) = False Then
                    dTotalSembradoDia += datatbl(3)
                    dTipo3 = datatbl(3)
                Else
                    dTipo3 = 0
                End If
                If IsDBNull(datatbl(4)) = False Then
                    dTotalSembradoDia += datatbl(4)
                    dTipo4 = datatbl(4)
                Else
                    dTipo4 = 0
                End If
                If IsDBNull(datatbl(5)) = False Then
                    dTotalSembradoDia += datatbl(5)
                    dTipo5 = datatbl(5)
                Else
                    dTipo5 = 0
                End If
                If IsDBNull(datatbl(6)) = False Then
                    dTotalSembradoDia += datatbl(6)
                    dTipo6 = datatbl(6)
                Else
                    dTipo6 = 0
                End If
                If IsDBNull(datatbl(7)) = False Then
                    dTotalSembradoDia += datatbl(7)
                    dTipo7 = datatbl(7)
                Else
                    dTipo7 = 0
                End If

                If IsDBNull(datatbl(8)) = False Then
                    dTotalSembradoDia += datatbl(8)
                    dTipo7 = datatbl(8)
                Else
                    dTipo8 = 0
                End If
                GrillaTotales.Rows(i).Cells(0).Value = datatbl(0)
                GrillaTotales.Rows(i).Cells(1).Value = dTotalSembradoDia
                GrillaTotales.Rows(i).Cells(2).Value = dtipo1
                GrillaTotales.Rows(i).Cells(3).Value = dTipo2
                GrillaTotales.Rows(i).Cells(4).Value = dTipo3
                GrillaTotales.Rows(i).Cells(5).Value = dTipo4
                GrillaTotales.Rows(i).Cells(6).Value = dTipo5
                GrillaTotales.Rows(i).Cells(7).Value = dTipo6
                GrillaTotales.Rows(i).Cells(8).Value = dTipo7
                GrillaTotales.Rows(i).Cells(9).Value = dTipo8


                i += 1
            End While
        Else
            MsgBox("NO EXISTEN LOTES SEMBRADOS")
        End If

        close_conexion()
    End Sub


    Private Sub GrillaControl_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrillaControl.CellDoubleClick
        Dim iNumLote As Integer
        Dim iFilaActual As Integer

        iFilaActual = GrillaControl.CurrentRow.Index

        iNumLote = GrillaControl.Rows(iFilaActual).Cells(0).Value

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