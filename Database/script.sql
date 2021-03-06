USE [QuanLyKhachSan]
GO
/****** Object:  Table [dbo].[BCDT]    Script Date: 6/27/2021 12:52:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BCDT](
	[MaBCDT] [int] IDENTITY(1000,1) NOT NULL,
	[Thang] [int] NOT NULL,
	[Nam] [int] NOT NULL,
	[TongDoanhThu] [money] NULL,
 CONSTRAINT [PK_BCDT] PRIMARY KEY CLUSTERED 
(
	[MaBCDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_PHONG]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PHONG](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ROOM_ID] [nchar](10) NOT NULL,
	[SUA_VAT_TU] [nvarchar](max) NULL,
	[HONG_VAT_TU] [nvarchar](max) NULL,
 CONSTRAINT [PK_CT_PHONG] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTBCDT]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTBCDT](
	[MaBCDT] [int] NOT NULL,
	[MaLoaiPhong] [varchar](10) NOT NULL,
	[DoanhThu] [money] NULL,
 CONSTRAINT [PK_CTBCDT] PRIMARY KEY CLUSTERED 
(
	[MaBCDT] ASC,
	[MaLoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD](
	[MaPTP] [varchar](10) NOT NULL,
	[SoHD] [int] NOT NULL,
	[SoNgayThue] [int] NOT NULL,
	[ThanhTien] [money] NOT NULL,
	[GiaTien] [money] NOT NULL,
 CONSTRAINT [PK_CTHD] PRIMARY KEY CLUSTERED 
(
	[MaPTP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPT]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPT](
	[MaPTP] [int] NOT NULL,
	[CMND] [varchar](15) NOT NULL,
	[MaLoaiKhachHang] [int] NOT NULL,
	[KhachHang] [nvarchar](30) NOT NULL,
	[DiaChi] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_CTPT] PRIMARY KEY CLUSTERED 
(
	[MaPTP] ASC,
	[KhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[SoHD] [int] IDENTITY(1000,1) NOT NULL,
	[KhachHang] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[NgayLap] [date] NOT NULL,
	[TongTien] [money] NOT NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[SoHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIKHACH]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIKHACH](
	[MaLoaiKhachHang] [int] IDENTITY(2000,1) NOT NULL,
	[TenLoaiKhachHang] [nvarchar](30) NOT NULL,
	[HeSoPhuThu] [float] NOT NULL,
	[KhaDung] [bit] NOT NULL,
 CONSTRAINT [PK_LOAIKHACH] PRIMARY KEY CLUSTERED 
(
	[MaLoaiKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIPHONG]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIPHONG](
	[MaLoaiPhong] [varchar](10) NOT NULL,
	[DonGia] [money] NOT NULL,
 CONSTRAINT [PK_LOAIPHONG] PRIMARY KEY CLUSTERED 
(
	[MaLoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUTHUE]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTHUE](
	[MaPTP] [int] IDENTITY(3000,1) NOT NULL,
	[MaPhong] [varchar](10) NOT NULL,
	[NgayBatDauThue] [date] NOT NULL,
	[SoKhach] [int] NOT NULL,
	[DonGiaTieuChuan] [money] NULL,
	[SoHD] [int] NULL,
	[DonGiaThue] [money] NULL,
 CONSTRAINT [PK_PHIEUTHUE] PRIMARY KEY CLUSTERED 
(
	[MaPTP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONG](
	[MaPhong] [varchar](10) NOT NULL,
	[MaLoaiPhong] [varchar](10) NULL,
	[GhiChu] [nvarchar](40) NULL,
	[MaTinhTrang] [varchar](10) NULL,
 CONSTRAINT [PK_PHONG] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THAMSO]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THAMSO](
	[TenThamSo] [nvarchar](30) NOT NULL,
	[GiaTri] [float] NOT NULL,
 CONSTRAINT [PK_THAMSO] PRIMARY KEY CLUSTERED 
(
	[TenThamSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TINHTRANG]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TINHTRANG](
	[MaTinhTrang] [varchar](10) NOT NULL,
	[TenTinhTrang] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_TINHTRANG] PRIMARY KEY CLUSTERED 
(
	[MaTinhTrang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BCDT] ON 

INSERT [dbo].[BCDT] ([MaBCDT], [Thang], [Nam], [TongDoanhThu]) VALUES (1036, 6, 2021, 595000.0000)
INSERT [dbo].[BCDT] ([MaBCDT], [Thang], [Nam], [TongDoanhThu]) VALUES (1037, 6, 2021, 1580000.0000)
INSERT [dbo].[BCDT] ([MaBCDT], [Thang], [Nam], [TongDoanhThu]) VALUES (1038, 6, 2021, 500000.0000)
INSERT [dbo].[BCDT] ([MaBCDT], [Thang], [Nam], [TongDoanhThu]) VALUES (1039, 6, 2021, 800000.0000)
INSERT [dbo].[BCDT] ([MaBCDT], [Thang], [Nam], [TongDoanhThu]) VALUES (1040, 6, 2021, 800000.0000)
INSERT [dbo].[BCDT] ([MaBCDT], [Thang], [Nam], [TongDoanhThu]) VALUES (1041, 6, 2021, 200000.0000)
SET IDENTITY_INSERT [dbo].[BCDT] OFF
GO
INSERT [dbo].[CTBCDT] ([MaBCDT], [MaLoaiPhong], [DoanhThu]) VALUES (1036, N'B', 595000.0000)
INSERT [dbo].[CTBCDT] ([MaBCDT], [MaLoaiPhong], [DoanhThu]) VALUES (1037, N'B', 680000.0000)
INSERT [dbo].[CTBCDT] ([MaBCDT], [MaLoaiPhong], [DoanhThu]) VALUES (1037, N'C', 900000.0000)
INSERT [dbo].[CTBCDT] ([MaBCDT], [MaLoaiPhong], [DoanhThu]) VALUES (1038, N'C', 500000.0000)
INSERT [dbo].[CTBCDT] ([MaBCDT], [MaLoaiPhong], [DoanhThu]) VALUES (1039, N'C', 800000.0000)
INSERT [dbo].[CTBCDT] ([MaBCDT], [MaLoaiPhong], [DoanhThu]) VALUES (1040, N'C', 800000.0000)
INSERT [dbo].[CTBCDT] ([MaBCDT], [MaLoaiPhong], [DoanhThu]) VALUES (1041, N'C', 200000.0000)
GO
INSERT [dbo].[CTPT] ([MaPTP], [CMND], [MaLoaiKhachHang], [KhachHang], [DiaChi]) VALUES (3055, N'12345654321', 2000, N'nguyen van c', N'123')
INSERT [dbo].[CTPT] ([MaPTP], [CMND], [MaLoaiKhachHang], [KhachHang], [DiaChi]) VALUES (3055, N'123456789780', 2000, N'nguyen van d', N'123')
INSERT [dbo].[CTPT] ([MaPTP], [CMND], [MaLoaiKhachHang], [KhachHang], [DiaChi]) VALUES (3055, N'123123', 2000, N'nguyen van e', N'123')
INSERT [dbo].[CTPT] ([MaPTP], [CMND], [MaLoaiKhachHang], [KhachHang], [DiaChi]) VALUES (3056, N'1234', 2000, N'nguyen van a', N'123')
INSERT [dbo].[CTPT] ([MaPTP], [CMND], [MaLoaiKhachHang], [KhachHang], [DiaChi]) VALUES (3056, N'123123', 2000, N'nguyen van f', N'123')
INSERT [dbo].[CTPT] ([MaPTP], [CMND], [MaLoaiKhachHang], [KhachHang], [DiaChi]) VALUES (3056, N'1234123', 2000, N'nguyen van g', N'123')
INSERT [dbo].[CTPT] ([MaPTP], [CMND], [MaLoaiKhachHang], [KhachHang], [DiaChi]) VALUES (3057, N'123123', 2000, N'nguyen van troi', N'123')
INSERT [dbo].[CTPT] ([MaPTP], [CMND], [MaLoaiKhachHang], [KhachHang], [DiaChi]) VALUES (3058, N'54345', 2000, N'nguyen van aa', N'123')
INSERT [dbo].[CTPT] ([MaPTP], [CMND], [MaLoaiKhachHang], [KhachHang], [DiaChi]) VALUES (3058, N'123321', 2000, N'nguyen van bb', N'123')
INSERT [dbo].[CTPT] ([MaPTP], [CMND], [MaLoaiKhachHang], [KhachHang], [DiaChi]) VALUES (3058, N'123123123', 2000, N'nguyen van dd', N'123')
INSERT [dbo].[CTPT] ([MaPTP], [CMND], [MaLoaiKhachHang], [KhachHang], [DiaChi]) VALUES (3059, N'1231231', 2000, N'NGUYEN VAN A', N'123')
INSERT [dbo].[CTPT] ([MaPTP], [CMND], [MaLoaiKhachHang], [KhachHang], [DiaChi]) VALUES (3059, N'123123123', 2000, N'NGUYEN VAN B', N'123')
INSERT [dbo].[CTPT] ([MaPTP], [CMND], [MaLoaiKhachHang], [KhachHang], [DiaChi]) VALUES (3060, N'123123123', 2000, N'NGUYEN VAN B', N'123')
INSERT [dbo].[CTPT] ([MaPTP], [CMND], [MaLoaiKhachHang], [KhachHang], [DiaChi]) VALUES (3061, N'12345678987', 2000, N'nguyen van đ', N'123')
GO
SET IDENTITY_INSERT [dbo].[HOADON] ON 

INSERT [dbo].[HOADON] ([SoHD], [KhachHang], [DiaChi], [NgayLap], [TongTien]) VALUES (1049, N'nguyen van c', N'123', CAST(N'2021-06-29' AS Date), 595000.0000)
INSERT [dbo].[HOADON] ([SoHD], [KhachHang], [DiaChi], [NgayLap], [TongTien]) VALUES (1050, N'nguyen van a', N'123', CAST(N'2021-06-30' AS Date), 1580000.0000)
INSERT [dbo].[HOADON] ([SoHD], [KhachHang], [DiaChi], [NgayLap], [TongTien]) VALUES (1051, N'nguyen van bb', N'123', CAST(N'2021-06-28' AS Date), 500000.0000)
INSERT [dbo].[HOADON] ([SoHD], [KhachHang], [DiaChi], [NgayLap], [TongTien]) VALUES (1052, N'NGUYEN VAN A', N'123', CAST(N'2021-06-30' AS Date), 800000.0000)
INSERT [dbo].[HOADON] ([SoHD], [KhachHang], [DiaChi], [NgayLap], [TongTien]) VALUES (1053, N'NGUYEN VAN B', N'123', CAST(N'2021-06-30' AS Date), 800000.0000)
INSERT [dbo].[HOADON] ([SoHD], [KhachHang], [DiaChi], [NgayLap], [TongTien]) VALUES (1054, N'nguyen van đ', N'123', CAST(N'2021-06-28' AS Date), 200000.0000)
SET IDENTITY_INSERT [dbo].[HOADON] OFF
GO
SET IDENTITY_INSERT [dbo].[LOAIKHACH] ON 

INSERT [dbo].[LOAIKHACH] ([MaLoaiKhachHang], [TenLoaiKhachHang], [HeSoPhuThu], [KhaDung]) VALUES (2000, N'Nội địa', 0, 1)
INSERT [dbo].[LOAIKHACH] ([MaLoaiKhachHang], [TenLoaiKhachHang], [HeSoPhuThu], [KhaDung]) VALUES (2001, N'Nước ngoài', 1.5, 1)
INSERT [dbo].[LOAIKHACH] ([MaLoaiKhachHang], [TenLoaiKhachHang], [HeSoPhuThu], [KhaDung]) VALUES (2002, N'D', 2, 0)
INSERT [dbo].[LOAIKHACH] ([MaLoaiKhachHang], [TenLoaiKhachHang], [HeSoPhuThu], [KhaDung]) VALUES (2003, N'Doanh nhan', 2, 0)
INSERT [dbo].[LOAIKHACH] ([MaLoaiKhachHang], [TenLoaiKhachHang], [HeSoPhuThu], [KhaDung]) VALUES (2005, N'ÓC CHÓ', 0.1, 1)
SET IDENTITY_INSERT [dbo].[LOAIKHACH] OFF
GO
INSERT [dbo].[LOAIPHONG] ([MaLoaiPhong], [DonGia]) VALUES (N'A', 150000.0000)
INSERT [dbo].[LOAIPHONG] ([MaLoaiPhong], [DonGia]) VALUES (N'B', 170000.0000)
INSERT [dbo].[LOAIPHONG] ([MaLoaiPhong], [DonGia]) VALUES (N'C', 200000.0000)
INSERT [dbo].[LOAIPHONG] ([MaLoaiPhong], [DonGia]) VALUES (N'VIP', 1000000.0000)
GO
SET IDENTITY_INSERT [dbo].[PHIEUTHUE] ON 

INSERT [dbo].[PHIEUTHUE] ([MaPTP], [MaPhong], [NgayBatDauThue], [SoKhach], [DonGiaTieuChuan], [SoHD], [DonGiaThue]) VALUES (3055, N'101', CAST(N'2021-06-26' AS Date), 3, 170000.0000, 1049, 595000.0000)
INSERT [dbo].[PHIEUTHUE] ([MaPTP], [MaPhong], [NgayBatDauThue], [SoKhach], [DonGiaTieuChuan], [SoHD], [DonGiaThue]) VALUES (3056, N'102', CAST(N'2021-06-26' AS Date), 3, 200000.0000, 1050, 900000.0000)
INSERT [dbo].[PHIEUTHUE] ([MaPTP], [MaPhong], [NgayBatDauThue], [SoKhach], [DonGiaTieuChuan], [SoHD], [DonGiaThue]) VALUES (3057, N'103', CAST(N'2021-06-26' AS Date), 1, 170000.0000, 1050, 680000.0000)
INSERT [dbo].[PHIEUTHUE] ([MaPTP], [MaPhong], [NgayBatDauThue], [SoKhach], [DonGiaTieuChuan], [SoHD], [DonGiaThue]) VALUES (3058, N'tuan', CAST(N'2021-06-26' AS Date), 3, 200000.0000, 1051, 500000.0000)
INSERT [dbo].[PHIEUTHUE] ([MaPTP], [MaPhong], [NgayBatDauThue], [SoKhach], [DonGiaTieuChuan], [SoHD], [DonGiaThue]) VALUES (3059, N'102', CAST(N'2021-06-26' AS Date), 2, 200000.0000, 1052, 800000.0000)
INSERT [dbo].[PHIEUTHUE] ([MaPTP], [MaPhong], [NgayBatDauThue], [SoKhach], [DonGiaTieuChuan], [SoHD], [DonGiaThue]) VALUES (3060, N'102', CAST(N'2021-06-26' AS Date), 1, 200000.0000, 1053, 800000.0000)
INSERT [dbo].[PHIEUTHUE] ([MaPTP], [MaPhong], [NgayBatDauThue], [SoKhach], [DonGiaTieuChuan], [SoHD], [DonGiaThue]) VALUES (3061, N'102', CAST(N'2021-06-27' AS Date), 1, 200000.0000, 1054, 200000.0000)
SET IDENTITY_INSERT [dbo].[PHIEUTHUE] OFF
GO
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [GhiChu], [MaTinhTrang]) VALUES (N'101', N'B', NULL, N'PHSC')
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [GhiChu], [MaTinhTrang]) VALUES (N'102', N'C', NULL, N'PHTR')
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [GhiChu], [MaTinhTrang]) VALUES (N'103', N'B', NULL, N'PHHO')
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [GhiChu], [MaTinhTrang]) VALUES (N'104', N'A', NULL, N'PHTR')
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [GhiChu], [MaTinhTrang]) VALUES (N'105', N'B', NULL, N'PHTR')
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [GhiChu], [MaTinhTrang]) VALUES (N'201', N'A', NULL, N'PHTR')
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [GhiChu], [MaTinhTrang]) VALUES (N'202', N'B', NULL, N'PHTR')
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [GhiChu], [MaTinhTrang]) VALUES (N'203', N'A', NULL, N'PHTR')
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [GhiChu], [MaTinhTrang]) VALUES (N'204', N'C', NULL, N'PHTR')
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [GhiChu], [MaTinhTrang]) VALUES (N'205', N'A', NULL, N'PHTR')
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [GhiChu], [MaTinhTrang]) VALUES (N'301', N'A', NULL, N'PHTR')
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [GhiChu], [MaTinhTrang]) VALUES (N'302', N'B', NULL, N'PHTR')
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [GhiChu], [MaTinhTrang]) VALUES (N'303', N'C', NULL, N'PHTR')
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [GhiChu], [MaTinhTrang]) VALUES (N'phien', N'A', NULL, N'PHTR')
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [GhiChu], [MaTinhTrang]) VALUES (N'tuan', N'C', NULL, N'PHTR')
GO
INSERT [dbo].[THAMSO] ([TenThamSo], [GiaTri]) VALUES (N'PTK3', 0.5)
INSERT [dbo].[THAMSO] ([TenThamSo], [GiaTri]) VALUES (N'SoKhachToiDa', 3)
GO
INSERT [dbo].[TINHTRANG] ([MaTinhTrang], [TenTinhTrang]) VALUES (N'PHHO', N'Hỏng')
INSERT [dbo].[TINHTRANG] ([MaTinhTrang], [TenTinhTrang]) VALUES (N'PHSC', N'Sửa')
INSERT [dbo].[TINHTRANG] ([MaTinhTrang], [TenTinhTrang]) VALUES (N'PHTH', N'Thuê')
INSERT [dbo].[TINHTRANG] ([MaTinhTrang], [TenTinhTrang]) VALUES (N'PHTR', N'Trống')
GO
ALTER TABLE [dbo].[CTBCDT]  WITH CHECK ADD  CONSTRAINT [FK_CTBCDT_BCDT] FOREIGN KEY([MaBCDT])
REFERENCES [dbo].[BCDT] ([MaBCDT])
GO
ALTER TABLE [dbo].[CTBCDT] CHECK CONSTRAINT [FK_CTBCDT_BCDT]
GO
ALTER TABLE [dbo].[CTBCDT]  WITH CHECK ADD  CONSTRAINT [FK_CTBCDT_LOAIPHONG] FOREIGN KEY([MaLoaiPhong])
REFERENCES [dbo].[LOAIPHONG] ([MaLoaiPhong])
GO
ALTER TABLE [dbo].[CTBCDT] CHECK CONSTRAINT [FK_CTBCDT_LOAIPHONG]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_HOADON] FOREIGN KEY([SoHD])
REFERENCES [dbo].[HOADON] ([SoHD])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_HOADON]
GO
ALTER TABLE [dbo].[CTPT]  WITH CHECK ADD  CONSTRAINT [FK_CTPT_PHIEUTHUE] FOREIGN KEY([MaPTP])
REFERENCES [dbo].[PHIEUTHUE] ([MaPTP])
GO
ALTER TABLE [dbo].[CTPT] CHECK CONSTRAINT [FK_CTPT_PHIEUTHUE]
GO
ALTER TABLE [dbo].[PHIEUTHUE]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHUE_PHONG] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PHONG] ([MaPhong])
GO
ALTER TABLE [dbo].[PHIEUTHUE] CHECK CONSTRAINT [FK_PHIEUTHUE_PHONG]
GO
ALTER TABLE [dbo].[PHONG]  WITH CHECK ADD  CONSTRAINT [FK_PHONG_LOAIPHONG] FOREIGN KEY([MaLoaiPhong])
REFERENCES [dbo].[LOAIPHONG] ([MaLoaiPhong])
GO
ALTER TABLE [dbo].[PHONG] CHECK CONSTRAINT [FK_PHONG_LOAIPHONG]
GO
ALTER TABLE [dbo].[PHONG]  WITH CHECK ADD  CONSTRAINT [FK_PHONG_TINHTRANG] FOREIGN KEY([MaTinhTrang])
REFERENCES [dbo].[TINHTRANG] ([MaTinhTrang])
GO
ALTER TABLE [dbo].[PHONG] CHECK CONSTRAINT [FK_PHONG_TINHTRANG]
GO
/****** Object:  StoredProcedure [dbo].[BaoCaoDoanhThuThang]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BaoCaoDoanhThuThang]
	@Thang int,
	@Nam int
AS
BEGIN
	DECLARE @TongDoanhThu MONEY
	SET @TongDoanhThu = (SELECT SUM(TongDoanhThu) FROM BCDT WHERE Thang = @Thang AND Nam = @Nam)

	SELECT MaLoaiPhong, SUM(DoanhThu) AS DoanhThu, (SUM(DoanhThu) / @TongDoanhThu * 100) AS TiLe
	FROM CTBCDT 
				JOIN BCDT ON CTBCDT.MaBCDT = BCDT.MaBCDT
	
	WHERE Thang = @Thang AND Nam = @Nam

	GROUP BY MaLoaiPhong
	ORDER BY MaLoaiPhong
END
GO
/****** Object:  StoredProcedure [dbo].[LietKeDanhMucPhong]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LietKeDanhMucPhong]
AS
BEGIN
	SELECT MaPhong, Phong.MaLoaiPhong, FORMAT(DonGia, 'N0') DonGia, TenTinhTrang, GhiChu
	FROM Phong 
		JOIN LoaiPhong ON Phong.MaLoaiPhong = LoaiPhong.MaLoaiPhong
		JOIN TinhTrang ON Phong.MaTinhTrang = TinhTrang.MaTinhTrang
END

GO
/****** Object:  StoredProcedure [dbo].[LietKePhongThue]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LietKePhongThue]
	@NgayThanhToan date
AS
BEGIN
	SELECT MaPhong
	FROM PhieuThue
	WHERE SoHD IS NULL
	AND NgayBatDauThue < @NgayThanhToan
	ORDER BY MaPhong ASC
END

GO
/****** Object:  StoredProcedure [dbo].[RoomDetail_DeleteCustomer]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		minh-nd
-- Description:	RoomDetail_DeleteCustomer
-- =============================================
CREATE PROCEDURE [dbo].[RoomDetail_DeleteCustomer]
	@ROOM_ID nvarchar(10),
	@CMND NVARCHAR(15)
AS
BEGIN
	DECLARE @MPT AS NVARCHAR(10)
	SELECT @MPT=MaPTP	
	FROM PHIEUTHUE
	WHERE MaPhong=@ROOM_ID
		AND SoHD IS NULL
	IF @MPT IS NOT NULL
	BEGIN
		DELETE FROM CTPT WHERE MaPTP=@MPT AND CMND=@CMND
		UPDATE PHIEUTHUE
		SET SoKhach=SoKhach-1
		WHERE MaPTP=@MPT
	END
END
GO
/****** Object:  StoredProcedure [dbo].[RoomDetail_GetListCustomer]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		minh-nd
-- Description:	RoomDetail_GetListCustomer
-- =============================================
CREATE PROCEDURE [dbo].[RoomDetail_GetListCustomer]
	@ROOM_ID nvarchar(10)
AS
BEGIN
	SELECT CMND	
		,KhachHang
		,DiaChi
		,LK.TenLoaiKhachHang
		,LK.MaLoaiKhachHang
	FROM CTPT
		LEFT JOIN LOAIKHACH LK ON CTPT.MaLoaiKhachHang=LK.MaLoaiKhachHang
		LEFT JOIN PHIEUTHUE PT ON PT.MaPTP=CTPT.MaPTP
	WHERE 
		PT.MaPhong=@ROOM_ID
		AND PT.SoHD IS NULL
END
GO
/****** Object:  StoredProcedure [dbo].[RoomDetail_Insert]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		minh-nd
-- Description:	insert detail for room
-- =============================================
CREATE PROCEDURE [dbo].[RoomDetail_Insert]
	@ROOM_ID nvarchar(10),
	@HONG_VAT_TU nvarchar(max)  null,
	@SUA_VAT_TU nvarchar(max) null
AS
BEGIN
	INSERT INTO CT_PHONG(ROOM_ID, HONG_VAT_TU,SUA_VAT_TU)
	VALUES(@ROOM_ID,@HONG_VAT_TU,@SUA_VAT_TU)
END
GO
/****** Object:  StoredProcedure [dbo].[RoomDetail_InsertCustomer]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		minh-nd
-- Description:	RoomDetail_GetListCustomer
-- =============================================
CREATE PROCEDURE [dbo].[RoomDetail_InsertCustomer]
	@ROOM_ID nvarchar(10),
	@CMND NVARCHAR(15),
	@MA_LOAI_KHACH INT,
	@NAME NVARCHAR(30),
	@DIACHI NVARCHAR(MAX)
AS
BEGIN
	DECLARE @MPT AS NVARCHAR(10)
	SELECT @MPT=MaPTP	
	FROM PHIEUTHUE
	WHERE MaPhong=@ROOM_ID
		AND SoHD IS NULL
	IF @MPT IS NOT NULL
	BEGIN
		INSERT INTO CTPT (MaPTP,CMND,MaLoaiKhachHang,KhachHang,DiaChi)
		VALUES (@MPT,@CMND,@MA_LOAI_KHACH,@NAME,@DIACHI)
		UPDATE PHIEUTHUE
		SET SoKhach=SoKhach+1
		WHERE MaPTP=@MPT
	END
END
GO
/****** Object:  StoredProcedure [dbo].[RoomDetail_Update]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RoomDetail_Update]
	@ROOM_ID nvarchar(10),
	@HONG_VAT_TU nvarchar(max),
	@SUA_VAT_TU nvarchar(max),
	@ID INT
AS
BEGIN
	UPDATE CT_PHONG
	SET 
		HONG_VAT_TU=@HONG_VAT_TU,
		SUA_VAT_TU=@SUA_VAT_TU
	WHERE
	 ID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[RoomDetail_UpdateCustomer]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		minh-nd
-- Description:	RoomDetail_UpdateCustomer
-- =============================================
Create PROCEDURE [dbo].[RoomDetail_UpdateCustomer]
	@ROOM_ID nvarchar(10),
	@CMND NVARCHAR(15),
	@MA_LOAI_KHACH INT,
	@NAME NVARCHAR(30),
	@DIACHI NVARCHAR(MAX),
	@CMND_OLD NVARCHAR(15)
AS
BEGIN
	DECLARE @MPT AS NVARCHAR(10)
	SELECT @MPT=MaPTP	
	FROM PHIEUTHUE
	WHERE MaPhong=@ROOM_ID
		AND SoHD IS NULL
	IF @MPT IS NOT NULL
	BEGIN
		EXEC [dbo].[RoomDetail_DeleteCustomer]	@ROOM_ID = @ROOM_ID,@CMND = @CMND_OLD

		INSERT INTO CTPT (MaPTP,CMND,MaLoaiKhachHang,KhachHang,DiaChi)
		VALUES (@MPT,@CMND,@MA_LOAI_KHACH,@NAME,@DIACHI)
		UPDATE PHIEUTHUE
		SET SoKhach=SoKhach+1
		WHERE MaPTP=@MPT
	END
END

GO
/****** Object:  StoredProcedure [dbo].[SuaPhong]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SuaPhong]
	@MaPhong varchar(10),
	@MaLoaiPhong varchar(10),
	@MaTinhTrang varchar(10),
	@GhiChu nvarchar(40) = null
AS
BEGIN
	UPDATE Phong
	SET MaLoaiPhong = @MaLoaiPhong, MaTinhTrang = @MaTinhTrang, GhiChu = @GhiChu
	WHERE MaPhong = @MaPhong
END

GO
/****** Object:  StoredProcedure [dbo].[ThemBaoCao]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemBaoCao]
	@Thang int,
	@Nam int,
	@TongDoanhThu money
AS
BEGIN
	INSERT INTO BCDT(Thang, Nam, TongDoanhThu)
	VALUES (@Thang, @Nam, @TongDoanhThu)


END

GO
/****** Object:  StoredProcedure [dbo].[ThemChiTietBaoCao]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemChiTietBaoCao]
	@MaPhong varchar(10)
AS
BEGIN
	DECLARE @MaLoaiPhong varchar(10)
	DECLARE @DoanhThu money
	DECLARE @MaBCDT varchar(10)
	SET @MaLoaiPhong = (SELECT MaLoaiPhong FROM PHONG WHERE MaPhong = @MaPhong)
	SET @DoanhThu = (SELECT TOP 1 DonGiaThue FROM PHIEUTHUE WHERE MaPhong  = @MaPhong 
															AND SoHD is not null ORDER BY MaPTP DESC)
	SET @MaBCDT = (SELECT TOP 1 MaBCDT FROM BCDT ORDER BY MaBCDT DESC)

	INSERT INTO CTBCDT(MaBCDT, MaLoaiPhong, DoanhThu)
	VALUES(@MaBCDT,@MaLoaiPhong,@DoanhThu)


END
GO
/****** Object:  StoredProcedure [dbo].[ThemChiTietPhieuThue]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemChiTietPhieuThue]
	@MaPTP int,
	@CMND varchar(15),
	@MaLoaiKhachHang int,
	@KhachHang nvarchar(30),
	@DiaChi nvarchar(50)
AS
BEGIN	
	INSERT INTO CTPT (MaPTP, CMND, MaLoaiKhachHang, KhachHang, DiaChi)
	VALUES (@MaPTP, @CMND, @MaLoaiKhachHang, @KhachHang, @DiaChi)
END

GO
/****** Object:  StoredProcedure [dbo].[ThemHoaDon]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemHoaDon]
	@KhachHang nvarchar(30),
	@DiaChi nvarchar(30),
	@NgayLap date,
	@TongTien money
AS
BEGIN
	INSERT INTO HoaDon(KhachHang, DiaChi, NgayLap, TongTien)
	VALUES (@KhachHang, @DiaChi, @NgayLap, @TongTien)
END

GO
/****** Object:  StoredProcedure [dbo].[ThemLoaiKhach]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemLoaiKhach]
	@TenLoaiKhachHang nvarchar(30),
	@HeSoPhuThu int
AS
BEGIN
	SET @HeSoPhuThu = CAST(@HeSoPhuThu AS FLOAT) / 100
	IF (EXISTS (SELECT * FROM LoaiKhach WHERE TenLoaiKhachHang = @TenLoaiKhachHang))
	BEGIN
		UPDATE LoaiKhach
		SET KhaDung = 1 , HeSoPhuThu = @HeSoPhuThu
		WHERE TenLoaiKhachHang = @TenLoaiKhachHang
	END
	ELSE
	BEGIN
		INSERT INTO LoaiKhach(TenLoaiKhachHang,HeSoPhuThu, KhaDung)
		VALUES (@TenLoaiKhachHang,@HeSoPhuThu,1)
	END
END

GO
/****** Object:  StoredProcedure [dbo].[ThemPhieuThuePhong]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemPhieuThuePhong]
	@MaPhong varchar(10),
	@NgayBatDauThue date,
	@SoKhach int,
	@DonGiaTieuChuan money
AS
BEGIN
	INSERT INTO PhieuThue (MaPhong, NgayBatDauThue, SoKhach, DonGiaTieuChuan)
	VALUES (@MaPhong, @NgayBatDauThue, @SoKhach, @DonGiaTieuChuan)
	UPDATE Phong
	SET MaTinhTrang = 'PHTH'
	WHERE MaPhong = @MaPhong
END

GO
/****** Object:  StoredProcedure [dbo].[ThemPhong]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- THÊM MỘT PHÒNG VÀO DANH MỤC PHÒNG (*)
CREATE PROCEDURE [dbo].[ThemPhong]
	@MaPhong varchar(10), 
	@MaLoaiPhong varchar(10),
	@MaTinhTrang varchar(10),
	@GhiChu nvarchar(40) = null
AS
BEGIN
	INSERT INTO Phong (MaPhong, MaLoaiPhong, MaTinhTrang, GhiChu)
	VALUES (@MaPhong, @MaLoaiPhong, @MaTinhTrang, @GhiChu)
END

GO
/****** Object:  StoredProcedure [dbo].[ThemThongTinThanhToan]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemThongTinThanhToan]
	@MaPhong varchar(10),
	@DonGiaThue bigint
AS
BEGIN
	DECLARE @SoHD varchar(10)	
	DECLARE @MaPTP int
	
	SET @SoHD = (SELECT TOP 1 SoHD FROM HOADON ORDER BY SoHD DESC)
	SET @MaPTP = (SELECT TOP 1 MaPTP FROM PHIEUTHUE WHERE MaPhong  = @MaPhong ORDER BY MaPTP DESC)
	
	UPDATE PhieuThue
	SET SoHD = @SoHD, DonGiaThue=@DonGiaThue
	WHERE MaPTP = @MaPTP	
	
	UPDATE PHONG
	SET MaTinhTrang = 'PHTR'
	WHERE MaPhong = @MaPhong	
END
GO
/****** Object:  StoredProcedure [dbo].[TimChiTietThanhToan]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TimChiTietThanhToan]
	@MaPhong varchar(10),
	@NgayThanhToan date
AS
BEGIN
	DECLARE @DonGia money, @ThanhTien money, @PhuThuKhachThem money, @PhuThuKhachTheoLoaiKhach money
	DECLARE @MaPTP int, @SoNgayThue int, @SoKhach int

	SET @MaPTP = (SELECT TOP 1 MaPTP FROM PhieuThue WHERE MaPhong = @MaPhong ORDER BY MaPTP DESC)
	SET @DonGia = (SELECT DonGiaTieuChuan FROM PhieuThue WHERE MaPTP = @MaPTP)
	SET @SoNgayThue = (SELECT DATEDIFF(DAY, NgayBatDauThue, @NgayThanhToan) FROM PhieuThue WHERE MaPTP = @MaPTP)
	SET @ThanhTien = @SoNgayThue * (SELECT DonGiaTieuChuan FROM PhieuThue WHERE MaPTP = @MaPTP) 
	SET @SoKhach = (SELECT SoKhach FROM PHIEUTHUE WHERE MaPTP=@MaPTP)

	IF (@SoKhach >= 3)
	BEGIN
		SET @PhuThuKhachThem = @DonGia * (SELECT GiaTri FROM ThamSo WHERE TenThamSo = 'PTK3') * (@SoKhach - 2)
	END
	ELSE
	BEGIN
		SET @PhuThuKhachThem = 0
	END

	SET @PhuThuKhachTheoLoaiKhach =@DonGia * (SELECT SUM(DISTINCT HeSoPhuThu) FROM LOAIKHACH 
											JOIN CTPT ON CTPT.MaLoaiKhachHang = LOAIKHACH.MaLoaiKhachHang
											WHERE MaPTP = @MaPTP)

	SET @ThanhTien = @ThanhTien + @PhuThuKhachTheoLoaiKhach + @PhuThuKhachThem
	
	SELECT	@MaPhong AS MaPhong, @DonGia AS DonGia, @SoNgayThue AS SoNgayThue, @PhuThuKhachThem AS PhuThuKhachThem, 
			@PhuThuKhachTheoLoaiKhach AS PhuThuKhachTheoLoaiKhach, @ThanhTien AS ThanhTien
END
GO
/****** Object:  StoredProcedure [dbo].[TimGiaTheoMaPhong]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- TÌM GIÁ PHÒNG TỪ MÃ PHÒNG (SAU KHI ĐÃ CHỌN MÃ PHÒNG TRONG COMBOBOX) (*)
CREATE PROCEDURE [dbo].[TimGiaTheoMaPhong]
	@MaPhong varchar(10)
AS
BEGIN
	SELECT DonGia
	FROM Phong JOIN LoaiPhong
	ON Phong.MaLoaiPhong = LoaiPhong.MaLoaiPhong
	WHERE MaPhong = @MaPhong
END

GO
/****** Object:  StoredProcedure [dbo].[TraCuuPhong]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TraCuuPhong]
	@MaPhong       varchar(10) = null,
	@MaLoaiPhong   varchar(10) = null,
	@DonGia        money = null,
	@MaTinhTrang  varchar(10) = null 
AS 
BEGIN

 DECLARE @query NVARCHAR(MAX);

SET @query = N'	SELECT MaPhong, Phong.MaLoaiPhong, FORMAT(DonGia, ''N0'') DonGia, TenTinhTrang, GhiChu
				FROM Phong 
					JOIN TinhTrang ON Phong.MaTinhTrang = TinhTrang.MaTinhTrang
					JOIN LoaiPhong ON Phong.MaLoaiPhong = LoaiPhong.MaLoaiPhong'

       + CASE WHEN @MaPhong IS NOT NULL 
              THEN ' AND MaPhong = @MaPhong' ELSE N' ' END 

       + CASE WHEN @MaLoaiPhong IS NOT NULL 
              THEN ' AND Phong.MaLoaiPhong = @MaLoaiPhong' ELSE N' ' END 

       + CASE WHEN @DonGia IS NOT NULL 
	          THEN ' AND DonGia = @DonGia' ELSE N' ' END 

       + CASE WHEN @MaTinhTrang IS NOT NULL 
              THEN N' AND Phong.MaTinhTrang = @MaTinhTrang' ELSE N' ' END 

EXECUTE SP_EXECUTESQL @query,
                    N'	@MaPhong varchar(10),
						@MaLoaiPhong varchar(10),
						@DonGia money,
						@MaTinhTrang varchar(10) '
                    ,@MaPhong
                    ,@MaLoaiPhong
                    ,@DonGia
                    ,@MaTinhTrang
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateRoom]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		minh-nd
-- Description:	Update detail for room
-- =============================================
CREATE PROCEDURE [dbo].[UpdateRoom]
	@ROOM_ID nvarchar(10),
	@HONG_VAT_TU nvarchar(max),
	@SUA_VAT_TU nvarchar(max)
AS
BEGIN
	UPDATE CT_PHONG
	SET 
		HONG_VAT_TU=@HONG_VAT_TU,
		SUA_VAT_TU=@SUA_VAT_TU
	WHERE 
		ROOM_ID=@ROOM_ID
END
GO
/****** Object:  StoredProcedure [dbo].[XoaLoaiKhach]    Script Date: 6/27/2021 12:52:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[XoaLoaiKhach]
	@TenLoaiKhachHang nvarchar(30)
AS
BEGIN
	IF (EXISTS (SELECT * FROM CTPT JOIN LoaiKhach 
				ON CTPT.MaLoaiKhachHang = LoaiKhach.MaLoaiKhachHang
				WHERE TenLoaiKhachHang = @TenLoaiKhachHang))
	BEGIN
		UPDATE LoaiKhach
		SET KhaDung = 0
		WHERE TenLoaiKhachHang = @TenLoaiKhachHang
	END
	ELSE
	BEGIN
		DELETE LoaiKhach
		WHERE TenLoaiKhachHang = @TenLoaiKhachHang
	END
END
GO
