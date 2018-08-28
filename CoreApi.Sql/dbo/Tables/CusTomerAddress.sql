CREATE TABLE [dbo].[CustomerAddress]
(
	[CustomerAddressId] INT NOT NULL PRIMARY KEY, 
    [PrimaryAddress] BIT NOT NULL, 
    [Street] NVARCHAR(MAX) NOT NULL, 
    [Suburb] NVARCHAR(MAX) NOT NULL, 
    [City] NVARCHAR(MAX) NOT NULL, 
    [PostCode] INT NOT NULL, 
    [CustomerId] INT NOT NULL, 
    CONSTRAINT [FK_CustomerAddress_Customer] FOREIGN KEY ([CustomerId]) REFERENCES [Customer]([CustomerId])
)
