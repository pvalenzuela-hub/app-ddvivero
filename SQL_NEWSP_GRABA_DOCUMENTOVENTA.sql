-- =======================================================================================
-- NEWSP_GRABA_DOCUMENTOVENTA
-- 09 NOV 2026: corrige grabación de Notas de Crédito.
--   La versión del 22 AGO 2026 perdió las tildes de sus textos y buscaba la forma de pago
--   'Nota de Credito' (en FORMAPAGO es 'Nota de Crédito'). El pago de la NC fallaba y,
--   al no haber transacción, quedaban grabados el lote, el pedido y la devolución de
--   bandejas sin el pago al documento referenciado (NC 29 a 35).
--   - La forma de pago de la NC se obtiene por su código ('NC'), no por el nombre.
--   - Cada llamada se ejecuta en una transacción: si algo falla no queda nada a medias.
-- Guardar este archivo como UTF-8 con BOM para conservar las tildes.
-- =======================================================================================
CREATE OR ALTER PROCEDURE [dbo].[NEWSP_GRABA_DOCUMENTOVENTA]
	@IdVtaHead int,
	@IdVendedor int,
	@IdCliente int,
	@Valor_Doc float,
	@Fecha_Doc date,
	@Num_Doc int,
	@Tipo_Doc varchar(2),
	@Comentario varchar(MAX),
	@IdClienteFactura int,
	@TotalNeto float,
	@IdUsuario varchar(10),
	@AbonoARebajar float,
	@Estado int,
	@IdVtaDetNC int,
	@Familia varchar(50),
	@Variedad varchar(50),
	@CANTIDAD int,
	@PRECIO_UNITARIO decimal(18,2),
	@GLOSA varchar(100),
    @IDGUIA int,
	@Tipo_Venta int,
	@Insumo varchar(50),
	@Indice int,
	@PromedioPlantas decimal(10,4),
	@CantidadBandejas int,
	@DescuentoComercial float = 0
AS
DECLARE @IdInsumo int,
		@IdFamilia int,
		@IdVariedad int,
		@Lote int,
		@Pedido int,
		@NuevoPedido int,
		@IdVtaHeadNC int,
		@TotalPago float,
		@ValorDocumento float,
		@Valor_Pago float,
		@Valor_DAI float,
		@Doc_Refer varchar(2),
		@Num_Refer int,
		@IdVtaDet int,
		@Glosa_Referencia varchar(50),
		@FormaPagoNC varchar(50),
		@Existe int,
		@MaxNum int
BEGIN
	SET XACT_ABORT ON;

	BEGIN TRY
	BEGIN TRANSACTION;

	-- Verificar correlativo antes de insertar
	IF @IdVtaHead = 0 AND @Indice = 0
	BEGIN
		SELECT @Existe = COUNT(*)
		FROM VENTA_HEADER
		WHERE NUM_DOC = @Num_Doc AND TIPO_DOC = @Tipo_Doc;
		IF @Existe > 0
		BEGIN
			SELECT @MaxNum = ISNULL(MAX(NUM_DOC), 0)
			FROM VENTA_HEADER
			WHERE TIPO_DOC = @Tipo_Doc;
			SET @Num_Doc = @MaxNum + 1;
		END
	END;
	If @Tipo_Venta in (0,2)
	Begin
		Set @IdFamilia = (Select idFamilia From FAMILIA Where DESCRIP = @Familia)
		Set @IdVariedad = (Select Idvariedad From TBL_VARIEDAD Where IdFamilia = @IdFamilia AND Descripcion = @Variedad)
		Set @IdInsumo = 0
	End
	If @Tipo_Venta = 1
	Begin
		Set @IdInsumo = (Select IdInsumo From INSUMO Where Descripcion = @Insumo)
		Set @IdFamilia = 0
		Set @IdVariedad = 0
	End
	If @IdvtaHead > 0 and @Indice = 0
	Begin
		Update Venta_Header
			Set IdCliente = @IdCliente,
				Id_ClienteFactura = @IdClienteFactura,
				IdVendedor = @IdVendedor,
				Fecha_Doc =  @Fecha_Doc,
				VALOR_DOC = @Valor_Doc,
				COMENTARIO = @Comentario,
				Total_Neto = @TotalNeto
		Where IdVtaHead = @IdvtaHead
		If @AbonoARebajar > 0
			Begin
				EXEC SP_INSERTA_PAGOS_PARCIALES
								@IdCliente,
								@Fecha_Doc,
								'CREDITO ABONO',
								'',
								@AbonoARebajar,
								@Tipo_Doc,
								@NUM_DOC,
								@AbonoARebajar,
								@Fecha_Doc,
								'ABONO INICIAL APLICADO',
								'S',
								@Fecha_Doc,
								0,
								@IdUsuario,
								0
				Exec SP_Actualiza_Abono_Inicial_Cliente @IDCLIENTE
			End
			Exec NEWSP_ELIMINA_DETALLEVENTA @IdVtaHead
	End
	If @IdVtaHead = 0 and @Indice = 0
	Begin
		INSERT INTO VENTA_HEADER
					   (IdVendedor
					   ,IDCLIENTE
					   ,VALOR_DOC
					   ,FECHA_DOC
					   ,NUM_DOC
					   ,TIPO_DOC
					   ,COMENTARIO
					   ,TOTAL_PAGO
					   ,FECHA_VCTO
					   ,ESTADO
					   ,Id_ClienteFactura
					   ,Total_Neto
					   ,IdUsuario)
				 VALUES
					   (@IdVendedor,
						@IdCliente,
						@Valor_Doc,
						@Fecha_Doc,
						@Num_Doc,
						@Tipo_Doc,
						@Comentario,
						0,
						@Fecha_Doc,
						@Estado,
						@IdClienteFactura,
						@TotalNeto,
						@IdUsuario)
		Set @IdVtaHead = @@Identity
		If @AbonoARebajar > 0
			Begin
				EXEC SP_INSERTA_PAGOS_PARCIALES
								@IdCliente,
								@Fecha_Doc,
								'CREDITO ABONO',
								'',
								@AbonoARebajar,
								@Tipo_Doc,
								@NUM_DOC,
								@AbonoARebajar,
								@Fecha_Doc,
								'ABONO INICIAL APLICADO',
								'S',
								@Fecha_Doc,
								0,
								@IdUsuario,
								0
				Exec SP_Actualiza_Abono_Inicial_Cliente @IDCLIENTE
			End
	End
	INSERT INTO VENTA_DETALLE
				   (IdvtaHead
				   ,IdFamilia
				   ,IdVariedad
				   ,IdInsumo
				   ,PRECIO_UNITARIO
				   ,CANTIDAD
				   ,TOTAL_NETO
				   ,GLOSA
				   ,IDGUIA
				   ,Tipo_Venta)
			 VALUES
				   (@IdvtaHead,
				   @IdFamilia,
				   @IdVariedad,
				   @IdInsumo,
				   @PRECIO_UNITARIO,
				   @CANTIDAD,
				   Round(@PRECIO_UNITARIO * @CANTIDAD, 0),
				   @GLOSA,
				   @IDGUIA,
				   @Tipo_Venta)
	Set @IdVtaDet = @@Identity
	If @IDGUIA > 0 AND @Tipo_Venta = 0
		UPDATE Guia_Lote
			SET Facturado_Ind = 'S'
		WHERE  IDGUIA = @IDGUIA
	If @Indice = 0 and @Tipo_Venta = 2 --> NC
	Begin
		-- La forma de pago se busca por código para no depender de tildes en la descripción.
		Set @FormaPagoNC = (Select DESCRIPCION From FORMAPAGO Where CodFpago = 'NC')
		If @FormaPagoNC Is Null
			THROW 50020, 'No existe la forma de pago con código NC (Nota de Crédito) en FORMAPAGO.', 1;

		Set @Lote = (Select IdPedidodet From Guia_Lote Where IDGUIA = @IDGUIA)
		Set @Pedido = (Select IdPedido From Pedido_Detalle Where IdPedidodet = @Lote)
		Set @IdVtaHeadNC = (Select IdVtaHead From Venta_Detalle Where IdVtaDet = @IdVtaDetNC)
		Set @TotalPago = (Select TOTAL_PAGO From Venta_Header Where IdVtaHead = @IdVtaHeadNC)
		Set @ValorDocumento = (Select VALOR_DOC From Venta_Header Where IdVtaHead = @IdVtaHeadNC)
		Set @Doc_Refer = (Select TIPO_DOC From Venta_Header Where IdVtaHead = @IdVtaHeadNC)
		Set @Num_Refer = (Select NUM_DOC  From Venta_Header Where IdVtaHead = @IdVtaHeadNC)
		Set @Glosa_Referencia = 'Devolución Plantas N.C. N° ' + Rtrim(Convert(char,@Num_Doc))
		Update Venta_Header
			Set IdVtaHeadNC = @IdVtaHeadNC
		Where IdVtaHead = @IdVtaHead
		-- Crear Pedido Hijo
		INSERT INTO PEDIDO_HEADER (IDCLIENTE,IdFormaEntrega,IdVendedor,FECHA,FECHA_ENTREGA,
				DIR_ENTREGA,COMENTARIO,
				IdCondVta,CodUsuario,EsPedidoHijo)
		Select @IdCliente,IdFormaEntrega,IdVendedor,@Fecha_Doc,FECHA_ENTREGA,
				DIR_ENTREGA,'Pedido creado por N.C. N'+Rtrim(Convert(char,@Num_Doc)),
				IdCondVta,@IdUsuario,1
		From PEDIDO_HEADER
		Where IdPedido = @Pedido
		Set @NuevoPedido = @@Identity
		Exec SP_CREA_NUEVO_LOTE_EXISTENTE @NuevoPedido,@Lote,@PRECIO_UNITARIO,@CANTIDAD,@PromedioPlantas,@CantidadBandejas,0
		-- Actualizar Guia con la devolucion de bandejas
		Update GUIA_LOTE
			Set Cant_Band_Devol = ISNULL(Cant_Band_Devol,0) + @CantidadBandejas
		Where IDGUIA = @IDGUIA
		-- Ingresa el Pago al Documento asociado con Nota de Credito
		if @Valor_Doc >= (@ValorDocumento - @TotalPago)
		Begin
			Set @Valor_Pago = @ValorDocumento - @TotalPago
			Set @Valor_DAI  = @Valor_Doc - @Valor_Pago
		End
		if @Valor_Doc < (@ValorDocumento - @TotalPago)
		Begin
			Set @Valor_Pago = @Valor_Doc
			Set @Valor_DAI  = 0
		End
		Exec SP_INSERTA_PAGOS_PARCIALES @IdCliente,@Fecha_Doc,@FormaPagoNC,'',@Valor_Pago,@Doc_Refer, @Num_Refer, @Valor_Pago, @Fecha_Doc,@Glosa_Referencia,'N',@Fecha_Doc, 0, @IdUsuario, @Valor_DAI, @IdVtaDet
	End
	-- Aplica Descuento Comercial al Documento
	If @Indice = 0 AND @Tipo_Venta <> 2 AND @DescuentoComercial > 0
	Begin
		UPDATE VENTA_HEADER
			SET DESCUENTO = @DescuentoComercial
		WHERE IdVtaHead = @IdVtaHead
		EXEC SP_APLICA_COMPENSACION_VENTA @IdCliente, @IdVtaHead, @DescuentoComercial, @IdUsuario
	End

	COMMIT TRANSACTION;

	SELECT @IdVtaHead

	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRANSACTION;
		THROW;
	END CATCH
END
