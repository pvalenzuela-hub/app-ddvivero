'Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports SendKey = System.Windows.Forms.SendKeys
Imports System.Drawing.Printing
Imports System.IO
Module FUNCIONES
    Public Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Public datatbl As SqlClient.SqlDataReader = Nothing
    Public datatbl2 As SqlClient.SqlDataReader = Nothing
    Public command As SqlCommand = Nothing
    Public command2 As SqlCommand = Nothing
    Public strConexion As String
    Public bOK As Boolean
    Public gSOURCE As String
    Public gDataEmp As String
    Public gDataEmpFono As String
    Public sServer As String
    Public gBODEGA As String
    REM *******
    REM USUARIO
    REM *******
    Public gUSER As String
    Public gNomUsuario As String
    Public gIdPerfil As Integer
    Public gIdVendedor As Integer


    Public gPrinter As String
    Public gPrintPDF As String
    Public gGTOGRAL As Double
    Public GIVA As Double
    Public gFactorIVA As Single
    Public gNROFACT As Double
    Public gINSCRIP As Double
    Public gMEDICION As Double
    Public dr As DataRow
    Public sSsql As String
    Public gRUT As String
    Public gIDCliente As Integer
    Public gAPELLIDO As String
    Public gNOMBRE As String
    Public connection As SqlConnection
    Public gPrecioSemilla As Double
    Public gQuienLlama As Integer
    Public gIdVariedad As Integer
    Public gSectorDireccion As String
    Public gRutCli As String
    Public gDetalleVariedad As String
    REM Variables Pedido
    Public gStockDispo As Integer
    Public gFechaActualizacion As String
    Public gStockActual As Integer
    Public gStockReservado As Integer
    Public zRut(0 To 0)
    Public zIDCliente(0 To 0)
    Public gPromedioPlantas As Decimal
    ' Variables para Imprimir Nota de Pedido Cliente
    Public gNumPedido As Integer
    Public gNombreCliente As String
    Public aID_FAMILIA_PROD(0 To 0) As Integer
    Public aID_VARIEDAD(0 To 0) As Integer
    Public aPrecio_Costo_Neto_Familia(0 To 0) As Double
    Public aMargen_Porc_Familia(0 To 0) As Double
    Public aPrecio_Neto_Familia(0 To 0) As Double
    Public aPrecio_Neto_Hechura(0 To 0) As Double
    Public aDias_Fabricacion(0 To 0) As Integer
    Public ID_Vendedor(0 To 0) As Integer
    Public Nombre_Vendedor(0 To 0) As String
    Dim command1 As SqlCommand = Nothing
    Dim command3 As SqlCommand = Nothing
    '' llaves de productos
    Public IDPRODUCTO(0 To 0)
    Public CODPROD(0 To 0)
    Public PRECIO(0 To 0)
    Public NDIAS_FABRICACION(0 To 0)
    Public gFAMILIA(0 To 0)
    Public gVARIEDAD(0 To 0)
    Public TB_CODIGO(0 To 0) As Integer
    Public TB_DESCRIP(0 To 0) As String
    Public TB_CANTIDAD(0 To 0) As Integer
    Public TU_ID(0 To 0) As Integer
    Public TU_DESCRIP(0 To 0) As String
    Public TI_ID(0 To 0) As Integer
    Public TI_DESCRIP(0 To 0) As String
    Public TI_COSTO(0 To 0) As Double
    Public TI_IDUnidad(0 To 0) As Integer
    Public TI_DESCUnidad(0 To 0) As String
    Public FO_NumFormula(0 To 0) As Integer
    Public FO_TipoBandeja(0 To 0) As String
    Public FO_Celdas(0 To 0) As Integer
    Public FO_IDTipoBandeja(0 To 0) As Integer
    '' Tabla de Eventos
    Public TE_ID(0 To 0) As Integer
    Public TE_Insumo(0 To 0) As String
    Public TE_Lote(0 To 0) As String
    Public TE_Camara(0 To 0) As String
    Public TE_ConteoPlantas(0 To 0) As String
    Public TE_IdentNave(0 To 0) As String
    '' tabla de sector
    Public TS_ID(0 To 0) As Integer
    Public TS_DESCRIP(0 To 0) As String
    '' Tabla forma de pago
    Public FP_IDFPAGO(0 To 0) As Integer
    Public FP_DESCRIP(0 To 0) As String
    'forma de entrega
    Public FE_CODIGO(0 To 0) As Integer
    Public FE_DESCRIP(0 To 0) As String
    Public FE_COSTO_FLETE(0 To 0) As Double
    ' Insumos
    Public IN_IDInsumo(0 To 0) As Integer
    Public IN_Descrip(0 To 0) As String
    Public IN_PCosto(0 To 0) As Double
    Public IN_Unidad(0 To 0) As Integer
    Public IN_DesUnidad(0 To 0) As String
    Public gIdProd As Integer
    Public gPeriodoContable As Integer
    Public gProrroga As String
    Public gClaveBloqueo As String
    ' Temporada
    Public gTempoPRI_Ini As String
    Public gTempoPRI_Fin As String
    Public gtempoOTO_Ini As String
    Public gTempoOTO_Fin As String
    Public gTempoINV_Ini As String
    Public gTempoINV_Fin As String
    Public gTempoVER_Ini1 As String
    Public gTempoVER_Fin1 As String
    Public gTempoVER_Ini2 As String
    Public gTempoVER_Fin2 As String
    Public Sub open()

        Dim connectionString As String = gSOURCE

        connection = New SqlConnection(connectionString)

        connection.Open()

    End Sub

    Public Function FormatoRut(sRut As String) As String
        'Rut debe ser largo 12 y tipo String
        Return Format(Val(Mid(sRut, 1, 11)), "###,###,###") & "-" & Mid(sRut, 12, 1)
    End Function
    Public Function RetornaTipoDoc(valorTipoDoc As Integer) As String
        Dim stipodoc As String = ""
        Select Case valorTipoDoc
            Case 1
                stipodoc = "FE"
            Case 2
                stipodoc = "BL"
            Case 3
                stipodoc = "NC"
            Case 4
                stipodoc = "BE"
        End Select
        Return stipodoc
    End Function
    Private Function GetConnectionString() As String
        ' Define String de conexión a la Base de Datos
        'Dim dbName As String

        'dbName = "CYN"

        'Data Source=myServerAddress;Initial Catalog=myDataBase;User Id=myUsername;Password=myPassword;
        Return gSOURCE

    End Function
    Public Sub AbreConexionDB()

        strConexion = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & gSOURCE
        Try
            'Abrimos la conexión
            'cn = New OleDbConnection(strConexion)
            'cn.Open()
        Catch ex As Exception
            MessageBox.Show("ERROR AL INTENTAR ABRIR LA CONEXIÓN CON LA BASE DE DATOS:" & vbCrLf & ex.Message)
        End Try

    End Sub
    Public Sub LecturaINI()
        Dim r As New Globalization.CultureInfo("es-ES")
        r.NumberFormat.CurrencyDecimalSeparator = "."
        r.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture = r
        REM default

        gSOURCE = My.Settings.ConexionVivero
        'gSOURCE = My.Settings.DBLocal
        gDataEmp = My.Settings.DatEmpIDM
        gDataEmpFono = My.Settings.DatEmpIDMFono

        open()
        command = connection.CreateCommand
        command.CommandText = "SP_CONSULTA_SYS_INI"
        datatbl = command.ExecuteReader()
        If datatbl.HasRows Then
            While datatbl.Read
                If datatbl(0) = 1 Then
                    gGTOGRAL = Val(datatbl(2))
                End If
                If datatbl(0) = 7 Then
                    GIVA = Val(datatbl(2))
                    gFactorIVA = 1 + (GIVA / 100)
                End If
                If datatbl(0) = 17 Then
                    gPeriodoContable = datatbl("Valor_Param")
                End If
                If datatbl(1) = "PRORROGA" Then
                    gProrroga = datatbl(2)
                End If
                If datatbl(1) = "PWDBLOQUEO" Then
                    gClaveBloqueo = datatbl(2)
                End If
                If datatbl(1) = "TEMPO_PRI" Then
                    gTempoPRI_Ini = datatbl(3)
                    gTempoPRI_Fin = datatbl(4)
                End If
                If datatbl(1) = "TEMPO_OTO" Then
                    gtempoOTO_Ini = datatbl(3)
                    gTempoOTO_Fin = datatbl(4)
                End If
                If datatbl(1) = "TEMPO_INV" Then
                    gTempoINV_Ini = datatbl(3)
                    gTempoINV_Fin = datatbl(4)
                End If
                If datatbl(1) = "TEMPO_VER" Then
                    If datatbl(2) = 1 Then
                        gTempoVER_Ini1 = datatbl(3)
                        gTempoVER_Fin1 = datatbl(4)
                    End If
                    If datatbl(2) = 2 Then
                        gTempoVER_Ini2 = datatbl(3)
                        gTempoVER_Fin2 = datatbl(4)
                    End If

                End If
            End While
        End If
        close_conexion()

        'Call SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY")

    End Sub

    Public Function EjecutaSQL(ByRef SQL As String, ByVal TABLA As String) As Boolean

        'bOK = True

        ''ds = New Data.DataSet
        ''da = New OleDbDataAdapter(SQL, cn)
        ''Cargamos el DataSet 
        'Try


        '    If (LSet(SQL, 6) = "INSERT" OrElse LSet(SQL, 6) = "DELETE" OrElse LSet(SQL, 6) = "UPDATE") Then
        '        '                ds.Tables(TABLA).DataSet
        '        'da.Update(ds.Tables(TABLA).DataSet, TABLA)
        '        'da.Update(ds.Tables.Item(

        '        'da.Update(ds.Tables().get_Item("tableName"));
        '        'da.Fill(ds.Tables.Add)
        '    Else
        '        'da.Fill(ds, TABLA)
        '        'If ds.Tables(TABLA).Rows.Count <= 0 Then
        '        'bOK = False
        '        'End If

        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("ERROR AL CARGAR EL SET DE DATOS:" & vbCrLf & ex.Message)
        '    bOK = False
        'End Try

        'EjecutaSQL = bOK

    End Function
    Public Function IniGet(ByVal sFileName As String, ByVal sSection As String, ByVal sKeyName As String, Optional ByVal sDefault As String = "") As String
        '--------------------------------------------------------------------------
        ' Devuelve el valor de una clave de un fichero INI
        ' Los parámetros son:
        '   sFileName   El fichero INI
        '   sSection    La sección de la que se quiere leer
        '   sKeyName    Clave
        '   sDefault    Valor opcional que devolverá si no se encuentra la clave
        '--------------------------------------------------------------------------
        Dim ret As Integer
        Dim sRetVal As String
        sRetVal = New String(Chr(0), 255)
        ret = GetPrivateProfileString(sSection, sKeyName, sDefault, sRetVal, Len(sRetVal), sFileName)
        If ret = 0 Then
            Return sDefault
        Else
            Return LSet(sRetVal, ret)
        End If
    End Function
    Public Sub close_conexion()
        connection.Close()
        connection.Dispose()
    End Sub
    Public Function Reemplaza_Comas(ByRef sValor As String) As String
        Dim NewValor As String

        NewValor = Replace(sValor, ",", ".")

        Return NewValor
    End Function
    Public Function Reemplaza_Puntos(ByVal sValor As String) As String
        Dim NewValor As String

        NewValor = Replace(sValor, ".", ",")
        Return NewValor
    End Function
    Public Function Reemplaza_Guiones(ByVal svalor As String) As String
        Dim newvalor As String

        newvalor = Replace(svalor, "-", "")
        newvalor = Replace(newvalor, "/", "")
        Return newvalor
    End Function
    Public Function Extrae_comas(ByVal sMontoconComas As String) As String
        Dim sValorRetorno As String

        sValorRetorno = Replace(sMontoconComas, ",", "")
        sValorRetorno = Replace(sValorRetorno, ".", "")
        Return sValorRetorno
    End Function

    Public Sub Carga_Full_Zona(ByVal cmb As ComboBox)

        Dim i As Integer
        Dim sString As String
        open()
        sSsql = "SP_CONSULTA_FULL_ZONA"

        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        cmb.Items.Clear()

        If datatbl.HasRows Then
            i = 0
            While datatbl.Read

                sString = datatbl(1)
                cmb.Items.Add(sString)
                i += 1
            End While

        End If
        close_conexion()
    End Sub
    Public Sub CargaSectorFiltro(ByVal cmb As ComboBox, ByVal sZona As String)
        Dim i As Integer
        Dim sString As String
        open()
        sSsql = "SP_CONSULTASectorFiltro "
        sSsql += "'" & sZona & "'"

        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        cmb.Items.Clear()

        If datatbl.HasRows Then
            i = 0
            While datatbl.Read
                sString = datatbl(1)
                cmb.Items.Add(sString)
                i += 1
            End While

        End If

        close_conexion()

    End Sub
    Public Sub Carga_Sector(ByVal cmb As ComboBox)

        Dim i As Integer
        Dim sString As String
        open()
        sSsql = "SP_CONSULTA_FULL_SECTOR"

        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        ReDim TS_ID(0 To 0)
        ReDim TS_DESCRIP(0 To 0)

        cmb.Items.Clear()

        If datatbl.HasRows Then
            i = 0
            While datatbl.Read
                ReDim Preserve TS_ID(0 To i)
                ReDim Preserve TS_DESCRIP(0 To i)

                TS_ID(i) = datatbl(0)
                TS_DESCRIP(i) = datatbl(1)

                sString = datatbl(1)
                cmb.Items.Add(sString)
                i += 1
            End While

        End If
        datatbl.Close()
        close_conexion()
    End Sub
    Public Sub Carga_Cuenta_Imputable(ByVal cmb As ComboBox)

        Dim i As Integer
        Dim sString As String
        open()
        sSsql = "SP_CONSULTA_CONTA_CtasImputables"

        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        cmb.Items.Clear()

        If datatbl.HasRows Then
            i = 0
            While datatbl.Read
                sString = datatbl(1)
                cmb.Items.Add(sString)
                i += 1
            End While

        End If
        close_conexion()

    End Sub
    Public Sub Carga_Cuenta_Diaria(ByVal cmb As ComboBox)

        Dim i As Integer
        Dim sString As String
        open()
        sSsql = "SP_CONSULTA_CONTA_CtasDiarias"

        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        cmb.Items.Clear()

        If datatbl.HasRows Then
            i = 0
            While datatbl.Read
                sString = datatbl(1)
                cmb.Items.Add(sString)
                i += 1
            End While

        End If
        close_conexion()

    End Sub
    Public Sub Carga_Centro_Costo(ByVal cmb As ComboBox)
        Dim i As Integer
        Dim sString As String
        open()
        sSsql = "SP_CONSULTA_CONTA_FULLCCosto"

        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        cmb.Items.Clear()

        If datatbl.HasRows Then
            i = 0
            While datatbl.Read
                sString = datatbl(2)
                cmb.Items.Add(sString)
                i += 1
            End While

        End If
        close_conexion()
    End Sub
    Public Sub Carga_Familia_Prod(ByVal cmb As ComboBox)
        ' Carga vector de Productos
        Dim i As Integer
        Dim sString As String
        open()
        sSsql = "SP_CONSULTA_FULL_FAMILIA_PRODUCTO"

        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        ReDim aID_FAMILIA_PROD(0 To 0)
        ReDim aPrecio_Costo_Neto_Familia(0 To 0)
        ReDim aMargen_Porc_Familia(0 To 0)
        ReDim aPrecio_Neto_Familia(0 To 0)
        ReDim aDias_Fabricacion(0 To 0)

        cmb.Items.Clear()

        If datatbl.HasRows Then
            i = 0
            While datatbl.Read
                ReDim Preserve aID_FAMILIA_PROD(0 To i)
                ReDim Preserve aPrecio_Costo_Neto_Familia(0 To i)
                ReDim Preserve aMargen_Porc_Familia(0 To i)
                ReDim Preserve aPrecio_Neto_Familia(0 To i)
                ReDim Preserve aDias_Fabricacion(0 To i)
                aID_FAMILIA_PROD(i) = datatbl(0)
                aPrecio_Costo_Neto_Familia(i) = datatbl(2)
                aMargen_Porc_Familia(i) = datatbl(3)
                aPrecio_Neto_Familia(i) = datatbl(4)
                If IsDBNull(datatbl(5)) Then
                    aDias_Fabricacion(i) = 0
                Else
                    aDias_Fabricacion(i) = datatbl(5)
                End If

                'aDias_Fabricacion(i) = datatbl(5)
                sString = datatbl(1)
                cmb.Items.Add(sString)
                i += 1
            End While

        End If
        datatbl.Close()
        close_conexion()
    End Sub
    Public Sub Carga_Variedad(ByVal cmb As ComboBox)
        ' Carga vector de Variedades
        Dim i As Integer
        Dim sString As String
        open()
        sSsql = "SP_CONSULTA_FULL_VARIEDAD"
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then
            i = 0
            While datatbl.Read
                ReDim Preserve aID_VARIEDAD(0 To i)
                aID_VARIEDAD(i) = datatbl(0)
                sString = datatbl(1)
                cmb.Items.Add(sString)
                i += 1
            End While

        End If

        close_conexion()
    End Sub

    Public Sub Carga_Lote_Activo(cmb As ComboBox)
        sSsql = "SP_CONSULTA_Full_LoteActivo"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then

            While datatbl.Read

                cmb.Items.Add(datatbl(0))

            End While

        End If

        close_conexion()
    End Sub
    Public Sub Carga_Nave(cmb As ComboBox)
        sSsql = "SP_CONSULTA_Full_Nave"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then

            While datatbl.Read

                cmb.Items.Add(datatbl(1))

            End While

        End If

        close_conexion()
    End Sub

    Public Sub Carga_Evento(ByVal cmb As ComboBox, sFiltro As String)
        ' Carga vector de Eventos
        Dim i As Integer
        Dim sString As String
        open()

        If sFiltro = "" Then
            sSsql = "SP_CONSULTA_TBL_EVENTOS"
        Else
            sSsql = "SP_CONSULTA_TBL_EVENTOS " & "'" & sFiltro & "'"
        End If

        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        cmb.Items.Clear()
        If datatbl.HasRows Then
            i = 0
            While datatbl.Read
                ReDim Preserve TE_ID(0 To i)
                ReDim Preserve TE_Camara(0 To i)
                ReDim Preserve TE_ConteoPlantas(0 To i)
                ReDim Preserve TE_Insumo(0 To i)
                ReDim Preserve TE_Lote(0 To i)
                ReDim Preserve TE_IdentNave(0 To i)
                TE_ID(i) = datatbl(0)
                TE_Camara(i) = datatbl(5)
                TE_ConteoPlantas(i) = datatbl(6)
                TE_Insumo(i) = datatbl(3)
                TE_Lote(i) = datatbl(4)
                TE_IdentNave(i) = If(IsDBNull(datatbl(7)), "", datatbl(7))
                sString = datatbl(1)
                cmb.Items.Add(sString)
                i += 1
            End While
        End If
        datatbl.Close()
        close_conexion()
    End Sub
    Public Sub Carga_Variedad_Filtro(ByVal cmb As ComboBox, ByVal sFamilia As String)
        ' Carga vector de Variedades
        Dim i As Integer
        Dim sString As String
        open()
        sSsql = "SP_CONSULTA_FULL_VARIEDAD_FILTRADO "
        sSsql += "'" & sFamilia & "'"
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        cmb.Items.Clear()
        If datatbl.HasRows Then
            i = 0
            While datatbl.Read
                ReDim Preserve aID_VARIEDAD(0 To i)
                aID_VARIEDAD(i) = datatbl(0)
                sString = datatbl(1)
                cmb.Items.Add(sString)
                i += 1
            End While

        End If
        datatbl.Close()
        close_conexion()
    End Sub
    Public Sub Buscar_Cliente(ByVal cmb As ComboBox, ByVal sBusqueda As String)
        Dim i As Integer
        'Dim x As Integer
        Dim sNombre As String
        cmb.Items.Clear()
        open()
        sSsql = "SP_CONSULTA_CLIENTE_NOMBRE '" & Trim(sBusqueda) & "',2"
        '0 Rut
        '1 Nombre
        '2 Apellido
        '3 IDCliente
        command.Dispose()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then
            i = 0
            While datatbl.Read
                ReDim Preserve zRut(0 To i)
                ReDim Preserve zIDCliente(0 To i)
                zRut(i) = datatbl(0)
                sNombre = Trim(datatbl(1)) & " " & datatbl(2)
                zIDCliente(i) = datatbl(3)
                cmb.Items.Add(sNombre)
                i += 1
            End While
        Else
            MessageBox.Show("NO EXISTEN CLIENTES CON DATOS INGRESADOS")
        End If

        cmb.Focus()
        datatbl.Close()
        close_conexion()
    End Sub

    Public Sub Carga_Personal(cmb As ComboBox)

        sSsql = "SP_CONSULTA_FULL_Personal"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then
            While datatbl.Read
                cmb.Items.Add(datatbl(0))
            End While
        End If

        close_conexion()
    End Sub

    Public Sub Carga_lista_Vendedor(ByVal cmb As ComboBox)
        Dim i As Integer
        Dim sLista As String
        sSsql = "SP_CONSULTA_FULL_VENDEDOR"

        '0 IdVendedor
        '1 MAX_DSCTO,
        '2 CCOSTO,
        '3 NOMBRE
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then

            While datatbl.Read
                ReDim Preserve ID_Vendedor(0 To i)
                ReDim Preserve Nombre_Vendedor(0 To i)

                ID_Vendedor(i) = datatbl(0).ToString
                Nombre_Vendedor(i) = datatbl(3).ToString
                sLista = Nombre_Vendedor(i)
                cmb.Items.Add(sLista)
                i += 1
            End While

        End If

        close_conexion()
    End Sub
    Public Sub Carga_Full_Guias(ByVal cmb As ComboBox)
        Dim i As Integer
        Dim sLista As String
        sSsql = "SP_CONSULTA_TODAS_GUIAS"

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then

            While datatbl.Read
                sLista = datatbl(0)
                cmb.Items.Add(sLista)
                i += 1

            End While

        End If
        datatbl.Close()
        close_conexion()
    End Sub
    Public Sub Carga_Proveedores(ByVal cmb As ComboBox)
        sSsql = "SP_CONSULTA_FULL_PROVEEDOR"
        cmb.Items.Clear()
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then

            While datatbl.Read
                cmb.Items.Add(datatbl(0))
            End While

        End If
        datatbl.Close()
        close_conexion()
    End Sub

    Public Sub Carga_Tipo_Bandeja(ByVal cmb As ComboBox)
        Dim i As Integer
        Dim slista As String
        sSsql = "SP_CONSULTA_FULL_TIPOBANDEJA"
        '0 IdTipoBandeja
        '1 DESCRIPCION
        '2 Cantidad

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then

            While datatbl.Read
                ReDim Preserve TB_CODIGO(0 To i)
                ReDim Preserve TB_DESCRIP(0 To i)
                ReDim Preserve TB_CANTIDAD(0 To i)

                TB_CODIGO(i) = datatbl(0)
                TB_DESCRIP(i) = datatbl(1).ToString
                TB_CANTIDAD(i) = datatbl(2)
                slista = TB_DESCRIP(i)
                cmb.Items.Add(slista)
                i += 1
            End While

        End If
        datatbl.Close()
        close_conexion()
    End Sub

    Public Sub CargaVehiculo(ByVal cmb As ComboBox)

        sSsql = "SP_ConsultaVehiculo"

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then

            While datatbl.Read

                cmb.Items.Add(datatbl(0))

            End While

        End If

        close_conexion()
    End Sub

    Public Sub Carga_CTL_Lote_ComboBox(cmb As ComboBox, sTipoTabla As String)
        Dim i As Integer
        sSsql = "SP_ReporteParametroControlLote "
        sSsql += "'" & sTipoTabla & "'"
        '0 IdTipoBandeja
        '1 DESCRIPCION
        '2 Cantidad

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then
            cmb.Items.Add("")
            While datatbl.Read
                cmb.Items.Add(datatbl(3))
                i += 1
            End While

        End If
        close_conexion()
    End Sub


    Public Sub Carga_CTL_Lote(ByVal cmb As DataGridViewComboBoxColumn, ByVal sTipoTabla As String)
        Dim i As Integer
        sSsql = "SP_ReporteParametroControlLote "
        sSsql += "'" & sTipoTabla & "'"
        '0 IdTipoBandeja
        '1 DESCRIPCION
        '2 Cantidad

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then
            cmb.Items.Add("")
            While datatbl.Read
                cmb.Items.Add(datatbl(3))
                i += 1
            End While

        End If
        close_conexion()
    End Sub

    Public Sub Carga_Valor_Semilla(ByVal cmb_familia As ComboBox, ByVal cmb_variedad As ComboBox)

        If cmb_familia.SelectedIndex > -1 AndAlso cmb_variedad.SelectedIndex > -1 Then
            sSsql = "SP_Consulta_StockSemilla "
            sSsql += "'" & cmb_familia.SelectedItem & "',"
            sSsql += "'" & cmb_variedad.SelectedItem & "'"
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                datatbl.Read()
                gPrecioSemilla = datatbl(2)
                'gDetalleVariedad = datatbl(9)
                gStockDispo = datatbl(3)
                gFechaActualizacion = datatbl(4)
                gStockActual = datatbl(5)
                gStockReservado = datatbl(6)
                'If gStockDispo = 0 Then
                '    MsgBox("STOCK DE VARIEDAD NO DISPONIBLE", MsgBoxStyle.Critical)
                'End If
            Else
                'MsgBox("Recuerde Definir Precio de Costo Semilla para esta variedad.")
                gPrecioSemilla = 0
                gDetalleVariedad = ""
                gStockDispo = 0
                gStockActual = 0
                gStockReservado = 0
            End If
            close_conexion()
            'calcula_precio()
        End If


    End Sub
    Public Sub Carga_Valor_Semilla_Id(ByVal cmb_familia As ComboBox, ByVal cmb_variedad As ComboBox)

        If cmb_familia.SelectedIndex > -1 AndAlso cmb_variedad.SelectedIndex > -1 Then
            sSsql = "SP_Consulta_StockSemilla_Id "
            sSsql += "'" & cmb_familia.SelectedValue.ToString() & "',"
            sSsql += "'" & cmb_variedad.SelectedValue.ToString() & "'"
            open()
            command = connection.CreateCommand()
            command.CommandText = sSsql
            datatbl = command.ExecuteReader()
            If datatbl.HasRows Then
                datatbl.Read()
                gPrecioSemilla = datatbl(2)
                'gDetalleVariedad = datatbl(9)
                gStockDispo = datatbl(3)
                gFechaActualizacion = datatbl(4)
                gStockActual = datatbl(5)
                gStockReservado = datatbl(6)
                'If gStockDispo = 0 Then
                '    MsgBox("STOCK DE VARIEDAD NO DISPONIBLE", MsgBoxStyle.Critical)
                'End If
            Else
                'MsgBox("Recuerde Definir Precio de Costo Semilla para esta variedad.")
                gPrecioSemilla = 0
                gDetalleVariedad = ""
                gStockDispo = 0
                gStockActual = 0
                gStockReservado = 0
            End If
            close_conexion()
            'calcula_precio()
        End If


    End Sub
    Public Sub Carga_Tipo_Unidad(ByVal cmb_unidad As ComboBox)
        Dim i As Integer
        Dim slista As String
        sSsql = "SP_CONSULTA_FULL_UNIDADES"

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then

            While datatbl.Read
                ReDim Preserve TU_ID(0 To i)
                ReDim Preserve TU_DESCRIP(0 To i)

                TU_ID(i) = datatbl(0)
                TU_DESCRIP(i) = datatbl(1).ToString
                slista = TU_DESCRIP(i)
                cmb_unidad.Items.Add(slista)
                i += 1
            End While

        End If
        datatbl.Close()
        close_conexion()
    End Sub
    Public Sub Carga_Insumo_Productos(ByVal cmb As ComboBox)
        Dim i As Integer
        Dim slista As String
        sSsql = "SP_CONSULTA_INSUMOS_Productos"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then

            While datatbl.Read
                ReDim Preserve TI_ID(0 To i)
                ReDim Preserve TI_DESCRIP(0 To i)
                ReDim Preserve TI_COSTO(0 To i)
                ReDim Preserve TI_IDUnidad(0 To i)
                ReDim Preserve TI_DESCUnidad(0 To i)

                TI_ID(i) = datatbl(0)
                TI_DESCRIP(i) = datatbl(1).ToString
                TI_COSTO(i) = IsDBNull(datatbl(2))
                TI_IDUnidad(i) = datatbl(3)
                TI_DESCUnidad(i) = datatbl(4)
                slista = TI_DESCRIP(i)
                cmb.Items.Add(slista)
                i += 1
            End While

        End If
        datatbl.Close()
        close_conexion()
    End Sub
    Public Sub Carga_Combo_Insumos(ByVal cmb_insumo As ComboBox)
        Dim i As Integer
        Dim slista As String
        sSsql = "SP_CONSULTA_FULL_INSUMOS"

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then

            While datatbl.Read
                ReDim Preserve TI_ID(0 To i)
                ReDim Preserve TI_DESCRIP(0 To i)
                ReDim Preserve TI_COSTO(0 To i)
                ReDim Preserve TI_IDUnidad(0 To i)
                ReDim Preserve TI_DESCUnidad(0 To i)

                TI_ID(i) = datatbl(0)
                TI_DESCRIP(i) = datatbl(1).ToString
                TI_COSTO(i) = IsDBNull(datatbl(2))
                TI_IDUnidad(i) = datatbl(3)
                TI_DESCUnidad(i) = datatbl(4)
                slista = TI_DESCRIP(i)
                cmb_insumo.Items.Add(slista)
                i += 1
            End While

        End If
        datatbl.Close()
        close_conexion()
    End Sub
    Public Function Calculo_Bandejas(ByVal dPlantas As Double, ByVal iTipoBandeja As Integer) As Integer
        Dim dParte1 As Double
        Dim iCantidad_Bandejas As Integer

        dParte1 = dPlantas / iTipoBandeja
        If Int(dParte1) = dParte1 Then
            iCantidad_Bandejas = dParte1
        Else
            iCantidad_Bandejas = Int(dParte1) + 1
        End If
        Return iCantidad_Bandejas
    End Function


    Public Sub Carga_Num_Formulas(ByVal combo_formulas As ComboBox)
        Dim i As Integer
        Dim slista As String
        sSsql = "SP_CONSULTA_FORMULAS_UNICAS"

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then

            While datatbl.Read
                ReDim Preserve FO_NumFormula(0 To i)
                ReDim Preserve FO_TipoBandeja(0 To i)
                ReDim Preserve FO_Celdas(0 To i)
                ReDim Preserve FO_IDTipoBandeja(0 To i)

                FO_NumFormula(i) = datatbl(0)
                FO_TipoBandeja(i) = datatbl(1).ToString
                FO_Celdas(i) = datatbl(2)
                FO_IDTipoBandeja(i) = datatbl(3)
                slista = FO_NumFormula(i)
                combo_formulas.Items.Add(slista)
                i += 1
            End While

        End If
        datatbl.Close()
        close_conexion()
    End Sub

    Public Sub Carga_FormaPago(ByVal combo_forma_pago As ComboBox, ByVal iTipo As Integer)
        Dim i As Integer
        Dim vdato As String
        sSsql = "SP_CONSULTA_FORMAPAGO_Tipo "
        sSsql += iTipo.ToString

        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then
            i = 0
            While datatbl.Read
                ReDim Preserve FP_IDFPAGO(0 To i)
                ReDim Preserve FP_DESCRIP(0 To i)
                vdato = datatbl(1)
                combo_forma_pago.Items.Add(vdato)
                FP_IDFPAGO(i) = datatbl(0)
                FP_DESCRIP(i) = datatbl(1).ToString
                i += 1
            End While

        End If
        close_conexion()
    End Sub
    Public Sub Carga_Forma_Entrega(ByVal cmb As ComboBox)
        Dim i As Integer
        Dim slista As String
        sSsql = "SP_CONSULTA_FULL_FORMAENTREGA"
        '0 IdFormaEntrega
        '1 DESCRIPCION
        '2 COSTO_FLETE
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        cmb.Items.Clear()
        If datatbl.HasRows Then

            While datatbl.Read
                ReDim Preserve FE_CODIGO(0 To i)
                ReDim Preserve FE_DESCRIP(0 To i)
                ReDim Preserve FE_COSTO_FLETE(0 To i)

                FE_CODIGO(i) = datatbl(0)
                FE_DESCRIP(i) = datatbl(1).ToString
                FE_COSTO_FLETE(i) = datatbl(2)
                slista = FE_DESCRIP(i)
                cmb.Items.Add(slista)
                i += 1
            End While

        End If
        datatbl.Close()
        close_conexion()
    End Sub


    Public Sub Carga_Full_Bancos(ByVal cmb As ComboBox)
        sSsql = "SP_CONSULTA_FULL_Bancos"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        cmb.Items.Clear()
        If datatbl.HasRows Then
            While datatbl.Read
                cmb.Items.Add(datatbl(1))
            End While
        End If
        datatbl.Close()
        close_conexion()
    End Sub

    Public Sub Carga_PlanCuentas(ByVal cmb As ComboBox)
        sSsql = "SP_CONSULTA_CONTA_PlanCuentas"
        open()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()
        cmb.Items.Clear()
        If datatbl.HasRows Then
            While datatbl.Read
                cmb.Items.Add(datatbl(1))
            End While
        End If
        datatbl.Close()
        close_conexion()
    End Sub


    Public Sub Carga_Lista_Pedidos(ByVal cmb As ComboBox)
        cmb.Items.Clear()
        open()
        sSsql = "SP_CONSULTA_FULL_PEDIDOS"
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then

            While datatbl.Read
                cmb.Items.Add(datatbl(0))
            End While

        End If
        datatbl.Close()
        close_conexion()
    End Sub
    Public Sub Busca_Proveedor(ByVal cmb As ComboBox, ByVal txt_proveedor As String)

        Dim i As Integer
        'Dim x As Integer
        Dim sNombre As String
        cmb.Items.Clear()
        'cmb_PROVEEDOR.Items.Clear()

        sSsql = "SP_CONSULTA_PROVEEDOR_NOMBRE '" & Trim(txt_proveedor) & "',2"
        open()
        command.Dispose()
        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then
            i = 0
            While datatbl.Read
                ReDim Preserve zRut(0 To i)
                zRut(i) = datatbl(0)
                sNombre = datatbl(1)
                cmb.Items.Add(sNombre)
                'cmb_PROVEEDOR.Items.Add(sNombre)
                i += 1
            End While
            cmb.Focus()
            'cmb_PROVEEDOR.Focus()
        Else
            MessageBox.Show("NO EXISTEN PROVEEDORES CON DATOS INGRESADOS")
        End If
        close_conexion()

    End Sub
    Public Sub Carga_Insumos_Compras(ByVal combo As ComboBox)
        open()

        sSsql = "SP_CONSULTA_INSUMOS_Compras"

        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then

            While datatbl.Read
                combo.Items.Add(datatbl(1))
            End While

        End If
        close_conexion()
    End Sub
    Public Sub Carga_Full_Insumos(ByVal combo As ComboBox)
        'Dim i As Integer
        'Dim vdato As String
        open()

        sSsql = "SP_CONSULTA_FULL_INSUMOS"

        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then

            While datatbl.Read
                'ReDim Preserve IN_IDInsumo(0 To i)
                'ReDim Preserve IN_Descrip(0 To i)
                'ReDim Preserve IN_PCosto(0 To i)
                'ReDim Preserve IN_Unidad(0 To i)
                'ReDim Preserve IN_DesUnidad(0 To i)
                'IN_IDInsumo(i) = datatbl(0)
                'IN_Descrip(i) = datatbl(1)
                'IN_PCosto(i) = datatbl(2)
                'IN_Unidad(i) = datatbl(3)
                'IN_DesUnidad(i) = datatbl(4)

                'vdato = IN_Descrip(i) + " " + IN_DesUnidad(i) + " " + Format(IN_PCosto(i), "###0.00")
                'lbox.Items.Add(vdato)

                combo.Items.Add(datatbl(1))



                'i += 1
            End While

        End If
        close_conexion()
    End Sub
    Public Sub Carga_Insumos_Ventas(ByVal combo As ComboBox)
        open()

        sSsql = "SP_CONSULTA_INSUMOS_Ventas"

        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then

            While datatbl.Read
                combo.Items.Add(datatbl(1))
            End While

        End If
        close_conexion()
    End Sub

    Public Sub Carga_Full_Insumos_Directos(ByVal combo As ComboBox)
        'Dim i As Integer
        'Dim vdato As String
        open()

        sSsql = "SP_CONSULTA_INSUMOS_Directos"

        command = connection.CreateCommand()
        command.CommandText = sSsql
        datatbl = command.ExecuteReader()

        If datatbl.HasRows Then

            While datatbl.Read
                combo.Items.Add(datatbl(1))
            End While

        End If
        close_conexion()
    End Sub
    Public Sub Abre_Excel(ByVal xls_filename As String)
        'Dim ef As ExcelFile = New ExcelFile

        ' Dim sheet As ExcelWorksheet
        'Dim row As ExcelRow
        'Dim col As ExcelColumn
        'Dim cell As ExcelCell

        ' Loads a spreadsheet from a file with the specified path 
        'Dim ef = ExcelFile.Load(xls_filename)



        'Using stream As New FileStream(xls_filename, FileMode.Open)
        ' Loads a spreadsheet from the specified stream
        'ef = ExcelFile.Load(Stream, LoadOptions.CsvDefault)
        'End Using


        '' Lectura Archivo de Zarpe


        'ef.LoadCsv(xls_filename, CsvType.SemicolonDelimited)

        'TryToDisplayGeneratedFile(xls_filename)

        'ef = Nothing
        'sheet = Nothing
        'row = Nothing
        'col = Nothing
        'cell = Nothing
    End Sub

    Public Sub TryToDisplayGeneratedFile(ByVal fileName As String)
        Try
            Process.Start(fileName)
        Catch exception1 As Exception
            Console.WriteLine((fileName & " created in application folder."))
        End Try
    End Sub
    Public Function MestoTexto(Mes As Integer)
        Dim sMes As String = ""
        Select Case Mes
            Case 1
                sMes = "Ene"
            Case 2
                sMes = "Feb"
            Case 3
                sMes = "Mar"
            Case 4
                sMes = "Abr"
            Case 5
                sMes = "May"
            Case 6
                sMes = "Jun"
            Case 7
                sMes = "Jul"
            Case 8
                sMes = "Ago"
            Case 9
                sMes = "Sep"
            Case 10
                sMes = "Oct"
            Case 11
                sMes = "Nov"
            Case 12
                sMes = "Dic"
        End Select

        Return sMes

    End Function
End Module
