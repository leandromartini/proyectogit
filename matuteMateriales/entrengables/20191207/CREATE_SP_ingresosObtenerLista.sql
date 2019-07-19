USE [MatuteMateriales]
GO
/****** Object:  StoredProcedure [dbo].[egresos_ObtenerLista]    Script Date: 12/07/2019 08:57:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Leandro Martini Lacrouts>
-- Create date: <30/04/2019 19:13>
-- Description:	<Este SP obtiene egresos>
-- =============================================
CREATE PROCEDURE [dbo].[ingresos_ObtenerLista]--1, '2019-05-01' , '2019-06-28'
 @id_con as int, 
 @fecDesde as Datetime = '1900-01-01',
 @fecHasta as Datetime = '1900-01-01'

AS
BEGIN 

set nocount on
DECLARE @sWhere as varchar(512)
DECLARE @sOpe as varchar(7)
DECLARE @sComando as varchar(3072)

BEGIN	
	SET NOCOUNT ON;
	SELECT @sOpe = ' '
	SELECT @sWhere = ' WHERE '

		IF NOT (@id_con = -1) BEGIN
		SELECT @sWhere = @sWhere + @sOpe + 'i.id_con = ' + CONVERT(varchar,@id_con) 
		SELECT @sOpe = ' AND ' 
	END

		IF NOT (@fecDesde IS NULL OR @fecDesde = '1900-01-01')
	BEGIN
		SELECT @sWhere = @sWhere + @sOpe + ' i.fec between '
		 + '''' + CONVERT(varchar, @fecDesde , 102) + '''' + ' and ' + '''' + CONVERT(varchar, @fecHasta , 102) + ''''
		SELECT @sOpe = ' AND ' 
	END


	
	IF @sWhere = ' WHERE '

		select ptp.fec,ptp.tipoTran,p.nombre as concepto,id_con,precio,cant,p.unidad from [ingresos] i
		left join [pagosTpoPago] ptp  on (i.id_ingreso = ptp.id_tran) and tipoTran = 'I' 
		left join [productos] p  on (p.id_prod = i.id_con) 			
	ELSE BEGIN
	
		SELECT @sComando = '
		select ptp.fec,ptp.tipoTran,p.nombre as concepto,id_con,precio,cant,p.unidad from [ingresos] i
		left join [pagosTpoPago] ptp  on (i.id_ingreso = ptp.id_tran) and tipoTran = ''I''
		left join [productos] p  on (p.id_prod = i.id_con)  ' + @sWhere	
		--group by IdOferta'
		--SELECT @sComando = @sComando 
		
		EXECUTE (@sComando)
		--print (@sComando)
	END
	END
	END
