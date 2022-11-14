// See https://aka.ms/new-console-template for more information
using DatabaseOpgave;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.Data;
using Microsoft.Data.SqlClient;
using System;


ColorPalette cp = new ColorPalette();


//DBClient.Reset();


DBClient.UpdateFacility("ComputerWroom", "HY", 5);
cp.Color(ConsoleColor.Green);
Console.WriteLine("Kalder 'GetFacility' metoden for at se faciliteter i databasen:");
Console.ResetColor();
DBClient.GetFacility();
cp.Color(ConsoleColor.Green);
Console.WriteLine("Kalder metoden 'AddFacility' og tilføjer en 'Trampolinpark' til 'Facility' table");
Console.ResetColor();
DBClient.AddFacility(6, "Trampolinpark", "SP");
DBClient.GetFacility();
cp.Color(ConsoleColor.Green);
Console.WriteLine("Kalder metoden 'DeleteFacility' og fjerner igen 'Trampolinpark'");
Console.ResetColor();
DBClient.DeleteFacility("Facility", "Fac_No", 6);
DBClient.GetFacility();
cp.Color(ConsoleColor.Green);
Console.WriteLine("Hov, der skulle stå 'ComputerRoom', og ikke 'ComputerWroom'. Kalder 'UpdateFacility' metoden og opdaterer navnet");
DBClient.UpdateFacility("ComputerRoom", "HY", 5);
Console.ResetColor();
DBClient.GetFacility();
cp.Color(ConsoleColor.Green);
Console.WriteLine("Det var CRUD på Facility. Lad os nu køre noget CRUD på samlingstabellen 'Facility_Hotel'");
Console.WriteLine("Kalder på 'GetHotelWithFacility' metoden for at se hvilke faciliteter hotellet 'Discount' indeholder");
Console.ResetColor();
DBClient.GetHotelWithFacility(5);
cp.Color(ConsoleColor.Green);
Console.WriteLine("Kalder metoden 'AddFacilityToHotel' metoden og tilføjer en pool til hotellet 'Inexpensive'");
Console.ResetColor();
DBClient.AddFacilityToHotel(4, 5);
DBClient.GetHotelWithFacility(5);
cp.Color(ConsoleColor.Green);
Console.WriteLine("Kalder metoden 'DeleteFacilityHotel' for at fjerne poolen igen");
Console.ResetColor();
DBClient.DeleteFacilityHotel(5, 4);
DBClient.GetHotelWithFacility(5);
cp.Color(ConsoleColor.Green);
Console.WriteLine("Så vi kalder metoden 'UpdateFacilityHotel' og opdaterer samletabellen så der nu er et computer rum i stedet for et fitness center");
Console.ResetColor();
DBClient.UpdateFacilityHotel(3, 5, 5);
DBClient.GetHotelWithFacility(5);
DBClient.UpdateFacilityHotel(5, 3, 5);
