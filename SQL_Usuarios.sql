CREATE OR ALTER PROCEDURE dbo.SP_RESTABLECE_PASSWORD_USUARIO
    @IdAdministrador varchar(10),
    @IdUsuario varchar(10),
    @NuevaContrasena varchar(50)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (
        SELECT 1
        FROM dbo.VENDEDOR
        WHERE IdUsuario = @IdAdministrador
          AND IdPerfil = 1
    )
    BEGIN
        SELECT -1 AS Resultado;
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM dbo.VENDEDOR WHERE IdUsuario = @IdUsuario)
    BEGIN
        SELECT -2 AS Resultado;
        RETURN;
    END

    UPDATE dbo.VENDEDOR
    SET Contrasena = HASHBYTES('SHA2_256', @NuevaContrasena)
    WHERE IdUsuario = @IdUsuario;

    SELECT 0 AS Resultado;
END
