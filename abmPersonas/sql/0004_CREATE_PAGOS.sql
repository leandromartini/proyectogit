USE [pruebas]
GO

/****** Object:  Table [dbo].[tmpPagos]    Script Date: 30/5/2018 19:25:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Pagos](
	[idleg] [int] NOT NULL,
	[idPago] [int] NOT NULL,
	[tpoPago] [smallint] NOT NULL,
	[importe] [decimal](9, 2) NOT NULL,
	[fecPago] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[idleg] ASC,
	[idPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


