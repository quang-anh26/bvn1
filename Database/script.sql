-- Chạy script này trong SSMS (hoặc SQL Server Object Explorer của Visual Studio)
IF DB_ID(N'WebBaiTapDb') IS NULL
    CREATE DATABASE WebBaiTapDb;
GO

USE WebBaiTapDb;
GO

IF OBJECT_ID(N'dbo.Product', N'U') IS NOT NULL
    DROP TABLE dbo.Product;
GO

CREATE TABLE dbo.Product
(
    Id    INT IDENTITY(1,1) PRIMARY KEY,
    Name  NVARCHAR(200)  NOT NULL,
    Price DECIMAL(18,2)  NOT NULL
);
GO

INSERT INTO dbo.Product (Name, Price) VALUES
(N'Laptop Dell XPS', 25000000),
(N'iPhone 15',       22000000),
(N'Chuột Logitech',  450000),
(N'Bàn phím cơ',     1200000),
(N'Màn hình LG 27"', 4500000);
GO

SELECT * FROM dbo.Product;
GO
