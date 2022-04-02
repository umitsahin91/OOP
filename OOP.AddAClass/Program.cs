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
            employee.Age = 30;
            Console.WriteLine(employee.Age);
            Console.WriteLine(employee.FirstName);
            Console.WriteLine(employee.LastName);

        }
    }
}
