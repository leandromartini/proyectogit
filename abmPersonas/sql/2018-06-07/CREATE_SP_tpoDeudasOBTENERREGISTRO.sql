USE [pruebas]
GO
/****** Object:  StoredProcedure [dbo].[deudas_obtenerTposDeudas]    Script Date: 07/06/2018 18:34:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[deudas_obtenerTposDeudas]
	
AS
BEGIN
	SELECT * FROM tpo_deudas
END
