--13. Departments Total Salaries
USE SoftUni
SELECT DepartmentID, SUM(Salary)
	FROM Employees 
	GROUP BY DepartmentID
	ORDER BY DepartmentID