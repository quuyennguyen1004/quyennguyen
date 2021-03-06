USE [master]
GO
/****** Object:  Database [Web]    Script Date: 7/9/2021 9:09:49 PM ******/
CREATE DATABASE [Web]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Web', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Web.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Web_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Web_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Web] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Web].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Web] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Web] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Web] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Web] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Web] SET ARITHABORT OFF 
GO
ALTER DATABASE [Web] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Web] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Web] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Web] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Web] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Web] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Web] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Web] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Web] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Web] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Web] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Web] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Web] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Web] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Web] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Web] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Web] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Web] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Web] SET  MULTI_USER 
GO
ALTER DATABASE [Web] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Web] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Web] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Web] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Web] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Web]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 7/9/2021 9:09:49 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 7/9/2021 9:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 7/9/2021 9:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 7/9/2021 9:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 7/9/2021 9:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 7/9/2021 9:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 7/9/2021 9:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[FullName] [nvarchar](30) NULL,
	[Dienthoai] [nvarchar](max) NULL,
	[Birthday] [datetime2](7) NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 7/9/2021 9:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Categories]    Script Date: 7/9/2021 9:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Comments]    Script Date: 7/9/2021 9:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
	[ComId] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[Content] [nvarchar](max) NULL,
	[Created] [datetime2](7) NOT NULL,
	[Rating] [int] NOT NULL,
	[UserId] [nvarchar](450) NULL,
 CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED 
(
	[ComId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 7/9/2021 9:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderDetailId] [int] IDENTITY(1,1) NOT NULL,
	[Quantity] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[OrderId] [int] NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orders]    Script Date: 7/9/2021 9:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[OrderDate] [datetime2](7) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[DiaChi] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NOT NULL,
	[isConfirm] [bit] NOT NULL,
	[UserId] [nvarchar](450) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 7/9/2021 9:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](max) NULL,
	[ProductQuantity] [int] NOT NULL,
	[ProductImage] [nvarchar](max) NULL,
	[Color] [nvarchar](max) NULL,
	[Ram] [nvarchar](max) NULL,
	[Batterycapacity] [nvarchar](max) NULL,
	[Screen] [nvarchar](max) NULL,
	[Rearcamera] [nvarchar](max) NULL,
	[Frontcamera] [nvarchar](max) NULL,
	[Chipset] [nvarchar](max) NULL,
	[ProductPrice] [float] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[Descriptions] [nvarchar](max) NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PurcharseHis]    Script Date: 7/9/2021 9:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurcharseHis](
	[PurcharseHisId] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NULL,
	[ProductId] [int] NULL,
 CONSTRAINT [PK_PurcharseHis] PRIMARY KEY CLUSTERED 
(
	[PurcharseHisId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210709134431_InitData', N'5.0.1')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210709134452_SeedData', N'5.0.1')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210709134516_CreatingIdentity', N'5.0.1')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210709134528_InsertedRoles', N'5.0.1')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'8c92be80-eed5-480c-a430-452ada4f0d5c', N'Administrator', N'ADMINISTRATOR', N'937b717f-6ba0-4b9f-ae78-0fb7442f0af0')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'd0c0815b-0c02-479b-b33d-3105217e5103', N'Visitor', N'VISITOR', N'4a787677-7903-4b87-8ed2-7b0122ebfed4')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4040fbd4-7efe-4b37-ba4f-cbf84af978fa', N'8c92be80-eed5-480c-a430-452ada4f0d5c')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'51a88326-c797-44ec-b5e6-113ba183b253', N'd0c0815b-0c02-479b-b33d-3105217e5103')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7a9b1f13-0662-4290-8e24-ffb10a5440bc', N'd0c0815b-0c02-479b-b33d-3105217e5103')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a018b6ac-f3d6-4380-a404-d85de249609c', N'd0c0815b-0c02-479b-b33d-3105217e5103')
INSERT [dbo].[AspNetUsers] ([Id], [FullName], [Dienthoai], [Birthday], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'4040fbd4-7efe-4b37-ba4f-cbf84af978fa', N'admin', NULL, CAST(N'2021-07-14 00:00:00.0000000' AS DateTime2), N'admin@gmail.com', N'ADMIN@GMAIL.COM', N'admin@gmail.com', N'ADMIN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEMGMYKvKlr2ikM3hz3Ug7Fa97LEDCzAV51DUMplopLUBzUZ8BrYveuvO/nC3xovstQ==', N'JSJ33C3HVPJFED7YAD5CETUG72AHCHI5', N'8e74f899-6457-40dc-b7e9-f4f5d35cbd00', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FullName], [Dienthoai], [Birthday], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'51a88326-c797-44ec-b5e6-113ba183b253', N'a', NULL, CAST(N'2021-07-15 00:00:00.0000000' AS DateTime2), N'a@gmai.com', N'A@GMAI.COM', N'a@gmai.com', N'A@GMAI.COM', 0, N'AQAAAAEAACcQAAAAENMU9c09ufILBSUj5bp54gpD1FQCwcMeVevnLNbxXHRVfkJ6yQcm36beToiimvM3ag==', N'5MPNQGNTWXBQXC4VMKIJZKAEHTW6RQTQ', N'2deb6e2c-6078-4f96-9aad-de74f2e1e1b2', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FullName], [Dienthoai], [Birthday], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'7a9b1f13-0662-4290-8e24-ffb10a5440bc', N'quyen', NULL, NULL, N'quyen@gmail.com', N'QUYEN@GMAIL.COM', N'quyen@gmail.com', N'QUYEN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEBFHtvQrlzTCPvNwZBMI/8lE/VxgJnR9XRp1N9gIzh8Krw4ElADoBHxOwbem7YHNqA==', N'QKYIJMHTR44F4BRYUB7DACWHI54UPD6O', N'a18d4a07-bc84-4fc2-a4bc-6a100a793c37', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FullName], [Dienthoai], [Birthday], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'a018b6ac-f3d6-4380-a404-d85de249609c', N'quy', NULL, NULL, N'quy@gmail.com', N'QUY@GMAIL.COM', N'quy@gmail.com', N'QUY@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEKiglmtqdnocqGdtlkFIMYmKvQavKtMwmJzFMaJ5UrlVBQau7bfD1XlYNVPYPgw92A==', N'NWGGHBKTXBVIYCASQ5QS3YC6M3XLERUR', N'c5293aed-9dcc-470a-a63d-da7d6aedfc49', NULL, 0, 0, NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (1, N'Iphone')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (2, N'SamSung')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (3, N'Oppo')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (4, N'Xiaomi')
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[Comments] ON 

INSERT [dbo].[Comments] ([ComId], [ProductId], [Content], [Created], [Rating], [UserId]) VALUES (1, 1, N'ghe', CAST(N'2021-07-09 20:50:18.1000151' AS DateTime2), 5, N'7a9b1f13-0662-4290-8e24-ffb10a5440bc')
INSERT [dbo].[Comments] ([ComId], [ProductId], [Content], [Created], [Rating], [UserId]) VALUES (2, 1, N'tot', CAST(N'2021-07-09 20:52:46.1871715' AS DateTime2), 3, N'a018b6ac-f3d6-4380-a404-d85de249609c')
INSERT [dbo].[Comments] ([ComId], [ProductId], [Content], [Created], [Rating], [UserId]) VALUES (3, 1, N'ok', CAST(N'2021-07-09 20:56:46.2310170' AS DateTime2), 4, N'4040fbd4-7efe-4b37-ba4f-cbf84af978fa')
INSERT [dbo].[Comments] ([ComId], [ProductId], [Content], [Created], [Rating], [UserId]) VALUES (4, 2, N'ok', CAST(N'2021-07-09 20:56:54.5395153' AS DateTime2), 4, N'4040fbd4-7efe-4b37-ba4f-cbf84af978fa')
INSERT [dbo].[Comments] ([ComId], [ProductId], [Content], [Created], [Rating], [UserId]) VALUES (5, 1, N'aaaa', CAST(N'2021-07-09 20:58:29.1781194' AS DateTime2), 5, N'4040fbd4-7efe-4b37-ba4f-cbf84af978fa')
SET IDENTITY_INSERT [dbo].[Comments] OFF
SET IDENTITY_INSERT [dbo].[OrderDetails] ON 

INSERT [dbo].[OrderDetails] ([OrderDetailId], [Quantity], [ProductId], [OrderId]) VALUES (1, 0, 1, 1)
SET IDENTITY_INSERT [dbo].[OrderDetails] OFF
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderId], [OrderDate], [Name], [DiaChi], [Phone], [isConfirm], [UserId]) VALUES (1, CAST(N'2021-07-16 20:50:00.0000000' AS DateTime2), N'quyen', N'hcmm', N'0979694479', 1, NULL)
SET IDENTITY_INSERT [dbo].[Orders] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductQuantity], [ProductImage], [Color], [Ram], [Batterycapacity], [Screen], [Rearcamera], [Frontcamera], [Chipset], [ProductPrice], [CreateDate], [Descriptions], [CategoryId]) VALUES (1, N'IphoneX', 100, N'ip.png', N'Black', N'3GB', N'2716 mAh', N'OLED, 5.8 Super Retina', N'2 camera 12 MP', N'7 MP', N'Apple A11 Bionic 6 nhân', 500, CAST(N'2021-07-09 20:45:27.5854958' AS DateTime2), N'iphoneX 256GB', 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductQuantity], [ProductImage], [Color], [Ram], [Batterycapacity], [Screen], [Rearcamera], [Frontcamera], [Chipset], [ProductPrice], [CreateDate], [Descriptions], [CategoryId]) VALUES (2, N'Iphone 8 Plus', 90, N'ip.png', N'Gold', N'3 GB', N'2691 mAh', N'Full HD (1080 x 1920 pixels)', N'2 camera 12 MP', N'7 MP', N'Apple A11 Bionic', 200, CAST(N'2021-07-09 20:45:27.5863566' AS DateTime2), N'iphone8+ 64GB', 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductQuantity], [ProductImage], [Color], [Ram], [Batterycapacity], [Screen], [Rearcamera], [Frontcamera], [Chipset], [ProductPrice], [CreateDate], [Descriptions], [CategoryId]) VALUES (3, N'Iphone 11 ProMax', 26, N'ip.png', N'Black', N'4 GB', N'3.969 mAh', N' OLED', N'12 MP + 12 MP + 12 MP', N'12 MP, f/2.2', N'Apple A13 Bionic', 700, CAST(N'2021-07-09 20:45:27.5863596' AS DateTime2), N'iphone11 ProMax 512GB', 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductQuantity], [ProductImage], [Color], [Ram], [Batterycapacity], [Screen], [Rearcamera], [Frontcamera], [Chipset], [ProductPrice], [CreateDate], [Descriptions], [CategoryId]) VALUES (4, N'SamSung Galaxy Note9', 46, N'ip.png', N'Blue', N'6GB', N'4000 mAh', N'Super AMOLED, 6.4, Quad HD + (2K +)', N'2 camera 12 MP', N'8 MP', N'Exynos 9810 8 nhân 64 bit', 550, CAST(N'2021-07-09 20:45:27.5863600' AS DateTime2), N'SamSung Note 9-128GB ', 2)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductQuantity], [ProductImage], [Color], [Ram], [Batterycapacity], [Screen], [Rearcamera], [Frontcamera], [Chipset], [ProductPrice], [CreateDate], [Descriptions], [CategoryId]) VALUES (5, N'SamSung Galaxy S10', 98, N'ip.png', N'Black', N'8GB', N'4500 mAh', N'Dynamic AMOLED 6.7'''' FullHD+ , 16 triệu màu', N'10 MP & TOF 3D ( 2 Camera )', N'24 MP & 10MP & 8 MP (3 camera)', N'Exynos 9820 8 nhân 64-bit', 720, CAST(N'2021-07-09 20:45:27.5863602' AS DateTime2), N'SamSung S10-256GB ', 2)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductQuantity], [ProductImage], [Color], [Ram], [Batterycapacity], [Screen], [Rearcamera], [Frontcamera], [Chipset], [ProductPrice], [CreateDate], [Descriptions], [CategoryId]) VALUES (6, N'Oppo A92', 92, N'ip.png', N'White', N'8GB', N'5000 mAh', N'IPS LCD, 6.5,Full HD + ', N'Chính 48 MP & Phụ 8 MP, 2 MP, 2 MP', N'16 MP', N'Snapdragon 665 8 nhân', 192, CAST(N'2021-07-09 20:45:27.5863603' AS DateTime2), N'OppoA92-256GB ', 3)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductQuantity], [ProductImage], [Color], [Ram], [Batterycapacity], [Screen], [Rearcamera], [Frontcamera], [Chipset], [ProductPrice], [CreateDate], [Descriptions], [CategoryId]) VALUES (7, N'Oppo Reno3', 70, N'ip.png', N'Pink', N'8GB', N'4025 mAh', N'AMOLED, 6.4, Full HD + ', N'Chính 48 MP & Phụ 13 MP, 8 MP, 2 MP', N'44 MP', N'MediaTek Helio P90 8 nhân', 300, CAST(N'2021-07-09 20:45:27.5863605' AS DateTime2), N'Oppo Reno3-256GB ', 3)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductQuantity], [ProductImage], [Color], [Ram], [Batterycapacity], [Screen], [Rearcamera], [Frontcamera], [Chipset], [ProductPrice], [CreateDate], [Descriptions], [CategoryId]) VALUES (8, N'XiaoMi Black Shark3', 22, N'ip.png', N'Black', N'8GB', N'4720 mAh', N'Amoled', N'camera chính 64 MP f/1.8, camera góc rộng 13 MP f/2.25, Portrait mode 5 MP f/2.2', N'20 MP, f/2.2', N'Qualcomm Adreno 650', 600, CAST(N'2021-07-09 20:45:27.5863607' AS DateTime2), N'Xiaomi Black Shark3-128GB ', 4)
SET IDENTITY_INSERT [dbo].[Products] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 7/9/2021 9:09:49 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [RoleNameIndex]    Script Date: 7/9/2021 9:09:49 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 7/9/2021 9:09:49 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 7/9/2021 9:09:49 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 7/9/2021 9:09:49 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [EmailIndex]    Script Date: 7/9/2021 9:09:49 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UserNameIndex]    Script Date: 7/9/2021 9:09:49 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Comments_ProductId]    Script Date: 7/9/2021 9:09:49 PM ******/
CREATE NONCLUSTERED INDEX [IX_Comments_ProductId] ON [dbo].[Comments]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Comments_UserId]    Script Date: 7/9/2021 9:09:49 PM ******/
CREATE NONCLUSTERED INDEX [IX_Comments_UserId] ON [dbo].[Comments]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderDetails_OrderId]    Script Date: 7/9/2021 9:09:49 PM ******/
CREATE NONCLUSTERED INDEX [IX_OrderDetails_OrderId] ON [dbo].[OrderDetails]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderDetails_ProductId]    Script Date: 7/9/2021 9:09:49 PM ******/
CREATE NONCLUSTERED INDEX [IX_OrderDetails_ProductId] ON [dbo].[OrderDetails]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Orders_UserId]    Script Date: 7/9/2021 9:09:49 PM ******/
CREATE NONCLUSTERED INDEX [IX_Orders_UserId] ON [dbo].[Orders]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_CategoryId]    Script Date: 7/9/2021 9:09:49 PM ******/
CREATE NONCLUSTERED INDEX [IX_Products_CategoryId] ON [dbo].[Products]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PurcharseHis_OrderId]    Script Date: 7/9/2021 9:09:49 PM ******/
CREATE NONCLUSTERED INDEX [IX_PurcharseHis_OrderId] ON [dbo].[PurcharseHis]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PurcharseHis_ProductId]    Script Date: 7/9/2021 9:09:49 PM ******/
CREATE NONCLUSTERED INDEX [IX_PurcharseHis_ProductId] ON [dbo].[PurcharseHis]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_Comments_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Comments_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_Comments_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductId])
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Comments_Products_ProductId]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([OrderId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders_OrderId]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products_ProductId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories_CategoryId]
GO
ALTER TABLE [dbo].[PurcharseHis]  WITH CHECK ADD  CONSTRAINT [FK_PurcharseHis_Orders_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([OrderId])
GO
ALTER TABLE [dbo].[PurcharseHis] CHECK CONSTRAINT [FK_PurcharseHis_Orders_OrderId]
GO
ALTER TABLE [dbo].[PurcharseHis]  WITH CHECK ADD  CONSTRAINT [FK_PurcharseHis_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductId])
GO
ALTER TABLE [dbo].[PurcharseHis] CHECK CONSTRAINT [FK_PurcharseHis_Products_ProductId]
GO
USE [master]
GO
ALTER DATABASE [Web] SET  READ_WRITE 
GO
