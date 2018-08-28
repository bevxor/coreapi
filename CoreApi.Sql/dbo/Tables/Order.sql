CREATE TABLE [dbo].[Order]
(
	[OrderId] INT NOT NULL PRIMARY KEY, 
    [OrderName] NVARCHAR(MAX) NULL, 
    [CustomerId] INT NULL, 
    CONSTRAINT [FK_Order_Customer] FOREIGN KEY ([CustomerId]) REFERENCES [Customer]([CustomerId])
)
