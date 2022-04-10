using System;

namespace OOP.Interfaces.LooselyCoupled
{
    public class ArrayStack : IStack
    {
        public void Pop()
        {
            Console.WriteLine("Array.Pop()");
        }

        public void Push(int item)
        {
            Console.WriteLine("Array.Push()");
        }
    }
}
