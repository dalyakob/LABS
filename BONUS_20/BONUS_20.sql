--Bonus 20

--Documentation https://dataedo.com/download/AdventureWorks.pdf

--Q1
SELECT 
    *
FROM Sales.Customer;

--Q2
SELECT
    FirstName,
    LastName,
    PA.City
FROM Sales.Customer AS SC
JOIN Person.Person AS PP
ON SC.PersonID = PP.BusinessEntityID --found in documentation for adventureworks 
JOIN Person.BusinessEntityAddress AS PBE
ON PP.BusinessEntityID = PBE.BusinessEntityID
JOIN Person.Address AS PA
ON PBE.AddressID = PA.AddressID
WHERE PA.City = 'London' OR PA.City = 'Paris';

--Q3
SELECT
    FirstName,
    LastName,
    PA.City
FROM Sales.Customer SC
JOIN Person.Person PP
JOIN Person.BusinessEntityAddress AS PB
  ON SC.PersonID = PP.BusinessEntityID --found in documentation for adventureworks 
JOIN Person.Address PA
  ON PB.AddressID = PA.AdressID
WHERE City IS NOT NULL;

--Q4
SELECT
FirstName
FROM HumanResources.Employee AS HRE
JOIN Person.Person AS PP
ON HRE.BusinessEntityID = PP.BusinessEntityID
ORDER BY PP.FirstName DESC;

--Q5
SELECT
AVG(Rate) AS AverageSalaryHourly
FROM HumanResources.EmployeePayHistory;

--Q6
SELECT 
FirstName,
LastName
FROM HumanResources.EmployeePayHistory HR
JOIN Person.Person PP
  ON HR.BusinessEntityID = PP.BusinessEntityID
WHERE HR.Rate = (
    SELECT Max(Rate)
    FROM HumanResources.EmployeePayHistory
);

--Q7
SELECT
*
FROM HumanResources.Employee HE
JOIN Person.Person PP
  ON HE.BusinessEntityID = PP.BusinessEntityID
JOIN Sales.vPersonDemographics SPD
  ON SPD.BusinessEntityID = PP.BusinessEntityID
WHERE SPD.Education = 'BA%';

--Q8
SELECT
TotalDue
FROM Purchasing.PurchaseOrderHeader;

--Q9
SELECT
FirstName,
LastName,
HR.HireDate
FROM HumanResources.Employee HR
JOIN Person.Person PP
  ON HR.BusinessEntityID = PP.BusinessEntityID
WHERE HR.HireDate >= '1-1-1994';

--Q10
SELECT
FirstName,
LastName,
DATEDIFF(YEAR,HR.HireDate, GETDATE()) YearsWorking
FROM HumanResources.Employee HR
JOIN Person.Person PP
ON HR.BusinessEntityID = PP.BusinessEntityID
WHERE HR.HireDate >= '1-1-1994';

--Q11 
--ASCENDING ORDER
SELECT 
PP.Name,
SUM(PI.Quantity)
FROM Production.Product PP
JOIN Production.ProductInventory PI
ON PP.ProductID = PI.ProductID
GROUP BY Name
ORDER BY SUM(PI.Quantity);

--DESCENDING ORDER
SELECT 
PP.Name,
SUM(PI.Quantity)
FROM Production.Product PP
JOIN Production.ProductInventory PI
ON PP.ProductID = PI.ProductID
GROUP BY Name
ORDER BY SUM(PI.Quantity) DESC;

--Q12
SELECT 
PP.Name,
SUM(PI.Quantity)
FROM Production.Product PP
JOIN Production.ProductInventory PI
ON PP.ProductID = PI.ProductID
GROUP BY Name
HAVING SUM(PI.Quantity) < 6;

--Q13
SELECT
Name,
SellEndDate
FROM Production.Product
WHERE SellEndDate IS NOT NULL;

--Q14
--Nothing found with tofu in the description
SELECT
P.Name,
PD.[Description]
FROM Production.Product P
JOIN Production.ProductModel PM
 ON P.ProductModelID = PM.ProductModelID
JOIN Production.ProductModelProductDescriptionCulture PDC
 ON PM.ProductModelID = PDC.ProductModelID
JOIN Production.ProductDescription PD
 ON PDC.ProductDescriptionID = PD.ProductDescriptionID
WHERE PD.[Description] LIKE '%tofu%'

--Q15
SELECT TOP 1
P.Name,
PO.UnitPrice
FROM Production.Product P
JOIN Purchasing.PurchaseOrderDetail PO
  ON P.ProductID = PO.ProductID
ORDER BY PO.UnitPrice DESC 

--Q16
SELECT
FirstName,
LastName,
HR.HireDate
FROM HumanResources.Employee HR
JOIN Person.Person PP
  ON HR.BusinessEntityID = PP.BusinessEntityID
WHERE HR.HireDate > '1-1-1993';

--Q17
SELECT
P.FirstName,
P.LastName,
P.Title
FROM HumanResources.Employee HE
JOIN Person.Person P
ON HE.BusinessEntityID = P.BusinessEntityID
WHERE P.Title = 'MS.' OR P.Title = 'Mrs.';

--Q18
SELECT
P.FirstName,
P.LastName,
PP.PhoneNumber
FROM HumanResources.Employee HE
JOIN Person.Person P
ON HE.BusinessEntityID = P.BusinessEntityID
JOIN Person.PersonPhone PP
  ON P.BusinessEntityID = PP.BusinessEntityID
WHERE PP.PhoneNumber LIKE '206%'