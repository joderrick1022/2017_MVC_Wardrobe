USE [master]
GO
/****** Object:  Database [Wardrobe2017]    Script Date: 11/7/2017 5:22:02 AM ******/
CREATE DATABASE [Wardrobe2017]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Wardrobe2017', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Wardrobe2017.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Wardrobe2017_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Wardrobe2017_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Wardrobe2017] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Wardrobe2017].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Wardrobe2017] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Wardrobe2017] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Wardrobe2017] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Wardrobe2017] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Wardrobe2017] SET ARITHABORT OFF 
GO
ALTER DATABASE [Wardrobe2017] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Wardrobe2017] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Wardrobe2017] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Wardrobe2017] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Wardrobe2017] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Wardrobe2017] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Wardrobe2017] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Wardrobe2017] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Wardrobe2017] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Wardrobe2017] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Wardrobe2017] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Wardrobe2017] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Wardrobe2017] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Wardrobe2017] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Wardrobe2017] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Wardrobe2017] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Wardrobe2017] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Wardrobe2017] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Wardrobe2017] SET  MULTI_USER 
GO
ALTER DATABASE [Wardrobe2017] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Wardrobe2017] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Wardrobe2017] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Wardrobe2017] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Wardrobe2017] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Wardrobe2017]
GO
/****** Object:  Table [dbo].[Categorty_Type]    Script Date: 11/7/2017 5:22:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categorty_Type](
	[TypeId] [int] IDENTITY(1,1) NOT NULL,
	[Categories] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Categorty_Type] PRIMARY KEY CLUSTERED 
(
	[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Wardrobe_Items]    Script Date: 11/7/2017 5:22:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Wardrobe_Items](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[TypeID] [int] NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Photo] [nvarchar](100) NOT NULL,
	[Color] [nvarchar](100) NOT NULL,
	[Season] [varchar](100) NULL,
	[Occasion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Wardrobe_Items] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Wardrobe_Items]  WITH CHECK ADD  CONSTRAINT [FK_Wardrobe_Items_Categorty_Type] FOREIGN KEY([TypeID])
REFERENCES [dbo].[Categorty_Type] ([TypeId])
GO
ALTER TABLE [dbo].[Wardrobe_Items] CHECK CONSTRAINT [FK_Wardrobe_Items_Categorty_Type]
GO
USE [master]
GO
ALTER DATABASE [Wardrobe2017] SET  READ_WRITE 
GO
