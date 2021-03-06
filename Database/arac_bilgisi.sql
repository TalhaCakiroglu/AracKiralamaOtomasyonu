/*
   10 Temmuz 2018 Salı23:24:49
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
ALTER TABLE dbo.arac_bilgisi ADD
	fiyat int NULL
GO
ALTER TABLE dbo.arac_bilgisi SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.arac_bilgisi', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.arac_bilgisi', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.arac_bilgisi', 'Object', 'CONTROL') as Contr_Per 