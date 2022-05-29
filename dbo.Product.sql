CREATE TABLE [dbo].[Product] (
    [PId]    INT             IDENTITY (1, 1) NOT NULL,
    [PName]  NVARCHAR (50)   NULL,
    [Prices] INT             NULL,
    [Number] INT             NULL,
    [Img]    VARBINARY (MAX) NULL,
    PRIMARY KEY CLUSTERED ([PId] ASC)
);

