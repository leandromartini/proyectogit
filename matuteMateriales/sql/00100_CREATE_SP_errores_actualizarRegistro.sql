USE [MatuteMateriales]
GO
/****** Object:  StoredProcedure [dbo].[productos_actualizarRegistro]    Script Date: 09/05/2019 13:47:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Leandro Martini Lacrouts>
-- Create date: <30/04/2019 19:13>
-- Description:	<Este SP agrega o actuliza la tabla productos>
-- =============================================
CREATE PROCEDURE [dbo].[errores_actualizarRegistro]
 @id_error int, 
 @mensaje varchar(2048),
 @namefrm varchar(100)
AS
BEGIN 
	INSERT INTO [dbo].[errores]([mensaje],[namefrm],[fec]) VALUES(@mensaje,@namefrm,GETDATE())
END 
