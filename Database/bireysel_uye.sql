/*
   10 Temmuz 2018 Salı14:18:02
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
CREATE TABLE dbo.bireysel_uye
	(
	Id int NOT NULL IDENTITY (1, 1),
	TC_no int NOT NULL,
	ad nvarchar(50) NOT NULL,
	soyad nvarchar(50) NOT NULL,
	sifre nvarchar(50) NOT NULL,
	eposta nvarchar(50) NOT NULL,
	gizli_soru nvarchar(50) NOT NULL,
	cevap nvarchar(50) NOT NULL,
	lisans_no nvarchar(50) NOT NULL,
	telefon int NOT NULL,
	dogum_tarihi nvarchar(50) NOT NULL,
	sehir nvarchar(50) NOT NULL,
	ulke nvarchar(50) NOT NULL,
	adres nvarchar(50) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.bireysel_uye ADD CONSTRAINT
	PK_bireysel_uye PRIMARY KEY CLUSTERED 
	(
	Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.bireysel_uye SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.bireysel_uye', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.bireysel_uye', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.bireysel_uye', 'Object', 'CONTROL') as Contr_Per 