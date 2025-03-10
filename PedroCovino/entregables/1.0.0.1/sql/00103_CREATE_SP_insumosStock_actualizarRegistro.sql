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
CREATE PROCEDURE [dbo].[insumosStock_actualizarRegistro]
 @codigo int, 
 @stock int,
 @stockMin int,
 @stockMax int,
 @fecAct datetime
AS
BEGIN 
	if not exists (select * from [dbo].[insumosStock] where codigo = @codigo)
	begin
	INSERT INTO [dbo].[insumosStock]([codigo],[stock],[stockMin],[stockMax],[fecAct])
     VALUES ( @codigo , @stock , @stockMin , @stockMax , @fecAct )
	end
else
	UPDATE [dbo].[insumosStock]  SET [stock] = @stock  ,[stockMin] = @stockMin  ,[stockMax] = @stockMax  ,[fecAct] = @fecAct
	WHERE codigo = @codigo
	select idStock from [dbo].[insumosStock] where codigo = @codigo
END 
