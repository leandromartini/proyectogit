USE [MatuteMateriales]
GO

/****** Object:  Table [dbo].[productosPrecioHist]    Script Date: 7/5/2019 17:02:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[productosPrecioHist](
	[id_prod] [smallint] NOT NULL,
	[precio] [decimal](8, 2) NOT NULL,
	[precioIVA] [decimal](8, 2) NOT NULL,
	[fecAct] [date] NOT NULL,
 CONSTRAINT [PK_productosPrecioHist] PRIMARY KEY CLUSTERED 
(
	[id_prod] ASC,
	[precio] ASC,
	[fecAct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


