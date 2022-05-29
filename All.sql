create database EndClass;
go
use EndClass;
go
CREATE TABLE [dbo].[Users] (
    [UId]      INT           IDENTITY (1, 1) NOT NULL,
    [UName]    NVARCHAR (50) NULL,
    [Mail]     NCHAR (50)    NOT NULL,
    [Password] NCHAR (50)    NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UId] ASC),
    UNIQUE NONCLUSTERED ([UName] ASC),
    UNIQUE NONCLUSTERED ([UName] ASC)
);
CREATE TABLE [dbo].[Product] (
    [PId]    INT             IDENTITY (1, 1) NOT NULL,
    [PName]  NVARCHAR (50)   NULL,
    [Prices] INT             NULL,
    [Number] INT             NULL,
    [Img]    VARBINARY (MAX) NULL,
    PRIMARY KEY CLUSTERED ([PId] ASC)
);
