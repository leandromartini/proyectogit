USE [pruebas]
GO

/****** Object:  Table [dbo].[tpoPropiedad]    Script Date: 08/05/2018 20:02:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tpoPropiedad](
	[id_tpo] [int] NOT NULL,
	[desc] [varchar](50) NOT NULL,
	[mtroscuad] [int] NOT NULL,
 CONSTRAINT [PK_tpoPropiedad] PRIMARY KEY CLUSTERED 
(
	[id_tpo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


