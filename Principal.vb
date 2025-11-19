Public Class Principal
    Private Sub IngresarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarToolStripMenuItem.Click
        'Ingreso_de_Ventas.Visible = True
        frmtablavirtual.Visible = True
    End Sub
    Private Sub ConsultarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem1.Click
        Consulta_Cliente.Visible = True
    End Sub

    Private Sub Principal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub Principal_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        End
    End Sub

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LecturaINI()
        'carga variables en pantalla principal
        Me.txt_User.Text = gNomUsuario
        Label4.Text = "Sistema de Gestión Vivero - V. 2024"
        opcionAutorizaPedido.Enabled = False
        Select Case gIdPerfil
            Case 1 'Administrador
                opcionAutorizaPedido.Enabled = True
                opcionParametros.Enabled = True
            Case 2

            Case Else

        End Select
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub IngresarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarToolStripMenuItem1.Click
        facturaCompra.Visible = True
    End Sub

    Private Sub CrearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearToolStripMenuItem.Click
        Consulta_Proveedor.Visible = True
    End Sub

    Private Sub ModificarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Consulta_Boleta_Pendiente.Visible = True
    End Sub

    Private Sub AjusteManualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Ajuste_INV.Visible = True
    End Sub
    Private Sub EliminarToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem2.Click
        Prox_Vcto.Show()
    End Sub

    Private Sub RegistroDePuntajeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Pedidos.Visible = True
    End Sub

    Private Sub PuntajePorVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Reporte_Cliente_01.Show()
    End Sub
    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        win_Ingredientes.Visible = True
    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cambio_Estado.Visible = True
    End Sub
    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Costo_Semilla.Visible = True
    End Sub

    Private Sub SemillasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Costo_Semilla.Visible = True
    End Sub
    Private Sub HechuraPlantasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Costo_Produccion.Visible = True
    End Sub
    Private Sub CrearGUIAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Guia.Visible = True
    End Sub
    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DepositoDoc.Visible = True
    End Sub

    Private Sub EntradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradasToolStripMenuItem.Click
        Analisis_Cuenta.Visible = True
    End Sub

    Private Sub ArqueoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Consulta_Caja.Visible = True
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Precios.Visible = True
    End Sub

    Private Sub FormulaciónDePreciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Formula.Visible = True
    End Sub

    Private Sub ControlDePreciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Control_Precios.Visible = True
    End Sub

    Private Sub ToolStripMenuItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Semillas.Visible = True
    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        Variedad.Visible = True
    End Sub

    Private Sub UnidadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnidadesToolStripMenuItem.Click
        Unidades.Visible = True
    End Sub

    Private Sub TipoDeBandejaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoDeBandejaToolStripMenuItem.Click
        TipoBandeja.Visible = True
    End Sub

    Private Sub InsumosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsumosToolStripMenuItem.Click
        Insumos.Visible = True
    End Sub

    Private Sub TablaDeConversiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TablaDeConversiónToolStripMenuItem.Click
        Conversion.Visible = True
    End Sub

    Private Sub TrabajoPorLotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cambio_Estado.Visible = True
    End Sub

    Private Sub BitácoraLoteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Bitacora.Visible = True
    End Sub


    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
        Mantencion_Eventos.Visible = True

    End Sub

    Private Sub GuíaDeEntregaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Guia.Visible = True
    End Sub

    Private Sub ConsultaPendientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Actividades_Pendientes.Visible = True
    End Sub

    Private Sub ConsultarToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Consulta_Precios.Visible = True
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click
        Listado_Proveedor.Visible = True
    End Sub



    Private Sub SectoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectoresToolStripMenuItem.Click
        Sector.Visible = True
    End Sub

    Private Sub DevoluciónBandejasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Devolucion_Bandejas.Visible = True
    End Sub

    Private Sub ToolStripMenuItem7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Impresion_Guia.Visible = True
    End Sub

    Private Sub AbonoDeudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Abono_Deuda.Visible = True
    End Sub

    Private Sub ConsultaConteosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Consulta_Conteo.Visible = True
    End Sub

    Private Sub ConsultaPresupuestoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Consulta_Presupuesto.Visible = True
    End Sub

    Private Sub SalirToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Shell("calc", AppWinStyle.NormalFocus)
    End Sub

    Private Sub BlockNotasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlockNotasToolStripMenuItem.Click
        Shell("Notepad", AppWinStyle.NormalFocus)
    End Sub

    Private Sub LibroVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LibroVentasToolStripMenuItem.Click
        Libro_Ventas.Visible = True
    End Sub

    Private Sub CartolaClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CartolaClientesToolStripMenuItem.Click
        Cartola_Cliente.Visible = True
    End Sub

    Private Sub RankingDeVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RankingDeVentasToolStripMenuItem.Click
        Ranking.Visible = True
    End Sub

    Private Sub ConsultaGuíasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Consulta_Guias.Visible = True
    End Sub

    Private Sub ToolStripMenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cotizacion.Visible = True
    End Sub

    Private Sub ListadoDeDeudoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeDeudoresToolStripMenuItem.Click
        Consulta_Deudores.Visible = True
    End Sub

    Private Sub FlujoDocumentosPendientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Flujo_DocVentaNoDocumentado.Visible = True
    End Sub

    Private Sub FlujoChequesLetrasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Consulta_cheques_Pendientes.Visible = True
    End Sub

    Private Sub MantenciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Pedidos.Visible = True
    End Sub

    Private Sub CotizacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cotizacion.Visible = True
    End Sub

    Private Sub CambioDeNombreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cambio_Nombre.Visible = True
    End Sub
    Private Sub LibroDeComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LibroDeComprasToolStripMenuItem.Click
        Libro_Compras.Visible = True
    End Sub

    Private Sub ConsultaVencimientosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaVencimientosToolStripMenuItem.Click
        ReporteVencimientosProveedor.Show()
    End Sub

    Private Sub BalanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Balance_IN_EG.Visible = True
    End Sub

    Private Sub CartolaProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CartolaProveedorToolStripMenuItem.Click
        Cartola_Proveedor.Visible = True
    End Sub
    Private Sub ConsultaDetalladaPorClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Flujo_DocVentaNoDocumentado.Visible = True
    End Sub

    Private Sub MantenciónToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Pedidos.Visible = True
    End Sub

    Private Sub CotizaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cotizacion.Visible = True
    End Sub

    Private Sub ConsultaLoteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cambio_Estado.Visible = True

    End Sub

    Private Sub ToolStripMenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Devolucion_Bandejas.Visible = True
    End Sub

    Private Sub GuíasDeDespachoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Guia.Visible = True
    End Sub

    Private Sub ReimpresiónDeGuíasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReimpresiónDeGuíasToolStripMenuItem.Click
        Impresion_Guia.Visible = True
    End Sub


    Private Sub ConsultaConteosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Consulta_Conteo.Visible = True
    End Sub

    Private Sub ConsultaGuíasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaGuíasToolStripMenuItem1.Click
        Consulta_Guias.Visible = True
    End Sub

    Private Sub EventosPorLoteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Bitacora.Visible = True
    End Sub

    Private Sub AplicaciónDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Aplic_Producto.Visible = True
    End Sub

    Private Sub ToolStripMenuItem4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        win_Ingredientes.Visible = True
    End Sub

    Private Sub FórmulaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FórmulaToolStripMenuItem.Click
        Costos_directos.Visible = True
    End Sub

    Private Sub PreciosHechurasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Precios.Visible = True
    End Sub

    Private Sub PreciosSemillasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Costo_Semilla.Visible = True
    End Sub

    Private Sub ToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Consulta_Pedido_Especie_Cliente.Visible = True
    End Sub

    Private Sub ToolStripMenuItem7_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        Pedidos.Visible = True
    End Sub

    Private Sub ToolStripMenuItem11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click
        gQuienLlama = 1
        Cotizacion_ReImpresion.Visible = True
    End Sub

    Private Sub RegistroControlDeLotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Registro_Control_Lote.Visible = True
    End Sub

    Private Sub ConsultaBitácoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaBitácoraToolStripMenuItem.Click
        Actividades_Pendientes.Visible = True
    End Sub


    Private Sub ToolStripMenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem16.Click
        Cmpbt_Ctbl.Visible = True
    End Sub

    Private Sub AbonosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbonosToolStripMenuItem.Click
        Abono_Deuda.Visible = True
    End Sub

    Private Sub DepósitosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DepositoDoc.Visible = True
    End Sub

    Private Sub ToolStripMenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem18.Click
        'Flujo_DocVentaNoDocumentado.Visible = True
        DocumentosPendientes.Show()
    End Sub


    Private Sub ToolStripMenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem17.Click
        Consulta_Cmpbte.Visible = True
    End Sub

    Private Sub PagoDeFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagoDeFacturasToolStripMenuItem.Click
        Pago_Proveedores.Visible = True
    End Sub
    Private Sub DepósitoDeDocumentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepósitoDeDocumentosToolStripMenuItem.Click
        DepositoDoc.Visible = True
    End Sub

    Private Sub PagosClienteProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagosClienteProveedorToolStripMenuItem.Click
        SP_CONTA_Contabiliza_Pagos_Cliente_Proveedor.Visible = True
    End Sub

    Private Sub CierraMesContableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CierraMesContableToolStripMenuItem.Click
        SP_CONTA_ProcesoContabilizacion.Visible = True
    End Sub

    Private Sub AperturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AperturaToolStripMenuItem.Click
        Registro_Apertura.Visible = True
    End Sub

    Private Sub CierreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CierreToolStripMenuItem.Click
        Cierra_Diario.Visible = True
    End Sub

    Private Sub ListadoDeudoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeudoresToolStripMenuItem.Click
        Flujo_DocVentaNoDocumentado.Visible = True
    End Sub

    Private Sub ConsultaLoteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cambio_Estado.Visible = True
    End Sub

    Private Sub ConsultaConteosToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Consulta_Conteo.Visible = True
    End Sub

    Private Sub DespachosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Control_Despachos.Visible = True
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Tabla_Zona.Visible = True
    End Sub

    Private Sub HechurasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HechurasToolStripMenuItem.Click
        Precios.Visible = True
    End Sub

    Private Sub SemillasToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SemillasToolStripMenuItem.Click
        Costo_Semilla.Visible = True
    End Sub

    Private Sub ConsultaLotesSinGuíasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaLotesSinGuíasToolStripMenuItem.Click
        ReporteLoteSinGuia.Show()
    End Sub

    Private Sub ControlDeDespachosToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Control_Despachos.Visible = True
    End Sub

    Private Sub PanelControlToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Reporte_Plantas_Entregadas.Show()
    End Sub

    Private Sub ToolStripMenuItem20_Click(sender As Object, e As EventArgs)
        HojaTrabajo.Show()
    End Sub

    Private Sub ToolStripMenuItem21_Click(sender As Object, e As EventArgs)
        ReporteLotes.Show()
    End Sub

    Private Sub ReporteDeInventarioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Reporte_Stock.Show()
    End Sub

    Private Sub ToolStripMenuItem23_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem23.Click
        ConsultaCuentaGestion.Show()
    End Sub

    Private Sub ReporteLotesSinGuíasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ReporteLoteSinGuia.Show()
    End Sub

    Private Sub ReporteCostoPorPlanraToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Reporte_Costo_Planta.Show()
    End Sub
    Private Sub ReporteIngresosPorVariedadToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Reporte_Ingresos_Variedad.Show()
    End Sub

    Private Sub HojaDeTrabajoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        HojaTrabajo.Show()
    End Sub
    Private Sub ReporteCostoManoDeObraToolStripMenuItem_Click(sender As Object, e As EventArgs)
        REP_CostoMOmes.Show()
    End Sub

    Private Sub ControlDeLoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlDeLoteToolStripMenuItem.Click
        ParametroControlLote.Show()
    End Sub

    Private Sub ToolStripMenuItem20_Click_1(sender As Object, e As EventArgs)
        Inv_Semilla.Show()
    End Sub

    Private Sub InventarioDePlantasToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Reporte_Stock.Show()
    End Sub

    Private Sub InventarioDeSemillasToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Inv_Semilla.Show()
    End Sub

    Private Sub ReporteDeLotesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeLotesToolStripMenuItem.Click
        ReporteLotes.Show()
    End Sub

    Private Sub ReporteLotesSinGuíasEmitidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteLotesSinGuíasEmitidasToolStripMenuItem.Click
        ReporteLoteSinGuia.Show()
    End Sub

    Private Sub PlantasEntregadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlantasEntregadasToolStripMenuItem.Click
        Reporte_Plantas_Entregadas.Show()
    End Sub
    Private Sub EvoluciónVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EvoluciónVentasToolStripMenuItem.Click
        Rep_MensualVenta.Show()
    End Sub

    Private Sub VentasPorVariedadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasPorVariedadesToolStripMenuItem.Click
        Reporte_Ingresos_Variedad.Show()
    End Sub

    Private Sub CostosPorPlantasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CostosPorPlantasToolStripMenuItem.Click
        Reporte_Costo_Planta.Show()
    End Sub

    Private Sub CostosDeProducciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CostosDeProducciónToolStripMenuItem.Click
        REP_CostoMOmes.Show()
    End Sub

    Private Sub PróximosVencimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PróximosVencimientosToolStripMenuItem.Click
        ReporteVencimientosProveedor.Show()
    End Sub

    Private Sub LotesPorSembrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LotesPorSembrarToolStripMenuItem.Click
        LotesXSembrar.Show()
    End Sub

    Private Sub ControlDeLotesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlDeLotesToolStripMenuItem.Click
        Reporte_Control_Lote.Show()
    End Sub


    Private Sub ControlEstadoDeLotesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlEstadoDeLotesToolStripMenuItem.Click
        ControlRevisionLotes.Show()
    End Sub
    Private Sub AjustesDeInventarioSemillaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        AjusteInventario.Show()
    End Sub

    Private Sub ToolStripMenuItem28_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem28.Click
        ReporteStockSemilla.Show()
    End Sub

    Private Sub SiembraVsEntregasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SiembraVsEntregasToolStripMenuItem.Click
        ReporteIndicadorPlantasRetiradas.Show()
    End Sub

    Private Sub AjusteInventarioSemillaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjusteInventarioSemillaToolStripMenuItem.Click
        AjusteInventario.Show()
    End Sub

    Private Sub MovimientosInventarioPorSemillaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientosInventarioPorSemillaToolStripMenuItem.Click
        ReporteKardexInventario.Show()
    End Sub

    Private Sub PedidosVsStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PedidosVsStockToolStripMenuItem.Click
        ReportePedidosVersusStockSemilla.Show()
    End Sub
    Private Sub ToolStripMenuItem29_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem29.Click
        PlanCuentas.Show()
    End Sub

    Private Sub VendedoresToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendedoresToolStripMenuItem1.Click
        Vendedores.Show()
    End Sub

    Private Sub ParámetrosGeneralesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcionParametros.Click
        ParametrosSistema.Show()
    End Sub

    Private Sub ListadoDePreciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDePreciosToolStripMenuItem.Click
        ReporteListadoPrecios.Show()
    End Sub

    Private Sub ComisionesVendedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComisionesVendedoresToolStripMenuItem.Click
        ReporteComisionVentas.Show()
    End Sub

    Private Sub VendedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendedoresToolStripMenuItem.Click
        Trabajadores.Show()
    End Sub

    Private Sub TablaPreciosHechurasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TablaPreciosHechurasToolStripMenuItem.Click
        PreMOAct.Visible = True
    End Sub

    Private Sub TablaPreciosSemillasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TablaPreciosSemillasToolStripMenuItem.Click
        PreSEMAct.Visible = True
    End Sub

    Private Sub ControlDespachosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CtlDesp.Visible = True
    End Sub

    Private Sub PreparaciónDeLotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreparaciónDeLotesToolStripMenuItem.Click
        PrepDespLote.Visible = True
    End Sub

    Private Sub CreaciónDespachosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreaciónDespachosToolStripMenuItem.Click
        CtlDesp.Visible = True
    End Sub

    Private Sub VersiónTemporalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VersiónTemporalToolStripMenuItem.Click
        Control_Despachos.Visible = True
    End Sub

    Private Sub ImprimeDespachosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimeDespachosToolStripMenuItem.Click
        Despacho.Visible = True
    End Sub
    Private Sub ReporteCuadraturaDiariaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteCuadraturaDiariaToolStripMenuItem.Click
        Form3.Visible = True
    End Sub

    Private Sub ToolStripMenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem30.Click
        CambioPassword.Visible = True
    End Sub

    Private Sub IndicadoresDeSiembraToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IndicadoresDeSiembraToolStripMenuItem.Click
        ConsultaControlSiembra.Visible = True
    End Sub

    Private Sub RankingDeVentasPorClienteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RankingDeVentasPorClienteToolStripMenuItem.Click
        RankingVenta.Visible = True
    End Sub

    Private Sub RankingDeVentasPorClienteYVariedadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RankingDeVentasPorClienteYVariedadToolStripMenuItem.Click
        RankingVentasClienteVariedad.Visible = True
    End Sub

    Private Sub ConsumoPetróleoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsumoPetróleoToolStripMenuItem.Click
        RendimientoVehiculo.Visible = True
    End Sub

    Private Sub RegistroDeVehículosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistroDeVehículosToolStripMenuItem.Click
        RegistroVehiculo.Visible = True
    End Sub

    Private Sub ToolStripMenuItem31_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem31.Click
        ReporteSiembras.Show()
    End Sub

    Private Sub ProyecciónDeVentaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProyecciónDeVentaToolStripMenuItem.Click
        ProyeccionVenta.ShowDialog()
    End Sub

    Private Sub IndicadoresDeSiembraAnualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndicadoresDeSiembraAnualToolStripMenuItem.Click
        RepIndicadorAnual.Show()
    End Sub

    Private Sub GuìasDeInventarioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        INV_ingresoGuia.Show()
    End Sub

    Private Sub ToolStripMenuItem32_Click(sender As Object, e As EventArgs)
        MaestroProducto.Show()
    End Sub

    Private Sub ConsultaStockToolStripMenuItem_Click(sender As Object, e As EventArgs)
        StockProductoBodega.Show()
    End Sub

    Private Sub DevolucionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevolucionesToolStripMenuItem.Click
        Devolucion_Bandejas.Visible = True
    End Sub

    Private Sub ConsultaConteosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ConsultaConteosToolStripMenuItem2.Click
        Consulta_Conteo.Visible = True
    End Sub

    Private Sub AplicaciónDeProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AplicaciónDeProductosToolStripMenuItem1.Click
        Aplic_Producto.Visible = True
    End Sub

    Private Sub ControlDeLotesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ControlDeLotesToolStripMenuItem1.Click
        Registro_Control_Lote.Visible = True
    End Sub

    Private Sub HojaDeTrabajoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HojaDeTrabajoToolStripMenuItem1.Click
        HojaTrabajo.Show()
    End Sub

    Private Sub RegistrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrosToolStripMenuItem.Click
        Bitacora.Visible = True
    End Sub

    Private Sub ConsultaLoteToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles ConsultaLoteToolStripMenuItem1.Click
        gQuienLlama = 0
        Cambio_Estado.Visible = True
    End Sub

    Private Sub ProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem1.Click
        MaestroProducto.Show()
    End Sub

    Private Sub EntradasSalidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasSalidasToolStripMenuItem.Click
        INV_ingresoGuia.Show()
    End Sub

    Private Sub ConsultaStockToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultaStockToolStripMenuItem1.Click
        StockProductoBodega.Show()
    End Sub

    Private Sub ConsultaPreciosDePlantasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaPreciosDePlantasToolStripMenuItem.Click
        Consulta_Precios.Visible = True
    End Sub

    Private Sub ClientesSinMovimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesSinMovimientoToolStripMenuItem.Click
        Reporte_Cliente_01.Show()
    End Sub

    Private Sub ConsultaPresupuestoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultaPresupuestoToolStripMenuItem1.Click
        Consulta_Presupuesto.Visible = True
    End Sub

    Private Sub BalanceTributarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BalanceTributarioToolStripMenuItem.Click
        Balance_IN_EG.Visible = True
    End Sub

    Private Sub LotesPorSembrarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LotesPorSembrarToolStripMenuItem1.Click
        LotesPorSembrar.Visible = True
    End Sub

    Private Sub ConsultaFacturasPendientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Prox_Vcto.Show()
    End Sub

    Private Sub ReporteDeLotesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReporteDeLotesToolStripMenuItem1.Click
        ConsultaLotesPantalla.Show()
    End Sub
    Private Sub SubirInformaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubirInformaciónToolStripMenuItem.Click
        SubirAutorizacionEntrega.Show()
    End Sub

    Private Sub CierrePeríodoAnualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CierrePeríodoAnualToolStripMenuItem.Click
        CierrePeriodoAnual.Show()
    End Sub

    Private Sub ToolStripMenuItem15_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem15.Click
        ModificaDocumentoVenta.Show()
    End Sub

    Private Sub ToolStripMenuItem21_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem21.Click
        ReporteDespachoRecuperacionBandejas.Show()
    End Sub

    Private Sub ReporteBandejasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteBandejasToolStripMenuItem.Click
        ReporteDespachoRecuperacionBandejas.Show()
    End Sub

    Private Sub ToolStripMenuItem33_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem33.Click
        Consulta_cheques_Pendientes.Show()
    End Sub

    Private Sub ImprimeGuíasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimeGuíasToolStripMenuItem.Click
        Dim nDespacho As Integer
        nDespacho = Val(InputBox("N° Despacho:", "Impresión masiva de Guías", DefaultResponse:=0))
        If nDespacho > 0 Then
            Print_Guia.nDespacho.Text = nDespacho
            Print_Guia.Show()
        End If
    End Sub

    Private Sub AutorizarPedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles opcionAutorizaPedido.Click
        AutorizacionPedidos.Show()
    End Sub

    Private Sub ToolStripMenuItem32_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem32.Click
        LotesParaConteo.Show()
    End Sub

    Private Sub ToolStripMenuItem34_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem34.Click
        DocumentosPendientes.Show()
    End Sub
End Class