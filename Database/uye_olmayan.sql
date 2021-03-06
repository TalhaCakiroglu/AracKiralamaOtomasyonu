/*
   10 Temmuz 2018 Salı23:21:14
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
CREATE TABLE dbo.Tmp_uye_olmayan
	(
	Id int NOT NULL IDENTITY (1, 1),
	TC_no int NOT NULL,
	ad nvarchar(50) NOT NULL,
	soyad nvarchar(50) NOT NULL,
	eposta nvarchar(50) NOT NULL,
	sürücü_lisans_no int NOT NULL,
	telefon_no nvarchar(50) NOT NULL,
	dogum_tar nvarchar(50) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_uye_olmayan SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_uye_olmayan ON
GO
IF EXISTS(SELECT * FROM dbo.uye_olmayan)
	 EXEC('INSERT INTO dbo.Tmp_uye_olmayan (Id, TC_no, ad, soyad, eposta, sürücü_lisans_no, telefon_no, dogum_tar)
		SELECT Id, TC_no, ad, soyad, eposta, sürücü_lisans_no, CONVERT(nvarchar(50), telefon_no), CONVERT(nvarchar(50), dogum_tar) FROM dbo.uye_olmayan WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_uye_olmayan OFF
GO
DROP TABLE dbo.uye_olmayan
GO
EXECUTE sp_rename N'dbo.Tmp_uye_olmayan', N'uye_olmayan', 'OBJECT' 
GO
ALTER TABLE dbo.uye_olmayan ADD CONSTRAINT
	PK_uye_olmayan PRIMARY KEY CLUSTERED 
	(
	Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.uye_olmayan', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.uye_olmayan', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.uye_olmayan', 'Object', 'CONTROL') as Contr_Per 