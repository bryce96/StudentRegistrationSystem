CREATE TABLE [dbo].[ClassTable] (
    [Class_Name]      VARCHAR (50) NOT NULL,
    [Class_Capacity]  INT          NOT NULL,
    [Seats_Remaining] INT          NOT NULL,
    [Class_Cost]      INT          NOT NULL,
    [Credit_Hours]    INT          NOT NULL,
    CONSTRAINT [PK_ClassTable] PRIMARY KEY CLUSTERED ([Class_Name] ASC),
    CONSTRAINT [FK_ClassTable_RegistrationTable] FOREIGN KEY ([Class_Name]) REFERENCES [dbo].[ClassTable] ([Class_Name])
);

