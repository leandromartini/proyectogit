USE [pruebas]
GO

/****** Object:  Table [dbo].[pagos]    Script Date: 31/5/2018 13:53:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[pagos](
	[idusuario] [int] NOT NULL,
	[idPago] [int] NOT NULL,
	[tpoPago] [smallint] NOT NULL,
	[importe] [decimal](9, 2) NOT NULL,
	[fecPago] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[idusuario] ASC,
	[idPago] ASC,
	[tpoPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


