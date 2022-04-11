using System;
using System.Collections.Generic;

namespace OOP_Generics.ArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<Book>();
            list.AddFirst(new Book(1,"Sefiller",30));
            list.AddFirst(new Book(2, "Suç ve Ceza", 40));
            list.AddFirst(new Book(3, "Devlet", 50));
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        private static void GenericClassDefinition()
        {
            var arr = new Array<char>('a', 'b', 'c');

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
