USE [MatuteMateriales]
GO
/****** Object:  StoredProcedure [dbo].[egresos_actualizarRegistro]    Script Date: 30/05/2019 13:51:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Leandro Martini Lacrouts>
-- Create date: <30/04/2019 19:13>
-- Description:	<Este SP agrega o actuliza la tabla ingresos>
-- =============================================
CREATE PROCEDURE [dbo].[ingresos_actualizarRegistro]
 @id_con int, 
 @precio decimal(8,2),
 @cant decimal(10,2),
 @total decimal(10,2),
 @fec date
AS
BEGIN 
	INSERT INTO [dbo].[ingresos]( [id_con],[precio], [cant],[total],[fec]) VALUES(@id_con, @precio, @cant,@total,@fec)
	select @@IDENTITY
END 
