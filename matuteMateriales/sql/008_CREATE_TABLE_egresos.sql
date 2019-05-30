USE [MatuteMateriales]
GO

/****** Object:  Table [dbo].[egresos]    Script Date: 10/05/2019 15:14:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[egresos](
	[id_egreso] [int] IDENTITY(1,1) NOT NULL,
	[id_con] [int] NOT NULL,
	[precio] [decimal](8, 2) NOT NULL,
	[cant] [decimal](10, 2) NOT NULL,
	[total] [decimal](10, 2) NOT NULL,
	[fec] [date] NOT NULL
 CONSTRAINT [PK_egresos] PRIMARY KEY CLUSTERED 
(
	[id_egreso] ASC,
	[id_con] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


