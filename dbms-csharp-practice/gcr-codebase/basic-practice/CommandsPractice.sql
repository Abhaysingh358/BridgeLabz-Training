-- CREATE DATABASE database_name;
-- USE database_name

-- DDL 
-- SYNTAX
-- CREATE TABLE table_name (
--   column datatype constraints
-- );

create  database practicedb;
use practicedb;

create table users(
userId int Primary key identity (1,1),
userName varchar (50) not null,
email varchar (100) unique,
createdate datetime default getdate()
);

-- SYNTAX
-- ALTER TABLE table_name ADD column datatype;

alter table users add isActive bit default 1;

-- SYNTAX
-- DROP TABLE table_name;

-- DROP TABLE Users; -- use it later if it will be needed

-- DML Data Manipulation Language

-- SYNTAX:
-- INSERT INTO table_name (column1, column2)
-- VALUES (value1, value2);

INSERT INTO users (userName, email)
VALUES 
('Aarav Sharma', 'aarav.sharma@example.com'),
('Ananya Iyer', 'ananya.iyer@example.com'),
('Vihaan Reddy', 'vihaan.reddy@example.com'),
('Aditi Gupta', 'aditi.gupta@example.com'),
('Arjun Das', 'arjun.das@example.com'),
('Saanvi Joshi', 'saanvi.joshi@example.com'),
('Ishaan Nair', 'ishaan.nair@example.com'),
('Diya Verma', 'diya.verma@example.com'),
('Advait Kulkarni', 'advait.kulkarni@example.com'),
('Myra Malhotra', 'myra.malhotra@example.com'),
('Reyansh Bhatt', 'reyansh.bhatt@example.com'),
('Anika Bose', 'anika.bose@example.com'),
('Vivaan Saxena', 'vivaan.saxena@example.com'),
('Aavya Kapoor', 'aavya.kapoor@example.com'),
('Kabir Singh', 'kabir.singh@example.com'),
('Kiara Mehra', 'kiara.mehra@example.com'),
('Aaryan Deshmukh', 'aaryan.deshmukh@example.com'),
('Riya Pandey', 'riya.pandey@example.com'),
('Dhruv Agarwal', 'dhruv.agarwal@example.com'),
('Zoya Khan', 'zoya.khan@example.com');

-- SYNTAX:
-- UPDATE table_name
-- SET column = value
-- WHERE condition;

UPDATE users 
SET isActive = 0
WHERE userName  = 'Kabir Singh';

-- DQL 
-- SELECT * FROM table_name
SELECT * FROM users;

-- SYNTAX:
-- CREATE TABLE table_name (
--   column datatype,
--   CONSTRAINT fk_name
--   FOREIGN KEY (column) REFERENCES parent_table(parent_column)
-- );

create table orders(
orderId int primary key identity(1,1),
userId int not null,
orderAmount decimal (10,2) not null,
orderDate datetime default getdate(),
constraint Fk_Orders_Users 
foreign key (userId) references users(UserId)
);


-- INSERT INTO table_name (col1, col2)
-- VALUES (val1, val2);

INSERT INTO Orders (UserId, OrderAmount)
VALUES
(1, 2500),
(1, 1800),
(2, 3200),
(3, 1500);

-- verifying relationship between orders and users table
select * from orders;

-----------------------------------------------------------------
-- joins practice
-- 1st is Inner join
-- syntax
-- SELECT columns
-- FROM table1
-- INNER JOIN table2
-- ON condition;

select u.userName ,o.orderAmount ,o.orderDate
from users u 
inner join orders o on u.userId = o.userId;


-- 2nd Left Join 
-- syntax
-- select columns
-- from table 1
-- left join table 2
-- on condition ;

select u.userName , o.orderAmount
from users u 
left join orders o on u.userId = o.orderId;

-- 3rd right join
--syntax
-- SELECT columns
-- FROM table1
-- RIGHT JOIN table2
-- ON condition;
SELECT 
    U.UserName,
    O.OrderAmount
FROM Orders O
RIGHT JOIN Users U
ON O.UserId = U.UserId;


-------------------------------------------------------------
-- practicing dcl command 
-- step 1 
-- Security setup  for login server level
-- syntax
-- CREATE LOGIN login_name WITH PASSWORD = 'password';
USE master;
GO
CREATE LOGIN dcl_user WITH PASSWORD = 'Dcl@123';
GO

-- step 2 
-- create user at database level
-- syntax
-- CREATE USER user_name  FOR LOGIN login_name;

USE practicedb;
GO 
CREATE USER dcl_user FOR LOGIN dcl_user;
GO

-- step 3 
-- GRANT Permissions (DCL)
-- syntax:
-- GRANT permission ON object TO user

GRANT SELECT ON users TO dcl_user;
GO

-- multiple permissions can be granted 
GRANT INSERT, UPDATE ON Users TO dcl_user;
GO

-- STEP 4 — REVOKE permissions (DCL)

-- REVOKE permission ON object FROM user;
REVOKE UPDATE ON users FROM dcl_user;


-- DENY permission ON object TO user;
-- DENY > GRANT
-- DENY DELETE ON Users TO dcl_user;
-- GO

-- Verify Permissions 
-- check permissions to show table has access of what permissions like insert, update etc.
SELECT * 
FROM fn_my_permissions('Users', 'OBJECT');

--------------------------------------------------------------------------------------
-- TCL 
-- BEGIN TRANSACTION + ROLLBACK(UNDO);
-- ROLLBACK;
BEGIN TRANSACTION;
UPDATE users
SET isActive  = 0
WHERE userName  = 'Aarav Sharma';

-- undo changes
ROLLBACK;

-- to verify , print the user name and is Actice status
select userName ,isActive  from users where  userName = 'Aarav Sharma';

--------------------------------------------------------------------------------------
-- begin transaction with COMMIT
-- BEGIN TRANSACTION;
-- COMMIT;

BEGIN TRANSACTION;

UPDATE users
SET IsActive = 0
WHERE userName = 'Vihaan Reddy';

COMMIT;

-- to verify , print the user name and is Actice status
select userName ,isActive  from users where  userName = 'Vihaan Reddy';

--------------------------------------------------------------------------------------
-- TRANSACTION with INSERT And  ROLLBACK
BEGIN TRANSACTION;
INSERT INTO users (userName , email)
VALUES ('Test User' , 'testing.user@gmail.com');
ROLLBACK;

-- to verify , print the user name and is Actice status
select * from users where  userName = 'Test User';

---------------------------------------------------------------------------------------
-- SAVEPOINT (Partial ROLLBACK)
-- SAVE TRANSACTION savepoint_name;
-- ROLLBACK TRANSACTION savepoint_name;

BEGIN TRANSACTION;
INSERT INTO users (userName ,email)
VALUES ('Test User1' ,'test.user1@gmail.com');

-- saving transaction at a point named sp1;
SAVE TRANSACTION sp1;
INSERT INTO users (userName ,email)
VALUES ('Test User2' ,'test.user2@gmail.com');

-- Roll back only second insert
ROLLBACK TRANSACTION sp1;
COMMIT;

--verify it using select query
SELECT * FROM Users
WHERE UserName IN ('Test User1', 'Test User2');

---------------------------------------------------------------------------------------

--TCL + ERROR SIMULATION :

BEGIN TRANSACTION;
UPDATE users SET email = NULL WHERE userID = 1; -- it is violating not null property which is set before
-- SQL SERVER errors here
ROLLBACK;

-- to verify the error handling using roll back 
select userName ,email  from users where  userID = 1;

-----------------------------------------------------------------------------------------------------
-- =======================================================================================================
-- working on Normalisation 
-- first UnNormalised table will be created

CREATE TABLE StudentDetails(
StudentID INT , 
StudentName VARCHAR(50),
DepartmentName VARCHAR(50),
Courses VARCHAR(200)  -- in this table multiple value can be inserted in one coloumn named Courses 
);

INSERT INTO StudentDetails
(StudentID, StudentName, DepartmentName, Courses)
VALUES
(1, 'Arjun', 'CSE','Math, Science'),
(2,'Abhay','CSE','Math'),
(3, 'Karan', 'ECE', 'Signals, Networks');


Select * from StudentDetails WHERE Courses LIKE '%Math%'; -- slow , not index friendly

-- above table breaks the rule of 1 NF , below is the 1NF Design
CREATE TABLE Students(
StudentId INT PRIMARY KEY,
StudentName VARCHAR(50),
DepartmentName VARCHAR(50)
);

CREATE TABLE Courses(
StudentID INT ,
CourseName VARCHAR(50),
PRIMARY KEY (StudentID , CourseName)
);

INSERT INTO Students (StudentId, StudentName, DepartmentName)
VALUES 
(101, 'Arjun Mehta', 'Computer Science'),
(102, 'Priya Sharma', 'Electrical Engineering'),
(103, 'Rohan Gupta', 'Mechanical Engineering'),
(104, 'Ishita Iyer', 'Information Technology'),
(105, 'Siddharth Nair', 'Civil Engineering');

INSERT INTO Courses (StudentID, CourseName)
VALUES 
(101, 'Database Management'),
(102, 'Power Systems'),
(103, 'Thermodynamics'),
(104, 'Cloud Computing'),
(105, 'Structural Analysis');


/* In above 1NF tables  need a fix  . the forein key is missing 
We do not yet know:
whether Students is final,whether StudentID will remain unchanged,whether CourseName should be a separate entity.*/

/* Foreign keys are introduced when:
entities are clearly separated
dependencies are understood
design is near final .*/

-- In StudentCourses:
-- Primary Key = (StudentID, CourseName)
-- But department info depends only on StudentID in 2NF Partial dependency is solved And Apply when compiste key exists

-- 2NF Design also solved 3nf 
-- in above Student table , studentId->departmentId->DepartmentName which violates 3 nf rule called transitive dependency.
-- So Department is shifted in Departments Table , Students reference it via foreign key and enrollments table has only keys.

DROP TABLE IF EXISTS Students;
DROP TABLE IF EXISTS Courses;

CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(50),
);

CREATE TABLE Students(
    StudentId INT PRIMARY KEY,
    StudentName VARCHAR(50),
    DepartmentId INT ,
    FOREIGN KEY (DepartmentId) REFERENCES Departments(DepartmentId)
);

CREATE TABLE Courses(
    CourseId INT PRIMARY KEY,
    CourseName VARCHAR(50)
);

CREATE TABLE Enrollments(
    StudentId INT,
    CourseId INT,
    PRIMARY KEY (StudentId , CourseId),
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

INSERT INTO Departments (DepartmentID, DepartmentName) VALUES 
(1, 'Computer Science'),
(2, 'Electrical Engineering'),
(3, 'Mechanical Engineering');

INSERT INTO Students (StudentId, StudentName, DepartmentId) VALUES 
(101, 'Aarav Sharma', 1),
(102, 'Ananya Iyer', 1),
(103, 'Vihaan Reddy', 2),
(104, 'Aditi Gupta', 2),
(105, 'Arjun Das', 3);


INSERT INTO Courses (CourseId, CourseName) VALUES 
(501, 'Machine Learning'),
(502, 'Digital Signal Processing'),
(503, 'Robotics'),
(504, 'Data Structures');


INSERT INTO Enrollments (StudentId, CourseId) VALUES 
(101, 501), -- Aarav takes ML
(101, 504), -- Aarav takes Data Structures
(102, 501), -- Ananya takes ML
(103, 502), -- Vihaan takes DSP
(105, 503); -- Arjun takes Robotics

-- displaying each table 
SELECT * FROM Departments;
SELECT * FROM Students;
SELECT * FROM Courses;
SELECT * FROM Enrollments;

-- displaying whole table using left join
select s.StudentId ,s.StudentName ,c.CourseId ,c.CourseName
from Students s 

left join Departments d 
    on s.DepartmentId = d.DepartmentID

left join Enrollments e
    on s.StudentId = e.StudentId

left join Courses c 
    on e.CourseId = c.CourseId

order by s.StudentId;

