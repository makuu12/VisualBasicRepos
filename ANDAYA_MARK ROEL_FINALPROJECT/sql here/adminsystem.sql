USE [master]
GO
/****** Object:  Database [sfit2a_andaya]    Script Date: 22/12/2024 1:06:38 pm ******/
CREATE DATABASE [sfit2a_andaya]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'sfit2a_andaya', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL_SERVER\MSSQL\DATA\sfit2a_andaya.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'sfit2a_andaya_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL_SERVER\MSSQL\DATA\sfit2a_andaya_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [sfit2a_andaya] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [sfit2a_andaya].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [sfit2a_andaya] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [sfit2a_andaya] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [sfit2a_andaya] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [sfit2a_andaya] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [sfit2a_andaya] SET ARITHABORT OFF 
GO
ALTER DATABASE [sfit2a_andaya] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [sfit2a_andaya] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [sfit2a_andaya] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [sfit2a_andaya] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [sfit2a_andaya] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [sfit2a_andaya] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [sfit2a_andaya] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [sfit2a_andaya] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [sfit2a_andaya] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [sfit2a_andaya] SET  DISABLE_BROKER 
GO
ALTER DATABASE [sfit2a_andaya] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [sfit2a_andaya] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [sfit2a_andaya] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [sfit2a_andaya] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [sfit2a_andaya] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [sfit2a_andaya] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [sfit2a_andaya] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [sfit2a_andaya] SET RECOVERY FULL 
GO
ALTER DATABASE [sfit2a_andaya] SET  MULTI_USER 
GO
ALTER DATABASE [sfit2a_andaya] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [sfit2a_andaya] SET DB_CHAINING OFF 
GO
ALTER DATABASE [sfit2a_andaya] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [sfit2a_andaya] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [sfit2a_andaya] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [sfit2a_andaya] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'sfit2a_andaya', N'ON'
GO
ALTER DATABASE [sfit2a_andaya] SET QUERY_STORE = OFF
GO
USE [sfit2a_andaya]
GO
/****** Object:  Table [dbo].[admin]    Script Date: 22/12/2024 1:06:39 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
 CONSTRAINT [PK_admin] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [sfit2a_andaya] SET  READ_WRITE 
GO
