using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Circle:Shape
    {
        public Circle()
        {

        }
        public Circle(int x,int y):base(x,y)
        {

        }
        public override void Draw()
        {
            Console.WriteLine("Circle drawing task...");
            //base.Draw();
        }
    }
}
