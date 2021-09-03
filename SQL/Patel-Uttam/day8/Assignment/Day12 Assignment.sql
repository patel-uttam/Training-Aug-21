USE [Day12 (Batch)]

-- Assignment


---------------------------------------------------------------------------------------------------------

-- Batch
/*
Create a batch Select Banking as ‘Bank Dept’, Insurance as ‘Insurance Dept’ and Services as ‘Services Dept’ from
employee table
*/

SELECT EMPLOYEE_ID , FIRST_NAME , LAST_NAME , SALARY , 'Department' = CASE DEPARTMENT 
															WHEN 'Banking' THEN 'Bank Dept'
															WHEN 'Insurance' THEN 'Insurance Dept'
															WHEN 'Services' THEN 'Services Dept'
															ELSE DEPARTMENT
															END 
													FROM Employee

---------------------------------------------------------------------------------------------------------