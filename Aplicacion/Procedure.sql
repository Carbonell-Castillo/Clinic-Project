/*Stored Procedures*/

/*Clinic*/
CREATE PROCEDURE addClinic
    @id varchar(13),
    @name varchar(30),
    @location varchar(40),
    @sector varchar(20)
AS
INSERT INTO clinics(id, name, location, sector)
VALUES(@id, @name, @location, @sector);
GO;

CREATE PROCEDURE viewClinics
AS
SELECT * FROM clinics;
GO;

CREATE PROCEDURE viewClinicById
    @id varchar(13)
AS
SELECT * FROM clinics WHERE id = @id;
GO;

/*Users*/

CREATE PROCEDURE addUser
    @userId varchar(13),
    @clinicId varchar(13),
    @roleId int,
    @username varchar(13),
    @name varchar(13),
    @password varchar(15)
AS
INSERT INTO users(userId, clinicId, roleId, username, name, password)
VALUES(@userId, @clinicId, @roleId, @username, @name, @password);
GO;


CREATE PROCEDURE viewUsers
AS
SELECT userId, clinicId, roleId, role.name, username, users.name, password FROM users INNER JOIN role
ON users.roleId = role.id;
GO;

CREATE PROCEDURE validateUser
    @username varchar(13),
    @password varchar(15)
AS
SELECT userId, clinicId, roleId, role.name, username, users.name, password
FROM users
INNER JOIN role ON users.roleId = role.id
WHERE username COLLATE SQL_Latin1_General_CP1_CS_AS = @username COLLATE SQL_Latin1_General_CP1_CS_AS
    AND password COLLATE SQL_Latin1_General_CP1_CS_AS = @password COLLATE SQL_Latin1_General_CP1_CS_AS;
GO;

/*Patient*/
CREATE PROCEDURE addPatient
    @dpi varchar(13),
    @name varchar(15),
    @age varchar(3),
    @gender varchar(12)
AS
INSERT INTO patient(dpi, name, age, gender)
VALUES(@dpi, @name, @age, @gender);
GO;

CREATE PROCEDURE viewPatients
AS
SELECT * FROM patient;
GO;

CREATE PROCEDURE viewPatientByDPI
    @dpi varchar(13)
AS
SELECT * FROM patient WHERE dpi = @dpi;
GO;

/*Category*/
CREATE PROCEDURE addCategory
    @id varchar(12),
    @name varchar(13)
AS
INSERT INTO category(id, name)
VALUES(@id, @name);
GO;

CREATE PROCEDURE viewCategories
AS
SELECT * FROM category;
GO;

/*Role*/
CREATE PROCEDURE addRole
    @id int,
    @name varchar(13)
AS
INSERT INTO role(id, name)
VALUES(@id, @name);
GO;

CREATE PROCEDURE viewRoles
AS
SELECT * FROM role;
GO;

/*Inventory*/
create procedure addInventory
    @id varchar(16), 
    @clinicId varchar(13),
    @categoryId varchar(13),
    @name varchar(12), 
    @quantity int, 
    @price decimal
as
insert into inventory(id, clinicId, categoryId, name, quantity, price)
values(@id, @clinicId, @categoryId, @name, @quantity, @price);
go;

CREATE PROCEDURE viewInventory
AS
SELECT inventory.id, clinicId, categoryId, category.name, inventory.name, quantity, price 
FROM inventory INNER JOIN category
ON inventory.categoryId = category.id;
GO;

CREATE PROCEDURE viewInventoryByClinic
    @clinicId varchar(13)
AS
SELECT inventory.id, clinicId, categoryId, category.name, inventory.name, quantity, price 
FROM inventory INNER JOIN category
ON inventory.categoryId = category.id
WHERE clinicId = @clinicId;
GO;

CREATE PROCEDURE viewInventoryByCategory
    @clinicId varchar(13),
    @categoryId varchar(12)
AS
SELECT inventory.id, clinicId, categoryId, category.name, inventory.name, quantity, price 
FROM inventory INNER JOIN category
ON inventory.categoryId = category.id
WHERE categoryId = @categoryId AND clinicId = @clinicId;
GO;

CREATE PROCEDURE searchInventoryById
    @id varchar(16)
AS
SELECT inventory.id, clinicId, categoryId, category.name, inventory.name, quantity, price 
FROM inventory INNER JOIN category
ON inventory.categoryId = category.id
WHERE inventory.id = @id;


/*Financial*/

CREATE PROCEDURE addIncomeStatement
    @rowId int,
    @counts varchar(30),
    @quantity decimal(10, 2)
AS
BEGIN
    INSERT INTO incomeStatement (rowId, counts, quantity)
    VALUES (@rowId, @counts, @quantity);
END;
GO;

CREATE PROCEDURE viewIncomeStatement
AS
BEGIN
    SELECT * FROM incomeStatement;
END;
GO;

CREATE PROCEDURE UpdateIncomeStatement
    @rowId int,
    @counts varchar(30),
    @quantity decimal(10, 2)
AS
BEGIN
    UPDATE incomeStatement
    SET counts = @counts,
        quantity = @quantity
    WHERE rowId = @rowId;
END;
GO;

CREATE PROCEDURE GetNetIncome
AS
BEGIN
    SELECT quantity
    FROM incomeStatement
    WHERE counts = 'Ingresos Netos';
END;

CREATE PROCEDURE addBalanceSheetActive
    @rowId int,
    @counts varchar(30),
    @quantity decimal(10, 2)
AS
BEGIN
    INSERT INTO BalanceSheetActive (rowId, counts, quantity)
    VALUES (@rowId, @counts, @quantity);
END;
GO;

CREATE PROCEDURE viewBalanceSheetActive
AS
BEGIN
    SELECT * FROM BalanceSheetActive;
END;
GO;

CREATE PROCEDURE updateBalanceSheetActive
    @rowId int,
    @counts varchar(30),
    @quantity decimal(10, 2)
AS
BEGIN
    UPDATE BalanceSheetActive
    SET counts = @counts,
        quantity = @quantity
    WHERE rowId = @rowId;
END;
GO;

CREATE PROCEDURE addBalanceSheetPassiveCapital
    @rowId int,
    @counts varchar(30),
    @quantity decimal(10, 2)
AS
BEGIN
    INSERT INTO BalanceSheetPassiveCapital (rowId, counts, quantity)
    VALUES (@rowId, @counts, @quantity);
END;
GO;

CREATE PROCEDURE viewBalanceSheetPassiveCapital
AS
BEGIN
    SELECT * FROM BalanceSheetPassiveCapital;
END;
GO;

CREATE PROCEDURE updateBalanceSheetPassiveCapital
    @rowId int,
    @counts varchar(30),
    @quantity decimal(10, 2)
AS
BEGIN
    UPDATE BalanceSheetPassiveCapital
    SET counts = @counts,
        quantity = @quantity
    WHERE rowId = @rowId;
END;
GO;