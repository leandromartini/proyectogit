USE [pruebas]
GO

/****** Object:  Table [dbo].[tpo_deudas]    Script Date: 07/06/2018 18:26:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tpo_deudas](
	[id] [smallint] NOT NULL,
	[cod] [smallint] NOT NULL,
	[descrip] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


