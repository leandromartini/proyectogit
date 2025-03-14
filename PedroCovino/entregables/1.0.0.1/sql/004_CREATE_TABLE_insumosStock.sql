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
CREATE TABLE dbo.insumosStock
	(
	idStock int NOT NULL IDENTITY (1, 1),
	codigo int NOT NULL,
	stock int NOT NULL,
	stockMin int NOT NULL,
	stockMax int NOT NULL,
	fecAct date NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.insumosStock SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
