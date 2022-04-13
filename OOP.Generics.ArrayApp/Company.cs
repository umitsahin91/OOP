namespace OOP_Generics.ArrayApp
{
    public struct Company
    {
        public Company(int id, string name, string country)
        {
            Id = id;
            Name = name;
            Country = country;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public override string ToString()
        {
            return $"{Id,-5} {Name,-20} {Country,-15}";
        }
    }
}
