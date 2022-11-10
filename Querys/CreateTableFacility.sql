CREATE TABLE [dbo].[Facility] (
    [Fac_No] INT          NOT NULL,
    [Type]   VARCHAR (2)  NOT NULL,
    [Name]   VARCHAR (30) NOT NULL,
    PRIMARY KEY CLUSTERED ([Fac_No] ASC),
    CONSTRAINT [checkType1] CHECK ([Type]='HO' OR [Type]='HY' OR [Type]='SP' OR [Type] IS NULL)
);
