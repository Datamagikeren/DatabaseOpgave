// See https://aka.ms/new-console-template for more information
using DatabaseOpgave;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.Data;
using Microsoft.Data.SqlClient;


ColorPalette cp = new ColorPalette();


//DBClient.Reset();
DBClient.UpdateFacility("ComputerWroom", "HY", 5);
cp.Color(ConsoleColor.Green);
Console.WriteLine("Kalder på 'GetFacility' metoden for at se faciliteter i databasen:");
Console.ResetColor();
DBClient.GetFacility();
cp.Color(ConsoleColor.Green);
Console.WriteLine("Tilføjer en 'Trampolinpark' til 'Facility' table");
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
Console.ReadKey();

