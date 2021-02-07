--Problem 13. Mix of Peak and River Names

SELECT PeakName, RiverName, LOWER(LEFT(PeakName, LEN(PeakName)-1)+RiverName) AS Mix FROM Peaks, Rivers
	WHERE LEFT(RiverName,1) = RIGHT(PeakName,1)
	ORDER BY Mix