--Problem 7. Find Towns Not Starting With

SELECT * FROM Towns 
	WHERE  LEFT(Name, 1) NOT IN ('R', 'B', 'D')
	ORDER BY Name ASC