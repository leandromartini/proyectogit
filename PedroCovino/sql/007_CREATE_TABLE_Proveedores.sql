USE [PedroCovino]
GO

/****** Object:  Table [dbo].[proveedores]    Script Date: 9/2/2021 12:53:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[proveedores](
	[idProv] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL
) ON [PRIMARY]
GO


