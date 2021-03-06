use master
go
create database ThiASP
go
USE [ThiASP]
GO
CREATE TABLE [dbo].[tblCat](
	[CatID] [int] IDENTITY(1,1) NOT NULL,
	[CatName] [nvarchar](50) NULL,
	[CatStatus] [int] NULL,
	[CatDescription] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblCat] PRIMARY KEY CLUSTERED 
(
	[CatID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1: cấm 2: được sử dụng' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblCat', @level2type=N'COLUMN',@level2name=N'CatStatus'
GO
SET IDENTITY_INSERT [dbo].[tblCat] ON
INSERT [dbo].[tblCat] ([CatID], [CatName], [CatStatus], [CatDescription]) VALUES (1, N'Máy bộ', 1, N'Máy bộ giành cho gia đình')
INSERT [dbo].[tblCat] ([CatID], [CatName], [CatStatus], [CatDescription]) VALUES (2, N'Laptop', 2, N'Máy tính xách tay thời trang')
INSERT [dbo].[tblCat] ([CatID], [CatName], [CatStatus], [CatDescription]) VALUES (3, N'Máy in', 1, N'Máy in giành cho gia đình và cho các công ty')
INSERT [dbo].[tblCat] ([CatID], [CatName], [CatStatus], [CatDescription]) VALUES (4, N'Máy MP3, MP4', 2, N'Máy nghe nhạc thời trang giành ')
INSERT [dbo].[tblCat] ([CatID], [CatName], [CatStatus], [CatDescription]) VALUES (5, N'Máy Scan', 1, N'Máy scan chất lượng cao, giá rẻ')
INSERT [dbo].[tblCat] ([CatID], [CatName], [CatStatus], [CatDescription]) VALUES (6, N'Mực in', 2, N'Mực in các loại, phù hợp nhiều máy in')
INSERT [dbo].[tblCat] ([CatID], [CatName], [CatStatus], [CatDescription]) VALUES (7, N'Ổ cứng', 1, N'Ố cứng để bàn, USB các loại')
SET IDENTITY_INSERT [dbo].[tblCat] OFF
/****** Object:  Table [dbo].[tblUser]    Script Date: 06/02/2014 15:59:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblUser](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NULL,
	[Userpass] [varbinary](50) NULL,
	[Fullname] [nvarchar](50) NULL,
	[Status] [int] NULL,
	[Systemright] [int] NULL,
 CONSTRAINT [PK_tblUser] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1:( cấm) - 2:(sử dụng)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblUser', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1: quyền User 2: quyền Admin' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblUser', @level2type=N'COLUMN',@level2name=N'Systemright'
GO
SET IDENTITY_INSERT [dbo].[tblUser] ON
INSERT [dbo].[tblUser] ([UserID], [Username], [Userpass], [Fullname], [Status], [Systemright]) VALUES (1, N'admin     ', 0x01008F240766C17EB8F79A7177B394FC2027E9220F915CCC2618BA26E78D3DBAFCBBD0BE9113F44E518A2F099315, N'Administrator', 2, 2)
INSERT [dbo].[tblUser] ([UserID], [Username], [Userpass], [Fullname], [Status], [Systemright]) VALUES (2, N'huutiep   ', NULL, N'Phan Hữu Tiếp', 1, 1)
INSERT [dbo].[tblUser] ([UserID], [Username], [Userpass], [Fullname], [Status], [Systemright]) VALUES (3, N'lachong   ', NULL, N'Đại Học lạc Hồng', 2, 1)
INSERT [dbo].[tblUser] ([UserID], [Username], [Userpass], [Fullname], [Status], [Systemright]) VALUES (4, N'trucquynh ', NULL, N'Phạm Trúc Quỳnh', 1, 1)
INSERT [dbo].[tblUser] ([UserID], [Username], [Userpass], [Fullname], [Status], [Systemright]) VALUES (5, N'thanhthao ', NULL, N'Nguyễn Thanh Thảo', 2, 1)
INSERT [dbo].[tblUser] ([UserID], [Username], [Userpass], [Fullname], [Status], [Systemright]) VALUES (6, N'baquat    ', NULL, N'Nguyễn Bá Quát', 1, 1)
INSERT [dbo].[tblUser] ([UserID], [Username], [Userpass], [Fullname], [Status], [Systemright]) VALUES (7, N'ductan    ', NULL, N'Trần Đức Tân', 2, 1)
INSERT [dbo].[tblUser] ([UserID], [Username], [Userpass], [Fullname], [Status], [Systemright]) VALUES (8, N'ngocdieu  ', NULL, N'Phan Ngọc Dịu', 1, 1)
INSERT [dbo].[tblUser] ([UserID], [Username], [Userpass], [Fullname], [Status], [Systemright]) VALUES (10, N'tuyetlinh ', NULL, N'Phan Tuyết Linh', 2, 1)
SET IDENTITY_INSERT [dbo].[tblUser] OFF
/****** Object:  Table [dbo].[tblPro]    Script Date: 06/02/2014 15:59:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPro](
	[ProID] [int] IDENTITY(1,1) NOT NULL,
	[ProName] [nvarchar](50) NULL,
	[ProStatus] [int] NULL,
	[ProDescription] [nvarchar](50) NULL,
	[CatID] [int] NULL,
 CONSTRAINT [PK_tblPro] PRIMARY KEY CLUSTERED 
(
	[ProID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1: Cấm 2: Được sử dụng' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblPro', @level2type=N'COLUMN',@level2name=N'ProStatus'
GO
SET IDENTITY_INSERT [dbo].[tblPro] ON
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (1, N'Máy bộ 1', 2, N'Máy bộ loại 1, giành cho cá nhân', 1)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (2, N'Máy bộ 2', 1, N'Máy bộ loại 2, giành cho gia đình', 1)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (3, N'Máy bộ 3', 2, N'Máy bộ loại 3, giành cho sinh viên', 1)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (4, N'Máy bộ 4', 1, N'Máy bộ loại 4, giành cho hộ gia đình', 1)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (5, N'Máy bộ 5', 2, N'Máy bộ loại 5, giành cho học sinh', 1)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (6, N'Laptop Acer', 1, N'Máy tính giá rẻ', 2)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (7, N'Laptop HP', 2, N'máy tính HP giành cho hô gia đinh2', 2)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (8, N'Laptop Compaq', 1, N'Laptop dưới  900 USD', 2)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (9, N'Laptop Dell', 2, N'Laptop Dell giảm giá', 2)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (10, N'Laptop Lenovo', 1, N'Lenovo hàng mới về', 2)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (11, N'Máy in loại 1', 2, N'Máy in loại tốt nhất', 3)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (12, N'Máy in loại 2', 1, N'Máy in hàng khuyến mãi', 3)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (13, N'Máy in loại 3', 2, N'Máy in hô gia đình', 3)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (14, N'Máy in loại 4', 1, N'Máy in màu đặc biệt', 3)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (15, N'Máy in loại 5', 2, N'Máy in kim giảm giá', 6)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (16, N'Máy MP3 1GB', 1, N'Giảm giá mùa hè', 4)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (17, N'Máy MP3 2 GB', 2, N'Siêu khuyến mãi nhân dịp lễ', 4)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (18, N'Máy MP3  3GB, chống sốc', 1, N'Hàng chất lượng tốt, giá rẻ', 4)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (19, N'Máy MP3 4GB', 2, N'Âm thanh chất lượng, rõ', 4)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (20, N'Máy MP3  5GB', 1, N'Dung lượng cao, chống sốc', 4)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (21, N'Máy Scan 1', 2, N'Máy Scan 1 hàng chất lượng', 5)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (22, N'Máy Scan 2', 1, N'Hàng tặng không bán', 5)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (23, N'Máy Scan 3', 2, N'Giảm giá 50%', 5)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (24, N'Máy Scan 4', 1, N'Mua 1 tặng 1', 5)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (25, N'Máy Scan 5', 2, N'Máy Scanchất lượng hình ảnh cao', 5)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (26, N'Mực in phun', 1, N'Mực in phun giành cho gia đình', 6)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (27, N'Mực in màu', 2, N'Mực in màu bền đep5', 6)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (28, N'Mực in loại 1', 1, N'Hàng Trung Quốc', 6)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (29, N'Mực in loại 2', 2, N'Hàng chất lượng cao, giá rẻ', 6)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (30, N'Mực in Epson', 1, N'Mực in Epson giá rẻ', 6)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (31, N'Ổ cứng Giảm giá', 2, N'Siêu giảm giá', 7)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (32, N'Ổ cứng Maxtor', 1, N'Maxtor giá rẻ', 7)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (33, N'Ổ cứng Hitachi', 2, N'Hitachi siêu bền', 7)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (34, N'Ổ cứng Seagate', 1, N'Ổ cứng 60 GB hàng khuyến mãi', 7)
INSERT [dbo].[tblPro] ([ProID], [ProName], [ProStatus], [ProDescription], [CatID]) VALUES (35, N'Ổ cứng chống sốc', 2, N'Ổ cứng siêu giảm giá', 7)
SET IDENTITY_INSERT [dbo].[tblPro] OFF
/****** Object:  Default [DF_tblUser_Status]    Script Date: 06/02/2014 15:59:32 ******/
ALTER TABLE [dbo].[tblUser] ADD  CONSTRAINT [DF_tblUser_Status]  DEFAULT (2) FOR [Status]
GO
/****** Object:  Default [DF_tblCat_CatStatus]    Script Date: 06/02/2014 15:59:32 ******/
ALTER TABLE [dbo].[tblCat] ADD  CONSTRAINT [DF_tblCat_CatStatus]  DEFAULT (2) FOR [CatStatus]
GO
/****** Object:  ForeignKey [FK_tblPro_tblCat]    Script Date: 06/02/2014 15:59:32 ******/
ALTER TABLE [dbo].[tblPro]  WITH CHECK ADD  CONSTRAINT [FK_tblPro_tblCat] FOREIGN KEY([CatID])
REFERENCES [dbo].[tblCat] ([CatID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblPro] CHECK CONSTRAINT [FK_tblPro_tblCat]
GO


create proc AddDMSP
@catName nvarchar(50),
@catStatus int,
@catDes nvarchar(50)
as
	insert into tblCat(CatName,CatStatus,CatDescription) values(@catName,@catStatus,@catDes)
go
