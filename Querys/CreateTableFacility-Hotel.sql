CREATE TABLE [dbo].[Facility_Hotel] (
    [Fac_No]   INT NOT NULL,
    [Hotel_No] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Fac_No] ASC, [Hotel_No] ASC),
    FOREIGN KEY ([Hotel_No]) REFERENCES [dbo].[Hotel] ([Hotel_No])
);
