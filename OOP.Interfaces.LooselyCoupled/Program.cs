using System;

namespace OOP.Interfaces.LooselyCoupled
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(new LinkedListStack());

            stack.Pop();
            stack.Push(5);
        }
    }
}
