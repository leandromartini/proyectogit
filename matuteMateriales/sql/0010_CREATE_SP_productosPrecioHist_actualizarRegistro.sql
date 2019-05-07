USE [MatuteMateriales]
GO
/****** Object:  StoredProcedure [dbo].[productosPrecio_actualizarRegistro]    Script Date: 7/5/2019 17:12:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Leandro Martini Lacrouts>
-- Create date: <3/05/2019 19:13>
-- Description:	<Este SP agrega o actuliza la tabla productosPrecio>
-- =============================================
CREATE PROCEDURE [dbo].[productosPrecioHist_actualizarRegistro]
 @id_prod smallint, 
 @precio decimal(8,2), 
 @precioiva decimal(8,2),
 @fecAct date 	
AS
BEGIN 	
	INSERT INTO [dbo].[productosPrecioHist] ([id_prod], [precio], [precioIVA],[fecAct])
    VALUES(@id_prod, @precio, @precioiva,@fecAct)
END 