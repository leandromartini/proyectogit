USE [MatuteMateriales]
GO
/****** Object:  StoredProcedure [dbo].[productosCantidad_actualizarRegistro]    Script Date: 7/5/2019 17:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Leandro Martini Lacrouts>
-- Create date: <3/05/2019 19:13>
-- Description:	<Este SP agrega o actuliza la tabla productosPrecio>
-- =============================================
CREATE PROCEDURE [dbo].[productosCantidad_actualizarRegistro]
 @id_prod int, 
 @cant decimal(8,2)
AS
BEGIN 
	if not exists (select * from [dbo].[productosCantidad] where id_prod = @id_prod)
	INSERT INTO [dbo].[productosCantidad] ([id_prod], [cant])
     VALUES(@id_prod, @cant)
else
	UPDATE [dbo].[productosCantidad] SET [cant] = @cant 
	where id_prod = @id_prod 
END 
