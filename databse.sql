USE [master]
GO

/****** Object:  Database [dbSwiftSend]    Script Date: 20/10/2024 22:22:13 ******/
 IF NOT EXISTS (SELECT 1 
           FROM sys.databases 
           WHERE NAME='dbSwiftSend') 
    BEGIN 
        CREATE DATABASE [dbSwiftSend]
    END
GO

USE [dbSwiftSend];
GO

IF NOT EXISTS (SELECT 1 
           FROM INFORMATION_SCHEMA.TABLES 
           WHERE TABLE_NAME='tblClass') 
    BEGIN 
        CREATE TABLE tblClass (
        cid INT IDENTITY(1,1) PRIMARY KEY,
        nameClass VARCHAR(30),
        yearGroup VARCHAR(20),
        number INT
        );

        ALTER TABLE tblClass
        ADD CONSTRAINT tblClass_number_range CHECK (
        number BETWEEN 0 AND 100
        )
    END



IF NOT EXISTS (SELECT 1 
           FROM INFORMATION_SCHEMA.TABLES 
           WHERE TABLE_NAME='tblClass') 
    BEGIN 
    
        CREATE TABLE tblStudents(
        stid INT IDENTITY (1,1) PRIMARY KEY,
        cid INT,
        title VARCHAR (10),
        forename VARCHAR (30),
        surname VARCHAR(30),
        email VARCHAR (100) -- Validate email in C# at later stage
        );

        ALTER TABLE tblStudents
        ADD FOREIGN KEY (clid) 
        REFERENCES tblClass(cid)
    END

