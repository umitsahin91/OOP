namespace OOP.Interfaces.IComparableApp
{
    public class Employee: System.IComparable
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Salary { get; set; }

        public int CompareTo(object obj)
        {
            var other = (Employee)obj;
            if (this.Salary < other.Salary)
            {
                return -1;
            }
            else if (this.Salary.Equals(other.Salary))
            {
                return 0;
            }
            else
            {
                return 1;
            }
            
        }

        public override string ToString()
        {
            return $"{Id,-2}| {FullName,-20} |{Salary,10}";
        }
    }
}
