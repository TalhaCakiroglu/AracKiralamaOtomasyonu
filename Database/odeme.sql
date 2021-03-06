/*
   9 Temmuz 2018 Pazartesi22:39:45
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
CREATE TABLE dbo.odeme
	(
	Id int NOT NULL IDENTITY (1, 1),
	kart1 int NOT NULL,
	kart2 int NOT NULL,
	kart3 int NOT NULL,
	kart4 int NOT NULL,
	kart_isim nvarchar(50) NOT NULL,
	cvc_kod int NOT NULL,
	ay int NOT NULL,
	yıl int NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.odeme ADD CONSTRAINT
	PK_odeme PRIMARY KEY CLUSTERED 
	(
	Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.odeme SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.odeme', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.odeme', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.odeme', 'Object', 'CONTROL') as Contr_Per 