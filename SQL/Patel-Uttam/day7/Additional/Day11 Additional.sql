USE PracticeExercise

-- Partitioned view

-- Creating Table 4

CREATE TABLE Shipments_Q1 (
Ship_Num INT NOT NULL,
Ship_CountryCode C HAR(3) NOT NULL,
Ship_Date DATETIME NULL,
Ship_Quarter SMALLINT NOT NULL CONSTRAINT CK_Ship_Q1 CHECK (Ship_Quarter = 1),
CONSTRAINT PK_Shipments_Q1 PRIMARY KEY (Ship_Num, Ship_Quarter)
);
 
GO
CREATE TABLE Shipments_Q2 (
Ship_Num INT NOT NULL,
Ship_CountryCode CHAR(3) NOT NULL,
Ship_Date DATETIME NULL,
Ship_Quarter SMALLINT NOT NULL CONSTRAINT CK_Ship_Q2 CHECK (Ship_Quarter = 2),
CONSTRAINT PK_Shipments_Q2 PRIMARY KEY (Ship_Num, Ship_Quarter)
);
 
 GO
CREATE TABLE Shipments_Q3 (
Ship_Num INT NOT NULL,
Ship_CountryCode CHAR(3) NOT NULL,
Ship_Date DATETIME NULL,
Ship_Quarter SMALLINT NOT NULL CONSTRAINT CK_Ship_Q3 CHECK (Ship_Quarter = 3),
CONSTRAINT PK_Shipments_Q3 PRIMARY KEY (Ship_Num, Ship_Quarter)
);
 
GO
CREATE TABLE Shipments_Q4 (
Ship_Num INT NOT NULL,
Ship_CountryCode CHAR(3) NOT NULL,
Ship_Date DATETIME NULL,
Ship_Quarter SMALLINT NOT NULL CONSTRAINT CK_Ship_Q4 CHECK (Ship_Quarter = 4),
CONSTRAINT PK_Shipments_Q4 PRIMARY KEY (Ship_Num, Ship_Quarter)
);
GO


-- Creating view

CREATE VIEW partitonview1 WITH SCHEMABINDING
AS
SELECT Ship_Num ,Ship_CountryCode,Ship_Date,Ship_Quarter FROM dbo.Shipments_Q1
UNION ALL
SELECT Ship_Num ,Ship_CountryCode,Ship_Date,Ship_Quarter FROM dbo.Shipments_Q2 
UNION ALL
SELECT Ship_Num ,Ship_CountryCode,Ship_Date,Ship_Quarter FROM dbo.Shipments_Q3 
UNION ALL
SELECT Ship_Num ,Ship_CountryCode,Ship_Date,Ship_Quarter FROM dbo.Shipments_Q4 
GO

-- inserting data in view

INSERT INTO partitonview1 VALUES (1,'IN',GETDATE(),1),
								(1,'IN',GETDATE(),2),
								(1,'US',GETDATE(),4),
								(1,'IN',GETDATE(),3),
								(2,'SA',GETDATE(),3),
								(2,'UK',GETDATE(),2),
								(2,'IN',GETDATE(),1),
								(2,'IN',GETDATE(),4),
								(3,'UK',GETDATE(),2),
								(3,'US',GETDATE(),1);



SELECT * FROM partitonview1 WHERE Ship_Quarter=3
SELECT * FROM partitonview1 WHERE Ship_Quarter=1
SELECT * FROM partitonview1 WHERE Ship_Quarter=2
SELECT * FROM partitonview1 WHERE Ship_Quarter=4
GO



