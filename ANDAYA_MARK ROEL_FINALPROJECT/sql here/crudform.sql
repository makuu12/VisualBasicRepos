USE [master]
GO
/****** Object:  Database [sfit2aCRUD]    Script Date: 22/12/2024 1:10:20 pm ******/
CREATE DATABASE [sfit2aCRUD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'sfit2aCRUD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL_SERVER\MSSQL\DATA\sfit2aCRUD.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'sfit2aCRUD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL_SERVER\MSSQL\DATA\sfit2aCRUD_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [sfit2aCRUD] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [sfit2aCRUD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [sfit2aCRUD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [sfit2aCRUD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [sfit2aCRUD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [sfit2aCRUD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [sfit2aCRUD] SET ARITHABORT OFF 
GO
ALTER DATABASE [sfit2aCRUD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [sfit2aCRUD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [sfit2aCRUD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [sfit2aCRUD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [sfit2aCRUD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [sfit2aCRUD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [sfit2aCRUD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [sfit2aCRUD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [sfit2aCRUD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [sfit2aCRUD] SET  ENABLE_BROKER 
GO
ALTER DATABASE [sfit2aCRUD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [sfit2aCRUD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [sfit2aCRUD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [sfit2aCRUD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [sfit2aCRUD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [sfit2aCRUD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [sfit2aCRUD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [sfit2aCRUD] SET RECOVERY FULL 
GO
ALTER DATABASE [sfit2aCRUD] SET  MULTI_USER 
GO
ALTER DATABASE [sfit2aCRUD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [sfit2aCRUD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [sfit2aCRUD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [sfit2aCRUD] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [sfit2aCRUD] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [sfit2aCRUD] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'sfit2aCRUD', N'ON'
GO
ALTER DATABASE [sfit2aCRUD] SET QUERY_STORE = OFF
GO
USE [sfit2aCRUD]
GO
/****** Object:  Table [dbo].[member]    Script Date: 22/12/2024 1:10:20 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[member](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[first] [nvarchar](10) NOT NULL,
	[last] [nvarchar](10) NOT NULL,
	[gender] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[insertrecor]    Script Date: 22/12/2024 1:10:21 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertrecor]
	@firstname1 nvarchar(50),
	@lastname1 nvarchar(50),
	@gender1 nvarchar(50)
AS
	insert into member (first, last, gender) values (@firstname1,@lastname1, @gender1)
GO
/****** Object:  StoredProcedure [dbo].[sqladd]    Script Date: 22/12/2024 1:10:21 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sqladd]
	@firstname1 nvarchar(50),
	@lastname1 nvarchar(50),
	@gender1 nvarchar(50)
AS
	insert into member (first, last, gender) values (@firstname1,@lastname1, @gender1)
GO
/****** Object:  StoredProcedure [dbo].[sqldelete]    Script Date: 22/12/2024 1:10:21 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sqldelete]
	@id1 int 
AS
	DELETE FROM member WHERE id= @id1
GO
/****** Object:  StoredProcedure [dbo].[sqlsearch]    Script Date: 22/12/2024 1:10:21 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sqlsearch]
    @id1 int
AS
    SELECT * FROM member WHERE id=@id1
GO
/****** Object:  StoredProcedure [dbo].[sqlupdate]    Script Date: 22/12/2024 1:10:21 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sqlupdate]
    @id1 int,
    @firstname1 nvarchar(50),
    @lastname1 nvarchar(50),
    @gender1 nvarchar(50)
AS
UPDATE member SET first = @firstname1, last = @lastname1, gender = @gender1 WHERE id=@id1
GO
/****** Object:  StoredProcedure [dbo].[viewallrecord]    Script Date: 22/12/2024 1:10:21 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[viewallrecord]
AS
    SELECT * FROM member
GO
USE [master]
GO
ALTER DATABASE [sfit2aCRUD] SET  READ_WRITE 
GO
