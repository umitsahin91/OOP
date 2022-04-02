using System.Collections.Generic;

namespace OOP.AddAClass
{
    class Employee
    {
        private string _firstName;
        private string _lastName;
        private List<Employee> _list;

        public string FirstName
        {
            set
            {
                _firstName = value;
            }
            get
            {
                return _firstName;
            }
        }

        public string LastName
        {
            //Expression-bodied propperty accessors
            get => _lastName;
            set => _lastName = value;
        }

        //Auto-implemented propperty
        public int Age { get; set; }

        //Constructor
        public Employee()
        {
            _list = new List<Employee>(); 
        }

        //Overloading
        public Employee(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string ToString()
        {
            return $"{FirstName,-20} {LastName,-15} {Age,5}";
        }

        public void Add(Employee employee)
        {
            _list.Add(employee);
        }

        public void AddRAnge(params Employee[] employees)
        {
            _list.AddRange(employees);
        }
    }
}
