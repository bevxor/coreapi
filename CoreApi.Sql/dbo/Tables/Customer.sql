CREATE TABLE [dbo].[Customer]
(
	[CustomerId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(250) NOT NULL, 
    [Surname] NVARCHAR(250) NOT NULL
)
