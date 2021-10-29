
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/27/2021 15:24:40
-- Generated from EDMX file: C:\Users\Ashish\source\repos\WebApplication1\WebApplication1\GKHUBEntity.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [GKHUB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Biology]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Biology];
GO
IF OBJECT_ID(N'[dbo].[Geography]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Geography];
GO
IF OBJECT_ID(N'[dbo].[Login]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Login];
GO
IF OBJECT_ID(N'[dbo].[Physics]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Physics];
GO
IF OBJECT_ID(N'[dbo].[Register]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Register];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Logins'
CREATE TABLE [dbo].[Logins] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Email] varchar(50)  NOT NULL,
    [Password] varchar(50)  NOT NULL,
    [Type] varchar(50)  NULL
);
GO

-- Creating table 'Physics'
CREATE TABLE [dbo].[Physics] (
    [QID] int IDENTITY(1,1) NOT NULL,
    [Question] nvarchar(500)  NULL,
    [A] nvarchar(100)  NULL,
    [B] nvarchar(100)  NULL,
    [C] nvarchar(100)  NULL,
    [D] nvarchar(100)  NULL,
    [RightAns] nvarchar(100)  NULL
);
GO

-- Creating table 'Registers'
CREATE TABLE [dbo].[Registers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NOT NULL,
    [Gender] varchar(50)  NULL,
    [Mobile] varchar(10)  NOT NULL,
    [Email] varchar(50)  NOT NULL,
    [Password] varchar(50)  NOT NULL,
    [Address] varchar(500)  NULL
);
GO

-- Creating table 'Biologies'
CREATE TABLE [dbo].[Biologies] (
    [QID] int IDENTITY(1,1) NOT NULL,
    [Question] nvarchar(500)  NULL,
    [A] nvarchar(100)  NULL,
    [B] nvarchar(100)  NULL,
    [C] nvarchar(100)  NULL,
    [D] nvarchar(100)  NULL,
    [RightAns] nvarchar(100)  NULL
);
GO

-- Creating table 'Chemistries'
CREATE TABLE [dbo].[Chemistries] (
    [QID] int IDENTITY(1,1) NOT NULL,
    [Question] nvarchar(500)  NULL,
    [A] nvarchar(100)  NULL,
    [B] nvarchar(100)  NULL,
    [C] nvarchar(100)  NULL,
    [D] nvarchar(100)  NULL,
    [RightAns] nvarchar(100)  NULL
);
GO

-- Creating table 'CurrentAffairs'
CREATE TABLE [dbo].[CurrentAffairs] (
    [QID] int IDENTITY(1,1) NOT NULL,
    [Question] nvarchar(500)  NULL,
    [A] nvarchar(100)  NULL,
    [B] nvarchar(100)  NULL,
    [C] nvarchar(100)  NULL,
    [D] nvarchar(100)  NULL,
    [RightAns] nvarchar(100)  NULL
);
GO

-- Creating table 'Economics'
CREATE TABLE [dbo].[Economics] (
    [QID] int IDENTITY(1,1) NOT NULL,
    [Question] nvarchar(500)  NULL,
    [A] nvarchar(100)  NULL,
    [B] nvarchar(100)  NULL,
    [C] nvarchar(100)  NULL,
    [D] nvarchar(100)  NULL,
    [RightAns] nvarchar(100)  NULL
);
GO

-- Creating table 'Geographies'
CREATE TABLE [dbo].[Geographies] (
    [QID] int IDENTITY(1,1) NOT NULL,
    [Question] nvarchar(500)  NULL,
    [A] nvarchar(100)  NULL,
    [B] nvarchar(100)  NULL,
    [C] nvarchar(100)  NULL,
    [D] nvarchar(100)  NULL,
    [RightAns] nvarchar(100)  NULL
);
GO

-- Creating table 'Histories'
CREATE TABLE [dbo].[Histories] (
    [QID] int IDENTITY(1,1) NOT NULL,
    [Question] nvarchar(500)  NULL,
    [A] nvarchar(100)  NULL,
    [B] nvarchar(100)  NULL,
    [C] nvarchar(100)  NULL,
    [D] nvarchar(100)  NULL,
    [RightAns] nvarchar(100)  NULL
);
GO

-- Creating table 'Polities'
CREATE TABLE [dbo].[Polities] (
    [QID] int IDENTITY(1,1) NOT NULL,
    [Question] nvarchar(500)  NULL,
    [A] nvarchar(100)  NULL,
    [B] nvarchar(100)  NULL,
    [C] nvarchar(100)  NULL,
    [D] nvarchar(100)  NULL,
    [RightAns] nvarchar(100)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Email] in table 'Logins'
ALTER TABLE [dbo].[Logins]
ADD CONSTRAINT [PK_Logins]
    PRIMARY KEY CLUSTERED ([Email] ASC);
GO

-- Creating primary key on [QID] in table 'Physics'
ALTER TABLE [dbo].[Physics]
ADD CONSTRAINT [PK_Physics]
    PRIMARY KEY CLUSTERED ([QID] ASC);
GO

-- Creating primary key on [Email] in table 'Registers'
ALTER TABLE [dbo].[Registers]
ADD CONSTRAINT [PK_Registers]
    PRIMARY KEY CLUSTERED ([Email] ASC);
GO

-- Creating primary key on [QID] in table 'Biologies'
ALTER TABLE [dbo].[Biologies]
ADD CONSTRAINT [PK_Biologies]
    PRIMARY KEY CLUSTERED ([QID] ASC);
GO

-- Creating primary key on [QID] in table 'Chemistries'
ALTER TABLE [dbo].[Chemistries]
ADD CONSTRAINT [PK_Chemistries]
    PRIMARY KEY CLUSTERED ([QID] ASC);
GO

-- Creating primary key on [QID] in table 'CurrentAffairs'
ALTER TABLE [dbo].[CurrentAffairs]
ADD CONSTRAINT [PK_CurrentAffairs]
    PRIMARY KEY CLUSTERED ([QID] ASC);
GO

-- Creating primary key on [QID] in table 'Economics'
ALTER TABLE [dbo].[Economics]
ADD CONSTRAINT [PK_Economics]
    PRIMARY KEY CLUSTERED ([QID] ASC);
GO

-- Creating primary key on [QID] in table 'Geographies'
ALTER TABLE [dbo].[Geographies]
ADD CONSTRAINT [PK_Geographies]
    PRIMARY KEY CLUSTERED ([QID] ASC);
GO

-- Creating primary key on [QID] in table 'Histories'
ALTER TABLE [dbo].[Histories]
ADD CONSTRAINT [PK_Histories]
    PRIMARY KEY CLUSTERED ([QID] ASC);
GO

-- Creating primary key on [QID] in table 'Polities'
ALTER TABLE [dbo].[Polities]
ADD CONSTRAINT [PK_Polities]
    PRIMARY KEY CLUSTERED ([QID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------