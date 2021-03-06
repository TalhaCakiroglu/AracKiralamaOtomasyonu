/*
   9 Temmuz 2018 Pazartesi22:43:25
   User: 
   Server: TALHA
   Database: arac_kiralama
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
CREATE TABLE dbo.rezervasyon
	(
	Id int NOT NULL IDENTITY (1, 1),
	alis_tarihi date NOT NULL,
	alis_saati time(7) NOT NULL,
	teslim_tarihi date NOT NULL,
	teslim_saati time(7) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.rezervasyon ADD CONSTRAINT
	PK_rezervasyon PRIMARY KEY CLUSTERED 
	(
	Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.rezervasyon SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.rezervasyon', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.rezervasyon', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.rezervasyon', 'Object', 'CONTROL') as Contr_Per 