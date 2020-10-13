USE [master]
GO
/****** Object:  Database [QLVATLIEU]    Script Date: 30/05/2019 10:48:52 CH ******/
CREATE DATABASE [QLVATLIEU]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLVATLIEU', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLVATLIEU.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLVATLIEU_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLVATLIEU_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLVATLIEU] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLVATLIEU].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLVATLIEU] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLVATLIEU] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLVATLIEU] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLVATLIEU] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLVATLIEU] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLVATLIEU] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLVATLIEU] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLVATLIEU] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLVATLIEU] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLVATLIEU] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLVATLIEU] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLVATLIEU] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLVATLIEU] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLVATLIEU] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLVATLIEU] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLVATLIEU] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLVATLIEU] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLVATLIEU] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLVATLIEU] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLVATLIEU] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLVATLIEU] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLVATLIEU] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLVATLIEU] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLVATLIEU] SET  MULTI_USER 
GO
ALTER DATABASE [QLVATLIEU] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLVATLIEU] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLVATLIEU] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLVATLIEU] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLVATLIEU] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QLVATLIEU]
GO
/****** Object:  Table [dbo].[GIOHANG]    Script Date: 30/05/2019 10:48:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIOHANG](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[MaHH] [nvarchar](10) NULL,
	[MaNV] [nvarchar](10) NULL,
	[TenHH] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[Thanhtien] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HANGHOA]    Script Date: 30/05/2019 10:48:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANGHOA](
	[MaHH] [nvarchar](10) NOT NULL,
	[TenHH] [nvarchar](50) NULL,
	[MaNCC] [nvarchar](10) NULL,
	[LoaiHang] [nvarchar](50) NULL,
	[NhanHieu] [nvarchar](50) NULL,
	[DonGia] [float] NULL DEFAULT ((0)),
	[DonGiaNhap] [float] NULL DEFAULT ((0)),
	[SoLuongcon] [int] NULL DEFAULT ((0)),
	[MoTa] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 30/05/2019 10:48:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaKH] [nvarchar](10) NULL,
	[MaNV] [nvarchar](10) NULL,
	[ngayban] [date] NULL,
	[MaHH] [nvarchar](10) NULL,
	[TenHH] [nvarchar](10) NULL,
	[DonGia] [float] NULL,
	[soluong] [int] NULL,
	[ThanhTien] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 30/05/2019 10:48:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [nvarchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Sdt] [nvarchar](11) NULL,
	[GioiTinh] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 30/05/2019 10:48:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MaNCC] [nvarchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDT] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 30/05/2019 10:48:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nvarchar](10) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[quyentruycap] [nvarchar](50) NULL,
	[TenNV] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[gioitinh] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nhaphang]    Script Date: 30/05/2019 10:48:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhaphang](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [nvarchar](10) NULL,
	[ngaynhap] [date] NULL DEFAULT (getdate()),
	[MaHH] [nvarchar](10) NULL,
	[TenHH] [nvarchar](10) NULL,
	[DonGia] [float] NULL,
	[soluong] [int] NULL,
	[ThanhTien] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaNCC], [LoaiHang], [NhanHieu], [DonGia], [DonGiaNhap], [SoLuongcon], [MoTa]) VALUES (N'HH1', N'ram', N'NCC1', N'linh kien', N'sony', 30000, 20000, 10, N'khong')
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [MaNCC], [LoaiHang], [NhanHieu], [DonGia], [DonGiaNhap], [SoLuongcon], [MoTa]) VALUES (N'HH2', N'ram', N'NCC2', N'linh kien', N'sony', 500000, 23300, 6, N'khong')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [DiaChi], [Sdt], [GioiTinh]) VALUES (N'174653490', N'HN', CAST(N'2019-05-30' AS Date), N'hn', N'0345648295', N'Nam')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [DiaChi], [Sdt], [GioiTinh]) VALUES (N'174653495', N'ccc', CAST(N'2019-05-30' AS Date), N'hn', N'0345648295', N'Nam')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SoDT], [Email]) VALUES (N'NCC1', N'sony1', N'Hà Nội', N'0345648295', N'quyet@gmail.com')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SoDT], [Email]) VALUES (N'NCC2', N'sony2', N'Hà Nội', N'0345648296', N'quyet@gmail.com')
INSERT [dbo].[NHANVIEN] ([MaNV], [MatKhau], [quyentruycap], [TenNV], [NgaySinh], [DiaChi], [SDT], [gioitinh]) VALUES (N'admin', N'123456', N'admin', N'nguyen va a', CAST(N'1995-02-16' AS Date), N'ha noi', N'01664561995', 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [MatKhau], [quyentruycap], [TenNV], [NgaySinh], [DiaChi], [SDT], [gioitinh]) VALUES (N'admin3', N'123456', N'admin', N'nguyen van B', CAST(N'1995-02-16' AS Date), N'Hà Nội', N'01664561995', 1)
SET IDENTITY_INSERT [dbo].[nhaphang] ON 

INSERT [dbo].[nhaphang] ([STT], [MaNV], [ngaynhap], [MaHH], [TenHH], [DonGia], [soluong], [ThanhTien]) VALUES (1, N'admin', CAST(N'2019-05-30' AS Date), N'HH2', N'ram', 10000, 2, 20000)
INSERT [dbo].[nhaphang] ([STT], [MaNV], [ngaynhap], [MaHH], [TenHH], [DonGia], [soluong], [ThanhTien]) VALUES (2, N'admin', CAST(N'2019-05-30' AS Date), N'HH3', N'ram', 0, 4, 0)
INSERT [dbo].[nhaphang] ([STT], [MaNV], [ngaynhap], [MaHH], [TenHH], [DonGia], [soluong], [ThanhTien]) VALUES (3, N'admin', CAST(N'2019-05-30' AS Date), N'HH8', N'ram', 20000, 10, 200000)
INSERT [dbo].[nhaphang] ([STT], [MaNV], [ngaynhap], [MaHH], [TenHH], [DonGia], [soluong], [ThanhTien]) VALUES (4, N'admin', CAST(N'2019-05-30' AS Date), N'HH8', N'ram', 20000, 10, 200000)
INSERT [dbo].[nhaphang] ([STT], [MaNV], [ngaynhap], [MaHH], [TenHH], [DonGia], [soluong], [ThanhTien]) VALUES (5, N'admin', CAST(N'2019-05-30' AS Date), N'HH9', N'ram', 20000, 10, 200000)
SET IDENTITY_INSERT [dbo].[nhaphang] OFF
ALTER TABLE [dbo].[HOADON] ADD  DEFAULT (getdate()) FOR [ngayban]
GO
ALTER TABLE [dbo].[GIOHANG]  WITH CHECK ADD FOREIGN KEY([MaHH])
REFERENCES [dbo].[HANGHOA] ([MaHH])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GIOHANG]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HANGHOA]  WITH CHECK ADD FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NHACUNGCAP] ([MaNCC])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[nhaphang]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
/****** Object:  StoredProcedure [dbo].[thongtinhoadon]    Script Date: 30/05/2019 10:48:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[thongtinhoadon]
@makh nvarchar(10)
as
select KHACHHANG.MaKH, TenKH,NgaySinh,DiaChi,Sdt,GioiTinh,MaNV,mahh,tenhh,soluong,ngayban,ThanhTien from KHACHHANG join HOADON on KHACHHANG.MaKH = HOADON.MaKH where KHACHHANG.MaKH = @makh and DAY(ngayban) = DAY(GETDATE()) and MONTH(ngayban) = MONTH(GETDATE()) and YEAR(ngayban) = YEAR(GETDATE())

exec thongtinhoadon '1234567'

select * from khachhang

GO
USE [master]
GO
ALTER DATABASE [QLVATLIEU] SET  READ_WRITE 
GO
