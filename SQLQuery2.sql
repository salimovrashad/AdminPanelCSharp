CREATE DATABASE EmployeeDB
USE EmployeeDB

CREATE TABLE Employees(
	ID int identity primary key,
	Name nvarchar(255),
	Position nvarchar(255),
	Office nvarchar(255),
	Age int,
	StartDate date,
	Salary int
);
SELECT * FROM Employees