USE [SAR]
GO

/****** Object:  Table [dbo].[ingresos]    Script Date: 20/02/2019 19:17:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ingresos](
	[id_uf] [int] NOT NULL,
	[mes] [int] NOT NULL,
	[anio] [int] NOT NULL,
	[expMes] [decimal](6, 2) NOT NULL,
	[expExtra] [decimal](6, 2) NOT NULL,
	[mantEdif] [decimal](3, 2) NOT NULL,
	[subTotal] [decimal](6, 2) NOT NULL,
	[redondeo] [decimal](3, 2) NOT NULL,
	[total] [decimal](6, 2) NOT NULL,
 CONSTRAINT [PK_ingresos] PRIMARY KEY CLUSTERED 
(
	[id_uf] ASC,
	[mes] ASC,
	[anio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


