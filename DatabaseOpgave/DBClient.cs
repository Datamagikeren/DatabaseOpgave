using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOpgave
{
    public class DBClient
    {
        ColorPalette cp = new ColorPalette();
        public static void Reset()
        {
            string sqlConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DatabaseOpgaveHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            FileInfo file = new FileInfo("C:\\Users\\lasse\\Dropbox\\Datamatik\\Software Design\\Obligatorisk DB opgave\\DatabaseOpgave\\SQLQuery2.sql");

            string script = file.OpenText().ReadToEnd();

            SqlConnection conn = new SqlConnection(sqlConnectionString);

            Server server = new Server(new ServerConnection(conn));

            server.ConnectionContext.ExecuteNonQuery(script);
        }
        public static void GetFacility()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DatabaseOpgaveHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "select * from Facility";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Console.WriteLine($"ID - Type - Name");
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string type = reader.GetString(1);
                    string name = reader.GetString(2);
                    Console.WriteLine($"{id}  - {type}   - {name}");

                }
            }
        }
        public static void GetHotel()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DatabaseOpgaveHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "select * from Hotel";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Console.WriteLine($"ID - Name");
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string type = reader.GetString(1);
                    Console.WriteLine($"{id}  - {type}");

                }
            }
        }
        public static void GetFacilityHotel()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DatabaseOpgaveHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "select * from Facility_Hotel";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Console.WriteLine($"ID - Name");
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    int id2 = reader.GetInt32(1);
                    Console.WriteLine($"{id}  - {id2}");

                }
            }
        }
        public static int AddFacility(int facNo, string facName, string facType)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DatabaseOpgaveHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string queryString = "INSERT INTO Facility VALUES(@Fac_No, @Type, @Name)";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@Fac_No", facNo);
                command.Parameters.AddWithValue("@Type", facType);
                command.Parameters.AddWithValue("@Name", facName);
                command.Connection.Open();
                int i = command.ExecuteNonQuery();
                command.Connection.Close();
                return i;

            }
        }
        public static int UpdateFacility(string facName, string facType, int facNo)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DatabaseOpgaveHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string queryString = "UPDATE Facility SET Name = @Name, Type = @Type WHERE Fac_No = @Fac_No";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@Type", facType);
                command.Parameters.AddWithValue("@Name", facName);
                command.Parameters.AddWithValue("@Fac_No", facNo);
                command.Connection.Open();
                int i = command.ExecuteNonQuery();
                command.Connection.Close();
                return i;

            }
        }
        public static void DeleteFacility(string table, string columnName, int IDNumber)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DatabaseOpgaveHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM " + table + " WHERE " + columnName + " = '" + IDNumber + "'", con))
                {
                    command.ExecuteNonQuery();
                }
                con.Close();
            }

            //catch (SystemException ex)
            //{
            //    Console.WriteLine("Error");
            //}
        }
     
    }
}
