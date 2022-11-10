CREATE TABLE [Facility] (
  [Fac_No] int NOT NULL,
  [Type] varchar (2), CONSTRAINT checkType1 CHECK (Type IN ('SP','HY','HO') OR Type IS NULL),
  [Name] varchar (30) NOT NULL,
  PRIMARY KEY ([Fac_No])
);

