using System;
using System.Collections.Generic;

namespace OOP.AddAClass
{
    class Program
    {
        static void Main(string[] args)
        {

            var employee = new Employee();
            employee.Add(new Employee("Ümit", "Şahin", 30));
            employee.AddRAnge(
                    new Employee("Mevlüt", "Ateş", 35),
                    new Employee("Adil", "Deniz", 35),
                    new Employee("Enes", "Güzel", 35),
                    new Employee("Mustafa", "Çakır", 35),
                    new Employee("Onur", "Coşkun", 35)
                             );





        }
    }
}
