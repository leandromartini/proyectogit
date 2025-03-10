USE [PedroCovino]
GO
/****** Object:  StoredProcedure [dbo].[insumosPrecios_actualizarRegistro]    Script Date: 3/2/2021 14:43:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Leandro Martini Lacrouts>
-- Create date: <30/04/2019 19:13>
-- Description:	<Este SP agrega o actuliza la tabla productos>
-- =============================================
CREATE PROCEDURE [dbo].[insumosPrecios_actualizarRegistro]-- 803,	390.45,	472.00,	662.00
 @codigo int, 
 @preciosiva decimal (8,2),
 @preciociva decimal (8,2),
 @ventapublico decimal (8,2)
AS
BEGIN 
	if not exists (select * from [dbo].[insumosPrecios] where codigo = @codigo)
	begin
	INSERT INTO [dbo].[insumosPrecios] ([codigo],[preciosiva],[preciociva],[ventapublico])
    VALUES(@codigo, @preciosiva,@preciociva ,@ventapublico)
	end
else
	UPDATE [dbo].[insumosPrecios]   SET   [preciosiva] =  @preciosiva    ,[preciociva] =  @preciociva     ,[ventapublico] = @ventapublico
    WHERE codigo = @codigo
	select idPrecio from [dbo].[insumosPrecios] where codigo = @codigo
END 
