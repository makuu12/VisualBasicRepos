USE [master]
GO
/****** Object:  Database [sfit2a_trigger]    Script Date: 22/12/2024 1:16:41 pm ******/
CREATE DATABASE [sfit2a_trigger]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'sfit2a_trigger', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL_SERVER\MSSQL\DATA\sfit2a_trigger.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'sfit2a_trigger_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL_SERVER\MSSQL\DATA\sfit2a_trigger_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [sfit2a_trigger] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [sfit2a_trigger].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [sfit2a_trigger] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [sfit2a_trigger] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [sfit2a_trigger] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [sfit2a_trigger] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [sfit2a_trigger] SET ARITHABORT OFF 
GO
ALTER DATABASE [sfit2a_trigger] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [sfit2a_trigger] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [sfit2a_trigger] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [sfit2a_trigger] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [sfit2a_trigger] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [sfit2a_trigger] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [sfit2a_trigger] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [sfit2a_trigger] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [sfit2a_trigger] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [sfit2a_trigger] SET  DISABLE_BROKER 
GO
ALTER DATABASE [sfit2a_trigger] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [sfit2a_trigger] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [sfit2a_trigger] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [sfit2a_trigger] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [sfit2a_trigger] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [sfit2a_trigger] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [sfit2a_trigger] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [sfit2a_trigger] SET RECOVERY FULL 
GO
ALTER DATABASE [sfit2a_trigger] SET  MULTI_USER 
GO
ALTER DATABASE [sfit2a_trigger] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [sfit2a_trigger] SET DB_CHAINING OFF 
GO
ALTER DATABASE [sfit2a_trigger] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [sfit2a_trigger] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [sfit2a_trigger] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [sfit2a_trigger] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'sfit2a_trigger', N'ON'
GO
ALTER DATABASE [sfit2a_trigger] SET QUERY_STORE = OFF
GO
USE [sfit2a_trigger]
GO
/****** Object:  Table [dbo].[tblCart]    Script Date: 22/12/2024 1:16:42 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCart](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[invoiceno] [nvarchar](50) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[price] [decimal](18, 2) NOT NULL,
	[qty] [int] NOT NULL,
	[total] [decimal](18, 2) NULL,
 CONSTRAINT [PK_tblCart] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[insert1]    Script Date: 22/12/2024 1:16:42 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insert1]
    @invoiceno1 nvarchar(50),
    @description1 nvarchar(MAX),
    @price1 decimal(18,2),
    @qty1 int
   
AS
BEGIN

    SET NOCOUNT ON;

    -- Insert statements for procedure here
    INSERT INTO tblCart (invoiceno, description, price, qty) VALUES (@invoiceno1, @description1, @price1, @qty1)
END
GO
USE [master]
GO
ALTER DATABASE [sfit2a_trigger] SET  READ_WRITE 
GO
