namespace OOP.AddAClass
{
    class Employee
    {
        private string _firstName;
        private string _lastName;

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
            System.Console.WriteLine("Yapılandırıcı metot....");
        }

        //Overloading
        public Employee(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

       

    }
}
