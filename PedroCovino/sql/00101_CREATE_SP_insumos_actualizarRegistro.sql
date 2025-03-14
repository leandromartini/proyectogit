USE [PedroCovino]
GO
/****** Object:  StoredProcedure [dbo].[insumos_actualizarRegistro]    Script Date: 7/2/2021 19:22:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Leandro Martini Lacrouts>
-- Create date: <30/04/2019 19:13>
-- Description:	<Este SP agrega o actuliza la tabla productos>
-- =============================================
CREATE PROCEDURE [dbo].[insumos_actualizarRegistro]
 @codigo int, 
 @descrip varchar(150)
AS
BEGIN 
	if not exists (select * from [dbo].[insumos] where codigo = @codigo)
	begin
	INSERT INTO [dbo].[insumos] ([codigo], [descrip])
    VALUES(@codigo, @descrip)
	select @codigo
	end
else
	UPDATE [dbo].[insumos] SET 	[descrip] = @descrip
	WHERE  [codigo] = @codigo
	select @codigo
END 

