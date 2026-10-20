-- =======================================================================================
-- Módulo de Aplicación de Productos (aplicación conjunta sobre varios lotes)
-- Solicitado por Jaime Ortiz (Viveros DyD), 13 OCT 2026.
-- Script idempotente: puede ejecutarse más de una vez.
-- =======================================================================================

IF NOT EXISTS (SELECT 1 FROM dbo.Tipo_Insumo WHERE Descripcion = 'HERBICIDAS')
    INSERT INTO dbo.Tipo_Insumo (Descripcion) VALUES ('HERBICIDAS');
GO

IF OBJECT_ID('dbo.APLICACION', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.APLICACION (
        IdAplicacion        int IDENTITY(1,1) NOT NULL CONSTRAINT PK_APLICACION PRIMARY KEY,
        FechaAplicacion     datetime       NOT NULL,
        IdAplicador         int            NOT NULL CONSTRAINT FK_APLICACION_VENDEDOR REFERENCES dbo.VENDEDOR (IdVendedor),
        IdTipoInsumo        int            NOT NULL CONSTRAINT FK_APLICACION_TIPO_INSUMO REFERENCES dbo.Tipo_Insumo (idTipoInsumo),
        IdInsumo            int            NOT NULL CONSTRAINT FK_APLICACION_INSUMO REFERENCES dbo.INSUMO (IdInsumo),
        Motivo              varchar(200)   NULL,
        -- L: dosis por litro, C: dosis por 100 L, T: cantidad total, H: dosis por hectárea
        FormaDosis          char(1)        NOT NULL CONSTRAINT CK_APLICACION_FORMA CHECK (FormaDosis IN ('L','C','T','H')),
        IdUnidad            int            NOT NULL CONSTRAINT FK_APLICACION_UNIDAD REFERENCES dbo.TBL_UNIDADES (IdUnidad),
        Dosis               decimal(18,6)  NOT NULL CONSTRAINT CK_APLICACION_DOSIS CHECK (Dosis > 0),
        LitrosPreparados    decimal(18,3)  NOT NULL CONSTRAINT CK_APLICACION_PREPARADOS CHECK (LitrosPreparados > 0),
        SuperficieM2        decimal(18,3)  NULL,
        LitrosUtilizados    decimal(18,3)  NOT NULL,
        UsoTotalMezcla      bit            NOT NULL,
        ProductoTotal       decimal(18,6)  NOT NULL,
        ProductoUtilizado   decimal(18,6)  NOT NULL,
        Observaciones       varchar(1000)  NULL,
        IdUsuarioRegistro   int            NULL,
        FechaRegistro       datetime       NOT NULL CONSTRAINT DF_APLICACION_FECHAREG DEFAULT (GETDATE()),
        Anulada             bit            NOT NULL CONSTRAINT DF_APLICACION_ANULADA DEFAULT (0),
        FechaAnulacion      datetime       NULL,
        IdUsuarioAnulacion  int            NULL,
        CONSTRAINT CK_APLICACION_UTILIZADOS CHECK (LitrosUtilizados > 0 AND LitrosUtilizados <= LitrosPreparados),
        CONSTRAINT CK_APLICACION_SUPERFICIE CHECK (FormaDosis <> 'H' OR SuperficieM2 > 0)
    );

    CREATE INDEX IX_APLICACION_FECHA ON dbo.APLICACION (FechaAplicacion);
END
GO

IF OBJECT_ID('dbo.APLICACION_LOTE', 'U') IS NULL
BEGIN
    -- Bandejas y plantas se guardan tal como estaban al momento de la aplicación.
    CREATE TABLE dbo.APLICACION_LOTE (
        IdAplicacion  int NOT NULL CONSTRAINT FK_APLICACION_LOTE_APLICACION REFERENCES dbo.APLICACION (IdAplicacion),
        IdPedidodet   int NOT NULL CONSTRAINT FK_APLICACION_LOTE_LOTE REFERENCES dbo.PEDIDO_DETALLE (IdPedidodet),
        Bandejas      int NOT NULL,
        Plantas       int NOT NULL,
        CONSTRAINT PK_APLICACION_LOTE PRIMARY KEY (IdAplicacion, IdPedidodet)
    );

    CREATE INDEX IX_APLICACION_LOTE_LOTE ON dbo.APLICACION_LOTE (IdPedidodet);
END
GO

IF TYPE_ID('dbo.TT_ListaLotes') IS NULL
    CREATE TYPE dbo.TT_ListaLotes AS TABLE (IdPedidodet int NOT NULL PRIMARY KEY);
GO

-- Lotes en vivero (Siembra, Conteo Plantas, Aviso Cliente) para seleccionar.
CREATE OR ALTER PROCEDURE dbo.SP_APLICACION_LOTES_ACTIVOS
AS
BEGIN
    SET NOCOUNT ON;

    SELECT  d.IdPedidodet,
            ISNULL(f.DESCRIP, '')           AS Cultivo,
            ISNULL(v.Descripcion, '')       AS Variedad,
            ISNULL(LTRIM(RTRIM(d.Num_Nave)), '')  AS Nave,
            ISNULL(LTRIM(RTRIM(d.Ubicacion)), '') AS Mesa,
            ISNULL(d.Saldo_Bandeja, 0)      AS Bandejas,
            ISNULL(tb.Cantidad, 0)          AS Alveolos,
            ISNULL(d.Saldo_Plantas, 0)      AS Plantas,
            ISNULL(e.nombre, '')            AS Estado
    FROM dbo.PEDIDO_DETALLE d
    LEFT JOIN dbo.FAMILIA f           ON f.idFamilia = d.IdFamilia
    LEFT JOIN dbo.TBL_VARIEDAD v      ON v.IdVariedad = d.IdVariedad
    LEFT JOIN dbo.TBL_TIPO_BANDEJA tb ON tb.IdTipoBandeja = d.IdTipoBandeja
    LEFT JOIN vivero.tEstado e        ON e.codigo = d.ESTADO
    WHERE d.ESTADO BETWEEN 1 AND 3
    ORDER BY d.IdPedidodet;
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_APLICACION_PRODUCTOS
AS
BEGIN
    SET NOCOUNT ON;

    SELECT IdInsumo, Descripcion
    FROM dbo.INSUMO
    WHERE Tipo_Insumo = 'P'
    ORDER BY Descripcion;
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_APLICACION_TIPOS
AS
BEGIN
    SET NOCOUNT ON;

    SELECT idTipoInsumo, Descripcion
    FROM dbo.Tipo_Insumo
    ORDER BY Descripcion;
END
GO

-- Unidades de dosificación: CC (mL), GR (g), LT (L), KG (kg).
CREATE OR ALTER PROCEDURE dbo.SP_APLICACION_UNIDADES
AS
BEGIN
    SET NOCOUNT ON;

    SELECT IdUnidad, Descripcion
    FROM dbo.TBL_UNIDADES
    WHERE Descripcion IN ('CC', 'GR', 'LT', 'KG')
    ORDER BY CASE Descripcion WHEN 'CC' THEN 1 WHEN 'GR' THEN 2 WHEN 'LT' THEN 3 ELSE 4 END;
END
GO

-- Graba una aplicación conjunta y sus lotes en una sola transacción.
-- Los totales de producto se calculan aquí para que siempre coincidan con la fórmula.
CREATE OR ALTER PROCEDURE dbo.SP_APLICACION_GRABAR
    @FechaAplicacion   datetime,
    @IdAplicador       int,
    @IdTipoInsumo      int,
    @IdInsumo          int,
    @Motivo            varchar(200),
    @FormaDosis        char(1),
    @IdUnidad          int,
    @Dosis             decimal(18,6),
    @LitrosPreparados  decimal(18,3),
    @SuperficieM2      decimal(18,3),
    @LitrosUtilizados  decimal(18,3),
    @UsoTotalMezcla    bit,
    @Observaciones     varchar(1000),
    @IdUsuarioRegistro int,
    @Lotes             dbo.TT_ListaLotes READONLY
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    IF NOT EXISTS (SELECT 1 FROM @Lotes)
        THROW 50001, 'Debe seleccionar al menos un lote.', 1;

    IF EXISTS (SELECT 1 FROM @Lotes l LEFT JOIN dbo.PEDIDO_DETALLE d ON d.IdPedidodet = l.IdPedidodet WHERE d.IdPedidodet IS NULL)
        THROW 50002, 'Uno o más lotes seleccionados no existen.', 1;

    IF @UsoTotalMezcla = 1
        SET @LitrosUtilizados = @LitrosPreparados;

    DECLARE @ProductoTotal decimal(18,6) =
        CASE @FormaDosis
            WHEN 'L' THEN @LitrosPreparados * @Dosis
            WHEN 'C' THEN @LitrosPreparados * @Dosis / 100
            WHEN 'T' THEN @Dosis
            WHEN 'H' THEN @SuperficieM2 * @Dosis / 10000
        END;

    DECLARE @ProductoUtilizado decimal(18,6) = @ProductoTotal * @LitrosUtilizados / @LitrosPreparados;
    DECLARE @IdAplicacion int;

    BEGIN TRANSACTION;

    INSERT INTO dbo.APLICACION (
        FechaAplicacion, IdAplicador, IdTipoInsumo, IdInsumo, Motivo, FormaDosis, IdUnidad, Dosis,
        LitrosPreparados, SuperficieM2, LitrosUtilizados, UsoTotalMezcla, ProductoTotal, ProductoUtilizado,
        Observaciones, IdUsuarioRegistro)
    VALUES (
        @FechaAplicacion, @IdAplicador, @IdTipoInsumo, @IdInsumo, NULLIF(LTRIM(RTRIM(@Motivo)), ''), @FormaDosis, @IdUnidad, @Dosis,
        @LitrosPreparados, CASE WHEN @FormaDosis = 'H' THEN @SuperficieM2 END, @LitrosUtilizados, @UsoTotalMezcla, @ProductoTotal, @ProductoUtilizado,
        NULLIF(LTRIM(RTRIM(@Observaciones)), ''), @IdUsuarioRegistro);

    SET @IdAplicacion = SCOPE_IDENTITY();

    INSERT INTO dbo.APLICACION_LOTE (IdAplicacion, IdPedidodet, Bandejas, Plantas)
    SELECT @IdAplicacion, d.IdPedidodet, ISNULL(d.Saldo_Bandeja, 0), ISNULL(d.Saldo_Plantas, 0)
    FROM @Lotes l
    INNER JOIN dbo.PEDIDO_DETALLE d ON d.IdPedidodet = l.IdPedidodet;

    COMMIT TRANSACTION;

    SELECT @IdAplicacion AS IdAplicacion;
END
GO

-- Historial: una fila por aplicación. @Texto busca en producto, aplicador o N° de lote.
CREATE OR ALTER PROCEDURE dbo.SP_APLICACION_HISTORIAL
    @Desde            date,
    @Hasta            date,
    @Texto            varchar(100) = NULL,
    @IncluirAnuladas  bit = 0
AS
BEGIN
    SET NOCOUNT ON;

    SET @Texto = NULLIF(LTRIM(RTRIM(@Texto)), '');

    SELECT  a.IdAplicacion,
            a.FechaAplicacion,
            ISNULL(ve.NOMBRE, '')        AS Aplicador,
            ISNULL(ti.Descripcion, '')   AS Tipo,
            ISNULL(i.Descripcion, '')    AS Producto,
            a.FormaDosis,
            a.Dosis,
            u.Descripcion                AS Unidad,
            a.SuperficieM2,
            a.LitrosPreparados,
            a.LitrosUtilizados,
            a.LitrosPreparados - a.LitrosUtilizados AS LitrosSobrantes,
            a.ProductoTotal,
            a.ProductoUtilizado,
            x.CantLotes,
            x.Bandejas,
            x.Plantas,
            x.Lotes,
            ISNULL(a.Motivo, '')         AS Motivo,
            ISNULL(a.Observaciones, '')  AS Observaciones,
            a.Anulada
    FROM dbo.APLICACION a
    LEFT JOIN dbo.VENDEDOR ve     ON ve.IdVendedor = a.IdAplicador
    LEFT JOIN dbo.Tipo_Insumo ti  ON ti.idTipoInsumo = a.IdTipoInsumo
    LEFT JOIN dbo.INSUMO i        ON i.IdInsumo = a.IdInsumo
    LEFT JOIN dbo.TBL_UNIDADES u  ON u.IdUnidad = a.IdUnidad
    CROSS APPLY (
        SELECT  COUNT(*)        AS CantLotes,
                SUM(al.Bandejas) AS Bandejas,
                SUM(al.Plantas)  AS Plantas,
                STRING_AGG(CAST(al.IdPedidodet AS varchar(20)), ', ') WITHIN GROUP (ORDER BY al.IdPedidodet) AS Lotes
        FROM dbo.APLICACION_LOTE al
        WHERE al.IdAplicacion = a.IdAplicacion
    ) x
    WHERE a.FechaAplicacion >= @Desde
      AND a.FechaAplicacion < DATEADD(day, 1, @Hasta)
      AND (@IncluirAnuladas = 1 OR a.Anulada = 0)
      AND (@Texto IS NULL
           OR i.Descripcion LIKE '%' + @Texto + '%'
           OR ve.NOMBRE LIKE '%' + @Texto + '%'
           OR EXISTS (SELECT 1 FROM dbo.APLICACION_LOTE al2
                      WHERE al2.IdAplicacion = a.IdAplicacion
                        AND CAST(al2.IdPedidodet AS varchar(20)) = @Texto))
    ORDER BY a.FechaAplicacion DESC, a.IdAplicacion DESC;
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_APLICACION_ANULAR
    @IdAplicacion int,
    @IdUsuario    int
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dbo.APLICACION
    SET Anulada = 1,
        FechaAnulacion = GETDATE(),
        IdUsuarioAnulacion = @IdUsuario
    WHERE IdAplicacion = @IdAplicacion
      AND Anulada = 0;

    SELECT @@ROWCOUNT AS Filas;
END
GO

-- Bitácora de aplicaciones de un lote (Consulta Lote).
CREATE OR ALTER PROCEDURE dbo.SP_APLICACION_POR_LOTE
    @IdPedidodet int
AS
BEGIN
    SET NOCOUNT ON;

    SELECT  a.FechaAplicacion,
            ISNULL(i.Descripcion, '')    AS Producto,
            ISNULL(ti.Descripcion, '')   AS Tipo,
            a.FormaDosis,
            a.Dosis,
            u.Descripcion                AS Unidad,
            ISNULL(ve.NOMBRE, '')        AS Aplicador,
            ISNULL(a.Motivo, '')         AS Motivo,
            ISNULL(a.Observaciones, '')  AS Observaciones,
            (SELECT COUNT(*) FROM dbo.APLICACION_LOTE x WHERE x.IdAplicacion = a.IdAplicacion) AS CantLotes,
            a.IdAplicacion
    FROM dbo.APLICACION_LOTE al
    INNER JOIN dbo.APLICACION a   ON a.IdAplicacion = al.IdAplicacion
    LEFT JOIN dbo.INSUMO i        ON i.IdInsumo = a.IdInsumo
    LEFT JOIN dbo.Tipo_Insumo ti  ON ti.idTipoInsumo = a.IdTipoInsumo
    LEFT JOIN dbo.TBL_UNIDADES u  ON u.IdUnidad = a.IdUnidad
    LEFT JOIN dbo.VENDEDOR ve     ON ve.IdVendedor = a.IdAplicador
    WHERE al.IdPedidodet = @IdPedidodet
      AND a.Anulada = 0
    ORDER BY a.FechaAplicacion DESC;
END
GO
