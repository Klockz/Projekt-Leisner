USE [leisner]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 29-10-2014 10:30:19 ******/
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
/****** Object:  Table [dbo].[Patient]    Script Date: 29-10-2014 10:30:19 ******/
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
/****** Object:  Table [dbo].[Questionnarie]    Script Date: 29-10-2014 10:30:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questionnarie](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[Motivation] [int] NOT NULL,
	[Comment] [nvarchar](400) NOT NULL,
	[PleaseContact] [bit] NOT NULL,
	[Patient] [int] NOT NULL,
 CONSTRAINT [PK_Questionnarie] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ToiletVisit]    Script Date: 29-10-2014 10:30:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ToiletVisit](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Time] [date] NOT NULL,
	[Questionnarie] [int] NOT NULL,
 CONSTRAINT [PK_ToiletVisit] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WetBed]    Script Date: 29-10-2014 10:30:19 ******/
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
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Customer] FOREIGN KEY([Customer])
REFERENCES [dbo].[Customer] ([Id])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_Customer]
GO
ALTER TABLE [dbo].[Questionnarie]  WITH CHECK ADD  CONSTRAINT [FK_Questionnarie_Patient] FOREIGN KEY([Patient])
REFERENCES [dbo].[Patient] ([Id])
GO
ALTER TABLE [dbo].[Questionnarie] CHECK CONSTRAINT [FK_Questionnarie_Patient]
GO
ALTER TABLE [dbo].[ToiletVisit]  WITH CHECK ADD  CONSTRAINT [FK_ToiletVisit_Questionnarie] FOREIGN KEY([Questionnarie])
REFERENCES [dbo].[Questionnarie] ([Id])
GO
ALTER TABLE [dbo].[ToiletVisit] CHECK CONSTRAINT [FK_ToiletVisit_Questionnarie]
GO
ALTER TABLE [dbo].[WetBed]  WITH CHECK ADD  CONSTRAINT [FK_WetBed_Questionnarie] FOREIGN KEY([Questionnaire])
REFERENCES [dbo].[Questionnarie] ([Id])
GO
ALTER TABLE [dbo].[WetBed] CHECK CONSTRAINT [FK_WetBed_Questionnarie]
GO
