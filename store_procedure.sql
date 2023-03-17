use School_Db
go

--Store Procedure
-- Load 
CREATE PROCEDURE GetAllStudents
AS
BEGIN
    SELECT * FROM Students
END
go
--load by id
CREATE PROCEDURE GetStudent
@Id int
AS
BEGIN
    SELECT * FROM Students where Id = @Id
END
go
--Create 
CREATE PROCEDURE InsertStudent
    @Name varchar(50),
    @DOB datetime,
    @Address varchar(100),
    @Phone varchar(15),
    @Email varchar(50)
AS
BEGIN
    INSERT INTO Students (Name, DOB, Address, Phone, Email)
    VALUES (@Name, @DOB, @Address, @Phone, @Email)
END
go
--Update
CREATE PROCEDURE UpdateStudent
    @Id int,
    @Name varchar(50),
    @DOB datetime,
    @Address varchar(100),
    @Phone varchar(15),
    @Email varchar(50)
AS
BEGIN
    UPDATE Students
    SET Name = @Name, DOB = @DOB, Address = @Address, Phone = @Phone, Email = @Email
    WHERE Id = @Id
END
go
--delete

CREATE PROCEDURE DeleteStudent
    @Id int
AS
BEGIN
    DELETE FROM Students WHERE Id = @Id
END