USE [MatuteMateriales]
GO
/****** Object:  StoredProcedure [dbo].[errores_actualizarRegistro]    Script Date: 10/05/2019 15:14:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Leandro Martini Lacrouts>
-- Create date: <30/04/2019 19:13>
-- Description:	<Este SP agrega o actuliza la tabla productos>
-- =============================================
CREATE PROCEDURE [dbo].[pagosTpoPago_actualizarRegistro]
 @id_tran int, 
 @formaPago varchar(20),
 @tipoTran char(1),
 @fec date
AS
BEGIN 
	INSERT INTO [dbo].[pagosTpoPago]( [id_tran], [formaPago],tipoTran, [fec]) VALUES(@id_tran,@formaPago,@tipoTran,@fec)
END 
