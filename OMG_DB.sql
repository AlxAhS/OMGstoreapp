USE [master]
GO
/****** Object:  Database [OMGsupplyDB]    Script Date: 19/02/2023 12:09:06 pm ******/
CREATE DATABASE [OMGsupplyDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OMGsupplyDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL_SERVER_AHS\MSSQL\DATA\OMGsupplyDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OMGsupplyDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL_SERVER_AHS\MSSQL\DATA\OMGsupplyDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [OMGsupplyDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OMGsupplyDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OMGsupplyDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OMGsupplyDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OMGsupplyDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OMGsupplyDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OMGsupplyDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [OMGsupplyDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OMGsupplyDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OMGsupplyDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OMGsupplyDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OMGsupplyDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OMGsupplyDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OMGsupplyDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OMGsupplyDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OMGsupplyDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OMGsupplyDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [OMGsupplyDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OMGsupplyDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OMGsupplyDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OMGsupplyDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OMGsupplyDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OMGsupplyDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [OMGsupplyDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OMGsupplyDB] SET RECOVERY FULL 
GO
ALTER DATABASE [OMGsupplyDB] SET  MULTI_USER 
GO
ALTER DATABASE [OMGsupplyDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OMGsupplyDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OMGsupplyDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OMGsupplyDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OMGsupplyDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [OMGsupplyDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'OMGsupplyDB', N'ON'
GO
ALTER DATABASE [OMGsupplyDB] SET QUERY_STORE = OFF
GO
USE [OMGsupplyDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 19/02/2023 12:09:06 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 19/02/2023 12:09:06 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[IdType] [nvarchar](6) NULL,
	[IDNumber] [nvarchar](25) NULL,
	[Email] [nvarchar](40) NULL,
	[PhoneNumber] [nvarchar](12) NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoices]    Script Date: 19/02/2023 12:09:06 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoices](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [nvarchar](30) NOT NULL,
	[Serial] [nvarchar](10) NULL,
 CONSTRAINT [PK_Invoices] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 19/02/2023 12:09:06 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StoreInfo]    Script Date: 19/02/2023 12:09:06 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StoreInfo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NIT] [nvarchar](20) NULL,
	[OwnerName] [nvarchar](30) NULL,
	[Address] [nvarchar](20) NULL,
	[City] [nvarchar](16) NULL,
	[State] [nvarchar](20) NULL,
	[Phone] [nvarchar](20) NULL,
	[AccountNumber] [nvarchar](20) NULL,
 CONSTRAINT [PK_StoreInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230219155623_newmigration', N'7.0.2')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230219165843_SeedingData', N'7.0.2')
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([ID], [Name], [IdType], [IDNumber], [Email], [PhoneNumber]) VALUES (1, N'Juan', N'CC', N'232131', N'juan@gmail.com', N'0644445532')
INSERT [dbo].[Clients] ([ID], [Name], [IdType], [IDNumber], [Email], [PhoneNumber]) VALUES (2, N'Pedro', N'CC', N'45423498', N'pedro@gmail.com', N'06432324884')
INSERT [dbo].[Clients] ([ID], [Name], [IdType], [IDNumber], [Email], [PhoneNumber]) VALUES (3, N'Alberto', N'CE', N'2349895-2', N'alberto@gmail.com', N'3117758739')
SET IDENTITY_INSERT [dbo].[Clients] OFF
GO
SET IDENTITY_INSERT [dbo].[Invoices] ON 

INSERT [dbo].[Invoices] ([ID], [Date], [Serial]) VALUES (1, N'2023-02-19 16:58:43.2661354', N'234234342')
INSERT [dbo].[Invoices] ([ID], [Date], [Serial]) VALUES (2, N'2023-02-19 16:58:43.2661358', N'3423432422')
INSERT [dbo].[Invoices] ([ID], [Date], [Serial]) VALUES (3, N'2023-02-19 16:58:43.2661361', N'878342223')
SET IDENTITY_INSERT [dbo].[Invoices] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ID], [Name], [Price]) VALUES (1, N'Cellphone', 450000)
INSERT [dbo].[Products] ([ID], [Name], [Price]) VALUES (2, N'PlayStation 4', 2000000)
INSERT [dbo].[Products] ([ID], [Name], [Price]) VALUES (3, N'Laptop', 3000000)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[StoreInfo] ON 

INSERT [dbo].[StoreInfo] ([ID], [NIT], [OwnerName], [Address], [City], [State], [Phone], [AccountNumber]) VALUES (1, N'98712311-3', N'Jhon Smith', N'Av Siempre Viva 123', N'Springfield', N'Columbia', N'3134435498', N'4560393234289')
SET IDENTITY_INSERT [dbo].[StoreInfo] OFF
GO
USE [master]
GO
ALTER DATABASE [OMGsupplyDB] SET  READ_WRITE 
GO
