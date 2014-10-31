USE [leisner]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 31-10-2014 09:35:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](400) NOT NULL,
	[Name] [nvarchar](400) NOT NULL,
	[CustomerNo] [int] NOT NULL,
	[PhoneNo] [int] NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Patient]    Script Date: 31-10-2014 09:35:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Age] [int] NOT NULL,
	[Customer] [int] NOT NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Questionnaire]    Script Date: 31-10-2014 09:35:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questionnaire](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[Motivation] [int] NOT NULL,
	[Comment] [nvarchar](400) NOT NULL,
	[PleaseContact] [bit] NOT NULL,
	[Patient] [int] NOT NULL,
 CONSTRAINT [PK_Questionnaire] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ToiletVisit]    Script Date: 31-10-2014 09:35:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ToiletVisit](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Time] [date] NOT NULL,
	[Questionnaire] [int] NOT NULL,
 CONSTRAINT [PK_ToiletVisit] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WetBed]    Script Date: 31-10-2014 09:35:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WetBed](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Size] [nvarchar](50) NOT NULL,
	[Time] [date] NOT NULL,
	[Questionnaire] [int] NOT NULL,
 CONSTRAINT [PK_WetBed] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([Id], [Email], [Name], [CustomerNo], [PhoneNo]) VALUES (1, N'Jens@Jens.dk', N'Jens Jensen', 1, 12345678)
INSERT [dbo].[Customer] ([Id], [Email], [Name], [CustomerNo], [PhoneNo]) VALUES (2, N'Peter@Peter.dk', N'Peter Petersen', 2, 23456789)
INSERT [dbo].[Customer] ([Id], [Email], [Name], [CustomerNo], [PhoneNo]) VALUES (3, N'Troels@Troels.dk', N'Troels Troelsen', 3, 34567891)
INSERT [dbo].[Customer] ([Id], [Email], [Name], [CustomerNo], [PhoneNo]) VALUES (4, N'Lasse@Lasse.dk', N'Lasse Lassen', 4, 45678910)
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Patient] ON 

INSERT [dbo].[Patient] ([Id], [Name], [Age], [Customer]) VALUES (1, N'Louise', 9, 1)
INSERT [dbo].[Patient] ([Id], [Name], [Age], [Customer]) VALUES (2, N'Laura', 7, 1)
INSERT [dbo].[Patient] ([Id], [Name], [Age], [Customer]) VALUES (3, N'Lone', 12, 2)
INSERT [dbo].[Patient] ([Id], [Name], [Age], [Customer]) VALUES (4, N'Lars', 15, 3)
INSERT [dbo].[Patient] ([Id], [Name], [Age], [Customer]) VALUES (5, N'Tchad', 8, 4)
SET IDENTITY_INSERT [dbo].[Patient] OFF
SET IDENTITY_INSERT [dbo].[Questionnaire] ON 

INSERT [dbo].[Questionnaire] ([Id], [Date], [Motivation], [Comment], [PleaseContact], [Patient]) VALUES (1, CAST(N'2014-10-25' AS Date), 3, N'Virker motiveret', 0, 1)
INSERT [dbo].[Questionnaire] ([Id], [Date], [Motivation], [Comment], [PleaseContact], [Patient]) VALUES (2, CAST(N'2014-09-18' AS Date), 10, N'so bad', 1, 2)
INSERT [dbo].[Questionnaire] ([Id], [Date], [Motivation], [Comment], [PleaseContact], [Patient]) VALUES (3, CAST(N'2014-10-14' AS Date), 1, N'Rigtig dygtig', 0, 3)
INSERT [dbo].[Questionnaire] ([Id], [Date], [Motivation], [Comment], [PleaseContact], [Patient]) VALUES (4, CAST(N'2013-01-20' AS Date), 1, N'blahblah', 1, 4)
INSERT [dbo].[Questionnaire] ([Id], [Date], [Motivation], [Comment], [PleaseContact], [Patient]) VALUES (5, CAST(N'2010-10-10' AS Date), 5, N'mediocre', 0, 5)
SET IDENTITY_INSERT [dbo].[Questionnaire] OFF
SET IDENTITY_INSERT [dbo].[ToiletVisit] ON 

INSERT [dbo].[ToiletVisit] ([Id], [Time], [Questionnaire]) VALUES (1, CAST(N'2014-10-25' AS Date), 1)
INSERT [dbo].[ToiletVisit] ([Id], [Time], [Questionnaire]) VALUES (2, CAST(N'2014-10-14' AS Date), 3)
SET IDENTITY_INSERT [dbo].[ToiletVisit] OFF
SET IDENTITY_INSERT [dbo].[WetBed] ON 

INSERT [dbo].[WetBed] ([Id], [Size], [Time], [Questionnaire]) VALUES (1, N'M', CAST(N'2014-09-18' AS Date), 2)
INSERT [dbo].[WetBed] ([Id], [Size], [Time], [Questionnaire]) VALUES (2, N'XL', CAST(N'2013-01-20' AS Date), 4)
INSERT [dbo].[WetBed] ([Id], [Size], [Time], [Questionnaire]) VALUES (3, N'XS', CAST(N'2010-10-10' AS Date), 5)
SET IDENTITY_INSERT [dbo].[WetBed] OFF
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Customer] FOREIGN KEY([Customer])
REFERENCES [dbo].[Customer] ([Id])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_Customer]
GO
ALTER TABLE [dbo].[Questionnaire]  WITH CHECK ADD  CONSTRAINT [FK_Questionnaire_Patient] FOREIGN KEY([Patient])
REFERENCES [dbo].[Patient] ([Id])
GO
ALTER TABLE [dbo].[Questionnaire] CHECK CONSTRAINT [FK_Questionnaire_Patient]
GO
ALTER TABLE [dbo].[ToiletVisit]  WITH CHECK ADD  CONSTRAINT [FK_ToiletVisit_Questionnaire] FOREIGN KEY([Questionnaire])
REFERENCES [dbo].[Questionnaire] ([Id])
GO
ALTER TABLE [dbo].[ToiletVisit] CHECK CONSTRAINT [FK_ToiletVisit_Questionnaire]
GO
ALTER TABLE [dbo].[WetBed]  WITH CHECK ADD  CONSTRAINT [FK_WetBed_Questionnaire] FOREIGN KEY([Questionnaire])
REFERENCES [dbo].[Questionnaire] ([Id])
GO
ALTER TABLE [dbo].[WetBed] CHECK CONSTRAINT [FK_WetBed_Questionnaire]
GO
