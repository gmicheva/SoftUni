--Problem 18. Orders Table
SELECT 
	ProductName, 
	OrderDate, 
	OrderDate + 3 AS  [Pay Due], 
	DATEADD(month, 1, OrderDate) AS [Deliver Due]
	FROM Orders