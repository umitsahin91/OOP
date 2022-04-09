using System;
using System.Collections.Generic;

namespace OOP.Interfaces.IFormattables
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Employee>()
            {
            new Employee()
            {
                Id = 1,
                Title = "Prof. Dr.",
                FirstName = "Ahmet",
                LastName = "Dağ"
            },
            new Employee()
            {
                Id = 2,
                Title = "Prof. Dr.",
                FirstName = "Filiz",
                LastName = "Çay"
            },
            new Employee()
            {
                Id = 3,
                Title = "Doç. Dr.",
                FirstName = "Merve",
                LastName = "Canan"
            },
             new Employee()
            {
                Id = 4,
                Title = "Dr. Öğr. Üyesi",
                FirstName = "Nurettin",
                LastName = "Han"
            }
        };

            foreach (var employee in list)
            {
                Console.WriteLine(employee.ToString());
                //Console.WriteLine(employee.ToString("LF"));
                //Console.WriteLine(employee.ToString("FL"));
                //Console.WriteLine(employee.ToString("S"));
            }
        }
    }
}
