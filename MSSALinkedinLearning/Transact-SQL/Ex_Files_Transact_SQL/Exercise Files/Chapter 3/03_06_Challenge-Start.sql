-- Challenge Two Start
USE WideWorldImporters;
GO

-- Create an audit table for customer accounts
CREATE TABLE Sales.CustomerAccountAudit (
    AuditID INT IDENTITY PRIMARY KEY,
    CustomerID INT,
    ReviewDate datetime2
);
GO

-- View existing data
SELECT * FROM Sales.Customers;
SELECT * FROM Sales.Orders;
GO

-- Write a stored procedure to:
-- 1) view information from Sales.Customers
-- 2) view information from Sales.Orders
-- 3) write a row to Sales.CustomerAccountAudit to log activity

CREATE OR ALTER PROCEDURE Sales.SalesInfo (@Customer AS INT)
AS
SELECT CustomerID, CustomerName, PhoneNumber
	FROM Sales.Customers
	WHERE CustomerID = @Customer;
SELECT OrderID, CustomerID, ExpectedDeliveryDate
	FROM Sales.Orders
	WHERE CustomerID = @Customer;
INSERT INTO Sales.CustomerAccountAudit (CustomerID, ReviewDate)
	VALUES (@Customer, GETDATE());
GO

EXEC Sales.SalesInfo 1;
GO

SELECT * FROM Sales.CustomerAccountAudit;
GO