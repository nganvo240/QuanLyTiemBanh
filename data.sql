﻿USE [QuanLyTiemBanh]
GO
/****** Object:  Table [dbo].[ACCOUNT]    Script Date: 08-Dec-20 2:34:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACCOUNT](
	[username] [nchar](50) NOT NULL,
	[password] [nchar](20) NOT NULL,
	[type] [int] NOT NULL,
	[nhanvien_id] [int] NULL,
 CONSTRAINT [PK_ACCOUNT] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BILL]    Script Date: 08-Dec-20 2:34:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BILL](
	[id] [int] NOT NULL,
	[day_out] [datetime] NOT NULL,
	[emp_id] [int] NULL,
 CONSTRAINT [PK_BILL] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BILL_INFORCAKE]    Script Date: 08-Dec-20 2:34:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BILL_INFORCAKE](
	[bill_id] [int] NOT NULL,
	[cake_id] [int] NOT NULL,
	[amount] [int] NULL,
	[price] [int] NULL,
	[id] [int] NOT NULL,
 CONSTRAINT [PK_BILL_INFORCAKE] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CAKE]    Script Date: 08-Dec-20 2:34:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAKE](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[price] [int] NOT NULL,
	[category_id] [int] NOT NULL,
	[amount] [int] NOT NULL,
	[place] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CAKE] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CATEGORY]    Script Date: 08-Dec-20 2:34:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORY](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CATEGORY] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPLOYEE]    Script Date: 08-Dec-20 2:34:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLOYEE](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[address] [nvarchar](50) NULL,
	[PhoneNumber] [char](10) NOT NULL,
	[sex] [nvarchar](10) NULL,
	[position] [nvarchar](50) NOT NULL,
	[salary] [int] NOT NULL,
	[status] [int] NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ACCOUNT]  WITH CHECK ADD  CONSTRAINT [FK_ACCOUNT_EMPLOYEE] FOREIGN KEY([nhanvien_id])
REFERENCES [dbo].[EMPLOYEE] ([id])
GO
ALTER TABLE [dbo].[ACCOUNT] CHECK CONSTRAINT [FK_ACCOUNT_EMPLOYEE]
GO
ALTER TABLE [dbo].[BILL]  WITH CHECK ADD  CONSTRAINT [FK_BILL_EMPLOYEE] FOREIGN KEY([emp_id])
REFERENCES [dbo].[EMPLOYEE] ([id])
GO
ALTER TABLE [dbo].[BILL] CHECK CONSTRAINT [FK_BILL_EMPLOYEE]
GO
ALTER TABLE [dbo].[CAKE]  WITH CHECK ADD  CONSTRAINT [FK_CAKE_CATEGORY] FOREIGN KEY([category_id])
REFERENCES [dbo].[CATEGORY] ([id])
GO
ALTER TABLE [dbo].[CAKE] CHECK CONSTRAINT [FK_CAKE_CATEGORY]
GO

ALTER TABLE BILL_INFORCAKE WITH CHECK ADD  CONSTRAINT [FK_BILL_INFORCAKE1] FOREIGN KEY (bill_id) REFERENCES BILL
GO

ALTER TABLE BILL_INFORCAKE WITH CHECK ADD  CONSTRAINT [FK_BILL_INFORCAKE2] FOREIGN KEY (cake_id) REFERENCES CAKE
GO

INSERT [dbo].[EMPLOYEE] ([id], [name], [address], [PhoneNumber], [sex], [position], [salary], [status]) VALUES (1, N'Võ Thị Thanh Ngân', N'Đồng Tháp', N'12', N'Nữ', N'nhân viên', 7000000, 1)
INSERT [dbo].[EMPLOYEE] ([id], [name], [address], [PhoneNumber], [sex], [position], [salary], [status]) VALUES (2, N'Lê Đỗ Trà My', N'Bình Dương', N'13', N'Nữ', N'nhân viên', 7000000, 1)
INSERT [dbo].[EMPLOYEE] ([id], [name], [address], [PhoneNumber], [sex], [position], [salary], [status]) VALUES (3, N'Hà Vân Xanh', N'quận 7', N'0413', N'Nam', N'nhân viên', 7000000, 1)
INSERT [dbo].[EMPLOYEE] ([id], [name], [address], [PhoneNumber], [sex], [position], [salary], [status]) VALUES (4, N'Ngô Phi Lít', N'Quãng Ngãi', N'1093', N'Nam', N'nhân viên', 7000000, 1)
INSERT [dbo].[EMPLOYEE] ([id], [name], [address], [PhoneNumber], [sex], [position], [salary], [status]) VALUES (5, N'Nguyễn Khánh Nhân', N'quận 8', N'1803', N'Nam', N'nhân viên', 7000000, 1)
INSERT [dbo].[EMPLOYEE] ([id], [name], [address], [PhoneNumber], [sex], [position], [salary], [status]) VALUES (6, N'Trần Đức Chinh', N'Tân Bình', N'1213', N'Nam', N'nhân viên', 7000000, 1)
INSERT [dbo].[EMPLOYEE] ([id], [name], [address], [PhoneNumber], [sex], [position], [salary], [status]) VALUES (7, N'Đào Thanh Tâm', N'quận 1', N'8913', N'Nam', N'nhân viên', 7000000, 0)
GO

INSERT [dbo].[ACCOUNT] ([username], [password], [type], [nhanvien_id]) VALUES (N'ad                                                ', N'1                   ', 1, 1)
INSERT [dbo].[ACCOUNT] ([username], [password], [type], [nhanvien_id]) VALUES (N'nv1                                               ', N'3                   ', 0, 3)
INSERT [dbo].[ACCOUNT] ([username], [password], [type], [nhanvien_id]) VALUES (N'nv2                                               ', N'1                   ', 0, 4)
INSERT [dbo].[ACCOUNT] ([username], [password], [type], [nhanvien_id]) VALUES (N'nv3                                               ', N'1                   ', 0, 5)
GO

insert CATEGORY values (1,N'Bánh mì')
insert CATEGORY values (2,N'Bánh mì nhanh')
insert CATEGORY values (3,N'Bánh không nướng')
insert CATEGORY values (4,N'Bánh mềm')
insert CATEGORY values (5,N'Bánh quy')
go

insert CAKE values (1,N'Bánh mì ngọt',5000,1,50,N'Kệ 1')
insert CAKE values (2,N'Coffee cake',9000,2,50,N'Kệ 2')
insert CAKE values (3,N'Doughnuts',9000,3,50,N'Kệ 3')
insert CAKE values (4,N'Cheesecake',13000,4,50,N'Kệ 4')
insert CAKE values (5,N'Pound cake',12000,4,50,N'Kệ 4')
insert CAKE values (6,N'Bánh quy trà xanh',5000,5,100,N'Kệ 5')
insert CAKE values (7,N'Bánh quy bơ',5000,5,100,N'Kệ 5')
insert CAKE values (8,N'Cupcake',10000,4,30,N'Kệ 4')
insert CAKE values (9,N'Tart',12000,4,20,N'Kệ 4')
insert CAKE values (10,N'Bánh mì thường',5000,1,100,N'Kệ 1')
go

insert BILL values (1,2020-11-10,3)
insert BILL values (2,2020-10-9,4)
insert BILL values (3,2020-11-10,3)
insert BILL values (4,2020-11-10,3)
insert BILL values (5,2020-9-15,5)
go

insert BILL_INFORCAKE values (1,2,5,9000,1)
insert BILL_INFORCAKE values (2,1,5,5000,2)
insert BILL_INFORCAKE values (2,6,1,5000,3)
insert BILL_INFORCAKE values (3,3,1,9000,4)
insert BILL_INFORCAKE values (4,7,1,5000,5)
insert BILL_INFORCAKE values (5,9,1,12000,6)
insert BILL_INFORCAKE values (5,10,2,5000,7)
go
