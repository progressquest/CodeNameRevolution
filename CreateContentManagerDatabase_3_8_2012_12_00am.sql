USE [master]
GO
/****** Object:  Database [ContentManager]    Script Date: 03/08/2012 00:00:41 ******/
CREATE DATABASE [ContentManager] ON  PRIMARY 
( NAME = N'ContentManager', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\ContentManager.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ContentManager_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\ContentManager_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ContentManager] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ContentManager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ContentManager] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [ContentManager] SET ANSI_NULLS OFF
GO
ALTER DATABASE [ContentManager] SET ANSI_PADDING OFF
GO
ALTER DATABASE [ContentManager] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [ContentManager] SET ARITHABORT OFF
GO
ALTER DATABASE [ContentManager] SET AUTO_CLOSE ON
GO
ALTER DATABASE [ContentManager] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [ContentManager] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [ContentManager] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [ContentManager] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [ContentManager] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [ContentManager] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [ContentManager] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [ContentManager] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [ContentManager] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [ContentManager] SET  DISABLE_BROKER
GO
ALTER DATABASE [ContentManager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [ContentManager] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [ContentManager] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [ContentManager] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [ContentManager] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [ContentManager] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [ContentManager] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [ContentManager] SET  READ_WRITE
GO
ALTER DATABASE [ContentManager] SET RECOVERY SIMPLE
GO
ALTER DATABASE [ContentManager] SET  MULTI_USER
GO
ALTER DATABASE [ContentManager] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [ContentManager] SET DB_CHAINING OFF
GO
USE [ContentManager]
GO
/****** Object:  Table [dbo].[ContentManagerSetting]    Script Date: 03/08/2012 00:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContentManagerSetting](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
	[Value] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_ContentManagerSettings] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ContentManagerSetting] ON
INSERT [dbo].[ContentManagerSetting] ([ID], [Name], [Description], [Value]) VALUES (1, N'Show Deleted Characters', N'Show deleted characters in the character list in the Characters tool.', N'False')
INSERT [dbo].[ContentManagerSetting] ([ID], [Name], [Description], [Value]) VALUES (2, N'Don''t Clear Last Name', N'Don''t Clear last name from textbox after each character is added.', N'False')
INSERT [dbo].[ContentManagerSetting] ([ID], [Name], [Description], [Value]) VALUES (3, N'Don''t Clear Gender', N'Dont clear gender radio buttons after each character is added.', N'False')
SET IDENTITY_INSERT [dbo].[ContentManagerSetting] OFF
