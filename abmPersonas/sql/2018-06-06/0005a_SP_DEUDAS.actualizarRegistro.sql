USE [pruebas]
GO
/****** Object:  StoredProcedure [dbo].[deudas_actualizarRegistro]    Script Date: 06/06/2018 17:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[deudas_actualizarRegistro] --1005,2,'234.50','06/06/2018'

  @idusuario int, 
  @tpodeuda as smallint,
  @importe as decimal(9,2), 
  @fecEmision as date

AS
BEGIN 
if not exists (select * from deudas where idusuario = @idusuario and tpodeuda = @tpodeuda )
	INSERT INTO [dbo].[deudas]([idusuario],[tpodeuda],[importe],[fecEmision])
     VALUES  ( @idusuario, @tpodeuda, @importe,  @fecEmision )
else
	UPDATE [dbo].[deudas] SET [importe] = @importe,[fecEmision] = @fecEmision where idusuario = @idusuario and tpodeuda = @tpodeuda
   
end
