--Problem 19. People Table
	CREATE TABLE People
	(
		Id INT PRIMARY KEY,
		[Name] VARCHAR(30),
		Birthday DATETIME
	)

	INSERT INTO People VALUES
	(1,'Victor', '2000-12-07'),
	(2, 'Steven', '1992-09-10'),
	(3, 'Stephen', '1910-09-19'),
	(4, 'John', '2010-01-06')

	SELECT 
		[Name], Birthday,
		YEAR(GETDATE())- YEAR(Birthday) AS [Age of year], 
		DATEDIFF(MONTH, Birthday, GETDATE()) AS [Age in Months],
		DATEDIFF(DAY, Birthday, GETDATE()) AS [Age in Days],
		'' [Age in Minutes]
	FROM People