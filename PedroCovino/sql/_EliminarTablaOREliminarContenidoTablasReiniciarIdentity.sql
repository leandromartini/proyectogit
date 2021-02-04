use PedroCovino

DROP TABLE  IF EXISTS  [dbo].[errores];
DROP TABLE  IF EXISTS  [dbo].[insumos]
DROP TABLE  IF EXISTS  [dbo].[insumosPrecioHist]
DROP TABLE  IF EXISTS  [dbo].[insumosPrecios]
DROP TABLE  IF EXISTS  [dbo].[insumosStock]
DROP PROCEDURE  IF EXISTS  [dbo].[errores_actualizarRegistro]
DROP PROCEDURE  IF EXISTS  [dbo].[insumos_obtenerLista]
DROP PROCEDURE  IF EXISTS  [dbo].[insumos_actualizarRegistro]
DROP PROCEDURE  IF EXISTS  [dbo].[insumos_obtenerListaDetalle]
DROP PROCEDURE  IF EXISTS  [dbo].[insumosPrecios_actualizarRegistro]
DROP PROCEDURE  IF EXISTS  [dbo].[insumosStock_actualizarRegistro]

--delete from [dbo].[errores]
--DBCC CHECKIDENT ([errores], RESEED,0)

--delete from [dbo].[insumos]
--DBCC CHECKIDENT ([insumos], RESEED,0)

--delete from [dbo].[insumosPrecioHist]
--DBCC CHECKIDENT ([insumosPrecioHist], RESEED,0)

--delete from [dbo].[insumosPrecios]
--DBCC CHECKIDENT ([insumosPrecios], RESEED,0)

--delete from [dbo].[insumosStock]
--DBCC CHECKIDENT ([insumosStock], RESEED,0)

