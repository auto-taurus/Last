USE [auto_news]
GO
/****** Object:  Table [dbo].[Auto_BatchInsert_NewsId]    Script Date: 2020/10/21 19:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Auto_BatchInsert_NewsId](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NewsId] [int] NULL,
	[Message] [nvarchar](max) NULL,
 CONSTRAINT [PK_Auto_BatchInsertId] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Member_Info]    Script Date: 2020/10/21 19:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member_Info](
	[MemberId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](10) NULL,
	[NickName] [nvarchar](20) NULL,
	[Name] [nvarchar](20) NULL,
	[Sex] [int] NULL,
	[Phone] [varchar](15) NULL,
	[Alipay] [varchar](20) NULL,
	[Wechat] [varchar](50) NULL,
	[Password] [varchar](100) NULL,
	[Avatar] [varchar](255) NULL,
	[Beans] [int] NULL,
	[BeansTotals] [int] NULL,
	[LastLoginTime] [datetime] NULL,
	[IsEnbale] [int] NULL,
	[Remarks] [nvarchar](255) NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_MEMBER_INFO] PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Report_Category_DayAccess]    Script Date: 2020/10/21 19:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Report_Category_DayAccess](
	[CategoryAccessId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NULL,
	[CategoryName] [nvarchar](50) NULL,
	[Count] [int] NULL,
	[Today] [date] NULL,
	[LastUpdateTime] [datetime] NULL,
 CONSTRAINT [PK_REPORT_CATEGORY_DAYACCESS] PRIMARY KEY CLUSTERED 
(
	[CategoryAccessId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Report_Category_DayClick]    Script Date: 2020/10/21 19:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Report_Category_DayClick](
	[CategoryClickId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NULL,
	[CategoryName] [nvarchar](50) NULL,
	[Count] [int] NULL,
	[Today] [date] NULL,
	[LastUpdateTime] [datetime] NULL,
 CONSTRAINT [PK_REPORT_CATEGORY_DAYCLICK] PRIMARY KEY CLUSTERED 
(
	[CategoryClickId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Report_News_DayAccess]    Script Date: 2020/10/21 19:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Report_News_DayAccess](
	[NewsAccessId] [int] IDENTITY(1,1) NOT NULL,
	[NewsId] [varchar](12) NULL,
	[CategoryId] [int] NULL,
	[CategoryName] [nvarchar](50) NULL,
	[SpecialCode] [int] NULL,
	[SpecialName] [nvarchar](50) NULL,
	[Count] [int] NULL,
	[Today] [date] NULL,
	[LastUpdateTime] [datetime] NULL,
 CONSTRAINT [PK_REPORT_NEWS_DAYACCESS] PRIMARY KEY CLUSTERED 
(
	[NewsAccessId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Report_News_DayClick]    Script Date: 2020/10/21 19:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Report_News_DayClick](
	[NewsClickId] [int] IDENTITY(1,1) NOT NULL,
	[NewsId] [varchar](12) NULL,
	[CategoryId] [int] NULL,
	[CategoryName] [nvarchar](50) NULL,
	[SpecialCode] [int] NULL,
	[SpecialName] [nvarchar](50) NULL,
	[Count] [int] NULL,
	[Today] [date] NULL,
	[LastUpdateTime] [datetime] NULL,
 CONSTRAINT [PK_REPORT_NEWS_DAYCLICK] PRIMARY KEY CLUSTERED 
(
	[NewsClickId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Report_Site_DayAccess]    Script Date: 2020/10/21 19:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Report_Site_DayAccess](
	[SiteAccessId] [int] IDENTITY(1,1) NOT NULL,
	[SiteId] [int] NULL,
	[Count] [int] NULL,
	[Today] [date] NULL,
	[LastUpdateTime] [datetime] NULL,
 CONSTRAINT [PK_REPORT_SITE_DAYACCESS] PRIMARY KEY CLUSTERED 
(
	[SiteAccessId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[System_Dictionary]    Script Date: 2020/10/21 19:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[System_Dictionary](
	[DictionaryId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NULL,
	[Keys] [varchar](50) NULL,
	[DictKey] [varchar](20) NULL,
	[DictTips] [nvarchar](20) NULL,
	[DictName] [nvarchar](255) NULL,
	[DictValue] [nvarchar](1000) NULL,
	[DictDesc] [nvarchar](255) NULL,
	[IsEnable] [int] NULL,
	[Squence] [int] NULL,
	[Remarks] [nvarchar](255) NULL,
 CONSTRAINT [PK_System_Dictionary] PRIMARY KEY CLUSTERED 
(
	[DictionaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[System_Logs]    Script Date: 2020/10/21 19:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[System_Logs](
	[LogsId] [int] IDENTITY(1,1) NOT NULL,
	[Methods] [varchar](100) NULL,
	[Grade] [int] NULL,
	[Source] [varchar](50) NULL,
	[Args] [nvarchar](2000) NULL,
	[Errors] [nvarchar](2000) NULL,
	[CreateBy] [int] NULL,
	[CreateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_System_Logs] PRIMARY KEY CLUSTERED 
(
	[LogsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[System_Menu]    Script Date: 2020/10/21 19:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[System_Menu](
	[MenuId] [int] IDENTITY(1,1) NOT NULL,
	[SiteId] [int] NULL,
	[MenuIcon] [varchar](20) NULL,
	[MenuName] [nvarchar](20) NULL,
	[ParentId] [int] NULL,
	[NodeValue] [varchar](1000) NULL,
	[Areas] [varchar](100) NULL,
	[Controller] [varchar](100) NULL,
	[Action] [varchar](100) NULL,
	[Urls] [nvarchar](500) NULL,
	[RouterName] [nvarchar](50) NULL,
	[RouterPath] [nvarchar](100) NULL,
	[Component] [varchar](100) NULL,
	[ShowAlways] [int] NULL,
	[ShowHeader] [int] NULL,
	[HideInBread] [int] NULL,
	[HideInMenu] [int] NULL,
	[NotCache] [int] NULL,
	[BeforeCloseName] [int] NULL,
	[Sequence] [int] NULL,
	[IsEnable] [int] NULL,
	[RowVers] [timestamp] NULL,
	[Remarks] [nvarchar](255) NULL,
	[CreateBy] [int] NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_System_Menus] PRIMARY KEY CLUSTERED 
(
	[MenuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[System_Role]    Script Date: 2020/10/21 19:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[System_Role](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](20) NULL,
	[IsEnable] [int] NULL,
	[Remarks] [nvarchar](255) NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_System_Role] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[System_RoleDictionary]    Script Date: 2020/10/21 19:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[System_RoleDictionary](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NOT NULL,
	[DictionaryKey] [varchar](20) NULL,
	[DictionaryValue] [nvarchar](100) NULL,
 CONSTRAINT [PK_System_RoleInDictionary] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[System_RoleInMenu]    Script Date: 2020/10/21 19:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[System_RoleInMenu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NULL,
	[MenuId] [int] NULL,
 CONSTRAINT [PK_System_RoleInMenu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[System_Users]    Script Date: 2020/10/21 19:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[System_Users](
	[UsersId] [int] IDENTITY(1,1) NOT NULL,
	[UsersName] [nvarchar](20) NULL,
	[LoginName] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[MobilePhone] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[LastLoginIp] [varchar](20) NULL,
	[LastLoginTime] [datetime] NULL,
	[IsEnable] [int] NULL,
	[Remarks] [nvarchar](255) NULL,
	[CreateBy] [int] NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_System_User] PRIMARY KEY CLUSTERED 
(
	[UsersId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[System_UsersDictionary]    Script Date: 2020/10/21 19:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[System_UsersDictionary](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[DictionaryKey] [varchar](20) NULL,
	[DictionaryValue] [nvarchar](100) NULL,
 CONSTRAINT [PK_System_UserInDictionary] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[System_UsersInMenu]    Script Date: 2020/10/21 19:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[System_UsersInMenu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[MenuId] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[System_UsersInRole]    Script Date: 2020/10/21 19:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[System_UsersInRole](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UsersId] [int] NULL,
	[RoleId] [int] NULL,
 CONSTRAINT [PK_System_UsersInRole] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[System_UsersRefreshToken]    Script Date: 2020/10/21 19:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[System_UsersRefreshToken](
	[RefreshTokenId] [int] IDENTITY(1,1) NOT NULL,
	[UsersId] [int] NULL,
	[AccessToken] [varchar](1000) NULL,
	[Expires] [datetime] NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_System_UsersRefreshToken] PRIMARY KEY CLUSTERED 
(
	[RefreshTokenId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Web_Category]    Script Date: 2020/10/21 19:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Web_Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[SiteId] [int] NULL,
	[CategoryName] [nvarchar](20) NULL,
	[ParentId] [int] NULL,
	[NodeValue] [varchar](1000) NULL,
	[Controller] [varchar](50) NULL,
	[Action] [varchar](50) NULL,
	[Urls] [varchar](500) NULL,
	[DocumentNumber] [int] NULL,
	[AccessNumber] [int] NULL,
	[ClickNumber] [int] NULL,
	[Title] [varchar](255) NULL,
	[Keywords] [varchar](255) NULL,
	[Description] [varchar](255) NULL,
	[Sequence] [int] NULL,
	[IsEnable] [int] NULL,
	[RowVers] [timestamp] NULL,
	[Remarks] [nvarchar](255) NULL,
	[CreateBy] [int] NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_Web_Classify] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Web_Channel]    Script Date: 2020/10/21 19:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Web_Channel](
	[ChannelId] [int] IDENTITY(1,1) NOT NULL,
	[SiteId] [int] NULL,
	[ChannelName] [varchar](100) NULL,
	[ChannelAddress] [varchar](1000) NULL,
	[ChannelJs] [varchar](255) NULL,
	[IsEnable] [int] NULL,
	[RowVers] [timestamp] NULL,
	[Remarks] [nvarchar](255) NULL,
	[CreateBy] [int] NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_Web_Channel] PRIMARY KEY CLUSTERED 
(
	[ChannelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Web_NewsOperate_Logs]    Script Date: 2020/10/21 19:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Web_NewsOperate_Logs](
	[NewsOperateId] [int] IDENTITY(1,1) NOT NULL,
	[NewsId] [varchar](12) NULL,
	[OperateType] [nvarchar](20) NULL,
	[OperateStatus] [nvarchar](255) NULL,
	[Remarks] [nvarchar](255) NULL,
	[CreateBy] [int] NULL,
	[CreateName] [nvarchar](20) NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_WEB_NEWSOPERATE_LOGS] PRIMARY KEY CLUSTERED 
(
	[NewsOperateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Web_Sensitive]    Script Date: 2020/10/21 19:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Web_Sensitive](
	[SensitiveId] [int] IDENTITY(1,1) NOT NULL,
	[SiteId] [int] NULL,
	[Type] [int] NULL,
	[TypeText] [nvarchar](20) NULL,
	[SensitiveWords] [nvarchar](50) NULL,
	[Author] [nvarchar](1000) NULL,
	[Urls] [nvarchar](4000) NULL,
	[RowVers] [timestamp] NULL,
	[IsEnable] [int] NULL,
	[Remarks] [nvarchar](255) NULL,
	[CreateBy] [int] NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_Web_Sensitive] PRIMARY KEY CLUSTERED 
(
	[SensitiveId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Web_Site]    Script Date: 2020/10/21 19:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Web_Site](
	[SiteId] [int] IDENTITY(1,1) NOT NULL,
	[SiteName] [nvarchar](50) NULL,
	[SiteUrls] [varchar](255) NULL,
	[LogoUrls] [varchar](255) NULL,
	[AccessNumber] [int] NULL,
	[Title] [varchar](255) NULL,
	[Keywords] [varchar](255) NULL,
	[Description] [varchar](255) NULL,
	[RowVers] [timestamp] NULL,
	[IsEnable] [int] NULL,
	[Remarks] [nvarchar](255) NULL,
	[CreateBy] [int] NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_Web_Site] PRIMARY KEY CLUSTERED 
(
	[SiteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Web_Special]    Script Date: 2020/10/21 19:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Web_Special](
	[SpecialId] [int] IDENTITY(1,1) NOT NULL,
	[SiteId] [int] NULL,
	[SpecialCode] [varchar](10) NULL,
	[Name] [nvarchar](50) NULL,
	[DisplayType] [int] NULL,
	[IsEnable] [int] NULL,
	[RowVers] [timestamp] NULL,
	[Remarks] [nvarchar](255) NULL,
	[CreateBy] [int] NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_Web_Code] PRIMARY KEY CLUSTERED 
(
	[SpecialId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Member_Info] ON 

INSERT [dbo].[Member_Info] ([MemberId], [Code], [NickName], [Name], [Sex], [Phone], [Alipay], [Wechat], [Password], [Avatar], [Beans], [BeansTotals], [LastLoginTime], [IsEnbale], [Remarks], [CreateTime]) VALUES (1, NULL, NULL, NULL, NULL, N'15216860857', NULL, NULL, N'123456', NULL, NULL, NULL, NULL, 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Member_Info] OFF
SET IDENTITY_INSERT [dbo].[System_Dictionary] ON 

INSERT [dbo].[System_Dictionary] ([DictionaryId], [Title], [Keys], [DictKey], [DictTips], [DictName], [DictValue], [DictDesc], [IsEnable], [Squence], [Remarks]) VALUES (1, N'提现方式', N'WithdrawalMethod', NULL, NULL, N'微信', NULL, N'1.申请提现后将在2个工作日内完成审核并打款到账，节假日顺延。
2.一个微信账号只能对应一个资讯账号，请勿帮他人提现。
3.提现账户中填写的真实姓名，是您微信账号认证的姓名，注意是您的姓名，不是昵称。
4.兑换成功后，可在微信-我-钱包-零钱-零钱明细中查看到账详情。', NULL, NULL, NULL)
INSERT [dbo].[System_Dictionary] ([DictionaryId], [Title], [Keys], [DictKey], [DictTips], [DictName], [DictValue], [DictDesc], [IsEnable], [Squence], [Remarks]) VALUES (2, N'提现方式', N'WithdrawalMethod', NULL, N'0.1元天天提', N'支付宝', NULL, N'1.申请提现后将在2个工作日内完成审核并打款到账，节假日顺延。
2.一个支付宝只能对应一个资讯账号，请勿帮他人提现。
3.提现账户中填写的真实姓名，请与支付宝账号的认证姓名保持一致。
4.兑换成功后，可在支付宝-我的-账单中查看到账详情。', NULL, NULL, NULL)
INSERT [dbo].[System_Dictionary] ([DictionaryId], [Title], [Keys], [DictKey], [DictTips], [DictName], [DictValue], [DictDesc], [IsEnable], [Squence], [Remarks]) VALUES (3, N'赚钱日报（每日固定收入分类）', N'IncomeDaily', N'1', NULL, N'好友收益', NULL, N'好友越多，获得的奖励越多', NULL, NULL, NULL)
INSERT [dbo].[System_Dictionary] ([DictionaryId], [Title], [Keys], [DictKey], [DictTips], [DictName], [DictValue], [DictDesc], [IsEnable], [Squence], [Remarks]) VALUES (4, N'赚钱日报（每日固定收入分类）', N'IncomeDaily', N'2', NULL, N'阅读收益', NULL, N'阅读文章获得收益', NULL, NULL, NULL)
INSERT [dbo].[System_Dictionary] ([DictionaryId], [Title], [Keys], [DictKey], [DictTips], [DictName], [DictValue], [DictDesc], [IsEnable], [Squence], [Remarks]) VALUES (5, N'赚钱日报（每日固定收入分类）', N'IncomeDaily', N'3', NULL, N'观看收益', NULL, N'观看视频、小视频获得奖励', NULL, NULL, NULL)
INSERT [dbo].[System_Dictionary] ([DictionaryId], [Title], [Keys], [DictKey], [DictTips], [DictName], [DictValue], [DictDesc], [IsEnable], [Squence], [Remarks]) VALUES (6, N'赚钱日报（每日固定收入分类）', N'IncomeDaily', N'4', NULL, N'分享收益', NULL, N'分享文章、视频、活动可获得收益', NULL, NULL, NULL)
INSERT [dbo].[System_Dictionary] ([DictionaryId], [Title], [Keys], [DictKey], [DictTips], [DictName], [DictValue], [DictDesc], [IsEnable], [Squence], [Remarks]) VALUES (7, N'赚钱日报（每日固定收入分类）', N'IncomeDaily', N'5', NULL, N'游戏收益', NULL, N'玩小游戏获得收益', NULL, NULL, NULL)
INSERT [dbo].[System_Dictionary] ([DictionaryId], [Title], [Keys], [DictKey], [DictTips], [DictName], [DictValue], [DictDesc], [IsEnable], [Squence], [Remarks]) VALUES (8, N'赚钱日报（每日固定收入分类）', N'IncomeDaily', N'6', NULL, N'任务收益', NULL, N'完成平台推荐任务获得收益', NULL, NULL, NULL)
INSERT [dbo].[System_Dictionary] ([DictionaryId], [Title], [Keys], [DictKey], [DictTips], [DictName], [DictValue], [DictDesc], [IsEnable], [Squence], [Remarks]) VALUES (9, N'常见问题', N'ProblemType', N'1', NULL, N'新手问题', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[System_Dictionary] ([DictionaryId], [Title], [Keys], [DictKey], [DictTips], [DictName], [DictValue], [DictDesc], [IsEnable], [Squence], [Remarks]) VALUES (10, N'常见问题', N'ProblemType', N'2', NULL, N'青豆问题', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[System_Dictionary] ([DictionaryId], [Title], [Keys], [DictKey], [DictTips], [DictName], [DictValue], [DictDesc], [IsEnable], [Squence], [Remarks]) VALUES (11, N'常见问题', N'ProblemType', N'3', NULL, N'邀请问题', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[System_Dictionary] ([DictionaryId], [Title], [Keys], [DictKey], [DictTips], [DictName], [DictValue], [DictDesc], [IsEnable], [Squence], [Remarks]) VALUES (12, N'常见问题', N'ProblemType', N'4', NULL, N'提现问题', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[System_Dictionary] ([DictionaryId], [Title], [Keys], [DictKey], [DictTips], [DictName], [DictValue], [DictDesc], [IsEnable], [Squence], [Remarks]) VALUES (13, N'常见问题', N'ProblemType', N'5', NULL, N'账号问题', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[System_Dictionary] ([DictionaryId], [Title], [Keys], [DictKey], [DictTips], [DictName], [DictValue], [DictDesc], [IsEnable], [Squence], [Remarks]) VALUES (14, N'常见问题', N'ProblemType', N'6', NULL, N'推送问题', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[System_Dictionary] ([DictionaryId], [Title], [Keys], [DictKey], [DictTips], [DictName], [DictValue], [DictDesc], [IsEnable], [Squence], [Remarks]) VALUES (15, N'任务分类', N'TaskCategory', N'1', NULL, N'新手任务', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[System_Dictionary] ([DictionaryId], [Title], [Keys], [DictKey], [DictTips], [DictName], [DictValue], [DictDesc], [IsEnable], [Squence], [Remarks]) VALUES (16, N'任务分类', N'TaskCategory', N'2', NULL, N'每日任务', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[System_Dictionary] ([DictionaryId], [Title], [Keys], [DictKey], [DictTips], [DictName], [DictValue], [DictDesc], [IsEnable], [Squence], [Remarks]) VALUES (17, N'任务分类', N'TaskCategory', N'3', NULL, N'进阶任务', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[System_Dictionary] ([DictionaryId], [Title], [Keys], [DictKey], [DictTips], [DictName], [DictValue], [DictDesc], [IsEnable], [Squence], [Remarks]) VALUES (18, N'任务分类', N'TaskCategory', N'4', NULL, N'赚钱任务', NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[System_Dictionary] OFF
SET IDENTITY_INSERT [dbo].[System_Menu] ON 

INSERT [dbo].[System_Menu] ([MenuId], [SiteId], [MenuIcon], [MenuName], [ParentId], [NodeValue], [Areas], [Controller], [Action], [Urls], [RouterName], [RouterPath], [Component], [ShowAlways], [ShowHeader], [HideInBread], [HideInMenu], [NotCache], [BeforeCloseName], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (1, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[System_Menu] OFF
SET IDENTITY_INSERT [dbo].[System_Role] ON 

INSERT [dbo].[System_Role] ([RoleId], [RoleName], [IsEnable], [Remarks], [CreateBy], [CreateDate]) VALUES (1, N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[System_Role] ([RoleId], [RoleName], [IsEnable], [Remarks], [CreateBy], [CreateDate]) VALUES (2, N'B', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[System_Role] OFF
SET IDENTITY_INSERT [dbo].[System_Users] ON 

INSERT [dbo].[System_Users] ([UsersId], [UsersName], [LoginName], [Password], [MobilePhone], [Email], [LastLoginIp], [LastLoginTime], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (1, N'超级管理员', N'admin', N'string', NULL, NULL, N'127.0.0.1', CAST(N'2020-09-22T15:45:08.143' AS DateTime), 1, N'string', NULL, CAST(N'2020-09-22T15:45:08.143' AS DateTime))
INSERT [dbo].[System_Users] ([UsersId], [UsersName], [LoginName], [Password], [MobilePhone], [Email], [LastLoginIp], [LastLoginTime], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (2, N'string', N'string', N'string', N'string', N'string', N'string', CAST(N'2020-09-22T05:33:46.063' AS DateTime), 0, N'string', NULL, NULL)
INSERT [dbo].[System_Users] ([UsersId], [UsersName], [LoginName], [Password], [MobilePhone], [Email], [LastLoginIp], [LastLoginTime], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (3, N'', N'string', N'string', N'string', N'string', N'string', CAST(N'2020-09-22T15:45:08.143' AS DateTime), 1, N'string', NULL, NULL)
INSERT [dbo].[System_Users] ([UsersId], [UsersName], [LoginName], [Password], [MobilePhone], [Email], [LastLoginIp], [LastLoginTime], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (4, N'string', N'string', N'string', N'string', N'string', N'string', CAST(N'2020-09-22T16:08:25.240' AS DateTime), 0, N'string', NULL, NULL)
INSERT [dbo].[System_Users] ([UsersId], [UsersName], [LoginName], [Password], [MobilePhone], [Email], [LastLoginIp], [LastLoginTime], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (5, N'', N'string', N'string', N'string', N'string', N'string', CAST(N'2020-09-22T16:08:25.240' AS DateTime), 0, N'string', NULL, NULL)
INSERT [dbo].[System_Users] ([UsersId], [UsersName], [LoginName], [Password], [MobilePhone], [Email], [LastLoginIp], [LastLoginTime], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (6, N'', N'string', N'string', N'string', N'string', N'string', CAST(N'2020-09-22T16:08:25.240' AS DateTime), 0, N'string', NULL, NULL)
INSERT [dbo].[System_Users] ([UsersId], [UsersName], [LoginName], [Password], [MobilePhone], [Email], [LastLoginIp], [LastLoginTime], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (7, N'string', N'string', N'string', N'string', N'247271810@qq.com', N'string', CAST(N'2020-09-22T16:21:58.580' AS DateTime), 0, N'string', NULL, NULL)
INSERT [dbo].[System_Users] ([UsersId], [UsersName], [LoginName], [Password], [MobilePhone], [Email], [LastLoginIp], [LastLoginTime], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (8, N'123', N'133333', N'312133', N'string', N'247271810@qq.com', N'string', CAST(N'2020-09-22T16:08:25.240' AS DateTime), 0, N'string', NULL, NULL)
SET IDENTITY_INSERT [dbo].[System_Users] OFF
SET IDENTITY_INSERT [dbo].[System_UsersInMenu] ON 

INSERT [dbo].[System_UsersInMenu] ([Id], [UserId], [MenuId]) VALUES (4, 1, 1)
INSERT [dbo].[System_UsersInMenu] ([Id], [UserId], [MenuId]) VALUES (5, 1, 1)
INSERT [dbo].[System_UsersInMenu] ([Id], [UserId], [MenuId]) VALUES (6, 1, 1)
INSERT [dbo].[System_UsersInMenu] ([Id], [UserId], [MenuId]) VALUES (7, 1, 1)
SET IDENTITY_INSERT [dbo].[System_UsersInMenu] OFF
SET IDENTITY_INSERT [dbo].[System_UsersInRole] ON 

INSERT [dbo].[System_UsersInRole] ([Id], [UsersId], [RoleId]) VALUES (9, 1, 1)
INSERT [dbo].[System_UsersInRole] ([Id], [UsersId], [RoleId]) VALUES (10, 1, 2)
INSERT [dbo].[System_UsersInRole] ([Id], [UsersId], [RoleId]) VALUES (11, 1, 1)
INSERT [dbo].[System_UsersInRole] ([Id], [UsersId], [RoleId]) VALUES (12, 1, 2)
INSERT [dbo].[System_UsersInRole] ([Id], [UsersId], [RoleId]) VALUES (13, 1, 1)
INSERT [dbo].[System_UsersInRole] ([Id], [UsersId], [RoleId]) VALUES (14, 1, 2)
INSERT [dbo].[System_UsersInRole] ([Id], [UsersId], [RoleId]) VALUES (15, 1, 1)
INSERT [dbo].[System_UsersInRole] ([Id], [UsersId], [RoleId]) VALUES (16, 1, 2)
INSERT [dbo].[System_UsersInRole] ([Id], [UsersId], [RoleId]) VALUES (17, 1, 1)
INSERT [dbo].[System_UsersInRole] ([Id], [UsersId], [RoleId]) VALUES (18, 1, 2)
SET IDENTITY_INSERT [dbo].[System_UsersInRole] OFF
SET IDENTITY_INSERT [dbo].[Web_Category] ON 

INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (1, 1, N'社会', 0, N'_1_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'社会-8181资讯', N'社会', N'社会', 2, 1, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (2, 1, N'娱乐', 0, N'_2_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'娱乐-8181资讯', N'娱乐', N'娱乐', 3, 1, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (3, 1, N'游戏', 0, N'_3_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'游戏-8181资讯', N'游戏', N'游戏', 10, 1, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (4, 1, N'体育', 0, N'_4_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'体育-8181资讯', N'体育', N'体育', 4, 1, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (5, 1, N'汽车', 0, N'_5_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'汽车-8181资讯', N'汽车', N'汽车', 11, 1, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (6, 1, N'财经', 0, N'_6_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'财经-8181资讯', N'财经', N'财经', 8, 1, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (7, 1, N'搞笑', 0, N'_7_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'搞笑-8181资讯', N'搞笑', N'搞笑', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (8, 1, N'军事', 0, N'_8_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'军事-8181资讯', N'军事', N'军事', 5, 1, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (9, 1, N'国际', 0, N'_9_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'国际-8181资讯', N'国际', N'国际', 6, 1, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (10, 1, N'时尚', 0, N'_10_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'时尚-8181资讯', N'时尚', N'时尚', 7, 1, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (11, 1, N'历史', 0, N'_11_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'历史-8181资讯', N'历史', N'历史', 9, 1, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (12, 1, N'科技', 0, N'_12_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'科技-8181资讯', N'科技', N'科技', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (13, 1, N'养生', 0, N'_13_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'养生-8181资讯', N'养生', N'养生', 12, 1, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (14, 1, N'情感', 0, N'_14_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'情感-8181资讯', N'情感', N'情感', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (15, 1, N'星座', 0, N'_15_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'星座-8181资讯', N'星座', N'星座', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (16, 1, N'家居', 0, N'_16_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'家居-8181资讯', N'家居', N'家居', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (17, 1, N'城市', 0, N'_17_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'城市-8181资讯', N'城市', N'城市', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (18, 1, N'动漫', 0, N'_18_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'动漫-8181资讯', N'动漫', N'动漫', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (19, 1, N'文化', 0, N'_19_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'文化-8181资讯', N'文化', N'文化', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (20, 1, N'旅游', 0, N'_20_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'旅游-8181资讯', N'旅游', N'旅游', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (21, 1, N'动物', 0, N'_21_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'动物-8181资讯', N'动物', N'动物', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (22, 1, N'彩票', 0, N'_22_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'彩票-8181资讯', N'彩票', N'彩票', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (23, 1, N'国内', 0, N'_23_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'国内-8181资讯', N'国内', N'国内', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (24, 1, N'房产', 0, N'_24_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'房产-8181资讯', N'房产', N'房产', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (25, 1, N'美食', 0, N'_25_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'美食-8181资讯', N'美食', N'美食', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (26, 1, N'教育', 0, N'_26_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'教育-8181资讯', N'教育', N'教育', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (27, 1, N'育儿', 0, N'_27_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'育儿-8181资讯', N'育儿', N'育儿', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (28, 1, N'其他', 0, N'_28_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'其他-8181资讯', N'其他', N'其他', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (29, 1, N'说说', 0, N'_29_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'说说-8181资讯', N'说说', N'说说', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (30, 1, N'艺术', 0, N'_30_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'艺术-8181资讯', N'艺术', N'艺术', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (31, 1, N'故事', 0, N'_31_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'故事-8181资讯', N'故事', N'故事', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (32, 1, N'生活', 0, N'_32_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'生活-8181资讯', N'生活', N'生活', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (33, 1, N'辽宁', 17, N'_17_33_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'辽宁-8181资讯', N'辽宁', N'辽宁', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (34, 1, N'大连', 17, N'_17_34_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'大连-8181资讯', N'大连', N'大连', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (35, 1, N'吉林', 17, N'_17_35_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'吉林-8181资讯', N'吉林', N'吉林', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (36, 1, N'天津', 17, N'_17_36_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'天津-8181资讯', N'天津', N'天津', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (37, 1, N'河南', 17, N'_17_37_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'河南-8181资讯', N'河南', N'河南', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (38, 1, N'河北', 17, N'_17_38_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'河北-8181资讯', N'河北', N'河北', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (39, 1, N'山西', 17, N'_17_39_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'山西-8181资讯', N'山西', N'山西', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (40, 1, N'山东', 17, N'_17_40_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'山东-8181资讯', N'山东', N'山东', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (41, 1, N'青岛', 17, N'_17_41_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'青岛-8181资讯', N'青岛', N'青岛', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (42, 1, N'重庆', 17, N'_17_42_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'重庆-8181资讯', N'重庆', N'重庆', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (43, 1, N'四川', 17, N'_17_43_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'四川-8181资讯', N'四川', N'四川', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (44, 1, N'陕西', 17, N'_17_44_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'陕西-8181资讯', N'陕西', N'陕西', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (45, 1, N'湖南', 17, N'_17_45_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'湖南-8181资讯', N'湖南', N'湖南', 255, 0, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
INSERT [dbo].[Web_Category] ([CategoryId], [SiteId], [CategoryName], [ParentId], [NodeValue], [Controller], [Action], [Urls], [DocumentNumber], [AccessNumber], [ClickNumber], [Title], [Keywords], [Description], [Sequence], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (46, 1, N'推荐', 0, N'_46_', N'/Category', N'/Index', N'/Category/Index', NULL, NULL, NULL, N'推荐-8181资讯', N'推荐', N'推荐', 1, 1, NULL, 1, CAST(N'2020-10-08T23:48:33.020' AS DateTime))
SET IDENTITY_INSERT [dbo].[Web_Category] OFF
SET IDENTITY_INSERT [dbo].[Web_Site] ON 

INSERT [dbo].[Web_Site] ([SiteId], [SiteName], [SiteUrls], [LogoUrls], [AccessNumber], [Title], [Keywords], [Description], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (1, N'8181资讯', NULL, NULL, NULL, N'8181资讯', N'8181资讯', N'8181资讯', 1, N'PC、H5、移动共用文章内容信息', 1, CAST(N'2020-10-01T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Web_Site] OFF
SET IDENTITY_INSERT [dbo].[Web_Special] ON 

INSERT [dbo].[Web_Special] ([SpecialId], [SiteId], [SpecialCode], [Name], [DisplayType], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (1, 1, N'C0001', N'今日快讯', NULL, 1, NULL, 1, CAST(N'2020-10-09T00:04:47.453' AS DateTime))
INSERT [dbo].[Web_Special] ([SpecialId], [SiteId], [SpecialCode], [Name], [DisplayType], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (2, 1, N'C0002', N'今日热点', NULL, 1, NULL, 1, CAST(N'2020-10-09T00:04:47.453' AS DateTime))
INSERT [dbo].[Web_Special] ([SpecialId], [SiteId], [SpecialCode], [Name], [DisplayType], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (3, 1, N'C0003', N'今日热门', NULL, 1, NULL, 1, CAST(N'2020-10-09T00:04:47.453' AS DateTime))
INSERT [dbo].[Web_Special] ([SpecialId], [SiteId], [SpecialCode], [Name], [DisplayType], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (4, 1, N'C0004', N'图文排行', NULL, 1, NULL, 1, CAST(N'2020-10-09T00:04:47.453' AS DateTime))
INSERT [dbo].[Web_Special] ([SpecialId], [SiteId], [SpecialCode], [Name], [DisplayType], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (5, 1, N'C0005', N'实时热点', NULL, 1, NULL, 1, CAST(N'2020-10-09T00:04:47.453' AS DateTime))
INSERT [dbo].[Web_Special] ([SpecialId], [SiteId], [SpecialCode], [Name], [DisplayType], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (6, 1, N'C0006', N'头条看点', NULL, 1, NULL, 1, CAST(N'2020-10-09T00:04:47.453' AS DateTime))
INSERT [dbo].[Web_Special] ([SpecialId], [SiteId], [SpecialCode], [Name], [DisplayType], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (7, 1, N'C0007', N'热图事件', NULL, 1, NULL, 1, CAST(N'2020-10-09T00:04:47.453' AS DateTime))
INSERT [dbo].[Web_Special] ([SpecialId], [SiteId], [SpecialCode], [Name], [DisplayType], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (8, 1, N'C0008', N'推荐', NULL, 1, N'内容页右边推荐', 1, CAST(N'2020-10-09T00:04:47.453' AS DateTime))
INSERT [dbo].[Web_Special] ([SpecialId], [SiteId], [SpecialCode], [Name], [DisplayType], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (9, 1, N'C0009', N'猜你喜欢', NULL, 1, NULL, 1, CAST(N'2020-10-09T00:04:47.453' AS DateTime))
INSERT [dbo].[Web_Special] ([SpecialId], [SiteId], [SpecialCode], [Name], [DisplayType], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (10, 1, N'C0010', N'热点新闻', NULL, 1, NULL, 1, CAST(N'2020-10-09T00:04:47.453' AS DateTime))
INSERT [dbo].[Web_Special] ([SpecialId], [SiteId], [SpecialCode], [Name], [DisplayType], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (11, 1, N'C0011', N'首页轮播图', NULL, 1, N'8181资讯首页轮播图', 1, CAST(N'2020-10-09T00:04:47.453' AS DateTime))
INSERT [dbo].[Web_Special] ([SpecialId], [SiteId], [SpecialCode], [Name], [DisplayType], [IsEnable], [Remarks], [CreateBy], [CreateTime]) VALUES (12, 1, N'C0012', N'首页大标', NULL, 1, N'8181资讯首页大标', 1, CAST(N'2020-10-09T00:04:47.453' AS DateTime))
SET IDENTITY_INSERT [dbo].[Web_Special] OFF
ALTER TABLE [dbo].[Web_Category] ADD  CONSTRAINT [DF__Web_Categ__Seque__4C413C06]  DEFAULT ((255)) FOR [Sequence]
GO
ALTER TABLE [dbo].[System_RoleDictionary]  WITH CHECK ADD  CONSTRAINT [FK_SYSTEM_R_REFERENCE_SYSTEM_RC] FOREIGN KEY([RoleId])
REFERENCES [dbo].[System_Role] ([RoleId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[System_RoleDictionary] CHECK CONSTRAINT [FK_SYSTEM_R_REFERENCE_SYSTEM_RC]
GO
ALTER TABLE [dbo].[System_RoleInMenu]  WITH CHECK ADD  CONSTRAINT [FK_SYSTEM_R_REFERENCE_SYSTEM_M] FOREIGN KEY([MenuId])
REFERENCES [dbo].[System_Menu] ([MenuId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[System_RoleInMenu] CHECK CONSTRAINT [FK_SYSTEM_R_REFERENCE_SYSTEM_M]
GO
ALTER TABLE [dbo].[System_RoleInMenu]  WITH CHECK ADD  CONSTRAINT [FK_SYSTEM_R_REFERENCE_SYSTEM_R] FOREIGN KEY([RoleId])
REFERENCES [dbo].[System_Role] ([RoleId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[System_RoleInMenu] CHECK CONSTRAINT [FK_SYSTEM_R_REFERENCE_SYSTEM_R]
GO
ALTER TABLE [dbo].[System_UsersDictionary]  WITH CHECK ADD  CONSTRAINT [FK_SYSTEM_U_REFERENCE_SYSTEM_UC] FOREIGN KEY([UserId])
REFERENCES [dbo].[System_Users] ([UsersId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[System_UsersDictionary] CHECK CONSTRAINT [FK_SYSTEM_U_REFERENCE_SYSTEM_UC]
GO
ALTER TABLE [dbo].[System_UsersInMenu]  WITH CHECK ADD  CONSTRAINT [FK_SYSTEM_U_REFERENCE_SYSTEM_M] FOREIGN KEY([MenuId])
REFERENCES [dbo].[System_Menu] ([MenuId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[System_UsersInMenu] CHECK CONSTRAINT [FK_SYSTEM_U_REFERENCE_SYSTEM_M]
GO
ALTER TABLE [dbo].[System_UsersInMenu]  WITH CHECK ADD  CONSTRAINT [FK_SYSTEM_U_REFERENCE_SYSTEM_UM] FOREIGN KEY([UserId])
REFERENCES [dbo].[System_Users] ([UsersId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[System_UsersInMenu] CHECK CONSTRAINT [FK_SYSTEM_U_REFERENCE_SYSTEM_UM]
GO
ALTER TABLE [dbo].[System_UsersInRole]  WITH CHECK ADD  CONSTRAINT [FK_SYSTEM_U_REFERENCE_SYSTEM_RU] FOREIGN KEY([RoleId])
REFERENCES [dbo].[System_Role] ([RoleId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[System_UsersInRole] CHECK CONSTRAINT [FK_SYSTEM_U_REFERENCE_SYSTEM_RU]
GO
ALTER TABLE [dbo].[System_UsersInRole]  WITH CHECK ADD  CONSTRAINT [FK_SYSTEM_U_REFERENCE_SYSTEM_UU] FOREIGN KEY([UsersId])
REFERENCES [dbo].[System_Users] ([UsersId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[System_UsersInRole] CHECK CONSTRAINT [FK_SYSTEM_U_REFERENCE_SYSTEM_UU]
GO
ALTER TABLE [dbo].[Web_NewsOperate_Logs]  WITH CHECK ADD  CONSTRAINT [FK_WEB_NEWS_REFERENCE_WEB_NEWS] FOREIGN KEY([NewsId])
REFERENCES [dbo].[Web_News] ([NewsId])
GO
ALTER TABLE [dbo].[Web_NewsOperate_Logs] CHECK CONSTRAINT [FK_WEB_NEWS_REFERENCE_WEB_NEWS]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Auto_BatchInsert_NewsId', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'NewsId' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Auto_BatchInsert_NewsId', @level2type=N'COLUMN',@level2name=N'NewsId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Message' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Auto_BatchInsert_NewsId', @level2type=N'COLUMN',@level2name=N'Message'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Auto_BatchInsert_NewsId' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Auto_BatchInsert_NewsId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member_Info', @level2type=N'COLUMN',@level2name=N'MemberId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户昵称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member_Info', @level2type=N'COLUMN',@level2name=N'NickName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member_Info', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'性别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member_Info', @level2type=N'COLUMN',@level2name=N'Sex'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户手机号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member_Info', @level2type=N'COLUMN',@level2name=N'Phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'支付宝账号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member_Info', @level2type=N'COLUMN',@level2name=N'Alipay'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'微信账号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member_Info', @level2type=N'COLUMN',@level2name=N'Wechat'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'登录密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member_Info', @level2type=N'COLUMN',@level2name=N'Password'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'头像' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member_Info', @level2type=N'COLUMN',@level2name=N'Avatar'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'剩余金币' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member_Info', @level2type=N'COLUMN',@level2name=N'Beans'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'累计金币' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member_Info', @level2type=N'COLUMN',@level2name=N'BeansTotals'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最后登录时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member_Info', @level2type=N'COLUMN',@level2name=N'LastLoginTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否有效' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member_Info', @level2type=N'COLUMN',@level2name=N'IsEnbale'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member_Info', @level2type=N'COLUMN',@level2name=N'Remarks'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member_Info', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Member_Info（用户信息）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member_Info'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CategoryAccessId' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_Category_DayAccess', @level2type=N'COLUMN',@level2name=N'CategoryAccessId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分类编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_Category_DayAccess', @level2type=N'COLUMN',@level2name=N'CategoryId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分类名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_Category_DayAccess', @level2type=N'COLUMN',@level2name=N'CategoryName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'日访问数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_Category_DayAccess', @level2type=N'COLUMN',@level2name=N'Count'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'当前日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_Category_DayAccess', @level2type=N'COLUMN',@level2name=N'Today'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最后更新时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_Category_DayAccess', @level2type=N'COLUMN',@level2name=N'LastUpdateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Report_Category_DayAccess' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_Category_DayAccess'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CategoryClickId' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_Category_DayClick', @level2type=N'COLUMN',@level2name=N'CategoryClickId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分类编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_Category_DayClick', @level2type=N'COLUMN',@level2name=N'CategoryId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分类名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_Category_DayClick', @level2type=N'COLUMN',@level2name=N'CategoryName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'日点击数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_Category_DayClick', @level2type=N'COLUMN',@level2name=N'Count'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'当前日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_Category_DayClick', @level2type=N'COLUMN',@level2name=N'Today'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最后更新时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_Category_DayClick', @level2type=N'COLUMN',@level2name=N'LastUpdateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Report_Category_DayClick' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_Category_DayClick'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'NewsAccessId' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_News_DayAccess', @level2type=N'COLUMN',@level2name=N'NewsAccessId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'新闻编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_News_DayAccess', @level2type=N'COLUMN',@level2name=N'NewsId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分类编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_News_DayAccess', @level2type=N'COLUMN',@level2name=N'CategoryId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分类名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_News_DayAccess', @level2type=N'COLUMN',@level2name=N'CategoryName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'专栏代码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_News_DayAccess', @level2type=N'COLUMN',@level2name=N'SpecialCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'专栏名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_News_DayAccess', @level2type=N'COLUMN',@level2name=N'SpecialName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'日访问数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_News_DayAccess', @level2type=N'COLUMN',@level2name=N'Count'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'当前日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_News_DayAccess', @level2type=N'COLUMN',@level2name=N'Today'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最后更新时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_News_DayAccess', @level2type=N'COLUMN',@level2name=N'LastUpdateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'固化数据，里面关联其他表名称等文本数据不要随意更改' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_News_DayAccess'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'NewsClickId' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_News_DayClick', @level2type=N'COLUMN',@level2name=N'NewsClickId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'新闻编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_News_DayClick', @level2type=N'COLUMN',@level2name=N'NewsId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分类编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_News_DayClick', @level2type=N'COLUMN',@level2name=N'CategoryId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分类名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_News_DayClick', @level2type=N'COLUMN',@level2name=N'CategoryName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'专栏代码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_News_DayClick', @level2type=N'COLUMN',@level2name=N'SpecialCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'专栏名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_News_DayClick', @level2type=N'COLUMN',@level2name=N'SpecialName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'日点击数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_News_DayClick', @level2type=N'COLUMN',@level2name=N'Count'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'当前日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_News_DayClick', @level2type=N'COLUMN',@level2name=N'Today'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最后更新时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_News_DayClick', @level2type=N'COLUMN',@level2name=N'LastUpdateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'固化数据，里面关联其他表名称等文本数据不要随意更改' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_News_DayClick'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'站点访问编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_Site_DayAccess', @level2type=N'COLUMN',@level2name=N'SiteAccessId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'SiteNo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_Site_DayAccess', @level2type=N'COLUMN',@level2name=N'SiteId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'日访问数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_Site_DayAccess', @level2type=N'COLUMN',@level2name=N'Count'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'当前日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_Site_DayAccess', @level2type=N'COLUMN',@level2name=N'Today'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最后更新时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_Site_DayAccess', @level2type=N'COLUMN',@level2name=N'LastUpdateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Report_Site_DayAccess' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Report_Site_DayAccess'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DictionaryId' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Dictionary', @level2type=N'COLUMN',@level2name=N'DictionaryId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'中文说明（不参与展示）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Dictionary', @level2type=N'COLUMN',@level2name=N'Title'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Keys（用于系统筛选）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Dictionary', @level2type=N'COLUMN',@level2name=N'Keys'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'提示（特殊情况下1：1显示简短提示）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Dictionary', @level2type=N'COLUMN',@level2name=N'DictTips'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Name（数据展示）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Dictionary', @level2type=N'COLUMN',@level2name=N'DictName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Value（具体业务数据展示）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Dictionary', @level2type=N'COLUMN',@level2name=N'DictValue'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Remarks（具体业务数据描述展示）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Dictionary', @level2type=N'COLUMN',@level2name=N'DictDesc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System_Dictionary' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Dictionary'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'LogsId' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Logs', @level2type=N'COLUMN',@level2name=N'LogsId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'调用方法地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Logs', @level2type=N'COLUMN',@level2name=N'Methods'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'等级' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Logs', @level2type=N'COLUMN',@level2name=N'Grade'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'来源' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Logs', @level2type=N'COLUMN',@level2name=N'Source'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'参数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Logs', @level2type=N'COLUMN',@level2name=N'Args'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'错误信息' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Logs', @level2type=N'COLUMN',@level2name=N'Errors'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Logs', @level2type=N'COLUMN',@level2name=N'CreateBy'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Logs', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System_Logs' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Logs'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系统菜单编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Menu', @level2type=N'COLUMN',@level2name=N'MenuId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'站点唯一标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Menu', @level2type=N'COLUMN',@level2name=N'SiteId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mate菜单Icon' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Menu', @level2type=N'COLUMN',@level2name=N'MenuIcon'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mate菜单名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Menu', @level2type=N'COLUMN',@level2name=N'MenuName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'父级菜单编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Menu', @level2type=N'COLUMN',@level2name=N'ParentId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单节点值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Menu', @level2type=N'COLUMN',@level2name=N'NodeValue'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'MVC区域' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Menu', @level2type=N'COLUMN',@level2name=N'Areas'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'MVC控制器' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Menu', @level2type=N'COLUMN',@level2name=N'Controller'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'MVC动作' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Menu', @level2type=N'COLUMN',@level2name=N'Action'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'外部访问地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Menu', @level2type=N'COLUMN',@level2name=N'Urls'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'VUE路由名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Menu', @level2type=N'COLUMN',@level2name=N'RouterName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'VUE路由地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Menu', @level2type=N'COLUMN',@level2name=N'RouterPath'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'VUE组件地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Menu', @level2type=N'COLUMN',@level2name=N'Component'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mate（0，1）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Menu', @level2type=N'COLUMN',@level2name=N'ShowAlways'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mate（0，1）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Menu', @level2type=N'COLUMN',@level2name=N'ShowHeader'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mate（0，1）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Menu', @level2type=N'COLUMN',@level2name=N'HideInBread'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mate（0，1）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Menu', @level2type=N'COLUMN',@level2name=N'HideInMenu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mate（0，1）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Menu', @level2type=N'COLUMN',@level2name=N'NotCache'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mate（0，1）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Menu', @level2type=N'COLUMN',@level2name=N'BeforeCloseName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Menu', @level2type=N'COLUMN',@level2name=N'Sequence'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否有效（-1在需要逻辑删除情况下使用,0无效,1有效）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Menu', @level2type=N'COLUMN',@level2name=N'IsEnable'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'RowVers' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Menu', @level2type=N'COLUMN',@level2name=N'RowVers'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Menu', @level2type=N'COLUMN',@level2name=N'Remarks'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Menu', @level2type=N'COLUMN',@level2name=N'CreateBy'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Menu', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System_Menus(系统菜单模块)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Menu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Role', @level2type=N'COLUMN',@level2name=N'RoleId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Role', @level2type=N'COLUMN',@level2name=N'RoleName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否有效（-1在需要逻辑删除情况下使用,0无效,1有效）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Role', @level2type=N'COLUMN',@level2name=N'IsEnable'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Role', @level2type=N'COLUMN',@level2name=N'Remarks'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Role', @level2type=N'COLUMN',@level2name=N'CreateBy'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Role', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System_Role(系统角色)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Role'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_RoleDictionary', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_RoleDictionary', @level2type=N'COLUMN',@level2name=N'RoleId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'数据键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_RoleDictionary', @level2type=N'COLUMN',@level2name=N'DictionaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'数据值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_RoleDictionary', @level2type=N'COLUMN',@level2name=N'DictionaryValue'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System_RoleDictionary（角色数据权限）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_RoleDictionary'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'RoleId' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_RoleInMenu', @level2type=N'COLUMN',@level2name=N'RoleId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'MenuId' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_RoleInMenu', @level2type=N'COLUMN',@level2name=N'MenuId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System_RoleInMenu（角色对应菜单）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_RoleInMenu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Users', @level2type=N'COLUMN',@level2name=N'UsersId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'真实姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Users', @level2type=N'COLUMN',@level2name=N'UsersName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'登陆名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Users', @level2type=N'COLUMN',@level2name=N'LoginName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'登陆密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Users', @level2type=N'COLUMN',@level2name=N'Password'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'手机号码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Users', @level2type=N'COLUMN',@level2name=N'MobilePhone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Email' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Users', @level2type=N'COLUMN',@level2name=N'Email'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'登录IP' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Users', @level2type=N'COLUMN',@level2name=N'LastLoginIp'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'登录时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Users', @level2type=N'COLUMN',@level2name=N'LastLoginTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否有效' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Users', @level2type=N'COLUMN',@level2name=N'IsEnable'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Users', @level2type=N'COLUMN',@level2name=N'Remarks'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Users', @level2type=N'COLUMN',@level2name=N'CreateBy'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Users', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System_User(系统用户)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_Users'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_UsersDictionary', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_UsersDictionary', @level2type=N'COLUMN',@level2name=N'UserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'数据键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_UsersDictionary', @level2type=N'COLUMN',@level2name=N'DictionaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'数据值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_UsersDictionary', @level2type=N'COLUMN',@level2name=N'DictionaryValue'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System_UsersDictionary（用户数据权限）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_UsersDictionary'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系统用户编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_UsersInMenu', @level2type=N'COLUMN',@level2name=N'UserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系统菜单编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_UsersInMenu', @level2type=N'COLUMN',@level2name=N'MenuId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System_UsersInMenu(用户菜单权限)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_UsersInMenu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系统用户编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_UsersInRole', @level2type=N'COLUMN',@level2name=N'UsersId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系统角色编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_UsersInRole', @level2type=N'COLUMN',@level2name=N'RoleId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System_UsersInRole（用户对应角色）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_UsersInRole'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'RefreshTokenId' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_UsersRefreshToken', @level2type=N'COLUMN',@level2name=N'RefreshTokenId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'UsersId' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_UsersRefreshToken', @level2type=N'COLUMN',@level2name=N'UsersId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'AccessToken' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_UsersRefreshToken', @level2type=N'COLUMN',@level2name=N'AccessToken'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Expires' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_UsersRefreshToken', @level2type=N'COLUMN',@level2name=N'Expires'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Active' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_UsersRefreshToken', @level2type=N'COLUMN',@level2name=N'Active'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System_UsersRefreshToken' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'System_UsersRefreshToken'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'栏目编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Category', @level2type=N'COLUMN',@level2name=N'CategoryId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'站点唯一编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Category', @level2type=N'COLUMN',@level2name=N'SiteId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'栏目名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Category', @level2type=N'COLUMN',@level2name=N'CategoryName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'父级栏目编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Category', @level2type=N'COLUMN',@level2name=N'ParentId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'栏目节点值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Category', @level2type=N'COLUMN',@level2name=N'NodeValue'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'MVC控制器' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Category', @level2type=N'COLUMN',@level2name=N'Controller'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'MVC动作' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Category', @level2type=N'COLUMN',@level2name=N'Action'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'外部地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Category', @level2type=N'COLUMN',@level2name=N'Urls'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'栏目总文档数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Category', @level2type=N'COLUMN',@level2name=N'DocumentNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'栏目实际访问数（定时同步）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Category', @level2type=N'COLUMN',@level2name=N'AccessNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'栏目实际点击数（定时同步）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Category', @level2type=N'COLUMN',@level2name=N'ClickNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'栏目网站标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Category', @level2type=N'COLUMN',@level2name=N'Title'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'栏目网站关键字' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Category', @level2type=N'COLUMN',@level2name=N'Keywords'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'栏目网站描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Category', @level2type=N'COLUMN',@level2name=N'Description'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Category', @level2type=N'COLUMN',@level2name=N'Sequence'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否有效（-1在需要逻辑删除情况下使用,0无效,1有效）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Category', @level2type=N'COLUMN',@level2name=N'IsEnable'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'RowVers' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Category', @level2type=N'COLUMN',@level2name=N'RowVers'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Category', @level2type=N'COLUMN',@level2name=N'Remarks'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Category', @level2type=N'COLUMN',@level2name=N'CreateBy'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Category', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Web_Classify（前端分类）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Category'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ChannelId' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Channel', @level2type=N'COLUMN',@level2name=N'ChannelId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'SiteNo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Channel', @level2type=N'COLUMN',@level2name=N'SiteId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ChannelName' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Channel', @level2type=N'COLUMN',@level2name=N'ChannelName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ChannelAddress' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Channel', @level2type=N'COLUMN',@level2name=N'ChannelAddress'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ChannelJs' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Channel', @level2type=N'COLUMN',@level2name=N'ChannelJs'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'IsEnable' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Channel', @level2type=N'COLUMN',@level2name=N'IsEnable'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'RowVers' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Channel', @level2type=N'COLUMN',@level2name=N'RowVers'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Remarks' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Channel', @level2type=N'COLUMN',@level2name=N'Remarks'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CreateBy' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Channel', @level2type=N'COLUMN',@level2name=N'CreateBy'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CreateTime' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Channel', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Web_Channel' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Channel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'NewsOperateId' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_NewsOperate_Logs', @level2type=N'COLUMN',@level2name=N'NewsOperateId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'NewsId' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_NewsOperate_Logs', @level2type=N'COLUMN',@level2name=N'NewsId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作类型（ENewsOperateType）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_NewsOperate_Logs', @level2type=N'COLUMN',@level2name=N'OperateType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作结果，状态（ENewsOperateStatus）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_NewsOperate_Logs', @level2type=N'COLUMN',@level2name=N'OperateStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Remarks' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_NewsOperate_Logs', @level2type=N'COLUMN',@level2name=N'Remarks'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CreateBy' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_NewsOperate_Logs', @level2type=N'COLUMN',@level2name=N'CreateBy'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CreateName' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_NewsOperate_Logs', @level2type=N'COLUMN',@level2name=N'CreateName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CreateTime' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_NewsOperate_Logs', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'文章操作日志' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_NewsOperate_Logs'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'SensitiveId' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Sensitive', @level2type=N'COLUMN',@level2name=N'SensitiveId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'站点唯一标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Sensitive', @level2type=N'COLUMN',@level2name=N'SiteId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'类型Key' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Sensitive', @level2type=N'COLUMN',@level2name=N'Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'类型Value（）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Sensitive', @level2type=N'COLUMN',@level2name=N'TypeText'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'敏感词' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Sensitive', @level2type=N'COLUMN',@level2name=N'SensitiveWords'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'限制同步作者' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Sensitive', @level2type=N'COLUMN',@level2name=N'Author'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'限制同步地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Sensitive', @level2type=N'COLUMN',@level2name=N'Urls'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'RowVers' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Sensitive', @level2type=N'COLUMN',@level2name=N'RowVers'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'IsEnable' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Sensitive', @level2type=N'COLUMN',@level2name=N'IsEnable'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Remarks' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Sensitive', @level2type=N'COLUMN',@level2name=N'Remarks'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CreateBy' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Sensitive', @level2type=N'COLUMN',@level2name=N'CreateBy'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CreateTime' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Sensitive', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'敏感词' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Sensitive'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'SiteId' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Site', @level2type=N'COLUMN',@level2name=N'SiteId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'站点名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Site', @level2type=N'COLUMN',@level2name=N'SiteName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'站点域名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Site', @level2type=N'COLUMN',@level2name=N'SiteUrls'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'站点Logo地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Site', @level2type=N'COLUMN',@level2name=N'LogoUrls'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'站点总访问数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Site', @level2type=N'COLUMN',@level2name=N'AccessNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'站点网站标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Site', @level2type=N'COLUMN',@level2name=N'Title'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'站点网站关键字' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Site', @level2type=N'COLUMN',@level2name=N'Keywords'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'站点网站描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Site', @level2type=N'COLUMN',@level2name=N'Description'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'RowVers' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Site', @level2type=N'COLUMN',@level2name=N'RowVers'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'IsEnable' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Site', @level2type=N'COLUMN',@level2name=N'IsEnable'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Remarks' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Site', @level2type=N'COLUMN',@level2name=N'Remarks'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CreateBy' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Site', @level2type=N'COLUMN',@level2name=N'CreateBy'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CreateTime' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Site', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Web_Site' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Site'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'专栏编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Special', @level2type=N'COLUMN',@level2name=N'SpecialId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'站点唯一标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Special', @level2type=N'COLUMN',@level2name=N'SiteId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'专栏代码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Special', @level2type=N'COLUMN',@level2name=N'SpecialCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'专栏名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Special', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'预留' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Special', @level2type=N'COLUMN',@level2name=N'DisplayType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'IsEnable' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Special', @level2type=N'COLUMN',@level2name=N'IsEnable'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'RowVers' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Special', @level2type=N'COLUMN',@level2name=N'RowVers'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Remarks' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Special', @level2type=N'COLUMN',@level2name=N'Remarks'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CreateBy' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Special', @level2type=N'COLUMN',@level2name=N'CreateBy'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CreateTime' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Special', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'专栏管理' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Web_Special'
GO
