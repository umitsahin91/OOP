using System.Collections;
using System.Collections.Generic;

namespace OOP.Interfaces.GetEnumerate_App
{
    public class Product : IEnumerable
    {
        private List<Product> _list;
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public Product()
        {
            _list = new List<Product>();
        }
        public IEnumerator GetEnumerator()
        {
            foreach (var item in _list)
            {
                yield return item;
            }
        }

        public void Add(Product product)
        {
            _list.Add(product);
        }
        public override string ToString()
        {
            return $"{ProductID} {ProductName} {Price}";
        }
    }
}
