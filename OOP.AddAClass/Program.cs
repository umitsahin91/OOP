using System;
using System.Collections.Generic;

namespace OOP.AddAClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Employee>()
            {
                new Employee(){FirstName = "Ümit",LastName = "Şahin",Age = 30 },
                new Employee("Mevlüt", "Ateş", 35),
                new Employee("Adil","Deniz",35)
            };
            
           
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

         
        }
    }
}
