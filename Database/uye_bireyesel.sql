/*
   10 Temmuz 2018 Salı14:00:52
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
CREATE TABLE dbo.Tmp_uye_bireyesel
	(
	Id int NOT NULL IDENTITY (1, 1),
	TC_no nvarchar(50) NOT NULL,
	ad nvarchar(50) NOT NULL,
	soyad nvarchar(50) NOT NULL,
	sifre nvarchar(50) NOT NULL,
	eposta nvarchar(50) NOT NULL,
	gizli_soru nvarchar(50) NOT NULL,
	cevap nvarchar(50) NOT NULL,
	lisans_no int NOT NULL,
	telefon int NOT NULL,
	dogum_tarihi nvarchar(50) NOT NULL,
	sehir nvarchar(50) NOT NULL,
	ulke nvarchar(50) NOT NULL,
	adres nvarchar(50) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_uye_bireyesel SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_uye_bireyesel ON
GO
IF EXISTS(SELECT * FROM dbo.uye_bireyesel)
	 EXEC('INSERT INTO dbo.Tmp_uye_bireyesel (Id, TC_no, ad, soyad, sifre, eposta, gizli_soru, cevap, lisans_no, telefon, dogum_tarihi, sehir, ulke, adres)
		SELECT Id, CONVERT(nvarchar(50), TC_no), ad, soyad, sifre, eposta, gizli_soru, cevap, lisans_no, telefon, dogum_tarihi, sehir, ulke, adres FROM dbo.uye_bireyesel WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_uye_bireyesel OFF
GO
DROP TABLE dbo.uye_bireyesel
GO
EXECUTE sp_rename N'dbo.Tmp_uye_bireyesel', N'uye_bireyesel', 'OBJECT' 
GO
ALTER TABLE dbo.uye_bireyesel ADD CONSTRAINT
	PK_uye_bireyesel PRIMARY KEY CLUSTERED 
	(
	Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.uye_bireyesel', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.uye_bireyesel', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.uye_bireyesel', 'Object', 'CONTROL') as Contr_Per 