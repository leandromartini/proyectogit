USE [pruebas]
GO

/****** Object:  Table [dbo].[deudas]    Script Date: 30/5/2018 21:04:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[deudas](
	[idusuario] [int] NOT NULL,
	[tpodeuda] [smallint] NOT NULL,
	[importe] [decimal](9, 2) NOT NULL,
	[fecEmision] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idusuario] ASC,
	[tpodeuda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


