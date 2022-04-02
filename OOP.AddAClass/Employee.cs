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
    }
}
