USE [master]
GO
/****** Object:  Database [Revolution]    Script Date: 03/06/2012 23:02:44 ******/
CREATE DATABASE [Revolution] ON  PRIMARY 
( NAME = N'Revolution', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQL\MSSQL\DATA\Revolution.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Revolution_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQL\MSSQL\DATA\Revolution_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
/****** Object:  Table [dbo].[Character]    Script Date: 03/06/2012 23:02:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Character](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[Gender] [bit] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Character] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Character] ON
INSERT [dbo].[Character] ([ID], [FirstName], [LastName], [Gender], [Deleted]) VALUES (1, N'Rhodan', N'Dhall', 1, 0)
INSERT [dbo].[Character] ([ID], [FirstName], [LastName], [Gender], [Deleted]) VALUES (2, N'Daina', N'Cross', 0, 0)
SET IDENTITY_INSERT [dbo].[Character] OFF
/****** Object:  Table [dbo].[PersonalityTypeType]    Script Date: 03/06/2012 23:02:45 ******/
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
/****** Object:  Table [dbo].[Topic]    Script Date: 03/06/2012 23:02:45 ******/
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
/****** Object:  Table [dbo].[Phrase]    Script Date: 03/06/2012 23:02:45 ******/
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
/****** Object:  Table [dbo].[PersonalityType]    Script Date: 03/06/2012 23:02:45 ******/
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
/****** Object:  Table [dbo].[PersonalityPhrase]    Script Date: 03/06/2012 23:02:45 ******/
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
/****** Object:  Table [dbo].[CharacterPersonality]    Script Date: 03/06/2012 23:02:45 ******/
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
/****** Object:  Default [DF_Character_Deleted]    Script Date: 03/06/2012 23:02:45 ******/
ALTER TABLE [dbo].[Character] ADD  CONSTRAINT [DF_Character_Deleted]  DEFAULT ((0)) FOR [Deleted]
GO
/****** Object:  Default [DF_Phrase_IsQuestion]    Script Date: 03/06/2012 23:02:45 ******/
ALTER TABLE [dbo].[Phrase] ADD  CONSTRAINT [DF_Phrase_IsQuestion]  DEFAULT ((0)) FOR [IsQuestion]
GO
/****** Object:  ForeignKey [FK_PersonalityTypeType_PersonalityType]    Script Date: 03/06/2012 23:02:45 ******/
ALTER TABLE [dbo].[PersonalityTypeType]  WITH CHECK ADD  CONSTRAINT [FK_PersonalityTypeType_PersonalityType] FOREIGN KEY([ID])
REFERENCES [dbo].[PersonalityTypeType] ([ID])
GO
ALTER TABLE [dbo].[PersonalityTypeType] CHECK CONSTRAINT [FK_PersonalityTypeType_PersonalityType]
GO
/****** Object:  ForeignKey [FK_Phrase_Topic]    Script Date: 03/06/2012 23:02:45 ******/
ALTER TABLE [dbo].[Phrase]  WITH CHECK ADD  CONSTRAINT [FK_Phrase_Topic] FOREIGN KEY([TopicID])
REFERENCES [dbo].[Topic] ([ID])
GO
ALTER TABLE [dbo].[Phrase] CHECK CONSTRAINT [FK_Phrase_Topic]
GO
/****** Object:  ForeignKey [FK_PersonalityType_PersonalityTypeType]    Script Date: 03/06/2012 23:02:45 ******/
ALTER TABLE [dbo].[PersonalityType]  WITH CHECK ADD  CONSTRAINT [FK_PersonalityType_PersonalityTypeType] FOREIGN KEY([TypeID])
REFERENCES [dbo].[PersonalityTypeType] ([ID])
GO
ALTER TABLE [dbo].[PersonalityType] CHECK CONSTRAINT [FK_PersonalityType_PersonalityTypeType]
GO
/****** Object:  ForeignKey [FK_PersonalityPhrase_Personality]    Script Date: 03/06/2012 23:02:45 ******/
ALTER TABLE [dbo].[PersonalityPhrase]  WITH CHECK ADD  CONSTRAINT [FK_PersonalityPhrase_Personality] FOREIGN KEY([PersonalityTypeID])
REFERENCES [dbo].[PersonalityType] ([ID])
GO
ALTER TABLE [dbo].[PersonalityPhrase] CHECK CONSTRAINT [FK_PersonalityPhrase_Personality]
GO
/****** Object:  ForeignKey [FK_PersonalityPhrase_Phrase]    Script Date: 03/06/2012 23:02:45 ******/
ALTER TABLE [dbo].[PersonalityPhrase]  WITH CHECK ADD  CONSTRAINT [FK_PersonalityPhrase_Phrase] FOREIGN KEY([PhraseID])
REFERENCES [dbo].[Phrase] ([ID])
GO
ALTER TABLE [dbo].[PersonalityPhrase] CHECK CONSTRAINT [FK_PersonalityPhrase_Phrase]
GO
/****** Object:  ForeignKey [FK_CharacterPersonality_Character]    Script Date: 03/06/2012 23:02:45 ******/
ALTER TABLE [dbo].[CharacterPersonality]  WITH CHECK ADD  CONSTRAINT [FK_CharacterPersonality_Character] FOREIGN KEY([CharacterID])
REFERENCES [dbo].[Character] ([ID])
GO
ALTER TABLE [dbo].[CharacterPersonality] CHECK CONSTRAINT [FK_CharacterPersonality_Character]
GO
/****** Object:  ForeignKey [FK_CharacterPersonality_Personality]    Script Date: 03/06/2012 23:02:45 ******/
ALTER TABLE [dbo].[CharacterPersonality]  WITH CHECK ADD  CONSTRAINT [FK_CharacterPersonality_Personality] FOREIGN KEY([PersonalityTypeID])
REFERENCES [dbo].[PersonalityType] ([ID])
GO
ALTER TABLE [dbo].[CharacterPersonality] CHECK CONSTRAINT [FK_CharacterPersonality_Personality]
GO
