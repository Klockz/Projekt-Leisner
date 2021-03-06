CREATE DATABASE Leisner
GO
USE [Leisner]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 09-11-2014 20:21:10 ******/
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
/****** Object:  Table [dbo].[Patient]    Script Date: 09-11-2014 20:21:10 ******/
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
/****** Object:  Table [dbo].[Questionnaire]    Script Date: 09-11-2014 20:21:10 ******/
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
/****** Object:  Table [dbo].[ToiletVisit]    Script Date: 09-11-2014 20:21:10 ******/
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
/****** Object:  Table [dbo].[WetBed]    Script Date: 09-11-2014 20:21:10 ******/
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
INSERT [dbo].[Customer] ([Id], [Email], [Name], [CustomerNo], [PhoneNo]) VALUES (5, N'hans@dk.dk', N'Hans', 5, 67891234)
INSERT [dbo].[Customer] ([Id], [Email], [Name], [CustomerNo], [PhoneNo]) VALUES (6, N'mikkel@mail.dk', N'Mikkel Jørgensen', 10, 33431230)
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Patient] ON 

INSERT [dbo].[Patient] ([Id], [Name], [Age], [Customer]) VALUES (1, N'Louise', 9, 1)
INSERT [dbo].[Patient] ([Id], [Name], [Age], [Customer]) VALUES (2, N'Laura', 7, 1)
INSERT [dbo].[Patient] ([Id], [Name], [Age], [Customer]) VALUES (3, N'Lone', 12, 2)
INSERT [dbo].[Patient] ([Id], [Name], [Age], [Customer]) VALUES (4, N'Lars', 15, 3)
INSERT [dbo].[Patient] ([Id], [Name], [Age], [Customer]) VALUES (5, N'Tchad', 8, 4)
INSERT [dbo].[Patient] ([Id], [Name], [Age], [Customer]) VALUES (6, N'Vigga', 12, 5)
INSERT [dbo].[Patient] ([Id], [Name], [Age], [Customer]) VALUES (7, N'Jesper', 8, 6)
SET IDENTITY_INSERT [dbo].[Patient] OFF
SET IDENTITY_INSERT [dbo].[Questionnaire] ON 

INSERT [dbo].[Questionnaire] ([Id], [Date], [Motivation], [Comment], [PleaseContact], [Patient]) VALUES (1, CAST(0x2A390B00 AS Date), 3, N'Ikke meget motiveret', 0, 1)
INSERT [dbo].[Questionnaire] ([Id], [Date], [Motivation], [Comment], [PleaseContact], [Patient]) VALUES (2, CAST(0x05390B00 AS Date), 10, N'Megt glad', 1, 2)
INSERT [dbo].[Questionnaire] ([Id], [Date], [Motivation], [Comment], [PleaseContact], [Patient]) VALUES (3, CAST(0x1F390B00 AS Date), 1, N'Rigtig ked af det', 0, 3)
INSERT [dbo].[Questionnaire] ([Id], [Date], [Motivation], [Comment], [PleaseContact], [Patient]) VALUES (4, CAST(0xA7360B00 AS Date), 6, N'En meget stor plet', 1, 4)
INSERT [dbo].[Questionnaire] ([Id], [Date], [Motivation], [Comment], [PleaseContact], [Patient]) VALUES (5, CAST(0x66330B00 AS Date), 5, N'En meget lille plet', 0, 5)
INSERT [dbo].[Questionnaire] ([Id], [Date], [Motivation], [Comment], [PleaseContact], [Patient]) VALUES (6, CAST(0x20390B00 AS Date), 5, N'I bedre humør', 0, 3)
INSERT [dbo].[Questionnaire] ([Id], [Date], [Motivation], [Comment], [PleaseContact], [Patient]) VALUES (7, CAST(0x21390B00 AS Date), 1, N'Helt galt!', 0, 3)
INSERT [dbo].[Questionnaire] ([Id], [Date], [Motivation], [Comment], [PleaseContact], [Patient]) VALUES (8, CAST(0x22390B00 AS Date), 7, N'Tilbage på hesten', 0, 3)
INSERT [dbo].[Questionnaire] ([Id], [Date], [Motivation], [Comment], [PleaseContact], [Patient]) VALUES (9, CAST(0x1D390B00 AS Date), 10, N'Hun er bare så glad', 0, 2)
INSERT [dbo].[Questionnaire] ([Id], [Date], [Motivation], [Comment], [PleaseContact], [Patient]) VALUES (10, CAST(0x66330B00 AS Date), 5, N'', 0, 1)
INSERT [dbo].[Questionnaire] ([Id], [Date], [Motivation], [Comment], [PleaseContact], [Patient]) VALUES (11, CAST(0x39390B00 AS Date), 4, N'Her til morgen synes han ikke det er sjovt', 0, 7)
SET IDENTITY_INSERT [dbo].[Questionnaire] OFF
SET IDENTITY_INSERT [dbo].[ToiletVisit] ON 

INSERT [dbo].[ToiletVisit] ([Id], [Time], [Questionnaire]) VALUES (1, CAST(0x2A390B00 AS Date), 1)
INSERT [dbo].[ToiletVisit] ([Id], [Time], [Questionnaire]) VALUES (2, CAST(0x1F390B00 AS Date), 3)
INSERT [dbo].[ToiletVisit] ([Id], [Time], [Questionnaire]) VALUES (3, CAST(0x1F390B00 AS Date), 3)
INSERT [dbo].[ToiletVisit] ([Id], [Time], [Questionnaire]) VALUES (4, CAST(0x1F390B00 AS Date), 3)
INSERT [dbo].[ToiletVisit] ([Id], [Time], [Questionnaire]) VALUES (5, CAST(0x20390B00 AS Date), 6)
INSERT [dbo].[ToiletVisit] ([Id], [Time], [Questionnaire]) VALUES (6, CAST(0x21390B00 AS Date), 6)
INSERT [dbo].[ToiletVisit] ([Id], [Time], [Questionnaire]) VALUES (7, CAST(0x21390B00 AS Date), 3)
INSERT [dbo].[ToiletVisit] ([Id], [Time], [Questionnaire]) VALUES (9, CAST(0x22390B00 AS Date), 8)
INSERT [dbo].[ToiletVisit] ([Id], [Time], [Questionnaire]) VALUES (10, CAST(0x23390B00 AS Date), 7)
INSERT [dbo].[ToiletVisit] ([Id], [Time], [Questionnaire]) VALUES (11, CAST(0x1D390B00 AS Date), 9)
SET IDENTITY_INSERT [dbo].[ToiletVisit] OFF
SET IDENTITY_INSERT [dbo].[WetBed] ON 

INSERT [dbo].[WetBed] ([Id], [Size], [Time], [Questionnaire]) VALUES (1, N'M', CAST(0x05390B00 AS Date), 2)
INSERT [dbo].[WetBed] ([Id], [Size], [Time], [Questionnaire]) VALUES (2, N'XL', CAST(0xA7360B00 AS Date), 4)
INSERT [dbo].[WetBed] ([Id], [Size], [Time], [Questionnaire]) VALUES (3, N'XS', CAST(0x66330B00 AS Date), 5)
INSERT [dbo].[WetBed] ([Id], [Size], [Time], [Questionnaire]) VALUES (4, N'M', CAST(0x1F390B00 AS Date), 3)
INSERT [dbo].[WetBed] ([Id], [Size], [Time], [Questionnaire]) VALUES (5, N'L', CAST(0x1F390B00 AS Date), 3)
INSERT [dbo].[WetBed] ([Id], [Size], [Time], [Questionnaire]) VALUES (6, N'M', CAST(0x20390B00 AS Date), 6)
INSERT [dbo].[WetBed] ([Id], [Size], [Time], [Questionnaire]) VALUES (7, N'S', CAST(0x21390B00 AS Date), 7)
INSERT [dbo].[WetBed] ([Id], [Size], [Time], [Questionnaire]) VALUES (8, N'M', CAST(0x21390B00 AS Date), 7)
INSERT [dbo].[WetBed] ([Id], [Size], [Time], [Questionnaire]) VALUES (9, N'S', CAST(0x21390B00 AS Date), 7)
INSERT [dbo].[WetBed] ([Id], [Size], [Time], [Questionnaire]) VALUES (10, N'XL', CAST(0x22390B00 AS Date), 8)
INSERT [dbo].[WetBed] ([Id], [Size], [Time], [Questionnaire]) VALUES (11, N'S', CAST(0x21390B00 AS Date), 7)
INSERT [dbo].[WetBed] ([Id], [Size], [Time], [Questionnaire]) VALUES (12, N'M', CAST(0x21390B00 AS Date), 7)
INSERT [dbo].[WetBed] ([Id], [Size], [Time], [Questionnaire]) VALUES (13, N'M', CAST(0x22390B00 AS Date), 7)
INSERT [dbo].[WetBed] ([Id], [Size], [Time], [Questionnaire]) VALUES (14, N'L', CAST(0x39390B00 AS Date), 11)
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
