using OOP.GenericRepositoryDesignPattern.Entities.Abstract;

namespace OOP.GenericRepositoryDesignPattern.Entities.Concrete

{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }
    }
}
