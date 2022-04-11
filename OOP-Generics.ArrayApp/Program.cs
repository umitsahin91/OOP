using System;

namespace OOP_Generics.ArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new Array<char>('a', 'b', 'c');

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
