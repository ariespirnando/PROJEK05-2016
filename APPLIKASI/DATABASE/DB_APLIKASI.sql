USE [master]
GO
/****** Object:  Database [TA_lampost2016]    Script Date: 06/04/2016 16:48:23 ******/
CREATE DATABASE [TA_lampost2016] ON  PRIMARY 
( NAME = N'TA_lampost2016', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\TA_lampost2016.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TA_lampost2016_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\TA_lampost2016_log.ldf' , SIZE = 2560KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TA_lampost2016] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TA_lampost2016].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TA_lampost2016] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [TA_lampost2016] SET ANSI_NULLS OFF
GO
ALTER DATABASE [TA_lampost2016] SET ANSI_PADDING OFF
GO
ALTER DATABASE [TA_lampost2016] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [TA_lampost2016] SET ARITHABORT OFF
GO
ALTER DATABASE [TA_lampost2016] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [TA_lampost2016] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [TA_lampost2016] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [TA_lampost2016] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [TA_lampost2016] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [TA_lampost2016] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [TA_lampost2016] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [TA_lampost2016] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [TA_lampost2016] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [TA_lampost2016] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [TA_lampost2016] SET  DISABLE_BROKER
GO
ALTER DATABASE [TA_lampost2016] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [TA_lampost2016] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [TA_lampost2016] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [TA_lampost2016] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [TA_lampost2016] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [TA_lampost2016] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [TA_lampost2016] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [TA_lampost2016] SET  READ_WRITE
GO
ALTER DATABASE [TA_lampost2016] SET RECOVERY SIMPLE
GO
ALTER DATABASE [TA_lampost2016] SET  MULTI_USER
GO
ALTER DATABASE [TA_lampost2016] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [TA_lampost2016] SET DB_CHAINING OFF
GO
USE [TA_lampost2016]
GO
/****** Object:  Table [dbo].[Pengguna]    Script Date: 06/04/2016 16:48:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pengguna](
	[username] [char](20) NOT NULL,
	[password] [char](20) NULL,
	[email] [varchar](40) NULL,
 CONSTRAINT [PK_Pengguna] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipeSurat]    Script Date: 06/04/2016 16:48:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipeSurat](
	[kodeSurat] [char](5) NOT NULL,
	[jenisSurat] [varchar](50) NULL,
 CONSTRAINT [PK_TipeSurat] PRIMARY KEY CLUSTERED 
(
	[kodeSurat] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SuratMasuk]    Script Date: 06/04/2016 16:48:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SuratMasuk](
	[nomorSurat] [varchar](50) NOT NULL,
	[prihalSM] [text] NULL,
	[tanggalSM] [date] NULL,
	[pengirimSM] [varchar](30) NULL,
	[alamatSM] [text] NULL,
	[penerimaSM] [varchar](30) NULL,
	[kodeSurat] [char](5) NULL,
 CONSTRAINT [PK_SuratMasuk] PRIMARY KEY CLUSTERED 
(
	[nomorSurat] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SuratKeluar]    Script Date: 06/04/2016 16:48:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SuratKeluar](
	[nomorSurat] [varchar](50) NOT NULL,
	[prihalSK] [text] NULL,
	[tanggalSK] [date] NULL,
	[penerimaSK] [varchar](50) NULL,
	[alamatSK] [text] NULL,
	[pengirimSK] [varchar](50) NULL,
	[kodeSurat] [char](5) NULL,
 CONSTRAINT [PK_SuratKeluar] PRIMARY KEY CLUSTERED 
(
	[nomorSurat] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[VSuratMasuk]    Script Date: 06/04/2016 16:48:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VSuratMasuk]
AS
SELECT     dbo.TipeSurat.jenisSurat, dbo.SuratMasuk.nomorSurat, dbo.SuratMasuk.prihalSM, dbo.SuratMasuk.pengirimSM, dbo.SuratMasuk.tanggalSM, 
                      dbo.SuratMasuk.alamatSM, dbo.SuratMasuk.penerimaSM
FROM         dbo.SuratMasuk INNER JOIN
                      dbo.TipeSurat ON dbo.SuratMasuk.kodeSurat = dbo.TipeSurat.kodeSurat
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4[60] 2) )"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 11
   End
   Begin DiagramPane = 
      PaneHidden = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "SuratMasuk"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "TipeSurat"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 95
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      PaneHidden = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VSuratMasuk'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VSuratMasuk'
GO
/****** Object:  View [dbo].[VSuratKeluar]    Script Date: 06/04/2016 16:48:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VSuratKeluar]
AS
SELECT     dbo.SuratKeluar.prihalSK, dbo.SuratKeluar.nomorSurat, dbo.SuratKeluar.tanggalSK, dbo.SuratKeluar.penerimaSK, dbo.SuratKeluar.alamatSK, 
                      dbo.SuratKeluar.pengirimSK, dbo.TipeSurat.jenisSurat
FROM         dbo.SuratKeluar INNER JOIN
                      dbo.TipeSurat ON dbo.SuratKeluar.kodeSurat = dbo.TipeSurat.kodeSurat
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "SuratKeluar"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "TipeSurat"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 95
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VSuratKeluar'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VSuratKeluar'
GO
/****** Object:  Table [dbo].[ArsipSuratKel]    Script Date: 06/04/2016 16:48:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ArsipSuratKel](
	[nomorSurat] [varchar](50) NULL,
	[GambarSk] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ArsipSurat]    Script Date: 06/04/2016 16:48:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ArsipSurat](
	[nomorSurat] [varchar](50) NULL,
	[Gambar] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_SuratMasuk_TipeSurat]    Script Date: 06/04/2016 16:48:24 ******/
ALTER TABLE [dbo].[SuratMasuk]  WITH CHECK ADD  CONSTRAINT [FK_SuratMasuk_TipeSurat] FOREIGN KEY([kodeSurat])
REFERENCES [dbo].[TipeSurat] ([kodeSurat])
GO
ALTER TABLE [dbo].[SuratMasuk] CHECK CONSTRAINT [FK_SuratMasuk_TipeSurat]
GO
/****** Object:  ForeignKey [FK_SuratKeluar_TipeSurat]    Script Date: 06/04/2016 16:48:24 ******/
ALTER TABLE [dbo].[SuratKeluar]  WITH CHECK ADD  CONSTRAINT [FK_SuratKeluar_TipeSurat] FOREIGN KEY([kodeSurat])
REFERENCES [dbo].[TipeSurat] ([kodeSurat])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SuratKeluar] CHECK CONSTRAINT [FK_SuratKeluar_TipeSurat]
GO
/****** Object:  ForeignKey [FK_ArsipSuratKel_SuratKeluar]    Script Date: 06/04/2016 16:48:25 ******/
ALTER TABLE [dbo].[ArsipSuratKel]  WITH CHECK ADD  CONSTRAINT [FK_ArsipSuratKel_SuratKeluar] FOREIGN KEY([nomorSurat])
REFERENCES [dbo].[SuratKeluar] ([nomorSurat])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ArsipSuratKel] CHECK CONSTRAINT [FK_ArsipSuratKel_SuratKeluar]
GO
/****** Object:  ForeignKey [FK_ArsipSurat_SuratMasuk]    Script Date: 06/04/2016 16:48:25 ******/
ALTER TABLE [dbo].[ArsipSurat]  WITH CHECK ADD  CONSTRAINT [FK_ArsipSurat_SuratMasuk] FOREIGN KEY([nomorSurat])
REFERENCES [dbo].[SuratMasuk] ([nomorSurat])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ArsipSurat] CHECK CONSTRAINT [FK_ArsipSurat_SuratMasuk]
GO
