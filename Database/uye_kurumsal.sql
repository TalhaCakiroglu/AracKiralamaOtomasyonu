/*
   9 Temmuz 2018 Pazartesi19:31:26
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
CREATE TABLE dbo.uye_kurumsal
	(
	Id int NOT NULL IDENTITY (1, 1),
	sirket_adi nvarchar(50) NOT NULL,
	yetkili_adi nvarchar(50) NOT NULL,
	yetkili_soyadi nvarchar(50) NOT NULL,
	sifre nvarchar(50) NOT NULL,
	sirket_tel int NOT NULL,
	basvuru_tipi nvarchar(50) NOT NULL,
	vergi_dairesi int NOT NULL,
	vergi_no int NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.uye_kurumsal ADD CONSTRAINT
	PK_uye_kurumsal PRIMARY KEY CLUSTERED 
	(
	Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.uye_kurumsal SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.uye_kurumsal', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.uye_kurumsal', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.uye_kurumsal', 'Object', 'CONTROL') as Contr_Per 