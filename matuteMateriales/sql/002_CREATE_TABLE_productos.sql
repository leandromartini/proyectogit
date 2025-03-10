use MatuteMateriales
/*
   martes, 30 de abril de 201919:09:33
   User: 
   Server: LEANDRO-PC
   Database: MatuteMateriales
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
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
CREATE TABLE dbo.productos
	(
	id_prod int NOT NULL IDENTITY (1, 1),
	nombre varchar(50) NOT NULL,
	descrip varchar(150) NOT NULL,
	unidad varchar(9) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.productos ADD CONSTRAINT
	PK_productos PRIMARY KEY CLUSTERED 
	(
	nombre ASC,
	id_prod	
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.productos SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
