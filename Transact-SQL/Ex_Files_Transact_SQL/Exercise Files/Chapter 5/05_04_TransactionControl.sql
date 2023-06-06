-- Transaction control with TRY...CATCH
USE WideWorldImporters;
GO

SELECT * FROM Warehouse.Colors
ORDER BY ColorID DESC;
GO

-- Add error handling to a transaction

BEGIN TRY
	BEGIN TRANSACTION;

	EXEC Warehouse.uspInsertColor 'Unicorn Pink';
	EXEC Warehouse.uspInsertColor 'Kraken Blue';

	COMMIT TRANSACTION;
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION;
	PRINT 'Oops! Unable to insert a color because it already exits in the database. Pick a unique name.'
END CATCH

-- View data
SELECT * FROM Warehouse.Colors
ORDER BY ColorID DESC;
GO