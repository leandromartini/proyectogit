USE [pruebas]
GO

/****** Object:  Table [dbo].[propiedad]    Script Date: 08/05/2018 19:57:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[propiedad](
	[id_prop] [int] IDENTITY(1,1) NOT NULL,
	[tpoProp] [int] NOT NULL,
	[disp] [int] NOT NULL,
 CONSTRAINT [PK_propiedad] PRIMARY KEY CLUSTERED 
(
	[id_prop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


