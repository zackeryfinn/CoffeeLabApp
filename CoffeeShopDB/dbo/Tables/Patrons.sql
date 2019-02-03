CREATE TABLE [dbo].[Patrons]
(
	[PatronID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NCHAR(50) NULL, 
    [LastName] NCHAR(50) NULL, 
    [Email] NCHAR(50) NULL
)
