-- =======================================================================================
-- Lotes ocultos del reporte de lotes disponibles a la venta
-- Solicitado por Jaime Ortiz (Viveros DyD), 12 NOV 2026.
-- Permite ocultar temporalmente lotes del reporte (L001_SP_ReporteLotes) sin cambiarlos
-- de cliente. Los lotes ocultos no aparecen ni con "Todo", salvo @IncluirOcultos = 1.
-- Se usa una tabla aparte para no modificar PEDIDO_DETALLE.
-- Script idempotente. Guardar como UTF-8 con BOM.
-- =======================================================================================

IF OBJECT_ID('dbo.LOTE_OCULTO_VENTA', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.LOTE_OCULTO_VENTA (
        IdPedidodet  int          NOT NULL CONSTRAINT PK_LOTE_OCULTO_VENTA PRIMARY KEY
                                  CONSTRAINT FK_LOTE_OCULTO_VENTA_LOTE REFERENCES dbo.PEDIDO_DETALLE (IdPedidodet),
        FechaOculto  datetime     NOT NULL CONSTRAINT DF_LOTE_OCULTO_VENTA_FECHA DEFAULT (GETDATE()),
        Usuario      varchar(10)  NULL,
        Motivo       varchar(200) NULL
    );
END
GO

-- Oculta un lote del reporte de venta. Si ya estaba oculto, actualiza el motivo.
CREATE OR ALTER PROCEDURE dbo.SP_LOTE_VENTA_OCULTAR
    @IdPedidodet int,
    @Usuario     varchar(10),
    @Motivo      varchar(200) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM dbo.PEDIDO_DETALLE WHERE IdPedidodet = @IdPedidodet)
        THROW 50030, 'El lote no existe.', 1;

    IF EXISTS (SELECT 1 FROM dbo.LOTE_OCULTO_VENTA WHERE IdPedidodet = @IdPedidodet)
        UPDATE dbo.LOTE_OCULTO_VENTA
        SET Motivo = ISNULL(NULLIF(LTRIM(RTRIM(@Motivo)), ''), Motivo)
        WHERE IdPedidodet = @IdPedidodet;
    ELSE
        INSERT INTO dbo.LOTE_OCULTO_VENTA (IdPedidodet, Usuario, Motivo)
        VALUES (@IdPedidodet, @Usuario, NULLIF(LTRIM(RTRIM(@Motivo)), ''));

    SELECT 1 AS Oculto;
END
GO

-- Vuelve a mostrar un lote en el reporte de venta.
CREATE OR ALTER PROCEDURE dbo.SP_LOTE_VENTA_MOSTRAR
    @IdPedidodet int
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM dbo.LOTE_OCULTO_VENTA WHERE IdPedidodet = @IdPedidodet;

    SELECT @@ROWCOUNT AS Filas;
END
GO

CREATE OR ALTER PROCEDURE [dbo].[L001_SP_ReporteLotes]
    @IdFamilia  int,
    @IdVariedad int,
	@EsTodo bit = null,
    @IncluirOcultos bit = 0
AS
BEGIN
    SET NOCOUNT ON;

    /*
      Reglas de filtro:
      - Si @IdFamilia = 0 => no filtra familia
      - Si @IdVariedad = 0 => no filtra variedad
      - Si ambos > 0 => filtra ambos
      - Los lotes de LOTE_OCULTO_VENTA no se muestran (tampoco con @EsTodo = 1),
        salvo @IncluirOcultos = 1. (12 NOV 2026)
    */

    SELECT
        A.IdPedidodet AS [NLote],

        CASE
            WHEN B.IDCliente = 425
                THEN C.Nombre
            ELSE SUBSTRING(C.APELLIDO + ' ' + C.Nombre, 1, 100)
        END AS [Cliente],

        RTRIM(H.DESCRIP) AS [Semilla],
        F.Descripcion AS [Variedad],
        A.Aporta_Semilla AS [AportaSemilla],
        A.Cantidad AS [Pedido],

        A.Fecha_CInicial AS [FechaConteoSiembra],

        G.Cantidad AS [Tipo],
        A.Saldo_Plantas AS [SaldoPlantas],
        A.Saldo_Bandeja AS [SaldoBandejas],

        A.Fecha_Inicio AS [FechaSiembra],
        A.Fecha_Entrega AS [FechaEntrega],

        E.EstadoLote,

        ISNULL(A.Ubicacion,'') AS [Ubicacion],
        ISNULL(A.Num_Nave,'')  AS [Nave],

        CASE
            WHEN A.Fecha_CInicial IS NOT NULL
                THEN DATEDIFF(day, A.Fecha_CInicial, GETDATE())
            ELSE 0
        END AS [DiasVivero],

        DATEADD(day, D.DiasFabrica, A.Fecha_Inicio) AS [Entregadias],

        A.FechaAutorizacionCliente AS [FechaAutorizacionCliente],

        CASE
            WHEN A.FechaAutorizacionCliente IS NULL THEN 0
            WHEN A.FechaAutorizacionCliente < CAST(GETDATE() AS date) THEN 1
            ELSE 0
        END AS [Atraso],
		D.DiasFabrica Periodo,
		[dbo].[Fx_Get_Temporada] (A.Fecha_Inicio) Ciclo,

        CAST(CASE WHEN O.IdPedidodet IS NULL THEN 0 ELSE 1 END AS bit) AS [Oculto],
        ISNULL(O.Motivo, '') AS [MotivoOculto]

    FROM Pedido_detalle A
    JOIN Pedido_header B      ON B.IdPedido   = A.IdPedido
    JOIN Cliente C            ON C.IDCLIENTE  = B.IDCLIENTE
    JOIN TBL_VARIEDAD F       ON F.IdVariedad = A.IdVariedad
    JOIN Tbl_Tipo_Bandeja G   ON G.IdTipoBandeja = A.IdTipoBandeja
    JOIN FAMILIA H            ON H.idFamilia  = A.idFamilia
    LEFT JOIN dbo.LOTE_OCULTO_VENTA O ON O.IdPedidodet = A.IdPedidodet

    -- Llamar funciones UNA vez por fila
    OUTER APPLY (SELECT dbo.Obtiene_Estados_Lote(A.Idpedidodet) AS EstadoLote) E
    OUTER APPLY (SELECT dbo.Fx_Get_DiasFabricaLote(A.IdPedidodet) AS DiasFabrica) D

	WHERE
        A.Estado IN (1,2,3,6)
        AND (
            @EsTodo = 1
            OR (B.IDCliente = 425 OR A.EsPreventa = 1)
        )
        AND (@IdFamilia  = 0 OR A.IdFamilia  = @IdFamilia)
        AND (@IdVariedad = 0 OR A.IdVariedad = @IdVariedad)
        AND (@IncluirOcultos = 1 OR O.IdPedidodet IS NULL)

    ORDER BY
        [Cliente],
        A.Fecha_CInicial;   -- orden real por fecha (mucho mejor que FORMAT)
END
GO
