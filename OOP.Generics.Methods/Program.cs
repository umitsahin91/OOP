using System;

namespace OOP.Generics.Methods
{
    class Program
    {
        static public void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            int a = 2, b = 3;
            Console.WriteLine($"a={a} b={b}");
            Swap<int>(ref a, ref b);
            Console.WriteLine($"a={a} b={b}");

            Console.WriteLine(new string('-',15));

            char c1 = 'A', c2 = 'B';
            Console.WriteLine($"c1={c1} c2={c2}"); 
            Swap<char>(ref c1, ref c2);
            Console.WriteLine($"c1={c1} c2={c2}");

            Console.WriteLine(new string('-', 15));

            string n1 = "Ahmet", n2 = "Mehmet";
            Console.WriteLine($"n1={n1} n2={n2}");
            Swap<string>(ref n1, ref n2);
            Console.WriteLine($"n1={n1} n2={n2}");
        }
    }
}
