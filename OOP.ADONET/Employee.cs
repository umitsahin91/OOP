namespace OOP.ADONET
{
    public  class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{EmployeeId,-5} {FirstName,-15} {LastName,-15}";
        }
    }
}
