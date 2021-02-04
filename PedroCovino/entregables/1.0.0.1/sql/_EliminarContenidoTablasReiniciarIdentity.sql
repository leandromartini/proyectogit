use PedroCovino

delete from [dbo].[errores]
DBCC CHECKIDENT ([errores], RESEED,0)

delete from [dbo].[insumos]
DBCC CHECKIDENT ([insumos], RESEED,0)

delete from [dbo].[insumosPrecioHist]
DBCC CHECKIDENT ([insumosPrecioHist], RESEED,0)

delete from [dbo].[insumosPrecios]
DBCC CHECKIDENT ([insumosPrecios], RESEED,0)

delete from [dbo].[insumosStock]
DBCC CHECKIDENT ([insumosStock], RESEED,0)

--DROP table [dbo].[errores]
--DROP table [dbo].[insumos]
--DROP table [dbo].[insumosPrecioHist]
--DROP table [dbo].[insumosPrecios]
--DROP table [dbo].[insumosStock]
--DROP PROCEDURE [dbo].[errores_actualizarRegistro]
--DROP PROCEDURE [dbo].[insumos_obtenerLista]
--DROP PROCEDURE [dbo].[insumos_obtenerListaDetalle]