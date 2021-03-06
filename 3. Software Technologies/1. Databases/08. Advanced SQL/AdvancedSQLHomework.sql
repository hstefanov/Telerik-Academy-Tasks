USE TelerikAcademy

/*1. Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
Use a nested SELECT statement. */


SELECT FirstName, LastName, Salary
	FROM Employees
	WHERE Salary = 
		(SELECT MIN(Salary) FROM Employees)


/*2. Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company. */
SELECT FirstName, LastName, Salary
FROM dbo.Employees
WHERE Salary BETWEEN 
	 (SELECT MIN(Salary) FROM Employees) AND 1.1 * 
		(SELECT MIN(Salary) FROM Employees)


/*3. Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department.
Use a nested SELECT statement. */

SELECT e.FirstName, e.LastName, e.Salary, d.Name
FROM dbo.Employees e
INNER JOIN dbo.Departments d
ON e.DepartmentID = d.DepartmentID
WHERE Salary = 
	(SELECT MIN(Salary) FROM dbo.Employees emp
	 WHERE emp.DepartmentID = d.DepartmentID)
ORDER BY Salary


/*4. Write a SQL query to find the average salary in the department #1. */
SELECT AVG(Salary) as [Avarage Salary]
FROM dbo.Employees
WHERE DepartmentID = 1


/* 5. Write a SQL query to find the average salary in the "Sales" department. */
SELECT AVG(e.Salary) as [Avarage Salary]
FROM dbo.Employees e
INNER JOIN dbo.Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'


/* 6. Write a SQL query to find the number of employees in the "Sales" department. */
SELECT COUNT(*) as [Number of employees]
FROM dbo.Employees e
INNER JOIN dbo.Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'


/* 7. Write a SQL query to find the number of all employees that have manager */
SELECT COUNT(ManagerID) as [Manger Employee Count] 
FROM dbo.Employees


/* 8. Write a SQL query to find the number of all employees that have no manager. */

SELECT COUNT(*) as [Managers Count]
FROM dbo.Employees
WHERE ManagerID IS NULL
 

/* 9. Write a SQL query to find all departments and the average salary for each of them. */

SELECT AVG(e.Salary) as [Avarage Salary], d.Name as [Department]
FROM dbo.Employees e
INNER JOIN dbo.Departments d
ON e.DepartmentID = d.DepartmentID
GROUP BY (d.Name) 
ORDER BY [Avarage Salary]


/* 10. Write a SQL query to find the count of all employees in each department and for each town. */

SELECT COUNT(e.EmployeeID) AS [Employee Count], t.Name AS [Town], d.Name AS [Department]
FROM dbo.Employees e
INNER JOIN dbo.Departments d
ON e.DepartmentID = d.DepartmentID
INNER JOIN dbo.Addresses a
ON e.AddressID = a.AddressID
INNER JOIN dbo.Towns t
ON a.TownID = t.TownID
GROUP BY d.Name,t.Name
ORDER BY d.Name


/* 11. Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name. */
SELECT e.EmployeeID as [Manager ID], e.FirstName + ' ' + e.LastName AS [Full Name], COUNT(e.EmployeeID) AS [Employees Count]
FROM dbo.Employees e
INNER JOIN dbo.Employees m
ON e.EmployeeID = m.ManagerID
GROUP BY e.EmployeeID, e.FirstName, e.LastName
HAVING COUNT(e.EmployeeID) > 5


/* 12. Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)". */
SELECT e.FirstName + ' ' + e.LastName AS [Employee Name],
COALESCE(m.FirstName + ' ' + m.LastName,'no manager') AS [Manager Name]
FROM dbo.Employees e
LEFT JOIN dbo.Employees m
ON e.EmployeeID = m.ManagerID


/* 13. Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-in LEN(str) function. */
SELECT LastName
FROM dbo.Employees
WHERE LEN(LastName) > 5


/* 14. Write a SQL query to display the current date and time in the following format "day.month.year hour:minutes:seconds:milliseconds". */
SELECT FORMAT(GETDATE(),'dd.MM.yy HH:mm:ss:ff');

/* 15. Write a SQL statement to create a table Users. Users should have username, password, full name and last login time.
Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint.
Define the primary key column as identity to facilitate inserting records.
Define unique constraint to avoid repeating usernames.
Define a check constraint to ensure the password is at least 5 characters long. */

CREATE TABLE Users (
UserId int IDENTITY PRIMARY KEY,
Username nvarchar(50) NOT NULL CHECK (LEN(Username) > 3 ) UNIQUE,
Pass nvarchar(256) NOT NULL CHECK (LEN(Pass) > 5),
FullName nvarchar(50) NOT NULL CHECK(LEN(FullName) > 5),
LastLoginTime DATETIME NOT NULL
)


/* 16. Write a SQL statement to create a view that displays the users from the Users table that have been in the system today. */
CREATE VIEW [Logged Users Today] AS
  SELECT Username FROM Users
  WHERE DATEDIFF(DAY,LastLoginTime,GETDATE()) = 0


/*17. Write a SQL statement to create a table Groups. Groups should have unique name (use unique constraint).
Define primary key and identity column. */
CREATE TABLE Groups (
	GroupId int IDENTITY PRIMARY KEY,
	NAME nvarchar(50) NOT NULL UNIQUE
	)


/*18. Write a SQL statement to add a column GroupID to the table Users.
Fill some data in this new column and as well in the `Groups table.
Write a SQL statement to add a foreign key constraint between tables Users and Groups tables. */
ALTER TABLE Users
	ADD GroupId int NOT NULL

ALTER TABLE Users
	ADD CONSTRAINT FK_Users_Groups
	FOREIGN KEY (GroupId)
	REFERENCES Groups(GroupId)


/* 19. Write SQL statements to insert several records in the Users and Groups tables. */
INSERT INTO Groups VALUES
    ('Facebook'),
    ('Twitter'),
    ('LinkedIn'),
    ('Gmail'),
    ('Telerik Academy'),
    ('SoftUni')

INSERT INTO Users VALUES
    ('username1', 'qwerty1', 'Unnamed1', '2010-3-06 00:00:00', 1),
    ('username2', 'qwerty2', 'Unnamed2', '2010-3-07 00:00:00', 2),
    ('username3', 'qwerty3', 'Unnamed3', '2010-3-08 00:00:00', 3),
    ('username4', 'qwerty4', 'Unnamed4', '2010-3-09 00:00:00', 4),
    ('username5', 'qwerty5', 'Unnamed5', '2010-3-10 00:00:00', 5),
    ('username6', 'qwerty6', 'Unnamed6', '2010-3-11 00:00:00', 6),
    ('username7', 'qwerty7', 'Unnamed7', '2010-3-12 00:00:00', 7),
    ('username8', 'qwerty8', 'Unnamed8', '2010-3-13 00:00:00', 8),
    ('username9', 'qwerty9', 'Unnamed9', '2010-3-14 00:00:00', 9)

/* 20. Write SQL statements to update some of the records in the Users and Groups tables. */
UPDATE Users
	SET Username = REPLACE(Username,'username','evenUser')
	WHERE [GroupId] % 2 = 0

/* 21. Write SQL statements to delete some of the records from the Users and Groups tables. */
DELETE
    FROM Users
    WHERE GroupId IN (3, 4, 5)

DELETE
    FROM Groups
    WHERE GroupId IN (3, 4, 5)

/* 22. Write SQL statements to insert in the Users table the names of all employees from the Employees table.
Combine the first and last names as a full name.
For username use the first letter of the first name + the last name (in lowercase).
Use the same for the password, and NULL for last login time. */

INSERT INTO Users (Username, FullName, Pass)
        (SELECT LOWER(CONCAT(FirstName, '.', LastName)),
                CONCAT(FirstName, ' ', LastName),
                LOWER(CONCAT(FirstName, '.', LastName))
        FROM Employees)
GO

/* 23. Write a SQL statement that changes the password to NULL for all users that have not been in the system since 10.03.2010.*/

UPDATE Users
    SET Pass = NULL
    WHERE DATEDIFF(day, LastLoginTime, '2010-3-10 00:00:00') > 0
GO

/* 24. Write a SQL statement that deletes all users without passwords (NULL password). */

DELETE FROM Users
WHERE Pass IS NULL
GO

/* 25. Write a SQL query to display the average employee salary by department and job title. */

SELECT ROUND(AVG(e.Salary),2) as [Avarage Salary], d.Name as [Department], e.JobTitle as [Job Title]
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle
ORDER BY d.Name

/* 26 . Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it. */

SELECT ROUND(MIN(e.Salary),2) as [Minimal Salary], d.Name as [Department], 
MIN(CONCAT(e.FirstName,' ',e.LastName)) as [Full Name]
FROM Employees e 
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle
ORDER BY d.Name

/* 27. Write a SQL query to display the town where maximal number of employees work. */

SELECT TOP 1 t.Name AS [Town], COUNT(e.EmployeeID) AS [EmployeesCount]
FROM Employees e
JOIN Addresses d
ON e.AddressID = d.AddressID
JOIN Towns t
ON t.TownID = d.TownID
GROUP BY t.Name


/* 28.  Write a SQL query to display the number of managers from each town. */

SELECT t.Name as [Town], COUNT(e.EmployeeID) as [ManagerCount]
FROM Employees e
JOIN Addresses d
ON e.AddressID = d.AddressID
JOIN Towns t
ON t.TownID = d.TownID
GROUP BY t.Name


/* 29. Write a SQL to create table WorkHours to store work reports for each employee (employee id, date, task, hours, comments).
Don't forget to define identity, primary key and appropriate foreign key.
Issue few SQL statements to insert, update and delete of some data in the table.
Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers.
For each change keep the old record data, the new record data and the command (insert / update / delete).
*/

--- TABLE: WorkHours
CREATE TABLE WorkHours (
    WorkReportId int IDENTITY,
    EmployeeId Int NOT NULL,
    OnDate DATETIME NOT NULL,
    Task nvarchar(256) NOT NULL,
    Hours Int NOT NULL,
    Comments nvarchar(256),
    CONSTRAINT PK_Id PRIMARY KEY(WorkReportId),
    CONSTRAINT FK_Employees_WorkHours 
        FOREIGN KEY (EmployeeId)
        REFERENCES Employees(EmployeeId)
) 
GO

--- INSERT
DECLARE @counter int;
SET @counter = 20;
WHILE @counter > 0
BEGIN
    INSERT INTO WorkHours(EmployeeId, OnDate, Task, [Hours])
    VALUES (@counter, GETDATE(), 'TASK: ' + CONVERT(varchar(10), @counter), @counter)
    SET @counter = @counter - 1
END

--- UPDATE
UPDATE WorkHours
    SET Comments = 'Work hard or go home!'
    WHERE [Hours] > 10

--- DELETE
DELETE 
    FROM WorkHours
    WHERE EmployeeId IN (1, 3, 5, 7, 13)

--- TABLE: WorkHoursLogs
CREATE TABLE WorkHoursLogs (
    WorkLogId int,
    EmployeeId Int NOT NULL,
    OnDate DATETIME NOT NULL,
    Task nvarchar(256) NOT NULL,
    Hours Int NOT NULL,
    Comments nvarchar(256),
    [Action] nvarchar(50) NOT NULL,
    CONSTRAINT FK_Employees_WorkHoursLogs
        FOREIGN KEY (EmployeeId)
        REFERENCES Employees(EmployeeId),
    CONSTRAINT [CC_WorkReportsLogs] CHECK ([Action] IN ('Insert', 'Delete', 'DeleteUpdate', 'InsertUpdate'))
) 
GO

--- TRIGGER FOR INSERT
CREATE TRIGGER tr_InsertWorkReports ON WorkHours FOR INSERT
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT WorkReportId, EmployeeID, OnDate, Task, [Hours], Comments, 'Insert'
    FROM inserted
GO

--- TRIGGER FOR DELETE
CREATE TRIGGER tr_DeleteWorkReports ON WorkHours FOR DELETE
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT WorkReportId, EmployeeID, OnDate, Task, [Hours], Comments, 'Delete'
    FROM deleted
GO

--- TRIGGER FOR UPDATE
CREATE TRIGGER tr_UpdateWorkReports ON WorkHours FOR UPDATE
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT WorkReportId, EmployeeID, OnDate, Task, [Hours], Comments, 'InsertUpdate'
    FROM inserted

INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT WorkReportId, EmployeeID, OnDate, Task, [Hours], Comments, 'DeleteUpdate'
    FROM deleted
GO

--- TEST TRIGGERS
DELETE 
    FROM WorkHoursLogs

INSERT INTO WorkHours(EmployeeId, OnDate, Task, [Hours])
    VALUES (25, GETDATE(), 'TASK: 25', 25)

DELETE 
    FROM WorkHours
    WHERE EmployeeId = 25

UPDATE WorkHours
    SET Comments = 'Updated'
    WHERE EmployeeId = 2

GO

/* 30. Start a database transaction, delete all employees from the 'Sales' department along with all dependent records from the pother tables.
At the end rollback the transaction. */

BEGIN TRAN

    ALTER TABLE Departments
        DROP CONSTRAINT FK_Departments_Employees
    GO

    DELETE 
        FROM Employees e
        JOIN Departments d
            ON e.DepartmentID = d.DepartmentID
        WHERE d.Name = 'Sales'

ROLLBACK TRAN

/* 31. Start a database transaction and drop the table EmployeesProjects.
Now how you could restore back the lost table data? */

BEGIN TRANSACTION

    DROP TABLE EmployeesProjects

ROLLBACK TRANSACTION


/* 32. Find how to use temporary tables in SQL Server.
Using temporary tables backup all records from EmployeesProjects and restore them back after dropping and re-creating the table. */

BEGIN TRANSACTION

    SELECT * 
        INTO #TempEmployeesProjects  --- Create new table
        FROM EmployeesProjects

    DROP TABLE EmployeesProjects

    SELECT * 
        INTO EmployeesProjects --- Create new table
        FROM #TempEmployeesProjects

    DROP TABLE #TempEmployeesProjects

ROLLBACK TRANSACTION











