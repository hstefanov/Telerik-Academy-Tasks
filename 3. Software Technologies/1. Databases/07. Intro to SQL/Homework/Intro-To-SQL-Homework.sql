/*TASK 01: What is SQL? What is DML? What is DDL? Recite 
the most important SQL commands.
SQL - Structured Query Language is a special-purpose programming language designed 
for managing data held in a relational database management system (RDBMS), 
or for stream processing in a relational data stream management system (RDSMS).
Originally based upon relational algebra and tuple relational calculus, 
SQL consists of a data definition language, data manipulation language, 
and a data control language. The scope of SQL includes data insert, query, update and delete,
 schema creation and modification, and data access control.
*/

/*TASK 02: What is Transact-SQL (T-SQL)?
Transact-SQL (T-SQL) is Microsoft's and Sybase's proprietary extension to SQL. 
SQL, the acronym for Structured Query Language, is a standardized computer language 
that was originally developed by IBM for querying, altering and defining relational 
databases, using declarative statements. T-SQL expands on the SQL standard to include
procedural programming, local variables, various support functions for string processing, 
date processing, mathematics, etc. and changes to the DELETE and UPDATE statements.
*/


USE TelerikAcademy
/*
TASK 04: Write a SQL query to find all information about all departments
(use "TelerikAcademy" database). */

GO
SELECT *
FROM dbo.Departments
GO

/*
TASK 05: Write a SQL query to find all department names. */
SELECT Name
FROM dbo.Departments
GO

/*
TASK 06: Write a SQL query to find the salary of each employee. */
SELECT Salary
FROM dbo.Employees
GO

/*
TASK 07: Write a SQL to find the full name of each employee. */
SELECT FirstName + ' ' + LastName AS 'FullName'
FROM dbo.Employees 
GO

/*
TASK 08: Write a SQL query to find the email addresses of each employee 
(by his first and last name). Consider that the mail domain is 
telerik.com. Emails should look like "John.Doe@telerik.com". The 
produced column should be named "Full Email Addresses". */

SELECT FirstName + '.' + LastName + '@telerik.com' AS 'Full Email Adresses'
FROM dbo.Employees
GO

/*
TASK 09: Write a SQL query to find all different employee salaries. */
 SELECT DISTINCT Salary
 FROM dbo.Employees
 GO

 /*
TASK 10: Write a SQL query to find all information about the employees 
whose job title is "Sales Representative".*/
SELECT *
FROM dbo.Employees e
WHERE e.JobTitle = 'Sales Representative'
GO

/*
TASK 11: Write a SQL query to find the names of all employees whose 
first name starts with "SA". */
SELECT FirstName + ' '  + LastName as 'FullName'
FROM dbo.Employees e
WHERE FirstName LIKE 'SA%'
GO

/*
TASK 12: Write a SQL query to find the names of all employees whose last
name contains "ei". */
SELECT FirstName + ' ' + LastName as 'FullName'
FROM dbo.Employees
WHERE LastName LIKE '%ei%'
GO

/*
TASK 13: Write a SQL query to find the salary of all employees whose 
salary is in the range [20000�30000]. */
SELECT *
FROM dbo.Employees 
WHERE Salary BETWEEN 20000 AND 30000
GO

/*
TASK 14: Write a SQL query to find the names of all employees whose 
salary is 25000, 14000, 12500 or 23600. */
SELECT *
FROM dbo.Employees
WHERE Salary in (25000,14000,12500,23600)
GO


/*
ASK 15: Write a SQL query to find all employees that do not have manager. */
SELECT * 
FROM dbo.Employees
WHERE ManagerID IS NULL
GO

/*
TASK 16: Write a SQL query to find all employees that have salary more 
than 50000. Order them in decreasing order by salary. */
SELECT * 
FROM dbo.Employees
WHERE Salary > 50000
ORDER BY Salary DESC
GO

/*
TASK 17: Write a SQL query to find the top 5 best paid employees. */
SELECT TOP 5 FirstName, LastName, Salary
FROM dbo.Employees
ORDER BY Salary DESC
GO


/*
TASK 18: Write a SQL query to find all employees along with their 
address. Use inner join with ON clause. */
SELECT *
FROM dbo.Employees e
INNER JOIN dbo.Addresses a
ON e.AddressID = a.AddressID
GO

/*
TASK 19: Write a SQL query to find all employees and their address. Use 
equijoins (conditions in the WHERE clause). */
SELECT * 
FROM dbo.Employees e, dbo.Addresses a
WHERE e.AddressID = a.AddressID
GO

/*TASK 20: Write a SQL query to find all employees along with their manager.
*/
SELECT e.FirstName + ' ' + e.LastName as 'EmployeeName', m.FirstName + ' ' + m.LastName as 'ManagerName'
FROM dbo.Employees e
JOIN dbo.Employees m
ON e.EmployeeID = m.ManagerID
GO

/*
TASK 21: Write a SQL query to find all employees, along with their 
manager and their address. Join the 3 tables: Employees e, Employees m 
and Addresses a. */

SELECT e.FirstName + ' ' + e.LastName as 'EmployeeName', m.FirstName + ' ' + m.LastName as 'ManagerName', a.AddressText
FROM dbo.Employees e
JOIN dbo.Employees m
ON e.EmployeeID = m.ManagerID
JOIN dbo.Addresses a
ON e.AddressID = a.AddressID
GO

/*TASK 22: Write a SQL query to find all departments and all town names as
a single list. Use UNION.*/
SELECT Name as 'Departments and Towns'
FROM dbo.Departments
UNION
SELECT Name as 'Departments and Towns'
FROM dbo.Towns
GO

/* TASK 23: Write a SQL query to find all the employees and the manager for
each of them along with the employees that do not have manager. Use right
outer join. Rewrite the query to use left outer join. */
SELECT e.FirstName + ' ' + e.LastName as 'EmployeeName', m.FirstName + ' ' + m.LastName as 'ManagerName'
FROM dbo.Employees e
RIGHT OUTER JOIN dbo.Employees m
ON e.EmployeeID = m.ManagerID
GO

SELECT e.FirstName + ' ' + e.LastName as 'EmployeeName', m.FirstName + ' ' + m.LastName as 'ManagerName'
FROM dbo.Employees e
LEFT OUTER JOIN dbo.Employees m
ON e.EmployeeID = m.ManagerID
GO

/*
TASK 24: Write a SQL query to find the names of all employees from the 
departments "Sales" and "Finance" whose hire year is between 1995 and 2005. */
SELECT e.FirstName + ' ' + e.LastName as 'EmployeeName', e.HireDate, d.Name
FROM dbo.Employees e
INNER JOIN dbo.Departments d
ON e.DepartmentID = d.DepartmentID
WHERE (d.Name = 'Sales' OR d.Name = 'Finance') AND
e.HireDate BETWEEN '1955-01-01 00:00:00' AND '2005-01-01 00:00:00'
GO

