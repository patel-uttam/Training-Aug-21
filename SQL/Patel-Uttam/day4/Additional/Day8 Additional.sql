USE PracticeExercise


-- Grouping and Grouping_ID 

--Grouping : Grouping is function that indicates that the column from GROUP BY is aggregated or not.
--			Grouping function takes one column as argument , column should be from GROUP BY list.

CREATE TABLE Location_Sale 
(
Continent varchar(50) NULL , 
Country varchar(50) NULL ,
City varchar(50) NULL ,
SaleAmount int NULL,
);


INSERT into Location_Sale 
Values
('Asia','India','Ahmedabad',2000),
('Asia','India','Mumbai',3000),
('Europe','England','Oxford',2500),
('Europe','England','London',5000),
('Europe','Italy','',1500),
('Europe','Italy','ROMA',1500),
('Asia','Russia','MOSCCO',1400),
('Asia','Russia','Bashkortostan,',500);


DELETE Location_Sale


SELECT  Continent , Country , City , SUM(SaleAmount) FROM Location_Sale GROUP BY ROLLUP (Continent , Country , City)


SELECT City , SUM(SaleAmount) as 'TotalSale', GROUPING(City) as 'Grouping_city' FROM Location_Sale GROUP BY ROLLUP (City)


-- Grouping 
SELECT 
Continent , Country , City ,SUM(SaleAmount) as 'TotalSale', GROUPING(Country) as 'Grouping_continent',GROUPING(Country) as 'Grouping_country',GROUPING(City) as 'Grouping_city' FROM Location_Sale GROUP BY ROLLUP(Continent ,Country,City)



SELECT Continent , Country , City , SUM(SaleAmount) as 'TotalSale', GROUPING(City) as 'Grouping_continent' FROM Location_Sale GROUP BY Continent ,Country,City



