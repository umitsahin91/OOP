using System;
using System.Data.SqlClient;

namespace OOP.ADONET
{
    class Program
    {
        static void Main(string[] args)
        {


            //ADONET

            //(C)reate

            //Connection

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            var conn = new SqlConnection(connectionString);
            //conn.ConnectionString = connectionString;
            conn.Open();

            //Command

            var cmd = new SqlCommand("INSERT INTO Employees(FirstName, LastName) VALUES(@FirstName,@LastName)");
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("FirstName", "Zafer");
            cmd.Parameters.AddWithValue("LastName", "Cömert");

            var s = cmd.ExecuteNonQuery();
            Console.WriteLine(s);

            //(R)ead
            //(U)pdate
            //(D)elete



        }
    }
}
