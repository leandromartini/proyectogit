USE [pruebas]
GO

/****** Object:  Table [dbo].[localidades]    Script Date: 20/04/2018 16:20:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[localidades](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cod_ent] [int] NOT NULL,
	[descrip] [varchar](20) NOT NULL
) ON [PRIMARY]
GO


