CREATE TABLE clinics (
    id varchar(13) primary key, 
    name varchar(40),
    location varchar(30),
    sector varchar(20)
);

CREATE TABLE users (
    userId varchar(13) primary key, 
    clinicId varchar(13),
    roleId int,
    username varchar(30),
    name varchar(50),
    password varchar(15)
);

CREATE TABLE patient (
    dpi varchar(13) primary key, 
    name varchar(50),
    age varchar(3),
    gender varchar(12)
);

/* Store prescription in the DB for better */
CREATE TABLE prescription (
    id VARCHAR(12) PRIMARY KEY,
    doctorId VARCHAR(13),
    patientId VARCHAR(13),
    date DATE,
    prescription VARBINARY(MAX)
);

CREATE TABLE category (
    id varchar(12) primary key, 
    name varchar(13)
);

CREATE TABLE role (
    id int primary key, 
    name varchar(13)
);

CREATE TABLE inventory (
    id varchar(16) primary key, 
    clinicId varchar(13),
    categoryId varchar(13),
    name varchar(100), 
    quantity int, 
    price decimal
);

CREATE TABLE incomeStatement (
    rowId int primary key, 
    counts varchar(30),
    quantity DECIMAL(10, 2)
);
GO;

CREATE TABLE BalanceSheetActive (
    rowId int primary key, 
    counts varchar(30),
    quantity DECIMAL(10, 2)
);
GO;

CREATE TABLE BalanceSheetPassiveCapital (
    rowId int primary key, 
    counts varchar(30),
    quantity DECIMAL(10, 2)
);
GO;