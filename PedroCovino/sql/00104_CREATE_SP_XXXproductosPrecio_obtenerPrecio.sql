USE PedroCovino
GO
-- =============================================
-- Author:		<Author,,Leandro Martini Lacrouts>
-- Create date: <3/05/2019 19:13>
-- Description:	<Este SP agrega o actuliza la tabla productosPrecio>
-- =============================================
CREATE PROCEDURE [dbo].[productosPrecio_obtenerPrecio]
 @id_prod int
AS
BEGIN 

select precio from productosPrecio where id_prod = @id_prod

END 

