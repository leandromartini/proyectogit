use MatuteMateriales
delete from [dbo].[ingresos]
DBCC CHECKIDENT ([ingresos], RESEED,0)
delete from [dbo].[egresos]
DBCC CHECKIDENT ([egresos], RESEED,0)
delete from [dbo].[pagosTpoPago]
DBCC CHECKIDENT ([pagosTpoPago], RESEED,0)
delete from [dbo].[productosCantidad]
delete from [dbo].[errores]
DBCC CHECKIDENT ([errores], RESEED,0)

delete from [dbo].[productos]
DBCC CHECKIDENT ([productos], RESEED,0)

delete from [dbo].[productosCantidad]
delete from [dbo].[productosPrecio]
delete from [dbo].[productosPrecioHist]

