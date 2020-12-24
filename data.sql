

USE [QuanLyTiemBanh]
GO

CREATE TABLE [dbo].[CATEGORY](
	[id] [int] primary key NOT NULL,
	[name] [nvarchar](50) NOT NULL,
)
GO

CREATE TABLE [dbo].[CAKE](
	[id] [int] primary key NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[price] [int] NOT NULL,
	[category_id] [int] NOT NULL,
	[amount] [int] NOT NULL,
	[place] [nvarchar](50) NOT NULL,
	foreign key(category_id) references CATEGORY (id),
)
GO

CREATE TABLE [dbo].[EMPLOYEE](
	[id] [int] primary key NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[address] [nvarchar](50) NULL,
	[PhoneNumber] [char](10) NOT NULL,
	[sex] [nvarchar](10) NULL,
	[position] [nvarchar](50) NOT NULL,
	[salary] [int] NOT NULL,
	[status] [int] NOT NULL,
)
GO


CREATE TABLE [dbo].[ACCOUNT](
	[username] [nchar](50) primary key NOT NULL,
	[password] [nchar](20) NOT NULL,
	[type] [int] NOT NULL,
	[nhanvien_id] [int] NULL,
	foreign key(nhanvien_id) references EMPLOYEE(id)
 )
GO

CREATE TABLE [dbo].[BILL](
	[id] [int] primary key identity(1,1) NOT NULL,
	[day_out] [datetime] NOT NULL,
	[emp_id] [int] NULL,
	foreign key(emp_id) references EMPLOYEE(id)
)
GO

CREATE TABLE [dbo].[BILL_INFORCAKE](
	[id] [int] primary key identity(1,1) NOT NULL,
	[bill_id] [int] NOT NULL,
	[cake_id] [int] NOT NULL,
	[amount] [int] NULL,
	[price] [int] NULL,
	foreign key(bill_id) references BILL(id),
	foreign key(cake_id) references CAKE(id),
)
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

SET IDENTITY_INSERT [dbo].[BILL] ON
GO
insert [dbo].[BILL] ([id],[day_out],[emp_id]) values (1,2020-11-10,3)
insert [dbo].[BILL] ([id],[day_out],[emp_id]) values (2,2020-10-9,4)
insert [dbo].[BILL] ([id],[day_out],[emp_id]) values (3,2020-11-10,3)
insert [dbo].[BILL] ([id],[day_out],[emp_id]) values (4,2020-11-10,3)
insert [dbo].[BILL] ([id],[day_out],[emp_id]) values (5,2020-9-15,5)
GO
SET IDENTITY_INSERT [dbo].[BILL] OFF
go

SET IDENTITY_INSERT [dbo].[BILL_INFORCAKE] ON
GO
insert [dbo].[BILL_INFORCAKE] ([id],[bill_id],[cake_id],[amount],[price]) values (1,1,2,5,9000)
insert [dbo].[BILL_INFORCAKE] ([id],[bill_id],[cake_id],[amount],[price]) values (2,2,1,5,5000)
insert [dbo].[BILL_INFORCAKE] ([id],[bill_id],[cake_id],[amount],[price]) values (3,2,6,1,5000)
insert [dbo].[BILL_INFORCAKE] ([id],[bill_id],[cake_id],[amount],[price]) values (4,3,3,1,9000)
insert [dbo].[BILL_INFORCAKE] ([id],[bill_id],[cake_id],[amount],[price]) values (5,4,7,1,5000)
insert [dbo].[BILL_INFORCAKE] ([id],[bill_id],[cake_id],[amount],[price]) values (6,5,9,1,12000)
insert [dbo].[BILL_INFORCAKE] ([id],[bill_id],[cake_id],[amount],[price]) values (7,5,10,2,5000)
go
SET IDENTITY_INSERT [dbo].[BILL_INFORCAKE] OFF
GO
