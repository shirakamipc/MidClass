CREATE TABLE [dbo].[Users] (
	[UId]      Int           Identity(1,1),
    [UName]    NVARCHAR (50) Unique,
    [Mail]     NCHAR (50)    NOT NULL,
    [Password] NCHAR (50)    NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UId] ASC)
);

