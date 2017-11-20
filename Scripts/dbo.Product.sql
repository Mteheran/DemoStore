CREATE TABLE [dbo].[Product]
(
	[Id] NVARCHAR(255) NOT NULL PRIMARY KEY DEFAULT  NEWID(), 
    [Number] INT NOT NULL, 
    [Tittle] NVARCHAR(50) NOT NULL, 
    [Price] FLOAT NOT NULL, 
    [Description] NVARCHAR(MAX) NULL 
)
