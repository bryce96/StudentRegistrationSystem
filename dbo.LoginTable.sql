CREATE TABLE [dbo].[LoginTable] (
    [Username] VARCHAR (50) NOT NULL,
    [Password] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_LoginTable] PRIMARY KEY CLUSTERED ([Username] ASC)
);

