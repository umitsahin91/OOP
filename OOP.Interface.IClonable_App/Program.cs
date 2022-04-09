using System;

namespace OOP.Interface.IClonable_App
{
    class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Book()
            {
                Id = 1,
                Title = "Suç ve Ceza",
                Price = 25.5
                
            };

            //var book2 = book1;
            //book2.Title = "Sefiller";
            //Console.WriteLine($"{book1.Id} {book1.Title} {book1.Price}");
            //Console.WriteLine($"{book2.Id} {book2.Title} {book2.Price}");

            var book3 = (Book)book1.Clone();
            book3.Id = 2;
            book3.Title = "Sefiller";
            Console.WriteLine($"{book1.Id} {book1.Title} {book1.Price}");
            Console.WriteLine($"{book3.Id} {book3.Title} {book3.Price}");
        }
    }
}
