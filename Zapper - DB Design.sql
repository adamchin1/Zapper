USE [Zapper]

CREATE TABLE Customer (
    CustomerId INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(100) NOT NULL,
    LastName VARCHAR(100) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    Settings VARCHAR(8) NOT NULL; -- 8 digit settings code
    CreateDate DATETIME
);

CREATE TABLE Merchant (
    MerchantId INT IDENTITY(1,1) PRIMARY KEY,
    MerchantName VARCHAR(100) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    CreateDate DATETIME
);

CREATE TABLE [Transaction] (
    TransactionId INT IDENTITY(1,1) PRIMARY KEY,
    CustomerId INT,
    MerchantId INT,
    ProductId INT
    Amount DECIMAL(10, 2) NOT NULL,
    TransactionDate DATETIME,
    StatusId INT
);

-- Optional Extra
CREATE TABLE Product (
    ProductId INT IDENTITY(1,1) PRIMARY KEY,
    MerchantId INT,
    [Description] VARCHAR(100) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    CreateDate DATETIME
);

