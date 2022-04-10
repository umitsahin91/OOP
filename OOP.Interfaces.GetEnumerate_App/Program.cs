using System;
using System.Collections.Generic;

namespace OOP.Interfaces.GetEnumerate_App
{
    class Program
    {
        static void Main(string[] args)
        {
            var collections = new List<Product>()
            {
             new Product(){ProductID=1,ProductName="Buz Dolabı",Price=8500},
             new Product(){ProductID=2,ProductName="Ocak",Price=5800},
             new Product(){ProductID=3,ProductName="Kahve Makinesi",Price=3000},
             new Product(){ProductID=4,ProductName="Bulaşık Makinesi",Price=4000},
             new Product(){ProductID=4,ProductName="Fırın",Price=8250}
            };

            foreach (var product in collections)
            {
                Console.WriteLine($"{product.ProductID} "+$"{product.ProductName} "+$"{product.Price} ");

            }
            Console.WriteLine(new string('-',25));

            IEnumerator<Product> enumerator = collections.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine($"{enumerator.Current.ProductID} " + $"{enumerator.Current.ProductName} " + $"{enumerator.Current.Price} ");
            }
            

        }
    }
}
