--Problem 15. User Email Providers
SELECT Username,
		SUBSTRING(Email, CHARINDEX('@', Email) + 1, LEN(Email)) 
		AS EmailProvider 
   FROM [Users]
  ORDER BY EmailProvider , [Username] 