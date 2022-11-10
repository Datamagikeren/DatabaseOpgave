CREATE TABLE [Facility-Hotel] 
(
  [Fac_No] Int,
  [Hotel_No] Int,
  PRIMARY KEY ([Fac_No], [Hotel_No]),
  FOREIGN KEY ([Fac_No]) REFERENCES Facility([Fac_No]),
  FOREIGN KEY ([Hotel_No]) REFERENCES Hotel([Hotel_No])
);

