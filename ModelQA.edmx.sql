
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/17/2020 10:30:44
-- Generated from EDMX file: C:\Users\Slava Medvedev\source\repos\QA_System\ModelQA.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [qa_system_db];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_SystemCollectionUserSystems]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserSystems] DROP CONSTRAINT [FK_SystemCollectionUserSystems];
GO
IF OBJECT_ID(N'[dbo].[FK_UserDataUserSystems]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserSystems] DROP CONSTRAINT [FK_UserDataUserSystems];
GO
IF OBJECT_ID(N'[dbo].[FK_UserSystemsUserQuestions]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserQuestions] DROP CONSTRAINT [FK_UserSystemsUserQuestions];
GO
IF OBJECT_ID(N'[dbo].[FK_SystemCollectionGroupDemand]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GroupDemands] DROP CONSTRAINT [FK_SystemCollectionGroupDemand];
GO
IF OBJECT_ID(N'[dbo].[FK_GroupDemandTypeDemand]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TypeDemands] DROP CONSTRAINT [FK_GroupDemandTypeDemand];
GO
IF OBJECT_ID(N'[dbo].[FK_TypeDemandDemandDescription]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DemandDescriptions] DROP CONSTRAINT [FK_TypeDemandDemandDescription];
GO
IF OBJECT_ID(N'[dbo].[FK_SystemCollectionGlossarySystem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GlossarySystems] DROP CONSTRAINT [FK_SystemCollectionGlossarySystem];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UserDatas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserDatas];
GO
IF OBJECT_ID(N'[dbo].[SystemCollections]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SystemCollections];
GO
IF OBJECT_ID(N'[dbo].[UserSystems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSystems];
GO
IF OBJECT_ID(N'[dbo].[UserQuestions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserQuestions];
GO
IF OBJECT_ID(N'[dbo].[GroupDemands]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GroupDemands];
GO
IF OBJECT_ID(N'[dbo].[TypeDemands]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypeDemands];
GO
IF OBJECT_ID(N'[dbo].[DemandDescriptions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DemandDescriptions];
GO
IF OBJECT_ID(N'[dbo].[GlossarySystems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GlossarySystems];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserDatas'
CREATE TABLE [dbo].[UserDatas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LoginUser] nvarchar(max)  NOT NULL,
    [PasswordUser] nvarchar(max)  NOT NULL,
    [NameUser] nvarchar(max)  NOT NULL,
    [RoleUser] nvarchar(max)  NOT NULL,
    [Hidden] bit  NOT NULL
);
GO

-- Creating table 'SystemCollections'
CREATE TABLE [dbo].[SystemCollections] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SystemName] nvarchar(max)  NOT NULL,
    [GeneralDescription] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UserSystems'
CREATE TABLE [dbo].[UserSystems] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SystemCollectionId] int  NOT NULL,
    [UserDataId] int  NOT NULL
);
GO

-- Creating table 'UserQuestions'
CREATE TABLE [dbo].[UserQuestions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserSystemsId] int  NOT NULL,
    [QuestionBody] nvarchar(max)  NOT NULL,
    [DemandDescriptionId] int  NULL
);
GO

-- Creating table 'GroupDemands'
CREATE TABLE [dbo].[GroupDemands] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [GroupName] nvarchar(max)  NOT NULL,
    [SystemCollectionId] int  NOT NULL
);
GO

-- Creating table 'TypeDemands'
CREATE TABLE [dbo].[TypeDemands] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TymeName] nvarchar(max)  NOT NULL,
    [GroupDemandId] int  NOT NULL
);
GO

-- Creating table 'DemandDescriptions'
CREATE TABLE [dbo].[DemandDescriptions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [TypeDemandId] int  NOT NULL
);
GO

-- Creating table 'GlossarySystems'
CREATE TABLE [dbo].[GlossarySystems] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [WordGlossary] nvarchar(max)  NOT NULL,
    [WordValue] int  NOT NULL,
    [SystemCollectionId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UserDatas'
ALTER TABLE [dbo].[UserDatas]
ADD CONSTRAINT [PK_UserDatas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SystemCollections'
ALTER TABLE [dbo].[SystemCollections]
ADD CONSTRAINT [PK_SystemCollections]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserSystems'
ALTER TABLE [dbo].[UserSystems]
ADD CONSTRAINT [PK_UserSystems]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserQuestions'
ALTER TABLE [dbo].[UserQuestions]
ADD CONSTRAINT [PK_UserQuestions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GroupDemands'
ALTER TABLE [dbo].[GroupDemands]
ADD CONSTRAINT [PK_GroupDemands]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TypeDemands'
ALTER TABLE [dbo].[TypeDemands]
ADD CONSTRAINT [PK_TypeDemands]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DemandDescriptions'
ALTER TABLE [dbo].[DemandDescriptions]
ADD CONSTRAINT [PK_DemandDescriptions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GlossarySystems'
ALTER TABLE [dbo].[GlossarySystems]
ADD CONSTRAINT [PK_GlossarySystems]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SystemCollectionId] in table 'UserSystems'
ALTER TABLE [dbo].[UserSystems]
ADD CONSTRAINT [FK_SystemCollectionUserSystems]
    FOREIGN KEY ([SystemCollectionId])
    REFERENCES [dbo].[SystemCollections]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SystemCollectionUserSystems'
CREATE INDEX [IX_FK_SystemCollectionUserSystems]
ON [dbo].[UserSystems]
    ([SystemCollectionId]);
GO

-- Creating foreign key on [UserDataId] in table 'UserSystems'
ALTER TABLE [dbo].[UserSystems]
ADD CONSTRAINT [FK_UserDataUserSystems]
    FOREIGN KEY ([UserDataId])
    REFERENCES [dbo].[UserDatas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserDataUserSystems'
CREATE INDEX [IX_FK_UserDataUserSystems]
ON [dbo].[UserSystems]
    ([UserDataId]);
GO

-- Creating foreign key on [UserSystemsId] in table 'UserQuestions'
ALTER TABLE [dbo].[UserQuestions]
ADD CONSTRAINT [FK_UserSystemsUserQuestions]
    FOREIGN KEY ([UserSystemsId])
    REFERENCES [dbo].[UserSystems]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserSystemsUserQuestions'
CREATE INDEX [IX_FK_UserSystemsUserQuestions]
ON [dbo].[UserQuestions]
    ([UserSystemsId]);
GO

-- Creating foreign key on [SystemCollectionId] in table 'GroupDemands'
ALTER TABLE [dbo].[GroupDemands]
ADD CONSTRAINT [FK_SystemCollectionGroupDemand]
    FOREIGN KEY ([SystemCollectionId])
    REFERENCES [dbo].[SystemCollections]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SystemCollectionGroupDemand'
CREATE INDEX [IX_FK_SystemCollectionGroupDemand]
ON [dbo].[GroupDemands]
    ([SystemCollectionId]);
GO

-- Creating foreign key on [GroupDemandId] in table 'TypeDemands'
ALTER TABLE [dbo].[TypeDemands]
ADD CONSTRAINT [FK_GroupDemandTypeDemand]
    FOREIGN KEY ([GroupDemandId])
    REFERENCES [dbo].[GroupDemands]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GroupDemandTypeDemand'
CREATE INDEX [IX_FK_GroupDemandTypeDemand]
ON [dbo].[TypeDemands]
    ([GroupDemandId]);
GO

-- Creating foreign key on [TypeDemandId] in table 'DemandDescriptions'
ALTER TABLE [dbo].[DemandDescriptions]
ADD CONSTRAINT [FK_TypeDemandDemandDescription]
    FOREIGN KEY ([TypeDemandId])
    REFERENCES [dbo].[TypeDemands]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TypeDemandDemandDescription'
CREATE INDEX [IX_FK_TypeDemandDemandDescription]
ON [dbo].[DemandDescriptions]
    ([TypeDemandId]);
GO

-- Creating foreign key on [SystemCollectionId] in table 'GlossarySystems'
ALTER TABLE [dbo].[GlossarySystems]
ADD CONSTRAINT [FK_SystemCollectionGlossarySystem]
    FOREIGN KEY ([SystemCollectionId])
    REFERENCES [dbo].[SystemCollections]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SystemCollectionGlossarySystem'
CREATE INDEX [IX_FK_SystemCollectionGlossarySystem]
ON [dbo].[GlossarySystems]
    ([SystemCollectionId]);
GO

-- Creating foreign key on [DemandDescriptionId] in table 'UserQuestions'
ALTER TABLE [dbo].[UserQuestions]
ADD CONSTRAINT [FK_DemandDescriptionUserQuestions]
    FOREIGN KEY ([DemandDescriptionId])
    REFERENCES [dbo].[DemandDescriptions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DemandDescriptionUserQuestions'
CREATE INDEX [IX_FK_DemandDescriptionUserQuestions]
ON [dbo].[UserQuestions]
    ([DemandDescriptionId]);
GO

INSERT INTO [dbo].[UserDatas]
           ([LoginUser]
           ,[PasswordUser]
           ,[NameUser]
           ,[RoleUser]
           ,[Hidden])
     VALUES
           ('admin'
           ,'admin'
           ,'Administrator'
           ,'admin'
           ,1)
GO
-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------