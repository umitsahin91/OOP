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
            Console.WriteLine(employee.FirstName);
            Console.WriteLine(employee.LastName);
            Console.WriteLine(employee.Age);

            Console.WriteLine("------------");

            Employee employee2 = new Employee("Mevlüt0", "Ateş", 35);
            Console.WriteLine(employee2.FirstName);
            Console.WriteLine(employee2.LastName);
            Console.WriteLine(employee2.Age);

        }
    }
}
