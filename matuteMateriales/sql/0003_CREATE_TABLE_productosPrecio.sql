USE [MatuteMateriales]
GO

/****** Object:  Table [dbo].[productosPrecio]    Script Date: 3/5/2019 19:34:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[productosPrecio](
	[id_prod] [int] NOT NULL,
	[precio] [decimal](8, 2) NOT NULL,
	[precioIVA] [decimal](8, 2) NOT NULL,
 CONSTRAINT [PK_productosPrecio] PRIMARY KEY CLUSTERED 
(
	[id_prod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


