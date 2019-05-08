USE MatuteMateriales
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Leandro Martini Lacrouts>
-- Create date: <30/04/2019 19:13>
-- Description:	<Este SP agrega o actuliza la tabla productos>
-- =============================================
CREATE PROCEDURE [dbo].[productos_actualizarRegistro]
 @id_prod int, 
 @nombre varchar(50), 
 @descrip varchar(150), 
 @unidad varchar(9) 	
AS
BEGIN 
	if not exists (select * from [dbo].[productos] where id_prod = @id_prod)
	INSERT INTO [dbo].[productos] ([nombre], [descrip], [unidad])
     VALUES(@nombre, @descrip, @unidad)
else
	UPDATE [dbo].[productos] SET [nombre] = @nombre , [descrip] = @descrip
	where id_prod = @id_prod 
END 
GO


