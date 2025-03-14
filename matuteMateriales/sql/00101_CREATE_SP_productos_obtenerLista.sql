USE [MatuteMateriales]
GO
/****** Object:  StoredProcedure [dbo].[productos_actualizarRegistro]    Script Date: 3/5/2019 20:37:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Leandro Martini Lacrouts>
-- Create date: <30/04/2019 19:13>
-- Description:	<Este SP obtiene la lista de productos>
-- =============================================
CREATE PROCEDURE [dbo].[productos_obtenerLista]--1
@id_prod as int

AS
DECLARE @sOpe as varchar(7)
DECLARE @sWhere as varchar(128)
DECLARE @sQuery as varchar(1284)

BEGIN
SELECT @sWhere = ' WHERE '
SELECT @sOpe = ' '
SELECT @sQuery = ' '

	if (not @id_prod = -1) begin
	select @sWhere = @sWhere + @sOpe +  'p.id_prod  = ' + CONVERT(varchar,@id_prod ) 
	select @sOpe = ' AND ' 
	end

	if @sWhere = ' WHERE '
	begin
	set @sWhere = ''
	end
	set @sQuery = 'select p.id_prod,p.nombre,p.descrip,p.unidad,pp.precio from productos p
				   left join productosPrecio as pp on (p.id_prod = pp.id_prod)'
	+ @sWhere
	execute(@sQuery)

END

