USE AdventureWorks2012
GO

CREATE TABLE [AdventureWorks2012].[Purchasing].[PurchaseReport] (
	PurchaseReportID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY
	,PurchaseOrderID INT NOT NULL
	,ProductNumber NVARCHAR(25) NOT NULL
	,OrderQty SMALLINT NOT NULL
	,UnitPrice MONEY NOT NULL
	,LineTotal MONEY NOT NULL
	)
GO

-- spCreateReport
CREATE PROCEDURE spCreateReport @Year INT
	,@Month INT
AS
	
INSERT INTO [AdventureWorks2012].[Purchasing].[PurchaseReport]

	SELECT d.PurchaseOrderID
		,p.ProductNumber
		,d.OrderQty
		,d.UnitPrice
		,d.LineTotal
	FROM (
		SELECT *
		FROM [AdventureWorks2012].[Purchasing].[PurchaseOrderDetail]
		WHERE PurchaseOrderID IN (
				SELECT PurchaseOrderID
				FROM [AdventureWorks2012].[Purchasing].[PurchaseOrderHeader]
				WHERE YEAR(OrderDate) = @Year
					AND MONTH(OrderDate) = @Month
				)
		) d
	LEFT JOIN [AdventureWorks2012].[Production].[Product] p ON p.ProductId = d.ProductId

EXEC spCreateReport 2005, 5;
GO

