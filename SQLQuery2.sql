DBCC CHECKIDENT ('[Facility]', RESEED, 5);
GO
UPDATE Facility
SET Name = 'ComputerRwogom', Type= 'HO'
WHERE Fac_No = 5;