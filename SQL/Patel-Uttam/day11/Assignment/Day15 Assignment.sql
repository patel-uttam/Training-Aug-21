USE [Day15 (USP)]


-- Assignment


 /*

-- Create a Store Procedure which will accept name of the customer as input parameter and product the following output, List Names of Customers who are Depositors and have Same Branch City as that of input parameter customer’s Name.

-- Create a Store Procedure which will accept name of the customer as input parameter and produce the following output List in JSON format, All the Depositors Having Depositors Having Deposit in All the Branches where input parameter customer is Having an Account

-- Create a Store Procedure that will accept city name and returns the number of customers in that city.

-- Create a Store Procedure which will accept city of the customer as input parameter and product the following output List in JSON format List All the Customers Living in city provided in input parameter and Having the Branch City as MUMBAI or DELHI

-- Count the Number of Customers Living in the City where Branch is Located

-- Create a Procedure which will accept input in JSON parameter CustomerName,City, ACTNO,Branch,amount  
	And insert these record in the Deposit table. Before inserting some validation should be done like amount should be greater than 10Rs. and date should always be current date.

*/



-- Create a Store Procedure which will accept name of the customer as input parameter and product the following output, List Names of Customers 
-- who are Depositors and have Same Branch City as that of input parameter customer’s Name.

--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	GO
	ALTER PROCEDURE usp_ass_1 
	@name varchar(18)

	AS
	BEGIN
	
	SELECT Cname FROM Deposit d
	JOIN BRANCH b
	ON
	b.BNAME = d.Bname
	where B.CITY = (SELECT CITY FROM BRANCH WHERE BNAME=(SELECT Bname FROM Deposit WHERE Cname=@name))
	
	END
	GO

	usp_ass_1 'SANDIP' WITH RECOMPILE
	GO


--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


-- Create a Store Procedure which will accept name of the customer as input parameter and produce the following output List in JSON format,
-- All the Depositors Having Depositors Having Deposit in All the Branches where input parameter customer is Having an Account

--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	ALTER PROCEDURE usp_ass_2
	@name varchar(10)

	AS
	BEGIN

	SELECT Cname FROM Deposit WHERE Bname IN (SELECT Bname FROM Deposit WHERE Cname = @name) FOR JSON PATH

	END
	GO

	usp_ass_2 'SANDIP'
	GO
--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



-- Create a Store Procedure that will accept city name and returns the number of customers in that city.

--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	
	GO

	CREATE PROCEDURE usp_ass_3
	@city varchar(18)

	AS
	BEGIN

		RETURN(SELECT COUNT(Cname) FROM Deposit WHERE Bname IN (SELECT BNAME FROM BRANCH WHERE CITY = @city))
	END
	GO

	DECLARE @c varchar(18)
	EXECUTE @c = usp_ass_3 'MUMBAI' 
	PRINT @c
	GO
--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




-- Create a Store Procedure which will accept city of the customer as input parameter and product the 
-- following output List in JSON format List All the Customers Living in city provided in input parameter and Having the Branch City as MUMBAI or DELHI

--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	GO

	CREATE PROCEDURE usp_ass_4
	@city varchar(18)

	AS
	BEGIN

		SELECT Cname FROM Deposit WHERE Bname IN (SELECT BNAME FROM BRANCH WHERE CITY = @city) AND Bname IN (SELECT BNAME FROM BRANCH WHERE CITY IN ('MUMBAI','DELHI'))
	END
	GO


	DECLARE @c varchar(18)
	EXECUTE @c = usp_ass_4 'DELHI' 
	PRINT @c
	GO



--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




-- Count the Number of Customers Living in the City where Branch is Located
--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	CREATE PROCEDURE usp_ass_5
	@name varchar(10)

	AS
	BEGIN

	SELECT COUNT(Cname) FROM Deposit WHERE Bname IN (SELECT Bname FROM BRANCH WHERE CITY = @name) 

	END
	GO

	usp_ass_5 'DELHI'
	GO




--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////






--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
