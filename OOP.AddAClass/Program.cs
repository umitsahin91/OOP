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
            //Console.WriteLine(employee.FirstName);
            //Console.WriteLine(employee.LastName);
            //Console.WriteLine(employee.Age);
            Console.WriteLine(employee);

            Console.WriteLine("------------");

            Employee employee2 = new Employee("Mevlüt", "Ateş", 35);
            //Console.WriteLine(
            //    $"{employee2.FirstName} " 
            //    +$"{employee2.LastName} " 
            //    +$"{employee2.Age}");
            Console.WriteLine(employee2);

            Employee employee3 = new Employee("Adil","Deniz",35);

            Console.WriteLine(employee3);
        }
    }
}
