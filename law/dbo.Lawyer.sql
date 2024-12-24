CREATE TABLE [dbo].[Lawyer] (
    [ID]   INT          IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (50) NOT NULL,
    [Birthdate]   VARCHAR (20) NULL,
    [Email]       VARCHAR (50) NOT NULL,
    [Address]     VARCHAR (50) NOT NULL,
    [Gender]      VARCHAR (10) NULL,
    [PhoneNumber] VARCHAR (20) NOT NULL,
    [Role]        VARCHAR (15) NOT NULL,
    [Password]    VARCHAR (50) NOT NULL,
    [Nationality] VARCHAR (50) NULL,
    [Lawyer_ID] VARCHAR(50) NOT NULL, 
    PRIMARY KEY CLUSTERED ([ID] ASC),
	CONSTRAINT UC_Lawyer_ID UNIQUE ([Lawyer_ID])
);

