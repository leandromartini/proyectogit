USE [MatuteMateriales]
GO

/****** Object:  Table [dbo].[pagosTpoPago]    Script Date: 10/05/2019 15:32:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[pagosTpoPago](
	[id_egreso] [int] NOT NULL,
	[formaPago] [varchar](20) NOT NULL,
	[fec] [date] NOT NULL,
 CONSTRAINT [PK_PagosTpoPago] PRIMARY KEY CLUSTERED 
(
	[id_egreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


