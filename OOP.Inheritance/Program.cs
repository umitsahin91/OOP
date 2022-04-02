using System;
using System.Collections.Generic;

namespace OOP.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>()
            {
                new Rectangle(),
                new Triangle(),
                new Circle()
            };

            foreach (var shape in shapes)
            {
                shape.Draw();
            }
            

        }

        private static void VirtualKeyword()
        {
            var _s1 = new Rectangle();
            var _s2 = new Circle();

            _s1.X = 10;
            _s1.Y = 100;
            Console.WriteLine("{0},{1}", _s1.X, _s1.Y);
            _s1.Draw();

            _s2.X = 5;
            _s2.Y = 55;
            Console.WriteLine("{0},{1}", _s2.X, _s2.Y);
            _s2.Draw();

            new Triangle().Draw();
        }
    }
}
