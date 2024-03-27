use trainingdb

	--1. Write a T-SQL Program to find the factorial of a given number.
DECLARE @inputNumber INT = 5 

WITH FactorialCTE AS (
    SELECT @inputNumber AS InputNumber, 1 AS Counter, 1 AS Factorial

    UNION ALL

    SELECT InputNumber, Counter + 1, Factorial * (Counter + 1)
    FROM FactorialCTE
    WHERE Counter < InputNumber
)
SELECT Factorial
FROM FactorialCTE
OPTION (MAXRECURSION 0)



--2. Create a stored procedure to generate multiplication tables up to a given number.

CREATE PROCEDURE GenerateMultiplicationTable  
@maxNumber INT 
AS
BEGIN
    DECLARE @counter INT = 1;
    WHILE @counter <= @maxNumber
    BEGIN
        DECLARE @multiplicand INT = 1;
        WHILE @multiplicand <= 10
        BEGIN
            DECLARE @result INT = @counter * @multiplicand;
            PRINT CONCAT(@counter, ' x ', @multiplicand, ' = ', @result);
            SET @multiplicand = @multiplicand + 1;
        END
        PRINT '';
        SET @counter = @counter + 1;
    END
END

-- example for multication of SP tables
EXEC GenerateMultiplicationTable @maxNumber = 5

