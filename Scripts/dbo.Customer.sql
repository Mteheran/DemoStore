﻿CREATE TABLE [dbo].[Table]
(
	[Id] NVARCHAR(255) NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [Name] NVARCHAR(255) NOT NULL, 
    [Email] NVARCHAR(50) NULL, 
    [Phone] NVARCHAR(50) NULL, 
    [Number] NVARCHAR(255) NOT NULL, 
    [Nit] NVARCHAR(50) NOT NULL, 
    [Date] DATETIME NULL DEFAULT GETDATE(), 
    [Estatus] BIT NOT NULL DEFAULT 1
)
