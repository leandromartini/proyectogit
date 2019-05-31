delete from [dbo].[ingresos]
DBCC CHECKIDENT ([ingresos], RESEED,0)
delete from [dbo].[egresos]
DBCC CHECKIDENT ([egresos], RESEED,0)
delete from [dbo].[pagosTpoPago]
DBCC CHECKIDENT ([pagosTpoPago], RESEED,0)
delete from [dbo].[productosCantidad]
delete from [dbo].[errores]
DBCC CHECKIDENT ([errores], RESEED,0)

--delete from [dbo].[productos]
--DBCC CHECKIDENT ([productos], RESEED,0)
--delete from [dbo].[productosCantidad]
--DBCC CHECKIDENT ([productosCantidad], RESEED,0)
--delete from [dbo].[productosPrecio]
--DBCC CHECKIDENT ([productosPrecio], RESEED,0)
--delete from [dbo].[productosPrecioHist]
--DBCC CHECKIDENT ([productosPrecioHist], RESEED,0)
