/*
    Alinea la logica historica de compras/proveedores para incluir Boleta Exenta (BE)
    junto con Factura (FA) en consultas de pendientes, libro de compras y contabilizacion.
*/

ALTER PROCEDURE [dbo].[COMP_COMPRAS_PENDIENTES]
AS
BEGIN
    SET NOCOUNT ON;

    ;WITH CTE_PagosPagados AS
    (
        SELECT
            CP.IDCOMPRAS,
            SUM(ISNULL(CP.VALOR_DOC, 0)) AS Total_pagado
        FROM COMPRA_PAGOS CP
        WHERE ISNULL(CP.PAGADO, 0) = 1
        GROUP BY CP.IDCOMPRAS
    ),
    CTE_PagosPendientes AS
    (
        SELECT
            CP.IDCOMPRAS,
            CP.VALOR_DOC AS Valor_Cuota_Pendiente,
            CP.FECHA_VCTO AS Fecha_Vencimiento
        FROM COMPRA_PAGOS CP
        WHERE ISNULL(CP.PAGADO, 0) <> 1
    ),
    CTE_Resultados AS
    (
        SELECT
            A.IDCOMPRAS,
            A.Tipo_doc,
            A.Num_doc,
            CONVERT(varchar(10), A.fecha_doc, 103) AS Fecha,
            pro.NOMBRE AS Proveedor,
            A.Valor_doc AS Valor_Factura,
            ISNULL(PP.Total_pagado, 0) AS Total_pagado,
            A.Valor_doc - ISNULL(PP.Total_pagado, 0) AS Saldo,
            Pend.Valor_Cuota_Pendiente,
            CASE
                WHEN Pend.Fecha_Vencimiento IS NOT NULL
                    THEN CONVERT(varchar(10), Pend.Fecha_Vencimiento, 103)
                ELSE 'Pendiente'
            END AS Fecha_Vencimiento,
            CASE
                WHEN Pend.Fecha_Vencimiento IS NOT NULL
                     AND CONVERT(date, Pend.Fecha_Vencimiento) < CONVERT(date, GETDATE())
                    THEN 1
                ELSE 0
            END AS Vencida,
            Pend.Fecha_Vencimiento AS FechaOrden
        FROM Compra_Header A
        INNER JOIN Proveedor pro
            ON pro.RUT = A.RUT
        LEFT JOIN CTE_PagosPagados PP
            ON PP.IDCOMPRAS = A.IDCOMPRAS
        LEFT JOIN CTE_PagosPendientes Pend
            ON Pend.IDCOMPRAS = A.IDCOMPRAS
        WHERE A.Tipo_doc IN ('FA', 'BE')
          AND A.Valor_doc > ISNULL(PP.Total_pagado, 0)
    )
    SELECT
        Tipo_doc,
        Num_doc,
        Fecha,
        Proveedor,
        Saldo AS Valor_doc,
        Total_pagado,
        Saldo,
        Valor_Cuota_Pendiente,
        Fecha_Vencimiento,
        Vencida
    FROM CTE_Resultados
    ORDER BY
        Vencida DESC,
        CASE WHEN FechaOrden IS NULL THEN 1 ELSE 0 END,
        FechaOrden,
        Num_doc;
END
GO

ALTER PROCEDURE [dbo].[COMP_COMPRAS_PENDIENTES_SINDOC]
AS
BEGIN
    SET NOCOUNT ON;

    ;WITH CTE_PagosPagados AS
    (
        SELECT
            CP.IDCOMPRAS,
            SUM(ISNULL(CP.VALOR_DOC, 0)) AS Total_pagado
        FROM COMPRA_PAGOS CP
        WHERE ISNULL(CP.PAGADO, 0) = 1
        GROUP BY CP.IDCOMPRAS
    ),
    CTE_PagosPendientes AS
    (
        SELECT
            CP.IDCOMPRAS,
            CP.VALOR_DOC AS Valor_Cuota_Pendiente,
            CP.FECHA_VCTO AS Fecha_Vencimiento
        FROM COMPRA_PAGOS CP
        WHERE ISNULL(CP.PAGADO, 0) <> 1
    ),
    CTE_Resultados AS
    (
        SELECT
            A.IDCOMPRAS,
            A.Tipo_doc,
            A.Num_doc,
            CONVERT(varchar(10), A.fecha_doc, 103) AS Fecha,
            pro.NOMBRE AS Proveedor,
            A.Valor_doc AS Valor_Factura,
            ISNULL(PP.Total_pagado, 0) AS Total_pagado,
            A.Valor_doc - ISNULL(PP.Total_pagado, 0) AS Saldo,
            Pend.Valor_Cuota_Pendiente,
            CASE
                WHEN Pend.Fecha_Vencimiento IS NOT NULL
                    THEN CONVERT(varchar(10), Pend.Fecha_Vencimiento, 103)
                ELSE 'Pendiente'
            END AS Fecha_Vencimiento,
            CASE
                WHEN Pend.Fecha_Vencimiento IS NOT NULL
                     AND CONVERT(date, Pend.Fecha_Vencimiento) < CONVERT(date, GETDATE())
                    THEN 1
                ELSE 0
            END AS Vencida,
            Pend.Fecha_Vencimiento AS FechaOrden
        FROM Compra_Header A
        INNER JOIN Proveedor pro
            ON pro.RUT = A.RUT
        LEFT JOIN CTE_PagosPagados PP
            ON PP.IDCOMPRAS = A.IDCOMPRAS
        LEFT JOIN CTE_PagosPendientes Pend
            ON Pend.IDCOMPRAS = A.IDCOMPRAS
        WHERE A.Tipo_doc IN ('FA', 'BE')
          AND A.Valor_doc > ISNULL(PP.Total_pagado, 0)
    )
    SELECT
        Tipo_doc,
        Num_doc,
        Fecha,
        Proveedor,
        Saldo AS Valor_doc,
        Total_pagado,
        Saldo,
        Valor_Cuota_Pendiente,
        Fecha_Vencimiento,
        Vencida
    FROM CTE_Resultados
    ORDER BY
        Vencida DESC,
        CASE WHEN FechaOrden IS NULL THEN 1 ELSE 0 END,
        FechaOrden,
        Num_doc;
END
GO

ALTER PROCEDURE [dbo].[SP_CONSULTA_COMPRAS_PENDIENTES]
    @Fecha1 varchar(10),
    @Fecha2 varchar(10)
AS
BEGIN
    SELECT
        A.Tipo_doc,
        A.Num_doc,
        CONVERT(char, A.fecha_doc, 103) AS Fecha,
        B.NOMBRE AS Proveedor,
        A.Valor_doc,
        ISNULL(A.Total_pago, 0) AS Total_pago,
        A.Valor_doc - ISNULL(A.Total_pago, 0) AS Saldo
    FROM Compra_Header A
    INNER JOIN Proveedor B ON A.RUT = B.RUT
    WHERE A.Valor_doc > ISNULL(A.Total_pago, 0)
      AND A.Fecha_Doc BETWEEN @Fecha1 AND @Fecha2
      AND A.Tipo_doc IN ('FA', 'BE');
END
GO

ALTER PROCEDURE [dbo].[SP_CONTA_Contabiliza_Pagos_Proveedor]
AS
DECLARE
    @NUM_DOCPAGO nvarchar(15),
    @Num_doc_Pago nvarchar(15),
    @Glosa varchar(100),
    @FECHA_VCTO datetime,
    @Valor_Doc float,
    @Cta_Ctble varchar(7),
    @Cta_Ctble_A varchar(7),
    @Fecha_CONTA datetime,
    @Agno_Conta_Ini int,
    @Num_Compbte int,
    @IDPAGOS int,
    @Tipo_Doc varchar(2),
    @Num_doc int,
    @Fecha_Comp datetime,
    @Rut nvarchar(12),
    @Suma_Total_Haber float,
    @Suma_Total_Debe float,
    @Glosa_Pago varchar(100),
    @Contador_paso int,
    @Contador_Final int
BEGIN
    SET @Agno_Conta_Ini = (SELECT Valor_Param FROM SYS_INI WHERE Tipo_Param = 'CONTA_INI');

    DECLARE Cursor_Conta_Pagos CURSOR FOR
        SELECT
            b.IDPAGOS,
            a.Tipo_doc,
            a.Num_doc,
            b.Fecha_Registro,
            a.RUT,
            fp.Cta_Ctble,
            b.Valor_Doc
        FROM COMPRA_HEADER a
        JOIN COMPRA_PAGOS b ON b.IDCOMPRAS = a.IDCOMPRAS
        JOIN FORMAPAGO fp ON fp.IdFPago = b.IdFPago
        WHERE b.Estado_Conta = 0
          AND a.tipo_doc IN ('FA', 'BE')
          AND b.Pagado = 1
        ORDER BY 1;

    OPEN Cursor_Conta_Pagos;

    FETCH NEXT FROM Cursor_Conta_Pagos
    INTO @IDPAGOS, @Tipo_Doc, @Num_doc, @Fecha_Comp, @Rut, @Cta_Ctble, @Valor_Doc;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        INSERT INTO CONTA_Cmpbte_Head(
            Fecha_Cmpbte,
            Tipo_Cmpbte,
            Glosa_Cmpbte,
            Estado_Cmpbte,
            Tipo_Doc,
            Num_Doc)
        VALUES (
            @Fecha_Comp,
            'E',
            'PAGO DOCUMENTO:' + FORMAT(@Num_doc, '############'),
            0,
            @Tipo_Doc,
            @Num_doc);

        SET @Num_Compbte = @@IDENTITY;

        INSERT INTO CONTA_Cmpbte_Det(
            idCmpbte,
            Cta_Ctble,
            Fecha_Cmpbte,
            CodCCosto,
            Monto_Debe,
            Monto_Haber,
            Glosa)
        VALUES (
            @Num_Compbte,
            @Cta_Ctble,
            @Fecha_Comp,
            0,
            0,
            @Valor_Doc,
            'PAGO DOCUMENTO:' + CONVERT(char, @Num_doc));

        INSERT INTO CONTA_Cmpbte_Det(
            idCmpbte,
            Cta_Ctble,
            Fecha_Cmpbte,
            CodCCosto,
            Monto_Debe,
            Monto_Haber,
            Rut,
            Tipo_Doc,
            Num_Doc,
            Glosa)
        VALUES (
            @Num_Compbte,
            '2102001',
            @Fecha_Comp,
            0,
            @Valor_Doc,
            0,
            @Rut,
            @Tipo_Doc,
            @Num_doc,
            'PAGO DOCUMENTO');

        UPDATE CONTA_Cmpbte_Head
        SET Total_DEBE = (SELECT SUM(Monto_Debe) FROM CONTA_Cmpbte_Det WHERE idCmpbte = @Num_Compbte),
            Total_HABER = (SELECT SUM(Monto_Haber) FROM CONTA_Cmpbte_Det WHERE idCmpbte = @Num_Compbte)
        WHERE IdCmpbte = @Num_Compbte;

        UPDATE COMPRA_PAGOS
        SET Estado_Conta = -1,
            IdCmpbte_Pago = @Num_Compbte
        WHERE IDPAGOS = @IDPAGOS;

        FETCH NEXT FROM Cursor_Conta_Pagos
        INTO @IDPAGOS, @Tipo_Doc, @Num_doc, @Fecha_Comp, @Rut, @Cta_Ctble, @Valor_Doc;
    END

    CLOSE Cursor_Conta_Pagos;
    DEALLOCATE Cursor_Conta_Pagos;
END
GO

ALTER PROCEDURE [dbo].[SP_CONTA_ProcesoContabilizacion]
    @Mes int,
    @Agno int
AS
DECLARE
    @Cta_Ctble varchar(7),
    @Total_Debe float,
    @Total_Haber float,
    @Tipo_Doc varchar(2),
    @Num_doc numeric(18,0),
    @Fecha_Comp datetime,
    @Rut nvarchar(12),
    @Valor_Doc float,
    @Total_Pago float,
    @Num_Compbte int,
    @IDCOMPRAS numeric(18,0),
    @Imp_Especifico float,
    @Total_Impuesto float,
    @Saldo_Pendiente float,
    @Iva_Venta float,
    @Suma_Total_Haber float,
    @Suma_Total_Debe float,
    @IdvtaHead int,
    @Monto_Haber float,
    @Glosa_Pago varchar(100),
    @Fecha_Contable datetime
BEGIN
    SET @Fecha_Contable = '01/' + CONVERT(char, @Mes) + '/' + CONVERT(char, @Agno);

    DECLARE Cursor_Conta CURSOR FOR
        SELECT
            IDCOMPRAS,
            Tipo_doc,
            Num_doc,
            Fecha_Declaracion,
            RUT,
            VALOR_DOC,
            TOTAL_PAGO,
            Imp_Especifico,
            Total_Impuesto
        FROM COMPRA_HEADER
        WHERE YEAR(FECHA_DOC) = @Agno
          AND MONTH(Fecha_Doc) = @Mes
          AND Estado_CONTA = 0
          AND Tipo_doc IN ('FA', 'BE');

    OPEN Cursor_Conta;

    FETCH NEXT FROM Cursor_Conta
    INTO @IDCOMPRAS, @Tipo_Doc, @Num_doc, @Fecha_Comp, @Rut, @Valor_Doc, @Total_Pago, @Imp_Especifico, @Total_Impuesto;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @Saldo_Pendiente = 0;

        DELETE FROM CONTA_Cmpbte_Head
        WHERE Tipo_Doc = @Tipo_Doc
          AND Num_Doc = @Num_doc
          AND RUT = @Rut;

        INSERT INTO CONTA_Cmpbte_Head(
            Fecha_Cmpbte,
            Tipo_Cmpbte,
            Glosa_Cmpbte,
            Estado_Cmpbte,
            Tipo_Doc,
            Num_Doc,
            RUT)
        VALUES (
            @Fecha_Comp,
            'E',
            'COMPRAS-' + @Tipo_Doc + '-' + RTRIM(CONVERT(char, @Num_doc)),
            0,
            @Tipo_Doc,
            @Num_doc,
            @Rut);

        SET @Num_Compbte = @@IDENTITY;

        INSERT INTO CONTA_Cmpbte_Det(
            idCmpbte,
            Cta_Ctble,
            Fecha_Cmpbte,
            CodCCosto,
            Monto_Debe,
            Monto_Haber,
            Glosa,
            Tipo_Doc,
            Num_Doc,
            RUT)
        SELECT
            @Num_Compbte,
            a.Cta_Ctble,
            @Fecha_Comp,
            a.CodCCosto,
            ROUND(a.CANTIDAD * a.PRECIO_UNITARIO, 0),
            0,
            a.DESCRIP,
            @Tipo_Doc,
            @Num_doc,
            @Rut
        FROM Compra_Detalle a
        INNER JOIN CONTA_Plan_Cuenta b ON b.Cta_Ctble = a.Cta_Ctble
        WHERE IDCOMPRAS = @IDCOMPRAS;

        IF @Total_Impuesto > 0
        BEGIN
            INSERT INTO CONTA_Cmpbte_Det(
                idCmpbte,
                Cta_Ctble,
                Fecha_Cmpbte,
                CodCCosto,
                Monto_Debe,
                Monto_Haber,
                Rut,
                Tipo_Doc,
                Num_Doc,
                Glosa)
            VALUES (
                @Num_Compbte,
                '1301001',
                @Fecha_Comp,
                0,
                @Total_Impuesto,
                0,
                '',
                @Tipo_Doc,
                @Num_doc,
                'IVA Compras');
        END

        IF @Imp_Especifico > 0
        BEGIN
            INSERT INTO CONTA_Cmpbte_Det(
                idCmpbte,
                Cta_Ctble,
                Fecha_Cmpbte,
                CodCCosto,
                Monto_Debe,
                Monto_Haber,
                Rut,
                Tipo_Doc,
                Num_Doc,
                Glosa)
            VALUES (
                @Num_Compbte,
                '4105001',
                @Fecha_Comp,
                379,
                @Imp_Especifico,
                0,
                @Rut,
                @Tipo_Doc,
                @Num_doc,
                'Impuesto Especifico');
        END

        SET @Suma_Total_Haber = ISNULL((SELECT SUM(Monto_Haber) FROM CONTA_Cmpbte_Det WHERE idCmpbte = @Num_Compbte), 0);
        SET @Suma_Total_Debe = ISNULL((SELECT SUM(Monto_Debe) FROM CONTA_Cmpbte_Det WHERE idCmpbte = @Num_Compbte), 0);

        IF @Suma_Total_Debe - @Suma_Total_Haber > 0
            SET @Saldo_Pendiente = @Suma_Total_Debe - @Suma_Total_Haber;

        IF @Saldo_Pendiente > 0
        BEGIN
            INSERT INTO CONTA_Cmpbte_Det(
                idCmpbte,
                Cta_Ctble,
                Fecha_Cmpbte,
                CodCCosto,
                Monto_Debe,
                Monto_Haber,
                Rut,
                Tipo_Doc,
                Num_Doc,
                Glosa)
            VALUES (
                @Num_Compbte,
                '2102001',
                @Fecha_Comp,
                0,
                0,
                @Saldo_Pendiente,
                @Rut,
                @Tipo_Doc,
                @Num_doc,
                'SALDO PENDIENTE DOCUMENTO');
        END

        UPDATE CONTA_Cmpbte_Head
        SET Total_DEBE = (SELECT SUM(Monto_Debe) FROM CONTA_Cmpbte_Det WHERE idCmpbte = @Num_Compbte),
            Total_HABER = (SELECT SUM(Monto_Haber) FROM CONTA_Cmpbte_Det WHERE idCmpbte = @Num_Compbte)
        WHERE IdCmpbte = @Num_Compbte;

        FETCH NEXT FROM Cursor_Conta
        INTO @IDCOMPRAS, @Tipo_Doc, @Num_doc, @Fecha_Comp, @Rut, @Valor_Doc, @Total_Pago, @Imp_Especifico, @Total_Impuesto;
    END

    CLOSE Cursor_Conta;
    DEALLOCATE Cursor_Conta;

    DECLARE Cursor_Conta_Ingreso CURSOR FOR
        SELECT
            a.IdvtaHead,
            a.Tipo_doc,
            a.Num_doc,
            a.FECHA_DOC,
            b.RUT,
            a.VALOR_DOC,
            TOTAL_PAGO,
            a.Valor_Doc - a.Total_Neto
        FROM VENTA_HEADER a
        INNER JOIN CLIENTE b ON b.Idcliente = a.IdCliente
        WHERE YEAR(a.FECHA_DOC) = @Agno
          AND MONTH(a.Fecha_Doc) = @Mes
          AND a.ESTADO = 0
          AND (tipo_doc = 'FE' OR tipo_doc = 'BE' OR tipo_doc = 'BL')
          AND a.Estado_CONTA = 0;

    OPEN Cursor_Conta_Ingreso;

    FETCH NEXT FROM Cursor_Conta_Ingreso
    INTO @IdvtaHead, @Tipo_Doc, @Num_doc, @Fecha_Comp, @Rut, @Valor_Doc, @Total_Pago, @Iva_Venta;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        DELETE FROM CONTA_Cmpbte_Head
        WHERE Tipo_Doc = @Tipo_Doc
          AND Num_Doc = @Num_doc
          AND RUT = @Rut;

        INSERT INTO CONTA_Cmpbte_Head(
            Fecha_Cmpbte,
            Tipo_Cmpbte,
            Glosa_Cmpbte,
            Estado_Cmpbte,
            Tipo_Doc,
            Num_Doc,
            RUT)
        VALUES (
            @Fecha_Comp,
            'I',
            'VENTAS-' + @Tipo_Doc + '-' + RTRIM(CONVERT(char, @Num_doc)),
            0,
            @Tipo_Doc,
            @Num_doc,
            @Rut);

        SET @Num_Compbte = @@IDENTITY;

        INSERT INTO CONTA_Cmpbte_Det(
            idCmpbte,
            Cta_Ctble,
            Fecha_Cmpbte,
            CodCCosto,
            Monto_debe,
            Monto_Haber,
            Rut,
            Tipo_Doc,
            Num_Doc,
            Glosa)
        SELECT
            @Num_Compbte,
            b.Cta_Ctble_I,
            @Fecha_Comp,
            b.CodCCosto_I,
            0,
            a.TOTAL_NETO,
            @Rut,
            @Tipo_Doc,
            @Num_doc,
            'VENTA INSUMOS'
        FROM VENTA_DETALLE a
        INNER JOIN INSUMO b ON b.IdInsumo = a.IdInsumo
        WHERE a.IdvtaHead = @IdvtaHead
          AND a.IdInsumo > 0;

        INSERT INTO CONTA_Cmpbte_Det(
            idCmpbte,
            Cta_Ctble,
            Fecha_Cmpbte,
            CodCCosto,
            Monto_Debe,
            Monto_Haber,
            Rut,
            Tipo_Doc,
            Num_Doc,
            Glosa)
        SELECT
            @Num_Compbte,
            b.Cta_Ctble_VentaPlantas,
            @Fecha_Comp,
            101,
            0,
            a.TOTAL_NETO,
            @Rut,
            @Tipo_Doc,
            @Num_doc,
            'VENTA PLANTINES'
        FROM Venta_Detalle a
        INNER JOIN Familia b ON b.IdFamilia = a.IdFamilia
        WHERE a.IdvtaHead = @IdvtaHead
          AND a.IdFamilia > 0;

        IF @Iva_Venta > 0
        BEGIN
            INSERT INTO CONTA_Cmpbte_Det(
                idCmpbte,
                Cta_Ctble,
                Fecha_Cmpbte,
                Monto_Debe,
                Monto_Haber,
                Rut,
                Tipo_Doc,
                Num_Doc,
                Glosa)
            VALUES (
                @Num_Compbte,
                '2131001',
                @Fecha_Comp,
                0,
                @Iva_Venta,
                @Rut,
                @Tipo_Doc,
                @Num_doc,
                'IVA Venta');
        END

        SET @Suma_Total_Haber = (SELECT SUM(Monto_Haber) FROM CONTA_Cmpbte_Det WHERE idCmpbte = @Num_Compbte);
        SET @Suma_Total_Debe = ISNULL((SELECT SUM(Monto_Debe) FROM CONTA_Cmpbte_Det WHERE idCmpbte = @Num_Compbte), 0);

        IF @Suma_Total_Haber - @Suma_Total_Debe > 0
        BEGIN
            INSERT INTO CONTA_Cmpbte_Det(
                idCmpbte,
                Cta_Ctble,
                Fecha_Cmpbte,
                Monto_Debe,
                Monto_Haber,
                Rut,
                Tipo_Doc,
                Num_Doc,
                Glosa)
            VALUES (
                @Num_Compbte,
                '1201001',
                @Fecha_Comp,
                @Suma_Total_Haber - @Suma_Total_Debe,
                0,
                @Rut,
                @Tipo_Doc,
                @Num_doc,
                'Deuda Cliente');
        END

        UPDATE CONTA_Cmpbte_Head
        SET Total_DEBE = (SELECT SUM(Monto_Debe) FROM CONTA_Cmpbte_Det WHERE idCmpbte = @Num_Compbte),
            Total_HABER = (SELECT SUM(Monto_Haber) FROM CONTA_Cmpbte_Det WHERE idCmpbte = @Num_Compbte)
        WHERE IdCmpbte = @Num_Compbte;

        FETCH NEXT FROM Cursor_Conta_Ingreso
        INTO @IdvtaHead, @Tipo_Doc, @Num_doc, @Fecha_Comp, @Rut, @Valor_Doc, @Total_Pago, @Iva_Venta;
    END

    CLOSE Cursor_Conta_Ingreso;
    DEALLOCATE Cursor_Conta_Ingreso;

    UPDATE COMPRA_HEADER
    SET Estado_CONTA = -1
    WHERE YEAR(FECHA_DOC) = @Agno
      AND MONTH(Fecha_Doc) = @Mes
      AND Estado_CONTA = 0
      AND Tipo_doc IN ('FA', 'BE');

    UPDATE VENTA_HEADER
    SET Estado_CONTA = -1
    WHERE YEAR(FECHA_DOC) = @Agno
      AND MONTH(Fecha_Doc) = @Mes
      AND ESTADO = 0
      AND (tipo_doc = 'FE' OR tipo_doc = 'BE' OR tipo_doc = 'BL')
      AND Estado_CONTA = 0;
END
GO

ALTER PROCEDURE [dbo].[SP_LIBRO_COMPRA]
    @Fecha1 datetime,
    @Fecha2 datetime,
    @Proveedor varchar(50)
AS
BEGIN
    IF RTRIM(@Proveedor) = ''
        SELECT
            A.Tipo_Doc,
            A.Num_Doc,
            CONVERT(char, A.FECHA_DOC, 103) AS Fecha,
            B.Rut,
            B.Nombre,
            A.Total_Neto,
            A.Imp_Especifico,
            A.Total_Impuesto,
            A.Total_Neto + A.Imp_Especifico + A.Total_Impuesto,
            A.Tipo_Factura
        FROM COMPRA_HEADER A
        INNER JOIN PROVEEDOR B ON B.Rut = A.Rut
        WHERE CONVERT(char, A.Fecha_Declaracion, 112) >= CONVERT(char, @Fecha1, 112)
          AND CONVERT(char, A.Fecha_Declaracion, 112) <= CONVERT(char, @Fecha2, 112)
          AND TIPO_DOC IN ('FA', 'BE')
        ORDER BY CONVERT(char, A.FECHA_DOC, 112);
    ELSE
        SELECT
            A.Tipo_Doc,
            A.Num_Doc,
            CONVERT(char, A.FECHA_DOC, 103) AS Fecha,
            B.Rut,
            B.Nombre,
            A.Total_Neto,
            A.Imp_Especifico,
            A.Total_Impuesto,
            A.Total_Neto + A.Imp_Especifico + A.Total_Impuesto,
            A.Tipo_Factura
        FROM COMPRA_HEADER A
        INNER JOIN PROVEEDOR B ON B.Rut = A.Rut
        WHERE CONVERT(char, A.Fecha_Declaracion, 112) >= CONVERT(char, @Fecha1, 112)
          AND CONVERT(char, A.Fecha_Declaracion, 112) <= CONVERT(char, @Fecha2, 112)
          AND B.Nombre = @Proveedor
          AND TIPO_DOC IN ('FA', 'BE')
        ORDER BY CONVERT(char, A.FECHA_DOC, 112);
END
GO
