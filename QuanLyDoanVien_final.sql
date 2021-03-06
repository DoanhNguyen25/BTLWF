USE [master]
GO
/****** Object:  Database [BTL_Windows]    Script Date: 08/20/21 10:24:30 AM ******/
CREATE DATABASE [BTL_Windows]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BTL_Windows', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\BTL_Windows.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BTL_Windows_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\BTL_Windows_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BTL_Windows] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BTL_Windows].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BTL_Windows] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BTL_Windows] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BTL_Windows] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BTL_Windows] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BTL_Windows] SET ARITHABORT OFF 
GO
ALTER DATABASE [BTL_Windows] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BTL_Windows] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BTL_Windows] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BTL_Windows] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BTL_Windows] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BTL_Windows] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BTL_Windows] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BTL_Windows] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BTL_Windows] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BTL_Windows] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BTL_Windows] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BTL_Windows] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BTL_Windows] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BTL_Windows] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BTL_Windows] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BTL_Windows] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BTL_Windows] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BTL_Windows] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BTL_Windows] SET  MULTI_USER 
GO
ALTER DATABASE [BTL_Windows] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BTL_Windows] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BTL_Windows] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BTL_Windows] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BTL_Windows] SET DELAYED_DURABILITY = DISABLED 
GO
USE [BTL_Windows]
GO
/****** Object:  Table [dbo].[CanBoDoan]    Script Date: 08/20/21 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CanBoDoan](
	[MaCB] [nchar](10) NOT NULL,
	[HoTenCB] [nvarchar](30) NULL,
	[GioiTinh] [nchar](10) NULL,
	[ChucVu] [nchar](20) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [nchar](10) NULL,
	[MaHD] [nchar](10) NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [pk_CanBoDoan] PRIMARY KEY CLUSTERED 
(
	[MaCB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoatDongDoan]    Script Date: 08/20/21 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoatDongDoan](
	[MaHD] [nchar](10) NOT NULL,
	[MaCB] [nchar](10) NULL,
	[TenHoatDong] [nvarchar](200) NULL,
	[DiaDiem] [nvarchar](100) NULL,
	[ThoiGian] [date] NULL,
 CONSTRAINT [pk_HoatDongDoan] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LopSinhHoat]    Script Date: 08/20/21 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopSinhHoat](
	[MaLop] [nchar](10) NOT NULL,
	[MaNganh] [nchar](10) NOT NULL,
	[TenLop] [nvarchar](100) NULL,
	[SiSo] [int] NULL,
 CONSTRAINT [pk_LopSinhHoat] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nganh]    Script Date: 08/20/21 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nganh](
	[MaNganh] [nchar](10) NOT NULL,
	[TenNganh] [nvarchar](100) NULL,
 CONSTRAINT [pk_Nganh] PRIMARY KEY CLUSTERED 
(
	[MaNganh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 08/20/21 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [nchar](10) NOT NULL,
	[HoTenSV] [nvarchar](30) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [nchar](15) NULL,
	[MaLop] [nchar](10) NOT NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [pk_SinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SoDoan]    Script Date: 08/20/21 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SoDoan](
	[SoSD] [nchar](10) NOT NULL,
	[ThongTin] [text] NULL,
	[NhanXet] [text] NULL,
	[MaSV] [nchar](10) NULL,
 CONSTRAINT [pk_SoDoan] PRIMARY KEY CLUSTERED 
(
	[SoSD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 08/20/21 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenDangNhap] [nchar](30) NOT NULL,
	[MatKhau] [nchar](10) NULL,
	[SoDTDKy] [nchar](12) NULL,
	[Quyen] [nchar](20) NULL,
 CONSTRAINT [pk_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThongTin_ChuyenSinhHoatDoan]    Script Date: 08/20/21 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTin_ChuyenSinhHoatDoan](
	[MaSV] [nchar](10) NOT NULL,
	[MaCB] [nchar](10) NULL,
	[NgayChuyen] [date] NULL,
	[NoiChuyenDen] [nvarchar](100) NULL,
 CONSTRAINT [pk_ThongTin_ChuyenSinhHoatDoan] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThongTin_NopDoanPhi]    Script Date: 08/20/21 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTin_NopDoanPhi](
	[MaSV] [nchar](10) NOT NULL,
	[MaCB] [nchar](10) NULL,
	[SoPhieu] [nchar](10) NOT NULL,
	[NgayNop] [date] NULL,
	[SoTien] [money] NULL,
	[NoiDung] [text] NULL,
 CONSTRAINT [pk_ThongTin_NopDoanPhi] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC,
	[SoPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThongTin_NopSoDoan]    Script Date: 08/20/21 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTin_NopSoDoan](
	[MaSV] [nchar](10) NOT NULL,
	[MaCB] [nchar](10) NULL,
	[SoSD] [nchar](10) NOT NULL,
	[NgayNop] [date] NULL,
 CONSTRAINT [pk_ThongTin_NopSoDoan] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC,
	[SoSD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThongTin_ThamGiaHoatDong]    Script Date: 08/20/21 10:24:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTin_ThamGiaHoatDong](
	[MaSV] [nchar](10) NOT NULL,
	[MaHD] [nchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC,
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[CanBoDoan] ([MaCB], [HoTenCB], [GioiTinh], [ChucVu], [DiaChi], [DienThoai], [MaHD], [TrangThai]) VALUES (N'CB01      ', N'Vũ Thị Kim Anh', N'Nữ        ', N'Bí thư              ', N'Hải Dương', N'0982527982', N'HD4       ', 1)
INSERT [dbo].[CanBoDoan] ([MaCB], [HoTenCB], [GioiTinh], [ChucVu], [DiaChi], [DienThoai], [MaHD], [TrangThai]) VALUES (N'CB02      ', N'Trần Thanh Thủy', N'Nữ        ', N'Phó bí thư          ', N'Hà Nội ', N'0973776072', N'HD1       ', 1)
INSERT [dbo].[CanBoDoan] ([MaCB], [HoTenCB], [GioiTinh], [ChucVu], [DiaChi], [DienThoai], [MaHD], [TrangThai]) VALUES (N'CB03      ', N'Ngô Mạnh Hà', N'Nam       ', N'Bí thư chi đoàn     ', N'Bắc Ninh', N'0917749254', N'HD2       ', 1)
INSERT [dbo].[CanBoDoan] ([MaCB], [HoTenCB], [GioiTinh], [ChucVu], [DiaChi], [DienThoai], [MaHD], [TrangThai]) VALUES (N'CB04      ', N'Vũ Tiến Lập', N'Nam       ', N'Bí thư              ', N'Hà Nội ', N'0904770053', N'HD3       ', 1)
INSERT [dbo].[CanBoDoan] ([MaCB], [HoTenCB], [GioiTinh], [ChucVu], [DiaChi], [DienThoai], [MaHD], [TrangThai]) VALUES (N'CB05      ', N'Trần Trung Kiên', N'Nam       ', N'Phó bí thư          ', N'Bắc Giang', N'0974880788', N'HD5       ', 1)
INSERT [dbo].[HoatDongDoan] ([MaHD], [MaCB], [TenHoatDong], [DiaDiem], [ThoiGian]) VALUES (N'HD1       ', N'CB01      ', N'Ngày hội xuân hồng', N'Trung tâm huyết học máu trung ương', CAST(N'2021-03-14' AS Date))
INSERT [dbo].[HoatDongDoan] ([MaHD], [MaCB], [TenHoatDong], [DiaDiem], [ThoiGian]) VALUES (N'HD2       ', N'CB03      ', N'Tham gia hỗ chợ phòng chóng CoVid', N'Bắc Ninh', CAST(N'2021-06-15' AS Date))
INSERT [dbo].[HoatDongDoan] ([MaHD], [MaCB], [TenHoatDong], [DiaDiem], [ThoiGian]) VALUES (N'HD3       ', N'CB04      ', N'Vì một màu xanh', N'Công viên thống nhất', CAST(N'2021-04-28' AS Date))
INSERT [dbo].[HoatDongDoan] ([MaHD], [MaCB], [TenHoatDong], [DiaDiem], [ThoiGian]) VALUES (N'HD4       ', N'CB01      ', N'Giờ trái đất', N'Hà Nội', CAST(N'2021-03-27' AS Date))
INSERT [dbo].[LopSinhHoat] ([MaLop], [MaNganh], [TenLop], [SiSo]) VALUES (N'L01       ', N'N03       ', N'KHMT1', 45)
INSERT [dbo].[LopSinhHoat] ([MaLop], [MaNganh], [TenLop], [SiSo]) VALUES (N'L02       ', N'N01       ', N'HTTT1', 20)
INSERT [dbo].[LopSinhHoat] ([MaLop], [MaNganh], [TenLop], [SiSo]) VALUES (N'L03       ', N'N01       ', N'HTTT2', 30)
INSERT [dbo].[LopSinhHoat] ([MaLop], [MaNganh], [TenLop], [SiSo]) VALUES (N'L04       ', N'N02       ', N'CNTT1', 20)
INSERT [dbo].[LopSinhHoat] ([MaLop], [MaNganh], [TenLop], [SiSo]) VALUES (N'L05       ', N'N03       ', N'KHMT2', 40)
INSERT [dbo].[LopSinhHoat] ([MaLop], [MaNganh], [TenLop], [SiSo]) VALUES (N'L06       ', N'N02       ', N'CNTT2', 25)
INSERT [dbo].[Nganh] ([MaNganh], [TenNganh]) VALUES (N'N01       ', N'Hệ thống thông tin')
INSERT [dbo].[Nganh] ([MaNganh], [TenNganh]) VALUES (N'N02       ', N'Công nghệ thông tin')
INSERT [dbo].[Nganh] ([MaNganh], [TenNganh]) VALUES (N'N03       ', N'Khoa học máy tính')
INSERT [dbo].[SinhVien] ([MaSV], [HoTenSV], [NgaySinh], [DiaChi], [DienThoai], [MaLop], [TrangThai]) VALUES (N'001       ', N'Đỗ Tuấn Anh', CAST(N'2000-10-23' AS Date), N'Vĩnh Phúc', N'0981580546     ', N'L04       ', 1)
INSERT [dbo].[SinhVien] ([MaSV], [HoTenSV], [NgaySinh], [DiaChi], [DienThoai], [MaLop], [TrangThai]) VALUES (N'002       ', N'Vũ Thị Kim Anh', CAST(N'2000-03-23' AS Date), N'Hải Dương', N'0368241690     ', N'L01       ', 0)
INSERT [dbo].[SinhVien] ([MaSV], [HoTenSV], [NgaySinh], [DiaChi], [DienThoai], [MaLop], [TrangThai]) VALUES (N'003       ', N'Hoàng Thị Mai Ảnh', CAST(N'2000-12-19' AS Date), N'Bắc Giang', N'0963427077     ', N'L03       ', 1)
INSERT [dbo].[SinhVien] ([MaSV], [HoTenSV], [NgaySinh], [DiaChi], [DienThoai], [MaLop], [TrangThai]) VALUES (N'004       ', N'Nguyễn Thị Chang', CAST(N'2000-02-28' AS Date), N'Hải Dương', N'0347541678     ', N'L01       ', 1)
INSERT [dbo].[SinhVien] ([MaSV], [HoTenSV], [NgaySinh], [DiaChi], [DienThoai], [MaLop], [TrangThai]) VALUES (N'005       ', N'Hà Mạnh Cường', CAST(N'2000-10-29' AS Date), N'Quảng Ninh', N'0336272203     ', N'L02       ', 1)
INSERT [dbo].[SinhVien] ([MaSV], [HoTenSV], [NgaySinh], [DiaChi], [DienThoai], [MaLop], [TrangThai]) VALUES (N'006       ', N'Đỗ Đại Dương', CAST(N'2000-06-04' AS Date), N'Thanh Hóa', N'0813134125     ', N'L04       ', 0)
INSERT [dbo].[SinhVien] ([MaSV], [HoTenSV], [NgaySinh], [DiaChi], [DienThoai], [MaLop], [TrangThai]) VALUES (N'007       ', N'Đỗ Hữu Đường', CAST(N'2000-03-14' AS Date), N'Nam Định', N'0966105713     ', N'L05       ', 0)
INSERT [dbo].[SinhVien] ([MaSV], [HoTenSV], [NgaySinh], [DiaChi], [DienThoai], [MaLop], [TrangThai]) VALUES (N'008       ', N'Hoàng Mạnh Duy', CAST(N'2000-12-17' AS Date), N'Thái Bình', N'0868955967     ', N'L03       ', 0)
INSERT [dbo].[SinhVien] ([MaSV], [HoTenSV], [NgaySinh], [DiaChi], [DienThoai], [MaLop], [TrangThai]) VALUES (N'009       ', N'Vũ Văn Duy', CAST(N'2000-10-22' AS Date), N'Quảng Ninh', N'0333460674     ', N'L06       ', 0)
INSERT [dbo].[SinhVien] ([MaSV], [HoTenSV], [NgaySinh], [DiaChi], [DienThoai], [MaLop], [TrangThai]) VALUES (N'010       ', N'Phạm Thị Hà', CAST(N'2000-01-28' AS Date), N'Ninh Bình', N'0966163215     ', N'L05       ', 0)
INSERT [dbo].[SinhVien] ([MaSV], [HoTenSV], [NgaySinh], [DiaChi], [DienThoai], [MaLop], [TrangThai]) VALUES (N'011       ', N'Phạm Ngọc Hải', CAST(N'2000-07-21' AS Date), N'Bắc Giang', N'0359999573     ', N'L02       ', 0)
INSERT [dbo].[SinhVien] ([MaSV], [HoTenSV], [NgaySinh], [DiaChi], [DienThoai], [MaLop], [TrangThai]) VALUES (N'012       ', N'Nguyễn Thị Hồng Hạnh', CAST(N'2000-10-21' AS Date), N'Ninh Bình', N'0971766370     ', N'L06       ', 0)
INSERT [dbo].[SoDoan] ([SoSD], [ThongTin], [NhanXet], [MaSV]) VALUES (N'S01       ', N'Do Tuan Anh', N'Nghiem tuc chap hanh tot', N'001       ')
INSERT [dbo].[SoDoan] ([SoSD], [ThongTin], [NhanXet], [MaSV]) VALUES (N'S02       ', N'Vu Thi Kim Anh', N'Hang hai nhiet tinh tham gia cac hoat dong cua doan doi', N'002       ')
INSERT [dbo].[SoDoan] ([SoSD], [ThongTin], [NhanXet], [MaSV]) VALUES (N'S03       ', N'Hoang Thi Mai Anh', N'Ki luat tot nang dong', N'003       ')
INSERT [dbo].[SoDoan] ([SoSD], [ThongTin], [NhanXet], [MaSV]) VALUES (N'S04       ', N'Nguyen Thi Chang', N'Co tinh than trach nhiem', N'004       ')
INSERT [dbo].[SoDoan] ([SoSD], [ThongTin], [NhanXet], [MaSV]) VALUES (N'S05       ', N'Ha Manh Cuong', N'Nang don sang tao', N'005       ')
INSERT [dbo].[SoDoan] ([SoSD], [ThongTin], [NhanXet], [MaSV]) VALUES (N'S06       ', N'Do Dai Duong', N'Hoat dong phong trao tot', N'006       ')
INSERT [dbo].[SoDoan] ([SoSD], [ThongTin], [NhanXet], [MaSV]) VALUES (N'S07       ', N'Do Huu Duong', N'Tich cuc tham gia cac hoat dong cua doan doi', N'007       ')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [SoDTDKy], [Quyen]) VALUES (N'anhvt                         ', N'abc       ', N'0982527982  ', N'User                ')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [SoDTDKy], [Quyen]) VALUES (N'hanm                          ', N'123       ', N'0917749254  ', N'User                ')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [SoDTDKy], [Quyen]) VALUES (N'kientt                        ', N'123       ', N'0974880788  ', N'User                ')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [SoDTDKy], [Quyen]) VALUES (N'lapvt                         ', N'456       ', N'0904770053  ', N'User                ')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [SoDTDKy], [Quyen]) VALUES (N'thuytt                        ', N'abc       ', N'0973776072  ', N'Admin               ')
INSERT [dbo].[ThongTin_ChuyenSinhHoatDoan] ([MaSV], [MaCB], [NgayChuyen], [NoiChuyenDen]) VALUES (N'002       ', N'CB01      ', CAST(N'2021-05-18' AS Date), N'Hải Dương')
INSERT [dbo].[ThongTin_ChuyenSinhHoatDoan] ([MaSV], [MaCB], [NgayChuyen], [NoiChuyenDen]) VALUES (N'005       ', N'CB04      ', CAST(N'2021-09-01' AS Date), N'Hà Nội')
INSERT [dbo].[ThongTin_ChuyenSinhHoatDoan] ([MaSV], [MaCB], [NgayChuyen], [NoiChuyenDen]) VALUES (N'006       ', N'CB04      ', CAST(N'2021-03-05' AS Date), N'Hà Nội')
INSERT [dbo].[ThongTin_ChuyenSinhHoatDoan] ([MaSV], [MaCB], [NgayChuyen], [NoiChuyenDen]) VALUES (N'007       ', N'CB03      ', CAST(N'2021-04-19' AS Date), N'Bắc Ninh')
INSERT [dbo].[ThongTin_ChuyenSinhHoatDoan] ([MaSV], [MaCB], [NgayChuyen], [NoiChuyenDen]) VALUES (N'008       ', N'CB01      ', CAST(N'2021-04-18' AS Date), N'Hải Dương')
INSERT [dbo].[ThongTin_ChuyenSinhHoatDoan] ([MaSV], [MaCB], [NgayChuyen], [NoiChuyenDen]) VALUES (N'009       ', N'CB05      ', CAST(N'2021-03-25' AS Date), N'Bắc Giang')
INSERT [dbo].[ThongTin_ChuyenSinhHoatDoan] ([MaSV], [MaCB], [NgayChuyen], [NoiChuyenDen]) VALUES (N'010       ', N'CB02      ', CAST(N'2021-03-27' AS Date), N'Hà Nội')
INSERT [dbo].[ThongTin_ChuyenSinhHoatDoan] ([MaSV], [MaCB], [NgayChuyen], [NoiChuyenDen]) VALUES (N'011       ', N'CB05      ', CAST(N'2021-05-07' AS Date), N'Bắc Giang')
INSERT [dbo].[ThongTin_ChuyenSinhHoatDoan] ([MaSV], [MaCB], [NgayChuyen], [NoiChuyenDen]) VALUES (N'012       ', N'CB03      ', CAST(N'2021-06-12' AS Date), N'Bắc Ninh')
INSERT [dbo].[ThongTin_NopDoanPhi] ([MaSV], [MaCB], [SoPhieu], [NgayNop], [SoTien], [NoiDung]) VALUES (N'001       ', N'CB05      ', N'SP01      ', CAST(N'2021-06-15' AS Date), 50000.0000, N'Nop tien doan phi')
INSERT [dbo].[ThongTin_NopDoanPhi] ([MaSV], [MaCB], [SoPhieu], [NgayNop], [SoTien], [NoiDung]) VALUES (N'002       ', N'CB03      ', N'SP02      ', CAST(N'2021-06-15' AS Date), 50000.0000, N'Nop tien doan phi')
INSERT [dbo].[ThongTin_NopDoanPhi] ([MaSV], [MaCB], [SoPhieu], [NgayNop], [SoTien], [NoiDung]) VALUES (N'003       ', N'CB02      ', N'SP03      ', CAST(N'2021-06-17' AS Date), 50000.0000, N'Nop tien doan phi')
INSERT [dbo].[ThongTin_NopDoanPhi] ([MaSV], [MaCB], [SoPhieu], [NgayNop], [SoTien], [NoiDung]) VALUES (N'004       ', N'CB05      ', N'SP04      ', CAST(N'2021-06-02' AS Date), 50000.0000, N'Nop tien doan phi')
INSERT [dbo].[ThongTin_NopDoanPhi] ([MaSV], [MaCB], [SoPhieu], [NgayNop], [SoTien], [NoiDung]) VALUES (N'005       ', N'CB01      ', N'SP05      ', CAST(N'2021-06-17' AS Date), 50000.0000, N'Nop tien doan phi')
INSERT [dbo].[ThongTin_NopDoanPhi] ([MaSV], [MaCB], [SoPhieu], [NgayNop], [SoTien], [NoiDung]) VALUES (N'006       ', N'CB01      ', N'SP06      ', CAST(N'2021-06-01' AS Date), 50000.0000, N'Nop tien doan phi')
INSERT [dbo].[ThongTin_NopDoanPhi] ([MaSV], [MaCB], [SoPhieu], [NgayNop], [SoTien], [NoiDung]) VALUES (N'007       ', N'CB05      ', N'SP07      ', CAST(N'2021-06-18' AS Date), 50000.0000, N'Nop tien doan phi')
INSERT [dbo].[ThongTin_NopDoanPhi] ([MaSV], [MaCB], [SoPhieu], [NgayNop], [SoTien], [NoiDung]) VALUES (N'008       ', N'CB04      ', N'SP08      ', CAST(N'2021-06-20' AS Date), 50000.0000, N'Nop tien doan phi')
INSERT [dbo].[ThongTin_NopSoDoan] ([MaSV], [MaCB], [SoSD], [NgayNop]) VALUES (N'001       ', N'CB05      ', N'S01       ', CAST(N'2021-07-12' AS Date))
INSERT [dbo].[ThongTin_NopSoDoan] ([MaSV], [MaCB], [SoSD], [NgayNop]) VALUES (N'002       ', N'CB02      ', N'S02       ', CAST(N'2021-07-23' AS Date))
INSERT [dbo].[ThongTin_NopSoDoan] ([MaSV], [MaCB], [SoSD], [NgayNop]) VALUES (N'003       ', N'CB04      ', N'S03       ', CAST(N'2021-06-29' AS Date))
INSERT [dbo].[ThongTin_NopSoDoan] ([MaSV], [MaCB], [SoSD], [NgayNop]) VALUES (N'004       ', N'CB03      ', N'S04       ', CAST(N'2021-06-15' AS Date))
INSERT [dbo].[ThongTin_NopSoDoan] ([MaSV], [MaCB], [SoSD], [NgayNop]) VALUES (N'005       ', N'CB05      ', N'S05       ', CAST(N'2021-07-13' AS Date))
INSERT [dbo].[ThongTin_NopSoDoan] ([MaSV], [MaCB], [SoSD], [NgayNop]) VALUES (N'006       ', N'CB02      ', N'S06       ', CAST(N'2021-07-10' AS Date))
INSERT [dbo].[ThongTin_NopSoDoan] ([MaSV], [MaCB], [SoSD], [NgayNop]) VALUES (N'007       ', N'CB01      ', N'S07       ', CAST(N'2021-06-27' AS Date))
INSERT [dbo].[ThongTin_ThamGiaHoatDong] ([MaSV], [MaHD]) VALUES (N'001       ', N'HD1       ')
INSERT [dbo].[ThongTin_ThamGiaHoatDong] ([MaSV], [MaHD]) VALUES (N'001       ', N'HD2       ')
INSERT [dbo].[ThongTin_ThamGiaHoatDong] ([MaSV], [MaHD]) VALUES (N'002       ', N'HD3       ')
INSERT [dbo].[ThongTin_ThamGiaHoatDong] ([MaSV], [MaHD]) VALUES (N'003       ', N'HD2       ')
INSERT [dbo].[ThongTin_ThamGiaHoatDong] ([MaSV], [MaHD]) VALUES (N'004       ', N'HD1       ')
ALTER TABLE [dbo].[HoatDongDoan]  WITH CHECK ADD  CONSTRAINT [fk_CanBoDoan_HoatDongDoan] FOREIGN KEY([MaCB])
REFERENCES [dbo].[CanBoDoan] ([MaCB])
GO
ALTER TABLE [dbo].[HoatDongDoan] CHECK CONSTRAINT [fk_CanBoDoan_HoatDongDoan]
GO
ALTER TABLE [dbo].[LopSinhHoat]  WITH CHECK ADD  CONSTRAINT [fk_Nganh_LopSinhHoat] FOREIGN KEY([MaNganh])
REFERENCES [dbo].[Nganh] ([MaNganh])
GO
ALTER TABLE [dbo].[LopSinhHoat] CHECK CONSTRAINT [fk_Nganh_LopSinhHoat]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [fk_Lop_SinhVien] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LopSinhHoat] ([MaLop])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [fk_Lop_SinhVien]
GO
ALTER TABLE [dbo].[SoDoan]  WITH CHECK ADD  CONSTRAINT [fk_SinhVien_SoDoan] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[SoDoan] CHECK CONSTRAINT [fk_SinhVien_SoDoan]
GO
ALTER TABLE [dbo].[ThongTin_ChuyenSinhHoatDoan]  WITH CHECK ADD  CONSTRAINT [fk_CanBoDoan_ThongTin_ChuyenSinhHoatDoan] FOREIGN KEY([MaCB])
REFERENCES [dbo].[CanBoDoan] ([MaCB])
GO
ALTER TABLE [dbo].[ThongTin_ChuyenSinhHoatDoan] CHECK CONSTRAINT [fk_CanBoDoan_ThongTin_ChuyenSinhHoatDoan]
GO
ALTER TABLE [dbo].[ThongTin_ChuyenSinhHoatDoan]  WITH CHECK ADD  CONSTRAINT [fk_SinhVien_ThongTin_ChuyenSinhHoatDoan] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[ThongTin_ChuyenSinhHoatDoan] CHECK CONSTRAINT [fk_SinhVien_ThongTin_ChuyenSinhHoatDoan]
GO
ALTER TABLE [dbo].[ThongTin_NopDoanPhi]  WITH CHECK ADD  CONSTRAINT [fk_CanBoDoan_ThongTin_NopDoanPhi] FOREIGN KEY([MaCB])
REFERENCES [dbo].[CanBoDoan] ([MaCB])
GO
ALTER TABLE [dbo].[ThongTin_NopDoanPhi] CHECK CONSTRAINT [fk_CanBoDoan_ThongTin_NopDoanPhi]
GO
ALTER TABLE [dbo].[ThongTin_NopDoanPhi]  WITH CHECK ADD  CONSTRAINT [fk_SinhVien_ThongTin_NopDoanPhi] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[ThongTin_NopDoanPhi] CHECK CONSTRAINT [fk_SinhVien_ThongTin_NopDoanPhi]
GO
ALTER TABLE [dbo].[ThongTin_NopSoDoan]  WITH CHECK ADD  CONSTRAINT [fk_CanBoDoan_ThongTin_NopSoDoan] FOREIGN KEY([MaCB])
REFERENCES [dbo].[CanBoDoan] ([MaCB])
GO
ALTER TABLE [dbo].[ThongTin_NopSoDoan] CHECK CONSTRAINT [fk_CanBoDoan_ThongTin_NopSoDoan]
GO
ALTER TABLE [dbo].[ThongTin_NopSoDoan]  WITH CHECK ADD  CONSTRAINT [fk_SinhVien_ThongTin_NopSoDoan] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[ThongTin_NopSoDoan] CHECK CONSTRAINT [fk_SinhVien_ThongTin_NopSoDoan]
GO
ALTER TABLE [dbo].[ThongTin_NopSoDoan]  WITH CHECK ADD  CONSTRAINT [fk_SoDoan_ThongTin_NopSoDoan] FOREIGN KEY([SoSD])
REFERENCES [dbo].[SoDoan] ([SoSD])
GO
ALTER TABLE [dbo].[ThongTin_NopSoDoan] CHECK CONSTRAINT [fk_SoDoan_ThongTin_NopSoDoan]
GO
ALTER TABLE [dbo].[ThongTin_ThamGiaHoatDong]  WITH CHECK ADD  CONSTRAINT [fk_ThongTinThamGiaHoatDong] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[ThongTin_ThamGiaHoatDong] CHECK CONSTRAINT [fk_ThongTinThamGiaHoatDong]
GO
ALTER TABLE [dbo].[ThongTin_ThamGiaHoatDong]  WITH CHECK ADD  CONSTRAINT [fk_ThongTinThamGiaHoatDong2] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoatDongDoan] ([MaHD])
GO
ALTER TABLE [dbo].[ThongTin_ThamGiaHoatDong] CHECK CONSTRAINT [fk_ThongTinThamGiaHoatDong2]
GO
USE [master]
GO
ALTER DATABASE [BTL_Windows] SET  READ_WRITE 
GO

select * from TaiKhoan
update TaiKhoan set Quyen = N'user' where Quyen='User'
update TaiKhoan set Quyen = N'admin' where TenDangNhap=N'thuytt'

select*from ThongTin_ThamGiaHoatDong where MaSV='001'
select * from TaiKhoan