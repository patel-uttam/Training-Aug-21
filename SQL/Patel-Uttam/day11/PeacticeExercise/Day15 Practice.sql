
USE [Day15 (USP)]
GO


-- Practice Exercise

/*
	What is Store Procedure
	Built in Store Procedure
	Creating Store Procedure with input and output parameter
	Executing Store Procedure
	Returning multiple resultset
	Return JSON output from Store Procedure
	Use the SET NOCOUNT ON
	WITH ENCRYPTION
	Exception Handling
	Using Try Catch
*/


-- Store Procedure / Stored Procedure : Store Procedure is bunch of SQL statement stored or saved in database.
								--		Main benefit of Store procedure is once we create Store Procedure then we can execute from within database environment.
								--		Store procedure accept input parameters and return multiple values in output parameters to the calling program.
								--		return status value to the calling program to indicate status.
								
								-- Benefits 
									-- Reduce network traffic
									-- Security
									-- Reduce the number of time we have to write simillar code.
									-- it improve execute , because when procedure compile first then procedure create one execution plan that reuse everytime procedure execute.



-- Buit-in Procedure : 









-- Creating Store Procedure with input and output parameter : 'CREATE' use to define Store procedure 


--1 without parameter
--///////////////////////////////////////////////////////////////////

-- store procedure to select all from Employees	
	CREATE PROC usp1
	AS
	SET NOCOUNT ON;
	SELECT * FROM Employees 
	GO

	usp1	--(executing store procedure)
	GO
	--DROP PROCEDURE usp1
	--GO
--///////////////////////////////////////////////////////////////////




--2 with input parameter
--///////////////////////////////////////////////////////////////////

	-- store procedure to select FullName of give name Employee from Employees
	CREATE PROCEDURE usp2 
	
	@name varchar(20) 

	AS
	SET NOCOUNT ON;
	SELECT (FirstName + ' ' + LastName) as'FullName' FROM Employees WHERE FirstName = @name
	GO 


--///////////////////////////////////////////////////////////////////


--3 with output parameter

--///////////////////////////////////////////////////////////////////

	-- find number of department under ManagerID = 0
	ALTER PROC usp3 
	@id int,
	@Dept int OUTPUT 

	AS
	BEGIN
	SELECT @Dept = COUNT(DepartmentName) FROM Departments WHERE ManagerID = @id
	END
	GO


--///////////////////////////////////////////////////////////////////






--Executing Store Procedure : EXEC / EXECUTE is use to execute Store Procedure , procedure without parameter can directly execute only by name of store procedure.


--///////////////////////////////////////////////////////////////////

	-- execution of usp1
	usp1
	GO

	
	-- execution of usp2 method 1
	usp2  @name = 'David' -- Executing procedure
	GO

	-- execution of usp2 method 2
	EXEC usp2  @name = 'David' -- Executing procedure
	GO


	-- execute of usp3 method 1 
	DECLARE @numdept int		
	EXECUTE usp3 0 , @numdept OUTPUT
	PRINT @numdept
	GO

	-- execute of usp3 method 2
	DECLARE @numdept int		
	EXECUTE usp3 @Dept = @numdept OUTPUT , @id=0
	PRINT @numdept
	GO


--///////////////////////////////////////////////////////////////////





-- Returning multiple resultset : 

--///////////////////////////////////////////////////////////////////




--///////////////////////////////////////////////////////////////////





-- Return JSON output from Store Procedure : 

--///////////////////////////////////////////////////////////////////

	CREATE PROCEDURE usp4 

	AS
	BEGIN
		SELECT FirstName , LastName , Salary FROM Employees FOR JSON PATH
	END
	GO

	usp4 
	GO
--///////////////////////////////////////////////////////////////////





-- Use the SET NOCOUNT ON : SET NOCOUNT ON prevent sending message to client , that improve execution time. 

--///////////////////////////////////////////////////////////////////

	ALTER PROCEDURE usp5 

	AS
	SET NOCOUNT ON;
	BEGIN
		SELECT FirstName , LastName , Salary FROM Employees
	END
	GO

	usp5 
	GO

--///////////////////////////////////////////////////////////////////





-- WITH ENCRYPTION : 'WITH ENCRYPTION' use to encrypt or prevent accessing 'generate script' of PROCEDURE.
				--    Nobody access it.

--///////////////////////////////////////////////////////////////////

	CREATE PROCEDURE usp6 WITH ENCRYPTION
	AS
	BEGIN
	SELECT * FROM Departments
	END
	GO

	sp_helptext usp6
	GO
--///////////////////////////////////////////////////////////////////







-- Recompile : 'RECOMPILE' use to recompile the procedure again at time of execution. (mostly procedure not compile every time.)
			-- 'RECOMPILE' required when significant changes done in procedure.


--///////////////////////////////////////////////////////////////////

	ALTER PROCEDURE usp7 
	@id int OUTPUT,
	@name varchar(20)
	AS
	BEGIN
		SELECT @id=MIN(Salary) FROM Employees WHERE FirstName = @name
	END
	GO

	usp7 
	GO

	--OR
	DECLARE @id1 int
	EXECUTE usp7 @id1 OUTPUT ,'David'
	PRINT @id1
	GO
	--OR

	EXEC sp_recompile 'usp7'
	DECLARE @id int
	EXEC usp7 @id=@id OUT , @name='Steven'
	PRINT @id
	GO
--///////////////////////////////////////////////////////////////////
