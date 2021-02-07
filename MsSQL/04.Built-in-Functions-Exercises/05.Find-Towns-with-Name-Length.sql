--Problem 5. Find Towns with Name Length

SELECT [Name] FROM Towns WHERE LEN(Name) = 5 OR LEN(Name) = 6
	ORDER BY Name ASC