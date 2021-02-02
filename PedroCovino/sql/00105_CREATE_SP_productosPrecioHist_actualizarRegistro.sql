USE PedroCovino
GO
/****** Object:  StoredProcedure [dbo].[productosPrecio_actualizarRegistro]    Script Date: 7/5/2019 17:12:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Leandro Martini Lacrouts>
-- Create date: <08/05/2019 19:13>
-- Description:	<Este SP agrega o actuliza la tabla productosPrecio>
-- =============================================
CREATE PROCEDURE [dbo].[productosPrecioHist_actualizarRegistro]--15,12.3,15.6,'16/06/2019'
 @id_prod int, 
 @precio decimal(8,2), 
 @precioiva decimal(8,2),
 @fecAct date 	
AS
declare @resu int
declare @sis_usu varchar(8000)
Declare @huboerror int

INSERT INTO [dbo].[productosPrecioHist] ([id_prod], [precio], [precioIVA],[fecAct])
VALUES(@id_prod, @precio, @precioiva,@fecAct)

SET @huboerror= @@ERROR
IF @huboerror <> 0 
	begin
	set @sis_usu =system_user
	raiserror(60000,9,1,'insert en productosPrecioHist','productosPrecioHist_actualizarRegistro', @sis_usu, @huboerror, @resu)
	return isnull(@resu,60000)
	end