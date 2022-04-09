using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces.IComparable_T_App
{
    public class Employee:IComparable<Employee>
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Employee other)
        {
            //if (this.Salary < other.Salary)
            //    return -1;
            //else if (this.Salary == other.Salary)
            //    return 0;
            //else
            //    return 1;
            //return this.FullName.CompareTo(other.FullName);
            //return this.Id.CompareTo(other.Id);
            //return this.Salary.CompareTo(other.Salary);
            //Reverse Sort
            if (this.Salary < other.Salary)
                return 1;
            else if (this.Salary == other.Salary)
                return 0;
            else
                return -1;
        }

        public override string ToString()
        {
            return $"{Id,-2}| {FullName,-20} |{Salary,10}";
        }
    }
}
