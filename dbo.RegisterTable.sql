CREATE TABLE [dbo].[RegisterTable] (
    [First_Name]       VARCHAR (50) NOT NULL,
    [Last_Name]        VARCHAR (50) NOT NULL,
    [Student_ID]       INT          NOT NULL,
    [Email]            VARCHAR (50) NOT NULL,
    [Class]            VARCHAR (50) NOT NULL,
    [Additional_Notes] VARCHAR (50) NULL,
    [Registration_ID]  INT          IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_RegisterTable] PRIMARY KEY CLUSTERED ([Registration_ID] ASC)
);

