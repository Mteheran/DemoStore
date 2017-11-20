CREATE TABLE [dbo].[Order_Detail]
(
	[Id] NVARCHAR(255) NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [Order_Id] NVARCHAR(255) NOT NULL, 
    [Quantity] INT NOT NULL, 
    [Product_Id] NVARCHAR(255) NOT NULL, 
    CONSTRAINT [FK_OrderDetails_Order] FOREIGN KEY (Order_Id) REFERENCES [Order](Id), 
    CONSTRAINT [FK_OrderDetails_Porduct] FOREIGN KEY (Product_Id) REFERENCES [Product]([Id])
)
