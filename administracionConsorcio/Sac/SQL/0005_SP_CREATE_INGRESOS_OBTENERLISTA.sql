USE [Ceba]
GO
/****** Object:  StoredProcedure [dbo].[persona_actualizarRegistro]    Script Date: 20/02/2019 19:19:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ingresos_obtenerLista]

 @id_uf int = -1,
 @mes int = -1,
 @anio int = -1
	        
AS

DECLARE @sOpe as varchar(7)
DECLARE @sWhere as varchar(128)

BEGIN 

SELECT @sWhere = ' WHERE '
SELECT @sOpe = ' '


	if (not @id_uf = -1) begin
	select @sWhere = @sWhere + @sOpe +  'id_uf  = ' + CONVERT(varchar,@id_uf ) 
	select @sOpe = ' AND ' 
	end

	if (not @id_uf = -1) begin
	select @sWhere = @sWhere + @sOpe + 'anio  = ' + CONVERT(varchar,@anio ) 
	select @sOpe = ' AND ' 
	end

	if (not @id_uf = -1) begin
	select @sWhere = @sWhere + @sOpe + 'mes  = ' + CONVERT(varchar,@mes ) 
	select @sOpe = ' AND ' 
	end

	if @sWhere = ' WHERE '
	@sWhere = ''

	select dpto,coef,mes,anio,expMes,expExtra,mantEdif,subTotal,redondeo,total from ingresos i
	left join uf on (i.id_uf = uf.id_uf)
	+ @sWhere

END 

