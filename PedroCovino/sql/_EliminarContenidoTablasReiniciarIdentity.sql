use PedroCovino

delete from [dbo].[errores]
DBCC CHECKIDENT ([errores], RESEED,0)

delete from [dbo].[insumos]
DBCC CHECKIDENT ([insumos], RESEED,0)

delete from [dbo].[insumosPrecioHist]
delete from [dbo].[insumosPrecios]
delete from [dbo].[insumosStock]

