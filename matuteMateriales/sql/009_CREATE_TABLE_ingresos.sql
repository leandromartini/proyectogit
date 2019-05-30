USE [MatuteMateriales]
GO

/****** Object:  Table [dbo].[ingresos]    Script Date: 30/05/2019 13:49:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ingresos](
	[id_ingreso] [int] IDENTITY(1,1) NOT NULL,
	[id_con] [int] NOT NULL,
	[precio] [decimal](8, 2) NOT NULL,
	[cant] [decimal](10, 2) NOT NULL,
	[total] [decimal](10, 2) NOT NULL,
	[fec] [date] NOT NULL,
 CONSTRAINT [PK_ingresos] PRIMARY KEY CLUSTERED 
(
	[id_ingreso] ASC,
	[id_con] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


