using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Triangle : Shape
    {
        public Triangle()
        {

        }
        public Triangle(int x, int y):base(x,y)
        {

        }
        public override void Draw()
        {
            Console.WriteLine("Triangle drawing task...");
            base.Draw();
        }
    }
}
