using System;

namespace OOP.AddAClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Ümit";
            employee.LastName = "Şahin";
            Console.WriteLine(employee.FirstName);
            Console.WriteLine(employee.LastName);

        }
    }
}
