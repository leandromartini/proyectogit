USE [MatuteMateriales]
GO

/****** Object:  Table [dbo].[errores]    Script Date: 09/05/2019 13:45:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[errores](
	[id_error] [int] IDENTITY(1,1) NOT NULL,
	[mensaje] [varchar](2048) NOT NULL,
	[namefrm] [varchar](100) NOT NULL,
	[fec] [date] NOT NULL
 CONSTRAINT [PK_errores] PRIMARY KEY CLUSTERED 
(
	[id_error] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


