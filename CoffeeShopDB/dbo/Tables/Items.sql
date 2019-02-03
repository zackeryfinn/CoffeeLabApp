CREATE TABLE [dbo].[Items]
(
	[ItemID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NCHAR(50) NULL, 
    [Description] NCHAR(50) NULL, 
    [Quantity] INT NULL, 
    [Price] FLOAT NULL
)
