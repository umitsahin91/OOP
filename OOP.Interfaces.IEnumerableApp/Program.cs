using System;

namespace OOP.Interfaces.IEnumerableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var CustomArr = new Array(1,2,3,5,6);
            //var arr = new int[] { 1, 3, 5, 7 };

            ////predefined
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(new string('-',25));
            foreach (var item in CustomArr)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
