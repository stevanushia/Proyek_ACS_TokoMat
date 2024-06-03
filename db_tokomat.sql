USE [master]
GO
/****** Object:  Database [db_tokomat]    Script Date: 5/31/2024 7:24:36 AM ******/
CREATE DATABASE [db_tokomat]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_tokomat', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\db_tokomat.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_tokomat_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\db_tokomat_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [db_tokomat] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_tokomat].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_tokomat] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_tokomat] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_tokomat] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_tokomat] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_tokomat] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_tokomat] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_tokomat] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_tokomat] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_tokomat] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_tokomat] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_tokomat] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_tokomat] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_tokomat] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_tokomat] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_tokomat] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_tokomat] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_tokomat] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_tokomat] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_tokomat] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_tokomat] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_tokomat] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_tokomat] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_tokomat] SET RECOVERY FULL 
GO
ALTER DATABASE [db_tokomat] SET  MULTI_USER 
GO
ALTER DATABASE [db_tokomat] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_tokomat] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_tokomat] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_tokomat] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_tokomat] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_tokomat] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'db_tokomat', N'ON'
GO
ALTER DATABASE [db_tokomat] SET QUERY_STORE = ON
GO
ALTER DATABASE [db_tokomat] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [db_tokomat]
GO
/****** Object:  Table [dbo].[barang]    Script Date: 5/31/2024 7:24:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[barang](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nama] [nvarchar](100) NOT NULL,
	[qty] [int] NOT NULL,
	[hargajual] [int] NOT NULL,
	[hargabeli] [int] NOT NULL,
	[status] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dpo]    Script Date: 5/31/2024 7:24:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dpo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[hpo] [int] NOT NULL,
	[barang] [int] NOT NULL,
	[qty] [int] NOT NULL,
	[subtotal] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dtrans]    Script Date: 5/31/2024 7:24:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dtrans](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[htrans] [int] NOT NULL,
	[barang] [int] NOT NULL,
	[qty] [int] NOT NULL,
	[UnitPrice] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hpo]    Script Date: 5/31/2024 7:24:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hpo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[supplier] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[date_ordered] [datetime] NULL,
	[date_arrived] [datetime] NULL,
	[total_bill] [int] NULL,
	[total_paid] [int] NULL,
	[status] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[htrans]    Script Date: 5/31/2024 7:24:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[htrans](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[sale_date] [datetime] NOT NULL,
	[total_amount] [int] NULL,
	[total_paid] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[retur]    Script Date: 5/31/2024 7:24:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[retur](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[SupplierID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[ReturnDate] [datetime] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Reason] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[supplier]    Script Date: 5/31/2024 7:24:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[supplier](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nama] [nvarchar](100) NOT NULL,
	[kontak] [nvarchar](255) NULL,
	[status] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 5/31/2024 7:24:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nama] [nvarchar](100) NOT NULL,
	[password] [nvarchar](100) NOT NULL,
	[status] [nvarchar](255) NOT NULL,
	[Role] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[barang] ON 

INSERT [dbo].[barang] ([id], [nama], [qty], [hargajual], [hargabeli], [status]) VALUES (1, N'Saus Tartar', 10, 15000, 10000, N'Available')
INSERT [dbo].[barang] ([id], [nama], [qty], [hargajual], [hargabeli], [status]) VALUES (2, N'Meja', 2, 25000, 10000, N'Available')
SET IDENTITY_INSERT [dbo].[barang] OFF
GO
SET IDENTITY_INSERT [dbo].[dpo] ON 

INSERT [dbo].[dpo] ([id], [hpo], [barang], [qty], [subtotal]) VALUES (1, 4, 1, 1, 10000)
INSERT [dbo].[dpo] ([id], [hpo], [barang], [qty], [subtotal]) VALUES (2, 4, 2, 1, 10000)
SET IDENTITY_INSERT [dbo].[dpo] OFF
GO
SET IDENTITY_INSERT [dbo].[hpo] ON 

INSERT [dbo].[hpo] ([id], [supplier], [UserID], [date_ordered], [date_arrived], [total_bill], [total_paid], [status]) VALUES (1, 1, 1, CAST(N'2024-05-30T22:33:45.000' AS DateTime), CAST(N'2024-05-30T22:33:45.000' AS DateTime), 90000, 0, N'Pending')
INSERT [dbo].[hpo] ([id], [supplier], [UserID], [date_ordered], [date_arrived], [total_bill], [total_paid], [status]) VALUES (2, 1, 1, CAST(N'2024-05-30T22:57:51.000' AS DateTime), CAST(N'2024-05-30T22:57:51.000' AS DateTime), 100000, 0, N'Pending')
INSERT [dbo].[hpo] ([id], [supplier], [UserID], [date_ordered], [date_arrived], [total_bill], [total_paid], [status]) VALUES (3, 1, 1, CAST(N'2024-05-30T23:07:15.000' AS DateTime), CAST(N'2024-05-30T23:07:15.000' AS DateTime), 20000, 0, N'Pending')
INSERT [dbo].[hpo] ([id], [supplier], [UserID], [date_ordered], [date_arrived], [total_bill], [total_paid], [status]) VALUES (4, 1, 1, CAST(N'2024-05-30T23:10:16.000' AS DateTime), CAST(N'2024-05-30T23:10:16.000' AS DateTime), 20000, 0, N'Pending')
SET IDENTITY_INSERT [dbo].[hpo] OFF
GO
SET IDENTITY_INSERT [dbo].[supplier] ON 

INSERT [dbo].[supplier] ([id], [nama], [kontak], [status]) VALUES (1, N'Budi Supratmana', N'182308123', N'Aktif')
SET IDENTITY_INSERT [dbo].[supplier] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([id], [nama], [password], [status], [Role]) VALUES (1, N'admin', N'admin', N'aktif', N'admin')
SET IDENTITY_INSERT [dbo].[users] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__users__6E2DBEDE363661D4]    Script Date: 5/31/2024 7:24:37 AM ******/
ALTER TABLE [dbo].[users] ADD UNIQUE NONCLUSTERED 
(
	[password] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[dpo]  WITH CHECK ADD FOREIGN KEY([barang])
REFERENCES [dbo].[barang] ([id])
GO
ALTER TABLE [dbo].[dpo]  WITH CHECK ADD FOREIGN KEY([hpo])
REFERENCES [dbo].[hpo] ([id])
GO
ALTER TABLE [dbo].[dtrans]  WITH CHECK ADD FOREIGN KEY([barang])
REFERENCES [dbo].[barang] ([id])
GO
ALTER TABLE [dbo].[dtrans]  WITH CHECK ADD FOREIGN KEY([htrans])
REFERENCES [dbo].[htrans] ([id])
GO
ALTER TABLE [dbo].[hpo]  WITH CHECK ADD FOREIGN KEY([supplier])
REFERENCES [dbo].[supplier] ([id])
GO
ALTER TABLE [dbo].[hpo]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[htrans]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[retur]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[barang] ([id])
GO
ALTER TABLE [dbo].[retur]  WITH CHECK ADD FOREIGN KEY([SupplierID])
REFERENCES [dbo].[supplier] ([id])
GO
ALTER TABLE [dbo].[retur]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[users] ([id])
GO
USE [master]
GO
ALTER DATABASE [db_tokomat] SET  READ_WRITE 
GO
