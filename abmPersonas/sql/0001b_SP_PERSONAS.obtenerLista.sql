use pruebas
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[persona_obtenerLista]-- 11,'Joaquin','Hernandez','04/12/1989',9

AS
BEGIN 
	select p.*,l.descrip from persona  p
	join localidades l on l.cod_ent = p.ciudad
 END 
