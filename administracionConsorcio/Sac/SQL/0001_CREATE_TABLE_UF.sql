USE [sar]
GO

/****** Object:  Table [dbo].[UF]    Script Date: 9/3/2019 15:20:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UF](
	[id_uf] [int] IDENTITY(1,1) NOT NULL,
	[id_cons] [int] NOT NULL,
	[dpto] [varchar](3) NOT NULL,
	[coef] [decimal](5, 4) NOT NULL,
	[descrip] [varchar](15) NOT NULL,
 CONSTRAINT [PK_UF] PRIMARY KEY CLUSTERED 
(
	[id_uf] ASC,
	[id_cons] ASC,
	[dpto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
