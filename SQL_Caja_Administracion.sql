-- Modelo adaptado a la estructura real de VENDEDOR

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO

IF EXISTS (SELECT 1 FROM sys.indexes WHERE name = 'UX_VENDEDOR_Cta_Caja_Activa' AND object_id = OBJECT_ID('dbo.VENDEDOR'))
    DROP INDEX UX_VENDEDOR_Cta_Caja_Activa ON dbo.VENDEDOR;
GO

IF EXISTS (
    SELECT 1
    FROM dbo.VENDEDOR
    WHERE Cta_Caja_Activa IS NOT NULL
    GROUP BY Cta_Caja_Activa
    HAVING COUNT(*) > 1
)
BEGIN
    RAISERROR('Existen cajas duplicadas en VENDEDOR. Limpie los datos antes de crear el indice.', 16, 1);
    RETURN;
END

CREATE UNIQUE INDEX UX_VENDEDOR_Cta_Caja_Activa
ON dbo.VENDEDOR (Cta_Caja_Activa)
WHERE Cta_Caja_Activa IS NOT NULL;
GO

IF COL_LENGTH('dbo.VENDEDOR', 'EsCajero') IS NULL
BEGIN
    ALTER TABLE dbo.VENDEDOR ADD EsCajero BIT NOT NULL CONSTRAINT DF_VENDEDOR_EsCajero DEFAULT (0);
END
GO

IF OBJECT_ID('dbo.VendedorCajaDiaria', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.VendedorCajaDiaria (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        IdVendedor INT NOT NULL,
        IdUsuario VARCHAR(10) NOT NULL,
        Cta_Caja_Activa VARCHAR(7) NOT NULL,
        FechaTrabajo DATE NOT NULL CONSTRAINT DF_VendedorCajaDiaria_FechaTrabajo DEFAULT (CAST(GETDATE() AS DATE)),
        Estado VARCHAR(10) NOT NULL CONSTRAINT DF_VendedorCajaDiaria_Estado DEFAULT ('ACTIVA'),
        FechaHoraAsignacion DATETIME NOT NULL CONSTRAINT DF_VendedorCajaDiaria_FechaHoraAsignacion DEFAULT (GETDATE()),
        FechaHoraLiberacion DATETIME NULL,
        UsuarioLibera VARCHAR(10) NULL,
        Motivo VARCHAR(250) NULL
    );
END
GO

IF EXISTS (SELECT 1 FROM sys.key_constraints WHERE name = 'UQ_VendedorCajaDiaria_UsuarioDia' AND parent_object_id = OBJECT_ID('dbo.VendedorCajaDiaria'))
    ALTER TABLE dbo.VendedorCajaDiaria DROP CONSTRAINT UQ_VendedorCajaDiaria_UsuarioDia;
GO

IF EXISTS (SELECT 1 FROM sys.key_constraints WHERE name = 'UQ_VendedorCajaDiaria_CajaDia' AND parent_object_id = OBJECT_ID('dbo.VendedorCajaDiaria'))
    ALTER TABLE dbo.VendedorCajaDiaria DROP CONSTRAINT UQ_VendedorCajaDiaria_CajaDia;
GO

IF EXISTS (SELECT 1 FROM sys.indexes WHERE name = 'UX_VendedorCajaDiaria_UsuarioActiva' AND object_id = OBJECT_ID('dbo.VendedorCajaDiaria'))
    DROP INDEX UX_VendedorCajaDiaria_UsuarioActiva ON dbo.VendedorCajaDiaria;
GO

IF EXISTS (SELECT 1 FROM sys.indexes WHERE name = 'UX_VendedorCajaDiaria_CajaActiva' AND object_id = OBJECT_ID('dbo.VendedorCajaDiaria'))
    DROP INDEX UX_VendedorCajaDiaria_CajaActiva ON dbo.VendedorCajaDiaria;
GO

CREATE UNIQUE INDEX UX_VendedorCajaDiaria_UsuarioActiva
ON dbo.VendedorCajaDiaria (FechaTrabajo, IdUsuario)
WHERE Estado = 'ACTIVA';
GO

CREATE UNIQUE INDEX UX_VendedorCajaDiaria_CajaActiva
ON dbo.VendedorCajaDiaria (FechaTrabajo, Cta_Caja_Activa)
WHERE Estado = 'ACTIVA';
GO

IF OBJECT_ID('dbo.VendedorCajaHistorial', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.VendedorCajaHistorial (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        IdVendedor INT NOT NULL,
        IdUsuario VARCHAR(10) NOT NULL,
        Cta_Caja_Activa VARCHAR(7) NOT NULL,
        FechaTrabajo DATE NOT NULL,
        FechaHoraLiberacion DATETIME NOT NULL CONSTRAINT DF_VendedorCajaHistorial_FechaHoraLiberacion DEFAULT (GETDATE()),
        UsuarioLibera VARCHAR(10) NOT NULL,
        Motivo VARCHAR(250) NULL
    );
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_CONSULTA_CAJA_ACTIVA_USUARIO
    @IdUsuario VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT ISNULL(Cta_Caja_Activa, '') AS Cta_Caja_Activa
    FROM dbo.VENDEDOR
    WHERE IdUsuario = @IdUsuario;
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_LIBERA_CAJA_ACTIVA_USUARIO
    @IdUsuario VARCHAR(10),
    @Motivo VARCHAR(250) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;

        DECLARE @Hoy DATE = CAST(GETDATE() AS DATE);
        DECLARE @IdVendedor INT;
        DECLARE @Caja VARCHAR(7);

        SELECT @IdVendedor = IdVendedor,
               @Caja = Cta_Caja_Activa
        FROM dbo.VENDEDOR
        WHERE IdUsuario = @IdUsuario;

        IF (@Caja IS NULL OR LTRIM(RTRIM(@Caja)) = '')
        BEGIN
            SELECT TOP 1 @Caja = Cta_Caja_Activa
            FROM dbo.VendedorCajaDiaria
            WHERE IdUsuario = @IdUsuario
              AND FechaTrabajo = @Hoy
            ORDER BY Id DESC;
        END

        IF @Caja IS NULL OR LTRIM(RTRIM(@Caja)) = ''
        BEGIN
            ROLLBACK TRAN;
            SELECT 0 AS Resultado, 'No existe caja activa para liberar.' AS Mensaje;
            RETURN;
        END

        INSERT INTO dbo.VendedorCajaHistorial (
            IdVendedor, IdUsuario, Cta_Caja_Activa, FechaTrabajo, UsuarioLibera, Motivo
        )
        VALUES (
            @IdVendedor, @IdUsuario, @Caja, @Hoy, @IdUsuario, @Motivo
        );

        UPDATE dbo.VendedorCajaDiaria
        SET Estado = 'LIBERADA',
            FechaHoraLiberacion = GETDATE(),
            UsuarioLibera = @IdUsuario,
            Motivo = ISNULL(@Motivo, Motivo)
        WHERE FechaTrabajo = @Hoy
          AND IdUsuario = @IdUsuario
          AND Estado = 'ACTIVA';

        UPDATE dbo.VENDEDOR
        SET Cta_Caja_Activa = NULL
        WHERE IdUsuario = @IdUsuario;

        COMMIT TRAN;
        SELECT 1 AS Resultado, 'Caja liberada correctamente.' AS Mensaje;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRAN;
        SELECT 0 AS Resultado, ERROR_MESSAGE() AS Mensaje;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE dbo.SP_ACTUALIZA_CAJA_ACTIVA_USUARIO
    @IdUsuario VARCHAR(10),
    @CtaCaja VARCHAR(7),
    @Motivo VARCHAR(250) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;

        DECLARE @Hoy DATE = CAST(GETDATE() AS DATE);
        DECLARE @IdVendedor INT;

        IF EXISTS (
            SELECT 1
            FROM dbo.VendedorCajaDiaria
            WHERE FechaTrabajo = @Hoy
              AND IdUsuario = @IdUsuario
              AND Estado = 'ACTIVA'
        )
        BEGIN
            UPDATE dbo.VendedorCajaDiaria
            SET Estado = 'LIBERADA',
                FechaHoraLiberacion = GETDATE(),
                UsuarioLibera = @IdUsuario,
                Motivo = ISNULL(@Motivo, Motivo)
            WHERE FechaTrabajo = @Hoy
              AND IdUsuario = @IdUsuario
              AND Estado = 'ACTIVA';
        END

        SELECT @IdVendedor = IdVendedor
        FROM dbo.VENDEDOR
        WHERE IdUsuario = @IdUsuario;

        IF EXISTS (
            SELECT 1
            FROM dbo.VENDEDOR
            WHERE Cta_Caja_Activa = @CtaCaja
              AND IdUsuario <> @IdUsuario
              AND ISNULL(Cta_Caja_Activa, '') <> ''
        )
        BEGIN
            ROLLBACK TRAN;
            SELECT 0 AS Resultado, 'La caja ya está asignada actualmente a otro usuario.' AS Mensaje;
            RETURN;
        END

        IF EXISTS (
            SELECT 1
            FROM dbo.VendedorCajaDiaria
            WHERE FechaTrabajo = @Hoy
              AND Cta_Caja_Activa = @CtaCaja
              AND Estado = 'ACTIVA'
              AND IdUsuario <> @IdUsuario
        )
        BEGIN
            ROLLBACK TRAN;
            SELECT 0 AS Resultado, 'La caja ya está asignada hoy a otro usuario.' AS Mensaje;
            RETURN;
        END

        INSERT INTO dbo.VendedorCajaDiaria (
            IdVendedor, IdUsuario, Cta_Caja_Activa, FechaTrabajo, Estado, FechaHoraAsignacion, Motivo
        )
        VALUES (
            @IdVendedor, @IdUsuario, @CtaCaja, @Hoy, 'ACTIVA', GETDATE(), @Motivo
        );

        UPDATE dbo.VENDEDOR
        SET Cta_Caja_Activa = @CtaCaja
        WHERE IdUsuario = @IdUsuario;

        COMMIT TRAN;
        SELECT 1 AS Resultado, 'Caja asignada correctamente.' AS Mensaje;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRAN;
        SELECT 0 AS Resultado, ERROR_MESSAGE() AS Mensaje;
    END CATCH
END
GO
