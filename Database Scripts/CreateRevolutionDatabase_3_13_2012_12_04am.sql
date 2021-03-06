USE [master]
GO
/****** Object:  Database [Revolution]    Script Date: 03/13/2012 00:05:43 ******/
CREATE DATABASE [Revolution] ON  PRIMARY 
( NAME = N'Revolution', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\Revolution.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Revolution_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\Revolution_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Revolution] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Revolution].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Revolution] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Revolution] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Revolution] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Revolution] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Revolution] SET ARITHABORT OFF
GO
ALTER DATABASE [Revolution] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Revolution] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Revolution] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Revolution] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Revolution] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Revolution] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Revolution] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Revolution] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Revolution] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Revolution] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Revolution] SET  DISABLE_BROKER
GO
ALTER DATABASE [Revolution] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Revolution] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Revolution] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Revolution] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Revolution] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Revolution] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Revolution] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Revolution] SET  READ_WRITE
GO
ALTER DATABASE [Revolution] SET RECOVERY SIMPLE
GO
ALTER DATABASE [Revolution] SET  MULTI_USER
GO
ALTER DATABASE [Revolution] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Revolution] SET DB_CHAINING OFF
GO
USE [Revolution]
GO
/****** Object:  Table [dbo].[Topic]    Script Date: 03/13/2012 00:05:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Topic](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [text] NOT NULL,
 CONSTRAINT [PK_Topic] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Topic] ON
INSERT [dbo].[Topic] ([ID], [Name], [Description]) VALUES (1, N'Idle Chat', N'No conversation started.')
INSERT [dbo].[Topic] ([ID], [Name], [Description]) VALUES (2, N'Threat', N'A threat in the environment.')
INSERT [dbo].[Topic] ([ID], [Name], [Description]) VALUES (5, N'Occupation', N'Conversations about one of the character''s occupation.')
INSERT [dbo].[Topic] ([ID], [Name], [Description]) VALUES (6, N'Quest', N'Conversations about a quest.')
SET IDENTITY_INSERT [dbo].[Topic] OFF
/****** Object:  Table [dbo].[ScopeNodeType]    Script Date: 03/13/2012 00:05:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScopeNodeType](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_ScopeNodeType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ScopeNodeType] ON
INSERT [dbo].[ScopeNodeType] ([ID], [Name], [Deleted]) VALUES (1, N'Region', 0)
INSERT [dbo].[ScopeNodeType] ([ID], [Name], [Deleted]) VALUES (2, N'Town', 0)
INSERT [dbo].[ScopeNodeType] ([ID], [Name], [Deleted]) VALUES (3, N'Group', 0)
INSERT [dbo].[ScopeNodeType] ([ID], [Name], [Deleted]) VALUES (4, N'Character', 0)
SET IDENTITY_INSERT [dbo].[ScopeNodeType] OFF
/****** Object:  Table [dbo].[PersonalityTypeType]    Script Date: 03/13/2012 00:05:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonalityTypeType](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [text] NOT NULL,
 CONSTRAINT [PK_PersonalityTypeType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PersonalityTypeType] ON
INSERT [dbo].[PersonalityTypeType] ([ID], [Name], [Description]) VALUES (1, N'Static', N'This is a permanant feature of this character.  It does not change over time.')
INSERT [dbo].[PersonalityTypeType] ([ID], [Name], [Description]) VALUES (2, N'Volatile', N'This is a highly variable part of a personality.  It is highly subject to the environment.')
INSERT [dbo].[PersonalityTypeType] ([ID], [Name], [Description]) VALUES (3, N'Sticky', N'This is a personality trait that is hard to change, but when it does, it changes significatly.')
INSERT [dbo].[PersonalityTypeType] ([ID], [Name], [Description]) VALUES (4, N'Mud', N'This personality trait moves, but is resistant to change.')
SET IDENTITY_INSERT [dbo].[PersonalityTypeType] OFF
/****** Object:  Table [dbo].[PersonalityType]    Script Date: 03/13/2012 00:05:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonalityType](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](1000) NOT NULL,
	[TypeID] [int] NOT NULL,
 CONSTRAINT [PK_PersonalityType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PersonalityType] ON
INSERT [dbo].[PersonalityType] ([ID], [Name], [Description], [TypeID]) VALUES (1, N'Extrovertedness', N'This trait determines how likely the character is to talk to you.  Also, generally how outgoing they are.  Low: Introvertedness', 1)
INSERT [dbo].[PersonalityType] ([ID], [Name], [Description], [TypeID]) VALUES (2, N'Hunger', N'This trait determines how hungry the character is.  Low:  Not Hungry', 2)
INSERT [dbo].[PersonalityType] ([ID], [Name], [Description], [TypeID]) VALUES (3, N'Bravery', N'This trait determines how likely the character is to pick a fight or stand up for itself.  Low: Cowardly', 3)
INSERT [dbo].[PersonalityType] ([ID], [Name], [Description], [TypeID]) VALUES (4, N'Observant', N'This trait determines how aware of the world around them a character is.  Low:  Oblivious', 4)
INSERT [dbo].[PersonalityType] ([ID], [Name], [Description], [TypeID]) VALUES (5, N'Wealth', N'This trait determines how concerned a character is with obtaining wealth.  Low:  Little regard for personal wealth.', 4)
INSERT [dbo].[PersonalityType] ([ID], [Name], [Description], [TypeID]) VALUES (6, N'Thirst', N'This trait determines how thirsty the character is.  Low:  Not Thirsty', 2)
INSERT [dbo].[PersonalityType] ([ID], [Name], [Description], [TypeID]) VALUES (7, N'Tired', N'This trait determines how tired the character is.  Low:  Not Tired', 2)
INSERT [dbo].[PersonalityType] ([ID], [Name], [Description], [TypeID]) VALUES (8, N'Impulsive', N'This trait determines how impulsive the character is.  Low:  Deliberate', 1)
INSERT [dbo].[PersonalityType] ([ID], [Name], [Description], [TypeID]) VALUES (9, N'Short-term Memory', N'This trait determines how good the character''s short-term memory is.  Low:  Not much sticks', 1)
INSERT [dbo].[PersonalityType] ([ID], [Name], [Description], [TypeID]) VALUES (10, N'Long-term Memory', N'This trait determines how good the character''s long-term memory is.  Low:  Not much of what goes past short-term sticks', 1)
INSERT [dbo].[PersonalityType] ([ID], [Name], [Description], [TypeID]) VALUES (11, N'Goal Oriented', N'This trait determines how goal oriented a charcter is.  How well they create and execute goals.  Low:  Lives in the moment', 1)
SET IDENTITY_INSERT [dbo].[PersonalityType] OFF
/****** Object:  Table [dbo].[ScopeNode]    Script Date: 03/13/2012 00:05:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScopeNode](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ScopeNodeTypeID] [int] NOT NULL,
	[ScopeObjectID] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_ScopeNode] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ScopeNode] ON
INSERT [dbo].[ScopeNode] ([ID], [ScopeNodeTypeID], [ScopeObjectID], [Deleted]) VALUES (1, 1, 1, 0)
INSERT [dbo].[ScopeNode] ([ID], [ScopeNodeTypeID], [ScopeObjectID], [Deleted]) VALUES (2, 2, 1, 0)
INSERT [dbo].[ScopeNode] ([ID], [ScopeNodeTypeID], [ScopeObjectID], [Deleted]) VALUES (3, 3, 1, 0)
INSERT [dbo].[ScopeNode] ([ID], [ScopeNodeTypeID], [ScopeObjectID], [Deleted]) VALUES (4, 4, 3, 0)
SET IDENTITY_INSERT [dbo].[ScopeNode] OFF
/****** Object:  Table [dbo].[Phrase]    Script Date: 03/13/2012 00:05:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phrase](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Immediacy] [int] NOT NULL,
	[Text] [ntext] NOT NULL,
	[IsQuestion] [bit] NOT NULL,
	[IsSpontaneous] [bit] NOT NULL,
	[TopicID] [int] NOT NULL,
 CONSTRAINT [PK_Phrase] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Phrase] ON
INSERT [dbo].[Phrase] ([ID], [Immediacy], [Text], [IsQuestion], [IsSpontaneous], [TopicID]) VALUES (1, 8, N'{diety~exasperation}, I''m hungry!', 0, 1, 1)
INSERT [dbo].[Phrase] ([ID], [Immediacy], [Text], [IsQuestion], [IsSpontaneous], [TopicID]) VALUES (4, 10, N'Those {threat~plural~any} don''t scare me.', 0, 1, 1)
INSERT [dbo].[Phrase] ([ID], [Immediacy], [Text], [IsQuestion], [IsSpontaneous], [TopicID]) VALUES (5, 4, N'Have you heard about {threat~immediate}?', 1, 1, 2)
INSERT [dbo].[Phrase] ([ID], [Immediacy], [Text], [IsQuestion], [IsSpontaneous], [TopicID]) VALUES (6, 2, N'I really need {item~immediate}.', 1, 1, 5)
INSERT [dbo].[Phrase] ([ID], [Immediacy], [Text], [IsQuestion], [IsSpontaneous], [TopicID]) VALUES (7, 1, N'RUN FOR YOUR LIFE!!!', 0, 1, 1)
INSERT [dbo].[Phrase] ([ID], [Immediacy], [Text], [IsQuestion], [IsSpontaneous], [TopicID]) VALUES (8, 2, N'Can I interest you in {quest~immediate}?', 1, 1, 6)
INSERT [dbo].[Phrase] ([ID], [Immediacy], [Text], [IsQuestion], [IsSpontaneous], [TopicID]) VALUES (9, 7, N'How are you?', 1, 1, 1)
INSERT [dbo].[Phrase] ([ID], [Immediacy], [Text], [IsQuestion], [IsSpontaneous], [TopicID]) VALUES (10, 8, N'Can you feel that?  Feels like rain.', 1, 1, 1)
INSERT [dbo].[Phrase] ([ID], [Immediacy], [Text], [IsQuestion], [IsSpontaneous], [TopicID]) VALUES (11, 8, N'Thank {diety} you''re safe.', 0, 1, 1)
INSERT [dbo].[Phrase] ([ID], [Immediacy], [Text], [IsQuestion], [IsSpontaneous], [TopicID]) VALUES (13, 4, N'How is it going with {quest~owned}?', 1, 1, 6)
INSERT [dbo].[Phrase] ([ID], [Immediacy], [Text], [IsQuestion], [IsSpontaneous], [TopicID]) VALUES (14, 5, N'You look like a {gender} who could {quest~any}...', 1, 1, 6)
INSERT [dbo].[Phrase] ([ID], [Immediacy], [Text], [IsQuestion], [IsSpontaneous], [TopicID]) VALUES (16, 3, N'Alms for the poor?', 1, 1, 5)
INSERT [dbo].[Phrase] ([ID], [Immediacy], [Text], [IsQuestion], [IsSpontaneous], [TopicID]) VALUES (18, 10, N'Those {threat~immediate} scare me.', 0, 1, 2)
INSERT [dbo].[Phrase] ([ID], [Immediacy], [Text], [IsQuestion], [IsSpontaneous], [TopicID]) VALUES (19, 3, N'Do you have {item~immediate}?', 1, 1, 5)
INSERT [dbo].[Phrase] ([ID], [Immediacy], [Text], [IsQuestion], [IsSpontaneous], [TopicID]) VALUES (20, 2, N'Would you be interested in {item~any}?', 1, 1, 5)
INSERT [dbo].[Phrase] ([ID], [Immediacy], [Text], [IsQuestion], [IsSpontaneous], [TopicID]) VALUES (23, 6, N'Have you heard about {threat~distant}?', 1, 1, 6)
INSERT [dbo].[Phrase] ([ID], [Immediacy], [Text], [IsQuestion], [IsSpontaneous], [TopicID]) VALUES (24, 2, N'I don''t really know you.', 0, 0, 1)
SET IDENTITY_INSERT [dbo].[Phrase] OFF
/****** Object:  Table [dbo].[Town]    Script Date: 03/13/2012 00:05:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Town](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
	[ScopeNodeID] [int] NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Town] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Town] ON
INSERT [dbo].[Town] ([ID], [Name], [Description], [ScopeNodeID], [Deleted]) VALUES (1, N'Midgar', N'City of Midgar', 2, 0)
SET IDENTITY_INSERT [dbo].[Town] OFF
/****** Object:  Table [dbo].[Character]    Script Date: 03/13/2012 00:05:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Character](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[Gender] [bit] NOT NULL,
	[NPC] [bit] NOT NULL,
	[ScopeNodeID] [int] NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Character] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Character] ON
INSERT [dbo].[Character] ([ID], [FirstName], [LastName], [Gender], [NPC], [ScopeNodeID], [Deleted]) VALUES (1, N'Rhodan', N'Dhall', 1, 1, NULL, 0)
INSERT [dbo].[Character] ([ID], [FirstName], [LastName], [Gender], [NPC], [ScopeNodeID], [Deleted]) VALUES (2, N'Daina', N'Cross3', 0, 1, NULL, 0)
INSERT [dbo].[Character] ([ID], [FirstName], [LastName], [Gender], [NPC], [ScopeNodeID], [Deleted]) VALUES (3, N'John', N'Reppy', 1, 1, 4, 0)
INSERT [dbo].[Character] ([ID], [FirstName], [LastName], [Gender], [NPC], [ScopeNodeID], [Deleted]) VALUES (4, N'Rep', N'Seeker', 0, 0, NULL, 0)
SET IDENTITY_INSERT [dbo].[Character] OFF
/****** Object:  Table [dbo].[ScopeNodeChildParent]    Script Date: 03/13/2012 00:05:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScopeNodeChildParent](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ParentID] [int] NOT NULL,
	[ChildID] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_ScopeNodeChildParent] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ScopeNodeChildParent] ON
INSERT [dbo].[ScopeNodeChildParent] ([ID], [ParentID], [ChildID], [Deleted]) VALUES (1, 1, 2, 0)
INSERT [dbo].[ScopeNodeChildParent] ([ID], [ParentID], [ChildID], [Deleted]) VALUES (2, 2, 3, 0)
INSERT [dbo].[ScopeNodeChildParent] ([ID], [ParentID], [ChildID], [Deleted]) VALUES (3, 3, 4, 0)
SET IDENTITY_INSERT [dbo].[ScopeNodeChildParent] OFF
/****** Object:  Table [dbo].[Region]    Script Date: 03/13/2012 00:05:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Region](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
	[ScopeNodeID] [int] NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Region] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Region] ON
INSERT [dbo].[Region] ([ID], [Name], [Description], [ScopeNodeID], [Deleted]) VALUES (1, N'Geldar', N'Kingdom of Geldar', 1, 0)
SET IDENTITY_INSERT [dbo].[Region] OFF
/****** Object:  Table [dbo].[PersonalityPhrase]    Script Date: 03/13/2012 00:05:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonalityPhrase](
	[PhraseID] [int] NOT NULL,
	[PersonalityTypeID] [int] NOT NULL,
	[PersonalityRating] [int] NOT NULL,
	[RatingIsGreater] [bit] NOT NULL,
 CONSTRAINT [PK_PersonalityPhrase] PRIMARY KEY CLUSTERED 
(
	[PhraseID] ASC,
	[PersonalityTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (1, 1, 5, 1)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (1, 2, 7, 1)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (4, 1, 6, 1)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (4, 3, 8, 1)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (4, 4, 4, 1)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (5, 1, 6, 1)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (5, 3, 6, 0)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (5, 4, 5, 1)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (6, 1, 3, 1)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (6, 5, 4, 1)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (7, 3, 8, 0)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (7, 4, 4, 1)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (8, 1, 5, 1)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (8, 3, 8, 0)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (8, 5, 7, 1)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (9, 1, 4, 1)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (9, 4, 3, 1)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (10, 1, 5, 1)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (10, 4, 9, 1)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (11, 1, 4, 1)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (11, 4, 6, 1)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (13, 1, 0, 1)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (14, 1, 3, 1)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (14, 3, 9, 0)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (14, 4, 7, 1)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (14, 5, 7, 1)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (20, 1, 4, 1)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (20, 4, 4, 1)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (20, 5, 8, 0)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (23, 1, 2, 1)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (23, 4, 9, 1)
INSERT [dbo].[PersonalityPhrase] ([PhraseID], [PersonalityTypeID], [PersonalityRating], [RatingIsGreater]) VALUES (24, 1, 6, 0)
/****** Object:  Table [dbo].[Group]    Script Date: 03/13/2012 00:05:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
	[ScopeNodeID] [int] NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Group] ON
INSERT [dbo].[Group] ([ID], [Name], [Description], [ScopeNodeID], [Deleted]) VALUES (1, N'Thieves Guild', N'Guild of Thieves', 3, 0)
SET IDENTITY_INSERT [dbo].[Group] OFF
/****** Object:  Table [dbo].[CharacterPersonality]    Script Date: 03/13/2012 00:05:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CharacterPersonality](
	[CharacterID] [int] NOT NULL,
	[PersonalityTypeID] [int] NOT NULL,
	[Rating] [int] NOT NULL,
 CONSTRAINT [PK_CharacterPersonality] PRIMARY KEY CLUSTERED 
(
	[CharacterID] ASC,
	[PersonalityTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CharacterPersonality] ([CharacterID], [PersonalityTypeID], [Rating]) VALUES (1, 1, 89)
INSERT [dbo].[CharacterPersonality] ([CharacterID], [PersonalityTypeID], [Rating]) VALUES (1, 2, 1)
INSERT [dbo].[CharacterPersonality] ([CharacterID], [PersonalityTypeID], [Rating]) VALUES (1, 3, 90)
INSERT [dbo].[CharacterPersonality] ([CharacterID], [PersonalityTypeID], [Rating]) VALUES (1, 4, 88)
INSERT [dbo].[CharacterPersonality] ([CharacterID], [PersonalityTypeID], [Rating]) VALUES (1, 5, 10)
INSERT [dbo].[CharacterPersonality] ([CharacterID], [PersonalityTypeID], [Rating]) VALUES (1, 6, 1)
INSERT [dbo].[CharacterPersonality] ([CharacterID], [PersonalityTypeID], [Rating]) VALUES (1, 7, 1)
INSERT [dbo].[CharacterPersonality] ([CharacterID], [PersonalityTypeID], [Rating]) VALUES (1, 8, 70)
INSERT [dbo].[CharacterPersonality] ([CharacterID], [PersonalityTypeID], [Rating]) VALUES (1, 9, 77)
INSERT [dbo].[CharacterPersonality] ([CharacterID], [PersonalityTypeID], [Rating]) VALUES (1, 10, 60)
INSERT [dbo].[CharacterPersonality] ([CharacterID], [PersonalityTypeID], [Rating]) VALUES (1, 11, 40)
INSERT [dbo].[CharacterPersonality] ([CharacterID], [PersonalityTypeID], [Rating]) VALUES (2, 1, 50)
INSERT [dbo].[CharacterPersonality] ([CharacterID], [PersonalityTypeID], [Rating]) VALUES (2, 2, 1)
INSERT [dbo].[CharacterPersonality] ([CharacterID], [PersonalityTypeID], [Rating]) VALUES (2, 3, 40)
INSERT [dbo].[CharacterPersonality] ([CharacterID], [PersonalityTypeID], [Rating]) VALUES (2, 4, 50)
INSERT [dbo].[CharacterPersonality] ([CharacterID], [PersonalityTypeID], [Rating]) VALUES (2, 5, 40)
INSERT [dbo].[CharacterPersonality] ([CharacterID], [PersonalityTypeID], [Rating]) VALUES (2, 6, 1)
INSERT [dbo].[CharacterPersonality] ([CharacterID], [PersonalityTypeID], [Rating]) VALUES (2, 7, 1)
INSERT [dbo].[CharacterPersonality] ([CharacterID], [PersonalityTypeID], [Rating]) VALUES (2, 8, 10)
INSERT [dbo].[CharacterPersonality] ([CharacterID], [PersonalityTypeID], [Rating]) VALUES (2, 9, 50)
INSERT [dbo].[CharacterPersonality] ([CharacterID], [PersonalityTypeID], [Rating]) VALUES (2, 10, 70)
INSERT [dbo].[CharacterPersonality] ([CharacterID], [PersonalityTypeID], [Rating]) VALUES (2, 11, 20)
/****** Object:  Table [dbo].[ScopeNodeReputation]    Script Date: 03/13/2012 00:05:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScopeNodeReputation](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CharacterID] [int] NOT NULL,
	[ScopeNodeID] [int] NOT NULL,
	[DirectReputation] [float] NOT NULL,
	[EffectiveReputation] [float] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_ScopeNodeReputation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ScopeNodeReputation] ON
INSERT [dbo].[ScopeNodeReputation] ([ID], [CharacterID], [ScopeNodeID], [DirectReputation], [EffectiveReputation], [Deleted]) VALUES (1, 4, 1, 0, 0, 0)
INSERT [dbo].[ScopeNodeReputation] ([ID], [CharacterID], [ScopeNodeID], [DirectReputation], [EffectiveReputation], [Deleted]) VALUES (2, 4, 2, 0, 0, 0)
INSERT [dbo].[ScopeNodeReputation] ([ID], [CharacterID], [ScopeNodeID], [DirectReputation], [EffectiveReputation], [Deleted]) VALUES (3, 4, 3, 0, 0, 0)
INSERT [dbo].[ScopeNodeReputation] ([ID], [CharacterID], [ScopeNodeID], [DirectReputation], [EffectiveReputation], [Deleted]) VALUES (4, 4, 4, 0, 0, 0)
SET IDENTITY_INSERT [dbo].[ScopeNodeReputation] OFF
/****** Object:  Table [dbo].[ScopeNodeReputationChildParent]    Script Date: 03/13/2012 00:05:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScopeNodeReputationChildParent](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ParentID] [int] NOT NULL,
	[ChildID] [int] NOT NULL,
	[ScopeNodeChildParentID] [int] NOT NULL,
	[RepFromChildMultiplier] [float] NOT NULL,
	[RepFromParentMultiplier] [float] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_ScopeNodeReputationChildParent] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ScopeNodeReputationChildParent] ON
INSERT [dbo].[ScopeNodeReputationChildParent] ([ID], [ParentID], [ChildID], [ScopeNodeChildParentID], [RepFromChildMultiplier], [RepFromParentMultiplier], [Deleted]) VALUES (1, 1, 2, 1, 0, 0, 0)
INSERT [dbo].[ScopeNodeReputationChildParent] ([ID], [ParentID], [ChildID], [ScopeNodeChildParentID], [RepFromChildMultiplier], [RepFromParentMultiplier], [Deleted]) VALUES (2, 2, 3, 2, 0, 0, 0)
INSERT [dbo].[ScopeNodeReputationChildParent] ([ID], [ParentID], [ChildID], [ScopeNodeChildParentID], [RepFromChildMultiplier], [RepFromParentMultiplier], [Deleted]) VALUES (3, 3, 4, 3, 0, 0, 0)
SET IDENTITY_INSERT [dbo].[ScopeNodeReputationChildParent] OFF
/****** Object:  Default [DF_ScopeNodeType_Deleted]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[ScopeNodeType] ADD  CONSTRAINT [DF_ScopeNodeType_Deleted]  DEFAULT ((0)) FOR [Deleted]
GO
/****** Object:  Default [DF_ScopeNode_Deleted]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[ScopeNode] ADD  CONSTRAINT [DF_ScopeNode_Deleted]  DEFAULT ((0)) FOR [Deleted]
GO
/****** Object:  Default [DF_Phrase_IsQuestion]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[Phrase] ADD  CONSTRAINT [DF_Phrase_IsQuestion]  DEFAULT ((0)) FOR [IsQuestion]
GO
/****** Object:  Default [DF_Town_Deleted]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[Town] ADD  CONSTRAINT [DF_Town_Deleted]  DEFAULT ((0)) FOR [Deleted]
GO
/****** Object:  Default [DF_Character_NPC]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[Character] ADD  CONSTRAINT [DF_Character_NPC]  DEFAULT ((1)) FOR [NPC]
GO
/****** Object:  Default [DF_Character_Deleted]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[Character] ADD  CONSTRAINT [DF_Character_Deleted]  DEFAULT ((0)) FOR [Deleted]
GO
/****** Object:  Default [DF_ScopeNodeChildParent_Deleted]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[ScopeNodeChildParent] ADD  CONSTRAINT [DF_ScopeNodeChildParent_Deleted]  DEFAULT ((0)) FOR [Deleted]
GO
/****** Object:  Default [DF_Region_Deleted]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[Region] ADD  CONSTRAINT [DF_Region_Deleted]  DEFAULT ((0)) FOR [Deleted]
GO
/****** Object:  Default [DF_Group_Deleted]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[Group] ADD  CONSTRAINT [DF_Group_Deleted]  DEFAULT ((0)) FOR [Deleted]
GO
/****** Object:  Default [DF_ScopeNodeReputation_DirectReputation]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[ScopeNodeReputation] ADD  CONSTRAINT [DF_ScopeNodeReputation_DirectReputation]  DEFAULT ((0.0)) FOR [DirectReputation]
GO
/****** Object:  Default [DF_ScopeNodeReputation_EffectiveReputation]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[ScopeNodeReputation] ADD  CONSTRAINT [DF_ScopeNodeReputation_EffectiveReputation]  DEFAULT ((0.0)) FOR [EffectiveReputation]
GO
/****** Object:  Default [DF_ScopeNodeReputation_Deleted]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[ScopeNodeReputation] ADD  CONSTRAINT [DF_ScopeNodeReputation_Deleted]  DEFAULT ((0)) FOR [Deleted]
GO
/****** Object:  Default [DF_ScopeNodeReputationChildParent_RepFromChildMultiplier]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[ScopeNodeReputationChildParent] ADD  CONSTRAINT [DF_ScopeNodeReputationChildParent_RepFromChildMultiplier]  DEFAULT ((0.0)) FOR [RepFromChildMultiplier]
GO
/****** Object:  Default [DF_ScopeNodeReputationChildParent_RepFromParentMultiplier]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[ScopeNodeReputationChildParent] ADD  CONSTRAINT [DF_ScopeNodeReputationChildParent_RepFromParentMultiplier]  DEFAULT ((0.0)) FOR [RepFromParentMultiplier]
GO
/****** Object:  Default [DF_ScopeNodeReputationChildParent_Deleted]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[ScopeNodeReputationChildParent] ADD  CONSTRAINT [DF_ScopeNodeReputationChildParent_Deleted]  DEFAULT ((0)) FOR [Deleted]
GO
/****** Object:  ForeignKey [FK_PersonalityTypeType_PersonalityType]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[PersonalityTypeType]  WITH CHECK ADD  CONSTRAINT [FK_PersonalityTypeType_PersonalityType] FOREIGN KEY([ID])
REFERENCES [dbo].[PersonalityTypeType] ([ID])
GO
ALTER TABLE [dbo].[PersonalityTypeType] CHECK CONSTRAINT [FK_PersonalityTypeType_PersonalityType]
GO
/****** Object:  ForeignKey [FK_PersonalityType_PersonalityTypeType]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[PersonalityType]  WITH CHECK ADD  CONSTRAINT [FK_PersonalityType_PersonalityTypeType] FOREIGN KEY([TypeID])
REFERENCES [dbo].[PersonalityTypeType] ([ID])
GO
ALTER TABLE [dbo].[PersonalityType] CHECK CONSTRAINT [FK_PersonalityType_PersonalityTypeType]
GO
/****** Object:  ForeignKey [FK_ScopeNode_ScopeNode]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[ScopeNode]  WITH CHECK ADD  CONSTRAINT [FK_ScopeNode_ScopeNode] FOREIGN KEY([ID])
REFERENCES [dbo].[ScopeNode] ([ID])
GO
ALTER TABLE [dbo].[ScopeNode] CHECK CONSTRAINT [FK_ScopeNode_ScopeNode]
GO
/****** Object:  ForeignKey [FK_ScopeNode_ScopeNodeType]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[ScopeNode]  WITH CHECK ADD  CONSTRAINT [FK_ScopeNode_ScopeNodeType] FOREIGN KEY([ScopeNodeTypeID])
REFERENCES [dbo].[ScopeNodeType] ([ID])
GO
ALTER TABLE [dbo].[ScopeNode] CHECK CONSTRAINT [FK_ScopeNode_ScopeNodeType]
GO
/****** Object:  ForeignKey [FK_Phrase_Topic]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[Phrase]  WITH CHECK ADD  CONSTRAINT [FK_Phrase_Topic] FOREIGN KEY([TopicID])
REFERENCES [dbo].[Topic] ([ID])
GO
ALTER TABLE [dbo].[Phrase] CHECK CONSTRAINT [FK_Phrase_Topic]
GO
/****** Object:  ForeignKey [FK_Town_ScopeNode]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[Town]  WITH CHECK ADD  CONSTRAINT [FK_Town_ScopeNode] FOREIGN KEY([ScopeNodeID])
REFERENCES [dbo].[ScopeNode] ([ID])
GO
ALTER TABLE [dbo].[Town] CHECK CONSTRAINT [FK_Town_ScopeNode]
GO
/****** Object:  ForeignKey [FK_Character_ScopeNode]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[Character]  WITH CHECK ADD  CONSTRAINT [FK_Character_ScopeNode] FOREIGN KEY([ScopeNodeID])
REFERENCES [dbo].[ScopeNode] ([ID])
GO
ALTER TABLE [dbo].[Character] CHECK CONSTRAINT [FK_Character_ScopeNode]
GO
/****** Object:  ForeignKey [FK_ScopeNodeChildParent_ScopeNode]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[ScopeNodeChildParent]  WITH CHECK ADD  CONSTRAINT [FK_ScopeNodeChildParent_ScopeNode] FOREIGN KEY([ChildID])
REFERENCES [dbo].[ScopeNode] ([ID])
GO
ALTER TABLE [dbo].[ScopeNodeChildParent] CHECK CONSTRAINT [FK_ScopeNodeChildParent_ScopeNode]
GO
/****** Object:  ForeignKey [FK_ScopeNodeChildParent_ScopeNode1]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[ScopeNodeChildParent]  WITH CHECK ADD  CONSTRAINT [FK_ScopeNodeChildParent_ScopeNode1] FOREIGN KEY([ParentID])
REFERENCES [dbo].[ScopeNode] ([ID])
GO
ALTER TABLE [dbo].[ScopeNodeChildParent] CHECK CONSTRAINT [FK_ScopeNodeChildParent_ScopeNode1]
GO
/****** Object:  ForeignKey [FK_Region_ScopeNode]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[Region]  WITH CHECK ADD  CONSTRAINT [FK_Region_ScopeNode] FOREIGN KEY([ScopeNodeID])
REFERENCES [dbo].[ScopeNode] ([ID])
GO
ALTER TABLE [dbo].[Region] CHECK CONSTRAINT [FK_Region_ScopeNode]
GO
/****** Object:  ForeignKey [FK_PersonalityPhrase_Personality]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[PersonalityPhrase]  WITH CHECK ADD  CONSTRAINT [FK_PersonalityPhrase_Personality] FOREIGN KEY([PersonalityTypeID])
REFERENCES [dbo].[PersonalityType] ([ID])
GO
ALTER TABLE [dbo].[PersonalityPhrase] CHECK CONSTRAINT [FK_PersonalityPhrase_Personality]
GO
/****** Object:  ForeignKey [FK_PersonalityPhrase_Phrase]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[PersonalityPhrase]  WITH CHECK ADD  CONSTRAINT [FK_PersonalityPhrase_Phrase] FOREIGN KEY([PhraseID])
REFERENCES [dbo].[Phrase] ([ID])
GO
ALTER TABLE [dbo].[PersonalityPhrase] CHECK CONSTRAINT [FK_PersonalityPhrase_Phrase]
GO
/****** Object:  ForeignKey [FK_Group_ScopeNode]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[Group]  WITH CHECK ADD  CONSTRAINT [FK_Group_ScopeNode] FOREIGN KEY([ScopeNodeID])
REFERENCES [dbo].[ScopeNode] ([ID])
GO
ALTER TABLE [dbo].[Group] CHECK CONSTRAINT [FK_Group_ScopeNode]
GO
/****** Object:  ForeignKey [FK_CharacterPersonality_Character]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[CharacterPersonality]  WITH CHECK ADD  CONSTRAINT [FK_CharacterPersonality_Character] FOREIGN KEY([CharacterID])
REFERENCES [dbo].[Character] ([ID])
GO
ALTER TABLE [dbo].[CharacterPersonality] CHECK CONSTRAINT [FK_CharacterPersonality_Character]
GO
/****** Object:  ForeignKey [FK_CharacterPersonality_Personality]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[CharacterPersonality]  WITH CHECK ADD  CONSTRAINT [FK_CharacterPersonality_Personality] FOREIGN KEY([PersonalityTypeID])
REFERENCES [dbo].[PersonalityType] ([ID])
GO
ALTER TABLE [dbo].[CharacterPersonality] CHECK CONSTRAINT [FK_CharacterPersonality_Personality]
GO
/****** Object:  ForeignKey [FK_ScopeNodeReputation_Character]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[ScopeNodeReputation]  WITH CHECK ADD  CONSTRAINT [FK_ScopeNodeReputation_Character] FOREIGN KEY([CharacterID])
REFERENCES [dbo].[Character] ([ID])
GO
ALTER TABLE [dbo].[ScopeNodeReputation] CHECK CONSTRAINT [FK_ScopeNodeReputation_Character]
GO
/****** Object:  ForeignKey [FK_ScopeNodeReputation_ScopeNode]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[ScopeNodeReputation]  WITH CHECK ADD  CONSTRAINT [FK_ScopeNodeReputation_ScopeNode] FOREIGN KEY([ScopeNodeID])
REFERENCES [dbo].[ScopeNode] ([ID])
GO
ALTER TABLE [dbo].[ScopeNodeReputation] CHECK CONSTRAINT [FK_ScopeNodeReputation_ScopeNode]
GO
/****** Object:  ForeignKey [FK_ScopeNodeReputationChildParent_ScopeNodeChildParent]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[ScopeNodeReputationChildParent]  WITH CHECK ADD  CONSTRAINT [FK_ScopeNodeReputationChildParent_ScopeNodeChildParent] FOREIGN KEY([ScopeNodeChildParentID])
REFERENCES [dbo].[ScopeNodeChildParent] ([ID])
GO
ALTER TABLE [dbo].[ScopeNodeReputationChildParent] CHECK CONSTRAINT [FK_ScopeNodeReputationChildParent_ScopeNodeChildParent]
GO
/****** Object:  ForeignKey [FK_ScopeNodeReputationChildParent_ScopeNodeReputation]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[ScopeNodeReputationChildParent]  WITH CHECK ADD  CONSTRAINT [FK_ScopeNodeReputationChildParent_ScopeNodeReputation] FOREIGN KEY([ChildID])
REFERENCES [dbo].[ScopeNodeReputation] ([ID])
GO
ALTER TABLE [dbo].[ScopeNodeReputationChildParent] CHECK CONSTRAINT [FK_ScopeNodeReputationChildParent_ScopeNodeReputation]
GO
/****** Object:  ForeignKey [FK_ScopeNodeReputationChildParent_ScopeNodeReputation1]    Script Date: 03/13/2012 00:05:45 ******/
ALTER TABLE [dbo].[ScopeNodeReputationChildParent]  WITH CHECK ADD  CONSTRAINT [FK_ScopeNodeReputationChildParent_ScopeNodeReputation1] FOREIGN KEY([ParentID])
REFERENCES [dbo].[ScopeNodeReputation] ([ID])
GO
ALTER TABLE [dbo].[ScopeNodeReputationChildParent] CHECK CONSTRAINT [FK_ScopeNodeReputationChildParent_ScopeNodeReputation1]
GO
