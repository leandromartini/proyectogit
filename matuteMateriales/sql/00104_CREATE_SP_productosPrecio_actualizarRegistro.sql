USE [MatuteMateriales]
GO
/****** Object:  StoredProcedure [dbo].[productosPrecio_actualizarRegistro]    Script Date: 7/5/2019 18:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Leandro Martini Lacrouts>
-- Create date: <3/05/2019 19:13>
-- Description:	<Este SP agrega o actuliza la tabla productosPrecio>
-- =============================================
CREATE PROCEDURE [dbo].[productosPrecio_actualizarRegistro]--24,1000,-1
 @id_prod int, 
 @precio decimal(8,2), 
 @precioiva decimal(8,2) 	
AS
BEGIN 
	if not exists (select * from [dbo].[productosPrecio] where id_prod = @id_prod)
	begin
	INSERT INTO [dbo].[productosPrecio] ([id_prod], [precio], [precioIVA])
    VALUES(@id_prod, @precio, @precioiva)
	end
else
	begin
	UPDATE [dbo].[productosPrecio] SET [precio] = @precio , [precioIVA] = @precioIVA
	where id_prod = @id_prod	
	end
	SELECT Convert(varchar,getdate(), 3)
END 


