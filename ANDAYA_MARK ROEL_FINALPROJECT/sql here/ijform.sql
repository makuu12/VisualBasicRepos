USE [master]
GO
/****** Object:  Database [sfit2a_relational]    Script Date: 22/12/2024 1:12:08 pm ******/
CREATE DATABASE [sfit2a_relational]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'sfit2a_relational', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL_SERVER\MSSQL\DATA\sfit2a_relational.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'sfit2a_relational_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL_SERVER\MSSQL\DATA\sfit2a_relational_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [sfit2a_relational] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [sfit2a_relational].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [sfit2a_relational] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [sfit2a_relational] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [sfit2a_relational] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [sfit2a_relational] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [sfit2a_relational] SET ARITHABORT OFF 
GO
ALTER DATABASE [sfit2a_relational] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [sfit2a_relational] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [sfit2a_relational] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [sfit2a_relational] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [sfit2a_relational] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [sfit2a_relational] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [sfit2a_relational] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [sfit2a_relational] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [sfit2a_relational] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [sfit2a_relational] SET  DISABLE_BROKER 
GO
ALTER DATABASE [sfit2a_relational] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [sfit2a_relational] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [sfit2a_relational] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [sfit2a_relational] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [sfit2a_relational] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [sfit2a_relational] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [sfit2a_relational] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [sfit2a_relational] SET RECOVERY FULL 
GO
ALTER DATABASE [sfit2a_relational] SET  MULTI_USER 
GO
ALTER DATABASE [sfit2a_relational] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [sfit2a_relational] SET DB_CHAINING OFF 
GO
ALTER DATABASE [sfit2a_relational] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [sfit2a_relational] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [sfit2a_relational] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [sfit2a_relational] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'sfit2a_relational', N'ON'
GO
ALTER DATABASE [sfit2a_relational] SET QUERY_STORE = OFF
GO
USE [sfit2a_relational]
GO
/****** Object:  Table [dbo].[section_table]    Script Date: 22/12/2024 1:12:08 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[section_table](
	[sectionid] [int] IDENTITY(1,1) NOT NULL,
	[sectionname] [nvarchar](50) NOT NULL,
	[section_desc] [nvarchar](50) NULL,
 CONSTRAINT [PK_section_table] PRIMARY KEY CLUSTERED 
(
	[sectionid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[courses_table]    Script Date: 22/12/2024 1:12:08 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[courses_table](
	[courseid] [int] IDENTITY(1,1) NOT NULL,
	[course_desc] [nvarchar](50) NOT NULL,
	[course_codes] [nvarchar](50) NULL,
	[no_units] [nvarchar](50) NULL,
 CONSTRAINT [PK_courses_table] PRIMARY KEY CLUSTERED 
(
	[courseid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[students_table]    Script Date: 22/12/2024 1:12:08 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[students_table](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstname] [nvarchar](50) NOT NULL,
	[lastname] [nvarchar](50) NOT NULL,
	[courseid] [int] NOT NULL,
	[sectionid] [int] NOT NULL,
 CONSTRAINT [PK_students_table] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[viewrecords]    Script Date: 22/12/2024 1:12:08 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[viewrecords]
AS
SELECT dbo.students_table.id, dbo.students_table.firstname, dbo.students_table.lastname, dbo.courses_table.course_desc, dbo.section_table.sectionname
FROM   dbo.students_table INNER JOIN
             dbo.section_table ON dbo.students_table.sectionid = dbo.section_table.sectionid INNER JOIN
             dbo.courses_table ON dbo.students_table.courseid = dbo.courses_table.courseid
GO
/****** Object:  View [dbo].[modifyrecords]    Script Date: 22/12/2024 1:12:08 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[modifyrecords]
AS
SELECT dbo.students_table.id, dbo.students_table.firstname, dbo.students_table.lastname, dbo.students_table.courseid, dbo.students_table.sectionid
FROM   dbo.courses_table INNER JOIN
             dbo.students_table ON dbo.courses_table.courseid = dbo.students_table.courseid INNER JOIN
             dbo.section_table ON dbo.students_table.sectionid = dbo.section_table.sectionid
GO
/****** Object:  View [dbo].[viewrec]    Script Date: 22/12/2024 1:12:08 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[viewrec]
AS
SELECT dbo.students_table.id, dbo.students_table.firstname, dbo.students_table.lastname, dbo.courses_table.course_desc, dbo.section_table.section_desc, dbo.section_table.sectionid, dbo.section_table.sectionname, dbo.courses_table.course_codes, dbo.courses_table.no_units, 
             dbo.courses_table.courseid
FROM   dbo.students_table INNER JOIN
             dbo.section_table ON dbo.students_table.sectionid = dbo.section_table.sectionid INNER JOIN
             dbo.courses_table ON dbo.students_table.courseid = dbo.courses_table.courseid
GO
/****** Object:  View [dbo].[updaterec]    Script Date: 22/12/2024 1:12:08 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[updaterec]
AS
SELECT firstname, lastname, courseid, id, sectionid
FROM   dbo.students_table
GO
ALTER TABLE [dbo].[students_table]  WITH CHECK ADD  CONSTRAINT [FK_students_table_courses_table] FOREIGN KEY([courseid])
REFERENCES [dbo].[courses_table] ([courseid])
GO
ALTER TABLE [dbo].[students_table] CHECK CONSTRAINT [FK_students_table_courses_table]
GO
ALTER TABLE [dbo].[students_table]  WITH CHECK ADD  CONSTRAINT [FK_students_table_section_table] FOREIGN KEY([courseid])
REFERENCES [dbo].[section_table] ([sectionid])
GO
ALTER TABLE [dbo].[students_table] CHECK CONSTRAINT [FK_students_table_section_table]
GO
/****** Object:  StoredProcedure [dbo].[viewallrecords]    Script Date: 22/12/2024 1:12:08 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[viewallrecords]

AS

SELECT students_table.firstname, students_table.lastname, 
courses_table.course_desc, section_table.sectionname FROM students_table
INNER JOIN courses_table ON students_table.courseid = courses_table.courseid
INNER JOIN section_table ON students_table.sectionid = section_table.sectionid
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
         Begin Table = "courses_table"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 206
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "section_table"
            Begin Extent = 
               Top = 9
               Left = 336
               Bottom = 179
               Right = 558
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "students_table"
            Begin Extent = 
               Top = 9
               Left = 615
               Bottom = 206
               Right = 837
            End
            DisplayFlags = 280
            TopColumn = 1
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'modifyrecords'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'modifyrecords'
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
         Begin Table = "students_table"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 303
               Right = 279
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'updaterec'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'updaterec'
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
         Begin Table = "students_table"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 284
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "section_table"
            Begin Extent = 
               Top = 9
               Left = 336
               Bottom = 247
               Right = 558
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "courses_table"
            Begin Extent = 
               Top = 9
               Left = 615
               Bottom = 282
               Right = 837
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'viewrec'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'viewrec'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[38] 2[3] 3) )"
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
         Begin Table = "students_table"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 298
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "section_table"
            Begin Extent = 
               Top = 9
               Left = 336
               Bottom = 299
               Right = 558
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "courses_table"
            Begin Extent = 
               Top = 9
               Left = 615
               Bottom = 301
               Right = 837
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'viewrecords'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'viewrecords'
GO
USE [master]
GO
ALTER DATABASE [sfit2a_relational] SET  READ_WRITE 
GO
