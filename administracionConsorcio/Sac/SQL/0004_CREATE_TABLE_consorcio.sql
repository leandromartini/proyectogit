USE [sar]
GO

/****** Object:  Table [dbo].[consorcio]    Script Date: 9/3/2019 13:14:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[consorcio](
	[id_cons] [int] IDENTITY(1,1) NOT NULL,
	[descrip] [varchar](50) NOT NULL,
 CONSTRAINT [PK_consorcio] PRIMARY KEY CLUSTERED 
(
	[id_cons] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


