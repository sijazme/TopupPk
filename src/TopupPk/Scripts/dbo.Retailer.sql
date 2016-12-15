CREATE TABLE [dbo].[Retailer]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Street] VARCHAR(50) NOT NULL, 
    [City] VARCHAR(50) NOT NULL, 
    [Country] VARCHAR(50) NULL, 
    [Phone] VARCHAR(50) NULL
)
