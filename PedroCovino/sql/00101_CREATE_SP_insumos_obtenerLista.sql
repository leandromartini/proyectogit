USE [PedroCovino]
GO
/****** Object:  StoredProcedure [dbo].[insumos_obtenerLista]    Script Date: 01/02/2021 19:40:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Leandro Martini Lacrouts>
-- Create date: <30/04/2019 19:13>
-- Description:	<Este SP obtiene la lista de productos>
-- =============================================
CREATE PROCEDURE [dbo].[insumos_obtenerLista]--1717
@codigo as int

AS
DECLARE @sOpe as varchar(7)
DECLARE @sWhere as varchar(128)
DECLARE @sQuery as varchar(1284)

BEGIN
SELECT @sWhere = ' WHERE '
SELECT @sOpe = ' '
SELECT @sQuery = ' '

	if (not @codigo = -1) begin
	select @sWhere = @sWhere + @sOpe +  'i.codigo  = ' + CONVERT(varchar,@codigo ) 
	select @sOpe = ' AND ' 
	end

	if @sWhere = ' WHERE '
	begin
	set @sWhere = ''
	end
	set @sQuery = 'select i.codigo,i.descrip from [insumos] i '
	+ @sWhere
	execute(@sQuery)

END

