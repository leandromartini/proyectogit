GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[persona_EliminarRegistro]--27126-- 11,'Joaquin','Hernandez','04/12/1989',9
 @idusuario int
AS
BEGIN 
	 delete from persona where idusuario = @idusuario
 END 
