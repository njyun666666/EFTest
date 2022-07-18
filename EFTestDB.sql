USE [EFTestDB]
GO
/****** Object:  Table [dbo].[TbPage]    Script Date: 2022/7/18 下午 03:30:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbPage](
	[PageID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[SubTitle] [nvarchar](50) NULL,
 CONSTRAINT [PK_TbPage] PRIMARY KEY CLUSTERED 
(
	[PageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbPageSection]    Script Date: 2022/7/18 下午 03:30:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbPageSection](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PageID] [int] NOT NULL,
	[SectionID] [int] NOT NULL,
 CONSTRAINT [PK_TbPageSection] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TbPage] ON 
GO
INSERT [dbo].[TbPage] ([PageID], [Title], [SubTitle]) VALUES (1, N'Title1', NULL)
GO
INSERT [dbo].[TbPage] ([PageID], [Title], [SubTitle]) VALUES (2, N'Title2', NULL)
GO
SET IDENTITY_INSERT [dbo].[TbPage] OFF
GO
SET IDENTITY_INSERT [dbo].[TbPageSection] ON 
GO
INSERT [dbo].[TbPageSection] ([ID], [PageID], [SectionID]) VALUES (1, 1, 100)
GO
INSERT [dbo].[TbPageSection] ([ID], [PageID], [SectionID]) VALUES (2, 1, 200)
GO
INSERT [dbo].[TbPageSection] ([ID], [PageID], [SectionID]) VALUES (3, 1, 300)
GO
INSERT [dbo].[TbPageSection] ([ID], [PageID], [SectionID]) VALUES (4, 2, 102)
GO
INSERT [dbo].[TbPageSection] ([ID], [PageID], [SectionID]) VALUES (5, 2, 202)
GO
INSERT [dbo].[TbPageSection] ([ID], [PageID], [SectionID]) VALUES (6, 2, 302)
GO
SET IDENTITY_INSERT [dbo].[TbPageSection] OFF
GO
ALTER TABLE [dbo].[TbPageSection]  WITH CHECK ADD  CONSTRAINT [FK_TbPageSection_TbPage] FOREIGN KEY([PageID])
REFERENCES [dbo].[TbPage] ([PageID])
GO
ALTER TABLE [dbo].[TbPageSection] CHECK CONSTRAINT [FK_TbPageSection_TbPage]
GO
