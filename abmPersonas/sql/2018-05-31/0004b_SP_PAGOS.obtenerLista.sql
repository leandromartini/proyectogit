USE [pruebas]
GO
/****** Object:  StoredProcedure [dbo].[persona_obtenerLista]    Script Date: 31/5/2018 14:15:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Leandro>
-- Create date: <Create 31/05/2018,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[pagos_obtenerLista]--2
@idusuario as int
AS
BEGIN 
	if @idusuario = '' 
	select * from pagos
	else
	select * from pagos where idusuario = @idusuario
	
 END 
