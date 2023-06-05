-- Challenge: Create a Function

-- Evaluate temperatures in Warehouse.ColdRoomTemperatures
-- Less than 3.5 degrees is too cold
-- Greater than 4 degrees is too hot
-- Between 3.5 and 4 degrees is just right

USE WideWorldImporters;
GO

CREATE OR ALTER FUNCTION Warehouse.TempDescription (@Temp DECIMAL(10,2))
RETURNS char(10)
AS
BEGIN
	BEGIN IF @Temp < 3.5
		RETURN 'Too cold'
	END

	BEGIN IF @Temp > 4
		RETURN 'Too hot'
	END

	RETURN 'Just right'
END;
GO


-- Local test cases
SELECT Warehouse.TempDescription(99.99) AS 'Temperature Description';
GO

SELECT Warehouse.TempDescription(-1.00) AS 'Temperature Description';
GO

SELECT Warehouse.TempDescription(3.75) AS 'Temperature Description';
GO

-- Lesson test cases
-- Test Function
SELECT ColdRoomTemperatureID,
	ColdRoomSensorNumber,
	Temperature,
	Warehouse.TempDescription(Temperature) AS 'Temperature Description'
FROM Warehouse.ColdRoomTemperatures;

SELECT ColdRoomTemperatureID,
	ColdRoomSensorNumber,
	Temperature
FROM Warehouse.ColdRoomTemperatures
WHERE Warehouse.TempDescription(Temperature) = 'Just Right';