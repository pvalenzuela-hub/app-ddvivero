USE [ddvivero]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SP_CONTA_CompletaCajaHeaderDiasSinMovimiento]
    @Cta_Ctble varchar(7),
    @FechaHasta date
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @FechaUltima date;
    DECLARE @SaldoInicial float;
    DECLARE @SaldoFinal float;
    DECLARE @Apertura_B1000 int;
    DECLARE @Apertura_B2000 int;
    DECLARE @Apertura_B5000 int;
    DECLARE @Apertura_B10000 int;
    DECLARE @Apertura_B20000 int;
    DECLARE @Apertura_B500 int;
    DECLARE @Apertura_B100 int;
    DECLARE @Apertura_B50 int;
    DECLARE @Apertura_B10 int;
    DECLARE @Cierre_B1000 int;
    DECLARE @Cierre_B2000 int;
    DECLARE @Cierre_B5000 int;
    DECLARE @Cierre_B10000 int;
    DECLARE @Cierre_B20000 int;
    DECLARE @Cierre_B500 int;
    DECLARE @Cierre_B100 int;
    DECLARE @Cierre_B50 int;
    DECLARE @Cierre_B10 int;
    DECLARE @Apertura_Conteo_Registrado bit;
    DECLARE @Cierre_Conteo_Registrado bit;

    SELECT TOP (1)
        @FechaUltima = CONVERT(date, Fecha_Caja),
        @SaldoInicial = Saldo_Inicial,
        @SaldoFinal = ISNULL(Saldo_Final, Saldo_Inicial),
        @Apertura_B1000 = ISNULL(Apertura_B1000, 0),
        @Apertura_B2000 = ISNULL(Apertura_B2000, 0),
        @Apertura_B5000 = ISNULL(Apertura_B5000, 0),
        @Apertura_B10000 = ISNULL(Apertura_B10000, 0),
        @Apertura_B20000 = ISNULL(Apertura_B20000, 0),
        @Apertura_B500 = ISNULL(Apertura_B500, 0),
        @Apertura_B100 = ISNULL(Apertura_B100, 0),
        @Apertura_B50 = ISNULL(Apertura_B50, 0),
        @Apertura_B10 = ISNULL(Apertura_B10, 0),
        @Cierre_B1000 = ISNULL(Cierre_B1000, 0),
        @Cierre_B2000 = ISNULL(Cierre_B2000, 0),
        @Cierre_B5000 = ISNULL(Cierre_B5000, 0),
        @Cierre_B10000 = ISNULL(Cierre_B10000, 0),
        @Cierre_B20000 = ISNULL(Cierre_B20000, 0),
        @Cierre_B500 = ISNULL(Cierre_B500, 0),
        @Cierre_B100 = ISNULL(Cierre_B100, 0),
        @Cierre_B50 = ISNULL(Cierre_B50, 0),
        @Cierre_B10 = ISNULL(Cierre_B10, 0),
        @Apertura_Conteo_Registrado = ISNULL(Apertura_Conteo_Registrado, 0),
        @Cierre_Conteo_Registrado = ISNULL(Cierre_Conteo_Registrado, 0)
    FROM dbo.CAJA_HEADER
    WHERE Cta_Ctble = @Cta_Ctble
      AND CONVERT(date, Fecha_Caja) <= @FechaHasta
    ORDER BY Fecha_Caja DESC;

    IF @FechaUltima IS NULL
    BEGIN
        RETURN;
    END

    DECLARE @FechaActual date = DATEADD(day, 1, @FechaUltima);

    WHILE @FechaActual <= @FechaHasta
    BEGIN
        IF NOT EXISTS (
            SELECT 1
            FROM dbo.CAJA_HEADER
            WHERE Cta_Ctble = @Cta_Ctble
              AND CONVERT(date, Fecha_Caja) = @FechaActual
        )
        BEGIN
            INSERT INTO dbo.CAJA_HEADER
            (
                Cta_Ctble,
                Fecha_Caja,
                Saldo_Inicial,
                Saldo_Final,
                Apertura_B1000,
                Apertura_B2000,
                Apertura_B5000,
                Apertura_B10000,
                Apertura_B20000,
                Apertura_B500,
                Apertura_B100,
                Apertura_B50,
                Apertura_B10,
                Cierre_B1000,
                Cierre_B2000,
                Cierre_B5000,
                Cierre_B10000,
                Cierre_B20000,
                Cierre_B500,
                Cierre_B100,
                Cierre_B50,
                Cierre_B10,
                Apertura_Conteo_Registrado,
                Cierre_Conteo_Registrado
            )
            VALUES
            (
                @Cta_Ctble,
                @FechaActual,
                @SaldoFinal,
                @SaldoFinal,
                @Apertura_B1000,
                @Apertura_B2000,
                @Apertura_B5000,
                @Apertura_B10000,
                @Apertura_B20000,
                @Apertura_B500,
                @Apertura_B100,
                @Apertura_B50,
                @Apertura_B10,
                @Cierre_B1000,
                @Cierre_B2000,
                @Cierre_B5000,
                @Cierre_B10000,
                @Cierre_B20000,
                @Cierre_B500,
                @Cierre_B100,
                @Cierre_B50,
                @Cierre_B10,
                @Apertura_Conteo_Registrado,
                @Cierre_Conteo_Registrado
            );
        END

        SET @FechaActual = DATEADD(day, 1, @FechaActual);
    END
END
GO
