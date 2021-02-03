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

