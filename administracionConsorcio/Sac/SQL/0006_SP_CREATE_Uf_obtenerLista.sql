USE [SAR]
GO

/****** Object:  StoredProcedure [dbo].[Uf_obtenerLista]    Script Date: 28/02/2019 21:47:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Uf_obtenerLista] --1,-1,-1

 @id_uf int = -1
	        
as

select * from UF 

GO


