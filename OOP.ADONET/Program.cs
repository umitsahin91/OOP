using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace OOP.ADONET
{
    class Program
    {
        static void Main(string[] args)
        {
            //ADONET

            //(C)reate
            //Create();

            //(R)ead
            //Read();
            //(U)pdate
            Employee employee = new Employee() {EmployeeId=12, FirstName = "Mehmet", LastName = "Demir" };
            //Connection
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (var conn = new SqlConnection(connectionString))
            {
                //conn.ConnectionString = connectionString;
                try
                {

                    conn.Open();
                    //Command
                    var cmd = new SqlCommand("UPDATE Employees SET FirstName=@FirstName, LastName=@LastName WHERE EmployeeID=@EmployeeId");
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("EmployeeID", employee.EmployeeId);
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
            //(D)elete



        }

        private static void Read()
        {
            var _list = new List<Employee>();
            //Connection
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            var conn = new SqlConnection(connectionString);
            conn.Open();

            //Command
            var cmd = new SqlCommand("SELECT EmployeeID, FirstName, LastName FROM Employees", conn);

            //Reader
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                _list.Add(new Employee
                {
                    EmployeeId = int.Parse(reader[0].ToString()),
                    FirstName = reader[1].ToString(),
                    LastName = reader[2].ToString()
                });
            }

            _list.ForEach(e => Console.WriteLine(e));
        }

        private static void Create()
        {
            //Connection

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            Employee employee = new Employee() { FirstName = "Mustafa", LastName = "Çakır" };
            using (var conn = new SqlConnection(connectionString))
            {
                //conn.ConnectionString = connectionString;
                try
                {

                    conn.Open();
                    //Command
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
        }
    }
}
