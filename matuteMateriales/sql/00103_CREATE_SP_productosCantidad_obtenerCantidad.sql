USE [MatuteMateriales]
GO
/****** Object:  StoredProcedure [dbo].[productosCantidad_actualizarRegistro]    Script Date: 7/5/2019 19:15:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Leandro Martini Lacrouts>
-- Create date: <3/05/2019 19:13>
-- Description:	<Este SP agrega o actuliza la tabla productosPrecio>
-- =============================================
CREATE PROCEDURE [dbo].[productosCantidad_obtenerCantidad]
 @id_prod int
AS
BEGIN 
	select cant from [dbo].[productosCantidad] where id_prod = @id_prod

END 
