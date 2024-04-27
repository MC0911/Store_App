USE [master]
GO
/****** Object:  Database [DoAnCoSo]    Script Date: 13/6/2023 12:03:51 PM ******/
CREATE DATABASE [DoAnCoSo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DoAnCoSo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DoAnCoSo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DoAnCoSo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DoAnCoSo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DoAnCoSo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DoAnCoSo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DoAnCoSo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DoAnCoSo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DoAnCoSo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DoAnCoSo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DoAnCoSo] SET ARITHABORT OFF 
GO
ALTER DATABASE [DoAnCoSo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DoAnCoSo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DoAnCoSo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DoAnCoSo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DoAnCoSo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DoAnCoSo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DoAnCoSo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DoAnCoSo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DoAnCoSo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DoAnCoSo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DoAnCoSo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DoAnCoSo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DoAnCoSo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DoAnCoSo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DoAnCoSo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DoAnCoSo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DoAnCoSo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DoAnCoSo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DoAnCoSo] SET  MULTI_USER 
GO
ALTER DATABASE [DoAnCoSo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DoAnCoSo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DoAnCoSo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DoAnCoSo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DoAnCoSo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DoAnCoSo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DoAnCoSo] SET QUERY_STORE = OFF
GO
USE [DoAnCoSo]
GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 13/6/2023 12:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfo](
	[Id] [int] NOT NULL,
	[Id_HangHoa] [nchar](10) NULL,
	[Id_HDN] [nchar](10) NULL,
	[Id_HDX] [nchar](10) NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_BillInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 13/6/2023 12:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[Id] [nchar](10) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Id_Loaihh] [int] NULL,
	[Ncc] [nvarchar](255) NULL,
	[Entry_price] [int] NULL,
	[Price] [int] NULL,
	[Unit] [nvarchar](50) NULL,
	[HSD] [date] NULL,
	[NSX] [date] NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_HangHoa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonNhap]    Script Date: 13/6/2023 12:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonNhap](
	[MaNhap] [nchar](10) NOT NULL,
	[MaHangHoa] [nchar](10) NOT NULL,
	[TenHangHoa] [nvarchar](255) NULL,
	[Ncc] [nvarchar](255) NULL,
	[GiaNhap] [int] NULL,
	[SoLuong] [int] NULL,
	[NgayNhap] [date] NULL,
 CONSTRAINT [PK_HoaDonNhap_1] PRIMARY KEY CLUSTERED 
(
	[MaNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonXuat]    Script Date: 13/6/2023 12:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonXuat](
	[MaXuat] [nchar](10) NOT NULL,
	[MaHangHoa] [nchar](10) NOT NULL,
	[TenHangHoa] [nvarchar](255) NULL,
	[Ncc] [nvarchar](255) NULL,
	[GiaXuat] [int] NULL,
	[SoLuong] [int] NULL,
	[NgayXuat] [datetime] NULL,
 CONSTRAINT [PK_HoaDonXuat_1] PRIMARY KEY CLUSTERED 
(
	[MaXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiHangHoa]    Script Date: 13/6/2023 12:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHangHoa](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_LoaiHangHoa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 13/6/2023 12:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](255) NOT NULL,
	[SDT] [nchar](12) NULL,
	[Email] [nvarchar](255) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[NgaySinh] [date] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 13/6/2023 12:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[id_user] [int] IDENTITY(1,1) NOT NULL,
	[permission] [nvarchar](50) NOT NULL,
	[username] [nchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[email] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_TaiKhoan_1] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[HangHoa] ([Id], [Name], [Id_Loaihh], [Ncc], [Entry_price], [Price], [Unit], [HSD], [NSX], [Quantity]) VALUES (N'HH01      ', N'Bánh quy Cosy', 1, N'Kinh đô', 15000, 30000, N'Hộp', CAST(N'2024-09-05' AS Date), CAST(N'2023-06-06' AS Date), 20)
INSERT [dbo].[HangHoa] ([Id], [Name], [Id_Loaihh], [Ncc], [Entry_price], [Price], [Unit], [HSD], [NSX], [Quantity]) VALUES (N'HH02      ', N'Bánh Chocopie', 1, N'Orion', 20000, 40000, N'Hộp', CAST(N'2024-09-05' AS Date), CAST(N'2023-06-06' AS Date), 30)
INSERT [dbo].[HangHoa] ([Id], [Name], [Id_Loaihh], [Ncc], [Entry_price], [Price], [Unit], [HSD], [NSX], [Quantity]) VALUES (N'HH03      ', N'Bánh quy bơ Danisa', 1, N'Danisa', 150000, 250000, N'Hộp', CAST(N'2024-09-05' AS Date), CAST(N'2023-06-06' AS Date), 15)
INSERT [dbo].[HangHoa] ([Id], [Name], [Id_Loaihh], [Ncc], [Entry_price], [Price], [Unit], [HSD], [NSX], [Quantity]) VALUES (N'HH04      ', N'Kẹo Oshi', 2, N'Oshi', 5000, 12000, N'Bịch', CAST(N'2024-05-10' AS Date), CAST(N'2023-06-06' AS Date), 30)
INSERT [dbo].[HangHoa] ([Id], [Name], [Id_Loaihh], [Ncc], [Entry_price], [Price], [Unit], [HSD], [NSX], [Quantity]) VALUES (N'HH05      ', N'Kẹo Dynamite Bạc Hà', 2, N'Dynamite', 6000, 15000, N'Bịch', CAST(N'2024-05-10' AS Date), CAST(N'2023-06-06' AS Date), 30)
INSERT [dbo].[HangHoa] ([Id], [Name], [Id_Loaihh], [Ncc], [Entry_price], [Price], [Unit], [HSD], [NSX], [Quantity]) VALUES (N'HH06      ', N'Nước ngọt CocaCola', 3, N'CocaCola', 30000, 60000, N'Lốc 6 lon', CAST(N'2025-10-05' AS Date), CAST(N'2023-06-06' AS Date), 30)
INSERT [dbo].[HangHoa] ([Id], [Name], [Id_Loaihh], [Ncc], [Entry_price], [Price], [Unit], [HSD], [NSX], [Quantity]) VALUES (N'HH07      ', N'Nước ngọt CocaCola ', 3, N'CocaCola', 150000, 250000, N'Thùng 24 lon', CAST(N'2025-10-05' AS Date), CAST(N'2023-06-06' AS Date), 10)
INSERT [dbo].[HangHoa] ([Id], [Name], [Id_Loaihh], [Ncc], [Entry_price], [Price], [Unit], [HSD], [NSX], [Quantity]) VALUES (N'HH08      ', N'Nước ngọt Pepsi vị canh 0 calo', 3, N'Pepsi', 140000, 230000, N'Thùng 24 lon', CAST(N'2025-10-05' AS Date), CAST(N'2023-06-06' AS Date), 10)
INSERT [dbo].[HangHoa] ([Id], [Name], [Id_Loaihh], [Ncc], [Entry_price], [Price], [Unit], [HSD], [NSX], [Quantity]) VALUES (N'HH09      ', N'Nước ngọt Pepsi vị chanh 0 calo', 3, N'Pepsi', 50000, 100000, N'Lốc 6 lon', CAST(N'2025-10-05' AS Date), CAST(N'2023-06-06' AS Date), 20)
INSERT [dbo].[HangHoa] ([Id], [Name], [Id_Loaihh], [Ncc], [Entry_price], [Price], [Unit], [HSD], [NSX], [Quantity]) VALUES (N'HH10      ', N'Nước ngọt Mirinda soda xanh', 3, N'Mirinda', 200000, 320000, N'Thùng 24 lon', CAST(N'2025-10-05' AS Date), CAST(N'2023-06-06' AS Date), 10)
INSERT [dbo].[HangHoa] ([Id], [Name], [Id_Loaihh], [Ncc], [Entry_price], [Price], [Unit], [HSD], [NSX], [Quantity]) VALUES (N'HH11      ', N'Nước ngọt Mirinda soda xanh', 3, N'Mirinda', 30000, 50000, N'Lốc 6 lon', CAST(N'2025-10-05' AS Date), CAST(N'2023-06-06' AS Date), 20)
INSERT [dbo].[HangHoa] ([Id], [Name], [Id_Loaihh], [Ncc], [Entry_price], [Price], [Unit], [HSD], [NSX], [Quantity]) VALUES (N'HH12      ', N'Bột Giặt ABA', 4, N'ABA', 100000, 200000, N'Bịch lớn', CAST(N'2023-06-01' AS Date), CAST(N'2025-06-01' AS Date), 20)
INSERT [dbo].[HangHoa] ([Id], [Name], [Id_Loaihh], [Ncc], [Entry_price], [Price], [Unit], [HSD], [NSX], [Quantity]) VALUES (N'HH13      ', N'Bột Giặt ABA', 4, N'ABA', 20000, 40000, N'Bịch nhỏ', CAST(N'2023-06-01' AS Date), CAST(N'2025-06-01' AS Date), 100)
INSERT [dbo].[HangHoa] ([Id], [Name], [Id_Loaihh], [Ncc], [Entry_price], [Price], [Unit], [HSD], [NSX], [Quantity]) VALUES (N'HH14      ', N'Bột Giặt Comfort', 4, N'Comfort', 30000, 50000, N'Bịch nhỏ', CAST(N'2025-06-01' AS Date), CAST(N'2023-06-01' AS Date), 100)
INSERT [dbo].[HangHoa] ([Id], [Name], [Id_Loaihh], [Ncc], [Entry_price], [Price], [Unit], [HSD], [NSX], [Quantity]) VALUES (N'HH15      ', N'Bột Giặt Comfort', 4, N'Comfort', 120000, 240000, N'Bịch lớn', CAST(N'2025-06-01' AS Date), CAST(N'2023-06-01' AS Date), 30)
INSERT [dbo].[HangHoa] ([Id], [Name], [Id_Loaihh], [Ncc], [Entry_price], [Price], [Unit], [HSD], [NSX], [Quantity]) VALUES (N'HH16      ', N'Khăn tắm Soybean', 1, N'Soybean', 5000, 100000, N'Bịch 5 cái', CAST(N'2023-06-01' AS Date), CAST(N'2030-06-01' AS Date), 20)
GO
INSERT [dbo].[HoaDonNhap] ([MaNhap], [MaHangHoa], [TenHangHoa], [Ncc], [GiaNhap], [SoLuong], [NgayNhap]) VALUES (N'MN01      ', N'HH01      ', N'Bánh quy Cosy', N'Kinh đô', 15000, 20, CAST(N'2023-06-01' AS Date))
INSERT [dbo].[HoaDonNhap] ([MaNhap], [MaHangHoa], [TenHangHoa], [Ncc], [GiaNhap], [SoLuong], [NgayNhap]) VALUES (N'MN02      ', N'HH02      ', N'Bánh Chocopie', N'Orion', 20000, 11, CAST(N'2023-06-09' AS Date))
INSERT [dbo].[HoaDonNhap] ([MaNhap], [MaHangHoa], [TenHangHoa], [Ncc], [GiaNhap], [SoLuong], [NgayNhap]) VALUES (N'MN03      ', N'HH11      ', N'Nước ngọt Mirinda soda xanh', N'Mirinda', 30000, 6, CAST(N'2023-06-01' AS Date))
INSERT [dbo].[HoaDonNhap] ([MaNhap], [MaHangHoa], [TenHangHoa], [Ncc], [GiaNhap], [SoLuong], [NgayNhap]) VALUES (N'MN04      ', N'HH05      ', N'Kẹo Dynamite Bạc Hà', N'Dynamite', 6000, 6, CAST(N'2023-06-18' AS Date))
INSERT [dbo].[HoaDonNhap] ([MaNhap], [MaHangHoa], [TenHangHoa], [Ncc], [GiaNhap], [SoLuong], [NgayNhap]) VALUES (N'MN05      ', N'HH06      ', N'Nước ngọt CocaCola', N'CocaCola', 30000, 10, CAST(N'2023-07-01' AS Date))
INSERT [dbo].[HoaDonNhap] ([MaNhap], [MaHangHoa], [TenHangHoa], [Ncc], [GiaNhap], [SoLuong], [NgayNhap]) VALUES (N'MN06      ', N'HH16      ', N'Khăn tắm Soybean', N'Soybean', 5000, 10, CAST(N'2023-07-01' AS Date))
INSERT [dbo].[HoaDonNhap] ([MaNhap], [MaHangHoa], [TenHangHoa], [Ncc], [GiaNhap], [SoLuong], [NgayNhap]) VALUES (N'MN07      ', N'HH15      ', N'Bột Giặt Comfort', N'Comfort', 120000, 10, CAST(N'2023-07-01' AS Date))
INSERT [dbo].[HoaDonNhap] ([MaNhap], [MaHangHoa], [TenHangHoa], [Ncc], [GiaNhap], [SoLuong], [NgayNhap]) VALUES (N'MN08      ', N'HH14      ', N'Bột Giặt Comfort', N'Comfort', 30000, 10, CAST(N'2023-07-01' AS Date))
INSERT [dbo].[HoaDonNhap] ([MaNhap], [MaHangHoa], [TenHangHoa], [Ncc], [GiaNhap], [SoLuong], [NgayNhap]) VALUES (N'MN09      ', N'HH01      ', N'Bánh quy Cosy', N'Kinh đô', 15000, 5, CAST(N'2023-07-01' AS Date))
INSERT [dbo].[HoaDonNhap] ([MaNhap], [MaHangHoa], [TenHangHoa], [Ncc], [GiaNhap], [SoLuong], [NgayNhap]) VALUES (N'MN10      ', N'HH03      ', N'Bánh quy bơ Danisa', N'Danisa', 150000, 5, CAST(N'2023-07-01' AS Date))
INSERT [dbo].[HoaDonNhap] ([MaNhap], [MaHangHoa], [TenHangHoa], [Ncc], [GiaNhap], [SoLuong], [NgayNhap]) VALUES (N'MN11      ', N'HH08      ', N'Nước ngọt Pepsi vị canh 0 calo', N'Pepsi', 140000, 7, CAST(N'2023-07-01' AS Date))
INSERT [dbo].[HoaDonNhap] ([MaNhap], [MaHangHoa], [TenHangHoa], [Ncc], [GiaNhap], [SoLuong], [NgayNhap]) VALUES (N'MN12      ', N'HH02      ', N'Bánh Chocopie', N'Orion', 20000, 5, CAST(N'2023-07-01' AS Date))
GO
INSERT [dbo].[HoaDonXuat] ([MaXuat], [MaHangHoa], [TenHangHoa], [Ncc], [GiaXuat], [SoLuong], [NgayXuat]) VALUES (N'MX01      ', N'HH01      ', N'Bánh quy Cosy', N'Kinh đô', 30000, 10, CAST(N'2023-06-09T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDonXuat] ([MaXuat], [MaHangHoa], [TenHangHoa], [Ncc], [GiaXuat], [SoLuong], [NgayXuat]) VALUES (N'MX02      ', N'HH03      ', N'Bánh quy bơ Danisa', N'Danisa', 250000, 5, CAST(N'2023-06-09T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDonXuat] ([MaXuat], [MaHangHoa], [TenHangHoa], [Ncc], [GiaXuat], [SoLuong], [NgayXuat]) VALUES (N'MX03      ', N'HH02      ', N'Bánh Chocopie', N'Orion', 40000, 10, CAST(N'2023-06-09T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDonXuat] ([MaXuat], [MaHangHoa], [TenHangHoa], [Ncc], [GiaXuat], [SoLuong], [NgayXuat]) VALUES (N'MX04      ', N'HH08      ', N'Nước ngọt Pepsi vị canh 0 calo', N'Pepsi', 230000, 20, CAST(N'2023-06-09T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDonXuat] ([MaXuat], [MaHangHoa], [TenHangHoa], [Ncc], [GiaXuat], [SoLuong], [NgayXuat]) VALUES (N'MX05      ', N'HH11      ', N'Nước ngọt Mirinda soda xanh', N'Mirinda', 50000, 10, CAST(N'2023-06-09T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDonXuat] ([MaXuat], [MaHangHoa], [TenHangHoa], [Ncc], [GiaXuat], [SoLuong], [NgayXuat]) VALUES (N'MX06      ', N'HH09      ', N'Nước ngọt Pepsi vị chanh 0 calo', N'Pepsi', 100000, 10, CAST(N'2023-06-09T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDonXuat] ([MaXuat], [MaHangHoa], [TenHangHoa], [Ncc], [GiaXuat], [SoLuong], [NgayXuat]) VALUES (N'MX07      ', N'HH04      ', N'Kẹo Oshi', N'Oshi', 12000, 8, CAST(N'2023-06-09T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDonXuat] ([MaXuat], [MaHangHoa], [TenHangHoa], [Ncc], [GiaXuat], [SoLuong], [NgayXuat]) VALUES (N'MX08      ', N'HH05      ', N'Kẹo Dynamite Bạc Hà', N'Dynamite', 15000, 10, CAST(N'2023-06-09T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDonXuat] ([MaXuat], [MaHangHoa], [TenHangHoa], [Ncc], [GiaXuat], [SoLuong], [NgayXuat]) VALUES (N'MX09      ', N'HH06      ', N'Nước ngọt CocaCola', N'CocaCola', 60000, 5, CAST(N'2023-06-09T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDonXuat] ([MaXuat], [MaHangHoa], [TenHangHoa], [Ncc], [GiaXuat], [SoLuong], [NgayXuat]) VALUES (N'MX10      ', N'HH07      ', N'Nước ngọt CocaCola ', N'CocaCola', 250000, 5, CAST(N'2023-06-09T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDonXuat] ([MaXuat], [MaHangHoa], [TenHangHoa], [Ncc], [GiaXuat], [SoLuong], [NgayXuat]) VALUES (N'MX11      ', N'HH10      ', N'Nước ngọt Mirinda soda xanh', N'Mirinda', 320000, 5, CAST(N'2023-06-09T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDonXuat] ([MaXuat], [MaHangHoa], [TenHangHoa], [Ncc], [GiaXuat], [SoLuong], [NgayXuat]) VALUES (N'MX12      ', N'HH01      ', N'Bánh quy Cosy', N'Kinh đô', 30000, 10, CAST(N'2023-07-07T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDonXuat] ([MaXuat], [MaHangHoa], [TenHangHoa], [Ncc], [GiaXuat], [SoLuong], [NgayXuat]) VALUES (N'MX13      ', N'HH02      ', N'Bánh Chocopie', N'Orion', 40000, 10, CAST(N'2023-07-07T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDonXuat] ([MaXuat], [MaHangHoa], [TenHangHoa], [Ncc], [GiaXuat], [SoLuong], [NgayXuat]) VALUES (N'MX14      ', N'HH03      ', N'Bánh quy bơ Danisa', N'Danisa', 250000, 10, CAST(N'2023-07-07T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDonXuat] ([MaXuat], [MaHangHoa], [TenHangHoa], [Ncc], [GiaXuat], [SoLuong], [NgayXuat]) VALUES (N'MX15      ', N'HH04      ', N'Kẹo Oshi', N'Oshi', 12000, 15, CAST(N'2023-07-07T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDonXuat] ([MaXuat], [MaHangHoa], [TenHangHoa], [Ncc], [GiaXuat], [SoLuong], [NgayXuat]) VALUES (N'MX16      ', N'HH05      ', N'Kẹo Dynamite Bạc Hà', N'Dynamite', 15000, 15, CAST(N'2023-07-07T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDonXuat] ([MaXuat], [MaHangHoa], [TenHangHoa], [Ncc], [GiaXuat], [SoLuong], [NgayXuat]) VALUES (N'MX17      ', N'HH06      ', N'Nước ngọt CocaCola', N'CocaCola', 60000, 5, CAST(N'2023-07-07T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDonXuat] ([MaXuat], [MaHangHoa], [TenHangHoa], [Ncc], [GiaXuat], [SoLuong], [NgayXuat]) VALUES (N'MX18      ', N'HH07      ', N'Nước ngọt CocaCola ', N'CocaCola', 250000, 5, CAST(N'2023-07-07T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDonXuat] ([MaXuat], [MaHangHoa], [TenHangHoa], [Ncc], [GiaXuat], [SoLuong], [NgayXuat]) VALUES (N'MX19      ', N'HH08      ', N'Nước ngọt Pepsi vị canh 0 calo', N'Pepsi', 230000, 20, CAST(N'2023-07-07T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDonXuat] ([MaXuat], [MaHangHoa], [TenHangHoa], [Ncc], [GiaXuat], [SoLuong], [NgayXuat]) VALUES (N'MX20      ', N'HH09      ', N'Nước ngọt Pepsi vị chanh 0 calo', N'Pepsi', 100000, 20, CAST(N'2023-07-07T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDonXuat] ([MaXuat], [MaHangHoa], [TenHangHoa], [Ncc], [GiaXuat], [SoLuong], [NgayXuat]) VALUES (N'MX21      ', N'HH10      ', N'Nước ngọt Mirinda soda xanh', N'Mirinda', 320000, 10, CAST(N'2023-07-07T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDonXuat] ([MaXuat], [MaHangHoa], [TenHangHoa], [Ncc], [GiaXuat], [SoLuong], [NgayXuat]) VALUES (N'MX22      ', N'HH11      ', N'Nước ngọt Mirinda soda xanh', N'Mirinda', 50000, 10, CAST(N'2023-07-07T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[LoaiHangHoa] ON 

INSERT [dbo].[LoaiHangHoa] ([Id], [Name]) VALUES (1, N'Bánh')
INSERT [dbo].[LoaiHangHoa] ([Id], [Name]) VALUES (2, N'Kẹo')
INSERT [dbo].[LoaiHangHoa] ([Id], [Name]) VALUES (3, N'Nước')
INSERT [dbo].[LoaiHangHoa] ([Id], [Name]) VALUES (4, N'Bột giặt')
INSERT [dbo].[LoaiHangHoa] ([Id], [Name]) VALUES (5, N'Khăn')
INSERT [dbo].[LoaiHangHoa] ([Id], [Name]) VALUES (6, N'Nước hoa')
INSERT [dbo].[LoaiHangHoa] ([Id], [Name]) VALUES (7, N'Dầu gội')
INSERT [dbo].[LoaiHangHoa] ([Id], [Name]) VALUES (8, N'Sữa tắm')
INSERT [dbo].[LoaiHangHoa] ([Id], [Name]) VALUES (9, N'Bàn chải')
INSERT [dbo].[LoaiHangHoa] ([Id], [Name]) VALUES (10, N'Vở')
INSERT [dbo].[LoaiHangHoa] ([Id], [Name]) VALUES (11, N'Pin')
SET IDENTITY_INSERT [dbo].[LoaiHangHoa] OFF
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [Email], [DiaChi], [NgaySinh]) VALUES (N'NV1       ', N'Hà Mạnh Cường', N'0862727024  ', N'hamanhcuong9a1@gmail.com', N'017 Bùi Công Trừng', CAST(N'2002-11-09' AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [Email], [DiaChi], [NgaySinh]) VALUES (N'NV2       ', N'Nam', N'0123456789  ', N'manh@gmail.com', N'42 Bùi Thị Xuân', CAST(N'2001-08-02' AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [Email], [DiaChi], [NgaySinh]) VALUES (N'NV3       ', N'Tài', N'0131345674  ', N'tai@gmail.com', N'Hẻm 42 Bùi Thị Xuân', CAST(N'2002-04-21' AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [Email], [DiaChi], [NgaySinh]) VALUES (N'NV4       ', N'Khoa', N'0131345675  ', N'khoa@gmail.com', N'Hẻm 43 Bùi Thị Xuân', CAST(N'2002-05-15' AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [Email], [DiaChi], [NgaySinh]) VALUES (N'NV5       ', N'Hào', N'01314151617 ', N'hao@gmail.com', N'Hẻm 31 Bùi Thị Xuân', CAST(N'2002-06-26' AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [Email], [DiaChi], [NgaySinh]) VALUES (N'NV6       ', N'Huy', N'0212223242  ', N'huy@gmail.com', N'Hẻm 49 Bùi Thị Xuân', CAST(N'2002-08-11' AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [Email], [DiaChi], [NgaySinh]) VALUES (N'NV7       ', N'Thái', N'0999945678  ', N'thai@gmail.com', N'Hẻm 99 Bùi Thị Xuân', CAST(N'2002-09-09' AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [Email], [DiaChi], [NgaySinh]) VALUES (N'NV8       ', N'Anhh', N'0921211233  ', N'Anhh@gmail.com', N'Hẻm 19 Bùi Thị Xuân', CAST(N'2002-10-15' AS Date))
GO
SET IDENTITY_INSERT [dbo].[TaiKhoan] ON 

INSERT [dbo].[TaiKhoan] ([id_user], [permission], [username], [password], [email]) VALUES (1, N'Admin', N'cuong                                             ', N'123456a', N'hamanhcuong9a1@gmail.com')
INSERT [dbo].[TaiKhoan] ([id_user], [permission], [username], [password], [email]) VALUES (2, N'Staff', N'nam                                               ', N'123123a', N'nam@gmail.com')
INSERT [dbo].[TaiKhoan] ([id_user], [permission], [username], [password], [email]) VALUES (4, N'Staff', N'abc2                                              ', N'111111a', N'a2@gmail.com')
INSERT [dbo].[TaiKhoan] ([id_user], [permission], [username], [password], [email]) VALUES (5, N'Staff', N'buz                                               ', N'111111a', N'byz@gmail.com')
SET IDENTITY_INSERT [dbo].[TaiKhoan] OFF
GO
ALTER TABLE [dbo].[HangHoa] ADD  CONSTRAINT [DF_HangHoa_Id_Loaihh]  DEFAULT ((0)) FOR [Id_Loaihh]
GO
ALTER TABLE [dbo].[HangHoa] ADD  CONSTRAINT [DF_HangHoa_GiaNhap]  DEFAULT ((0)) FOR [Entry_price]
GO
ALTER TABLE [dbo].[HangHoa] ADD  CONSTRAINT [DF_HangHoa_GiaBan]  DEFAULT ((0)) FOR [Price]
GO
ALTER TABLE [dbo].[HangHoa] ADD  CONSTRAINT [DF_HangHoa_SoLuong]  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[TaiKhoan] ADD  CONSTRAINT [DF_TaiKhoan_permission]  DEFAULT ((0)) FOR [permission]
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD  CONSTRAINT [FK_BillInfo_HangHoa] FOREIGN KEY([Id_HangHoa])
REFERENCES [dbo].[HangHoa] ([Id])
GO
ALTER TABLE [dbo].[BillInfo] CHECK CONSTRAINT [FK_BillInfo_HangHoa]
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD  CONSTRAINT [FK_BillInfo_HoaDonNhap] FOREIGN KEY([Id_HDN])
REFERENCES [dbo].[HoaDonNhap] ([MaNhap])
GO
ALTER TABLE [dbo].[BillInfo] CHECK CONSTRAINT [FK_BillInfo_HoaDonNhap]
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD  CONSTRAINT [FK_BillInfo_HoaDonXuat] FOREIGN KEY([Id_HDX])
REFERENCES [dbo].[HoaDonXuat] ([MaXuat])
GO
ALTER TABLE [dbo].[BillInfo] CHECK CONSTRAINT [FK_BillInfo_HoaDonXuat]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_LoaiHangHoa] FOREIGN KEY([Id_Loaihh])
REFERENCES [dbo].[LoaiHangHoa] ([Id])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_LoaiHangHoa]
GO
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNhap_HangHoa] FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[HangHoa] ([Id])
GO
ALTER TABLE [dbo].[HoaDonNhap] CHECK CONSTRAINT [FK_HoaDonNhap_HangHoa]
GO
ALTER TABLE [dbo].[HoaDonXuat]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonXuat_HangHoa] FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[HangHoa] ([Id])
GO
ALTER TABLE [dbo].[HoaDonXuat] CHECK CONSTRAINT [FK_HoaDonXuat_HangHoa]
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillExportByDate]    Script Date: 13/6/2023 12:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetListBillExportByDate]
@ngayxuat date
AS
BEGIN
	SELECT MaXuat AS [Mã xuất], MaHangHoa AS [Mã hàng hóa], TenHangHoa AS [Tên hàng hóa], Ncc AS [Nhà cung cấp], GiaXuat AS [Giá xuất], SoLuong AS [Số lượng], NgayXuat AS [Ngày xuất] 
	FROM HoaDonXuat 
	WHERE NgayXuat <= @ngayxuat AND MONTH(NgayXuat) = Month(@ngayxuat)
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillImportByDate]    Script Date: 13/6/2023 12:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetListBillImportByDate]
@ngaynhap date
AS
BEGIN
	SELECT MaNhap AS [Mã nhập], MaHangHoa AS [Mã hàng hóa], TenHangHoa AS [Tên hàng hóa], Ncc AS [Nhà cung cấp], GiaNhap AS [Giá nhập], SoLuong AS [Số lượng], NgayNhap AS [Ngày nhập] 
	FROM HoaDonNhap 
	WHERE NgayNhap <= @ngaynhap AND MONTH(NgayNhap) = Month(@ngaynhap)
END
GO
/****** Object:  StoredProcedure [dbo].[USP_LoadData]    Script Date: 13/6/2023 12:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_LoadData]
@MaHangHoa nchar(10)
AS
BEGIN
	SELECT Name, Ncc, Entry_price FROM HangHoa WHERE Id = @MaHangHoa
END
GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 13/6/2023 12:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_Login]
@userName nchar (50), @passWord nvarchar(50)
AS
BEGIN
	SELECT * FROM TaiKhoan WHERE username = @userName and password = @passWord
END
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateAccount]    Script Date: 13/6/2023 12:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateAccount]
@username nvarchar(50), @password nvarchar(50), @newpass nvarchar(50)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	SELECT @isRightPass = COUNT(*) FROM DBO.TaiKhoan WHERE username = @username AND password = @password

	IF (@isRightPass = 1)
	BEGIN
		IF (@newpass = NULL OR @newpass = '')
		BEGIN
			return
		END
		ELSE
			UPDATE DBO.TaiKhoan SET password = @newpass WHERE username = @username
	END
END
GO
USE [master]
GO
ALTER DATABASE [DoAnCoSo] SET  READ_WRITE 
GO
