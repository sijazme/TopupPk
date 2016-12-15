USE [TopupPk]
GO

/****** Object: Table [dbo].[Retailer] Script Date: 12/15/2016 7:57:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Retailer];


GO
CREATE TABLE [dbo].[Retailer] (
    [Id]      INT          NOT NULL,
    [Name]    VARCHAR (50) NOT NULL,
    [Street]  VARCHAR (50) NOT NULL,
    [City]    VARCHAR (50) NOT NULL,
    [Country] VARCHAR (50) NOT NULL,
    [Phone]   VARCHAR (50) NOT NULL,
	[Credit] MONEY NOT NULL
);


