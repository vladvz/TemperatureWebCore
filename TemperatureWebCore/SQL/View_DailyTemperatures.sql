CREATE OR REPLACE VIEW Measures.DailyTemperatures AS
SELECT	DATE(Time) Time, 
		MAX(Temperature) MaxTemperature,
        MIN(Temperature) MinTemperature,
        ROUND(AVG(Temperature),1) AvgTemperature
FROM	Measure
GROUP BY DATE(Time)
ORDER BY Time;