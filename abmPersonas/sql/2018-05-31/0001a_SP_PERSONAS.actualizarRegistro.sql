USE [pruebas]
GO
/****** Object:  StoredProcedure [dbo].[persona_actualizarRegistro]    Script Date: 20/04/2018 16:25:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[persona_actualizarRegistro]-- 11,'Joaquin','Hernandez','04/12/1989',9

  @idusuario int, 
  @nombre as varchar(30),
  @apellido as varchar(30), 
  @fecNac as varchar(30),
  @ciudad int
AS
BEGIN 
	if @idusuario = -1
	INSERT INTO [dbo].[persona]([nombre],[apellido],[fecNac],[ciudad])
    VALUES (@nombre,@apellido,@fecNac,@ciudad)
	else
   UPDATE [dbo].[persona]
   SET [nombre] = @nombre
      ,[apellido] = @apellido
      ,[fecNac] = @fecNac
      ,[ciudad] = @ciudad
 WHERE idusuario = @idusuario
 END 

