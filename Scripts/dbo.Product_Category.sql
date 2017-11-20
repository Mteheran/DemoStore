CREATE TABLE [dbo].[Product_Category]
(
	[Id] NVARCHAR(255) NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [Product_Id] NVARCHAR(255) NOT NULL, 
    [Category_Id] NVARCHAR(255) NOT NULL, 
    CONSTRAINT [FK_Product_Category_Product_ID] FOREIGN KEY (Product_Id) REFERENCES Product(Id), 
	CONSTRAINT [FK_Product_Category_Category_Id] FOREIGN KEY (Category_Id) REFERENCES Category(Id)
    
)
