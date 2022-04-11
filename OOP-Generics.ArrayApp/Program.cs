using System;
using System.Collections;
using System.Collections.Generic;

namespace OOP_Generics.ArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = new Array<Book>(
                new Book(1, "Suç ve Ceza", 30),
                new Book(1, "Sefiller", 40),
                new Book(1, "Devlet", 50)
                );

            var arr2 = new Array<Company>(
                new Company(1,"Aselsan","Türkiye"),
                new Company(2,"Trendyol","Türkiye"),
                new Company(3,"Sahibinden","Türkiye")
                );

            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-',30));

            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }

        }

        private static void GenericAndStruct()
        {
            var stack = new Stack<Company>();
            stack.Push(new Company(1, "Aselsan", "Türkiye"));

            Console.WriteLine(stack.Peek());
        }

        private static void GenericCollection()
        {
            var arr = new Array<char>('a', 'b', 'c');

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            var arrayList = new List<int>();
            arrayList.Add(3);
            arrayList.Add('a');

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine((int)arrayList[1] * 10);
        }

        private static void GenericAndCustomType()
        {
            var list = new LinkedList<Book>();
            list.AddFirst(new Book(1, "Sefiller", 30));
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
