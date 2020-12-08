USE [QuanLyTiemBanh]
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
	[total_price] [int] NOT NULL,
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
	[PhoneNumber] [nvarchar](50) NULL,
	[sex] [nvarchar](50) NULL,
	[position] [nvarchar](50) NULL,
	[salary] [int] NULL,
	[status] [int] NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ACCOUNT] ([username], [password], [type], [nhanvien_id]) VALUES (N'ad                                                ', N'1                   ', 1, 1)
INSERT [dbo].[ACCOUNT] ([username], [password], [type], [nhanvien_id]) VALUES (N'nv1                                               ', N'3                   ', 0, 1)
INSERT [dbo].[ACCOUNT] ([username], [password], [type], [nhanvien_id]) VALUES (N'nv2                                               ', N'1                   ', 0, 1)
GO
INSERT [dbo].[EMPLOYEE] ([id], [name], [address], [PhoneNumber], [sex], [position], [salary], [status]) VALUES (1, N'ngan', N'dt', N'12', N'nu', N'nv', 100, 1)
INSERT [dbo].[EMPLOYEE] ([id], [name], [address], [PhoneNumber], [sex], [position], [salary], [status]) VALUES (2, N'my', N'bd', N'13', N'nu', N'nv', 200, 1)
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
