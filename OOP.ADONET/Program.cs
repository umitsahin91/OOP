using OOP.ADONET.DAL.Concrete;
using OOP.ADONET.Entities;
using System;
using System.Collections.Generic;


namespace OOP.ADONET
{
    class Program
    {
        static void Main(string[] args)
        {
            var _employeeDai = new EmployeeDal();
            var _list = _employeeDai.GetAll();
            foreach (var employee in _list)
            {
                Console.WriteLine(employee);
            }
        }

        private static void Delete()
        {
            Employee employee = new Employee() { EmployeeId = 1012 };
            new EmployeeDal().Delete(employee);
        }

        private static void Update()
        {
            Employee employee = new Employee() { EmployeeId = 1014, FirstName = "Mehmet", LastName = "Demir" };
            new EmployeeDal().Update(employee);
        }

        private static void Read()
        {
            new EmployeeDal()
                .GetAll()
                .ForEach(e => Console.WriteLine(e));       
        }

        private static void Create()
        {
            Employee employee = new Employee() { FirstName = "Enes", LastName = "Güzel" };
            new EmployeeDal().Add(employee);
        }
    }
}
