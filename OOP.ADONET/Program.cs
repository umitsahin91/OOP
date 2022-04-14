using System;
using System.Data.SqlClient;

namespace OOP.ADONET
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Ümit", LastName = "Şahin" };


            //ADONET

            //(C)reate

            //Connection

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (var conn = new SqlConnection(connectionString))
            {
                try
                {

                    conn.Open();
                    var cmd = new SqlCommand("INSERT INTO Employees(FirstName, LastName) VALUES(@FirstName,@LastName)");
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("FirstName", employee.FirstName);
                    cmd.Parameters.AddWithValue("LastName", employee.LastName);

                    var s = cmd.ExecuteNonQuery();

                    Console.WriteLine(s);
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
              
            }
           
            //conn.ConnectionString = connectionString;
            

            //Command

           

            //(R)ead
            //(U)pdate
            //(D)elete



        }
    }
}
