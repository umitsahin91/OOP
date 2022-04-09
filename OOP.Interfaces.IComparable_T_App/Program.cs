using System;
using System.Collections.Generic;

namespace OOP.Interfaces.IComparable_T_App
{
    class Program
    {
        static void Main(string[] args)
        {
            var employess = new List<Employee>()
            {
                   new Employee()
                   {
                       Id=1,
                       FullName="Ahmet Aslan",
                       Salary=9500
                   },
                   new Employee()
                   {
                       Id=2,
                       FullName="Aslan Yıldırım",
                       Salary=3500
                   },
                   new Employee()
                   {
                       Id=3,
                       FullName="Merve Dağ",
                       Salary=12000
                   },
                   new Employee()
                   {
                       Id=4,
                       FullName="Züleyha Çan",
                       Salary=4250
                   },
                   new Employee()
                   {
                       Id=5,
                       FullName="Çakır Büyüküstün",
                       Salary=7500
                   },
                   new Employee()
                   {
                       Id=6,
                       FullName="Birol Baş",
                       Salary=13250
                   }


            };

            employess.Sort();
            
            foreach (var employee in employess)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
