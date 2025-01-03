USE [master]
GO
/****** Object:  Database [sfit2a_labexam]    Script Date: 22/12/2024 1:13:46 pm ******/
CREATE DATABASE [sfit2a_labexam]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'sfit2a_labexam', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL_SERVER\MSSQL\DATA\sfit2a_labexam.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'sfit2a_labexam_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL_SERVER\MSSQL\DATA\sfit2a_labexam_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [sfit2a_labexam] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [sfit2a_labexam].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [sfit2a_labexam] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [sfit2a_labexam] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [sfit2a_labexam] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [sfit2a_labexam] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [sfit2a_labexam] SET ARITHABORT OFF 
GO
ALTER DATABASE [sfit2a_labexam] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [sfit2a_labexam] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [sfit2a_labexam] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [sfit2a_labexam] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [sfit2a_labexam] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [sfit2a_labexam] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [sfit2a_labexam] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [sfit2a_labexam] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [sfit2a_labexam] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [sfit2a_labexam] SET  DISABLE_BROKER 
GO
ALTER DATABASE [sfit2a_labexam] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [sfit2a_labexam] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [sfit2a_labexam] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [sfit2a_labexam] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [sfit2a_labexam] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [sfit2a_labexam] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [sfit2a_labexam] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [sfit2a_labexam] SET RECOVERY FULL 
GO
ALTER DATABASE [sfit2a_labexam] SET  MULTI_USER 
GO
ALTER DATABASE [sfit2a_labexam] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [sfit2a_labexam] SET DB_CHAINING OFF 
GO
ALTER DATABASE [sfit2a_labexam] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [sfit2a_labexam] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [sfit2a_labexam] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [sfit2a_labexam] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'sfit2a_labexam', N'ON'
GO
ALTER DATABASE [sfit2a_labexam] SET QUERY_STORE = OFF
GO
USE [sfit2a_labexam]
GO
/****** Object:  Table [dbo].[students]    Script Date: 22/12/2024 1:13:46 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[students](
	[studentsid] [int] IDENTITY(1,1) NOT NULL,
	[firstname] [nvarchar](50) NOT NULL,
	[lastname] [nvarchar](50) NOT NULL,
	[genderid] [int] NOT NULL,
	[courseid] [int] NOT NULL,
	[sectionid] [int] NOT NULL,
 CONSTRAINT [PK_students] PRIMARY KEY CLUSTERED 
(
	[studentsid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View2]    Script Date: 22/12/2024 1:13:46 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View2]
AS
SELECT studentsid, firstname, lastname, genderid, courseid, sectionid
FROM   dbo.students
GO
/****** Object:  Table [dbo].[courses]    Script Date: 22/12/2024 1:13:46 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[courses](
	[courseid] [int] IDENTITY(1,1) NOT NULL,
	[course_desc] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_courses] PRIMARY KEY CLUSTERED 
(
	[courseid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sections]    Script Date: 22/12/2024 1:13:46 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sections](
	[sectionid] [int] IDENTITY(1,1) NOT NULL,
	[section_name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_sections] PRIMARY KEY CLUSTERED 
(
	[sectionid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[genders]    Script Date: 22/12/2024 1:13:46 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[genders](
	[genderid] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_genders] PRIMARY KEY CLUSTERED 
(
	[genderid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View1]    Script Date: 22/12/2024 1:13:46 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View1]
AS
SELECT dbo.students.studentsid, dbo.students.firstname, dbo.students.lastname, dbo.genders.title, dbo.courses.course_desc, dbo.sections.section_name
FROM   dbo.courses INNER JOIN
             dbo.students ON dbo.courses.courseid = dbo.students.courseid INNER JOIN
             dbo.genders ON dbo.students.genderid = dbo.genders.genderid INNER JOIN
             dbo.sections ON dbo.students.sectionid = dbo.sections.sectionid
GO
ALTER TABLE [dbo].[students]  WITH CHECK ADD  CONSTRAINT [FK_students_courses] FOREIGN KEY([courseid])
REFERENCES [dbo].[courses] ([courseid])
GO
ALTER TABLE [dbo].[students] CHECK CONSTRAINT [FK_students_courses]
GO
ALTER TABLE [dbo].[students]  WITH CHECK ADD  CONSTRAINT [FK_students_genders] FOREIGN KEY([genderid])
REFERENCES [dbo].[genders] ([genderid])
GO
ALTER TABLE [dbo].[students] CHECK CONSTRAINT [FK_students_genders]
GO
ALTER TABLE [dbo].[students]  WITH CHECK ADD  CONSTRAINT [FK_students_sections] FOREIGN KEY([sectionid])
REFERENCES [dbo].[sections] ([sectionid])
GO
ALTER TABLE [dbo].[students] CHECK CONSTRAINT [FK_students_sections]
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
         Begin Table = "courses"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 152
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "genders"
            Begin Extent = 
               Top = 9
               Left = 336
               Bottom = 152
               Right = 558
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "sections"
            Begin Extent = 
               Top = 9
               Left = 615
               Bottom = 152
               Right = 837
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "students"
            Begin Extent = 
               Top = 9
               Left = 894
               Bottom = 206
               Right = 1116
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View1'
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
         Begin Table = "students"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 293
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View2'
GO
USE [master]
GO
ALTER DATABASE [sfit2a_labexam] SET  READ_WRITE 
GO
