USE ddvivero
GO

ALTER PROCEDURE [dbo].[NEWSP_CONSULTA_DOCVENTA]
    @IdVtaHead int
AS
BEGIN
    SELECT vh.IdvtaHead,
           vh.IdLocal,
           vh.IdVendedor,
           vh.IDCLIENTE,
           vh.VALOR_DOC,
           vh.FECHA_DOC,
           vh.NUM_DOC,
           vh.TIPO_DOC,
           td.Nombre TipoDocumento,
           td.TipoDoc,
           vh.TipoDocumentoId,
           vh.COMENTARIO,
           vh.TOTAL_PAGO,
           ISNULL(vh.DESCUENTO, 0) DescuentoComercial,
           ISNULL(cli.RUT, '') Rut,
           FORMAT(vh.FECHA_VCTO, 'dd/MM/yyyy') Fecha_Vcto,
           vh.ESTADO,
           ISNULL(cli.RUT, '') RutCliente,
           ISNULL(vh.Id_ClienteFactura, 0) RutFactura,
           vend.NOMBRE,
           RTRIM(cli.Nombre) + ' ' + RTRIM(cli.APELLIDO) Cliente,
           RTRIM(ISNULL(clif.Nombre, '')) + ' ' + RTRIM(ISNULL(clif.APELLIDO, '')) ClienteFactura,
           ISNULL(vh.IdUsuario, '') Usuario,
           vh.NumDocSII,
           vh.TipoDocSII,
           vd.CANTIDAD,
           vd.GLOSA,
           vd.IdFamilia,
           vd.IDGUIA,
           vd.IdInsumo,
           vd.IdVariedad,
           vd.IdVtaDet,
           vd.PRECIO_UNITARIO,
           vd.TOTAL_NETO,
           vd.Tipo_Venta,
           ISNULL(cli.Saldo_Abonos, 0) Saldo_Abonos,
           ISNULL(fam.DESCRIP, '') Familia,
           ISNULL(vari.Descripcion, '') Variedad,
           ISNULL(insu.Descripcion, '') Insumo
    FROM VENTA_HEADER vh
    JOIN Venta_Detalle vd ON vd.IdVtaHead = vh.IdvtaHead
    JOIN CLIENTE cli ON cli.IdCliente = vh.Idcliente
    LEFT OUTER JOIN CLIENTE clif ON clif.Idcliente = vh.Id_ClienteFactura
    JOIN VENDEDOR vend ON vend.IdVendedor = vh.IdVendedor
    LEFT OUTER JOIN Familia fam ON fam.IdFamilia = vd.IdFamilia
    LEFT OUTER JOIN TBL_Variedad vari ON vari.IdVariedad = vd.IdVariedad
    LEFT OUTER JOIN Insumo insu ON insu.IdInsumo = vd.IdInsumo
    JOIN [vivero].[TipoDocumento] td ON td.TipoDoc = vh.TIPO_DOC
    WHERE vh.IdVtaHead = @IdVtaHead
END
GO

ALTER PROCEDURE [dbo].[SP_Lectura_Det_Factura]
    @IdvtaHead int
AS
BEGIN
    SELECT a.Cantidad,
           Detalle = CASE
                         WHEN a.IdFamilia > 0 AND a.IdVariedad > 0 THEN RTRIM(c.Descrip) + ' ' + d.Descripcion
                         WHEN a.IdFamilia > 0 AND (a.IdVariedad = 0 OR a.IdVariedad IS NULL) THEN c.Descrip
                         WHEN a.IdFamilia = 0 AND a.IdVariedad > 0 THEN c.Descrip
                         WHEN a.IdInsumo IS NOT NULL THEN RTRIM(e.Descripcion) + ' - ' + a.Glosa
                     END,
           ROUND(a.TOTAL_NETO * 1.19 / a.Cantidad, 2) Precio,
           ROUND(a.TOTAL_NETO * 1.19, 0) Total,
           CASE WHEN a.IDGUIA > 0 THEN gl.Cant_Band_Retiro ELSE 0 END Bandejas
    FROM venta_detalle a
    LEFT OUTER JOIN familia c ON c.IdFamilia = a.IdFamilia
    LEFT OUTER JOIN TBL_VARIEDAD d ON d.IdVariedad = a.IdVariedad
    LEFT OUTER JOIN INSUMO e ON e.IdInsumo = a.IdInsumo
    LEFT OUTER JOIN GUIA_LOTE gl ON gl.IDGUIA = a.IDGUIA
    WHERE a.IdVtaHead = @IdvtaHead

    UNION ALL

    SELECT 1,
           'Compensación saldo a favor',
           -vh.DESCUENTO,
           -vh.DESCUENTO,
           0
    FROM VENTA_HEADER vh
    WHERE vh.IdVtaHead = @IdvtaHead
      AND ISNULL(vh.DESCUENTO, 0) > 0
END
GO
