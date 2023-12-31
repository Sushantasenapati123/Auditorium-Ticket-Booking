USE [Auditorium]
GO
/****** Object:  Table [dbo].[Auditorium_TBL]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Auditorium_TBL](
	[AuditoriumId] [int] IDENTITY(1,1) NOT NULL,
	[RowId] [int] NULL,
	[AuditoriumName] [varchar](50) NULL,
	[AuditoriumDesc] [varchar](50) NULL,
	[DeletedFlag] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Block_Tbl]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Block_Tbl](
	[BlockId] [int] IDENTITY(1,1) NOT NULL,
	[BlockName] [varchar](50) NULL,
	[AuditoriumId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[BlockId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Booking_Tbl]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking_Tbl](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BookingDate] [date] NULL,
	[UserId] [varchar](50) NULL,
	[AuditoriumId] [int] NULL,
	[BlockId] [int] NULL,
	[RowId] [int] NULL,
	[SeatId] [int] NULL,
	[ShowName] [varbinary](50) NULL,
	[ShowType] [varchar](50) NULL,
	[ShowTime] [varbinary](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[M_DepartmentMaster]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[M_DepartmentMaster](
	[DepartmentId] [int] IDENTITY(1,1) NOT NULL,
	[Department] [varchar](100) NULL,
	[CreatedOn] [date] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedOn] [date] NULL,
	[UpdatedBy] [int] NULL,
	[DeletedFlag] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[M_DesignationMaster]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[M_DesignationMaster](
	[DesignationId] [int] IDENTITY(1,1) NOT NULL,
	[Designation] [varchar](100) NULL,
	[CreatedOn] [date] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedOn] [date] NULL,
	[UpdatedBy] [int] NULL,
	[DeletedFlag] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[DesignationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[M_Roll_Tbl]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[M_Roll_Tbl](
	[RollID] [int] IDENTITY(1,1) NOT NULL,
	[RollName] [varchar](50) NULL,
	[CreatedOn] [date] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedOn] [date] NULL,
	[DeletedFlag] [bit] NULL,
 CONSTRAINT [PK_M_Roll_Tbl] PRIMARY KEY CLUSTERED 
(
	[RollID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[M_RowTbl]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[M_RowTbl](
	[Row_No] [int] IDENTITY(1,1) NOT NULL,
	[Row_Name] [varchar](50) NULL,
	[DeletedFlag] [bit] NULL,
	[RowDesc] [varchar](50) NULL,
	[IsChecked] [bit] NULL,
 CONSTRAINT [PK_M_RowTbl] PRIMARY KEY CLUSTERED 
(
	[Row_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[M_SeatNoTbl]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[M_SeatNoTbl](
	[Seat_Id] [int] IDENTITY(1,1) NOT NULL,
	[Row_No] [int] NULL,
	[Seat_No] [varchar](100) NULL,
	[DeletedFlag] [bit] NULL,
 CONSTRAINT [PK_M_SeatNoTbl] PRIMARY KEY CLUSTERED 
(
	[Seat_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[M_Tbl_Block]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[M_Tbl_Block](
	[BlockId] [int] IDENTITY(1,1) NOT NULL,
	[AuditoriumID] [int] NULL,
	[BlockName] [varchar](100) NULL,
	[DeletedFlag] [bit] NULL,
	[CreatedBy] [int] NULL,
	[CreatedOn] [date] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedOn] [date] NULL,
 CONSTRAINT [PK_M_Tbl_Block] PRIMARY KEY CLUSTERED 
(
	[BlockId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[M_Tbl_PriceMaster]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[M_Tbl_PriceMaster](
	[PriceId] [int] IDENTITY(1,1) NOT NULL,
	[AuditoriumID] [int] NULL,
	[BlockId] [int] NULL,
	[Row_No] [int] NULL,
	[Price] [varchar](100) NULL,
	[CreatedOn] [date] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedOn] [date] NULL,
	[UpdatedBy] [int] NULL,
	[DeletedFlag] [bit] NULL,
 CONSTRAINT [PK_M_Tbl_PriceMaster] PRIMARY KEY CLUSTERED 
(
	[PriceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[M_Tbl_ShowsMaster]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[M_Tbl_ShowsMaster](
	[ShowID] [int] IDENTITY(1,1) NOT NULL,
	[ShowName] [varchar](100) NULL,
	[AuditoriumID] [int] NULL,
	[CreatedBy] [int] NULL,
	[CreatedOn] [date] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedOn] [date] NULL,
	[DeletedFlag] [bit] NULL,
 CONSTRAINT [PK_M_Tbl_ShowsMaster] PRIMARY KEY CLUSTERED 
(
	[ShowID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[M_Tbl_SlotMaster]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[M_Tbl_SlotMaster](
	[SlotID] [int] IDENTITY(1,1) NOT NULL,
	[SlotName] [varchar](100) NULL,
	[AuditoriumID] [int] NULL,
	[Slot_TimeFrom] [varchar](100) NULL,
	[Slot_TimeTo] [varchar](100) NULL,
	[CreatedBy] [int] NULL,
	[CreatedOn] [date] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedOn] [date] NULL,
	[DeletedFlag] [bit] NULL,
 CONSTRAINT [PK_M_Tbl_SlotMaster] PRIMARY KEY CLUSTERED 
(
	[SlotID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[M_USER]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[M_USER](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[FullName] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Mobile] [varchar](50) NULL,
	[Gender] [varchar](50) NULL,
	[Address] [varchar](500) NULL,
	[Age] [int] NULL,
	[City] [varchar](300) NULL,
	[DesignationId] [int] NULL,
	[DepartmentId] [int] NULL,
	[RollID] [int] NULL,
	[AuditoriumID] [int] NULL,
	[CreatedOn] [date] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedOn] [date] NULL,
	[DeletedFlag] [bit] NULL,
 CONSTRAINT [PK_M_PL_USER] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Row_Tbl]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Row_Tbl](
	[RowId] [int] IDENTITY(1,1) NOT NULL,
	[RowName] [varchar](50) NULL,
	[RowDesc] [varchar](50) NULL,
	[AuditoriumId] [int] NULL,
	[DeletedFlag] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[RowId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seat_Tbl]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seat_Tbl](
	[SeatId] [int] IDENTITY(1,1) NOT NULL,
	[SeatName] [varchar](50) NULL,
	[AuditoriumId] [int] NULL,
	[RowId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SeatId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Block_Row_Mapping]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Block_Row_Mapping](
	[BlockRowID] [int] IDENTITY(1,1) NOT NULL,
	[AuditoriumID] [int] NULL,
	[BlockId] [int] NULL,
	[Row_No] [int] NULL,
	[IsChecked] [bit] NULL,
	[DeletedFlag] [bit] NULL,
	[CreatedBy] [int] NULL,
	[CreatedOn] [date] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedOn] [date] NULL,
 CONSTRAINT [PK_T_Block_Row_Mapping] PRIMARY KEY CLUSTERED 
(
	[BlockRowID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Tbl_SlotMapping]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Tbl_SlotMapping](
	[SMID] [int] IDENTITY(1,1) NOT NULL,
	[AuditoriumID] [int] NULL,
	[SlotID] [int] NULL,
	[ShowDate] [date] NULL,
	[ShowID] [int] NULL,
	[CreatedBy] [int] NULL,
	[CreatedOn] [date] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedOn] [date] NULL,
	[DeletedFlag] [bit] NULL,
 CONSTRAINT [PK_T_Tbl_SlotMapping] PRIMARY KEY CLUSTERED 
(
	[SMID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Auth_Menu]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Auth_Menu](
	[MenuID] [int] IDENTITY(1,1) NOT NULL,
	[MenuName] [varchar](100) NULL,
	[SlNo] [int] NULL,
	[IconName] [varchar](100) NULL,
	[CreatedOn] [date] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedOn] [date] NULL,
	[UpdatedBy] [int] NULL,
	[DeletedFlag] [bit] NULL,
 CONSTRAINT [PK_Tbl_Auth_Menu] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Auth_Permission]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Auth_Permission](
	[PermissionId] [int] IDENTITY(1,1) NOT NULL,
	[RollID] [int] NULL,
	[UserId] [int] NULL,
	[SubMenuID] [int] NULL,
	[IsChecked] [bit] NULL,
	[CreatedOn] [date] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedOn] [date] NULL,
	[UpdatedBy] [int] NULL,
	[DeletedFlag] [bit] NULL,
 CONSTRAINT [PK_Tbl_Auth_Permission] PRIMARY KEY CLUSTERED 
(
	[PermissionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Auth_SubMenu]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Auth_SubMenu](
	[SubMenuID] [int] IDENTITY(1,1) NOT NULL,
	[SubMenuName] [varchar](100) NULL,
	[SubMenuURL] [varchar](100) NULL,
	[MenuID] [int] NULL,
	[SlNo] [int] NULL,
	[SubMenuDescription] [varchar](100) NULL,
	[CreatedOn] [date] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedOn] [date] NULL,
	[UpdatedBy] [int] NULL,
	[DeletedFlag] [bit] NULL,
 CONSTRAINT [PK_Tbl_Auth_SubMenu] PRIMARY KEY CLUSTERED 
(
	[SubMenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Bk_ScreenMap]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Bk_ScreenMap](
	[ScreenMapId] [int] IDENTITY(1,1) NOT NULL,
	[AuditoriumID] [int] NULL,
	[id] [int] NULL,
	[ShowId] [int] NULL,
	[CreatedOn] [date] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedOn] [date] NULL,
	[UpdatedBy] [int] NULL,
	[DeletedFlag] [bit] NULL,
	[ShowTimeFrom] [varchar](100) NULL,
	[ShowTimeTo] [varchar](100) NULL,
	[ShowType] [varchar](100) NULL,
 CONSTRAINT [PK_Tbl_Bk_ScreenMap] PRIMARY KEY CLUSTERED 
(
	[ScreenMapId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Bk_ShowMaster]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Bk_ShowMaster](
	[ShowId] [int] IDENTITY(1,1) NOT NULL,
	[ShowName] [varchar](50) NULL,
	[ShowType] [varchar](50) NULL,
	[ShowTimeFrom] [varchar](100) NULL,
	[ShowTimeTo] [varchar](100) NULL,
	[ShowDate] [date] NULL,
	[Photo] [varchar](50) NULL,
	[id] [int] NULL,
	[CreatedBy] [int] NULL,
	[CreatedOn] [date] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedOn] [date] NULL,
	[DeletedFlag] [bit] NULL,
 CONSTRAINT [PK_Tbl_Bk_ShowMaster] PRIMARY KEY CLUSTERED 
(
	[ShowId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Bkg_SeatNOs]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Bkg_SeatNOs](
	[SeatNoId] [int] IDENTITY(1,1) NOT NULL,
	[SeatId] [int] NULL,
	[SeatNos] [int] NULL,
	[DeletedFlag] [bit] NULL,
	[AuditoriumID] [int] NULL,
	[Row_No] [int] NULL,
 CONSTRAINT [PK_Tbl_Bkg_SeatNOs] PRIMARY KEY CLUSTERED 
(
	[SeatNoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_M_Auditorium]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_M_Auditorium](
	[AuditoriumID] [int] IDENTITY(1,1) NOT NULL,
	[AuditoriumName] [varchar](100) NULL,
	[DeletedFlag] [bit] NULL,
 CONSTRAINT [PK_Tbl_M_Auditorium] PRIMARY KEY CLUSTERED 
(
	[AuditoriumID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Seatmaster]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Seatmaster](
	[SeatId] [int] IDENTITY(1,1) NOT NULL,
	[AuditoriumID] [int] NULL,
	[Row_No] [int] NULL,
	[SeatCapacity] [int] NULL,
	[DeletedFlag] [bit] NULL,
	[CreatedBy] [int] NULL,
	[CreatedOn] [date] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedOn] [date] NULL,
	[IsChecked] [bit] NULL,
 CONSTRAINT [PK_Tbl_Seatmaster] PRIMARY KEY CLUSTERED 
(
	[SeatId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_ShowType]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_ShowType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ShowType] [varchar](50) NULL,
 CONSTRAINT [PK_Tbl_ShowType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_T_AudiSeat]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_T_AudiSeat](
	[AuditseatID] [int] IDENTITY(1,1) NOT NULL,
	[Row_No] [int] NULL,
	[Number] [varchar](50) NULL,
	[AuditoriumID] [int] NULL,
	[DeletedFlag] [bit] NULL,
 CONSTRAINT [PK_Tbl_T_AudiSeat] PRIMARY KEY CLUSTERED 
(
	[AuditseatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserLogin_Tbl]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserLogin_Tbl](
	[UserId] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[UserName] [varchar](100) NULL,
	[UserType] [varchar](10) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Auditorium_TBL] ON 

INSERT [dbo].[Auditorium_TBL] ([AuditoriumId], [RowId], [AuditoriumName], [AuditoriumDesc], [DeletedFlag]) VALUES (1, NULL, N'Gopabandhu Auditorium', N'For Dancing', NULL)
INSERT [dbo].[Auditorium_TBL] ([AuditoriumId], [RowId], [AuditoriumName], [AuditoriumDesc], [DeletedFlag]) VALUES (2, NULL, N'M1', N'For Mythology', NULL)
INSERT [dbo].[Auditorium_TBL] ([AuditoriumId], [RowId], [AuditoriumName], [AuditoriumDesc], [DeletedFlag]) VALUES (3, NULL, N'M2', N'A Small Auditorium', NULL)
INSERT [dbo].[Auditorium_TBL] ([AuditoriumId], [RowId], [AuditoriumName], [AuditoriumDesc], [DeletedFlag]) VALUES (4, NULL, N'ded', NULL, NULL)
INSERT [dbo].[Auditorium_TBL] ([AuditoriumId], [RowId], [AuditoriumName], [AuditoriumDesc], [DeletedFlag]) VALUES (5, NULL, N'dede', NULL, NULL)
INSERT [dbo].[Auditorium_TBL] ([AuditoriumId], [RowId], [AuditoriumName], [AuditoriumDesc], [DeletedFlag]) VALUES (6, NULL, N'Gopabandhu Auditorium', N'For Dancing', NULL)
INSERT [dbo].[Auditorium_TBL] ([AuditoriumId], [RowId], [AuditoriumName], [AuditoriumDesc], [DeletedFlag]) VALUES (7, NULL, N'M1', N'For Mythology', NULL)
INSERT [dbo].[Auditorium_TBL] ([AuditoriumId], [RowId], [AuditoriumName], [AuditoriumDesc], [DeletedFlag]) VALUES (8, NULL, N'M2', N'A Small Auditorium', NULL)
SET IDENTITY_INSERT [dbo].[Auditorium_TBL] OFF
GO
SET IDENTITY_INSERT [dbo].[Block_Tbl] ON 

INSERT [dbo].[Block_Tbl] ([BlockId], [BlockName], [AuditoriumId]) VALUES (1, N'Block A', 6)
INSERT [dbo].[Block_Tbl] ([BlockId], [BlockName], [AuditoriumId]) VALUES (2, N'Block B', 6)
INSERT [dbo].[Block_Tbl] ([BlockId], [BlockName], [AuditoriumId]) VALUES (3, N'Block C', 6)
INSERT [dbo].[Block_Tbl] ([BlockId], [BlockName], [AuditoriumId]) VALUES (4, N'Block A', 7)
INSERT [dbo].[Block_Tbl] ([BlockId], [BlockName], [AuditoriumId]) VALUES (5, N'Block B', 7)
INSERT [dbo].[Block_Tbl] ([BlockId], [BlockName], [AuditoriumId]) VALUES (6, N'Block C', 7)
INSERT [dbo].[Block_Tbl] ([BlockId], [BlockName], [AuditoriumId]) VALUES (7, N'Block A', 8)
INSERT [dbo].[Block_Tbl] ([BlockId], [BlockName], [AuditoriumId]) VALUES (8, N'Block B', 8)
INSERT [dbo].[Block_Tbl] ([BlockId], [BlockName], [AuditoriumId]) VALUES (9, N'Block C', 8)
SET IDENTITY_INSERT [dbo].[Block_Tbl] OFF
GO
SET IDENTITY_INSERT [dbo].[Booking_Tbl] ON 

INSERT [dbo].[Booking_Tbl] ([Id], [BookingDate], [UserId], [AuditoriumId], [BlockId], [RowId], [SeatId], [ShowName], [ShowType], [ShowTime]) VALUES (1, CAST(N'2023-06-21' AS Date), N'SuperAdmin123', 8, 2, 2, 15, NULL, NULL, NULL)
INSERT [dbo].[Booking_Tbl] ([Id], [BookingDate], [UserId], [AuditoriumId], [BlockId], [RowId], [SeatId], [ShowName], [ShowType], [ShowTime]) VALUES (2, CAST(N'2023-06-22' AS Date), N'SuperAdmin123', 6, 2, 1, 4, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Booking_Tbl] OFF
GO
SET IDENTITY_INSERT [dbo].[M_DepartmentMaster] ON 

INSERT [dbo].[M_DepartmentMaster] ([DepartmentId], [Department], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (1, N'Adminstrative', CAST(N'2023-04-17' AS Date), NULL, NULL, NULL, 0)
INSERT [dbo].[M_DepartmentMaster] ([DepartmentId], [Department], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (2, N'HR', CAST(N'2023-04-17' AS Date), NULL, NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[M_DepartmentMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[M_DesignationMaster] ON 

INSERT [dbo].[M_DesignationMaster] ([DesignationId], [Designation], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (1, N'Manager', CAST(N'2023-04-17' AS Date), NULL, NULL, NULL, 0)
INSERT [dbo].[M_DesignationMaster] ([DesignationId], [Designation], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (2, N'Asst.Manager', CAST(N'2023-04-17' AS Date), NULL, NULL, NULL, 0)
INSERT [dbo].[M_DesignationMaster] ([DesignationId], [Designation], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (3, N'Executive', CAST(N'2023-04-17' AS Date), NULL, NULL, NULL, 0)
INSERT [dbo].[M_DesignationMaster] ([DesignationId], [Designation], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (4, N'User', CAST(N'2023-06-14' AS Date), NULL, NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[M_DesignationMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[M_Roll_Tbl] ON 

INSERT [dbo].[M_Roll_Tbl] ([RollID], [RollName], [CreatedOn], [CreatedBy], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (1, N'Admin', CAST(N'2023-04-17' AS Date), NULL, NULL, CAST(N'2023-04-17' AS Date), 0)
INSERT [dbo].[M_Roll_Tbl] ([RollID], [RollName], [CreatedOn], [CreatedBy], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (2, N'User', CAST(N'2023-04-17' AS Date), NULL, NULL, CAST(N'2023-04-17' AS Date), 0)
INSERT [dbo].[M_Roll_Tbl] ([RollID], [RollName], [CreatedOn], [CreatedBy], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (3, N'SuperAdmin', CAST(N'2023-04-19' AS Date), NULL, NULL, CAST(N'2023-04-19' AS Date), 0)
SET IDENTITY_INSERT [dbo].[M_Roll_Tbl] OFF
GO
SET IDENTITY_INSERT [dbo].[M_RowTbl] ON 

INSERT [dbo].[M_RowTbl] ([Row_No], [Row_Name], [DeletedFlag], [RowDesc], [IsChecked]) VALUES (1, N'1', 0, N'R1', 0)
INSERT [dbo].[M_RowTbl] ([Row_No], [Row_Name], [DeletedFlag], [RowDesc], [IsChecked]) VALUES (2, N'2', 0, N'R2', 0)
INSERT [dbo].[M_RowTbl] ([Row_No], [Row_Name], [DeletedFlag], [RowDesc], [IsChecked]) VALUES (3, N'3', 0, N'R3', 0)
INSERT [dbo].[M_RowTbl] ([Row_No], [Row_Name], [DeletedFlag], [RowDesc], [IsChecked]) VALUES (4, N'4', 0, N'R4', 0)
INSERT [dbo].[M_RowTbl] ([Row_No], [Row_Name], [DeletedFlag], [RowDesc], [IsChecked]) VALUES (5, N'5', 0, N'R5', 0)
INSERT [dbo].[M_RowTbl] ([Row_No], [Row_Name], [DeletedFlag], [RowDesc], [IsChecked]) VALUES (6, N'7', 1, N'E4', NULL)
SET IDENTITY_INSERT [dbo].[M_RowTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[M_SeatNoTbl] ON 

INSERT [dbo].[M_SeatNoTbl] ([Seat_Id], [Row_No], [Seat_No], [DeletedFlag]) VALUES (1, 1, N'A1', 0)
SET IDENTITY_INSERT [dbo].[M_SeatNoTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[M_Tbl_Block] ON 

INSERT [dbo].[M_Tbl_Block] ([BlockId], [AuditoriumID], [BlockName], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (1, 6, N'A', 0, NULL, CAST(N'2023-04-26' AS Date), NULL, CAST(N'2023-04-26' AS Date))
INSERT [dbo].[M_Tbl_Block] ([BlockId], [AuditoriumID], [BlockName], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (2, 6, N'B', 0, NULL, CAST(N'2023-04-26' AS Date), NULL, CAST(N'2023-04-26' AS Date))
INSERT [dbo].[M_Tbl_Block] ([BlockId], [AuditoriumID], [BlockName], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (3, 6, N'C', 0, NULL, CAST(N'2023-04-26' AS Date), NULL, CAST(N'2023-04-26' AS Date))
INSERT [dbo].[M_Tbl_Block] ([BlockId], [AuditoriumID], [BlockName], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (4, 7, N'A', 0, NULL, CAST(N'2023-04-26' AS Date), NULL, CAST(N'2023-04-26' AS Date))
INSERT [dbo].[M_Tbl_Block] ([BlockId], [AuditoriumID], [BlockName], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (5, 7, N'B', 0, NULL, CAST(N'2023-04-26' AS Date), NULL, CAST(N'2023-04-26' AS Date))
INSERT [dbo].[M_Tbl_Block] ([BlockId], [AuditoriumID], [BlockName], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (6, 7, N'C', 0, NULL, CAST(N'2023-04-26' AS Date), NULL, CAST(N'2023-04-26' AS Date))
INSERT [dbo].[M_Tbl_Block] ([BlockId], [AuditoriumID], [BlockName], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (7, 8, N'D', 0, NULL, CAST(N'2023-04-26' AS Date), NULL, CAST(N'2023-04-26' AS Date))
INSERT [dbo].[M_Tbl_Block] ([BlockId], [AuditoriumID], [BlockName], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (8, 8, N'A', 0, NULL, CAST(N'2023-05-02' AS Date), NULL, CAST(N'2023-05-02' AS Date))
INSERT [dbo].[M_Tbl_Block] ([BlockId], [AuditoriumID], [BlockName], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (9, 8, N'B', 0, NULL, CAST(N'2023-05-02' AS Date), NULL, CAST(N'2023-05-02' AS Date))
SET IDENTITY_INSERT [dbo].[M_Tbl_Block] OFF
GO
SET IDENTITY_INSERT [dbo].[M_Tbl_PriceMaster] ON 

INSERT [dbo].[M_Tbl_PriceMaster] ([PriceId], [AuditoriumID], [BlockId], [Row_No], [Price], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (1, 1, 1, 1, N'100', CAST(N'2023-05-12' AS Date), NULL, CAST(N'2023-05-12' AS Date), NULL, 0)
INSERT [dbo].[M_Tbl_PriceMaster] ([PriceId], [AuditoriumID], [BlockId], [Row_No], [Price], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (2, 2, 4, 1, N'200', CAST(N'2023-05-15' AS Date), NULL, CAST(N'2023-05-15' AS Date), NULL, 0)
INSERT [dbo].[M_Tbl_PriceMaster] ([PriceId], [AuditoriumID], [BlockId], [Row_No], [Price], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (3, 3, 8, 1, N'22', CAST(N'2023-05-15' AS Date), NULL, CAST(N'2023-05-15' AS Date), NULL, 1)
SET IDENTITY_INSERT [dbo].[M_Tbl_PriceMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[M_Tbl_ShowsMaster] ON 

INSERT [dbo].[M_Tbl_ShowsMaster] ([ShowID], [ShowName], [AuditoriumID], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (1, N'GasLight', 1, NULL, CAST(N'2023-04-13' AS Date), NULL, CAST(N'2023-04-13' AS Date), 0)
INSERT [dbo].[M_Tbl_ShowsMaster] ([ShowID], [ShowName], [AuditoriumID], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (2, N'IronMan', 2, NULL, CAST(N'2023-04-13' AS Date), NULL, CAST(N'2023-04-13' AS Date), 0)
INSERT [dbo].[M_Tbl_ShowsMaster] ([ShowID], [ShowName], [AuditoriumID], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (3, N'CaptainAmerica', 2, NULL, CAST(N'2023-04-13' AS Date), NULL, CAST(N'2023-04-13' AS Date), 0)
SET IDENTITY_INSERT [dbo].[M_Tbl_ShowsMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[M_Tbl_SlotMaster] ON 

INSERT [dbo].[M_Tbl_SlotMaster] ([SlotID], [SlotName], [AuditoriumID], [Slot_TimeFrom], [Slot_TimeTo], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (1, N'Morning', 1, N'06:00', N'07:30', NULL, CAST(N'2023-04-12' AS Date), NULL, CAST(N'2023-04-12' AS Date), 0)
INSERT [dbo].[M_Tbl_SlotMaster] ([SlotID], [SlotName], [AuditoriumID], [Slot_TimeFrom], [Slot_TimeTo], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (2, N'Morning', 2, N'06:30', N'08:00', NULL, CAST(N'2023-04-12' AS Date), NULL, CAST(N'2023-04-12' AS Date), 0)
INSERT [dbo].[M_Tbl_SlotMaster] ([SlotID], [SlotName], [AuditoriumID], [Slot_TimeFrom], [Slot_TimeTo], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (3, N'Evening', 1, N'12:00', N'14:50', NULL, CAST(N'2023-04-12' AS Date), NULL, CAST(N'2023-04-12' AS Date), 0)
INSERT [dbo].[M_Tbl_SlotMaster] ([SlotID], [SlotName], [AuditoriumID], [Slot_TimeFrom], [Slot_TimeTo], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (4, N'Afternoon', 2, N'12:45', N'14:00', NULL, CAST(N'2023-04-13' AS Date), NULL, CAST(N'2023-04-13' AS Date), 0)
SET IDENTITY_INSERT [dbo].[M_Tbl_SlotMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[M_USER] ON 

INSERT [dbo].[M_USER] ([UserId], [UserName], [Password], [FullName], [Email], [Mobile], [Gender], [Address], [Age], [City], [DesignationId], [DepartmentId], [RollID], [AuditoriumID], [CreatedOn], [CreatedBy], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (1, N'Admin123', N'Admin', N'Subhasmita Nayak', N'nayak12@gmail.com', N'7205828589`', N'Female', N'Bhubaneswar', 27, N'bhubaneswar', 1, 1, 1, 1, CAST(N'2023-04-17' AS Date), NULL, NULL, NULL, 0)
INSERT [dbo].[M_USER] ([UserId], [UserName], [Password], [FullName], [Email], [Mobile], [Gender], [Address], [Age], [City], [DesignationId], [DepartmentId], [RollID], [AuditoriumID], [CreatedOn], [CreatedBy], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (2, N'Vinaya12', N'Vinaya@12', N'Vinaya Shah', N'Shah@gmai.com', N'7689078678', N'Male', N'At-Kalpana Square', 33, N'Bhubaneswar', 1, 2, 2, 2, CAST(N'2023-04-17' AS Date), NULL, NULL, NULL, 0)
INSERT [dbo].[M_USER] ([UserId], [UserName], [Password], [FullName], [Email], [Mobile], [Gender], [Address], [Age], [City], [DesignationId], [DepartmentId], [RollID], [AuditoriumID], [CreatedOn], [CreatedBy], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (3, N'sushanta12', N'sushanta@12', N'Shusanta', N'Senapati@gmail.com', N'654327890', N'Female', N'Kalpana', 45, N'bbsr', 2, 2, 2, 1, CAST(N'2023-04-17' AS Date), NULL, NULL, NULL, 0)
INSERT [dbo].[M_USER] ([UserId], [UserName], [Password], [FullName], [Email], [Mobile], [Gender], [Address], [Age], [City], [DesignationId], [DepartmentId], [RollID], [AuditoriumID], [CreatedOn], [CreatedBy], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (4, N'SuperAdmin12', N'SuperAdmin@12', N'Subhasmita', N'nayak@gmail.com', N'9937861938', N'Female', N'Bhubaneswar', 27, N'Bhubaneswar', 1, 1, 3, 1, CAST(N'2023-04-19' AS Date), NULL, NULL, NULL, 0)
INSERT [dbo].[M_USER] ([UserId], [UserName], [Password], [FullName], [Email], [Mobile], [Gender], [Address], [Age], [City], [DesignationId], [DepartmentId], [RollID], [AuditoriumID], [CreatedOn], [CreatedBy], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (5, N'Subhasmita12', N'Subhasmita@12', N'Subhasmita Nayak', N'nayaksubha@gmail.com', N'8907689890', N'Female', N'Bhubaneswar', 27, N'Bhubaneswar', 1, 1, 3, 1, CAST(N'2023-04-20' AS Date), NULL, NULL, NULL, 0)
INSERT [dbo].[M_USER] ([UserId], [UserName], [Password], [FullName], [Email], [Mobile], [Gender], [Address], [Age], [City], [DesignationId], [DepartmentId], [RollID], [AuditoriumID], [CreatedOn], [CreatedBy], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (6, N'SuperAdmin123', N'SuperAdmin123', N'Sushanta kumar senapati', N'sushantasenapati718@gmail.com', N'3434343434', N'Not Mention', N'Not Mention', 0, N'Not Mention', 4, 0, 2, 0, CAST(N'2023-06-14' AS Date), NULL, NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[M_USER] OFF
GO
SET IDENTITY_INSERT [dbo].[Row_Tbl] ON 

INSERT [dbo].[Row_Tbl] ([RowId], [RowName], [RowDesc], [AuditoriumId], [DeletedFlag]) VALUES (1, N'A', N'Front Row', 6, NULL)
INSERT [dbo].[Row_Tbl] ([RowId], [RowName], [RowDesc], [AuditoriumId], [DeletedFlag]) VALUES (2, N'B', N'Middle Row', 6, NULL)
INSERT [dbo].[Row_Tbl] ([RowId], [RowName], [RowDesc], [AuditoriumId], [DeletedFlag]) VALUES (3, N'C', N'Back Row', 6, NULL)
INSERT [dbo].[Row_Tbl] ([RowId], [RowName], [RowDesc], [AuditoriumId], [DeletedFlag]) VALUES (4, N'A', N'Front Row', 7, NULL)
INSERT [dbo].[Row_Tbl] ([RowId], [RowName], [RowDesc], [AuditoriumId], [DeletedFlag]) VALUES (5, N'B', N'Middle Row', 7, NULL)
INSERT [dbo].[Row_Tbl] ([RowId], [RowName], [RowDesc], [AuditoriumId], [DeletedFlag]) VALUES (6, N'C', N'Back Row', 7, NULL)
INSERT [dbo].[Row_Tbl] ([RowId], [RowName], [RowDesc], [AuditoriumId], [DeletedFlag]) VALUES (7, N'A', N'Front Row', 8, NULL)
INSERT [dbo].[Row_Tbl] ([RowId], [RowName], [RowDesc], [AuditoriumId], [DeletedFlag]) VALUES (8, N'B', N'Middle Row', 8, NULL)
INSERT [dbo].[Row_Tbl] ([RowId], [RowName], [RowDesc], [AuditoriumId], [DeletedFlag]) VALUES (9, N'C', N'Back Row', 8, NULL)
SET IDENTITY_INSERT [dbo].[Row_Tbl] OFF
GO
SET IDENTITY_INSERT [dbo].[Seat_Tbl] ON 

INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (1, N'1', 6, 1)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (2, N'2', 6, 1)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (3, N'3', 6, 1)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (4, N'4', 6, 1)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (5, N'5', 6, 1)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (6, N'6', 6, 1)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (7, N'7', 6, 1)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (8, N'8', 6, 1)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (9, N'9', 6, 1)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (10, N'10', 6, 1)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (11, N'11', 6, 2)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (12, N'12', 6, 2)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (13, N'13', 6, 2)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (14, N'14', 6, 2)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (15, N'15', 6, 2)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (16, N'16', 6, 2)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (17, N'17', 6, 2)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (18, N'18', 6, 2)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (19, N'19', 6, 2)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (20, N'20', 6, 2)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (21, N'21', 6, 3)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (22, N'22', 6, 3)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (23, N'23', 6, 3)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (24, N'24', 6, 3)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (25, N'25', 6, 3)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (26, N'26', 6, 3)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (27, N'27', 6, 3)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (28, N'28', 6, 3)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (29, N'29', 6, 3)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (30, N'30', 6, 3)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (31, N'1', 7, 4)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (32, N'2', 7, 4)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (33, N'3', 7, 4)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (34, N'4', 7, 4)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (35, N'5', 7, 4)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (36, N'6', 7, 4)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (37, N'7', 7, 4)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (38, N'8', 7, 4)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (39, N'9', 7, 4)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (40, N'10', 7, 4)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (41, N'11', 7, 5)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (42, N'12', 7, 5)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (43, N'13', 7, 5)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (44, N'14', 7, 5)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (45, N'15', 7, 5)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (46, N'16', 7, 5)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (47, N'17', 7, 5)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (48, N'18', 7, 5)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (49, N'19', 7, 5)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (50, N'20', 7, 5)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (51, N'21', 7, 6)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (52, N'22', 7, 6)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (53, N'23', 7, 6)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (54, N'24', 7, 6)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (55, N'25', 7, 6)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (56, N'26', 7, 6)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (57, N'27', 7, 6)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (58, N'28', 7, 6)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (59, N'29', 7, 6)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (60, N'30', 7, 6)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (61, N'1', 8, 7)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (62, N'2', 8, 7)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (63, N'3', 8, 7)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (64, N'4', 8, 7)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (65, N'5', 8, 7)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (66, N'6', 8, 7)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (67, N'7', 8, 7)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (68, N'8', 8, 7)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (69, N'9', 8, 7)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (70, N'10', 8, 7)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (71, N'11', 8, 8)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (72, N'12', 8, 8)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (73, N'13', 8, 8)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (74, N'14', 8, 8)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (75, N'15', 8, 8)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (76, N'16', 8, 8)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (77, N'17', 8, 8)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (78, N'18', 8, 8)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (79, N'19', 8, 8)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (80, N'20', 8, 8)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (81, N'21', 8, 9)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (82, N'22', 8, 9)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (83, N'23', 8, 9)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (84, N'24', 8, 9)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (85, N'25', 8, 9)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (86, N'26', 8, 9)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (87, N'27', 8, 9)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (88, N'28', 8, 9)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (89, N'29', 8, 9)
INSERT [dbo].[Seat_Tbl] ([SeatId], [SeatName], [AuditoriumId], [RowId]) VALUES (90, N'30', 8, 9)
SET IDENTITY_INSERT [dbo].[Seat_Tbl] OFF
GO
SET IDENTITY_INSERT [dbo].[T_Block_Row_Mapping] ON 

INSERT [dbo].[T_Block_Row_Mapping] ([BlockRowID], [AuditoriumID], [BlockId], [Row_No], [IsChecked], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (1, 1, 1, 1, 1, 0, NULL, CAST(N'2023-05-03' AS Date), NULL, CAST(N'2023-05-03' AS Date))
INSERT [dbo].[T_Block_Row_Mapping] ([BlockRowID], [AuditoriumID], [BlockId], [Row_No], [IsChecked], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (2, 1, 1, 2, 1, 0, NULL, CAST(N'2023-05-03' AS Date), NULL, CAST(N'2023-05-03' AS Date))
INSERT [dbo].[T_Block_Row_Mapping] ([BlockRowID], [AuditoriumID], [BlockId], [Row_No], [IsChecked], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (3, 1, 2, 1, 1, 0, NULL, CAST(N'2023-05-03' AS Date), NULL, CAST(N'2023-05-03' AS Date))
INSERT [dbo].[T_Block_Row_Mapping] ([BlockRowID], [AuditoriumID], [BlockId], [Row_No], [IsChecked], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (4, 1, 2, 2, 1, 0, NULL, CAST(N'2023-05-03' AS Date), NULL, CAST(N'2023-05-03' AS Date))
INSERT [dbo].[T_Block_Row_Mapping] ([BlockRowID], [AuditoriumID], [BlockId], [Row_No], [IsChecked], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (5, 1, 2, 3, 1, 0, NULL, CAST(N'2023-05-03' AS Date), NULL, CAST(N'2023-05-03' AS Date))
INSERT [dbo].[T_Block_Row_Mapping] ([BlockRowID], [AuditoriumID], [BlockId], [Row_No], [IsChecked], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (6, 1, 2, 4, 1, 0, NULL, CAST(N'2023-05-03' AS Date), NULL, CAST(N'2023-05-03' AS Date))
INSERT [dbo].[T_Block_Row_Mapping] ([BlockRowID], [AuditoriumID], [BlockId], [Row_No], [IsChecked], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (8, 1, 3, 1, 1, 0, NULL, CAST(N'2023-05-03' AS Date), NULL, CAST(N'2023-05-03' AS Date))
INSERT [dbo].[T_Block_Row_Mapping] ([BlockRowID], [AuditoriumID], [BlockId], [Row_No], [IsChecked], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (9, 1, 3, 2, 1, 0, NULL, CAST(N'2023-05-03' AS Date), NULL, CAST(N'2023-05-03' AS Date))
INSERT [dbo].[T_Block_Row_Mapping] ([BlockRowID], [AuditoriumID], [BlockId], [Row_No], [IsChecked], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (10, 1, 3, 3, 1, 0, NULL, CAST(N'2023-05-03' AS Date), NULL, CAST(N'2023-05-03' AS Date))
INSERT [dbo].[T_Block_Row_Mapping] ([BlockRowID], [AuditoriumID], [BlockId], [Row_No], [IsChecked], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (11, 2, 4, 1, 1, 0, NULL, CAST(N'2023-05-15' AS Date), NULL, CAST(N'2023-05-15' AS Date))
INSERT [dbo].[T_Block_Row_Mapping] ([BlockRowID], [AuditoriumID], [BlockId], [Row_No], [IsChecked], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (12, 2, 4, 2, 1, 0, NULL, CAST(N'2023-05-15' AS Date), NULL, CAST(N'2023-05-15' AS Date))
INSERT [dbo].[T_Block_Row_Mapping] ([BlockRowID], [AuditoriumID], [BlockId], [Row_No], [IsChecked], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (13, 2, 4, 3, 1, 0, NULL, CAST(N'2023-05-15' AS Date), NULL, CAST(N'2023-05-15' AS Date))
INSERT [dbo].[T_Block_Row_Mapping] ([BlockRowID], [AuditoriumID], [BlockId], [Row_No], [IsChecked], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (14, 2, 5, 1, 1, 0, NULL, CAST(N'2023-05-15' AS Date), NULL, CAST(N'2023-05-15' AS Date))
INSERT [dbo].[T_Block_Row_Mapping] ([BlockRowID], [AuditoriumID], [BlockId], [Row_No], [IsChecked], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (15, 2, 5, 2, 1, 0, NULL, CAST(N'2023-05-15' AS Date), NULL, CAST(N'2023-05-15' AS Date))
INSERT [dbo].[T_Block_Row_Mapping] ([BlockRowID], [AuditoriumID], [BlockId], [Row_No], [IsChecked], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (16, 3, 8, 1, 1, 0, NULL, CAST(N'2023-05-15' AS Date), NULL, CAST(N'2023-05-15' AS Date))
INSERT [dbo].[T_Block_Row_Mapping] ([BlockRowID], [AuditoriumID], [BlockId], [Row_No], [IsChecked], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (17, 3, 8, 2, 1, 0, NULL, CAST(N'2023-05-15' AS Date), NULL, CAST(N'2023-05-15' AS Date))
SET IDENTITY_INSERT [dbo].[T_Block_Row_Mapping] OFF
GO
SET IDENTITY_INSERT [dbo].[T_Tbl_SlotMapping] ON 

INSERT [dbo].[T_Tbl_SlotMapping] ([SMID], [AuditoriumID], [SlotID], [ShowDate], [ShowID], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (1, 1, 1, CAST(N'2023-04-14' AS Date), 1, NULL, CAST(N'2023-04-13' AS Date), NULL, CAST(N'2023-04-13' AS Date), 0)
INSERT [dbo].[T_Tbl_SlotMapping] ([SMID], [AuditoriumID], [SlotID], [ShowDate], [ShowID], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (2, 1, 3, CAST(N'2023-04-14' AS Date), 1, NULL, CAST(N'2023-04-13' AS Date), NULL, CAST(N'2023-04-13' AS Date), 0)
INSERT [dbo].[T_Tbl_SlotMapping] ([SMID], [AuditoriumID], [SlotID], [ShowDate], [ShowID], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (3, 2, 2, CAST(N'2023-04-18' AS Date), 1, NULL, CAST(N'2023-04-14' AS Date), NULL, CAST(N'2023-04-14' AS Date), 0)
INSERT [dbo].[T_Tbl_SlotMapping] ([SMID], [AuditoriumID], [SlotID], [ShowDate], [ShowID], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (4, 2, 4, CAST(N'2023-04-17' AS Date), 3, NULL, CAST(N'2023-04-14' AS Date), NULL, CAST(N'2023-04-14' AS Date), 0)
SET IDENTITY_INSERT [dbo].[T_Tbl_SlotMapping] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Auth_Menu] ON 

INSERT [dbo].[Tbl_Auth_Menu] ([MenuID], [MenuName], [SlNo], [IconName], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (1, N'Authentication', 1, N'fa fa-user-secret', CAST(N'2023-04-19' AS Date), 0, CAST(N'2023-04-19' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Menu] ([MenuID], [MenuName], [SlNo], [IconName], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (2, N'Master', 2, N'fa fa-user', CAST(N'2023-04-19' AS Date), 0, CAST(N'2023-04-19' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Menu] ([MenuID], [MenuName], [SlNo], [IconName], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (3, N'SlotMapping', 2, N'fa fa-map', CAST(N'2023-04-19' AS Date), 0, CAST(N'2023-04-19' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Menu] ([MenuID], [MenuName], [SlNo], [IconName], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (4, N'AuditoriumCapacity', 4, N'fa fa-list', CAST(N'2023-04-19' AS Date), 0, CAST(N'2023-04-19' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Menu] ([MenuID], [MenuName], [SlNo], [IconName], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (5, N'SlotMaster', 5, N'fa fa-list', CAST(N'2023-04-19' AS Date), 0, CAST(N'2023-04-19' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Menu] ([MenuID], [MenuName], [SlNo], [IconName], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (6, N'as3', 6, N'wdh', CAST(N'2023-04-19' AS Date), 0, CAST(N'2023-04-19' AS Date), NULL, 1)
INSERT [dbo].[Tbl_Auth_Menu] ([MenuID], [MenuName], [SlNo], [IconName], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (7, N'SeatMaster', 6, N'fa fa-user', CAST(N'2023-04-21' AS Date), 0, CAST(N'2023-04-21' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Menu] ([MenuID], [MenuName], [SlNo], [IconName], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (8, N'BlockMaster', 7, N'fa fa-list', CAST(N'2023-04-25' AS Date), 0, CAST(N'2023-04-25' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Menu] ([MenuID], [MenuName], [SlNo], [IconName], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (9, N'BlockRowMapping', 8, N'fa fa-map', CAST(N'2023-04-26' AS Date), 0, CAST(N'2023-04-26' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Menu] ([MenuID], [MenuName], [SlNo], [IconName], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (10, N'ScreenMap', 9, N'fa fa-map', CAST(N'2023-05-09' AS Date), 0, CAST(N'2023-05-09' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Menu] ([MenuID], [MenuName], [SlNo], [IconName], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (11, N'Booking', 1, N'fa fa-map', CAST(N'2023-06-14' AS Date), 0, CAST(N'2023-06-14' AS Date), NULL, 0)
SET IDENTITY_INSERT [dbo].[Tbl_Auth_Menu] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Auth_Permission] ON 

INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (273, 1, 0, 1, 0, CAST(N'2023-05-12' AS Date), NULL, CAST(N'2023-05-12' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (274, 1, 0, 2, 0, CAST(N'2023-05-12' AS Date), NULL, CAST(N'2023-05-12' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (275, 1, 0, 3, 0, CAST(N'2023-05-12' AS Date), NULL, CAST(N'2023-05-12' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (276, 1, 0, 4, 0, CAST(N'2023-05-12' AS Date), NULL, CAST(N'2023-05-12' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (277, 1, 0, 5, 0, CAST(N'2023-05-12' AS Date), NULL, CAST(N'2023-05-12' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (278, 1, 0, 6, 0, CAST(N'2023-05-12' AS Date), NULL, CAST(N'2023-05-12' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (279, 1, 0, 7, 1, CAST(N'2023-05-12' AS Date), NULL, CAST(N'2023-05-12' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (280, 1, 0, 8, 1, CAST(N'2023-05-12' AS Date), NULL, CAST(N'2023-05-12' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (281, 1, 0, 9, 0, CAST(N'2023-05-12' AS Date), NULL, CAST(N'2023-05-12' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (282, 1, 0, 10, 0, CAST(N'2023-05-12' AS Date), NULL, CAST(N'2023-05-12' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (283, 1, 0, 11, 0, CAST(N'2023-05-12' AS Date), NULL, CAST(N'2023-05-12' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (284, 1, 0, 12, 1, CAST(N'2023-05-12' AS Date), NULL, CAST(N'2023-05-12' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (285, 1, 0, 13, 1, CAST(N'2023-05-12' AS Date), NULL, CAST(N'2023-05-12' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (286, 1, 0, 14, 1, CAST(N'2023-05-12' AS Date), NULL, CAST(N'2023-05-12' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (287, 1, 0, 15, 1, CAST(N'2023-05-12' AS Date), NULL, CAST(N'2023-05-12' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (288, 1, 0, 16, 1, CAST(N'2023-05-12' AS Date), NULL, CAST(N'2023-05-12' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (289, 1, 0, 17, 1, CAST(N'2023-05-12' AS Date), NULL, CAST(N'2023-05-12' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (308, 2, 0, 1, 0, CAST(N'2023-06-16' AS Date), NULL, CAST(N'2023-06-16' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (309, 2, 0, 2, 0, CAST(N'2023-06-16' AS Date), NULL, CAST(N'2023-06-16' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (310, 2, 0, 3, 0, CAST(N'2023-06-16' AS Date), NULL, CAST(N'2023-06-16' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (311, 2, 0, 4, 0, CAST(N'2023-06-16' AS Date), NULL, CAST(N'2023-06-16' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (312, 2, 0, 5, 0, CAST(N'2023-06-16' AS Date), NULL, CAST(N'2023-06-16' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (313, 2, 0, 6, 0, CAST(N'2023-06-16' AS Date), NULL, CAST(N'2023-06-16' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (314, 2, 0, 7, 0, CAST(N'2023-06-16' AS Date), NULL, CAST(N'2023-06-16' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (315, 2, 0, 8, 0, CAST(N'2023-06-16' AS Date), NULL, CAST(N'2023-06-16' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (316, 2, 0, 9, 0, CAST(N'2023-06-16' AS Date), NULL, CAST(N'2023-06-16' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (317, 2, 0, 10, 0, CAST(N'2023-06-16' AS Date), NULL, CAST(N'2023-06-16' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (318, 2, 0, 11, 0, CAST(N'2023-06-16' AS Date), NULL, CAST(N'2023-06-16' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (319, 2, 0, 12, 0, CAST(N'2023-06-16' AS Date), NULL, CAST(N'2023-06-16' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (320, 2, 0, 13, 0, CAST(N'2023-06-16' AS Date), NULL, CAST(N'2023-06-16' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (321, 2, 0, 14, 0, CAST(N'2023-06-16' AS Date), NULL, CAST(N'2023-06-16' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (322, 2, 0, 15, 0, CAST(N'2023-06-16' AS Date), NULL, CAST(N'2023-06-16' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (323, 2, 0, 16, 0, CAST(N'2023-06-16' AS Date), NULL, CAST(N'2023-06-16' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (324, 2, 0, 17, 0, CAST(N'2023-06-16' AS Date), NULL, CAST(N'2023-06-16' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (325, 2, 0, 18, 1, CAST(N'2023-06-16' AS Date), NULL, CAST(N'2023-06-16' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (326, 3, 0, 1, 1, CAST(N'2023-06-21' AS Date), NULL, CAST(N'2023-06-21' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (327, 3, 0, 2, 1, CAST(N'2023-06-21' AS Date), NULL, CAST(N'2023-06-21' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (328, 3, 0, 3, 1, CAST(N'2023-06-21' AS Date), NULL, CAST(N'2023-06-21' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (329, 3, 0, 4, 1, CAST(N'2023-06-21' AS Date), NULL, CAST(N'2023-06-21' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (330, 3, 0, 5, 1, CAST(N'2023-06-21' AS Date), NULL, CAST(N'2023-06-21' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (331, 3, 0, 6, 1, CAST(N'2023-06-21' AS Date), NULL, CAST(N'2023-06-21' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (332, 3, 0, 7, 1, CAST(N'2023-06-21' AS Date), NULL, CAST(N'2023-06-21' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (333, 3, 0, 8, 1, CAST(N'2023-06-21' AS Date), NULL, CAST(N'2023-06-21' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (334, 3, 0, 9, 0, CAST(N'2023-06-21' AS Date), NULL, CAST(N'2023-06-21' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (335, 3, 0, 10, 1, CAST(N'2023-06-21' AS Date), NULL, CAST(N'2023-06-21' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (336, 3, 0, 11, 1, CAST(N'2023-06-21' AS Date), NULL, CAST(N'2023-06-21' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (337, 3, 0, 12, 1, CAST(N'2023-06-21' AS Date), NULL, CAST(N'2023-06-21' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (338, 3, 0, 13, 1, CAST(N'2023-06-21' AS Date), NULL, CAST(N'2023-06-21' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (339, 3, 0, 14, 1, CAST(N'2023-06-21' AS Date), NULL, CAST(N'2023-06-21' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (340, 3, 0, 15, 1, CAST(N'2023-06-21' AS Date), NULL, CAST(N'2023-06-21' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (341, 3, 0, 16, 1, CAST(N'2023-06-21' AS Date), NULL, CAST(N'2023-06-21' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (342, 3, 0, 17, 1, CAST(N'2023-06-21' AS Date), NULL, CAST(N'2023-06-21' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_Permission] ([PermissionId], [RollID], [UserId], [SubMenuID], [IsChecked], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (343, 3, 0, 18, 0, CAST(N'2023-06-21' AS Date), NULL, CAST(N'2023-06-21' AS Date), NULL, 0)
SET IDENTITY_INSERT [dbo].[Tbl_Auth_Permission] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Auth_SubMenu] ON 

INSERT [dbo].[Tbl_Auth_SubMenu] ([SubMenuID], [SubMenuName], [SubMenuURL], [MenuID], [SlNo], [SubMenuDescription], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (1, N'CommonMaster', N'/OHSB/Add', 2, 1, N'Adding Department,Designation and Roll ', CAST(N'2023-04-18' AS Date), 0, CAST(N'2023-04-19' AS Date), 0, 0)
INSERT [dbo].[Tbl_Auth_SubMenu] ([SubMenuID], [SubMenuName], [SubMenuURL], [MenuID], [SlNo], [SubMenuDescription], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (2, N'UserRegistration', N'/Employee/AddUser', 2, 2, N'UserRegistration', CAST(N'2023-04-18' AS Date), 0, CAST(N'2023-04-19' AS Date), 0, 0)
INSERT [dbo].[Tbl_Auth_SubMenu] ([SubMenuID], [SubMenuName], [SubMenuURL], [MenuID], [SlNo], [SubMenuDescription], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (3, N'SlotMapping', N'/SlotMapping/AddSlotMapping', 3, 1, N'Adding SlotMapping', CAST(N'2023-04-18' AS Date), 0, CAST(N'2023-04-19' AS Date), 0, 0)
INSERT [dbo].[Tbl_Auth_SubMenu] ([SubMenuID], [SubMenuName], [SubMenuURL], [MenuID], [SlNo], [SubMenuDescription], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (4, N'MenuMaster', N'/MenuMaster/AddMenu', 1, 1, N'Adding Menu ', CAST(N'2023-04-19' AS Date), 0, CAST(N'2023-04-19' AS Date), 0, 0)
INSERT [dbo].[Tbl_Auth_SubMenu] ([SubMenuID], [SubMenuName], [SubMenuURL], [MenuID], [SlNo], [SubMenuDescription], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (5, N'SubMenu', N'/SubMenu/AddSubMenu', 1, 2, N'adding SubMenu Details', CAST(N'2023-04-19' AS Date), 0, CAST(N'2023-04-19' AS Date), 0, 0)
INSERT [dbo].[Tbl_Auth_SubMenu] ([SubMenuID], [SubMenuName], [SubMenuURL], [MenuID], [SlNo], [SubMenuDescription], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (6, N'Permission', N'/Permission/AddPermission', 1, 3, N'Giving access to users', CAST(N'2023-04-19' AS Date), 0, CAST(N'2023-04-19' AS Date), 0, 0)
INSERT [dbo].[Tbl_Auth_SubMenu] ([SubMenuID], [SubMenuName], [SubMenuURL], [MenuID], [SlNo], [SubMenuDescription], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (7, N'AuditoriumMaster', N'/AuditoriumMaster/AddAuditorium', 2, 3, N'Adding Auditorium', CAST(N'2023-04-19' AS Date), 0, CAST(N'2023-04-19' AS Date), 0, 0)
INSERT [dbo].[Tbl_Auth_SubMenu] ([SubMenuID], [SubMenuName], [SubMenuURL], [MenuID], [SlNo], [SubMenuDescription], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (8, N'RowMaster', N'/RowMaster/AddRow', 2, 4, N'adding Row and seat ', CAST(N'2023-04-19' AS Date), 0, CAST(N'2023-04-19' AS Date), 0, 0)
INSERT [dbo].[Tbl_Auth_SubMenu] ([SubMenuID], [SubMenuName], [SubMenuURL], [MenuID], [SlNo], [SubMenuDescription], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (9, N'ShowMaster', N'/ShowMaster/AddShow', 2, 5, N'Adding Shows', CAST(N'2023-04-19' AS Date), 0, CAST(N'2023-04-19' AS Date), 0, 0)
INSERT [dbo].[Tbl_Auth_SubMenu] ([SubMenuID], [SubMenuName], [SubMenuURL], [MenuID], [SlNo], [SubMenuDescription], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (10, N'AuditoriumCapacity', N'/AuditoriumCapacity/Add', 4, 1, N'Adding each row capacity of each auditorium', CAST(N'2023-04-19' AS Date), 0, CAST(N'2023-04-19' AS Date), 0, 0)
INSERT [dbo].[Tbl_Auth_SubMenu] ([SubMenuID], [SubMenuName], [SubMenuURL], [MenuID], [SlNo], [SubMenuDescription], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (11, N'SlotMaster', N'/SlotMaster/AddSlot', 5, 1, N'Managing Time and auditorium', CAST(N'2023-04-19' AS Date), 0, CAST(N'2023-04-19' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_SubMenu] ([SubMenuID], [SubMenuName], [SubMenuURL], [MenuID], [SlNo], [SubMenuDescription], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (12, N'AddSeatInfo', N'/SeatMaster/AddSeatInfo', 7, 1, N'Adding Seat Information', CAST(N'2023-04-21' AS Date), 0, CAST(N'2023-04-21' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_SubMenu] ([SubMenuID], [SubMenuName], [SubMenuURL], [MenuID], [SlNo], [SubMenuDescription], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (13, N'AddBlock', N'/BlockMaster/AddBlock', 8, 1, N'Adding Bocks in Auditorium', CAST(N'2023-04-25' AS Date), 0, CAST(N'2023-04-25' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_SubMenu] ([SubMenuID], [SubMenuName], [SubMenuURL], [MenuID], [SlNo], [SubMenuDescription], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (14, N'BlockRowMapping', N'/BlockRowMapping/AddBlockMap', 9, 1, N'Adding rows according to block and Auditorium', CAST(N'2023-04-26' AS Date), 0, CAST(N'2023-04-26' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_SubMenu] ([SubMenuID], [SubMenuName], [SubMenuURL], [MenuID], [SlNo], [SubMenuDescription], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (15, N'Show_Master', N'/Show_Master/AddShows', 2, 6, N'Adding Show', CAST(N'2023-05-08' AS Date), 0, CAST(N'2023-05-08' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_SubMenu] ([SubMenuID], [SubMenuName], [SubMenuURL], [MenuID], [SlNo], [SubMenuDescription], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (16, N'AddScreenMapp', N'/ScreenMap/AddScreenMapp', 10, 1, N'adding screen and show to auditorium', CAST(N'2023-05-09' AS Date), 0, CAST(N'2023-05-09' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_SubMenu] ([SubMenuID], [SubMenuName], [SubMenuURL], [MenuID], [SlNo], [SubMenuDescription], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (17, N'PriceMaster', N'/PriceMaster/AddPrice', 2, 7, N'Adding Price for seats in row wise', CAST(N'2023-05-12' AS Date), 0, CAST(N'2023-05-12' AS Date), NULL, 0)
INSERT [dbo].[Tbl_Auth_SubMenu] ([SubMenuID], [SubMenuName], [SubMenuURL], [MenuID], [SlNo], [SubMenuDescription], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag]) VALUES (18, N'Ticket Booking', N'/Booking/ViewBooking', 11, 1, N'Ticket Booking', CAST(N'2023-06-14' AS Date), 0, CAST(N'2023-06-14' AS Date), NULL, 0)
SET IDENTITY_INSERT [dbo].[Tbl_Auth_SubMenu] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Bk_ScreenMap] ON 

INSERT [dbo].[Tbl_Bk_ScreenMap] ([ScreenMapId], [AuditoriumID], [id], [ShowId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag], [ShowTimeFrom], [ShowTimeTo], [ShowType]) VALUES (3, 2, 0, 1, CAST(N'2023-06-16' AS Date), NULL, CAST(N'2023-06-16' AS Date), NULL, 0, N'09:00', N'12:30', N'Morning')
INSERT [dbo].[Tbl_Bk_ScreenMap] ([ScreenMapId], [AuditoriumID], [id], [ShowId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag], [ShowTimeFrom], [ShowTimeTo], [ShowType]) VALUES (4, 1, 0, 2, CAST(N'2023-06-21' AS Date), NULL, CAST(N'2023-06-21' AS Date), NULL, 0, N'13:30', N'16:00', N'Noon')
INSERT [dbo].[Tbl_Bk_ScreenMap] ([ScreenMapId], [AuditoriumID], [id], [ShowId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag], [ShowTimeFrom], [ShowTimeTo], [ShowType]) VALUES (5, 2, 0, 3, CAST(N'2023-06-21' AS Date), NULL, CAST(N'2023-06-21' AS Date), NULL, 0, N'19:00', N'22:00', N'Evening')
INSERT [dbo].[Tbl_Bk_ScreenMap] ([ScreenMapId], [AuditoriumID], [id], [ShowId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag], [ShowTimeFrom], [ShowTimeTo], [ShowType]) VALUES (6, 1, 0, 7, CAST(N'2023-06-21' AS Date), NULL, CAST(N'2023-06-21' AS Date), NULL, 0, N'06:00', N'10:00', N'Morning')
INSERT [dbo].[Tbl_Bk_ScreenMap] ([ScreenMapId], [AuditoriumID], [id], [ShowId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag], [ShowTimeFrom], [ShowTimeTo], [ShowType]) VALUES (7, 1, 0, 8, CAST(N'2023-06-21' AS Date), NULL, CAST(N'2023-06-21' AS Date), NULL, 0, N'12:00', N'04:00', N'Noon')
INSERT [dbo].[Tbl_Bk_ScreenMap] ([ScreenMapId], [AuditoriumID], [id], [ShowId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag], [ShowTimeFrom], [ShowTimeTo], [ShowType]) VALUES (9, 1, 0, 1, CAST(N'2023-06-22' AS Date), NULL, CAST(N'2023-06-22' AS Date), NULL, 0, N'09:00', N'12:30', N'Morning')
INSERT [dbo].[Tbl_Bk_ScreenMap] ([ScreenMapId], [AuditoriumID], [id], [ShowId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag], [ShowTimeFrom], [ShowTimeTo], [ShowType]) VALUES (10, 1, 0, 9, CAST(N'2023-06-22' AS Date), NULL, CAST(N'2023-06-22' AS Date), NULL, 0, N'09:00', N'12:00', N'Morning')
INSERT [dbo].[Tbl_Bk_ScreenMap] ([ScreenMapId], [AuditoriumID], [id], [ShowId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag], [ShowTimeFrom], [ShowTimeTo], [ShowType]) VALUES (11, 1, 0, 10, CAST(N'2023-06-22' AS Date), NULL, CAST(N'2023-06-22' AS Date), NULL, 0, N'12:00', N'03:00', N'Noon')
INSERT [dbo].[Tbl_Bk_ScreenMap] ([ScreenMapId], [AuditoriumID], [id], [ShowId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag], [ShowTimeFrom], [ShowTimeTo], [ShowType]) VALUES (12, 2, 0, 11, CAST(N'2023-06-22' AS Date), NULL, CAST(N'2023-06-22' AS Date), NULL, 0, N'18:00', N'22:00', N'Evening')
INSERT [dbo].[Tbl_Bk_ScreenMap] ([ScreenMapId], [AuditoriumID], [id], [ShowId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag], [ShowTimeFrom], [ShowTimeTo], [ShowType]) VALUES (13, 3, 0, 13, CAST(N'2023-06-22' AS Date), NULL, CAST(N'2023-06-22' AS Date), NULL, 0, N'12:00', N'03:00', N'Noon')
INSERT [dbo].[Tbl_Bk_ScreenMap] ([ScreenMapId], [AuditoriumID], [id], [ShowId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag], [ShowTimeFrom], [ShowTimeTo], [ShowType]) VALUES (14, 2, 0, 12, CAST(N'2023-06-22' AS Date), NULL, CAST(N'2023-06-22' AS Date), NULL, 0, N'18:00', N'21:00', N'Evening')
INSERT [dbo].[Tbl_Bk_ScreenMap] ([ScreenMapId], [AuditoriumID], [id], [ShowId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag], [ShowTimeFrom], [ShowTimeTo], [ShowType]) VALUES (15, 1, 0, 12, CAST(N'2023-06-22' AS Date), NULL, CAST(N'2023-06-22' AS Date), NULL, 0, N'18:00', N'21:00', N'Evening')
INSERT [dbo].[Tbl_Bk_ScreenMap] ([ScreenMapId], [AuditoriumID], [id], [ShowId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag], [ShowTimeFrom], [ShowTimeTo], [ShowType]) VALUES (16, 6, 0, 9, CAST(N'2023-06-23' AS Date), NULL, CAST(N'2023-06-23' AS Date), NULL, 0, N'09:00', N'12:00', N'Morning')
INSERT [dbo].[Tbl_Bk_ScreenMap] ([ScreenMapId], [AuditoriumID], [id], [ShowId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag], [ShowTimeFrom], [ShowTimeTo], [ShowType]) VALUES (17, 7, 0, 10, CAST(N'2023-06-23' AS Date), NULL, CAST(N'2023-06-23' AS Date), NULL, 0, N'12:00', N'03:00', N'Noon')
INSERT [dbo].[Tbl_Bk_ScreenMap] ([ScreenMapId], [AuditoriumID], [id], [ShowId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag], [ShowTimeFrom], [ShowTimeTo], [ShowType]) VALUES (18, 8, 0, 11, CAST(N'2023-06-23' AS Date), NULL, CAST(N'2023-06-23' AS Date), NULL, 0, N'18:00', N'22:00', N'Evening')
INSERT [dbo].[Tbl_Bk_ScreenMap] ([ScreenMapId], [AuditoriumID], [id], [ShowId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag], [ShowTimeFrom], [ShowTimeTo], [ShowType]) VALUES (19, 6, 0, 12, CAST(N'2023-06-23' AS Date), NULL, CAST(N'2023-06-23' AS Date), NULL, 0, N'18:00', N'21:00', N'Evening')
INSERT [dbo].[Tbl_Bk_ScreenMap] ([ScreenMapId], [AuditoriumID], [id], [ShowId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag], [ShowTimeFrom], [ShowTimeTo], [ShowType]) VALUES (20, 7, 0, 13, CAST(N'2023-06-23' AS Date), NULL, CAST(N'2023-06-23' AS Date), NULL, 0, N'12:00', N'03:00', N'Noon')
INSERT [dbo].[Tbl_Bk_ScreenMap] ([ScreenMapId], [AuditoriumID], [id], [ShowId], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [DeletedFlag], [ShowTimeFrom], [ShowTimeTo], [ShowType]) VALUES (21, 8, 0, 9, CAST(N'2023-06-23' AS Date), NULL, CAST(N'2023-06-23' AS Date), NULL, 0, N'09:00', N'12:00', N'Morning')
SET IDENTITY_INSERT [dbo].[Tbl_Bk_ScreenMap] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Bk_ShowMaster] ON 

INSERT [dbo].[Tbl_Bk_ShowMaster] ([ShowId], [ShowName], [ShowType], [ShowTimeFrom], [ShowTimeTo], [ShowDate], [Photo], [id], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (1, N'Play1', NULL, N'09:00', N'12:30', CAST(N'2023-05-09' AS Date), N'prodimage/568987.jfif', 1, NULL, CAST(N'2023-05-09' AS Date), NULL, CAST(N'2023-05-09' AS Date), 1)
INSERT [dbo].[Tbl_Bk_ShowMaster] ([ShowId], [ShowName], [ShowType], [ShowTimeFrom], [ShowTimeTo], [ShowDate], [Photo], [id], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (2, N'Play2', NULL, N'13:30', N'16:00', CAST(N'2023-05-17' AS Date), N'prodimage/chiikkk.jfif', 2, NULL, CAST(N'2023-05-09' AS Date), NULL, CAST(N'2023-05-09' AS Date), 1)
INSERT [dbo].[Tbl_Bk_ShowMaster] ([ShowId], [ShowName], [ShowType], [ShowTimeFrom], [ShowTimeTo], [ShowDate], [Photo], [id], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (3, N'Play3', NULL, N'19:00', N'22:00', CAST(N'2023-05-11' AS Date), N'prodimage/imag 2.jpg', 3, NULL, CAST(N'2023-05-09' AS Date), NULL, CAST(N'2023-05-09' AS Date), 1)
INSERT [dbo].[Tbl_Bk_ShowMaster] ([ShowId], [ShowName], [ShowType], [ShowTimeFrom], [ShowTimeTo], [ShowDate], [Photo], [id], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (7, N'Play4', NULL, N'06:00', N'10:00', CAST(N'2023-05-17' AS Date), N'prodimage/png1.png', 1, NULL, CAST(N'2023-05-10' AS Date), NULL, CAST(N'2023-05-10' AS Date), 1)
INSERT [dbo].[Tbl_Bk_ShowMaster] ([ShowId], [ShowName], [ShowType], [ShowTimeFrom], [ShowTimeTo], [ShowDate], [Photo], [id], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (8, N'play5', NULL, N'12:00', N'04:00', CAST(N'2023-05-18' AS Date), N'prodimage/prod2.jpg', 2, NULL, CAST(N'2023-05-10' AS Date), NULL, CAST(N'2023-05-10' AS Date), 1)
INSERT [dbo].[Tbl_Bk_ShowMaster] ([ShowId], [ShowName], [ShowType], [ShowTimeFrom], [ShowTimeTo], [ShowDate], [Photo], [id], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (9, N'ADIPURUS', NULL, N'09:00', N'12:00', CAST(N'2023-06-13' AS Date), N'prodimage/Adipurus.jfif', 1, NULL, CAST(N'2023-06-22' AS Date), NULL, CAST(N'2023-06-22' AS Date), 0)
INSERT [dbo].[Tbl_Bk_ShowMaster] ([ShowId], [ShowName], [ShowType], [ShowTimeFrom], [ShowTimeTo], [ShowDate], [Photo], [id], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (10, N'Love London', NULL, N'12:00', N'03:00', CAST(N'2023-06-30' AS Date), N'prodimage/Lovelondon.jfif', 2, NULL, CAST(N'2023-06-22' AS Date), NULL, CAST(N'2023-06-22' AS Date), 0)
INSERT [dbo].[Tbl_Bk_ShowMaster] ([ShowId], [ShowName], [ShowType], [ShowTimeFrom], [ShowTimeTo], [ShowDate], [Photo], [id], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (11, N'The Flush', NULL, N'18:00', N'22:00', CAST(N'2023-06-30' AS Date), N'prodimage/The Flush.jfif', 3, NULL, CAST(N'2023-06-22' AS Date), NULL, CAST(N'2023-06-22' AS Date), 0)
INSERT [dbo].[Tbl_Bk_ShowMaster] ([ShowId], [ShowName], [ShowType], [ShowTimeFrom], [ShowTimeTo], [ShowDate], [Photo], [id], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (12, N'Spider Man', NULL, N'18:00', N'21:00', CAST(N'2023-06-29' AS Date), N'prodimage/spiderman.jfif', 3, NULL, CAST(N'2023-06-22' AS Date), NULL, CAST(N'2023-06-22' AS Date), 0)
INSERT [dbo].[Tbl_Bk_ShowMaster] ([ShowId], [ShowName], [ShowType], [ShowTimeFrom], [ShowTimeTo], [ShowDate], [Photo], [id], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (13, N'Zara Hatke Zara Bachke', NULL, N'12:00', N'03:00', CAST(N'2023-07-04' AS Date), N'prodimage/zara Hatke zara bachke.jpg', 2, NULL, CAST(N'2023-06-22' AS Date), NULL, CAST(N'2023-06-22' AS Date), 0)
INSERT [dbo].[Tbl_Bk_ShowMaster] ([ShowId], [ShowName], [ShowType], [ShowTimeFrom], [ShowTimeTo], [ShowDate], [Photo], [id], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [DeletedFlag]) VALUES (14, N'AD', NULL, N'13:48', N'17:48', CAST(N'2023-08-15' AS Date), N'prodimage/Adipurus (1).jpg', 1, NULL, CAST(N'2023-08-10' AS Date), NULL, CAST(N'2023-08-10' AS Date), 0)
SET IDENTITY_INSERT [dbo].[Tbl_Bk_ShowMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Bkg_SeatNOs] ON 

INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (1, 1, 1, 0, 1, 1)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (2, 1, 2, 0, 1, 1)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (3, 1, 3, 0, 1, 1)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (4, 2, 1, 0, 2, 1)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (5, 2, 2, 0, 2, 1)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (6, 2, 3, 0, 2, 1)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (7, 2, 4, 0, 2, 1)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (8, 2, 5, 0, 2, 1)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (9, 3, 1, 0, 1, 2)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (10, 3, 2, 0, 1, 2)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (11, 3, 3, 0, 1, 2)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (12, 3, 4, 0, 1, 2)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (13, 3, 5, 0, 1, 2)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (14, 3, 6, 0, 1, 2)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (15, 3, 7, 0, 1, 2)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (16, 3, 8, 0, 1, 2)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (17, 3, 9, 0, 1, 2)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (18, 3, 10, 0, 1, 2)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (19, 4, 1, 0, 1, 3)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (20, 4, 2, 0, 1, 3)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (21, 4, 3, 0, 1, 3)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (22, 4, 4, 0, 1, 3)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (23, 4, 5, 0, 1, 3)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (24, 4, 6, 0, 1, 3)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (25, 4, 7, 0, 1, 3)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (26, 4, 8, 0, 1, 3)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (27, 4, 9, 0, 1, 3)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (28, 4, 10, 0, 1, 3)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (29, 4, 11, 0, 1, 3)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (30, 5, 1, 0, 1, 4)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (31, 5, 2, 0, 1, 4)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (32, 5, 3, 0, 1, 4)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (33, 7, 1, 0, 2, 2)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (34, 7, 2, 0, 2, 2)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (35, 7, 3, 0, 2, 2)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (36, 7, 4, 0, 2, 2)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (37, 7, 5, 0, 2, 2)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (38, 7, 6, 0, 2, 2)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (39, 8, 1, 0, 1, 5)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (40, 8, 2, 0, 1, 5)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (41, 8, 3, 0, 1, 5)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (42, 8, 4, 0, 1, 5)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (43, 8, 5, 0, 1, 5)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (44, 8, 6, 0, 1, 5)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (45, 8, 7, 0, 1, 5)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (46, 8, 8, 0, 1, 5)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (47, 8, 9, 0, 1, 5)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (48, 8, 10, 0, 1, 5)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (49, 9, 1, 0, 2, 3)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (50, 9, 2, 0, 2, 3)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (51, 9, 3, 0, 2, 3)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (52, 9, 4, 0, 2, 3)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (53, 9, 5, 0, 2, 3)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (54, 9, 6, 0, 2, 3)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (55, 9, 7, 0, 2, 3)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (56, 9, 8, 0, 2, 3)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (57, 10, 1, 0, 3, 1)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (58, 10, 2, 0, 3, 1)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (59, 10, 3, 0, 3, 1)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (60, 10, 4, 0, 3, 1)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (61, 10, 5, 0, 3, 1)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (62, 11, 1, 0, 3, 2)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (63, 11, 2, 0, 3, 2)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (64, 11, 3, 0, 3, 2)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (65, 11, 4, 0, 3, 2)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (66, 11, 5, 0, 3, 2)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (67, 11, 6, 0, 3, 2)
INSERT [dbo].[Tbl_Bkg_SeatNOs] ([SeatNoId], [SeatId], [SeatNos], [DeletedFlag], [AuditoriumID], [Row_No]) VALUES (68, 11, 7, 0, 3, 2)
SET IDENTITY_INSERT [dbo].[Tbl_Bkg_SeatNOs] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_M_Auditorium] ON 

INSERT [dbo].[Tbl_M_Auditorium] ([AuditoriumID], [AuditoriumName], [DeletedFlag]) VALUES (6, N'MSD Adutorium', 0)
INSERT [dbo].[Tbl_M_Auditorium] ([AuditoriumID], [AuditoriumName], [DeletedFlag]) VALUES (7, N'Sachin Adutorium', 0)
INSERT [dbo].[Tbl_M_Auditorium] ([AuditoriumID], [AuditoriumName], [DeletedFlag]) VALUES (8, N'Kholi Adutorium', 0)
SET IDENTITY_INSERT [dbo].[Tbl_M_Auditorium] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Seatmaster] ON 

INSERT [dbo].[Tbl_Seatmaster] ([SeatId], [AuditoriumID], [Row_No], [SeatCapacity], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [IsChecked]) VALUES (1, 1, 1, 3, 0, NULL, CAST(N'2023-04-25' AS Date), NULL, CAST(N'2023-04-25' AS Date), 1)
INSERT [dbo].[Tbl_Seatmaster] ([SeatId], [AuditoriumID], [Row_No], [SeatCapacity], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [IsChecked]) VALUES (2, 2, 1, 5, 0, NULL, CAST(N'2023-04-25' AS Date), NULL, CAST(N'2023-04-25' AS Date), 1)
INSERT [dbo].[Tbl_Seatmaster] ([SeatId], [AuditoriumID], [Row_No], [SeatCapacity], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [IsChecked]) VALUES (3, 1, 2, 10, 0, NULL, CAST(N'2023-04-25' AS Date), NULL, CAST(N'2023-04-25' AS Date), 1)
INSERT [dbo].[Tbl_Seatmaster] ([SeatId], [AuditoriumID], [Row_No], [SeatCapacity], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [IsChecked]) VALUES (4, 1, 3, 11, 0, NULL, CAST(N'2023-04-25' AS Date), NULL, CAST(N'2023-04-25' AS Date), 1)
INSERT [dbo].[Tbl_Seatmaster] ([SeatId], [AuditoriumID], [Row_No], [SeatCapacity], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [IsChecked]) VALUES (5, 1, 4, 3, 0, NULL, CAST(N'2023-04-28' AS Date), NULL, CAST(N'2023-04-28' AS Date), 1)
INSERT [dbo].[Tbl_Seatmaster] ([SeatId], [AuditoriumID], [Row_No], [SeatCapacity], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [IsChecked]) VALUES (6, NULL, NULL, NULL, 0, NULL, CAST(N'2023-04-28' AS Date), NULL, CAST(N'2023-04-28' AS Date), 1)
INSERT [dbo].[Tbl_Seatmaster] ([SeatId], [AuditoriumID], [Row_No], [SeatCapacity], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [IsChecked]) VALUES (7, 2, 2, 6, 0, NULL, CAST(N'2023-05-02' AS Date), NULL, CAST(N'2023-05-02' AS Date), 0)
INSERT [dbo].[Tbl_Seatmaster] ([SeatId], [AuditoriumID], [Row_No], [SeatCapacity], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [IsChecked]) VALUES (8, 1, 5, 10, 0, NULL, CAST(N'2023-05-02' AS Date), NULL, CAST(N'2023-05-02' AS Date), 0)
INSERT [dbo].[Tbl_Seatmaster] ([SeatId], [AuditoriumID], [Row_No], [SeatCapacity], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [IsChecked]) VALUES (9, 2, 3, 8, 0, NULL, CAST(N'2023-05-02' AS Date), NULL, CAST(N'2023-05-02' AS Date), 0)
INSERT [dbo].[Tbl_Seatmaster] ([SeatId], [AuditoriumID], [Row_No], [SeatCapacity], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [IsChecked]) VALUES (10, 3, 1, 5, 0, NULL, CAST(N'2023-05-02' AS Date), NULL, CAST(N'2023-05-02' AS Date), 0)
INSERT [dbo].[Tbl_Seatmaster] ([SeatId], [AuditoriumID], [Row_No], [SeatCapacity], [DeletedFlag], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [IsChecked]) VALUES (11, 3, 2, 7, 0, NULL, CAST(N'2023-05-02' AS Date), NULL, CAST(N'2023-05-02' AS Date), 0)
SET IDENTITY_INSERT [dbo].[Tbl_Seatmaster] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_ShowType] ON 

INSERT [dbo].[Tbl_ShowType] ([id], [ShowType]) VALUES (1, N'Morning')
INSERT [dbo].[Tbl_ShowType] ([id], [ShowType]) VALUES (2, N'Noon')
INSERT [dbo].[Tbl_ShowType] ([id], [ShowType]) VALUES (3, N'Evening')
SET IDENTITY_INSERT [dbo].[Tbl_ShowType] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_T_AudiSeat] ON 

INSERT [dbo].[Tbl_T_AudiSeat] ([AuditseatID], [Row_No], [Number], [AuditoriumID], [DeletedFlag]) VALUES (1, 1, N'10', 1, 0)
INSERT [dbo].[Tbl_T_AudiSeat] ([AuditseatID], [Row_No], [Number], [AuditoriumID], [DeletedFlag]) VALUES (2, 2, N'2', 3, 0)
SET IDENTITY_INSERT [dbo].[Tbl_T_AudiSeat] OFF
GO
INSERT [dbo].[UserLogin_Tbl] ([UserId], [Password], [UserName], [UserType]) VALUES (N'rikan', N'862000', N'Abhishek Satapathy', N'Admin')
INSERT [dbo].[UserLogin_Tbl] ([UserId], [Password], [UserName], [UserType]) VALUES (N'mitra', N'123456', N'Mitrabasu Behera', N'User')
INSERT [dbo].[UserLogin_Tbl] ([UserId], [Password], [UserName], [UserType]) VALUES (N'rishi', N'456789', N'Rishikesh Jena', N'User')
GO
ALTER TABLE [dbo].[M_DepartmentMaster] ADD  CONSTRAINT [DF_M_PL_DepartmentMaster_CreatedOn]  DEFAULT (getdate()) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[M_DepartmentMaster] ADD  CONSTRAINT [DF_M_PL_DepartmentMaster_DeletedFlag]  DEFAULT ((0)) FOR [DeletedFlag]
GO
ALTER TABLE [dbo].[M_DesignationMaster] ADD  CONSTRAINT [DF_M_PL_DesignationMaster_CreatedOn]  DEFAULT (getdate()) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[M_DesignationMaster] ADD  CONSTRAINT [DF_M_PL_DesignationMaster_DeletedFlag]  DEFAULT ((0)) FOR [DeletedFlag]
GO
ALTER TABLE [dbo].[M_Roll_Tbl] ADD  CONSTRAINT [DF_M_Roll_Tbl_CreatedOn]  DEFAULT (getdate()) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[M_Roll_Tbl] ADD  CONSTRAINT [DF_M_Roll_Tbl_UpdatedOn]  DEFAULT (getdate()) FOR [UpdatedOn]
GO
ALTER TABLE [dbo].[M_Roll_Tbl] ADD  CONSTRAINT [DF_M_Roll_Tbl_DeletedFlag]  DEFAULT ((0)) FOR [DeletedFlag]
GO
ALTER TABLE [dbo].[M_RowTbl] ADD  CONSTRAINT [DF_M_RowTbl_DeletedFlag]  DEFAULT ((0)) FOR [DeletedFlag]
GO
ALTER TABLE [dbo].[M_SeatNoTbl] ADD  CONSTRAINT [DF_M_SeatNoTbl_DeletedFlag]  DEFAULT ((0)) FOR [DeletedFlag]
GO
ALTER TABLE [dbo].[M_Tbl_Block] ADD  CONSTRAINT [DF_M_Tbl_Block_DeletedFlag]  DEFAULT ((0)) FOR [DeletedFlag]
GO
ALTER TABLE [dbo].[M_Tbl_Block] ADD  CONSTRAINT [DF_M_Tbl_Block_CreatedOn]  DEFAULT (getdate()) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[M_Tbl_Block] ADD  CONSTRAINT [DF_M_Tbl_Block_UpdatedOn]  DEFAULT (getdate()) FOR [UpdatedOn]
GO
ALTER TABLE [dbo].[M_Tbl_PriceMaster] ADD  CONSTRAINT [DF_M_Tbl_PriceMaster_CreatedOn]  DEFAULT (getdate()) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[M_Tbl_PriceMaster] ADD  CONSTRAINT [DF_M_Tbl_PriceMaster_UpdatedOn]  DEFAULT (getdate()) FOR [UpdatedOn]
GO
ALTER TABLE [dbo].[M_Tbl_PriceMaster] ADD  CONSTRAINT [DF_M_Tbl_PriceMaster_DeletedFlag]  DEFAULT ((0)) FOR [DeletedFlag]
GO
ALTER TABLE [dbo].[M_Tbl_ShowsMaster] ADD  CONSTRAINT [DF_M_Tbl_ShowsMaster_CreatedOn]  DEFAULT (getdate()) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[M_Tbl_ShowsMaster] ADD  CONSTRAINT [DF_M_Tbl_ShowsMaster_UpdatedOn]  DEFAULT (getdate()) FOR [UpdatedOn]
GO
ALTER TABLE [dbo].[M_Tbl_ShowsMaster] ADD  CONSTRAINT [DF_M_Tbl_ShowsMaster_DeletedFlag]  DEFAULT ((0)) FOR [DeletedFlag]
GO
ALTER TABLE [dbo].[M_Tbl_SlotMaster] ADD  CONSTRAINT [DF_M_Tbl_SlotMaster_CreatedOn]  DEFAULT (getdate()) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[M_Tbl_SlotMaster] ADD  CONSTRAINT [DF_M_Tbl_SlotMaster_UpdatedOn]  DEFAULT (getdate()) FOR [UpdatedOn]
GO
ALTER TABLE [dbo].[M_Tbl_SlotMaster] ADD  CONSTRAINT [DF_M_Tbl_SlotMaster_DeletedFlag]  DEFAULT ((0)) FOR [DeletedFlag]
GO
ALTER TABLE [dbo].[M_USER] ADD  CONSTRAINT [DF_M_PL_USER_CreatedOn]  DEFAULT (getdate()) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[M_USER] ADD  CONSTRAINT [DF_M_PL_USER_DeletedFlag]  DEFAULT ((0)) FOR [DeletedFlag]
GO
ALTER TABLE [dbo].[T_Block_Row_Mapping] ADD  CONSTRAINT [DF_T_Block_Row_Mapping_IsChecked]  DEFAULT ((0)) FOR [IsChecked]
GO
ALTER TABLE [dbo].[T_Block_Row_Mapping] ADD  CONSTRAINT [DF_T_Block_Row_Mapping_DeletedFlag]  DEFAULT ((0)) FOR [DeletedFlag]
GO
ALTER TABLE [dbo].[T_Block_Row_Mapping] ADD  CONSTRAINT [DF_T_Block_Row_Mapping_CreatedOn]  DEFAULT (getdate()) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[T_Block_Row_Mapping] ADD  CONSTRAINT [DF_T_Block_Row_Mapping_UpdatedOn]  DEFAULT (getdate()) FOR [UpdatedOn]
GO
ALTER TABLE [dbo].[T_Tbl_SlotMapping] ADD  CONSTRAINT [DF_T_Tbl_SlotMapping_CreatedOn]  DEFAULT (getdate()) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[T_Tbl_SlotMapping] ADD  CONSTRAINT [DF_T_Tbl_SlotMapping_UpdatedOn]  DEFAULT (getdate()) FOR [UpdatedOn]
GO
ALTER TABLE [dbo].[T_Tbl_SlotMapping] ADD  CONSTRAINT [DF_T_Tbl_SlotMapping_DeletedFlag]  DEFAULT ((0)) FOR [DeletedFlag]
GO
ALTER TABLE [dbo].[Tbl_Auth_Menu] ADD  CONSTRAINT [DF_Tbl_Auth_Menu_CreatedOn]  DEFAULT (getdate()) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[Tbl_Auth_Menu] ADD  CONSTRAINT [DF_Tbl_Auth_Menu_UpdatedOn]  DEFAULT (getdate()) FOR [UpdatedOn]
GO
ALTER TABLE [dbo].[Tbl_Auth_Menu] ADD  CONSTRAINT [DF_Tbl_Auth_Menu_DeletedFlag]  DEFAULT ((0)) FOR [DeletedFlag]
GO
ALTER TABLE [dbo].[Tbl_Auth_Permission] ADD  CONSTRAINT [DF_Tbl_Auth_Permission_CreatedOn]  DEFAULT (getdate()) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[Tbl_Auth_Permission] ADD  CONSTRAINT [DF_Tbl_Auth_Permission_UpdatedOn]  DEFAULT (getdate()) FOR [UpdatedOn]
GO
ALTER TABLE [dbo].[Tbl_Auth_Permission] ADD  CONSTRAINT [DF_Tbl_Auth_Permission_DeletedFlag]  DEFAULT ((0)) FOR [DeletedFlag]
GO
ALTER TABLE [dbo].[Tbl_Auth_SubMenu] ADD  CONSTRAINT [DF_Tbl_Auth_SubMenu_CreatedOn]  DEFAULT (getdate()) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[Tbl_Auth_SubMenu] ADD  CONSTRAINT [DF_Tbl_Auth_SubMenu_UpdatedOn]  DEFAULT (getdate()) FOR [UpdatedOn]
GO
ALTER TABLE [dbo].[Tbl_Auth_SubMenu] ADD  CONSTRAINT [DF_Tbl_Auth_SubMenu_DeletedFlag]  DEFAULT ((0)) FOR [DeletedFlag]
GO
ALTER TABLE [dbo].[Tbl_Bk_ScreenMap] ADD  CONSTRAINT [DF_Tbl_Bk_ScreenMap_CreatedOn]  DEFAULT (getdate()) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[Tbl_Bk_ScreenMap] ADD  CONSTRAINT [DF_Tbl_Bk_ScreenMap_UpdatedOn]  DEFAULT (getdate()) FOR [UpdatedOn]
GO
ALTER TABLE [dbo].[Tbl_Bk_ScreenMap] ADD  CONSTRAINT [DF_Tbl_Bk_ScreenMap_DeletedFlag]  DEFAULT ((0)) FOR [DeletedFlag]
GO
ALTER TABLE [dbo].[Tbl_Bk_ShowMaster] ADD  CONSTRAINT [DF_Tbl_Bk_ShowMaster_CreatedOn]  DEFAULT (getdate()) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[Tbl_Bk_ShowMaster] ADD  CONSTRAINT [DF_Tbl_Bk_ShowMaster_UpdatedOn]  DEFAULT (getdate()) FOR [UpdatedOn]
GO
ALTER TABLE [dbo].[Tbl_Bk_ShowMaster] ADD  CONSTRAINT [DF_Tbl_Bk_ShowMaster_DeletedFlag]  DEFAULT ((0)) FOR [DeletedFlag]
GO
ALTER TABLE [dbo].[Tbl_Bkg_SeatNOs] ADD  CONSTRAINT [DF_Tbl_Bkg_SeatNOs_DeletedFlag]  DEFAULT ((0)) FOR [DeletedFlag]
GO
ALTER TABLE [dbo].[Tbl_M_Auditorium] ADD  CONSTRAINT [DF_Tbl_M_Auditorium_DeletedFlag]  DEFAULT ((0)) FOR [DeletedFlag]
GO
ALTER TABLE [dbo].[Tbl_Seatmaster] ADD  CONSTRAINT [DF_Tbl_Seatmaster_DeletedFlag]  DEFAULT ((0)) FOR [DeletedFlag]
GO
ALTER TABLE [dbo].[Tbl_Seatmaster] ADD  CONSTRAINT [DF_Tbl_Seatmaster_CreatedOn]  DEFAULT (getdate()) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[Tbl_Seatmaster] ADD  CONSTRAINT [DF_Tbl_Seatmaster_UpdatedOn]  DEFAULT (getdate()) FOR [UpdatedOn]
GO
ALTER TABLE [dbo].[Tbl_Seatmaster] ADD  CONSTRAINT [DF_Tbl_Seatmaster_IsChecked]  DEFAULT ((0)) FOR [IsChecked]
GO
ALTER TABLE [dbo].[Tbl_T_AudiSeat] ADD  CONSTRAINT [DF_Tbl_T_AudiSeat_DeletedFlag]  DEFAULT ((0)) FOR [DeletedFlag]
GO
/****** Object:  StoredProcedure [dbo].[EMP_DASHBOARD]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[EMP_DASHBOARD]
(
  @ID INT=0,
  @EmployeeCode VARCHAR(20)=NULL,
  @EmployeeName VARCHAR(50)=NULL,
  @DepartmentCode VARCHAR(10)=NULL,
  @DesignationCode VARCHAR(10)=NULL,
  @RollCode VARCHAR(10)=NULL,
  @Password VARCHAR(50)=NULL,
  @DepartmentName VARCHAR(50)=NULL,
  @DesignationName VARCHAR(50)=NULL,
  @RollName VARCHAR(50)=NULL,
  @Action VARCHAR(50)
)
AS
BEGIN
IF(@Action = 'InsertUpdateEmp')
IF(@ID=0)
 BEGIN
  INSERT INTO Employee_Tbl (EmployeeCode, EmployeeName, DepartmentCode, DesignationCode, RollCode, Password)
  VALUES (@EmployeeCode, @EmployeeName, @DepartmentCode, @DesignationCode, @RollCode, @Password)
 END
 ELSE
BEGIN
  UPDATE Employee_Tbl 
  SET 
	  EmployeeCode = @EmployeeCode,
	  EmployeeName = @EmployeeName, 
      DepartmentCode = @DepartmentCode, 
      DesignationCode = @DesignationCode, 
      RollCode = @RollCode, 
      Password = @Password
  WHERE ID = @ID
END
IF (@Action = 'DeleteEmployee')
BEGIN
  DELETE FROM Employee_Tbl 
  WHERE ID = @ID
END

 ELSE IF (@Action = 'SelectAllEmp')
  BEGIN
    SELECT e.ID,e.EmployeeCode, e.EmployeeName, d.DepartmentName, des.DesignationName, r.RollName,e.Password
    FROM Employee_Tbl e
   inner JOIN Department_Tbl d ON e.DepartmentCode = d.DepartmentCode
  inner  JOIN Designation_Tbl des ON e.DesignationCode = des.DesignationCode
   inner JOIN Roll_Tbl r ON e.RollCode = r.RollCode;
  END
  IF (@Action = 'SelectOneEmp')
BEGIN
select * from Employee_Tbl where ID= @ID; 
END
 ELSE IF (@Action = 'SaveDepartment')
    BEGIN
        INSERT INTO Department_Tbl (DepartmentCode, DepartmentName)
        VALUES (@DepartmentCode, @DepartmentName)
    END
  ELSE IF (@Action = 'Department')
  BEGIN
    SELECT DepartmentCode, DepartmentName FROM Department_Tbl
  END

  ELSE IF (@Action = 'SaveDesignation')
    BEGIN
        INSERT INTO Designation_Tbl (DesignationCode, DesignationName)
        VALUES (@DesignationCode, @DesignationName)
    END
  ELSE IF (@Action = 'Designation')
  BEGIN
    SELECT DesignationCode, DesignationName FROM Designation_Tbl
  END

  ELSE IF (@Action = 'SaveRoll')
    BEGIN
        INSERT INTO Roll_Tbl (RollCode, RollName)
        VALUES (@RollCode, @RollName)
    END
  ELSE IF (@Action = 'Roll')
  BEGIN
    SELECT RollCode, RollName FROM Roll_Tbl
  END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Booking]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_Booking](
@Id int =0,
@BookingDate Date =Null,
@UserId varchar(50)=nul,
@AuditoriumId int=0,
@BlockId int=0,
@RowId int=0,
@SeatId int=0,
@NoOfTicket int=0,
@action varchar(50),
@PMSGOUT varchar(100) output
)
as 
begin
if(@action='InsertBooking')
begin
 IF EXISTS (SELECT 1 FROM Booking_Tbl WHERE AuditoriumId=@AuditoriumId AND BookingDate=@BookingDate AND SeatId = @SeatId AND RowId = @RowId AND BlockId = @BlockId )
BEGIN
    SET @PMSGOUT = '4';
END
ELSE 
BEGIN
    INSERT INTO Booking_Tbl (BookingDate, UserId, AuditoriumId, BlockId, RowId, SeatId)
    SELECT @BookingDate, @UserId, @AuditoriumId, @BlockId, RowId, SeatId
    FROM Seat_Tbl
    WHERE RowId = @RowId AND SeatId = @SeatId
    
    SET @PMSGOUT = '1';
END


end
else if(@action='UpdateBooking')
Begin
	IF Exists (Select 1 from Booking_Tbl where BookingDate=@BookingDate and AuditoriumId=@AuditoriumId and BlockId=@BlockId and RowId=@RowId and SeatId=@SeatId and Id!=@Id )
			BEGIN
				SET @PMSGOUT='4';			
			END
  ELSE
begin
Update Booking_Tbl set BookingDate=@BookingDate,AuditoriumId=@AuditoriumId,BlockId=@BlockId,RowId=@RowId,SeatId=@SeatId
where Id=@Id
set @PMSGOUT='2';
end
end
else if(@action='SelectAll')
begin
SELECT 
    bo.Id,
	bo.BookingDate,
	U.UserName,
    a.AuditoriumName,
	b.BlockName,
	r.RowName,
    s.SeatName
FROM 
    Booking_Tbl bo
    JOIN Seat_Tbl s ON bo.SeatId = s.SeatId
    JOIN Row_Tbl r ON bo.RowId = r.RowId
	JOIN Block_Tbl b On bo.BlockId=b.BlockId
    JOIN Tbl_M_Auditorium a ON bo.AuditoriumId = a.AuditoriumId
	JOIN M_USER U ON bo.UserId=U.UserName
ORDER BY 
    bo.BookingDate ASC

	--select * from Booking_Tbl
	--select * from Seat_Tbl
--	INSERT [dbo].[UserLogin_Tbl] ([UserId], [Password], [UserName], [UserType]) VALUES (N'rikan', N'862000', N'Abhishek Satapathy', N'Admin')
--INSERT [dbo].[UserLogin_Tbl] ([UserId], [Password], [UserName], [UserType]) VALUES (N'mitra', N'123456', N'Mitrabasu Behera', N'User')
--INSERT [dbo].[UserLogin_Tbl] ([UserId], [Password], [UserName], [UserType]) VALUES (N'rishi', N'456789', N'Rishikesh Jena', N'User')

	--select * from M_USER
	--select * from Block_Tbl
	--select * from Auditorium_TBL
	--select * from UserLogin_Tbl
set  @PMSGOUT='7';
end
else if(@action='Ticket')
begin
       declare @NoOfTickett int=4
		SELECT 
			bo.Id,
			bo.BookingDate,
			U.UserName,
			a.AuditoriumName,
			b.BlockName,
			r.RowName,
			s.SeatName
		FROM 
			Booking_Tbl bo
			JOIN Seat_Tbl s ON bo.SeatId = s.SeatId
			JOIN Row_Tbl r ON bo.RowId = r.RowId
			JOIN Block_Tbl b On bo.BlockId=b.BlockId
			JOIN Tbl_M_Auditorium a ON bo.AuditoriumId = a.AuditoriumId
			JOIN M_USER U ON bo.UserId=U.UserName
       where bo.UserId=@UserId and bo.BookingDate=@BookingDate
		ORDER BY 
			bo.id desc
end
else if(@action='SelectOne')
SELECT 
    bo.Id,a.AuditoriumId,b.BlockId,r.RowId,s.SeatId,
	bo.BookingDate,
    a.AuditoriumName,
	b.BlockName,
	r.RowName,
    s.SeatName
FROM 
    Booking_Tbl bo
    JOIN Seat_Tbl s ON bo.SeatId = s.SeatId
    JOIN Row_Tbl r ON bo.RowId = r.RowId
	JOIN Block_Tbl b On bo.BlockId=b.BlockId
    JOIN Auditorium_TBL a ON bo.AuditoriumId = a.AuditoriumId 
	where bo.Id=@Id
else if(@action='D')
begin
Delete Booking_Tbl where Id=@Id
set @PMSGOUT='3';
end
else if(@action='BookedSeat')
begin
SELECT 
    Id,AuditoriumId,BlockId,RowId,SeatId,
	BookingDate
FROM 
    Booking_Tbl 
WHERE AuditoriumId = @AuditoriumId and BookingDate=@BookingDate
set @PMSGOUT='8';
end
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Seat]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Seat](
    @SeatId INT = NULL,
    @SeatName VARCHAR(50) = NULL,
    @AuditoriumId INT = NULL,
    @AuditoriumName VARCHAR(50) = NULL,
@BlockId INT =NULL,
    @RowId INT = NULL,
    @RowName CHAR(1) = NULL,
    @action VARCHAR(50),
    @PMSGOUT VARCHAR(100) OUTPUT
)
AS 
BEGIN
    IF (@action = 'InsertSeat')
    BEGIN
        IF EXISTS (SELECT 1 FROM Seat_Tbl WHERE  SeatName = @SeatName)
        BEGIN
            SET @PMSGOUT = '4';
        END
      
        ELSE
            BEGIN
                INSERT INTO Seat_Tbl (SeatName, AuditoriumId, RowId) VALUES (@SeatName, @AuditoriumId, @RowId);
                SET @PMSGOUT = '1';
            END
     END
    
    ELSE IF (@action = 'UpdateSeat')
    BEGIN
        IF EXISTS (SELECT 1 FROM Seat_Tbl  where SeatName = @SeatName AND SeatId != @SeatId)
        BEGIN
            SET @PMSGOUT = '4';
        END
        ELSE
        BEGIN
            UPDATE Seat_Tbl SET SeatName = @SeatName, AuditoriumId = @AuditoriumId, RowId = @RowId WHERE SeatId = @SeatId;
            SET @PMSGOUT = '2';
        END
    END
    ELSE IF (@action = 'SelectAll')
    BEGIN
        SELECT A.AuditoriumId, R.RowId, S.SeatId, A.AuditoriumName, R.RowName, S.SeatName
        FROM Seat_Tbl S
        INNER JOIN Row_Tbl R ON S.RowId = R.RowId
        INNER JOIN Auditorium_TBL A ON A.AuditoriumId = S.AuditoriumId
        SET @PMSGOUT = '7';
    END
    ELSE IF (@action = 'SelectOne')
    BEGIN
        SELECT A.AuditoriumId, R.RowId, S.SeatId, A.AuditoriumName, R.RowName, S.SeatName
        FROM Seat_Tbl S
        INNER JOIN Row_Tbl R ON S.RowId = R.RowId
        INNER JOIN Auditorium_TBL A ON A.AuditoriumId = S.AuditoriumId
where S.SeatId=@SeatId
    END
    ELSE IF (@action = 'D')
    BEGIN
        DELETE FROM Seat_Tbl WHERE SeatId = @SeatId;
        SET @PMSGOUT = '3';
    END
ELSE IF (@action = 'SelectAllForBlock')
    BEGIN
        SELECT s.SeatId, s.SeatName, r.RowId, r.RowName, a.AuditoriumId,b.BlockId,b.BlockName
FROM Tbl_M_Auditorium a
INNER JOIN Block_Tbl b ON a.AuditoriumId = b.AuditoriumId
INNER JOIN Row_Tbl r ON b.AuditoriumId = r.AuditoriumId
INNER JOIN Seat_Tbl s ON r.RowId = s.RowId

WHERE a.AuditoriumId = @AuditoriumId
SET @PMSGOUT = '5';
    END
END

GO
/****** Object:  StoredProcedure [dbo].[Usp_AuditoriumOP]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Usp_AuditoriumOP](
@AuditoriumID int =0,
@AuditoriumName varchar (100)= NULL,
--@SeatNo int= 0,
@AuditseatID int=0,
@Row_Name varchar(50)=null,
@Row_No int=0,
@Number varchar(100)=null,
@action varchar(100),
@PMSGOUT varchar(100) output)
as 
begin
if(@action='InsertAuditorium')
begin
 IF Exists (Select 1 from Tbl_M_Auditorium where DeletedFlag=0 AND AuditoriumName=@AuditoriumName )
			BEGIN
				SET @PMSGOUT='4';			
			END
      else 
begin
insert into Tbl_M_Auditorium(AuditoriumName) values(@AuditoriumName)
set @PMSGOUT='1';
end
end
else if(@action='UpdateAuditorium')
Begin
	IF Exists (Select 1 from Tbl_M_Auditorium where DeletedFlag=0 and AuditoriumName=@AuditoriumName and AuditoriumID!=@AuditoriumID )
			BEGIN
				SET @PMSGOUT='4';			
			END
  ELSE
begin
Update Tbl_M_Auditorium set AuditoriumName=@AuditoriumName
where AuditoriumID=@AuditoriumID
set @PMSGOUT='2';
end
end
else if(@action='SelectAll')
begin
select * from Tbl_M_Auditorium where DeletedFlag=0
set  @PMSGOUT='7';
end
else if(@action='SelectOne')
select AuditoriumID,AuditoriumName from  Tbl_M_Auditorium where DeletedFlag=0  and AuditoriumID=@AuditoriumID
else if(@action='D')
begin
update Tbl_M_Auditorium set DeletedFlag=1 where AuditoriumID=@AuditoriumID
set @PMSGOUT='3';
end
--transaction
else if(@action='BindAuditorium')
begin
select  AuditoriumID,AuditoriumName from Tbl_M_Auditorium where DeletedFlag=0 
set @PMSGOUT='5';
end
else if(@action='BindRow')
begin
select  Row_No,Row_Name from M_RowTbl where DeletedFlag=0 
set @PMSGOUT='6';
end
else if(@action='InsertRowDetails')
begin
 IF Exists (Select 1 from Tbl_T_AudiSeat where DeletedFlag=0 AND Row_No=@Row_No )
			BEGIN
				SET @PMSGOUT='4';			
			END
      else 
begin
insert into Tbl_T_AudiSeat(Row_No,Number,AuditoriumID) values(@Row_No,@Number,@AuditoriumID)
set @PMSGOUT='1';
end
end
else if(@action='UpdateRowDetails')
Begin
	IF Exists (Select 1 from Tbl_T_AudiSeat where DeletedFlag=0 and Row_No=@Row_No and AuditseatID!=@AuditseatID )
			BEGIN
				SET @PMSGOUT='4';			
			END
  ELSE
begin
Update Tbl_T_AudiSeat set Row_No=@Row_No,
Number=@Number,AuditoriumID=@AuditoriumID
where AuditseatID=@AuditseatID
set @PMSGOUT='2';
end
end
else if(@action='Delete')
begin
update Tbl_T_AudiSeat set DeletedFlag=1 where  AuditseatID=@AuditseatID
set @PMSGOUT='3';
end
else if(@action='SelectAllData')
begin
select a.AuditseatID,b.Row_Name,a.Number,c.AuditoriumName from Tbl_T_AudiSeat a
inner join M_RowTbl b on b.Row_No=a.Row_No 
inner join Tbl_M_Auditorium c on c.AuditoriumID=a.AuditoriumID
and a.DeletedFlag=0 and b.DeletedFlag=0 and c.DeletedFlag=0
set  @PMSGOUT='7';
end
else if(@action='SelectOne')
select AuditoriumID,Row_No,Number  from  Tbl_T_AudiSeat where DeletedFlag=0  and AuditseatID=@AuditseatID
end
GO
/****** Object:  StoredProcedure [dbo].[Usp_Bk_ScreenMap_OP]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Usp_Bk_ScreenMap_OP](
@ScreenMapId int =0,
@ShowId int =0,
@ShowName varchar (100)= NULL,
@ShowType varchar (50)= NULL,
@ShowTimeFrom varchar (100)= NULL,
@ShowTimeTo varchar(100)=null,
@Photo varchar(100)=null,
@ShowDate date=null,
@id int=0,
@AuditoriumID int=0,
@action varchar(100),
@PMSGOUT varchar(100) output)
as 
begin
if(@action='Insert')
begin
 IF Exists (Select 1 from Tbl_Bk_ScreenMap where DeletedFlag=0 AND ShowId=@ShowId and AuditoriumID=@AuditoriumID and ShowId=@ShowId and ShowType=@ShowType  )
			BEGIN
				SET @PMSGOUT='4';			
			END
Else 
			begin
			insert into Tbl_Bk_ScreenMap(AuditoriumID,id,ShowId,ShowTimeFrom,ShowTimeTo,ShowType) 
			values(@AuditoriumID,@id,@ShowId,@ShowTimeFrom,@ShowTimeTo,@ShowType)
			set @PMSGOUT='1';
			end
end
else if(@action='UpdateShow')
Begin
	IF Exists (Select 1 from Tbl_Bk_ScreenMap where DeletedFlag=0 and AuditoriumID=@AuditoriumID and ShowId=@ShowId  and ScreenMapId!=@ScreenMapId )
			BEGIN
				SET @PMSGOUT='4';			
			END
  ELSE
begin
Update Tbl_Bk_ScreenMap set ShowId=@ShowId , AuditoriumID=@AuditoriumID,id=@id,ShowTimeFrom=@ShowTimeFrom,ShowTimeTo=@ShowTimeTo
where ScreenMapId=@ScreenMapId and DeletedFlag=0
set @PMSGOUT='2';
end
end
else if(@action='SelectAll')
begin
--select a.ScreenMapId, b.AuditoriumName,c.ShowName,convert(varchar(50),c.ShowDate,103) as ShowDate ,a.ShowTimeFrom,a.ShowTimeTo,a.ShowType  from Tbl_Bk_ScreenMap a
--inner join Tbl_M_Auditorium b on a.AuditoriumID=b.AuditoriumID
--inner join Tbl_Bk_ShowMaster c on c.ShowId=a.ShowId
--inner join Tbl_ShowType d on d.id=a.id where a.DeletedFlag=0 
select a.ScreenMapId,a.ShowTimeFrom,a.ShowTimeTo,a.ShowType,b.AuditoriumName,convert(varchar(50),c.ShowDate,103) as ShowDate,c.ShowName
from Tbl_Bk_ScreenMap a 
inner join Tbl_M_Auditorium b on b.AuditoriumID=a.AuditoriumID
inner join Tbl_Bk_ShowMaster c on c.ShowId=a.ShowId
where a.DeletedFlag=0 and b.DeletedFlag=0 and c.DeletedFlag=0
set  @PMSGOUT='8';
end
else if(@action='SelectOne')
begin
	select a.ScreenMapId,a.ShowTimeFrom,a.ShowTimeTo,a.ShowType,b.AuditoriumName,convert(varchar(50),c.ShowDate,103) as ShowDate,c.ShowName
	from Tbl_Bk_ScreenMap a 
	inner join Tbl_M_Auditorium b on b.AuditoriumID=a.AuditoriumID
	inner join Tbl_Bk_ShowMaster c on c.ShowId=a.ShowId
	where a.DeletedFlag=0 and b.DeletedFlag=0 and c.DeletedFlag=0  and ScreenMapId=@ScreenMapId 
end
else if(@action='findallFilm')
begin
		select ShowId, ShowName, ShowType, ShowTimeFrom, ShowTimeTo, ShowDate, Photo, id, CreatedBy, CreatedOn, UpdatedBy, UpdatedOn, DeletedFlag  from Tbl_Bk_ShowMaster
		where DeletedFlag=0 
end
else if(@action='GetbyShowid')
begin
		select ShowId, ShowName, ShowType, ShowTimeFrom, ShowTimeTo, ShowDate, Photo, id, CreatedBy, CreatedOn, UpdatedBy, UpdatedOn, DeletedFlag  from Tbl_Bk_ShowMaster
		where DeletedFlag=0 and ShowId=@ShowId
end
else if(@action='GetbyShowid')
begin
		select ShowId, ShowName, ShowType, ShowTimeFrom, ShowTimeTo, ShowDate, Photo, id, CreatedBy, 
		CreatedOn, UpdatedBy, UpdatedOn, DeletedFlag  from Tbl_Bk_ShowMaster
		where DeletedFlag=0 and ShowId=@ShowId
end
else if(@action='GetAuditoriumAndTimebyShowid')
begin
      declare  @shownamee varchar(30)
      select @shownamee=ShowName from Tbl_Bk_ShowMaster where ShowId=@ShowId

		select a.ScreenMapId,a.ShowTimeFrom,a.ShowTimeTo,a.ShowType,b.AuditoriumID,b.AuditoriumName,convert(varchar(50),c.ShowDate,103) as ShowDate,c.ShowName
		from Tbl_Bk_ScreenMap a 
		inner join Tbl_M_Auditorium b on b.AuditoriumID=a.AuditoriumID
		inner join Tbl_Bk_ShowMaster c on c.ShowId=a.ShowId
		where a.DeletedFlag=0 and b.DeletedFlag=0 and c.DeletedFlag=0 and ShowName=@shownamee
end
--select *
--from  Tbl_Bk_ScreenMap where DeletedFlag=0  and ScreenMapId=@ScreenMapId 
else if(@action='DeleteShow')
begin
update Tbl_Bk_ScreenMap set DeletedFlag=1 where ScreenMapId=@ScreenMapId
set @PMSGOUT='3';
end
else if(@action='BindShowType')
begin
select  id,ShowType from Tbl_ShowType 
set @PMSGOUT='5';
end
else if(@action='BindShow')
begin
select  ShowId,ShowName from Tbl_Bk_ShowMaster where DeletedFlag=0
set @PMSGOUT='6';
end
else if(@action='BindShowtime')
begin
--select ShowTimeFrom,ShowTimeTo  from Tbl_Bk_ShowMaster  where id=@id and ShowId=@ShowId
select a.ShowTimeFrom,a.ShowTimeTo ,b.ShowType from Tbl_Bk_ShowMaster a 
inner join Tbl_ShowType b on b.id=a.id where  ShowId=@ShowId and a.DeletedFlag=0
set @PMSGOUT='7';
end
end
GO
/****** Object:  StoredProcedure [dbo].[Usp_Bk_ShowMasterOP]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE procedure [dbo].[Usp_Bk_ShowMasterOP](
@ShowId int =0,
@ShowName varchar (100)= NULL,
@ShowType varchar (100)= NULL,
@ShowTimeFrom varchar (100)= NULL,
@ShowTimeTo varchar(100)=null,
@ShowDate varchar(50)=null,
@id int=0,
@Photo varchar(100)=null,
@action varchar(100),
@PMSGOUT varchar(100) output)
as 
begin
if(@action='InsertShow')
begin
 IF Exists (Select 1 from Tbl_Bk_ShowMaster where DeletedFlag=0   and id=@id and ShowId=@ShowId  )
			BEGIN
				SET @PMSGOUT='4';			
			END
      else 
begin
insert into Tbl_Bk_ShowMaster(ShowName,ShowTimeFrom,ShowTimeTo,ShowDate,id,Photo) 
values(@ShowName,@ShowTimeFrom,@ShowTimeTo,@ShowDate,@id,@Photo)
set @PMSGOUT='1';
end
end
else if(@action='UpdateShow')
Begin
	IF Exists (Select 1 from Tbl_Bk_ShowMaster where DeletedFlag=0 and ShowName=@ShowName and ShowID!=@ShowID )
			BEGIN
				SET @PMSGOUT='4';			
			END
  ELSE
begin
Update Tbl_Bk_ShowMaster set ShowName=@ShowName,ShowType=@ShowType,ShowTimeFrom=@ShowTimeFrom,ShowTimeTo=@ShowTimeTo,
ShowDate=@ShowDate,id=@id,Photo=@Photo
where ShowID=@ShowID
set @PMSGOUT='2';
end
end
else if(@action='SelectAll')
begin
select a.ShowId,b.ShowType,a.ShowName,a.ShowTimeFrom,a.ShowTimeTo,convert(varchar(50),a.ShowDate,105) as  ShowDate 
from Tbl_Bk_ShowMaster a inner join Tbl_ShowType b on a.id=b.id where a.DeletedFlag=0 
set  @PMSGOUT='8';
end
else if(@action='SelectOne')
select ShowId,ShowName,id,ShowTimeFrom,ShowTimeTo,ShowDate  from  Tbl_Bk_ShowMaster where DeletedFlag=0  and ShowId=@ShowId
else if(@action='DeleteShow')
begin
update Tbl_Bk_ShowMaster set DeletedFlag=1 where ShowId=@ShowId
set @PMSGOUT='3';
end
----transaction
--else if(@action='BindAuditorium')
--begin
--select  AuditoriumID,AuditoriumName from Tbl_M_Auditorium where DeletedFlag=0 
--set @PMSGOUT='5';
--end
else if(@action='BindShowType')
begin
select  id,ShowType from Tbl_ShowType 
set @PMSGOUT='5';
end
end
GO
/****** Object:  StoredProcedure [dbo].[USP_BKG_SeatOP]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_BKG_SeatOP]
(
@SeatId int=0,
@AuditoriumID int=0,
@Row_No int=0,
@SeatCapacity int=0,
@CreatedBy int=0 ,
@SeatNos int=0,
@action varchar(100),
@PMSGOUT varchar(100) output
)
as 
begin
	if (@action='InsertSeat')
	Begin
	    IF Exists (Select 1 from Tbl_Seatmaster where DeletedFlag=0 AND Row_No=@Row_No and AuditoriumID=@AuditoriumID)
			BEGIN
				SET @PMSGOUT='-2';			
			END
		ELSE
			BEGIN
             insert into Tbl_Seatmaster (AuditoriumID,Row_No,SeatCapacity)values(@AuditoriumID,@Row_No,@SeatCapacity)
	            set @PMSGOUT=SCOPE_IDENTITY();
			END
	
	End
    else if(@action='UpdateSeat')
	Begin
	    IF Exists (Select 1 from Tbl_Seatmaster where DeletedFlag=0 AND AuditoriumID=@AuditoriumID and Row_No=@Row_No AND SeatId !=@SeatId )
			BEGIN
				SET @PMSGOUT='-2';			
			END
		ELSE
			BEGIN
			     update  Tbl_Seatmaster set AuditoriumID=@AuditoriumID,Row_No=@Row_No,SeatCapacity=@SeatCapacity
				 where SeatId =@SeatId
	             set @PMSGOUT=@SeatId
				 
			END 
     
	 End
     else if(@action='SelectAllseatInfo')
	 Begin
     select h.SeatId,h.AuditoriumID,b.Row_No,b.RowDesc,a.AuditoriumName,h.SeatCapacity from  
	    Tbl_Seatmaster h inner join Tbl_M_Auditorium a on a.AuditoriumID=h.AuditoriumID
		inner join M_RowTbl b  on b.Row_No=h.Row_No
	 where h.DeletedFlag=0 and a.DeletedFlag=0 and b.DeletedFlag=0
	 End
	 else if(@action='SelectOneseatInfo')
	 Begin
     select SeatId,AuditoriumID,Row_No,SeatCapacity  from  Tbl_Seatmaster 
	 where  DeletedFlag=0 and SeatId=@SeatId
	 End
     else if(@action='DeleteseatInfo')
	 Begin
     update Tbl_Seatmaster set DeletedFlag=1  where SeatId=@SeatId
	 update Tbl_Bkg_SeatNOs set DeletedFlag=1 where SeatId=@SeatId
	  set @PMSGOUT='3';
	  End
	 else if(@action='InsertseatNo')
	 Begin
     insert into Tbl_Bkg_SeatNOs (SeatId,SeatNos,AuditoriumID,Row_No)values(@SeatId,@SeatNos,@AuditoriumID,@Row_No)
	  set @PMSGOUT='1';
	  End
	  else if(@action='SeatCapcity')
	 Begin
     select AuditoriumID,Row_No,SeatCapacity  from  Tbl_Seatmaster 
	 where  DeletedFlag=0 and SeatId=@SeatId
	 End
	 else if(@action='getrowbyauditoriumID')
 select a.SeatId,a.AuditoriumID,b.AuditoriumName,a.Row_No,c.RowDesc,a.SeatCapacity
from Tbl_Seatmaster a 
inner join Tbl_M_Auditorium b on a.AuditoriumID=b.AuditoriumID
inner join M_RowTbl c on a.Row_No=c.Row_Name and a.AuditoriumID=@AuditoriumID
where a.DeletedFlag=0 and b.DeletedFlag=0 and c.DeletedFlag=0
 else if(@action='getdetailsofseats')
select distinct t.Row_No,t.SeatId,b.SeatCapacity,c.AuditoriumName,d.RowDesc,
  STUFF((SELECT  ', ' + cast(t1.SeatNos as varchar(100))
         from Tbl_Bkg_SeatNOs t1
         where t.Row_No = t1.Row_No
		 and t.AuditoriumID=t1.AuditoriumID
            FOR XML PATH(''), TYPE
            ).value('.', 'NVARCHAR(MAX)') 
        ,1,2,'') SeatNo
from Tbl_Bkg_SeatNOs t
 inner join Tbl_Seatmaster b on b.SeatId=t.SeatId
 inner join Tbl_M_Auditorium c on c.AuditoriumID=t.AuditoriumID
 inner join M_RowTbl d on d.Row_No=t.Row_No
 where t.DeletedFlag=0 and b.DeletedFlag=0 and c.DeletedFlag=0 and d.DeletedFlag=0 and t.AuditoriumID=@AuditoriumID
 else if(@action='DeleteToUpdateSeatnos')
	Begin
	delete from Tbl_Bkg_SeatNOs where SeatId=@SeatId;
	set @PMSGOUT='2';
	End
	 else if(@action='countrow')
	Begin
	select count(1) from Tbl_Seatmaster where Row_No=@Row_No and AuditoriumID=@AuditoriumID and DeletedFlag=0
	set @PMSGOUT='5';
	End
	 else if(@action='AllSeat')
	Begin
   select SeatNos,SeatNoId from Tbl_Bkg_SeatNOs where AuditoriumID=@AuditoriumID and DeletedFlag=0
	set @PMSGOUT='6';
	End
end
GO
/****** Object:  StoredProcedure [dbo].[Usp_Block_OP]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Usp_Block_OP](
@AuditoriumID int =0,
@AuditoriumName varchar (100)= NULL,
@BlockId int=0,
@BlockName varchar(50)=null,
@action varchar(100),
@PMSGOUT varchar(100) output)
as 
begin
if(@action='InsertBlock')
begin
 IF Exists (Select 1 from M_Tbl_Block where DeletedFlag=0 AND BlockId=@BlockId )
			BEGIN
				SET @PMSGOUT='4';			
			END
      else 
begin
insert into M_Tbl_Block(AuditoriumID,BlockName) values(@AuditoriumID,@BlockName)
set @PMSGOUT='1';
end
end
else if(@action='UpdateBlock')
--Begin
--	IF Exists (Select 1 from M_Tbl_Block where DeletedFlag=0 and BlockName=BlockName and BlockId=@BlockId )
--			BEGIN
--				SET @PMSGOUT='4';			
--			END
--  ELSE
begin
Update M_Tbl_Block set AuditoriumID=@AuditoriumID,BlockName=@BlockName
where BlockId=@BlockId
set @PMSGOUT='2';
--end
end
else if(@action='SelectAllBlock')
begin
select b.BlockId ,b.AuditoriumID,a.AuditoriumName,b.BlockName from M_Tbl_Block b
inner join Tbl_M_Auditorium a on a.AuditoriumID=b.AuditoriumID
where a.DeletedFlag=0 and b.DeletedFlag=0
set  @PMSGOUT='7';
end
else if(@action='SelectOneBlock')
select BlockId,AuditoriumID,BlockName from  M_Tbl_Block where DeletedFlag=0  and BlockId=@BlockId
else if(@action='DeleteBlock')
begin
update M_Tbl_Block set DeletedFlag=1 where BlockId=@BlockId
set @PMSGOUT='3';
end
end
GO
/****** Object:  StoredProcedure [dbo].[USP_Department]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_Department]
(
@DepartmentId int=0,
@Department varchar (100) =NULL,
@CreatedBy int=0 ,
@action varchar(100),
@PMSGOUT varchar(100) output
)
as 
begin
	if (@action='Insert')
	Begin
	    IF Exists (Select 1 from M_DepartmentMaster where DeletedFlag=0 AND Department=@Department)
			BEGIN
				SET @PMSGOUT='4';			
			END
		ELSE
			BEGIN
                insert into M_DepartmentMaster (Department)values(@Department)
	            set @PMSGOUT='1';
			END
	
	End
    else if(@action='Update')
	Begin
	    IF Exists (Select 1 from M_DepartmentMaster where DeletedFlag=0 AND Department=@Department AND DepartmentId !=@DepartmentId )
			BEGIN
				SET @PMSGOUT='4';			
			END
		ELSE
			BEGIN
			     update  M_DepartmentMaster set Department=@Department where DepartmentId =@DepartmentId;
	             set @PMSGOUT='2';
			END 
     
	 End
     else if(@action='SelectAll')
	 Begin
     select DepartmentId,Department from  M_DepartmentMaster 
	 where  DeletedFlag=0
	 End
	 else if(@action='SelectOne')
	 Begin
     select DepartmentId,Department  from  M_DepartmentMaster 
	 where  DeletedFlag=0 and DepartmentId=@DepartmentId
	 End
     else if(@action='Delete')
	 Begin
     update M_DepartmentMaster set DeletedFlag=1  where DepartmentId=@DepartmentId
	  set @PMSGOUT='3';
	  End
end
GO
/****** Object:  StoredProcedure [dbo].[USP_Designation]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_Designation]
(
@DesignationId int=0,
@Designation varchar (100) =NULL,
@CreatedBy int=0 ,
@action varchar(100),
@PMSGOUT varchar(100) output
)
as 
begin
	if (@action='InsertDesignation')
	Begin
	    IF Exists (Select 1 from M_DesignationMaster where DeletedFlag=0 AND Designation=@Designation)
			BEGIN
				SET @PMSGOUT='4';			
			END
		ELSE
			BEGIN
                insert into M_DesignationMaster (Designation)values(@Designation)
	            set @PMSGOUT='1';
			END
	
	End
    else if(@action='UpdateDesignation')
	Begin
	    IF Exists (Select 1 from M_DesignationMaster where DeletedFlag=0 AND Designation=@Designation AND DesignationId !=@DesignationId )
			BEGIN
				SET @PMSGOUT='4';			
			END
		ELSE
			BEGIN
			     update  M_DesignationMaster set Designation=@Designation where DesignationId =@DesignationId;
	             set @PMSGOUT='2';
			END 
     
	 End
     else if(@action='SelectAllDesignation')
	 Begin
     select DesignationId,Designation from  M_DesignationMaster 
	 where  DeletedFlag=0
	 End
	 else if(@action='SelectOneDesignation')
	 Begin
     select DesignationId,Designation  from  M_DesignationMaster 
	 where  DeletedFlag=0 and DesignationId=@DesignationId
	 End
     else if(@action='DeleteDesignation')
	 Begin
     update M_DesignationMaster set DeletedFlag=1  where DesignationId=@DesignationId
	  set @PMSGOUT='3';
	  End
end
GO
/****** Object:  StoredProcedure [dbo].[USP_MenuTable]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_MenuTable]
(
@MenuID int=0,
@MenuName varchar (100) =NULL,
@SlNo int=0,
@IconName varchar(100)=null,
@CreatedBy int=0 ,
@action varchar(100),
@PMSGOUT varchar(100) output
)
as 
begin
	if (@action='MenuInsert')
	Begin
	    IF Exists (Select 1 from Tbl_Auth_Menu where DeletedFlag=0 AND MenuName=@MenuName)
			BEGIN
				SET @PMSGOUT='4';			
			END
		ELSE
			BEGIN
                insert into Tbl_Auth_Menu (MenuName,SlNo,IconName,CreatedBy)values(@MenuName,@SlNo,@IconName,@CreatedBy)
	            set @PMSGOUT='1';
			END
	
	End
    else if(@action='MenuUpdate')
	Begin
	    IF Exists (Select 1 from Tbl_Auth_Menu where DeletedFlag=0 AND MenuName=@MenuName AND MenuID =@MenuID )
			BEGIN
				SET @PMSGOUT='4';			
			END
		ELSE
			BEGIN
			     update  Tbl_Auth_Menu set MenuName=@MenuName,SlNo=@SlNo,IconName=@IconName where MenuID =@MenuID;
	             set @PMSGOUT='2';
			END 
     
	 End
     else if(@action='MenuSelectAll')
	 Begin
     select MenuID,MenuName,SlNo,IconName from  Tbl_Auth_Menu 
	 where  DeletedFlag=0
	 End
	 else if(@action='MenuSelectOne')
	 Begin
     select MenuId,MenuName,SlNo,IconName  from  Tbl_Auth_Menu 
	 where  DeletedFlag=0 and MenuID=@MenuID
	 End
     else if(@action='MenuDelete')
	 Begin
     update Tbl_Auth_Menu set DeletedFlag=1  where MenuID=@MenuID
	  set @PMSGOUT='3';
	  End
end

GO
/****** Object:  StoredProcedure [dbo].[USP_OHSB]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_OHSB](
@CMN_ID int =0,
@CMN_CODE nvarchar (100)= NULL,
@CMN_NAME nvarchar(50)= NULL,
@CMN_TYPE int=0,
@CMN_TYPEID int=0,
@CMN_TYPENAME nvarchar(50)=null,
@action varchar(100),
@PMSGOUT varchar(100) output)
as 
begin
if(@action='I')
begin
 IF Exists (Select 1 from CMN_MST where DeletedFlag=0 AND CMN_CODE=@CMN_CODE )
			BEGIN
				SET @PMSGOUT='4';			
			END
      else 
begin
insert into CMN_MST(CMN_CODE,CMN_NAME,CMN_TYPE) values(@CMN_CODE,@CMN_NAME,@CMN_TYPE)
set @PMSGOUT='1';
end
end
else if(@action='U')
Begin
	IF Exists (Select 1 from CMN_MST where DeletedFlag=0 and CMN_CODE=@CMN_CODE and CMN_ID!=@CMN_ID )
			BEGIN
				SET @PMSGOUT='4';			
			END
  ELSE
begin
Update CMN_MST set CMN_CODE=@CMN_CODE,
CMN_NAME=@CMN_NAME,CMN_TYPE=@CMN_TYPE
where CMN_ID=@CMN_ID
set @PMSGOUT='2';
end
end
else if(@action='DropDownBindType')
begin
select * from CMN_TYPE
set  @PMSGOUT='7';
end
else if(@action='SelectAll')
select a.CMN_ID,a.CMN_NAME,b.CMN_TYPENAME ,a.CMN_CODE
from CMN_MST a  inner join CMN_TYPE b on a.CMN_TYPE=b.CMN_TYPEID
where a.DeletedFlag=0 
else if(@action='SelectOne')
select CMN_ID,CMN_NAME,CMN_CODE,CMN_TYPE  from  CMN_MST where DeletedFlag=0  and CMN_ID=@CMN_ID
else if(@action='D')
begin
update CMN_MST set DeletedFlag=1 where CMN_ID=@CMN_ID
set @PMSGOUT='3';
end
end
GO
/****** Object:  StoredProcedure [dbo].[USP_PermissionTable]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_PermissionTable]
(
@PermissionId int=0,
@SubMenuID int=0,
@RollID int=0,
@UserId int=0,
@IsChecked bit=0,
@CreatedBy int=0 ,
@action varchar(100),
@PMSGOUT varchar(100) output
)
as 
begin
if(@action='DDLROLL')
select * from M_Roll_Tbl where DeletedFlag=0
else if (@action='PermissionInsert')	   
			BEGIN
                insert into Tbl_Auth_Permission (SubMenuID,RollID,UserId,IsChecked)
				values(@SubMenuID,@RollID,@UserId,@IsChecked)
	            set @PMSGOUT='1';
			END	
    else if(@action='PermissionUpdateToDelete')
	Begin
	 delete from Tbl_Auth_Permission where RollID=@RollID ;
	 --and case when @UserId=0 then 0 else UserId END=@UserId
		set @PMSGOUT='3'
	 End
	 else if(@action='GetSelectedSubMenus')
	 Begin
     select s.SubMenuID,s.SubMenuName,s.SubMenuURL,m.MenuID,m.MenuName,s.SlNo,
	 case when p.IsChecked is null or p.IsChecked=0 then 0 else 1 end as IsChecked 
	 from  Tbl_Auth_SubMenu s
	 INNER JOIN Tbl_Auth_Menu m ON m.MenuId = s.MenuID  
	 LEFT join Tbl_Auth_Permission p on p.SubMenuID=s.SubMenuID and p.RollID=@RollID
	 where  s.DeletedFlag=0 and m.DeletedFlag=0 ;
	 End 
	 else if(@action='GetSelectedSubMenuByDesig')
	 Begin
     select s.SubMenuID,s.SubMenuName,s.SubMenuURL,m.MenuId,m.MenuName,s.SlNo
	 from  Tbl_Auth_SubMenu s
	 INNER JOIN Tbl_Auth_Menu m ON m.MenuID = s.MenuId  
	 INNER join Tbl_Auth_Permission p on p.SubMenuID=s.SubMenuId and p.RollID=@RollID and p.IsChecked=1
	 where  s.DeletedFlag=0 and m.DeletedFlag=0 ;
	 End 
	 else if(@action='GetSelectedMenuByDesig')
	 Begin
select m.MenuID,m.MenuName,m.IconName,m.SlNo
	 from  Tbl_Auth_Menu m
	 INNER JOIN Tbl_Auth_SubMenu s ON m.MenuID = s.MenuID  
	 INNER join Tbl_Auth_Permission p on p.SubMenuID=s.SubMenuID and p.RollID=@RollID and p.IsChecked=1
	 where  s.DeletedFlag=0 and m.DeletedFlag=0 
	 group by m.MenuID,m.MenuName,m.IconName,m.SlNo
	 End 

end
GO
/****** Object:  StoredProcedure [dbo].[Usp_PriceMaster]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Usp_PriceMaster](
@AuditoriumID int =0,
@AuditoriumName varchar (100)= NULL,
@Row_Name varchar(50)=null,
@Row_No int=0,
@PriceId int =0,
@BlockId int=0,
@Price varchar(100)=null,
@action varchar(100),
@PMSGOUT varchar(100) output)
as 
begin
if(@action='InsertPrice')
begin
 IF Exists (Select 1 from M_Tbl_PriceMaster where DeletedFlag=0 AND AuditoriumID=@AuditoriumID and BlockId=@BlockId and PriceId!=PriceId )
			BEGIN
				SET @PMSGOUT='4';			
			END
      else 
begin
insert into M_Tbl_PriceMaster(AuditoriumID,BlockId,Row_No,Price) values(@AuditoriumID,@BlockId,@Row_No,@Price)
set @PMSGOUT='1';
end
end
else if(@action='UpdatePrice')
Begin
	IF Exists (Select 1 from M_Tbl_PriceMaster where DeletedFlag=0 and AuditoriumID=@AuditoriumID and BlockId=@BlockId 
	and PriceId!=@PriceId )
			BEGIN
				SET @PMSGOUT='4';			
			END
  ELSE
begin
Update M_Tbl_PriceMaster set AuditoriumID=@AuditoriumID,BlockId=@BlockId,Row_No=@Row_No,Price=@Price
where PriceId=@PriceId
set @PMSGOUT='2';
end
end
else if(@action='SelectAll')
begin
select a.PriceId,b.AuditoriumName,c.BlockName,d.RowDesc,a.Price from M_Tbl_PriceMaster a
inner join Tbl_M_Auditorium b on b.AuditoriumID=a.AuditoriumID
inner join M_Tbl_Block c on c.BlockId=a.BlockId
inner join M_RowTbl d on d.Row_No=a.Row_No
where a.DeletedFlag=0 and b.DeletedFlag=0 and c.DeletedFlag=0 and d.DeletedFlag=0
set  @PMSGOUT='7';
end
else if(@action='SelectOne')
select PriceId, AuditoriumID,BlockId,Row_No,Price from  M_Tbl_PriceMaster where DeletedFlag=0  and PriceId=@PriceId
else if(@action='Delete')
begin
update M_Tbl_PriceMaster set DeletedFlag=1 where PriceId=@PriceId
set @PMSGOUT='3';
end
--transaction
else if(@action='BindAuditorium')
begin
select  AuditoriumID,AuditoriumName from Tbl_M_Auditorium where DeletedFlag=0 
set @PMSGOUT='5';
end
else if(@action='BindRow')
begin
select a.Row_No,b.RowDesc from T_Block_Row_Mapping a inner join M_RowTbl b on b.Row_No=a.Row_No where  a.BlockId=@BlockId and a.DeletedFlag=0 and b.DeletedFlag=0
set @PMSGOUT='6';
end
else if(@action='BindBlock')
begin
select BlockId,BlockName from M_Tbl_Block  where AuditoriumID=@AuditoriumID and DeletedFlag=0
set @PMSGOUT='7';
end
end
GO
/****** Object:  StoredProcedure [dbo].[USP_RollMaster]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_RollMaster]
(
@RollID int=0,
@RollName varchar (100) =NULL,
@CreatedBy int=0 ,
@action varchar(100),
@PMSGOUT varchar(100) output
)
as 
begin
	if (@action='InsertRoll')
	Begin
	    IF Exists (Select 1 from M_Roll_Tbl where DeletedFlag=0 AND RollName=@RollName)
			BEGIN
				SET @PMSGOUT='4';			
			END
		ELSE
			BEGIN
                insert into M_Roll_Tbl (RollName)values(@RollName)
	            set @PMSGOUT='1';
			END
	
	End
    else if(@action='UpdateRoll')
	Begin
	    IF Exists (Select 1 from M_Roll_Tbl where DeletedFlag=0 AND RollName=@RollName AND RollID !=@RollID )
			BEGIN
				SET @PMSGOUT='4';			
			END
		ELSE
			BEGIN
			     update  M_Roll_Tbl set RollName=@RollName where RollID =@RollID;
	             set @PMSGOUT='2';
			END 
     
	 End
     else if(@action='SelectAllRoll')
	 Begin
     select RollID,RollName from  M_Roll_Tbl 
	 where  DeletedFlag=0
	 End
	 else if(@action='SelectOneRoll')
	 Begin
     select RollID,RollName  from  M_Roll_Tbl 
	 where  DeletedFlag=0 and RollID=@RollID
	 End
     else if(@action='DeleteRoll')
	 Begin
     update M_Roll_Tbl set DeletedFlag=1  where RollID=@RollID
	  set @PMSGOUT='3';
	  End
end
GO
/****** Object:  StoredProcedure [dbo].[USP_Row_Block_Map]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_Row_Block_Map]
(
@BlockRowID int=0,
@AuditoriumID int=0,
@BlockId int=0,
@Row_No int=0,
@IsChecked bit=0,
@CreatedBy int=0 ,
@action varchar(100),
@PMSGOUT varchar(100) output
)
as 
begin
	if (@action='RowBlockInsert')	
	Begin
	    IF Exists (Select 1 from T_Block_Row_Mapping where DeletedFlag=0 and AuditoriumID=@AuditoriumID and 
		BlockId=@BlockId
		 and Row_No=@Row_No and IsChecked=1 )
			BEGIN
				SET @PMSGOUT='4';			
			END
		ELSE
			BEGIN
                insert into T_Block_Row_Mapping(AuditoriumID,BlockId,Row_No,IsChecked)
				values(@AuditoriumID,@BlockId,@Row_No,@IsChecked)
	            set @PMSGOUT='1';
			END	 
			end
			
else if(@action='SelectedAllRows')
begin
select * from M_RowTbl where Row_No  in(select Row_No  from Tbl_Seatmaster where
AuditoriumID=@AuditoriumID and DeletedFlag=0)
and DeletedFlag=0
set  @PMSGOUT='5';
end
else if(@action='SelectedAllBlocks')
begin
select BlockId,BlockName from M_Tbl_Block where AuditoriumID=@AuditoriumID  and DeletedFlag=0
and DeletedFlag=0
set  @PMSGOUT='6';
end
else if(@action='GetAllMapDetails')
begin
--select A.AuditoriumID,A.BlockId,A.BlockRowID,A.Row_No,B.AuditoriumName,C.BlockName,D.RowDesc
--from T_Block_Row_Mapping A
-- inner join Tbl_M_Auditorium B on B.AuditoriumID=A.AuditoriumID
-- inner join M_Tbl_Block C on C.BlockId=A.BlockId
-- inner join M_RowTbl D on D.Row_No=A.Row_No
--  where A.DeletedFlag=0 and B.DeletedFlag=0 and C.DeletedFlag=0 and D.DeletedFlag=0 
select distinct t.AuditoriumID,b.AuditoriumName,c.BlockName,c.BlockId,
  STUFF((SELECT distinct ', ' + cast(m.RowDesc as varchar(100))
         from T_Block_Row_Mapping t1
		 inner join M_RowTbl m on m.Row_No=t1.Row_No
         where t.BlockId = t1.BlockId
		 and t.AuditoriumID=t1.AuditoriumID
            FOR XML PATH(''), TYPE
            ).value('.', 'NVARCHAR(MAX)') 
        ,1,2,'') RowDesc
from T_Block_Row_Mapping t
inner join Tbl_M_Auditorium b on b.AuditoriumID=t.AuditoriumID
 inner join M_Tbl_Block c on c.BlockId=t.BlockId
 inner join M_RowTbl d on d.Row_No=t.Row_No
  where t.DeletedFlag=0 and b.DeletedFlag=0 and c.DeletedFlag=0 and d.DeletedFlag=0 and t.IsChecked=1
  set @PMSGOUT='7'
end
else if(@action='DeleteToUpdate')
	Begin
	delete from T_Block_Row_Mapping where AuditoriumID=@AuditoriumID  and BlockId=@BlockId
		set @PMSGOUT='2';
	End
	else if(@action='Update')
	Begin
	    IF Exists (Select 1 from T_Block_Row_Mapping where DeletedFlag=0 AND AuditoriumID=@AuditoriumID And BlockId=@BlockId AND  Row_No=@Row_No and BlockRowID!=@BlockRowID)
			BEGIN
				SET @PMSGOUT='4';			
			END
		ELSE
			BEGIN
		update  T_Block_Row_Mapping set AuditoriumID=@AuditoriumID,BlockId=@BlockId,Row_No=@Row_No where BlockRowID=@BlockRowID
	              set @PMSGOUT='2';
			END  
			end
			else if(@action='getdatabyids')
			select BlockRowID,BlockId,AuditoriumID,Row_No,IsChecked from T_Block_Row_Mapping  where AuditoriumID=@AuditoriumID
			and BlockId=@BlockId and DeletedFlag=0 and IsChecked=1
			else if(@action='Delete')
			begin
			update  T_Block_Row_Mapping set DeletedFlag=1 where BlockId=@BlockId and AuditoriumID=@AuditoriumID
			 set @PMSGOUT='3';
			 end
end
GO
/****** Object:  StoredProcedure [dbo].[USP_RowDetails]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_RowDetails](
@Seat_Id int =0,
@Seat_No varchar (100)= NULL,
@Row_No int=0,
@Row_Name varchar (50)= NULL,
@RowDesc varchar(50)=Null,
@action varchar(100),
@PMSGOUT varchar(100) output)
as 
begin
if(@action='InsertRow')
begin
 IF Exists (Select 1 from M_RowTbl where DeletedFlag=0 AND Row_No=@Row_No )
			BEGIN
				SET @PMSGOUT='4';			
			END
      else 
begin
insert into M_RowTbl(Row_Name,RowDesc) values(@Row_Name,@RowDesc)
set @PMSGOUT='1';
end
end
else if(@action='UpdateRow')
Begin
	IF Exists (Select 1 from M_RowTbl where DeletedFlag=0 and Row_Name=@Row_Name and Row_No!=@Row_No )
			BEGIN
				SET @PMSGOUT='4';			
			END
  ELSE
begin
Update M_RowTbl set Row_Name=@Row_Name,RowDesc=@RowDesc
where Row_No=@Row_No 
set @PMSGOUT='2';
end
end
else if(@action='SelectOneRow')
select Row_No,Row_Name,RowDesc  from  M_RowTbl where DeletedFlag=0  and Row_No=@Row_No
else if(@action='DeleteRow')
begin
update M_RowTbl set DeletedFlag=1 where Row_No=@Row_No
set @PMSGOUT='3';
end
else if(@action='SelectAllRow')
select Row_No,Row_Name,RowDesc  from  M_RowTbl where DeletedFlag=0  
--seatdetails
else if(@action='DropDownBindRows')
begin
select * from M_RowTbl where  DeletedFlag=0
set  @PMSGOUT='7';
end
else if(@action='SelectAllSeat')
select a.Seat_Id,b.Row_Name,a.Seat_No 
from M_SeatNoTbl a  inner join M_RowTbl b on a.Row_No=b.Row_No
where a.DeletedFlag=0 

else if(@action='SelectOneSeat')
select Seat_Id,Row_No,Seat_No  from  M_SeatNoTbl where DeletedFlag=0  and Seat_Id=@Seat_Id
else if (@action='InsertSeat')
begin
 IF Exists (Select 1 from M_SeatNoTbl where DeletedFlag=0 AND Row_No=@Row_No )
			BEGIN
				SET @PMSGOUT='4';			
			END
      else 
begin
insert into M_SeatNoTbl(Row_No,Seat_No) values(@Row_No,@Seat_No)
set @PMSGOUT='1';
end
end
else if(@action='UpdateSeat')
Begin
	IF Exists (Select 1 from M_SeatNoTbl where DeletedFlag=0 and Row_No=@Row_No and Seat_Id!=@Seat_Id )
			BEGIN
				SET @PMSGOUT='4';			
			END
  ELSE
begin
Update M_SeatNoTbl set Row_No=@Row_No,Seat_No=@Seat_No
where Seat_Id=@Seat_Id
set @PMSGOUT='2';
end
end
else if(@action='DeleteSeat')
begin
update M_SeatNoTbl set DeletedFlag=1 where Seat_Id=@Seat_Id
set @PMSGOUT='3';
end
end
GO
/****** Object:  StoredProcedure [dbo].[Usp_ShowMasterOP]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Usp_ShowMasterOP](
@ShowID int =0,
@ShowName varchar (100)= NULL,
@AuditoriumID int= 0,
@action varchar(100),
@PMSGOUT varchar(100) output)
as 
begin
if(@action='InsertShow')
begin
 IF Exists (Select 1 from M_Tbl_ShowsMaster where DeletedFlag=0 AND ShowName=@ShowName )
			BEGIN
				SET @PMSGOUT='4';			
			END
      else 
begin
insert into M_Tbl_ShowsMaster(ShowName,AuditoriumID) values(@ShowName,@AuditoriumID)
set @PMSGOUT='1';
end
end
else if(@action='UpdateShow')
Begin
	IF Exists (Select 1 from M_Tbl_ShowsMaster where DeletedFlag=0 and ShowName=@ShowName and ShowID!=@ShowID )
			BEGIN
				SET @PMSGOUT='4';			
			END
  ELSE
begin
Update M_Tbl_ShowsMaster set ShowName=@ShowName
,AuditoriumID=@AuditoriumID
where ShowID=@ShowID
set @PMSGOUT='2';
end
end
else if(@action='SelectAll')
begin
select a.ShowID,a.ShowName,b.AuditoriumName from M_Tbl_ShowsMaster a
inner join Tbl_M_Auditorium b on b.AuditoriumID=a.AuditoriumID where
a.DeletedFlag=0 and b.DeletedFlag=0
set  @PMSGOUT='7';
end
else if(@action='SelectOne')
select AuditoriumID,ShowID,ShowName  from  M_Tbl_ShowsMaster where DeletedFlag=0  and ShowID=@ShowID
else if(@action='DeleteShow')
begin
update M_Tbl_ShowsMaster set DeletedFlag=1 where ShowID=@ShowID
set @PMSGOUT='3';
end
--transaction
else if(@action='BindAuditorium')
begin
select  AuditoriumID,AuditoriumName from Tbl_M_Auditorium where DeletedFlag=0 
set @PMSGOUT='5';
end
end
GO
/****** Object:  StoredProcedure [dbo].[USP_Slot_Master]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_Slot_Master]
(
@SlotID int=0,
@SlotName varchar(30)=null,
@AuditoriumID int=0,
@Slot_TimeFrom varchar(100)=null,
@Slot_TimeTo varchar(100)=null,
@UpdatedOn date=null,
@UpdatedBy varchar(50)=null,
@action varchar(100),
@PMSGOUT varchar(100) output
)
as
begin
 if(@action='GetAllSlotByAuditorium')
		Begin
		  Select AuditoriumID,AuditoriumName from Tbl_M_Auditorium where DeletedFlag=0 
		End
	else if(@action='InsertUpdate')
		begin
		   if(@SlotID=0)
			   begin					
					IF Exists (Select 1 from M_Tbl_SlotMaster where DeletedFlag=0 and AuditoriumID=@AuditoriumID and SlotName=@SlotName )
						begin
						   SET @PMSGOUT='4'; 
						end
					else
					begin
					   insert into M_Tbl_SlotMaster(SlotName, AuditoriumID, Slot_TimeFrom,Slot_TimeTo)
					   values(@SlotName,@AuditoriumID,@Slot_TimeFrom,@Slot_TimeTo)
					   set @PMSGOUT='1';
					end
			   end
		   else
			   begin
			   IF Exists (Select 1 from M_Tbl_SlotMaster where DeletedFlag=0 AND Slot_TimeFrom=@Slot_TimeFrom and Slot_TimeTo=@Slot_TimeTo and SlotID!=@SlotID)
						begin
						   SET @PMSGOUT='4'; 
						end
				   else
				   begin
					   update M_Tbl_SlotMaster set SlotName=@SlotName,AuditoriumID=@AuditoriumID,Slot_TimeFrom=@Slot_TimeFrom,Slot_TimeTo=@Slot_TimeTo,UpdatedOn=getdate(),UpdatedBy=@SlotID where SlotID=@SlotID
					   set @PMSGOUT='2';
				   end
				end
		end
else if(@action='Delete')
	 begin
	 update M_Tbl_SlotMaster set DeletedFlag=1  where SlotID=@SlotID
	 set @PMSGOUT='3';
	 end
else if(@action='SelectOne')
    select SlotID,SlotName,AuditoriumID,Slot_TimeFrom,Slot_TimeTo 
	from M_Tbl_SlotMaster where SlotID=@SlotID
 else if(@action='Alldata')
 begin
 if(@AuditoriumID=0)
	  begin
			select SlotID, SlotName, AuditoriumName, Slot_TimeFrom,Slot_TimeTo,s.DeletedFlag
			from M_Tbl_SlotMaster s,Tbl_M_Auditorium H where s.DeletedFlag=0 and s.AuditoriumID=h.AuditoriumID order by SlotID desc
	  end
else
	 begin
			select SlotID, SlotName, AuditoriumName, Slot_TimeFrom,Slot_TimeTo,s.DeletedFlag
			from M_Tbl_SlotMaster s,Tbl_M_Auditorium H where s.DeletedFlag=0 and s.AuditoriumID=h.AuditoriumID and s.AuditoriumID=@AuditoriumID order by SlotID desc
	 end
 
 end			
end
GO
/****** Object:  StoredProcedure [dbo].[USP_SubMenuTable]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_SubMenuTable]
(
@SubMenuID int=0,
@SubMenuName varchar (100) =NULL,
@SubMenuURL varchar(100)=null,
@MenuID int=0,
@SlNo int=0,
@SubMenuDescription varchar(100)=null,
@CreatedBy int=0 ,
@action varchar(100),
@PMSGOUT varchar(100) output
)
as 
begin
	if (@action='SubMenuInsert')
	Begin
	    IF Exists (Select 1 from Tbl_Auth_SubMenu where DeletedFlag=0 AND SubMenuName=@SubMenuName)
			BEGIN
				SET @PMSGOUT='4';			
			END
		ELSE
			BEGIN
                insert into Tbl_Auth_SubMenu (SubMenuName,SubMenuURL,MenuID,SlNo,SubMenuDescription,CreatedBy)
				values(@SubMenuName,@SubMenuURL,@MenuID,@SlNo,@SubMenuDescription,@CreatedBy)
	            set @PMSGOUT='1';
			END
	
	End
    else if(@action='SubMenuUpdate')
	Begin
	    IF Exists (Select 1 from Tbl_Auth_SubMenu where DeletedFlag=0 AND SubMenuName=@SubMenuName AND 
		SubMenuID !=@SubMenuID )
			BEGIN
				SET @PMSGOUT='4';			
			END
		ELSE
			BEGIN
			     update  Tbl_Auth_SubMenu set SubMenuName=@SubMenuName,SubMenuURL=@SubMenuURL,MenuID=@MenuID,
				 SlNo=@SlNo,SubMenuDescription=@SubMenuDescription,UpdatedOn=getdate(),UpdatedBy=@CreatedBy 
				 where SubMenuID =@SubMenuID;
	             set @PMSGOUT='2';
			END 
     
	 End
     else if(@action='SubMenuSelectAll')
	 Begin
     select s.SubMenuID,s.SubMenuName,s.SubMenuURL,m.MenuId,m.MenuName,s.SlNo,s.SubMenuDescription
	 from  Tbl_Auth_SubMenu s
	 INNER JOIN Tbl_Auth_Menu m ON m.MenuID = s.MenuID  
	 where  s.DeletedFlag=0 
	 End
	 
	 	 else if(@action='SubMenuSelectOne')
	 Begin
     select SubMenuID,SubMenuName,SubMenuURL,MenuId,SlNo,SubMenuDescription from  Tbl_Auth_SubMenu 
	 where  DeletedFlag=0 and SubMenuID=@SubMenuID
	 End
     else if(@action='SubMenuDelete')
	 Begin
     update Tbl_Auth_SubMenu set DeletedFlag=1  where SubMenuID=@SubMenuID 
	  set @PMSGOUT='3';
	  End
end
GO
/****** Object:  StoredProcedure [dbo].[USP_USER]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_USER]
(
@UserId int=0,
@Age int=0,
@UserName varchar(50)=NULL,
@Password varchar(50)=NULL,
@FullName varchar(50)='',
@Email varchar(50)=NULL,
@Mobile varchar(50)=NULL,
@City varchar(40)=null,
@DesignationId int=0,
@Designation varchar(40)=null,
@DepartmentId int=0,
@AuditoriumID int=0,
@RollID int=0,
@Gender varchar(50)=NULL,
@Address varchar(500)=NULL,
@mode varchar(100),
@PMSGOUT varchar(100) output
)
as
begin
 if(@mode='BindDepartMent')
   select *  from M_DepartmentMaster where DeletedFlag=0
    else if(@mode='BindDesignation')
   select *  from M_DesignationMaster where DeletedFlag=0  
else if(@mode='IU')
begin
   if(@UserId=0)
       begin
	        IF Exists (Select 1 from M_USER where DeletedFlag=0 AND UserName=@UserName)
				begin
				   SET @PMSGOUT='4'; 
				end
			else
			begin
			   insert into M_USER(UserName, Password, FullName, Email, Mobile, Gender, Address,Age,City,DesignationId,DepartmentId,AuditoriumID,RollID)
			   values(@UserName,@Password,@FullName,@Email,@Mobile,@Gender,@Address,@Age,@city,@DesignationId,@DepartmentId,@AuditoriumID,@RollID)
			   set @PMSGOUT='1';
		    end
	   end
   else
	   begin
	   IF Exists (Select 1 from M_USER where DeletedFlag=0 AND UserName=@UserName and UserId!=@UserId)
				begin
				   SET @PMSGOUT='4'; 
				end
		   else
		   begin
			   update M_USER set UserName=@UserName,Password=@Password,FullName=@FullName,Email=@Email,Mobile=@Mobile,Gender=@Gender,Address=@Address,Age=@Age,City=@City,DesignationId=@DesignationId,AuditoriumID=@AuditoriumID,RollID=@RollID where UserId=@UserId
			   set @PMSGOUT='2';
		   end
		end
end


 else if(@mode='D')
 begin
 update M_USER set DeletedFlag=1  where UserId=@UserId
 set @PMSGOUT='3';
 end
else if(@mode='S')
 select *  from M_USER where UserId=@UserId
 else if(@mode='A')
 begin
	   select UserId,UserName,FullName,Email,Mobile,Gender,Age,d.Designation,r.RollName  from M_USER u,M_DesignationMaster d ,M_Roll_Tbl r where u.DeletedFlag=0 and 
	     UserName!='Admin' and
	    u.DesignationId=d.DesignationId and u.RollID=r.RollID 
		--and
		--case when ISNULL(@FullName,'') = '' then ISNULL(@FullName,'') else FullName end=ISNULL(@FullName,'')
		--and case when ISNULL(@DesignationId,'0') ='0'then ISNULL(@DesignationId,'0') else d.DesignationId end=ISNULL(@DesignationId,'0')
		 order by UserId desc;
 end
 else if(@mode='Bind')
   begin
   select RollID, RollName  from M_Roll_Tbl where DeletedFlag=0
   end  
 end




 
	
GO
/****** Object:  StoredProcedure [dbo].[USP_USER_LOGIN_MANAGE]    Script Date: 10-08-2023 12:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_USER_LOGIN_MANAGE](
	@UserId int =0,
	@UserName varchar(50) =NULL,
	@Password varchar(50)= NULL,
	@FullName varchar(50)= NULL,
	@Email varchar(50)= NULL,
	@Mobile varchar(50)= NULL,
	@Gender varchar(50) =NULL,
	@Address varchar(500) =NULL,
	@RollID int =0,
	@CreatedBy int =0,
	@action varchar(100),
	@PMSGOUT varchar(100) output
)
as
begin
if (@action='LoginPage')
begin
select * from M_USER p
--inner join Tbl_M_Auditorium h on p.AuditoriumID=h.AuditoriumID 
where UserName=@UserName and Password=@Password and p.DeletedFlag=0 
end
else if(@action='changepassword')
begin
update M_USER set Password=@Password where UserName=@UserName
set @PMSGOUT=1
end
--else if(@action='DoctorLogin')
--select * from M_PL_USER where UserName=@UserName and Password=@Password and DeletedFlag=0 and DesignationId=6
end
GO
