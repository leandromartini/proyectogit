USE [PedroCovino]
GO

/****** Object:  Table [dbo].[insumosProveedoresMarca]    Script Date: 9/2/2021 13:13:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[insumosProveedoresMarca](
	[codigo] [int] NOT NULL,
	[idProv] [int] NOT NULL,
	[idmarca] [int] NOT NULL
) ON [PRIMARY]
GO


