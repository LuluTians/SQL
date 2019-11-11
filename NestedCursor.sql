USE AdventureWorks2012
GO

-- create PurchaseReport table
CREATE TABLE [AdventureWorks2012].[Purchasing].[PurchaseReport] (
	PurchaseReportID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY
	,PurchaseOrderID INT NOT NULL
	,ProductNumber NVARCHAR(25) NOT NULL
	,OrderQty SMALLINT NOT NULL
	,UnitPrice MONEY NOT NULL
	,LineTotal MONEY NOT NULL
	)
GO

--drop PROCEDURE spCreateReport;
-- Create the procedure that populate the PurchaseReport table, this procedure has 2 parameters


-- start of Procedure spCreateReport definition
CREATE PROCEDURE spCreateReport 
	@Year INT -- first parameter
	,@Month INT -- first parameter 
AS

-- delete all the rows from the PurchaseReport table
delete from [AdventureWorks2012].[Purchasing].[PurchaseReport];

-- declare variables to store intermediate values
print 'declare variables'
DECLARE @PurchaseOrderID INT
	,@ProductNumber NVARCHAR(25)
	,@OrderQty SMALLINT
	,@UnitPrice MONEY
	,@LineTotal MONEY;

print 'declare cursor findHeaderByTime'

-- start of CURSOR findHeaderByTime definition
DECLARE findHeaderByTime CURSOR FOR
	SELECT PurchaseOrderID
		FROM [AdventureWorks2012].[Purchasing].[PurchaseOrderHeader]
		WHERE YEAR(OrderDate) = @Year
			AND MONTH(OrderDate) = @Month
	FOR READ ONLY
-- end of CURSOR findHeaderByTime definition

print 'open cursor findHeaderByTime'
OPEN findHeaderByTime
FETCH NEXT FROM  findHeaderByTime
INTO @PurchaseOrderID
WHILE @@FETCH_STATUS = 0
BEGIN
	print 'PurchaseOrderID' 
	print @PurchaseOrderID
	-- declare a nested cursor, that get all the OrderDetail where the PurchaseOrderID from table PurchaseOrderDetail is equal to the parameter @PurchaseOrderID
	-- start of CURSOR findDetailByOrderID definition
	DECLARE findDetailByOrderID CURSOR FOR

		SELECT  d.PurchaseOrderID
				,p.ProductNumber
				,d.OrderQty
				,d.UnitPrice
				,d.LineTotal
		FROM (
			SELECT * FROM [AdventureWorks2012].[Purchasing].[PurchaseOrderDetail] 
			WHERE PurchaseOrderID = @PurchaseOrderID
		) d
		-- using left join to get ProductNumber value
		LEFT JOIN [AdventureWorks2012].[Production].[Product] p ON p.ProductId = d.ProductId
	FOR READ ONLY
	-- end of CURSOR findDetailByOrderID definition
	
	-- execute the cursor, extract the values that we need
	OPEN findDetailByOrderID
	FETCH NEXT FROM findDetailByOrderID
	INTO @PurchaseOrderID
		,@ProductNumber
		,@OrderQty
		,@UnitPrice
		,@LineTotal
	
	-- loop through the result, and insert the final record to PurchaseReport table
	WHILE @@FETCH_STATUS = 0
	BEGIN
		print 'insert into [PurchaseReport] '
		print @PurchaseOrderID
		print @ProductNumber
		print @OrderQty
		INSERT INTO [AdventureWorks2012].[Purchasing].[PurchaseReport] (
			PurchaseOrderID
			,ProductNumber
			,OrderQty
			,UnitPrice
			,LineTotal
			)
		VALUES (
			@PurchaseOrderID
			,@ProductNumber
			,@OrderQty
			,@UnitPrice
			,@LineTotal
			);
		FETCH NEXT FROM findDetailByOrderID
		INTO @PurchaseOrderID
			,@ProductNumber
			,@OrderQty
			,@UnitPrice
			,@LineTotal
	END
	-- close and deallocate the nested cursor, because the @PurchaseOrderID changes every time for the outer cursor findHeaderByTime
	CLOSE findDetailByOrderID
	DEALLOCATE findDetailByOrderID
	
	-- fetch the next value to variable @PurchaseOrderID
	FETCH NEXT FROM  findHeaderByTime
	INTO @PurchaseOrderID

END

-- close and deallocate the outer cursor
close findHeaderByTime
DEALLOCATE findHeaderByTime

--End of Procedure spCreateReport definition



-- execute the procedure with 2 provided parameters
EXEC spCreateReport 2005,5;
GO