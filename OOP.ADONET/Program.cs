using System;
using System.Collections.Generic;
using System.Data;
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
            //Update();

            //(D)elete
            //Delete();

        }

        private static void Delete()
        {
            Employee employee = new Employee() { EmployeeId = 1011 };

            //Command
            var cmd = new SqlCommand("DELETE FROM Employees WHERE EmployeeID=@EmployeeId");
            cmd.Parameters.AddWithValue("EmployeeID", employee.EmployeeId);

            var s = RDMS.SqlNonQuery(cmd);
            Console.WriteLine(s);

        }

        private static void Update()
        {
            Employee employee = new Employee() { EmployeeId = 1012, FirstName = "Mehmet", LastName = "Demir" };

            //Command
            var cmd = new SqlCommand("UPDATE Employees SET FirstName=@FirstName, LastName=@LastName WHERE EmployeeID=@EmployeeId");

            cmd.Parameters.AddWithValue("EmployeeID", employee.EmployeeId);
            cmd.Parameters.AddWithValue("FirstName", employee.FirstName);
            cmd.Parameters.AddWithValue("LastName", employee.LastName);

            var s = RDMS.SqlNonQuery(cmd);
            Console.WriteLine(s);




        }

        private static void Read()
        {
            var _list = new List<Employee>();
            var cmd = new SqlCommand("SELECT EmployeeID, FirstName, LastName FROM Employees");
            var ds = RDMS.SqlReader(cmd);

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                _list.Add(
                    new Employee
                    {
                        EmployeeId = int.Parse(item[0].ToString()),
                        FirstName = item[1].ToString(),
                        LastName = item[2].ToString()
                    }
                    );
            }

            _list.ForEach(e => Console.WriteLine(e));
        }

        private static void Create()
        {
            Employee employee = new Employee() { FirstName = "Mustafa", LastName = "Çakır" };

            //Command
            var cmd = new SqlCommand("INSERT INTO Employees(FirstName, LastName) VALUES(@FirstName,@LastName)");
            cmd.Parameters.AddWithValue("FirstName", employee.FirstName);
            cmd.Parameters.AddWithValue("LastName", employee.LastName);
            var s = RDMS.SqlNonQuery(cmd);
            Console.WriteLine(s);
        }
    }
}
