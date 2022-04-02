using System;

namespace OOP.AbstractClassAndMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 3, 2, 1, 4, 5 };
            var minHeap = new MinHeap();
            var maxHeap = new MaxHeap();

            foreach (var item in arr)
            {
                minHeap.Insert(item);
                maxHeap.Insert(item);
            }

            Console.WriteLine(minHeap.Extract());
            Console.WriteLine(maxHeap.Extract());
            
        }
    }
}
