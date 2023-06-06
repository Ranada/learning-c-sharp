DROP TABLE IF EXISTS dbo.BankAccounts;
CREATE TABLE dbo.BankAccounts (
    AccountID INT PRIMARY KEY,
    Balance decimal(10,2)
);
GO
INSERT INTO dbo.BankAccounts
    VALUES (1, 100.00), (2, 200.00), (3, 300.00);
GO
SELECT * FROM dbo.BankAccounts;
GO

CREATE OR ALTER PROCEDURE dbo.TransferFunds (@FromAccount AS INT, @ToAccount AS INT, @Amount AS DECIMAL(10,2))
AS

BEGIN TRY
	BEGIN TRANSACTION;

	BEGIN IF (SELECT AccountID FROM dbo.BankAccounts WHERE AccountID = @FromAccount) IS NULL
		THROW 500001, 'Oops! The "FROM" account does not exist. Try again.', 1
	END;

	BEGIN IF (SELECT AccountID FROM dbo.BankAccounts WHERE AccountID = @ToAccount) IS NULL
		THROW 500002, 'Oops! The "TO" account does not exist. Try again.', 1
	END;

	BEGIN IF (SELECT BALANCE FROM dbo.BankAccounts WHERE AccountID = @FromAccount) + 0.00 < @Amount
		THROW 500003, 'Oh snap! You do not have enough money to transfer.', 1
	END;

	UPDATE dbo.BankAccounts
		SET Balance -= @Amount
		WHERE AccountID = @FromAccount;

	UPDATE dbo.BankAccounts
		SET Balance += @Amount
		WHERE AccountID = @ToAccount;

	COMMIT TRANSACTION;
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION;
	PRINT ERROR_MESSAGE()
END CATCH
;
GO

-- Test cases
EXEC dbo.TransferFunds 1, 3, 50.00;
EXEC dbo.TransferFunds 99, 3, 99.00;
EXEC dbo.TransferFunds 1, 5, 55.00;
EXEC dbo.TransferFunds 1, 3, 777.00;

SELECT * FROM dbo.BankAccounts;