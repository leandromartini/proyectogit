USE [pruebas]
GO

/****** Object:  StoredProcedure [dbo].[pagos_actualizarRegistro]    Script Date: 31/5/2018 13:58:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[pagos_actualizarRegistro] --2,1,'302.50','01/06/2018'

  @idusuario int, 
  @idPago as int,
  @tpoPago as smallint, 
  @importe as decimal(9,2),
  @fecPago as date

AS
BEGIN 
	 INSERT INTO [dbo].[pagos]([idusuario],[idPago],[tpoPago] ,[importe] ,[fecPago])
     VALUES  (@idusuario, @idPago,  @tpoPago,   @importe ,  @fecPago)
END 
GO


