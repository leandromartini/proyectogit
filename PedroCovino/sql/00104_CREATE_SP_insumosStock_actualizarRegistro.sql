USE [PedroCovino]
GO
/****** Object:  StoredProcedure [dbo].[insumos_obtenerLista]    Script Date: 9/2/2021 10:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Leandro Martini Lacrouts>
-- Create date: <30/04/2019 19:13>
-- Description:	<Este SP obtiene la lista de insumosProveedores>
-- =============================================
CREATE PROCEDURE [dbo].[insumosProveedores_obtenerLista]--1
@idProv as int = -1

AS
DECLARE @sOpe as varchar(7)
DECLARE @sWhere as varchar(128)
DECLARE @sQuery as varchar(1284)

BEGIN
SELECT @sWhere = ' WHERE '
SELECT @sOpe = ' '
SELECT @sQuery = ' '

	if (not @idProv = -1) begin
	select @sWhere = @sWhere + @sOpe +  'idProv  = ' + CONVERT(varchar,@idProv ) 
	select @sOpe = ' AND ' 
	end

	if @sWhere = ' WHERE '
	begin
	set @sWhere = ''
	end
	set @sQuery = 'select * from insumosProveedores '
	+ @sWhere
	execute(@sQuery)

END




