USE PedroCovino
GO
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.insumosPrecioHist
	(
	idPrecioHist int NOT NULL IDENTITY (1, 1),
	codigo int NOT NULL,
	preciosiva decimal(8, 2) NOT NULL,
	preciociva decimal(8, 2) NOT NULL,
	ventapublico decimal(8, 2) NOT NULL,
	fecAct date NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.insumosPrecioHist SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
