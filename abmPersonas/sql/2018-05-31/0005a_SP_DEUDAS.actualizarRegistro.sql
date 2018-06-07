USE [pruebas]
GO

/****** Object:  StoredProcedure [dbo].[deudas_actualizarRegistro]    Script Date: 31/5/2018 13:59:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[deudas_actualizarRegistro] --2,1,'302.50','01/06/2018'

  @idusuario int, 
  @tpodeuda as smallint,
  @importe as decimal(9,2), 
  @fecEmision as date

AS
BEGIN 
	INSERT INTO [dbo].[deudas]([idusuario],[tpodeuda],[importe],[fecEmision])
     VALUES  ( @idusuario, @tpodeuda, @importe,  @fecEmision )
 END 
GO


