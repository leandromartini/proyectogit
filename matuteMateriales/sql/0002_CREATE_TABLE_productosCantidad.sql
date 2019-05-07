USE [MatuteMateriales]
GO

/****** Object:  Table [dbo].[productosCantidad]    Script Date: 7/5/2019 16:59:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[productosCantidad](
	[id_prod] [smallint] NOT NULL,
	[cant] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_productosCantidad] PRIMARY KEY CLUSTERED 
(
	[id_prod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


