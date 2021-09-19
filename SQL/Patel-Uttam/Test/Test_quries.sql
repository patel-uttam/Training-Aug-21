--CREATE DATABASE Test_Assignment

USE Test_Assignment


-- Table Creation and Insertion
--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

--CREATE TABLE Campus
--(CampusID Varchar(5) CONSTRAINT Campus_CampusID_PK Primary key, 
--CampusName varchar(20) NOT NULL,
--Street varchar(50) NOT NULL , 
--City varchar(15) NOT NULL, 
--State varchar(20) NOT NULL,
--Zip varchar(5) NOT NULL, 
--Phone varchar(13) NOT NULL, 
--CampusDiscount Decimal(4,2)
--);

--INSERT INTO Campus 
--			VALUES
--			('1','IUPUI','425 University Blvd.','Indianapolis', 'IN','46202', '317-274-4591',.08),
--			('2','Indiana University','107 S. Indiana Ave.','Bloomington', 'IN','47405', '812-855-4848',.07),
--			('3','Purdue University','475 Stadium Mall Drive','West Lafayette', 'IN','47907', '765-494-1776',.06);

--SELECT * FROM Campus


--CREATE TABLE Position
--(
--PositionID varchar(5) CONSTRAINT Position_PositionID_PK PRIMARY KEY, 
--Position varchar(20) NOT NULL, 
--YearlyMembershipFee decimal(9,2) CONSTRAINT check_YearlyMembershipFee_check CHECK(YearlyMembershipFee > 0)
--);

--INSERT INTO Position
--			VALUES
--			('6','Lecturer', 1050.505),
--			('2','Associate Professor', 900.50),
--			('3','Assistant Professor', 875.50),
--			('4','Professor', 700.75),
--			('5','Full Professor', 500.50);

--SELECT * FROM Position


--CREATE TABLE Members
--(
--MemberID varchar(2) PRIMARY KEY, 
--LastName varchar(15) NOT NULL, 
--FirstName varchar(15) NOT NULL, 
--CampusAddress varchar(50) NOT NULL, 
--CampusPhone varchar(13) NOT NULL,
--CampusID varchar(5) NOT NULL CONSTRAINT FK_campusID FOREIGN KEY REFERENCES Campus(CampusID), 
--PositionID varchar(5) NOT NULL CONSTRAINT FK_position_ID FOREIGN KEY REFERENCES Position(PositionID), 
--ContractDuration int NOT NULL CONSTRAINT check_contractduration CHECK(ContractDuration>0 AND ContractDuration<1000)
--);


--INSERT INTO Members
--			VALUES
--			('1','Ellen','Monk','009 Purnell', '812-123-1234', '2', '5', 12),
--			('2','Joe','Brady','008 Statford Hall', '765-234-2345', '3', '2', 10),
--			('3','Dave','Davidson','007 Purnell', '812-345-3456', '2', '3', 10),
--			('4','Sebastian','Cole','210 Rutherford Hall', '765-234-2345', '3', '5', 10),
--			('5','Michael','Doo','66C Peobody', '812-548-8956', '2', '1', 10),
--			('6','Jerome','Clark','SL 220', '317-274-9766', '1', '1', 12),
--			('7','Bob','House','ET 329', '317-278-9098', '1', '4', 10),
--			('8','Bridget','Stanley','SI 234', '317-274-5678', '1', '1', 12),
--			('9','Bradley','Wilson','334 Statford Hall', '765-258-2567', '3', '2', 10);

--SELECT * FROM Members





--CREATE TABLE Prices
--(
--FoodItemTypeID int CONSTRAINT Prices_FoodItemTypeID_PK PRIMARY KEY IDENTITY(1,1),
--MealType varchar(15) NOT NULL, 
--MealPrice decimal(9,2) NOT NULL
--);

--INSERT INTO Prices(MealType,MealPrice)
--			VALUES
--			('Beer/Wine', 5.50),
--			('Dessert', 2.75), 
--			('Dinner', 15.50),
--			('Soft Drink', 2.50),
--			('Lunch', 7.25);

--SELECT * FROM Prices


--CREATE TABLE FoodItems
--(
--FoodItemID varchar(5) CONSTRAINT FoodItems_FoodItemID_PK PRIMARY KEY,
--FoodItemName varchar(20) NOT NULL, 
--FoodItemTypeID int NOT NULL CONSTRAINT FoodItems_FoodItemTypeID_FK FOREIGN KEY REFERENCES Prices(FoodItemTypeID)
--);

--INSERT INTO FoodItems
--			VALUES
--			('10001','Lager', 1),
--			('10002','Red Wine', 1),
--			('10003','White Wine',1),
--			('10004','Coke',4),
--			('10005','Coffee',4),
--			('10006','Chicken a la King', 3),
--			('10007','Rib Steak', 3),
--			('10008','Fish and Chips', 3),
--			('10009','Veggie Delight', 3),
--			('10010','Chocolate Mousse', 2),
--			('10011','Carrot Cake', 2),
--			('10012','Fruit Cup', 2),
--			('10013','Fish and Chips', 5),
--			('10014','Angus Beef Burger', 5),
--			('10015','Cobb Salad', 5);

--SELECT * FROM FoodItems


	--CREATE TABLE Orders
	--(
	--OrderID varchar(5) CONSTRAINT Orders_OrderID_PK PRIMARY KEY,
	--MemberID varchar(2) NOT NULL CONSTRAINT Orders_MemberID_FK FOREIGN KEY REFERENCES Members(MemberID),
	--OrderDate DATE DEFAULT GetDate()
	--);

	--INSERT INTO Orders(OrderID,MemberID)
	--			VALUES
	--			('1', '9'),
	--			('2','8'),
	--			('3','7'),
	--			('4','6'),
	--			('5','5'),
	--			('6','4'),
	--			('7','3'),
	--			('8','2'),
	--			('9','1');

	--SELECT * FROM Orders


--CREATE TABLE OrderLine
--(
--OrderID varchar(5) NOT NULL CONSTRAINT OrderLine_OrderID_FK FOREIGN KEY REFERENCES Orders(OrderID),
--FoodItemsID varchar(5) NOT NULL CONSTRAINT OrderLine_FoodItemID_FK FOREIGN KEY REFERENCES FoodItems(FoodItemID),
--Quantity int NOT NULL CONSTRAINT check_Quantity CHECK(Quantity>0 AND Quantity<1000)
--);

--INSERT INTO OrderLine
--			VALUES 
--			('1','10001',1),
--			('1','10006',1),
--			('1','10012',1),
--			('2','10004',2),
--			('2','10013',1),
--			('2','10014',1),
--			('3','10005',1),
--			('3','10011',1),
--			('4','10005',2),
--			('4','10004',2),
--			('4','10006',1),
--			('4','10007',1),
--			('4','10010',2),
--			('5','10003',1),
--			('6','10002',2),
--			('7','10005',2),
--			('8','10005',1),
--			('8','10011',1),
--			('9','10001',1);

--SELECT * FROM OrderLine

--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////







-- Queries
--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


  
/*	Create a listing of all Faculty Members (First and Last), their Faculty Position and the University that they are affiliated with (Name),
	along with their Monthly_Dues (Calculated Field with a column alias). Sort the records in descending order by University and then by Faculty's last name in ascending order. */

-----------------------------------------------------------------------------------------------------------------------------------------------
	SELECT CONCAT(m.FirstName,' ',m.LastName) as 'Faculty Name' , p.Position , c.CampusName , (P.YearlyMembershipFee/12) as 'MonthlyDue' FROM Members as m
	JOIN Campus as c
	ON m.CampusID = c.CampusID
	JOIN Position as p
	ON p.PositionID = m.PositionID
	
-----------------------------------------------------------------------------------------------------------------------------------------------



/* Create a listing that shows the various food items that the faculty club serves (Name of the food item, 
type of food item and the price of the food item). Note: List no alcoholic beverages. Sort therecords in ascending order by price. */

-----------------------------------------------------------------------------------------------------------------------------------------------
	SELECT f.FoodItemName as 'Food' , p.MealType as 'FoodType' , p.MealPrice as 'Price' FROM  FoodItems as f
	JOIN Prices as p
	ON F.FoodItemTypeID=p.FoodItemTypeID
	WHERE p.FoodItemTypeID <> 1 ORDER BY p.MealPrice ASC

-----------------------------------------------------------------------------------------------------------------------------------------------


/* List the OrderID, Order Date, Faculty Member's Name, Campus Name, each FoodItem that makes u.p a given order, the type of meal, 
cost of the meal, quantity ordered and the total line total (calculated field and columnalias). Sort by Order IDs in descending order. */

-----------------------------------------------------------------------------------------------------------------------------------------------


	SELECT o.OrderID , o.OrderDate , m.FirstName, m.LastName , c.CampusName , fi.FoodItemName , p.MealType , p.MealPrice , ol.Quantity , SUM(p.MealPrice) , SUM(ol.Quantity) ,GROUPING_ID(p.MealPrice) as 'TotalPrice' , GROUPING_ID(ol.Quantity) as 'Total Quantity' FROM OrderLine as ol
	join Orders as o
	ON o.OrderID = ol.OrderID
	JOIN Members as m
	ON m.MemberID = o.MemberID
	JOIN Campus as c
	ON c.CampusID=m.CampusID
	JOIN FoodItems as fi
	ON fi.FoodItemID = ol.FoodItemsID
	JOIN Prices as p
	ON p.FoodItemTypeID = fi.FoodItemTypeID
	GROUP BY  ROLLUP(o.OrderID,o.OrderDate,m.FirstName, m.LastName,c.CampusName,fi.FoodItemName,MealType,p.MealType,p.MealPrice,ol.Quantity)
	ORDER BY O.OrderID DESC

-----------------------------------------------------------------------------------------------------------------------------------------------
