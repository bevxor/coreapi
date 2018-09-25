CREATE VIEW [dbo].[vwCustomerPrimaryAddress]
	AS 
SELECT 
	[Customer].CustomerId,
	[Customer].FirstName,
	[Customer].Surname,
	[CustomerAddress].Street,
	[CustomerAddress].City,
	[CustomerAddress].Suburb,
	[CustomerAddress].PostCode
FROM [Customer] 
	LEFT OUTER JOIN [CustomerAddress]
		ON [Customer].CustomerId = [CustomerAddress].CustomerId
WHERE 
	[CustomerAddress].PrimaryAddress = 1

